<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifMaterial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifMaterial))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.rbDolares = New System.Windows.Forms.RadioButton()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.rbSoles = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.txtStockSeg = New System.Windows.Forms.TextBox()
        Me.btnNewMar = New System.Windows.Forms.Button()
        Me.cboMarcas = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnNewFam = New System.Windows.Forms.Button()
        Me.txtNumSerie = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboPerfiles = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboUnidades = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboTipos = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDUN14 = New System.Windows.Forms.TextBox()
        Me.txtEAN13 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPVenta = New System.Windows.Forms.TextBox()
        Me.txtPCompra = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoRecepcion = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboRG1 = New System.Windows.Forms.ComboBox()
        Me.cboRG2 = New System.Windows.Forms.ComboBox()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCajasPaquete = New System.Windows.Forms.TextBox()
        Me.txtUnidadesCaja = New System.Windows.Forms.TextBox()
        Me.btnExamFamilia = New System.Windows.Forms.Button()
        Me.txtDescripcionFamilia = New System.Windows.Forms.TextBox()
        Me.txtCodigoFamilia = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.chkNumSerie = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(840, 96)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "Volver"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAceptar, "Regresar al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'rbDolares
        '
        Me.rbDolares.AutoSize = True
        Me.rbDolares.Location = New System.Drawing.Point(484, 159)
        Me.rbDolares.Name = "rbDolares"
        Me.rbDolares.Size = New System.Drawing.Size(31, 17)
        Me.rbDolares.TabIndex = 10
        Me.rbDolares.TabStop = True
        Me.rbDolares.Text = "$"
        Me.rbDolares.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(700, 96)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnGuardar, "Guardar cambios en el material")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'rbSoles
        '
        Me.rbSoles.AutoSize = True
        Me.rbSoles.Location = New System.Drawing.Point(438, 159)
        Me.rbSoles.Name = "rbSoles"
        Me.rbSoles.Size = New System.Drawing.Size(47, 17)
        Me.rbSoles.TabIndex = 10
        Me.rbSoles.TabStop = True
        Me.rbSoles.Text = "U$D"
        Me.rbSoles.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(322, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 15)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "(*) Moneda:"
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(751, 402)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(131, 20)
        Me.txtStockMin.TabIndex = 15
        '
        'txtStockSeg
        '
        Me.txtStockSeg.Location = New System.Drawing.Point(751, 368)
        Me.txtStockSeg.Name = "txtStockSeg"
        Me.txtStockSeg.Size = New System.Drawing.Size(131, 20)
        Me.txtStockSeg.TabIndex = 7
        '
        'btnNewMar
        '
        Me.btnNewMar.ForeColor = System.Drawing.Color.Black
        Me.btnNewMar.Location = New System.Drawing.Point(833, 297)
        Me.btnNewMar.Name = "btnNewMar"
        Me.btnNewMar.Size = New System.Drawing.Size(49, 21)
        Me.btnNewMar.TabIndex = 27
        Me.btnNewMar.Text = "Nueva"
        Me.btnNewMar.UseVisualStyleBackColor = True
        '
        'cboMarcas
        '
        Me.cboMarcas.FormattingEnabled = True
        Me.cboMarcas.Location = New System.Drawing.Point(700, 298)
        Me.cboMarcas.Name = "cboMarcas"
        Me.cboMarcas.Size = New System.Drawing.Size(127, 21)
        Me.cboMarcas.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(633, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "(*) Marca:"
        '
        'btnNewFam
        '
        Me.btnNewFam.ForeColor = System.Drawing.Color.Black
        Me.btnNewFam.Location = New System.Drawing.Point(888, 227)
        Me.btnNewFam.Name = "btnNewFam"
        Me.btnNewFam.Size = New System.Drawing.Size(62, 21)
        Me.btnNewFam.TabIndex = 24
        Me.btnNewFam.Text = "Nueva"
        Me.btnNewFam.UseVisualStyleBackColor = True
        '
        'txtNumSerie
        '
        Me.txtNumSerie.Location = New System.Drawing.Point(484, 191)
        Me.txtNumSerie.Name = "txtNumSerie"
        Me.txtNumSerie.Size = New System.Drawing.Size(106, 20)
        Me.txtNumSerie.TabIndex = 11
        Me.txtNumSerie.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(322, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "(*) N° de Serie:"
        '
        'cboPerfiles
        '
        Me.cboPerfiles.FormattingEnabled = True
        Me.cboPerfiles.Location = New System.Drawing.Point(749, 331)
        Me.cboPerfiles.Name = "cboPerfiles"
        Me.cboPerfiles.Size = New System.Drawing.Size(133, 21)
        Me.cboPerfiles.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(633, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "(*) N° Autorización:"
        '
        'cboUnidades
        '
        Me.cboUnidades.FormattingEnabled = True
        Me.cboUnidades.Location = New System.Drawing.Point(751, 263)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.Size = New System.Drawing.Size(131, 21)
        Me.cboUnidades.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(633, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "(*) Unidad Entrega:"
        '
        'cboTipos
        '
        Me.cboTipos.FormattingEnabled = True
        Me.cboTipos.Location = New System.Drawing.Point(117, 225)
        Me.cboTipos.Name = "cboTipos"
        Me.cboTipos.Size = New System.Drawing.Size(154, 21)
        Me.cboTipos.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "(*) Tipo:"
        '
        'txtDUN14
        '
        Me.txtDUN14.Location = New System.Drawing.Point(118, 193)
        Me.txtDUN14.Name = "txtDUN14"
        Me.txtDUN14.Size = New System.Drawing.Size(153, 20)
        Me.txtDUN14.TabIndex = 3
        '
        'txtEAN13
        '
        Me.txtEAN13.Location = New System.Drawing.Point(117, 160)
        Me.txtEAN13.Name = "txtEAN13"
        Me.txtEAN13.Size = New System.Drawing.Size(154, 20)
        Me.txtEAN13.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "DUN14:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "EAN13:"
        '
        'txtPVenta
        '
        Me.txtPVenta.Location = New System.Drawing.Point(436, 119)
        Me.txtPVenta.Name = "txtPVenta"
        Me.txtPVenta.Size = New System.Drawing.Size(154, 20)
        Me.txtPVenta.TabIndex = 9
        '
        'txtPCompra
        '
        Me.txtPCompra.Location = New System.Drawing.Point(436, 86)
        Me.txtPCompra.Name = "txtPCompra"
        Me.txtPCompra.Size = New System.Drawing.Size(154, 20)
        Me.txtPCompra.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 267)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(473, 85)
        Me.txtDescripcion.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(117, 123)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(117, 89)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "(*) Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "(*) Precio Venta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "(*) Precio Compra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Material"
        '
        'cboTipoRecepcion
        '
        Me.cboTipoRecepcion.FormattingEnabled = True
        Me.cboTipoRecepcion.Location = New System.Drawing.Point(438, 226)
        Me.cboTipoRecepcion.Name = "cboTipoRecepcion"
        Me.cboTipoRecepcion.Size = New System.Drawing.Size(152, 21)
        Me.cboTipoRecepcion.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(323, 227)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 15)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "(*) Tipo recepción:"
        '
        'cboRG1
        '
        Me.cboRG1.FormattingEnabled = True
        Me.cboRG1.Items.AddRange(New Object() {"1", "2"})
        Me.cboRG1.Location = New System.Drawing.Point(117, 367)
        Me.cboRG1.Name = "cboRG1"
        Me.cboRG1.Size = New System.Drawing.Size(154, 21)
        Me.cboRG1.TabIndex = 17
        '
        'cboRG2
        '
        Me.cboRG2.FormattingEnabled = True
        Me.cboRG2.Items.AddRange(New Object() {"A", "B"})
        Me.cboRG2.Location = New System.Drawing.Point(438, 366)
        Me.cboRG2.Name = "cboRG2"
        Me.cboRG2.Size = New System.Drawing.Size(152, 21)
        Me.cboRG2.TabIndex = 18
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'txtCajasPaquete
        '
        Me.txtCajasPaquete.Location = New System.Drawing.Point(438, 402)
        Me.txtCajasPaquete.Name = "txtCajasPaquete"
        Me.txtCajasPaquete.Size = New System.Drawing.Size(152, 20)
        Me.txtCajasPaquete.TabIndex = 21
        '
        'txtUnidadesCaja
        '
        Me.txtUnidadesCaja.Location = New System.Drawing.Point(117, 402)
        Me.txtUnidadesCaja.Name = "txtUnidadesCaja"
        Me.txtUnidadesCaja.Size = New System.Drawing.Size(154, 20)
        Me.txtUnidadesCaja.TabIndex = 19
        '
        'btnExamFamilia
        '
        Me.btnExamFamilia.ForeColor = System.Drawing.Color.Black
        Me.btnExamFamilia.Location = New System.Drawing.Point(888, 193)
        Me.btnExamFamilia.Name = "btnExamFamilia"
        Me.btnExamFamilia.Size = New System.Drawing.Size(62, 21)
        Me.btnExamFamilia.TabIndex = 54
        Me.btnExamFamilia.Text = "Examinar"
        Me.btnExamFamilia.UseVisualStyleBackColor = True
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.Enabled = False
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(636, 227)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(246, 20)
        Me.txtDescripcionFamilia.TabIndex = 53
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.Enabled = False
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(782, 194)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.ReadOnly = True
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoFamilia.TabIndex = 52
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(633, 194)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 15)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "(*) Familia | Sub-Familia:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(633, 407)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 15)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "(*) Stock Mínimo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(633, 369)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 15)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "(*) Stock Seguridad:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(291, 396)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 34)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "(*) Cajas por Paquete:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(0, 396)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(111, 25)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "(*) Unid. por Caja:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(395, 367)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 15)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "RG2:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(76, 367)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 15)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "RG1:"
        '
        'chkNumSerie
        '
        Me.chkNumSerie.AutoSize = True
        Me.chkNumSerie.Location = New System.Drawing.Point(438, 195)
        Me.chkNumSerie.Name = "chkNumSerie"
        Me.chkNumSerie.Size = New System.Drawing.Size(15, 14)
        Me.chkNumSerie.TabIndex = 61
        Me.chkNumSerie.UseVisualStyleBackColor = True
        '
        'ModifMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 453)
        Me.Controls.Add(Me.chkNumSerie)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnExamFamilia)
        Me.Controls.Add(Me.txtDescripcionFamilia)
        Me.Controls.Add(Me.txtCodigoFamilia)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtCajasPaquete)
        Me.Controls.Add(Me.txtUnidadesCaja)
        Me.Controls.Add(Me.cboRG2)
        Me.Controls.Add(Me.cboRG1)
        Me.Controls.Add(Me.cboTipoRecepcion)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStockMin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtStockSeg)
        Me.Controls.Add(Me.rbDolares)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnNewMar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMarcas)
        Me.Controls.Add(Me.rbSoles)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnNewFam)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtNumSerie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboPerfiles)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtPCompra)
        Me.Controls.Add(Me.cboUnidades)
        Me.Controls.Add(Me.txtPVenta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEAN13)
        Me.Controls.Add(Me.cboTipos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDUN14)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModifMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDUN14 As System.Windows.Forms.TextBox
    Friend WithEvents txtEAN13 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtPCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboTipos As System.Windows.Forms.ComboBox
    Friend WithEvents cboUnidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboPerfiles As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnNewFam As System.Windows.Forms.Button
    Friend WithEvents btnNewMar As System.Windows.Forms.Button
    Friend WithEvents cboMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbDolares As System.Windows.Forms.RadioButton
    Friend WithEvents rbSoles As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtStockMin As System.Windows.Forms.TextBox
    Friend WithEvents txtStockSeg As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents cboTipoRecepcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboRG1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboRG2 As System.Windows.Forms.ComboBox
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCajasPaquete As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidadesCaja As System.Windows.Forms.TextBox
    Friend WithEvents btnExamFamilia As Button
    Friend WithEvents txtDescripcionFamilia As TextBox
    Friend WithEvents txtCodigoFamilia As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents chkNumSerie As CheckBox
End Class
