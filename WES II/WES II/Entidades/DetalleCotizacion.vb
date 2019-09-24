Public Class DetalleCotizacion

    Property IDCotizacion As Integer
    Property IDDetalleItem As Integer
    Property Titulo As String
    Property DescripcionTrabajo As String
    Property LstDetallePersonal As List(Of CotizacionDetallePersonal)
    Property LstDetalleMateriales As List(Of CotizacionDetalleMaterial)


    Public Sub New()
        LstDetallePersonal = New List(Of CotizacionDetallePersonal)
        LstDetalleMateriales = New List(Of CotizacionDetalleMaterial)
    End Sub
End Class
