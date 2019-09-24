Public Class TipoRecepcion

    Public Shared Function listar() As DataTable
        Return _conexion.consultar("SELECT * FROM Tipo_Recepcion")
    End Function

End Class
