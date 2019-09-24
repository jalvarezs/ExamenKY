Public Class Contenedor

    Public Shared Function listar() As DataTable
        Return _conexion.consultarSP("SP_ListarContenedores")
    End Function

    Public Shared Function buscarEtiqueta(ByVal inicioE As String) As DataTable
        _conexion.prepararSP("SP_BuscarContenedoresEtiqueta")
        _conexion.agregarCadena("@inicioE", inicioE)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function buscarMaterial(ByVal idMaterial As String) As DataTable
        _conexion.prepararSP("SP_BuscarContenedoresMaterial")
        _conexion.agregarEntero("@idMaterial", CInt(idMaterial) - 10000)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ActualizarCantidad(ByVal idMaterial As String, ByVal cantidad As Integer) As String
        _conexion.prepararSP("SP_ActualizaCantidadContenedor")
        _conexion.agregarEntero("@idContenedor", CInt(idMaterial) - 10000)
        _conexion.agregarEntero("@cantidad", cantidad)
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function obtenerSgteID() As Integer
        Return _conexion.consultarSP("SP_SgteID_Contenedor").Rows(0)(0)
    End Function

    Public Shared Function ubicar(ByVal idContenedor As Integer, ByVal idUbicacion As Integer)
        With _conexion
            .prepararSP("SP_UbicarContenedor")
            .agregarEntero("@idContenedor", idContenedor)
            .agregarEntero("@idUbicacion", idUbicacion)
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function registrar(ByVal tipoUbicacion As String, ByVal fechaCreacion As String, ByVal etiqueta As String, ByVal alto As String, ByVal ancho As String, ByVal calidad As String, ByVal superior As String) As String
        Dim respuesta As String
        Dim superiorInt As Integer
        If superior = "" Then
            superiorInt = 0
        End If
        With _conexion
            .prepararSP("SP_MantenedorContenedor")
            .agregarCadena("@fechaCreacion", fechaCreacion)
            .agregarEntero("@idTipoUbicacion", CInt(tipoUbicacion))
            .agregarCadena("@etiqueta", etiqueta)
            .agregarCadena("@calidad", calidad)
            .agregarEntero("@superior", superiorInt)
            .agregarDecimal("@ancho", CDec(ancho))
            .agregarDecimal("@alto", CDec(alto))
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo contenedor."
        End If

        Return respuesta
    End Function

    Public Shared Function ListarDetalles(ByVal _id As String) As DataTable
        Try
            Dim id As Integer = CInt(_id) - 10000
            _conexion.prepararSP("SP_ListarDetalleContenedor")
            _conexion.agregarEntero("@id", id)
            Return _conexion.ejecutarSP_DataTable()

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function eliminar(ByVal id As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorContenedor")
            .agregarEntero("@idContenedor", CInt(id) - 10000)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado el contenedor indicado."
        End If
        Return respuesta
    End Function

    Public Shared Function trasladarStock(ByVal Id_Origen As String, ByVal Id_Destino As String, ByVal Id_Material As String, ByVal Cantidad As String) As String
        _conexion.prepararSP("SP_TrasladarStock")
        _conexion.agregarEntero("@Id_Origen", CInt(Id_Origen))
        _conexion.agregarEntero("@Id_Destino", CInt(Id_Destino))
        _conexion.agregarEntero("@Id_Material", CInt(Id_Material))
        _conexion.agregarEntero("@cantidad", CInt(Cantidad))
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function buscarContenedorPorEtiqueta(ByVal _etiqueta As String) As DataTable
        Try

            _conexion.prepararSP("SP_Buscar_Contenedor_x_Etiqueta")
            _conexion.agregarCadena("@etiqueta", _etiqueta)
            Return _conexion.ejecutarSP_DataTable()

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function listarDocumentosContenedor(ByVal _idContenedor As Integer, ByVal _idMaterial As Integer) As DataTable
        Try

            _conexion.prepararSP("SP_Listar_Documentos_Contenedor")
            _conexion.agregarEntero("@idMaterial", _idMaterial)
            _conexion.agregarEntero("@idContenedor", _idContenedor)
            Return _conexion.ejecutarSP_DataTable()

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
