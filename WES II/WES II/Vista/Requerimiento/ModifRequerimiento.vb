Public Class ModifRequerimiento

    Private idProyecto, idAlmacen, idOrden As String
    Private codRequerimiento, proyecto, codOrdenCompra, almacenDestino As String
    Private idReq As Integer
    Private precioRef, codMaterial As String

    Sub New(ByVal _id As String)
        InitializeComponent()

        codRequerimiento = _id
        idReq = CInt(_id) - 10000

        ' Traer toda su info desde la BD
        Dim requerimiento As New Requerimiento()
        requerimiento.obtener(idReq)

        idProyecto = requerimiento.ID_Proyecto
        proyecto = requerimiento.Proyecto
        'MessageBox.Show("proyecto: " + CStr(idProyecto))

        idAlmacen = requerimiento.ID_Almacen
        almacenDestino = requerimiento.Almacen

        idOrden = requerimiento.ID_Orden_Compra
        If idOrden = "" Then
            codOrdenCompra = ""
        Else
            codOrdenCompra = requerimiento.ID_Orden_Compra + 10000
        End If
    End Sub

    Private Sub ModifRequerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Asignar a los ctrles la info capturada
        txtCodRequerimiento.Text = codRequerimiento
        txtProyecto.Text = proyecto
        txtCodOrdenCompra.Text = codOrdenCompra
        txtAlmacenDestino.Text = almacenDestino

        cargarDetalles()
    End Sub

    Private Sub cargarDetalles()
        Dim detallesPrevios As DataTable
        detallesPrevios = Requerimiento.listarDetalles(idReq)
        For Each detalle As DataRow In detallesPrevios.Rows
            Dim codMaterial As String = detalle(0)
            Dim material As String = detalle(1)
            Dim solicitada As Integer = detalle(2)
            ' Cantidad recibida es la columna 3
            Dim precioRef As Decimal = detalle(4)
            dgvMateriales.Rows.Add(codMaterial, material, solicitada, precioRef)
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not dgvMateriales.Rows.Count > 1 Then
            MessageBox.Show("No se ha agregado ningún material al requerimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If idProyecto = "" Then
            MessageBox.Show("No se ha seleccionado ningún proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim codOrdenCompra As String = txtCodOrdenCompra.Text

        _conexion.iniciarTransaccion()
        Try
            Dim rpta As String = Requerimiento.modificar(idReq, idProyecto, idOrden, idAlmacen)
            If rpta <> "" Then Throw New System.Exception(rpta)

            Dim idMaterial As Integer
            Requerimiento.eliminarDetalles(idReq)

            For Each row As DataGridViewRow In dgvMateriales.Rows
                idMaterial = CInt(row.Cells(0).Value) - 10000
                If idMaterial > 0 Then
                    rpta = Requerimiento.registrarDetalle(idReq, CStr(idMaterial), row.Cells(2).Value)
                    If rpta <> "" Then Throw New System.Exception(rpta)
                End If
            Next
            _conexion.hacerCommit()
            MessageBox.Show("El requerimiento se ha modificado correctamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            _conexion.hacerRollBack()
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnExaminarP_Click(sender As Object, e As EventArgs) Handles btnExaminarP.Click
        Dim frmExamProyecto As New ExamProyecto(txtProyecto)
        frmExamProyecto.ShowDialog()
        idProyecto = frmExamProyecto.codigoProyecto
    End Sub

    Private Sub btnExaminarCOC_Click(sender As Object, e As EventArgs) Handles btnExaminarCOC.Click
        Dim frmExamOrdenCompra As New ExamOrdenCompra(txtCodOrdenCompra)
        frmExamOrdenCompra.ShowDialog()
    End Sub

    Private Sub btnExaminarAD_Click(sender As Object, e As EventArgs) Handles btnExaminarAD.Click
        Dim frmExamAlmacen As New ExamAlmacen(txtAlmacenDestino)
        frmExamAlmacen.ShowDialog()
        idAlmacen = frmExamAlmacen.codigoAlmacen
    End Sub

    Private Sub btnExaminarM_Click(sender As Object, e As EventArgs) Handles btnExaminarM.Click
        Dim frmExamMat As New ExamMaterial(txtMateriales)
        frmExamMat.ShowDialog()
        precioRef = frmExamMat.getPrecio()
        codMaterial = frmExamMat.getCode()
    End Sub

    Private Sub validar()
        If (txtProyecto.Text.Trim = "") Then
            errorProvider.SetError(txtProyecto, "Seleccione un proyecto.")
        Else
            errorProvider.SetError(txtProyecto, Nothing)
        End If

        If (txtMateriales.Text.Trim = "") Then
            errorProvider.SetError(txtMateriales, "Seleccione un material.")
        Else
            errorProvider.SetError(txtMateriales, Nothing)
        End If

        Try
            Dim temporal = CInt(txtCantidad.Text.Trim)
            errorProvider.SetError(txtCantidad, Nothing)
        Catch ex As Exception
            errorProvider.SetError(txtCantidad, "Ingrese una cantidad válida.")
        End Try
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click
        validar()
        If (ErrorProvider.GetError(txtProyecto) = Nothing And ErrorProvider.GetError(txtMateriales) = Nothing And ErrorProvider.GetError(txtCantidad) = Nothing) Then
            agregarFila()
        End If
    End Sub

    Private Sub agregarFila()
        Dim flag As Boolean
        flag = False

        For j As Integer = 0 To (dgvMateriales.Rows.Count - 2)
            Dim dato As String
            dato = txtMateriales.Text
            If dgvMateriales.Rows(j).Cells(1).Value.ToString = dato Then
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                msg = "El material ya ha sido agregado, desea añadir la cantidad indicada?"
                style = MsgBoxStyle.DefaultButton2 Or _
                   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                title = "Sugerencia"
                ' Display message.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then
                    sumarCantidad(j)
                End If
                flag = True
            End If
        Next

        If Not flag Then
            Dim Fila As DataGridViewRow
            Fila = dgvMateriales.Rows(0).Clone
            Fila.Cells(0).Value = codMaterial
            Fila.Cells(1).Value = txtMateriales.Text
            Fila.Cells(2).Value = txtCantidad.Text
            Fila.Cells(3).Value = precioRef
            dgvMateriales.Rows.Add(Fila)
        End If
    End Sub

    Private Sub sumarCantidad(ByVal j As String)
        dgvMateriales.Rows(j).Cells(2).Value = Convert.ToString(CDbl(dgvMateriales.Rows(j).Cells(2).Value.ToString) + CDbl(txtCantidad.Text))
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            If dgvMateriales.Rows.Count > 1 Then
                Dim filaActual As Integer = dgvMateriales.CurrentCell.RowIndex
                dgvMateriales.Rows.RemoveAt(filaActual)
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar el detalle que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class