Public Class Marca
    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Marca")
    End Function

    Public Shared Function registrar(ByVal nombre As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorMarca")
            .agregarCadena("@nombre", nombre)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente la nueva marca de productos."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal id As String, ByVal nombre As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorMarca")
            .agregarEntero("@idMarca", CInt(id))
            .agregarCadena("@nombre", nombre)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente la marca de productos."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal id As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorMarca")
            .agregarEntero("@idMarca", CInt(id))
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado correctamente la marca seleccionada."
        End If

        Return respuesta
    End Function
End Class
