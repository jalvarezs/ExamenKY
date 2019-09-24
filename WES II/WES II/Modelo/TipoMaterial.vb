Public Class TipoMaterial

    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Tipo_Material")
    End Function

End Class
