Public Class FormFamilias

    Private Sub FormFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTablaFamilias()
    End Sub

    Private Sub ActualizarTablaFamilias()
        Try
            Dim familias As DataTable

            ' Consultamos por todos los tipos de producto
            familias = Familia.ListarFamiliasGrid()

            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvFamilias.DataSource = familias
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ActualizarTablaSubFamilias()
        Try
            Dim subFamilias As DataTable

            subFamilias = Familia.ListarSubFamiliasGrid()

            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvSubFamilia.DataSource = subFamilias
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            validarCampos(1)
            If (hayErrores()) Then
                MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim nombre As String = txtNombre.Text
            Dim descripcion As String = txtDescripcion.Text

            Dim rpta As String = Familia.RegistrarFamilia(nombre, descripcion)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActualizarTablaFamilias()

            txtNombre.Text = ""
            txtDescripcion.Text = ""

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer
        Try
            If dgvFamilias.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvFamilias.CurrentRow.Index
            End If

            Dim id As String = dgvFamilias.Item(0, row).Value.ToString - 10000
            Dim nombre As String = dgvFamilias.Item(1, row).Value.ToString
            Dim descripcion As String = dgvFamilias.Item(2, row).Value.ToString

            Dim formModificar As New ModifFamilia(id, nombre, descripcion)
            formModificar.ShowDialog()
            ActualizarTablaFamilias()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer
        Try
            If dgvFamilias.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvFamilias.CurrentRow.Index
            End If

            Dim result As Integer = MessageBox.Show(
                String.Format("¿Está seguro que desea eliminar el elemento seleccionado ({0})?", dgvFamilias.Item(0, row).Value.ToString),
                "Confirmar",
                MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return
            End If

            Dim idFamilia As String = dgvFamilias.Item(0, row).Value.ToString - 10000

            Dim subFamilias As DataTable = Familia.ListarSubFamilias(idFamilia)

            If subFamilias IsNot Nothing Then
                If subFamilias.Rows.Count > 0 Then
                    MessageBox.Show("No es posible eliminar la Familia, ya que tiene Sub-Familia(s) asociadas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If

            Dim rpta As String = Familia.EliminarFamilia(idFamilia)
            MessageBox.Show(rpta, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ActualizarTablaFamilias()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorFamilia.SetError(sender, "")
        Else
            ErrorFamilia.SetError(sender, "Ingrese el nombre de la familia de materiales")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then 'El Nombre es puras letras 
            e.Handled = True
        End If
    End Sub

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtNombre.Text.Trim.Length < 4 And nivel >= 1 Then
            ErrorFamilia.SetError(txtNombre, "Debe ingresar almenos 4 caracteres.")
        Else
            ErrorFamilia.SetError(txtNombre, Nothing)
        End If
    End Sub

    Private Function hayErrores() As Boolean
        If ErrorFamilia.GetError(txtNombre) = Nothing Then
            Return False
        End If

        Return True
    End Function

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub btnAceptarSubFamilia_Click(sender As Object, e As EventArgs) Handles btnAceptarSubFamilia.Click
        Me.Dispose()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim index As Integer = TabControl1.SelectedIndex

        'Seleccionar Tab Crear Sub-Familia
        If index.Equals(2) Then
            CargarFamilias()
        ElseIf index.Equals(3) Then
            ActualizarTablaSubFamilias()
        End If

    End Sub

    Private Sub CargarFamilias()
        Dim lista As New List(Of EntidadDropDown)

        Dim entidadNuevoItem As New EntidadDropDown
        entidadNuevoItem.Id = 0
        entidadNuevoItem.Descripcion = "Seleccione"
        lista.Add(entidadNuevoItem)

        Dim dtFamilias As DataTable = Familia.ListarFamilias


        For Each dr As DataRow In dtFamilias.Rows
            Dim entidad As New EntidadDropDown
            entidad.Id = dr("ID_Familia_Material")
            entidad.Descripcion = dr("Nombre")
            lista.Add(entidad)
        Next

        cbFamilia.DataSource = lista
        cbFamilia.ValueMember = "Id"
        cbFamilia.DisplayMember = "Descripcion"

    End Sub

    Private Sub btnGuardarSubFamilia_Click(sender As Object, e As EventArgs) Handles btnGuardarSubFamilia.Click
        Try
            Dim idFamilia As Integer = cbFamilia.SelectedValue
            If idFamilia.Equals(0) Then
                MessageBox.Show("Por favor, seleccione una Familia", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If txtSubFamilia.Text.Trim.Equals("") Then
                MessageBox.Show("Por favor, ingrese el nombre de la Sub-Familia", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim rpta As String = Familia.RegistrarSubFamilia(idFamilia, txtSubFamilia.Text.Trim, txtSubFamiliaDesc.Text.Trim)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarFamilias()

            txtSubFamilia.Text = ""
            txtSubFamiliaDesc.Text = ""

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnModificarSubFamilia_Click(sender As Object, e As EventArgs) Handles btnModificarSubFamilia.Click
        Dim row As Integer
        Try
            If dgvSubFamilia.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvSubFamilia.CurrentRow.Index
            End If

            Dim idSubFamilia As Integer = dgvSubFamilia.Item(0, row).Value.ToString - 10000

            Dim formModificarSubFamilia As New ModifSubFamilia(idSubFamilia)
            formModificarSubFamilia.ShowDialog()

            ActualizarTablaSubFamilias()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEliminarSubFamilia_Click(sender As Object, e As EventArgs) Handles btnEliminarSubFamilia.Click
        Dim row As Integer
        Try
            If dgvSubFamilia.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvSubFamilia.CurrentRow.Index
            End If

            Dim result As Integer = MessageBox.Show(
                String.Format("¿Está seguro que desea eliminar el elemento seleccionado ({0})?", dgvSubFamilia.Item(0, row).Value.ToString),
                "Confirmar",
                MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return
            End If

            Dim idSubFamilia As String = dgvSubFamilia.Item(0, row).Value.ToString - 10000

            Dim rpta As String = Familia.EliminarSubFamilia(idSubFamilia)
            MessageBox.Show(rpta, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ActualizarTablaSubFamilias()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class