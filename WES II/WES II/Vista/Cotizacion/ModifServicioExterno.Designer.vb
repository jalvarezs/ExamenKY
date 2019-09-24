<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifServicioExterno
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlBotones = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btnCotizacionOSE = New System.Windows.Forms.Button()
        Me.txtCotizacionOSE = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.txtDetalleOSE = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTotalOSE = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtDirproveedor = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitarioOSE = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtCantidadOSE = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 75)
        Me.Panel1.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Servicio Externo"
        '
        'PnlBotones
        '
        Me.PnlBotones.Controls.Add(Me.btnAceptar)
        Me.PnlBotones.Controls.Add(Me.btnGuardar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotones.Location = New System.Drawing.Point(0, 335)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.Size = New System.Drawing.Size(757, 69)
        Me.PnlBotones.TabIndex = 72
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(385, 12)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 56
        Me.btnAceptar.Text = "Volver"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(269, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 55
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(29, 132)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(137, 15)
        Me.Label39.TabIndex = 89
        Me.Label39.Text = "(*) Dirección Proveedor:"
        '
        'btnCotizacionOSE
        '
        Me.btnCotizacionOSE.Location = New System.Drawing.Point(269, 160)
        Me.btnCotizacionOSE.Name = "btnCotizacionOSE"
        Me.btnCotizacionOSE.Size = New System.Drawing.Size(83, 23)
        Me.btnCotizacionOSE.TabIndex = 88
        Me.btnCotizacionOSE.Text = "Examinar"
        Me.btnCotizacionOSE.UseVisualStyleBackColor = True
        '
        'txtCotizacionOSE
        '
        Me.txtCotizacionOSE.Enabled = False
        Me.txtCotizacionOSE.Location = New System.Drawing.Point(117, 163)
        Me.txtCotizacionOSE.Name = "txtCotizacionOSE"
        Me.txtCotizacionOSE.ReadOnly = True
        Me.txtCotizacionOSE.Size = New System.Drawing.Size(138, 20)
        Me.txtCotizacionOSE.TabIndex = 87
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(29, 165)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(83, 15)
        Me.Label38.TabIndex = 86
        Me.Label38.Text = "(*) Cotización:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(29, 95)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 15)
        Me.Label31.TabIndex = 73
        Me.Label31.Text = "(*) Proveedor:"
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(117, 95)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(138, 20)
        Me.txtProveedor.TabIndex = 74
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(358, 95)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(83, 23)
        Me.btnBuscarProveedor.TabIndex = 75
        Me.btnBuscarProveedor.Text = "Examinar"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'txtDetalleOSE
        '
        Me.txtDetalleOSE.Location = New System.Drawing.Point(117, 201)
        Me.txtDetalleOSE.MaxLength = 600
        Me.txtDetalleOSE.Multiline = True
        Me.txtDetalleOSE.Name = "txtDetalleOSE"
        Me.txtDetalleOSE.Size = New System.Drawing.Size(583, 108)
        Me.txtDetalleOSE.TabIndex = 79
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(29, 202)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 15)
        Me.Label33.TabIndex = 78
        Me.Label33.Text = "(*) Detalle:"
        '
        'txtTotalOSE
        '
        Me.txtTotalOSE.Enabled = False
        Me.txtTotalOSE.Location = New System.Drawing.Point(592, 166)
        Me.txtTotalOSE.Name = "txtTotalOSE"
        Me.txtTotalOSE.ReadOnly = True
        Me.txtTotalOSE.Size = New System.Drawing.Size(108, 20)
        Me.txtTotalOSE.TabIndex = 85
        '
        'txtRuc
        '
        Me.txtRuc.Enabled = False
        Me.txtRuc.Location = New System.Drawing.Point(261, 95)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(91, 20)
        Me.txtRuc.TabIndex = 76
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(534, 168)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 15)
        Me.Label36.TabIndex = 84
        Me.Label36.Text = "(*) Total:"
        '
        'txtDirproveedor
        '
        Me.txtDirproveedor.Enabled = False
        Me.txtDirproveedor.Location = New System.Drawing.Point(170, 129)
        Me.txtDirproveedor.Name = "txtDirproveedor"
        Me.txtDirproveedor.ReadOnly = True
        Me.txtDirproveedor.Size = New System.Drawing.Size(182, 20)
        Me.txtDirproveedor.TabIndex = 77
        '
        'txtPrecioUnitarioOSE
        '
        Me.txtPrecioUnitarioOSE.Location = New System.Drawing.Point(592, 130)
        Me.txtPrecioUnitarioOSE.Name = "txtPrecioUnitarioOSE"
        Me.txtPrecioUnitarioOSE.Size = New System.Drawing.Size(108, 20)
        Me.txtPrecioUnitarioOSE.TabIndex = 83
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(481, 132)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(107, 15)
        Me.Label35.TabIndex = 82
        Me.Label35.Text = "(*) Precio Unitario:"
        '
        'txtCantidadOSE
        '
        Me.txtCantidadOSE.Location = New System.Drawing.Point(592, 93)
        Me.txtCantidadOSE.Name = "txtCantidadOSE"
        Me.txtCantidadOSE.Size = New System.Drawing.Size(108, 20)
        Me.txtCantidadOSE.TabIndex = 81
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(513, 95)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(75, 15)
        Me.Label34.TabIndex = 80
        Me.Label34.Text = "(*) Cantidad:"
        '
        'ModifServicioExterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 404)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.btnCotizacionOSE)
        Me.Controls.Add(Me.txtCotizacionOSE)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.btnBuscarProveedor)
        Me.Controls.Add(Me.txtDetalleOSE)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txtTotalOSE)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtDirproveedor)
        Me.Controls.Add(Me.txtPrecioUnitarioOSE)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtCantidadOSE)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.PnlBotones)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ModifServicioExterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Servicio Externo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlBotones.ResumeLayout(False)
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlBotones As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents errorProvider As ErrorProvider
    Friend WithEvents Label39 As Label
    Friend WithEvents btnCotizacionOSE As Button
    Friend WithEvents txtCotizacionOSE As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents txtDetalleOSE As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtTotalOSE As TextBox
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtDirproveedor As TextBox
    Friend WithEvents txtPrecioUnitarioOSE As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtCantidadOSE As TextBox
    Friend WithEvents Label34 As Label
End Class
