Public Class ModifAlmacen
    Private id, nombre, tipo, observaciones, estado, una_ciudad, un_proyecto, un_usuario As String
    Private ciudades As New DataTable
    Private proyectos As New DataTable
    Private usuarios As New DataTable

    Sub New(ByVal _id As String, ByVal _nombre As String, ByVal _tipo As String, ByVal _observaciones As String, ByVal _estado As String, ByVal _ciudad As String, ByVal _proyecto As String, ByVal _usuario As String)

        Try

            InitializeComponent()

            id = _id
            nombre = _nombre
            tipo = _tipo
            observaciones = _observaciones
            estado = _estado
            una_ciudad = _ciudad
            un_proyecto = _proyecto
            un_usuario = _usuario

            ' Listado de ciudades
            ciudades = Ciudad.listar()
            With cboCiudad
                .DataSource = ciudades
                .ValueMember = ciudades.Columns(0).ToString
                .DisplayMember = ciudades.Columns(1).ToString
            End With

            proyectos = Proyecto.listar()
            With cboProyecto
                .DataSource = proyectos
                .ValueMember = proyectos.Columns(0).ToString
                .DisplayMember = proyectos.Columns(1).ToString
            End With

            'Usuario
            usuarios = Usuario.listar()
            With cboUsuario
                .DataSource = usuarios
                .ValueMember = usuarios.Columns(0).ToString
                .DisplayMember = usuarios.Columns(1).ToString
            End With

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ModifAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            cboTipo.SelectedIndex = cboTipo.FindStringExact(tipo)
            txtNombre.Text = nombre
            txtObservaciones.Text = observaciones
            cboEstado.SelectedIndex = cboEstado.FindStringExact(estado)
            cboCiudad.SelectedIndex = cboCiudad.FindStringExact(una_ciudad)
            cboProyecto.SelectedIndex = cboProyecto.FindStringExact(un_proyecto)
            cboUsuario.SelectedIndex = cboUsuario.FindStringExact(un_usuario)
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If txtNombre.Text.Trim.Length > 4 Then
                Dim tipo As String = cboTipo.SelectedIndex.ToString
                Dim nombre As String = txtNombre.Text.Trim
                Dim observaciones As String = txtObservaciones.Text.Trim
                Dim estado As String = cboEstado.SelectedIndex.ToString
                Dim ciudad As String = cboCiudad.SelectedValue.ToString
                Dim proyecto As String = cboProyecto.SelectedValue.ToString
                Dim usuario As String = cboUsuario.SelectedValue.ToString

                Dim rpta As String = Almacen.modificar(id, nombre, tipo, observaciones, estado, ciudad, proyecto, usuario)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El nombre del almacén debe tener mínimo 4 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text.Trim.Length < 4 Then
            Errores.SetError(txtNombre, "No se permiten menos de 4 caracteres")
        Else
            Errores.Dispose()
        End If
    End Sub
End Class