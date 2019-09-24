Public Class FormIniciosTrabajo

    Private IdMaterial As String
    Private PrecioUnitario As Decimal
    Private IdCotizacion As Integer
    Private IdOrdenServicio As Integer

    'Listado de Ordenes de Trabajo
    Private ListaInicioTrabajo As New List(Of EntidadInicioTrabajo)

    'Listado de Datos Cotización Plantilla
    Private ListaCotizacionDetalle As New List(Of DetalleCotizacion)
    Private IdClienteBusqueda As String

    'Entidad Examinar Detalle OSE
    Private InicioTra_bDetalle_OSE As InicioTrabajoDetalleSOE

    'Id Orden Trabajo Actual
    Private IdOrdenTrabajoActual As Integer = -1
    Private NuevaOrdenTrabajoActual As EntidadInicioTrabajo

    Private tt As ToolTip

    Private Sub FormIniciosTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarTipoOrdenTrabajo()

            LimpiarDatosFormulario()

            txtEstado.Text = "POR EJECUTAR"
            btnExamCotizacion.Enabled = False

            CargarEstadosOT()

            btnCancelarNuevoItemOT.Enabled = False
            btnGuardarItemOT.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarDatosFormulario()

        'txtEstado.Text = ""
        txtCodigoOT.Text = ""

        txtCotizacion.Text = ""
        IdCotizacion = 0
        btnExamCotizacion.Enabled = False
        txtCliente.Text = ""
        txtDescripcionCoti.Text = ""

        CargarCotizacionDetallesItems()
        cbCotizacionDetalleItem.SelectedValue = 0
        txtTitulo.Text = ""
        txtDescripcionDetalleItem.Text = ""

        'Limpiar Materiales
        txtMaterial.Text = ""
        txtCantMateriales.Text = ""
        txtTotalMateriales.Text = ""
        dgvMateriales.Rows.Clear()

        'Limpiar Personal
        txtCantEmpleados.Text = ""
        cboCargos.Text = ""
        dgvEmpleados.Rows.Clear()

        'Limpiar OSE
        txtNroOSE.Text = ""
        dgvOrdenesServicio.Rows.Clear()

    End Sub

    Private Sub btnExamCotizacion_Click(sender As Object, e As EventArgs) Handles btnExamCotizacion.Click
        Try
            Dim form As New ExamCotizacion(txtCotizacion)
            form.ShowDialog()

            ' Carga desde la BD los datos de la cotización seleccionada
            If txtCotizacion.Text.Trim = "" Then
                Return
            End If

            IdCotizacion = CInt(txtCotizacion.Text) - 10000

            ListaInicioTrabajo = New List(Of EntidadInicioTrabajo)

            CargarDatosCotizacion()

            CargarCotizacionDetallesItems()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarDatosCotizacion()
        Try

            Dim dtCoti As DataTable = WES_II.Cotizacion.ObtenerCotizacion(IdCotizacion)
            If dtCoti IsNot Nothing Then
                Dim rowCoti As DataRow = dtCoti.AsEnumerable.FirstOrDefault

                txtCliente.Text = rowCoti("Cliente")
                txtDescripcionCoti.Text = rowCoti("Descripcion")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarDetallePersonal()
        Try

            Dim idDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue
            Dim detalleCoti As DetalleCotizacion = ListaCotizacionDetalle.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))

            dgvEmpleados.Rows.Clear()

            Dim idInicioTrabajo As Integer
            'Orden Trabajo Nueva
            If IdOrdenTrabajoActual < 0 Then
                idInicioTrabajo = IdOrdenTrabajoActual
            Else
                idInicioTrabajo = cbOrdenTrabajoItem.SelectedValue
            End If

            Dim entidadInicioTrabajo As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idInicioTrabajo))

            For Each row As CotizacionDetallePersonal In detalleCoti.LstDetallePersonal

                Dim iniTraDetallePersonal As New InicioTrabajoDetallePersonal
                iniTraDetallePersonal.IdInicioTrabajo = idInicioTrabajo
                iniTraDetallePersonal.IdCotizacion = IdCotizacion
                iniTraDetallePersonal.ID_CotizacionDetalleItem = idDetalleItem
                iniTraDetallePersonal.Personal = row.Personal
                iniTraDetallePersonal.Cantidad = row.Cantidad
                iniTraDetallePersonal.Duracion_Dias = 0
                iniTraDetallePersonal.Duracion_Horas = 0

                entidadInicioTrabajo.LstDetallePersonal.Add(iniTraDetallePersonal)

                dgvEmpleados.Rows.Add(row.Personal, 0, 0, row.Cantidad)
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarDetalleMateriales()
        Try
            Dim idDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue

            Dim detalleCoti As DetalleCotizacion = ListaCotizacionDetalle.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))

            dgvMateriales.Rows.Clear()

            Dim idInicioTrabajo As Integer
            'Orden Trabajo Nueva
            If IdOrdenTrabajoActual < 0 Then
                idInicioTrabajo = IdOrdenTrabajoActual
            Else
                idInicioTrabajo = cbOrdenTrabajoItem.SelectedValue
            End If

            Dim detalleOT As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idInicioTrabajo))

            For Each row As CotizacionDetalleMaterial In detalleCoti.LstDetalleMateriales

                Dim codMaterial As String = row.Codigo
                Dim material As String = row.NombreMaterial
                Dim cantidad As Integer = row.Cantidad
                Dim pUnitario As Decimal = row.Precio_Unitario
                Dim subTotal As Decimal = cantidad * pUnitario

                Dim dias As Integer = row.Duracion_Dias
                Dim horas As Integer = row.Duracion_Horas

                dgvMateriales.Rows.Add(codMaterial, material, cantidad, pUnitario, dias, horas, subTotal)

                If detalleOT IsNot Nothing Then
                    Dim iniTrabDetalleMaterial As New InicioTrabajoDetalleMaterial
                    iniTrabDetalleMaterial.IdInicioTrabajo = idInicioTrabajo
                    iniTrabDetalleMaterial.ID_DetalleItem = idDetalleItem
                    iniTrabDetalleMaterial.Codigo = codMaterial
                    iniTrabDetalleMaterial.NombreMaterial = material
                    iniTrabDetalleMaterial.Cantidad = cantidad
                    iniTrabDetalleMaterial.Precio_Unitario = pUnitario
                    iniTrabDetalleMaterial.Duracion_Dias = dias
                    iniTrabDetalleMaterial.Duracion_Horas = horas
                    iniTrabDetalleMaterial.Precio_Total = subTotal
                    iniTrabDetalleMaterial.ID_Material = codMaterial - 10000
                    detalleOT.LstDetalleMateriales.Add(iniTrabDetalleMaterial)
                End If

            Next

            ActualizarTotalMateriales()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAddPersonal_Click(sender As Object, e As EventArgs) Handles btnAddPersonal.Click
        Try
            Dim idInicioTrabajo As Integer = cbOrdenTrabajoItem.SelectedValue

            'Orden Trabajo Nueva
            If IdOrdenTrabajoActual < 0 Then
                idInicioTrabajo = IdOrdenTrabajoActual
            Else

                If idInicioTrabajo.Equals(0) Then
                    MessageBox.Show("Por favor, seleccione una OT", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbOrdenTrabajoItem.Select()
                    Return
                End If
            End If

            If cboCargos.Text = "" Then
                MessageBox.Show("Seleccione un cargo para el personal a asignar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboCargos.Select()
                Return
            End If

            Dim cantEmpleados As Integer = 0
            Try
                cantEmpleados = UtilConvertidor.GetInteger(txtCantEmpleados.Text)

                If cantEmpleados.Equals(0) Then
                    MessageBox.Show("El número de trabajadores debe ser diferente de cero", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCantEmpleados.Select()
                    Return
                End If
            Catch
                MessageBox.Show("Ingrese una cantidad válida para el número de trabajadores.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCantEmpleados.Select()
                Return
            End Try

            Dim entidadInicioTrabajo As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idInicioTrabajo))

            Dim iniTraDetallePersonal As New InicioTrabajoDetallePersonal
            iniTraDetallePersonal.IdInicioTrabajo = idInicioTrabajo
            iniTraDetallePersonal.IdCotizacion = IdCotizacion
            iniTraDetallePersonal.ID_CotizacionDetalleItem = cbCotizacionDetalleItem.SelectedValue
            iniTraDetallePersonal.Personal = cboCargos.Text

            iniTraDetallePersonal.Duracion_Dias = NudDuracionDiasPersonal.Value
            iniTraDetallePersonal.Duracion_Horas = NudDuracionHorasPersonal.Value

            iniTraDetallePersonal.Cantidad = cantEmpleados
            entidadInicioTrabajo.LstDetallePersonal.Add(iniTraDetallePersonal)

            dgvEmpleados.Rows.Add(cboCargos.Text, NudDuracionDiasPersonal.Value, NudDuracionHorasPersonal.Value, cantEmpleados)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnElimEmpleados_Click(sender As Object, e As EventArgs) Handles btnElimEmpleados.Click
        Try
            Dim filaActual As Integer = dgvEmpleados.CurrentCell.RowIndex
            dgvEmpleados.Rows.RemoveAt(filaActual)

            'Eliminar todos los datos de la lista temporal
            Dim idInicioTrabajo As Integer
            'Orden Trabajo Nueva
            If IdOrdenTrabajoActual < 0 Then
                idInicioTrabajo = IdOrdenTrabajoActual
            Else
                idInicioTrabajo = cbOrdenTrabajoItem.SelectedValue
            End If

            Dim entidadInicioTrabajo As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idInicioTrabajo))

            entidadInicioTrabajo.LstDetallePersonal = New List(Of InicioTrabajoDetallePersonal)

            'Cargar datos a la lista temporal desde DataGrid
            For Each row As DataGridViewRow In dgvEmpleados.Rows

                Dim iniTrabDetallePersonal As New InicioTrabajoDetallePersonal
                iniTrabDetallePersonal.IdInicioTrabajo = idInicioTrabajo
                iniTrabDetallePersonal.IdCotizacion = IdCotizacion
                iniTrabDetallePersonal.ID_CotizacionDetalleItem = cbCotizacionDetalleItem.SelectedValue
                iniTrabDetallePersonal.Personal = row.Cells("Cargo").Value
                iniTrabDetallePersonal.Cantidad = row.Cells("CantidadPersonal").Value
                entidadInicioTrabajo.LstDetallePersonal.Add(iniTrabDetallePersonal)
            Next

        Catch
            MessageBox.Show("Debe seleccionar la fila del personal a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnElimMateriales_Click(sender As Object, e As EventArgs) Handles btnElimMateriales.Click
        Try
            Dim filaActual As Integer = dgvMateriales.CurrentCell.RowIndex
            dgvMateriales.Rows.RemoveAt(filaActual)

            'Eliminar todos los datos de la lista temporal
            Dim ordenTrabajoItem As Integer = IdOrdenTrabajoActual

            Dim detalleCoti As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(ordenTrabajoItem))
            If detalleCoti IsNot Nothing Then

                detalleCoti.LstDetalleMateriales = New List(Of InicioTrabajoDetalleMaterial)

                'Cargar datos a la lista temporal desde DataGrid
                For Each row As DataGridViewRow In dgvMateriales.Rows
                    Dim cotiDetMaterial As New InicioTrabajoDetalleMaterial
                    cotiDetMaterial.ID_Cotizacion = IdCotizacion
                    cotiDetMaterial.ID_DetalleItem = ordenTrabajoItem
                    cotiDetMaterial.Codigo = row.Cells("Codigo").Value
                    cotiDetMaterial.NombreMaterial = row.Cells("NombreMaterial").Value
                    cotiDetMaterial.Cantidad = row.Cells("Cantidad").Value
                    cotiDetMaterial.Precio_Unitario = row.Cells("PrecioUnit").Value
                    cotiDetMaterial.Precio_Total = row.Cells("PrecioTot").Value
                    cotiDetMaterial.ID_Material = CInt(row.Cells("Codigo").Value) - 10000
                    detalleCoti.LstDetalleMateriales.Add(cotiDetMaterial)
                Next

            End If

            ActualizarTotalMateriales()

        Catch
            MessageBox.Show("Debe seleccionar la fila del detalle a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddMaterial_Click(sender As Object, e As EventArgs) Handles btnAddMaterial.Click
        Try
            Dim idDetalleItem As Integer

            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue

            If idTipoOrden.Equals(1) Then
                idDetalleItem = 0
            Else
                If txtCotizacion.Text.Trim.Equals("") Then
                    MessageBox.Show("Por favor, seleccione una cotización", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    btnExamCotizacion.Select()
                    Return
                End If

                If txtTitulo.Text.Trim.Equals("") Then
                    MessageBox.Show("Por favor, ingrese un título para el Inicio de Trabajo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtTitulo.Select()
                    Return
                End If

                idDetalleItem = cbCotizacionDetalleItem.SelectedValue
                If idDetalleItem.Equals(0) Then
                    MessageBox.Show("Por favor, seleccione un  Item", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                If txtMaterial.Text.Trim.Equals("") Then
                    MessageBox.Show("Por favor, seleccione un material", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    btnExamMaterial.Select()
                    Return
                End If

            End If


            AgregarFila()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub AgregarFila()

        Dim nuevaFila As Boolean = True

        Dim cantMateriales As Integer = 0
        cantMateriales = UtilConvertidor.GetInteger(txtCantMateriales.Text)

        If cantMateriales.Equals(0) Then
            MessageBox.Show("La cantidad de materiales debe ser diferente de cero", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantMateriales.Select()
            Return
        End If

        ' Buscamos si el material ya se registró antes
        For j As Integer = 0 To dgvMateriales.Rows.Count - 1
            Dim dato As String = txtMaterial.Text

            If dgvMateriales.Rows(j).Cells("NombreMaterial").Value.ToString = dato Then

                nuevaFila = False
                If deseaSumarCantidad() Then
                    SumarCantidad(j)
                End If

                ' Termina con el método, ya no se agrega fila
                ActualizarTotalMateriales()

            End If
        Next

        If nuevaFila Then
            ' Es un nuevo material, se añade una nueva fila
            Dim cantidad As Decimal = CDec(txtCantMateriales.Text.Trim)
            Dim precio As Decimal = CDec(PrecioUnitario)
            Dim total As Decimal = cantidad * precio

            Dim diasMaterial As Integer = NudDuracionDiasMaterial.Value
            Dim horasMaterial As Integer = NudDuracionHorasMaterial.Value


            dgvMateriales.Rows.Add(IdMaterial, txtMaterial.Text.Trim, txtCantMateriales.Text.Trim, PrecioUnitario, diasMaterial, horasMaterial, total)

            Dim idDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue



            Dim idInicioTrabajo As Integer
            'Orden Trabajo Nueva
            If IdOrdenTrabajoActual < 0 Then
                idInicioTrabajo = IdOrdenTrabajoActual
            Else
                idInicioTrabajo = cbOrdenTrabajoItem.SelectedValue
            End If

            Dim detalleCoti As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idInicioTrabajo))
            If detalleCoti IsNot Nothing Then
                Dim iniTrabDetalleMaterial As New InicioTrabajoDetalleMaterial
                iniTrabDetalleMaterial.IdInicioTrabajo = idInicioTrabajo
                iniTrabDetalleMaterial.ID_DetalleItem = idDetalleItem
                iniTrabDetalleMaterial.Codigo = IdMaterial
                iniTrabDetalleMaterial.NombreMaterial = txtMaterial.Text.Trim
                iniTrabDetalleMaterial.Cantidad = cantidad
                iniTrabDetalleMaterial.Duracion_Dias = diasMaterial
                iniTrabDetalleMaterial.Duracion_Horas = horasMaterial
                iniTrabDetalleMaterial.Precio_Unitario = precio
                iniTrabDetalleMaterial.Precio_Total = total
                iniTrabDetalleMaterial.ID_Material = IdMaterial - 10000
                detalleCoti.LstDetalleMateriales.Add(iniTrabDetalleMaterial)
            End If

            ' Sea por el aumento o por la nueva fila insertada
            ActualizarTotalMateriales()

        End If

    End Sub

    Private Sub SumarCantidad(ByVal j As String)
        Try
            Dim cantidadPrevia As Decimal = CDbl(dgvMateriales.Rows(j).Cells("Cantidad").Value.ToString)
            Dim cantAdicional As Decimal = CDbl(txtCantMateriales.Text)
            dgvMateriales.Rows(j).Cells("Cantidad").Value = CStr(cantidadPrevia + cantAdicional)

            'Actualizar Listado Temporal
            Dim idDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue

            Dim idInicioTrabajo As Integer
            'Orden Trabajo Nueva
            If IdOrdenTrabajoActual < 0 Then
                idInicioTrabajo = IdOrdenTrabajoActual
            Else
                idInicioTrabajo = cbOrdenTrabajoItem.SelectedValue
            End If

            Dim idCodigoMaterial As String = dgvMateriales.Rows(j).Cells("Codigo").Value

            Dim detalleCotizacion As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(q) q.IdInicioTrabajo.Equals(idInicioTrabajo))
            If detalleCotizacion IsNot Nothing Then
                Dim detalleMateriales As InicioTrabajoDetalleMaterial = detalleCotizacion.LstDetalleMateriales.FirstOrDefault(Function(z) z.Codigo.Equals(idCodigoMaterial))
                If detalleMateriales IsNot Nothing Then
                    detalleMateriales.Cantidad = CStr(cantidadPrevia + cantAdicional)
                End If
            End If

        Catch
            MessageBox.Show("Por favor ingrese cantidades válidas.")
        End Try
    End Sub

    Private Sub ActualizarTotalMateriales()
        Try
            Dim totalMateriales As Decimal = 0

            For Each row As DataGridViewRow In dgvMateriales.Rows
                Dim cantidad As Decimal = CDec(row.Cells("Cantidad").Value)
                Dim precio As Decimal = CDec(row.Cells("PrecioUnit").Value)
                Dim total As Decimal = cantidad * precio

                row.Cells("PrecioTot").Value = total

                totalMateriales += total
            Next

            txtTotalMateriales.Text = totalMateriales
        Catch ex As Exception

        End Try

    End Sub

    Private Function deseaSumarCantidad() As Boolean
        Dim msg As String = "El material ya ha sido agregado, desea añadir la cantidad indicada?"
        Dim title As String = "Sugerencia"
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or
           MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

        ' Mostrar la caja de entrada
        response = MsgBox(msg, style, title)

        ' Devuelve TRUE si aceptó
        Return response = MsgBoxResult.Yes
    End Function

    Private Sub btnExamMaterial_Click(sender As Object, e As EventArgs) Handles btnExamMaterial.Click
        Try
            Dim idDetalleItem As Integer

            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue
            If idTipoOrden.Equals(1) Then
                idDetalleItem = 0
            Else
                idDetalleItem = cbCotizacionDetalleItem.SelectedValue
                If idDetalleItem.Equals(0) Then
                    MessageBox.Show("Por favor, seleccione un  Item", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If

            Dim form As New ExamMaterial(txtMaterial)
            form.ShowDialog()
            IdMaterial = form.getCode()
            PrecioUnitario = CDec(form.getPrecio())
        Catch ex As Exception

        End Try

    End Sub

    Private Function ValidaGrabacion() As Boolean
        Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue
        If idTipoOrden.Equals(0) Then
            MessageBox.Show("Seleccione un Tipo de Orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        If Not idTipoOrden.Equals(1) Then
            If txtCotizacion.Text.Equals("") Then
                MessageBox.Show("Seleccione una Cotización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If ListaInicioTrabajo.Count.Equals(0) Then
                MessageBox.Show("La Cotización no contiene ningún Item ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        Return True

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not ValidaGrabacion() Then
            Return
        End If


        Try
            If ListaInicioTrabajo.Where(Function(x) x.EstadoOperacion.Equals("GRABADA")).Any Then

                _conexion.iniciarTransaccion()

                For Each entidadInicioTrabajo As EntidadInicioTrabajo In ListaInicioTrabajo.Where(Function(x) x.EstadoOperacion.Equals("GRABADA"))

                    'Registrar Inicio Trabajo
                    Dim rpta As String = InicioTrabajo.RegistrarInicioTrabajo(entidadInicioTrabajo.IDCotizacion,
                                                                              entidadInicioTrabajo.TituloOT,
                                                                              entidadInicioTrabajo.FechaInicioOT,
                                                                              entidadInicioTrabajo.FechaFinOT,
                                                                              entidadInicioTrabajo.IDCotizacionDetalleItem,
                                                                              entidadInicioTrabajo.CodigoAutoGenerado,
                                                                              entidadInicioTrabajo.EstadoOT,
                                                                              entidadInicioTrabajo.DescripcionOT,
                                                                              entidadInicioTrabajo.TipoOrden)

                    If rpta <> "" Then
                        Throw New System.Exception(rpta)
                    End If

                    Dim idInicioTrabajo As Integer
                    idInicioTrabajo = InicioTrabajo.obtenerUltimoID()

                    'Registrar Detalle de Material
                    For Each detalleMaterial As InicioTrabajoDetalleMaterial In entidadInicioTrabajo.LstDetalleMateriales
                        rpta = InicioTrabajo.RegistrarDetalleMateriales(idInicioTrabajo,
                                                                        detalleMaterial.ID_Material,
                                                                        detalleMaterial.Cantidad,
                                                                        detalleMaterial.ID_DetalleItem,
                                                                        detalleMaterial.Precio_Unitario,
                                                                        detalleMaterial.Duracion_Dias,
                                                                        detalleMaterial.Duracion_Horas,
                                                                        detalleMaterial.Precio_Total)
                        If rpta <> "" Then Throw New System.Exception(rpta)
                    Next

                    'Registrar Detalle de Personal
                    For Each iniTrabDetallePersonal As InicioTrabajoDetallePersonal In entidadInicioTrabajo.LstDetallePersonal
                        rpta = InicioTrabajo.RegistrarDetallePersonal(idInicioTrabajo,
                                                                      iniTrabDetallePersonal.Personal,
                                                                      iniTrabDetallePersonal.Cantidad,
                                                                      iniTrabDetallePersonal.ID_CotizacionDetalleItem,
                                                                      iniTrabDetallePersonal.Duracion_Dias,
                                                                      iniTrabDetallePersonal.Duracion_Horas)

                        If rpta <> "" Then Throw New System.Exception(rpta)
                    Next

                    'Registrar Detalle de Ordenes de Servicio
                    For Each detalleOSE As InicioTrabajoDetalleSOE In entidadInicioTrabajo.LstDetalleOrdenesServcio
                        rpta = InicioTrabajo.RegistrarDetalleOrdenServicio(idInicioTrabajo, detalleOSE.ID_DetalleItem, detalleOSE.ID_Orden_Servicio)
                        If rpta <> "" Then Throw New System.Exception(rpta)
                    Next

                Next

                _conexion.hacerCommit()
                MessageBox.Show("Los datos han sido registrados correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimpiarCampos()
                LimpiarDatosFormulario()
                ListaInicioTrabajo = New List(Of EntidadInicioTrabajo)

            Else
                MessageBox.Show("No existen Items OT para grabar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _conexion.hacerRollBack()
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtCantEmpleados.Text = ""
        txtCantMateriales.Text = ""

        txtCotizacion.Text = ""
        txtTitulo.Text = ""
        txtCliente.Text = ""
        txtDescripcionDetalleItem.Text = ""
        txtMaterial.Text = ""
        txtTotalMateriales.Text = 0

        dgvMateriales.Rows.Clear()
        dgvEmpleados.Rows.Clear()
        dgvOrdenesServicio.Rows.Clear()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            ConsultarOrdenTrabajo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConsultarOrdenTrabajo()
        Try
            dgvOrdenTrabajo.DataSource = Nothing
            dgvDetallesMateriales.DataSource = Nothing
            dgvListarEmpleados.DataSource = Nothing


            Dim fi As Date = DateTime.Parse(dtpBuscarDesde.Value.Date.ToShortDateString())
            Dim ff As Date = DateTime.Parse(dtpBuscarHasta.Value.Date.ToShortDateString()).AddDays(1)

            Dim idCliente As Integer = CInt(IdClienteBusqueda)

            dgvOrdenTrabajo.DataSource = InicioTrabajo.BusquedaOrdenTrabajo(fi, ff, idCliente, cbEstado.SelectedValue, cbTipoOTConsulta.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvInicios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrdenTrabajo.SelectionChanged
        Try
            If dgvOrdenTrabajo.CurrentRow Is Nothing Then
                Return
            End If

            Dim nuevaSeleccion As Integer = dgvOrdenTrabajo.CurrentRow.Index

            Dim id As String = dgvOrdenTrabajo.Item(0, nuevaSeleccion).Value.ToString()
            ActualizarDetalles(id)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActualizarDetalles(ByVal id As String)
        Try
            Dim idInicioTrabajo As Integer = CInt(id) - 10000

            dgvDetallesMateriales.DataSource = InicioTrabajo.ListarDetalles(idInicioTrabajo)
            dgvListarEmpleados.DataSource = InicioTrabajo.ListarPersonal(idInicioTrabajo)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarCotizacionDetallesItems()
        Try
            Dim lista As New List(Of EntidadDropDown)

            Dim entidadNuevoItem As New EntidadDropDown
            entidadNuevoItem.Id = 0
            entidadNuevoItem.Descripcion = "Seleccione"
            lista.Add(entidadNuevoItem)

            Dim dt As DataTable = Cotizacion.BuscarDetalleItems(IdCotizacion)

            For Each dr As DataRow In dt.Rows

                'Cargar Listado Detalle Items
                Dim entidad As New EntidadDropDown
                entidad.Id = dr("ID_DetalleItem")
                entidad.Descripcion = dr("Titulo")
                lista.Add(entidad)

                Dim detalleCoti As New DetalleCotizacion
                detalleCoti.IDDetalleItem = dr("ID_DetalleItem")
                detalleCoti.IDCotizacion = dr("ID_Cotizacion")
                detalleCoti.Titulo = dr("Titulo")
                detalleCoti.DescripcionTrabajo = dr("Descripcion_Trabajo")

                'Cargar los detalles Items Personal
                Dim tablaPersonal As DataTable = Cotizacion.ListarPersonalCotizacionPorItem(IdCotizacion, dr("ID_DetalleItem"))

                For Each row As DataRow In tablaPersonal.Rows
                    Dim cotizaDetPersonal As New CotizacionDetallePersonal
                    cotizaDetPersonal.ID_Cotizacion = row("ID_Cotizacion")
                    cotizaDetPersonal.ID_DetalleItem = row("ID_DetalleItem")
                    cotizaDetPersonal.Personal = row("Personal")
                    cotizaDetPersonal.Cantidad = row("Cantidad")
                    detalleCoti.LstDetallePersonal.Add(cotizaDetPersonal)
                Next

                'Cargar los detalles Items Material
                Dim tablaMaterial As DataTable = Cotizacion.ListarDetallesPorDetalleItem(IdCotizacion, dr("ID_DetalleItem"))

                For Each row As DataRow In tablaMaterial.Rows
                    Dim cotiDetMaterial As New CotizacionDetalleMaterial
                    cotiDetMaterial.ID_Cotizacion = row("ID_Cotizacion")
                    cotiDetMaterial.ID_DetalleItem = row("ID_DetalleItem")
                    cotiDetMaterial.Codigo = row("Código material")
                    cotiDetMaterial.NombreMaterial = row("Material")
                    cotiDetMaterial.EsAlquilerCol = row("Precio alquiler Día") + row("Precio alquiler Hora") > 0
                    cotiDetMaterial.Cantidad = row("Cantidad")
                    cotiDetMaterial.Precio_Unitario = row("Precio unitario")
                    cotiDetMaterial.Duracion_Dias = row("Dias")
                    cotiDetMaterial.Duracion_Horas = row("Horas")
                    cotiDetMaterial.Precio_Alquiler_Dia = row("Precio alquiler Día")
                    cotiDetMaterial.Precio_Alquiler_Hora = row("Precio alquiler Hora")
                    cotiDetMaterial.Descuento = row("Descuento")
                    cotiDetMaterial.Precio_Total = row("Precio Total")
                    cotiDetMaterial.ID_Material = CInt(row("Código material")) - 10000
                    detalleCoti.LstDetalleMateriales.Add(cotiDetMaterial)
                Next

                'Agregar detalle a lista temporal
                ListaCotizacionDetalle.Add(detalleCoti)

            Next

            'Cargar ComboBox Detalle Items
            cbCotizacionDetalleItem.DataSource = lista
            cbCotizacionDetalleItem.ValueMember = "Id"
            cbCotizacionDetalleItem.DisplayMember = "Descripcion"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarOrdenTrabajoItems()
        Try
            Dim lista As New List(Of EntidadDropDown)

            Dim otNuevoItem As New EntidadDropDown
            otNuevoItem.Id = 0
            otNuevoItem.Descripcion = "Seleccione"
            lista.Add(otNuevoItem)

            For Each ordenTrabajoItem As EntidadInicioTrabajo In ListaInicioTrabajo.AsEnumerable.Where(
                Function(x) x.IDCotizacionDetalleItem.Equals(cbCotizacionDetalleItem.SelectedValue) And x.EstadoOperacion.Equals("GRABADA"))

                Dim otItem As New EntidadDropDown
                otItem.Id = ordenTrabajoItem.IdInicioTrabajo
                otItem.Descripcion = ordenTrabajoItem.CodigoOrdenTrabajo
                lista.Add(otItem)
            Next

            'Cargar ComboBox Orden Trabajo Items
            cbOrdenTrabajoItem.DataSource = lista
            cbOrdenTrabajoItem.ValueMember = "Id"
            cbOrdenTrabajoItem.DisplayMember = "Descripcion"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarTipoOrdenTrabajo()
        Try
            Dim lista As New List(Of EntidadDropDown)

            Dim entidadNuevoItem As New EntidadDropDown
            entidadNuevoItem.Id = 0
            entidadNuevoItem.Descripcion = "Seleccione"
            lista.Add(entidadNuevoItem)

            Dim itemInterna As New EntidadDropDown
            itemInterna.Id = 1
            itemInterna.Descripcion = "Interna"
            lista.Add(itemInterna)

            Dim itemExternoa As New EntidadDropDown
            itemExternoa.Id = 2
            itemExternoa.Descripcion = "Externa"
            lista.Add(itemExternoa)

            cbTipoOrden.DataSource = lista
            cbTipoOrden.ValueMember = "Id"
            cbTipoOrden.DisplayMember = "Descripcion"

            cbTipoOTConsulta.DataSource = lista
            cbTipoOTConsulta.ValueMember = "Id"
            cbTipoOTConsulta.DisplayMember = "Descripcion"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbItemDetallesItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCotizacionDetalleItem.SelectedIndexChanged
        Try
            Dim idDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue

            Dim detalleCoti As DetalleCotizacion = ListaCotizacionDetalle.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))

            If detalleCoti IsNot Nothing Then
                txtTitulo.Text = detalleCoti.Titulo
                txtDescripcionDetalleItem.Text = detalleCoti.DescripcionTrabajo
            Else
                txtTitulo.Text = ""
                txtDescripcionDetalleItem.Text = ""
                txtCodigoOT.Text = ""
            End If

            'Cargar OT Items
            CargarOrdenTrabajoItems()

            'Limpiar Ordenes Trabajo Item
            LimpiarDatosOrdenTrabajoItem()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbTipoOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoOrden.SelectedIndexChanged
        Try
            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue

            LimpiarDatosFormulario()

            If idTipoOrden.Equals(1) Then 'Tipo Interna - No tiene cotización
                btnExamCotizacion.Enabled = False
                cbCotizacionDetalleItem.Enabled = False
            End If

            If idTipoOrden.Equals(2) Then 'Tipo Externa - Debe tener Cotización
                btnExamCotizacion.Enabled = True
                cbCotizacionDetalleItem.Enabled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarEstadosOT()
        Try
            Dim lista As New List(Of EntidadDropDown)

            Dim entidadNuevoItem As New EntidadDropDown
            entidadNuevoItem.IdStr = ""
            entidadNuevoItem.Descripcion = "Seleccione"
            lista.Add(entidadNuevoItem)

            Dim itemPorEjecutar As New EntidadDropDown
            itemPorEjecutar.IdStr = "POR EJECUTAR"
            itemPorEjecutar.Descripcion = "POR EJECUTAR"
            lista.Add(itemPorEjecutar)

            Dim itemEnEjecucion As New EntidadDropDown
            itemEnEjecucion.IdStr = "EN EJECUCION"
            itemEnEjecucion.Descripcion = "EN EJECUCION"
            lista.Add(itemEnEjecucion)

            Dim itemLiquidada As New EntidadDropDown
            itemLiquidada.IdStr = "LIQUIDADA"
            itemLiquidada.Descripcion = "LIQUIDADA"
            lista.Add(itemLiquidada)

            Dim itemCerrada As New EntidadDropDown
            itemCerrada.IdStr = "CERRADA"
            itemCerrada.Descripcion = "CERRADA"
            lista.Add(itemCerrada)

            cbEstado.DataSource = lista
            cbEstado.ValueMember = "IdStr"
            cbEstado.DisplayMember = "Descripcion"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExamCliente_Click(sender As Object, e As EventArgs) Handles btnExamCliente.Click
        Try
            Dim form As New ExamCliente(txtClienteBusqueda, txtClienteBusqueda)
            form.ShowDialog()
            IdClienteBusqueda = form.idCliente
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnExaminarOSE_Click(sender As Object, e As EventArgs) Handles btnExaminarOSE.Click
        Try
            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue
            If idTipoOrden.Equals(1) Then
                MessageBox.Show("No se permite agregar una Orden de Servicio a una Orden Interna", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim idDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue
            If idDetalleItem.Equals(0) Then
                MessageBox.Show("Por favor, seleccione un  Item", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim form As New ExamOrdenServicio(IdCotizacion, txtNroOSE)
            form.ShowDialog()
            IdOrdenServicio = CInt(txtNroOSE.Text - 10000)
            InicioTra_bDetalle_OSE = form.InicioTrab_Detalle_OSE

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarOSE_Click(sender As Object, e As EventArgs) Handles btnAgregarOSE.Click
        Try
            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue
            If idTipoOrden.Equals(1) Then
                MessageBox.Show("No se permite agregar una Orden de Servicio a una Orden Interna", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim idCotizacionDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue
            If idCotizacionDetalleItem.Equals(0) Then
                MessageBox.Show("Por favor, seleccione un  Item", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbCotizacionDetalleItem.Select()
                Return
            End If

            If InicioTra_bDetalle_OSE.ID_Orden_Servicio.Equals(0) Then
                Return
            End If

            'Validar que el Servicio Externo no haya sido registrado en algún otro item
            For Each detalleInicioTrabajo As EntidadInicioTrabajo In ListaInicioTrabajo
                Dim any As Boolean = detalleInicioTrabajo.LstDetalleOrdenesServcio.Any(Function(q) q.Orden_Servicio.Equals(InicioTra_bDetalle_OSE.Orden_Servicio))
                If any Then
                    MessageBox.Show("La Orden de Servicio ya ha sido agregada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Next

            Dim idInicioTrabajo As Integer

            'Orden Trabajo Nueva (NEW)
            If IdOrdenTrabajoActual < 0 Then
                idInicioTrabajo = IdOrdenTrabajoActual
            Else
                idInicioTrabajo = cbOrdenTrabajoItem.SelectedValue
            End If

            Dim orden As String = InicioTra_bDetalle_OSE.Orden_Servicio
            Dim detalleCoti As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idInicioTrabajo))

            For Each detalle As InicioTrabajoDetalleSOE In detalleCoti.LstDetalleOrdenesServcio
                If detalle.Orden_Servicio.Equals(InicioTra_bDetalle_OSE.Orden_Servicio) Then
                    MessageBox.Show("La Orden de Servicio ya se encuetra agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            Next

            'Agrear Orden de Servicio a Lista Temporal
            InicioTra_bDetalle_OSE.ID_Inicio_Trabajo = idInicioTrabajo
            InicioTra_bDetalle_OSE.ID_DetalleItem = idCotizacionDetalleItem
            detalleCoti.LstDetalleOrdenesServcio.Add(InicioTra_bDetalle_OSE)

            dgvOrdenesServicio.Rows.Add(InicioTra_bDetalle_OSE.Orden_Servicio, InicioTra_bDetalle_OSE.Detalle, InicioTra_bDetalle_OSE.Cantidad, InicioTra_bDetalle_OSE.Precio_Unitario, InicioTra_bDetalle_OSE.Total)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarOSE_Click(sender As Object, e As EventArgs) Handles btnEliminarOSE.Click
        Try
            Dim filaActual As Integer = dgvOrdenesServicio.CurrentCell.RowIndex
            dgvOrdenesServicio.Rows.RemoveAt(filaActual)

            'Eliminar todos los datos de la lista temporal
            Dim idDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue
            Dim detalleCoti As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IDCotizacionDetalleItem.Equals(idDetalleItem))
            detalleCoti.LstDetalleOrdenesServcio = New List(Of InicioTrabajoDetalleSOE)

            'Cargar datos a la lista temporal desde DataGrid
            For Each row As DataGridViewRow In dgvOrdenesServicio.Rows
                Dim iniTrabjoSOE As New InicioTrabajoDetalleSOE
                iniTrabjoSOE.ID_Cotizacion = IdCotizacion
                iniTrabjoSOE.ID_DetalleItem = idDetalleItem
                iniTrabjoSOE.ID_Orden_Servicio = row.Cells("CodigoOSE").Value - 10000
                iniTrabjoSOE.Orden_Servicio = row.Cells("CodigoOSE").Value
                iniTrabjoSOE.Detalle = row.Cells("DetalleOSE").Value
                iniTrabjoSOE.Cantidad = row.Cells("CantidadOSE").Value
                iniTrabjoSOE.Cantidad = row.Cells("PrecioUnitOSE").Value
                iniTrabjoSOE.Cantidad = row.Cells("TotalOSE").Value
                detalleCoti.LstDetalleOrdenesServcio.Add(iniTrabjoSOE)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDescripcionCoti_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcionCoti.MouseHover
        Try
            tt.Show(txtDescripcionCoti.Text, txtDescripcionCoti)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDescripcionCoti_MouseLeave(sender As Object, e As EventArgs) Handles txtDescripcionCoti.MouseLeave
        Try
            tt.Show("", txtDescripcionCoti)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDescripcionDetalleItem_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcionDetalleItem.MouseHover
        Try
            tt.Show(txtDescripcionDetalleItem.Text, txtDescripcionDetalleItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDescripcionDetalleItem_MouseLeave(sender As Object, e As EventArgs) Handles txtDescripcionDetalleItem.MouseLeave
        Try
            tt.Show("", txtDescripcionDetalleItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeshabilitarBotonesNuevoItemOT(ByVal estado As Boolean)
        Try
            btnGuardar.Enabled = estado
            btnEliminarItemOT.Enabled = estado
            btnNuevoItemOT.Enabled = estado
            cbOrdenTrabajoItem.Enabled = estado
            cbTipoOrden.Enabled = estado
            btnExamCotizacion.Enabled = estado
            cbCotizacionDetalleItem.Enabled = estado

            btnCancelarNuevoItemOT.Enabled = IIf(estado, False, True)
            btnGuardarItemOT.Enabled = IIf(estado, False, True)

            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue

            If idTipoOrden.Equals(1) Then 'Tipo Interna - No tiene cotización
                btnExamCotizacion.Enabled = False
                cbCotizacionDetalleItem.Enabled = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevoItemOT_Click(sender As Object, e As EventArgs) Handles btnNuevoItemOT.Click
        Try

            If cbTipoOrden.SelectedValue.Equals(0) Then
                MessageBox.Show("Por favor, seleccione un Tipo de Orden", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbTipoOrden.Select()
                Return
            End If

            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue

            If idTipoOrden.Equals(1) Then
                IdCotizacion = 0
            Else
                If txtCotizacion.Text.Trim.Equals("") Then
                    MessageBox.Show("Por favor, seleccione una Cotización", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCotizacion.Select()
                    Return
                End If

                Dim idCotizacionDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue
                If idCotizacionDetalleItem.Equals(0) Then
                    MessageBox.Show("Por favor, seleccione un  Item", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbCotizacionDetalleItem.Select()
                    Return
                End If
            End If


            Dim ordenNueva As EntidadInicioTrabajo = ListaInicioTrabajo.AsEnumerable.FirstOrDefault(Function(x) x.EstadoOperacion.Equals("NUEVO"))

            If ordenNueva IsNot Nothing Then
                MessageBox.Show(String.Format("El Item {0} aún no ha sido grabado. Por favor, debe guardar el Item antes de agregar uno nuevo.", ordenNueva.CodigoOrdenTrabajo),
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            'Deshabilitar los botones para continuar
            DeshabilitarBotonesNuevoItemOT(False)

            cbOrdenTrabajoItem.SelectedValue = 0

            LimpiarDatosOrdenTrabajoItem()

            Dim secuencia As Integer

            If ListaInicioTrabajo.Any Then
                IdOrdenTrabajoActual = ListaInicioTrabajo.AsEnumerable().Min(Function(x) x.IdInicioTrabajo) - 1
                secuencia = ListaInicioTrabajo.Count() + 1
            Else
                IdOrdenTrabajoActual = -1
                secuencia = 1
            End If

            'Nueva Orden Trabajo
            NuevaOrdenTrabajoActual = New EntidadInicioTrabajo
            NuevaOrdenTrabajoActual.IdInicioTrabajo = IdOrdenTrabajoActual
            NuevaOrdenTrabajoActual.IDCotizacion = IdCotizacion
            NuevaOrdenTrabajoActual.IDCotizacionDetalleItem = cbCotizacionDetalleItem.SelectedValue
            NuevaOrdenTrabajoActual.SecuenciaItems = secuencia
            NuevaOrdenTrabajoActual.CodigoOrdenTrabajo = NuevaOrdenTrabajoActual.CodigoAutoGenerado
            NuevaOrdenTrabajoActual.EstadoOperacion = "NUEVO"
            ListaInicioTrabajo.Add(NuevaOrdenTrabajoActual)

            txtCodigoOT.Text = NuevaOrdenTrabajoActual.CodigoOrdenTrabajo

            'Cargar Materiales a Data Grid View
            CargarDetalleMateriales()

            'Cargar Personal  a Data Grid View
            CargarDetallePersonal()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarDatosOrdenTrabajoItem()
        txtCodigoOT.Text = ""
        txtTituloOT.Text = ""
        txtDescripcionOT.Text = ""
        txtMaterial.Text = ""
        txtCantMateriales.Text = ""
        txtTotalMateriales.Text = ""
        txtCantEmpleados.Text = ""
        txtNroOSE.Text = ""

        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFin.Value = DateTime.Now

        NudDuracionDiasMaterial.Value = 0
        NudDuracionHorasMaterial.Value = 0

        NudDuracionDiasPersonal.Value = 0
        NudDuracionHorasPersonal.Value = 0

        dgvMateriales.Rows.Clear()
        dgvEmpleados.Rows.Clear()
        dgvOrdenesServicio.Rows.Clear()
    End Sub

    Private Sub btnGuardarItemOT_Click(sender As Object, e As EventArgs) Handles btnGuardarItemOT.Click
        Try

            Dim esNuevo As Boolean = False

            If txtCodigoOT.Text.Trim.Equals("") Then
                MessageBox.Show("No existe ningún Item para agregar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If cbTipoOrden.SelectedValue.Equals(0) Then
                MessageBox.Show("Por favor, seleccione un Tipo de Orden", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbTipoOrden.Select()
                Return
            End If

            Dim idTipoOrden As Integer = cbTipoOrden.SelectedValue

            If Not idTipoOrden.Equals(1) Then
                If txtCotizacion.Text.Trim.Equals("") Then
                    MessageBox.Show("Por favor, seleccione una Cotización", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCotizacion.Select()
                    Return
                End If

                Dim idCotizacionDetalleItem As Integer = cbCotizacionDetalleItem.SelectedValue
                If idCotizacionDetalleItem.Equals(0) Then
                    MessageBox.Show("Por favor, seleccione un  Item", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbCotizacionDetalleItem.Select()
                    Return
                End If
            End If


            If txtTituloOT.Text.Trim = "" Then
                MessageBox.Show("Por favor, ingrese el título de la Orden de Trabajo.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTituloOT.Select()
                Return
            End If

            If txtDescripcionOT.Text.Trim = "" Then
                MessageBox.Show("Por favor, ingrese la descripción de la Orden de Trabajo.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDescripcionOT.Select()
                Return
            End If

            If dgvMateriales.Rows.Count.Equals(0) Then
                MessageBox.Show("Por favor, ingrese al menos un detalle de materiales.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim codigoOT As String = ""

            If NuevaOrdenTrabajoActual IsNot Nothing Then

                Dim ordenNueva As EntidadInicioTrabajo = ListaInicioTrabajo.AsEnumerable.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(IdOrdenTrabajoActual))

                ordenNueva.IdInicioTrabajo = IdOrdenTrabajoActual
                ordenNueva.IDCotizacion = IdCotizacion
                ordenNueva.TipoOrden = cbTipoOrden.SelectedValue
                ordenNueva.EstadoOT = txtEstado.Text
                ordenNueva.IDCotizacionDetalleItem = cbCotizacionDetalleItem.SelectedValue
                ordenNueva.TituloOT = txtTituloOT.Text
                ordenNueva.DescripcionOT = txtDescripcionOT.Text
                ordenNueva.FechaInicioOT = dtpFechaInicio.Value.Date
                ordenNueva.FechaFinOT = dtpFechaFin.Value.Date
                ordenNueva.EstadoOperacion = "GRABADA"
                codigoOT = ordenNueva.CodigoAutoGenerado

                MessageBox.Show(String.Format("La Orden de Trabajo {0} ha sido agregada", codigoOT), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                Dim ordenTrabajoEditar As EntidadInicioTrabajo = ListaInicioTrabajo.AsEnumerable.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(cbOrdenTrabajoItem.SelectedValue))
                If ordenTrabajoEditar IsNot Nothing Then
                    ordenTrabajoEditar.TituloOT = txtTituloOT.Text
                    ordenTrabajoEditar.DescripcionOT = txtDescripcionOT.Text
                    ordenTrabajoEditar.FechaInicioOT = dtpFechaInicio.Value.Date
                    ordenTrabajoEditar.FechaFinOT = dtpFechaFin.Value.Date

                    MessageBox.Show(String.Format("La Orden de Trabajo {0} ha sido editada", ordenTrabajoEditar.CodigoAutoGenerado), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            NuevaOrdenTrabajoActual = Nothing

            CargarOrdenTrabajoItems()
            LimpiarDatosOrdenTrabajoItem()

            DeshabilitarBotonesNuevoItemOT(True)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbOrdenTrabajoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrdenTrabajoItem.SelectedIndexChanged
        Try
            Dim idInicioTrabajo As Integer = cbOrdenTrabajoItem.SelectedValue

            NuevaOrdenTrabajoActual = Nothing
            IdOrdenTrabajoActual = idInicioTrabajo

            ListaInicioTrabajo.RemoveAll(Function(x) x.EstadoOperacion.Equals("NUEVO"))


            If Not idInicioTrabajo.Equals(0) Then

                'Cargar Orden de Trabajo
                Dim entidadInicioTrabajo As EntidadInicioTrabajo = ListaInicioTrabajo.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idInicioTrabajo))

                'Cargar Datos OT
                txtCodigoOT.Text = entidadInicioTrabajo.CodigoAutoGenerado
                dtpFechaInicio.Value = entidadInicioTrabajo.FechaInicioOT
                dtpFechaFin.Value = entidadInicioTrabajo.FechaFinOT
                txtTituloOT.Text = entidadInicioTrabajo.TituloOT
                txtDescripcionOT.Text = entidadInicioTrabajo.DescripcionOT

                dgvEmpleados.Rows.Clear()
                dgvMateriales.Rows.Clear()
                dgvOrdenesServicio.Rows.Clear()


                For Each row As InicioTrabajoDetallePersonal In entidadInicioTrabajo.LstDetallePersonal
                    dgvEmpleados.Rows.Add(row.Personal, row.Duracion_Dias, row.Duracion_Horas, row.Cantidad)
                Next

                For Each row As InicioTrabajoDetalleMaterial In entidadInicioTrabajo.LstDetalleMateriales
                    Dim codMaterial As String = row.Codigo
                    Dim material As String = row.NombreMaterial
                    Dim cantidad As Integer = row.Cantidad
                    Dim pUnitario As Decimal = row.Precio_Unitario
                    Dim subTotal As Decimal = cantidad * pUnitario
                    Dim horas As Integer = row.Duracion_Horas
                    Dim dias As Integer = row.Duracion_Dias

                    dgvMateriales.Rows.Add(codMaterial, material, cantidad, pUnitario, dias, horas, subTotal)
                Next
                ActualizarTotalMateriales()

                For Each row As InicioTrabajoDetalleSOE In entidadInicioTrabajo.LstDetalleOrdenesServcio
                    dgvOrdenesServicio.Rows.Add(row.Orden_Servicio, row.Detalle, row.Cantidad, row.Precio_Unitario, row.Total)
                Next

            Else
                LimpiarDatosOrdenTrabajoItem()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim result As Integer = MessageBox.Show("¿Desea cerrar el formulario? Debe guarde sus cambios antes de cerrar, caso contrario se perderán sus cambios.", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarItemOT_Click(sender As Object, e As EventArgs) Handles btnEliminarItemOT.Click
        Try
            Dim idOrdenTrabajo As Integer = cbOrdenTrabajoItem.SelectedValue
            Dim codigoOT As String = ""

            Dim ordenTrabajo As EntidadInicioTrabajo = ListaInicioTrabajo.AsEnumerable.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(idOrdenTrabajo))

            If ordenTrabajo IsNot Nothing Then
                codigoOT = ordenTrabajo.CodigoOrdenTrabajo
                Dim result As Integer = MessageBox.Show(String.Format("¿Desea eliminar la Orden de Trabajo {0}?", codigoOT), "Confirmar", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    ListaInicioTrabajo.Remove(ordenTrabajo)

                    CargarOrdenTrabajoItems()
                    LimpiarDatosOrdenTrabajoItem()
                    MessageBox.Show(String.Format("La Orden de Trabajo {0} ha sido eliminada", codigoOT), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLimpiarConsulta_Click(sender As Object, e As EventArgs) Handles btnLimpiarConsulta.Click
        Try
            IdClienteBusqueda = 0
            cbTipoOTConsulta.SelectedValue = 0
            cbEstado.SelectedValue = ""
            txtClienteBusqueda.Text = ""

            dtpBuscarDesde.Value = DateTime.Now
            dtpBuscarHasta.Value = DateTime.Now

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelarNuevoItemOT_Click(sender As Object, e As EventArgs) Handles btnCancelarNuevoItemOT.Click
        Try
            Dim ordenNueva As EntidadInicioTrabajo = ListaInicioTrabajo.AsEnumerable.FirstOrDefault(Function(x) x.IdInicioTrabajo.Equals(IdOrdenTrabajoActual))
            ListaInicioTrabajo.Remove(ordenNueva)

            DeshabilitarBotonesNuevoItemOT(True)

            LimpiarDatosOrdenTrabajoItem()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            Dim index As Integer = TabControl1.SelectedIndex

            If index.Equals(1) Then
                cbTipoOTConsulta.SelectedValue = 0

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class