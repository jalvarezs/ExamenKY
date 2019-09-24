Public Class Familia

    Public Shared Function ListarFamiliasGrid() As DataTable
        _conexion.prepararSP("SP_Listar_Familias_Grid")
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ListarSubFamiliasGrid() As DataTable
        _conexion.prepararSP("SP_Listar_SubFamilias_Grid")
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ListarFamilias() As DataTable
        _conexion.prepararSP("SP_Listar_Familias")
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function RegistrarFamilia(ByVal nombre As String, ByVal descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorFamilia_Material")
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente la Familia de Materiales"
        End If

        Return respuesta
    End Function

    Public Shared Function ModificarFamilia(ByVal id As String, ByVal nombre As String, ByVal descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorFamilia_Material")
            .agregarEntero("@idFamilia", id)
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente la Familia de Materiales."
        End If

        Return respuesta
    End Function

    Public Shared Function EliminarFamilia(ByVal id As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorFamilia_Material")
            .agregarEntero("@idFamilia", id)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado correctamente la Familia seleccionada."
        End If

        Return respuesta
    End Function

    Public Shared Function RegistrarSubFamilia(ByVal idFamilia As Integer, ByVal nombre As String, ByVal descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_Mantener_Sub_Familia")
            .agregarEntero("@idFamilia", idFamilia)
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente la Sub-Familia"
        End If

        Return respuesta
    End Function

    Public Shared Function ModificarSubFamilia(ByVal idSubFamilia As Integer, ByVal idFamilia As Integer, ByVal nombre As String, ByVal descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_Mantener_Sub_Familia")
            .agregarEntero("@idSubFamilia", idSubFamilia)
            .agregarEntero("@idFamilia", idFamilia)
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente la Sub-Familia"
        End If

        Return respuesta
    End Function

    Public Shared Function EliminarSubFamilia(ByVal idSubFamilia As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_Mantener_Sub_Familia")
            .agregarEntero("@idSubFamilia", idSubFamilia)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado correctamente la Sub-Familia"
        End If

        Return respuesta
    End Function

    Public Shared Function ListarSubFamilias(ByVal idFamilia As Integer) As DataTable
        With _conexion
            .prepararSP("SP_Listar_SubFamilia_Por_Familia")
            .agregarEntero("@idFamilia", idFamilia)
        End With

        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ObtenerSubFamiliaPorId(ByVal idSubFamilia As Integer) As DataTable
        With _conexion
            .prepararSP("SP_Obtener_SubFamilia_Por_Id")
            .agregarEntero("@idSubFamilia", idSubFamilia)
        End With

        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ExaminarFamiliaSubFamilia(ByVal nombre As String) As DataTable
        _conexion.prepararSP("SP_Examinar_Familia_SubFamilia")
        _conexion.agregarCadena("@nombre", nombre)
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
