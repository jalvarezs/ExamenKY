Public Class CargarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nombres As String = TextBox1.Text

        Dim apellidos As String = TextBox2.Text


        Dim rpta As String = UsuariosCF.registrarUsuarioCF(nombres, apellidos)

        MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class