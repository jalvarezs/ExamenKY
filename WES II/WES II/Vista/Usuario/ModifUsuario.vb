Public Class ModifUsuario
    Private Id, Usuarios, Nombres, Perfil As String
    Private dataTable As DataTable

    Sub New(ByVal _Id As String, ByVal _Usuarios As String, ByVal _Nombres As String, ByVal _Perfil As String)
        InitializeComponent()
        Id = _Id

        Usuarios = _Usuarios
        Nombres = _Nombres
        Perfil = _Perfil

        dataTable = Usuario.listarPerfiles
        cboPerfil.DataSource = dataTable
        cboPerfil.ValueMember = dataTable.Columns(0).ToString
        cboPerfil.DisplayMember = dataTable.Columns(1).ToString
    End Sub

    Private Sub FormModifRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = Usuarios
        txtNombres.Text = Nombres
        cboPerfil.SelectedIndex = cboPerfil.FindStringExact(Perfil)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Usuarios As String = txtUsuario.Text.Trim
        Dim Nombres As String = txtNombres.Text.Trim
        Dim ClaveA As String = txtClaveAntigua.Text.Trim
        Dim ClaveN1 As String = txtClaveNueva1.Text.Trim
        Dim ClaveN2 As String = txtClaveNueva2.Text.Trim

        validarCampos(3)
        If (hayErrores()) Then
            MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If ClaveN1 <> ClaveN2 Then
                ErrorUsuario.SetError(txtClaveNueva1, "Las Claves no coinciden.")
                ErrorUsuario.SetError(txtClaveNueva2, "Las Claves no coinciden.")
            Else
                Dim verificarAntigua As String = Usuario.verificarClaves(Id, ClaveA)
                If verificarAntigua = "" Then
                    Dim rpta As String = Usuario.modificar(Id, Usuarios, ClaveN1, Nombres, cboPerfil.SelectedValue.ToString)
                    If rpta = "" Then
                        MessageBox.Show("Usuario modificado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show(verificarAntigua, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub


    Private Function hayErrores() As Boolean
        If ErrorUsuario.GetError(txtClaveAntigua) = Nothing Then
            Return False
        End If
        Return True

    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtClaveAntigua.Text.Trim.Length < 7 And nivel >= 1 Then
            ErrorUsuario.SetError(txtClaveAntigua, "Debe ingresar su Clave nueva con almenos 7 caracteres.")
        ElseIf (nivel = 1) Then
            ErrorUsuario.SetError(txtClaveAntigua, Nothing)
        End If

        If txtClaveNueva1.Text.Trim.Length < 7 And nivel >= 2 Then
            ErrorUsuario.SetError(txtClaveNueva1, "Debe ingresar su Clave nueva con almenos 7 caracteres.")
        ElseIf (nivel = 2) Then
            ErrorUsuario.SetError(txtClaveNueva1, Nothing)
        End If

        If txtClaveNueva2.Text.Trim.Length < 7 And nivel >= 3 Then
            ErrorUsuario.SetError(txtClaveNueva2, "Debe ingresar su Clave nueva con almenos 7 caracteres.")
        ElseIf (nivel = 3) Then
            ErrorUsuario.SetError(txtClaveNueva2, Nothing)
        End If

    End Sub

    Private Sub txtClaveAntigua_TextChanged(sender As Object, e As EventArgs) Handles txtClaveAntigua.TextChanged
        validarCampos(1)
    End Sub

    Private Sub txtClaveNueva1_TextChanged(sender As Object, e As EventArgs) Handles txtClaveNueva1.TextChanged
        validarCampos(2)
        If txtClaveNueva1.Text = txtClaveNueva2.Text Then
            ErrorUsuario.SetError(txtClaveNueva1, "")
            ErrorUsuario.SetError(txtClaveNueva2, "")
        End If

    End Sub

    Private Sub txtClaveNueva2_TextChanged(sender As Object, e As EventArgs) Handles txtClaveNueva2.TextChanged
        validarCampos(3)
        If txtClaveNueva1.Text = txtClaveNueva2.Text Then
            ErrorUsuario.SetError(txtClaveNueva1, "")
            ErrorUsuario.SetError(txtClaveNueva2, "")
        End If
    End Sub
End Class