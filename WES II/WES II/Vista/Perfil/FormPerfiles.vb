Public Class FormPerfiles

    Private Sub FormPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()
        Dim perfiles As DataTable

        ' Consultamos por todos los tipos de perfiles
        perfiles = Perfil.listar()

        ' Mostramos tales tipos en el dataGridView correspondiente
        dgvPerfiles.DataSource = perfiles
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = txtDescripcion.Text

        Dim rpta As String = Perfil.registrar(nombre, descripcion)
        MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        actualizarTabla()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer

        If dgvPerfiles.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvPerfiles.CurrentRow.Index
        End If

        Dim id As String = dgvPerfiles.Item(0, row).Value.ToString
        Dim nombre As String = dgvPerfiles.Item(1, row).Value.ToString
        Dim descripcion As String = dgvPerfiles.Item(2, row).Value.ToString

        Dim formModificar As New ModifPerfil(id, nombre, descripcion)
        formModificar.ShowDialog()
        actualizarTabla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvPerfiles.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvPerfiles.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim id As String = dgvPerfiles.Item(0, row).Value.ToString
            'Dim rpta As String =
            Perfil.eliminar(id)
            ' MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla()
        End If
    End Sub

    ''Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
    ''    If txtNombre.Text.Length < 5 Then 'Nombre cuyos caracteres son mayores a 5
    ''        ErrorPerfil.SetError(txtNombre, "Debe ingresar un Nombre con al menos 5 caracteres")
    ''    Else
    ''        ErrorPerfil.SetError(txtNombre, "")
    ''    End If
    ''End Sub

    ''Private Sub txtGrado_TextChanged(sender As Object, e As EventArgs) Handles txtGrado.TextChanged
    ''    If txtGrado.Text.Length < 0 Or txtGrado.Text.Length > 5 Then 'Grado cuyo dígitos son entre 1 - 5
    ''        ErrorPerfil.SetError(txtGrado, "Debe ingresar un Grado menor a 6 dígitos")
    ''    Else
    ''        ErrorPerfil.SetError(txtGrado, "")
    ''    End If
    ''End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorPerfil.SetError(sender, "")
        Else
            ErrorPerfil.SetError(sender, "Ingrese el Nombre del Perfil ya que este dato es obligatorio")
        End If
    End Sub

    Private Sub txtGrado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorPerfil.SetError(sender, "")
        Else
            ErrorPerfil.SetError(sender, "Ingrese el Grado del Perfil ya que este dato es obligatorio")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then 'El Nombre es puras letras
            e.Handled = True
        End If
    End Sub

    Private Sub txtGrado_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar)) Then 'El Grado es puros numeros
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTipPerfil.SetToolTip(txtNombre, "Ingrese aquí el Nombre del Perfil")
        ToolTipPerfil.ToolTipTitle = "Nombre del Perfil"
        ToolTipPerfil.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtGrado_MouseHover(sender As Object, e As EventArgs)
        'ToolTipPerfil.SetToolTip(txtGrado, "Ingrese aquí el Grado del Perfil")
        ToolTipPerfil.ToolTipTitle = "Grado del Perfil"
        ToolTipPerfil.ToolTipIcon = ToolTipIcon.Info
    End Sub

End Class