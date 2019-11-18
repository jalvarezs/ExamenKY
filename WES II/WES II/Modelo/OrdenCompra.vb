


Public Class OrdenCompra

    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Orden_Compra")
    End Function

    Public Shared Function ObtenerPreComProm(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ObtenerPrecioPromed_Material")
        _conexion.agregarCadena("@idMaterial", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function
    Public Shared Function buscar(ByVal codigo As String) As DataTable
        _conexion.prepararSP("SP_BuscarOrdenCompra")
        _conexion.agregarCadena("@codOrdenCompra", codigo)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function listarPorFechas(ByVal fi As String, ByVal ff As String) As DataTable
        _conexion.prepararSP("SP_ListarOrdenesPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function listarDetalles(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarDetallesPorOrden")
        _conexion.agregarEntero("@idOrden", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function obtenerUltimoID() As Integer
        If IsNumeric(_conexion.consultar("SELECT MAX(ID_Orden_Compra) FROM Orden_Compra").Rows(0)(0)) Then
            Return CInt(_conexion.consultar("SELECT MAX(ID_Orden_Compra) FROM Orden_Compra").Rows(0)(0))
        End If
        Return 0
    End Function
    'Se agrega parametro EstOc para colocar el estado Aprobado o Pendiente segun la
    'consulta que se realiza en la tabla parametro al campo Aprobar_OC
    Public Shared Function registrarOrden(ByVal Fecha As String, ByVal ID_Proyecto As String, ByVal ID_Usuario As String,
                                          ByVal ID_Proveedor As String, ByVal EstOc As String, ByVal ID_Oferta As String, ByVal TipoCompra As String,
                                          ByVal TipoCredito As String, ByVal FormaPago As String, ByVal Moneda As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorOrdenCompra")
            .agregarFecha("@fecha", CDate(Fecha))
            If ID_Proyecto <> "-1" Then .agregarEntero("@idProyecto", CInt(ID_Proyecto))
            .agregarEntero("@idUsuario", CInt(ID_Usuario))
            If ID_Oferta <> "-1" Then .agregarEntero("@idOferta ", CInt(ID_Oferta))
            .agregarEntero("@idProveedor ", CInt(ID_Proveedor))
            .agregarCadena("@estado", EstOc)
            .agregarCadena("@TipoCompra", TipoCompra)
            .agregarCadena("@TipoCredito", TipoCredito)
            .agregarCadena("@FormaPago", FormaPago)
            .agregarCadena("@Moneda", Moneda)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        respuesta = _conexion.ejecutarSP_String()

        Return respuesta
    End Function

    Public Shared Function registrarDetalle(ByVal ID_Orden As String, ByVal ID_Material As String,
                                            ByVal Cantidad_Solicitada As String, ByVal Precio_compra As String) As String
        Dim respuesta As String
        'Se agrega campo parametro Precio_compra y la  @PrecioComp  (01/10/2019)
        With _conexion
            .prepararSP("SP_MantenedorDetalleOrdenCompra")
            .agregarEntero("@idOrdenCompra", CInt(ID_Orden))
            .agregarEntero("@idMaterial", CInt(ID_Material))
            .agregarEntero("@CantidadSol ", CInt(Cantidad_Solicitada))
            .agregarDecimal("@PrecioComp", Precio_compra)
            .agregarEntero("@accion", 1) ' Registrar
        End With

        respuesta = _conexion.ejecutarSP_String()

        Return respuesta
    End Function

    Public Shared Function modificarOrden(ByVal ID_Orden As String, ByVal Fecha As String, ByVal ID_Proyecto As String, ByVal ID_Proveedor As String, ByVal ID_Oferta As String, ByVal estado As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorOrdenCompra")
            .agregarEntero("@idOrdenCompra", CInt(ID_Orden))
            .agregarFecha("@fecha", CDate(Fecha))
            If ID_Proyecto <> "-1" Then .agregarEntero("@idProyecto", CInt(ID_Proyecto))
            If ID_Oferta <> "-1" Then .agregarEntero("@idOferta ", CInt(ID_Oferta))
            .agregarEntero("@idProveedor ", CInt(ID_Proveedor))
            .agregarCadena("@estado", estado)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()

        Return respuesta
    End Function
    'Se agrega campo PrecioCompra a tabla Detalle_Orden_Compra
    Public Shared Function eliminarDetalles(ByVal ID_Orden As Integer, id_material As String, cantsol As String, cantrec As String, PreComp As String, acci As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorDetalleOrdenCompra")
            .agregarEntero("@idOrdenCompra", ID_Orden)
            .agregarEntero("@idMaterial", id_material)
            .agregarEntero("@CantidadSol", cantsol)
            .agregarEntero("@CantidadRec", cantrec)
            .agregarEntero("@PrecioComp", PreComp)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        Return respuesta
    End Function
    'Function agregada para aprobar OC 
    'autor : JAS 
    'fecha: 02/10/19
    Public Shared Function aprobar(ByVal id As Integer, ByVal estado As String) As String
        Dim respuesta As String
        Dim cestado As String
        With _conexion
            .prepararSP("SP_Actualizar_Estado_OC")
            .agregarEntero("@idOC", id)
            .agregarCadena("@estado", estado)
        End With

        respuesta = _conexion.ejecutarSP_String()
        If estado = "Aprobado" Then
            cestado = "Aprobado"
        Else
            cestado = "Denegado"
        End If
        If respuesta Is "" Then
            respuesta = "Se ha " + cestado + " correctamente la Orden indicada."
        End If

        Return respuesta
    End Function

    Public Shared Function cancelar(ByVal id As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorOrdenCompra")
            .agregarEntero("@idOrdenCompra", id)
            .agregarEntero("@accion", 3) ' Cancelar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha cancelado correctamente la Orden indicada."
        End If

        Return respuesta
    End Function

    ' En adelante: atributos y métodos de instancia
    Public Property Codigo As String ' Código con formato de 10 000
    Public Property Fecha As Date

    Public Property ID_Proveedor As Integer ' ID del proveedor
    Public Property Proveedor As String ' Nombre a mostrar
    Public Property ID_Proyecto As Integer ' ID del proyecto
    Public Property Proyecto As String ' Nombre a mostrar
    Public Property ID_Oferta As Integer ' ID de la oferta
    Public Property Estado As String ' Estado de la orden
    Public Property Ruc As String
    Public Property DireccionProveedor As String


    'Public Property ID_Usuario As Integer ' ID del usuario
    'Public Property Usuario As String ' Nombre a mostrar

    ' Método para obtener toda la info desde la BD
    Public Function obtener(ByVal valor As String) As Boolean
        Dim dataTable As DataTable
        Dim consulta As String
        consulta = "select top 1 OC.ID_Orden_Compra, OC.Fecha, OC.ID_Proveedor, PROV.Nombre as Proveedor, OC.ID_Proyecto, PROY.Nombre as Proyecto, OC.ID_Oferta, OC.Estado, PROV.RUC , PROV.Direccion "
        consulta &= "from Orden_Compra OC "
        consulta &= "left join Proyecto PROY on OC.ID_Proyecto = PROY.ID_Proyecto "
        consulta &= "left join Proveedor PROV on OC.ID_Proveedor = PROV.ID_Proveedor "
        consulta &= "left join Oferta O on OC.ID_Oferta = O.ID_Oferta "
        consulta &= "where ID_Orden_Compra = " & valor
        dataTable = _conexion.consultar(consulta)

        ' Si no se encontraron coincidencias
        If dataTable.Rows.Count = 0 Then
            Return False
        End If

        ' Decodificamos el resultado en los atributos
        Dim fila As DataRow = dataTable.Rows(0)
        Codigo = fila("ID_Orden_Compra") + 10000
        Fecha = fila("Fecha")

        ' Proveedor nunca debe ser null, es campo FK obligatorio
        ID_Proveedor = fila("ID_Proveedor")
        Proveedor = fila("Proveedor")
        Ruc = fila("RUC")
        DireccionProveedor = fila("Direccion")

        If IsDBNull(fila("ID_Proyecto")) Then
            ID_Proyecto = -1
            Proyecto = ""
        Else
            ID_Proyecto = fila("ID_Proyecto")
            Proyecto = fila("Proyecto")
        End If

        If IsDBNull(fila("ID_Oferta")) Then
            ID_Oferta = -1
        Else
            ID_Oferta = fila("ID_Oferta")
        End If

        Estado = fila("Estado")

        Return True
    End Function
End Class





