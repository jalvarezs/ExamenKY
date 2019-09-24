Public Class Reporte_Ingresos

    Private Sub Reporte_Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim añosIngresos As DataTable = _conexion.consultar("SELECT * FROM V_AniosIngresos")
        cboAños.DataSource = añosIngresos
        cboAños.ValueMember = "Años"
        cboAños.DisplayMember = "Años"

        Dim mesesIngresos As DataTable = _conexion.consultar("SELECT * FROM V_MesesIngresos")
        cboMeses.DataSource = mesesIngresos
        cboMeses.ValueMember = "Meses"
        cboMeses.DisplayMember = "Meses"
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Me.SP_ReporteIngresosTableAdapter.Fill(Me.DS_Wes_II_TestB.SP_ReporteIngresos, cboAños.SelectedValue, cboMeses.Text)
        Me.reportViewer.RefreshReport()
    End Sub

End Class