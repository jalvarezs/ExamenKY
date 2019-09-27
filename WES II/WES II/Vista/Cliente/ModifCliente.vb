Public Class ModifCliente

    Private id, nombre, ruc, Distrito, direccion, telf, telf_sec, email, web, contacto1, EmailContacto1, TelefonoContacto1, contacto2, EmailContacto2, TelefonoContacto2, banco1, moneda1, cuentaCorriente1, CCI1, banco2, moneda2, cuentaCorriente2, CCI2 As String

    Sub New(ByVal _id As String,
            ByVal _nombre As String,
            ByVal _ruc As String,
            ByVal _Distrito As String,
            ByVal _direccion As String,
            ByVal _telf As String,
            ByVal _telf_sec As String,
            ByVal _email As String,
            ByVal _web As String,
            ByVal _contacto1 As String,
            ByVal _EmailContacto1 As String,
            ByVal _TelefonoContacto1 As String,
            ByVal _contacto2 As String,
            ByVal _EmailContacto2 As String,
            ByVal _TelefonoContacto2 As String,
            ByVal _banco1 As String,
            ByVal _moneda1 As String,
            ByVal _cuentaCorriente1 As String,
            ByVal _CCI1 As String,
            ByVal _banco2 As String,
            ByVal _moneda2 As String,
            ByVal _cuentaCorriente2 As String,
            ByVal _CCI2 As String)
        InitializeComponent()

        id = _id.Trim
        nombre = _nombre.Trim
        ruc = _ruc.Trim
        Distrito = _Distrito.Trim
        direccion = _direccion.Trim
        telf = _telf.Trim
        telf_sec = _telf_sec.Trim
        email = _email.Trim
        web = _web.Trim
        contacto1 = _contacto1.Trim
        EmailContacto1 = _EmailContacto1.Trim
        TelefonoContacto1 = _TelefonoContacto1.Trim
        contacto2 = _contacto2.Trim
        EmailContacto2 = _EmailContacto2.Trim
        TelefonoContacto2 = _TelefonoContacto2.Trim
        banco1 = _banco1.Trim
        moneda1 = _moneda1.Trim
        cuentaCorriente1 = _cuentaCorriente1.Trim
        CCI1 = _CCI1.Trim
        banco2 = _banco2.Trim
        moneda2 = _moneda2.Trim
        cuentaCorriente2 = _cuentaCorriente2.Trim
        CCI2 = _CCI2.Trim

    End Sub


    Private Sub btninfocomercial_Click(sender As Object, e As EventArgs) Handles btninfocomercial.Click
        TabControl1.SelectedIndex = 0
        txtnmbrecontacto1.Select()
    End Sub

    Private Sub btninfocontacto_Click(sender As Object, e As EventArgs) Handles btninfocontacto.Click
        TabControl1.SelectedIndex = 1
        txtNombre.Select()
    End Sub

    Private Sub btninfobancos_Click(sender As Object, e As EventArgs) Handles btninfobancos.Click
        TabControl1.SelectedIndex = 2
        txtbanco1.Select()
    End Sub

    Private Sub ModifCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtNombre.Text = nombre.Trim
            txtRUC.Text = ruc.Trim
            txtnmbrecontacto1.Text = contacto1.Trim
            txtnmbrecontacto2.Text = contacto2.Trim
            txtDireccion.Text = direccion.Trim
            txtTelf.Text = telf.Trim
            txtTelfSec.Text = telf_sec.Trim
            txtEmail.Text = email.Trim
            txtWeb.Text = web.Trim
            txtDistrito.Text = Distrito.Trim
            txtemailcontacto1.Text = EmailContacto1.Trim
            txtemailcontacto2.Text = EmailContacto2.Trim
            txttelfcontacto1.Text = TelefonoContacto1.Trim
            txttelfcontacto2.Text = TelefonoContacto2.Trim
            txtbanco1.Text = banco1.Trim
            txtbanco2.Text = banco2.Trim

            If moneda1 = "USD" Then
                rbDolar.Checked = True
            Else
                rbSoles.Checked = True
            End If

            If moneda2 = "USD" Then
                rbDolar1.Checked = True
            Else
                rbSoles1.Checked = True
            End If

            txtcuentabanco1.Text = cuentaCorriente1.Trim
            txtcuentabanco2.Text = cuentaCorriente2.Trim
            txtccibanco1.Text = CCI1.Trim
            txtccibanco2.Text = CCI2.Trim

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim nombre As String = txtNombre.Text
            Dim ruc As String = txtRUC.Text
            Dim contacto1 As String = txtnmbrecontacto1.Text
            Dim contacto2 As String = txtnmbrecontacto2.Text
            Dim direccion As String = txtDireccion.Text
            Dim telf As String = txtTelf.Text
            Dim telf_sec As String = txtTelfSec.Text
            Dim email As String = txtEmail.Text
            Dim web As String = txtWeb.Text
            Dim Distrito As String = txtDistrito.Text
            Dim emailcontacto1 As String = txtemailcontacto1.Text
            Dim emailcontacto2 As String = txtemailcontacto2.Text
            Dim telfcontacto1 As String = txttelfcontacto1.Text
            Dim telfcontacto2 As String = txttelfcontacto2.Text
            Dim Banco1 As String = txtbanco1.Text
            Dim Banco2 As String = txtbanco2.Text
            Dim moneda1 As String
            Dim moneda2 As String
            Dim CuentaCorriente1 As String = txtcuentabanco1.Text
            Dim CuentaCorriente2 As String = txtcuentabanco2.Text
            Dim CCI1 As String = txtccibanco1.Text
            Dim CCI2 As String = txtccibanco2.Text
            If rbDolar.Checked = True Then
                moneda1 = "USD"
            Else
                moneda1 = "SOL"
            End If
            If rbDolar1.Checked = True Then
                moneda2 = "USD"
            Else
                moneda2 = "SOL"
            End If
            validarCampos(6)
            If (hayErrores()) Then
                MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rpta As String = Cliente.modificar(id, nombre, ruc, contacto1, contacto2, String.Empty, String.Empty, direccion, telf, telf_sec, email, web, Distrito, emailcontacto1, emailcontacto2, telfcontacto1, telfcontacto2, Banco1, Banco2, moneda1, moneda2, CuentaCorriente1, CuentaCorriente2, CCI1, CCI2)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)
        If txtNombre.Text.Length < 4 Then
            ErrorModifCliente.SetError(txtNombre, "El nombre debe tener mas de 4 caracteres")
        Else
            ErrorModifCliente.SetError(txtNombre, "")
        End If
    End Sub

    Private Sub txtTelf_TextChanged(sender As Object, e As EventArgs)
        If txtTelf.Text.Length > 15 Then
            ErrorModifCliente.SetError(txtTelf, "El telefono debe tener menos de 15 carcateres")
        Else
            ErrorModifCliente.SetError(txtTelf, "")
        End If
    End Sub

    Private Sub txtTelf_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelfSec_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    Public Function HayArroba(ByVal nombre As String) As Boolean
        Dim contador As Integer = 0
        While contador < nombre.Length
            If nombre.Substring(contador, 1).Equals("@") Then
                Return True
            End If
            contador = contador + 1
        End While
        Return False
    End Function

    Private Sub txtEmail_MouseLeave(sender As Object, e As EventArgs)
        If Not HayArroba(txtEmail.Text) Then
            ErrorModifCliente.SetError(txtEmail, "Formato incorrecto (miEmail@ccc.cc)")
        Else
            ErrorModifCliente.SetError(txtEmail, "")
        End If
    End Sub

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtNombre.Text.Trim.Length < 4 And nivel >= 1 Then
            ErrorModifCliente.SetError(txtNombre, "Debe ingresar al menos 4 caracteres.")
        ElseIf (nivel = 1) Then
            ErrorModifCliente.SetError(txtNombre, Nothing)
        End If

        If (txtTelf.Text.Length < 5 Or txtTelf.Text.Length = 0) And nivel >= 2 Then
            ErrorModifCliente.SetError(txtTelf, "El teléfono debe tener al menos 5 caracteres.")
        ElseIf (nivel = 2) Then
            ErrorModifCliente.SetError(txtTelf, Nothing)
        End If

        If (Not HayArroba(txtEmail.Text)) And txtEmail.Text.Trim.Length > 0 And nivel >= 3 Then
            ErrorModifCliente.SetError(txtEmail, "Formato incorrecto de email (se requiere @).")
        ElseIf (nivel = 3) Then
            ErrorModifCliente.SetError(txtEmail, Nothing)
        End If

        If txtDireccion.Text.Trim.Length < 4 And nivel >= 4 Then
            ErrorModifCliente.SetError(txtDireccion, "Debe ingresar al menos 4 caracteres.")
        ElseIf (nivel = 4) Then
            ErrorModifCliente.SetError(txtDireccion, Nothing)
        End If

        If txtTelfSec.Text.Trim.Length < 5 And txtTelfSec.Text.Trim.Length > 0 And nivel >= 5 Then
            ErrorModifCliente.SetError(txtTelfSec, "Debe ingresar al menos 5 caracteres.")
        ElseIf (nivel = 5) Then
            ErrorModifCliente.SetError(txtTelfSec, Nothing)
        End If

        If txtWeb.Text.Trim.Length < 5 And txtWeb.Text.Trim.Length > 0 And nivel >= 6 Then
            ErrorModifCliente.SetError(txtWeb, "Debe ingresar al menos 5 caracteres.")
        ElseIf (nivel = 6) Then
            ErrorModifCliente.SetError(txtWeb, Nothing)
        End If

    End Sub

    Private Function hayErrores() As Boolean
        If (ErrorCliente.GetError(txtNombre) = Nothing And
            ErrorCliente.GetError(txtTelf) = Nothing And
            ErrorCliente.GetError(txtEmail) = Nothing And
            ErrorCliente.GetError(txtDireccion) = Nothing And
            ErrorCliente.GetError(txtTelfSec) = Nothing And
            ErrorCliente.GetError(txtWeb) = Nothing) Then
            Return False
        End If
        Return True
    End Function
End Class