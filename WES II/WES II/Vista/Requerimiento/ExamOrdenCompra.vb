Public Class ExamOrdenCompra

    Dim txtCodigoOrdenCompra As TextBox

    Dim sinAceptar As Boolean = True

    Sub New(ByRef codOrdenCompra As TextBox)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        txtCodigoOrdenCompra = codOrdenCompra
    End Sub

    Private Sub ExamOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla("")
    End Sub
    Private Sub actualizarTabla(ByVal codigo As String)
        Dim ordencompradt As DataTable

        'Consultamos por todos los tipos de orden de compra
        ordencompradt = OrdenCompra.buscar(codigo)

        'Mostramos tales tipos en el dataGridView correspondiente
        dgvOrdenCompra.DataSource = ordencompradt
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer
        sinAceptar = False
        If dgvOrdenCompra.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvOrdenCompra.CurrentRow.Index
        End If
        txtCodigoOrdenCompra.Text = dgvOrdenCompra.Item(0, row).Value.ToString()
        Me.Dispose()
    End Sub

    Private Sub txtCodOrdenCompra_TextChanged(sender As Object, e As EventArgs) Handles txtCodOrdenCompra.TextChanged
        actualizarTabla(txtCodOrdenCompra.Text)
    End Sub

    Private Sub ExamOrdenCompra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtCodigoOrdenCompra.Text = ""
        End If
    End Sub

End Class