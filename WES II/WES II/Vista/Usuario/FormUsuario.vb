Public Class FormUsuario
    Private dataTable As DataTable
    Private Sub FormRegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataTable = Usuario.listarPerfiles
        cboPerfil.DataSource = dataTable
        cboPerfil.ValueMember = dataTable.Columns(0).ToString
        cboPerfil.DisplayMember = dataTable.Columns(1).ToString
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()
        dataTable = Usuario.listar()
        dgvUsuarios.DataSource = dataTable
        dgvUsuarios.Columns(0).Width = 60
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        validarCampos(3)
        If (hayErrores()) Then
            MessageBox.Show("Por favor revise los errores indicados.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim rpta As String = Usuario.registrar(txtUsuario.Text.Trim, txtClave.Text.Trim, txtNombres.Text.Trim, cboPerfil.SelectedValue.ToString)
            If rpta = "" Then
                MessageBox.Show("Usuario registrado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
            Else
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function hayErrores() As Boolean
        If ErrorUsuario.GetError(txtUsuario) = Nothing And
            ErrorUsuario.GetError(txtClave) = Nothing And
            ErrorUsuario.GetError(txtConfirmar) = Nothing And
            ErrorUsuario.GetError(txtNombres) = Nothing Then

            Return False
        End If

        Return True
    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtUsuario.Text.Trim.Length < 6 And nivel >= 1 Then
            ErrorUsuario.SetError(txtUsuario, "Debe ingresar un usuario con al menos 5 caracteres.")
        ElseIf (nivel = 1) Then
            ErrorUsuario.SetError(txtUsuario, Nothing)
        End If

        If txtClave.Text.Trim.Length < 7 And nivel >= 2 Then
            ErrorUsuario.SetError(txtClave, "Debe ingresar una clave con al menos 7 caracteres.")
        ElseIf (nivel = 2) Then
            ErrorUsuario.SetError(txtClave, Nothing)
        End If

        If Not String.Equals(txtClave.Text, txtConfirmar.Text) And nivel >= 3 Then
            ErrorUsuario.SetError(txtConfirmar, "Las contraseñas no coinciden.")
        ElseIf (nivel = 3) Then
            ErrorUsuario.SetError(txtConfirmar, Nothing)
        End If

        If txtNombres.Text.Trim.Length < 4 And nivel >= 3 Then
            ErrorUsuario.SetError(txtNombres, "Debe ingresar su nombre con al menos 3 caracteres.")
        ElseIf (nivel = 3) Then
            ErrorUsuario.SetError(txtNombres, Nothing)
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer

        If dgvUsuarios.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvUsuarios.CurrentRow.Index
        End If

        Dim Id As String = dgvUsuarios.Item(0, row).Value.ToString
        Dim Usuario As String = dgvUsuarios.Item(1, row).Value.ToString
        Dim Nombres As String = dgvUsuarios.Item(2, row).Value.ToString
        Dim Perfil As String = dgvUsuarios.Item(5, row).Value.ToString

        Dim form As New ModifUsuario(Id, Usuario, Nombres, Perfil)
        form.Show()
        actualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvUsuarios.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvUsuarios.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim Id As String = dgvUsuarios.Item(0, row).Value.ToString
            Dim rpta As String = Usuario.darDeBaja(Id)
            If rpta = "" Then
                rpta = "Usuario eliminado correctamente"
            End If

            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla()
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        validarCampos(1)
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        validarCampos(2)
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged
        validarCampos(3)
    End Sub
End Class