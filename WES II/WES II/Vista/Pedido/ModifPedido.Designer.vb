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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifPedido))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorModifCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlContacto = New System.Windows.Forms.Panel()
        Me.txt_orderId = New System.Windows.Forms.TextBox()
        Me.txt_idCliente = New System.Windows.Forms.TextBox()
        Me.txt_observa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdb_confirma = New System.Windows.Forms.RadioButton()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_modpedido = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_valortotal = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorModifCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContacto.SuspendLayout()
        CType(Me.dgv_modpedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(341, 522)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 92)
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
        Me.Label1.Size = New System.Drawing.Size(215, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Pedido"
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
        Me.pnlContacto.Controls.Add(Me.txt_valortotal)
        Me.pnlContacto.Controls.Add(Me.txt_orderId)
        Me.pnlContacto.Controls.Add(Me.txt_idCliente)
        Me.pnlContacto.Controls.Add(Me.txt_observa)
        Me.pnlContacto.Controls.Add(Me.Label4)
        Me.pnlContacto.Controls.Add(Me.Label3)
        Me.pnlContacto.Controls.Add(Me.rdb_confirma)
        Me.pnlContacto.Controls.Add(Me.dtp_fecha)
        Me.pnlContacto.Controls.Add(Me.Label2)
        Me.pnlContacto.Controls.Add(Me.dgv_modpedido)
        Me.pnlContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContacto.Location = New System.Drawing.Point(4, 4)
        Me.pnlContacto.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContacto.Name = "pnlContacto"
        Me.pnlContacto.Size = New System.Drawing.Size(782, 381)
        Me.pnlContacto.TabIndex = 52
        '
        'txt_orderId
        '
        Me.txt_orderId.Location = New System.Drawing.Point(724, 337)
        Me.txt_orderId.Name = "txt_orderId"
        Me.txt_orderId.Size = New System.Drawing.Size(29, 29)
        Me.txt_orderId.TabIndex = 13
        Me.txt_orderId.Visible = False
        Me.txt_orderId.WordWrap = False
        '
        'txt_idCliente
        '
        Me.txt_idCliente.Location = New System.Drawing.Point(724, 305)
        Me.txt_idCliente.Name = "txt_idCliente"
        Me.txt_idCliente.Size = New System.Drawing.Size(29, 29)
        Me.txt_idCliente.TabIndex = 12
        Me.txt_idCliente.Visible = False
        '
        'txt_observa
        '
        Me.txt_observa.Location = New System.Drawing.Point(235, 314)
        Me.txt_observa.Multiline = True
        Me.txt_observa.Name = "txt_observa"
        Me.txt_observa.Size = New System.Drawing.Size(333, 52)
        Me.txt_observa.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Comentarios :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(553, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total"
        '
        'rdb_confirma
        '
        Me.rdb_confirma.AutoSize = True
        Me.rdb_confirma.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_confirma.Location = New System.Drawing.Point(179, 249)
        Me.rdb_confirma.Name = "rdb_confirma"
        Me.rdb_confirma.Size = New System.Drawing.Size(103, 22)
        Me.rdb_confirma.TabIndex = 7
        Me.rdb_confirma.TabStop = True
        Me.rdb_confirma.Text = "Confirmado"
        Me.rdb_confirma.UseVisualStyleBackColor = True
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CustomFormat = "dd/mm/yyyy"
        Me.dtp_fecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(24, 250)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(123, 26)
        Me.dtp_fecha.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pedido "
        '
        'dgv_modpedido
        '
        Me.dgv_modpedido.AllowUserToAddRows = False
        Me.dgv_modpedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_modpedido.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_modpedido.Location = New System.Drawing.Point(24, 29)
        Me.dgv_modpedido.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_modpedido.Name = "dgv_modpedido"
        Me.dgv_modpedido.ReadOnly = True
        Me.dgv_modpedido.Size = New System.Drawing.Size(729, 214)
        Me.dgv_modpedido.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 100)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(798, 418)
        Me.TabControl1.TabIndex = 58
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlContacto)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(790, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Confirmación de Pedido"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_valortotal
        '
        Me.txt_valortotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_valortotal.Enabled = False
        Me.txt_valortotal.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valortotal.Location = New System.Drawing.Point(631, 255)
        Me.txt_valortotal.MaxLength = 10
        Me.txt_valortotal.Name = "txt_valortotal"
        Me.txt_valortotal.Size = New System.Drawing.Size(100, 29)
        Me.txt_valortotal.TabIndex = 14
        Me.txt_valortotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ModifPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 586)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModifPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KY Pedidos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorModifCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContacto.ResumeLayout(False)
        Me.pnlContacto.PerformLayout()
        CType(Me.dgv_modpedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorCliente As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorModifCliente As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlContacto As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_observa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rdb_confirma As RadioButton
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_modpedido As DataGridView
    Friend WithEvents txt_idCliente As TextBox
    Friend WithEvents txt_orderId As TextBox
    Friend WithEvents txt_valortotal As TextBox
End Class
