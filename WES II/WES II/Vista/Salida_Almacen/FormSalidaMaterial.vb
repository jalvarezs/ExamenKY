Public Class FormSalidaMaterial

    Dim ultimoCodigo As Integer = -1
    Private idReq As Integer

    Private Sub FormSalidaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            MostrarSgteID()

            CargarTipoDocumento()

            CargarTipoDocumentoConsultar()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MostrarSgteID()
        Try
            txtCodigo.Text = 1 + SalidaAlmacen.obtenerUltimoID + 10000
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExaminarR_Click(sender As Object, e As EventArgs) Handles btnExaminarR.Click
        Try
            If rb_Requerimiento.Checked = True Then
                Dim frmExamRequerimiento As New FormExamRequerimiento(txtRequerimiento, txtProyecto, txtCodOrdenCompra, txtAlmacenDestino)
                frmExamRequerimiento.ShowDialog()
            Else
                If Rb_OrdenTra.Checked = True Then
                    Dim ExamCotizacion As New ExamCotizacion(txtRequerimiento)
                    ExamCotizacion.ShowDialog()
                End If
            End If
            ActualizarDetalles(txtRequerimiento.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarDetalles(ByVal id As String)
        If id = "" Then
            MessageBox.Show("Debe seleccionar un requerimiento para la salida de materiales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        idReq = CInt(id) - 10000
        Dim detallesOrden As DataTable
        detallesOrden = Requerimiento.listarDetalles(idReq)
        detallesOrden.Columns.Add("Cantidad Saliente", Type.GetType("System.Int32"))
        detallesOrden.Columns.Add("Etiqueta Contenedor Origen", Type.GetType("System.String"))
        detallesOrden.Columns.Add("Contenedor Origen", Type.GetType("System.String"))

        For i As Integer = 0 To detallesOrden.Rows.Count - 1
            detallesOrden.Rows(i).Item(5) = 0
            detallesOrden.Rows(i).Item(6) = ""
            detallesOrden.Rows(i).Item(7) = ""
        Next

        dgvMateriales.DataSource = detallesOrden
    End Sub

    Private Sub btnCantidadParcial_Click(sender As Object, e As EventArgs) Handles btnCantidadParcial.Click
        Try
            AgregarCantidadRecibida()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AgregarCantidadRecibida()
        Dim row As Integer
        If dgvMateriales.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvMateriales.CurrentRow.Index
        End If

        If UtilConvertidor.GetInteger(dgvMateriales.Item(7, row).Value) = 0 Then
            MessageBox.Show(String.Format("Seleccione un contenedor para el Material ({0})", dgvMateriales.Item(0, row).Value), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim message, title, defaultValue As String
        Dim cantidadIngresada As Integer

        Dim idMaterial As Integer = UtilConvertidor.GetInteger(dgvMateriales.Item(0, row).Value) - 10000
        Dim cantidadRequerida As Integer = UtilConvertidor.GetInteger(dgvMateriales.Item(2, row).Value)
        Dim idContenedor As Integer = UtilConvertidor.GetInteger(dgvMateriales.Item(7, row).Value) - 10000
        Dim cantidadDisponible As Integer = 0

        'Obtener la cantidad disponible en el contenedor
        Dim ds As DataSet = SalidaAlmacen.ObtenerCantidadDisponibleContenedor(idReq, idContenedor, idMaterial)
        If ds IsNot Nothing Then

            Dim dtContenedor As DataTable = ds.Tables(0)
            If dtContenedor IsNot Nothing Then
                Dim drContenedor As DataRow = dtContenedor.AsEnumerable.FirstOrDefault
                cantidadDisponible = UtilConvertidor.GetInteger(drContenedor("Cantidad_Disponible_Contenedor"))
            End If

        End If

        message = String.Format("Por favor, ingrese la cantidad saliente. Cantidad disponible en el contenedor: {0}", cantidadDisponible)
        title = "Ingresar Cantidad Saliente"

        defaultValue = UtilConvertidor.GetInteger(dgvMateriales.Item(5, row).Value)
        cantidadIngresada = defaultValue

        Try
            Dim aux As String
            aux = InputBox(message, title, defaultValue)

            If aux <> "" Then
                cantidadIngresada = UtilConvertidor.GetInteger(aux)
            End If

            If cantidadIngresada <= 0 Then
                MessageBox.Show("La cantidad ingresada no puede ser menor o igual a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If cantidadIngresada > cantidadRequerida Then
                MessageBox.Show("La cantidad ingresada no puede ser mayor que la cantidad requerida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If cantidadIngresada > cantidadDisponible Then
                MessageBox.Show(String.Format("La cantidad ingresada ({0}) no puede ser mayor que la cantidad disponible ({1})",
                                              cantidadIngresada,
                                              cantidadDisponible),
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            dgvMateriales.Item(5, row).Value = cantidadIngresada

        Catch ex As Exception
            MessageBox.Show("El dato ingresado no es válido. Ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub btnCantidadTotal_Click(sender As Object, e As EventArgs) Handles btnCantidadTotal.Click
        Try
            For row As Integer = 0 To dgvMateriales.Rows.Count - 2
                dgvMateriales.Item(5, row).Value = dgvMateriales.Item(2, row).Value - dgvMateriales.Item(3, row).Value
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            '****************************** INICIO VALIDACIONES ****************************** 

            If Not dgvMateriales.Rows.Count > 1 Then
                MessageBox.Show("No se han registrado materiales en la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If (txtRequerimiento.Text.Trim = "") Then
                MessageBox.Show("Seleccione un requerimiento", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If Not (txtNumDocumento.Text.Trim = String.Empty) Then
                Dim dt As DataTable = SalidaAlmacen.BuscarSalidaAlmacen(txtNumDocumento.Text.Trim)
                If dt IsNot Nothing Then
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("El Número de Documento ya ha sido ingresado, por favor ingrese uno distinto", "Validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If
            End If

            If Not (cboTipoDocumento.SelectedValue = String.Empty) Then
                If (txtNumDocumento.Text.Trim = String.Empty) Then
                    MessageBox.Show("Ingrese Número de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtNumDocumento.Select()
                    Return
                End If
            End If

            If Not (txtNumDocumento.Text.Trim = String.Empty) Then
                If (cboTipoDocumento.SelectedValue = String.Empty) Then
                    MessageBox.Show("Seleccione Tipo de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboTipoDocumento.Select()
                    Return
                End If
            End If

            '****************************** FIN VALIDACIONES ****************************** 

            Dim entregaTotal As Boolean = True

            For Each row As DataGridViewRow In dgvMateriales.Rows

                'Validar que el Codigo de Material Exista
                If Not UtilConvertidor.GetInteger(row.Cells(0).Value).Equals(0) Then

                    Dim idMaterial As Integer = UtilConvertidor.GetInteger(row.Cells(0).Value) - 10000
                    Dim cantidadSolicitada As Integer = UtilConvertidor.GetInteger(row.Cells(2).Value)


                    Dim cantidadSaliente As Integer = UtilConvertidor.GetInteger(row.Cells(5).Value)
                    Dim contenedor As String = row.Cells(7).Value

                    If (contenedor = "") Then
                        MessageBox.Show(String.Format("Seleccione un contenedor para el Material ({0})", row.Cells(0).Value),
                                        "Validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    Dim idContenedor As Integer = UtilConvertidor.GetInteger(row.Cells(7).Value) - 10000

                    Dim cantidadDisponibleContenedor As Integer = 0
                    Dim totalSalidaAlmacen As Integer = 0

                    Dim ds As DataSet = SalidaAlmacen.ObtenerCantidadDisponibleContenedor(idReq, idContenedor, idMaterial)
                    If ds IsNot Nothing Then

                        'Cantidad Disponible Contenedor
                        Dim dtContenedor As DataTable = ds.Tables(0)
                        If dtContenedor IsNot Nothing Then
                            Dim drContenedor As DataRow = dtContenedor.AsEnumerable.FirstOrDefault
                            If drContenedor IsNot Nothing Then
                                cantidadDisponibleContenedor = UtilConvertidor.GetInteger(drContenedor("Cantidad_Disponible_Contenedor"))
                            End If
                        End If

                        'Total Salida Almacen
                        Dim dtDetalleSalida As DataTable = ds.Tables(1)
                        If dtDetalleSalida IsNot Nothing Then
                            Dim drDetalleSalida As DataRow = dtDetalleSalida.AsEnumerable.FirstOrDefault
                            If drDetalleSalida IsNot Nothing Then
                                totalSalidaAlmacen = UtilConvertidor.GetInteger(drDetalleSalida("Total_Salida_Almacen"))
                            End If
                        End If

                    End If

                    If (cantidadSaliente <= 0) Then
                        MessageBox.Show(String.Format("La cantidad saliente no puede ser menor o igual que cero. Verifique el Material ({0})",
                                                      row.Cells(0).Value), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    If (totalSalidaAlmacen + cantidadSaliente) > cantidadSolicitada Then
                        MessageBox.Show(String.Format("El requerimiento tiene un total de salidas ({0}). La cantidad de salida máxima permitida es ({1}). Verifique el Material ({2}) )",
                                                  totalSalidaAlmacen,
                                                  (cantidadSolicitada - totalSalidaAlmacen),
                                                  row.Cells(0).Value),
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    If (cantidadSaliente > cantidadDisponibleContenedor) Then
                        MessageBox.Show(String.Format("La cantidad saliente ({0}) no puede ser mayor que la cantidad disponible en el contenedor ({1}). Verifique el Material ({2})",
                                                  cantidadSaliente,
                                                  cantidadDisponibleContenedor,
                                                  row.Cells(0).Value
                                                  ), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    If (cantidadSaliente > cantidadSolicitada) Then
                        MessageBox.Show(String.Format("La cantidad saliente no puede ser mayor que la cantidad solicitada. Verifique el Material ({0})",
                                                  row.Cells(0).Value),
                                                   "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    If (totalSalidaAlmacen + cantidadSaliente) <> cantidadSolicitada Then
                        entregaTotal = False
                    End If

                End If


            Next

            _conexion.iniciarTransaccion()
            Try

                Dim rpta As String = SalidaAlmacen.RegistrarSalida(dpFechaReq.Text, idReq, _usuario, txtNumDocumento.Text.Trim, cboTipoDocumento.SelectedValue)
                If rpta <> "" Then Throw New System.Exception(rpta)

                Dim idSalida As Integer
                Dim idMaterial As Integer
                For Each row As DataGridViewRow In dgvMateriales.Rows

                    idSalida = SalidaAlmacen.obtenerUltimoID()
                    idMaterial = UtilConvertidor.GetInteger(row.Cells(0).Value) - 10000

                    If idMaterial > 0 And row.Cells(5).Value <> 0 Then

                        rpta = SalidaAlmacen.RegistrarDetalleSalida(CStr(idSalida), idMaterial, row.Cells(5).Value, row.Cells(7).Value)
                        If rpta <> "" Then Throw New System.Exception(rpta)

                    End If
                Next

                If entregaTotal Then
                    rpta = SalidaAlmacen.ActualizarRequerimiento(idReq, "Entregado Totalmente")
                    If rpta <> "" Then Throw New System.Exception(rpta)
                Else
                    rpta = SalidaAlmacen.ActualizarRequerimiento(idReq, "Entregado Parcialmente")
                    If rpta <> "" Then Throw New System.Exception(rpta)
                End If

                If rpta.Equals("") Then
                    MessageBox.Show("La salida de materiales se ha registrado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _conexion.hacerCommit()

                    LimpiarCampos()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                _conexion.hacerRollBack()
            End Try

        Catch ex_ As Exception
            MessageBox.Show(ex_.Message, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub LimpiarCampos()
        txtAlmacenDestino.Text = ""
        txtCodOrdenCompra.Text = ""
        txtProyecto.Text = ""
        txtRequerimiento.Text = ""

        txtNumDocumento.Text = String.Empty
        cboTipoDocumento.SelectedValue = String.Empty

        dgvMateriales.DataSource = Nothing
        dgvMateriales.Rows.Clear()

        MostrarSgteID()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim salidas As DataTable
            salidas = SalidaAlmacen.listarPorFechas(dtpDesde.Text, dtpHasta.Text, txtNumDocBuscar.Text.Trim, cbTipoDocBuscar.SelectedValue)
            dgvSalidas.DataSource = salidas
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvSalidas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSalidas.SelectionChanged
        Try
            Dim nuevaSeleccion As Integer
            If dgvSalidas.CurrentRow Is Nothing Then
                Return
            Else
                nuevaSeleccion = dgvSalidas.CurrentRow.Index
            End If

            Dim id As Integer = dgvSalidas.Item(0, nuevaSeleccion).Value.ToString()

            ActualizarDetallesSalida(id)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActualizarDetallesSalida(ByVal id As String)
        Dim SalidaID As Integer
        SalidaID = CInt(id) - 10000
        If ultimoCodigo <> id Then
            Dim detallesSalida As DataTable
            detallesSalida = SalidaAlmacen.listarDetalles(SalidaID)
            dgvDetalles.DataSource = detallesSalida
            ultimoCodigo = id
        End If
    End Sub

    Private Sub btnExamCont_Click(sender As Object, e As EventArgs) Handles btnExamCont.Click
        Try
            Dim row As Integer
            If dgvMateriales.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvMateriales.CurrentRow.Index
            End If

            ' Abrimos el form para examinar contenedores con el material seleccionado
            Dim idMaterial As String = dgvMateriales.Item(0, row).Value

            Dim formExamCont As New FormExamContenedor(idMaterial)
            formExamCont.ShowDialog()

            dgvMateriales.Item(6, row).Value = formExamCont.EtiquetaContenedor
            dgvMateriales.Item(7, row).Value = formExamCont.IdContenedor

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarTipoDocumento()
        Dim lista As New List(Of EntidadDropDown)

        Dim entidadNuevoItem As New EntidadDropDown
        entidadNuevoItem.IdStr = String.Empty
        entidadNuevoItem.Descripcion = "Seleccione"
        lista.Add(entidadNuevoItem)

        Dim dt As DataTable = TipoDocumento.ListarTipoDocumentos


        For Each dr As DataRow In dt.Rows
            Dim entidad As New EntidadDropDown
            entidad.IdStr = dr("CODIGO")
            entidad.Descripcion = dr("DESCRIPCION")
            lista.Add(entidad)
        Next

        cboTipoDocumento.DataSource = lista
        cboTipoDocumento.ValueMember = "IdStr"
        cboTipoDocumento.DisplayMember = "Descripcion"

    End Sub

    Private Sub CargarTipoDocumentoConsultar()
        Dim lista_ As New List(Of EntidadDropDown)

        Dim entidadNuevoItem_ As New EntidadDropDown
        entidadNuevoItem_.IdStr = String.Empty
        entidadNuevoItem_.Descripcion = "Seleccione"
        lista_.Add(entidadNuevoItem_)

        Dim dt_ As DataTable = TipoDocumento.ListarTipoDocumentos


        For Each dr_ As DataRow In dt_.Rows
            Dim entidad_ As New EntidadDropDown
            entidad_.IdStr = dr_("CODIGO")
            entidad_.Descripcion = dr_("DESCRIPCION")
            lista_.Add(entidad_)
        Next

        cbTipoDocBuscar.DataSource = lista_
        cbTipoDocBuscar.ValueMember = "IdStr"
        cbTipoDocBuscar.DisplayMember = "Descripcion"

    End Sub

    Private Sub rb_Requerimiento_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Requerimiento.CheckedChanged
        If rb_Requerimiento.Checked = True Then
            Label9.Text = "(*) Requerimiento"
        End If
    End Sub

    Private Sub Rb_OrdenTra_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_OrdenTra.CheckedChanged
        If Rb_OrdenTra.Checked = True Then
            Label9.Text = "(*) Orden de Trabajo"
        End If
    End Sub
End Class