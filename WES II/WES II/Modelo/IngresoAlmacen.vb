Public Class IngresoAlmacen

    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Ingreso_Almacen")
    End Function

    ' Falta implementar todo lo que es listar ingresos
    Public Shared Function listarPorFechas(ByVal fi As String, ByVal ff As String) As DataTable
        _conexion.prepararSP("SP_ListarIngresosPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function listarDetalles(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarDetallesPorIngreso")
        _conexion.agregarEntero("@idIngreso", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function obtenerUltimoID() As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(ID_Ingreso) FROM Ingreso_Almacen").Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(ID_Ingreso) FROM Ingreso_Almacen").Rows(0)(0))
        End If
        Return 0
    End Function

    Public Shared Function registrarIngreso(ByVal Fecha As String,
                                            ByVal ID_OrdenCompra As String,
                                            ByVal ID_Usuario As String,
                                            ByVal numeroDocumento As String,
                                            ByVal tipoDocumento As String) As String

        With _conexion
            .prepararSP("SP_MantenedorIngreso")
            .agregarFecha("@Fecha", CDate(Fecha))
            .agregarEntero("@idOrdenCompra", CInt(ID_OrdenCompra))
            .agregarEntero("@idUsuario ", CInt(ID_Usuario))

            .agregarCadena("@numDocumento ", numeroDocumento)
            .agregarCadena("@tipoDocumento ", tipoDocumento)

            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function registrarDetalleIngreso(ByVal ID_Ingreso As String, ByVal ID_Material As String,
                                            ByVal Cantidad_Recibida As String, ByVal precio As String, ByVal ID_Contenedor As String, ByVal fecha As DateTime) As String
        Dim idContenedor As Integer
        Try
            idContenedor = CInt(ID_Contenedor) - 10000
        Catch ex As Exception
            idContenedor = 0
        End Try

        With _conexion
            .prepararSP("SP_MantenedorDetalleIngreso")
            .agregarEntero("@idIngreso", CInt(ID_Ingreso))
            .agregarEntero("@idMaterial", CInt(ID_Material))
            .agregarEntero("@CantidadRec ", CInt(Cantidad_Recibida))
            .agregarDecimal("@precio", CDec(precio))

            If idContenedor <> 0 Then
                .agregarEntero("@idContenedor", idContenedor)
            End If
            .agregarFechaHora("@fecha", fecha)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()

    End Function

    Public Shared Function ActualizarEstadoOrdenCompra(ByVal idOC As Integer, ByVal estado As String) As String

        With _conexion
            .prepararSP("SP_Actualizar_Estado_OC")
            .agregarEntero("@idOC", CInt(idOC))
            .agregarCadena("@estado ", estado)
        End With

        Return _conexion.ejecutarSP_String()
    End Function

End Class
