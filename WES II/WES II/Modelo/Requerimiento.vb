Public Class Requerimiento
    Public Shared Function listarReq() As DataTable
        Return _conexion.consultar("SELECT * FROM V_ListarReq")
    End Function
    Public Shared Function buscarAlmacenReq(ByVal id_almacen As Integer) As DataTable
        _conexion.prepararSP("SP_BuscarAlmacenReq")
        _conexion.agregarEntero("@idAlmacen", id_almacen)
        Return _conexion.ejecutarSP_DataTable
    End Function

    Public Shared Function listarReqPorFechas(ByVal Fecha_Inicio As String, ByVal Fecha_Fin As String) As DataTable
        _conexion.prepararSP("SP_ListarReqPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(Fecha_Inicio))
        _conexion.agregarFecha("@FechaFin", CDate(Fecha_Fin))
        Return _conexion.ejecutarSP_DataTable()
    End Function

    ' Listar req por fechas, con el estado indicado
    Public Shared Function listarReqPorFechas(ByVal Fecha_Inicio As String, ByVal Fecha_Fin As String, ByVal Estado As String) As DataTable
        _conexion.prepararSP("SP_ListarReqPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(Fecha_Inicio))
        _conexion.agregarFecha("@FechaFin", CDate(Fecha_Fin))
        _conexion.agregarCadena("@Estado", Estado)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function listarDetalles(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarDetallesPorReq")
        _conexion.agregarEntero("@idReq", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function obtenerUltimoID() As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(ID_Requerimiento) FROM Requerimiento").Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(ID_Requerimiento) FROM Requerimiento").Rows(0)(0))
        End If
        Return 0
    End Function

    Public Shared Function aprobarReq(ByVal id As Integer) As String
        _conexion.prepararSP("SP_AprobarReq")
        _conexion.agregarEntero("@ID_Requerimiento", id)
        _conexion.agregarEntero("@ID_Usuario", _usuario)
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function denegarReq(ByVal id As String) As String
        _conexion.prepararSP("SP_DenegarReq")
        _conexion.agregarEntero("@ID_Requerimiento", CInt(id) - 10000)
        _conexion.agregarEntero("@ID_Usuario", _usuario)
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function registrar(ByVal proyecto As String, ByVal fecha_crea As String, ByVal codOrdenCompra As String,
                                     ByVal almacenDestino As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorRequerimiento")
            .agregarEntero("@proyecto", CInt(proyecto)) 'ID_Proyecto
            .agregarFecha("@fecha_crea", fecha_crea) 'Fecha
            .agregarEntero("@usuario_crea", _usuario)
            If codOrdenCompra <> "" Then .agregarEntero("@codOrdenCompra", CInt(codOrdenCompra) - 10000) 'ID_OrdenCompra
            If almacenDestino <> "" Then .agregarEntero("@almacenDestino", CInt(almacenDestino)) 'Almacen destino
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        Return respuesta
    End Function

    Public Shared Function eliminarDetalles(ByVal ID_Requerimiento As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorDetalleRequerimiento")
            .agregarEntero("@ID_Requerimiento", ID_Requerimiento)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        Return respuesta
    End Function

    Public Shared Function registrarDetalle(ByVal ID_Requerimiento As Integer, ByVal ID_Material As Integer, ByVal Cantidad_Solicitada As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorDetalleRequerimiento")
            .agregarEntero("@ID_Requerimiento", ID_Requerimiento)
            .agregarEntero("@ID_Material", ID_Material)
            .agregarEntero("@CantidadSol", CInt(Cantidad_Solicitada))
            .agregarEntero("@accion", 1) ' Registrar
        End With

        respuesta = _conexion.ejecutarSP_String()
        Return respuesta
    End Function

    Public Shared Function modificar(ByVal id As String, ByVal proyecto As String,
                                     ByVal codOrdenCompra As String, ByVal almacenDestino As String) As String

        With _conexion
            .prepararSP("SP_MantenedorRequerimiento")
            .agregarEntero("@ID_Requerimiento", id) 'ID_Requerimiento
            MessageBox.Show("parametro proyecto: " & proyecto)
            .agregarEntero("@proyecto", CInt(proyecto)) 'ID_Proyecto
            If codOrdenCompra <> "" Then .agregarEntero("@codOrdenCompra", CInt(codOrdenCompra)) 'ID_OrdenCompra
            MessageBox.Show("parametro almacen: " & almacenDestino)
            If almacenDestino <> "" Then .agregarEntero("@almacenDestino", CInt(almacenDestino)) 'Almacen destino
            .agregarEntero("@accion", 2) ' Modificar
        End With

        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function eliminar(ByVal id As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorRequerimiento")
            .agregarEntero("@ID_Requerimiento", id)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado correctamente el requerimiento indicado."
        End If

        Return respuesta
    End Function

    ' En adelante: atributos y métodos de instancia
    Public Property ID_Orden_Compra As String ' ID de la OC

    Public Property ID_Proyecto As String ' ID del proyecto
    Public Property Proyecto As String ' Nombre a mostrar

    Public Property ID_Almacen As String ' ID del almacén
    Public Property Almacen As String ' Nombre a mostrar

    ' Método para obtener toda la info desde la BD
    Public Function obtener(ByVal valor As String) As Boolean
        Dim dataTable As DataTable
        Dim consulta As String
        consulta = "select top 1 R.ID_Orden_Compra, PROY.ID_Proyecto, PROY.Nombre as Proyecto, A.ID_Almacen, A.Nombre as Almacen "
        consulta &= "from Requerimiento R "
        consulta &= "left join Proyecto PROY on R.ID_Proyecto = PROY.ID_Proyecto "
        consulta &= "left join Almacen A on R.ID_Almacen = A.ID_Almacen "
        consulta &= "where ID_Requerimiento = " & valor
        dataTable = _conexion.consultar(consulta)

        ' Si no se encontraron coincidencias
        If dataTable.Rows.Count = 0 Then
            Return False
        End If

        ' Decodificamos el resultado en los atributos
        Dim fila As DataRow = dataTable.Rows(0)

        If IsDBNull(fila("ID_Orden_Compra")) Then
            ID_Orden_Compra = ""
        Else
            ID_Orden_Compra = fila("ID_Orden_Compra")
        End If

        ' Proyecto nunca debe ser null, es campo FK obligatorio
        ID_Proyecto = fila("ID_Proyecto")
        Proyecto = fila("Proyecto")

        If IsDBNull(fila("ID_Almacen")) Then
            ID_Almacen = ""
            Almacen = ""
        Else
            ID_Almacen = fila("ID_Almacen")
            Almacen = fila("Almacen")
        End If

        Return True
    End Function

End Class
