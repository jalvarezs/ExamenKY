<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTrasladarStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTrasladarStock))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscarContenedor2 = New System.Windows.Forms.Button()
        Me.btnBuscarContenedor1 = New System.Windows.Forms.Button()
        Me.btnD_I = New System.Windows.Forms.Button()
        Me.btnI_D = New System.Windows.Forms.Button()
        Me.ErrorContenedor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtContenedor1 = New System.Windows.Forms.TextBox()
        Me.dgvContenedores1 = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgvContenedores2 = New System.Windows.Forms.DataGridView()
        Me.txtContenedor2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrorContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContenedores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContenedores2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(806, 342)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnBuscarContenedor2
        '
        Me.btnBuscarContenedor2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscarContenedor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarContenedor2.Image = Global.WES_II.My.Resources.Resources.Buscar_24x24
        Me.btnBuscarContenedor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarContenedor2.Location = New System.Drawing.Point(737, 116)
        Me.btnBuscarContenedor2.Name = "btnBuscarContenedor2"
        Me.btnBuscarContenedor2.Size = New System.Drawing.Size(82, 34)
        Me.btnBuscarContenedor2.TabIndex = 31
        Me.btnBuscarContenedor2.Text = "Buscar"
        Me.btnBuscarContenedor2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnBuscarContenedor2, "Buscar Contenedor 2")
        Me.btnBuscarContenedor2.UseVisualStyleBackColor = True
        '
        'btnBuscarContenedor1
        '
        Me.btnBuscarContenedor1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscarContenedor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarContenedor1.Image = Global.WES_II.My.Resources.Resources.Buscar_24x24
        Me.btnBuscarContenedor1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarContenedor1.Location = New System.Drawing.Point(299, 116)
        Me.btnBuscarContenedor1.Name = "btnBuscarContenedor1"
        Me.btnBuscarContenedor1.Size = New System.Drawing.Size(82, 34)
        Me.btnBuscarContenedor1.TabIndex = 26
        Me.btnBuscarContenedor1.Text = "Buscar"
        Me.btnBuscarContenedor1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnBuscarContenedor1, "Buscar Contedor 1")
        Me.btnBuscarContenedor1.UseVisualStyleBackColor = True
        '
        'btnD_I
        '
        Me.btnD_I.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnD_I.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnD_I.Image = CType(resources.GetObject("btnD_I.Image"), System.Drawing.Image)
        Me.btnD_I.Location = New System.Drawing.Point(442, 254)
        Me.btnD_I.Name = "btnD_I"
        Me.btnD_I.Size = New System.Drawing.Size(82, 34)
        Me.btnD_I.TabIndex = 33
        Me.btnD_I.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnD_I.UseVisualStyleBackColor = True
        '
        'btnI_D
        '
        Me.btnI_D.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnI_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnI_D.Image = CType(resources.GetObject("btnI_D.Image"), System.Drawing.Image)
        Me.btnI_D.Location = New System.Drawing.Point(442, 194)
        Me.btnI_D.Name = "btnI_D"
        Me.btnI_D.Size = New System.Drawing.Size(82, 34)
        Me.btnI_D.TabIndex = 32
        Me.btnI_D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnI_D.UseVisualStyleBackColor = True
        '
        'ErrorContenedor
        '
        Me.ErrorContenedor.ContainerControl = Me
        '
        'txtContenedor1
        '
        Me.txtContenedor1.Location = New System.Drawing.Point(57, 126)
        Me.txtContenedor1.Name = "txtContenedor1"
        Me.txtContenedor1.ReadOnly = True
        Me.txtContenedor1.Size = New System.Drawing.Size(111, 20)
        Me.txtContenedor1.TabIndex = 25
        '
        'dgvContenedores1
        '
        Me.dgvContenedores1.AllowUserToAddRows = False
        Me.dgvContenedores1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContenedores1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContenedores1.Location = New System.Drawing.Point(27, 169)
        Me.dgvContenedores1.Name = "dgvContenedores1"
        Me.dgvContenedores1.ReadOnly = True
        Me.dgvContenedores1.Size = New System.Drawing.Size(389, 148)
        Me.dgvContenedores1.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 101)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 15)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Contenedor 1:"
        '
        'dgvContenedores2
        '
        Me.dgvContenedores2.AllowUserToAddRows = False
        Me.dgvContenedores2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContenedores2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContenedores2.Location = New System.Drawing.Point(550, 169)
        Me.dgvContenedores2.Name = "dgvContenedores2"
        Me.dgvContenedores2.ReadOnly = True
        Me.dgvContenedores2.Size = New System.Drawing.Size(366, 148)
        Me.dgvContenedores2.TabIndex = 28
        '
        'txtContenedor2
        '
        Me.txtContenedor2.Location = New System.Drawing.Point(507, 126)
        Me.txtContenedor2.Name = "txtContenedor2"
        Me.txtContenedor2.ReadOnly = True
        Me.txtContenedor2.Size = New System.Drawing.Size(111, 20)
        Me.txtContenedor2.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Contenedor 2:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 75)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movimiento de Stock entre Contenedores"
        '
        'FormTrasladarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 409)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnD_I)
        Me.Controls.Add(Me.btnI_D)
        Me.Controls.Add(Me.btnBuscarContenedor2)
        Me.Controls.Add(Me.txtContenedor2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvContenedores2)
        Me.Controls.Add(Me.btnBuscarContenedor1)
        Me.Controls.Add(Me.txtContenedor1)
        Me.Controls.Add(Me.dgvContenedores1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTrasladarStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Trasladar Stock"
        CType(Me.ErrorContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContenedores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContenedores2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorContenedor As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarContenedor1 As System.Windows.Forms.Button
    Friend WithEvents txtContenedor1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvContenedores1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarContenedor2 As System.Windows.Forms.Button
    Friend WithEvents txtContenedor2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvContenedores2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnD_I As System.Windows.Forms.Button
    Friend WithEvents btnI_D As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
