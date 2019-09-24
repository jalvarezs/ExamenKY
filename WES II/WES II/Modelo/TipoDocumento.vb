Public Class TipoDocumento

    Public Shared Function ListarTipoDocumentos() As DataTable

        Dim parametro As New EntidadParametro
        _conexion.prepararSP("SP_Obtener_Tipo_Documento")
        _conexion.agregarCadena("@codigo", String.Empty)

        Dim dt As DataTable = _conexion.ejecutarSP_DataTable()

        Return dt
    End Function

End Class
