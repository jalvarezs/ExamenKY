Public Class UsuariosCF

    Public Shared Function registrarUsuarioCF(
        ByVal nombre As String, ByVal apellido As String
        ) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorUsuarioCF")
            .agregarCadena("@nombre_", nombre)
            .agregarCadena("@apellido_", apellido)


            .agregarEntero("@accion", 1) ' Insertar



        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el usuario."
        End If

        Return respuesta
    End Function


    Public Shared Function listarUS_FACT() As DataTable
        _conexion.prepararSP("SP_ListarUsuariosFact")

        Return _conexion.ejecutarSP_DataTable()
    End Function




End Class
