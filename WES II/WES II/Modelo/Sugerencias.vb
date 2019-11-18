Public Class Sugerencias
    Public Shared Function Registrar(ByVal nombre As String, ByVal nomprov As String,
                                    ByVal preciorefe As String, ByVal ruc As String, ByVal direc As String,
                                    ByVal idMaterial As String, ByVal cantsol As String, ByVal idProv As String, fecha As String)

        Dim respuesta As String

        Dim _idMaterial As Integer = UtilConvertidor.GetInteger(idMaterial)
        Dim _idProv As Integer = UtilConvertidor.GetInteger(idProv)


        With _conexion
            .prepararSP("SP_MantenerSugerenciaMat")
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@NombreProv", nomprov)
            .agregarDecimal("@preciorefe", UtilConvertidor.GetDecimal(preciorefe))
            .agregarCadena("@ruc", ruc)
            .agregarCadena("@Direccion", direc)
            .agregarCadena("@idMaterial", idMaterial)
            .agregarEntero("@cantsoli", UtilConvertidor.GetInteger(cantsol))
            .agregarFecha("@fecha", CDate(fecha))
            .agregarCadena("@id_proveedor", idProv)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()

        If respuesta Is "" Then
            'respuesta = "Se ha registrado correctamente el nuevo producto."
        Else
            respuesta = "[ERROR] " & respuesta

            Throw New Exception(respuesta)

        End If

        Return respuesta
    End Function

    Public Shared Function listarPorFechas(ByVal fi As String, ByVal ff As String) As DataTable
        _conexion.prepararSP("SP_ListarSugerenciasPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function eliminarSugerencia(ByVal ID_RUC As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenerSugerenciaMat")
            .agregarEntero("@ruc", ID_RUC)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        Return respuesta
    End Function
End Class
