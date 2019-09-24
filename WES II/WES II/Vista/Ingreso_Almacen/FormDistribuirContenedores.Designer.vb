<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDistribuirContenedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDistribuirContenedores))
        Me.dgvContenedores = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCantidadEntrante = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminarContenedor = New System.Windows.Forms.Button()
        Me.btnDistContenedor = New System.Windows.Forms.Button()
        Me.CodigoMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSolicitada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadRecibida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntrante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contenedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoContenedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvContenedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvContenedores
        '
        Me.dgvContenedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContenedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContenedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoMaterial, Me.Material, Me.CantidadSolicitada, Me.CantidadRecibida, Me.CantidadEntrante, Me.Contenedor, Me.TipoContenedor})
        Me.dgvContenedores.Location = New System.Drawing.Point(26, 144)
        Me.dgvContenedores.Name = "dgvContenedores"
        Me.dgvContenedores.ReadOnly = True
        Me.dgvContenedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContenedores.Size = New System.Drawing.Size(692, 210)
        Me.dgvContenedores.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 83)
        Me.Panel1.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Distribuir Contenedores"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(310, 370)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 47)
        Me.btnAceptar.TabIndex = 45
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCantidadEntrante
        '
        Me.txtCantidadEntrante.Enabled = False
        Me.txtCantidadEntrante.Location = New System.Drawing.Point(146, 105)
        Me.txtCantidadEntrante.Name = "txtCantidadEntrante"
        Me.txtCantidadEntrante.ReadOnly = True
        Me.txtCantidadEntrante.Size = New System.Drawing.Size(92, 20)
        Me.txtCantidadEntrante.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Cantidad Entrante:"
        '
        'btnEliminarContenedor
        '
        Me.btnEliminarContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarContenedor.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnEliminarContenedor.Location = New System.Drawing.Point(601, 92)
        Me.btnEliminarContenedor.Name = "btnEliminarContenedor"
        Me.btnEliminarContenedor.Size = New System.Drawing.Size(117, 47)
        Me.btnEliminarContenedor.TabIndex = 47
        Me.btnEliminarContenedor.Text = "Eliminar"
        Me.btnEliminarContenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminarContenedor.UseVisualStyleBackColor = True
        '
        'btnDistContenedor
        '
        Me.btnDistContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDistContenedor.Image = Global.WES_II.My.Resources.Resources.Contenedor
        Me.btnDistContenedor.Location = New System.Drawing.Point(469, 91)
        Me.btnDistContenedor.Name = "btnDistContenedor"
        Me.btnDistContenedor.Size = New System.Drawing.Size(126, 47)
        Me.btnDistContenedor.TabIndex = 48
        Me.btnDistContenedor.Text = "Distribuir Contenedores"
        Me.btnDistContenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDistContenedor.UseVisualStyleBackColor = True
        '
        'CodigoMaterial
        '
        Me.CodigoMaterial.DataPropertyName = "CodigoMaterial"
        Me.CodigoMaterial.HeaderText = "Codigo Material"
        Me.CodigoMaterial.Name = "CodigoMaterial"
        Me.CodigoMaterial.ReadOnly = True
        '
        'Material
        '
        Me.Material.DataPropertyName = "Material"
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.ReadOnly = True
        '
        'CantidadSolicitada
        '
        Me.CantidadSolicitada.DataPropertyName = "CantidadSolicitada"
        Me.CantidadSolicitada.HeaderText = "Cantidad Solicitada"
        Me.CantidadSolicitada.Name = "CantidadSolicitada"
        Me.CantidadSolicitada.ReadOnly = True
        '
        'CantidadRecibida
        '
        Me.CantidadRecibida.DataPropertyName = "CantidadRecibida"
        Me.CantidadRecibida.HeaderText = "Cantidad Recibida"
        Me.CantidadRecibida.Name = "CantidadRecibida"
        Me.CantidadRecibida.ReadOnly = True
        '
        'CantidadEntrante
        '
        Me.CantidadEntrante.DataPropertyName = "CantidadEntrante"
        Me.CantidadEntrante.HeaderText = "Cantidad Entrante"
        Me.CantidadEntrante.Name = "CantidadEntrante"
        Me.CantidadEntrante.ReadOnly = True
        '
        'Contenedor
        '
        Me.Contenedor.DataPropertyName = "Contenedor"
        Me.Contenedor.HeaderText = "Contenedor"
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.ReadOnly = True
        '
        'TipoContenedor
        '
        Me.TipoContenedor.DataPropertyName = "TipoContenedor"
        Me.TipoContenedor.HeaderText = "Tipo Contenedor"
        Me.TipoContenedor.Name = "TipoContenedor"
        Me.TipoContenedor.ReadOnly = True
        '
        'FormDistribuirContenedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 429)
        Me.Controls.Add(Me.btnDistContenedor)
        Me.Controls.Add(Me.btnEliminarContenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvContenedores)
        Me.Controls.Add(Me.txtCantidadEntrante)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDistribuirContenedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Distribuir Contenedores"
        CType(Me.dgvContenedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents dgvContenedores As System.Windows.Forms.DataGridView
    Friend WithEvents txtCantidadEntrante As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminarContenedor As Button
    Friend WithEvents btnDistContenedor As Button
    Friend WithEvents CodigoMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents CantidadSolicitada As DataGridViewTextBoxColumn
    Friend WithEvents CantidadRecibida As DataGridViewTextBoxColumn
    Friend WithEvents CantidadEntrante As DataGridViewTextBoxColumn
    Friend WithEvents Contenedor As DataGridViewTextBoxColumn
    Friend WithEvents TipoContenedor As DataGridViewTextBoxColumn
End Class
