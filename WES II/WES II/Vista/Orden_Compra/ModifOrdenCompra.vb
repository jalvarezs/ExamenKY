Public Class ModifOrdenCompra

    Private conexion As Conexion

    Private codOrden As String ' Recibido en el constructor
    Private idOrden As Integer ' Decodificado a ID real

    ' Datos consultados en la BD según el ID de la OC
    Private idProyecto As Integer
    Private nombreProy As String
    Private idOferta As Integer
    Private estado As String
    Private ID_Proveedor As String
    Private EstadoOrden As String


    Sub New(ByVal _codOrden As String, ByVal _estado As String)
        InitializeComponent()

        codOrden = _codOrden
        idOrden = CInt(codOrden) - 10000
        EstadoOrden = _estado

    End Sub

    Private Sub HabilitarControles(ByVal enabled As Boolean)
        btnExaminarProv.Enabled = enabled
        btnExaminarMat.Enabled = enabled
        btnAgregar.Enabled = enabled
        btnBorrar.Enabled = enabled
        btnGuardar.Enabled = enabled
        txtcantidad.Enabled = enabled
        dpFechaOrden.Enabled = enabled
        chkProyecto.Enabled = enabled
        cboProyecto.Enabled = enabled

    End Sub


    Private Sub ModifOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtCodigo.Text = codOrden

        Dim orden As New OrdenCompra()
        orden.obtener(idOrden)

        txtProveedor.Text = orden.Proveedor
        ID_Proveedor = orden.ID_Proveedor

        txtRUC.Text = orden.Ruc
        txtDirproveedor.Text = orden.DireccionProveedor

        dpFechaOrden.Value = orden.Fecha
        idProyecto = orden.ID_Proyecto
        nombreProy = orden.Proyecto
        idOferta = orden.ID_Oferta
        estado = orden.Estado

        cargarCabecera()
        cargarDetalles()

        If UtilConstantes.OrdenCompra.Estado.Cancelada.Equals(EstadoOrden) Then
            HabilitarControles(False)
            MessageBox.Show("La Orden de Compra está en estado Cancelada, no es posible editar la orden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

    End Sub

    Private Sub cargarCabecera()
        If idProyecto <> -1 Then
            chkProyecto.Checked = True
            cboProyecto.Enabled = True
            cargarProyectos()
            cboProyecto.SelectedIndex = cboProyecto.FindStringExact(nombreProy)
        End If
    End Sub

    Private Sub cargarDetalles()
        Dim detallesPrevios As DataTable
        detallesPrevios = OrdenCompra.listarDetalles(idOrden)
        For Each detalle As DataRow In detallesPrevios.Rows
            Dim codMaterial As String = detalle(0)
            Dim material As String = detalle(1)
            Dim solicitada As Integer = detalle(2)
            ' Cantidad recibida es la columna 3
            Dim precioRef As Decimal = detalle(4)
            dgvMateriales.Rows.Add(codMaterial, material, solicitada, precioRef)
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not dgvMateriales.Rows.Count > 1 Then
            MessageBox.Show("No se ha agregado ningún material a la orden de compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim project As String
        Dim codOferta As String

        If cboProyecto.SelectedValue = Nothing Then
            project = "-1"
        Else
            project = cboProyecto.SelectedValue.ToString
        End If

        If cboOferta.SelectedValue = Nothing Then
            codOferta = "-1"
        Else
            codOferta = cboOferta.SelectedValue.ToString
        End If

        _conexion.iniciarTransaccion()
        Try
            Dim rpta As String = OrdenCompra.modificarOrden(idOrden, dpFechaOrden.Text, project, ID_Proveedor, codOferta, estado)
            If rpta <> "" Then
                Throw New System.Exception(rpta)
            End If

            'Se agrega parametros para el SP_MantenedorDetalleOrdenCompra y que eliminará el registro del detalle 
            Dim idMaterial As Integer
            OrdenCompra.eliminarDetalles(idOrden, idMaterial, "0", "0", "0", "")
            '-------------------------------------------------
            For Each row As DataGridViewRow In dgvMateriales.Rows
                idMaterial = CInt(row.Cells(0).Value) - 10000

                If idMaterial > 0 Then
                    'Se cambia los parametros para la opción de modificar cantidad y precio de compra
                    'cambio realizado el 01/10/2019 --JAS
                    rpta = OrdenCompra.registrarDetalle(idOrden, CStr(idMaterial), txtcantidad.Text, txtpref.Text)
                    'rpta = OrdenCompra.registrarDetalle(idOrden, CStr(idMaterial), row.Cells(2).Value, precom)
                    If rpta <> "" Then
                        Throw New System.Exception(rpta)
                    End If
                End If
            Next
            _conexion.hacerCommit()
            MessageBox.Show("La orden de compra se ha modificado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            _conexion.hacerRollBack()
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
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


    Private Sub btnExaminarProv_Click(sender As Object, e As EventArgs) Handles btnExaminarProv.Click
        Dim frmExProv As New ExamProveedor(txtProveedor, txtRUC, txtDirproveedor)
        frmExProv.ShowDialog()
        ID_Proveedor = frmExProv.getIdProv()
    End Sub

    Private Sub cargarProyectos()
        Dim dt As DataTable = Proyecto.listar()
        cboProyecto.DataSource = dt
        cboProyecto.ValueMember = dt.Columns(0).ColumnName
        cboProyecto.DisplayMember = dt.Columns(1).ColumnName
    End Sub

    Private Sub chkProyecto_CheckedChanged(sender As Object, e As EventArgs) Handles chkProyecto.CheckedChanged
        If (chkProyecto.Checked) Then
            cboProyecto.Enabled = True
            cargarProyectos()
        Else
            cboProyecto.Enabled = False
            cboOferta.Enabled = False
        End If
    End Sub

    Private Sub chkOferta_CheckedChanged(sender As Object, e As EventArgs) Handles chkOferta.CheckedChanged
        If (chkOferta.Checked) Then
            cboOferta.Enabled = True
        Else
            cboOferta.Enabled = False
        End If
    End Sub

    Private codigoMaterial, precioReferencial As String

    Private Sub btnExaminarMat_Click(sender As Object, e As EventArgs) Handles btnExaminarMat.Click
        Dim frmExProd As New ExamMaterial(txtMateriales)
        frmExProd.ShowDialog()
        codigoMaterial = frmExProd.getCode()
        precioReferencial = frmExProd.getPrecio()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        validar()
        If (errorProvider.GetError(txtProveedor) = Nothing And errorProvider.GetError(txtMateriales) = Nothing And errorProvider.GetError(txtcantidad) = Nothing) Then
            agregarFila()
        End If
    End Sub

    Private Sub agregarFila()
        Dim flag As Boolean = False

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

    End Sub

    Private Sub sumarCantidad(ByVal j As String)
        dgvMateriales.Rows(j).Cells(2).Value = Convert.ToString(CDbl(dgvMateriales.Rows(j).Cells(2).Value.ToString) + CDbl(txtcantidad.Text))
    End Sub

    Private Sub actualizarCantidad(ByVal j As String)
        dgvMateriales.Rows(j).Cells(2).Value = CDbl(txtcantidad.Text)
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        Fg_SoloNumeros(e.KeyChar, txtcantidad)
    End Sub

    Private Sub txtDirproveedor_TextChanged(sender As Object, e As EventArgs) Handles txtDirproveedor.TextChanged

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            If dgvMateriales.Rows.Count > 1 Then
                Dim filaActual As Integer = dgvMateriales.CurrentCell.RowIndex
                dgvMateriales.Rows.RemoveAt(filaActual)
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar el detalle que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class