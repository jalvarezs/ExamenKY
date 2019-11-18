<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifOrdenCompra))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtMateriales = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExaminarMat = New System.Windows.Forms.Button()
        Me.lbMat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFechaOrden = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExaminarProv = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDirproveedor = New System.Windows.Forms.TextBox()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.txtpref = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBorrar.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnBorrar.Location = New System.Drawing.Point(568, 339)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(110, 47)
        Me.btnBorrar.TabIndex = 47
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnBorrar, "Registrar nueva orden de compra")
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(568, 468)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 30
        Me.btnAceptar.Text = "Volver"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(568, 415)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnGuardar, "Registrar nueva orden de compra")
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar órdenes de compra"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(249, 311)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(83, 23)
        Me.btnAgregar.TabIndex = 46
        Me.btnAgregar.Text = "&Añadir"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreMaterial, Me.Cantidad, Me.Precio})
        Me.dgvMateriales.Location = New System.Drawing.Point(31, 339)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(531, 179)
        Me.dgvMateriales.TabIndex = 45
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
        'cboOferta
        '
        Me.cboOferta.Enabled = False
        Me.cboOferta.FormattingEnabled = True
        Me.cboOferta.Location = New System.Drawing.Point(527, 283)
        Me.cboOferta.Name = "cboOferta"
        Me.cboOferta.Size = New System.Drawing.Size(147, 21)
        Me.cboOferta.TabIndex = 44
        '
        'cboProyecto
        '
        Me.cboProyecto.Enabled = False
        Me.cboProyecto.FormattingEnabled = True
        Me.cboProyecto.Location = New System.Drawing.Point(527, 239)
        Me.cboProyecto.Name = "cboProyecto"
        Me.cboProyecto.Size = New System.Drawing.Size(147, 21)
        Me.cboProyecto.TabIndex = 43
        '
        'chkOferta
        '
        Me.chkOferta.AutoSize = True
        Me.chkOferta.Enabled = False
        Me.chkOferta.Location = New System.Drawing.Point(406, 285)
        Me.chkOferta.Name = "chkOferta"
        Me.chkOferta.Size = New System.Drawing.Size(93, 17)
        Me.chkOferta.TabIndex = 42
        Me.chkOferta.Text = "Asignar Oferta"
        Me.chkOferta.UseVisualStyleBackColor = True
        '
        'chkProyecto
        '
        Me.chkProyecto.AutoSize = True
        Me.chkProyecto.Location = New System.Drawing.Point(406, 241)
        Me.chkProyecto.Name = "chkProyecto"
        Me.chkProyecto.Size = New System.Drawing.Size(106, 17)
        Me.chkProyecto.TabIndex = 41
        Me.chkProyecto.Text = "Asignar Proyecto"
        Me.chkProyecto.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(527, 186)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(147, 20)
        Me.txtCodigo.TabIndex = 40
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(140, 280)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(103, 20)
        Me.txtcantidad.TabIndex = 37
        '
        'txtMateriales
        '
        Me.txtMateriales.Enabled = False
        Me.txtMateriales.Location = New System.Drawing.Point(140, 234)
        Me.txtMateriales.Name = "txtMateriales"
        Me.txtMateriales.Size = New System.Drawing.Size(103, 20)
        Me.txtMateriales.TabIndex = 33
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(140, 98)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(146, 20)
        Me.txtProveedor.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Código de la orden:"
        '
        'btnExaminarMat
        '
        Me.btnExaminarMat.Location = New System.Drawing.Point(249, 232)
        Me.btnExaminarMat.Name = "btnExaminarMat"
        Me.btnExaminarMat.Size = New System.Drawing.Size(83, 23)
        Me.btnExaminarMat.TabIndex = 38
        Me.btnExaminarMat.Text = "Examinar"
        Me.btnExaminarMat.UseVisualStyleBackColor = True
        '
        'lbMat
        '
        Me.lbMat.AutoSize = True
        Me.lbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMat.Location = New System.Drawing.Point(59, 281)
        Me.lbMat.Name = "lbMat"
        Me.lbMat.Size = New System.Drawing.Size(75, 15)
        Me.lbMat.TabIndex = 36
        Me.lbMat.Text = "(*) Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "(*) Materiales:"
        '
        'dpFechaOrden
        '
        Me.dpFechaOrden.Location = New System.Drawing.Point(140, 187)
        Me.dpFechaOrden.Name = "dpFechaOrden"
        Me.dpFechaOrden.Size = New System.Drawing.Size(192, 20)
        Me.dpFechaOrden.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Fecha:"
        '
        'btnExaminarProv
        '
        Me.btnExaminarProv.Location = New System.Drawing.Point(397, 98)
        Me.btnExaminarProv.Name = "btnExaminarProv"
        Me.btnExaminarProv.Size = New System.Drawing.Size(83, 23)
        Me.btnExaminarProv.TabIndex = 31
        Me.btnExaminarProv.Text = "Examinar"
        Me.btnExaminarProv.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "(*) Proveedor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 15)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Dirección Proveedor:"
        '
        'txtDirproveedor
        '
        Me.txtDirproveedor.Enabled = False
        Me.txtDirproveedor.Location = New System.Drawing.Point(143, 127)
        Me.txtDirproveedor.Multiline = True
        Me.txtDirproveedor.Name = "txtDirproveedor"
        Me.txtDirproveedor.Size = New System.Drawing.Size(536, 47)
        Me.txtDirproveedor.TabIndex = 49
        '
        'txtRUC
        '
        Me.txtRUC.Enabled = False
        Me.txtRUC.Location = New System.Drawing.Point(292, 99)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(100, 20)
        Me.txtRUC.TabIndex = 48
        '
        'txtpref
        '
        Me.txtpref.Location = New System.Drawing.Point(140, 313)
        Me.txtpref.Name = "txtpref"
        Me.txtpref.Size = New System.Drawing.Size(103, 20)
        Me.txtpref.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 15)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Precio Referencial:"
        '
        'ModifOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 528)
        Me.Controls.Add(Me.txtpref)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDirproveedor)
        Me.Controls.Add(Me.txtRUC)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvMateriales)
        Me.Controls.Add(Me.cboOferta)
        Me.Controls.Add(Me.cboProyecto)
        Me.Controls.Add(Me.chkOferta)
        Me.Controls.Add(Me.chkProyecto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtMateriales)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExaminarMat)
        Me.Controls.Add(Me.lbMat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dpFechaOrden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExaminarProv)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModifOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Ordenes de Compra"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents cboOferta As System.Windows.Forms.ComboBox
    Friend WithEvents cboProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents chkOferta As System.Windows.Forms.CheckBox
    Friend WithEvents chkProyecto As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtMateriales As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExaminarMat As System.Windows.Forms.Button
    Friend WithEvents lbMat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpFechaOrden As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExaminarProv As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDirproveedor As TextBox
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents txtpref As TextBox
    Friend WithEvents Label13 As Label
End Class
