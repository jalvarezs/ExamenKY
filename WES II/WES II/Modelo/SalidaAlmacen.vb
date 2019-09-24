Public Class SalidaAlmacen

    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Salida_Almacen")
    End Function

    Public Shared Function listarPorFechas(ByVal fi As String, ByVal ff As String, ByVal NumDocumento As String, ByVal TipoDocumento As String) As DataTable
        _conexion.prepararSP("SP_ListarSalidasPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        _conexion.agregarCadena("@NumeroDocumento", NumDocumento)
        _conexion.agregarCadena("@tipoDocumento", TipoDocumento)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function listarDetalles(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarDetallesPorSalida")
        _conexion.agregarEntero("@idSalida", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function obtenerUltimoID() As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(ID_Salida) FROM Salida_Almacen").Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(ID_Salida) FROM Salida_Almacen").Rows(0)(0))
        End If
        Return 0
    End Function

    Public Shared Function RegistrarSalida(ByVal Fecha As String, ByVal ID_Requerimiento As String,
                                            ByVal ID_Usuario As String, ByVal NumDocumento As String,
                                            ByVal TipoDocumento As String) As String

        With _conexion
            .prepararSP("SP_MantenedorSalida")
            .agregarFecha("@Fecha", CDate(Fecha))
            .agregarEntero("@idRequerimiento", CInt(ID_Requerimiento))
            .agregarEntero("@idUsuario ", CInt(ID_Usuario))
            .agregarCadena("@NumeroDocumento", NumDocumento)
            .agregarCadena("@tipoDocumento", TipoDocumento)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function RegistrarDetalleSalida(ByVal ID_Salida As String, ByVal ID_Material As Integer,
                                            ByVal Cantidad_Recibida As String, ByVal idContenedor As String) As String

        With _conexion
            .prepararSP("SP_MantenedorDetalleSalida")
            .agregarEntero("@idSalida", UtilConvertidor.GetInteger(ID_Salida))
            .agregarEntero("@idMaterial", ID_Material)
            .agregarEntero("@CantidadRec ", UtilConvertidor.GetInteger(Cantidad_Recibida))

            If idContenedor <> "" Then .agregarEntero("@idContenedor", UtilConvertidor.GetInteger(idContenedor) - 10000)

            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function ObtenerCantidadDisponibleContenedor(ByVal idRequerimiento As Integer, ByVal idContenedor As Integer, ByVal idMaterial As Integer) As DataSet
        _conexion.prepararSP("SP_Obtener_Cant_Disponible_Contenedor")
        _conexion.agregarEntero("@idRequerimiento", idRequerimiento)
        _conexion.agregarEntero("@idContenedor", idContenedor)
        _conexion.agregarEntero("@idMaterial", idMaterial)
        Return _conexion.ejecutarSP_DataSet()
    End Function

    Public Shared Function ActualizarRequerimiento(ByVal idRequerimiento As Integer, ByVal estado As String) As String

        With _conexion
            .prepararSP("SP_Actualizar_Requerimiento")
            .agregarEntero("@idReq", CInt(idRequerimiento))
            .agregarCadena("@estado ", estado)
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function BuscarSalidaAlmacen(ByVal numeroDocumento As String) As DataTable
        _conexion.prepararSP("SP_Salida_Material_x_NumDoc")
        _conexion.agregarCadena("@NumeroDocumento", numeroDocumento)
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
