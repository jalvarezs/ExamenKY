Public Class FormPrincipal

    ' Click en el botón de Productos
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        ' Abrimos la interfaz para administrar productos
        If Usuario.tieneAcceso("Materiales") Then
            Dim form As New FormMateriales
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Click en el botón de Familias
    Private Sub btnFamilias_Click(sender As Object, e As EventArgs) Handles btnFamilias.Click
        ' Abrimos la interfaz para administrar familias de productos
        If Usuario.tieneAcceso("Familias") Then
            Dim form As New FormFamilias
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles optSalir.Click
        Me.Close()
    End Sub

    ' Click en el botón de Marcas
    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        ' Abrimos la interfaz para administrar marcas de productos
        If Usuario.tieneAcceso("Marcas") Then
            Dim form As New FormMarcas
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Click en el botón de Clientes
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ' Abrimos la interfaz para administrar clientes
        If Usuario.tieneAcceso("Clientes") Then
            Dim form As New FormClientes
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        ' Abrimos la interfaz para administrar proveedores
        If Usuario.tieneAcceso("Proveedores") Then
            Dim form As New FormProveedores
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        ' Abrimos la interfaz para administrar clientes
        If Usuario.tieneAcceso("Almacenes") Then
            Dim form As New FormAlmacenes
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPerfiles_Click(sender As Object, e As EventArgs) Handles btnPerfiles.Click
        ' Abrimos la interfaz para administrar perfiles
        If Usuario.tieneAcceso("Perfiles") Then
            Dim form As New FormPerfiles
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With opcionesTabs
            .SizeMode = TabSizeMode.Fixed
            .ItemSize = New Size(0, 1)
            .Appearance = TabAppearance.Buttons
        End With

        For Each pagina As TabPage In opcionesTabs.TabPages
            pagina.BackgroundImage = Global.WES_II.My.Resources.Resources.blue_flat_design
            pagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            pagina.BackColor = Color.Aqua
        Next

    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles optConfiguracion.Click
        opcionesTabs.SelectedIndex = 0
    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles optOperaciones.Click
        opcionesTabs.SelectedIndex = 1
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles optReportes.Click
        opcionesTabs.SelectedIndex = 2
    End Sub

    Private Sub btnCotizaciones_Click(sender As Object, e As EventArgs) Handles optCotizaciones.Click
        opcionesTabs.SelectedIndex = 3
    End Sub

    Private Sub btnOrdenes_Click(sender As Object, e As EventArgs) Handles btnOrdenes.Click
        ' Abrimos la interfaz para administrar las órdenes de compra
        If Usuario.tieneAcceso("Órdenes de compra") Then
            Dim form As New FormOrdenCompra(False)
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnIngresoMat_Click(sender As Object, e As EventArgs) Handles btnIngresoMat.Click
        If Usuario.tieneAcceso("Ingreso de materiales") Then
            Dim form As New FormIngresoMaterial
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSalidaMat_Click(sender As Object, e As EventArgs) Handles btnSalidaMat.Click
        ' Abrimos la interfaz para administrar la salida de almacén
        If Usuario.tieneAcceso("Salida de materiales") Then
            Dim form As New FormSalidaMaterial
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAltaReq_Click(sender As Object, e As EventArgs) Handles btnAltaReq.Click
        ' Abrimos la interfaz para administrar requerimientos
        If Usuario.tieneAcceso("Alta de requerimientos") Then
            Dim form As New FormRequerimientos
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnAprobacionReq_Click(sender As Object, e As EventArgs) Handles btnAprobacionReq.Click
        ' Abrimos la interfaz para administrar la aprobación de req
        If Usuario.tieneAcceso("Aprobación de requerimientos") Then
            Dim form As New FormAprobacionRequerimiento
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnContenedores_Click(sender As Object, e As EventArgs) Handles btnContenedores.Click
        ' Abrimos la interfaz para administrar los contenedores
        If Usuario.tieneAcceso("Contenedores") Then
            Dim form As New FormContenedor
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnModifStock_Click(sender As Object, e As EventArgs) Handles btnModifStock.Click
        ' Abrimos la interfaz para administrar el contenido de contenedores
        If Usuario.tieneAcceso("Modificaciones de stock") Then
            Dim form As New FormTrasladarStock
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnProyectos_Click(sender As Object, e As EventArgs) Handles btnProyectos.Click
        ' Abrimos la interfaz para administrar los proyectos
        If Usuario.tieneAcceso("Proyectos") Then
            Dim form As New FormProyectos
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUbicaciones_Click(sender As Object, e As EventArgs) Handles btnUbicaciones.Click
        ' Abrimos la interfaz para administrar ubicaciones
        If Usuario.tieneAcceso("Ubicaciones") Then
            Dim form As New FormUbicaciones
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnOfertas_Click(sender As Object, e As EventArgs) Handles btnOfertas.Click

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        ' Abrimos la interfaz para administrar usuarios
        If Usuario.tieneAcceso("Usuarios") Then
            Dim form As New FormUsuario
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSugerencias_Click(sender As Object, e As EventArgs) Handles btnSugerencias.Click
        ' Abrimos la interfaz con las sugerencias de compra
        If Usuario.tieneAcceso("Sugerencias de compra") Then
            Dim form As New FormOrdenCompra(True)
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCotizaciones_Click_1(sender As Object, e As EventArgs) Handles btnCotizaciones.Click
        Dim form As New FormCotizaciones()
        form.ShowDialog()
    End Sub

    Private Sub btnIniciosTrabajo_Click(sender As Object, e As EventArgs) Handles btnIniciosTrabajo.Click
        Dim form As New FormIniciosTrabajo()
        form.ShowDialog()
    End Sub

    Private Sub btnControlServicios_Click(sender As Object, e As EventArgs) Handles btnControlServicios.Click
        Dim form As New FormControlServicios
        form.ShowDialog()
    End Sub

    Private Sub btnReporteIngresos_Click(sender As Object, e As EventArgs) Handles btnReporteIngresos.Click
        Dim form As New Reporte_Ingresos()
        form.ShowDialog()
    End Sub

    Private Sub btnReporteSalidas_Click(sender As Object, e As EventArgs) Handles btnReporteSalidas.Click
        Dim form As New Reporte_Salidas()
        form.ShowDialog()
    End Sub


    Private Sub btnReporteMovimientos_Click(sender As Object, e As EventArgs) Handles btnReporteMovimientos.Click
        Dim form As New Reporte_Movimientos_Stock()
        form.ShowDialog()
    End Sub

    Private Sub btnConsultarStock_Click(sender As Object, e As EventArgs) Handles btnConsultarStock.Click
        ' El formulario siguiente mostrará el stock de todos los materiales sumando las cantidades en los contenedores
        Dim form As New FormConsultarStock()
        form.ShowDialog()
    End Sub

    Private Sub btnZonas_Click(sender As Object, e As EventArgs) Handles btnZonas.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim form As New FormInventarios()
        form.ShowDialog()



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If Usuario.tieneAcceso("Carga Facturas") Then
            Dim form As New frmCargaFactura
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If Usuario.tieneAcceso("Listado Facturas") Then
            Dim form As New frmListarFactura
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        If Usuario.tieneAcceso("UsuarioCF") Then
            Dim form As New CargarUsuario
            form.ShowDialog()
        Else
            MessageBox.Show("Usted no tiene acceso a esta área.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub BtnReporteCotizacion_Click(sender As Object, e As EventArgs) Handles BtnReporteCotizacion.Click
        Dim form As New Reporte_Cotizacion()
        form.ShowDialog()
    End Sub

    Private Sub btnQuiebreStock_Click(sender As Object, e As EventArgs) Handles btnQuiebreStock.Click
        Try
            Dim form As New FormQuiebreStock()
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuiebreStockOT_Click(sender As Object, e As EventArgs) Handles btnQuiebreStockOT.Click
        Try
            Dim form As New FormQuiebreStockPorOT()
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStockArticuloSum_Click(sender As Object, e As EventArgs) Handles btnStockArticuloSum.Click
        Try
            Dim form As New Reporte_Stock_Articulo_Sumarizado()
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStockArticuloContenedor_Click(sender As Object, e As EventArgs) Handles btnStockArticuloContenedor.Click
        Try
            Dim form As New Reporte_Stock_Articulo()
            form.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class