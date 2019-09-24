<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormQuiebreStockPorOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQuiebreStockPorOT))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ErrorContenedor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvStockMateriales = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnExamOT = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        CType(Me.ErrorContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStockMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(553, 492)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.dgvStockMateriales.Location = New System.Drawing.Point(12, 159)
        Me.dgvStockMateriales.Name = "dgvStockMateriales"
        Me.dgvStockMateriales.ReadOnly = True
        Me.dgvStockMateriales.Size = New System.Drawing.Size(651, 313)
        Me.dgvStockMateriales.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(415, 15)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Listado de materiales que estan por debajo del stock de seguridad y/o en 0"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 75)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quiebre de Stock por Orden Trabajo"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Image = Global.WES_II.My.Resources.Resources.Buscar_32x32
        Me.btnBuscar.Location = New System.Drawing.Point(545, 96)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 47)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtOrdenTrabajo
        '
        Me.txtOrdenTrabajo.Enabled = False
        Me.txtOrdenTrabajo.Location = New System.Drawing.Point(116, 96)
        Me.txtOrdenTrabajo.Name = "txtOrdenTrabajo"
        Me.txtOrdenTrabajo.ReadOnly = True
        Me.txtOrdenTrabajo.Size = New System.Drawing.Size(119, 20)
        Me.txtOrdenTrabajo.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "(*) Orden Trabajo:"
        '
        'btnExamOT
        '
        Me.btnExamOT.Location = New System.Drawing.Point(361, 95)
        Me.btnExamOT.Name = "btnExamOT"
        Me.btnExamOT.Size = New System.Drawing.Size(67, 23)
        Me.btnExamOT.TabIndex = 38
        Me.btnExamOT.Text = "Examinar"
        Me.btnExamOT.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(239, 96)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(119, 20)
        Me.txtCodigo.TabIndex = 39
        '
        'FormQuiebreStockPorOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 551)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtOrdenTrabajo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnExamOT)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvStockMateriales)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormQuiebreStockPorOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Quiebre Stock Por Orden Trabajo"
        CType(Me.ErrorContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStockMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorContenedor As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvStockMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtOrdenTrabajo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnExamOT As Button
End Class
