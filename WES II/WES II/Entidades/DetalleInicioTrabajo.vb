Public Class EntidadInicioTrabajo
    Private _codigoGenerado As String

    Property IdInicioTrabajo As Integer
    Property TipoOrden As String
    Property EstadoOT As String
    Property IDCotizacion As Integer
    Property IDCotizacionDetalleItem As Integer
    Property CodigoOrdenTrabajo As String
    Property TituloOT As String
    Property DescripcionOT As String
    Property FechaInicioOT As Date
    Property FechaFinOT As Date
    Property LstDetallePersonal As List(Of InicioTrabajoDetallePersonal)
    Property LstDetalleMateriales As List(Of InicioTrabajoDetalleMaterial)
    Property LstDetalleOrdenesServcio As List(Of InicioTrabajoDetalleSOE)
    Property SecuenciaItems As Integer
    Property EstadoOperacion As String
    Public Property CodigoAutoGenerado() As String
        Get

            Dim codigoOT As String
            Dim codigoCoti As String
            Dim codigoCotizacionItem As String
            Dim codigoSecuencia As String

            codigoCoti = IDCotizacion.ToString("D" & 5)
            codigoCotizacionItem = IDCotizacionDetalleItem.ToString("D" & 5)
            codigoSecuencia = SecuenciaItems.ToString("D" & 5)
            codigoOT = "OT" & codigoCoti & "-" & codigoCotizacionItem & "-" & codigoSecuencia
            _codigoGenerado = codigoOT

            Return _codigoGenerado
        End Get
        Set(ByVal value As String)
            _codigoGenerado = value
        End Set
    End Property

    Public Sub New()
        LstDetallePersonal = New List(Of InicioTrabajoDetallePersonal)
        LstDetalleMateriales = New List(Of InicioTrabajoDetalleMaterial)
        LstDetalleOrdenesServcio = New List(Of InicioTrabajoDetalleSOE)
    End Sub
End Class
