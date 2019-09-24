<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCotizaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCotizaciones))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvCotizaciones = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExamMaterial = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lbMat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaCotizacion = New System.Windows.Forms.DateTimePicker()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnElimEmpleados = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnBuscarDescripcion = New System.Windows.Forms.Button()
        Me.txtBuscarDescripcion = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnExamCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarItem = New System.Windows.Forms.Button()
        Me.btnNuevoItem = New System.Windows.Forms.Button()
        Me.cbDetallesCotizacion = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.nudDuracionHoras = New System.Windows.Forms.NumericUpDown()
        Me.NudDuracionDias = New System.Windows.Forms.NumericUpDown()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dtpHoras = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkServicioExterno = New System.Windows.Forms.CheckBox()
        Me.chkMaterial = New System.Windows.Forms.CheckBox()
        Me.chkRRHH = New System.Windows.Forms.CheckBox()
        Me.ChkAgregarDuracion = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionTrabajo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtTituloItem = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.NudDescuento = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.NudDuracionDiasMaterial = New System.Windows.Forms.NumericUpDown()
        Me.NudDuracionHorasMaterial = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboCargos = New System.Windows.Forms.ComboBox()
        Me.txtCantEmpleados = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnAddPersonal = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgArchivos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnDescargar = New System.Windows.Forms.Button()
        Me.btnExaminarDescarga = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtArchivoDescarga = New System.Windows.Forms.TextBox()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdArchivo = New System.Windows.Forms.TextBox()
        Me.txtprefijo = New System.Windows.Forms.TextBox()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.btnExaminarSubida = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtArchivoSubida = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btnCotizacionOSE = New System.Windows.Forms.Button()
        Me.txtCotizacionOSE = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.txtDetalleOSE = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTotalOSE = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtDirproveedor = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitarioOSE = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtCantidadOSE = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.dtpHastaBuscarSE = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesdeBuscarSE = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btnExamCotiBuscar = New System.Windows.Forms.Button()
        Me.txtCotizacionBuscarSE = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtProveedorBuscarSE = New System.Windows.Forms.TextBox()
        Me.btnExamProvBuscar = New System.Windows.Forms.Button()
        Me.txtRucBuscarSE = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dgvServiciosExternos = New System.Windows.Forms.DataGridView()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnAutorizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGrabarOSE = New System.Windows.Forms.Button()
        Me.btnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.btnBuscarSE = New System.Windows.Forms.Button()
        Me.btnModificarOSE = New System.Windows.Forms.Button()
        Me.btnEliminarOSE = New System.Windows.Forms.Button()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudDuracionHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDuracionDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.NudDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDuracionDiasMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDuracionHorasMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.dgvServiciosExternos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(787, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Hasta:"
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(576, 17)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(207, 20)
        Me.dtpInicio.TabIndex = 16
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(503, 36)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(66, 23)
        Me.btnAgregar.TabIndex = 35
        Me.btnAgregar.Text = "&Añadir"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AllowUserToAddRows = False
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreMaterial, Me.EsAlquilerCol, Me.Cantidad, Me.PrecioUnit, Me.MaterialDiasCol, Me.MaterialHorasCol, Me.PrecioAlquilerDiaCol, Me.PrecioAlquilerHoraCol, Me.DescuentoCol, Me.PrecioTot})
        Me.dgvMateriales.Location = New System.Drawing.Point(16, 66)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.Size = New System.Drawing.Size(1041, 128)
        Me.dgvMateriales.TabIndex = 36
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(527, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Desde:"
        '
        'dgvCotizaciones
        '
        Me.dgvCotizaciones.AllowUserToAddRows = False
        Me.dgvCotizaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCotizaciones.Location = New System.Drawing.Point(22, 45)
        Me.dgvCotizaciones.Name = "dgvCotizaciones"
        Me.dgvCotizaciones.ReadOnly = True
        Me.dgvCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCotizaciones.Size = New System.Drawing.Size(1114, 259)
        Me.dgvCotizaciones.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(25, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Listado de cotizaciones:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(166, 27)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(211, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Código de la cotización:"
        '
        'btnExamMaterial
        '
        Me.btnExamMaterial.Location = New System.Drawing.Point(256, 13)
        Me.btnExamMaterial.Name = "btnExamMaterial"
        Me.btnExamMaterial.Size = New System.Drawing.Size(67, 23)
        Me.btnExamMaterial.TabIndex = 27
        Me.btnExamMaterial.Text = "Examinar"
        Me.btnExamMaterial.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(410, 15)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(71, 20)
        Me.txtCantidad.TabIndex = 29
        '
        'lbMat
        '
        Me.lbMat.AutoSize = True
        Me.lbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMat.Location = New System.Drawing.Point(329, 17)
        Me.lbMat.Name = "lbMat"
        Me.lbMat.Size = New System.Drawing.Size(75, 15)
        Me.lbMat.TabIndex = 28
        Me.lbMat.Text = "(*) Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "(*) Material:"
        '
        'dtpFechaCotizacion
        '
        Me.dtpFechaCotizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCotizacion.Location = New System.Drawing.Point(433, 25)
        Me.dtpFechaCotizacion.Name = "dtpFechaCotizacion"
        Me.dtpFechaCotizacion.Size = New System.Drawing.Size(110, 20)
        Me.dtpFechaCotizacion.TabIndex = 6
        '
        'txtMaterial
        '
        Me.txtMaterial.Enabled = False
        Me.txtMaterial.Location = New System.Drawing.Point(84, 14)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(166, 20)
        Me.txtMaterial.TabIndex = 26
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBorrar.Location = New System.Drawing.Point(575, 37)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(82, 22)
        Me.btnBorrar.TabIndex = 37
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnBorrar, "Eliminar el detalle seleccionado")
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnElimEmpleados
        '
        Me.btnElimEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnElimEmpleados.Location = New System.Drawing.Point(494, 19)
        Me.btnElimEmpleados.Name = "btnElimEmpleados"
        Me.btnElimEmpleados.Size = New System.Drawing.Size(80, 22)
        Me.btnElimEmpleados.TabIndex = 24
        Me.btnElimEmpleados.Text = "Eliminar"
        Me.btnElimEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnElimEmpleados, "Eliminar el detalle seleccionado")
        Me.btnElimEmpleados.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(833, 17)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(194, 20)
        Me.dtpFin.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha:"
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(22, 363)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.Size = New System.Drawing.Size(1114, 177)
        Me.dgvDetalles.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnPDF)
        Me.TabPage2.Controls.Add(Me.btnAutorizar)
        Me.TabPage2.Controls.Add(Me.BtnBuscarDescripcion)
        Me.TabPage2.Controls.Add(Me.txtBuscarDescripcion)
        Me.TabPage2.Controls.Add(Me.dgvDetalles)
        Me.TabPage2.Controls.Add(Me.btnListar)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.dtpFin)
        Me.TabPage2.Controls.Add(Me.dtpInicio)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.dgvCotizaciones)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.btnEliminar)
        Me.TabPage2.Controls.Add(Me.btnModificar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1169, 564)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar cotizaciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnBuscarDescripcion
        '
        Me.BtnBuscarDescripcion.Location = New System.Drawing.Point(391, 15)
        Me.BtnBuscarDescripcion.Name = "BtnBuscarDescripcion"
        Me.BtnBuscarDescripcion.Size = New System.Drawing.Size(129, 23)
        Me.BtnBuscarDescripcion.TabIndex = 23
        Me.BtnBuscarDescripcion.Text = "Buscar por descripcion"
        Me.BtnBuscarDescripcion.UseVisualStyleBackColor = True
        '
        'txtBuscarDescripcion
        '
        Me.txtBuscarDescripcion.Location = New System.Drawing.Point(168, 17)
        Me.txtBuscarDescripcion.Name = "txtBuscarDescripcion"
        Me.txtBuscarDescripcion.Size = New System.Drawing.Size(219, 20)
        Me.txtBuscarDescripcion.TabIndex = 22
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(1029, 16)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(109, 23)
        Me.btnListar.TabIndex = 20
        Me.btnListar.Text = "Buscar por fecha"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnExamCliente
        '
        Me.btnExamCliente.Location = New System.Drawing.Point(286, 43)
        Me.btnExamCliente.Name = "btnExamCliente"
        Me.btnExamCliente.Size = New System.Drawing.Size(83, 23)
        Me.btnExamCliente.TabIndex = 4
        Me.btnExamCliente.Text = "Examinar"
        Me.btnExamCliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(102, 52)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(186, 20)
        Me.txtCliente.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "(*) Cliente:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.nudDuracionHoras)
        Me.TabPage1.Controls.Add(Me.NudDuracionDias)
        Me.TabPage1.Controls.Add(Me.txtDescripcion)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.dtpHoras)
        Me.TabPage1.Controls.Add(Me.dtpFechaCotizacion)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCliente)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1169, 564)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar cotización"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAgregarItem)
        Me.GroupBox4.Controls.Add(Me.btnNuevoItem)
        Me.GroupBox4.Controls.Add(Me.cbDetallesCotizacion)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 181)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1134, 50)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Listado de Detalles"
        '
        'btnAgregarItem
        '
        Me.btnAgregarItem.Location = New System.Drawing.Point(541, 17)
        Me.btnAgregarItem.Name = "btnAgregarItem"
        Me.btnAgregarItem.Size = New System.Drawing.Size(110, 23)
        Me.btnAgregarItem.TabIndex = 42
        Me.btnAgregarItem.Text = "Guardar Item"
        Me.btnAgregarItem.UseVisualStyleBackColor = True
        '
        'btnNuevoItem
        '
        Me.btnNuevoItem.Location = New System.Drawing.Point(425, 17)
        Me.btnNuevoItem.Name = "btnNuevoItem"
        Me.btnNuevoItem.Size = New System.Drawing.Size(110, 23)
        Me.btnNuevoItem.TabIndex = 45
        Me.btnNuevoItem.Text = "Nuevo Item"
        Me.btnNuevoItem.UseVisualStyleBackColor = True
        '
        'cbDetallesCotizacion
        '
        Me.cbDetallesCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDetallesCotizacion.Location = New System.Drawing.Point(94, 19)
        Me.cbDetallesCotizacion.Name = "cbDetallesCotizacion"
        Me.cbDetallesCotizacion.Size = New System.Drawing.Size(316, 21)
        Me.cbDetallesCotizacion.TabIndex = 20
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(20, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 15)
        Me.Label28.TabIndex = 19
        Me.Label28.Text = "Items:"
        '
        'nudDuracionHoras
        '
        Me.nudDuracionHoras.Location = New System.Drawing.Point(754, 76)
        Me.nudDuracionHoras.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDuracionHoras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDuracionHoras.Name = "nudDuracionHoras"
        Me.nudDuracionHoras.Size = New System.Drawing.Size(52, 20)
        Me.nudDuracionHoras.TabIndex = 14
        Me.nudDuracionHoras.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDuracionHoras.Visible = False
        '
        'NudDuracionDias
        '
        Me.NudDuracionDias.Location = New System.Drawing.Point(754, 23)
        Me.NudDuracionDias.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudDuracionDias.Name = "NudDuracionDias"
        Me.NudDuracionDias.Size = New System.Drawing.Size(52, 20)
        Me.NudDuracionDias.TabIndex = 9
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(26, 102)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(517, 59)
        Me.txtDescripcion.TabIndex = 17
        '
        'dtpHoras
        '
        Me.dtpHoras.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoras.Location = New System.Drawing.Point(754, 50)
        Me.dtpHoras.Name = "dtpHoras"
        Me.dtpHoras.Size = New System.Drawing.Size(121, 20)
        Me.dtpHoras.TabIndex = 12
        Me.dtpHoras.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(680, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Hora:"
        Me.Label9.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(813, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Horas"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(680, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Duración:"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(815, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Días"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(680, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Duración:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.ChkAgregarDuracion)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnAceptar)
        Me.GroupBox3.Controls.Add(Me.btnExamCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1134, 169)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Cotización"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkServicioExterno)
        Me.GroupBox6.Controls.Add(Me.chkMaterial)
        Me.GroupBox6.Controls.Add(Me.chkRRHH)
        Me.GroupBox6.Location = New System.Drawing.Point(541, 96)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(326, 59)
        Me.GroupBox6.TabIndex = 42
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
        'ChkAgregarDuracion
        '
        Me.ChkAgregarDuracion.AutoSize = True
        Me.ChkAgregarDuracion.Checked = True
        Me.ChkAgregarDuracion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAgregarDuracion.Location = New System.Drawing.Point(541, 21)
        Me.ChkAgregarDuracion.Name = "ChkAgregarDuracion"
        Me.ChkAgregarDuracion.Size = New System.Drawing.Size(109, 17)
        Me.ChkAgregarDuracion.TabIndex = 7
        Me.ChkAgregarDuracion.Text = "Agregar Duración"
        Me.ChkAgregarDuracion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Descripción del trabajo:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtDescripcionTrabajo)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.txtTituloItem)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.TabControl2)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 237)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1134, 323)
        Me.GroupBox5.TabIndex = 46
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle de Cotización"
        '
        'txtDescripcionTrabajo
        '
        Me.txtDescripcionTrabajo.Location = New System.Drawing.Point(541, 22)
        Me.txtDescripcionTrabajo.MaxLength = 600
        Me.txtDescripcionTrabajo.Multiline = True
        Me.txtDescripcionTrabajo.Name = "txtDescripcionTrabajo"
        Me.txtDescripcionTrabajo.Size = New System.Drawing.Size(563, 48)
        Me.txtDescripcionTrabajo.TabIndex = 40
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(417, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(118, 13)
        Me.Label30.TabIndex = 39
        Me.Label30.Text = "Descripción del trabajo:"
        '
        'txtTituloItem
        '
        Me.txtTituloItem.Location = New System.Drawing.Point(87, 18)
        Me.txtTituloItem.MaxLength = 250
        Me.txtTituloItem.Name = "txtTituloItem"
        Me.txtTituloItem.Size = New System.Drawing.Size(323, 20)
        Me.txtTituloItem.TabIndex = 38
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(20, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 13)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "Título Item:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(23, 67)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1085, 239)
        Me.TabControl2.TabIndex = 44
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvMateriales)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.btnBorrar)
        Me.TabPage4.Controls.Add(Me.btnAgregar)
        Me.TabPage4.Controls.Add(Me.NudDescuento)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.txtTotal)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.NudDuracionDiasMaterial)
        Me.TabPage4.Controls.Add(Me.NudDuracionHorasMaterial)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.lbMat)
        Me.TabPage4.Controls.Add(Me.txtMaterial)
        Me.TabPage4.Controls.Add(Me.btnExamMaterial)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.txtCantidad)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1077, 213)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Materiales"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(333, 44)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 13)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Descuento (%)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NudDescuento
        '
        Me.NudDescuento.Location = New System.Drawing.Point(410, 40)
        Me.NudDescuento.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NudDescuento.Name = "NudDescuento"
        Me.NudDescuento.Size = New System.Drawing.Size(71, 20)
        Me.NudDescuento.TabIndex = 42
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(662, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Total por materiales:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(770, 38)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(113, 20)
        Me.txtTotal.TabIndex = 39
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(210, 44)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 13)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Horas"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Duración:"
        '
        'NudDuracionDiasMaterial
        '
        Me.NudDuracionDiasMaterial.Location = New System.Drawing.Point(84, 40)
        Me.NudDuracionDiasMaterial.Name = "NudDuracionDiasMaterial"
        Me.NudDuracionDiasMaterial.Size = New System.Drawing.Size(44, 20)
        Me.NudDuracionDiasMaterial.TabIndex = 31
        '
        'NudDuracionHorasMaterial
        '
        Me.NudDuracionHorasMaterial.Location = New System.Drawing.Point(165, 40)
        Me.NudDuracionHorasMaterial.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudDuracionHorasMaterial.Name = "NudDuracionHorasMaterial"
        Me.NudDuracionHorasMaterial.Size = New System.Drawing.Size(42, 20)
        Me.NudDuracionHorasMaterial.TabIndex = 33
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(131, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 13)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Días"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgvEmpleados)
        Me.TabPage5.Controls.Add(Me.cboCargos)
        Me.TabPage5.Controls.Add(Me.btnElimEmpleados)
        Me.TabPage5.Controls.Add(Me.txtCantEmpleados)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.btnAddPersonal)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1077, 213)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Personal"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cargo, Me.Cantidad_, Me.Valor})
        Me.dgvEmpleados.Location = New System.Drawing.Point(15, 46)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(559, 148)
        Me.dgvEmpleados.TabIndex = 23
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'Cantidad_
        '
        Me.Cantidad_.HeaderText = "Cantidad"
        Me.Cantidad_.Name = "Cantidad_"
        Me.Cantidad_.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'cboCargos
        '
        Me.cboCargos.FormattingEnabled = True
        Me.cboCargos.Items.AddRange(New Object() {"Soldador", "Pintor"})
        Me.cboCargos.Location = New System.Drawing.Point(86, 19)
        Me.cboCargos.Name = "cboCargos"
        Me.cboCargos.Size = New System.Drawing.Size(162, 21)
        Me.cboCargos.TabIndex = 19
        '
        'txtCantEmpleados
        '
        Me.txtCantEmpleados.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtCantEmpleados.Location = New System.Drawing.Point(328, 20)
        Me.txtCantEmpleados.Name = "txtCantEmpleados"
        Me.txtCantEmpleados.Size = New System.Drawing.Size(82, 20)
        Me.txtCantEmpleados.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(250, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 15)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "(*) Cantidad:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 15)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "(*) RR.HH.:"
        '
        'btnAddPersonal
        '
        Me.btnAddPersonal.Location = New System.Drawing.Point(416, 18)
        Me.btnAddPersonal.Name = "btnAddPersonal"
        Me.btnAddPersonal.Size = New System.Drawing.Size(72, 23)
        Me.btnAddPersonal.TabIndex = 22
        Me.btnAddPersonal.Text = "&Añadir"
        Me.btnAddPersonal.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(0, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1177, 590)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgArchivos)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1169, 564)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gestión de archivos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgArchivos
        '
        Me.dgArchivos.AllowUserToAddRows = False
        Me.dgArchivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArchivos.Location = New System.Drawing.Point(25, 278)
        Me.dgArchivos.Name = "dgArchivos"
        Me.dgArchivos.ReadOnly = True
        Me.dgArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArchivos.Size = New System.Drawing.Size(748, 263)
        Me.dgArchivos.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.btnDescargar)
        Me.GroupBox2.Controls.Add(Me.btnExaminarDescarga)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtArchivoDescarga)
        Me.GroupBox2.Controls.Add(Me.txtRuta)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 109)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descarga Archivo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(535, 44)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "Archivo"
        '
        'btnDescargar
        '
        Me.btnDescargar.Location = New System.Drawing.Point(339, 66)
        Me.btnDescargar.Name = "btnDescargar"
        Me.btnDescargar.Size = New System.Drawing.Size(100, 23)
        Me.btnDescargar.TabIndex = 29
        Me.btnDescargar.Text = "Descargar"
        Me.btnDescargar.UseVisualStyleBackColor = True
        '
        'btnExaminarDescarga
        '
        Me.btnExaminarDescarga.Location = New System.Drawing.Point(338, 22)
        Me.btnExaminarDescarga.Name = "btnExaminarDescarga"
        Me.btnExaminarDescarga.Size = New System.Drawing.Size(101, 23)
        Me.btnExaminarDescarga.TabIndex = 7
        Me.btnExaminarDescarga.Text = "Examinar"
        Me.btnExaminarDescarga.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Ruta"
        '
        'txtArchivoDescarga
        '
        Me.txtArchivoDescarga.Location = New System.Drawing.Point(77, 65)
        Me.txtArchivoDescarga.Name = "txtArchivoDescarga"
        Me.txtArchivoDescarga.ReadOnly = True
        Me.txtArchivoDescarga.Size = New System.Drawing.Size(243, 20)
        Me.txtArchivoDescarga.TabIndex = 3
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(77, 24)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(243, 20)
        Me.txtRuta.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdArchivo)
        Me.GroupBox1.Controls.Add(Me.txtprefijo)
        Me.GroupBox1.Controls.Add(Me.btnSubir)
        Me.GroupBox1.Controls.Add(Me.btnExaminarSubida)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblFile)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtArchivoSubida)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 124)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subir Archivo"
        '
        'txtIdArchivo
        '
        Me.txtIdArchivo.Location = New System.Drawing.Point(560, 69)
        Me.txtIdArchivo.Name = "txtIdArchivo"
        Me.txtIdArchivo.ReadOnly = True
        Me.txtIdArchivo.Size = New System.Drawing.Size(50, 20)
        Me.txtIdArchivo.TabIndex = 29
        '
        'txtprefijo
        '
        Me.txtprefijo.Location = New System.Drawing.Point(528, 29)
        Me.txtprefijo.Name = "txtprefijo"
        Me.txtprefijo.ReadOnly = True
        Me.txtprefijo.Size = New System.Drawing.Size(82, 20)
        Me.txtprefijo.TabIndex = 29
        '
        'btnSubir
        '
        Me.btnSubir.Location = New System.Drawing.Point(338, 69)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(100, 23)
        Me.btnSubir.TabIndex = 28
        Me.btnSubir.Text = "Subir"
        Me.btnSubir.UseVisualStyleBackColor = True
        '
        'btnExaminarSubida
        '
        Me.btnExaminarSubida.Location = New System.Drawing.Point(337, 28)
        Me.btnExaminarSubida.Name = "btnExaminarSubida"
        Me.btnExaminarSubida.Size = New System.Drawing.Size(101, 23)
        Me.btnExaminarSubida.TabIndex = 4
        Me.btnExaminarSubida.Text = "Examinar"
        Me.btnExaminarSubida.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(482, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Cod. Archivo"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(120, 76)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(16, 13)
        Me.lblFile.TabIndex = 3
        Me.lblFile.Text = "..."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(482, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Cotiz."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(28, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Archivo Nombre:"
        '
        'txtArchivoSubida
        '
        Me.txtArchivoSubida.Location = New System.Drawing.Point(77, 30)
        Me.txtArchivoSubida.Name = "txtArchivoSubida"
        Me.txtArchivoSubida.Size = New System.Drawing.Size(243, 20)
        Me.txtArchivoSubida.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Archivo"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.TabControl3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1169, 564)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Servicios Externos"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Location = New System.Drawing.Point(23, 21)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(910, 510)
        Me.TabControl3.TabIndex = 27
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label39)
        Me.TabPage7.Controls.Add(Me.btnCotizacionOSE)
        Me.TabPage7.Controls.Add(Me.txtCotizacionOSE)
        Me.TabPage7.Controls.Add(Me.Label38)
        Me.TabPage7.Controls.Add(Me.Label31)
        Me.TabPage7.Controls.Add(Me.btnGrabarOSE)
        Me.TabPage7.Controls.Add(Me.txtProveedor)
        Me.TabPage7.Controls.Add(Me.btnBuscarProveedor)
        Me.TabPage7.Controls.Add(Me.txtDetalleOSE)
        Me.TabPage7.Controls.Add(Me.Label33)
        Me.TabPage7.Controls.Add(Me.txtTotalOSE)
        Me.TabPage7.Controls.Add(Me.txtRuc)
        Me.TabPage7.Controls.Add(Me.Label36)
        Me.TabPage7.Controls.Add(Me.txtDirproveedor)
        Me.TabPage7.Controls.Add(Me.txtPrecioUnitarioOSE)
        Me.TabPage7.Controls.Add(Me.Label35)
        Me.TabPage7.Controls.Add(Me.txtCantidadOSE)
        Me.TabPage7.Controls.Add(Me.Label34)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(902, 484)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Registrar Servicio Externo"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(21, 67)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(137, 15)
        Me.Label39.TabIndex = 29
        Me.Label39.Text = "(*) Dirección Proveedor:"
        '
        'btnCotizacionOSE
        '
        Me.btnCotizacionOSE.Location = New System.Drawing.Point(261, 95)
        Me.btnCotizacionOSE.Name = "btnCotizacionOSE"
        Me.btnCotizacionOSE.Size = New System.Drawing.Size(83, 23)
        Me.btnCotizacionOSE.TabIndex = 28
        Me.btnCotizacionOSE.Text = "Examinar"
        Me.btnCotizacionOSE.UseVisualStyleBackColor = True
        '
        'txtCotizacionOSE
        '
        Me.txtCotizacionOSE.Enabled = False
        Me.txtCotizacionOSE.Location = New System.Drawing.Point(109, 98)
        Me.txtCotizacionOSE.Name = "txtCotizacionOSE"
        Me.txtCotizacionOSE.ReadOnly = True
        Me.txtCotizacionOSE.Size = New System.Drawing.Size(138, 20)
        Me.txtCotizacionOSE.TabIndex = 27
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(21, 100)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(83, 15)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "(*) Cotización:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(21, 30)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 15)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "(*) Proveedor:"
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(109, 30)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(138, 20)
        Me.txtProveedor.TabIndex = 6
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(350, 30)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(83, 23)
        Me.btnBuscarProveedor.TabIndex = 7
        Me.btnBuscarProveedor.Text = "Examinar"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'txtDetalleOSE
        '
        Me.txtDetalleOSE.Location = New System.Drawing.Point(109, 136)
        Me.txtDetalleOSE.MaxLength = 600
        Me.txtDetalleOSE.Multiline = True
        Me.txtDetalleOSE.Name = "txtDetalleOSE"
        Me.txtDetalleOSE.Size = New System.Drawing.Size(583, 108)
        Me.txtDetalleOSE.TabIndex = 13
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(21, 137)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 15)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "(*) Detalle:"
        '
        'txtTotalOSE
        '
        Me.txtTotalOSE.Enabled = False
        Me.txtTotalOSE.Location = New System.Drawing.Point(584, 101)
        Me.txtTotalOSE.Name = "txtTotalOSE"
        Me.txtTotalOSE.ReadOnly = True
        Me.txtTotalOSE.Size = New System.Drawing.Size(108, 20)
        Me.txtTotalOSE.TabIndex = 19
        '
        'txtRuc
        '
        Me.txtRuc.Enabled = False
        Me.txtRuc.Location = New System.Drawing.Point(253, 30)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(91, 20)
        Me.txtRuc.TabIndex = 8
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(526, 103)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 15)
        Me.Label36.TabIndex = 18
        Me.Label36.Text = "(*) Total:"
        '
        'txtDirproveedor
        '
        Me.txtDirproveedor.Enabled = False
        Me.txtDirproveedor.Location = New System.Drawing.Point(162, 64)
        Me.txtDirproveedor.Name = "txtDirproveedor"
        Me.txtDirproveedor.ReadOnly = True
        Me.txtDirproveedor.Size = New System.Drawing.Size(182, 20)
        Me.txtDirproveedor.TabIndex = 9
        '
        'txtPrecioUnitarioOSE
        '
        Me.txtPrecioUnitarioOSE.Location = New System.Drawing.Point(584, 65)
        Me.txtPrecioUnitarioOSE.Name = "txtPrecioUnitarioOSE"
        Me.txtPrecioUnitarioOSE.Size = New System.Drawing.Size(108, 20)
        Me.txtPrecioUnitarioOSE.TabIndex = 17
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(473, 67)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(107, 15)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "(*) Precio Unitario:"
        '
        'txtCantidadOSE
        '
        Me.txtCantidadOSE.Location = New System.Drawing.Point(584, 28)
        Me.txtCantidadOSE.Name = "txtCantidadOSE"
        Me.txtCantidadOSE.Size = New System.Drawing.Size(108, 20)
        Me.txtCantidadOSE.TabIndex = 15
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(505, 30)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(75, 15)
        Me.Label34.TabIndex = 14
        Me.Label34.Text = "(*) Cantidad:"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.btnLimpiarBusqueda)
        Me.TabPage8.Controls.Add(Me.btnBuscarSE)
        Me.TabPage8.Controls.Add(Me.Label41)
        Me.TabPage8.Controls.Add(Me.dtpHastaBuscarSE)
        Me.TabPage8.Controls.Add(Me.dtpDesdeBuscarSE)
        Me.TabPage8.Controls.Add(Me.Label42)
        Me.TabPage8.Controls.Add(Me.btnExamCotiBuscar)
        Me.TabPage8.Controls.Add(Me.txtCotizacionBuscarSE)
        Me.TabPage8.Controls.Add(Me.Label32)
        Me.TabPage8.Controls.Add(Me.Label40)
        Me.TabPage8.Controls.Add(Me.txtProveedorBuscarSE)
        Me.TabPage8.Controls.Add(Me.btnExamProvBuscar)
        Me.TabPage8.Controls.Add(Me.txtRucBuscarSE)
        Me.TabPage8.Controls.Add(Me.btnModificarOSE)
        Me.TabPage8.Controls.Add(Me.Label37)
        Me.TabPage8.Controls.Add(Me.dgvServiciosExternos)
        Me.TabPage8.Controls.Add(Me.btnEliminarOSE)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(902, 484)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Consultar Servicio Externo"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(439, 62)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(42, 15)
        Me.Label41.TabIndex = 39
        Me.Label41.Text = "Hasta:"
        '
        'dtpHastaBuscarSE
        '
        Me.dtpHastaBuscarSE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHastaBuscarSE.Location = New System.Drawing.Point(491, 59)
        Me.dtpHastaBuscarSE.Name = "dtpHastaBuscarSE"
        Me.dtpHastaBuscarSE.Size = New System.Drawing.Size(116, 20)
        Me.dtpHastaBuscarSE.TabIndex = 38
        '
        'dtpDesdeBuscarSE
        '
        Me.dtpDesdeBuscarSE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesdeBuscarSE.Location = New System.Drawing.Point(491, 25)
        Me.dtpDesdeBuscarSE.Name = "dtpDesdeBuscarSE"
        Me.dtpDesdeBuscarSE.Size = New System.Drawing.Size(116, 20)
        Me.dtpDesdeBuscarSE.TabIndex = 37
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(439, 25)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(46, 15)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = "Desde:"
        '
        'btnExamCotiBuscar
        '
        Me.btnExamCotiBuscar.Location = New System.Drawing.Point(253, 55)
        Me.btnExamCotiBuscar.Name = "btnExamCotiBuscar"
        Me.btnExamCotiBuscar.Size = New System.Drawing.Size(91, 23)
        Me.btnExamCotiBuscar.TabIndex = 35
        Me.btnExamCotiBuscar.Text = "Examinar"
        Me.btnExamCotiBuscar.UseVisualStyleBackColor = True
        '
        'txtCotizacionBuscarSE
        '
        Me.txtCotizacionBuscarSE.Enabled = False
        Me.txtCotizacionBuscarSE.Location = New System.Drawing.Point(111, 57)
        Me.txtCotizacionBuscarSE.Name = "txtCotizacionBuscarSE"
        Me.txtCotizacionBuscarSE.ReadOnly = True
        Me.txtCotizacionBuscarSE.Size = New System.Drawing.Size(138, 20)
        Me.txtCotizacionBuscarSE.TabIndex = 34
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(23, 59)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(83, 15)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "(*) Cotización:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(23, 22)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(82, 15)
        Me.Label40.TabIndex = 29
        Me.Label40.Text = "(*) Proveedor:"
        '
        'txtProveedorBuscarSE
        '
        Me.txtProveedorBuscarSE.Enabled = False
        Me.txtProveedorBuscarSE.Location = New System.Drawing.Point(111, 22)
        Me.txtProveedorBuscarSE.Name = "txtProveedorBuscarSE"
        Me.txtProveedorBuscarSE.ReadOnly = True
        Me.txtProveedorBuscarSE.Size = New System.Drawing.Size(138, 20)
        Me.txtProveedorBuscarSE.TabIndex = 30
        '
        'btnExamProvBuscar
        '
        Me.btnExamProvBuscar.Location = New System.Drawing.Point(350, 22)
        Me.btnExamProvBuscar.Name = "btnExamProvBuscar"
        Me.btnExamProvBuscar.Size = New System.Drawing.Size(83, 23)
        Me.btnExamProvBuscar.TabIndex = 31
        Me.btnExamProvBuscar.Text = "Examinar"
        Me.btnExamProvBuscar.UseVisualStyleBackColor = True
        '
        'txtRucBuscarSE
        '
        Me.txtRucBuscarSE.Enabled = False
        Me.txtRucBuscarSE.Location = New System.Drawing.Point(253, 22)
        Me.txtRucBuscarSE.Name = "txtRucBuscarSE"
        Me.txtRucBuscarSE.ReadOnly = True
        Me.txtRucBuscarSE.Size = New System.Drawing.Size(91, 20)
        Me.txtRucBuscarSE.TabIndex = 32
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(21, 103)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(167, 15)
        Me.Label37.TabIndex = 21
        Me.Label37.Text = "Listado de Servicios Externos"
        '
        'dgvServiciosExternos
        '
        Me.dgvServiciosExternos.AllowUserToAddRows = False
        Me.dgvServiciosExternos.AllowUserToDeleteRows = False
        Me.dgvServiciosExternos.AllowUserToOrderColumns = True
        Me.dgvServiciosExternos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvServiciosExternos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServiciosExternos.Location = New System.Drawing.Point(24, 130)
        Me.dgvServiciosExternos.Name = "dgvServiciosExternos"
        Me.dgvServiciosExternos.ReadOnly = True
        Me.dgvServiciosExternos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiciosExternos.Size = New System.Drawing.Size(856, 255)
        Me.dgvServiciosExternos.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1189, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cotizaciones"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(994, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 40
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnGuardar, "Guardar los datos de la cotización")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(994, 108)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 41
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPDF.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnPDF.Location = New System.Drawing.Point(464, 310)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(110, 47)
        Me.btnPDF.TabIndex = 25
        Me.btnPDF.Text = "PDF"
        Me.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnPDF, "Reporte PDF")
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'btnAutorizar
        '
        Me.btnAutorizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAutorizar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAutorizar.Location = New System.Drawing.Point(348, 310)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(110, 47)
        Me.btnAutorizar.TabIndex = 24
        Me.btnAutorizar.Text = "Autorizar"
        Me.btnAutorizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAutorizar, "Autorizar la orden de compra seleccionada")
        Me.btnAutorizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.Image = Global.WES_II.My.Resources.Resources.Cancel_32x32
        Me.btnEliminar.Location = New System.Drawing.Point(696, 310)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 47)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Cancelar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnEliminar, "Cancelar la orden de compra seleccionada")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificar.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnModificar.Location = New System.Drawing.Point(580, 310)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 47)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnModificar, "Modificar la orden de compra seleccionada")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGrabarOSE
        '
        Me.btnGrabarOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGrabarOSE.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGrabarOSE.Location = New System.Drawing.Point(324, 262)
        Me.btnGrabarOSE.Name = "btnGrabarOSE"
        Me.btnGrabarOSE.Size = New System.Drawing.Size(110, 47)
        Me.btnGrabarOSE.TabIndex = 25
        Me.btnGrabarOSE.Text = "Grabar"
        Me.btnGrabarOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnGrabarOSE, "Grabar Servicio Externo")
        Me.btnGrabarOSE.UseVisualStyleBackColor = True
        '
        'btnLimpiarBusqueda
        '
        Me.btnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLimpiarBusqueda.Image = Global.WES_II.My.Resources.Resources.eraser
        Me.btnLimpiarBusqueda.Location = New System.Drawing.Point(640, 22)
        Me.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda"
        Me.btnLimpiarBusqueda.Size = New System.Drawing.Size(110, 47)
        Me.btnLimpiarBusqueda.TabIndex = 41
        Me.btnLimpiarBusqueda.Text = "Limpiar"
        Me.btnLimpiarBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'btnBuscarSE
        '
        Me.btnBuscarSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscarSE.Image = Global.WES_II.My.Resources.Resources.Buscar_32x32
        Me.btnBuscarSE.Location = New System.Drawing.Point(770, 22)
        Me.btnBuscarSE.Name = "btnBuscarSE"
        Me.btnBuscarSE.Size = New System.Drawing.Size(110, 47)
        Me.btnBuscarSE.TabIndex = 40
        Me.btnBuscarSE.Text = "Buscar"
        Me.btnBuscarSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarSE.UseVisualStyleBackColor = True
        '
        'btnModificarOSE
        '
        Me.btnModificarOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificarOSE.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnModificarOSE.Location = New System.Drawing.Point(323, 406)
        Me.btnModificarOSE.Name = "btnModificarOSE"
        Me.btnModificarOSE.Size = New System.Drawing.Size(110, 47)
        Me.btnModificarOSE.TabIndex = 26
        Me.btnModificarOSE.Text = "Modificar"
        Me.btnModificarOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnModificarOSE, "Modificar Servicio Externo")
        Me.btnModificarOSE.UseVisualStyleBackColor = True
        '
        'btnEliminarOSE
        '
        Me.btnEliminarOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarOSE.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnEliminarOSE.Location = New System.Drawing.Point(470, 406)
        Me.btnEliminarOSE.Name = "btnEliminarOSE"
        Me.btnEliminarOSE.Size = New System.Drawing.Size(110, 47)
        Me.btnEliminarOSE.TabIndex = 26
        Me.btnEliminarOSE.Text = "Eliminar"
        Me.btnEliminarOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnEliminarOSE, "Eliminar Servicio Externo")
        Me.btnEliminarOSE.UseVisualStyleBackColor = True
        '
        'FormCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCotizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Cotizaciones"
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudDuracionHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDuracionDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.NudDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDuracionDiasMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDuracionHorasMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.dgvServiciosExternos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents dgvCotizaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExamMaterial As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbMat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCotizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExamCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nudDuracionHoras As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudDuracionDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpHoras As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminarSubida As System.Windows.Forms.Button
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtArchivoSubida As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtprefijo As System.Windows.Forms.TextBox
    Friend WithEvents btnSubir As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnDescargar As System.Windows.Forms.Button
    Friend WithEvents btnExaminarDescarga As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtArchivoDescarga As System.Windows.Forms.TextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dgArchivos As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscarDescripcion As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cboCargos As ComboBox
    Friend WithEvents btnElimEmpleados As Button
    Friend WithEvents btnAddPersonal As Button
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents txtCantEmpleados As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ChkAgregarDuracion As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents NudDuracionHorasMaterial As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents NudDuracionDiasMaterial As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents NudDescuento As NumericUpDown
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
    Friend WithEvents BtnBuscarDescripcion As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnAgregarItem As Button
    Friend WithEvents txtDescripcionTrabajo As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtTituloItem As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents cbDetallesCotizacion As ComboBox
    Friend WithEvents btnNuevoItem As Button
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_ As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents btnAutorizar As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents txtDirproveedor As TextBox
    Friend WithEvents txtTotalOSE As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtPrecioUnitarioOSE As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtCantidadOSE As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtDetalleOSE As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents btnEliminarOSE As Button
    Friend WithEvents btnGrabarOSE As Button
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents btnModificarOSE As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents btnCotizacionOSE As Button
    Friend WithEvents txtCotizacionOSE As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents dgvServiciosExternos As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents chkServicioExterno As CheckBox
    Friend WithEvents chkMaterial As CheckBox
    Friend WithEvents chkRRHH As CheckBox
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnExamCotiBuscar As Button
    Friend WithEvents txtCotizacionBuscarSE As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents txtProveedorBuscarSE As TextBox
    Friend WithEvents btnExamProvBuscar As Button
    Friend WithEvents txtRucBuscarSE As TextBox
    Friend WithEvents btnBuscarSE As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents dtpHastaBuscarSE As DateTimePicker
    Friend WithEvents dtpDesdeBuscarSE As DateTimePicker
    Friend WithEvents Label42 As Label
    Friend WithEvents btnLimpiarBusqueda As Button
End Class
