<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAprobacionRequerimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAprobacionRequerimiento))
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnListarReq = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnDenegar = New System.Windows.Forms.Button()
        Me.btnAprobar = New System.Windows.Forms.Button()
        Me.dgvRequerimiento = New System.Windows.Forms.DataGridView()
        Me.rdb_ordcomp = New System.Windows.Forms.RadioButton()
        Me.rdb_req = New System.Windows.Forms.RadioButton()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(708, 83)
        Me.Panel1.TabIndex = 134
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(562, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Aprobación de Ordenes de Compra / Requerimientos"
        '
        'btnListarReq
        '
        Me.btnListarReq.Location = New System.Drawing.Point(574, 152)
        Me.btnListarReq.Name = "btnListarReq"
        Me.btnListarReq.Size = New System.Drawing.Size(110, 31)
        Me.btnListarReq.TabIndex = 143
        Me.btnListarReq.Text = "Listar "
        Me.btnListarReq.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(303, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 142
        Me.Label13.Text = "Hasta:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(364, 156)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(194, 20)
        Me.dtpFechaFin.TabIndex = 141
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(82, 155)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(207, 20)
        Me.dtpFechaInicio.TabIndex = 140
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "Desde:"
        '
        'btnDenegar
        '
        Me.btnDenegar.BackgroundImage = Global.WES_II.My.Resources.Resources.Cancel_32x32
        Me.btnDenegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDenegar.Location = New System.Drawing.Point(574, 382)
        Me.btnDenegar.Name = "btnDenegar"
        Me.btnDenegar.Size = New System.Drawing.Size(110, 47)
        Me.btnDenegar.TabIndex = 137
        Me.btnDenegar.Text = "     Denegar"
        Me.btnDenegar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDenegar.UseVisualStyleBackColor = True
        '
        'btnAprobar
        '
        Me.btnAprobar.BackgroundImage = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAprobar.Location = New System.Drawing.Point(574, 274)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(110, 47)
        Me.btnAprobar.TabIndex = 136
        Me.btnAprobar.Text = "      Aprobar"
        Me.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAprobar.UseVisualStyleBackColor = True
        '
        'dgvRequerimiento
        '
        Me.dgvRequerimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequerimiento.Location = New System.Drawing.Point(31, 195)
        Me.dgvRequerimiento.Name = "dgvRequerimiento"
        Me.dgvRequerimiento.ReadOnly = True
        Me.dgvRequerimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequerimiento.Size = New System.Drawing.Size(527, 333)
        Me.dgvRequerimiento.TabIndex = 135
        '
        'rdb_ordcomp
        '
        Me.rdb_ordcomp.AutoSize = True
        Me.rdb_ordcomp.Location = New System.Drawing.Point(33, 110)
        Me.rdb_ordcomp.Name = "rdb_ordcomp"
        Me.rdb_ordcomp.Size = New System.Drawing.Size(124, 17)
        Me.rdb_ordcomp.TabIndex = 144
        Me.rdb_ordcomp.TabStop = True
        Me.rdb_ordcomp.Text = "Lista Ord. de Compra"
        Me.rdb_ordcomp.UseVisualStyleBackColor = True
        '
        'rdb_req
        '
        Me.rdb_req.AutoSize = True
        Me.rdb_req.Location = New System.Drawing.Point(221, 110)
        Me.rdb_req.Name = "rdb_req"
        Me.rdb_req.Size = New System.Drawing.Size(123, 17)
        Me.rdb_req.TabIndex = 145
        Me.rdb_req.TabStop = True
        Me.rdb_req.Text = "Lista Requerimientos"
        Me.rdb_req.UseVisualStyleBackColor = True
        '
        'FormAprobacionRequerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 555)
        Me.Controls.Add(Me.rdb_req)
        Me.Controls.Add(Me.rdb_ordcomp)
        Me.Controls.Add(Me.btnListarReq)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnDenegar)
        Me.Controls.Add(Me.btnAprobar)
        Me.Controls.Add(Me.dgvRequerimiento)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAprobacionRequerimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Aprobación de Requerimiento"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnListarReq As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnDenegar As System.Windows.Forms.Button
    Friend WithEvents btnAprobar As System.Windows.Forms.Button
    Friend WithEvents dgvRequerimiento As System.Windows.Forms.DataGridView
    Friend WithEvents rdb_req As RadioButton
    Friend WithEvents rdb_ordcomp As RadioButton
End Class
