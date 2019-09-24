Public Class ModifInicioTrabajo
    Private inicioTrabajo, codigoCotizacion As Integer
    Private titulo As String
    Private idCotizacion As Integer

    Sub New(ByVal _inicioTrabajo As Integer, ByVal _titulo As String, ByVal _codigoCotizacion As Integer)

        InitializeComponent()

        inicioTrabajo = _inicioTrabajo
        titulo = _titulo
        codigoCotizacion = _codigoCotizacion

    End Sub

    Private Sub ModifInicioTrabajo_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtCodigo.Text = inicioTrabajo
        txtCotizacionActual.Text = codigoCotizacion
        txtTitulo.Text = titulo
    End Sub

    Private Sub btnExamCotizacion_Click(sender As Object, e As EventArgs) Handles btnExamCotizacion.Click
        Dim form As New ExamCotizacion(txtCotizacion)
        form.ShowDialog()
        cargarDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub cargarDatos()
        ' Carga desde la BD los datos de la cotización seleccionada
        If txtCotizacion.Text = "" Then
            Return
        End If

        idCotizacion = CInt(txtCotizacion.Text) - 10000

        Dim unaCotizacion As New Cotizacion()
        unaCotizacion.Obtener(idCotizacion)

        ' cargarDetallesPrevios()
    End Sub

End Class