Public Class FormDocumentosContenedor

    Sub New()

        Try
            InitializeComponent()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub New(ByVal _idContenedor As Integer, ByVal _idMaterial As Integer)

        Try
            InitializeComponent()

            Dim dt As DataTable
            dt = Contenedor.listarDocumentosContenedor(_idContenedor, _idMaterial)
            dgvDetalle.DataSource = dt

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class