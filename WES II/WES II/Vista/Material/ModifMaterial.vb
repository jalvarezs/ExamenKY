Public Class ModifMaterial

    Private DatosSubFamilia As ExaminarSubFamilia

    Private id As Integer

    Private codigo,
        nombre,
        descripcion,
        pcompra,
        pventa,
        EAN13,
        DUN14,
        tipoMat,
        unidadEnt,
        tipoRec,
        amarca,
        prov,
        aperfil,
        stockSeg,
        numSerie,
        stockMin,
        RG1,
        RG2,
        moneda,
        afamilia,
        unidadesCaja,
        cajasPaquete As String

    Sub New(ByVal _id As String)
        InitializeComponent()

        id = CInt(_id) - 10000

        Dim dtMaterial As DataTable = Material.ObtenerMaterialPorId(id)

        If dtMaterial IsNot Nothing Then

            Dim row As DataRow = dtMaterial.AsEnumerable.FirstOrDefault

            codigo = (row("ID_Material") + 10000).ToString()
            nombre = row("Nombre")
            descripcion = row("Descripcion")
            pcompra = row("PrecioCompra").ToString()
            pventa = row("PrecioVenta").ToString()
            EAN13 = row("EAN13").ToString().Trim()
            DUN14 = row("DUN14").ToString().Trim()
            tipoMat = row("ID_Tipo_Material").ToString()
            unidadEnt = row("ID_Unidad_Entrega").ToString()
            tipoRec = row("ID_Tipo_Recepcion").ToString()
            amarca = row("ID_Marca").ToString()
            aperfil = row("NvAutorizacion").ToString()
            stockSeg = row("StockSeguridad").ToString()
            stockMin = row("StockMinimo").ToString()
            RG1 = row("RG1").ToString()
            RG2 = row("RG2").ToString()
            moneda = row("Moneda")
            afamilia = row("ID_Familia_Material").ToString()
            numSerie = row("NumSerie")
            unidadesCaja = row("Unidades_Caja").ToString()
            cajasPaquete = row("Cajas_Paquete").ToString()

            idFamilia = row("ID_Familia_Material")
            nombreFamilia = row("Familia")

            idSubFamilia = row("ID_SubFamilia_Material")
            nombreSubFamilia = row("Sub-Familia")

            DatosSubFamilia = New ExaminarSubFamilia
            DatosSubFamilia.IdFamilia = idFamilia
            DatosSubFamilia.NombreFamilia = nombreFamilia

            DatosSubFamilia.IdSubFamilia = idSubFamilia
            DatosSubFamilia.NombreSubFamilia = nombreSubFamilia

            ' Se agrega codigo para bloquear el campo de precio de compra
            '***************inicio****************************************************
            Try
                Dim dt As DataTable = Parametro.ObtenerParametrosPorGrupo("ESTADO_PRECO")
                Dim rows As DataRow = dt.AsEnumerable.FirstOrDefault
                valprec = rows("VALOR")
                If valprec = "NO" Then
                    txtPCompra.Enabled = False
                    Dim dtpm As DataTable = OrdenCompra.ObtenerPreComProm(id)
                    Dim rpc As DataRow = dtpm.AsEnumerable.FirstOrDefault
                    Dim precioc As Decimal = rpc("precprom")
                    txtPCompra.Text = precioc
                Else
                    txtPVenta.Enabled = True
                End If
            Catch ex As Exception
            End Try

            Try
                Dim dt As DataTable = Parametro.ObtenerParametrosPorGrupo("ESTADO_PREVE")
                Dim rows As DataRow = dt.AsEnumerable.FirstOrDefault
                valprec = rows("VALOR")
                If valprec = "NO" Then
                    txtPVenta.Enabled = False
                    'Dim dtpm As DataTable = OrdenCompra.ObtenerPreComProm(id)
                    'Dim rpc As DataRow = dtpm.AsEnumerable.FirstOrDefault
                    'Dim precioc As Decimal = rpc("precprom")
                    'txtPCompra.Text = precioc
                Else
                    txtPVenta.Enabled = True
                End If
            Catch ex As Exception
            End Try
            '*****************Fin ***************************************
        End If
    End Sub

    Private Sub ModifProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTipos()
        listarMarcas()
        listarPerfiles()
        listarUnidades()
        listarTipoRecepcion()
        LlenarCampos()
    End Sub

    Private Sub LlenarCampos()
        Try
            'Campos de texto
            txtCodigo.Text = codigo
            txtDescripcion.Text = descripcion
            txtDUN14.Text = DUN14
            txtEAN13.Text = EAN13

            'txtNumSerie.Text = numSerie

            If UtilConstantes.Parametro.VALOR_SI.Equals(numSerie) Then
                chkNumSerie.Checked = True
            Else
                chkNumSerie.Checked = False
            End If

            txtNombre.Text = nombre
            txtPCompra.Text = pcompra
            txtPVenta.Text = pventa
            txtStockMin.Text = stockMin
            txtStockSeg.Text = stockSeg
            txtUnidadesCaja.Text = unidadesCaja
            txtCajasPaquete.Text = cajasPaquete

            'Combos de Texto
            cboMarcas.SelectedValue = amarca
            cboPerfiles.SelectedValue = aperfil
            cboRG1.SelectedText = RG1
            cboRG2.SelectedText = RG2
            cboTipoRecepcion.SelectedValue = tipoRec
            cboTipos.SelectedValue = tipoMat
            cboUnidades.SelectedValue = unidadEnt

            If DatosSubFamilia.IdSubFamilia.Equals(0) Then
                txtCodigoFamilia.Text = (DatosSubFamilia.IdFamilia + 10000).ToString()
                txtDescripcionFamilia.Text = DatosSubFamilia.NombreFamilia
            Else
                txtCodigoFamilia.Text = (DatosSubFamilia.IdFamilia + 10000).ToString() & " | " & (DatosSubFamilia.IdSubFamilia + 10000).ToString()
                txtDescripcionFamilia.Text = DatosSubFamilia.NombreFamilia & " | " & DatosSubFamilia.NombreSubFamilia
            End If



            'RadioButtons
            If (moneda = "S") Then
                rbSoles.Select()
            Else
                rbDolares.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub listarTipoRecepcion()
        Dim listaTipoRecepcion As DataTable
        listaTipoRecepcion = TipoRecepcion.listar()
        With cboTipoRecepcion
            .DataSource = listaTipoRecepcion
            .ValueMember = listaTipoRecepcion.Columns(0).ColumnName
            .DisplayMember = listaTipoRecepcion.Columns(1).ColumnName
        End With
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

    Private Sub CargarFamilia()
        Try

        Catch ex As Exception

        End Try
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

    Private Sub btnExamFamilia_Click(sender As Object, e As EventArgs) Handles btnExamFamilia.Click
        Try

            Dim form As New ExamFamilia(txtCodigoFamilia, txtDescripcionFamilia)
            form.ShowDialog()

            DatosSubFamilia = form.DatosSubFamilia

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
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

                Dim rpta As String = Material.Modificar(id,
                                                        txtNombre.Text,
                                                        txtDescripcion.Text,
                                                        txtPCompra.Text,
                                                        txtPVenta.Text,
                                                        txtEAN13.Text,
                                                        txtDUN14.Text,
                                                        cboTipos.SelectedValue.ToString,
                                                        cboUnidades.SelectedValue.ToString,
                                                        cboTipoRecepcion.SelectedValue.ToString,
                                                        cboMarcas.SelectedValue.ToString,
                                                        cboPerfiles.SelectedValue.ToString,
                                                        DatosSubFamilia.IdFamilia,
                                                        txtStockSeg.Text,
                                                        txtStockMin.Text,
                                                        cboRG1.Text,
                                                        cboRG2.Text,
                                                        IIf(rbSoles.Checked, "S", "D"),
                                                        strNumSerie,
                                                        txtUnidadesCaja.Text,
                                                        txtCajasPaquete.Text,
                                                        DatosSubFamilia.IdSubFamilia)


                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
            Else
                MessageBox.Show("Hay campos obligatorios para verificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try

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

End Class