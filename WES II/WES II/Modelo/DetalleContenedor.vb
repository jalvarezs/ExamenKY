Public Class DetalleContenedor
    Public Shared Function registrar(ByVal idContenedor As String, ByVal idMaterial As String, ByVal cantidad As String, ByVal estadoMercancia As String) As String
        Dim respuesta As String
        With _conexion
            .prepararSP("SP_MantenedorDetalle_Contenedor")
            .agregarEntero("@idContenedor", CInt(idContenedor) - 10000)
            .agregarEntero("@idMaterial", CInt(idMaterial) - 10000)
            .agregarEntero("@cantidad", CDec(cantidad))
            .agregarFechaHora("@fecha", DateTime.Now())
            .agregarCadena("@estadoMercancia", estadoMercancia)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo detalle."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal idContenedor As String, ByVal idMaterial As String, ByVal cantidad As String, ByVal estadoMercancia As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorDetalle_Contenedor")
            .agregarEntero("@idContenedor", CInt(idContenedor) - 10000)
            .agregarEntero("@idMaterial", CInt(idMaterial) - 10000)
            .agregarEntero("@cantidad", CDec(cantidad))
            .agregarFechaHora("@fecha", DateTime.Now())
            .agregarCadena("@estadoMercancia", estadoMercancia)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente el detalle."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal idContenedor As String, ByVal idMaterial As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorDetalle_Contenedor")
            .agregarEntero("@idContenedor", CInt(idContenedor) - 10000)
            .agregarEntero("@idMaterial", CInt(idMaterial) - 10000)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado el detalle indicado."
        End If
        Return respuesta
    End Function

    Public Shared Function ObtenerDetalleContenedorPorMaterial(ByVal idContenedor As String, ByVal idMaterial As String) As DataTable

        _conexion.prepararSP("SP_Get_Detalle_Contenedor_x_Material")
        _conexion.agregarEntero("@idContenedor", CInt(idContenedor) - 10000)
        _conexion.agregarEntero("@idMaterial", CInt(idMaterial) - 10000)

        Dim dt As DataTable = _conexion.ejecutarSP_DataTable()

        Return dt
    End Function

End Class
