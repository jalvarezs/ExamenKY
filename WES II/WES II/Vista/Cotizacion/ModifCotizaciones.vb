Public Class ModifCotizaciones

    Private nombre, descripcion, estado As String
    Private fechaRegistro, horaInicio As Date
    Private codigoCotizacion, duracionDias, duracionHoras As Integer

    Private ListaDetalleCotizacion As New List(Of DetalleCotizacion)

#Region "Propiedades privadas de materiales"
    Private Property IdMaterial As String
    Private Property PrecioUnitario As Decimal
    Private Property PrecioAlquilerDia As Decimal
    Private Property PrecioAlquilerHora As Decimal
    Private Property EsAlquiler As Boolean
#End Region

    Sub New(ByVal _codigoCotizacion As Integer, ByVal _nombre As String, ByVal _fechaRegistro As Date, ByVal _descripcion As String,
            ByVal _duracionDias As Integer, ByVal _horaInicio As Date, ByVal _duracionhoras As Integer, ByVal _estado As String)
        Try
            InitializeComponent()

            codigoCotizacion = _codigoCotizacion
            nombre = _nombre
            fechaRegistro = _fechaRegistro
            descripcion = _descripcion
            duracionDias = _duracionDias
            horaInicio = _horaInicio
            duracionHoras = _duracionhoras
            estado = _estado

            Dim dtCotizacion As DataTable = Cotizacion.BuscarCotizacionPorId(_codigoCotizacion - 10000)
            If dtCotizacion IsNot Nothing Then
                Dim rowCoti As DataRow = dtCotizacion.AsEnumerable.FirstOrDefault

                chkRRHH.Checked = If(rowCoti("VerRRHH"), True, False)
                chkMaterial.Checked = If(rowCoti("VerMaterial"), True, False)
                chkServicioExterno.Checked = If(rowCoti("VerServicioExterno"), True, False)

            End If

            ListarTipos()

            CargarDatosItemsDetalles()

            ListarPersonal()

            ListarMateriales()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub CargarDatosItemsDetalles()

        Dim lista As New List(Of EntidadDropDown)

        Dim entidadNuevoItem As New EntidadDropDown
        entidadNuevoItem.Id = 0
        entidadNuevoItem.Descripcion = "Seleccione"
        lista.Add(entidadNuevoItem)

        Dim dt As DataTable = Cotizacion.BuscarDetalleItems(codigoCotizacion - 10000)

        For Each dr As DataRow In dt.Rows
            Dim entidad As New EntidadDropDown
            entidad.Id = dr("ID_DetalleItem")
            entidad.Descripcion = dr("Titulo")
            lista.Add(entidad)
        Next

        cbItemDetallesMateriales.DataSource = lista
        cbItemDetallesMateriales.ValueMember = "Id"
        cbItemDetallesMateriales.DisplayMember = "Descripcion"

        cbItemDetallesPersonal.DataSource = lista
        cbItemDetallesPersonal.ValueMember = "Id"
        cbItemDetallesPersonal.DisplayMember = "Descripcion"

        'Cargar los detalles Items de la Cotizacion
        For Each dr As DataRow In dt.Rows

            Dim idCoti As Integer = codigoCotizacion - 10000

            Dim detalleCoti As New DetalleCotizacion
            detalleCoti.IDCotizacion = idCoti
            detalleCoti.IDDetalleItem = dr("ID_DetalleItem")
            detalleCoti.Titulo = dr("Titulo")
            ListaDetalleCotizacion.Add(detalleCoti)

            'Cargar los detalles Items Personal
            Dim tablaPersonal As DataTable = Cotizacion.ListarPersonalCotizacionPorItem(codigoCotizacion - 10000, dr("ID_DetalleItem"))

            For Each row As DataRow In tablaPersonal.Rows
                Dim cotizaDetPersonal As New CotizacionDetallePersonal
                cotizaDetPersonal.ID_DetalleItem = row("ID_DetalleItem")
                cotizaDetPersonal.Personal = row("Personal")
                cotizaDetPersonal.Cantidad = row("Cantidad")
                detalleCoti.LstDetallePersonal.Add(cotizaDetPersonal)
            Next


            'Cargar los detalles Items Material
            Dim tablaMaterial As DataTable = Cotizacion.ListarDetallesPorDetalleItem(codigoCotizacion - 10000, dr("ID_DetalleItem"))

            For Each row As DataRow In tablaMaterial.Rows
                Dim cotiDetMaterial As New CotizacionDetalleMaterial
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

        Next

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            codigoCotizacion = txtCodigo.Text
            descripcion = txtDescripcion.Text
            fechaRegistro = dtpFechaCotizacion.Value.Date
            duracionDias = NudDuracionDias.Value
            horaInicio = dtpHoras.Value
            duracionHoras = nudDuracionHoras.Value

            _conexion.iniciarTransaccion()

            Dim verRRHH As Integer = If(chkRRHH.Checked, 1, 0)
            Dim verMaterial As Integer = If(chkMaterial.Checked, 1, 0)
            Dim verServicioExterno As Integer = If(chkServicioExterno.Checked, 1, 0)

            Dim rpta As String = Cotizacion.Modificar(codigoCotizacion,
                                                      descripcion,
                                                      fechaRegistro,
                                                      duracionDias,
                                                      horaInicio,
                                                      duracionHoras,
                                                      verRRHH,
                                                      verMaterial,
                                                      verServicioExterno)

            Cotizacion.LimpiarDetallesCotizacion(codigoCotizacion - 10000)

            For Each detalleCoti As DetalleCotizacion In ListaDetalleCotizacion

                For Each detalleCotiPersonal As CotizacionDetallePersonal In detalleCoti.LstDetallePersonal
                    rpta = Cotizacion.RegistrarPersonal(codigoCotizacion - 10000,
                                                    detalleCotiPersonal.ID_DetalleItem,
                                                    detalleCotiPersonal.Personal,
                                                    detalleCotiPersonal.Cantidad)
                    If Not String.IsNullOrWhiteSpace(rpta) Then Throw New Exception(rpta)
                Next

                For Each detalleCotiMaterial As CotizacionDetalleMaterial In detalleCoti.LstDetalleMateriales
                    rpta = Cotizacion.RegistrarDetalleMaterial(codigoCotizacion - 10000,
                                                               detalleCotiMaterial.ID_DetalleItem,
                                                               detalleCotiMaterial.ID_Material,
                                                               detalleCotiMaterial.Cantidad,
                                                               detalleCotiMaterial.Precio_Unitario,
                                                               detalleCotiMaterial.Precio_Total,
                                                               detalleCotiMaterial.Precio_Alquiler_Dia,
                                                               detalleCotiMaterial.Precio_Alquiler_Hora,
                                                               detalleCotiMaterial.Descuento,
                                                               detalleCotiMaterial.Duracion_Dias,
                                                               detalleCotiMaterial.Duracion_Horas)
                    If Not String.IsNullOrWhiteSpace(rpta) Then Throw New Exception(rpta)
                Next
            Next

            _conexion.hacerCommit()

            MessageBox.Show("Se ha modificado correctamente la cotización.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            _conexion.hacerRollBack()
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ModifCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = codigoCotizacion
        txtCliente.Text = nombre
        dtpFechaCotizacion.Value = fechaRegistro
        txtDescripcion.Text = descripcion
        NudDuracionDias.Value = duracionDias
        dtpHoras.Value = horaInicio
        nudDuracionHoras.Value = duracionHoras
    End Sub

    'WALC_181015: Se agrega logica para modificacion completa de cotización
#Region "Eventos de controles"
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If TodoCorrecto() Then
            AgregarMaterial()
        End If

        txtMaterial.Text = String.Empty
        txtCantidad.Text = "0"
        NudDuracionDiasMaterial.Value = 0
        NudDuracionHorasMaterial.Value = 0
        NudDescuento.Value = 0
    End Sub

    Private Sub BtnExamMaterial_Click(sender As Object, e As EventArgs) Handles btnExamMaterial.Click
        Try
            Dim frmExamProducto As New ExamMaterial(txtMaterial)
            frmExamProducto.ShowDialog()
            IdMaterial = frmExamProducto.getCode()
            PrecioUnitario = UtilConvertidor.GetDecimal(frmExamProducto.getPrecio())
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnAddPersonal_Click(sender As Object, e As EventArgs) Handles btnAddPersonal.Click
        If String.IsNullOrWhiteSpace(cboCargos.Text) Then
            MessageBox.Show("Seleccione un cargo para el personal a asignar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbItemDetallesPersonal.SelectedValue.Equals(0) Then
            MessageBox.Show("Seleccione un Item válido", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cantEmpleados As Integer = 0
        Try
            cantEmpleados = Integer.Parse(txtCantEmpleados.Text)

            Dim idDetalleItem As Integer = cbItemDetallesPersonal.SelectedValue

            Dim detalleCoti As DetalleCotizacion = ListaDetalleCotizacion.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))
            Dim cotizaDetPersonal As New CotizacionDetallePersonal
            cotizaDetPersonal.ID_DetalleItem = idDetalleItem
            cotizaDetPersonal.ItemTitulo = cbItemDetallesPersonal.Text
            cotizaDetPersonal.Personal = cboCargos.Text
            cotizaDetPersonal.Cantidad = cantEmpleados
            detalleCoti.LstDetallePersonal.Add(cotizaDetPersonal)

            dgvEmpleados.Rows.Add(idDetalleItem, cbItemDetallesPersonal.Text, cboCargos.Text, cantEmpleados)

        Catch
            MessageBox.Show("Ingrese una cantidad válida para el número de trabajadores.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally

        End Try

    End Sub

    Private Sub BtnElimEmpleados_Click(sender As Object, e As EventArgs) Handles btnElimEmpleados.Click
        Try
            Dim idDetalleItem As Integer = dgvEmpleados.Rows(dgvEmpleados.CurrentCell.RowIndex).Cells("ItemCodigo").Value

            dgvEmpleados.Rows.RemoveAt(dgvEmpleados.CurrentCell.RowIndex)

            'Eliminar todos los datos de la lista temporal
            Dim detalleCoti As DetalleCotizacion = ListaDetalleCotizacion.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))
            detalleCoti.LstDetallePersonal = New List(Of CotizacionDetallePersonal)

            'Cargar datos a la lista temporal desde DataGrid
            For Each row As DataGridViewRow In dgvEmpleados.Rows
                Dim cotizaDetPersonal As New CotizacionDetallePersonal
                cotizaDetPersonal.ID_DetalleItem = row.Cells("ItemCodigo").Value
                cotizaDetPersonal.ItemTitulo = row.Cells("Item").Value
                cotizaDetPersonal.Personal = row.Cells("CargoPersonalCol").Value
                cotizaDetPersonal.Cantidad = row.Cells("CantidadPersonalCol").Value
                cotizaDetPersonal.Valor = row.Cells("ValorPersonalCol").Value
                detalleCoti.LstDetallePersonal.Add(cotizaDetPersonal)
            Next

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar la fila del personal a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim idDetalleItem As Integer = dgvMateriales.Rows(dgvMateriales.CurrentCell.RowIndex).Cells("ItemCodigo_").Value

            dgvMateriales.Rows.RemoveAt(dgvMateriales.CurrentCell.RowIndex)

            'Eliminar todos los datos de la lista temporal
            Dim detalleCoti As DetalleCotizacion = ListaDetalleCotizacion.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))
            detalleCoti.LstDetalleMateriales = New List(Of CotizacionDetalleMaterial)

            'Cargar datos a la lista temporal desde DataGrid
            For Each row As DataGridViewRow In dgvMateriales.Rows
                Dim cotiDetMaterial As New CotizacionDetalleMaterial
                cotiDetMaterial.ID_DetalleItem = row.Cells("ItemCodigo_").Value
                cotiDetMaterial.DetalleItemTitulo = row.Cells("ItemMat").Value
                cotiDetMaterial.Codigo = row.Cells("Codigo").Value
                cotiDetMaterial.NombreMaterial = row.Cells("NombreMaterial").Value
                cotiDetMaterial.EsAlquilerCol = row.Cells("EsAlquilerCol").Value
                cotiDetMaterial.Cantidad = row.Cells("Cantidad").Value
                cotiDetMaterial.Precio_Unitario = row.Cells("PrecioUnit").Value
                cotiDetMaterial.Duracion_Dias = row.Cells("MaterialDiasCol").Value
                cotiDetMaterial.Duracion_Horas = row.Cells("MaterialHorasCol").Value
                cotiDetMaterial.Precio_Alquiler_Dia = row.Cells("PrecioAlquilerDiaCol").Value
                cotiDetMaterial.Precio_Alquiler_Hora = row.Cells("PrecioAlquilerHoraCol").Value
                cotiDetMaterial.Descuento = row.Cells("DescuentoCol").Value
                cotiDetMaterial.Precio_Total = row.Cells("PrecioTot").Value
                cotiDetMaterial.ID_Material = CInt(row.Cells("Codigo").Value) - 10000
                detalleCoti.LstDetalleMateriales.Add(cotiDetMaterial)
            Next

            ActualizarTotales()
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar la fila que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvMateriales_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMateriales.CellEndEdit
        Dim grid As DataGridView = sender

        Select Case grid.Columns(e.ColumnIndex).Name
            Case "MaterialDiasCol", "MaterialHorasCol", "DescuentoCol"
                Dim valor As String = String.Empty
                Try
                    valor = Integer.Parse(grid(e.ColumnIndex, e.RowIndex).Value).ToString
                Catch ex As Exception
                    valor = 0
                Finally
                    grid(e.ColumnIndex, e.RowIndex).Value = valor
                End Try
            Case "Cantidad", "PrecioAlquilerDiaCol", "PrecioAlquilerHoraCol"
                Dim valor As String = String.Empty
                Try
                    valor = Decimal.Parse(grid(e.ColumnIndex, e.RowIndex).Value).ToString
                Catch ex As Exception
                    valor = 0
                Finally
                    grid(e.ColumnIndex, e.RowIndex).Value = valor
                End Try
        End Select

        ActualizarTotales()
    End Sub
