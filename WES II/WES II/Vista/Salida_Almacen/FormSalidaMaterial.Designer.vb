<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalidaMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalidaMaterial))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvSalidas = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtNumDocumento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExamCont = New System.Windows.Forms.Button()
        Me.btnCantidadTotal = New System.Windows.Forms.Button()
        Me.dgvMateriales = New System.Windows.Forms.DataGridView()
        Me.btnCantidadParcial = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnExaminarR = New System.Windows.Forms.Button()
        Me.txtRequerimiento = New System.Windows.Forms.TextBox()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.txtAlmacenDestino = New System.Windows.Forms.TextBox()
        Me.txtCodOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFechaReq = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTipoDocBuscar = New System.Windows.Forms.ComboBox()
        Me.txtNumDocBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.cbTipoDocBuscar)
        Me.TabPage2.Controls.Add(Me.txtNumDocBuscar)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.dgvDetalles)
        Me.TabPage2.Controls.Add(Me.btnListar)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.dtpHasta)
        Me.TabPage2.Controls.Add(Me.dtpDesde)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.dgvSalidas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(876, 492)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Consultar salidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(22, 306)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.Size = New System.Drawing.Size(829, 166)
        Me.dgvDetalles.TabIndex = 100
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(551, 81)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(86, 23)
        Me.btnListar.TabIndex = 99
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(330, 47)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(194, 20)
        Me.dtpHasta.TabIndex = 97
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(71, 48)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(207, 20)
        Me.dtpDesde.TabIndex = 96
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Desde:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 15)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Listado de Salida de Materiales:"
        '
        'dgvSalidas
        '
        Me.dgvSalidas.AllowUserToAddRows = False
        Me.dgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalidas.Location = New System.Drawing.Point(22, 123)
        Me.dgvSalidas.Name = "dgvSalidas"
        Me.dgvSalidas.ReadOnly = True
        Me.dgvSalidas.Size = New System.Drawing.Size(829, 166)
        Me.dgvSalidas.TabIndex = 73
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cboTipoDocumento)
        Me.TabPage1.Controls.Add(Me.txtNumDocumento)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnExamCont)
        Me.TabPage1.Controls.Add(Me.btnCantidadTotal)
        Me.TabPage1.Controls.Add(Me.dgvMateriales)
        Me.TabPage1.Controls.Add(Me.btnCantidadParcial)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.btnExaminarR)
        Me.TabPage1.Controls.Add(Me.txtRequerimiento)
        Me.TabPage1.Controls.Add(Me.txtProyecto)
        Me.TabPage1.Controls.Add(Me.txtAlmacenDestino)
        Me.TabPage1.Controls.Add(Me.txtCodOrdenCompra)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dpFechaReq)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(876, 492)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar salidas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(404, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Tipo Documento:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(502, 130)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(128, 21)
        Me.cboTipoDocumento.TabIndex = 94
        '
        'txtNumDocumento
        '
        Me.txtNumDocumento.Location = New System.Drawing.Point(116, 130)
        Me.txtNumDocumento.MaxLength = 100
        Me.txtNumDocumento.Name = "txtNumDocumento"
        Me.txtNumDocumento.Size = New System.Drawing.Size(200, 20)
        Me.txtNumDocumento.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "N° Documento:"
        '
        'btnExamCont
        '
        Me.btnExamCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExamCont.Image = Global.WES_II.My.Resources.Resources.Contenedor
        Me.btnExamCont.Location = New System.Drawing.Point(724, 161)
        Me.btnExamCont.Name = "btnExamCont"
        Me.btnExamCont.Size = New System.Drawing.Size(145, 47)
        Me.btnExamCont.TabIndex = 90
        Me.btnExamCont.Text = "Definir Contenedor Origen"
        Me.btnExamCont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExamCont.UseVisualStyleBackColor = True
        '
        'btnCantidadTotal
        '
        Me.btnCantidadTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCantidadTotal.Image = Global.WES_II.My.Resources.Resources.Aprobacion
        Me.btnCantidadTotal.Location = New System.Drawing.Point(724, 292)
        Me.btnCantidadTotal.Name = "btnCantidadTotal"
        Me.btnCantidadTotal.Size = New System.Drawing.Size(145, 47)
        Me.btnCantidadTotal.TabIndex = 89
        Me.btnCantidadTotal.Text = "Definir Salida Total"
        Me.btnCantidadTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCantidadTotal.UseVisualStyleBackColor = True
        '
        'dgvMateriales
        '
        Me.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriales.Location = New System.Drawing.Point(22, 161)
        Me.dgvMateriales.Name = "dgvMateriales"
        Me.dgvMateriales.ReadOnly = True
        Me.dgvMateriales.Size = New System.Drawing.Size(688, 310)
        Me.dgvMateriales.TabIndex = 88
        '
        'btnCantidadParcial
        '
        Me.btnCantidadParcial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCantidadParcial.Image = Global.WES_II.My.Resources.Resources.Edit_32x32
        Me.btnCantidadParcial.Location = New System.Drawing.Point(724, 226)
        Me.btnCantidadParcial.Name = "btnCantidadParcial"
        Me.btnCantidadParcial.Size = New System.Drawing.Size(145, 47)
        Me.btnCantidadParcial.TabIndex = 87
        Me.btnCantidadParcial.Text = "Definir Cantidad Recibida"
        Me.btnCantidadParcial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCantidadParcial.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 15)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Registrar Salida Material:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Location = New System.Drawing.Point(724, 424)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(145, 47)
        Me.btnAceptar.TabIndex = 72
        Me.btnAceptar.Text = "    Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(724, 358)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(145, 47)
        Me.btnGuardar.TabIndex = 71
        Me.btnGuardar.Text = "     Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnExaminarR
        '
        Me.btnExaminarR.Location = New System.Drawing.Point(222, 43)
        Me.btnExaminarR.Name = "btnExaminarR"
        Me.btnExaminarR.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarR.TabIndex = 67
        Me.btnExaminarR.Text = "Examinar"
        Me.btnExaminarR.UseVisualStyleBackColor = True
        '
        'txtRequerimiento
        '
        Me.txtRequerimiento.Location = New System.Drawing.Point(116, 43)
        Me.txtRequerimiento.Name = "txtRequerimiento"
        Me.txtRequerimiento.ReadOnly = True
        Me.txtRequerimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtRequerimiento.TabIndex = 64
        '
        'txtProyecto
        '
        Me.txtProyecto.Location = New System.Drawing.Point(116, 69)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.ReadOnly = True
        Me.txtProyecto.Size = New System.Drawing.Size(100, 20)
        Me.txtProyecto.TabIndex = 59
        '
        'txtAlmacenDestino
        '
        Me.txtAlmacenDestino.Location = New System.Drawing.Point(502, 101)
        Me.txtAlmacenDestino.Name = "txtAlmacenDestino"
        Me.txtAlmacenDestino.ReadOnly = True
        Me.txtAlmacenDestino.Size = New System.Drawing.Size(128, 20)
        Me.txtAlmacenDestino.TabIndex = 56
        '
        'txtCodOrdenCompra
        '
        Me.txtCodOrdenCompra.Location = New System.Drawing.Point(502, 72)
        Me.txtCodOrdenCompra.Name = "txtCodOrdenCompra"
        Me.txtCodOrdenCompra.ReadOnly = True
        Me.txtCodOrdenCompra.Size = New System.Drawing.Size(128, 20)
        Me.txtCodOrdenCompra.TabIndex = 55
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(502, 43)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(128, 20)
        Me.txtCodigo.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "(*) Requerimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Almacén destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Orden de compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "(*) Código:"
        '
        'dpFechaReq
        '
        Me.dpFechaReq.Location = New System.Drawing.Point(116, 101)
        Me.dpFechaReq.Name = "dpFechaReq"
        Me.dpFechaReq.Size = New System.Drawing.Size(200, 20)
        Me.dpFechaReq.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "(*) Proyecto:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(884, 518)
        Me.TabControl1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 83)
        Me.Panel1.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Salida de Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Tipo Documento:"
        '
        'cbTipoDocBuscar
        '
        Me.cbTipoDocBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocBuscar.FormattingEnabled = True
        Me.cbTipoDocBuscar.Location = New System.Drawing.Point(379, 83)
        Me.cbTipoDocBuscar.Name = "cbTipoDocBuscar"
        Me.cbTipoDocBuscar.Size = New System.Drawing.Size(145, 21)
        Me.cbTipoDocBuscar.TabIndex = 103
        '
        'txtNumDocBuscar
        '
        Me.txtNumDocBuscar.Location = New System.Drawing.Point(115, 83)
        Me.txtNumDocBuscar.MaxLength = 100
        Me.txtNumDocBuscar.Name = "txtNumDocBuscar"
        Me.txtNumDocBuscar.Size = New System.Drawing.Size(163, 20)
        Me.txtNumDocBuscar.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "N° Documento:"
        '
        'FormSalidaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 601)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSalidaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Salida de Materiales"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtAlmacenDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtCodOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpFechaReq As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvSalidas As System.Windows.Forms.DataGridView
    Friend WithEvents btnCantidadParcial As System.Windows.Forms.Button
    Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents btnExaminarR As System.Windows.Forms.Button
    Friend WithEvents txtRequerimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCantidadTotal As System.Windows.Forms.Button
    Friend WithEvents btnExamCont As System.Windows.Forms.Button
    Friend WithEvents txtNumDocumento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboTipoDocumento As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbTipoDocBuscar As ComboBox
    Friend WithEvents txtNumDocBuscar As TextBox
    Friend WithEvents Label11 As Label
End Class
