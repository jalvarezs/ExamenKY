<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaFactura
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mesDet = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.personal = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.modificacion = New System.Windows.Forms.CheckBox()
        Me.fc = New System.Windows.Forms.DateTimePicker()
        Me.fpago_ = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pagosdet = New System.Windows.Forms.TextBox()
        Me.fechadet = New System.Windows.Forms.DateTimePicker()
        Me.cancelada_ = New System.Windows.Forms.TextBox()
        Me.controlpagado = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.IGV_ = New System.Windows.Forms.TextBox()
        Me.porcdet = New System.Windows.Forms.TextBox()
        Me.subtotal_ = New System.Windows.Forms.TextBox()
        Me.guia_ = New System.Windows.Forms.TextBox()
        Me.nrooc = New System.Windows.Forms.TextBox()
        Me.nroproforma = New System.Windows.Forms.TextBox()
        Me.fechaemision = New System.Windows.Forms.DateTimePicker()
        Me.detret = New System.Windows.Forms.TextBox()
        Me.detalle2 = New System.Windows.Forms.TextBox()
        Me.ruc2 = New System.Windows.Forms.TextBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.nrofactura = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DS_Wes_II_TestB = New WES_II.DS_Wes_II_TestB()
        Me.DSWesIITestBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSWesIITestBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DS_Wes_II_TestB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSWesIITestBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSWesIITestBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1031, 442)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.mesDet)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.personal)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.modificacion)
        Me.TabPage1.Controls.Add(Me.fc)
        Me.TabPage1.Controls.Add(Me.fpago_)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.pagosdet)
        Me.TabPage1.Controls.Add(Me.fechadet)
        Me.TabPage1.Controls.Add(Me.cancelada_)
        Me.TabPage1.Controls.Add(Me.controlpagado)
        Me.TabPage1.Controls.Add(Me.total)
        Me.TabPage1.Controls.Add(Me.IGV_)
        Me.TabPage1.Controls.Add(Me.porcdet)
        Me.TabPage1.Controls.Add(Me.subtotal_)
        Me.TabPage1.Controls.Add(Me.guia_)
        Me.TabPage1.Controls.Add(Me.nrooc)
        Me.TabPage1.Controls.Add(Me.nroproforma)
        Me.TabPage1.Controls.Add(Me.fechaemision)
        Me.TabPage1.Controls.Add(Me.detret)
        Me.TabPage1.Controls.Add(Me.detalle2)
        Me.TabPage1.Controls.Add(Me.ruc2)
        Me.TabPage1.Controls.Add(Me.txtcliente)
        Me.TabPage1.Controls.Add(Me.nrofactura)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1023, 416)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Facturas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'mesDet
        '
        Me.mesDet.FormattingEnabled = True
        Me.mesDet.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.mesDet.Location = New System.Drawing.Point(121, 122)
        Me.mesDet.Name = "mesDet"
        Me.mesDet.Size = New System.Drawing.Size(100, 21)
        Me.mesDet.TabIndex = 45
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(446, 43)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Seleccionar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 380)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 25
        '
        'personal
        '
        Me.personal.Enabled = False
        Me.personal.Location = New System.Drawing.Point(340, 71)
        Me.personal.Name = "personal"
        Me.personal.Size = New System.Drawing.Size(100, 20)
        Me.personal.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(446, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Seleccionar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(923, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Seleccionar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'modificacion
        '
        Me.modificacion.AutoSize = True
        Me.modificacion.Enabled = False
        Me.modificacion.Location = New System.Drawing.Point(148, 382)
        Me.modificacion.Name = "modificacion"
        Me.modificacion.Size = New System.Drawing.Size(86, 17)
        Me.modificacion.TabIndex = 26
        Me.modificacion.Text = "Modificacion"
        Me.modificacion.UseVisualStyleBackColor = True
        '
        'fc
        '
        Me.fc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fc.Location = New System.Drawing.Point(817, 123)
        Me.fc.Name = "fc"
        Me.fc.Size = New System.Drawing.Size(113, 20)
        Me.fc.TabIndex = 19
        '
        'fpago_
        '
        Me.fpago_.Location = New System.Drawing.Point(817, 149)
        Me.fpago_.Name = "fpago_"
        Me.fpago_.Size = New System.Drawing.Size(100, 20)
        Me.fpago_.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(729, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 13)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Forma P"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(842, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pagosdet
        '
        Me.pagosdet.Location = New System.Drawing.Point(614, 149)
        Me.pagosdet.Name = "pagosdet"
        Me.pagosdet.Size = New System.Drawing.Size(100, 20)
        Me.pagosdet.TabIndex = 22
        '
        'fechadet
        '
        Me.fechadet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechadet.Location = New System.Drawing.Point(121, 149)
        Me.fechadet.Name = "fechadet"
        Me.fechadet.Size = New System.Drawing.Size(113, 20)
        Me.fechadet.TabIndex = 20
        '
        'cancelada_
        '
        Me.cancelada_.Location = New System.Drawing.Point(340, 123)
        Me.cancelada_.Name = "cancelada_"
        Me.cancelada_.Size = New System.Drawing.Size(100, 20)
        Me.cancelada_.TabIndex = 17
        '
        'controlpagado
        '
        Me.controlpagado.Location = New System.Drawing.Point(817, 97)
        Me.controlpagado.Name = "controlpagado"
        Me.controlpagado.Size = New System.Drawing.Size(100, 20)
        Me.controlpagado.TabIndex = 15
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(614, 97)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 14
        '
        'IGV_
        '
        Me.IGV_.Location = New System.Drawing.Point(817, 71)
        Me.IGV_.Name = "IGV_"
        Me.IGV_.Size = New System.Drawing.Size(100, 20)
        Me.IGV_.TabIndex = 11
        '
        'porcdet
        '
        Me.porcdet.Location = New System.Drawing.Point(614, 123)
        Me.porcdet.Name = "porcdet"
        Me.porcdet.Size = New System.Drawing.Size(100, 20)
        Me.porcdet.TabIndex = 18
        '
        'subtotal_
        '
        Me.subtotal_.Location = New System.Drawing.Point(340, 97)
        Me.subtotal_.Name = "subtotal_"
        Me.subtotal_.Size = New System.Drawing.Size(100, 20)
        Me.subtotal_.TabIndex = 13
        '
        'guia_
        '
        Me.guia_.Location = New System.Drawing.Point(121, 97)
        Me.guia_.Name = "guia_"
        Me.guia_.Size = New System.Drawing.Size(100, 20)
        Me.guia_.TabIndex = 12
        '
        'nrooc
        '
        Me.nrooc.Location = New System.Drawing.Point(614, 71)
        Me.nrooc.Name = "nrooc"
        Me.nrooc.Size = New System.Drawing.Size(100, 20)
        Me.nrooc.TabIndex = 10
        '
        'nroproforma
        '
        Me.nroproforma.Enabled = False
        Me.nroproforma.Location = New System.Drawing.Point(340, 45)
        Me.nroproforma.Name = "nroproforma"
        Me.nroproforma.Size = New System.Drawing.Size(100, 20)
        Me.nroproforma.TabIndex = 0
        '
        'fechaemision
        '
        Me.fechaemision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaemision.Location = New System.Drawing.Point(614, 45)
        Me.fechaemision.Name = "fechaemision"
        Me.fechaemision.Size = New System.Drawing.Size(109, 20)
        Me.fechaemision.TabIndex = 2
        Me.fechaemision.Value = New Date(2017, 11, 14, 10, 41, 0, 0)
        '
        'detret
        '
        Me.detret.Location = New System.Drawing.Point(340, 149)
        Me.detret.Name = "detret"
        Me.detret.Size = New System.Drawing.Size(100, 20)
        Me.detret.TabIndex = 21
        '
        'detalle2
        '
        Me.detalle2.Location = New System.Drawing.Point(121, 192)
        Me.detalle2.Multiline = True
        Me.detalle2.Name = "detalle2"
        Me.detalle2.Size = New System.Drawing.Size(796, 100)
        Me.detalle2.TabIndex = 24
        '
        'ruc2
        '
        Me.ruc2.Enabled = False
        Me.ruc2.Location = New System.Drawing.Point(121, 71)
        Me.ruc2.Name = "ruc2"
        Me.ruc2.Size = New System.Drawing.Size(100, 20)
        Me.ruc2.TabIndex = 6
        '
        'txtcliente
        '
        Me.txtcliente.Enabled = False
        Me.txtcliente.Location = New System.Drawing.Point(817, 46)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtcliente.TabIndex = 3
        '
        'nrofactura
        '
        Me.nrofactura.Enabled = False
        Me.nrofactura.Location = New System.Drawing.Point(121, 45)
        Me.nrofactura.Name = "nrofactura"
        Me.nrofactura.Size = New System.Drawing.Size(100, 20)
        Me.nrofactura.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(527, 152)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Pago S/det"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(31, 155)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Fecha Det"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(527, 126)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "% Det / Ret"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Mes Det"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(240, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Det/Ret"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(729, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Fecha Can."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(240, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Cancelada"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(729, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Control Pagado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(527, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(729, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "IGV"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(240, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Sub Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Guía R"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(527, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Nro. Orden C."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Per. autorizado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Nro proforma"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Detalle fact."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "RUC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(729, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Emp. emitida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(527, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Emision"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nro. Factura"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1023, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Facturas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DS_Wes_II_TestB
        '
        Me.DS_Wes_II_TestB.DataSetName = "DS_Wes_II_TestB"
        Me.DS_Wes_II_TestB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DSWesIITestBBindingSource
        '
        Me.DSWesIITestBBindingSource.DataSource = Me.DS_Wes_II_TestB
        Me.DSWesIITestBBindingSource.Position = 0
        '
        'DSWesIITestBBindingSource1
        '
        Me.DSWesIITestBBindingSource1.DataSource = Me.DS_Wes_II_TestB
        Me.DSWesIITestBBindingSource1.Position = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 75)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carga Facturas"
        '
        'frmCargaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 512)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCargaFactura"
        Me.Text = "Carga Factura"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DS_Wes_II_TestB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSWesIITestBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSWesIITestBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents fechaemision As DateTimePicker
    Friend WithEvents detret As TextBox
    Friend WithEvents detalle2 As TextBox
    Friend WithEvents ruc2 As TextBox
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents nrofactura As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents pagosdet As TextBox
    Friend WithEvents fechadet As DateTimePicker
    Friend WithEvents cancelada_ As TextBox
    Friend WithEvents controlpagado As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents IGV_ As TextBox
    Friend WithEvents porcdet As TextBox

    Friend WithEvents subtotal_ As TextBox
    Friend WithEvents guia_ As TextBox
    Friend WithEvents nrooc As TextBox
    Friend WithEvents nroproforma As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents fpago_ As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents fc As DateTimePicker
    Friend WithEvents modificacion As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DSWesIITestBBindingSource1 As BindingSource
    Friend WithEvents DS_Wes_II_TestB As DS_Wes_II_TestB
    Friend WithEvents DSWesIITestBBindingSource As BindingSource
    Friend WithEvents Button3 As Button
    Friend WithEvents personal As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents mesDet As ComboBox
End Class
