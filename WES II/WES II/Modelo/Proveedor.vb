Public Class Proveedor

    Public Shared Function listar() As DataTable
        Return _conexion.consultarSP("SP_ListarProveedores")
    End Function

    Public Shared Function listarMateriales(ByVal id As Integer) As DataTable
        _conexion.prepararSP("SP_ListarMaterialesProveedor")
        _conexion.agregarEntero("@idProveedor", id)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function eliminarMaterial(ByVal idProveedor As Integer, ByVal idMaterial As Integer) As String
        _conexion.prepararSP("SP_MantenedorMaterialesProveedor")
        _conexion.agregarEntero("@idProveedor", idProveedor)
        _conexion.agregarEntero("@idMaterial", idMaterial)
        _conexion.agregarEntero("@accion", 2) ' Acción 2 es Eliminar
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function agregarMaterial(ByVal idProveedor As Integer, ByVal idMaterial As Integer) As String
        _conexion.prepararSP("SP_MantenedorMaterialesProveedor")
        _conexion.agregarEntero("@idProveedor", idProveedor)
        _conexion.agregarEntero("@idMaterial", idMaterial)
        _conexion.agregarEntero("@accion", 1) ' Acción 1 es Insertar
        Return _conexion.ejecutarSP_String()
    End Function

    Public Shared Function buscar(ByVal nombre As String) As DataTable
        _conexion.prepararSP("SP_BuscarProveedor")
        _conexion.agregarCadena("@nombre", nombre)
        Return _conexion.ejecutarSP_DataTable()
    End Function
    Public Shared Function buscarXnombre(ByVal nombre As String) As DataTable
        'Se agrega function de busqueda por nombre para obtener id del proveedor
        'creado el 04/10/19
        _conexion.prepararSP("SP_BuscarProvxNombre")
        _conexion.agregarCadena("@nombre", nombre)
        Return _conexion.ejecutarSP_DataTable()
    End Function


    Public Shared Function listarSegunMaterial(ByVal idMaterial As String) As DataTable
        _conexion.prepararSP("SP_ProveedoresPorMaterial")
        _conexion.agregarEntero("@idMaterial", idMaterial)
        Return _conexion.ejecutarSP_DataTable()
    End Function

    Public Shared Function registrar(ByVal nombre As String, ByVal ruc As String, ByVal contacto1 As String, ByVal contacto2 As String, ByVal banco As String, ByVal cuentaCorriente As String, ByVal direccion As String, ByVal telf As String, ByVal telf_sec As String, ByVal email As String, ByVal web As String,
                                     ByVal Distrito As String, ByVal EmailContacto1 As String, ByVal EmailContacto2 As String, ByVal TelefonoContacto1 As String, ByVal TelefonoContacto2 As String, ByVal Banco1 As String, ByVal Banco2 As String, ByVal moneda1 As String, ByVal moneda2 As String, ByVal CuentaCorriente1 As String,
                                     ByVal CuentaCorriente2 As String, ByVal CCI1 As String, ByVal CCI2 As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorProveedor")
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
            respuesta = "Se ha registrado correctamente el nuevo proveedor."
        End If

        Return respuesta
    End Function

    Public Shared Function modificar(ByVal idProveedor As String, ByVal nombre As String, ByVal ruc As String, ByVal contacto1 As String, ByVal contacto2 As String, ByVal banco As String, ByVal cuentaCorriente As String, ByVal direccion As String, ByVal telf As String, ByVal telf_sec As String, ByVal email As String, ByVal web As String,
                                     ByVal Distrito As String, ByVal EmailContacto1 As String, ByVal EmailContacto2 As String, ByVal TelefonoContacto1 As String, ByVal TelefonoContacto2 As String, ByVal Banco1 As String, ByVal Banco2 As String, ByVal moneda1 As String, ByVal moneda2 As String, ByVal CuentaCorriente1 As String,
                                     ByVal CuentaCorriente2 As String, ByVal CCI1 As String, ByVal CCI2 As String) As String
        Dim respuesta As String

        With _conexion
            .prepararSP("SP_MantenedorProveedor")
            .agregarEntero("@idProveedor", idProveedor)
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
            respuesta = "Se ha modificado correctamente el proveedor."
        End If

        Return respuesta
    End Function

    Public Shared Function eliminar(ByVal id As String) As String

        Dim respuesta As String

        Try

            Dim dt As New DataTable
            dt = proveedorPorDetalleContenedor(CInt(id))

            If dt.Rows.Count > 0 Then
                respuesta = "El proveedor no puede ser eliminado, ya que tiene stock"
            Else
                With _conexion
                    .prepararSP("SP_MantenedorProveedor")
                    .agregarEntero("@idProveedor", id)
                    .agregarEntero("@accion", 3) ' Eliminar
                End With

                respuesta = _conexion.ejecutarSP_String()
                If respuesta Is "" Then
                    respuesta = "Se ha eliminado correctamente el proveedor."
                End If
            End If

        Catch ex As Exception
            respuesta = ex.Message
        End Try

        Return respuesta


    End Function

    Public Shared Function proveedorPorDetalleContenedor(ByVal idProveedor As Integer) As DataTable
        _conexion.prepararSP("SP_Proveedor_x_Detalle_Contenedor")
        _conexion.agregarCadena("@idProveedor", idProveedor)
        Return _conexion.ejecutarSP_DataTable()
    End Function

End Class
