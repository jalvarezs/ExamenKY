Public Class ExamProyecto

    Dim txtProyecto As TextBox
    Property codigoProyecto As String

    Dim sinAceptar As Boolean = True

    Sub New(ByRef proyecto As TextBox)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        txtProyecto = proyecto

    End Sub

    Private Sub ExamProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla("")
    End Sub

    Private Sub actualizarTabla(ByVal nombre As String)
        Dim proyectodt As DataTable

        ' Consultamos por todos los tipos de proyecto
        proyectodt = Proyecto.buscar(nombre)

        ' Mostramos tales tipos en el dataGridView correspondiente
        dgvProyecto.DataSource = proyectodt
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer

        sinAceptar = False

        If dgvProyecto.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvProyecto.CurrentRow.Index
        End If

        codigoProyecto = dgvProyecto.Item(0, row).Value.ToString()
        txtProyecto.Text = dgvProyecto.Item(1, row).Value.ToString()

        Me.Dispose()
    End Sub

    Private Sub txtNombreProyecto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProyecto.TextChanged
        actualizarTabla(txtNombreProyecto.Text)
    End Sub

    Private Sub ExamProyecto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtProyecto.Text = ""
            codigoProyecto = ""
        End If
    End Sub
End Class