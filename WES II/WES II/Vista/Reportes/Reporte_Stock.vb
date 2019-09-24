Public Class Reporte_Movimientos_Stock

    Private idMaterial As Integer

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Me.SP_ReporteStockTableAdapter.Fill(Me.DS_Wes_II_TestB.SP_MovimientosStock, idMaterial)
        Me.reportViewer.RefreshReport()
    End Sub


    Private Sub btnExamMaterial_Click(sender As Object, e As EventArgs) Handles btnExamMaterial.Click
        Dim form As New ExamMaterial(txtMaterial)
        form.ShowDialog()
        Dim codigo = form.getCode()
        MessageBox.Show(codigo)

        If codigo <> "" Then
            idMaterial = CInt(codigo) - 10000
        Else
            idMaterial = 0
        End If

        MessageBox.Show("en entero el id: " & idMaterial)
    End Sub

End Class