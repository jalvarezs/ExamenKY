<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSugCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.Seleccione = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CantidadComprar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.idprov = New System.Windows.Forms.TextBox()
        Me.vdirec = New System.Windows.Forms.TextBox()
        Me.vruc = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 87)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Examinar materiales por debajo del Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Proveedor:"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefrescar.Image = Global.WES_II.My.Resources.Resources.Buscar_32x32
        Me.btnRefrescar.Location = New System.Drawing.Point(792, 87)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(111, 54)
        Me.btnRefrescar.TabIndex = 45
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(362, 436)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 46
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = False
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccione, Me.CantidadComprar})
        Me.dgvProducto.Location = New System.Drawing.Point(12, 143)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.Size = New System.Drawing.Size(891, 287)
        Me.dgvProducto.TabIndex = 47
        '
        'Seleccione
        '
        Me.Seleccione.HeaderText = "Seleccione"
        Me.Seleccione.Name = "Seleccione"
        '
        'CantidadComprar
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.CantidadComprar.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadComprar.HeaderText = "Cantidad a Comprar"
        Me.CantidadComprar.MaxInputLength = 6
        Me.CantidadComprar.Name = "CantidadComprar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.idprov)
        Me.Panel2.Controls.Add(Me.vdirec)
        Me.Panel2.Controls.Add(Me.vruc)
        Me.Panel2.Location = New System.Drawing.Point(879, 442)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 13)
        Me.Panel2.TabIndex = 50
        Me.Panel2.Visible = False
        '
        'idprov
        '
        Me.idprov.Location = New System.Drawing.Point(83, 0)
        Me.idprov.Name = "idprov"
        Me.idprov.Size = New System.Drawing.Size(24, 24)
        Me.idprov.TabIndex = 2
        '
        'vdirec
        '
        Me.vdirec.Location = New System.Drawing.Point(44, 3)
        Me.vdirec.Name = "vdirec"
        Me.vdirec.Size = New System.Drawing.Size(24, 24)
        Me.vdirec.TabIndex = 1
        '
        'vruc
        '
        Me.vruc.Location = New System.Drawing.Point(3, 3)
        Me.vruc.Name = "vruc"
        Me.vruc.Size = New System.Drawing.Size(10, 24)
        Me.vruc.TabIndex = 0
        '
        'Dtp_fecha
        '
        Me.Dtp_fecha.Location = New System.Drawing.Point(528, 105)
        Me.Dtp_fecha.Name = "Dtp_fecha"
        Me.Dtp_fecha.Size = New System.Drawing.Size(221, 24)
        Me.Dtp_fecha.TabIndex = 51
        Me.Dtp_fecha.Value = New Date(2019, 10, 12, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(474, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Fecha:"
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(113, 104)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(315, 26)
        Me.cbProveedor.TabIndex = 53
        '
        'FormSugCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 485)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dtp_fecha)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormSugCompra"
        Me.Text = "GDA - Sugerencia de Compra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgvProducto As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents vdirec As TextBox
    Friend WithEvents vruc As TextBox
    Friend WithEvents idprov As TextBox
    Friend WithEvents Seleccione As DataGridViewCheckBoxColumn
    Friend WithEvents CantidadComprar As DataGridViewTextBoxColumn
    Friend WithEvents Dtp_fecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cbProveedor As ComboBox
End Class
