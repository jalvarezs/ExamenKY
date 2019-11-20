Public Class Pedido
    Public Shared Function listar() As DataTable
        _conexion.prepararSP("sp_ListarPedido")
        Return _conexion.ejecutarSP_DataTable
        'Return _conexion.consultarSP("sp_ListarPedido")
    End Function

    Public Shared Function buscarPorId(ByVal idOrder As String) As DataTable
        _conexion.prepararSP("CustOrdersDetail")
        _conexion.agregarEntero("@OrderID", idOrder)
        Return _conexion.ejecutarSP_DataTable()
    End Function
    Public Shared Function modificar(ByVal idorder As Integer, ByVal idCliente As String, ByVal fecha As String, ByVal estado As String, ByVal comentario As String)
        With _conexion
            .prepararSP("SP_MantenedorPedido")
            .agregarEntero("@idOrder", idorder)
            .agregarCadena("@idCliente", idCliente)
            .agregarCadena("@fecha", fecha)
            .agregarCadena("@estado", estado)
            .agregarCadena("@comentario", comentario)
        End With
        Return _conexion.ejecutarSP_String()
    End Function
End Class
