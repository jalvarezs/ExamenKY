Public Class FormRequerimientos

    Dim ultimoCodigo As Integer = -1

    Private Sub FormRequerimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarCodigoSgte()
    End Sub

    Private Sub mostrarCodigoSgte()
        txtCodigo.Text = 10000 + Requerimiento.obtenerUltimoID() + 1
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not dgvMateriales.Rows.Count > 1 Then
            MessageBox.Show("No se ha agregado ningún material al requerimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If codProyecto = "" Then
            MessageBox.Show("No se ha seleccionado ningún proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim fecha As String = dpFechaReq.Text
        Dim codOrdenCompra As String = txtCodOrdenCompra.Text

        _conexion.iniciarTransaccion()
        Try
            ' Registramos la cabecera
            Dim rpta As String = Requerimiento.registrar(codProyecto, fecha, codOrdenCompra, codAlmacen)
            If rpta <> "" Then Throw New System.Exception(rpta)

            Dim idReq, idMaterial As Integer
            idReq = Requerimiento.obtenerUltimoID()

            Requerimiento.eliminarDetalles(idReq)
            For Each row As DataGridViewRow In dgvMateriales.Rows
                idMaterial = CInt(row.Cells(0).Value) - 10000
                If idMaterial > 0 Then
                    rpta = Requerimiento.registrarDetalle(idReq, idMaterial, row.Cells(2).Value)
                    If rpta <> "" Then Throw New System.Exception(rpta)
                End If
            Next

            _conexion.hacerCommit()
            MessageBox.Show("El requerimiento se ha registrado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim param_RequiereAutorizacion As EntidadParametro = Parametro.ObtenerParametroPorCode(UtilConstantes.Parametro.PEDIDOS_REQ_AUT)

            If param_RequiereAutorizacion.Valor.Equals(UtilConstantes.Parametro.VALOR_NO) Then
                Dim aprobarReq As String = Requerimiento.aprobarReq(idReq)
                If aprobarReq <> "" Then
                    MessageBox.Show(aprobarReq, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            mostrarCodigoSgte()
            limpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _conexion.hacerRollBack()
        End Try
    End Sub

    Private Sub limpiarCampos()
        txtProyecto.Text = ""
        codProyecto = ""
        txtMateriales.Text = ""
        codMaterial = ""
        txtCantidad.Text = ""
        txtCodigo.Text = ""
        txtCodOrdenCompra.Text = ""
        txtAlmacenDestino.Text = ""
        codAlmacen = ""
        dgvMateriales.DataSource = Nothing
        dgvMateriales.Rows.Clear()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private codProyecto As String

    Private Sub btnExaminarP_Click(sender As Object, e As EventArgs) Handles btnExaminarP.Click
        Dim frmExamProyecto As New ExamProyecto(txtProyecto)
        frmExamProyecto.ShowDialog()
        codProyecto = frmExamProyecto.codigoProyecto
    End Sub

    Private codMaterial, precioRef As String

    Private Sub btnExaminarM_Click(sender As Object, e As EventArgs) Handles btnExaminarM.Click
        Dim frmExamProducto As New ExamMaterial(txtMateriales)
        frmExamProducto.ShowDialog()
        codMaterial = frmExamProducto.getCode()
        precioRef = frmExamProducto.getPrecio()
    End Sub

    Private Sub btnExaminarCOC_Click(sender As Object, e As EventArgs) Handles btnExaminarOC.Click
        Dim frmExamOrdenCompra As New ExamOrdenCompra(txtCodOrdenCompra)
        frmExamOrdenCompra.ShowDialog()
    End Sub

    Private codAlmacen As String

    Private Sub btnExaminarAD_Click(sender As Object, e As EventArgs) Handles btnExaminarAD.Click
        Dim frmExamAlmacen As New ExamAlmacen(txtAlmacenDestino)
        frmExamAlmacen.ShowDialog()
        codAlmacen = frmExamAlmacen.codigoAlmacen
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer

        If dgvRequerimiento.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvRequerimiento.CurrentRow.Index
        End If

        Dim id As String = dgvRequerimiento.Item(0, row).Value.ToString

        Dim formModificar As New ModifRequerimiento(id)
        formModificar.ShowDialog()
        actualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvRequerimiento.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvRequerimiento.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim id As String = dgvRequerimiento.Item(0, row).Value.ToString - 10000
            Dim rptaDet As String = Requerimiento.eliminarDetalles(id)
            Dim rpta As String = Requerimiento.eliminar(id)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla()
        End If
    End Sub

    Private Sub validar()
        If (txtProyecto.Text.Trim = "") Then
            errorProvider.SetError(txtProyecto, "Seleccione un proyecto.")
        Else
            errorProvider.SetError(txtProyecto, Nothing)
        End If

        If (txtMateriales.Text.Trim = "") Then
            errorProvider.SetError(txtMateriales, "Seleccione un material.")
        Else
            errorProvider.SetError(txtMateriales, Nothing)
        End If

        Try
            Dim temporal = CInt(txtCantidad.Text.Trim)
            errorProvider.SetError(txtCantidad, Nothing)
        Catch ex As Exception
            errorProvider.SetError(txtCantidad, "Ingrese una cantidad válida.")
        End Try
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click
        validar()
        If (errorProvider.GetError(txtProyecto) = Nothing And errorProvider.GetError(txtMateriales) = Nothing And errorProvider.GetError(txtCantidad) = Nothing) Then
            agregarFila()
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
                msg = "El material ya ha sido agregado, desea añadir la cantidad indicada?"
                style = MsgBoxStyle.DefaultButton2 Or _
                   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                title = "Sugerencia"
                ' Display message.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then
                    sumarCantidad(j)
                End If
                flag = True
            End If
        Next

        If Not flag Then
            Dim Fila As DataGridViewRow
            Fila = dgvMateriales.Rows(0).Clone
            Fila.Cells(0).Value = codMaterial
            Fila.Cells(1).Value = txtMateriales.Text
            Fila.Cells(2).Value = txtCantidad.Text
            Fila.Cells(3).Value = precioRef
            dgvMateriales.Rows.Add(Fila)
        End If
    End Sub

    Private Sub sumarCantidad(ByVal j As String)
        dgvMateriales.Rows(j).Cells(2).Value = Convert.ToString(CDbl(dgvMateriales.Rows(j).Cells(2).Value.ToString) + CDbl(txtCantidad.Text))
    End Sub

    Private Sub btnBorrarItem_Click(sender As Object, e As EventArgs) Handles btnBorrarItem.Click
        Try
            If dgvMateriales.Rows.Count > 1 Then
                Dim filaActual As Integer = dgvMateriales.CurrentCell.RowIndex
                dgvMateriales.Rows.RemoveAt(filaActual)
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar una fila con detalle para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtCantidad)
    End Sub

    Private Sub Fg_SoloNumeros(ByRef Digito As String, ByRef Texto As TextBox)
        If InStr(1, "0123456789" & Chr(8), Digito) = 0 Then
            Digito = CChar("")
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()
        Dim requerimientos As DataTable
        requerimientos = Requerimiento.listarReqPorFechas(dtpDesde.Text, dtpHasta.Text)
        dgvRequerimiento.DataSource = requerimientos
    End Sub

    Private Sub dgvRequerimiento_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRequerimiento.SelectionChanged
        Dim nuevaSeleccion As Integer
        If dgvRequerimiento.CurrentRow Is Nothing Then
            Return
        Else
            nuevaSeleccion = dgvRequerimiento.CurrentRow.Index
        End If

        Dim id As Integer = dgvRequerimiento.Item(0, nuevaSeleccion).Value.ToString()
        actualizarDetalles(id)
    End Sub

    Private Sub actualizarDetalles(ByVal id As String)
        Dim idReq As Integer
        idReq = CInt(id) - 10000
        If ultimoCodigo <> id Then
            Dim detallesOrden As DataTable
            detallesOrden = Requerimiento.listarDetalles(idReq)
            dgvDetalles.DataSource = detallesOrden

            ultimoCodigo = id
        End If
    End Sub

    Private Sub dgvRequerimiento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequerimiento.CellContentClick

    End Sub
End Class