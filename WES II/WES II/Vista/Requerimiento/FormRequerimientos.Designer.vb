<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRequerimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRequerimientos))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvRequerimiento = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAgregarItem = New System.Windows.Forms.Button()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBorrarItem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnExaminarAD = New System.Windows.Forms.Button()
        Me.btnExaminarOC = New System.Windows.Forms.Button()
        Me.btnExaminarM = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtMateriales = New System.Windows.Forms.TextBox()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.txtAlmacenDestino = New System.Windows.Forms.TextBox()
        Me.txtCodOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnExaminarP = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFechaReq = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.Location = New System.Drawing.Point(359, 282)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 47)
        Me.btnEliminar.TabIndex = 93
        Me.btnEliminar.Text = "     Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnEliminar, "Eliminar el requerimiento seleccionado")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificar.Location = New System.Drawing.Point(199, 282)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 47)
        Me.btnModificar.TabIndex = 92
        Me.btnModificar.Text = "      Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnModificar, "Modificar el requerimiento seleccionado")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
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
        Me.TabPage2.Controls.Add(Me.dgvRequerimiento)
        Me.TabPage2.Controls.Add(Me.btnEliminar)
        Me.TabPage2.Controls.Add(Me.btnModificar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(639, 498)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Consultar requerimientos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(18, 335)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.Size = New System.Drawing.Size(598, 144)
        Me.dgvDetalles.TabIndex = 100
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(530, 45)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(86, 23)
        Me.btnListar.TabIndex = 99
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 15)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(330, 45)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(194, 20)
        Me.dtpHasta.TabIndex = 97
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(71, 48)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(207, 20)
        Me.dtpDesde.TabIndex = 96
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Desde:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 15)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Listado de Requerimientos:"
        '
        'dgvRequerimiento
        '
        Me.dgvRequerimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequerimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequerimiento.Location = New System.Drawing.Point(22, 89)
        Me.dgvRequerimiento.Name = "dgvRequerimiento"
        Me.dgvRequerimiento.ReadOnly = True
        Me.dgvRequerimiento.Size = New System.Drawing.Size(594, 187)
        Me.dgvRequerimiento.TabIndex = 73
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAgregarItem)
        Me.TabPage1.Controls.Add(Me.dgvMateriales)
        Me.TabPage1.Controls.Add(Me.btnBorrarItem)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.btnExaminarAD)
        Me.TabPage1.Controls.Add(Me.btnExaminarOC)
        Me.TabPage1.Controls.Add(Me.btnExaminarM)
        Me.TabPage1.Controls.Add(Me.txtCantidad)
        Me.TabPage1.Controls.Add(Me.txtMateriales)
        Me.TabPage1.Controls.Add(Me.txtProyecto)
        Me.TabPage1.Controls.Add(Me.txtAlmacenDestino)
        Me.TabPage1.Controls.Add(Me.txtCodOrdenCompra)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.btnExaminarP)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dpFechaReq)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(639, 498)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Alta de requerimientos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAgregarItem
        '
        Me.btnAgregarItem.Location = New System.Drawing.Point(196, 191)
        Me.btnAgregarItem.Name = "btnAgregarItem"
        Me.btnAgregarItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarItem.TabIndex = 89
        Me.btnAgregarItem.Text = "Añadir"
        Me.btnAgregarItem.UseVisualStyleBackColor = True
        '
        'dgvMateriales
        '
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreMaterial, Me.Cantidad, Me.Precio})
        Me.dgvMateriales.Location = New System.Drawing.Point(22, 229)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(493, 220)
        Me.dgvMateriales.TabIndex = 88
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'NombreMaterial
        '
        Me.NombreMaterial.HeaderText = "Nombre de Material"
        Me.NombreMaterial.Name = "NombreMaterial"
        Me.NombreMaterial.ReadOnly = True
        Me.NombreMaterial.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad Solicitada"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio Referencial"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'btnBorrarItem
        '
        Me.btnBorrarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBorrarItem.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnBorrarItem.Location = New System.Drawing.Point(521, 229)
        Me.btnBorrarItem.Name = "btnBorrarItem"
        Me.btnBorrarItem.Size = New System.Drawing.Size(110, 47)
        Me.btnBorrarItem.TabIndex = 87
        Me.btnBorrarItem.Text = "Eliminar"
        Me.btnBorrarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrarItem.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 15)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Registrar Requerimiento:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Location = New System.Drawing.Point(521, 402)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 72
        Me.btnAceptar.Text = "    Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(521, 349)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 71
        Me.btnGuardar.Text = "     Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnExaminarAD
        '
        Me.btnExaminarAD.Location = New System.Drawing.Point(544, 148)
        Me.btnExaminarAD.Name = "btnExaminarAD"
        Me.btnExaminarAD.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarAD.TabIndex = 70
        Me.btnExaminarAD.Text = "Examinar"
        Me.btnExaminarAD.UseVisualStyleBackColor = True
        '
        'btnExaminarOC
        '
        Me.btnExaminarOC.Location = New System.Drawing.Point(544, 103)
        Me.btnExaminarOC.Name = "btnExaminarOC"
        Me.btnExaminarOC.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarOC.TabIndex = 69
        Me.btnExaminarOC.Text = "Examinar"
        Me.btnExaminarOC.UseVisualStyleBackColor = True
        '
        'btnExaminarM
        '
        Me.btnExaminarM.Location = New System.Drawing.Point(196, 153)
        Me.btnExaminarM.Name = "btnExaminarM"
        Me.btnExaminarM.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarM.TabIndex = 67
        Me.btnExaminarM.Text = "Examinar"
        Me.btnExaminarM.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(90, 191)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 66
        '
        'txtMateriales
        '
        Me.txtMateriales.Location = New System.Drawing.Point(90, 156)
        Me.txtMateriales.Name = "txtMateriales"
        Me.txtMateriales.ReadOnly = True
        Me.txtMateriales.Size = New System.Drawing.Size(100, 20)
        Me.txtMateriales.TabIndex = 64
        '
        'txtProyecto
        '
        Me.txtProyecto.Location = New System.Drawing.Point(90, 60)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.ReadOnly = True
        Me.txtProyecto.Size = New System.Drawing.Size(100, 20)
        Me.txtProyecto.TabIndex = 59
        '
        'txtAlmacenDestino
        '
        Me.txtAlmacenDestino.Location = New System.Drawing.Point(438, 148)
        Me.txtAlmacenDestino.Name = "txtAlmacenDestino"
        Me.txtAlmacenDestino.ReadOnly = True
        Me.txtAlmacenDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtAlmacenDestino.TabIndex = 56
        '
        'txtCodOrdenCompra
        '
        Me.txtCodOrdenCompra.Location = New System.Drawing.Point(438, 106)
        Me.txtCodOrdenCompra.Name = "txtCodOrdenCompra"
        Me.txtCodOrdenCompra.ReadOnly = True
        Me.txtCodOrdenCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtCodOrdenCompra.TabIndex = 55
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(438, 58)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "(*) Cantidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "(*) Material:"
        '
        'btnExaminarP
        '
        Me.btnExaminarP.Location = New System.Drawing.Point(196, 60)
        Me.btnExaminarP.Name = "btnExaminarP"
        Me.btnExaminarP.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarP.TabIndex = 60
        Me.btnExaminarP.Text = "Examinar"
        Me.btnExaminarP.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Almacén destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Orden de compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "(*) Código:"
        '
        'dpFechaReq
        '
        Me.dpFechaReq.Location = New System.Drawing.Point(90, 99)
        Me.dpFechaReq.Name = "dpFechaReq"
        Me.dpFechaReq.Size = New System.Drawing.Size(200, 20)
        Me.dpFechaReq.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "(*) Proyecto:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 524)
        Me.TabControl1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 83)
        Me.Panel1.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Requerimientos"
        '
        'FormRequerimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 607)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRequerimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Requerimientos"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnExaminarAD As System.Windows.Forms.Button
    Friend WithEvents btnExaminarOC As System.Windows.Forms.Button
    Friend WithEvents btnExaminarM As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtMateriales As System.Windows.Forms.TextBox
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtAlmacenDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtCodOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnExaminarP As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpFechaReq As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgvRequerimiento As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrarItem As System.Windows.Forms.Button
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarItem As System.Windows.Forms.Button
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
End Class
