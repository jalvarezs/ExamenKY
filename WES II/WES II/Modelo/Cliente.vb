Public Class Cliente
    Public Shared Function listar() As DataTable
        Return _conexion.consultarSP("SP_ListarClientes")
    End Function

    Public Shared Function buscar(ByVal nombre As String) As DataTable
        _conexion.prepararSP("SP_BuscarCliente")
        _conexion.agregarCadena("@nombre", nombre)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function buscarPorId(ByVal idCliente As Integer) As DataTable
        _conexion.prepararSP("SP_BuscarCliente_x_Id")
        _conexion.agregarEntero("@idCliente", idCliente)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function busqueda_inteligente(ByVal nombre As String, ByVal RUC As String, ByVal distrito As String)
        'Realiza una busqueda con parametro a la db
        With _conexion
            .prepararSP("SP_BuscarClienteInteligente")
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@RUC", RUC)
            .agregarCadena("@Distrito", distrito)
        End With

        Return _conexion.ejecutarSP_DataTable
    End Function

    Public Shared Function registrar(ByVal nombre As String, ByVal ruc As String, ByVal contacto1 As String, ByVal contacto2 As String, ByVal banco As String, ByVal cuentaCorriente As String, ByVal direccion As String, ByVal telf As String, ByVal telf_sec As String, ByVal email As String, ByVal web As String,
                                     ByVal Distrito As String, ByVal EmailContacto1 As String, ByVal EmailContacto2 As String, ByVal TelefonoContacto1 As String, ByVal TelefonoContacto2 As String, ByVal Banco1 As String, ByVal Banco2 As String, ByVal moneda1 As String, ByVal moneda2 As String, ByVal CuentaCorriente1 As String,
                                     ByVal CuentaCorriente2 As String, ByVal CCI1 As String, ByVal CCI2 As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorCliente")
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@ruc", ruc)
            .agregarCadena("@contacto1", contacto1)
            .agregarCadena("@contacto2", contacto2)
            .agregarCadena("@banco", banco)
            .agregarCadena("@cuentaCorriente", cuentaCorriente)
            .agregarCadena("@direccion", direccion)
            .agregarCadena("@telf", telf)
            .agregarCadena("@telf_sec", telf_sec)
            .agregarCadena("@email", email)
            .agregarCadena("@web", web)
            .agregarCadena("@Distrito", Distrito)
            .agregarCadena("@EmailContacto1", EmailContacto1)
            .agregarCadena("@EmailContacto2", EmailContacto2)
            .agregarCadena("@TelefonoContacto1", TelefonoContacto1)
            .agregarCadena("@TelefonoContacto2", TelefonoContacto2)
            .agregarCadena("@Banco1", Banco1)
            .agregarCadena("@Banco2", Banco2)
            .agregarCadena("@moneda1", moneda1)
            .agregarCadena("@moneda2", moneda2)
            .agregarCadena("@CuentaCorriente1", CuentaCorriente1)
            .agregarCadena("@CuentaCorriente2", CuentaCorriente2)
            .agregarCadena("@CCI1", CCI1)
            .agregarCadena("@CCI2", CCI2)
            .agregarEntero("@accion", 1) ' Insertar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha registrado correctamente el nuevo cliente."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal idCliente As String, ByVal nombre As String, ByVal ruc As String, ByVal contacto1 As String, ByVal contacto2 As String, ByVal banco As String, ByVal cuentaCorriente As String, ByVal direccion As String, ByVal telf As String, ByVal telf_sec As String, ByVal email As String, ByVal web As String,
                                     ByVal Distrito As String, ByVal EmailContacto1 As String, ByVal EmailContacto2 As String, ByVal TelefonoContacto1 As String, ByVal TelefonoContacto2 As String, ByVal Banco1 As String, ByVal Banco2 As String, ByVal moneda1 As String, ByVal moneda2 As String, ByVal CuentaCorriente1 As String,
                                     ByVal CuentaCorriente2 As String, ByVal CCI1 As String, ByVal CCI2 As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorCliente")
            .agregarEntero("@idCliente", idCliente)
            .agregarCadena("@nombre", nombre)
            .agregarCadena("@ruc", ruc)
            .agregarCadena("@contacto1", contacto1)
            .agregarCadena("@contacto2", contacto2)
            .agregarCadena("@banco", banco)
            .agregarCadena("@cuentaCorriente", cuentaCorriente)
            .agregarCadena("@direccion", direccion)
            .agregarCadena("@telf", telf)
            .agregarCadena("@telf_sec", telf_sec)
            .agregarCadena("@email", email)
            .agregarCadena("@web", web)
            .agregarCadena("@Distrito", Distrito)
            .agregarCadena("@EmailContacto1", EmailContacto1)
            .agregarCadena("@EmailContacto2", EmailContacto2)
            .agregarCadena("@TelefonoContacto1", TelefonoContacto1)
            .agregarCadena("@TelefonoContacto2", TelefonoContacto2)
            .agregarCadena("@Banco1", Banco1)
            .agregarCadena("@Banco2", Banco2)
            .agregarCadena("@moneda1", moneda1)
            .agregarCadena("@moneda2", moneda2)
            .agregarCadena("@CuentaCorriente1", CuentaCorriente1)
            .agregarCadena("@CuentaCorriente2", CuentaCorriente2)
            .agregarCadena("@CCI1", CCI1)
            .agregarCadena("@CCI2", CCI2)
            .agregarEntero("@accion", 2) ' Modificar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha modificado correctamente el cliente."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal idCliente As Integer) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorCliente")
            .agregarEntero("@idCliente", idCliente)
            .agregarEntero("@accion", 3) ' Eliminar
        End With

        respuesta = _conexion.ejecutarSP_String()
        If respuesta Is "" Then
            respuesta = "Se ha eliminado el cliente indicado."
        End If
        Return respuesta
    End Function
End Class
