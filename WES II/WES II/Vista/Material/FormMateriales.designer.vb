<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMateriales))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkNumSerie = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnExamFamilia = New System.Windows.Forms.Button()
        Me.txtDescripcionFamilia = New System.Windows.Forms.TextBox()
        Me.txtCodigoFamilia = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCajasPaquete = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtUnidadesCaja = New System.Windows.Forms.TextBox()
        Me.cboRG2 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboRG1 = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboTipoRecepcion = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
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
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNombreBuscar = New System.Windows.Forms.Label()
        Me.cbotipofamilia = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionBuscar = New System.Windows.Forms.TextBox()
        Me.txtxnombrebuscar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dgvMaterialesDesdeExcel = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGrabarDesdeExcel = New System.Windows.Forms.Button()
        Me.btnSubirPlantilla = New System.Windows.Forms.Button()
        Me.btnDescargarPlantilla = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvMaterialesDesdeExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(967, 389)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkNumSerie)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.btnExamFamilia)
        Me.TabPage1.Controls.Add(Me.txtDescripcionFamilia)
        Me.TabPage1.Controls.Add(Me.txtCodigoFamilia)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtCajasPaquete)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtUnidadesCaja)
        Me.TabPage1.Controls.Add(Me.cboRG2)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.cboRG1)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.cboTipoRecepcion)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.rbDolares)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.rbSoles)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtStockMin)
        Me.TabPage1.Controls.Add(Me.txtStockSeg)
        Me.TabPage1.Controls.Add(Me.btnNewMar)
        Me.TabPage1.Controls.Add(Me.cboMarcas)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.btnNewFam)
        Me.TabPage1.Controls.Add(Me.txtNumSerie)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.cboPerfiles)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cboUnidades)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cboTipos)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtDUN14)
        Me.TabPage1.Controls.Add(Me.txtEAN13)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtPVenta)
        Me.TabPage1.Controls.Add(Me.txtPCompra)
        Me.TabPage1.Controls.Add(Me.txtDescripcion)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(959, 363)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar material"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkNumSerie
        '
        Me.chkNumSerie.AutoSize = True
        Me.chkNumSerie.Location = New System.Drawing.Point(410, 125)
        Me.chkNumSerie.Name = "chkNumSerie"
        Me.chkNumSerie.Size = New System.Drawing.Size(15, 14)
        Me.chkNumSerie.TabIndex = 52
        Me.chkNumSerie.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(605, 319)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 15)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "(*) Stock Mínimo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(605, 281)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 15)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "(*) Stock Seguridad:"
        '
        'btnExamFamilia
        '
        Me.btnExamFamilia.ForeColor = System.Drawing.Color.Black
        Me.btnExamFamilia.Location = New System.Drawing.Point(860, 125)
        Me.btnExamFamilia.Name = "btnExamFamilia"
        Me.btnExamFamilia.Size = New System.Drawing.Size(62, 21)
        Me.btnExamFamilia.TabIndex = 49
        Me.btnExamFamilia.Text = "Examinar"
        Me.btnExamFamilia.UseVisualStyleBackColor = True
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.Enabled = False
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(608, 157)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(246, 20)
        Me.txtDescripcionFamilia.TabIndex = 48
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.Enabled = False
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(754, 126)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.ReadOnly = True
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoFamilia.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(264, 308)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 34)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "(*) Cajas por Paquete:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCajasPaquete
        '
        Me.txtCajasPaquete.Location = New System.Drawing.Point(409, 317)
        Me.txtCajasPaquete.Name = "txtCajasPaquete"
        Me.txtCajasPaquete.Size = New System.Drawing.Size(154, 20)
        Me.txtCajasPaquete.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 309)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 25)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "(*) Unid. por Caja:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnidadesCaja
        '
        Me.txtUnidadesCaja.Location = New System.Drawing.Point(123, 313)
        Me.txtUnidadesCaja.Name = "txtUnidadesCaja"
        Me.txtUnidadesCaja.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidadesCaja.TabIndex = 19
        '
        'cboRG2
        '
        Me.cboRG2.FormattingEnabled = True
        Me.cboRG2.Items.AddRange(New Object() {"A", "B"})
        Me.cboRG2.Location = New System.Drawing.Point(410, 279)
        Me.cboRG2.Name = "cboRG2"
        Me.cboRG2.Size = New System.Drawing.Size(153, 21)
        Me.cboRG2.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(368, 279)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 15)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "RG2:"
        '
        'cboRG1
        '
        Me.cboRG1.FormattingEnabled = True
        Me.cboRG1.Items.AddRange(New Object() {"1", "2"})
        Me.cboRG1.Location = New System.Drawing.Point(123, 278)
        Me.cboRG1.Name = "cboRG1"
        Me.cboRG1.Size = New System.Drawing.Size(100, 21)
        Me.cboRG1.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(72, 279)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 15)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "RG1:"
        '
        'cboTipoRecepcion
        '
        Me.cboTipoRecepcion.FormattingEnabled = True
        Me.cboTipoRecepcion.Location = New System.Drawing.Point(410, 158)
        Me.cboTipoRecepcion.Name = "cboTipoRecepcion"
        Me.cboTipoRecepcion.Size = New System.Drawing.Size(153, 21)
        Me.cboTipoRecepcion.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(295, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 15)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "(*) Tipo Recepción:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(812, 19)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Regresar al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'rbDolares
        '
        Me.rbDolares.AutoSize = True
        Me.rbDolares.Location = New System.Drawing.Point(479, 84)
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
        Me.btnGuardar.Location = New System.Drawing.Point(676, 18)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Registrar nuevo material")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'rbSoles
        '
        Me.rbSoles.AutoSize = True
        Me.rbSoles.Location = New System.Drawing.Point(409, 84)
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
        Me.Label18.Location = New System.Drawing.Point(295, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 15)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "(*) Moneda:"
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(722, 317)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(132, 20)
        Me.txtStockMin.TabIndex = 15
        '
        'txtStockSeg
        '
        Me.txtStockSeg.Location = New System.Drawing.Point(722, 278)
        Me.txtStockSeg.Name = "txtStockSeg"
        Me.txtStockSeg.Size = New System.Drawing.Size(132, 20)
        Me.txtStockSeg.TabIndex = 7
        '
        'btnNewMar
        '
        Me.btnNewMar.ForeColor = System.Drawing.Color.Black
        Me.btnNewMar.Location = New System.Drawing.Point(792, 213)
        Me.btnNewMar.Name = "btnNewMar"
        Me.btnNewMar.Size = New System.Drawing.Size(62, 21)
        Me.btnNewMar.TabIndex = 27
        Me.btnNewMar.Text = "[Nueva]"
        Me.btnNewMar.UseVisualStyleBackColor = True
        '
        'cboMarcas
        '
        Me.cboMarcas.FormattingEnabled = True
        Me.cboMarcas.Location = New System.Drawing.Point(674, 213)
        Me.cboMarcas.Name = "cboMarcas"
        Me.cboMarcas.Size = New System.Drawing.Size(112, 21)
        Me.cboMarcas.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(605, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "(*) Marca:"
        '
        'btnNewFam
        '
        Me.btnNewFam.ForeColor = System.Drawing.Color.Black
        Me.btnNewFam.Location = New System.Drawing.Point(860, 156)
        Me.btnNewFam.Name = "btnNewFam"
        Me.btnNewFam.Size = New System.Drawing.Size(62, 21)
        Me.btnNewFam.TabIndex = 24
        Me.btnNewFam.Text = "[Nueva]"
        Me.btnNewFam.UseVisualStyleBackColor = True
        '
        'txtNumSerie
        '
        Me.txtNumSerie.Location = New System.Drawing.Point(479, 120)
        Me.txtNumSerie.Name = "txtNumSerie"
        Me.txtNumSerie.Size = New System.Drawing.Size(84, 20)
        Me.txtNumSerie.TabIndex = 11
        Me.txtNumSerie.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(295, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "(*) N°  Serie:"
        '
        'cboPerfiles
        '
        Me.cboPerfiles.FormattingEnabled = True
        Me.cboPerfiles.Location = New System.Drawing.Point(722, 244)
        Me.cboPerfiles.Name = "cboPerfiles"
        Me.cboPerfiles.Size = New System.Drawing.Size(132, 21)
        Me.cboPerfiles.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(605, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "(*) N° Autorización:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(605, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "(*) Familia | Sub-Familia:"
        '
        'cboUnidades
        '
        Me.cboUnidades.FormattingEnabled = True
        Me.cboUnidades.Location = New System.Drawing.Point(741, 184)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.Size = New System.Drawing.Size(113, 21)
        Me.cboUnidades.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(605, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "(*) Unidad de Entrega:"
        '
        'cboTipos
        '
        Me.cboTipos.FormattingEnabled = True
        Me.cboTipos.Location = New System.Drawing.Point(122, 159)
        Me.cboTipos.Name = "cboTipos"
        Me.cboTipos.Size = New System.Drawing.Size(154, 21)
        Me.cboTipos.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "(*) Tipo:"
        '
        'txtDUN14
        '
        Me.txtDUN14.Location = New System.Drawing.Point(123, 123)
        Me.txtDUN14.Name = "txtDUN14"
        Me.txtDUN14.Size = New System.Drawing.Size(153, 20)
        Me.txtDUN14.TabIndex = 3
        '
        'txtEAN13
        '
        Me.txtEAN13.Location = New System.Drawing.Point(122, 85)
        Me.txtEAN13.Name = "txtEAN13"
        Me.txtEAN13.Size = New System.Drawing.Size(154, 20)
        Me.txtEAN13.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "DUN14:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "EAN13:"
        '
        'txtPVenta
        '
        Me.txtPVenta.Location = New System.Drawing.Point(409, 49)
        Me.txtPVenta.Name = "txtPVenta"
        Me.txtPVenta.Size = New System.Drawing.Size(154, 20)
        Me.txtPVenta.TabIndex = 9
        '
        'txtPCompra
        '
        Me.txtPCompra.Location = New System.Drawing.Point(409, 18)
        Me.txtPCompra.Name = "txtPCompra"
        Me.txtPCompra.Size = New System.Drawing.Size(154, 20)
        Me.txtPCompra.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(122, 197)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(441, 71)
        Me.txtDescripcion.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(122, 46)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(122, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "(*) Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "(*) Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "(*) Precio Venta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "(*) Precio Compra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.dgvMateriales)
        Me.TabPage2.Controls.Add(Me.btnEliminar)
        Me.TabPage2.Controls.Add(Me.btnModificar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(959, 363)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar materiales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtNombreBuscar)
        Me.GroupBox1.Controls.Add(Me.cbotipofamilia)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionBuscar)
        Me.GroupBox1.Controls.Add(Me.txtxnombrebuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 76)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Image = Global.WES_II.My.Resources.Resources.Buscar_32x32
        Me.btnBuscar.Location = New System.Drawing.Point(776, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(110, 47)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(536, 37)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Tipo:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(283, 37)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Descripcion:"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.AutoSize = True
        Me.txtNombreBuscar.Location = New System.Drawing.Point(12, 37)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(47, 13)
        Me.txtNombreBuscar.TabIndex = 4
        Me.txtNombreBuscar.Text = "Nombre:"
        '
        'cbotipofamilia
        '
        Me.cbotipofamilia.FormattingEnabled = True
        Me.cbotipofamilia.Location = New System.Drawing.Point(573, 34)
        Me.cbotipofamilia.Name = "cbotipofamilia"
        Me.cbotipofamilia.Size = New System.Drawing.Size(176, 21)
        Me.cbotipofamilia.TabIndex = 2
        '
        'txtDescripcionBuscar
        '
        Me.txtDescripcionBuscar.Location = New System.Drawing.Point(356, 34)
        Me.txtDescripcionBuscar.Name = "txtDescripcionBuscar"
        Me.txtDescripcionBuscar.Size = New System.Drawing.Size(172, 20)
        Me.txtDescripcionBuscar.TabIndex = 1
        '
        'txtxnombrebuscar
        '
        Me.txtxnombrebuscar.Location = New System.Drawing.Point(63, 34)
        Me.txtxnombrebuscar.Name = "txtxnombrebuscar"
        Me.txtxnombrebuscar.Size = New System.Drawing.Size(211, 20)
        Me.txtxnombrebuscar.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(29, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 15)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Listado de Materiales:"
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AllowUserToAddRows = False
        Me.dgvMateriales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Location = New System.Drawing.Point(22, 103)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(761, 239)
        Me.dgvMateriales.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnEliminar.Location = New System.Drawing.Point(799, 295)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 47)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar el Producto seleccionado")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificar.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnModificar.Location = New System.Drawing.Point(799, 103)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 47)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar el Producto seleccionado")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.dgvMaterialesDesdeExcel)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(959, 363)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Importar desde Excel"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(29, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 15)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Listado de Materiales:"
        '
        'dgvMaterialesDesdeExcel
        '
        Me.dgvMaterialesDesdeExcel.AllowUserToAddRows = False
        Me.dgvMaterialesDesdeExcel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMaterialesDesdeExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterialesDesdeExcel.Location = New System.Drawing.Point(22, 103)
        Me.dgvMaterialesDesdeExcel.Name = "dgvMaterialesDesdeExcel"
        Me.dgvMaterialesDesdeExcel.ReadOnly = True
        Me.dgvMaterialesDesdeExcel.Size = New System.Drawing.Size(915, 239)
        Me.dgvMaterialesDesdeExcel.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnGrabarDesdeExcel)
        Me.GroupBox2.Controls.Add(Me.btnSubirPlantilla)
        Me.GroupBox2.Controls.Add(Me.btnDescargarPlantilla)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 76)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLimpiar.Image = Global.WES_II.My.Resources.Resources.eraser
        Me.btnLimpiar.Location = New System.Drawing.Point(640, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(110, 47)
        Me.btnLimpiar.TabIndex = 34
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "Registrar nuevo material")
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGrabarDesdeExcel
        '
        Me.btnGrabarDesdeExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGrabarDesdeExcel.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGrabarDesdeExcel.Location = New System.Drawing.Point(490, 19)
        Me.btnGrabarDesdeExcel.Name = "btnGrabarDesdeExcel"
        Me.btnGrabarDesdeExcel.Size = New System.Drawing.Size(110, 47)
        Me.btnGrabarDesdeExcel.TabIndex = 33
        Me.btnGrabarDesdeExcel.Text = "Guardar"
        Me.btnGrabarDesdeExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnGrabarDesdeExcel, "Registrar nuevo material")
        Me.btnGrabarDesdeExcel.UseVisualStyleBackColor = True
        '
        'btnSubirPlantilla
        '
        Me.btnSubirPlantilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSubirPlantilla.Image = Global.WES_II.My.Resources.Resources.IngresosMat
        Me.btnSubirPlantilla.Location = New System.Drawing.Point(340, 19)
        Me.btnSubirPlantilla.Name = "btnSubirPlantilla"
        Me.btnSubirPlantilla.Size = New System.Drawing.Size(110, 47)
        Me.btnSubirPlantilla.TabIndex = 32
        Me.btnSubirPlantilla.Text = "Subir Plantilla"
        Me.btnSubirPlantilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnSubirPlantilla, "Buscar")
        Me.btnSubirPlantilla.UseVisualStyleBackColor = True
        '
        'btnDescargarPlantilla
        '
        Me.btnDescargarPlantilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDescargarPlantilla.Image = Global.WES_II.My.Resources.Resources.SalidasMat
        Me.btnDescargarPlantilla.Location = New System.Drawing.Point(190, 19)
        Me.btnDescargarPlantilla.Name = "btnDescargarPlantilla"
        Me.btnDescargarPlantilla.Size = New System.Drawing.Size(110, 47)
        Me.btnDescargarPlantilla.TabIndex = 31
        Me.btnDescargarPlantilla.Text = "Descargar Plantilla"
        Me.btnDescargarPlantilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnDescargarPlantilla, "Buscar")
        Me.btnDescargarPlantilla.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ABM de materiales"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 464)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Materiales"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvMaterialesDesdeExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboRG2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboRG1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboTipoRecepcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCajasPaquete As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadesCaja As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtNombreBuscar As Label
    Friend WithEvents cbotipofamilia As ComboBox
    Friend WithEvents txtDescripcionBuscar As TextBox
    Friend WithEvents txtxnombrebuscar As TextBox
    Friend WithEvents btnExamFamilia As Button
    Friend WithEvents txtDescripcionFamilia As TextBox
    Friend WithEvents txtCodigoFamilia As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chkNumSerie As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label24 As Label
    Friend WithEvents dgvMaterialesDesdeExcel As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGrabarDesdeExcel As Button
    Friend WithEvents btnSubirPlantilla As Button
    Friend WithEvents btnDescargarPlantilla As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnLimpiar As Button
End Class
