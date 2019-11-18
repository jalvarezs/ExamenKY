<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConsultarStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultarStock))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ErrorContenedor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvStockMateriales = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ErrorContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStockMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(514, 492)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ErrorContenedor
        '
        Me.ErrorContenedor.ContainerControl = Me
        '
        'dgvStockMateriales
        '
        Me.dgvStockMateriales.AllowUserToAddRows = False
        Me.dgvStockMateriales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStockMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockMateriales.Location = New System.Drawing.Point(12, 128)
        Me.dgvStockMateriales.Name = "dgvStockMateriales"
        Me.dgvStockMateriales.ReadOnly = True
        Me.dgvStockMateriales.Size = New System.Drawing.Size(612, 209)
        Me.dgvStockMateriales.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 75)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultar Stock en Contenedores"
        '
        'dgvProveedores
        '
        Me.dgvProveedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Location = New System.Drawing.Point(13, 371)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.Size = New System.Drawing.Size(611, 109)
        Me.dgvProveedores.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Proveedores del material seleccionado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Listado de Materiales y sus cantidades:"
        '
        'FormConsultarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 551)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvProveedores)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvStockMateriales)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormConsultarStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Consultar Stock"
        CType(Me.ErrorContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStockMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorContenedor As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvStockMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As Label
End Class
