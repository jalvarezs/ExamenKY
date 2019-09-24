Public Class FormMarcas

    Private conexion As Conexion

    Private Sub FormMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()
        Dim marcas As DataTable

        ' Consultamos por todos los tipos de producto
        marcas = Marca.listar()

        ' Mostramos tales tipos en el dataGridView correspondiente
        dgvMarcas.DataSource = marcas

        ' Asignamos nombres de columnas adecuados
        With dgvMarcas
            .Columns(0).HeaderCell.Value = "Código"
            .Columns(1).HeaderCell.Value = "Nombre"
        End With
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        validar(1)
        If (hayErrores()) Then
            MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim nombre As String = txtNombre.Text

        Dim rpta As String = Marca.registrar(nombre)
        MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        actualizarTabla()


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer = dgvMarcas.CurrentRow.Index
        Dim id As String = dgvMarcas.Item(0, row).Value.ToString

        Dim nombre As String = InputBox("Ingrese nuevo nombre:", "Modificar marca", "")

        If Not nombre Is "" Then
            Marca.modificar(id, nombre)
            actualizarTabla()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvMarcas.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvMarcas.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            Return
        End If

        Dim id As String = dgvMarcas.Item(0, row).Value.ToString
        Dim rpta As String = Marca.eliminar(id)
        MessageBox.Show(rpta, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        actualizarTabla()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub validar(ByVal nivel As Integer)
        If txtNombre.Text.Trim.Length < 4 And nivel >= 1 Then
            errorMarcas.SetError(txtNombre, "Debe ingresar al menos 4 caracteres.")
        Else
            errorMarcas.SetError(txtNombre, Nothing)
        End If

        'If (txtNombre.Text.Trim.Length > 20 And nivel >= 2) Then
        '    errorMarcas.SetError(txtNombre, "Nombre demasiado extenso.")
        'Else
        '    errorMarcas.SetError(txtNombre, Nothing)
        'End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Function hayErrores() As Boolean
        If errorMarcas.GetError(txtNombre) = Nothing Then
            Return False
        End If
        Return True
    End Function


    Private Sub txtNombre_TextChanged_1(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            errorMarcas.SetError(sender, "")
        Else
            errorMarcas.SetError(sender, "Ingrese el nombre de la marca")
        End If
    End Sub
End Class