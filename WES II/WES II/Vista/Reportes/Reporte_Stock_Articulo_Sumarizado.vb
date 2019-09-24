Public Class Reporte_Stock_Articulo_Sumarizado

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            Dim idContenedor As Integer

            If txtContenedor.Text.Trim = String.Empty Then
                idContenedor = 0
            Else
                idContenedor = UtilConvertidor.GetInteger(txtContenedor.Text.Trim) - 10000
            End If

            Me.SP_Stock_Sumarizado_ArticuloTableAdapter.Fill(Me.DS_Wes_II_TestB.SP_Stock_Sumarizado_Articulo, idContenedor)
            Me.reportViewer.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub reportViewer_Load(sender As Object, e As EventArgs) Handles reportViewer.Load

    End Sub

    Private Sub btnExaminarContenedor_Click(sender As Object, e As EventArgs) Handles btnExaminarContenedor.Click
        Try
            Dim formExamCont As New FormExamContenedor(txtContenedor)
            formExamCont.ShowDialog()

            txtContenedor.Text = formExamCont.IdContenedor
        Catch ex As Exception

        End Try
    End Sub


End Class