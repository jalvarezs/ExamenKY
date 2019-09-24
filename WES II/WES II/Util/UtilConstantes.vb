Public Class UtilConstantes

    Public Class Cotizacion
        Public Class Estado
            Public Const Pendiente = "PENDIENTE"
            Public Const Autorizada = "AUTORIZADA"
        End Class
    End Class

    Public Class Parametro

        Public Const CONTROL_LONG_EAN13 = "CONTROL_LONG_EAN13"
        Public Const CONTROL_LONG_DUN14 = "CONTROL_LONG_DUN14"
        Public Const ELIMINAR_CONTENEDOR_VACIO = "ELIMINAR_CONTENEDOR_VACIO"

        Public Const PEDIDOS_REQ_AUT = "PEDIDOS_REQ_AUT"

        Public Const VALOR_SI = "SI"
        Public Const VALOR_NO = "NO"

        Public Class Grupo
            Public Const EstadoMercancia = "ESTADO_MERCANCIA"
        End Class


    End Class

    Public Class OrdenCompra

        Public Class Estado
            Public Const EntregadoTotalmente = "Entregado Totalmente"
            Public Const EntregadoParcialmente = "Entregado Parcialmente"
            Public Const Pendiente = "Pendiente"
            Public Const Cancelada = "Cancelada"
        End Class

    End Class

    Public Class CargaMasterSku
        Public Const SKU As Integer = 0
        Public Const Descripcion As Integer = 1
        Public Const EAN As Integer = 2
        Public Const DUN As Integer = 3
        Public Const NumSerie As Integer = 4
        Public Const Proveedor As Integer = 5
        Public Const CodigoProveedor As Integer = 6
        Public Const Familia As Integer = 7
        Public Const SubFamilia As Integer = 8

        Public Const Marca As Integer = 9
        Public Const TipoMaterial As Integer = 10
        Public Const TipoRecepcion As Integer = 11
        Public Const UnidadEntrega As Integer = 12
        Public Const Autorizacion As Integer = 13
    End Class

    Public Class TipoContenedor
        Public Const Base = "Base"
        Public Const Adicional = "Adicional"
    End Class

End Class
