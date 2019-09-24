Public Class ControlServicio
    Public Shared Function listar() As DataTable
        Return _conexion.consultarSP("SP_ListarControlServicios")
    End Function


    Public Shared Function registrar(ByVal idCliente As Integer, ByVal trabajo As String, ByVal fecha As Date,
                                     ByVal contacto As String, ByVal responsable As String,
                                     ByVal fechaInicioPlan As Date, ByVal horaInicioPlan As TimeSpan,
                                     ByVal fechaFinPlan As Date, ByVal horaFinPlan As TimeSpan,
                                     ByVal fechaInicioReal As Date, ByVal horaInicioReal As TimeSpan,
                                     ByVal fechaFinReal As Date, ByVal horaFinReal As TimeSpan,
                                     ByVal avance As Integer, ByVal retrasos As String, ByVal estado As String,
                                     ByVal nroProforma As Integer)
        With _conexion
            .prepararSP("SP_MantenedorControlServicios")
            .agregarCadena("@cliente", idCliente)
            .agregarCadena("@trabajo", trabajo)
            .agregarFecha("@fecha", CDate(fecha))
            .agregarCadena("@contactoCliente", contacto)
            .agregarCadena("@responsableEmpresa", responsable)
            .agregarFecha("@fechaInicioPlanificada", CDate(fechaInicioPlan))
            .agregarHora("@horaInicioPlanificada", horaInicioPlan)
            .agregarFecha("@fechaFinPlanificada", CDate(fechaFinPlan))
            .agregarHora("@horaFinPlanificada", horaFinPlan)
            .agregarFecha("@fechaInicioReal", CDate(fechaInicioReal))
            .agregarHora("@horaInicioReal", horaInicioReal)
            .agregarFecha("@fechaFinReal", CDate(fechaFinReal))
            .agregarHora("@horaFinReal", horaFinReal)
            .agregarEntero("@avance", CInt(avance))
            .agregarCadena("@retrasos", retrasos)
            .agregarCadena("@estado", estado)
            .agregarEntero("@nroProforma", CInt(nroProforma))
            .agregarEntero("@accion", 1)
        End With

        Return _conexion.ejecutarSP_String

    End Function

    Public Shared Function eliminar(ByVal nroProforma As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorControlServicios")
            .agregarEntero("@nroProforma", nroProforma)
            .agregarEntero("@accion", 3) ' Eliminaree
        End With

        respuesta = _conexion.ejecutarSP_String
        If respuesta = "" Then
            respuesta = "Se ha eliminado el registro indicado"
        End If
        Return respuesta
    End Function

    Public Shared Function ListarPersonal() As DataTable
        Return _conexion.consultarSP("SP_ListarPersonal")
    End Function

    Public Shared Function obtenerUltimoID() As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(IdControlServicio) FROM ControlDeServicios").Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(IdControlServicio) FROM ControlDeServicios").Rows(0)(0))
        End If
        Return 0
    End Function

    Public Shared Function registrarDetalle(ByVal idControlServicio As Integer, ByVal idPersonal As Integer, ByVal cantidad As Integer,
                                             ByVal horas As Integer, ByVal total As Integer, ByVal fecha As Date)
        With _conexion
            .prepararSP("SP_MantenedorDetallePersonalCDS")
            .agregarEntero("@idControlServicio", CInt(idControlServicio))
            .agregarEntero("@idPersonal", CInt(idPersonal))
            .agregarEntero("@cantidad", CInt(cantidad))
            .agregarEntero("@horas", CInt(horas))
            .agregarEntero("@total", CInt(total))
            .agregarFecha("@fecha", CDate(fecha))
            .agregarEntero("@accion", 1)
        End With

        Return _conexion.ejecutarSP_String
    End Function

    Public Shared Function buscarPersonal(ByVal codigo As Integer) As DataTable
        _conexion.prepararSP("SP_BuscarDetallePersonal")
        _conexion.agregarEntero("@idControlServicio", codigo)
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
