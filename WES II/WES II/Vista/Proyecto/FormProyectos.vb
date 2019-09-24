Public Class FormProyectos
    Dim tablaId As New DataTable
    Dim parteCodigo As String
    Private Sub FormProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla()
        tablaId = Proyecto.obtenerSgteID()
        formatoCodigo(tablaId.Rows(0)(0).ToString)
        txtCodigo.Text = "PROY" & parteCodigo
    End Sub

    Private Sub formatoCodigo(ByVal numero As String)
        If numero.Length < 2 Then
            parteCodigo = "000" + numero
        ElseIf numero.Length < 3 Then
            parteCodigo = "00" + numero
        ElseIf numero.Length < 4 Then
            parteCodigo = "0" + numero
        Else
            parteCodigo = numero
        End If
    End Sub

    Private Sub actualizarTabla()
        Dim proyectos As New DataTable

        ' Consultamos por todos los almacenes
        proyectos = Proyecto.listar()

        ' Mostramos los almacenes en el dataGridView correspondiente
        dgvProyectos.DataSource = proyectos

        With dgvProyectos
            .Columns(0).Width = 50
            .Columns(1).Width = 100
            .Columns(2).Width = 70
            .Columns(3).Width = 70
            .Columns(4).Width = 100
            .Columns(5).Width = 70
            .Columns(6).Width = 70
        End With
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Nombre As String = txtNombre.Text.Trim
        Dim FechaInicio As String = dtpInicio.Text
        Dim FechaFin As String = dtpFin.Text
        Dim Descripcion As String = txtDescripcion.Text.Trim

        validarCampos(1)
        If (hayErrores()) Then
            MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim rpta As String = Proyecto.registrar(Nombre, FechaInicio, FechaFin, Descripcion)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        actualizarTabla()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer

        If dgvProyectos.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvProyectos.CurrentRow.Index
        End If

        Dim IdProyecto As String = dgvProyectos.Item(0, row).Value.ToString
        Dim Nombre As String = dgvProyectos.Item(1, row).Value.ToString
        Dim FechaInicio As String = dgvProyectos.Item(2, row).Value.ToString
        Dim FechaFin As String = dgvProyectos.Item(3, row).Value.ToString
        Dim Descripcion As String = dgvProyectos.Item(4, row).Value.ToString

        Dim formModificar As New ModifProyecto(IdProyecto, Nombre, FechaInicio, FechaFin, Descripcion)
        formModificar.ShowDialog()
        actualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvProyectos.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvProyectos.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim IdProyecto As String = dgvProyectos.Item(0, row).Value.ToString
            Dim rpta As String = Proyecto.eliminar(IdProyecto)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla()
        End If
    End Sub

    Private Function hayErrores() As Boolean
        If ErrorProyecto.GetError(txtNombre) = Nothing Then
            Return False
        End If

        Return True
    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtNombre.Text.Trim.Length < 4 And nivel >= 1 Then
            ErrorProyecto.SetError(txtNombre, "Debe ingresar almenos 4 caracteres.")
        ElseIf (nivel = 1) Then
            ErrorProyecto.SetError(txtNombre, Nothing)
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        validarCampos(1)
    End Sub

End Class