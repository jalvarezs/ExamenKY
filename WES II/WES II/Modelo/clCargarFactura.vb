Public Class clCargarFactura

    Public Shared Function registrarFactura(
        ByVal NRO_FACTURA As String, ByVal FECHA_EMISION As String, ByVal EMPRESA_EMITIDA As String, ByVal RUC As String, ByVal DETALLE As String, ByVal PERSONAL_AUTORIZADO As String, ByVal NRO_PROFORMA As String, ByVal NRO_OC As String, ByVal GUIA As String, ByVal SUBTOTAL As Integer, ByVal IGV As Integer, ByVal MONTO_TOTAL As Integer, ByVal CONTROL_PAGADO As Integer, ByVal CANCELADA As String, ByVal FECHA_CANC As String, ByVal FORMA_PAGO As String, ByVal DET_RET As String, ByVal PORCENTAJE_DET As Integer, ByVal MES_DET As String, ByVal FECHA_DET As String, ByVal MONTO_REST_DET As String
        ) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorCargaFacturas")
            .agregarCadena("@NRO_FACTURA", NRO_FACTURA)
            .agregarFecha("@FECHA_EMISION", CDate(FECHA_EMISION))
            .agregarCadena("@EMPRESA_EMITIDA", EMPRESA_EMITIDA)
            .agregarCadena("@RUC", RUC)
            .agregarCadena("@DETALLE", DETALLE)
            .agregarCadena("@PERSONAL_AUTORIZADO", PERSONAL_AUTORIZADO)
            .agregarCadena("@NRO_PROFORMA", NRO_PROFORMA)
            .agregarCadena("@NRO_OC", NRO_OC)
            .agregarCadena("@GUIA", GUIA)
            .agregarCadena("@SUBTOTAL", SUBTOTAL)
            .agregarCadena("@IGV", IGV)
            .agregarCadena("@MONTO_TOTAL", MONTO_TOTAL)
            .agregarCadena("@CONTROL_PAGADO", CONTROL_PAGADO)
            .agregarCadena("@CANCELADA", CANCELADA)
            .agregarFecha("@FECHA_CANC", CDate(FECHA_CANC))
            .agregarCadena("@FORMA_PAGO", FORMA_PAGO)
            .agregarCadena("@DET_RET", DET_RET)
            .agregarFecha("@FECHA_DET", CDate(FECHA_DET))
            .agregarCadena("@PORCENTAJE_DET", PORCENTAJE_DET)
            .agregarCadena("@MES_DET", MES_DET)
            .agregarCadena("@MONTO_REST_DET", MONTO_REST_DET)

            .agregarEntero("@accion", 1) ' Insertar



        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente la factura."
        End If

        Return respuesta
    End Function
    Public Shared Function obtenerSgteID() As Integer
        Return _conexion.consultarSP("SP_SgteID_CARGADEFACTURA").Rows(0)(0)
    End Function

    Public Shared Function actualizarFactura(ByVal NRO_FACTURA As String, ByVal FECHA_EMISION As String, ByVal EMPRESA_EMITIDA As String, ByVal RUC As String, ByVal DETALLE As String, ByVal PERSONAL_AUTORIZADO As String, ByVal NRO_PROFORMA As String, ByVal NRO_OC As String, ByVal GUIA As String, ByVal SUBTOTAL As Integer, ByVal IGV As Integer, ByVal MONTO_TOTAL As Integer, ByVal CONTROL_PAGADO As Integer, ByVal CANCELADA As String, ByVal FECHA_CANC As String, ByVal FORMA_PAGO As String, ByVal DET_RET As String, ByVal PORCENTAJE_DET As Integer, ByVal MES_DET As String, ByVal FECHA_DET As String, ByVal MONTO_REST_DET As String
        ) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorCargaFacturas")
            .agregarCadena("@NRO_FACTURA", NRO_FACTURA)
            .agregarFecha("@FECHA_EMISION", CDate(FECHA_EMISION))
            .agregarCadena("@EMPRESA_EMITIDA", EMPRESA_EMITIDA)
            .agregarCadena("@RUC", RUC)
            .agregarCadena("@DETALLE", DETALLE)
            .agregarCadena("@PERSONAL_AUTORIZADO", PERSONAL_AUTORIZADO)
            .agregarCadena("@NRO_PROFORMA", NRO_PROFORMA)
            .agregarCadena("@NRO_OC", NRO_OC)
            .agregarCadena("@GUIA", GUIA)
            .agregarCadena("@SUBTOTAL", SUBTOTAL)
            .agregarCadena("@IGV", IGV)
            .agregarCadena("@MONTO_TOTAL", MONTO_TOTAL)
            .agregarCadena("@CONTROL_PAGADO", CONTROL_PAGADO)
            .agregarCadena("@CANCELADA", CANCELADA)
            .agregarFecha("@FECHA_CANC", CDate(FECHA_CANC))
            .agregarCadena("@FORMA_PAGO", FORMA_PAGO)
            .agregarCadena("@DET_RET", DET_RET)
            .agregarFecha("@FECHA_DET", CDate(FECHA_DET))
            .agregarCadena("@PORCENTAJE_DET", PORCENTAJE_DET)
            .agregarCadena("@MES_DET", MES_DET)
            .agregarCadena("@MONTO_REST_DET", MONTO_REST_DET)

            .agregarEntero("@accion", 2) ' Insertar



        End With


        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente la factura."
        End If

        Return respuesta
    End Function





    Public Shared Function listarFactCargPorFechas(ByVal fi As String, ByVal ff As String) As DataTable
        _conexion.prepararSP("SP_ListarFacturasCargadasPorFechas")
        _conexion.agregarFecha("@FechaInicio", CDate(fi))
        _conexion.agregarFecha("@FechaFin", CDate(ff))
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function CargaCampos(ByVal id As String) As DataTable
        Return _conexion.consultar("SELECT * FROM V_CargaFactura where ID_cotizacion = " + id)
    End Function

End Class
