Public Class FormLogin

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        _usuario = Usuario.validarLogin(txtUsername.Text, txtPassword.Text)
        If _usuario = 0 Then
            MessageBox.Show("Los datos de acceso son incorrectos.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Text = ""
            Return
        End If

        Me.Hide()

        ' Se abre el form principal
        Dim f As New FormPrincipal
        f.ShowDialog()

        ' Al cerrar el principal vuelve a la ventana de login
        'txtPassword.Text = ""
        Me.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter AndAlso txtPassword.Text <> "" Then
            btnIniciar_Click(sender, e)
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class