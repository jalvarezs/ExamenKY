Public Class FormOrdenCompra

    Private cargarSugerencias As Boolean

    Sub New(ByVal _cargarSugerencias As Boolean)
        InitializeComponent()

        cargarSugerencias = _cargarSugerencias
    End Sub


    Private Sub FormOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        mostrarCodigoSgte()
        btnExaminarMat.Enabled = False

        If cargarSugerencias Then
            Dim sugerencias As DataTable
            sugerencias = _conexion.consultar("select * from V_ListarSugerencias")
            For Each sugerencia As DataRow In sugerencias.Rows
                dgvMateriales.Rows.Add(sugerencia.Item(0), sugerencia.Item(1), sugerencia.Item(2), sugerencia.Item(3))
            Next
        End If
    End Sub

    Private Sub mostrarCodigoSgte()
        txtCodigo.Text = 10000 + OrdenCompra.obtenerUltimoID() + 1
    End Sub

    Dim ordenCompradt As DataTable
    Dim ultimoCodigo As Integer = -1
    Private Sub txtProveedor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProveedor.TextChanged

        If (txtProveedor.Text Is Nothing Or txtProveedor.Text.Trim().Length < 1) Then
            btnExaminarMat.Enabled = False
        Else
            btnExaminarMat.Enabled = True

        End If

    End Sub

    Private Sub actualizarTabla()
        ultimoCodigo = -1

        ' Consultamos por todos los tipos de producto
        ordenCompradt = OrdenCompra.listarPorFechas(dtpInicio.Text.ToString, dtpFin.Text.ToString)

        ' Mostramos tales tipos en el dataGridView correspondiente
        dgvOrden.DataSource = ordenCompradt
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not dgvMateriales.Rows.Count > 1 Then
            MessageBox.Show("No se ha agregado ningún material a la orden de compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If (cbotipocredito.Text.Trim = "") Then
            MessageBox.Show("Por favor, seleccione un tipo de crédito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbotipocredito.Select()
            Return
        End If


        If (cbotipocompra.Text.Trim = "") Then
            MessageBox.Show("Por favor, seleccione un tipo de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbotipocompra.Select()
            Return
        End If

        If (cboformapago.Text.Trim = "") Then
            MessageBox.Show("Por favor, seleccione una forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboformapago.Select()
            Return
        End If

        Dim project As String
        Dim oferta As String
        Dim Moneda As String



        If cboProyecto.SelectedValue = Nothing Then
            project = "-1"
        Else
            project = cboProyecto.SelectedValue.ToString
        End If

        If cboOferta.SelectedValue = Nothing Then
            oferta = "-1"
        Else
            oferta = cboOferta.SelectedValue.ToString
        End If

        If rbDolar.Checked = True Then
            Moneda = "USD"
        Else
            Moneda = "PESOS"
        End If

        _conexion.iniciarTransaccion()
        Try
            Dim rpta As String = OrdenCompra.registrarOrden(dtpFechaOrden.Text,
                                                            project,
                                                            _usuario,
                                                            ID_Proveedor,
                                                            oferta,
                                                            cbotipocompra.Text.Substring(0, 3),
                                                            cbotipocredito.Text.Substring(0, 3),
                                                            cboformapago.Text.Substring(0, 3),
                                                            Moneda)
            If rpta <> "" Then
                Throw New System.Exception(rpta)
            End If

            Dim idOrden, idMaterial As Integer
            idOrden = OrdenCompra.obtenerUltimoID()

            For Each row As DataGridViewRow In dgvMateriales.Rows
                idMaterial = CInt(row.Cells(0).Value) - 10000
                If idMaterial > 0 Then
                    rpta = OrdenCompra.registrarDetalle(CStr(idOrden), CStr(idMaterial), row.Cells(2).Value)
                    If rpta <> "" Then
                        Throw New System.Exception(rpta)
                    End If
                End If
            Next

            _conexion.hacerCommit()
            MessageBox.Show("La orden de compra se ha registrado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            mostrarCodigoSgte()
            limpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _conexion.hacerRollBack()
        End Try

    End Sub

    Private Sub limpiarCampos()
        txtProveedor.Text = ""
        txtDirproveedor.Text = String.Empty
        txtRUC.Text = String.Empty

        txtMateriales.Text = ""
        txtcantidad.Text = ""
        chkProyecto.Checked = False
        chkOferta.Enabled = False
        cboProyecto.DataSource = Nothing
        cboOferta.DataSource = Nothing

        cbotipocredito.Text = ""
        cbotipocompra.Text = ""
        cboformapago.Text = ""

        cboProyecto.Items.Clear()
        cboOferta.Items.Clear()

        dgvMateriales.Rows.Clear()

        tstotalCantidad.Text = "Cantidad Solicitada: 0"
        tstotalpreciounitario.Text = "Precio Referencial: 0"
        tstotalIGV.Text = "IGV (18%): 0"
        tsTotalgeneral.Text = "Total Referencial: 0"

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer
        Dim id As String
        Dim _estado As String

        If dgvOrden.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista de órdenes.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvOrden.CurrentRow.Index
            id = dgvOrden.Item(0, row).Value.ToString
            _estado = dgvOrden.Item(2, row).Value.ToString

        End If

        Dim form As New ModifOrdenCompra(id, _estado)
        form.ShowDialog()
        actualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvOrden.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista de órdenes.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvOrden.CurrentRow.Index
        End If

        Dim estadoOrden As String = dgvOrden.Item(2, row).Value.ToString

        If UtilConstantes.OrdenCompra.Estado.EntregadoParcialmente.Equals(estadoOrden) Then
            MessageBox.Show("No es posible cancelar una Orden de Compra en estado Entregado Parcialmente.",
                            "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea cancelar la Orden seleccionada?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim id As String = dgvOrden.Item(0, row).Value.ToString
            Dim idOrden As Integer
            Dim rpta As String
            idOrden = CInt(id) - 10000
            rpta = OrdenCompra.cancelar(idOrden)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla()
        End If
    End Sub

    Private Sub validar()
        If (txtProveedor.Text.Trim = "") Then
            errorProvider.SetError(txtProveedor, "Seleccione un proveedor.")
        Else
            errorProvider.SetError(txtProveedor, Nothing)
        End If

        If (txtMateriales.Text.Trim = "") Then
            errorProvider.SetError(txtMateriales, "Seleccione un material.")
        Else
            errorProvider.SetError(txtMateriales, Nothing)
        End If

        If (cbotipocompra.Text.Trim = "") Then
            errorProvider.SetError(cbotipocompra, "Seleccione Tipo de compra.")
        Else
            errorProvider.SetError(cbotipocompra, Nothing)
        End If

        If (cbotipocredito.Text.Trim = "") Then
            errorProvider.SetError(cbotipocredito, "Seleccione Tipo de Credito.")
        Else
            errorProvider.SetError(cbotipocredito, Nothing)
        End If

        If (cboformapago.Text.Trim = "") Then
            errorProvider.SetError(cboformapago, "Seleccione la Forma de Pago.")
        Else
            errorProvider.SetError(cboformapago, Nothing)
        End If

        Try
            Dim temporal = CInt(txtcantidad.Text.Trim)
            errorProvider.SetError(txtcantidad, Nothing)
        Catch ex As Exception
            errorProvider.SetError(txtcantidad, "Ingrese una cantidad válida.")
        End Try
    End Sub

    Private Sub Fg_SoloNumeros(ByRef Digito As String, ByRef Texto As TextBox)
        If InStr(1, "0123456789" & Chr(8), Digito) = 0 Then
            Digito = CChar("")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Dim ID_Proveedor As String
    Private Sub btnExaminarProv_Click(sender As Object, e As EventArgs) Handles btnExaminarProv.Click
        Dim frmExProv As New ExamProveedor(txtProveedor, txtRUC, txtDirproveedor)
        frmExProv.ShowDialog()
        ID_Proveedor = frmExProv.getIdProv()
    End Sub

    Private Sub chkProyecto_CheckedChanged(sender As Object, e As EventArgs) Handles chkProyecto.CheckedChanged
        If (chkProyecto.Checked) Then
            cboProyecto.Enabled = True
            Dim dt As DataTable = Proyecto.listar()
            cboProyecto.DataSource = dt
            cboProyecto.ValueMember = dt.Columns(0).ColumnName
            cboProyecto.DisplayMember = dt.Columns(1).ColumnName
        Else
            cboProyecto.Enabled = False
        End If
    End Sub

    Private Sub chkOferta_CheckedChanged(sender As Object, e As EventArgs) Handles chkOferta.CheckedChanged
        If (chkOferta.Checked) Then
            cboOferta.Enabled = True
            chkProyecto.Checked = True
        Else
            cboOferta.Enabled = False
        End If
    End Sub

    Dim codigoMaterial, precioReferencial As String

    Private Sub btnExaminarMat_Click(sender As Object, e As EventArgs) Handles btnExaminarMat.Click
        Dim frmExProd As New ExamMaterial(txtMateriales)
        frmExProd.iniProveedor(ID_Proveedor)
        frmExProd.ShowDialog()
        codigoMaterial = frmExProd.getCode()
        precioReferencial = frmExProd.getPrecio()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        validar()
        If (errorProvider.GetError(txtProveedor) = Nothing And errorProvider.GetError(txtMateriales) = Nothing And errorProvider.GetError(txtcantidad) = Nothing) Then
            agregarFila()

            txtcantidad.Text = String.Empty
        End If
    End Sub

    Private Sub agregarFila()
        Dim flag As Boolean
        flag = False

        For j As Integer = 0 To (dgvMateriales.Rows.Count - 2)
            Dim dato As String
            dato = txtMateriales.Text

            If dgvMateriales.Rows(j).Cells(1).Value.ToString = dato Then
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle

                Dim response As MsgBoxResult
                msg = "El material ya ha sido agregado, desea actualizar la cantidad indicada?"
                style = MsgBoxStyle.DefaultButton2 Or
                   MsgBoxStyle.Question Or MsgBoxStyle.YesNo
                title = "Sugerencia"
                ' Display message.
                response = MsgBox(msg, style, title)

                If response = MsgBoxResult.Yes Then
                    actualizarCantidad(j)
                End If

                flag = True
            End If

        Next

        If Not flag Then
            Dim Fila As DataGridViewRow
            Fila = dgvMateriales.Rows(0).Clone
            Fila.Cells(0).Value = codigoMaterial
            Fila.Cells(1).Value = txtMateriales.Text
            Fila.Cells(2).Value = txtcantidad.Text
            Fila.Cells(3).Value = precioReferencial
            dgvMateriales.Rows.Add(Fila)
        End If

        'Agregamos pie de pagina
        Dim cantidad As Integer = 0
        Dim precio As Double = 0

        For i As Integer = 0 To (dgvMateriales.Rows.Count - 2)
            cantidad = cantidad + Integer.Parse(dgvMateriales.Rows(i).Cells(2).Value)
            precio = precio + (Integer.Parse(dgvMateriales.Rows(i).Cells(2).Value) * Double.Parse(dgvMateriales.Rows(i).Cells(3).Value))

        Next

        tstotalCantidad.Text = "Cantidad Solicitada: " + cantidad.ToString()
        tstotalpreciounitario.Text = "Precio Referencial: " + precio.ToString()
        tstotalIGV.Text = "IGV (18%): " + (precio * 0.18).ToString()
        tsTotalgeneral.Text = "Total Referencial: " + (precio * 1.18).ToString()
    End Sub

    Private Sub sumarCantidad(ByVal j As String)
        dgvMateriales.Rows(j).Cells(2).Value = Convert.ToString(CDbl(dgvMateriales.Rows(j).Cells(2).Value.ToString) + CDbl(txtcantidad.Text))
    End Sub

    Private Sub actualizarCantidad(ByVal j As String)
        dgvMateriales.Rows(j).Cells(2).Value = CDbl(txtcantidad.Text)
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtcantidad)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            If dgvMateriales.Rows.Count > 1 Then
                Dim filaActual As Integer = dgvMateriales.CurrentCell.RowIndex
                dgvMateriales.Rows.RemoveAt(filaActual)
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar una fila con detalle para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ordenCompradt = OrdenCompra.listarPorFechas(dtpInicio.Text.ToString, dtpFin.Text.ToString)
        dgvOrden.DataSource = ordenCompradt
    End Sub

    Private Sub dgvOrden_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrden.SelectionChanged
        Dim nuevaSeleccion As Integer
        If dgvOrden.CurrentRow Is Nothing Then
            Return
        Else
            nuevaSeleccion = dgvOrden.CurrentRow.Index
        End If

        Dim id As Integer = dgvOrden.Item(0, nuevaSeleccion).Value.ToString()
        actualizarDetalles(id)
    End Sub

    Private Sub actualizarDetalles(ByVal id As String)
        Dim OrdenID As Integer
        OrdenID = CInt(id) - 10000
        If ultimoCodigo <> id Then
            Dim detallesOrden As DataTable
            detallesOrden = OrdenCompra.listarDetalles(OrdenID)
            dgvDetalles.DataSource = detallesOrden

            ultimoCodigo = id
        End If
    End Sub

    Private Sub dgvOrden_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrden.CellContentClick

    End Sub

    Private Sub FormOrdenCompra_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tctRUC_TextChanged(sender As Object, e As EventArgs) Handles txtRUC.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub
End Class