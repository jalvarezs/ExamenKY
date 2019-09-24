Public Class FormQuiebreStock

    Public Sub New()
        InitializeComponent()
        ActualizarTabla()
    End Sub

    Private Sub ActualizarTabla()
        Try
            Dim dtQuiebreStock As DataTable = Material.ConsultarQuiebreStock()

            If dtQuiebreStock IsNot Nothing Then


                If dtQuiebreStock.AsEnumerable.Any Then

                    For Each row As DataRow In dtQuiebreStock.Rows
                        row("Stock") = row("Ingreso") - row("Salida")

                        If (row("Stock") > row("StockSeguridad")) Then
                            row.Delete()
                        End If
                    Next

                    dtQuiebreStock.AcceptChanges()

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

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Try
            ActualizarTabla()
        Catch ex As Exception

        End Try
    End Sub
End Class