#End Region
#Region "Métodos privados"
    Private Sub ListarTipos()
        Dim listaTipos As DataTable
        listaTipos = TipoPersonal.listar()
        With cboCargos
            .DataSource = listaTipos
            .ValueMember = listaTipos.Columns(0).ColumnName
            .DisplayMember = listaTipos.Columns(1).ColumnName
        End With
    End Sub

    Private Sub ListarMateriales()
        Try
            Dim idDetalleItem As Integer = cbItemDetallesMateriales.SelectedValue

            'Dim tabla As DataTable
            'tabla = Cotizacion.listarDetallesPorDetalleItem(codigoCotizacion - 10000, idDetalleItem)

            Dim detalleCoti As DetalleCotizacion = ListaDetalleCotizacion.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))

            dgvMateriales.Rows.Clear()

            For Each row As CotizacionDetalleMaterial In detalleCoti.LstDetalleMateriales
                Dim rowIndex As Integer = dgvMateriales.Rows.Add
                dgvMateriales.Rows(rowIndex).Cells("ItemCodigo_").Value = detalleCoti.IDDetalleItem
                dgvMateriales.Rows(rowIndex).Cells("ItemMat").Value = detalleCoti.Titulo
                dgvMateriales.Rows(rowIndex).Cells("Codigo").Value = row.Codigo
                dgvMateriales.Rows(rowIndex).Cells("NombreMaterial").Value = row.NombreMaterial
                dgvMateriales.Rows(rowIndex).Cells("EsAlquilerCol").Value = row.EsAlquilerCol
                dgvMateriales.Rows(rowIndex).Cells("Cantidad").Value = row.Cantidad
                dgvMateriales.Rows(rowIndex).Cells("PrecioUnit").Value = row.Precio_Unitario
                dgvMateriales.Rows(rowIndex).Cells("MaterialDiasCol").Value = row.Duracion_Dias
                dgvMateriales.Rows(rowIndex).Cells("MaterialHorasCol").Value = row.Duracion_Horas
                dgvMateriales.Rows(rowIndex).Cells("PrecioAlquilerDiaCol").Value = row.Precio_Alquiler_Dia
                dgvMateriales.Rows(rowIndex).Cells("PrecioAlquilerHoraCol").Value = row.Precio_Alquiler_Hora
                dgvMateriales.Rows(rowIndex).Cells("DescuentoCol").Value = row.Descuento
                dgvMateriales.Rows(rowIndex).Cells("PrecioTot").Value = row.Precio_Total
            Next

            ActualizarTotales()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListarPersonal()
        Try

            Dim idDetalleItem As Integer = cbItemDetallesPersonal.SelectedValue

            'Dim tabla As DataTable
            'tabla = Cotizacion.ListarPersonalCotizacionPorItem(codigoCotizacion - 10000, idDetalleItem)

            Dim detalleCoti As DetalleCotizacion = ListaDetalleCotizacion.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))

            dgvEmpleados.Rows.Clear()

            For Each row As CotizacionDetallePersonal In detalleCoti.LstDetallePersonal
                Dim rowIndex As Integer = dgvEmpleados.Rows.Add
                dgvEmpleados.Rows(rowIndex).Cells("ItemCodigo").Value = detalleCoti.IDDetalleItem
                dgvEmpleados.Rows(rowIndex).Cells("Item").Value = detalleCoti.Titulo
                dgvEmpleados.Rows(rowIndex).Cells("CargoPersonalCol").Value = row.Personal
                dgvEmpleados.Rows(rowIndex).Cells("CantidadPersonalCol").Value = row.Cantidad
                dgvEmpleados.Rows(rowIndex).Cells("ValorPersonalCol").Value = String.Empty
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbItemDetallesPersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItemDetallesPersonal.SelectedIndexChanged
        Try
            ListarPersonal()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbItemDetallesMateriales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItemDetallesMateriales.SelectedIndexChanged
        Try
            ListarMateriales()

        Catch ex As Exception

        End Try
    End Sub

    Private Function TodoCorrecto()

        If cbItemDetallesMateriales.SelectedValue.Equals(0) Then
            MessageBox.Show("Seleccione un Item válido", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            errorProvider.SetError(txtCliente, "Seleccione un cliente.")
            Return False
        Else
            errorProvider.SetError(txtCliente, Nothing)
        End If

        If String.IsNullOrWhiteSpace(txtMaterial.Text) Then
            errorProvider.SetError(txtMaterial, "Seleccione un material.")
            Return False
        Else
            errorProvider.SetError(txtMaterial, Nothing)
        End If

        Try
            Dim temporal = CInt(txtCantidad.Text.Trim)
            errorProvider.SetError(txtCantidad, Nothing)
        Catch ex As Exception
            errorProvider.SetError(txtCantidad, "Ingrese una cantidad válida.")
            Return False
        End Try

        Return True
    End Function

    Private Sub AgregarMaterial()
        Try
            'Actualizar listado temporal
            Dim idDetalleItem As Integer = cbItemDetallesMateriales.SelectedValue
            Dim detalleCoti As DetalleCotizacion = ListaDetalleCotizacion.FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleItem))


            For Each row As DataGridViewRow In dgvMateriales.Rows
                Dim dato As String = txtMaterial.Text

                If row.Cells("NombreMaterial").Value.ToString.Equals(dato, StringComparison.InvariantCultureIgnoreCase) Then

                    If DeseaSumarCantidad() Then
                        SumarCantidad(row)
                    End If

                    ActualizarTotales()
                    Return
                End If
            Next

            Dim diasMaterial As Integer = NudDuracionDiasMaterial.Value
            Dim horasMaterial As Integer = NudDuracionHorasMaterial.Value
            Dim descuento As Integer = NudDescuento.Value
            Dim cantidad As Decimal = CDec(txtCantidad.Text)
            Dim precioTotal As Decimal

            precioTotal = IIf(EsAlquiler, ((diasMaterial * PrecioAlquilerDia) + (horasMaterial * PrecioAlquilerHora)) * cantidad, cantidad * PrecioUnitario)
            precioTotal = IIf(descuento = 0, precioTotal, precioTotal - (precioTotal * (descuento / 100)))

            Dim rowIndex = dgvMateriales.Rows.Add()
            dgvMateriales.Rows(rowIndex).Cells("ItemCodigo_").Value = idDetalleItem
            dgvMateriales.Rows(rowIndex).Cells("ItemMat").Value = cbItemDetallesMateriales.Text
            dgvMateriales.Rows(rowIndex).Cells("Codigo").Value = IdMaterial
            dgvMateriales.Rows(rowIndex).Cells("NombreMaterial").Value = txtMaterial.Text
            dgvMateriales.Rows(rowIndex).Cells("EsAlquilerCol").Value = EsAlquiler
            dgvMateriales.Rows(rowIndex).Cells("Cantidad").Value = cantidad
            dgvMateriales.Rows(rowIndex).Cells("PrecioUnit").Value = PrecioUnitario
            dgvMateriales.Rows(rowIndex).Cells("MaterialDiasCol").Value = diasMaterial
            dgvMateriales.Rows(rowIndex).Cells("MaterialHorasCol").Value = horasMaterial
            dgvMateriales.Rows(rowIndex).Cells("PrecioAlquilerDiaCol").Value = PrecioAlquilerDia
            dgvMateriales.Rows(rowIndex).Cells("PrecioAlquilerHoraCol").Value = PrecioAlquilerHora
            dgvMateriales.Rows(rowIndex).Cells("DescuentoCol").Value = descuento
            dgvMateriales.Rows(rowIndex).Cells("PrecioTot").Value = precioTotal


            Dim cotiDetMaterial As New CotizacionDetalleMaterial
            cotiDetMaterial.ID_DetalleItem = idDetalleItem
            cotiDetMaterial.DetalleItemTitulo = cbItemDetallesMateriales.Text
            cotiDetMaterial.Codigo = IdMaterial
            cotiDetMaterial.NombreMaterial = txtMaterial.Text
            cotiDetMaterial.EsAlquilerCol = EsAlquiler
            cotiDetMaterial.Cantidad = cantidad
            cotiDetMaterial.Precio_Unitario = PrecioUnitario
            cotiDetMaterial.Duracion_Dias = diasMaterial
            cotiDetMaterial.Duracion_Horas = horasMaterial
            cotiDetMaterial.Precio_Alquiler_Dia = PrecioAlquilerDia
            cotiDetMaterial.Precio_Alquiler_Hora = PrecioAlquilerHora
            cotiDetMaterial.Descuento = descuento
            cotiDetMaterial.Precio_Total = precioTotal
            cotiDetMaterial.ID_Material = CInt(IdMaterial) - 10000
            detalleCoti.LstDetalleMateriales.Add(cotiDetMaterial)

            ' Sea por el aumento o por la nueva fila insertada
            ActualizarTotales()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub SumarCantidad(ByVal row As DataGridViewRow)
        Try
            Dim cantidadPrevia As Decimal = CDbl(row.Cells("Cantidad").Value.ToString)
            Dim cantAdicional As Decimal = CDbl(txtCantidad.Text)
            row.Cells("Cantidad").Value = CStr(cantidadPrevia + cantAdicional)

            'Actualizar Listado Temporal
            Dim idDetalleItem As Integer = row.Cells("ItemCodigo_").Value
            Dim idCodigoMaterial As String = row.Cells("Codigo").Value

            Dim detalleCotizacion As DetalleCotizacion = ListaDetalleCotizacion.FirstOrDefault(Function(q) q.IDDetalleItem.Equals(idDetalleItem))
            If detalleCotizacion IsNot Nothing Then
                Dim detalleMateriales As CotizacionDetalleMaterial = detalleCotizacion.LstDetalleMateriales.FirstOrDefault(Function(z) z.Codigo.Equals(idCodigoMaterial))
                If detalleMateriales IsNot Nothing Then
                    detalleMateriales.Cantidad = CStr(cantidadPrevia + cantAdicional)
                End If
            End If

        Catch
            MessageBox.Show("Por favor ingrese cantidades válidas.")
        End Try
    End Sub

    Private Sub ActualizarTotales()
        Try
            Dim totalGeneral As Decimal = 0

            For Each row As DataGridViewRow In dgvMateriales.Rows

                Dim cantidad As Decimal = CDec(row.Cells("Cantidad").Value)
                Dim precio As Decimal = CDec(row.Cells("PrecioUnit").Value)
                Dim precioAlquilerPorDia As Decimal = row.Cells("PrecioAlquilerDiaCol").Value
                Dim precioAlquilerPorHora As Decimal = row.Cells("PrecioAlquilerHoraCol").Value
                Dim dias As Integer = row.Cells("MaterialDiasCol").Value
                Dim horas As Integer = row.Cells("MaterialHorasCol").Value
                Dim descuento As Integer = row.Cells("DescuentoCol").Value
                Dim alquiler As Boolean = row.Cells("EsAlquilerCol").Value
                Dim total As Decimal

                total = IIf(alquiler, ((dias * precioAlquilerPorDia) + (horas * precioAlquilerPorHora)) * cantidad, cantidad * precio)
                total = IIf(descuento = 0, total, total - (total * (descuento / 100)))

                row.Cells("PrecioTot").Value = total
                totalGeneral += total
            Next

            txtTotal.Text = totalGeneral
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function DeseaSumarCantidad() As Boolean
        Return MessageBox.Show("El material ya ha sido agregado, desea añadir la cantidad indicada?", "Sugerencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes
    End Function
#End Region
    'FIN WALC_181015
End Class