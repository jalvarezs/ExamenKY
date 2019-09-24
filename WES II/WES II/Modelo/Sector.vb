Public Class Sector
    ' Lista total de sectores
    Public Shared Function listarSectores() As DataTable
        Return _conexion.consultarSP("SP_ListarSectores")
    End Function

    Public Shared Function registrar(ByVal nombre As String, ByVal codigo As String, ByVal almacen As Integer, ByVal estado As Integer, ByVal pasillos As Integer, ByVal columnas As Integer, ByVal niveles As Integer) As String
        Dim respuesta As String

        'OJO: Al registrar un sector un disparador en la tabla sectores graba las ubicaciones y para el tipo de ubicacion lo pasa fijo en el disparador.


        With _conexion
            .prepararSP("SP_MantenedorSector")
            .agregarCadena("@Nombre", nombre)
            .agregarCadena("@Codigo", codigo)
            .agregarEntero("@IdAlmacen", almacen)
            .agregarEntero("@Estado", estado)
            .agregarEntero("@Pasillos", pasillos)
            .agregarEntero("@Columnas", columnas)
            .agregarEntero("@Niveles", niveles)
            .agregarEntero("@Accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo sector."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal id As Integer, ByVal nombre As String, ByVal codigo As String, ByVal almacen As Integer, ByVal estado As Integer, ByVal pasillos As Integer, ByVal columnas As Integer, ByVal niveles As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorSector")
            .agregarEntero("@IdSector", id)
            .agregarCadena("@Nombre", nombre)
            .agregarCadena("@Codigo", codigo)
            .agregarEntero("@IdAlmacen", almacen)
            .agregarEntero("@Estado", estado)
            .agregarEntero("@Pasillos", pasillos)
            .agregarEntero("@Columnas", columnas)
            .agregarEntero("@Niveles", niveles)
            .agregarEntero("@Accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente el nuevo sector."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal id As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorSector")
            .agregarEntero("@IdSector", id)
            .agregarEntero("@Accion", 3) ' Eliminar
        End With
        'Dim rs As String = _conexion.ejecutarSP_String().ToString()


        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado el sector indicado"
        End If

        Return respuesta
    End Function
End Class