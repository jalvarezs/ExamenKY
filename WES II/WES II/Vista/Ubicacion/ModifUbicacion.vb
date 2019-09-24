Public Class ModifUbicacion

    Private ID_Ubicacion, ID_TipoUbicacion, Pasillo, Columna, Nivel, Compartimiento, Estado, Capacidad As String
    Private TiposUbi As DataTable

    Sub New(ByVal _ID_Ubicacion As String, ByVal _ID_TipoUbicacion As String, ByVal _Pasillo As String, ByVal _Columna As String, ByVal _Nivel As String, ByVal _Compartimiento As String, ByVal _Estado As String, ByVal _Capacidad As String)
        InitializeComponent()

        ID_Ubicacion = _ID_Ubicacion
        ID_TipoUbicacion = _ID_TipoUbicacion
        Pasillo = _Pasillo
        Columna = _Columna
        Nivel = _Nivel
        Compartimiento = _Compartimiento
        Estado = _Estado
        Capacidad = _Capacidad

        TiposUbi = New DataTable
        TiposUbi = TipoUbicacion.listar()

        cboTipoUbicacion.DataSource = TiposUbi
        cboTipoUbicacion.ValueMember = TiposUbi.Columns(0).ToString
        cboTipoUbicacion.DisplayMember = TiposUbi.Columns(1).ToString
    End Sub

    Private Sub ModifUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipoUbicacion.SelectedIndex = cboTipoUbicacion.FindStringExact(ID_TipoUbicacion)
        txtPasillo.Text = Pasillo
        txtColumna.Text = Columna
        txtNivel.Text = Nivel
        txtCompartimiento.Text = Compartimiento
        txtCapacidad.Text = Capacidad
        If Estado = "True" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'If txtPasillo.Text.Trim.Length > 1 AND txtColumna.Text.Trim.Length > 1 And txtNivel.Text.Trim.Length > 1 And txtCompartimiento.Text.Trim.Length > 1 And txtCapacidad.Text.Trim.Length > 1 Then
        Dim ID_TipoUbic As String = cboTipoUbicacion.SelectedValue.ToString
        Dim Pasillo As String = txtPasillo.Text.Trim
        Dim Columna As String = txtColumna.Text.Trim
        Dim Nivel As String = txtNivel.Text.Trim
        Dim Compartimiento As String = txtCompartimiento.Text.Trim
        Dim Capacidad As String = txtCapacidad.Text.Trim
        Dim Estado As Integer

        If chkEstado.Checked = True Then
            Estado = 1
        Else
            Estado = 0
        End If
        If (txtPasillo.Text.Length > 0 And txtColumna.Text.Length > 0 And txtNivel.Text.Length And txtCompartimiento.Text.Length > 0 And txtCapacidad.Text.Length > 0) Then

            Dim rpta As String = Ubicacion.modificarUbicacion(ID_Ubicacion, ID_TipoUbic, Pasillo, Columna, Nivel, Compartimiento, Capacidad, Estado)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (txtPasillo.Text.Length < 1) Then
            MessageBox.Show("Debe ingresar un pasillo ")
        ElseIf (txtColumna.Text.Length < 1) Then
            MessageBox.Show("Debe ingresar una columna")
        ElseIf (txtNivel.Text.Length < 1) Then
            MessageBox.Show("Debe ingresar un nivel")
        ElseIf (txtCompartimiento.Text.Length < 1) Then
            MessageBox.Show("Debe ingresar un Compartimiento")
        ElseIf (txtCapacidad.Text.Length < 1) Then
            MessageBox.Show("Debe ingresar una capacidad")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub Fg_SoloNumeros(ByRef Digito As String, ByRef Texto As TextBox)
        If InStr(1, "0123456789" & Chr(8), Digito) = 0 Then
            Digito = CChar("")
        End If
    End Sub

    Private Sub txtPasillos_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtPasillo.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtPasillo)
    End Sub

    Private Sub txtColumnas_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtColumna.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtColumna)
    End Sub

    Private Sub txtNiveles_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtNivel.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtNivel)
    End Sub

    Private Sub txtCompartimiento_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtCompartimiento.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtCompartimiento)
    End Sub
End Class