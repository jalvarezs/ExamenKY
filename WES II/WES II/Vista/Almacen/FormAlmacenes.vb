Public Class FormAlmacenes
    Dim ciudades As New DataTable
    Dim proyectos As New DataTable
    Private Sub FormAlmacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' Lista de ciudades
            ciudades = Ciudad.listar()
            With cboCiudad
                .DataSource = ciudades
                .ValueMember = ciudades.Columns(0).ToString
                .DisplayMember = ciudades.Columns(1).ToString
            End With

            ' Lista de proyectos 
            proyectos = Proyecto.listar()
            With cboProyecto
                .DataSource = proyectos
                .ValueMember = proyectos.Columns(0).ToString
                .DisplayMember = proyectos.Columns(1).ToString
            End With

            cboEstado.SelectedIndex = 1
            cboTipo.SelectedIndex = 1
            actualizarTabla()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarTabla()
        Dim almacenes As New DataTable

        Try

            ' Consultamos por todos los almacenes
            almacenes = Almacen.listar()

            ' Mostramos los almacenes en el dataGridView correspondiente
            dgvAlmacenes.DataSource = almacenes

            With dgvAlmacenes
                .Columns(0).Width = 50
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 75
                .Columns(5).Width = 75
                .Columns(6).Width = 75
            End With

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Try

        validarCampos(2)
            If (hayErrores()) Then
                MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim Nombre As String = txtNombre.Text.Trim
            Dim Tipo As String = cboTipo.SelectedIndex.ToString
            Dim Observaciones As String = txtObservaciones.Text.Trim
            Dim Estado As String = cboEstado.SelectedIndex.ToString
            Dim Ciudad As String = cboCiudad.SelectedValue.ToString
            Dim Proyecto As String = cboProyecto.SelectedValue.ToString

            Dim rpta As String = Almacen.registrar(Nombre, Tipo, Observaciones, Estado, Ciudad, Proyecto)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            actualizarTabla()

        'Catch ex As Exception
        '    MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer
        Try

            If dgvAlmacenes.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvAlmacenes.CurrentRow.Index
            End If

            Dim IdAlmacen As String = dgvAlmacenes.Item(0, row).Value.ToString
            Dim Nombre As String = dgvAlmacenes.Item(1, row).Value.ToString
            Dim Tipo As String = dgvAlmacenes.Item(2, row).Value.ToString
            Dim Observaciones As String = dgvAlmacenes.Item(3, row).Value.ToString
            Dim Estado As String = dgvAlmacenes.Item(4, row).Value.ToString
            Dim Ciudad As String = dgvAlmacenes.Item(5, row).Value.ToString
            Dim Proyecto As String = dgvAlmacenes.Item(6, row).Value.ToString
            Dim Usuario As String = dgvAlmacenes.Item(7, row).Value.ToString

            Dim formModificar As New ModifAlmacen(IdAlmacen, Nombre, Tipo, Observaciones, Estado, Ciudad, Proyecto, Usuario)
            formModificar.ShowDialog()
            actualizarTabla()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        Try

            If dgvAlmacenes.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvAlmacenes.CurrentRow.Index
            End If

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim IdAlmacen As String = dgvAlmacenes.Item(0, row).Value.ToString

                Dim rpta As String = Almacen.eliminar(IdAlmacen)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function hayErrores() As Boolean
        If ErrorAlmacen.GetError(txtNombre) = Nothing And ErrorAlmacen.GetError(cboProyecto) = Nothing Then
            Return False
        End If

        Return True
    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtNombre.Text.Trim.Length < 4 And nivel >= 1 Then
            ErrorAlmacen.SetError(txtNombre, "Debe ingresar almenos 4 caracteres.")
        Else
            ErrorAlmacen.SetError(txtNombre, Nothing)
        End If

        If cboCiudad.Text = "" And nivel >= 2 Then
            ErrorAlmacen.SetError(cboProyecto, "Debe registrar una ciudad, al menos.")
        Else
            ErrorAlmacen.SetError(cboCiudad, Nothing)
        End If

        If cboProyecto.Text = "" And nivel >= 2 Then
            ErrorAlmacen.SetError(cboProyecto, "Debe registrar un proyecto, al menos.")
        Else
            ErrorAlmacen.SetError(cboProyecto, Nothing)
        End If


    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        validarCampos(1)
    End Sub

    Private Sub btnVerSectores_Click(sender As Object, e As EventArgs) Handles btnVerSectores.Click
        Dim row As Integer
        Try

            If dgvAlmacenes.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvAlmacenes.CurrentRow.Index
            End If

            Dim IdAlmacen As String = dgvAlmacenes.Item(0, row).Value.ToString
            Dim Nombre As String = dgvAlmacenes.Item(1, row).Value.ToString
            Dim form As New FormSectoresAlmacen(IdAlmacen, Nombre)
            form.ShowDialog()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try

            Dim form As New FormProyectos()
            form.ShowDialog()
            ' Lista de proyectos 
            proyectos = Proyecto.listar()
            With cboProyecto
                .DataSource = proyectos
                .ValueMember = proyectos.Columns(0).ToString
                .DisplayMember = proyectos.Columns(1).ToString
            End With

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class