<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifCliente))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorModifCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.pnlinfobanco = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbSoles1 = New System.Windows.Forms.RadioButton()
        Me.rbDolar1 = New System.Windows.Forms.RadioButton()
        Me.txtccibanco2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtcuentabanco2 = New System.Windows.Forms.TextBox()
        Me.txtbanco2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbSoles = New System.Windows.Forms.RadioButton()
        Me.rbDolar = New System.Windows.Forms.RadioButton()
        Me.txtccibanco1 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtcuentabanco1 = New System.Windows.Forms.TextBox()
        Me.txtbanco1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.pnlContacto = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txttelfcontacto2 = New System.Windows.Forms.TextBox()
        Me.txtemailcontacto2 = New System.Windows.Forms.TextBox()
        Me.txtnmbrecontacto2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txttelfcontacto1 = New System.Windows.Forms.TextBox()
        Me.txtemailcontacto1 = New System.Windows.Forms.TextBox()
        Me.txtnmbrecontacto1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btninfobancos = New System.Windows.Forms.Button()
        Me.btninfocontacto = New System.Windows.Forms.Button()
        Me.btninfocomercial = New System.Windows.Forms.Button()
        Me.pnlBasico = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtTelf = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtTelfSec = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorModifCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlinfobanco.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.pnlContacto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlBasico.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(404, 382)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
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
        Me.btnGuardar.Location = New System.Drawing.Point(268, 382)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
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
        'txtWeb
        '
        Me.txtWeb.Location = New System.Drawing.Point(134, 189)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(212, 20)
        Me.txtWeb.TabIndex = 41
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(134, 163)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(212, 20)
        Me.txtEmail.TabIndex = 40
        '
        'pnlinfobanco
        '
        Me.pnlinfobanco.Controls.Add(Me.GroupBox4)
        Me.pnlinfobanco.Controls.Add(Me.GroupBox5)
        Me.pnlinfobanco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlinfobanco.Location = New System.Drawing.Point(0, 0)
        Me.pnlinfobanco.Name = "pnlinfobanco"
        Me.pnlinfobanco.Size = New System.Drawing.Size(606, 243)
        Me.pnlinfobanco.TabIndex = 53
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbSoles1)
        Me.GroupBox4.Controls.Add(Me.rbDolar1)
        Me.GroupBox4.Controls.Add(Me.txtccibanco2)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtcuentabanco2)
        Me.GroupBox4.Controls.Add(Me.txtbanco2)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Location = New System.Drawing.Point(37, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Banco 2"
        '
        'rbSoles1
        '
        Me.rbSoles1.AutoSize = True
        Me.rbSoles1.Checked = True
        Me.rbSoles1.Location = New System.Drawing.Point(402, 18)
        Me.rbSoles1.Name = "rbSoles1"
        Me.rbSoles1.Size = New System.Drawing.Size(40, 17)
        Me.rbSoles1.TabIndex = 48
        Me.rbSoles1.TabStop = True
        Me.rbSoles1.Text = "S/."
        Me.rbSoles1.UseVisualStyleBackColor = True
        '
        'rbDolar1
        '
        Me.rbDolar1.AutoSize = True
        Me.rbDolar1.Location = New System.Drawing.Point(455, 18)
        Me.rbDolar1.Name = "rbDolar1"
        Me.rbDolar1.Size = New System.Drawing.Size(31, 17)
        Me.rbDolar1.TabIndex = 49
        Me.rbDolar1.Text = "$"
        Me.rbDolar1.UseVisualStyleBackColor = True
        '
        'txtccibanco2
        '
        Me.txtccibanco2.Location = New System.Drawing.Point(128, 73)
        Me.txtccibanco2.Name = "txtccibanco2"
        Me.txtccibanco2.Size = New System.Drawing.Size(377, 20)
        Me.txtccibanco2.TabIndex = 45
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(76, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 15)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = " CCI:"
        '
        'txtcuentabanco2
        '
        Me.txtcuentabanco2.Location = New System.Drawing.Point(127, 46)
        Me.txtcuentabanco2.Name = "txtcuentabanco2"
        Me.txtcuentabanco2.Size = New System.Drawing.Size(377, 20)
        Me.txtcuentabanco2.TabIndex = 43
        '
        'txtbanco2
        '
        Me.txtbanco2.Location = New System.Drawing.Point(83, 16)
        Me.txtbanco2.Name = "txtbanco2"
        Me.txtbanco2.Size = New System.Drawing.Size(188, 20)
        Me.txtbanco2.TabIndex = 41
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 46)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 15)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Cuenta Corriente:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(304, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 15)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Moneda:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(58, 15)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = " Nombre:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbSoles)
        Me.GroupBox5.Controls.Add(Me.rbDolar)
        Me.GroupBox5.Controls.Add(Me.txtccibanco1)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.txtcuentabanco1)
        Me.GroupBox5.Controls.Add(Me.txtbanco1)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Location = New System.Drawing.Point(37, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(520, 100)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Banco 1"
        '
        'rbSoles
        '
        Me.rbSoles.AutoSize = True
        Me.rbSoles.Checked = True
        Me.rbSoles.Location = New System.Drawing.Point(402, 18)
        Me.rbSoles.Name = "rbSoles"
        Me.rbSoles.Size = New System.Drawing.Size(40, 17)
        Me.rbSoles.TabIndex = 48
        Me.rbSoles.TabStop = True
        Me.rbSoles.Text = "S/."
        Me.rbSoles.UseVisualStyleBackColor = True
        '
        'rbDolar
        '
        Me.rbDolar.AutoSize = True
        Me.rbDolar.Location = New System.Drawing.Point(455, 18)
        Me.rbDolar.Name = "rbDolar"
        Me.rbDolar.Size = New System.Drawing.Size(31, 17)
        Me.rbDolar.TabIndex = 49
        Me.rbDolar.Text = "$"
        Me.rbDolar.UseVisualStyleBackColor = True
        '
        'txtccibanco1
        '
        Me.txtccibanco1.Location = New System.Drawing.Point(128, 73)
        Me.txtccibanco1.Name = "txtccibanco1"
        Me.txtccibanco1.Size = New System.Drawing.Size(377, 20)
        Me.txtccibanco1.TabIndex = 45
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(76, 73)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(29, 15)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "CCI:"
        '
        'txtcuentabanco1
        '
        Me.txtcuentabanco1.Location = New System.Drawing.Point(127, 46)
        Me.txtcuentabanco1.Name = "txtcuentabanco1"
        Me.txtcuentabanco1.Size = New System.Drawing.Size(377, 20)
        Me.txtcuentabanco1.TabIndex = 43
        '
        'txtbanco1
        '
        Me.txtbanco1.Location = New System.Drawing.Point(83, 16)
        Me.txtbanco1.Name = "txtbanco1"
        Me.txtbanco1.Size = New System.Drawing.Size(188, 20)
        Me.txtbanco1.TabIndex = 41
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(7, 46)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(102, 15)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "Cuenta Corriente:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(304, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 15)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "Moneda:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 15)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Nombre:"
        '
        'pnlContacto
        '
        Me.pnlContacto.Controls.Add(Me.GroupBox3)
        Me.pnlContacto.Controls.Add(Me.GroupBox2)
        Me.pnlContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContacto.Location = New System.Drawing.Point(3, 3)
        Me.pnlContacto.Name = "pnlContacto"
        Me.pnlContacto.Size = New System.Drawing.Size(600, 237)
        Me.pnlContacto.TabIndex = 52
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttelfcontacto2)
        Me.GroupBox3.Controls.Add(Me.txtemailcontacto2)
        Me.GroupBox3.Controls.Add(Me.txtnmbrecontacto2)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(37, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto 2"
        '
        'txttelfcontacto2
        '
        Me.txttelfcontacto2.Location = New System.Drawing.Point(181, 71)
        Me.txttelfcontacto2.Name = "txttelfcontacto2"
        Me.txttelfcontacto2.Size = New System.Drawing.Size(279, 20)
        Me.txttelfcontacto2.TabIndex = 49
        '
        'txtemailcontacto2
        '
        Me.txtemailcontacto2.Location = New System.Drawing.Point(181, 45)
        Me.txtemailcontacto2.Name = "txtemailcontacto2"
        Me.txtemailcontacto2.Size = New System.Drawing.Size(279, 20)
        Me.txtemailcontacto2.TabIndex = 48
        '
        'txtnmbrecontacto2
        '
        Me.txtnmbrecontacto2.Location = New System.Drawing.Point(181, 15)
        Me.txtnmbrecontacto2.Name = "txtnmbrecontacto2"
        Me.txtnmbrecontacto2.Size = New System.Drawing.Size(279, 20)
        Me.txtnmbrecontacto2.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(101, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 15)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = " Teléfono:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(129, 46)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 15)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "E-mail:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(104, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 15)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = " Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttelfcontacto1)
        Me.GroupBox2.Controls.Add(Me.txtemailcontacto1)
        Me.GroupBox2.Controls.Add(Me.txtnmbrecontacto1)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contacto 1"
        '
        'txttelfcontacto1
        '
        Me.txttelfcontacto1.Location = New System.Drawing.Point(179, 72)
        Me.txttelfcontacto1.Name = "txttelfcontacto1"
        Me.txttelfcontacto1.Size = New System.Drawing.Size(279, 20)
        Me.txttelfcontacto1.TabIndex = 43
        '
        'txtemailcontacto1
        '
        Me.txtemailcontacto1.Location = New System.Drawing.Point(179, 46)
        Me.txtemailcontacto1.Name = "txtemailcontacto1"
        Me.txtemailcontacto1.Size = New System.Drawing.Size(279, 20)
        Me.txtemailcontacto1.TabIndex = 42
        '
        'txtnmbrecontacto1
        '
        Me.txtnmbrecontacto1.Location = New System.Drawing.Point(179, 16)
        Me.txtnmbrecontacto1.Name = "txtnmbrecontacto1"
        Me.txtnmbrecontacto1.Size = New System.Drawing.Size(279, 20)
        Me.txtnmbrecontacto1.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(99, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 15)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = " Teléfono:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(127, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 15)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "E-mail:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(102, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 15)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Nombre:"
        '
        'btninfobancos
        '
        Me.btninfobancos.Location = New System.Drawing.Point(658, 279)
        Me.btninfobancos.Name = "btninfobancos"
        Me.btninfobancos.Size = New System.Drawing.Size(125, 66)
        Me.btninfobancos.TabIndex = 56
        Me.btninfobancos.Text = "Información Bancaria"
        Me.btninfobancos.UseVisualStyleBackColor = True
        '
        'btninfocontacto
        '
        Me.btninfocontacto.Location = New System.Drawing.Point(658, 208)
        Me.btninfocontacto.Name = "btninfocontacto"
        Me.btninfocontacto.Size = New System.Drawing.Size(125, 65)
        Me.btninfocontacto.TabIndex = 55
        Me.btninfocontacto.Text = "Persona de Contacto"
        Me.btninfocontacto.UseVisualStyleBackColor = True
        '
        'btninfocomercial
        '
        Me.btninfocomercial.Location = New System.Drawing.Point(658, 137)
        Me.btninfocomercial.Name = "btninfocomercial"
        Me.btninfocomercial.Size = New System.Drawing.Size(125, 66)
        Me.btninfocomercial.TabIndex = 54
        Me.btninfocomercial.Text = "Informacion Comercial"
        Me.btninfocomercial.UseVisualStyleBackColor = True
        '
        'pnlBasico
        '
        Me.pnlBasico.Controls.Add(Me.Label2)
        Me.pnlBasico.Controls.Add(Me.Label31)
        Me.pnlBasico.Controls.Add(Me.txtDistrito)
        Me.pnlBasico.Controls.Add(Me.txtRUC)
        Me.pnlBasico.Controls.Add(Me.Label34)
        Me.pnlBasico.Controls.Add(Me.txtTelf)
        Me.pnlBasico.Controls.Add(Me.Label35)
        Me.pnlBasico.Controls.Add(Me.Label36)
        Me.pnlBasico.Controls.Add(Me.txtEmail)
        Me.pnlBasico.Controls.Add(Me.txtWeb)
        Me.pnlBasico.Controls.Add(Me.txtTelfSec)
        Me.pnlBasico.Controls.Add(Me.Label37)
        Me.pnlBasico.Controls.Add(Me.txtDireccion)
        Me.pnlBasico.Controls.Add(Me.Label38)
        Me.pnlBasico.Controls.Add(Me.txtNombre)
        Me.pnlBasico.Controls.Add(Me.Label39)
        Me.pnlBasico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBasico.Location = New System.Drawing.Point(3, 3)
        Me.pnlBasico.Name = "pnlBasico"
        Me.pnlBasico.Size = New System.Drawing.Size(600, 237)
        Me.pnlBasico.TabIndex = 57
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(373, 163)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 15)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "Distrito:"
        '
        'txtDistrito
        '
        Me.txtDistrito.Location = New System.Drawing.Point(427, 161)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(116, 20)
        Me.txtDistrito.TabIndex = 37
        '
        'txtRUC
        '
        Me.txtRUC.Location = New System.Drawing.Point(427, 54)
        Me.txtRUC.MaxLength = 11
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(116, 20)
        Me.txtRUC.TabIndex = 32
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(385, 55)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(36, 15)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "RUC:"
        '
        'txtTelf
        '
        Me.txtTelf.Location = New System.Drawing.Point(134, 81)
        Me.txtTelf.Name = "txtTelf"
        Me.txtTelf.Size = New System.Drawing.Size(116, 20)
        Me.txtTelf.TabIndex = 33
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(44, 85)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(74, 15)
        Me.Label35.TabIndex = 34
        Me.Label35.Text = "(*) Teléfono:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(76, 164)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(42, 15)
        Me.Label36.TabIndex = 39
        Me.Label36.Text = "Email:"
        '
        'txtTelfSec
        '
        Me.txtTelfSec.Location = New System.Drawing.Point(427, 80)
        Me.txtTelfSec.Name = "txtTelfSec"
        Me.txtTelfSec.Size = New System.Drawing.Size(116, 20)
        Me.txtTelfSec.TabIndex = 34
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(299, 81)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(122, 15)
        Me.Label37.TabIndex = 36
        Me.Label37.Text = "Teléfono secundario:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(134, 107)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(409, 48)
        Me.txtDireccion.TabIndex = 35
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(40, 124)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 15)
        Me.Label38.TabIndex = 32
        Me.Label38.Text = "(*) Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(134, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(116, 20)
        Me.txtNombre.TabIndex = 31
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(47, 49)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 15)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "(*) Nombre:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(27, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(614, 269)
        Me.TabControl1.TabIndex = 58
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlContacto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(606, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Info. Comercial"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pnlBasico)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(606, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Info. Contacto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.pnlinfobanco)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(606, 243)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Info. Financiera"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Web:"
        '
        'ModifCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 445)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btninfobancos)
        Me.Controls.Add(Me.btninfocontacto)
        Me.Controls.Add(Me.btninfocomercial)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModifCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorModifCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlinfobanco.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.pnlContacto.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlBasico.ResumeLayout(False)
        Me.pnlBasico.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorCliente As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorModifCliente As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents pnlinfobanco As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtccibanco2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtcuentabanco2 As TextBox
    Friend WithEvents txtbanco2 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtccibanco1 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtcuentabanco1 As TextBox
    Friend WithEvents txtbanco1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents pnlContacto As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txttelfcontacto2 As TextBox
    Friend WithEvents txtemailcontacto2 As TextBox
    Friend WithEvents txtnmbrecontacto2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txttelfcontacto1 As TextBox
    Friend WithEvents txtemailcontacto1 As TextBox
    Friend WithEvents txtnmbrecontacto1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btninfobancos As Button
    Friend WithEvents btninfocontacto As Button
    Friend WithEvents btninfocomercial As Button
    Friend WithEvents pnlBasico As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtTelf As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txtTelfSec As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents rbSoles As RadioButton
    Friend WithEvents rbDolar As RadioButton
    Friend WithEvents rbSoles1 As RadioButton
    Friend WithEvents rbDolar1 As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
End Class
