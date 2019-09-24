Public Class Ciudad
    ' Lista de Ciudades
    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Ciudad")
    End Function
End Class
