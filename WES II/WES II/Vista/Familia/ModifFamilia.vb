Public Class ModifFamilia

    Private id, nombre, descripcion As String

    Sub New(ByVal _id As String, ByVal _nombre As String, ByVal _descripcion As String)
        Try
            InitializeComponent()

            id = _id
            nombre = _nombre
            descripcion = _descripcion
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ModifFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = nombre
        txtDescripcion.Text = descripcion
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim nombre As String = txtNombre.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim rpta As String = Familia.ModificarFamilia(id, nombre, descripcion)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorFamilia.SetError(sender, "")
        Else
            ErrorFamilia.SetError(sender, "El nombre es un dato es obligatorio.")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then 'El Nombre es puras letras 
            e.Handled = True
        End If
    End Sub

End Class