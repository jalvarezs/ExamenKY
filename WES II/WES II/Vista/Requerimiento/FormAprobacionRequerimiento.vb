Public Class FormAprobacionRequerimiento

    Private Sub actualizarTabla()
        Dim listarReq As DataTable
        Dim fecha_inicio As String = dtpFechaInicio.Text
        Dim fecha_fin As String = dtpFechaFin.Text

        ' Consultamos los requerimientos por fechas
        listarReq = Requerimiento.listarReqPorFechas(fecha_inicio, fecha_fin)

        ' Mostramos tales requerimientos por fechas en el dataGridView correspondiente
        dgvRequerimiento.DataSource = listarReq
    End Sub

    Private Sub btnListarReq_Click(sender As Object, e As EventArgs) Handles btnListarReq.Click
        actualizarTabla()
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            Dim aprobarReq As String
            Dim row As Integer

            row = dgvRequerimiento.CurrentRow.Index

            Dim id As String = dgvRequerimiento.Item(0, row).Value.ToString()

            ' Aprobamos un requerimiento a través de un id
            aprobarReq = Requerimiento.aprobarReq(CInt(id) - 10000)
            If aprobarReq <> "" Then
                MessageBox.Show(aprobarReq)
            End If
            actualizarTabla()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnDenegar_Click(sender As Object, e As EventArgs) Handles btnDenegar.Click
        Dim denegarReq As String
        Dim row As Integer

        row = dgvRequerimiento.CurrentRow.Index

        Dim id As String = dgvRequerimiento.Item(0, row).Value.ToString()

        ' Denegar un requerimiento a través de un id
        denegarReq = Requerimiento.denegarReq(id)
        actualizarTabla()
    End Sub
End Class