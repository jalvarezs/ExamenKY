Public Class FormQuiebreStockPorOT

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub ActualizarTabla()
        Try
            Dim dtQuiebreStock As DataTable = Material.ConsultarQuiebreStockPorOrdenTrabajo(txtOrdenTrabajo.Text)

            If dtQuiebreStock IsNot Nothing Then

                For Each row As DataRow In dtQuiebreStock.Rows
                    row("Stock") = row("Ingreso") - row("Salida")
                Next

                If dtQuiebreStock.AsEnumerable.Any Then
                    dgvStockMateriales.DataSource = dtQuiebreStock
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FormConsultarStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnExamOT_Click(sender As Object, e As EventArgs) Handles btnExamOT.Click
        Try
            Dim frmExamOrdenTrabajo As New ExamInicioTrabajo(txtOrdenTrabajo, txtCodigo)
            frmExamOrdenTrabajo.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtOrdenTrabajo.Text.Equals("") Then
                MessageBox.Show("Por favor, seleccione una Orden de Trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ActualizarTabla()

        Catch ex As Exception

        End Try
    End Sub
End Class