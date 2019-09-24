Public Class ExamCotizacion

    Dim txtCodigoCotizacion As TextBox
    Property empresa As String = String.Empty

    Property ruc As String
    Dim sinAceptar As Boolean = True

    Sub New(ByRef txtCotizacion As TextBox)
        InitializeComponent()
        txtCodigoCotizacion = txtCotizacion
    End Sub
    Private Sub Inicampos(ByVal emp As String, ByVal ruc2 As String)
        empresa = emp
        ruc = ruc2
    End Sub
    Private Sub ExamCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla()
    End Sub

    Private Sub ActualizarTabla()
        Try
            dgvCotizaciones.DataSource = Cotizacion.ListarCotizacion(dtpInicio.Text, dtpFin.Text, UtilConstantes.Cotizacion.Estado.Autorizada)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim row As Integer

            If dgvCotizaciones.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvCotizaciones.CurrentRow.Index
            End If

            sinAceptar = False
            txtCodigoCotizacion.Text = dgvCotizaciones.Item(0, row).Value.ToString()
            Inicampos(dgvCotizaciones.Item(1, row).Value.ToString(), dgvCotizaciones.Item(2, row).Value.ToString())
            Me.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ExamCotizacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtCodigoCotizacion.Text = ""
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ActualizarTabla()
        Catch ex As Exception

        End Try

    End Sub

End Class