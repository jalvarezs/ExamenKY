Public Class FormNuevoSector
    Private almacen As String
    Private Sub FormSectorParaAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEstado.SelectedIndex = 1
    End Sub

    Sub New(ByVal _id As String)
        InitializeComponent()
        almacen = _id
    End Sub

    Private Sub BtnGuardarst_Click(sender As Object, e As EventArgs) Handles btnGuardarST.Click


        'OJO: Al registrar un sector un disparador en la tabla sectores graba las ubicaciones y para el tipo de ubicacion lo pasa fijo en el disparador.


        Try

            Dim nombre As String = txtNombre.Text.Trim
            Dim codigo As String = txtCodigo.Text.Trim
            Dim estado As String = cboEstado.SelectedIndex.ToString
            Dim pasillos As String = txtPasillos.Text.Trim
            Dim columnas As String = txtColumnas.Text.Trim
            Dim niveles As String = txtNiveles.Text.Trim

            validarCampos(4)
            If (hayErrores()) Then
                MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rpta As String = Sector.registrar(nombre, codigo, almacen, estado, pasillos, columnas, niveles)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub


    ' Eventos  KeyPress
    Private Sub txtPasillos_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            ErrorSector.SetError(txtPasillos, "Debe ingresar números")
            e.Handled = True
        Else
            ErrorSector.Dispose()
        End If
    End Sub

    Private Sub txtNiveles_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            ErrorSector.SetError(txtNiveles, "Debe ingresar números")
            e.Handled = True
        Else
            ErrorSector.Dispose()
        End If
    End Sub


    Private Sub txtColumnas_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            ErrorSector.SetError(txtColumnas, "Debe ingresar números")
            e.Handled = True
        Else
            ErrorSector.Dispose()
        End If
    End Sub

    ' Eventos  txtChanged
    Private Sub txtPasillos_TextChanged(sender As Object, e As EventArgs)
        If txtPasillos.Text.Trim = "0" Then
            MessageBox.Show("El almacén debe tener por lo menos un pasilo")
        End If
    End Sub

    Private Sub txtColumnas_TextChanged(sender As Object, e As EventArgs)
        If txtColumnas.Text.Trim = "0" Then
            MessageBox.Show("El almacén debe tener por lo menos una columna")
        End If
    End Sub

    Private Sub txtNiveles_TextChanged(sender As Object, e As EventArgs)
        If txtNiveles.Text.Trim = "0" Then
            MessageBox.Show("El almacén debe tener por lo menos un nivel.")
        End If
    End Sub

    Private Function hayErrores() As Boolean
        If ErrorSector.GetError(txtNombre) = Nothing Then
            Return False
        End If

        If ErrorSector.GetError(txtPasillos) = Nothing Then
            Return False
        End If

        If ErrorSector.GetError(txtColumnas) = Nothing Then
            Return False
        End If

        If ErrorSector.GetError(txtNiveles) = Nothing Then
            Return False
        End If

        Return True
    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtNombre.Text.Trim.Length < 4 And nivel >= 1 Then
            ErrorSector.SetError(txtNombre, "Debe ingresar al menos 4 caracteres.")
        ElseIf (nivel = 1) Then
            ErrorSector.SetError(txtNombre, Nothing)
        End If

        If txtPasillos.Text.Trim.Length = 0 And nivel >= 2 Then
            ErrorSector.SetError(txtPasillos, "Debe ingresar un número.")
        ElseIf (nivel = 2) Then
            ErrorSector.SetError(txtPasillos, Nothing)
        End If

        If txtColumnas.Text.Trim.Length < 1 And nivel >= 3 Then
            ErrorSector.SetError(txtColumnas, "Debe ingresar un número.")
        ElseIf (nivel = 3) Then
            ErrorSector.SetError(txtColumnas, Nothing)
        End If

        If txtNiveles.Text.Trim.Length < 1 And nivel >= 4 Then
            ErrorSector.SetError(txtNiveles, "Debe ingresar un número.")
        ElseIf (nivel = 4) Then
            ErrorSector.SetError(txtNiveles, Nothing)
        End If

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(1)
    End Sub

    Private Sub txtPasillos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(2)
    End Sub

    Private Sub txtColumnas_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(3)
    End Sub

    Private Sub txtNiveles_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(4)
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub Fg_SoloNumeros(ByRef Digito As String, ByRef Texto As TextBox)
        If InStr(1, "0123456789" & Chr(8), Digito) = 0 Then
            Digito = CChar("")
        End If
    End Sub

    Private Sub txtPasillos_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtPasillos.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtPasillos)
    End Sub

    Private Sub txtColumnas_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtColumnas.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtColumnas)
    End Sub

    Private Sub txtNiveles_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtNiveles.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtNiveles)
    End Sub
End Class