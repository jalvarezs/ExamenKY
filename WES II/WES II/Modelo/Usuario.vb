
Public Class Usuario
    Public Shared Function listar()
        Return _conexion.consultarSP("SP_ListarUsuarios")
    End Function

    Public Shared Function listarPerfiles()
        Return _conexion.consultarSP("SP_ListarPerfiles")
    End Function




    Public Shared Function darDeBaja(ByVal ID_Usuario As Integer)
        With _conexion
            .prepararSP("SP_MantenedorUsuarios")
            .agregarEntero("@ID_Usuario", ID_Usuario)
            .agregarEntero("@Accion", 3)
        End With
        Return _conexion.ejecutarSP_String()
    End Function





    Public Shared Function tieneAcceso(ByVal NombreBtn As String) As Boolean
        With _conexion
            .prepararSP("SP_EvaluarAcceso")
            .agregarCadena("@ID_Usuario", _usuario)
            .agregarCadena("@Boton", NombreBtn)
        End With

        Dim rpta As DataTable = _conexion.ejecutarSP_DataTable()
        Return rpta.Rows.Count > 0
    End Function

End Class