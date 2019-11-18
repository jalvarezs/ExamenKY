Public Class FormPedido

    Private conexion As Conexion

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()

        Try
            Dim clientes As DataTable

            ' Consultamos por todos los tipos de producto
            clientes = Cliente.listar()

            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvPedidos.DataSource = clientes
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub MostrarDatos(opcion1 As Boolean, opcion2 As Boolean, opcion3 As Boolean)
        'Muestra los datos segun el usuario haga click en las opciones
        pnlBasico.Visible = opcion1
        pnlContacto.Visible = opcion2
        pnlinfobanco.Visible = opcion3
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Try

            Dim nombre As String = txtNombre.Text
            Dim ruc As String = txtRUC.Text
            Dim contacto1 As String = txtnmbrecontacto1.Text
            Dim contacto2 As String = txtnmbrecontacto2.Text
            Dim banco As String = txtBanco.Text
            Dim cuentaCorriente As String = txtCuenta.Text
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
                Dim rpta As String = Cliente.registrar(nombre, ruc, contacto1, contacto2, banco, cuentaCorriente, direccion, telf, telf_sec, email, web, Distrito, emailcontacto1, emailcontacto2, telfcontacto1, telfcontacto2, Banco1, Banco2, moneda1, moneda2, CuentaCorriente1, CuentaCorriente2, CCI1, CCI2)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
                txtNombre.Text = ""
                txtRUC.Text = ""
                txtnmbrecontacto1.Text = ""
                txtnmbrecontacto2.Text = ""
                txtBanco.Text = ""
                txtCuenta.Text = ""
                txtDireccion.Text = ""
                txtTelf.Text = ""
                txtTelfSec.Text = ""
                txtEmail.Text = ""
                txtWeb.Text = ""
                txtDistrito.Text = ""
                txtemailcontacto1.Text = ""
                txtemailcontacto2.Text = ""
                txttelfcontacto1.Text = ""
                txttelfcontacto2.Text = ""
                txtbanco1.Text = ""
                txtbanco2.Text = ""
                txtcuentabanco1.Text = ""
                txtcuentabanco2.Text = ""
                txtccibanco1.Text = ""
                txtccibanco2.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
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
            Dim nombre As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(1, row).Value)
            Dim ruc As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(2, row).Value)
            Dim Distrito As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(3, row).Value)
            Dim direccion As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(4, row).Value)
            Dim telf As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(5, row).Value)
            Dim telf_sec As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(6, row).Value)
            Dim email As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(7, row).Value)
            Dim web As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(8, row).Value)
            Dim contacto1 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(9, row).Value)
            Dim EmailContacto1 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(10, row).Value)
            Dim TelefonoContacto1 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(11, row).Value)
            Dim contacto2 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(12, row).Value)
            Dim EmailContacto2 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(13, row).Value)
            Dim TelefonoContacto2 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(14, row).Value)
            Dim banco1 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(15, row).Value)
            Dim moneda1 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(16, row).Value)
            Dim cuentaCorriente1 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(17, row).Value)
            Dim CCI1 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(18, row).Value)
            Dim banco2 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(19, row).Value)
            Dim moneda2 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(20, row).Value)
            Dim cuentaCorriente2 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(21, row).Value)
            Dim CCI2 As String = UtilConvertidor.GetStringVal(dgvPedidos.Item(22, row).Value)

            Dim formModificar As New ModifPedido(id, nombre, ruc, Distrito, direccion, telf, telf_sec, email, web, contacto1, EmailContacto1, TelefonoContacto1, contacto2, EmailContacto2, TelefonoContacto2, banco1, moneda1, cuentaCorriente1, CCI1, banco2, moneda2, cuentaCorriente2, CCI2)
            formModificar.ShowDialog()
            actualizarTabla()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        Try

            If dgvPedidos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvPedidos.CurrentRow.Index()
            End If

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim id As Integer = dgvPedidos.Item(0, row).Value
                Dim rpta As String = Cliente.eliminar(id)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
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

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtNombre.Text.Trim.Length < 4 And nivel >= 1 Then
            ErrorCliente.SetError(txtNombre, "Debe ingresar al menos 4 caracteres.")
        ElseIf (nivel = 1) Then
            ErrorCliente.SetError(txtNombre, Nothing)
        End If

        'If (txtTelf.Text.Length < 5 Or txtTelf.Text.Length = 0) And nivel >= 2 Then
        '    ErrorCliente.SetError(txtTelf, "El teléfono debe tener al menos 5 caracteres.")
        'ElseIf (nivel = 2) Then
        '    ErrorCliente.SetError(txtTelf, Nothing)
        'End If

        'If (Not HayArroba(txtEmail.Text)) And txtEmail.Text.Trim.Length > 0 And nivel >= 3 Then
        'ErrorCliente.SetError(txtEmail, "Formato incorrecto de email (se requiere @).")
        'ElseIf (nivel = 3) Then
        'ErrorCliente.SetError(txtEmail, Nothing)
        'End If

        If txtDireccion.Text.Trim.Length < 4 And nivel >= 4 Then
            ErrorCliente.SetError(txtDireccion, "Debe ingresar al menos 4 caracteres.")
        ElseIf (nivel = 4) Then
            ErrorCliente.SetError(txtDireccion, Nothing)
        End If

        If txtTelfSec.Text.Trim.Length < 5 And txtTelfSec.Text.Trim.Length > 0 And nivel >= 5 Then
            ErrorCliente.SetError(txtTelfSec, "Debe ingresar al menos 5 caracteres.")
        ElseIf (nivel = 5) Then
            ErrorCliente.SetError(txtTelfSec, Nothing)
        End If

        If txtWeb.Text.Trim.Length < 5 And txtWeb.Text.Trim.Length > 0 And nivel >= 6 Then
            ErrorCliente.SetError(txtWeb, "Debe ingresar al menos 5 caracteres.")
        ElseIf (nivel = 6) Then
            ErrorCliente.SetError(txtWeb, Nothing)
        End If

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(1)
    End Sub

    Private Sub txtTelf_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(2)
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(3)
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(4)
    End Sub

    Private Sub txtTelfSec_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(5)
    End Sub

    Private Sub txtWeb_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(6)
    End Sub

    Private Sub txtTelf_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTelf_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btninfocomercial_Click(sender As Object, e As EventArgs)
        MostrarDatos(True, False, False)
        txtNombre.Focus()
    End Sub

    Private Sub btninfocontacto_Click(sender As Object, e As EventArgs)
        MostrarDatos(False, True, False)
        txtnmbrecontacto1.Focus()
    End Sub

    Private Sub btninfobancos_Click(sender As Object, e As EventArgs)
        MostrarDatos(False, False, True)
        txtbanco1.Focus()
    End Sub

    Private Sub cmdbuscar_Click(sender As Object, e As EventArgs)
        Try
            Dim nombre As String = txtbuscarnombre.Text
            Dim RUC As String = txtRUCbuscar.Text
            Dim Distrito As String = txtDistritoBuscar.Text
            Dim clientes As DataTable

            If nombre = "" Then
                nombre = "-1"
            End If
            If RUC = "" Then
                RUC = "-1"
            End If
            If Distrito = "" Then
                Distrito = "-1"
            End If

            ' Consultamos por todos los filtros
            clientes = Cliente.busqueda_inteligente(nombre, RUC, Distrito)

            ' Mostramos clientes en el dataGridView correspondiente
            dgvPedidos.DataSource = clientes

            TabControl1.SelectedTab = TabPage2
            txtbuscarnombre.Text = ""
            txtRUCbuscar.Text = ""
            txtDistritoBuscar.Text = ""
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class