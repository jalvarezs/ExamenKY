<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresoMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIngresoMaterial))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnDefinirCantidad = New System.Windows.Forms.Button()
        Me.btnDefinirTotal = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnDefinirPrecio = New System.Windows.Forms.Button()
        Me.btnDistribuirContenedores = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.txtOferta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExaminarOrden = New System.Windows.Forms.Button()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.btnExamCont = New System.Windows.Forms.Button()
        Me.txtContenedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvIngresos = New System.Windows.Forms.DataGridView()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDefinirCantidad
        '
        Me.btnDefinirCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDefinirCantidad.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnDefinirCantidad.Location = New System.Drawing.Point(580, 261)
        Me.btnDefinirCantidad.Name = "btnDefinirCantidad"
        Me.btnDefinirCantidad.Size = New System.Drawing.Size(129, 47)
        Me.btnDefinirCantidad.TabIndex = 54
        Me.btnDefinirCantidad.Text = "Definir Cantidad Entrante"
        Me.btnDefinirCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnDefinirCantidad, "Registrar nueva orden de compra")
        Me.btnDefinirCantidad.UseVisualStyleBackColor = True
        '
        'btnDefinirTotal
        '
        Me.btnDefinirTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDefinirTotal.Image = Global.WES_II.My.Resources.Resources.Aprobacion
        Me.btnDefinirTotal.Location = New System.Drawing.Point(580, 319)
        Me.btnDefinirTotal.Name = "btnDefinirTotal"
        Me.btnDefinirTotal.Size = New System.Drawing.Size(129, 47)
        Me.btnDefinirTotal.TabIndex = 47
        Me.btnDefinirTotal.Text = "Definir Ingreso Total"
        Me.btnDefinirTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnDefinirTotal, "Registrar nueva orden de compra")
        Me.btnDefinirTotal.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(580, 438)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(129, 47)
        Me.btnAceptar.TabIndex = 36
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(580, 378)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 47)
        Me.btnGuardar.TabIndex = 35
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnGuardar, "Registrar nueva orden de compra")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnDefinirPrecio
        '
        Me.btnDefinirPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDefinirPrecio.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnDefinirPrecio.Location = New System.Drawing.Point(580, 206)
        Me.btnDefinirPrecio.Name = "btnDefinirPrecio"
        Me.btnDefinirPrecio.Size = New System.Drawing.Size(129, 45)
        Me.btnDefinirPrecio.TabIndex = 55
        Me.btnDefinirPrecio.Text = "Definir Precio Actualizado"
        Me.btnDefinirPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnDefinirPrecio, "Registrar nueva orden de compra")
        Me.btnDefinirPrecio.UseVisualStyleBackColor = True
        '
        'btnDistribuirContenedores
        '
        Me.btnDistribuirContenedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDistribuirContenedores.Image = Global.WES_II.My.Resources.Resources.Contenedor
        Me.btnDistribuirContenedores.Location = New System.Drawing.Point(580, 149)
        Me.btnDistribuirContenedores.Name = "btnDistribuirContenedores"
        Me.btnDistribuirContenedores.Size = New System.Drawing.Size(129, 45)
        Me.btnDistribuirContenedores.TabIndex = 63
        Me.btnDistribuirContenedores.Text = "Distribuir Contenedores"
        Me.btnDistribuirContenedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnDistribuirContenedores, "Contenedores")
        Me.btnDistribuirContenedores.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'txtProyecto
        '
        Me.txtProyecto.Enabled = False
        Me.txtProyecto.Location = New System.Drawing.Point(439, 11)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.ReadOnly = True
        Me.txtProyecto.Size = New System.Drawing.Size(127, 20)
        Me.txtProyecto.TabIndex = 53
        '
        'txtOferta
        '
        Me.txtOferta.Enabled = False
        Me.txtOferta.Location = New System.Drawing.Point(438, 49)
        Me.txtOferta.Name = "txtOferta"
        Me.txtOferta.ReadOnly = True
        Me.txtOferta.Size = New System.Drawing.Size(128, 20)
        Me.txtOferta.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(392, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Oferta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Proyecto:"
        '
        'txtOrden
        '
        Me.txtOrden.Enabled = False
        Me.txtOrden.Location = New System.Drawing.Point(112, 11)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(103, 20)
        Me.txtOrden.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Proveedor:"
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Location = New System.Drawing.Point(22, 149)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(544, 336)
        Me.dgvMateriales.TabIndex = 45
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(112, 85)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(192, 20)
        Me.dtpFechaIngreso.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Fecha:"
        '
        'btnExaminarOrden
        '
        Me.btnExaminarOrden.Location = New System.Drawing.Point(221, 11)
        Me.btnExaminarOrden.Name = "btnExaminarOrden"
        Me.btnExaminarOrden.Size = New System.Drawing.Size(83, 23)
        Me.btnExaminarOrden.TabIndex = 37
        Me.btnExaminarOrden.Text = "Examinar"
        Me.btnExaminarOrden.UseVisualStyleBackColor = True
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(112, 49)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(192, 20)
        Me.txtProveedor.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "(*) Orden:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Materiales"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(737, 531)
        Me.TabControl1.TabIndex = 55
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDistribuirContenedores)
        Me.TabPage1.Controls.Add(Me.cboTipoDocumento)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtNumeroDocumento)
        Me.TabPage1.Controls.Add(Me.btnExamCont)
        Me.TabPage1.Controls.Add(Me.txtContenedor)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnDefinirPrecio)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnDefinirCantidad)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnDefinirTotal)
        Me.TabPage1.Controls.Add(Me.txtProyecto)
        Me.TabPage1.Controls.Add(Me.dgvMateriales)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.txtProveedor)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.txtOferta)
        Me.TabPage1.Controls.Add(Me.btnExaminarOrden)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.dtpFechaIngreso)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtOrden)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar ingresos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(438, 122)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(128, 21)
        Me.cboTipoDocumento.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(334, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Tipo Documento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "N° Documento:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(112, 122)
        Me.txtNumeroDocumento.MaxLength = 100
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(192, 20)
        Me.txtNumeroDocumento.TabIndex = 59
        '
        'btnExamCont
        '
        Me.btnExamCont.Location = New System.Drawing.Point(580, 85)
        Me.btnExamCont.Name = "btnExamCont"
        Me.btnExamCont.Size = New System.Drawing.Size(82, 23)
        Me.btnExamCont.TabIndex = 58
        Me.btnExamCont.Text = "Examinar"
        Me.btnExamCont.UseVisualStyleBackColor = True
        '
        'txtContenedor
        '
        Me.txtContenedor.Location = New System.Drawing.Point(439, 85)
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.ReadOnly = True
        Me.txtContenedor.Size = New System.Drawing.Size(127, 20)
        Me.txtContenedor.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(315, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "(*) Contenedor destino:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDetalles)
        Me.TabPage2.Controls.Add(Me.btnListar)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.dtpHasta)
        Me.TabPage2.Controls.Add(Me.dtpDesde)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.dgvIngresos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(729, 505)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar ingresos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(37, 313)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.Size = New System.Drawing.Size(656, 164)
        Me.dgvDetalles.TabIndex = 110
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(580, 44)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(86, 23)
        Me.btnListar.TabIndex = 109
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(315, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(371, 45)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(194, 20)
        Me.dtpHasta.TabIndex = 107
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(90, 45)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(207, 20)
        Me.dtpDesde.TabIndex = 106
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(38, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "Desde:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(34, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 15)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Listado de Ingreso de Materiales:"
        '
        'dgvIngresos
        '
        Me.dgvIngresos.AllowUserToAddRows = False
        Me.dgvIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresos.Location = New System.Drawing.Point(37, 87)
        Me.dgvIngresos.Name = "dgvIngresos"
        Me.dgvIngresos.ReadOnly = True
        Me.dgvIngresos.Size = New System.Drawing.Size(656, 195)
        Me.dgvIngresos.TabIndex = 101
        '
        'FormIngresoMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 606)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormIngresoMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Ingreso de materiales"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtOferta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDefinirTotal As System.Windows.Forms.Button
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExaminarOrden As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDefinirCantidad As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvIngresos As System.Windows.Forms.DataGridView
    Friend WithEvents btnDefinirPrecio As System.Windows.Forms.Button
    Friend WithEvents btnExamCont As System.Windows.Forms.Button
    Friend WithEvents txtContenedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumeroDocumento As TextBox
    Friend WithEvents btnDistribuirContenedores As Button
End Class
