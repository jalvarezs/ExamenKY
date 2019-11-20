Public Class FormPedido

    Private conexion As Conexion

    Private Sub FormPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()

        Try
            Dim pedidos As DataTable

            ' Consultamos por todos los tipos de producto
            pedidos = Pedido.listar()

            ' Mostramos  en el dataGridView correspondiente
            dgvPedidos.DataSource = pedidos
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub MostrarDatos(opcion1 As Boolean, opcion2 As Boolean, opcion3 As Boolean)
        'Muestra los datos segun el usuario haga click en las opciones
        'pnlBasico.Visible = opcion1
        'pnlContacto.Visible = opcion2
        'pnlinfobanco.Visible = opcion3
    End Sub



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            Dim row As Integer

            If dgvPedidos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvPedidos.CurrentRow.Index
            End If


            Dim id As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(0, row).Value)
            Dim fecha As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(1, row).Value)
            Dim nombre As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(2, row).Value)
            Dim idCliente As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(4, row).Value)

            Dim formModificar As New ModifPedido(id, nombre, fecha, "", "", idCliente)
            formModificar.ShowDialog()
            actualizarTabla()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub




    'Private Sub cmdbuscar_Click(sender As Object, e As EventArgs)
    '    Try

    '        ' Consultamos por todos los filtros
    '        clientes = Pedido.busqueda_inteligente(nombre, RUC, Distrito)

    '        ' Mostramos clientes en el dataGridView correspondiente
    '        dgvPedidos.DataSource = clientes


    '    Catch ex As Exception
    '        MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub
End Class