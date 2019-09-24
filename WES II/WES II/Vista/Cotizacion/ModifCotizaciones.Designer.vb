<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifCotizaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TabCotizaciones = New System.Windows.Forms.TabControl()
        Me.TbgGeneral = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkServicioExterno = New System.Windows.Forms.CheckBox()
        Me.chkMaterial = New System.Windows.Forms.CheckBox()
        Me.chkRRHH = New System.Windows.Forms.CheckBox()
        Me.nudDuracionHoras = New System.Windows.Forms.NumericUpDown()
        Me.NudDuracionDias = New System.Windows.Forms.NumericUpDown()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpHoras = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaCotizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TpgObreros = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ItemCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoPersonalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadPersonalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPersonalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlControlesObreros = New System.Windows.Forms.Panel()
        Me.cbItemDetallesPersonal = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCargos = New System.Windows.Forms.ComboBox()
        Me.btnElimEmpleados = New System.Windows.Forms.Button()
        Me.btnAddPersonal = New System.Windows.Forms.Button()
        Me.txtCantEmpleados = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TpgMateriales = New System.Windows.Forms.TabPage()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.ItemCodigo_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsAlquilerCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDiasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialHorasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioAlquilerDiaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioAlquilerHoraCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlControlesMateriales = New System.Windows.Forms.Panel()
        Me.cbItemDetallesMateriales = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GrpDuracion = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.NudDuracionHorasMaterial = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.NudDuracionDiasMaterial = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.NudDescuento = New System.Windows.Forms.NumericUpDown()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnExamMaterial = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lbMat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.TabCotizaciones.SuspendLayout()
        Me.TbgGeneral.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nudDuracionHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDuracionDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpgObreros.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlControlesObreros.SuspendLayout()
        Me.TpgMateriales.SuspendLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlControlesMateriales.SuspendLayout()
        Me.GrpDuracion.SuspendLayout()
        CType(Me.NudDuracionHorasMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDuracionDiasMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 75)
        Me.Panel1.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Cotizaciones"
        '
        'PnlBotones
        '
        Me.PnlBotones.Controls.Add(Me.btnAceptar)
        Me.PnlBotones.Controls.Add(Me.btnGuardar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotones.Location = New System.Drawing.Point(0, 430)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(973, 69)
        Me.PnlBotones.TabIndex = 72
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(486, 12)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 56
        Me.btnAceptar.Text = "Volver"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(358, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 55
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TabCotizaciones
        '
        Me.TabCotizaciones.Controls.Add(Me.TbgGeneral)
        Me.TabCotizaciones.Controls.Add(Me.TpgObreros)
        Me.TabCotizaciones.Controls.Add(Me.TpgMateriales)
        Me.TabCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCotizaciones.Location = New System.Drawing.Point(0, 75)
        Me.TabCotizaciones.Name = "TabCotizaciones"
        Me.TabCotizaciones.SelectedIndex = 0
        Me.TabCotizaciones.Size = New System.Drawing.Size(973, 355)
        Me.TabCotizaciones.TabIndex = 73
        '
        'TbgGeneral
        '
        Me.TbgGeneral.Controls.Add(Me.GroupBox6)
        Me.TbgGeneral.Controls.Add(Me.nudDuracionHoras)
        Me.TbgGeneral.Controls.Add(Me.NudDuracionDias)
        Me.TbgGeneral.Controls.Add(Me.txtDescripcion)
        Me.TbgGeneral.Controls.Add(Me.Label7)
        Me.TbgGeneral.Controls.Add(Me.txtCodigo)
        Me.TbgGeneral.Controls.Add(Me.Label4)
        Me.TbgGeneral.Controls.Add(Me.dtpHoras)
        Me.TbgGeneral.Controls.Add(Me.dtpFechaCotizacion)
        Me.TbgGeneral.Controls.Add(Me.Label9)
        Me.TbgGeneral.Controls.Add(Me.Label13)
        Me.TbgGeneral.Controls.Add(Me.Label12)
        Me.TbgGeneral.Controls.Add(Me.Label11)
        Me.TbgGeneral.Controls.Add(Me.Label10)
        Me.TbgGeneral.Controls.Add(Me.Label2)
        Me.TbgGeneral.Controls.Add(Me.txtCliente)
        Me.TbgGeneral.Controls.Add(Me.Label5)
        Me.TbgGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TbgGeneral.Name = "TbgGeneral"
        Me.TbgGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TbgGeneral.Size = New System.Drawing.Size(965, 329)
        Me.TbgGeneral.TabIndex = 0
        Me.TbgGeneral.Text = "General"
        Me.TbgGeneral.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkServicioExterno)
        Me.GroupBox6.Controls.Add(Me.chkMaterial)
        Me.GroupBox6.Controls.Add(Me.chkRRHH)
        Me.GroupBox6.Location = New System.Drawing.Point(112, 121)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(326, 59)
        Me.GroupBox6.TabIndex = 88
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Reporte PDF"
        '
        'chkServicioExterno
        '
        Me.chkServicioExterno.AutoSize = True
        Me.chkServicioExterno.Location = New System.Drawing.Point(193, 26)
        Me.chkServicioExterno.Name = "chkServicioExterno"
        Me.chkServicioExterno.Size = New System.Drawing.Size(103, 17)
        Me.chkServicioExterno.TabIndex = 2
        Me.chkServicioExterno.Text = "Servicio Externo"
        Me.chkServicioExterno.UseVisualStyleBackColor = True
        '
        'chkMaterial
        '
        Me.chkMaterial.AutoSize = True
        Me.chkMaterial.Location = New System.Drawing.Point(97, 26)
        Me.chkMaterial.Name = "chkMaterial"
        Me.chkMaterial.Size = New System.Drawing.Size(63, 17)
        Me.chkMaterial.TabIndex = 1
        Me.chkMaterial.Text = "Material"
        Me.chkMaterial.UseVisualStyleBackColor = True
        '
        'chkRRHH
        '
        Me.chkRRHH.AutoSize = True
        Me.chkRRHH.Location = New System.Drawing.Point(13, 26)
        Me.chkRRHH.Name = "chkRRHH"
        Me.chkRRHH.Size = New System.Drawing.Size(58, 17)
        Me.chkRRHH.TabIndex = 0
        Me.chkRRHH.Text = "RRHH"
        Me.chkRRHH.UseVisualStyleBackColor = True
        '
        'nudDuracionHoras
        '
        Me.nudDuracionHoras.Location = New System.Drawing.Point(576, 121)
        Me.nudDuracionHoras.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDuracionHoras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDuracionHoras.Name = "nudDuracionHoras"
        Me.nudDuracionHoras.Size = New System.Drawing.Size(52, 20)
        Me.nudDuracionHoras.TabIndex = 87
        Me.nudDuracionHoras.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDuracionHoras.Visible = False
        '
        'NudDuracionDias
        '
        Me.NudDuracionDias.Location = New System.Drawing.Point(576, 59)
        Me.NudDuracionDias.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudDuracionDias.Name = "NudDuracionDias"
        Me.NudDuracionDias.Size = New System.Drawing.Size(52, 20)
        Me.NudDuracionDias.TabIndex = 86
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 221)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(636, 92)
        Me.txtDescripcion.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Descripción del trabajo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(252, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(186, 20)
        Me.txtCodigo.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 15)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Código de la cotización:"
        '
        'dtpHoras
        '
        Me.dtpHoras.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoras.Location = New System.Drawing.Point(576, 92)
        Me.dtpHoras.Name = "dtpHoras"
        Me.dtpHoras.Size = New System.Drawing.Size(121, 20)
        Me.dtpHoras.TabIndex = 80
        Me.dtpHoras.Visible = False
        '
        'dtpFechaCotizacion
        '
        Me.dtpFechaCotizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCotizacion.Location = New System.Drawing.Point(576, 29)
        Me.dtpFechaCotizacion.Name = "dtpFechaCotizacion"
        Me.dtpFechaCotizacion.Size = New System.Drawing.Size(121, 20)
        Me.dtpFechaCotizacion.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(502, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Hora:"
        Me.Label9.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(634, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 15)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Horas"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(500, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 15)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Duración:"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(634, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 15)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Días"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(502, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 15)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Duración:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(502, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Fecha:"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(252, 73)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(186, 20)
        Me.txtCliente.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "(*) Cliente:"
        '
        'TpgObreros
        '
        Me.TpgObreros.Controls.Add(Me.dgvEmpleados)
        Me.TpgObreros.Controls.Add(Me.PnlControlesObreros)
        Me.TpgObreros.Location = New System.Drawing.Point(4, 22)
        Me.TpgObreros.Name = "TpgObreros"
        Me.TpgObreros.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgObreros.Size = New System.Drawing.Size(965, 329)
        Me.TpgObreros.TabIndex = 1
        Me.TpgObreros.Text = "Personal"
        Me.TpgObreros.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodigo, Me.Item, Me.CargoPersonalCol, Me.CantidadPersonalCol, Me.ValorPersonalCol})
        Me.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 55)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(959, 271)
        Me.dgvEmpleados.TabIndex = 24
        '
        'ItemCodigo
        '
        Me.ItemCodigo.HeaderText = "ItemCodigo"
        Me.ItemCodigo.Name = "ItemCodigo"
        Me.ItemCodigo.ReadOnly = True
        Me.ItemCodigo.Visible = False
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        '
        'CargoPersonalCol
        '
        Me.CargoPersonalCol.HeaderText = "Cargo"
        Me.CargoPersonalCol.Name = "CargoPersonalCol"
        Me.CargoPersonalCol.ReadOnly = True
        '
        'CantidadPersonalCol
        '
        Me.CantidadPersonalCol.HeaderText = "Cantidad"
        Me.CantidadPersonalCol.Name = "CantidadPersonalCol"
        Me.CantidadPersonalCol.ReadOnly = True
        '
        'ValorPersonalCol
        '
        Me.ValorPersonalCol.HeaderText = "Valor"
        Me.ValorPersonalCol.Name = "ValorPersonalCol"
        Me.ValorPersonalCol.ReadOnly = True
        '
        'PnlControlesObreros
        '
        Me.PnlControlesObreros.Controls.Add(Me.cbItemDetallesPersonal)
        Me.PnlControlesObreros.Controls.Add(Me.Label6)
        Me.PnlControlesObreros.Controls.Add(Me.cboCargos)
        Me.PnlControlesObreros.Controls.Add(Me.btnElimEmpleados)
        Me.PnlControlesObreros.Controls.Add(Me.btnAddPersonal)
        Me.PnlControlesObreros.Controls.Add(Me.txtCantEmpleados)
        Me.PnlControlesObreros.Controls.Add(Me.Label22)
        Me.PnlControlesObreros.Controls.Add(Me.Label23)
        Me.PnlControlesObreros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlControlesObreros.Location = New System.Drawing.Point(3, 3)
        Me.PnlControlesObreros.Name = "PnlControlesObreros"
        Me.PnlControlesObreros.Size = New System.Drawing.Size(959, 52)
        Me.PnlControlesObreros.TabIndex = 0
        '
        'cbItemDetallesPersonal
        '
        Me.cbItemDetallesPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItemDetallesPersonal.FormattingEnabled = True
        Me.cbItemDetallesPersonal.Items.AddRange(New Object() {"Soldador", "Pintor"})
        Me.cbItemDetallesPersonal.Location = New System.Drawing.Point(68, 14)
        Me.cbItemDetallesPersonal.Name = "cbItemDetallesPersonal"
        Me.cbItemDetallesPersonal.Size = New System.Drawing.Size(162, 21)
        Me.cbItemDetallesPersonal.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "(*) Item:"
        '
        'cboCargos
        '
        Me.cboCargos.FormattingEnabled = True
        Me.cboCargos.Items.AddRange(New Object() {"Soldador", "Pintor"})
        Me.cboCargos.Location = New System.Drawing.Point(308, 15)
        Me.cboCargos.Name = "cboCargos"
        Me.cboCargos.Size = New System.Drawing.Size(162, 21)
        Me.cboCargos.TabIndex = 26
        '
        'btnElimEmpleados
        '
        Me.btnElimEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnElimEmpleados.Location = New System.Drawing.Point(721, 15)
        Me.btnElimEmpleados.Name = "btnElimEmpleados"
        Me.btnElimEmpleados.Size = New System.Drawing.Size(66, 23)
        Me.btnElimEmpleados.TabIndex = 30
        Me.btnElimEmpleados.Text = "Eliminar"
        Me.btnElimEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnElimEmpleados.UseVisualStyleBackColor = True
        '
        'btnAddPersonal
        '
        Me.btnAddPersonal.Location = New System.Drawing.Point(654, 15)
        Me.btnAddPersonal.Name = "btnAddPersonal"
        Me.btnAddPersonal.Size = New System.Drawing.Size(66, 23)
        Me.btnAddPersonal.TabIndex = 29
        Me.btnAddPersonal.Text = "&Añadir"
        Me.btnAddPersonal.UseVisualStyleBackColor = True
        '
        'txtCantEmpleados
        '
        Me.txtCantEmpleados.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtCantEmpleados.Location = New System.Drawing.Point(557, 16)
        Me.txtCantEmpleados.Name = "txtCantEmpleados"
        Me.txtCantEmpleados.Size = New System.Drawing.Size(84, 20)
        Me.txtCantEmpleados.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(477, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 15)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "(*) Cantidad:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(235, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 15)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "(*) RR.HH.:"
        '
        'TpgMateriales
        '
        Me.TpgMateriales.Controls.Add(Me.dgvMateriales)
        Me.TpgMateriales.Controls.Add(Me.PnlControlesMateriales)
        Me.TpgMateriales.Location = New System.Drawing.Point(4, 22)
        Me.TpgMateriales.Name = "TpgMateriales"
        Me.TpgMateriales.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgMateriales.Size = New System.Drawing.Size(965, 329)
        Me.TpgMateriales.TabIndex = 2
        Me.TpgMateriales.Text = "Materiales"
        Me.TpgMateriales.UseVisualStyleBackColor = True
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AllowUserToAddRows = False
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodigo_, Me.ItemMat, Me.Codigo, Me.NombreMaterial, Me.EsAlquilerCol, Me.Cantidad, Me.PrecioUnit, Me.MaterialDiasCol, Me.MaterialHorasCol, Me.PrecioAlquilerDiaCol, Me.PrecioAlquilerHoraCol, Me.DescuentoCol, Me.PrecioTot})
        Me.dgvMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMateriales.Location = New System.Drawing.Point(3, 109)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.Size = New System.Drawing.Size(959, 217)
        Me.dgvMateriales.TabIndex = 37
        '
        'ItemCodigo_
        '
        Me.ItemCodigo_.HeaderText = "ItemCodigo"
        Me.ItemCodigo_.Name = "ItemCodigo_"
        Me.ItemCodigo_.Visible = False
        '
        'ItemMat
        '
        Me.ItemMat.HeaderText = "Item"
        Me.ItemMat.Name = "ItemMat"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.ToolTipText = "Código del material"
        '
        'NombreMaterial
        '
        Me.NombreMaterial.HeaderText = "Nombre del material"
        Me.NombreMaterial.Name = "NombreMaterial"
        Me.NombreMaterial.ReadOnly = True
        Me.NombreMaterial.ToolTipText = "Nombre del material"
        '
        'EsAlquilerCol
        '
        Me.EsAlquilerCol.HeaderText = "Alquiler"
        Me.EsAlquilerCol.Name = "EsAlquilerCol"
        Me.EsAlquilerCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EsAlquilerCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EsAlquilerCol.ToolTipText = "Indica si es material de alquiler"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad solicitada"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.ToolTipText = "Cantidad solicitada"
        '
        'PrecioUnit
        '
        Me.PrecioUnit.HeaderText = "Precio unitario"
        Me.PrecioUnit.Name = "PrecioUnit"
        Me.PrecioUnit.ReadOnly = True
        Me.PrecioUnit.ToolTipText = "Precio unitario"
        '
        'MaterialDiasCol
        '
        Me.MaterialDiasCol.HeaderText = "Días"
        Me.MaterialDiasCol.Name = "MaterialDiasCol"
        Me.MaterialDiasCol.ToolTipText = "Días de alquiler"
        '
        'MaterialHorasCol
        '
        Me.MaterialHorasCol.HeaderText = "Horas"
        Me.MaterialHorasCol.Name = "MaterialHorasCol"
        Me.MaterialHorasCol.ToolTipText = "Horas de alquiler"
        '
        'PrecioAlquilerDiaCol
        '
        Me.PrecioAlquilerDiaCol.HeaderText = "P/U Alquiler Día"
        Me.PrecioAlquilerDiaCol.Name = "PrecioAlquilerDiaCol"
        Me.PrecioAlquilerDiaCol.ToolTipText = "Precio Unitario de Alquiler por Día"
        '
        'PrecioAlquilerHoraCol
        '
        Me.PrecioAlquilerHoraCol.HeaderText = "P/U Alquiler Hora"
        Me.PrecioAlquilerHoraCol.Name = "PrecioAlquilerHoraCol"
        Me.PrecioAlquilerHoraCol.ToolTipText = "Precio Unitario de Alquiler por Hora"
        '
        'DescuentoCol
        '
        Me.DescuentoCol.HeaderText = "Desc"
        Me.DescuentoCol.Name = "DescuentoCol"
        Me.DescuentoCol.ToolTipText = "Decuento sobre el total de la linea"
        '
        'PrecioTot
        '
        Me.PrecioTot.HeaderText = "Precio total"
        Me.PrecioTot.Name = "PrecioTot"
        Me.PrecioTot.ReadOnly = True
        Me.PrecioTot.ToolTipText = "Precio total de la linea"
        '
        'PnlControlesMateriales
        '
        Me.PnlControlesMateriales.Controls.Add(Me.cbItemDetallesMateriales)
        Me.PnlControlesMateriales.Controls.Add(Me.Label8)
        Me.PnlControlesMateriales.Controls.Add(Me.txtTotal)
        Me.PnlControlesMateriales.Controls.Add(Me.Label14)
        Me.PnlControlesMateriales.Controls.Add(Me.GrpDuracion)
        Me.PnlControlesMateriales.Controls.Add(Me.Label27)
        Me.PnlControlesMateriales.Controls.Add(Me.NudDescuento)
        Me.PnlControlesMateriales.Controls.Add(Me.btnBorrar)
        Me.PnlControlesMateriales.Controls.Add(Me.btnAgregar)
        Me.PnlControlesMateriales.Controls.Add(Me.btnExamMaterial)
        Me.PnlControlesMateriales.Controls.Add(Me.txtCantidad)
        Me.PnlControlesMateriales.Controls.Add(Me.lbMat)
        Me.PnlControlesMateriales.Controls.Add(Me.Label3)
        Me.PnlControlesMateriales.Controls.Add(Me.txtMaterial)
        Me.PnlControlesMateriales.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlControlesMateriales.Location = New System.Drawing.Point(3, 3)
        Me.PnlControlesMateriales.Name = "PnlControlesMateriales"
        Me.PnlControlesMateriales.Size = New System.Drawing.Size(959, 106)
        Me.PnlControlesMateriales.TabIndex = 0
        '
        'cbItemDetallesMateriales
        '
        Me.cbItemDetallesMateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItemDetallesMateriales.FormattingEnabled = True
        Me.cbItemDetallesMateriales.Items.AddRange(New Object() {"Soldador", "Pintor"})
        Me.cbItemDetallesMateriales.Location = New System.Drawing.Point(75, 9)
        Me.cbItemDetallesMateriales.Name = "cbItemDetallesMateriales"
        Me.cbItemDetallesMateriales.Size = New System.Drawing.Size(170, 21)
        Me.cbItemDetallesMateriales.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "(*) Items:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(721, 63)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(125, 20)
        Me.txtTotal.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(613, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Total por materiales:"
        '
        'GrpDuracion
        '
        Me.GrpDuracion.Controls.Add(Me.Label26)
        Me.GrpDuracion.Controls.Add(Me.NudDuracionHorasMaterial)
        Me.GrpDuracion.Controls.Add(Me.Label25)
        Me.GrpDuracion.Controls.Add(Me.NudDuracionDiasMaterial)
        Me.GrpDuracion.Location = New System.Drawing.Point(16, 43)
        Me.GrpDuracion.Name = "GrpDuracion"
        Me.GrpDuracion.Size = New System.Drawing.Size(229, 53)
        Me.GrpDuracion.TabIndex = 58
        Me.GrpDuracion.TabStop = False
        Me.GrpDuracion.Text = "Duración"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(169, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 13)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "Horas"
        '
        'NudDuracionHorasMaterial
        '
        Me.NudDuracionHorasMaterial.Location = New System.Drawing.Point(108, 24)
        Me.NudDuracionHorasMaterial.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudDuracionHorasMaterial.Name = "NudDuracionHorasMaterial"
        Me.NudDuracionHorasMaterial.Size = New System.Drawing.Size(56, 20)
        Me.NudDuracionHorasMaterial.TabIndex = 56
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(73, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 13)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Días"
        '
        'NudDuracionDiasMaterial
        '
        Me.NudDuracionDiasMaterial.Location = New System.Drawing.Point(12, 24)
        Me.NudDuracionDiasMaterial.Name = "NudDuracionDiasMaterial"
        Me.NudDuracionDiasMaterial.Size = New System.Drawing.Size(56, 20)
        Me.NudDuracionDiasMaterial.TabIndex = 54
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(318, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 13)
        Me.Label27.TabIndex = 57
        Me.Label27.Text = "Descuento (%)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NudDescuento
        '
        Me.NudDescuento.Location = New System.Drawing.Point(258, 67)
        Me.NudDescuento.Name = "NudDescuento"
        Me.NudDescuento.Size = New System.Drawing.Size(56, 20)
        Me.NudDescuento.TabIndex = 56
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBorrar.Location = New System.Drawing.Point(779, 8)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(67, 23)
        Me.btnBorrar.TabIndex = 55
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(706, 8)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(67, 23)
        Me.btnAgregar.TabIndex = 54
        Me.btnAgregar.Text = "&Añadir"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnExamMaterial
        '
        Me.btnExamMaterial.Location = New System.Drawing.Point(462, 9)
        Me.btnExamMaterial.Name = "btnExamMaterial"
        Me.btnExamMaterial.Size = New System.Drawing.Size(67, 23)
        Me.btnExamMaterial.TabIndex = 46
        Me.btnExamMaterial.Text = "Examinar"
        Me.btnExamMaterial.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(616, 10)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(84, 20)
        Me.txtCantidad.TabIndex = 48
        '
        'lbMat
        '
        Me.lbMat.AutoSize = True
        Me.lbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMat.Location = New System.Drawing.Point(535, 13)
        Me.lbMat.Name = "lbMat"
        Me.lbMat.Size = New System.Drawing.Size(75, 15)
        Me.lbMat.TabIndex = 47
        Me.lbMat.Text = "(*) Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "(*) Material:"
        '
        'txtMaterial
        '
        Me.txtMaterial.Enabled = False
        Me.txtMaterial.Location = New System.Drawing.Point(329, 10)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(127, 20)
        Me.txtMaterial.TabIndex = 45
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'ModifCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 499)
        Me.Controls.Add(Me.TabCotizaciones)
        Me.Controls.Add(Me.PnlBotones)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ModifCotizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifCotizaciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlBotones.ResumeLayout(False)
        Me.TabCotizaciones.ResumeLayout(False)
        Me.TbgGeneral.ResumeLayout(False)
        Me.TbgGeneral.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nudDuracionHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDuracionDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpgObreros.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlControlesObreros.ResumeLayout(False)
        Me.PnlControlesObreros.PerformLayout()
        Me.TpgMateriales.ResumeLayout(False)
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlControlesMateriales.ResumeLayout(False)
        Me.PnlControlesMateriales.PerformLayout()
        Me.GrpDuracion.ResumeLayout(False)
        Me.GrpDuracion.PerformLayout()
        CType(Me.NudDuracionHorasMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDuracionDiasMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlBotones As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TabCotizaciones As TabControl
    Friend WithEvents TbgGeneral As TabPage
    Friend WithEvents nudDuracionHoras As NumericUpDown
    Friend WithEvents NudDuracionDias As NumericUpDown
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpHoras As DateTimePicker
    Friend WithEvents dtpFechaCotizacion As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TpgObreros As TabPage
    Friend WithEvents PnlControlesObreros As Panel
    Friend WithEvents cboCargos As ComboBox
    Friend WithEvents btnElimEmpleados As Button
    Friend WithEvents btnAddPersonal As Button
    Friend WithEvents txtCantEmpleados As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents TpgMateriales As TabPage
    Friend WithEvents PnlControlesMateriales As Panel
    Friend WithEvents GrpDuracion As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents NudDuracionHorasMaterial As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents NudDuracionDiasMaterial As NumericUpDown
    Friend WithEvents Label27 As Label
    Friend WithEvents NudDescuento As NumericUpDown
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnExamMaterial As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lbMat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents dgvMateriales As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents errorProvider As ErrorProvider
    Friend WithEvents cbItemDetallesPersonal As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbItemDetallesMateriales As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ItemCodigo As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents CargoPersonalCol As DataGridViewTextBoxColumn
    Friend WithEvents CantidadPersonalCol As DataGridViewTextBoxColumn
    Friend WithEvents ValorPersonalCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodigo_ As DataGridViewTextBoxColumn
    Friend WithEvents ItemMat As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents NombreMaterial As DataGridViewTextBoxColumn
    Friend WithEvents EsAlquilerCol As DataGridViewCheckBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnit As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDiasCol As DataGridViewTextBoxColumn
    Friend WithEvents MaterialHorasCol As DataGridViewTextBoxColumn
    Friend WithEvents PrecioAlquilerDiaCol As DataGridViewTextBoxColumn
    Friend WithEvents PrecioAlquilerHoraCol As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoCol As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTot As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents chkServicioExterno As CheckBox
    Friend WithEvents chkMaterial As CheckBox
    Friend WithEvents chkRRHH As CheckBox
End Class
