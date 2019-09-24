Public Class InicioTrabajo

    Public Shared Function Buscar(ByVal cotizacion As Integer) As DataTable
        _conexion.prepararSP("SP_BuscarInicioTrabajo")
        _conexion.agregarEntero("@idCotizacion", cotizacion)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function listarPorFechas(ByVal fi As String, ByVal ff As String) As DataTable
        _conexion.prepararSP("SP_ListarIniciosPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function obtenerSgteID() As Integer
        Return _conexion.consultarSP("SP_SgteID_InicioTrabajo").Rows(0)(0)
    End Function

    Public Shared Function obtenerUltimoID() As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(ID_Inicio_Trabajo) FROM Inicio_Trabajo").Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(ID_Inicio_Trabajo) FROM Inicio_Trabajo").Rows(0)(0))
        End If
        Return 0
    End Function

    Public Shared Function ListarDetalles(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarDetallesPorInicio")
        _conexion.agregarEntero("@idInicioTrabajo", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ListarPersonal(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarPersonalPorInicio")
        _conexion.agregarEntero("@idInicioTrabajo", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function RegistrarInicioTrabajo(ByVal idCotizacion As Integer,
                                                  ByVal tituloOT As String,
                                                  ByVal fechaI As String,
                                                  ByVal fechaF As String,
                                                  ByVal idCotizacionDetalleItem As Integer,
                                                  ByVal codigo As String,
                                                  ByVal estado As String,
                                                  ByVal descripcionOT As String,
                                                  ByVal tipoOrden As Integer) As String
        With _conexion
            .prepararSP("SP_MantenedorInicio")
            .agregarEntero("@idCotizacion", idCotizacion)
            .agregarEntero("@idCotizacionDetalleItem", idCotizacionDetalleItem)
            .agregarCadena("@titulo", tituloOT)
            .agregarFecha("@fechaInicio", CDate(fechaI))
            .agregarFecha("@fechaFin", CDate(fechaF))
            .agregarCadena("@estado", estado)
            .agregarCadena("@codigo", codigo)
            .agregarCadena("@descripcionOT", descripcionOT)
            .agregarEntero("@tipoOrden", tipoOrden)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function RegistrarDetalleMateriales(ByVal idInicioTrabajo As Integer, ByVal idMaterial As Integer, ByVal cantidad As String, ByVal idDetalleItem As Integer,
                                                      ByVal precioUnit As Decimal, ByVal dias As Integer, ByVal horas As Integer, ByVal total As Decimal) As String
        With _conexion
            .prepararSP("SP_MantenedorDetalleInicio")
            .agregarEntero("@idInicioTrabajo", idInicioTrabajo)
            .agregarEntero("@idMaterial", idMaterial)
            .agregarEntero("@cantidad ", CInt(cantidad))
            .agregarEntero("@idDetalleItem ", idDetalleItem)
            .agregarDecimal("@precioUnit ", precioUnit)
            .agregarEntero("@dias ", dias)
            .agregarEntero("@horas ", horas)
            .agregarDecimal("@precioTotal ", total)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function RegistrarDetallePersonal(ByVal idInicioTrabajo As Integer, ByVal personal As String, ByVal cantidad As String, ByVal idDetalleItem As Integer,
                                                    ByVal dias As Integer, ByVal horas As Integer) As String
        With _conexion
            .prepararSP("SP_MantenedorPersonalInicio")
            .agregarEntero("@idInicioTrabajo", idInicioTrabajo)
            .agregarCadena("@personal", personal)
            .agregarEntero("@cantidad ", CInt(cantidad))
            .agregarEntero("@dias ", dias)
            .agregarEntero("@horas ", horas)
            .agregarEntero("@idDetalleItem ", idDetalleItem)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function RegistrarDetalleOrdenServicio(ByVal idInicioTrabajo As Integer, ByVal idDetalleItem As Integer, ByVal idServicioExterno As Integer) As String
        With _conexion
            .prepararSP("SP_Mantenedor_OSE_Inicio")
            .agregarEntero("@idInicioTrabajo", idInicioTrabajo)
            .agregarEntero("@idDetalleItem ", idDetalleItem)
            .agregarEntero("@idServicioExterno ", idServicioExterno)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function BusquedaOrdenTrabajo(ByVal fi As Date, ByVal ff As Date, ByVal idCliente As Integer, ByVal estado As String, ByVal tipoOt As Integer) As DataTable
        _conexion.prepararSP("SP_BusquedaOrdenTrabajo")
        _conexion.agregarFecha("@FechaInicio", fi)
        _conexion.agregarFecha("@FechaFin", ff)
        _conexion.agregarEntero("@Id_Cliente", idCliente)
        _conexion.agregarCadena("@Estado", estado)
        _conexion.agregarEntero("@tipoOT", tipoOt)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ExaminarInicioTrabajo() As DataTable
        _conexion.prepararSP("SP_Examinar_InicioTrabajo")
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
