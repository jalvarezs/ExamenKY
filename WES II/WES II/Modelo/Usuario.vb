
Public Class Usuario
    Public Shared Function listar()
        Return _conexion.consultarSP("SP_ListarUsuarios")
    End Function

    Public Shared Function listarPerfiles()
        Return _conexion.consultarSP("SP_ListarPerfiles")
    End Function
    Public Shared Function registrar(ByVal Usuario As String, ByVal Clave As String, ByVal Nombres As String, ByVal Perfil As Integer)
        With _conexion
            .prepararSP("SP_MantenedorUsuarios")
            .agregarCadena("@Usuario", Usuario)
            .agregarCadena("@Clave", Hashing.sha1(Clave))
            .agregarCadena("@Nombres", Nombres)
            .agregarEntero("@ID_Perfil", Perfil)
            .agregarEntero("@Accion", 1)
        End With
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function modificar(ByVal ID_Usuario As Integer, ByVal Usuario As String, ByVal Clave As String, ByVal Nombres As String, ByVal Perfil As Integer)
        With _conexion
            .prepararSP("SP_MantenedorUsuarios")
            .agregarEntero("@ID_Usuario", ID_Usuario)
            .agregarCadena("@Usuario", Usuario)
            .agregarCadena("@Clave", Hashing.sha1(Clave))
            .agregarCadena("@Nombres", Nombres)
            .agregarEntero("@ID_Perfil", Perfil)
            .agregarEntero("@Accion", 2)
        End With
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function darDeBaja(ByVal ID_Usuario As Integer)
        With _conexion
            .prepararSP("SP_MantenedorUsuarios")
            .agregarEntero("@ID_Usuario", ID_Usuario)
            .agregarEntero("@Accion", 3)
        End With
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function verificarClaves(ByVal ID_Usuario As Integer, ByVal ClaveN As String)
        With _conexion
            .prepararSP("SP_VerificarClave")
            .agregarEntero("@ID_Usuario", ID_Usuario)
            .agregarCadena("@ClaveNueva", Hashing.sha1(ClaveN))
        End With
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function validarLogin(ByVal Usuario As String, ByVal Clave As String)
        With _conexion
            .prepararSP("SP_ValidarLogin")
            .agregarCadena("@Usuario", Usuario)
            .agregarCadena("@Clave", Hashing.sha1(Clave))
        End With

        Dim rpta As DataTable = _conexion.ejecutarSP_DataTable()
        If rpta.Rows.Count > 0 Then
            Return rpta.Rows(0)(0)
        End If

        Return 0
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