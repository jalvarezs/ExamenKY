<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.optConfiguracion = New System.Windows.Forms.Button()
        Me.optOperaciones = New System.Windows.Forms.Button()
        Me.optReportes = New System.Windows.Forms.Button()
        Me.optCotizaciones = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optSalir = New System.Windows.Forms.Button()
        Me.opcionesTabs = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnOfertas = New System.Windows.Forms.Button()
        Me.btnUbicaciones = New System.Windows.Forms.Button()
        Me.btnProyectos = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnAlmacenes = New System.Windows.Forms.Button()
        Me.btnZonas = New System.Windows.Forms.Button()
        Me.btnMarcas = New System.Windows.Forms.Button()
        Me.btnPerfiles = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnFamilias = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConsultarStock = New System.Windows.Forms.Button()
        Me.btnSugerencias = New System.Windows.Forms.Button()
        Me.btnContenedores = New System.Windows.Forms.Button()
        Me.btnModifStock = New System.Windows.Forms.Button()
        Me.btnAprobacionReq = New System.Windows.Forms.Button()
        Me.btnAltaReq = New System.Windows.Forms.Button()
        Me.btnSalidaMat = New System.Windows.Forms.Button()
        Me.btnIngresoMat = New System.Windows.Forms.Button()
        Me.btnOrdenes = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnStockArticuloContenedor = New System.Windows.Forms.Button()
        Me.btnStockArticuloSum = New System.Windows.Forms.Button()
        Me.BtnReporteCotizacion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnReporteMovimientos = New System.Windows.Forms.Button()
        Me.btnReporteSalidas = New System.Windows.Forms.Button()
        Me.btnReporteIngresos = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnQuiebreStockOT = New System.Windows.Forms.Button()
        Me.btnQuiebreStock = New System.Windows.Forms.Button()
        Me.btnControlServicios = New System.Windows.Forms.Button()
        Me.btnIniciosTrabajo = New System.Windows.Forms.Button()
        Me.btnCotizaciones = New System.Windows.Forms.Button()
        Me.toolTipBotones = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.opcionesTabs.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.opcionesTabs, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 396.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(742, 396)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_black_opt
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.optConfiguracion)
        Me.Panel1.Controls.Add(Me.optOperaciones)
        Me.Panel1.Controls.Add(Me.optReportes)
        Me.Panel1.Controls.Add(Me.optCotizaciones)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.optSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 396)
        Me.Panel1.TabIndex = 0
        '
        'optConfiguracion
        '
        Me.optConfiguracion.BackColor = System.Drawing.Color.White
        Me.optConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.optConfiguracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optConfiguracion.Image = Global.WES_II.My.Resources.Resources.Configuración
        Me.optConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optConfiguracion.Location = New System.Drawing.Point(0, 214)
        Me.optConfiguracion.Name = "optConfiguracion"
        Me.optConfiguracion.Size = New System.Drawing.Size(220, 36)
        Me.optConfiguracion.TabIndex = 7
        Me.optConfiguracion.Text = "Configuración"
        Me.optConfiguracion.UseVisualStyleBackColor = False
        '
        'optOperaciones
        '
        Me.optOperaciones.BackColor = System.Drawing.Color.White
        Me.optOperaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.optOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOperaciones.Image = Global.WES_II.My.Resources.Resources.Calculator
        Me.optOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optOperaciones.Location = New System.Drawing.Point(0, 250)
        Me.optOperaciones.Name = "optOperaciones"
        Me.optOperaciones.Size = New System.Drawing.Size(220, 36)
        Me.optOperaciones.TabIndex = 6
        Me.optOperaciones.Text = "Operaciones"
        Me.optOperaciones.UseVisualStyleBackColor = False
        '
        'optReportes
        '
        Me.optReportes.BackColor = System.Drawing.Color.White
        Me.optReportes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.optReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optReportes.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.optReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optReportes.Location = New System.Drawing.Point(0, 286)
        Me.optReportes.Name = "optReportes"
        Me.optReportes.Size = New System.Drawing.Size(220, 36)
        Me.optReportes.TabIndex = 5
        Me.optReportes.Text = "Reportes"
        Me.optReportes.UseVisualStyleBackColor = False
        '
        'optCotizaciones
        '
        Me.optCotizaciones.BackColor = System.Drawing.Color.White
        Me.optCotizaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.optCotizaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCotizaciones.Image = Global.WES_II.My.Resources.Resources.Cotizaciones
        Me.optCotizaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optCotizaciones.Location = New System.Drawing.Point(0, 322)
        Me.optCotizaciones.Name = "optCotizaciones"
        Me.optCotizaciones.Size = New System.Drawing.Size(220, 36)
        Me.optCotizaciones.TabIndex = 4
        Me.optCotizaciones.Text = "Cotizaciones"
        Me.optCotizaciones.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(143, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(73, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "GDA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Notificaciones:"
        '
        'optSalir
        '
        Me.optSalir.BackColor = System.Drawing.Color.White
        Me.optSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.optSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSalir.Image = Global.WES_II.My.Resources.Resources.LaunchPad
        Me.optSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optSalir.Location = New System.Drawing.Point(0, 358)
        Me.optSalir.Name = "optSalir"
        Me.optSalir.Size = New System.Drawing.Size(220, 36)
        Me.optSalir.TabIndex = 3
        Me.optSalir.Text = "Salir"
        Me.optSalir.UseVisualStyleBackColor = False
        '
        'opcionesTabs
        '
        Me.opcionesTabs.Controls.Add(Me.TabPage3)
        Me.opcionesTabs.Controls.Add(Me.TabPage4)
        Me.opcionesTabs.Controls.Add(Me.TabPage5)
        Me.opcionesTabs.Controls.Add(Me.TabPage6)
        Me.opcionesTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opcionesTabs.Location = New System.Drawing.Point(225, 3)
        Me.opcionesTabs.Name = "opcionesTabs"
        Me.opcionesTabs.SelectedIndex = 0
        Me.opcionesTabs.Size = New System.Drawing.Size(514, 390)
        Me.opcionesTabs.TabIndex = 15
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage3.Controls.Add(Me.btnOfertas)
        Me.TabPage3.Controls.Add(Me.btnUbicaciones)
        Me.TabPage3.Controls.Add(Me.btnProyectos)
        Me.TabPage3.Controls.Add(Me.btnUsuarios)
        Me.TabPage3.Controls.Add(Me.btnAlmacenes)
        Me.TabPage3.Controls.Add(Me.btnZonas)
        Me.TabPage3.Controls.Add(Me.btnMarcas)
        Me.TabPage3.Controls.Add(Me.btnPerfiles)
        Me.TabPage3.Controls.Add(Me.btnProveedores)
        Me.TabPage3.Controls.Add(Me.btnClientes)
        Me.TabPage3.Controls.Add(Me.btnProductos)
        Me.TabPage3.Controls.Add(Me.btnFamilias)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(506, 364)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Configuración"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnOfertas
        '
        Me.btnOfertas.BackColor = System.Drawing.Color.Transparent
        Me.btnOfertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOfertas.Image = Global.WES_II.My.Resources.Resources.Ofertas
        Me.btnOfertas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOfertas.Location = New System.Drawing.Point(160, 52)
        Me.btnOfertas.Name = "btnOfertas"
        Me.btnOfertas.Size = New System.Drawing.Size(79, 70)
        Me.btnOfertas.TabIndex = 17
        Me.btnOfertas.Text = "Ofertas"
        Me.btnOfertas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnOfertas, "Administrar almacenes centrales y temporales")
        Me.btnOfertas.UseVisualStyleBackColor = False
        Me.btnOfertas.Visible = False
        '
        'btnUbicaciones
        '
        Me.btnUbicaciones.BackColor = System.Drawing.Color.Transparent
        Me.btnUbicaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUbicaciones.Image = Global.WES_II.My.Resources.Resources.Ubicaciones
        Me.btnUbicaciones.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbicaciones.Location = New System.Drawing.Point(378, 52)
        Me.btnUbicaciones.Name = "btnUbicaciones"
        Me.btnUbicaciones.Size = New System.Drawing.Size(79, 70)
        Me.btnUbicaciones.TabIndex = 16
        Me.btnUbicaciones.Text = "Ubicaciones"
        Me.btnUbicaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnUbicaciones, "Administrar ubicaciones")
        Me.btnUbicaciones.UseVisualStyleBackColor = False
        '
        'btnProyectos
        '
        Me.btnProyectos.BackColor = System.Drawing.Color.Transparent
        Me.btnProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProyectos.Image = Global.WES_II.My.Resources.Resources.Proyectos
        Me.btnProyectos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProyectos.Location = New System.Drawing.Point(51, 52)
        Me.btnProyectos.Name = "btnProyectos"
        Me.btnProyectos.Size = New System.Drawing.Size(79, 70)
        Me.btnProyectos.TabIndex = 15
        Me.btnProyectos.Text = "Proyectos"
        Me.btnProyectos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnProyectos, "Administrar proyectos")
        Me.btnProyectos.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUsuarios.Image = Global.WES_II.My.Resources.Resources.Usuarios
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsuarios.Location = New System.Drawing.Point(375, 226)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(79, 70)
        Me.btnUsuarios.TabIndex = 14
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnUsuarios, "Administrar usuarios")
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnAlmacenes
        '
        Me.btnAlmacenes.BackColor = System.Drawing.Color.Transparent
        Me.btnAlmacenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlmacenes.Image = Global.WES_II.My.Resources.Resources.Numbers1
        Me.btnAlmacenes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAlmacenes.Location = New System.Drawing.Point(269, 52)
        Me.btnAlmacenes.Name = "btnAlmacenes"
        Me.btnAlmacenes.Size = New System.Drawing.Size(79, 70)
        Me.btnAlmacenes.TabIndex = 2
        Me.btnAlmacenes.Text = "Almacenes"
        Me.btnAlmacenes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnAlmacenes, "Administrar almacenes centrales y temporales")
        Me.btnAlmacenes.UseVisualStyleBackColor = False
        '
        'btnZonas
        '
        Me.btnZonas.BackColor = System.Drawing.Color.Transparent
        Me.btnZonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnZonas.Image = Global.WES_II.My.Resources.Resources.BootCamp
        Me.btnZonas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnZonas.Location = New System.Drawing.Point(375, 137)
        Me.btnZonas.Name = "btnZonas"
        Me.btnZonas.Size = New System.Drawing.Size(79, 70)
        Me.btnZonas.TabIndex = 4
        Me.btnZonas.Text = "Zonas"
        Me.btnZonas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnZonas, "Administrar zonas de carga y descarga")
        Me.btnZonas.UseVisualStyleBackColor = False
        '
        'btnMarcas
        '
        Me.btnMarcas.BackColor = System.Drawing.Color.Transparent
        Me.btnMarcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMarcas.Image = Global.WES_II.My.Resources.Resources.Marcas
        Me.btnMarcas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMarcas.Location = New System.Drawing.Point(160, 137)
        Me.btnMarcas.Name = "btnMarcas"
        Me.btnMarcas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMarcas.Size = New System.Drawing.Size(79, 70)
        Me.btnMarcas.TabIndex = 12
        Me.btnMarcas.Text = "Marcas"
        Me.btnMarcas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnMarcas, "Administrar marcas de productos")
        Me.btnMarcas.UseVisualStyleBackColor = False
        '
        'btnPerfiles
        '
        Me.btnPerfiles.BackColor = System.Drawing.Color.Transparent
        Me.btnPerfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPerfiles.Image = Global.WES_II.My.Resources.Resources.Perfiles
        Me.btnPerfiles.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPerfiles.Location = New System.Drawing.Point(269, 226)
        Me.btnPerfiles.Name = "btnPerfiles"
        Me.btnPerfiles.Size = New System.Drawing.Size(79, 70)
        Me.btnPerfiles.TabIndex = 13
        Me.btnPerfiles.Text = "Perfiles"
        Me.btnPerfiles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnPerfiles, "Administrar perfiles")
        Me.btnPerfiles.UseVisualStyleBackColor = False
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.Transparent
        Me.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProveedores.Image = Global.WES_II.My.Resources.Resources.Contacts
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedores.Location = New System.Drawing.Point(51, 226)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(79, 70)
        Me.btnProveedores.TabIndex = 3
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnProveedores, "Administrar proveedores")
        Me.btnProveedores.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClientes.Image = Global.WES_II.My.Resources.Resources.Clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.Location = New System.Drawing.Point(160, 226)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(79, 70)
        Me.btnClientes.TabIndex = 11
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnClientes, "Administrar clientes")
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.Transparent
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProductos.Image = Global.WES_II.My.Resources.Resources.AppStore
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProductos.Location = New System.Drawing.Point(269, 137)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(79, 70)
        Me.btnProductos.TabIndex = 5
        Me.btnProductos.Text = "Materiales"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnProductos, "Administrar materiales")
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnFamilias
        '
        Me.btnFamilias.BackColor = System.Drawing.Color.Transparent
        Me.btnFamilias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFamilias.Image = Global.WES_II.My.Resources.Resources.Chess
        Me.btnFamilias.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFamilias.Location = New System.Drawing.Point(51, 137)
        Me.btnFamilias.Name = "btnFamilias"
        Me.btnFamilias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFamilias.Size = New System.Drawing.Size(79, 70)
        Me.btnFamilias.TabIndex = 6
        Me.btnFamilias.Text = "Familias"
        Me.btnFamilias.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnFamilias, "Administrar familias de productos")
        Me.btnFamilias.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.WES_II.My.Resources.Resources.blue_flat_design
        Me.TabPage4.Controls.Add(Me.Button8)
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.btnConsultarStock)
        Me.TabPage4.Controls.Add(Me.btnSugerencias)
        Me.TabPage4.Controls.Add(Me.btnContenedores)
        Me.TabPage4.Controls.Add(Me.btnModifStock)
        Me.TabPage4.Controls.Add(Me.btnAprobacionReq)
        Me.TabPage4.Controls.Add(Me.btnAltaReq)
        Me.TabPage4.Controls.Add(Me.btnSalidaMat)
        Me.TabPage4.Controls.Add(Me.btnIngresoMat)
        Me.TabPage4.Controls.Add(Me.btnOrdenes)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(506, 364)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Operaciones"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(318, 18)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(87, 70)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "Usuario CF"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(16, 283)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(82, 70)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Carga Facturas"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(119, 283)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(82, 70)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Listado Facturas"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(220, 283)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 70)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Actualización Listado Facturas"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(323, 283)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 70)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Actualización Listado compras"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(323, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 70)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Listado Compras"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 70)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Carga Compras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnConsultarStock
        '
        Me.btnConsultarStock.BackColor = System.Drawing.Color.Transparent
        Me.btnConsultarStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultarStock.Image = Global.WES_II.My.Resources.Resources.StockMateriales
        Me.btnConsultarStock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultarStock.Location = New System.Drawing.Point(220, 200)
        Me.btnConsultarStock.Name = "btnConsultarStock"
        Me.btnConsultarStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnConsultarStock.Size = New System.Drawing.Size(82, 70)
        Me.btnConsultarStock.TabIndex = 16
        Me.btnConsultarStock.Text = "Consultar Stock"
        Me.btnConsultarStock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnConsultarStock, "Modificación de stock")
        Me.btnConsultarStock.UseVisualStyleBackColor = False
        '
        'btnSugerencias
        '
        Me.btnSugerencias.BackColor = System.Drawing.Color.Transparent
        Me.btnSugerencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSugerencias.Image = Global.WES_II.My.Resources.Resources.Sugerencias
        Me.btnSugerencias.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSugerencias.Location = New System.Drawing.Point(220, 18)
        Me.btnSugerencias.Name = "btnSugerencias"
        Me.btnSugerencias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSugerencias.Size = New System.Drawing.Size(82, 70)
        Me.btnSugerencias.TabIndex = 15
        Me.btnSugerencias.Text = "Sugerencias de compra"
        Me.btnSugerencias.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnSugerencias, "Registrar órdenes según sugerencias")
        Me.btnSugerencias.UseVisualStyleBackColor = False
        '
        'btnContenedores
        '
        Me.btnContenedores.BackColor = System.Drawing.Color.Transparent
        Me.btnContenedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnContenedores.Image = Global.WES_II.My.Resources.Resources.Contenedor
        Me.btnContenedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnContenedores.Location = New System.Drawing.Point(16, 200)
        Me.btnContenedores.Name = "btnContenedores"
        Me.btnContenedores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnContenedores.Size = New System.Drawing.Size(82, 70)
        Me.btnContenedores.TabIndex = 14
        Me.btnContenedores.Text = "Contenedores"
        Me.btnContenedores.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnContenedores, "Administrar contenedores")
        Me.btnContenedores.UseVisualStyleBackColor = False
        '
        'btnModifStock
        '
        Me.btnModifStock.BackColor = System.Drawing.Color.Transparent
        Me.btnModifStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModifStock.Image = Global.WES_II.My.Resources.Resources.ModifiStock
        Me.btnModifStock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModifStock.Location = New System.Drawing.Point(119, 200)
        Me.btnModifStock.Name = "btnModifStock"
        Me.btnModifStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnModifStock.Size = New System.Drawing.Size(82, 70)
        Me.btnModifStock.TabIndex = 13
        Me.btnModifStock.Text = "Trasladar Stock"
        Me.btnModifStock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnModifStock, "Modificación de stock")
        Me.btnModifStock.UseVisualStyleBackColor = False
        '
        'btnAprobacionReq
        '
        Me.btnAprobacionReq.BackColor = System.Drawing.Color.Transparent
        Me.btnAprobacionReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAprobacionReq.Image = Global.WES_II.My.Resources.Resources.Aprobacion
        Me.btnAprobacionReq.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAprobacionReq.Location = New System.Drawing.Point(119, 111)
        Me.btnAprobacionReq.Name = "btnAprobacionReq"
        Me.btnAprobacionReq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAprobacionReq.Size = New System.Drawing.Size(82, 70)
        Me.btnAprobacionReq.TabIndex = 12
        Me.btnAprobacionReq.Text = "Aprobación"
        Me.btnAprobacionReq.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnAprobacionReq, "Aprobación de requerimientos")
        Me.btnAprobacionReq.UseVisualStyleBackColor = False
        '
        'btnAltaReq
        '
        Me.btnAltaReq.BackColor = System.Drawing.Color.Transparent
        Me.btnAltaReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAltaReq.Image = Global.WES_II.My.Resources.Resources.Requerimiento
        Me.btnAltaReq.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAltaReq.Location = New System.Drawing.Point(16, 111)
        Me.btnAltaReq.Name = "btnAltaReq"
        Me.btnAltaReq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAltaReq.Size = New System.Drawing.Size(82, 70)
        Me.btnAltaReq.TabIndex = 11
        Me.btnAltaReq.Text = "Reque."
        Me.btnAltaReq.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnAltaReq, "Alta de requerimientos")
        Me.btnAltaReq.UseVisualStyleBackColor = False
        '
        'btnSalidaMat
        '
        Me.btnSalidaMat.BackColor = System.Drawing.Color.Transparent
        Me.btnSalidaMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalidaMat.Image = Global.WES_II.My.Resources.Resources.SalidasMat
        Me.btnSalidaMat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalidaMat.Location = New System.Drawing.Point(220, 111)
        Me.btnSalidaMat.Name = "btnSalidaMat"
        Me.btnSalidaMat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalidaMat.Size = New System.Drawing.Size(82, 70)
        Me.btnSalidaMat.TabIndex = 10
        Me.btnSalidaMat.Text = "Salida de materiales"
        Me.btnSalidaMat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnSalidaMat, "Registrar salida de materiales")
        Me.btnSalidaMat.UseVisualStyleBackColor = False
        '
        'btnIngresoMat
        '
        Me.btnIngresoMat.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresoMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnIngresoMat.Image = Global.WES_II.My.Resources.Resources.IngresosMat
        Me.btnIngresoMat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIngresoMat.Location = New System.Drawing.Point(119, 18)
        Me.btnIngresoMat.Name = "btnIngresoMat"
        Me.btnIngresoMat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIngresoMat.Size = New System.Drawing.Size(82, 70)
        Me.btnIngresoMat.TabIndex = 9
        Me.btnIngresoMat.Text = "Ingreso de materiales"
        Me.btnIngresoMat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnIngresoMat, "Registrar ingreso de materiales")
        Me.btnIngresoMat.UseVisualStyleBackColor = False
        '
        'btnOrdenes
        '
        Me.btnOrdenes.BackColor = System.Drawing.Color.Transparent
        Me.btnOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOrdenes.Image = Global.WES_II.My.Resources.Resources.Ordenes
        Me.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrdenes.Location = New System.Drawing.Point(16, 18)
        Me.btnOrdenes.Name = "btnOrdenes"
        Me.btnOrdenes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOrdenes.Size = New System.Drawing.Size(82, 70)
        Me.btnOrdenes.TabIndex = 8
        Me.btnOrdenes.Text = "Órdenes de compra"
        Me.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnOrdenes, "Administrar órdenes de compra")
        Me.btnOrdenes.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnStockArticuloContenedor)
        Me.TabPage5.Controls.Add(Me.btnStockArticuloSum)
        Me.TabPage5.Controls.Add(Me.BtnReporteCotizacion)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.btnReporteMovimientos)
        Me.TabPage5.Controls.Add(Me.btnReporteSalidas)
        Me.TabPage5.Controls.Add(Me.btnReporteIngresos)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(506, 364)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Reportes"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnStockArticuloContenedor
        '
        Me.btnStockArticuloContenedor.BackColor = System.Drawing.Color.Transparent
        Me.btnStockArticuloContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStockArticuloContenedor.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnStockArticuloContenedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockArticuloContenedor.Location = New System.Drawing.Point(276, 90)
        Me.btnStockArticuloContenedor.Name = "btnStockArticuloContenedor"
        Me.btnStockArticuloContenedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStockArticuloContenedor.Size = New System.Drawing.Size(171, 50)
        Me.btnStockArticuloContenedor.TabIndex = 18
        Me.btnStockArticuloContenedor.Text = "Reporte Stock Artículo por Contenedor"
        Me.btnStockArticuloContenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStockArticuloContenedor.UseVisualStyleBackColor = False
        '
        'btnStockArticuloSum
        '
        Me.btnStockArticuloSum.BackColor = System.Drawing.Color.Transparent
        Me.btnStockArticuloSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStockArticuloSum.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnStockArticuloSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockArticuloSum.Location = New System.Drawing.Point(276, 22)
        Me.btnStockArticuloSum.Name = "btnStockArticuloSum"
        Me.btnStockArticuloSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStockArticuloSum.Size = New System.Drawing.Size(171, 50)
        Me.btnStockArticuloSum.TabIndex = 17
        Me.btnStockArticuloSum.Text = "Reporte Stock Artículo Sumarizado"
        Me.btnStockArticuloSum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStockArticuloSum.UseVisualStyleBackColor = False
        '
        'BtnReporteCotizacion
        '
        Me.BtnReporteCotizacion.BackColor = System.Drawing.Color.Transparent
        Me.BtnReporteCotizacion.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.BtnReporteCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnReporteCotizacion.Location = New System.Drawing.Point(49, 268)
        Me.BtnReporteCotizacion.Name = "BtnReporteCotizacion"
        Me.BtnReporteCotizacion.Size = New System.Drawing.Size(171, 50)
        Me.BtnReporteCotizacion.TabIndex = 16
        Me.BtnReporteCotizacion.Text = "Cotización"
        Me.BtnReporteCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReporteCotizacion.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(49, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 50)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Inventarios"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnReporteMovimientos
        '
        Me.btnReporteMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.btnReporteMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReporteMovimientos.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnReporteMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteMovimientos.Location = New System.Drawing.Point(49, 148)
        Me.btnReporteMovimientos.Name = "btnReporteMovimientos"
        Me.btnReporteMovimientos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporteMovimientos.Size = New System.Drawing.Size(171, 50)
        Me.btnReporteMovimientos.TabIndex = 14
        Me.btnReporteMovimientos.Text = "Reporte Movimientos de Stock"
        Me.btnReporteMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporteMovimientos.UseVisualStyleBackColor = False
        '
        'btnReporteSalidas
        '
        Me.btnReporteSalidas.BackColor = System.Drawing.Color.Transparent
        Me.btnReporteSalidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReporteSalidas.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnReporteSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteSalidas.Location = New System.Drawing.Point(49, 90)
        Me.btnReporteSalidas.Name = "btnReporteSalidas"
        Me.btnReporteSalidas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporteSalidas.Size = New System.Drawing.Size(171, 50)
        Me.btnReporteSalidas.TabIndex = 13
        Me.btnReporteSalidas.Text = "Reporte de Salidas a Almacén"
        Me.btnReporteSalidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporteSalidas.UseVisualStyleBackColor = False
        '
        'btnReporteIngresos
        '
        Me.btnReporteIngresos.BackColor = System.Drawing.Color.Transparent
        Me.btnReporteIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReporteIngresos.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnReporteIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteIngresos.Location = New System.Drawing.Point(49, 22)
        Me.btnReporteIngresos.Name = "btnReporteIngresos"
        Me.btnReporteIngresos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporteIngresos.Size = New System.Drawing.Size(171, 50)
        Me.btnReporteIngresos.TabIndex = 12
        Me.btnReporteIngresos.Text = "Reporte de Ingresos a Almacén"
        Me.btnReporteIngresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporteIngresos.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnQuiebreStockOT)
        Me.TabPage6.Controls.Add(Me.btnQuiebreStock)
        Me.TabPage6.Controls.Add(Me.btnControlServicios)
        Me.TabPage6.Controls.Add(Me.btnIniciosTrabajo)
        Me.TabPage6.Controls.Add(Me.btnCotizaciones)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(506, 364)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Cotizaciones"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnQuiebreStockOT
        '
        Me.btnQuiebreStockOT.BackColor = System.Drawing.Color.Transparent
        Me.btnQuiebreStockOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnQuiebreStockOT.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnQuiebreStockOT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuiebreStockOT.Location = New System.Drawing.Point(36, 137)
        Me.btnQuiebreStockOT.Name = "btnQuiebreStockOT"
        Me.btnQuiebreStockOT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnQuiebreStockOT.Size = New System.Drawing.Size(93, 70)
        Me.btnQuiebreStockOT.TabIndex = 18
        Me.btnQuiebreStockOT.Text = "Quiebre Stock OT"
        Me.btnQuiebreStockOT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnQuiebreStockOT, "Modificación de stock")
        Me.btnQuiebreStockOT.UseVisualStyleBackColor = False
        '
        'btnQuiebreStock
        '
        Me.btnQuiebreStock.BackColor = System.Drawing.Color.Transparent
        Me.btnQuiebreStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnQuiebreStock.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnQuiebreStock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuiebreStock.Location = New System.Drawing.Point(389, 34)
        Me.btnQuiebreStock.Name = "btnQuiebreStock"
        Me.btnQuiebreStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnQuiebreStock.Size = New System.Drawing.Size(93, 70)
        Me.btnQuiebreStock.TabIndex = 17
        Me.btnQuiebreStock.Text = "Quiebre  Stock"
        Me.btnQuiebreStock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnQuiebreStock, "Modificación de stock")
        Me.btnQuiebreStock.UseVisualStyleBackColor = False
        '
        'btnControlServicios
        '
        Me.btnControlServicios.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.btnControlServicios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnControlServicios.Location = New System.Drawing.Point(274, 34)
        Me.btnControlServicios.Name = "btnControlServicios"
        Me.btnControlServicios.Size = New System.Drawing.Size(93, 70)
        Me.btnControlServicios.TabIndex = 11
        Me.btnControlServicios.Text = "Control Servicios"
        Me.btnControlServicios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnControlServicios.UseVisualStyleBackColor = True
        '
        'btnIniciosTrabajo
        '
        Me.btnIniciosTrabajo.BackColor = System.Drawing.Color.Transparent
        Me.btnIniciosTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnIniciosTrabajo.Image = Global.WES_II.My.Resources.Resources.Requerimiento
        Me.btnIniciosTrabajo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIniciosTrabajo.Location = New System.Drawing.Point(154, 34)
        Me.btnIniciosTrabajo.Name = "btnIniciosTrabajo"
        Me.btnIniciosTrabajo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIniciosTrabajo.Size = New System.Drawing.Size(93, 70)
        Me.btnIniciosTrabajo.TabIndex = 10
        Me.btnIniciosTrabajo.Text = "Inicios de Trabajo"
        Me.btnIniciosTrabajo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnIniciosTrabajo, "Administrar inicios de trabajo")
        Me.btnIniciosTrabajo.UseVisualStyleBackColor = False
        '
        'btnCotizaciones
        '
        Me.btnCotizaciones.BackColor = System.Drawing.Color.Transparent
        Me.btnCotizaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCotizaciones.Image = Global.WES_II.My.Resources.Resources.Cotizaciones
        Me.btnCotizaciones.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCotizaciones.Location = New System.Drawing.Point(36, 34)
        Me.btnCotizaciones.Name = "btnCotizaciones"
        Me.btnCotizaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCotizaciones.Size = New System.Drawing.Size(93, 70)
        Me.btnCotizaciones.TabIndex = 9
        Me.btnCotizaciones.Text = "Cotizaciones"
        Me.btnCotizaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTipBotones.SetToolTip(Me.btnCotizaciones, "Administrar cotizaciones")
        Me.btnCotizaciones.UseVisualStyleBackColor = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(742, 396)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.opcionesTabs.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents optSalir As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents toolTipBotones As System.Windows.Forms.ToolTip
    Friend WithEvents optCotizaciones As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents optConfiguracion As System.Windows.Forms.Button
    Friend WithEvents optOperaciones As System.Windows.Forms.Button
    Friend WithEvents optReportes As System.Windows.Forms.Button
    Friend WithEvents opcionesTabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnAlmacenes As System.Windows.Forms.Button
    Friend WithEvents btnZonas As System.Windows.Forms.Button
    Friend WithEvents btnMarcas As System.Windows.Forms.Button
    Friend WithEvents btnPerfiles As System.Windows.Forms.Button
    Friend WithEvents btnProveedores As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents btnFamilias As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents btnOrdenes As System.Windows.Forms.Button
    Friend WithEvents btnIngresoMat As System.Windows.Forms.Button
    Friend WithEvents btnSalidaMat As System.Windows.Forms.Button
    Friend WithEvents btnAltaReq As System.Windows.Forms.Button
    Friend WithEvents btnAprobacionReq As System.Windows.Forms.Button
    Friend WithEvents btnModifStock As System.Windows.Forms.Button
    Friend WithEvents btnContenedores As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnProyectos As System.Windows.Forms.Button
    Friend WithEvents btnUbicaciones As System.Windows.Forms.Button
    Friend WithEvents btnOfertas As System.Windows.Forms.Button
    Friend WithEvents btnSugerencias As System.Windows.Forms.Button
    Friend WithEvents btnCotizaciones As System.Windows.Forms.Button
    Friend WithEvents btnIniciosTrabajo As System.Windows.Forms.Button
    Friend WithEvents btnReporteIngresos As System.Windows.Forms.Button
    Friend WithEvents btnReporteSalidas As System.Windows.Forms.Button
    Friend WithEvents btnReporteMovimientos As System.Windows.Forms.Button
    Friend WithEvents btnConsultarStock As System.Windows.Forms.Button
    Friend WithEvents btnControlServicios As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BtnReporteCotizacion As Button
    Friend WithEvents btnQuiebreStockOT As Button
    Friend WithEvents btnQuiebreStock As Button
    Friend WithEvents btnStockArticuloContenedor As Button
    Friend WithEvents btnStockArticuloSum As Button
End Class
