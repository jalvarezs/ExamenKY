<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrdenCompra))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_idprov = New System.Windows.Forms.TextBox()
        Me.txtpref = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tsInfofooter = New System.Windows.Forms.ToolStrip()
        Me.tstotalCantidad = New System.Windows.Forms.ToolStripButton()
        Me.tstotalpreciounitario = New System.Windows.Forms.ToolStripButton()
        Me.tstotalIGV = New System.Windows.Forms.ToolStripButton()
        Me.tsTotalgeneral = New System.Windows.Forms.ToolStripButton()
        Me.rbSoles = New System.Windows.Forms.RadioButton()
        Me.rbDolar = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbotipocredito = New System.Windows.Forms.ComboBox()
        Me.cboformapago = New System.Windows.Forms.ComboBox()
        Me.cbotipocompra = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDirproveedor = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnExaminarProv = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboOferta = New System.Windows.Forms.ComboBox()
        Me.cboProyecto = New System.Windows.Forms.ComboBox()
        Me.chkOferta = New System.Windows.Forms.CheckBox()
        Me.chkProyecto = New System.Windows.Forms.CheckBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExaminarMat = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lbMat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaOrden = New System.Windows.Forms.DateTimePicker()
        Me.txtMateriales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgvOrden = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_Listasug = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_finsu = New System.Windows.Forms.DateTimePicker()
        Me.dtp_inicsu = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgv_sugerencias = New System.Windows.Forms.DataGridView()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_aceptarsg = New System.Windows.Forms.Button()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsInfofooter.SuspendLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_sugerencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 92)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(941, 713)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.txt_idprov)
        Me.TabPage1.Controls.Add(Me.txtpref)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.tsInfofooter)
        Me.TabPage1.Controls.Add(Me.rbSoles)
        Me.TabPage1.Controls.Add(Me.rbDolar)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbotipocredito)
        Me.TabPage1.Controls.Add(Me.cboformapago)
        Me.TabPage1.Controls.Add(Me.cbotipocompra)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtDirproveedor)
        Me.TabPage1.Controls.Add(Me.txtProveedor)
        Me.TabPage1.Controls.Add(Me.txtRUC)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.btnExaminarProv)
        Me.TabPage1.Controls.Add(Me.btnAgregar)
        Me.TabPage1.Controls.Add(Me.dgvMateriales)
        Me.TabPage1.Controls.Add(Me.cboOferta)
        Me.TabPage1.Controls.Add(Me.cboProyecto)
        Me.TabPage1.Controls.Add(Me.chkOferta)
        Me.TabPage1.Controls.Add(Me.chkProyecto)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnExaminarMat)
        Me.TabPage1.Controls.Add(Me.txtcantidad)
        Me.TabPage1.Controls.Add(Me.lbMat)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dtpFechaOrden)
        Me.TabPage1.Controls.Add(Me.txtMateriales)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(933, 684)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar orden"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(965, 41)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(141, 87)
        Me.DataGridView1.TabIndex = 44
        '
        'txt_idprov
        '
        Me.txt_idprov.Location = New System.Drawing.Point(880, 646)
        Me.txt_idprov.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_idprov.Name = "txt_idprov"
        Me.txt_idprov.Size = New System.Drawing.Size(25, 22)
        Me.txt_idprov.TabIndex = 43
        Me.txt_idprov.Visible = False
        '
        'txtpref
        '
        Me.txtpref.Location = New System.Drawing.Point(192, 373)
        Me.txtpref.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpref.Name = "txtpref"
        Me.txtpref.Size = New System.Drawing.Size(136, 22)
        Me.txtpref.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(37, 374)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 18)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Precio Referencial:"
        '
        'tsInfofooter
        '
        Me.tsInfofooter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tsInfofooter.Dock = System.Windows.Forms.DockStyle.None
        Me.tsInfofooter.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsInfofooter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstotalCantidad, Me.tstotalpreciounitario, Me.tstotalIGV, Me.tsTotalgeneral})
        Me.tsInfofooter.Location = New System.Drawing.Point(57, 632)
        Me.tsInfofooter.Name = "tsInfofooter"
        Me.tsInfofooter.Size = New System.Drawing.Size(584, 27)
        Me.tsInfofooter.TabIndex = 40
        Me.tsInfofooter.Text = "ToolStrip1"
        '
        'tstotalCantidad
        '
        Me.tstotalCantidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tstotalCantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstotalCantidad.Image = CType(resources.GetObject("tstotalCantidad.Image"), System.Drawing.Image)
        Me.tstotalCantidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstotalCantidad.Name = "tstotalCantidad"
        Me.tstotalCantidad.Size = New System.Drawing.Size(163, 24)
        Me.tstotalCantidad.Text = "Cantidad Solicitada: 0"
        '
        'tstotalpreciounitario
        '
        Me.tstotalpreciounitario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tstotalpreciounitario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstotalpreciounitario.Image = CType(resources.GetObject("tstotalpreciounitario.Image"), System.Drawing.Image)
        Me.tstotalpreciounitario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstotalpreciounitario.Name = "tstotalpreciounitario"
        Me.tstotalpreciounitario.Size = New System.Drawing.Size(155, 24)
        Me.tstotalpreciounitario.Text = "Precio Referencial: 0"
        '
        'tstotalIGV
        '
        Me.tstotalIGV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tstotalIGV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstotalIGV.Image = CType(resources.GetObject("tstotalIGV.Image"), System.Drawing.Image)
        Me.tstotalIGV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstotalIGV.Name = "tstotalIGV"
        Me.tstotalIGV.Size = New System.Drawing.Size(107, 24)
        Me.tstotalIGV.Text = "IGV (18%):  0"
        '
        'tsTotalgeneral
        '
        Me.tsTotalgeneral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsTotalgeneral.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsTotalgeneral.Image = CType(resources.GetObject("tsTotalgeneral.Image"), System.Drawing.Image)
        Me.tsTotalgeneral.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTotalgeneral.Name = "tsTotalgeneral"
        Me.tsTotalgeneral.Size = New System.Drawing.Size(147, 24)
        Me.tsTotalgeneral.Text = "Total Referencial: 0"
        '
        'rbSoles
        '
        Me.rbSoles.AutoSize = True
        Me.rbSoles.Checked = True
        Me.rbSoles.Location = New System.Drawing.Point(711, 332)
        Me.rbSoles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbSoles.Name = "rbSoles"
        Me.rbSoles.Size = New System.Drawing.Size(37, 21)
        Me.rbSoles.TabIndex = 38
        Me.rbSoles.TabStop = True
        Me.rbSoles.Text = "$"
        Me.rbSoles.UseVisualStyleBackColor = True
        '
        'rbDolar
        '
        Me.rbDolar.AutoSize = True
        Me.rbDolar.Location = New System.Drawing.Point(781, 332)
        Me.rbDolar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbDolar.Name = "rbDolar"
        Me.rbDolar.Size = New System.Drawing.Size(56, 21)
        Me.rbDolar.TabIndex = 39
        Me.rbDolar.Text = "U$S"
        Me.rbDolar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(588, 332)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 18)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "(*)Moneda:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(536, 283)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 18)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "(*)Forma de Pago :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 236)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 18)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "(*)Tipo de Credito :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 284)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 18)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "(*)Tipo de Compra :"
        '
        'cbotipocredito
        '
        Me.cbotipocredito.FormattingEnabled = True
        Me.cbotipocredito.Items.AddRange(New Object() {"Ninguno", "15 Días", "30 Días", "60 Días"})
        Me.cbotipocredito.Location = New System.Drawing.Point(193, 234)
        Me.cbotipocredito.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbotipocredito.Name = "cbotipocredito"
        Me.cbotipocredito.Size = New System.Drawing.Size(253, 24)
        Me.cbotipocredito.TabIndex = 31
        '
        'cboformapago
        '
        Me.cboformapago.FormattingEnabled = True
        Me.cboformapago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Depósito"})
        Me.cboformapago.Location = New System.Drawing.Point(708, 282)
        Me.cboformapago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboformapago.Name = "cboformapago"
        Me.cboformapago.Size = New System.Drawing.Size(197, 24)
        Me.cboformapago.TabIndex = 30
        '
        'cbotipocompra
        '
        Me.cbotipocompra.FormattingEnabled = True
        Me.cbotipocompra.Items.AddRange(New Object() {"Contado", "Crédito"})
        Me.cbotipocompra.Location = New System.Drawing.Point(193, 282)
        Me.cbotipocompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbotipocompra.Name = "cbotipocompra"
        Me.cbotipocompra.Size = New System.Drawing.Size(253, 24)
        Me.cbotipocompra.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Dirección Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "(*)Proveedor:"
        '
        'txtDirproveedor
        '
        Me.txtDirproveedor.Enabled = False
        Me.txtDirproveedor.Location = New System.Drawing.Point(192, 70)
        Me.txtDirproveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDirproveedor.Multiline = True
        Me.txtDirproveedor.Name = "txtDirproveedor"
        Me.txtDirproveedor.Size = New System.Drawing.Size(713, 57)
        Me.txtDirproveedor.TabIndex = 12
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(193, 36)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(193, 22)
        Me.txtProveedor.TabIndex = 6
        '
        'txtRUC
        '
        Me.txtRUC.Enabled = False
        Me.txtRUC.Location = New System.Drawing.Point(391, 36)
        Me.txtRUC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(132, 22)
        Me.txtRUC.TabIndex = 11
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBorrar.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnBorrar.Location = New System.Drawing.Point(759, 405)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(147, 58)
        Me.btnBorrar.TabIndex = 26
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnBorrar, "Eliminar el detalle seleccionado")
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnExaminarProv
        '
        Me.btnExaminarProv.Location = New System.Drawing.Point(532, 34)
        Me.btnExaminarProv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExaminarProv.Name = "btnExaminarProv"
        Me.btnExaminarProv.Size = New System.Drawing.Size(111, 28)
        Me.btnExaminarProv.TabIndex = 10
        Me.btnExaminarProv.Text = "Examinar"
        Me.btnExaminarProv.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(337, 369)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(111, 28)
        Me.btnAgregar.TabIndex = 25
        Me.btnAgregar.Text = "&Añadir"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreMaterial, Me.Cantidad, Me.Precio})
        Me.dgvMateriales.Location = New System.Drawing.Point(57, 405)
        Me.dgvMateriales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(693, 220)
        Me.dgvMateriales.TabIndex = 24
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'NombreMaterial
        '
        Me.NombreMaterial.HeaderText = "Nombre del material"
        Me.NombreMaterial.Name = "NombreMaterial"
        Me.NombreMaterial.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad solicitada"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio referencial"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'cboOferta
        '
        Me.cboOferta.Enabled = False
        Me.cboOferta.FormattingEnabled = True
        Me.cboOferta.Location = New System.Drawing.Point(708, 234)
        Me.cboOferta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboOferta.Name = "cboOferta"
        Me.cboOferta.Size = New System.Drawing.Size(195, 24)
        Me.cboOferta.TabIndex = 23
        '
        'cboProyecto
        '
        Me.cboProyecto.Enabled = False
        Me.cboProyecto.FormattingEnabled = True
        Me.cboProyecto.Location = New System.Drawing.Point(708, 187)
        Me.cboProyecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboProyecto.Name = "cboProyecto"
        Me.cboProyecto.Size = New System.Drawing.Size(195, 24)
        Me.cboProyecto.TabIndex = 22
        '
        'chkOferta
        '
        Me.chkOferta.AutoSize = True
        Me.chkOferta.Enabled = False
        Me.chkOferta.Location = New System.Drawing.Point(547, 236)
        Me.chkOferta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkOferta.Name = "chkOferta"
        Me.chkOferta.Size = New System.Drawing.Size(122, 21)
        Me.chkOferta.TabIndex = 21
        Me.chkOferta.Text = "Asignar Oferta"
        Me.chkOferta.UseVisualStyleBackColor = True
        '
        'chkProyecto
        '
        Me.chkProyecto.AutoSize = True
        Me.chkProyecto.Location = New System.Drawing.Point(547, 190)
        Me.chkProyecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkProyecto.Name = "chkProyecto"
        Me.chkProyecto.Size = New System.Drawing.Size(138, 21)
        Me.chkProyecto.TabIndex = 20
        Me.chkProyecto.Text = "Asignar Proyecto"
        Me.chkProyecto.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(711, 145)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(195, 22)
        Me.txtCodigo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(533, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Código de la orden:"
        '
        'btnExaminarMat
        '
        Me.btnExaminarMat.Location = New System.Drawing.Point(337, 185)
        Me.btnExaminarMat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExaminarMat.Name = "btnExaminarMat"
        Me.btnExaminarMat.Size = New System.Drawing.Size(111, 28)
        Me.btnExaminarMat.TabIndex = 17
        Me.btnExaminarMat.Text = "Examinar"
        Me.btnExaminarMat.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(192, 327)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(136, 22)
        Me.txtcantidad.TabIndex = 16
        '
        'lbMat
        '
        Me.lbMat.AutoSize = True
        Me.lbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMat.Location = New System.Drawing.Point(84, 329)
        Me.lbMat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMat.Name = "lbMat"
        Me.lbMat.Size = New System.Drawing.Size(90, 18)
        Me.lbMat.TabIndex = 15
        Me.lbMat.Text = "(*) Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "(*) Material:"
        '
        'dtpFechaOrden
        '
        Me.dtpFechaOrden.Location = New System.Drawing.Point(192, 142)
        Me.dtpFechaOrden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaOrden.Name = "dtpFechaOrden"
        Me.dtpFechaOrden.Size = New System.Drawing.Size(255, 22)
        Me.dtpFechaOrden.TabIndex = 13
        '
        'txtMateriales
        '
        Me.txtMateriales.Enabled = False
        Me.txtMateriales.Location = New System.Drawing.Point(192, 187)
        Me.txtMateriales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMateriales.Name = "txtMateriales"
        Me.txtMateriales.Size = New System.Drawing.Size(136, 22)
        Me.txtMateriales.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(759, 567)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(147, 58)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(759, 502)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(147, 58)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnGuardar, "Guardar la orden de compra")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDetalles)
        Me.TabPage2.Controls.Add(Me.btnListar)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.dtpFin)
        Me.TabPage2.Controls.Add(Me.dtpInicio)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnEliminar)
        Me.TabPage2.Controls.Add(Me.btnModificar)
        Me.TabPage2.Controls.Add(Me.dgvOrden)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(933, 684)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar órdenes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(29, 399)
        Me.dgvDetalles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.Size = New System.Drawing.Size(849, 177)
        Me.dgvDetalles.TabIndex = 21
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(720, 66)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(159, 28)
        Me.btnListar.TabIndex = 20
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(379, 68)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "hasta:"
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(440, 68)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(257, 22)
        Me.dtpFin.TabIndex = 17
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(95, 68)
        Me.dtpInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(275, 22)
        Me.dtpInicio.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Desde:"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.Image = Global.WES_II.My.Resources.Resources.Cancel_32x32
        Me.btnEliminar.Location = New System.Drawing.Point(487, 334)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(147, 58)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Cancelar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnEliminar, "Cnacelar la orden de compra seleccionada")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificar.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnModificar.Location = New System.Drawing.Point(285, 334)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(147, 58)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnModificar, "Modificar la orden de compra seleccionada")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'dgvOrden
        '
        Me.dgvOrden.AllowUserToAddRows = False
        Me.dgvOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrden.Location = New System.Drawing.Point(29, 118)
        Me.dgvOrden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvOrden.Name = "dgvOrden"
        Me.dgvOrden.ReadOnly = True
        Me.dgvOrden.Size = New System.Drawing.Size(887, 208)
        Me.dgvOrden.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(25, 18)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 18)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Listado de órdenes:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_aceptarsg)
        Me.TabPage3.Controls.Add(Me.btn_Listasug)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.dtp_finsu)
        Me.TabPage3.Controls.Add(Me.dtp_inicsu)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.dgv_sugerencias)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(933, 684)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Consultar Sugerencias"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_Listasug
        '
        Me.btn_Listasug.Location = New System.Drawing.Point(731, 66)
        Me.btn_Listasug.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Listasug.Name = "btn_Listasug"
        Me.btn_Listasug.Size = New System.Drawing.Size(144, 28)
        Me.btn_Listasug.TabIndex = 26
        Me.btn_Listasug.Text = "Listar"
        Me.btn_Listasug.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(389, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 18)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "hasta:"
        '
        'dtp_finsu
        '
        Me.dtp_finsu.Location = New System.Drawing.Point(451, 68)
        Me.dtp_finsu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_finsu.Name = "dtp_finsu"
        Me.dtp_finsu.Size = New System.Drawing.Size(257, 22)
        Me.dtp_finsu.TabIndex = 24
        '
        'dtp_inicsu
        '
        Me.dtp_inicsu.Location = New System.Drawing.Point(105, 68)
        Me.dtp_inicsu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_inicsu.Name = "dtp_inicsu"
        Me.dtp_inicsu.Size = New System.Drawing.Size(275, 22)
        Me.dtp_inicsu.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(36, 68)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 18)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Desde:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(48, 21)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(244, 18)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Listado de Sugerencias de Compra:"
        '
        'dgv_sugerencias
        '
        Me.dgv_sugerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sugerencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.dgv_sugerencias.Location = New System.Drawing.Point(31, 106)
        Me.dgv_sugerencias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_sugerencias.Name = "dgv_sugerencias"
        Me.dgv_sugerencias.Size = New System.Drawing.Size(844, 528)
        Me.dgv_sugerencias.TabIndex = 1
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 92)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Órdenes de compra"
        '
        'btn_aceptarsg
        '
        Me.btn_aceptarsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_aceptarsg.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btn_aceptarsg.Location = New System.Drawing.Point(354, 637)
        Me.btn_aceptarsg.Name = "btn_aceptarsg"
        Me.btn_aceptarsg.Size = New System.Drawing.Size(139, 47)
        Me.btn_aceptarsg.TabIndex = 47
        Me.btn_aceptarsg.Text = "Aceptar"
        Me.btn_aceptarsg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_aceptarsg.UseVisualStyleBackColor = True
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FormOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 805)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Ordenes de Compra"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsInfofooter.ResumeLayout(False)
        Me.tsInfofooter.PerformLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgv_sugerencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents dgvOrden As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboOferta As System.Windows.Forms.ComboBox
    Friend WithEvents cboProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents chkOferta As System.Windows.Forms.CheckBox
    Friend WithEvents chkProyecto As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExaminarMat As System.Windows.Forms.Button
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbMat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaOrden As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMateriales As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExaminarProv As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDirproveedor As TextBox
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbotipocredito As ComboBox
    Friend WithEvents cboformapago As ComboBox
    Friend WithEvents cbotipocompra As ComboBox
    Friend WithEvents rbSoles As RadioButton
    Friend WithEvents rbDolar As RadioButton
    Friend WithEvents tsInfofooter As ToolStrip
    Friend WithEvents tstotalCantidad As ToolStripButton
    Friend WithEvents tstotalpreciounitario As ToolStripButton
    Friend WithEvents tstotalIGV As ToolStripButton
    Friend WithEvents tsTotalgeneral As ToolStripButton
    Friend WithEvents txtpref As TextBox
    Friend WithEvents Label13 As Label
    Public WithEvents dgvMateriales As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgv_sugerencias As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_Listasug As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents dtp_finsu As DateTimePicker
    Friend WithEvents dtp_inicsu As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_idprov As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_aceptarsg As Button
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
End Class
