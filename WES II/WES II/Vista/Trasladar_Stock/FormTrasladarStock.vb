Public Class FormTrasladarStock

    Private IdContenedor1 As String
    Private Sub btnBuscarContenedor1_Click(sender As Object, e As EventArgs) Handles btnBuscarContenedor1.Click
        Dim frmExamContenedor As New FormExamContenedor(txtContenedor1)
        frmExamContenedor.ShowDialog()
        IdContenedor1 = frmExamContenedor.IdContenedor
        actualizarTabla(dgvContenedores1, IdContenedor1)
    End Sub

    Private IdContenedor2 As String
    Private Sub btnBuscarContenedor2_Click(sender As Object, e As EventArgs) Handles btnBuscarContenedor2.Click
        Dim frmExamContenedor As New FormExamContenedor(txtContenedor2)
        frmExamContenedor.ShowDialog()
        IdContenedor2 = frmExamContenedor.IdContenedor
        actualizarTabla(dgvContenedores2, IdContenedor2)
    End Sub

    Private Sub actualizarTabla(ByRef dgvContenedor As DataGridView, ByRef IdContenedor As String)
        Dim contenedordt As DataTable

        'Consultamos por los Tipos de almacenes
        contenedordt = Contenedor.listarDetalles(IdContenedor)

        'Mostramos tales Tipos en el dataGridView correspondiented
        dgvContenedor.DataSource = contenedordt
    End Sub

    Private Sub btnI_D_Click(sender As Object, e As EventArgs) Handles btnI_D.Click
        Dim row As Integer

        If dgvContenedores1.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvContenedores1.CurrentRow.Index
        End If

        Dim message, title, defaultValue As String
        Dim cantidad As Integer
        ' Set prompt.
        message = "Ingrese la cantidad a trasladar"
        ' Set title.
        title = "Traslado de izquierda a derecha =>"
        defaultValue = 0   ' Set default value.

        ' Display message, title, and default value.
        Try
            Dim aux As String
            aux = InputBox(message, title, defaultValue)
            If aux <> "" Then cantidad = aux
        Catch ex As Exception
            MessageBox.Show("El dato ingresado no es válido. Ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim IdMaterial As Integer = dgvContenedores1.Rows(row).Cells(1).Value

        Dim rpta As String = Contenedor.trasladarStock(CInt(IdContenedor1) - 10000, CInt(IdContenedor2) - 10000, CInt(IdMaterial) - 10000, cantidad)
        If rpta = "" Then
            MessageBox.Show("Se ha trasladado correctamente el material.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla(dgvContenedores1, IdContenedor1)
            actualizarTabla(dgvContenedores2, IdContenedor2)
        Else
            MessageBox.Show(rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnD_I_Click(sender As Object, e As EventArgs) Handles btnD_I.Click
        Dim row As Integer

        If dgvContenedores2.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvContenedores2.CurrentRow.Index
        End If

        Dim message, title, defaultValue As String
        Dim cantidad As Integer
        ' Set prompt.
        message = "Ingrese la cantidad a trasladar"
        ' Set title.
        title = "Traslado de derecha a izquierda <="
        defaultValue = 0   ' Set default value.

        ' Display message, title, and default value.
        Try
            Dim aux As String
            aux = InputBox(message, title, defaultValue)
            If aux <> "" Then cantidad = aux
        Catch ex As Exception
            MessageBox.Show("El dato ingresado no es válido. Ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim IdMaterial As Integer = dgvContenedores2.Rows(row).Cells(1).Value

        Dim rpta As String = Contenedor.trasladarStock(CInt(IdContenedor2) - 10000, CInt(IdContenedor1) - 10000, CInt(IdMaterial) - 10000, cantidad)
        If rpta = "" Then
            MessageBox.Show("Se ha trasladado correctamente el material.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla(dgvContenedores1, IdContenedor1)
            actualizarTabla(dgvContenedores2, IdContenedor2)
        Else
            MessageBox.Show(rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

End Class