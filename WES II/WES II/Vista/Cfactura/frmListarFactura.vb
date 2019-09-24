Public Class frmListarFactura
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dgvCargaFacturas.DataSource = clCargarFactura.listarFactCargPorFechas(inicio.Value.ToShortDateString, fin.Value.ToShortDateString)








    End Sub

    Private Sub dgvCargaFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargaFacturas.CellDoubleClick


        Dim nroFact As String


        Dim row As Integer

        row = dgvCargaFacturas.CurrentRow.Index
        nroFact = dgvCargaFacturas.Item(0, row).Value

        If Usuario.tieneAcceso("Carga Facturas") Then
            Dim form As New frmCargaFactura






            form.nrofactura.Text = dgvCargaFacturas.Item(0, row).Value

            form.fechaemision.Value = dgvCargaFacturas.Item(1, row).Value

            form.txtcliente.Text = dgvCargaFacturas.Item(2, row).Value

            form.ruc2.Text = dgvCargaFacturas.Item(3, row).Value

            form.detalle2.Text = dgvCargaFacturas.Item(4, row).Value

            form.personal.Text = dgvCargaFacturas.Item(5, row).Value

            form.nroproforma.Text = dgvCargaFacturas.Item(6, row).Value

            form.nrooc.Text = dgvCargaFacturas.Item(7, row).Value

            form.guia_.Text = dgvCargaFacturas.Item(8, row).Value

            form.subtotal_.Text = dgvCargaFacturas.Item(9, row).Value

            form.IGV_.Text = dgvCargaFacturas.Item(10, row).Value

            form.total.Text = dgvCargaFacturas.Item(11, row).Value

            form.controlpagado.Text = dgvCargaFacturas.Item(12, row).Value

            form.cancelada_.Text = dgvCargaFacturas.Item(13, row).Value

            form.fc.Value = dgvCargaFacturas.Item(14, row).Value

            form.fpago_.Text = dgvCargaFacturas.Item(15, row).Value


            form.detret.Text = dgvCargaFacturas.Item(16, row).Value

            form.porcdet.Text = dgvCargaFacturas.Item(17, row).Value

            form.mesdet.Text = dgvCargaFacturas.Item(18, row).Value

            form.fechadet.Value = dgvCargaFacturas.Item(19, row).Value

            form.pagosdet.Text = dgvCargaFacturas.Item(20, row).Value

            ' Dim codigoCotizacion As Integer = dgvCotizaciones.Item(0, row).Value.ToString











            form.modificacion.Checked = True

            form.ShowDialog()



        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If






    End Sub

    Private Sub dgvCargaFacturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargaFacturas.CellContentClick

    End Sub

    Private Sub frmListarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class