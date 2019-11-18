Public Class FormAprobacionRequerimiento

    Private Sub actualizarTabla()
        Dim listarReq As DataTable
        Dim listarOc As DataTable
        Dim fecha_inicio As String = dtpFechaInicio.Text
        Dim fecha_fin As String = dtpFechaFin.Text

        ' Consultamos los requerimientos por fechas

        'Se incluyen radio buttons, que listará segun la opcion que se escoja Ord.compra o Requerimientos
        'Se agrega también listarOc que mostrará las ordenes de compra segun fechas.JAS 02/10/19
        If rdb_ordcomp.Checked Then
            listarOc = OrdenCompra.listarPorFechas(fecha_inicio, fecha_fin)
            dgvRequerimiento.DataSource = listarOc
        Else
            If rdb_req.Checked Then
                listarReq = Requerimiento.listarReqPorFechas(fecha_inicio, fecha_fin)
                ' Mostramos tales requerimientos por fechas en el dataGridView correspondiente
                dgvRequerimiento.DataSource = listarReq
            Else
                MessageBox.Show("Debe escoger una de las 2 opciones Listar OC o Req.")

            End If
        End If
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

            If rdb_req.Checked Then
                ' Aprobamos un requerimiento a través de un id
                aprobarReq = Requerimiento.aprobarReq(CInt(id) - 10000)
                If aprobarReq <> "" Then
                    MessageBox.Show(aprobarReq)
                End If
            End If

            ' Agregamos radio buttons para aprobar la orden de compra
            If rdb_ordcomp.Checked Then
                ' Aprobamos una Orden de Compra a través de un id
                'OrdenCompra.listarPorFechas(fecha_inicio, fecha_fin)
                aprobarReq = OrdenCompra.aprobar(CInt(id) - 10000, "Aprobado")
                If aprobarReq <> "" Then
                    MessageBox.Show(aprobarReq)
                End If
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

        If rdb_req.Checked Then
            ' Denegar un requerimiento a través de un id
            denegarReq = Requerimiento.denegarReq(id)
        End If

        ' Agregamos radio buttons para denegar la orden de compra
        If rdb_ordcomp.Checked Then
            ' Denegamos una Orden de Compra a través de un id
            denegarReq = OrdenCompra.aprobar(CInt(id) - 10000, "Denegado")
        End If

        actualizarTabla()
    End Sub
End Class