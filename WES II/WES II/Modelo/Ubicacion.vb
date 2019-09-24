Public Class Ubicacion

    Public Shared Function listarPasillosSector(ByVal Sector As String) As DataTable
        With _conexion
            .prepararSP("SP_ListarPasillosSector")
            .agregarCadena("@NombreSector", Sector)
        End With
        Return _conexion.ejecutarSP_DataTable
    End Function

    Public Shared Function listarColumnasSector(ByVal Sector As String, ByVal pasillo As Integer) As DataTable
        With _conexion
            .prepararSP("SP_ListarColumnasSector")
            .agregarCadena("@NombreSector", Sector)
            .agregarEntero("@Pasillo", pasillo)
        End With
        Return _conexion.ejecutarSP_DataTable
    End Function

    Public Shared Function guardarColumna(ByVal Sector As String, ByVal Pasillo As Integer, ByVal Niveles As Integer, ByVal Tipo_Ubicacion As Integer, ByVal Capacidad As Decimal) As String
        With _conexion
            .prepararSP("SP_AgregarColumnaUbi")
            .agregarCadena("@NombreSector", Sector)
            .agregarEntero("@Pasillo", Pasillo)
            .agregarEntero("@Niveles", Niveles)
            .agregarEntero("@Tipo_Ubicacion", Tipo_Ubicacion)
            .agregarDecimal("@Capacidad", Capacidad)
        End With

        Dim respuesta As String
        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha agregado correctamente la  nueva columna."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminarColumna(ByVal NombreSector As String, ByVal Pasillo As Integer, ByVal Columna As Integer) As String
        With _conexion
            .prepararSP("SP_EliminarColumna")
            .agregarCadena("@NombreSector", NombreSector)
            .agregarEntero("@Pasillo", Pasillo)
            .agregarEntero("@Columna", Columna)
        End With

        Dim respuesta As String
        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado correctamente la  columna indicada."
        End If

        Return respuesta

    End Function

    Public Shared Function eliminarUbicacion(ByVal ID_Ubicacion As Integer) As String
        With _conexion
            .prepararSP("SP_EliminarUbicacion")
            .agregarEntero("@ID_Ubicacion", ID_Ubicacion)
        End With

        Dim respuesta As String
        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado correctamente la  ubicación indicada."
        End If

        Return respuesta

    End Function

    Public Shared Function listarPorSector(ByVal idSector As Integer) As DataTable
        With _conexion
            .prepararSP("SP_ListarUbicacionesSector")
            .agregarEntero("@idSector", idSector)
        End With
        Return _conexion.ejecutarSP_DataTable
    End Function

    Public Shared Function modificarUbicacion(ByVal ID_Ubicacion As Integer, ByVal ID_TipoUbicacion As Integer, ByVal Pasillo As Integer, ByVal Columna As Integer, ByVal Nivel As Integer, ByVal Compartimiento As Integer, ByVal Capacidad As Decimal, ByVal Estado As Integer) As String
        With _conexion
            .prepararSP("SP_ModificarUbicacion")
            .agregarEntero("@ID_Ubicacion", ID_Ubicacion)
            .agregarEntero("@ID_Tipo_Ubicacion", ID_TipoUbicacion)
            .agregarEntero("@Pasillo", Pasillo)
            .agregarEntero("@Columna", Columna)
            .agregarEntero("@Nivel", Nivel)
            .agregarEntero("@Compartimiento", Compartimiento)
            .agregarEntero("@Estado", Estado)
            .agregarDecimal("@Capacidad", Capacidad)
        End With

        Dim respuesta As String
        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente la  nueva ubicación."
        End If

        Return respuesta
    End Function

End Class