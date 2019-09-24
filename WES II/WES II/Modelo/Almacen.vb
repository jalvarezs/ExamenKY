Public Class Almacen

    ' Listado de almacenes 
    Public Shared Function listar()
        Return _conexion.consultarSP("SP_ListarAlmacenes")
    End Function

    Public Shared Function buscar(ByVal nombre As String) As DataTable
        _conexion.prepararSP("SP_BuscarAlmacen")
        _conexion.agregarCadena("@nombre", nombre)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    ' Lista de sectores de un determinado almacén
    Public Shared Function listarSectoresAlmacen(ByVal id As String) As DataTable
        _conexion.prepararSP("SP_ListarSectoresAlmacen")
        _conexion.agregarCadena("@IdAlmacen", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function registrar(ByVal Nombre As String, ByVal Tipo As Integer, ByVal Observaciones As String, ByVal Estado As Integer, ByVal Ciudad As Integer, ByVal Proyecto As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorAlmacen")
            .agregarCadena("@Nombre", Nombre)
            .agregarEntero("@Tipo ", Tipo)
            .agregarCadena("@Observaciones", Observaciones)
            .agregarEntero("@Estado", Estado)
            .agregarEntero("@IdCiudad", Ciudad)
            .agregarEntero("@IdProyecto", Proyecto)
            .agregarEntero("@IdUsuario", _usuario)
            .agregarEntero("@Accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo almacén."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal IdAlmacen As Integer, ByVal Nombre As String, ByVal Tipo As Integer, ByVal Observaciones As String, ByVal Estado As Integer, ByVal Ciudad As Integer, ByVal Proyecto As Integer, ByVal Usuario As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorAlmacen")
            .agregarEntero("@IdAlmacen", IdAlmacen)
            .agregarCadena("@Nombre", Nombre)
            .agregarEntero("@Tipo ", Tipo)
            .agregarCadena("@Observaciones", Observaciones)
            .agregarEntero("@Estado", Estado)
            .agregarEntero("@IdCiudad", Ciudad)
            .agregarEntero("@IdProyecto", Proyecto)
            .agregarEntero("@IdUsuario", Usuario)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente el nuevo almacén."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal IdAlmacen As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorAlmacen")
            .agregarEntero("@IdAlmacen", IdAlmacen)
            .agregarEntero("@Accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado el almacén indicado"
        End If

        Return respuesta
    End Function

End Class
