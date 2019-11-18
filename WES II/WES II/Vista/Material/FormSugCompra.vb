Public Class FormSugCompra
    Private Sub FormSugCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnAceptar.Visible = False
        CargarProveedores()
        Dtp_fecha.Value = Now
    End Sub
    Private Sub CargarProveedores()

        Dim proveedores As DataTable = Proveedor.listar()
        With cbProveedor
            .DataSource = proveedores
            .DisplayMember = proveedores.Columns(1).ColumnName
            .ValueMember = proveedores.Columns(0).ColumnName
        End With
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Dim col As New DataGridViewTextBoxColumn

        'If rdb_Selec.Checked = True Then
        Dim dt As DataTable = Proveedor.buscarXnombre(cbProveedor.Text)
        Dim rows As DataRow = dt.AsEnumerable.FirstOrDefault
        Try
            vidprov = rows("ID_Proveedor")
            idprov.Text = vidprov
            vruc.Text = rows("RUC")
            vdirec.Text = rows("direccion")
            'txtnomprov.Text = rows("Nombre")
            actualizarTabla(idprov.Text)
            btnAceptar.Visible = True
        Catch ex As Exception
            MessageBox.Show("No existe ese proveedor en la Base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvProducto.DataSource = Nothing
        End Try
        'Else
        '    If rdb_todos.Checked Then
        '        actualizarTabla("", "", "2")
        '    End If
        'End If

    End Sub

    Private Sub actualizarTabla(ByVal prov As String)
        Try
            Dim productos As DataTable

            ' Consultamos por todos los tipos de producto
            'productos = Material.buscarMatQuiebre(nombre, prov, mopc)
            productos = Material.buscarMatQuiebre(prov)

            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvProducto.DataSource = productos
            If dgvProducto.RowCount > 0 Then
                btnAceptar.Visible = True
            Else
                btnAceptar.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btn_Generar_OC(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim vselec As Boolean
        For i = 0 To dgvProducto.Rows.Count
            If dgvProducto.Rows(i).Cells(0).Value = False Then
                vselec = False
            Else
                If dgvProducto.Rows(i).Cells(1).Value <> "" Then
                    vselec = True
                    Exit For
                Else
                    MessageBox.Show("Debe de ingresar una cantidad.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    vselec = False
                    Exit Sub
                End If
                If i = dgvProducto.Rows.Count - 1 Then
                    Exit For
                End If
            End If
        Next

        If vselec = False Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        j = 0
        If dgvProducto.Rows(i).Cells(3).Value > dgvProducto.Rows(i).Cells(1).Value Then
            MessageBox.Show("La cantidad a comprar no puede ser menor que el Stock minimo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For i = 0 To dgvProducto.Rows.Count
            If dgvProducto.Rows(i).Cells(0).Value = True Then
                Dim rpta As String = Sugerencias.Registrar(dgvProducto.Rows(i).Cells(13).Value, cbProveedor.Text,
                                                           dgvProducto.Rows(i).Cells(5).Value,
                                                           vruc.Text, vdirec.Text, dgvProducto.Rows(i).Cells(2).Value,
                                                           dgvProducto.Rows(i).Cells(1).Value, idprov.Text, Dtp_fecha.Text)

            End If
            If i = dgvProducto.Rows.Count - 1 Then
                Exit For
            End If
        Next

        MessageBox.Show("Debe ir al formulario de OC para ver las sugerencias de reposicion de material", "Información")
        Me.Close()
    End Sub

    Private Sub txtnomprov_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged

    End Sub
End Class