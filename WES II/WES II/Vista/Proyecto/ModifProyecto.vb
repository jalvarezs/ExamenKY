Public Class ModifProyecto
    Dim tablaId As New DataTable
    Dim parteCodigo As String
    Private id, nombre, fechaInicio, fechaFin, descripcion As String
    Sub New(ByVal _id As String, ByVal _nombre As String, _fechaInicio As String, _fechaFin As String, ByVal _descripcion As String)
        InitializeComponent()

        id = _id
        nombre = _nombre
        fechaInicio = _fechaInicio
        fechaFin = _fechaFin
        descripcion = _descripcion
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

    Private Sub ModifProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatoCodigo(id)
        txtCodigo.Text = "PROY" & parteCodigo
        txtNombre.Text = nombre
        dtpInicio.Value = fechaInicio
        dtpFin.Value = fechaFin
        txtDescripcion.Text = descripcion
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text.Trim.Length > 4 Then
            Dim nombre As String = txtNombre.Text.Trim
            Dim fechaInicio As String = dtpInicio.Text
            Dim fechaFin As String = dtpFin.Text
            Dim descripcion As String = txtDescripcion.Text.Trim

            Dim rpta As String = Proyecto.modificar(id, nombre, fechaInicio, fechaFin, descripcion)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Porfavor, el nombre del almacén debe tener mínimos 4 caracteres")
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)
        If txtNombre.Text.Trim.Length < 4 Then
            ErrorProyecto.SetError(txtNombre, "No se permiten menos de 4 caracteres")
        Else
            ErrorProyecto.Dispose()
        End If
    End Sub
End Class