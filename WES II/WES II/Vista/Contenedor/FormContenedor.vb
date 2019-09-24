Public Class FormContenedor

    Private conexion As Conexion

    ' Se refiere al código del último contenedor cargado
    Private ultimoCodigo As Integer = -1
    Private idMaterial As String
    Private documentoColumn As DataGridViewButtonColumn

    Private Sub FormContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTipoUbicacion()
        mostrarCodigoSgte()
        actualizarTabla()

        documentoColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        documentoColumn.HeaderText = "Documentos"
        documentoColumn.Name = "Documentos"
        documentoColumn.ReadOnly = True
        documentoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True
        documentoColumn.Text = "Ver"
        documentoColumn.ToolTipText = "Ver Documentos"
        documentoColumn.UseColumnTextForButtonValue = True

    End Sub

    Private Sub listarTipoUbicacion()

        Try

            Dim listaTipoUbicacion As DataTable
            listaTipoUbicacion = TipoUbicacion.listar()
            With cboTipoUbicacion
                .DataSource = listaTipoUbicacion
                .ValueMember = listaTipoUbicacion.Columns(0).ColumnName
                .DisplayMember = listaTipoUbicacion.Columns(1).ColumnName
            End With

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mostrarCodigoSgte()
        Try
            txtCodigo.Text = 10000 + Contenedor.obtenerSgteID()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub limpiarTextos()
        Try
            txtEtiqueta.Text = String.Empty
            txtCalidad.Text = String.Empty
            txtAncho.Text = String.Empty
            txtAlto.Text = String.Empty
            txtSuperior.Text = String.Empty

            cboTipoUbicacion.Text = String.Empty

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarTabla()

        Try

            Dim contenedores As DataTable
            ' Consultamos por todos los tipos de producto
            contenedores = Contenedor.listar()
            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvContenedores.DataSource = contenedores

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarTabla(ByVal inicio_etiqueta As String)

        Try
            Dim contenedores As DataTable
            ' Consultamos por todos los tipos de producto
            contenedores = Contenedor.buscarEtiqueta(inicio_etiqueta)
            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvContenedores.DataSource = contenedores
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarTabla2(ByVal idMaterial As String)
        Try
            Dim contenedores As DataTable
            ' Consultamos por todos los tipos de producto
            contenedores = Contenedor.buscarMaterial(idMaterial)
            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvContenedores.DataSource = contenedores
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarDetalles(ByVal id As Integer)
        Try
            If ultimoCodigo <> id Then

                Dim detallesContenedor As DataTable
                detallesContenedor = Contenedor.listarDetalles(id)
                dgvDetalles.DataSource = detallesContenedor

                If detallesContenedor.Rows.Count > 0 Then
                    If dgvDetalles.ColumnCount = 5 Then
                        dgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.documentoColumn})
                    End If
                End If

                ultimoCodigo = id
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            'Validar etiqueta de contenedor
            Dim dtContenedor As DataTable
            dtContenedor = Contenedor.buscarContenedorPorEtiqueta(txtEtiqueta.Text.Trim)
            If dtContenedor IsNot Nothing Then
                If dtContenedor.Rows.Count > 0 Then
                    MessageBox.Show("La etiqueta ingresada para el contenedor, ya ha sido registrada. Por favor, utilice otra etiqueta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtEtiqueta.Select()
                    Return
                End If
            End If

            If txtCalidad.Text.Trim().Equals("") Then
                MessageBox.Show("Ingrese cantidad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCalidad.Select()
                Return
            End If

            Dim _cantidad As Integer = UtilConvertidor.GetInteger(txtCalidad.Text.Trim())

            If _cantidad <= 0 Then
                MessageBox.Show("Ingrese un valor válido en el campo Cantidad. El valor debe ser entero mayor que cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCalidad.Select()
                Return
            End If

            Dim fechaCreacion As String = dtpFechaCreacion.Value.Date.ToString("yyyy-MM-dd")
            Dim codigo As String = txtCodigo.Text.Trim
            Dim tipoUbicacion As String = cboTipoUbicacion.SelectedValue
            Dim etiqueta As String = txtEtiqueta.Text.Trim
            Dim alto As String = txtAlto.Text.Trim
            Dim ancho As String = txtAncho.Text.Trim
            Dim calidad As String = txtCalidad.Text.Trim
            Dim superior As String = txtSuperior.Text.Trim

            validarCampos(3)

            If (hayErrores()) Then
                MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rpta As String = Contenedor.registrar(tipoUbicacion, fechaCreacion, etiqueta, alto, ancho, calidad, superior)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
                mostrarCodigoSgte()

                limpiarTextos()

            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer

        Try
            If dgvContenedores.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvContenedores.CurrentRow.Index
            End If

            Dim id As String = dgvContenedores.Item(0, row).Value.ToString

            Dim formModificar As New ModifContenedor(id)
            formModificar.ShowDialog()
            actualizarTabla()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function HayArroba(ByVal nombre As String) As Boolean
        Dim contador As Integer = 0
        While contador < nombre.Length
            If nombre.Substring(contador, 1).Equals("@") Then
                Return True
            End If
            contador = contador + 1
        End While
        Return False
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        Try
            If dgvContenedores.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvContenedores.CurrentRow.Index()
            End If

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim id As String = dgvContenedores.Item(0, row).Value.ToString
                Dim rpta As String = Contenedor.eliminar(id)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function hayErrores() As Boolean
        If (ErrorContenedor.GetError(txtEtiqueta) = Nothing And
            ErrorContenedor.GetError(txtAncho) = Nothing And
            ErrorContenedor.GetError(txtAlto) = Nothing) Then
            Return False
        End If
        Return True
    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        Try
            If txtEtiqueta.Text.Trim.Length < 3 And nivel >= 1 Then
                ErrorContenedor.SetError(txtEtiqueta, "Debe ingresar al menos 3 caracteres.")
            ElseIf (nivel = 1) Then
                ErrorContenedor.SetError(txtEtiqueta, Nothing)
            End If

            If txtAncho.Text.Length < 1 And nivel >= 2 Then
                ErrorContenedor.SetError(txtAncho, "La medida de anchura es incorrecta.")
            ElseIf (nivel = 2) Then
                ErrorContenedor.SetError(txtAncho, Nothing)
            End If

            If txtAlto.Text.Length < 1 And nivel >= 3 Then
                ErrorContenedor.SetError(txtAlto, "La medida de altura es incorrecta.")
            ElseIf (nivel = 3) Then
                ErrorContenedor.SetError(txtAlto, Nothing)
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub txtEtiqueta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validarCampos(1)
    End Sub

    Private Sub txtAncho_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAncho.Validating
        validarCampos(2)
    End Sub

    Private Sub txtAlto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlto.Validating
        validarCampos(3)
    End Sub

    Private Sub dgvContenedores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvContenedores.SelectionChanged
        Try
            Dim nuevaSeleccion As Integer
            If dgvContenedores.CurrentRow Is Nothing Then
                Return
            Else
                nuevaSeleccion = dgvContenedores.CurrentRow.Index
            End If

            Dim id As Integer = dgvContenedores.Item(0, nuevaSeleccion).Value.ToString()
            actualizarDetalles(id)
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtBuscarEtiqueta_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarEtiqueta.KeyUp
        actualizarTabla(txtBuscarEtiqueta.Text)
    End Sub

    Private Sub btnBuscarMaterial_Click(sender As Object, e As EventArgs) Handles btnBuscarMaterial.Click
        Try

            Dim Form As New FormConsultarStock()
            Form.ShowDialog()
            idMaterial = Form.idMaterial

            actualizarTabla2(idMaterial)
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnUbicar_Click(sender As Object, e As EventArgs) Handles btnUbicar.Click

        Try
            Dim row As Integer

            If dgvContenedores.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvContenedores.CurrentRow.Index()
            End If

            ' ID del contenedor seleccionado
            Dim id As String = dgvContenedores.Item(0, row).Value - 10000

            Dim formExamUbic As New FormExamUbicacion()
            formExamUbic.ShowDialog()

            Dim etiqueta As String = formExamUbic.etiqueta
            Dim idUbicacion As Integer = formExamUbic.idUbicacion

            Dim rpta As String = Contenedor.ubicar(id, idUbicacion)
            If rpta = "" Then
                MessageBox.Show("Se ha modificado exitosamente la ubicación por: " + etiqueta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
            Else
                MessageBox.Show(rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub txtEtiqueta_TextChanged(sender As Object, e As EventArgs) Handles txtEtiqueta.TextChanged
        validarCampos(1)
    End Sub

    Private Sub dgvDetalles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)

            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
               e.RowIndex >= 0 Then
                'TODO - Button Clicked - Execute Code Here

                Dim contenedor As String = dgvDetalles.Rows(e.RowIndex).Cells(1).Value.ToString().Trim()
                Dim material As String = dgvDetalles.Rows(e.RowIndex).Cells(2).Value.ToString().Trim()

                Dim idContenedor As Integer = UtilConvertidor.GetInteger(contenedor) - 10000
                Dim idMaterial As Integer = UtilConvertidor.GetInteger(material) - 10000

                Dim formDocumentos As New FormDocumentosContenedor(idContenedor, idMaterial)
                formDocumentos.ShowDialog()

            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class