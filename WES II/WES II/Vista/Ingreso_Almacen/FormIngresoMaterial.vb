Public Class FormIngresoMaterial
    Private CantidadContenedor As Integer
    Private conexion As Conexion
    Dim idOrdenCompra As Integer
    Private idContenedor As String = String.Empty
    Dim ultimoCodigo As Integer = -1
    Dim detallesOrden As DataTable
    Dim listDetalleMaterial As List(Of IngresoMaterialDetalle)

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim recibidaTotalmente As Boolean = True
        Dim existeCantidadEntrante As Boolean = False

        Try
            If Not ValidarDatos() Then Return

            For Each row As DataGridViewRow In dgvMateriales.Rows

                Dim cantidadRecibida As Integer
                Dim cantidadEntrante As Integer
                Dim cantidadSolicitada As Integer

                cantidadEntrante = UtilConvertidor.GetInteger(row.Cells(5).Value)
                cantidadSolicitada = UtilConvertidor.GetInteger(row.Cells(2).Value)
                cantidadRecibida = UtilConvertidor.GetInteger(row.Cells(3).Value)

                If cantidadEntrante > 0 Then
                    existeCantidadEntrante = True
                End If

                If Not cantidadSolicitada.Equals(cantidadRecibida + cantidadEntrante) Then
                    recibidaTotalmente = False
                End If

            Next

            If Not existeCantidadEntrante Then
                MessageBox.Show("No existe valores para realizar un ingreso de materiales", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Catch ex As Exception

        End Try

        _conexion.iniciarTransaccion()
        Try

            Dim rpta As String = IngresoAlmacen.registrarIngreso(dtpFechaIngreso.Text,
                                                                 idOrdenCompra,
                                                                 _usuario,
                                                                 txtNumeroDocumento.Text.Trim,
                                                                 cboTipoDocumento.SelectedValue)

            If rpta <> "" Then Throw New System.Exception(rpta)

            Dim idIngreso As Integer = IngresoAlmacen.obtenerUltimoID()
            Dim idMaterial As Integer


            For Each detalle As IngresoMaterialDetalle In listDetalleMaterial

                idMaterial = CInt(detalle.CodigoMaterial) - 10000

                If idMaterial > 0 And detalle.CantidadEntrante <> 0 Then
                    rpta = IngresoAlmacen.registrarDetalleIngreso(CStr(idIngreso), CStr(idMaterial), detalle.CantidadEntrante, detalle.PrecioReferencial, detalle.Contenedor, dtpFechaIngreso.Value)
                    If rpta <> "" Then Throw New System.Exception(rpta)
                End If

                Contenedor.ActualizarCantidad(detalle.Contenedor, detalle.CantidadEntrante)

            Next


            If recibidaTotalmente Then
                rpta = IngresoAlmacen.ActualizarEstadoOrdenCompra(idOrdenCompra, UtilConstantes.OrdenCompra.Estado.EntregadoTotalmente)
                If rpta <> "" Then Throw New System.Exception(rpta)
            Else
                rpta = IngresoAlmacen.ActualizarEstadoOrdenCompra(idOrdenCompra, UtilConstantes.OrdenCompra.Estado.EntregadoParcialmente)
                If rpta <> "" Then Throw New System.Exception(rpta)
            End If

            If rpta.Equals("") Then
                MessageBox.Show("El ingreso al almacén se ha registrado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                _conexion.hacerCommit()

                LimpiarCampos()

                CantidadContenedor = 0
                'idOrdenCompra = 0
                idContenedor = String.Empty
                listDetalleMaterial = New List(Of IngresoMaterialDetalle)

                ActualizarDetalles(idOrdenCompra)

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _conexion.hacerRollBack()
        End Try

    End Sub

    Private Sub LimpiarCampos()
        'txtOrden.Text = ""
        'txtProveedor.Text = ""
        'txtOferta.Text = ""
        'txtProyecto.Text = ""
        txtContenedor.Text = ""
        txtNumeroDocumento.Text = String.Empty

        cboTipoDocumento.SelectedValue = String.Empty

        dgvMateriales.DataSource = Nothing
        dgvMateriales.Rows.Clear()
    End Sub

    Private Function ValidarDatos() As Boolean
        If (txtOrden.Text.Trim = "") Then
            MessageBox.Show("Seleccione una orden de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOrden.Select()
            Return False
        End If

        If (txtContenedor.Text.Trim = "") Then
            MessageBox.Show("Seleccione un contenedor destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContenedor.Select()
            Return False
        End If

        If Not dgvMateriales.Rows.Count > 1 Then
            MessageBox.Show("No se han registrado materiales en el ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not (cboTipoDocumento.SelectedValue = "") Then
            If (txtNumeroDocumento.Text.Trim = "") Then
                MessageBox.Show("Ingrese Número de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNumeroDocumento.Select()
                Return False
            End If
        End If

        If Not (txtNumeroDocumento.Text.Trim = "") Then
            If (cboTipoDocumento.SelectedValue = "") Then
                MessageBox.Show("Seleccione Tipo de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboTipoDocumento.Select()
                Return False
            End If
        End If

        Return True

    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnExaminarOrden_Click(sender As Object, e As EventArgs) Handles btnExaminarOrden.Click
        Try
            Dim eoc As New ExmOrdenCompra
            eoc.ShowDialog()
            Dim codigo As String = eoc.getOrdenCompra
            txtOrden.Text = codigo

            If codigo <> "" Then
                idOrdenCompra = CInt(codigo) - 10000
                txtProveedor.Text = eoc.getProveedor
                txtProyecto.Text = eoc.getProyecto
                txtOferta.Text = eoc.getOferta

                ActualizarDetalles(idOrdenCompra)

            Else
                LimpiarCampos()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ActualizarDetalles(ByVal idOrdenCompra As Integer)
        Try
            detallesOrden = OrdenCompra.listarDetalles(idOrdenCompra)

            detallesOrden.Columns.Add("Cantidad Entrante", Type.GetType("System.Int32"))

            For i As Integer = 0 To detallesOrden.Rows.Count - 1
                detallesOrden.Rows(i).Item(5) = 0

                Dim detalle As New IngresoMaterialDetalle
                detalle.OrdenCompra = idOrdenCompra
                detalle.CodigoMaterial = detallesOrden.Rows(i).Item(0)
                detalle.Material = detallesOrden.Rows(i).Item(1)
                detalle.CantidadSolicitada = UtilConvertidor.GetInteger(detallesOrden.Rows(i).Item(2))
                detalle.CantidadRecibida = UtilConvertidor.GetInteger(detallesOrden.Rows(i).Item(3))
                detalle.PrecioReferencial = UtilConvertidor.GetDecimal(detallesOrden.Rows(i).Item(4))
                detalle.CantidadEntrante = UtilConvertidor.GetInteger(detallesOrden.Rows(i).Item(5))
                detalle.Contenedor = idContenedor
                detalle.TipoContenedor = UtilConstantes.TipoContenedor.Base
                listDetalleMaterial.Add(detalle)

            Next

            dgvMateriales.DataSource = detallesOrden


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefinirCantidad_Click(sender As Object, e As EventArgs) Handles btnDefinirCantidad.Click
        Try
            If (txtOrden.Text.Trim = "") Then
                MessageBox.Show("Seleccione una orden de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtOrden.Select()
                Return
            End If

            If (txtContenedor.Text.Trim = "") Then
                MessageBox.Show("Seleccione un contenedor destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContenedor.Select()
                Return
            End If

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

        Dim message, title, defaultValue As String
        Dim cantidadEntrante As Integer
        Dim cantidadSolicitada As Integer
        Dim cantidadRecibida As Integer
        Dim codigoMaterial As String

        ' Set prompt.
        message = "Defina la cantidad entrante"
        ' Set title.
        title = "Instruccion"

        codigoMaterial = dgvMateriales.Item(0, row).Value

        defaultValue = dgvMateriales.Item(5, row).Value   ' Set default value.
        cantidadEntrante = UtilConvertidor.GetInteger(defaultValue)

        cantidadSolicitada = UtilConvertidor.GetInteger(dgvMateriales.Item(2, row).Value)
        cantidadRecibida = UtilConvertidor.GetInteger(dgvMateriales.Item(3, row).Value)

        ' Display message, title, and default value.
        Try

            Dim aux As String
            aux = InputBox(message, title, defaultValue)

            If UtilConvertidor.GetInteger(aux) <= 0 Then Throw New Exception()

            If aux <> "" Then cantidadEntrante = UtilConvertidor.GetInteger(aux)

            If cantidadEntrante > cantidadSolicitada Then
                MessageBox.Show(String.Format("La cantidad entrante no puede ser mayor que la cantidad solicitada. Por favor, verifique Material: {0}", codigoMaterial),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cantidadEntrante > (cantidadSolicitada - cantidadRecibida) Then
                MessageBox.Show(String.Format("La cantidad entrante excede el total de las cantidad recibidas. Por favor, verifique Material: {0}", codigoMaterial),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If CantidadContenedor - cantidadEntrante < 0 Then
                MessageBox.Show(String.Format("El contenedor solo tiene espacio para {0} elementos.", CantidadContenedor), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            CantidadContenedor = CantidadContenedor - cantidadEntrante

            dgvMateriales.Item(5, row).Value = cantidadEntrante

            If UtilConvertidor.GetInteger(defaultValue) > 0 Then
                Dim result As Integer = MessageBox.Show("¿Está seguro que desea editar la cantidad recibida? Si modifica la cantidad recibida los contenedores adicionales será eliminados", "Confirmar", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    listDetalleMaterial.RemoveAll(Function(x) x.CodigoMaterial.Equals(codigoMaterial) And x.TipoContenedor.Equals(UtilConstantes.TipoContenedor.Adicional))
                End If

            End If

            Dim detalle As IngresoMaterialDetalle
            detalle = listDetalleMaterial.Where(Function(x) x.CodigoMaterial.Equals(codigoMaterial) And x.TipoContenedor.Equals(UtilConstantes.TipoContenedor.Base)).FirstOrDefault
            detalle.CantidadEntrante = cantidadEntrante


        Catch ex As Exception
            MessageBox.Show("El dato ingresado no es válido. Ingrese un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

    End Sub

    Private Sub btnDefinirTotal_Click(sender As Object, e As EventArgs) Handles btnDefinirTotal.Click
        Try

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea editar la cantidad total recibida? Si modifica la cantidad recibida los contenedores adicionales será eliminados", "Confirmar", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                For row As Integer = 0 To dgvMateriales.Rows.Count - 2

                    Dim IdCodigoMaterial As String = dgvMateriales.Item(0, row).Value
                    Dim cantidadEntranteTotal As Integer = dgvMateriales.Item(2, row).Value - dgvMateriales.Item(3, row).Value

                    listDetalleMaterial.RemoveAll(Function(x) x.CodigoMaterial.Equals(IdCodigoMaterial) And x.TipoContenedor.Equals(UtilConstantes.TipoContenedor.Adicional))

                    Dim detalle As IngresoMaterialDetalle
                    detalle = listDetalleMaterial.Where(Function(x) x.CodigoMaterial.Equals(IdCodigoMaterial) And x.TipoContenedor.Equals(UtilConstantes.TipoContenedor.Base)).FirstOrDefault
                    detalle.CantidadEntrante = cantidadEntranteTotal

                    dgvMateriales.Item(5, row).Value = cantidadEntranteTotal

                Next

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim ingresos As DataTable
        ingresos = IngresoAlmacen.listarPorFechas(dtpDesde.Text, dtpHasta.Text)
        dgvIngresos.DataSource = ingresos
    End Sub

    Private Sub dgvIngresos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvIngresos.SelectionChanged
        Dim nuevaSeleccion As Integer
        If dgvIngresos.CurrentRow Is Nothing Then
            Return
        Else
            nuevaSeleccion = dgvIngresos.CurrentRow.Index
        End If

        Dim id As Integer = dgvIngresos.Item(0, nuevaSeleccion).Value.ToString()

        actualizarDetallesIngreso(id)
    End Sub

    Private Sub actualizarDetallesIngreso(ByVal id As String)
        Dim IngresoID As Integer
        IngresoID = CInt(id) - 10000
        If ultimoCodigo <> id Then
            Dim detallesIngreso As DataTable
            detallesIngreso = IngresoAlmacen.listarDetalles(IngresoID)
            dgvDetalles.DataSource = detallesIngreso
            ultimoCodigo = id
        End If
    End Sub

    Private Sub btnDefinirPrecio_Click(sender As Object, e As EventArgs) Handles btnDefinirPrecio.Click
        Try
            DefinirPrecioActualizado()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DefinirPrecioActualizado()
        Dim row As Integer
        If dgvMateriales.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvMateriales.CurrentRow.Index
        End If

        Dim message, title, defaultValue As String
        Dim precio As Decimal
        Dim codigoMaterial As String

        codigoMaterial = dgvMateriales.Item(0, row).Value

        ' Set prompt.
        message = "Defina el nuevo precio actualizado para el ingreso.(Opcional)"
        ' Set title.
        title = "Instruccion"
        defaultValue = dgvMateriales.Item(4, row).Value   ' Set default value.
        precio = UtilConvertidor.GetDecimal(defaultValue)
        ' Display message, title, and default value.

        Try
            Dim aux As String
            aux = InputBox(message, title, defaultValue)

            If UtilConvertidor.GetDecimal(aux) <= 0 Then
                Throw New Exception()
            End If

            If aux <> "" Then
                precio = UtilConvertidor.GetDecimal(aux)
            End If

            dgvMateriales.Item(4, row).Value = precio

            For Each detalle As IngresoMaterialDetalle In listDetalleMaterial
                If detalle.CodigoMaterial = codigoMaterial Then
                    detalle.PrecioReferencial = precio
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("El dato ingresado no es válido. Ingrese un número entero o decimal positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub btnExamCont_Click(sender As Object, e As EventArgs) Handles btnExamCont.Click
        Try
            If idContenedor.Equals(String.Empty) Then
                Dim frmExamContenedor As New FormExamContenedor(txtContenedor)
                frmExamContenedor.ShowDialog()
                idContenedor = frmExamContenedor.IdContenedor
                CantidadContenedor = frmExamContenedor.Cantidad

                For Each detalle As IngresoMaterialDetalle In listDetalleMaterial
                    If detalle.TipoContenedor = UtilConstantes.TipoContenedor.Base Then
                        detalle.Contenedor = idContenedor
                    End If
                Next
            Else

                Dim result As Integer = MessageBox.Show("La siguiente acción actualizará todos los contenedores base y eliminará los contenedores adicionales. ¿Está seguro que desea continuar?", "Confirmar", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then

                    Dim lstMaterialesEliminar As New List(Of String)

                    For Each detalle As IngresoMaterialDetalle In listDetalleMaterial
                        If detalle.TipoContenedor = UtilConstantes.TipoContenedor.Base Then
                            detalle.Contenedor = idContenedor
                        Else
                            lstMaterialesEliminar.Add(detalle.CodigoMaterial)
                        End If
                    Next

                    For Each material As String In lstMaterialesEliminar
                        Dim f As IngresoMaterialDetalle
                        f = listDetalleMaterial.Where(Function(x) x.CodigoMaterial.Equals(material)).FirstOrDefault
                        listDetalleMaterial.Remove(f)
                    Next

                    Dim frmExamContenedor As New FormExamContenedor(txtContenedor)
                    frmExamContenedor.ShowDialog()
                    idContenedor = frmExamContenedor.IdContenedor
                    CantidadContenedor = frmExamContenedor.Cantidad

                    For Each detalle As IngresoMaterialDetalle In listDetalleMaterial
                        If detalle.TipoContenedor = UtilConstantes.TipoContenedor.Base Then
                            detalle.Contenedor = idContenedor
                        End If
                    Next

                End If

            End If

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

    Private Sub FormIngresoMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            listDetalleMaterial = New List(Of IngresoMaterialDetalle)

            CargarTipoDocumento()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDistribuirContenedores_Click(sender As Object, e As EventArgs) Handles btnDistribuirContenedores.Click
        Try

            Dim cantidadEntrante As Integer
            Dim row As Integer
            Dim codigoMaterial As String

            If dgvMateriales.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvMateriales.CurrentRow.Index
            End If

            If (txtContenedor.Text.Trim = "") Then
                MessageBox.Show("Seleccione un contenedor destino base", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContenedor.Select()
                Return
            End If

            cantidadEntrante = UtilConvertidor.GetInteger(dgvMateriales.Item(5, row).Value)

            If cantidadEntrante = 0 Then
                MessageBox.Show("Ingrese la cantidad entrante para distribuir en los contenedores.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            codigoMaterial = dgvMateriales.Item(0, row).Value


            Dim frmDistContenedor As New FormDistribuirContenedores(listDetalleMaterial, codigoMaterial, cantidadEntrante)
            frmDistContenedor.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
End Class