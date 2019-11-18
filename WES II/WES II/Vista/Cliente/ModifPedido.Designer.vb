<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifPedido))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorModifCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlContacto = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txttelfcontacto2 = New System.Windows.Forms.TextBox()
        Me.txtemailcontacto2 = New System.Windows.Forms.TextBox()
        Me.txtnmbrecontacto2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorModifCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContacto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(448, 470)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(147, 58)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Volver"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Volver al formulario anterior")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(266, 470)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(147, 58)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Registrar nueva familia")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 92)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Cliente"
        '
        'ErrorCliente
        '
        Me.ErrorCliente.ContainerControl = Me
        '
        'ErrorModifCliente
        '
        Me.ErrorModifCliente.ContainerControl = Me
        '
        'pnlContacto
        '
        Me.pnlContacto.Controls.Add(Me.GroupBox3)
        Me.pnlContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContacto.Location = New System.Drawing.Point(4, 4)
        Me.pnlContacto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlContacto.Name = "pnlContacto"
        Me.pnlContacto.Size = New System.Drawing.Size(803, 294)
        Me.pnlContacto.TabIndex = 52
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txttelfcontacto2)
        Me.GroupBox3.Controls.Add(Me.txtemailcontacto2)
        Me.GroupBox3.Controls.Add(Me.txtnmbrecontacto2)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(693, 271)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'txttelfcontacto2
        '
        Me.txttelfcontacto2.Location = New System.Drawing.Point(255, 89)
        Me.txttelfcontacto2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttelfcontacto2.Name = "txttelfcontacto2"
        Me.txttelfcontacto2.Size = New System.Drawing.Size(66, 22)
        Me.txttelfcontacto2.TabIndex = 49
        '
        'txtemailcontacto2
        '
        Me.txtemailcontacto2.Location = New System.Drawing.Point(255, 52)
        Me.txtemailcontacto2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtemailcontacto2.Name = "txtemailcontacto2"
        Me.txtemailcontacto2.Size = New System.Drawing.Size(371, 22)
        Me.txtemailcontacto2.TabIndex = 48
        '
        'txtnmbrecontacto2
        '
        Me.txtnmbrecontacto2.Location = New System.Drawing.Point(255, 18)
        Me.txtnmbrecontacto2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnmbrecontacto2.Name = "txtnmbrecontacto2"
        Me.txtnmbrecontacto2.Size = New System.Drawing.Size(66, 22)
        Me.txtnmbrecontacto2.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(88, 89)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 18)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Precio Unitario:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(88, 56)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(131, 18)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Nombre Producto:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(88, 18)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 18)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Order Id:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(36, 121)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 331)
        Me.TabControl1.TabIndex = 58
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlContacto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(811, 302)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle Pedido"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Cantidad:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(560, 85)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 22)
        Me.TextBox1.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 18)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha de confirmación:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(255, 124)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 53
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Location = New System.Drawing.Point(91, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 66)
        Me.Panel2.TabIndex = 56
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(123, 21)
        Me.RadioButton2.TabIndex = 57
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No Confirmado"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 21)
        Me.RadioButton1.TabIndex = 56
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Confirmado"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Observaciones: "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(318, 185)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(361, 22)
        Me.TextBox2.TabIndex = 58
        '
        'ModifCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 548)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ModifCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorModifCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContacto.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorCliente As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorModifCliente As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlContacto As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txttelfcontacto2 As TextBox
    Friend WithEvents txtemailcontacto2 As TextBox
    Friend WithEvents txtnmbrecontacto2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
