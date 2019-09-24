Imports System.Net
Public Class FormCotizaciones

    Private idCliente As String
    Private ruc2 As TextBox
    Private idMaterial As String
    Private precioUnitario As Decimal
    Private precioAlquilerDia As Decimal
    Private precioAlquilerHora As Decimal
    Private esAlquiler As Boolean
    Private server, user, pass As String
    Private wc As New WebClient
    Private codigoCotizacion As Integer
    Private idCotizacion As Integer
    Private id As Integer

    Private ultimoIdCargado As Integer = -1

    Private listaDetalleCotizacion As New List(Of DetalleCotizacion)
    Private idDetalleActual As Integer = -1

    'Variables Servicios Externos
    Private ID_ProveedorOSE As Integer = 0
    Private ID_CotizacionOSE As Integer = 0

    'Variables Servicios Externos Busqueda
    Private ID_ProveedorOSE_Buscar As Integer = 0
    Private ID_CotizacionOSE_Buscar As Integer = 0



    Private Sub FormCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ActualizarSgteId()
            actualizarArchivos()
            listarTipos()

            CargarDetallesItems()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ActualizarSgteId()
        txtCodigo.Text = Cotizacion.ObtenerSgteID() + 10000
    End Sub

    Private Sub btnExamCliente_Click(sender As Object, e As EventArgs) Handles btnExamCliente.Click
        Try
            Dim form As New ExamCliente(txtCliente, txtCliente)
            form.ShowDialog()
            idCliente = form.idCliente
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnExamMaterial_Click(sender As Object, e As EventArgs) Handles btnExamMaterial.Click
        Dim frmExamProducto As New ExamMaterial(txtMaterial)
        frmExamProducto.ShowDialog()
        idMaterial = frmExamProducto.getCode()
        precioUnitario = UtilConvertidor.GetDecimal(frmExamProducto.getPrecio())
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If todoCorrecto() Then
            AgregarFila()
        End If
    End Sub

    Private Function todoCorrecto()

        If (txtCliente.Text.Trim = "") Then
            errorProvider.SetError(txtCliente, "Seleccione un cliente.")
            Return False
        Else
            errorProvider.SetError(txtCliente, Nothing)
        End If

        If (txtMaterial.Text.Trim = "") Then
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

    Private Sub AgregarFila()
        ' Buscamos si el material ya se registró antes
        For j As Integer = 0 To dgvMateriales.Rows.Count - 1
            Dim dato As String = txtMaterial.Text

            If dgvMateriales.Rows(j).Cells("NombreMaterial").Value.ToString = dato Then
                If DeseaSumarCantidad() Then
                    SumarCantidad(j)
                End If

                ' Termina con el método, ya no se agrega fila
                ActualizarTotales()
                Return
            End If
        Next

        ' Es un nuevo material, se añade una nueva fila
        Dim diasMaterial As Integer = NudDuracionDiasMaterial.Value
        Dim horasMaterial As Integer = NudDuracionHorasMaterial.Value
        Dim descuento As Integer = NudDescuento.Value
        Dim cantidad As Decimal = CDec(txtCantidad.Text)
        Dim precioTotal As Decimal

        If esAlquiler Then
            precioTotal = ((diasMaterial * precioAlquilerDia) + (horasMaterial * precioAlquilerHora)) * cantidad
        Else
            precioTotal = cantidad * precioUnitario
        End If
        precioTotal = IIf(descuento = 0, precioTotal, precioTotal - (precioTotal * (descuento / 100)))

        Dim rowIndex = dgvMateriales.Rows.Add()
        dgvMateriales.Rows(rowIndex).Cells("Codigo").Value = idMaterial
        dgvMateriales.Rows(rowIndex).Cells("NombreMaterial").Value = txtMaterial.Text
        dgvMateriales.Rows(rowIndex).Cells("EsAlquilerCol").Value = esAlquiler
        dgvMateriales.Rows(rowIndex).Cells("Cantidad").Value = cantidad
        dgvMateriales.Rows(rowIndex).Cells("PrecioUnit").Value = precioUnitario
        dgvMateriales.Rows(rowIndex).Cells("MaterialDiasCol").Value = diasMaterial
        dgvMateriales.Rows(rowIndex).Cells("MaterialHorasCol").Value = horasMaterial
        dgvMateriales.Rows(rowIndex).Cells("PrecioAlquilerDiaCol").Value = precioAlquilerDia
        dgvMateriales.Rows(rowIndex).Cells("PrecioAlquilerHoraCol").Value = precioAlquilerHora
        dgvMateriales.Rows(rowIndex).Cells("DescuentoCol").Value = descuento
        dgvMateriales.Rows(rowIndex).Cells("PrecioTot").Value = precioTotal
        ' Sea por el aumento o por la nueva fila insertada
        ActualizarTotales()
    End Sub

    Private Sub SumarCantidad(ByVal j As String)
        Try
            Dim cantidadPrevia As Decimal = CDbl(dgvMateriales.Rows(j).Cells("Cantidad").Value.ToString)
            Dim cantAdicional As Decimal = CDbl(txtCantidad.Text)
            dgvMateriales.Rows(j).Cells("Cantidad").Value = CStr(cantidadPrevia + cantAdicional)

            'Actualizar Listado Temporal
            Dim idDetalleItem As Integer = idDetalleActual
            Dim idCodigoMaterial As String = dgvMateriales.Rows(j).Cells("Codigo").Value

            Dim detalleCotizacion As DetalleCotizacion = listaDetalleCotizacion.FirstOrDefault(Function(q) q.IDDetalleItem.Equals(idDetalleItem))
            If detalleCotizacion IsNot Nothing Then
                Dim detalleMateriales As CotizacionDetalleMaterial = detalleCotizacion.LstDetalleMateriales.FirstOrDefault(Function(z) z.Codigo.Equals(idCodigoMaterial))
                If detalleMateriales IsNot Nothing Then
                    detalleMateriales.Cantidad = CStr(cantidadPrevia + cantAdicional)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Por favor ingrese cantidades válidas.")
        End Try
    End Sub

    Private Sub ActualizarTotalesPersonal()
        Try

            Dim subTotal As Decimal = 0

            For Each row As DataGridViewRow In dgvMateriales.Rows
                Dim cantidad As Decimal = CDec(row.Cells(2).Value)
                Dim precio As Decimal = CDec(row.Cells(3).Value)
                Dim total As Decimal = cantidad * precio

                row.Cells(4).Value = total
                subTotal += total
            Next

            'txtTotal.Text = subTotal

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ActualizarTotales()
        Try

            Dim subTotalMaterial As Decimal = 0

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

                If alquiler Then
                    total = ((dias * precioAlquilerPorDia) + (horas * precioAlquilerPorHora)) * cantidad
                Else
                    total = cantidad * precio
                End If
                total = IIf(descuento = 0, total, total - (total * (descuento / 100)))

                row.Cells("PrecioTot").Value = total
                subTotalMaterial += total
            Next

            txtTotal.Text = subTotalMaterial

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function DeseaSumarCantidad() As Boolean

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

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim filaActual As Integer = dgvMateriales.CurrentCell.RowIndex
            dgvMateriales.Rows.RemoveAt(filaActual)
            ActualizarTotales()
        Catch
            MessageBox.Show("Debe seleccionar la fila que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ExisteItems() As Boolean
        Dim existeItems_ As Boolean = False

        If listaDetalleCotizacion.Any Then
            existeItems_ = True
        End If

        Return existeItems_
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not ExisteItems() Then
            MessageBox.Show("No se ha agregado ningún detalle a la cotización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim horas As TimeSpan = dtpHoras.Value.TimeOfDay
        _conexion.iniciarTransaccion()
        Try

            horas = IIf(ChkAgregarDuracion.Checked, horas, New TimeSpan())

            Dim totalGeneral As Decimal = ObtenerTotal()

            Dim verRRHH As Integer = If(chkRRHH.Checked, 1, 0)
            Dim verMaterial As Integer = If(chkMaterial.Checked, 1, 0)
            Dim verServicioExterno As Integer = If(chkServicioExterno.Checked, 1, 0)

            Dim rpta As String = Cotizacion.Registrar(idCliente,
                                                        dtpFechaCotizacion.Value.Date,
                                                        txtDescripcion.Text,
                                                        NudDuracionDias.Value,
                                                        horas,
                                                        nudDuracionHoras.Value,
                                                        totalGeneral,
                                                        verRRHH,
                                                        verMaterial,
                                                        verServicioExterno)

            If rpta <> "" Then
                Throw New System.Exception(rpta)
            End If

            '***************
            'Id Cotizacion
            '***************
            Dim idCotizacion, idMaterial As Integer
            idCotizacion = Cotizacion.ObtenerUltimoID()

            For Each detalle In listaDetalleCotizacion

                Dim detalleItem As DetalleCotizacion = CType(detalle, DetalleCotizacion)
                Dim idDetalleItem = Cotizacion.InsertarDetalleItemCotizacion(idCotizacion, detalleItem.Titulo, detalleItem.DescripcionTrabajo)

                For Each itemDetPersonal In detalleItem.LstDetallePersonal

                    Dim itemDetallePersonal As CotizacionDetallePersonal = CType(itemDetPersonal, CotizacionDetallePersonal)
                    rpta = Cotizacion.RegistrarPersonal(idCotizacion, idDetalleItem, itemDetallePersonal.Personal, itemDetallePersonal.Cantidad)
                    If rpta <> "" Then Throw New Exception(rpta)
                Next

                For Each itemDetMaterial In detalleItem.LstDetalleMateriales

                    Dim itemDetalleMaterial As CotizacionDetalleMaterial = CType(itemDetMaterial, CotizacionDetalleMaterial)
                    rpta = Cotizacion.RegistrarDetalleMaterial(idCotizacion, idDetalleItem, itemDetalleMaterial.ID_Material, itemDetalleMaterial.Cantidad,
                                                                itemDetalleMaterial.Precio_Unitario, itemDetalleMaterial.Precio_Total, itemDetalleMaterial.Precio_Alquiler_Dia,
                                                                itemDetalleMaterial.Precio_Alquiler_Hora, itemDetalleMaterial.Descuento, itemDetalleMaterial.Duracion_Dias,
                                                                itemDetalleMaterial.Duracion_Horas)
                    If rpta <> "" Then Throw New Exception(rpta)
                Next

            Next

            _conexion.hacerCommit()
            MessageBox.Show("La cotización se ha registrado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ActualizarSgteId()
            'Limpiar lista de Detalles Items
            listaDetalleCotizacion = New List(Of DetalleCotizacion)

            LimpiarCampos()
            CargarDetallesItems()
            LimpiarDatosDetalle()

        Catch ex As Exception
            Try
                _conexion.hacerRollBack()

            Catch ex_ As Exception

            End Try

        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtCantidad.Text = ""
        txtCliente.Text = ""
        txtDescripcion.Text = ""
        txtMaterial.Text = ""
        txtTotal.Text = 0
        NudDuracionDias.Value = 0
        chkRRHH.Checked = False
        chkMaterial.Checked = False
        chkServicioExterno.Checked = False

        txtCantEmpleados.Text = ""
        dgvEmpleados.Rows.Clear()
        dgvMateriales.Rows.Clear()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        dgvCotizaciones.DataSource = Cotizacion.ListarPorFechas(dtpInicio.Value.ToShortDateString, dtpFin.Value.ToShortDateString)
    End Sub

    Private Sub dgvCotizaciones_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCotizaciones.SelectionChanged
        If dgvCotizaciones.CurrentRow Is Nothing Then
            Return
        End If

        Dim nuevaSeleccion As Integer = dgvCotizaciones.CurrentRow.Index

        Dim id As String = dgvCotizaciones.Item(0, nuevaSeleccion).Value.ToString()
        ActualizarDetalles(id)
    End Sub

    Private Sub ActualizarDetalles(ByVal id As String)
        Dim idCotizacion As Integer = CInt(id) - 10000

        If idCotizacion <> ultimoIdCargado Then
            ' MessageBox.Show("Detalles de: " & idCotizacion)
            dgvDetalles.DataSource = Cotizacion.ListarDetalles(idCotizacion)
            ultimoIdCargado = idCotizacion
        End If
    End Sub

    Private Sub DatosFTP()
        server = "52.22.129.97"
        user = "sga"
        pass = "milanga2017"
    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        DatosFTP()
        Try
            My.Computer.Network.UploadFile(txtArchivoSubida.Text, "ftp://" & server + "/cotizaciones" + "/" + lblFile.Text, user, pass, True, 50000)

            MessageBox.Show("Subida Exitosa.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            GuardarArchivo(idCotizacion, id, lblFile.Text)
            LimpiarSubida()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LimpiarSubida()
        txtprefijo.Text = ""
        txtIdArchivo.Text = ""
        txtArchivoSubida.Text = ""
        lblFile.Text = "..."
    End Sub

    Private Sub btnExaminarSubida_Click(sender As Object, e As EventArgs) Handles btnExaminarSubida.Click
        Dim op As New OpenFileDialog

        If txtprefijo.Text = "" Then
            MessageBox.Show("Debe seleccionar una cotización desde la tabla .", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txtIdArchivo.Text = "" Then
            Return
        End If

        With op
            .ShowDialog()
            idCotizacion = txtprefijo.Text
            id = txtIdArchivo.Text
            txtArchivoSubida.Text = .FileName
            lblFile.Text = idCotizacion & "-" & id & "-" & .SafeFileName
        End With


    End Sub

    Private Sub btnExaminarDescarga_Click(sender As Object, e As EventArgs) Handles btnExaminarDescarga.Click
        FolderBrowserDialog.ShowDialog()
        txtRuta.Text$ = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click
        Try
            DatosFTP()
            Dim url As String = "ftp://" & user & ":" & pass & "@" & server & txtArchivoDescarga.Text$
            AddHandler wc.DownloadFileCompleted, AddressOf DownloadCompleted
            wc.DownloadFileAsync(New Uri(url), txtRuta.Text$ & "\" & txtArchivoDescarga.Text.Substring(txtArchivoDescarga.Text.LastIndexOf("/") + 1))
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        MessageBox.Show("Descarga Exitosa.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgvCotizaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCotizaciones.CellClick


    End Sub

    Private Sub GuardarArchivo(ByVal idCotizacion As Integer, ByVal idArchivo As Integer, ByVal nombre As String)

        Try
            'Dim idArchivo As Integer            

            Dim rpta As String = Cotizacion.RegistrarArchivo(idCotizacion, idArchivo, nombre)
            If rpta <> "" Then
                Throw New System.Exception(rpta)
            End If


            MessageBox.Show("El archivo se ha registrado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarArchivos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub listarTipos()
        Dim listaTipos As DataTable
        listaTipos = TipoPersonal.listar()
        With cboCargos
            .DataSource = listaTipos
            .ValueMember = listaTipos.Columns(0).ColumnName
            .DisplayMember = listaTipos.Columns(1).ColumnName
        End With
    End Sub

    Private Sub actualizarArchivos()
        Dim archivos As DataTable

        archivos = Cotizacion.ListarArchivos()
        dgArchivos.DataSource = archivos
    End Sub

    Private Sub dgArchivos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArchivos.CellClick
        Dim row As Integer
        Dim archivo As String

        row = dgArchivos.CurrentRow.Index
        archivo = dgArchivos.Item(2, row).Value
        txtArchivoDescarga.Text = "/cotizaciones/" & archivo
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Close()
    End Sub

    Private Sub dgArchivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArchivos.CellContentClick

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        dgArchivos.DataSource = Cotizacion.ListarPorFechas(dtpInicio.Value.ToShortDateString, dtpFin.Value.ToShortDateString)


    End Sub

    Private Sub dtpFechaCotizacion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaCotizacion.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


        txtCodigo.Text = dtpFechaCotizacion.Value.Date


    End Sub

    Private Sub btnAddPersonal_Click(sender As Object, e As EventArgs) Handles btnAddPersonal.Click
        If cboCargos.Text = "" Then
            MessageBox.Show("Seleccione un cargo para el personal a asignar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cantEmpleados As Integer = 0
        Try
            cantEmpleados = CInt(txtCantEmpleados.Text)
        Catch
            MessageBox.Show("Ingrese una cantidad válida para el nro de trabajadores.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        dgvEmpleados.Rows.Add(cboCargos.Text, cantEmpleados)


    End Sub

    Private Sub btnElimEmpleados_Click(sender As Object, e As EventArgs) Handles btnElimEmpleados.Click
        Try
            Dim filaActual As Integer = dgvEmpleados.CurrentCell.RowIndex
            dgvEmpleados.Rows.RemoveAt(filaActual)
        Catch
            MessageBox.Show("Debe seleccionar la fila del personal a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvMateriales_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMateriales.CellEndEdit
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

    Private Sub ChkAgregarDuracion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAgregarDuracion.CheckedChanged
        nudDuracionHoras.Enabled = ChkAgregarDuracion.Checked
        dtpFechaCotizacion.Enabled = ChkAgregarDuracion.Checked
        NudDuracionDias.Enabled = ChkAgregarDuracion.Checked

        If Not ChkAgregarDuracion.Checked Then
            NudDuracionDias.Value = 0
            nudDuracionHoras.Value = 1
        End If
    End Sub

    Private Sub BtnBuscarDescripcion_Click(sender As Object, e As EventArgs) Handles BtnBuscarDescripcion.Click
        dgvCotizaciones.DataSource = Cotizacion.ListarPorDescripcion(txtBuscarDescripcion.Text)
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click

        Try
            If txtTituloItem.Text.Trim = "" Then
                MessageBox.Show("Por favor, ingrese Título del Item.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If dgvMateriales.Rows.Count.Equals(0) Then
                MessageBox.Show("Por favor, ingrese al menos un detalle de materiales.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim esNuevo As Boolean = False
            'Dim detCotiEliminado As New DetalleCotizacion

            'Verificar que no exista un titulo item ya ingresado
            If idDetalleActual.Equals(0) Then
                Dim detalles = listaDetalleCotizacion.AsEnumerable().Any(Function(x) x.Titulo.Equals(txtTituloItem.Text))
                If detalles Then
                    MessageBox.Show("El Título del Item ya existe, ingrese uno distinto", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                If listaDetalleCotizacion.Any Then
                    idDetalleActual = listaDetalleCotizacion.AsEnumerable().Min(Function(x) x.IDDetalleItem) - 1
                Else
                    idDetalleActual = -1
                End If

                esNuevo = True
            Else
                detCotiEliminado = listaDetalleCotizacion.AsEnumerable().FirstOrDefault(Function(x) x.IDDetalleItem.Equals(idDetalleActual))

            End If


            Dim detalleCotizacion As New DetalleCotizacion
            detalleCotizacion.Titulo = txtTituloItem.Text.Trim
            detalleCotizacion.DescripcionTrabajo = txtDescripcionTrabajo.Text.Trim
            detalleCotizacion.IDDetalleItem = idDetalleActual


            For Each row As DataGridViewRow In dgvEmpleados.Rows
                Dim cotizaDetPersonal As New CotizacionDetallePersonal
                cotizaDetPersonal.ID_DetalleItem = idDetalleActual
                cotizaDetPersonal.Personal = row.Cells("Cargo").Value
                cotizaDetPersonal.Cantidad = row.Cells("Cantidad_").Value
                cotizaDetPersonal.Valor = row.Cells("Valor").Value
                detalleCotizacion.LstDetallePersonal.Add(cotizaDetPersonal)
            Next

            For Each row As DataGridViewRow In dgvMateriales.Rows
                Dim cotiDetMaterial As New CotizacionDetalleMaterial
                cotiDetMaterial.ID_DetalleItem = idDetalleActual

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

                detalleCotizacion.LstDetalleMateriales.Add(cotiDetMaterial)
            Next


            If esNuevo Then
                listaDetalleCotizacion.Add(detalleCotizacion)
            Else

                listaDetalleCotizacion.Remove(detCotiEliminado)

                listaDetalleCotizacion.Add(detalleCotizacion)
            End If


            CargarDetallesItems()
            LimpiarDatosDetalle()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbDetallesCotizacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDetallesCotizacion.SelectedIndexChanged
        Try
            idDetalleActual = cbDetallesCotizacion.SelectedValue

            Dim detalle = listaDetalleCotizacion.AsEnumerable.FirstOrDefault(Function(z) z.IDDetalleItem.Equals(idDetalleActual))

            LimpiarDatosDetalle()

            If detalle IsNot Nothing Then

                Dim detalleItem As DetalleCotizacion = CType(detalle, DetalleCotizacion)

                txtTituloItem.Text = detalleItem.Titulo
                txtDescripcionTrabajo.Text = detalleItem.DescripcionTrabajo

                For Each cotiDetPersonal In detalleItem.LstDetallePersonal

                    Dim detPersonal As CotizacionDetallePersonal = CType(cotiDetPersonal, CotizacionDetallePersonal)
                    dgvEmpleados.Rows.Add(detPersonal.Personal, detPersonal.Cantidad, detPersonal.Valor)

                Next


                Dim subTotal As Decimal = 0

                For Each cotiDetMaterial In detalleItem.LstDetalleMateriales

                    Dim detMaterial As CotizacionDetalleMaterial = CType(cotiDetMaterial, CotizacionDetalleMaterial)
                    dgvMateriales.Rows.Add(detMaterial.Codigo, detMaterial.NombreMaterial, detMaterial.EsAlquilerCol,
                                            detMaterial.Cantidad, detMaterial.Precio_Unitario, detMaterial.Duracion_Dias,
                                            detMaterial.Duracion_Horas, detMaterial.Precio_Alquiler_Dia,
                                            detMaterial.Precio_Alquiler_Hora, detMaterial.Descuento, detMaterial.Precio_Total)

                    subTotal += detMaterial.Precio_Total

                Next

                txtTotal.Text = subTotal

            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvCotizaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCotizaciones.CellDoubleClick
        Dim row As Integer
        Try
            LimpiarSubida()

            row = dgvCotizaciones.CurrentRow.Index
            codigoCotizacion = dgvCotizaciones.Item(0, row).Value
            txtprefijo.Text = codigoCotizacion
            txtIdArchivo.Text = Cotizacion.ObtenerUltimoIDArchivo(codigoCotizacion) + 1

            MessageBox.Show("Código Cotización: " & txtprefijo.Text, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnNuevoItem_Click(sender As Object, e As EventArgs) Handles btnNuevoItem.Click
        Try
            CargarDetallesItems()
            cbDetallesCotizacion.SelectedValue = 0
            LimpiarDatosDetalle()

            If listaDetalleCotizacion.Any Then
                idDetalleActual = listaDetalleCotizacion.AsEnumerable().Min(Function(x) x.IDDetalleItem) - 1
            Else
                idDetalleActual = -1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarDatosDetalle()

        txtTituloItem.Text = ""
        txtDescripcionTrabajo.Text = ""

        txtMaterial.Text = ""
        txtCantidad.Text = ""
        NudDuracionDiasMaterial.Value = 0
        NudDuracionHorasMaterial.Value = 0
        NudDescuento.Value = 0
        txtTotal.Text = ""
        cboCargos.Text = ""
        txtCantEmpleados.Text = ""



        dgvEmpleados.Rows.Clear()
        dgvMateriales.Rows.Clear()



    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer
        Try
            If dgvCotizaciones.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvCotizaciones.CurrentRow.Index
            End If


            Dim codigoCotizacion As Integer = dgvCotizaciones.Item(0, row).Value.ToString
            Dim nombre As String = dgvCotizaciones.Item(1, row).Value.ToString
            Dim RUC As String = dgvCotizaciones.Item(2, row).Value.ToString
            Dim fechaRegistro As Date = dgvCotizaciones.Item(3, row).Value.ToString
            Dim descripcion As String = dgvCotizaciones.Item(4, row).Value.ToString
            Dim duracionDias As Integer = dgvCotizaciones.Item(5, row).Value.ToString
            Dim horaInicio As Date = dgvCotizaciones.Item(6, row).Value.ToString
            Dim duracionHoras As Integer = dgvCotizaciones.Item(7, row).Value.ToString
            Dim estado As String = dgvCotizaciones.Item(8, row).Value.ToString

            If estado <> "PENDIENTE" Then
                MessageBox.Show("No se puede modificar un elemento en estado no Pendiente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim formModificar As New ModifCotizaciones(codigoCotizacion, nombre, fechaRegistro, descripcion,
                                                       duracionDias, horaInicio, duracionHoras, estado)
            formModificar.ShowDialog()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Try
            Dim row As Integer

            If dgvCotizaciones.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvCotizaciones.CurrentRow.Index
            End If

            Dim codigoCotizacion As Integer = dgvCotizaciones.Item(0, row).Value.ToString

            Dim result As Integer = MessageBox.Show(String.Format("¿Desea autorizar la Cotización {0}?", codigoCotizacion), "Autorizar Cotización", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim rpta As String = Cotizacion.AutorizarCotizacion(codigoCotizacion - 10000)
                If rpta <> "" Then Throw New Exception(rpta)
                MessageBox.Show("La Cotización ha sido autorizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgvCotizaciones.DataSource = Cotizacion.ListarPorDescripcion(txtBuscarDescripcion.Text)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Try
            Dim frmExProv As New ExamProveedor(txtProveedor, txtRuc, txtDirproveedor)
            frmExProv.ShowDialog()
            ID_ProveedorOSE = frmExProv.getIdProv()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCotizacionOSE_Click(sender As Object, e As EventArgs) Handles btnCotizacionOSE.Click
        Dim form As New ExaminarCotizaciones(txtCotizacionOSE)
        Try

            form.ShowDialog()
            ID_CotizacionOSE = form.idCotizacion - 10000

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnGrabarOSE_Click(sender As Object, e As EventArgs) Handles btnGrabarOSE.Click
        If txtProveedor.Text.Trim = "" Then
            MessageBox.Show("Seleccione un Proveedor.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtCotizacionOSE.Text.Trim = "" Then
            MessageBox.Show("Seleccione una Cotización.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtCantidadOSE.Text.Trim = "" Then
            MessageBox.Show("Ingrese una cantidad", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Validar cantidad OSE
        Dim cantidadOSE As Decimal = 0
        Try
            cantidadOSE = CInt(txtCantidadOSE.Text.Trim)
        Catch ex As Exception
            MessageBox.Show("Ingrese una cantidad válida", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        If txtPrecioUnitarioOSE.Text.Trim = "" Then
            MessageBox.Show("Ingrese una Precio Unitario", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Validar cantidad OSE
        Dim precioUnitarioOSE As Decimal = 0
        Try
            precioUnitarioOSE = CDbl(txtPrecioUnitarioOSE.Text.Trim)
        Catch ex As Exception
            MessageBox.Show("Ingrese un Precio Unitario válido", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        Dim totalOSE As Decimal = cantidadOSE * precioUnitarioOSE

        If txtDetalleOSE.Text.Trim = "" Then
            MessageBox.Show("Ingrese el detalle del Servicio Externo", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim rpta As String = Cotizacion.InsertarServicioExterno(ID_CotizacionOSE, ID_ProveedorOSE, txtDetalleOSE.Text, cantidadOSE, precioUnitarioOSE, totalOSE)
            If rpta <> "" Then Throw New Exception(rpta)
            MessageBox.Show("El Servicio Externo ha sido creado correctamente", "Crear Servicio Externo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarDatosOSE()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub LimpiarDatosOSE()
        txtProveedor.Text = ""
        txtRuc.Text = ""
        txtDirproveedor.Text = ""
        txtCotizacionOSE.Text = ""
        txtDetalleOSE.Text = ""
        txtCantidadOSE.Text = ""
        txtPrecioUnitarioOSE.Text = ""
        txtTotalOSE.Text = ""

    End Sub

    Private Sub txtCantidadOSE_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadOSE.TextChanged
        Try
            txtTotalOSE.Text = ""

            Dim cantidadOSE As Decimal = 0
            cantidadOSE = CInt(txtCantidadOSE.Text.Trim)

            Dim precioUnitarioOSE As Decimal = 0
            precioUnitarioOSE = CDbl(txtPrecioUnitarioOSE.Text.Trim)

            Dim totalOSE As Decimal = cantidadOSE * precioUnitarioOSE

            txtTotalOSE.Text = totalOSE.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecioUnitarioOSE_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitarioOSE.TextChanged
        Try
            txtTotalOSE.Text = ""
            Dim cantidadOSE As Decimal = 0
            cantidadOSE = CInt(txtCantidadOSE.Text.Trim)

            Dim precioUnitarioOSE As Decimal = 0
            precioUnitarioOSE = CDbl(txtPrecioUnitarioOSE.Text.Trim)

            Dim totalOSE As Decimal = cantidadOSE * precioUnitarioOSE

            txtTotalOSE.Text = totalOSE.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl3.SelectedIndexChanged
        Dim index As Integer = TabControl3.SelectedIndex

        If index.Equals(1) Then
            ListarrServiciosExternos()
        End If
    End Sub

    Private Sub ListarrServiciosExternos()
        Try

            Dim fechaInicio As Date = DateTime.Parse(dtpDesdeBuscarSE.Value.Date.ToShortDateString())
            Dim fechaFin As Date = DateTime.Parse(dtpHastaBuscarSE.Value.Date.ToShortDateString()).AddDays(1)

            dgvServiciosExternos.DataSource = Cotizacion.ListarServiciosExternos(ID_CotizacionOSE_Buscar, ID_ProveedorOSE_Buscar, fechaInicio, fechaFin)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarOSE_Click(sender As Object, e As EventArgs) Handles btnEliminarOSE.Click
        Try
            Dim row As Integer

            If dgvServiciosExternos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvServiciosExternos.CurrentRow.Index
            End If

            Dim codigoOSE As Integer = dgvServiciosExternos.Item(0, row).Value.ToString

            Dim result As Integer = MessageBox.Show(String.Format("¿Desea eliminar el Servicio Externo {0}?", codigoOSE), "Eliminar Servicio Externo", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Dim rpta As String = Cotizacion.EliminarServicioExterno(codigoOSE - 10000)
                If rpta <> "" Then Throw New Exception(rpta)
                MessageBox.Show("El Servicio Externo ha sido eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ListarrServiciosExternos()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificarOSE_Click(sender As Object, e As EventArgs) Handles btnModificarOSE.Click
        Dim row As Integer
        Try
            If dgvServiciosExternos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvServiciosExternos.CurrentRow.Index
            End If

            Dim codigoServicioExterno As Integer = dgvServiciosExternos.Item(0, row).Value - 10000


            Dim formModificar As New ModifServicioExterno(codigoServicioExterno)
            formModificar.ShowDialog()

            ListarrServiciosExternos()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvServiciosExternos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiciosExternos.CellContentClick

    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Try
            Dim row As Integer
            If dgvCotizaciones.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvCotizaciones.CurrentRow.Index
            End If

            Dim codigoCotizacion As String = dgvCotizaciones.Item(0, row).Value.ToString()

            Dim form As New Reporte_Cotizacion(codigoCotizacion)
            form.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarSE_Click(sender As Object, e As EventArgs) Handles btnBuscarSE.Click
        Try
            ListarrServiciosExternos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExamProvBuscar_Click(sender As Object, e As EventArgs) Handles btnExamProvBuscar.Click
        Try
            Dim frmExProv As New ExamProveedor(txtProveedorBuscarSE, txtRucBuscarSE)
            frmExProv.ShowDialog()
            ID_ProveedorOSE_Buscar = frmExProv.getIdProv()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExamCotiBuscar_Click(sender As Object, e As EventArgs) Handles btnExamCotiBuscar.Click

        Try
            Dim form As New ExaminarCotizaciones(txtCotizacionBuscarSE)
            form.ShowDialog()
            If Not form.idCotizacion.Equals(0) Then
                ID_CotizacionOSE_Buscar = form.idCotizacion - 10000
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles btnLimpiarBusqueda.Click
        Try
            txtProveedorBuscarSE.Text = ""
            txtRucBuscarSE.Text = ""
            txtCotizacionBuscarSE.Text = ""
            dtpDesdeBuscarSE.Value = DateTime.Now
            dtpHastaBuscarSE.Value = DateTime.Now

            ID_CotizacionOSE_Buscar = 0
            ID_ProveedorOSE_Buscar = 0

            ListarrServiciosExternos()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarDetallesItems()

        Dim lista As New List(Of EntidadDropDown)

        Dim entidadNuevoItem As New EntidadDropDown
        entidadNuevoItem.Id = 0
        entidadNuevoItem.Descripcion = "Seleccione"
        lista.Add(entidadNuevoItem)


        For Each detalle In listaDetalleCotizacion.OrderBy(Function(x) x.Titulo)
            Dim entidad As New EntidadDropDown
            entidad.Id = CType(detalle, DetalleCotizacion).IDDetalleItem
            entidad.Descripcion = CType(detalle, DetalleCotizacion).Titulo
            lista.Add(entidad)
        Next

        cbDetallesCotizacion.DataSource = lista
        cbDetallesCotizacion.ValueMember = "Id"
        cbDetallesCotizacion.DisplayMember = "Descripcion"

    End Sub

    Private Function ObtenerTotal() As Decimal
        Dim totalGeneral As Decimal = 0

        Try

            For Each detalle In listaDetalleCotizacion
                Dim det As DetalleCotizacion = CType(detalle, DetalleCotizacion)
                For Each detMaterial In det.LstDetalleMateriales
                    Dim detMat As CotizacionDetalleMaterial = CType(detMaterial, CotizacionDetalleMaterial)
                    totalGeneral += detMat.Precio_Total
                Next
            Next

        Catch ex As Exception

        End Try
        Return totalGeneral
    End Function

End Class