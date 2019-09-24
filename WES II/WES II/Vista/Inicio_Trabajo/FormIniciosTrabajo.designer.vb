<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIniciosTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIniciosTrabajo))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpBuscarDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnAddMaterial = New System.Windows.Forms.Button()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDiasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialHorasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnElimMateriales = New System.Windows.Forms.Button()
        Me.dgvOrdenTrabajo = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnExamMaterial = New System.Windows.Forms.Button()
        Me.txtCantMateriales = New System.Windows.Forms.TextBox()
        Me.lbMat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnElimEmpleados = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminarOSE = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpBuscarHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetallesMateriales = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLimpiarConsulta = New System.Windows.Forms.Button()
        Me.cbTipoOTConsulta = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnExamCliente = New System.Windows.Forms.Button()
        Me.txtClienteBusqueda = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.dgvListarEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbTipoOrden = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.NudDuracionDiasMaterial = New System.Windows.Forms.NumericUpDown()
        Me.NudDuracionHorasMaterial = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalMateriales = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.NudDuracionDiasPersonal = New System.Windows.Forms.NumericUpDown()
        Me.NudDuracionHorasPersonal = New System.Windows.Forms.NumericUpDown()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalDiasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalHorasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboCargos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCantEmpleados = New System.Windows.Forms.TextBox()
        Me.btnAddPersonal = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnAgregarOSE = New System.Windows.Forms.Button()
        Me.dgvOrdenesServicio = New System.Windows.Forms.DataGridView()
        Me.CodigoOSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleOSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadOSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitOSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalOSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNroOSE = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnExaminarOSE = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcionDetalleItem = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcionCoti = New System.Windows.Forms.TextBox()
        Me.cbCotizacionDetalleItem = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCotizacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnExamCotizacion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarItemOT = New System.Windows.Forms.Button()
        Me.txtDescripcionOT = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnGuardarItemOT = New System.Windows.Forms.Button()
        Me.txtTituloOT = New System.Windows.Forms.TextBox()
        Me.btnNuevoItemOT = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbOrdenTrabajoItem = New System.Windows.Forms.ComboBox()
        Me.txtCodigoOT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelarNuevoItemOT = New System.Windows.Forms.Button()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrdenTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetallesMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.NudDuracionDiasMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDuracionHorasMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.NudDuracionDiasPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDuracionHorasPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvOrdenesServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Hasta:"
        '
        'dtpBuscarDesde
        '
        Me.dtpBuscarDesde.Location = New System.Drawing.Point(71, 42)
        Me.dtpBuscarDesde.Name = "dtpBuscarDesde"
        Me.dtpBuscarDesde.Size = New System.Drawing.Size(194, 20)
        Me.dtpBuscarDesde.TabIndex = 16
        '
        'btnAddMaterial
        '
        Me.btnAddMaterial.Location = New System.Drawing.Point(507, 17)
        Me.btnAddMaterial.Name = "btnAddMaterial"
        Me.btnAddMaterial.Size = New System.Drawing.Size(80, 22)
        Me.btnAddMaterial.TabIndex = 25
        Me.btnAddMaterial.Text = "&Añadir"
        Me.btnAddMaterial.UseVisualStyleBackColor = True
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AllowUserToAddRows = False
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreMaterial, Me.Cantidad, Me.PrecioUnit, Me.MaterialDiasCol, Me.MaterialHorasCol, Me.PrecioTot})
        Me.dgvMateriales.Location = New System.Drawing.Point(21, 80)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(907, 126)
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
        'PrecioUnit
        '
        Me.PrecioUnit.HeaderText = "Precio unitario"
        Me.PrecioUnit.Name = "PrecioUnit"
        Me.PrecioUnit.ReadOnly = True
        '
        'MaterialDiasCol
        '
        Me.MaterialDiasCol.HeaderText = "Días"
        Me.MaterialDiasCol.Name = "MaterialDiasCol"
        Me.MaterialDiasCol.ReadOnly = True
        '
        'MaterialHorasCol
        '
        Me.MaterialHorasCol.HeaderText = "Horas"
        Me.MaterialHorasCol.Name = "MaterialHorasCol"
        Me.MaterialHorasCol.ReadOnly = True
        '
        'PrecioTot
        '
        Me.PrecioTot.HeaderText = "Precio total"
        Me.PrecioTot.Name = "PrecioTot"
        Me.PrecioTot.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Desde:"
        '
        'btnElimMateriales
        '
        Me.btnElimMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnElimMateriales.Location = New System.Drawing.Point(593, 17)
        Me.btnElimMateriales.Name = "btnElimMateriales"
        Me.btnElimMateriales.Size = New System.Drawing.Size(80, 22)
        Me.btnElimMateriales.TabIndex = 26
        Me.btnElimMateriales.Text = "Eliminar"
        Me.btnElimMateriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnElimMateriales, "Eliminar el detalle seleccionado")
        Me.btnElimMateriales.UseVisualStyleBackColor = True
        '
        'dgvOrdenTrabajo
        '
        Me.dgvOrdenTrabajo.AllowUserToAddRows = False
        Me.dgvOrdenTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOrdenTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenTrabajo.Location = New System.Drawing.Point(22, 102)
        Me.dgvOrdenTrabajo.Name = "dgvOrdenTrabajo"
        Me.dgvOrdenTrabajo.ReadOnly = True
        Me.dgvOrdenTrabajo.Size = New System.Drawing.Size(1100, 163)
        Me.dgvOrdenTrabajo.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(19, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Listado de Ordenes Trabajo:"
        '
        'btnExamMaterial
        '
        Me.btnExamMaterial.Location = New System.Drawing.Point(278, 17)
        Me.btnExamMaterial.Name = "btnExamMaterial"
        Me.btnExamMaterial.Size = New System.Drawing.Size(67, 22)
        Me.btnExamMaterial.TabIndex = 17
        Me.btnExamMaterial.Text = "Examinar"
        Me.btnExamMaterial.UseVisualStyleBackColor = True
        '
        'txtCantMateriales
        '
        Me.txtCantMateriales.Location = New System.Drawing.Point(425, 18)
        Me.txtCantMateriales.Name = "txtCantMateriales"
        Me.txtCantMateriales.Size = New System.Drawing.Size(76, 20)
        Me.txtCantMateriales.TabIndex = 16
        '
        'lbMat
        '
        Me.lbMat.AutoSize = True
        Me.lbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMat.Location = New System.Drawing.Point(349, 20)
        Me.lbMat.Name = "lbMat"
        Me.lbMat.Size = New System.Drawing.Size(75, 15)
        Me.lbMat.TabIndex = 15
        Me.lbMat.Text = "(*) Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "(*) Material:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(376, 68)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(129, 20)
        Me.dtpFechaInicio.TabIndex = 13
        '
        'txtMaterial
        '
        Me.txtMaterial.Enabled = False
        Me.txtMaterial.Location = New System.Drawing.Point(93, 18)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(183, 20)
        Me.txtMaterial.TabIndex = 12
        '
        'btnElimEmpleados
        '
        Me.btnElimEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnElimEmpleados.Location = New System.Drawing.Point(769, 15)
        Me.btnElimEmpleados.Name = "btnElimEmpleados"
        Me.btnElimEmpleados.Size = New System.Drawing.Size(80, 22)
        Me.btnElimEmpleados.TabIndex = 41
        Me.btnElimEmpleados.Text = "Eliminar"
        Me.btnElimEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnElimEmpleados, "Eliminar el detalle seleccionado")
        Me.btnElimEmpleados.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(1002, 376)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
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
        Me.btnGuardar.Location = New System.Drawing.Point(1002, 323)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnGuardar, "Guardar la orden de compra")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminarOSE
        '
        Me.btnEliminarOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarOSE.Location = New System.Drawing.Point(453, 18)
        Me.btnEliminarOSE.Name = "btnEliminarOSE"
        Me.btnEliminarOSE.Size = New System.Drawing.Size(80, 22)
        Me.btnEliminarOSE.TabIndex = 43
        Me.btnEliminarOSE.Text = "Eliminar"
        Me.btnEliminarOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnEliminarOSE, "Eliminar el detalle seleccionado")
        Me.btnEliminarOSE.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'dtpBuscarHasta
        '
        Me.dtpBuscarHasta.Location = New System.Drawing.Point(315, 42)
        Me.dtpBuscarHasta.Name = "dtpBuscarHasta"
        Me.dtpBuscarHasta.Size = New System.Drawing.Size(194, 20)
        Me.dtpBuscarHasta.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Inicio:"
        '
        'dgvDetallesMateriales
        '
        Me.dgvDetallesMateriales.AllowUserToAddRows = False
        Me.dgvDetallesMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetallesMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallesMateriales.Location = New System.Drawing.Point(22, 289)
        Me.dgvDetallesMateriales.Name = "dgvDetallesMateriales"
        Me.dgvDetallesMateriales.ReadOnly = True
        Me.dgvDetallesMateriales.Size = New System.Drawing.Size(540, 230)
        Me.dgvDetallesMateriales.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnLimpiarConsulta)
        Me.TabPage2.Controls.Add(Me.cbTipoOTConsulta)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.btnExamCliente)
        Me.TabPage2.Controls.Add(Me.txtClienteBusqueda)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cbEstado)
        Me.TabPage2.Controls.Add(Me.dgvListarEmpleados)
        Me.TabPage2.Controls.Add(Me.dgvDetallesMateriales)
        Me.TabPage2.Controls.Add(Me.btnListar)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.dtpBuscarHasta)
        Me.TabPage2.Controls.Add(Me.dtpBuscarDesde)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.dgvOrdenTrabajo)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1144, 543)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Orden Trabajo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnLimpiarConsulta
        '
        Me.btnLimpiarConsulta.Location = New System.Drawing.Point(871, 40)
        Me.btnLimpiarConsulta.Name = "btnLimpiarConsulta"
        Me.btnLimpiarConsulta.Size = New System.Drawing.Size(80, 22)
        Me.btnLimpiarConsulta.TabIndex = 59
        Me.btnLimpiarConsulta.Text = "Limpiar"
        Me.btnLimpiarConsulta.UseVisualStyleBackColor = True
        '
        'cbTipoOTConsulta
        '
        Me.cbTipoOTConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoOTConsulta.FormattingEnabled = True
        Me.cbTipoOTConsulta.Location = New System.Drawing.Point(572, 75)
        Me.cbTipoOTConsulta.Name = "cbTipoOTConsulta"
        Me.cbTipoOTConsulta.Size = New System.Drawing.Size(125, 21)
        Me.cbTipoOTConsulta.TabIndex = 58
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(450, 77)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(116, 15)
        Me.Label34.TabIndex = 57
        Me.Label34.Text = "Tipo Orden Trabajo:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(585, 270)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(124, 15)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "Detalles de Personal:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 270)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 15)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Detalles de Material:"
        '
        'btnExamCliente
        '
        Me.btnExamCliente.Location = New System.Drawing.Point(271, 73)
        Me.btnExamCliente.Name = "btnExamCliente"
        Me.btnExamCliente.Size = New System.Drawing.Size(83, 23)
        Me.btnExamCliente.TabIndex = 54
        Me.btnExamCliente.Text = "Examinar"
        Me.btnExamCliente.UseVisualStyleBackColor = True
        '
        'txtClienteBusqueda
        '
        Me.txtClienteBusqueda.Enabled = False
        Me.txtClienteBusqueda.Location = New System.Drawing.Point(86, 75)
        Me.txtClienteBusqueda.Name = "txtClienteBusqueda"
        Me.txtClienteBusqueda.ReadOnly = True
        Me.txtClienteBusqueda.Size = New System.Drawing.Size(179, 20)
        Me.txtClienteBusqueda.TabIndex = 53
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(19, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 15)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "(*) Cliente:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(522, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 15)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(572, 41)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(186, 21)
        Me.cbEstado.TabIndex = 50
        '
        'dgvListarEmpleados
        '
        Me.dgvListarEmpleados.AllowUserToAddRows = False
        Me.dgvListarEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarEmpleados.Location = New System.Drawing.Point(582, 289)
        Me.dgvListarEmpleados.Name = "dgvListarEmpleados"
        Me.dgvListarEmpleados.ReadOnly = True
        Me.dgvListarEmpleados.Size = New System.Drawing.Size(540, 230)
        Me.dgvListarEmpleados.TabIndex = 22
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(776, 40)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(80, 22)
        Me.btnListar.TabIndex = 20
        Me.btnListar.Text = "Buscar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(90, 56)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(190, 20)
        Me.txtCliente.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cliente:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbTipoOrden)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtEstado)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1144, 543)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Orden Trabajo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbTipoOrden
        '
        Me.cbTipoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoOrden.FormattingEnabled = True
        Me.cbTipoOrden.Location = New System.Drawing.Point(172, 11)
        Me.cbTipoOrden.Name = "cbTipoOrden"
        Me.cbTipoOrden.Size = New System.Drawing.Size(125, 21)
        Me.cbTipoOrden.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(19, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 15)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "(*) Tipo Orden Trabajo:"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(390, 12)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(192, 20)
        Me.txtEstado.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(308, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 15)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Estado:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(14, 301)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(960, 238)
        Me.TabControl2.TabIndex = 47
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.NudDuracionDiasMaterial)
        Me.TabPage3.Controls.Add(Me.NudDuracionHorasMaterial)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.dgvMateriales)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtTotalMateriales)
        Me.TabPage3.Controls.Add(Me.lbMat)
        Me.TabPage3.Controls.Add(Me.txtMaterial)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.txtCantMateriales)
        Me.TabPage3.Controls.Add(Me.btnExamMaterial)
        Me.TabPage3.Controls.Add(Me.btnAddMaterial)
        Me.TabPage3.Controls.Add(Me.btnElimMateriales)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(952, 212)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Materiales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(231, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "Horas"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(34, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 13)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "Duración:"
        '
        'NudDuracionDiasMaterial
        '
        Me.NudDuracionDiasMaterial.Location = New System.Drawing.Point(93, 44)
        Me.NudDuracionDiasMaterial.Name = "NudDuracionDiasMaterial"
        Me.NudDuracionDiasMaterial.Size = New System.Drawing.Size(44, 20)
        Me.NudDuracionDiasMaterial.TabIndex = 48
        '
        'NudDuracionHorasMaterial
        '
        Me.NudDuracionHorasMaterial.Location = New System.Drawing.Point(186, 44)
        Me.NudDuracionHorasMaterial.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudDuracionHorasMaterial.Name = "NudDuracionHorasMaterial"
        Me.NudDuracionHorasMaterial.Size = New System.Drawing.Size(42, 20)
        Me.NudDuracionHorasMaterial.TabIndex = 50
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(140, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 13)
        Me.Label30.TabIndex = 49
        Me.Label30.Text = "Días"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(739, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Total Materiales:"
        '
        'txtTotalMateriales
        '
        Me.txtTotalMateriales.Enabled = False
        Me.txtTotalMateriales.Location = New System.Drawing.Point(828, 41)
        Me.txtTotalMateriales.Name = "txtTotalMateriales"
        Me.txtTotalMateriales.ReadOnly = True
        Me.txtTotalMateriales.Size = New System.Drawing.Size(102, 20)
        Me.txtTotalMateriales.TabIndex = 46
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Controls.Add(Me.Label32)
        Me.TabPage4.Controls.Add(Me.NudDuracionDiasPersonal)
        Me.TabPage4.Controls.Add(Me.NudDuracionHorasPersonal)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.dgvEmpleados)
        Me.TabPage4.Controls.Add(Me.cboCargos)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.btnElimEmpleados)
        Me.TabPage4.Controls.Add(Me.txtCantEmpleados)
        Me.TabPage4.Controls.Add(Me.btnAddPersonal)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(952, 212)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Personal"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(463, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 13)
        Me.Label31.TabIndex = 56
        Me.Label31.Text = "Horas"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(281, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(53, 13)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Duración:"
        '
        'NudDuracionDiasPersonal
        '
        Me.NudDuracionDiasPersonal.Location = New System.Drawing.Point(337, 19)
        Me.NudDuracionDiasPersonal.Name = "NudDuracionDiasPersonal"
        Me.NudDuracionDiasPersonal.Size = New System.Drawing.Size(44, 20)
        Me.NudDuracionDiasPersonal.TabIndex = 53
        '
        'NudDuracionHorasPersonal
        '
        Me.NudDuracionHorasPersonal.Location = New System.Drawing.Point(418, 19)
        Me.NudDuracionHorasPersonal.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudDuracionHorasPersonal.Name = "NudDuracionHorasPersonal"
        Me.NudDuracionHorasPersonal.Size = New System.Drawing.Size(42, 20)
        Me.NudDuracionHorasPersonal.TabIndex = 55
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(385, 22)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 13)
        Me.Label33.TabIndex = 54
        Me.Label33.Text = "Días"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cargo, Me.PersonalDiasCol, Me.PersonalHorasCol, Me.CantidadPersonal})
        Me.dgvEmpleados.Location = New System.Drawing.Point(23, 53)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(659, 143)
        Me.dgvEmpleados.TabIndex = 39
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'PersonalDiasCol
        '
        Me.PersonalDiasCol.HeaderText = "Días"
        Me.PersonalDiasCol.Name = "PersonalDiasCol"
        Me.PersonalDiasCol.ReadOnly = True
        '
        'PersonalHorasCol
        '
        Me.PersonalHorasCol.HeaderText = "Hora"
        Me.PersonalHorasCol.Name = "PersonalHorasCol"
        Me.PersonalHorasCol.ReadOnly = True
        '
        'CantidadPersonal
        '
        Me.CantidadPersonal.HeaderText = "Cantidad"
        Me.CantidadPersonal.Name = "CantidadPersonal"
        Me.CantidadPersonal.ReadOnly = True
        '
        'cboCargos
        '
        Me.cboCargos.FormattingEnabled = True
        Me.cboCargos.Items.AddRange(New Object() {"Soldador", "Pintor"})
        Me.cboCargos.Location = New System.Drawing.Point(90, 17)
        Me.cboCargos.Name = "cboCargos"
        Me.cboCargos.Size = New System.Drawing.Size(186, 21)
        Me.cboCargos.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 15)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "(*) RR.HH.:"
        '
        'txtCantEmpleados
        '
        Me.txtCantEmpleados.Location = New System.Drawing.Point(598, 17)
        Me.txtCantEmpleados.Name = "txtCantEmpleados"
        Me.txtCantEmpleados.Size = New System.Drawing.Size(84, 20)
        Me.txtCantEmpleados.TabIndex = 37
        '
        'btnAddPersonal
        '
        Me.btnAddPersonal.Location = New System.Drawing.Point(686, 15)
        Me.btnAddPersonal.Name = "btnAddPersonal"
        Me.btnAddPersonal.Size = New System.Drawing.Size(80, 22)
        Me.btnAddPersonal.TabIndex = 40
        Me.btnAddPersonal.Text = "&Añadir"
        Me.btnAddPersonal.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(520, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 15)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "(*) Cantidad:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnEliminarOSE)
        Me.TabPage5.Controls.Add(Me.btnAgregarOSE)
        Me.TabPage5.Controls.Add(Me.dgvOrdenesServicio)
        Me.TabPage5.Controls.Add(Me.txtNroOSE)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.btnExaminarOSE)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(952, 212)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Servicio Externo"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnAgregarOSE
        '
        Me.btnAgregarOSE.Location = New System.Drawing.Point(367, 18)
        Me.btnAgregarOSE.Name = "btnAgregarOSE"
        Me.btnAgregarOSE.Size = New System.Drawing.Size(80, 22)
        Me.btnAgregarOSE.TabIndex = 42
        Me.btnAgregarOSE.Text = "&Añadir"
        Me.btnAgregarOSE.UseVisualStyleBackColor = True
        '
        'dgvOrdenesServicio
        '
        Me.dgvOrdenesServicio.AllowUserToAddRows = False
        Me.dgvOrdenesServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrdenesServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenesServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoOSE, Me.DetalleOSE, Me.CantidadOSE, Me.PrecioUnitOSE, Me.TotalOSE})
        Me.dgvOrdenesServicio.Location = New System.Drawing.Point(23, 56)
        Me.dgvOrdenesServicio.Name = "dgvOrdenesServicio"
        Me.dgvOrdenesServicio.ReadOnly = True
        Me.dgvOrdenesServicio.Size = New System.Drawing.Size(849, 140)
        Me.dgvOrdenesServicio.TabIndex = 40
        '
        'CodigoOSE
        '
        Me.CodigoOSE.HeaderText = "Codigo Orden"
        Me.CodigoOSE.Name = "CodigoOSE"
        Me.CodigoOSE.ReadOnly = True
        '
        'DetalleOSE
        '
        Me.DetalleOSE.HeaderText = "Detalle"
        Me.DetalleOSE.Name = "DetalleOSE"
        Me.DetalleOSE.ReadOnly = True
        '
        'CantidadOSE
        '
        Me.CantidadOSE.HeaderText = "Cantidad"
        Me.CantidadOSE.Name = "CantidadOSE"
        Me.CantidadOSE.ReadOnly = True
        '
        'PrecioUnitOSE
        '
        Me.PrecioUnitOSE.HeaderText = "Precio Unit"
        Me.PrecioUnitOSE.Name = "PrecioUnitOSE"
        Me.PrecioUnitOSE.ReadOnly = True
        '
        'TotalOSE
        '
        Me.TotalOSE.HeaderText = "Total"
        Me.TotalOSE.Name = "TotalOSE"
        Me.TotalOSE.ReadOnly = True
        '
        'txtNroOSE
        '
        Me.txtNroOSE.Enabled = False
        Me.txtNroOSE.Location = New System.Drawing.Point(127, 18)
        Me.txtNroOSE.Name = "txtNroOSE"
        Me.txtNroOSE.Size = New System.Drawing.Size(149, 20)
        Me.txtNroOSE.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(18, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 15)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "(*) Orden Servicio:"
        '
        'btnExaminarOSE
        '
        Me.btnExaminarOSE.Location = New System.Drawing.Point(279, 17)
        Me.btnExaminarOSE.Name = "btnExaminarOSE"
        Me.btnExaminarOSE.Size = New System.Drawing.Size(67, 22)
        Me.btnExaminarOSE.TabIndex = 20
        Me.btnExaminarOSE.Text = "Examinar"
        Me.btnExaminarOSE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTitulo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionDetalleItem)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionCoti)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbCotizacionDetalleItem)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCotizacion)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnExamCotizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1120, 94)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotización"
        '
        'txtTitulo
        '
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Location = New System.Drawing.Point(640, 57)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(190, 20)
        Me.txtTitulo.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(572, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "(*) Título:"
        '
        'txtDescripcionDetalleItem
        '
        Me.txtDescripcionDetalleItem.Enabled = False
        Me.txtDescripcionDetalleItem.Location = New System.Drawing.Point(906, 20)
        Me.txtDescripcionDetalleItem.Multiline = True
        Me.txtDescripcionDetalleItem.Name = "txtDescripcionDetalleItem"
        Me.txtDescripcionDetalleItem.ReadOnly = True
        Me.txtDescripcionDetalleItem.Size = New System.Drawing.Size(192, 57)
        Me.txtDescripcionDetalleItem.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(294, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Descripción:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(836, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Descripción:"
        '
        'txtDescripcionCoti
        '
        Me.txtDescripcionCoti.Enabled = False
        Me.txtDescripcionCoti.Location = New System.Drawing.Point(376, 20)
        Me.txtDescripcionCoti.Multiline = True
        Me.txtDescripcionCoti.Name = "txtDescripcionCoti"
        Me.txtDescripcionCoti.ReadOnly = True
        Me.txtDescripcionCoti.Size = New System.Drawing.Size(192, 57)
        Me.txtDescripcionCoti.TabIndex = 55
        '
        'cbCotizacionDetalleItem
        '
        Me.cbCotizacionDetalleItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCotizacionDetalleItem.FormattingEnabled = True
        Me.cbCotizacionDetalleItem.Location = New System.Drawing.Point(640, 23)
        Me.cbCotizacionDetalleItem.Name = "cbCotizacionDetalleItem"
        Me.cbCotizacionDetalleItem.Size = New System.Drawing.Size(190, 21)
        Me.cbCotizacionDetalleItem.TabIndex = 49
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(572, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 15)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "(*) Item:"
        '
        'txtCotizacion
        '
        Me.txtCotizacion.Enabled = False
        Me.txtCotizacion.Location = New System.Drawing.Point(92, 26)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.ReadOnly = True
        Me.txtCotizacion.Size = New System.Drawing.Size(119, 20)
        Me.txtCotizacion.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "(*) Cotización:"
        '
        'btnExamCotizacion
        '
        Me.btnExamCotizacion.Location = New System.Drawing.Point(215, 25)
        Me.btnExamCotizacion.Name = "btnExamCotizacion"
        Me.btnExamCotizacion.Size = New System.Drawing.Size(67, 23)
        Me.btnExamCotizacion.TabIndex = 33
        Me.btnExamCotizacion.Text = "Examinar"
        Me.btnExamCotizacion.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelarNuevoItemOT)
        Me.GroupBox2.Controls.Add(Me.btnEliminarItemOT)
        Me.GroupBox2.Controls.Add(Me.txtDescripcionOT)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.btnGuardarItemOT)
        Me.GroupBox2.Controls.Add(Me.txtTituloOT)
        Me.GroupBox2.Controls.Add(Me.btnNuevoItemOT)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.cbOrdenTrabajoItem)
        Me.GroupBox2.Controls.Add(Me.txtCodigoOT)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1120, 155)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orden Trabajo"
        '
        'btnEliminarItemOT
        '
        Me.btnEliminarItemOT.Location = New System.Drawing.Point(250, 27)
        Me.btnEliminarItemOT.Name = "btnEliminarItemOT"
        Me.btnEliminarItemOT.Size = New System.Drawing.Size(110, 23)
        Me.btnEliminarItemOT.TabIndex = 59
        Me.btnEliminarItemOT.Text = "Eliminar Item OT"
        Me.btnEliminarItemOT.UseVisualStyleBackColor = True
        '
        'txtDescripcionOT
        '
        Me.txtDescripcionOT.Location = New System.Drawing.Point(602, 91)
        Me.txtDescripcionOT.MaxLength = 500
        Me.txtDescripcionOT.Multiline = True
        Me.txtDescripcionOT.Name = "txtDescripcionOT"
        Me.txtDescripcionOT.Size = New System.Drawing.Size(496, 46)
        Me.txtDescripcionOT.TabIndex = 58
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(517, 112)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(79, 13)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "(*) Descripción:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(517, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "(*) Título:"
        '
        'btnGuardarItemOT
        '
        Me.btnGuardarItemOT.Location = New System.Drawing.Point(129, 27)
        Me.btnGuardarItemOT.Name = "btnGuardarItemOT"
        Me.btnGuardarItemOT.Size = New System.Drawing.Size(110, 23)
        Me.btnGuardarItemOT.TabIndex = 57
        Me.btnGuardarItemOT.Text = "Guardar Item OT"
        Me.btnGuardarItemOT.UseVisualStyleBackColor = True
        '
        'txtTituloOT
        '
        Me.txtTituloOT.Location = New System.Drawing.Point(602, 65)
        Me.txtTituloOT.MaxLength = 150
        Me.txtTituloOT.Name = "txtTituloOT"
        Me.txtTituloOT.Size = New System.Drawing.Size(190, 20)
        Me.txtTituloOT.TabIndex = 57
        '
        'btnNuevoItemOT
        '
        Me.btnNuevoItemOT.Location = New System.Drawing.Point(13, 27)
        Me.btnNuevoItemOT.Name = "btnNuevoItemOT"
        Me.btnNuevoItemOT.Size = New System.Drawing.Size(110, 23)
        Me.btnNuevoItemOT.TabIndex = 56
        Me.btnNuevoItemOT.Text = "Nuevo Item OT"
        Me.btnNuevoItemOT.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 70)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 15)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "(*) OT:"
        '
        'cbOrdenTrabajoItem
        '
        Me.cbOrdenTrabajoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrdenTrabajoItem.FormattingEnabled = True
        Me.cbOrdenTrabajoItem.Location = New System.Drawing.Point(90, 67)
        Me.cbOrdenTrabajoItem.Name = "cbOrdenTrabajoItem"
        Me.cbOrdenTrabajoItem.Size = New System.Drawing.Size(190, 21)
        Me.cbOrdenTrabajoItem.TabIndex = 56
        '
        'txtCodigoOT
        '
        Me.txtCodigoOT.Enabled = False
        Me.txtCodigoOT.Location = New System.Drawing.Point(90, 102)
        Me.txtCodigoOT.Name = "txtCodigoOT"
        Me.txtCodigoOT.ReadOnly = True
        Me.txtCodigoOT.Size = New System.Drawing.Size(190, 20)
        Me.txtCodigoOT.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "(*) Código:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(296, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Fecha Fin:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(376, 105)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(129, 20)
        Me.dtpFechaFin.TabIndex = 30
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1152, 569)
        Me.TabControl1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1165, 75)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generación de Orden de trabajo "
        '
        'btnCancelarNuevoItemOT
        '
        Me.btnCancelarNuevoItemOT.Location = New System.Drawing.Point(366, 27)
        Me.btnCancelarNuevoItemOT.Name = "btnCancelarNuevoItemOT"
        Me.btnCancelarNuevoItemOT.Size = New System.Drawing.Size(110, 23)
        Me.btnCancelarNuevoItemOT.TabIndex = 60
        Me.btnCancelarNuevoItemOT.Text = "Cancelar Item OT"
        Me.btnCancelarNuevoItemOT.UseVisualStyleBackColor = True
        '
        'FormIniciosTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormIniciosTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Generacion OT"
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrdenTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetallesMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvListarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.NudDuracionDiasMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDuracionHorasMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.NudDuracionDiasPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDuracionHorasPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvOrdenesServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpBuscarDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAddMaterial As System.Windows.Forms.Button
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnElimMateriales As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents dgvOrdenTrabajo As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnExamMaterial As System.Windows.Forms.Button
    Friend WithEvents txtCantMateriales As System.Windows.Forms.TextBox
    Friend WithEvents lbMat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDetallesMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents dtpBuscarHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcionDetalleItem As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboCargos As System.Windows.Forms.ComboBox
    Friend WithEvents btnElimEmpleados As System.Windows.Forms.Button
    Friend WithEvents btnAddPersonal As System.Windows.Forms.Button
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents txtCantEmpleados As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnExamCotizacion As System.Windows.Forms.Button
    Friend WithEvents txtCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalMateriales As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgvListarEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cbCotizacionDetalleItem As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbTipoOrden As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txtDescripcionCoti As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents btnExamCliente As Button
    Friend WithEvents txtClienteBusqueda As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dgvOrdenesServicio As DataGridView
    Friend WithEvents txtNroOSE As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnExaminarOSE As Button
    Friend WithEvents btnEliminarOSE As Button
    Friend WithEvents btnAgregarOSE As Button
    Friend WithEvents CodigoOSE As DataGridViewTextBoxColumn
    Friend WithEvents DetalleOSE As DataGridViewTextBoxColumn
    Friend WithEvents CantidadOSE As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitOSE As DataGridViewTextBoxColumn
    Friend WithEvents TotalOSE As DataGridViewTextBoxColumn
    Friend WithEvents Label25 As Label
    Friend WithEvents cbOrdenTrabajoItem As ComboBox
    Friend WithEvents txtCodigoOT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btnGuardarItemOT As Button
    Friend WithEvents txtTituloOT As TextBox
    Friend WithEvents btnNuevoItemOT As Button
    Friend WithEvents txtDescripcionOT As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents btnEliminarItemOT As Button
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents NombreMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnit As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDiasCol As DataGridViewTextBoxColumn
    Friend WithEvents MaterialHorasCol As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTot As DataGridViewTextBoxColumn
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents NudDuracionDiasMaterial As NumericUpDown
    Friend WithEvents NudDuracionHorasMaterial As NumericUpDown
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents NudDuracionDiasPersonal As NumericUpDown
    Friend WithEvents NudDuracionHorasPersonal As NumericUpDown
    Friend WithEvents Label33 As Label
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents PersonalDiasCol As DataGridViewTextBoxColumn
    Friend WithEvents PersonalHorasCol As DataGridViewTextBoxColumn
    Friend WithEvents CantidadPersonal As DataGridViewTextBoxColumn
    Friend WithEvents cbTipoOTConsulta As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents btnLimpiarConsulta As Button
    Friend WithEvents btnCancelarNuevoItemOT As Button
End Class
