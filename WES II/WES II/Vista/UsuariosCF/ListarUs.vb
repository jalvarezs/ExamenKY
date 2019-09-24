Public Class ListarUs

    Dim personal As TextBox



    Dim sinAceptar As Boolean = True

    Private Sub ListarUs_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        dgvUs.DataSource = UsuariosCF.listarUS_FACT()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim row As Integer

        Try
            If dgvUs.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvUs.CurrentRow.Index
            End If

            sinAceptar = False


            personal.Text = dgvUs.Item(0, row).Value.ToString()


            Me.Close()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Sub New(ByRef _personal As TextBox)
        Try
            InitializeComponent()
            personal = _personal



        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



End Class