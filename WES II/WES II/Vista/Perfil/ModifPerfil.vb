Public Class ModifPerfil

    Private id, nombre, descripcion As String

    Sub New(ByVal _id As String, ByVal _nombre As String, ByVal _descripcion As String)
        InitializeComponent()

        id = _id
        nombre = _nombre
        descripcion = _descripcion
    End Sub

    Private Sub ModifPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = nombre
        txtDescripcion.Text = descripcion
        actualizarTablas()
    End Sub

    Private Sub actualizarTablas()
        Dim datos As DataTable
        datos = Perfil.listarBotones(id)
        dgvBotones.DataSource = datos

        datos = Perfil.listarPermisos(id)
        dgvPermisos.DataSource = datos
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = txtDescripcion.Text

        Dim rpta As String = Perfil.modificar(id, nombre, descripcion)
        MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
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

    Private Sub dgvBotones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBotones.CellContentClick

    End Sub

    Private Sub btnMasAcceso_Click(sender As Object, e As EventArgs) Handles btnMasAcceso.Click
        Dim row As Integer
        row = dgvBotones.CurrentRow.Index
        Dim Boton As String = dgvBotones.Item(0, row).Value.ToString
        Dim rpta As String
        rpta = Perfil.masAcceso(id, Boton)
        If rpta = "" Then
            actualizarTablas()
        Else
            MessageBox.Show(rpta)
        End If
    End Sub

    Private Sub btnMenosAcceso_Click(sender As Object, e As EventArgs) Handles btnMenosAcceso.Click
        Dim row As Integer
        row = dgvPermisos.CurrentRow.Index
        Dim Boton As String = dgvPermisos.Item(0, row).Value.ToString
        Dim rpta As String
        rpta = Perfil.menosAcceso(id, Boton)
        If rpta = "" Then
            actualizarTablas()
        Else
            MessageBox.Show(rpta)
        End If
    End Sub
End Class