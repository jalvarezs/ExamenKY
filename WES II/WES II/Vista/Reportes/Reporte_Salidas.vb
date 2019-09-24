Public Class Reporte_Salidas

    Private Sub Reporte_Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim añosSalidas As DataTable = _conexion.consultar("SELECT * FROM V_AniosSalidas")
        cboAños.DataSource = añosSalidas
        cboAños.ValueMember = "Años"
        cboAños.DisplayMember = "Años"

        Dim mesesSalidas As DataTable = _conexion.consultar("SELECT * FROM V_MesesSalidas")
        cboMeses.DataSource = mesesSalidas
        cboMeses.ValueMember = "Meses"
        cboMeses.DisplayMember = "Meses"
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Me.SP_ReporteSalidasTableAdapter.Fill(Me.DS_Wes_II_TestB.SP_ReporteSalidas, cboAños.SelectedValue, cboMeses.Text)
        Me.reportViewer.RefreshReport()
    End Sub

End Class