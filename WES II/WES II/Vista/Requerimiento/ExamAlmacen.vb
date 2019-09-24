Public Class ExamAlmacen

    Dim txtAlmacenDestino As TextBox
    Property codigoAlmacen As String

    Dim sinAceptar As Boolean = True

    Sub New(ByRef Almacen As TextBox)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        txtAlmacenDestino = Almacen

    End Sub

    Private Sub ExamAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla("")
    End Sub

    Private Sub actualizarTabla(ByVal nombre As String)
        Dim almacendt As DataTable

        'Consultamos por los Tipos de almacenes
        almacendt = Almacen.buscar(nombre)

        'Mostramos tales Tipos en el dataGridView correspondiente
        dgvAlmacen.DataSource = almacendt
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer
        sinAceptar = False
        If dgvAlmacen.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvAlmacen.CurrentRow.Index
        End If

        codigoAlmacen = dgvAlmacen.Item(0, row).Value.ToString()
        txtAlmacenDestino.Text = dgvAlmacen.Item(1, row).Value.ToString()

        Me.Dispose()
    End Sub

    Private Sub txtNombreAlmacen_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAlmacen.TextChanged
        actualizarTabla(txtNombreAlmacen.Text)
    End Sub

    Private Sub ExamAlmacen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtAlmacenDestino.Text = ""
            codigoAlmacen = ""
        End If
    End Sub
End Class