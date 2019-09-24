<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFamilias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.poii
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFamilias))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgvFamilias = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cbFamilia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptarSubFamilia = New System.Windows.Forms.Button()
        Me.btnGuardarSubFamilia = New System.Windows.Forms.Button()
        Me.txtSubFamiliaDesc = New System.Windows.Forms.TextBox()
        Me.txtSubFamilia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvSubFamilia = New System.Windows.Forms.DataGridView()
        Me.btnEliminarSubFamilia = New System.Windows.Forms.Button()
        Me.btnModificarSubFamilia = New System.Windows.Forms.Button()
        Me.toolTipFamilia = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorFamilia = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvSubFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(715, 310)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.txtDescripcion)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Familia"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(449, 131)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(333, 131)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnGuardar, "Registrar nueva familia")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 65)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(425, 45)
        Me.txtDescripcion.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(134, 23)
        Me.txtNombre.MaxLength = 25
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(238, 20)
        Me.txtNombre.TabIndex = 6
        Me.toolTipFamilia.SetToolTip(Me.txtNombre, "XDXD")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "(*) Nombre:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnEliminar)
        Me.TabPage2.Controls.Add(Me.btnModificar)
        Me.TabPage2.Controls.Add(Me.dgvFamilias)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(707, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Familias"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnEliminar.Location = New System.Drawing.Point(574, 210)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 47)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnEliminar, "Eliminar Familia")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificar.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnModificar.Location = New System.Drawing.Point(574, 33)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 47)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnModificar, "Modificar Familia")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'dgvFamilias
        '
        Me.dgvFamilias.AllowUserToAddRows = False
        Me.dgvFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFamilias.Location = New System.Drawing.Point(22, 33)
        Me.dgvFamilias.Name = "dgvFamilias"
        Me.dgvFamilias.ReadOnly = True
        Me.dgvFamilias.Size = New System.Drawing.Size(546, 224)
        Me.dgvFamilias.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(19, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Listado de Familias:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cbFamilia)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.btnAceptarSubFamilia)
        Me.TabPage3.Controls.Add(Me.btnGuardarSubFamilia)
        Me.TabPage3.Controls.Add(Me.txtSubFamiliaDesc)
        Me.TabPage3.Controls.Add(Me.txtSubFamilia)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(707, 284)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Registrar Sub-Familia"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cbFamilia
        '
        Me.cbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFamilia.FormattingEnabled = True
        Me.cbFamilia.Location = New System.Drawing.Point(134, 21)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.Size = New System.Drawing.Size(238, 21)
        Me.cbFamilia.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "(*) Familia:"
        '
        'btnAceptarSubFamilia
        '
        Me.btnAceptarSubFamilia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptarSubFamilia.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptarSubFamilia.Location = New System.Drawing.Point(449, 160)
        Me.btnAceptarSubFamilia.Name = "btnAceptarSubFamilia"
        Me.btnAceptarSubFamilia.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptarSubFamilia.TabIndex = 15
        Me.btnAceptarSubFamilia.Text = "Aceptar"
        Me.btnAceptarSubFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnAceptarSubFamilia, "Volver al formulario anterior")
        Me.btnAceptarSubFamilia.UseVisualStyleBackColor = True
        '
        'btnGuardarSubFamilia
        '
        Me.btnGuardarSubFamilia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardarSubFamilia.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardarSubFamilia.Location = New System.Drawing.Point(333, 160)
        Me.btnGuardarSubFamilia.Name = "btnGuardarSubFamilia"
        Me.btnGuardarSubFamilia.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardarSubFamilia.TabIndex = 14
        Me.btnGuardarSubFamilia.Text = "Guardar"
        Me.btnGuardarSubFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnGuardarSubFamilia, "Registrar nueva familia")
        Me.btnGuardarSubFamilia.UseVisualStyleBackColor = True
        '
        'txtSubFamiliaDesc
        '
        Me.txtSubFamiliaDesc.Location = New System.Drawing.Point(134, 92)
        Me.txtSubFamiliaDesc.MaxLength = 100
        Me.txtSubFamiliaDesc.Multiline = True
        Me.txtSubFamiliaDesc.Name = "txtSubFamiliaDesc"
        Me.txtSubFamiliaDesc.Size = New System.Drawing.Size(425, 45)
        Me.txtSubFamiliaDesc.TabIndex = 13
        '
        'txtSubFamilia
        '
        Me.txtSubFamilia.Location = New System.Drawing.Point(134, 52)
        Me.txtSubFamilia.MaxLength = 25
        Me.txtSubFamilia.Name = "txtSubFamilia"
        Me.txtSubFamilia.Size = New System.Drawing.Size(238, 20)
        Me.txtSubFamilia.TabIndex = 12
        Me.toolTipFamilia.SetToolTip(Me.txtSubFamilia, "XDXD")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "(*) Nombre:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.dgvSubFamilia)
        Me.TabPage4.Controls.Add(Me.btnEliminarSubFamilia)
        Me.TabPage4.Controls.Add(Me.btnModificarSubFamilia)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(707, 284)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Consultar Sub-Familia"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Listado de Sub-Familias:"
        '
        'dgvSubFamilia
        '
        Me.dgvSubFamilia.AllowUserToAddRows = False
        Me.dgvSubFamilia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubFamilia.Location = New System.Drawing.Point(22, 33)
        Me.dgvSubFamilia.Name = "dgvSubFamilia"
        Me.dgvSubFamilia.ReadOnly = True
        Me.dgvSubFamilia.Size = New System.Drawing.Size(546, 224)
        Me.dgvSubFamilia.TabIndex = 15
        '
        'btnEliminarSubFamilia
        '
        Me.btnEliminarSubFamilia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminarSubFamilia.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnEliminarSubFamilia.Location = New System.Drawing.Point(574, 210)
        Me.btnEliminarSubFamilia.Name = "btnEliminarSubFamilia"
        Me.btnEliminarSubFamilia.Size = New System.Drawing.Size(110, 47)
        Me.btnEliminarSubFamilia.TabIndex = 17
        Me.btnEliminarSubFamilia.Text = "Eliminar"
        Me.btnEliminarSubFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnEliminarSubFamilia, "Eliminar Sub-Familia")
        Me.btnEliminarSubFamilia.UseVisualStyleBackColor = True
        '
        'btnModificarSubFamilia
        '
        Me.btnModificarSubFamilia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificarSubFamilia.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnModificarSubFamilia.Location = New System.Drawing.Point(574, 33)
        Me.btnModificarSubFamilia.Name = "btnModificarSubFamilia"
        Me.btnModificarSubFamilia.Size = New System.Drawing.Size(110, 47)
        Me.btnModificarSubFamilia.TabIndex = 16
        Me.btnModificarSubFamilia.Text = "Modificar"
        Me.btnModificarSubFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipFamilia.SetToolTip(Me.btnModificarSubFamilia, "Modificar Sub-Familia")
        Me.btnModificarSubFamilia.UseVisualStyleBackColor = True
        '
        'ErrorFamilia
        '
        Me.ErrorFamilia.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Familia y Sub-Familia de Productos"
        '
        'FormFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 385)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFamilias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Familias"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvSubFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents toolTipFamilia As System.Windows.Forms.ToolTip
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dgvFamilias As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents ErrorFamilia As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cbFamilia As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptarSubFamilia As Button
    Friend WithEvents btnGuardarSubFamilia As Button
    Friend WithEvents txtSubFamiliaDesc As TextBox
    Friend WithEvents txtSubFamilia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEliminarSubFamilia As Button
    Friend WithEvents btnModificarSubFamilia As Button
    Friend WithEvents dgvSubFamilia As DataGridView
End Class
