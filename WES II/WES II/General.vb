Module General

    ' Variable conexión general

    Public _databaseName As String = System.Configuration.ConfigurationManager.AppSettings("DATABASE_SQLSERVER")

    Public _conexion As New Conexion(_databaseName)

    ' ID del usuario que ha iniciado sesión
    Public _usuario As Integer

End Module
