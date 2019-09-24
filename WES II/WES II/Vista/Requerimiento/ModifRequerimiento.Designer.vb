<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifRequerimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifRequerimiento))
        Me.btnExaminarAD = New System.Windows.Forms.Button()
        Me.btnExaminarCOC = New System.Windows.Forms.Button()
        Me.btnExaminarP = New System.Windows.Forms.Button()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.txtAlmacenDestino = New System.Windows.Forms.TextBox()
        Me.txtCodOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtCodRequerimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAgregarItem = New System.Windows.Forms.Button()
        Me.btnExaminarM = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtMateriales = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExaminarAD
        '
        Me.btnExaminarAD.Location = New System.Drawing.Point(550, 215)
        Me.btnExaminarAD.Name = "btnExaminarAD"
        Me.btnExaminarAD.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarAD.TabIndex = 105
        Me.btnExaminarAD.Text = "Examinar"
        Me.btnExaminarAD.UseVisualStyleBackColor = True
        '
        'btnExaminarCOC
        '
        Me.btnExaminarCOC.Location = New System.Drawing.Point(550, 175)
        Me.btnExaminarCOC.Name = "btnExaminarCOC"
        Me.btnExaminarCOC.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarCOC.TabIndex = 104
        Me.btnExaminarCOC.Text = "Examinar"
        Me.btnExaminarCOC.UseVisualStyleBackColor = True
        '
        'btnExaminarP
        '
        Me.btnExaminarP.Location = New System.Drawing.Point(199, 142)
        Me.btnExaminarP.Name = "btnExaminarP"
        Me.btnExaminarP.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarP.TabIndex = 96
        Me.btnExaminarP.Text = "Examinar"
        Me.btnExaminarP.UseVisualStyleBackColor = True
        '
        'txtProyecto
        '
        Me.txtProyecto.Location = New System.Drawing.Point(93, 142)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.ReadOnly = True
        Me.txtProyecto.Size = New System.Drawing.Size(100, 20)
        Me.txtProyecto.TabIndex = 95
        '
        'txtAlmacenDestino
        '
        Me.txtAlmacenDestino.Location = New System.Drawing.Point(444, 215)
        Me.txtAlmacenDestino.Name = "txtAlmacenDestino"
        Me.txtAlmacenDestino.ReadOnly = True
        Me.txtAlmacenDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtAlmacenDestino.TabIndex = 94
        '
        'txtCodOrdenCompra
        '
        Me.txtCodOrdenCompra.Location = New System.Drawing.Point(444, 178)
        Me.txtCodOrdenCompra.Name = "txtCodOrdenCompra"
        Me.txtCodOrdenCompra.ReadOnly = True
        Me.txtCodOrdenCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtCodOrdenCompra.TabIndex = 93
        '
        'txtCodRequerimiento
        '
        Me.txtCodRequerimiento.Enabled = False
        Me.txtCodRequerimiento.Location = New System.Drawing.Point(444, 142)
        Me.txtCodRequerimiento.Name = "txtCodRequerimiento"
        Me.txtCodRequerimiento.ReadOnly = True
        Me.txtCodRequerimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtCodRequerimiento.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Almacén destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Orden de compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Código:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "(*) Proyecto:"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBorrar.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnBorrar.Location = New System.Drawing.Point(539, 284)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(110, 47)
        Me.btnBorrar.TabIndex = 119
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnBorrar, "Eliminar el detalle seleccionado")
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 83)
        Me.Panel1.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(259, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Modificar Requerimiento"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Location = New System.Drawing.Point(539, 416)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 107
        Me.btnAceptar.Text = "    Volver"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(539, 363)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 106
        Me.btnGuardar.Text = "     Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAgregarItem
        '
        Me.btnAgregarItem.Location = New System.Drawing.Point(199, 218)
        Me.btnAgregarItem.Name = "btnAgregarItem"
        Me.btnAgregarItem.Size = New System.Drawing.Size(75, 20)
        Me.btnAgregarItem.TabIndex = 116
        Me.btnAgregarItem.Text = "Añadir"
        Me.btnAgregarItem.UseVisualStyleBackColor = True
        '
        'btnExaminarM
        '
        Me.btnExaminarM.Location = New System.Drawing.Point(199, 180)
        Me.btnExaminarM.Name = "btnExaminarM"
        Me.btnExaminarM.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarM.TabIndex = 114
        Me.btnExaminarM.Text = "Examinar"
        Me.btnExaminarM.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(93, 218)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 113
        '
        'txtMateriales
        '
        Me.txtMateriales.Location = New System.Drawing.Point(93, 183)
        Me.txtMateriales.Name = "txtMateriales"
        Me.txtMateriales.ReadOnly = True
        Me.txtMateriales.Size = New System.Drawing.Size(100, 20)
        Me.txtMateriales.TabIndex = 111
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "(*) Cantidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "(*) Material:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 15)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Modificar Requerimiento:"
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreMaterial, Me.Cantidad, Me.Precio})
        Me.dgvMateriales.Location = New System.Drawing.Point(12, 284)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(521, 179)
        Me.dgvMateriales.TabIndex = 120
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
        'ModifRequerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 489)
        Me.Controls.Add(Me.dgvMateriales)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnAgregarItem)
        Me.Controls.Add(Me.btnExaminarM)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtMateriales)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnExaminarAD)
        Me.Controls.Add(Me.btnExaminarCOC)
        Me.Controls.Add(Me.btnExaminarP)
        Me.Controls.Add(Me.txtProyecto)
        Me.Controls.Add(Me.txtAlmacenDestino)
        Me.Controls.Add(Me.txtCodOrdenCompra)
        Me.Controls.Add(Me.txtCodRequerimiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModifRequerimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Requerimiento"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnExaminarAD As System.Windows.Forms.Button
    Friend WithEvents btnExaminarCOC As System.Windows.Forms.Button
    Friend WithEvents btnExaminarP As System.Windows.Forms.Button
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtAlmacenDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtCodOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtCodRequerimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Private WithEvents btnAgregarItem As System.Windows.Forms.Button
    Friend WithEvents btnExaminarM As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtMateriales As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
