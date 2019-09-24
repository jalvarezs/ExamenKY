Imports System.Data.SqlClient

Public Class Cotizacion

    Public Shared Function Listar() As DataTable
        Return _conexion.consultarSP("SP_ListarCotizaciones")
    End Function
    Public Shared Function ListarArchivos() As DataTable
        Return _conexion.consultarSP("SP_ListarArchivos")
    End Function

    Public Shared Function Buscar(ByVal codigo As Integer) As DataTable
        _conexion.prepararSP("SP_BuscarCotizacion")
        _conexion.agregarEntero("@idCotizacion", codigo)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ListarPorFechas(ByVal fi As String, ByVal ff As String) As DataTable
        _conexion.prepararSP("SP_ListarCotizacionesPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ListarCotizacion(ByVal fi As String, ByVal ff As String, ByVal estado As String) As DataTable
        _conexion.prepararSP("SP_ListarCotizaciones_Fecha_Estado")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        _conexion.agregarCadena("@estado", estado)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ListarPorDescripcion(ByVal descripcion As String) As DataTable
        _conexion.prepararSP("SP_ListarCotizacionesPorDescripcion")
        _conexion.agregarCadena("@descripcion", String.Concat("%", descripcion, "%"))
        Return _conexion.ejecutarSP_DataTable()
    End Function
    Public Shared Function ObtenerSgteID() As Integer
        Return _conexion.consultarSP("SP_SgteID_Cotizacion").Rows(0)(0)
    End Function

    Public Shared Function ObtenerUltimoID() As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(ID_Cotizacion) FROM Cotizacion").Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(ID_Cotizacion) FROM Cotizacion").Rows(0)(0))
        End If
        Return 0
    End Function

    Public Shared Function ListarPersonalCotizacion(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarPersonalCotizacion")
        _conexion.agregarEntero("@idCotizacion", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ListarPersonalCotizacionPorItem(ByVal idCotizacion As Integer, ByVal idDetalleItem As Integer) As DataTable
        _conexion.prepararSP("SP_ListarPersonalCotizacionPorItem")
        _conexion.agregarEntero("@idCotizacion", idCotizacion)
        _conexion.agregarEntero("@idDetalleItem", idDetalleItem)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Sub LimpiarDetallesCotizacion(ByVal id As Integer)
        _conexion.prepararSP("SP_LimpiarDetallesCotizacion")
        _conexion.agregarEntero("@idCotizacion", id)
        _conexion.ejecutarSP_String()
    End Sub

    Public Shared Function ListarDetalles(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarDetallesCotizacion")
        _conexion.agregarEntero("@idCotizacion", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function
    Public Shared Function ListarDetallesPorDetalleItem(ByVal idCotizacion As Integer, ByVal idDetalleItem As Integer) As DataTable
        _conexion.prepararSP("SP_ListarDetallesCotizacionPorItem")
        _conexion.agregarEntero("@idCotizacion", idCotizacion)
        _conexion.agregarEntero("@idDetalleItem", idDetalleItem)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function Registrar(ByVal idCliente As String, ByVal fecha As String, ByVal descripcion As String,
                                     ByVal DuracionDias As Integer, ByVal horasInicio As TimeSpan,
                                     ByVal DuracionHoras As Integer, ByVal ValorTotal As Decimal,
                                     ByVal verRRHH As Integer, ByVal verMaterial As Integer, ByVal verServicioExterno As Integer) As String
        With _conexion
            .prepararSP("SP_MantenedorCotizacion")
            .agregarEntero("@idCliente", CInt(idCliente))
            .agregarFecha("@fecha", CDate(fecha))
            .agregarCadena("@descripcion", descripcion)
            .agregarEntero("@duracionFecha", CInt(DuracionDias))
            .agregarHora("@horasInicio", horasInicio)
            .agregarEntero("@duracionHoras", CInt(DuracionHoras))
            .agregarDecimal("@ValorTotal", ValorTotal)
            .agregarEntero("@verRRHH", verRRHH)
            .agregarEntero("@verMaterial", verMaterial)
            .agregarEntero("@verServicioExterno", verServicioExterno)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function RegistrarPersonal(ByVal idInicioTrabajo As Integer, ByVal idItemDetalle As Integer, ByVal personal As String, ByVal cantidad As String) As String
        With _conexion
            .prepararSP("SP_MantenedorPersonalCotizacion")
            .agregarEntero("@idCotizacion", idInicioTrabajo)
            .agregarEntero("@idDetalleItem", idItemDetalle)
            .agregarCadena("@personal", personal)
            .agregarEntero("@cantidad ", CInt(cantidad))
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function RegistrarDetalleMaterial(ByVal idCotizacion As Integer, ByVal idDetalleItem As Integer, ByVal idMaterial As Integer, ByVal cantidad As String, ByVal precioUnitario As Decimal,
                                            ByVal precioTotal As Decimal, ByVal precioAlquilerDia As Decimal, ByVal precioAlquilerHora As Decimal,
                                            ByVal descuento As Integer, ByVal duracionDias As Integer, ByVal duracionHoras As Integer) As String

        If (CInt(cantidad) = 0 Or precioTotal = 0) Then
            Throw New Exception("No se pueden registrar detalles con cantidad o precio cero.")
        End If

        With _conexion
            .prepararSP("SP_MantenedorDetalleCotizacion")
            .agregarEntero("@idCotizacion", idCotizacion)
            .agregarEntero("@idDetalleItem", idDetalleItem)
            .agregarEntero("@idMaterial", idMaterial)
            .agregarEntero("@cantidad ", CInt(cantidad))
            .agregarDecimal("@precioUnitario", precioUnitario)
            .agregarDecimal("@precioTotal", precioTotal)
            .agregarDecimal("@precioAlquilerDia", precioAlquilerDia)
            .agregarDecimal("@precioAlquilerHora", precioAlquilerHora)
            .agregarEntero("@descuento", descuento)
            .agregarEntero("@duracionDias", duracionDias)
            .agregarEntero("@duracionHoras", duracionHoras)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    ' Atributos de una cotización en particular
    Public Property Cliente As String
    Public Property Fecha As Date
    Public Property Descripcion As String

    Public Function Obtener(ByVal idCotizacion As String) As Boolean
        Dim consulta As String
        consulta = "select top 1 CLI.Nombre as Cliente, COT.Fecha, COT.Descripcion "
        consulta &= "from Cotizacion COT "
        consulta &= "join Cliente CLI on COT.ID_Cliente = CLI.ID_Cliente "
        consulta &= "where ID_Cotizacion = " & idCotizacion
        Dim resultados As DataTable = _conexion.consultar(consulta)

        ' Si no se encontraron coincidencias
        If resultados.Rows.Count = 0 Then
            Return False
        End If

        ' Decodificamos el resultado en los atributos
        Dim fila As DataRow = resultados.Rows(0)
        Cliente = fila("Cliente")
        Fecha = fila("Fecha")
        Descripcion = fila("Descripcion")

        Return True
    End Function

    Public Shared Function RegistrarArchivo(ByVal idCotizacion As Integer, ByVal idArchivo As Integer, ByVal nombre As String) As String
        With _conexion
            .prepararSP("SP_MantenedorArchivosCotizacion")
            .agregarEntero("@idCotizacion", CInt(idCotizacion))
            .agregarEntero("@idArchivo", CInt(idArchivo))
            .agregarCadena("@nombreArchivo ", nombre)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function ObtenerUltimoIDArchivo(ByVal idCotizacion As Integer) As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(idArchivo) FROM ArchivosCotizacion Where idCotizacion = " & idCotizacion).Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(idArchivo) FROM ArchivosCotizacion  Where idCotizacion = " & idCotizacion).Rows(0)(0))
        End If
        Return 0
    End Function

    Public Shared Function Modificar(ByVal codigoCotizacion As Integer, ByVal descripcion As String, ByVal fechaRegistro As Date,
                                     ByVal duracionDias As Integer, ByVal horaInico As Date, ByVal duracionHoras As Integer,
                                     ByVal verRRHH As Integer, ByVal verMaterial As Integer, ByVal verServicioExterno As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorCotizacion")
            .agregarEntero("@idCotizacion", codigoCotizacion - 10000)
            .agregarCadena("@descripcion", descripcion)
            .agregarFecha("@fecha", fechaRegistro)
            .agregarEntero("@duracionFecha", duracionDias)
            .agregarFecha("@horasInicio", horaInico)
            .agregarEntero("@duracionHoras", duracionHoras)
            .agregarEntero("@verRRHH", verRRHH)
            .agregarEntero("@verMaterial", verMaterial)
            .agregarEntero("@verServicioExterno", verServicioExterno)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente la cotización."
        End If

        Return respuesta
    End Function

    Public Shared Function CotizacionInforme(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_CotizacionInforme")
        _conexion.agregarEntero("@idCotizacion", id - 10000)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function InsertarDetalleItemCotizacion(ByVal idCotizacion As Integer, ByVal titulo As String, ByVal descripcionTrabajo As String) As Integer
        Dim idDetalleItem As Integer = 0

        Try
            _conexion.prepararSP("SP_Insertar_DetalleItemCotiza")
            _conexion.agregarEntero("@idCotizacion", idCotizacion)
            _conexion.agregarCadena("@titulo", titulo)
            _conexion.agregarCadena("@descripcionTrabajo", descripcionTrabajo)
            _conexion.agregarEnteroOutPut("@idDetalleItem")
            _conexion.ejecutarSP_ExecuteNonQuery()

            _conexion.getValueEnteroOutPut("@idDetalleItem", idDetalleItem)

        Catch ex As Exception

        End Try

        Return idDetalleItem

    End Function

    Public Shared Function BuscarDetalleItems(ByVal idCotizacion As Integer) As DataTable
        _conexion.prepararSP("SP_BuscarDetalleItems")
        _conexion.agregarEntero("@idCotizacion", idCotizacion)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function AutorizarCotizacion(ByVal idCotizacion As Integer) As String
        _conexion.prepararSP("SP_AutorizarCotizacion")
        _conexion.agregarEntero("@idCotizacion", idCotizacion)
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function InsertarServicioExterno(ByVal idCotizacion As Integer, ByVal idProveedor As Integer, ByVal detalle As String,
                                     ByVal cantidad As Integer, ByVal precioUnitario As Decimal, ByVal total As Decimal) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_Mantener_Servicio_Externo")
            .agregarEntero("@idCotizacion", idCotizacion)
            .agregarEntero("@idProveedor", idProveedor)
            .agregarCadena("@detalle", detalle)
            .agregarEntero("@cantidad", cantidad)
            .agregarDecimal("@precioUnitario", precioUnitario)
            .agregarDecimal("@total", total)
            .agregarEntero("@accion", 1) 'Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()

        Return respuesta
    End Function

    Public Shared Function ModificarServicioExterno(ByVal idServicioExterno As Integer, ByVal idCotizacion As Integer, ByVal idProveedor As Integer, ByVal detalle As String,
                                     ByVal cantidad As Integer, ByVal precioUnitario As Decimal, ByVal total As Decimal) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_Mantener_Servicio_Externo")
            .agregarEntero("@idServicioExterno", idServicioExterno)
            .agregarEntero("@idCotizacion", idCotizacion)
            .agregarEntero("@idProveedor", idProveedor)
            .agregarCadena("@detalle", detalle)
            .agregarEntero("@cantidad", cantidad)
            .agregarDecimal("@precioUnitario", precioUnitario)
            .agregarDecimal("@total", total)
            .agregarEntero("@accion", 2) 'Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()

        Return respuesta
    End Function

    Public Shared Function ListarServiciosExternos(ByVal idCotizacion As Integer,
                                                   ByVal idProveedor As Integer,
                                                   ByVal fechaInicio As Date,
                                                   ByVal fechaFin As Date) As DataTable
        _conexion.prepararSP("SP_Listar_Servicio_Externo")
        _conexion.agregarEntero("@idCotizacion", idCotizacion)
        _conexion.agregarEntero("@idProveedor", idProveedor)
        _conexion.agregarFecha("@FechaInicio", fechaInicio)
        _conexion.agregarFecha("@FechaFin", fechaFin)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function EliminarServicioExterno(ByVal idServicioExterno As Integer) As String
        _conexion.prepararSP("SP_Mantener_Servicio_Externo")
        _conexion.agregarEntero("@idServicioExterno", idServicioExterno)
        _conexion.agregarEntero("@accion", 3) 'Eliminar
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function BuscarServicioExterno(ByVal idServicioExterno As Integer) As DataTable
        _conexion.prepararSP("SP_Buscar_Servicio_Externo")
        _conexion.agregarEntero("@idServicioExterno", idServicioExterno)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function BuscarCotizacionPorId(ByVal idCotizacion As Integer) As DataTable
        _conexion.prepararSP("SP_BuscarCotizacionPorId")
        _conexion.agregarEntero("@idCotizacion", idCotizacion)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ObtenerCotizacion(ByVal idCotizacion As Integer) As DataTable
        _conexion.prepararSP("SP_Obtener_Cotizacion")
        _conexion.agregarEntero("@idCotizacion", idCotizacion)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ExaminarServicioExterno(ByVal idCotizacion As Integer, ByVal ordenServicio As Integer) As DataTable
        _conexion.prepararSP("SP_Examinar_Servicio_Externo")
        _conexion.agregarEntero("@IdCotizacion", idCotizacion)
        _conexion.agregarEntero("@OrdenServicio", ordenServicio)
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
