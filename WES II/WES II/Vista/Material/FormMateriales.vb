Imports System.IO

Public Class FormMateriales
    Dim error1 As Boolean
    Private DatosSubFamilia As ExaminarSubFamilia
    Private dtMaterialesExcel As New DataTable

    Private Sub FormMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCodigoSgte()
        listarTipos()
        listarFamilias()
        listarMarcas()
        listarPerfiles()
        listarUnidades()
        listarTipoRecepcion()
        cboRG1.SelectedIndex = 0
        cboRG2.SelectedIndex = 0
        rbSoles.Select()
        ActualizarTabla()

        LimpiarTextos()
    End Sub

    Private Sub MostrarCodigoSgte()
        txtCodigo.Text = 10000 + Material.obtenerSgteID()
    End Sub

    Private Sub ActualizarTabla()
        Dim materiales As DataTable
        ' Consultamos por todos los tipos de Material
        materiales = Material.listar()

        ' Mostramos tales tipos en el dataGridView correspondiente
        dgvMateriales.DataSource = materiales
    End Sub

    Private Sub listarPerfiles()
        Dim listaPerfiles As DataTable
        listaPerfiles = Perfil.listar()
        With cboPerfiles
            .DataSource = listaPerfiles
            .ValueMember = listaPerfiles.Columns(0).ColumnName
            .DisplayMember = listaPerfiles.Columns(1).ColumnName
        End With
    End Sub

    Private Sub listarTipoRecepcion()
        Dim listaRecepcion As DataTable
        listaRecepcion = TipoRecepcion.listar()
        With cboTipoRecepcion
            .DataSource = listaRecepcion
            .ValueMember = listaRecepcion.Columns(0).ColumnName
            .DisplayMember = listaRecepcion.Columns(1).ColumnName
        End With
    End Sub

    Private Sub listarUnidades()
        Dim listaUnidades As DataTable
        listaUnidades = UnidadEntrega.listar()
        With cboUnidades
            .DataSource = listaUnidades
            .ValueMember = listaUnidades.Columns(0).ColumnName
            .DisplayMember = listaUnidades.Columns(1).ColumnName
        End With
    End Sub

    Private Sub listarMarcas()
        Dim listaMarcas As DataTable
        listaMarcas = Marca.listar()
        With cboMarcas
            .DataSource = listaMarcas
            .ValueMember = listaMarcas.Columns(0).ColumnName
            .DisplayMember = listaMarcas.Columns(1).ColumnName
        End With
    End Sub

    Private Sub listarFamilias()
        Dim listaFamilias As DataTable
        listaFamilias = Familia.ListarFamilias()



        'Agregamos los datos tambien al combo de busqueda pero agregamos un item mas
        Dim table As DataTable
        table = Familia.ListarFamilias()

        Dim datarow As DataRow = Nothing
        datarow = table.NewRow
        datarow(0) = -1
        datarow(1) = "Todos"
        datarow(2) = "Todos"
        table.Rows.InsertAt(datarow, 0)

        listaFamilias.Rows.Add()
        With cbotipofamilia
            .DataSource = table
            .ValueMember = listaFamilias.Columns(0).ColumnName
            .DisplayMember = listaFamilias.Columns(1).ColumnName
        End With

    End Sub

    Private Sub listarTipos()
        Dim listaTipos As DataTable
        listaTipos = TipoMaterial.listar()
        With cboTipos
            .DataSource = listaTipos
            .ValueMember = listaTipos.Columns(0).ColumnName
            .DisplayMember = listaTipos.Columns(1).ColumnName
        End With
    End Sub

    Private Sub btnNewMarca_Click(sender As Object, e As EventArgs) Handles btnNewMar.Click
        Dim formMarca As New FormMarcas()
        formMarca.ShowDialog()
        listarMarcas()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvMateriales.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvMateriales.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim _id As String = dgvMateriales.Item(0, row).Value.ToString
            Dim id As Integer = CInt(_id)
            Dim rpta = Material.eliminar(id - 10000)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActualizarTabla()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Function ValidarCampos() As Boolean

        If txtNombre.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Select()
            Return False
        End If

        If txtPCompra.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Precio Compra", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPCompra.Select()
            Return False
        End If

        If txtPVenta.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Precio Venta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPVenta.Select()
            Return False
        End If

        If txtDescripcion.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Select()
            Return False
        End If

        'If txtNumSerie.Text.Trim.Equals("") Then
        '    MessageBox.Show("Ingrese Número de Serie", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtNumSerie.Select()
        '    Return False
        'End If

        If txtStockSeg.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Stock Seguridad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStockSeg.Select()
            Return False
        End If

        If txtStockMin.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Stock Mínimo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStockMin.Select()
            Return False
        End If

        If txtUnidadesCaja.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Unidades por Caja", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUnidadesCaja.Select()
            Return False
        End If

        If txtCajasPaquete.Text.Trim.Equals("") Then
            MessageBox.Show("Ingrese Caja por Paquete", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCajasPaquete.Select()
            Return False
        End If

        Dim param_EAN13 As EntidadParametro = Parametro.ObtenerParametroPorCode(UtilConstantes.Parametro.CONTROL_LONG_EAN13)

        If (param_EAN13.Valor.Equals(UtilConstantes.Parametro.VALOR_SI)) Then
            If ((txtEAN13.Text.Trim.Length <> 13)) Then
                MessageBox.Show("Ingrese valor EAN13 de 13 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEAN13.Select()
                Return False
            End If
        End If

        Dim param_DUN14 As EntidadParametro = Parametro.ObtenerParametroPorCode(UtilConstantes.Parametro.CONTROL_LONG_DUN14)

        If (param_DUN14.Valor.Equals(UtilConstantes.Parametro.VALOR_SI)) Then
            If ((txtDUN14.Text.Length <> 4)) Then
                MessageBox.Show("Ingrese valor DUN14 de 4 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDUN14.Select()
                Return False
            End If
        End If

        If (((txtDescripcion.Text.Trim.Length < 15 And txtDescripcion.Text.Trim.Length <> 0) Or txtDescripcion.Text.Trim.Length > 200)) Then
            MessageBox.Show("La descripción debe tener min 15 y max 200 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Select()
            Return False
        End If

        If txtCodigoFamilia.Text.Trim.Equals("") Then
            MessageBox.Show("Seleccione una Familia | Sub-Familia", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnExamFamilia.Select()
            Return False
        End If

        Return True

    End Function

    Private Sub LimpiarTextos()
        txtNombre.Text = ""
        txtPCompra.Text = ""
        txtPVenta.Text = ""
        txtDescripcion.Text = ""
        txtNumSerie.Text = ""
        chkNumSerie.Checked = False
        txtStockSeg.Text = ""
        txtStockMin.Text = ""
        txtUnidadesCaja.Text = ""
        txtCajasPaquete.Text = ""
        txtEAN13.Text = ""
        txtDUN14.Text = ""
        txtCodigoFamilia.Text = ""
        txtDescripcionFamilia.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If (ValidarCampos()) Then

                Dim strNumSerie As String = String.Empty

                If chkNumSerie.Checked Then
                    strNumSerie = UtilConstantes.Parametro.VALOR_SI
                Else
                    strNumSerie = UtilConstantes.Parametro.VALOR_NO
                End If

                Dim rpta As String = Material.Registrar(txtNombre.Text,
                                                        txtDescripcion.Text,
                                                        txtPCompra.Text,
                                                        txtPVenta.Text,
                                                        txtEAN13.Text,
                                                        txtDUN14.Text,
                                                        cboTipos.SelectedValue.ToString(),
                                                        cboUnidades.SelectedValue.ToString(),
                                                        cboTipoRecepcion.SelectedValue.ToString(),
                                                        cboMarcas.SelectedValue.ToString(),
                                                        cboPerfiles.SelectedValue.ToString(),
                                                        DatosSubFamilia.IdFamilia,
                                                        txtStockSeg.Text,
                                                        txtStockMin.Text,
                                                        cboRG1.Text,
                                                        cboRG2.Text,
                                                        IIf(rbSoles.Checked, "D", "S"),
                                                        strNumSerie,
                                                        txtUnidadesCaja.Text,
                                                        txtCajasPaquete.Text,
                                                        DatosSubFamilia.IdSubFamilia)

                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If rpta.Contains("ERROR") Then
                    Return
                Else
                    LimpiarTextos()
                    DatosSubFamilia = New ExaminarSubFamilia
                End If



            End If

            ActualizarTabla()
            MostrarCodigoSgte()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer

        If dgvMateriales.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvMateriales.CurrentRow.Index
        End If

        Dim id As String = dgvMateriales.Item(0, row).Value.ToString

        Dim formModificar As New ModifMaterial(id)
        formModificar.ShowDialog()
        ActualizarTabla()
    End Sub

    Private Sub btnNewFam_Click(sender As Object, e As EventArgs) Handles btnNewFam.Click
        Dim formFamilias As New FormFamilias()
        formFamilias.ShowDialog()
        listarFamilias()
    End Sub

    Private Sub Fg_SoloNumeros(ByRef Digito As String, ByRef Texto As TextBox)
        If InStr(1, "0123456789,-" & Chr(8), Digito) = 0 Then
            Digito = CChar("")
        ElseIf Digito = "," Then
            If Texto.Text = "" Then
                Digito = CChar("")
            Else
                If InStr(Texto.Text, ",") <> 0 Then
                    Digito = CChar("")
                End If

            End If
        ElseIf Digito = "-" Then
            If Texto.Text <> "" Then
                Digito = CChar("")
            Else
                If InStr(Texto.Text, "-") <> 0 Then
                    Digito = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txtPCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPCompra.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtPCompra)
    End Sub

    Private Sub txtPVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPVenta.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtPVenta)
    End Sub

    Private Sub txtStockSeg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockSeg.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtStockSeg)
    End Sub

    Private Sub txtStockMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockMin.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtStockMin)
    End Sub

    Private Sub txtUnidadesC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidadesCaja.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtUnidadesCaja)
    End Sub

    Private Sub txtCajasP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCajasPaquete.KeyPress
        Fg_SoloNumeros(e.KeyChar, txtCajasPaquete)
    End Sub

    Private Sub btnExamFamilia_Click(sender As Object, e As EventArgs) Handles btnExamFamilia.Click
        Try

            Dim form As New ExamFamilia(txtCodigoFamilia, txtDescripcionFamilia)
            form.ShowDialog()

            DatosSubFamilia = form.DatosSubFamilia

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'busqueda por filtro 
            Dim nombre As String = txtxnombrebuscar.Text
            Dim descripcion As String = txtDescripcionBuscar.Text
            Dim tipofamilia As String = cbotipofamilia.SelectedValue.ToString()

            If nombre = "" Then
                nombre = "-1"
            End If

            If descripcion = "" Then
                descripcion = "-1"
            End If

            materiales = Material.buscar_por_filtro(nombre, descripcion, tipofamilia)

            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvMateriales.DataSource = materiales
        Catch ex As Exception
            MessageBox.Show("Error en la carga: " & ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnDescargarPlantilla_Click(sender As Object, e As EventArgs) Handles btnDescargarPlantilla.Click
        Try
            SaveFileDialog1 = New SaveFileDialog()
            SaveFileDialog1.FileName = "Carga_Master_Sku.xlsx"
            SaveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx"


            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                Dim sourcePath As String = Application.StartupPath

                System.IO.File.Copy(sourcePath + "\\Plantilla\\Carga_Master_Sku.xlsx", SaveFileDialog1.FileName, True)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSubirPlantilla_Click(sender As Object, e As EventArgs) Handles btnSubirPlantilla.Click
        Try
            OpenFileDialog1 = New OpenFileDialog()
            OpenFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx"

            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                Dim mem As Stream
                Dim bytesPlantillas As Byte() = Nothing

                bytesPlantillas = File.ReadAllBytes(OpenFileDialog1.FileName)

                mem = New MemoryStream(bytesPlantillas)

                Dim dt As DataTable = UtilConvertidor.ConvertExcelToDataTable(mem)

                If ValidarCamposExcel(dt) Then

                    dtMaterialesExcel = dt
                    dgvMaterialesDesdeExcel.DataSource = dtMaterialesExcel

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error en la carga: " & ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGrabarDesdeExcel_Click(sender As Object, e As EventArgs) Handles btnGrabarDesdeExcel.Click
        Try
            If dtMaterialesExcel.Rows.Count = 0 Then
                MessageBox.Show("Por favor, suba la plantilla Excel con los materiales a cargar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnSubirPlantilla.Select()
                Return
            End If

            For Each row As DataRow In dtMaterialesExcel.Rows

                Dim nombre As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.SKU)
                Dim descripcion As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Descripcion)
                Dim EAN As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.EAN)
                Dim DUN As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.DUN)
                Dim serie As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.NumSerie)
                Dim proveedor As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Proveedor)
                Dim codigoProveedor As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.CodigoProveedor)
                Dim familia As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Familia)
                Dim subFamilia As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.SubFamilia)

                Dim idFamilia As Integer = UtilConvertidor.GetInteger(familia) - 10000
                Dim idSubFamilia As Integer = UtilConvertidor.GetInteger(subFamilia) - 10000

                Dim marca As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Marca)
                Dim tipoMaterial As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.TipoMaterial)
                Dim tipoRecepcion As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.TipoRecepcion)
                Dim unidadEntrega As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.UnidadEntrega)
                Dim autorizacion As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Autorizacion)



                Dim rpta As String = Material.Registrar(nombre,
                                                       descripcion,
                                                       "",
                                                       "",
                                                       EAN,
                                                       DUN,
                                                       tipoMaterial,
                                                       unidadEntrega,
                                                       tipoRecepcion,
                                                       marca,
                                                       autorizacion,
                                                       idFamilia,
                                                       "",
                                                       "",
                                                       "",
                                                       "",
                                                       "",
                                                       serie,
                                                       "",
                                                       "",
                                                       idSubFamilia)

            Next

            MessageBox.Show("Los datos han sido registrados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Actualizar Tabla de Materiales
            ActualizarTabla()

            LimpiarTablaExcel()


        Catch ex As Exception
            MessageBox.Show("Error en la carga: " & ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCamposExcel(ByVal dt As DataTable) As Boolean

        Dim fila As Integer = 1

        For Each row As DataRow In dt.Rows

            Dim nombre As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.SKU)
            Dim descripcion As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Descripcion)
            Dim EAN As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.EAN)
            Dim DUN As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.DUN)
            Dim serie As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.NumSerie)
            Dim proveedor As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Proveedor)
            Dim codigoProveedor As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.CodigoProveedor)
            Dim familia As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Familia)
            Dim subFamilia As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.SubFamilia)

            Dim marca As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Marca)
            Dim tipoMaterial As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.TipoMaterial)
            Dim tipoRecepcion As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.TipoRecepcion)
            Dim unidadEntrega As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.UnidadEntrega)
            Dim autorizacion As String = UtilConvertidor.GetString(row, UtilConstantes.CargaMasterSku.Autorizacion)

            If nombre.Trim.Equals("") Then
                MessageBox.Show(String.Format("Fila {0} - Ingrese campo SKU", fila), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If descripcion.Trim.Equals("") Then
                MessageBox.Show(String.Format("Fila {0} - Ingrese descripción", fila), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim param_EAN13 As EntidadParametro = Parametro.ObtenerParametroPorCode(UtilConstantes.Parametro.CONTROL_LONG_EAN13)

            If (param_EAN13.Valor.Equals(UtilConstantes.Parametro.VALOR_SI)) Then
                If ((EAN.Trim.Length <> 13)) Then
                    MessageBox.Show(String.Format("Fila {0} - Ingrese valor EAN13 de 13 caracteres, campo requerido", fila), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End If

            Dim param_DUN14 As EntidadParametro = Parametro.ObtenerParametroPorCode(UtilConstantes.Parametro.CONTROL_LONG_DUN14)

            If (param_DUN14.Valor.Equals(UtilConstantes.Parametro.VALOR_SI)) Then
                If ((DUN.Length <> 4)) Then
                    MessageBox.Show(String.Format("Fila {0} - Ingrese valor DUN14 de 4 caracteres, campo requerido", fila), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End If

            If (((descripcion.Trim.Length < 15 And descripcion.Trim.Length <> 0) Or descripcion.Trim.Length > 200)) Then
                MessageBox.Show(String.Format("Fila {0} - La descripción debe tener min 15 y max 200 caracteres", fila), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If familia.Trim.Equals("") Then
                MessageBox.Show(String.Format("Fila {0} - Ingrese campo Familia", fila), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If subFamilia.Trim.Equals("") Then
                MessageBox.Show(String.Format("Fila {0} - Ingrese campo Sub Familia", fila), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            fila = fila + 1

        Next

        Return True

    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTablaExcel()
    End Sub

    Private Sub LimpiarTablaExcel()
        Try
            dtMaterialesExcel = New DataTable

            dgvMaterialesDesdeExcel.DataSource = dtMaterialesExcel


        Catch ex As Exception
            MessageBox.Show("Error en la carga: " & ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class