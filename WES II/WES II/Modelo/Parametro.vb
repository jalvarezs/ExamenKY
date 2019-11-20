Public Class Parametro

    'Public Shared Function ObtenerParametroPorCode(ByVal code As String) As EntidadParametro

    '    Dim parametro As New EntidadParametro
    '    _conexion.prepararSP("SP_Obtener_Parametro_Por_Code")
    '    _conexion.agregarCadena("@code", code)

    '    Dim dt As DataTable = _conexion.ejecutarSP_DataTable()

    '    For Each row As DataRow In dt.Rows
    '        parametro.Id = row("Id")
    '        parametro.Descripcion = row("Descripcion")
    '        parametro.Code = row("Code")
    '        parametro.Valor = row("Valor")
    '    Next

    '    Return parametro
    'End Function

    Public Shared Function ObtenerParametrosPorGrupo(ByVal grupo As String) As DataTable


        _conexion.prepararSP("SP_Obtener_Parametros_Por_Grupo")
        _conexion.agregarCadena("@grupo", grupo)

        Dim dt As DataTable = _conexion.ejecutarSP_DataTable()

        Return dt
    End Function
End Class
