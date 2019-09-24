Public Class TipoUbicacion
    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Tipo_Ubicacion")
    End Function
End Class
