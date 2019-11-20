Public Class ModifPedido

    Private id, nomid, fecha, confirmado, observaciones, idCliente As String

    Sub New(ByVal _id As String,
            ByVal _nomid As String,
            ByVal _fecha As String,
            ByVal _confirmado As String,
            ByVal _observaciones As String,
            ByVal _idCliente As String)

        InitializeComponent()

        id = _id.Trim
        nomid = _nomid.Trim
        fecha = _fecha.Trim
        confirmado = _confirmado.Trim
        observaciones = _observaciones.Trim
        idCliente = _idCliente

    End Sub

    Private Sub ModifCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Label2.Text = Label2.Text + " " + id + " " + nomid
            txt_orderId.Text = id.Trim
            txt_idCliente.Text = idCliente

            Dim cliente As DataTable
            cliente = Pedido.buscarPorId(id)
            dgv_modpedido.DataSource = cliente
            Dim valortot As Double
            If dgv_modpedido.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgv_modpedido.Rows
                    valortot = valortot + Fila.Cells("Total").Value
                Next
                txt_valortotal.Text = valortot.ToString
            End If
            dgv_modpedido.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgv_modpedido.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_modpedido.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_modpedido.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim estado As String
            Dim fecha As String = Me.dtp_fecha.Value
            If rdb_confirma.Checked = True Then
                estado = "S"
            Else
                estado = "N"
            End If
            Dim comentario As String = txt_observa.Text
            Dim rpta As String = Pedido.modificar(id, idCliente, fecha, estado, comentario)
            MessageBox.Show("Pedido se ha confirmado", "Actuaización")
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


End Class