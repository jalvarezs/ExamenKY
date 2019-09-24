Public Class Personal

    Public Shared Function buscar(ByVal descripcion As String) As DataTable
        _conexion.prepararSP("SP_BuscarPersonal")
        _conexion.agregarCadena("@descripcion", descripcion)
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
