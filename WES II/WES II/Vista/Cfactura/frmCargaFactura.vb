Public Class frmCargaFactura

    Private idCliente As String
    Private idfactura As Integer
    Private Sub actualizarSgteId()
        idfactura = clCargarFactura.obtenerSgteID()
        nrofactura.Text = idfactura + 10000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each ctrl In Me.Controls
            If TypeName(ctrl) = "TextBox" Then
                If ctrl.Text = "" Then
                    Exit Sub
                End If
            End If
        Next ctrl


        If Not ValidarCampos() Then
            MessageBox.Show("Existen Campos Sin Valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim NRO_FACTURA As String = nrofactura.Text

        'Dim FECHA_EMISION As String = fechaemision.Value.Date

        Dim EMPRESA_EMITIDA As String = txtcliente.Text

        Dim RUC As String = ruc2.Text

        Dim detalle As String = detalle2.Text

        Dim PERSONAL_AUTORIZADO As String = personal.Text


        Dim NRO_PROFORMA As String = nroproforma.Text

        Dim NRO_OC As String = nrooc.Text

        Dim guia As String = guia_.Text
        Dim subtotal As Integer = Math.Truncate(CDbl(Val(subtotal_.Text)))

        Dim IGV As Integer = Math.Truncate(CDbl(Val(IGV_.Text)))

        Dim MONTO_TOTAL As Integer = Math.Truncate(CDbl(Val(total.Text)))

        Dim CONTROL_PAGADO As Integer

        If controlpagado.Text = String.Empty Then
            CONTROL_PAGADO = 0

        Else
            CONTROL_PAGADO = Math.Truncate(CDbl(Val(controlpagado.Text)))
        End If


        Dim cancelada As String = cancelada_.Text

        'Dim FECHA_CANC As String = fechacancelacion.Text
        Dim FORMA_PAGO As String = fpago_.Text
        If IsNumeric(fpago_.Text) = False Then
            fpago_.Text = 0
        End If

        If fpago_.Text = String.Empty Then
            FORMA_PAGO = 0

        Else
            FORMA_PAGO = Math.Truncate(CDbl(Val(fpago_.Text)))
        End If

        Dim DET_RET As String = detret.Text
        If IsNumeric(detret.Text) = False Then
            detret.Text = 0
        End If

        If detret.Text = String.Empty Then
            DET_RET = 0

        Else
            DET_RET = Math.Truncate(CDbl(Val(detret.Text)))
        End If

        Dim PORCENTAJE_DET As String = porcdet.Text
        If IsNumeric(porcdet.Text) = False Then
            detret.Text = 0
        End If

        If porcdet.Text = String.Empty Then
            PORCENTAJE_DET = 0

        Else
            PORCENTAJE_DET = Math.Truncate(CDbl(Val(porcdet.Text)))
        End If



        Dim MES_DET As String = mesdet.Text

        ' Dim FECHA_DET As String = fechadet.Value.Date.ToString ggggg

        Dim MONTO_REST_DET As String = pagosdet.Text
        If IsNumeric(pagosdet.Text) = False Then
            pagosdet.Text = 0
        End If

        If pagosdet.Text = String.Empty Then
            MONTO_REST_DET = 0

        Else
            MONTO_REST_DET = Math.Truncate(CDbl(Val(pagosdet.Text)))
        End If

        Try
            If modificacion.Checked = False Then


                Dim rpta As String = clCargarFactura.registrarFactura(NRO_FACTURA,
                                                          fechaemision.Value.Date,
                                                          EMPRESA_EMITIDA,
                                                          RUC, detalle,
                                                          PERSONAL_AUTORIZADO,
                                                          NRO_PROFORMA,
                                                          NRO_OC,
                                                          guia,
                                                          subtotal,
                                                          IGV,
                                                          MONTO_TOTAL,
                                                          CONTROL_PAGADO,
                                                          cancelada,
                                                        fc.Value.Date,
                                                        FORMA_PAGO,
                                                          DET_RET,
                                                          PORCENTAJE_DET,
                                                          MES_DET,
                                                           fechaemision.Value.Date,
                                                          MONTO_REST_DET)


                MessageBox.Show(rpta, "Registro insertado", MessageBoxButtons.OK, MessageBoxIcon.Information)



            Else



                Dim rpta2 As String = clCargarFactura.actualizarFactura(NRO_FACTURA,
                                                          fechaemision.Value.Date,
                                                          EMPRESA_EMITIDA,
                                                          RUC, detalle,
                                                          PERSONAL_AUTORIZADO,
                                                          NRO_PROFORMA,
                                                          NRO_OC,
                                                          guia,
                                                          subtotal,
                                                          IGV,
                                                          MONTO_TOTAL,
                                                          CONTROL_PAGADO,
                                                          cancelada,
                                                        fc.Value.Date,
                                                        FORMA_PAGO,
                                                          DET_RET,
                                                          PORCENTAJE_DET,
                                                          MES_DET,
                                                           fechaemision.Value.Date,
                                                          MONTO_REST_DET)


                MessageBox.Show(rpta2, "Registro actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)









            End If
            actualizarSgteId()
            limpiarCampos()
        Catch

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


        fpago_.Text = fechadet.Value.Date


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub limpiarCampos()
        txtcliente.Text = ""
        detalle2.Text = ""
        detret.Text = ""
        nroproforma.Text = ""
        ruc2.Text = ""
        personal.Text = ""
        nrooc.Text = ""
        IGV_.Text = ""
        guia_.Text = ""
        subtotal_.Text = ""
        total.Text = ""
        controlpagado.Text = ""
        mesDet.Text = ""
        cancelada_.Text = ""
        porcdet.Text = ""
        detret.Text = ""
        pagosdet.Text = ""
        fpago_.Text = ""
        actualizarSgteId()
    End Sub
    Private Function ValidarCampos() As Boolean
        Dim i As Integer
        Dim op As Boolean = True
        If subtotal_.Text.Trim = String.Empty Then
            i += 1
        End If
        If ruc2.Text.Trim = String.Empty Then
            i += 1
        End If
        If total.Text.Trim = String.Empty Then
            i += 1
        End If
        If IGV_.Text.Trim = String.Empty Then
            i += 1
        End If
        If txtcliente.Text.Trim = String.Empty Then
            i += 1
        End If
        If i > 0 Then
            op = False
        End If
        Return op
    End Function
    Private Sub frmCargaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If modificacion.Checked.ToString = "True" Then

        Else
            actualizarSgteId()
        End If
        TextBox1.Text = modificacion.Checked.ToString







    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim form As New ExamCliente(txtcliente, ruc2)
            form.ShowDialog()
            idCliente = form.idCliente
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim form As New ListarUs(personal)
        form.ShowDialog()








    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim form As New ExamCotizacion(nroproforma)
            form.ShowDialog()
            If form.empresa IsNot String.Empty Then
                txtcliente.Text = form.empresa
                ruc2.Text = form.ruc
                CargarCampos()
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function CargarCampos()
        Dim listaTipos As DataTable
        listaTipos = clCargarFactura.CargaCampos(CInt(nroproforma.Text) - 10000)
        IGV_.Text = listaTipos.Rows(0).Item(1)
        subtotal_.Text = listaTipos.Rows(0).Item(2)
        total.Text = listaTipos.Rows(0).Item(3)
        porcdet.Text = listaTipos.Rows(0).Item(4)
        detret.Text = listaTipos.Rows(0).Item(5)
    End Function

    Private Sub mesdet_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub IGV__KeyPress(sender As Object, e As KeyPressEventArgs) Handles IGV_.KeyPress
    '    Dim AllowedKeys As String = "0123456789." & vbBack
    '    e.Handled = Not AllowedKeys.Contains(e.KeyChar)
    'End Sub
    Private Sub IGV__KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IGV_.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
    Private Sub controlpagado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles controlpagado.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
    Private Sub total_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles total.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub total_TextChanged(sender As Object, e As EventArgs) Handles total.TextChanged

    End Sub

    Private Sub porcdet_TextChanged(sender As Object, e As EventArgs) Handles porcdet.TextChanged

    End Sub
    Private Sub porcdet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles porcdet.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
    Private Sub subtotal__KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles subtotal_.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub subtotal__TextChanged(sender As Object, e As EventArgs) Handles subtotal_.TextChanged

    End Sub
    Private Sub detret_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles detret.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
    Private Sub detret_TextChanged(sender As Object, e As EventArgs) Handles detret.TextChanged

    End Sub
End Class