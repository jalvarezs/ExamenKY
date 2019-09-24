Public Class Proyecto

    ' Lista de proyectos
    Public Shared Function listar() As DataTable
        Return _conexion.consultarSP("SP_ListarProyectos")
    End Function

    Public Shared Function buscar(ByVal nombre As String) As DataTable
        _conexion.prepararSP("SP_BuscarProyecto")
        _conexion.agregarCadena("@nombre", nombre)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    ' Sgte id de proyectos
    Public Shared Function obtenerSgteID() As DataTable
        Return _conexion.consultarSP("SP_SgteID_Proyecto")
    End Function

    ' Código autogenerado de los proyectos
    Public Shared Function codificarProyecto() As DataTable
        Return _conexion.consultarSP("SP_CodificarProyecto")
    End Function

    Public Shared Function registrar(ByVal Nombre As String, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorProyecto")
            .agregarCadena("@Nombre", Nombre)
            .agregarFecha("@FechaInicio", FechaInicio)
            .agregarFecha("@FechaFin", FechaFin)
            .agregarCadena("@Descripcion", Descripcion)
            .agregarEntero("@Accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo proyecto."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal IdProyecto As Integer, ByVal Nombre As String, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Descripcion As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorProyecto")
            .agregarEntero("@IdProyecto", IdProyecto)
            .agregarCadena("@Nombre", Nombre)
            .agregarFecha("@FechaInicio", FechaInicio)
            .agregarFecha("@FechaFin", FechaFin)
            .agregarCadena("@Descripcion", Descripcion)
            .agregarEntero("@Accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente el nuevo proyecto."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal IdProyecto As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorProyecto")
            .agregarEntero("@IdProyecto", IdProyecto)
            .agregarEntero("@Accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado el proyecto indicado."
        End If

        Return respuesta
    End Function

End Class
