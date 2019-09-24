Public Class TipoPersonal
    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Personal")
    End Function
End Class
