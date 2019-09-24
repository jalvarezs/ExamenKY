Public Class ExamCliente

    Dim txtCliente As TextBox

    Dim ruc2 As TextBox

    Property idCliente As String
    Dim sinAceptar As Boolean = True

    Sub New(ByRef _txtCliente As TextBox, ByRef _ruc2 As TextBox)
        Try
            InitializeComponent()
            txtCliente = _txtCliente

            ruc2 = _ruc2


        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub ExamCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla("")
    End Sub

    Private Sub actualizarTabla(ByVal nombre As String)
        Dim clientes As DataTable
        clientes = Cliente.buscar(nombre)
        dgvClientes.DataSource = clientes
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer

        Try
            If dgvClientes.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvClientes.CurrentRow.Index
            End If

            sinAceptar = False

            idCliente = dgvClientes.Item(0, row).Value.ToString()
            txtCliente.Text = dgvClientes.Item(1, row).Value.ToString()

            ruc2.Text = dgvClientes.Item(2, row).Value.ToString()


            Me.Close()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProveedor.TextChanged
        actualizarTabla(txtNombreProveedor.Text)
    End Sub

    Private Sub ExamCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtCliente.Text = ""
            idCliente = ""
        End If
    End Sub

End Class