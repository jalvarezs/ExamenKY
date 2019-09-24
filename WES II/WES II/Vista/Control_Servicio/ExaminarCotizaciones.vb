Public Class ExaminarCotizaciones

    Dim txtProforma, txtCliente, txtTrabajo, txtFecha, txtContacto As TextBox
    Dim txtFechaInicioPlanificada, txtFechaFinPlanificada, txtHoraInicioPlanificada,
        txtHoraFinPlanificada, txtEstado As TextBox

    Property idCotizacion As Integer
    Property idCliente As Integer
    Property Estado As String
    Property trabajo As String
    Property fecha As Date
    Property hora As TimeSpan
    Property contacto As String
    Property duracionHoras As Integer

    Dim sinAceptar As Boolean = True

    Sub New(ByRef _txtProforma As TextBox, ByRef _txtCliente As TextBox,
            ByRef _txtTrabajo As TextBox, ByRef _txtFecha As TextBox,
            ByRef _txtContacto As TextBox, ByRef _txtFechaInicioPlanificada As TextBox,
            _txtFechaFinPlanificada As TextBox, _txtHoraInicioPlanificada As TextBox,
            _txtHoraFinPlanificada As TextBox, _txtEstado As TextBox)
        Try

            InitializeComponent()
            txtProforma = _txtProforma
            txtCliente = _txtCliente
            txtTrabajo = _txtTrabajo
            txtFecha = _txtFecha
            txtContacto = _txtContacto
            txtFechaInicioPlanificada = _txtFechaInicioPlanificada
            txtFechaFinPlanificada = _txtFechaFinPlanificada
            txtHoraInicioPlanificada = _txtHoraInicioPlanificada
            txtHoraFinPlanificada = _txtHoraFinPlanificada
            txtEstado = _txtEstado

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Sub New(ByRef _txtProforma As TextBox)
        Try

            InitializeComponent()
            txtProforma = _txtProforma

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ExaminarCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTablaCompleta()
    End Sub

    Private Sub actualizarTabla(ByVal codigo As Integer)
        Try
            Dim cotizaciones As DataTable
            cotizaciones = Cotizacion.Buscar(codigo)
            dgvCotizaciones.DataSource = cotizaciones
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarTablaCompleta()
        Dim cotizaciones As DataTable
        cotizaciones = Cotizacion.Listar()
        dgvCotizaciones.DataSource = cotizaciones
    End Sub

    Private Sub txtNombreProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        actualizarTabla(txtCodigo.Text)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer
        Dim duracionDias As Integer

        Try

            If dgvCotizaciones.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvCotizaciones.CurrentRow.Index
            End If

            sinAceptar = False

            idCotizacion = dgvCotizaciones.Item(0, row).Value.ToString

            If txtProforma IsNot Nothing Then
                txtProforma.Text = dgvCotizaciones.Item(0, row).Value.ToString
            End If

            If txtCliente IsNot Nothing Then
                txtCliente.Text = dgvCotizaciones.Item(1, row).Value.ToString
            End If

            If txtTrabajo IsNot Nothing Then
                txtTrabajo.Text = dgvCotizaciones.Item(3, row).Value.ToString
                trabajo = txtTrabajo.Text
            End If

            If txtFecha IsNot Nothing Then
                txtFecha.Text = Format(dgvCotizaciones.Item(2, row).Value, "dd/MM/yyyy")
                fecha = txtFecha.Text
            End If

            If txtContacto IsNot Nothing Then
                txtContacto.Text = dgvCotizaciones.Item(4, row).Value.ToString
                contacto = txtContacto.Text
            End If

            If txtFechaInicioPlanificada IsNot Nothing Then
                txtFechaInicioPlanificada.Text = Format(dgvCotizaciones.Item(2, row).Value, "dd/MM/yyyy")
                duracionDias = dgvCotizaciones.Item(5, row).Value

                If txtFechaFinPlanificada IsNot Nothing Then
                    txtFechaFinPlanificada.Text = DateAdd(DateInterval.Day, duracionDias, dgvCotizaciones.Item(2, row).Value)
                End If

            End If

            If txtHoraInicioPlanificada IsNot Nothing Then
                txtHoraInicioPlanificada.Text = Format(dgvCotizaciones.Item(6, row).Value, "hh:mm:ss tt")
                duracionHoras = dgvCotizaciones.Item(7, row).Value
                If txtHoraFinPlanificada IsNot Nothing Then
                    txtHoraFinPlanificada.Text = Format(DateAdd(DateInterval.Hour, duracionHoras, dgvCotizaciones.Item(6, row).Value), "hh:mm:ss tt")
                End If
            End If


            idCliente = dgvCotizaciones.Item(8, row).Value

            If txtEstado IsNot Nothing Then
                txtEstado.Text = dgvCotizaciones.Item(9, row).Value
            End If

            Me.Close()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ExaminarCotizaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If sinAceptar Then
            txtProforma.Text = ""
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        actualizarTablaCompleta()
    End Sub
    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

End Class