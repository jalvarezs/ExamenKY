Public Class Perfil
    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT ID_Perfil as Código, Nombre, Descripcion FROM Perfil")
    End Function

    Public Shared Function registrar(ByVal nombre As String, ByVal descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorPerfil")
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo perfil de usuario."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal id As String, ByVal nombre As String, ByVal descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorPerfil")
            .agregarEntero("@idPerfil", id)
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente el perfil."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal id As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorPerfil")
            .agregarEntero("@idPerfil", id)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado correctamente el perfil indicado."
        End If

        Return respuesta
    End Function

    Public Shared Function listarBotones(ByVal ID_Perfil As Integer)
        With _conexion
            .prepararSP("SP_SinBotones")
            .agregarEntero("@ID_Perfil", ID_Perfil)
        End With
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function listarPermisos(ByVal ID_Perfil As Integer)
        With _conexion
            .prepararSP("SP_ConBotones")
            .agregarEntero("@ID_Perfil", ID_Perfil)
        End With
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function masAcceso(ByVal ID_Perfil As Integer, ByVal Boton As String)
        With _conexion
            .prepararSP("SP_MasAcceso")
            .agregarEntero("@ID_Perfil", ID_Perfil)
            .agregarCadena("@Boton", Boton)
        End With
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function menosAcceso(ByVal ID_Perfil As Integer, ByVal Boton As String)
        With _conexion
            .prepararSP("SP_MenosAcceso")
            .agregarEntero("@ID_Perfil", ID_Perfil)
            .agregarCadena("@Boton", Boton)
        End With
        Return _conexion.ejecutarSP_String()
    End Function
End Class