Public Class ExamOrdenServicio

    Dim txtOrdenServicio As TextBox
    Property IdOrdenServicio As String
    Property IdCotizacion As Integer
    Dim sinAceptar As Boolean = True
    Property InicioTrab_Detalle_OSE As InicioTrabajoDetalleSOE

    Sub New(ByVal _idCotizacion As Integer, ByRef _txtOrdenServicio As TextBox)
        Try
            InitializeComponent()

            txtOrdenServicio = _txtOrdenServicio
            IdCotizacion = _idCotizacion

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ExamOrdenServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla(IdCotizacion, 0)
    End Sub


    Private Sub ActualizarTabla(ByVal idCotizacion As Integer, ByVal ordenServicio As Integer)
        Try
            Dim dtServicioExternos As DataTable
            dtServicioExternos = Cotizacion.ExaminarServicioExterno(idCotizacion, ordenServicio)
            dgvOrdenServicio.DataSource = dtServicioExternos
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer

        Try
            If dgvOrdenServicio.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvOrdenServicio.CurrentRow.Index
            End If

            sinAceptar = False

            IdOrdenServicio = dgvOrdenServicio.Item(0, row).Value.ToString()
            txtOrdenServicio.Text = dgvOrdenServicio.Item(0, row).Value.ToString()

            'Set CotizacionDetalleOSE
            InicioTrab_Detalle_OSE = New InicioTrabajoDetalleSOE
            InicioTrab_Detalle_OSE.ID_Cotizacion = IdCotizacion
            InicioTrab_Detalle_OSE.Orden_Servicio = dgvOrdenServicio.Item(0, row).Value.ToString()
            InicioTrab_Detalle_OSE.ID_Orden_Servicio = dgvOrdenServicio.Item(0, row).Value - 10000
            InicioTrab_Detalle_OSE.Detalle = dgvOrdenServicio.Item(3, row).Value
            InicioTrab_Detalle_OSE.Cantidad = dgvOrdenServicio.Item(4, row).Value
            InicioTrab_Detalle_OSE.Precio_Unitario = dgvOrdenServicio.Item(5, row).Value
            InicioTrab_Detalle_OSE.Total = dgvOrdenServicio.Item(6, row).Value

            Me.Close()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ExamCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtOrdenServicio.Text = ""
            IdOrdenServicio = ""
        End If
    End Sub

    Private Sub txtNroOrdenServicio_TextChanged(sender As Object, e As EventArgs) Handles txtNroOrdenServicio.TextChanged
        Try
            Dim ordenServicio As Integer
            If txtNroOrdenServicio.Text.Trim.Equals("") Then
                ordenServicio = 0
            Else
                ordenServicio = CInt(txtNroOrdenServicio.Text.Trim) - 10000
            End If

            ActualizarTabla(IdCotizacion, ordenServicio)

        Catch ex As Exception

        End Try
    End Sub

    Public Function GetOrdenServicio() As InicioTrabajoDetalleSOE
        Return InicioTrab_Detalle_OSE
    End Function

End Class