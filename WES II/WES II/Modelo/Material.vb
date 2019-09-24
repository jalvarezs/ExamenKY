Public Class Material

    Public Shared Function listar() As DataTable
        Return _conexion.consultarSP("SP_ListarMateriales")
    End Function

    Public Shared Function listarStocks() As DataTable
        Return _conexion.consultar("SELECT * FROM V_StockMateriales")
    End Function

    Public Shared Function buscar_por_filtro(ByVal nombre As String, ByVal descripcion As String, ByVal tipofamilia As String)
        _conexion.prepararSP("SP_BuscarMaterialfiltro")
        _conexion.agregarCadena("@nombre", nombre)
        _conexion.agregarCadena("@descripcion", descripcion)
        _conexion.agregarCadena("@tipofamilia", tipofamilia)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function buscar(ByVal nombre As String, ByVal prov As String) As DataTable
        _conexion.prepararSP("SP_BuscarMaterial")
        _conexion.agregarCadena("@nombre", nombre)
        _conexion.agregarCadena("@proveedor", prov)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function obtenerSgteID() As Integer
        Return _conexion.consultarSP("SP_SgteID_Material").Rows(0)(0)
    End Function

    Public Shared Function Registrar(ByVal nombre As String, ByVal descripcion As String,
                                     ByVal precioCompra As String, ByVal precioVenta As String, ByVal EAN13 As String,
                                     ByVal DUN14 As String, ByVal idTipoMaterial As String, ByVal idUnidadEntrega As String,
                                     ByVal idTipoRecepcion As String, ByVal idMarca As String,
                                     ByVal idPerfil As String, ByVal idFamilia As Integer, ByVal stockSeguridad As String,
                                     ByVal stockMinimo As String, ByVal RG1 As String, ByVal RG2 As String, ByVal moneda As String,
                                     ByVal numSerie As String, ByVal unidadesCaja As String, ByVal cajasPaquete As String,
                                     ByVal idSubFamiliaMaterial As Integer) As String
        Dim respuesta As String

        Dim _idTipoMaterial As Integer = UtilConvertidor.GetInteger(idTipoMaterial)
        Dim _idMarca As Integer = UtilConvertidor.GetInteger(idMarca)
        Dim _idTipoRecepcion As Integer = UtilConvertidor.GetInteger(idTipoRecepcion)
        Dim _idUnidadEntrega As Integer = UtilConvertidor.GetInteger(idUnidadEntrega)
        Dim _idPerfil As Integer = UtilConvertidor.GetInteger(idPerfil)

        With _conexion
            .prepararSP("SP_MantenedorMaterial")
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarDecimal("@precioCompra", UtilConvertidor.GetDecimal(precioCompra))
            .agregarDecimal("@precioVenta", UtilConvertidor.GetDecimal(precioVenta))
            .agregarCadena("@EAN13", EAN13)
            .agregarCadena("@DUN14", DUN14)

            If _idTipoMaterial > 0 Then
                .agregarEntero("@idTipo_Material", _idTipoMaterial)
            End If

            If _idUnidadEntrega > 0 Then
                .agregarEntero("@idUnidad_Entrega", UtilConvertidor.GetInteger(_idUnidadEntrega))
            End If

            If _idTipoRecepcion > 0 Then
                .agregarEntero("@idTipo_Recepcion", _idTipoRecepcion)
            End If

            If _idMarca > 0 Then
                .agregarEntero("@idMarca", _idMarca)
            End If

            If _idPerfil > 0 Then
                .agregarEntero("@idPerfil", UtilConvertidor.GetInteger(idPerfil))
            End If

            .agregarEntero("@idFamilia", idFamilia)
            .agregarEntero("@IdSubFamiliaMaterial", idSubFamiliaMaterial)

            If stockSeguridad.Trim.Length > 0 Then
                Dim _stockSeguridad As Decimal
                Try
                    _stockSeguridad = UtilConvertidor.GetDecimal(stockSeguridad)
                    .agregarDecimal("@stockSeguridad", _stockSeguridad)
                Catch ex As Exception
                    Return "Ingrese un stock de seguridad válido."
                End Try
            End If

            If stockMinimo.Trim.Length > 0 Then
                Dim _stockMinimo As Decimal
                Try
                    _stockMinimo = UtilConvertidor.GetDecimal(stockMinimo)
                    .agregarDecimal("@stockMinimo", stockMinimo)
                Catch ex As Exception
                    Return "Ingrese un stock mínimo válido."
                End Try
            End If

            .agregarEntero("@RG1", UtilConvertidor.GetInteger(RG1))
            .agregarCadena("@RG2", RG2)
            .agregarCadena("@moneda", moneda)
            .agregarCadena("@numSerie", numSerie)
            .agregarEntero("@unidadesCaja", UtilConvertidor.GetInteger(unidadesCaja))
            .agregarEntero("@cajasPaquete", UtilConvertidor.GetInteger(cajasPaquete))
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()

        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo producto."
        Else
            respuesta = "[ERROR] " & respuesta

            Throw New Exception(respuesta)

        End If

        Return respuesta
    End Function

    Public Shared Function Modificar(ByVal idMaterial As Integer, ByVal nombre As String, ByVal descripcion As String,
                                     ByVal precioCompra As String, ByVal precioVenta As String, ByVal EAN13 As String,
                                     ByVal DUN14 As String, ByVal idTipoMaterial As String, ByVal idUnidadEntrega As String,
                                     ByVal idTipoRecepcion As String, ByVal idMarca As String,
                                     ByVal idPerfil As String, ByVal idFamilia As Integer,
                                     ByVal stockSeguridad As String, ByVal stockMinimo As String, ByVal RG1 As String, ByVal RG2 As String,
                                     ByVal moneda As String, ByVal numSerie As String, ByVal unidadesCaja As String, ByVal cajasPaquete As String,
                                     ByVal idSubFamiliaMaterial As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorMaterial")
            .agregarEntero("@idMaterial", idMaterial)
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@descripcion", descripcion)
            .agregarDecimal("@precioCompra", CDec(precioCompra))
            .agregarDecimal("@precioVenta", CDec(precioVenta))
            .agregarCadena("@EAN13", EAN13)
            .agregarCadena("@DUN14", DUN14)
            .agregarEntero("@idTipo_Material", CInt(idTipoMaterial))
            .agregarEntero("@idUnidad_Entrega", CInt(idUnidadEntrega))
            .agregarEntero("@idTipo_Recepcion", CInt(idTipoRecepcion))
            .agregarEntero("@idMarca", CInt(idMarca))
            .agregarEntero("@idPerfil", CInt(idPerfil))
            .agregarEntero("@idFamilia", idFamilia)
            .agregarDecimal("@stockSeguridad", CDec(stockSeguridad))
            .agregarDecimal("@stockMinimo", CDec(stockMinimo))
            .agregarEntero("@RG1", CInt(RG1))
            .agregarCadena("@RG2", RG2)
            .agregarCadena("@moneda", moneda)
            .agregarCadena("@numSerie", numSerie)
            .agregarEntero("@unidadesCaja", unidadesCaja)
            .agregarEntero("@cajasPaquete", cajasPaquete)
            .agregarEntero("@IdSubFamiliaMaterial", idSubFamiliaMaterial)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente los datos del producto."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal id As String) As String

        Dim respuesta As String
        Try

            Dim dt As New DataTable
            dt = materialPorDetalleContenedor(CInt(id))

            If dt.Rows.Count > 0 Then
                respuesta = "El material no puede ser eliminado, ya que tiene stock"
            Else
                With _conexion
                    .prepararSP("SP_MantenedorMaterial")
                    .agregarEntero("@idMaterial", CInt(id))
                    .agregarEntero("@accion", 3) ' Eliminar
                End With

                respuesta = _conexion.ejecutarSP_String()
                If respuesta Is "" Then
                    respuesta = "Se ha eliminado correctamente el producto indicado."
                End If
            End If

        Catch ex As Exception
            respuesta = ex.Message
        End Try

        Return respuesta

    End Function

    ' Atributos de instancia
    Public Property ID_Material As Integer
    
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Descripcion As String

    Public Property PrecioCompra As Decimal
    Public Property PrecioVenta As Decimal

    Public Property EAN13 As String
    Public Property DUN14 As String

    Public Property ID_Tipo_Material As Integer
    Public Property ID_Unidad_Entrega As Integer
    Public Property ID_Tipo_Recepcion As Integer
    Public Property ID_Marca As Integer
    Public Property NvAutorizacion As Integer

    Public Property ID_Familia_Material As Integer
	
    Public Property StockSeguridad As Decimal
    Public Property StockMinimo As Decimal

    Public Property RG1 As Integer
    Public Property RG2 As String
    Public Property Moneda As String

    Public Property NumSerie As String
    Public Property Unidades_Caja As Integer
    Public Property Cajas_Paquete As Integer

    ' Método para obtener toda la info desde la BD
    Public Sub obtener(ByVal valor As String)
        Dim dataTable As DataTable
        dataTable = _conexion.consultar("SELECT TOP 1 * FROM Material WHERE ID_Material = " & valor)
        Codigo = dataTable.Rows(0)("ID_Material") + 10000
        Nombre = dataTable.Rows(0)("Nombre")
        Descripcion = dataTable.Rows(0)("Descripcion")
        PrecioCompra = dataTable.Rows(0)("PrecioCompra")
        PrecioVenta = dataTable.Rows(0)("PrecioVenta")
        EAN13 = dataTable.Rows(0)("EAN13")
        DUN14 = dataTable.Rows(0)("DUN14")
        ID_Tipo_Material = dataTable.Rows(0)("ID_Tipo_Material")
        ID_Unidad_Entrega = dataTable.Rows(0)("ID_Unidad_Entrega")
        ID_Tipo_Recepcion = dataTable.Rows(0)("ID_Tipo_Recepcion")
        ID_Marca = dataTable.Rows(0)("ID_Marca")
        NvAutorizacion = dataTable.Rows(0)("NvAutorizacion")
        ID_Familia_Material = dataTable.Rows(0)("ID_Familia_Material")
        StockSeguridad = IIf(IsDBNull(dataTable.Rows(0)("StockSeguridad")), 0, dataTable.Rows(0)("StockSeguridad"))
        StockMinimo = IIf(IsDBNull(dataTable.Rows(0)("StockMinimo")), 0, dataTable.Rows(0)("StockMinimo"))
        RG1 = dataTable.Rows(0)("RG1")
        RG2 = dataTable.Rows(0)("RG2")
        Moneda = dataTable.Rows(0)("Moneda")
        NumSerie = dataTable.Rows(0)("NumSerie")
        Unidades_Caja = dataTable.Rows(0)("Unidades_Caja")
        Cajas_Paquete = dataTable.Rows(0)("Cajas_Paquete")
    End Sub

    Public Shared Function ObtenerMaterialPorId(ByVal idMaterial As Integer)
        _conexion.prepararSP("SP_Obtener_Material_Por_Id")
        _conexion.agregarEntero("@idMaterial", idMaterial)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ConsultarQuiebreStock()
        _conexion.prepararSP("SP_Consultar_Quiebre_Stock")
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function ConsultarQuiebreStockPorOrdenTrabajo(ByVal idOrdenTrabajo As Integer)
        _conexion.prepararSP("SP_Consultar_Quiebre_Stock_x_OT")
        _conexion.agregarEntero("@IdInicioTrabajo", idOrdenTrabajo)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function materialPorDetalleContenedor(ByVal idMaterial As Integer) As DataTable
        _conexion.prepararSP("SP_Materiales_x_Detalle_Contenedor")
        _conexion.agregarCadena("@idMaterial", idMaterial)
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
