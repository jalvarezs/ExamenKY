Public Class UnidadEntrega
    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Unidad_Entrega")
    End Function
End Class
