<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte_Cotizacion
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
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TpgGeneral = New System.Windows.Forms.TabPage()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.BtnGenerarReporte = New System.Windows.Forms.Button()
        Me.txtEncabezadoReporte = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPrefijoCliente = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnbuscarCotizacion = New System.Windows.Forms.Button()
        Me.txtCotizacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLugarCotizacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TpgConfiguraciones = New System.Windows.Forms.TabPage()
        Me.TabFormatos = New System.Windows.Forms.TabControl()
        Me.TpgLugarFecha = New System.Windows.Forms.TabPage()
        Me.BtnColorLugarFecha = New System.Windows.Forms.Button()
        Me.pnlColorLugarFecha = New System.Windows.Forms.Panel()
        Me.LblColorLugarFecha = New System.Windows.Forms.Label()
        Me.txtTestFuenteLugarFecha = New System.Windows.Forms.RichTextBox()
        Me.BtnFuenteLugarFecha = New System.Windows.Forms.Button()
        Me.txtFuenteLugarFecha = New System.Windows.Forms.TextBox()
        Me.LblFuenteLugarFecha = New System.Windows.Forms.Label()
        Me.TpgDestinatario = New System.Windows.Forms.TabPage()
        Me.BtnColorDestinatario = New System.Windows.Forms.Button()
        Me.PnlColorDestinatario = New System.Windows.Forms.Panel()
        Me.LblColorDestinatario = New System.Windows.Forms.Label()
        Me.txtTestFuenteDestinatario = New System.Windows.Forms.RichTextBox()
        Me.BtnFuenteDestinatario = New System.Windows.Forms.Button()
        Me.txtFuenteDestinatario = New System.Windows.Forms.TextBox()
        Me.LblFuenteDestinatario = New System.Windows.Forms.Label()
        Me.TpgFolioCotizacion = New System.Windows.Forms.TabPage()
        Me.BtnColorFolioCotizacion = New System.Windows.Forms.Button()
        Me.PnlColorFolioCotizacion = New System.Windows.Forms.Panel()
        Me.LblColorFolioCotizacion = New System.Windows.Forms.Label()
        Me.txtTestFuenteFolioCotizacion = New System.Windows.Forms.RichTextBox()
        Me.BtnFuenteFolioCotizacion = New System.Windows.Forms.Button()
        Me.txtFuenteFolioCotizacion = New System.Windows.Forms.TextBox()
        Me.LblFuenteFolioCotizacion = New System.Windows.Forms.Label()
        Me.TpgTextoEncabezado = New System.Windows.Forms.TabPage()
        Me.BtnColorTextoEncabezado = New System.Windows.Forms.Button()
        Me.PnlColorTextoEncabezado = New System.Windows.Forms.Panel()
        Me.LblColorTextoEncabezado = New System.Windows.Forms.Label()
        Me.txtTestFuenteTextoEncabezado = New System.Windows.Forms.RichTextBox()
        Me.BtnFuenteTextoEncabezado = New System.Windows.Forms.Button()
        Me.txtFuenteTextoEncabezado = New System.Windows.Forms.TextBox()
        Me.LblFuenteTextoEncabezado = New System.Windows.Forms.Label()
        Me.TpgEncabezadoPrincipal = New System.Windows.Forms.TabPage()
        Me.BtnColorEncabezadoPrincipal = New System.Windows.Forms.Button()
        Me.PnlColorEncabezadoPrincipal = New System.Windows.Forms.Panel()
        Me.LblColorEncabezadoPrincipal = New System.Windows.Forms.Label()
        Me.txtTestFuenteEncabezadoPrincipal = New System.Windows.Forms.RichTextBox()
        Me.BtnFuenteEncabezadoPrincipal = New System.Windows.Forms.Button()
        Me.txtFuenteEncabezadoPrincipal = New System.Windows.Forms.TextBox()
        Me.LblFuenteEncabezadoPrincipal = New System.Windows.Forms.Label()
        Me.TpgEncabezadoSecundario = New System.Windows.Forms.TabPage()
        Me.BtnColorEncabezadoSecundario = New System.Windows.Forms.Button()
        Me.PnlColorEncabezadoSecundario = New System.Windows.Forms.Panel()
        Me.LblColorEncabezadoSecundario = New System.Windows.Forms.Label()
        Me.txtTestFuenteEncabezadoSecundario = New System.Windows.Forms.RichTextBox()
        Me.BtnFuenteEncabezadoSecundario = New System.Windows.Forms.Button()
        Me.txtFuenteEncabezadoSecundario = New System.Windows.Forms.TextBox()
        Me.LblFuenteEncabezadoSecundario = New System.Windows.Forms.Label()
        Me.TpgTextoEstandar = New System.Windows.Forms.TabPage()
        Me.BtnColorTextEstandar = New System.Windows.Forms.Button()
        Me.PnlColorTextEstandar = New System.Windows.Forms.Panel()
        Me.LblColorTextEstandar = New System.Windows.Forms.Label()
        Me.txtTestFuenteTextEstandar = New System.Windows.Forms.RichTextBox()
        Me.BtnFuenteTextEstandar = New System.Windows.Forms.Button()
        Me.txtFuenteTextEstandar = New System.Windows.Forms.TextBox()
        Me.LblFuenteTextEstandar = New System.Windows.Forms.Label()
        Me.TpgReporte = New System.Windows.Forms.TabPage()
        Me.CrvReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FontSelector = New System.Windows.Forms.FontDialog()
        Me.ColorSelector = New System.Windows.Forms.ColorDialog()
        Me.Informe_Cotizacion1 = New WES_II.Informe_Cotizacion()
        Me.PnlHeader.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.TpgGeneral.SuspendLayout()
        Me.TpgConfiguraciones.SuspendLayout()
        Me.TabFormatos.SuspendLayout()
        Me.TpgLugarFecha.SuspendLayout()
        Me.TpgDestinatario.SuspendLayout()
        Me.TpgFolioCotizacion.SuspendLayout()
        Me.TpgTextoEncabezado.SuspendLayout()
        Me.TpgEncabezadoPrincipal.SuspendLayout()
        Me.TpgEncabezadoSecundario.SuspendLayout()
        Me.TpgTextoEstandar.SuspendLayout()
        Me.TpgReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.PnlHeader.Controls.Add(Me.Label1)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(985, 62)
        Me.PnlHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte de Cotizaciones"
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TpgGeneral)
        Me.TabMain.Controls.Add(Me.TpgConfiguraciones)
        Me.TabMain.Controls.Add(Me.TpgReporte)
        Me.TabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMain.Location = New System.Drawing.Point(0, 62)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(985, 479)
        Me.TabMain.TabIndex = 1
        '
        'TpgGeneral
        '
        Me.TpgGeneral.Controls.Add(Me.txtRuc)
        Me.TpgGeneral.Controls.Add(Me.BtnGenerarReporte)
        Me.TpgGeneral.Controls.Add(Me.txtEncabezadoReporte)
        Me.TpgGeneral.Controls.Add(Me.Label5)
        Me.TpgGeneral.Controls.Add(Me.cmbPrefijoCliente)
        Me.TpgGeneral.Controls.Add(Me.txtCliente)
        Me.TpgGeneral.Controls.Add(Me.Label4)
        Me.TpgGeneral.Controls.Add(Me.BtnbuscarCotizacion)
        Me.TpgGeneral.Controls.Add(Me.txtCotizacion)
        Me.TpgGeneral.Controls.Add(Me.Label3)
        Me.TpgGeneral.Controls.Add(Me.txtLugarCotizacion)
        Me.TpgGeneral.Controls.Add(Me.Label2)
        Me.TpgGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TpgGeneral.Name = "TpgGeneral"
        Me.TpgGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgGeneral.Size = New System.Drawing.Size(977, 453)
        Me.TpgGeneral.TabIndex = 0
        Me.TpgGeneral.Text = "General"
        Me.TpgGeneral.UseVisualStyleBackColor = True
        '
        'txtRuc
        '
        Me.txtRuc.Enabled = False
        Me.txtRuc.Location = New System.Drawing.Point(190, 38)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(76, 20)
        Me.txtRuc.TabIndex = 13
        '
        'BtnGenerarReporte
        '
        Me.BtnGenerarReporte.Image = Global.WES_II.My.Resources.Resources.Reportes
        Me.BtnGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGenerarReporte.Location = New System.Drawing.Point(632, 12)
        Me.BtnGenerarReporte.Name = "BtnGenerarReporte"
        Me.BtnGenerarReporte.Size = New System.Drawing.Size(100, 69)
        Me.BtnGenerarReporte.TabIndex = 10
        Me.BtnGenerarReporte.Text = "&Generar Reporte"
        Me.BtnGenerarReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGenerarReporte.UseVisualStyleBackColor = True
        '
        'txtEncabezadoReporte
        '
        Me.txtEncabezadoReporte.Location = New System.Drawing.Point(135, 94)
        Me.txtEncabezadoReporte.Name = "txtEncabezadoReporte"
        Me.txtEncabezadoReporte.Size = New System.Drawing.Size(437, 135)
        Me.txtEncabezadoReporte.TabIndex = 9
        Me.txtEncabezadoReporte.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Encabezado del reporte:"
        '
        'cmbPrefijoCliente
        '
        Me.cmbPrefijoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrefijoCliente.FormattingEnabled = True
        Me.cmbPrefijoCliente.Items.AddRange(New Object() {"Sr.", "Sra.", "Srita.", "Doc.", "Lic.", "Arq.", "Ing."})
        Me.cmbPrefijoCliente.Location = New System.Drawing.Point(135, 38)
        Me.cmbPrefijoCliente.Name = "cmbPrefijoCliente"
        Me.cmbPrefijoCliente.Size = New System.Drawing.Size(51, 21)
        Me.cmbPrefijoCliente.TabIndex = 4
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(272, 38)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtCliente.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'BtnbuscarCotizacion
        '
        Me.BtnbuscarCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnbuscarCotizacion.Image = Global.WES_II.My.Resources.Resources.Buscar_24x24
        Me.BtnbuscarCotizacion.Location = New System.Drawing.Point(323, 10)
        Me.BtnbuscarCotizacion.Name = "BtnbuscarCotizacion"
        Me.BtnbuscarCotizacion.Size = New System.Drawing.Size(25, 25)
        Me.BtnbuscarCotizacion.TabIndex = 2
        Me.BtnbuscarCotizacion.UseVisualStyleBackColor = True
        '
        'txtCotizacion
        '
        Me.txtCotizacion.Enabled = False
        Me.txtCotizacion.Location = New System.Drawing.Point(136, 12)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.ReadOnly = True
        Me.txtCotizacion.Size = New System.Drawing.Size(174, 20)
        Me.txtCotizacion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cotización:"
        '
        'txtLugarCotizacion
        '
        Me.txtLugarCotizacion.Location = New System.Drawing.Point(135, 65)
        Me.txtLugarCotizacion.Name = "txtLugarCotizacion"
        Me.txtLugarCotizacion.Size = New System.Drawing.Size(437, 20)
        Me.txtLugarCotizacion.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lugar de Cotización:"
        '
        'TpgConfiguraciones
        '
        Me.TpgConfiguraciones.Controls.Add(Me.TabFormatos)
        Me.TpgConfiguraciones.Location = New System.Drawing.Point(4, 22)
        Me.TpgConfiguraciones.Name = "TpgConfiguraciones"
        Me.TpgConfiguraciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgConfiguraciones.Size = New System.Drawing.Size(977, 453)
        Me.TpgConfiguraciones.TabIndex = 2
        Me.TpgConfiguraciones.Text = "Configuraciones"
        Me.TpgConfiguraciones.UseVisualStyleBackColor = True
        '
        'TabFormatos
        '
        Me.TabFormatos.Controls.Add(Me.TpgLugarFecha)
        Me.TabFormatos.Controls.Add(Me.TpgDestinatario)
        Me.TabFormatos.Controls.Add(Me.TpgFolioCotizacion)
        Me.TabFormatos.Controls.Add(Me.TpgTextoEncabezado)
        Me.TabFormatos.Controls.Add(Me.TpgEncabezadoPrincipal)
        Me.TabFormatos.Controls.Add(Me.TpgEncabezadoSecundario)
        Me.TabFormatos.Controls.Add(Me.TpgTextoEstandar)
        Me.TabFormatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFormatos.Location = New System.Drawing.Point(3, 3)
        Me.TabFormatos.Name = "TabFormatos"
        Me.TabFormatos.SelectedIndex = 0
        Me.TabFormatos.Size = New System.Drawing.Size(971, 447)
        Me.TabFormatos.TabIndex = 1
        '
        'TpgLugarFecha
        '
        Me.TpgLugarFecha.Controls.Add(Me.BtnColorLugarFecha)
        Me.TpgLugarFecha.Controls.Add(Me.pnlColorLugarFecha)
        Me.TpgLugarFecha.Controls.Add(Me.LblColorLugarFecha)
        Me.TpgLugarFecha.Controls.Add(Me.txtTestFuenteLugarFecha)
        Me.TpgLugarFecha.Controls.Add(Me.BtnFuenteLugarFecha)
        Me.TpgLugarFecha.Controls.Add(Me.txtFuenteLugarFecha)
        Me.TpgLugarFecha.Controls.Add(Me.LblFuenteLugarFecha)
        Me.TpgLugarFecha.Location = New System.Drawing.Point(4, 22)
        Me.TpgLugarFecha.Name = "TpgLugarFecha"
        Me.TpgLugarFecha.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgLugarFecha.Size = New System.Drawing.Size(963, 421)
        Me.TpgLugarFecha.TabIndex = 0
        Me.TpgLugarFecha.Text = "Lugar y Fecha"
        Me.TpgLugarFecha.UseVisualStyleBackColor = True
        '
        'BtnColorLugarFecha
        '
        Me.BtnColorLugarFecha.Location = New System.Drawing.Point(706, 9)
        Me.BtnColorLugarFecha.Name = "BtnColorLugarFecha"
        Me.BtnColorLugarFecha.Size = New System.Drawing.Size(30, 23)
        Me.BtnColorLugarFecha.TabIndex = 6
        Me.BtnColorLugarFecha.Text = "..."
        Me.BtnColorLugarFecha.UseVisualStyleBackColor = True
        '
        'pnlColorLugarFecha
        '
        Me.pnlColorLugarFecha.Location = New System.Drawing.Point(582, 9)
        Me.pnlColorLugarFecha.Name = "pnlColorLugarFecha"
        Me.pnlColorLugarFecha.Size = New System.Drawing.Size(118, 23)
        Me.pnlColorLugarFecha.TabIndex = 5
        '
        'LblColorLugarFecha
        '
        Me.LblColorLugarFecha.AutoSize = True
        Me.LblColorLugarFecha.Location = New System.Drawing.Point(535, 14)
        Me.LblColorLugarFecha.Name = "LblColorLugarFecha"
        Me.LblColorLugarFecha.Size = New System.Drawing.Size(34, 13)
        Me.LblColorLugarFecha.TabIndex = 4
        Me.LblColorLugarFecha.Text = "Color:"
        '
        'txtTestFuenteLugarFecha
        '
        Me.txtTestFuenteLugarFecha.Location = New System.Drawing.Point(67, 39)
        Me.txtTestFuenteLugarFecha.Name = "txtTestFuenteLugarFecha"
        Me.txtTestFuenteLugarFecha.Size = New System.Drawing.Size(669, 53)
        Me.txtTestFuenteLugarFecha.TabIndex = 3
        Me.txtTestFuenteLugarFecha.Text = "Este es un texto de prueba de la configuración seleccionada."
        '
        'BtnFuenteLugarFecha
        '
        Me.BtnFuenteLugarFecha.Location = New System.Drawing.Point(469, 9)
        Me.BtnFuenteLugarFecha.Name = "BtnFuenteLugarFecha"
        Me.BtnFuenteLugarFecha.Size = New System.Drawing.Size(30, 23)
        Me.BtnFuenteLugarFecha.TabIndex = 2
        Me.BtnFuenteLugarFecha.Text = "..."
        Me.BtnFuenteLugarFecha.UseVisualStyleBackColor = True
        '
        'txtFuenteLugarFecha
        '
        Me.txtFuenteLugarFecha.Enabled = False
        Me.txtFuenteLugarFecha.Location = New System.Drawing.Point(67, 10)
        Me.txtFuenteLugarFecha.Name = "txtFuenteLugarFecha"
        Me.txtFuenteLugarFecha.Size = New System.Drawing.Size(396, 20)
        Me.txtFuenteLugarFecha.TabIndex = 1
        '
        'LblFuenteLugarFecha
        '
        Me.LblFuenteLugarFecha.AutoSize = True
        Me.LblFuenteLugarFecha.Location = New System.Drawing.Point(17, 14)
        Me.LblFuenteLugarFecha.Name = "LblFuenteLugarFecha"
        Me.LblFuenteLugarFecha.Size = New System.Drawing.Size(43, 13)
        Me.LblFuenteLugarFecha.TabIndex = 0
        Me.LblFuenteLugarFecha.Text = "Fuente:"
        '
        'TpgDestinatario
        '
        Me.TpgDestinatario.Controls.Add(Me.BtnColorDestinatario)
        Me.TpgDestinatario.Controls.Add(Me.PnlColorDestinatario)
        Me.TpgDestinatario.Controls.Add(Me.LblColorDestinatario)
        Me.TpgDestinatario.Controls.Add(Me.txtTestFuenteDestinatario)
        Me.TpgDestinatario.Controls.Add(Me.BtnFuenteDestinatario)
        Me.TpgDestinatario.Controls.Add(Me.txtFuenteDestinatario)
        Me.TpgDestinatario.Controls.Add(Me.LblFuenteDestinatario)
        Me.TpgDestinatario.Location = New System.Drawing.Point(4, 22)
        Me.TpgDestinatario.Name = "TpgDestinatario"
        Me.TpgDestinatario.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgDestinatario.Size = New System.Drawing.Size(963, 421)
        Me.TpgDestinatario.TabIndex = 1
        Me.TpgDestinatario.Text = "Destinatario"
        Me.TpgDestinatario.UseVisualStyleBackColor = True
        '
        'BtnColorDestinatario
        '
        Me.BtnColorDestinatario.Location = New System.Drawing.Point(711, 9)
        Me.BtnColorDestinatario.Name = "BtnColorDestinatario"
        Me.BtnColorDestinatario.Size = New System.Drawing.Size(30, 23)
        Me.BtnColorDestinatario.TabIndex = 13
        Me.BtnColorDestinatario.Text = "..."
        Me.BtnColorDestinatario.UseVisualStyleBackColor = True
        '
        'PnlColorDestinatario
        '
        Me.PnlColorDestinatario.Location = New System.Drawing.Point(587, 9)
        Me.PnlColorDestinatario.Name = "PnlColorDestinatario"
        Me.PnlColorDestinatario.Size = New System.Drawing.Size(118, 23)
        Me.PnlColorDestinatario.TabIndex = 12
        '
        'LblColorDestinatario
        '
        Me.LblColorDestinatario.AutoSize = True
        Me.LblColorDestinatario.Location = New System.Drawing.Point(540, 14)
        Me.LblColorDestinatario.Name = "LblColorDestinatario"
        Me.LblColorDestinatario.Size = New System.Drawing.Size(34, 13)
        Me.LblColorDestinatario.TabIndex = 11
        Me.LblColorDestinatario.Text = "Color:"
        '
        'txtTestFuenteDestinatario
        '
        Me.txtTestFuenteDestinatario.Location = New System.Drawing.Point(72, 39)
        Me.txtTestFuenteDestinatario.Name = "txtTestFuenteDestinatario"
        Me.txtTestFuenteDestinatario.Size = New System.Drawing.Size(669, 53)
        Me.txtTestFuenteDestinatario.TabIndex = 10
        Me.txtTestFuenteDestinatario.Text = "Este es un texto de prueba de la configuración seleccionada."
        '
        'BtnFuenteDestinatario
        '
        Me.BtnFuenteDestinatario.Location = New System.Drawing.Point(474, 9)
        Me.BtnFuenteDestinatario.Name = "BtnFuenteDestinatario"
        Me.BtnFuenteDestinatario.Size = New System.Drawing.Size(30, 23)
        Me.BtnFuenteDestinatario.TabIndex = 9
        Me.BtnFuenteDestinatario.Text = "..."
        Me.BtnFuenteDestinatario.UseVisualStyleBackColor = True
        '
        'txtFuenteDestinatario
        '
        Me.txtFuenteDestinatario.Enabled = False
        Me.txtFuenteDestinatario.Location = New System.Drawing.Point(72, 10)
        Me.txtFuenteDestinatario.Name = "txtFuenteDestinatario"
        Me.txtFuenteDestinatario.Size = New System.Drawing.Size(396, 20)
        Me.txtFuenteDestinatario.TabIndex = 8
        '
        'LblFuenteDestinatario
        '
        Me.LblFuenteDestinatario.AutoSize = True
        Me.LblFuenteDestinatario.Location = New System.Drawing.Point(22, 14)
        Me.LblFuenteDestinatario.Name = "LblFuenteDestinatario"
        Me.LblFuenteDestinatario.Size = New System.Drawing.Size(43, 13)
        Me.LblFuenteDestinatario.TabIndex = 7
        Me.LblFuenteDestinatario.Text = "Fuente:"
        '
        'TpgFolioCotizacion
        '
        Me.TpgFolioCotizacion.Controls.Add(Me.BtnColorFolioCotizacion)
        Me.TpgFolioCotizacion.Controls.Add(Me.PnlColorFolioCotizacion)
        Me.TpgFolioCotizacion.Controls.Add(Me.LblColorFolioCotizacion)
        Me.TpgFolioCotizacion.Controls.Add(Me.txtTestFuenteFolioCotizacion)
        Me.TpgFolioCotizacion.Controls.Add(Me.BtnFuenteFolioCotizacion)
        Me.TpgFolioCotizacion.Controls.Add(Me.txtFuenteFolioCotizacion)
        Me.TpgFolioCotizacion.Controls.Add(Me.LblFuenteFolioCotizacion)
        Me.TpgFolioCotizacion.Location = New System.Drawing.Point(4, 22)
        Me.TpgFolioCotizacion.Name = "TpgFolioCotizacion"
        Me.TpgFolioCotizacion.Size = New System.Drawing.Size(963, 421)
        Me.TpgFolioCotizacion.TabIndex = 2
        Me.TpgFolioCotizacion.Text = "Folio de la Cotización"
        Me.TpgFolioCotizacion.UseVisualStyleBackColor = True
        '
        'BtnColorFolioCotizacion
        '
        Me.BtnColorFolioCotizacion.Location = New System.Drawing.Point(711, 9)
        Me.BtnColorFolioCotizacion.Name = "BtnColorFolioCotizacion"
        Me.BtnColorFolioCotizacion.Size = New System.Drawing.Size(30, 23)
        Me.BtnColorFolioCotizacion.TabIndex = 20
        Me.BtnColorFolioCotizacion.Text = "..."
        Me.BtnColorFolioCotizacion.UseVisualStyleBackColor = True
        '
        'PnlColorFolioCotizacion
        '
        Me.PnlColorFolioCotizacion.Location = New System.Drawing.Point(587, 9)
        Me.PnlColorFolioCotizacion.Name = "PnlColorFolioCotizacion"
        Me.PnlColorFolioCotizacion.Size = New System.Drawing.Size(118, 23)
        Me.PnlColorFolioCotizacion.TabIndex = 19
        '
        'LblColorFolioCotizacion
        '
        Me.LblColorFolioCotizacion.AutoSize = True
        Me.LblColorFolioCotizacion.Location = New System.Drawing.Point(540, 14)
        Me.LblColorFolioCotizacion.Name = "LblColorFolioCotizacion"
        Me.LblColorFolioCotizacion.Size = New System.Drawing.Size(34, 13)
        Me.LblColorFolioCotizacion.TabIndex = 18
        Me.LblColorFolioCotizacion.Text = "Color:"
        '
        'txtTestFuenteFolioCotizacion
        '
        Me.txtTestFuenteFolioCotizacion.Location = New System.Drawing.Point(72, 39)
        Me.txtTestFuenteFolioCotizacion.Name = "txtTestFuenteFolioCotizacion"
        Me.txtTestFuenteFolioCotizacion.Size = New System.Drawing.Size(669, 53)
        Me.txtTestFuenteFolioCotizacion.TabIndex = 17
        Me.txtTestFuenteFolioCotizacion.Text = "Este es un texto de prueba de la configuración seleccionada."
        '
        'BtnFuenteFolioCotizacion
        '
        Me.BtnFuenteFolioCotizacion.Location = New System.Drawing.Point(474, 9)
        Me.BtnFuenteFolioCotizacion.Name = "BtnFuenteFolioCotizacion"
        Me.BtnFuenteFolioCotizacion.Size = New System.Drawing.Size(30, 23)
        Me.BtnFuenteFolioCotizacion.TabIndex = 16
        Me.BtnFuenteFolioCotizacion.Text = "..."
        Me.BtnFuenteFolioCotizacion.UseVisualStyleBackColor = True
        '
        'txtFuenteFolioCotizacion
        '
        Me.txtFuenteFolioCotizacion.Enabled = False
        Me.txtFuenteFolioCotizacion.Location = New System.Drawing.Point(72, 10)
        Me.txtFuenteFolioCotizacion.Name = "txtFuenteFolioCotizacion"
        Me.txtFuenteFolioCotizacion.Size = New System.Drawing.Size(396, 20)
        Me.txtFuenteFolioCotizacion.TabIndex = 15
        '
        'LblFuenteFolioCotizacion
        '
        Me.LblFuenteFolioCotizacion.AutoSize = True
        Me.LblFuenteFolioCotizacion.Location = New System.Drawing.Point(22, 14)
        Me.LblFuenteFolioCotizacion.Name = "LblFuenteFolioCotizacion"
        Me.LblFuenteFolioCotizacion.Size = New System.Drawing.Size(43, 13)
        Me.LblFuenteFolioCotizacion.TabIndex = 14
        Me.LblFuenteFolioCotizacion.Text = "Fuente:"
        '
        'TpgTextoEncabezado
        '
        Me.TpgTextoEncabezado.Controls.Add(Me.BtnColorTextoEncabezado)
        Me.TpgTextoEncabezado.Controls.Add(Me.PnlColorTextoEncabezado)
        Me.TpgTextoEncabezado.Controls.Add(Me.LblColorTextoEncabezado)
        Me.TpgTextoEncabezado.Controls.Add(Me.txtTestFuenteTextoEncabezado)
        Me.TpgTextoEncabezado.Controls.Add(Me.BtnFuenteTextoEncabezado)
        Me.TpgTextoEncabezado.Controls.Add(Me.txtFuenteTextoEncabezado)
        Me.TpgTextoEncabezado.Controls.Add(Me.LblFuenteTextoEncabezado)
        Me.TpgTextoEncabezado.Location = New System.Drawing.Point(4, 22)
        Me.TpgTextoEncabezado.Name = "TpgTextoEncabezado"
        Me.TpgTextoEncabezado.Size = New System.Drawing.Size(963, 421)
        Me.TpgTextoEncabezado.TabIndex = 3
        Me.TpgTextoEncabezado.Text = "Texto del Encabezado"
        Me.TpgTextoEncabezado.UseVisualStyleBackColor = True
        '
        'BtnColorTextoEncabezado
        '
        Me.BtnColorTextoEncabezado.Location = New System.Drawing.Point(711, 9)
        Me.BtnColorTextoEncabezado.Name = "BtnColorTextoEncabezado"
        Me.BtnColorTextoEncabezado.Size = New System.Drawing.Size(30, 23)
        Me.BtnColorTextoEncabezado.TabIndex = 20
        Me.BtnColorTextoEncabezado.Text = "..."
        Me.BtnColorTextoEncabezado.UseVisualStyleBackColor = True
        '
        'PnlColorTextoEncabezado
        '
        Me.PnlColorTextoEncabezado.Location = New System.Drawing.Point(587, 9)
        Me.PnlColorTextoEncabezado.Name = "PnlColorTextoEncabezado"
        Me.PnlColorTextoEncabezado.Size = New System.Drawing.Size(118, 23)
        Me.PnlColorTextoEncabezado.TabIndex = 19
        '
        'LblColorTextoEncabezado
        '
        Me.LblColorTextoEncabezado.AutoSize = True
        Me.LblColorTextoEncabezado.Location = New System.Drawing.Point(540, 14)
        Me.LblColorTextoEncabezado.Name = "LblColorTextoEncabezado"
        Me.LblColorTextoEncabezado.Size = New System.Drawing.Size(34, 13)
        Me.LblColorTextoEncabezado.TabIndex = 18
        Me.LblColorTextoEncabezado.Text = "Color:"
        '
        'txtTestFuenteTextoEncabezado
        '
        Me.txtTestFuenteTextoEncabezado.Location = New System.Drawing.Point(72, 39)
        Me.txtTestFuenteTextoEncabezado.Name = "txtTestFuenteTextoEncabezado"
        Me.txtTestFuenteTextoEncabezado.Size = New System.Drawing.Size(669, 53)
        Me.txtTestFuenteTextoEncabezado.TabIndex = 17
        Me.txtTestFuenteTextoEncabezado.Text = "Este es un texto de prueba de la configuración seleccionada."
        '
        'BtnFuenteTextoEncabezado
        '
        Me.BtnFuenteTextoEncabezado.Location = New System.Drawing.Point(474, 9)
        Me.BtnFuenteTextoEncabezado.Name = "BtnFuenteTextoEncabezado"
        Me.BtnFuenteTextoEncabezado.Size = New System.Drawing.Size(30, 23)
        Me.BtnFuenteTextoEncabezado.TabIndex = 16
        Me.BtnFuenteTextoEncabezado.Text = "..."
        Me.BtnFuenteTextoEncabezado.UseVisualStyleBackColor = True
        '
        'txtFuenteTextoEncabezado
        '
        Me.txtFuenteTextoEncabezado.Enabled = False
        Me.txtFuenteTextoEncabezado.Location = New System.Drawing.Point(72, 10)
        Me.txtFuenteTextoEncabezado.Name = "txtFuenteTextoEncabezado"
        Me.txtFuenteTextoEncabezado.Size = New System.Drawing.Size(396, 20)
        Me.txtFuenteTextoEncabezado.TabIndex = 15
        '
        'LblFuenteTextoEncabezado
        '
        Me.LblFuenteTextoEncabezado.AutoSize = True
        Me.LblFuenteTextoEncabezado.Location = New System.Drawing.Point(22, 14)
        Me.LblFuenteTextoEncabezado.Name = "LblFuenteTextoEncabezado"
        Me.LblFuenteTextoEncabezado.Size = New System.Drawing.Size(43, 13)
        Me.LblFuenteTextoEncabezado.TabIndex = 14
        Me.LblFuenteTextoEncabezado.Text = "Fuente:"
        '
        'TpgEncabezadoPrincipal
        '
        Me.TpgEncabezadoPrincipal.Controls.Add(Me.BtnColorEncabezadoPrincipal)
        Me.TpgEncabezadoPrincipal.Controls.Add(Me.PnlColorEncabezadoPrincipal)
        Me.TpgEncabezadoPrincipal.Controls.Add(Me.LblColorEncabezadoPrincipal)
        Me.TpgEncabezadoPrincipal.Controls.Add(Me.txtTestFuenteEncabezadoPrincipal)
        Me.TpgEncabezadoPrincipal.Controls.Add(Me.BtnFuenteEncabezadoPrincipal)
        Me.TpgEncabezadoPrincipal.Controls.Add(Me.txtFuenteEncabezadoPrincipal)
        Me.TpgEncabezadoPrincipal.Controls.Add(Me.LblFuenteEncabezadoPrincipal)
        Me.TpgEncabezadoPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.TpgEncabezadoPrincipal.Name = "TpgEncabezadoPrincipal"
        Me.TpgEncabezadoPrincipal.Size = New System.Drawing.Size(963, 421)
        Me.TpgEncabezadoPrincipal.TabIndex = 4
        Me.TpgEncabezadoPrincipal.Text = "Título"
        Me.TpgEncabezadoPrincipal.UseVisualStyleBackColor = True
        '
        'BtnColorEncabezadoPrincipal
        '
        Me.BtnColorEncabezadoPrincipal.Location = New System.Drawing.Point(711, 9)
        Me.BtnColorEncabezadoPrincipal.Name = "BtnColorEncabezadoPrincipal"
        Me.BtnColorEncabezadoPrincipal.Size = New System.Drawing.Size(30, 23)
        Me.BtnColorEncabezadoPrincipal.TabIndex = 20
        Me.BtnColorEncabezadoPrincipal.Text = "..."
        Me.BtnColorEncabezadoPrincipal.UseVisualStyleBackColor = True
        '
        'PnlColorEncabezadoPrincipal
        '
        Me.PnlColorEncabezadoPrincipal.Location = New System.Drawing.Point(587, 9)
        Me.PnlColorEncabezadoPrincipal.Name = "PnlColorEncabezadoPrincipal"
        Me.PnlColorEncabezadoPrincipal.Size = New System.Drawing.Size(118, 23)
        Me.PnlColorEncabezadoPrincipal.TabIndex = 19
        '
        'LblColorEncabezadoPrincipal
        '
        Me.LblColorEncabezadoPrincipal.AutoSize = True
        Me.LblColorEncabezadoPrincipal.Location = New System.Drawing.Point(540, 14)
        Me.LblColorEncabezadoPrincipal.Name = "LblColorEncabezadoPrincipal"
        Me.LblColorEncabezadoPrincipal.Size = New System.Drawing.Size(34, 13)
        Me.LblColorEncabezadoPrincipal.TabIndex = 18
        Me.LblColorEncabezadoPrincipal.Text = "Color:"
        '
        'txtTestFuenteEncabezadoPrincipal
        '
        Me.txtTestFuenteEncabezadoPrincipal.Location = New System.Drawing.Point(72, 39)
        Me.txtTestFuenteEncabezadoPrincipal.Name = "txtTestFuenteEncabezadoPrincipal"
        Me.txtTestFuenteEncabezadoPrincipal.Size = New System.Drawing.Size(669, 53)
        Me.txtTestFuenteEncabezadoPrincipal.TabIndex = 17
        Me.txtTestFuenteEncabezadoPrincipal.Text = "Este es un texto de prueba de la configuración seleccionada."
        '
        'BtnFuenteEncabezadoPrincipal
        '
        Me.BtnFuenteEncabezadoPrincipal.Location = New System.Drawing.Point(474, 9)
        Me.BtnFuenteEncabezadoPrincipal.Name = "BtnFuenteEncabezadoPrincipal"
        Me.BtnFuenteEncabezadoPrincipal.Size = New System.Drawing.Size(30, 23)
        Me.BtnFuenteEncabezadoPrincipal.TabIndex = 16
        Me.BtnFuenteEncabezadoPrincipal.Text = "..."
        Me.BtnFuenteEncabezadoPrincipal.UseVisualStyleBackColor = True
        '
        'txtFuenteEncabezadoPrincipal
        '
        Me.txtFuenteEncabezadoPrincipal.Enabled = False
        Me.txtFuenteEncabezadoPrincipal.Location = New System.Drawing.Point(72, 10)
        Me.txtFuenteEncabezadoPrincipal.Name = "txtFuenteEncabezadoPrincipal"
        Me.txtFuenteEncabezadoPrincipal.Size = New System.Drawing.Size(396, 20)
        Me.txtFuenteEncabezadoPrincipal.TabIndex = 15
        '
        'LblFuenteEncabezadoPrincipal
        '
        Me.LblFuenteEncabezadoPrincipal.AutoSize = True
        Me.LblFuenteEncabezadoPrincipal.Location = New System.Drawing.Point(22, 14)
        Me.LblFuenteEncabezadoPrincipal.Name = "LblFuenteEncabezadoPrincipal"
        Me.LblFuenteEncabezadoPrincipal.Size = New System.Drawing.Size(43, 13)
        Me.LblFuenteEncabezadoPrincipal.TabIndex = 14
        Me.LblFuenteEncabezadoPrincipal.Text = "Fuente:"
        '
        'TpgEncabezadoSecundario
        '
        Me.TpgEncabezadoSecundario.Controls.Add(Me.BtnColorEncabezadoSecundario)
        Me.TpgEncabezadoSecundario.Controls.Add(Me.PnlColorEncabezadoSecundario)
        Me.TpgEncabezadoSecundario.Controls.Add(Me.LblColorEncabezadoSecundario)
        Me.TpgEncabezadoSecundario.Controls.Add(Me.txtTestFuenteEncabezadoSecundario)
        Me.TpgEncabezadoSecundario.Controls.Add(Me.BtnFuenteEncabezadoSecundario)
        Me.TpgEncabezadoSecundario.Controls.Add(Me.txtFuenteEncabezadoSecundario)
        Me.TpgEncabezadoSecundario.Controls.Add(Me.LblFuenteEncabezadoSecundario)
        Me.TpgEncabezadoSecundario.Location = New System.Drawing.Point(4, 22)
        Me.TpgEncabezadoSecundario.Name = "TpgEncabezadoSecundario"
        Me.TpgEncabezadoSecundario.Size = New System.Drawing.Size(963, 421)
        Me.TpgEncabezadoSecundario.TabIndex = 5
        Me.TpgEncabezadoSecundario.Text = "Sub Título"
        Me.TpgEncabezadoSecundario.UseVisualStyleBackColor = True
        '
        'BtnColorEncabezadoSecundario
        '
        Me.BtnColorEncabezadoSecundario.Location = New System.Drawing.Point(711, 9)
        Me.BtnColorEncabezadoSecundario.Name = "BtnColorEncabezadoSecundario"
        Me.BtnColorEncabezadoSecundario.Size = New System.Drawing.Size(30, 23)
        Me.BtnColorEncabezadoSecundario.TabIndex = 20
        Me.BtnColorEncabezadoSecundario.Text = "..."
        Me.BtnColorEncabezadoSecundario.UseVisualStyleBackColor = True
        '
        'PnlColorEncabezadoSecundario
        '
        Me.PnlColorEncabezadoSecundario.Location = New System.Drawing.Point(587, 9)
        Me.PnlColorEncabezadoSecundario.Name = "PnlColorEncabezadoSecundario"
        Me.PnlColorEncabezadoSecundario.Size = New System.Drawing.Size(118, 23)
        Me.PnlColorEncabezadoSecundario.TabIndex = 19
        '
        'LblColorEncabezadoSecundario
        '
        Me.LblColorEncabezadoSecundario.AutoSize = True
        Me.LblColorEncabezadoSecundario.Location = New System.Drawing.Point(540, 14)
        Me.LblColorEncabezadoSecundario.Name = "LblColorEncabezadoSecundario"
        Me.LblColorEncabezadoSecundario.Size = New System.Drawing.Size(34, 13)
        Me.LblColorEncabezadoSecundario.TabIndex = 18
        Me.LblColorEncabezadoSecundario.Text = "Color:"
        '
        'txtTestFuenteEncabezadoSecundario
        '
        Me.txtTestFuenteEncabezadoSecundario.Location = New System.Drawing.Point(72, 39)
        Me.txtTestFuenteEncabezadoSecundario.Name = "txtTestFuenteEncabezadoSecundario"
        Me.txtTestFuenteEncabezadoSecundario.Size = New System.Drawing.Size(669, 53)
        Me.txtTestFuenteEncabezadoSecundario.TabIndex = 17
        Me.txtTestFuenteEncabezadoSecundario.Text = "Este es un texto de prueba de la configuración seleccionada."
        '
        'BtnFuenteEncabezadoSecundario
        '
        Me.BtnFuenteEncabezadoSecundario.Location = New System.Drawing.Point(474, 9)
        Me.BtnFuenteEncabezadoSecundario.Name = "BtnFuenteEncabezadoSecundario"
        Me.BtnFuenteEncabezadoSecundario.Size = New System.Drawing.Size(30, 23)
        Me.BtnFuenteEncabezadoSecundario.TabIndex = 16
        Me.BtnFuenteEncabezadoSecundario.Text = "..."
        Me.BtnFuenteEncabezadoSecundario.UseVisualStyleBackColor = True
        '
        'txtFuenteEncabezadoSecundario
        '
        Me.txtFuenteEncabezadoSecundario.Enabled = False
        Me.txtFuenteEncabezadoSecundario.Location = New System.Drawing.Point(72, 10)
        Me.txtFuenteEncabezadoSecundario.Name = "txtFuenteEncabezadoSecundario"
        Me.txtFuenteEncabezadoSecundario.Size = New System.Drawing.Size(396, 20)
        Me.txtFuenteEncabezadoSecundario.TabIndex = 15
        '
        'LblFuenteEncabezadoSecundario
        '
        Me.LblFuenteEncabezadoSecundario.AutoSize = True
        Me.LblFuenteEncabezadoSecundario.Location = New System.Drawing.Point(22, 14)
        Me.LblFuenteEncabezadoSecundario.Name = "LblFuenteEncabezadoSecundario"
        Me.LblFuenteEncabezadoSecundario.Size = New System.Drawing.Size(43, 13)
        Me.LblFuenteEncabezadoSecundario.TabIndex = 14
        Me.LblFuenteEncabezadoSecundario.Text = "Fuente:"
        '
        'TpgTextoEstandar
        '
        Me.TpgTextoEstandar.Controls.Add(Me.BtnColorTextEstandar)
        Me.TpgTextoEstandar.Controls.Add(Me.PnlColorTextEstandar)
        Me.TpgTextoEstandar.Controls.Add(Me.LblColorTextEstandar)
        Me.TpgTextoEstandar.Controls.Add(Me.txtTestFuenteTextEstandar)
        Me.TpgTextoEstandar.Controls.Add(Me.BtnFuenteTextEstandar)
        Me.TpgTextoEstandar.Controls.Add(Me.txtFuenteTextEstandar)
        Me.TpgTextoEstandar.Controls.Add(Me.LblFuenteTextEstandar)
        Me.TpgTextoEstandar.Location = New System.Drawing.Point(4, 22)
        Me.TpgTextoEstandar.Name = "TpgTextoEstandar"
        Me.TpgTextoEstandar.Size = New System.Drawing.Size(963, 421)
        Me.TpgTextoEstandar.TabIndex = 6
        Me.TpgTextoEstandar.Text = "Texto Estandar"
        Me.TpgTextoEstandar.UseVisualStyleBackColor = True
        '
        'BtnColorTextEstandar
        '
        Me.BtnColorTextEstandar.Location = New System.Drawing.Point(711, 9)
        Me.BtnColorTextEstandar.Name = "BtnColorTextEstandar"
        Me.BtnColorTextEstandar.Size = New System.Drawing.Size(30, 23)
        Me.BtnColorTextEstandar.TabIndex = 20
        Me.BtnColorTextEstandar.Text = "..."
        Me.BtnColorTextEstandar.UseVisualStyleBackColor = True
        '
        'PnlColorTextEstandar
        '
        Me.PnlColorTextEstandar.Location = New System.Drawing.Point(587, 9)
        Me.PnlColorTextEstandar.Name = "PnlColorTextEstandar"
        Me.PnlColorTextEstandar.Size = New System.Drawing.Size(118, 23)
        Me.PnlColorTextEstandar.TabIndex = 19
        '
        'LblColorTextEstandar
        '
        Me.LblColorTextEstandar.AutoSize = True
        Me.LblColorTextEstandar.Location = New System.Drawing.Point(540, 14)
        Me.LblColorTextEstandar.Name = "LblColorTextEstandar"
        Me.LblColorTextEstandar.Size = New System.Drawing.Size(34, 13)
        Me.LblColorTextEstandar.TabIndex = 18
        Me.LblColorTextEstandar.Text = "Color:"
        '
        'txtTestFuenteTextEstandar
        '
        Me.txtTestFuenteTextEstandar.Location = New System.Drawing.Point(72, 39)
        Me.txtTestFuenteTextEstandar.Name = "txtTestFuenteTextEstandar"
        Me.txtTestFuenteTextEstandar.Size = New System.Drawing.Size(669, 53)
        Me.txtTestFuenteTextEstandar.TabIndex = 17
        Me.txtTestFuenteTextEstandar.Text = "Este es un texto de prueba de la configuración seleccionada."
        '
        'BtnFuenteTextEstandar
        '
        Me.BtnFuenteTextEstandar.Location = New System.Drawing.Point(474, 9)
        Me.BtnFuenteTextEstandar.Name = "BtnFuenteTextEstandar"
        Me.BtnFuenteTextEstandar.Size = New System.Drawing.Size(30, 23)
        Me.BtnFuenteTextEstandar.TabIndex = 16
        Me.BtnFuenteTextEstandar.Text = "..."
        Me.BtnFuenteTextEstandar.UseVisualStyleBackColor = True
        '
        'txtFuenteTextEstandar
        '
        Me.txtFuenteTextEstandar.Enabled = False
        Me.txtFuenteTextEstandar.Location = New System.Drawing.Point(72, 10)
        Me.txtFuenteTextEstandar.Name = "txtFuenteTextEstandar"
        Me.txtFuenteTextEstandar.Size = New System.Drawing.Size(396, 20)
        Me.txtFuenteTextEstandar.TabIndex = 15
        '
        'LblFuenteTextEstandar
        '
        Me.LblFuenteTextEstandar.AutoSize = True
        Me.LblFuenteTextEstandar.Location = New System.Drawing.Point(22, 14)
        Me.LblFuenteTextEstandar.Name = "LblFuenteTextEstandar"
        Me.LblFuenteTextEstandar.Size = New System.Drawing.Size(43, 13)
        Me.LblFuenteTextEstandar.TabIndex = 14
        Me.LblFuenteTextEstandar.Text = "Fuente:"
        '
        'TpgReporte
        '
        Me.TpgReporte.Controls.Add(Me.CrvReport)
        Me.TpgReporte.Location = New System.Drawing.Point(4, 22)
        Me.TpgReporte.Name = "TpgReporte"
        Me.TpgReporte.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgReporte.Size = New System.Drawing.Size(977, 453)
        Me.TpgReporte.TabIndex = 1
        Me.TpgReporte.Text = "Reporte"
        Me.TpgReporte.UseVisualStyleBackColor = True
        '
        'CrvReport
        '
        Me.CrvReport.ActiveViewIndex = -1
        Me.CrvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvReport.Location = New System.Drawing.Point(3, 3)
        Me.CrvReport.Name = "CrvReport"
        Me.CrvReport.ShowCloseButton = False
        Me.CrvReport.ShowCopyButton = False
        Me.CrvReport.ShowGroupTreeButton = False
        Me.CrvReport.ShowLogo = False
        Me.CrvReport.ShowParameterPanelButton = False
        Me.CrvReport.ShowRefreshButton = False
        Me.CrvReport.Size = New System.Drawing.Size(971, 447)
        Me.CrvReport.TabIndex = 3
        Me.CrvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FontSelector
        '
        Me.FontSelector.AllowScriptChange = False
        Me.FontSelector.AllowSimulations = False
        Me.FontSelector.AllowVectorFonts = False
        Me.FontSelector.AllowVerticalFonts = False
        Me.FontSelector.FontMustExist = True
        '
        'ColorSelector
        '
        Me.ColorSelector.SolidColorOnly = True
        '
        'Reporte_Cotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 541)
        Me.Controls.Add(Me.TabMain)
        Me.Controls.Add(Me.PnlHeader)
        Me.Name = "Reporte_Cotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Cotización"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.TabMain.ResumeLayout(False)
        Me.TpgGeneral.ResumeLayout(False)
        Me.TpgGeneral.PerformLayout()
        Me.TpgConfiguraciones.ResumeLayout(False)
        Me.TabFormatos.ResumeLayout(False)
        Me.TpgLugarFecha.ResumeLayout(False)
        Me.TpgLugarFecha.PerformLayout()
        Me.TpgDestinatario.ResumeLayout(False)
        Me.TpgDestinatario.PerformLayout()
        Me.TpgFolioCotizacion.ResumeLayout(False)
        Me.TpgFolioCotizacion.PerformLayout()
        Me.TpgTextoEncabezado.ResumeLayout(False)
        Me.TpgTextoEncabezado.PerformLayout()
        Me.TpgEncabezadoPrincipal.ResumeLayout(False)
        Me.TpgEncabezadoPrincipal.PerformLayout()
        Me.TpgEncabezadoSecundario.ResumeLayout(False)
        Me.TpgEncabezadoSecundario.PerformLayout()
        Me.TpgTextoEstandar.ResumeLayout(False)
        Me.TpgTextoEstandar.PerformLayout()
        Me.TpgReporte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabMain As TabControl
    Friend WithEvents TpgGeneral As TabPage
    Friend WithEvents TpgReporte As TabPage
    Friend WithEvents txtCotizacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLugarCotizacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPrefijoCliente As ComboBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnbuscarCotizacion As Button
    Friend WithEvents txtEncabezadoReporte As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Informe_Cotizacion1 As Informe_Cotizacion
    Friend WithEvents BtnGenerarReporte As Button
    Friend WithEvents FontSelector As FontDialog
    Friend WithEvents ColorSelector As ColorDialog
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents TpgConfiguraciones As TabPage
    Friend WithEvents TabFormatos As TabControl
    Friend WithEvents TpgLugarFecha As TabPage
    Friend WithEvents BtnColorLugarFecha As Button
    Friend WithEvents pnlColorLugarFecha As Panel
    Friend WithEvents LblColorLugarFecha As Label
    Friend WithEvents txtTestFuenteLugarFecha As RichTextBox
    Friend WithEvents BtnFuenteLugarFecha As Button
    Friend WithEvents txtFuenteLugarFecha As TextBox
    Friend WithEvents LblFuenteLugarFecha As Label
    Friend WithEvents TpgDestinatario As TabPage
    Friend WithEvents BtnColorDestinatario As Button
    Friend WithEvents PnlColorDestinatario As Panel
    Friend WithEvents LblColorDestinatario As Label
    Friend WithEvents txtTestFuenteDestinatario As RichTextBox
    Friend WithEvents BtnFuenteDestinatario As Button
    Friend WithEvents txtFuenteDestinatario As TextBox
    Friend WithEvents LblFuenteDestinatario As Label
    Friend WithEvents TpgFolioCotizacion As TabPage
    Friend WithEvents BtnColorFolioCotizacion As Button
    Friend WithEvents PnlColorFolioCotizacion As Panel
    Friend WithEvents LblColorFolioCotizacion As Label
    Friend WithEvents txtTestFuenteFolioCotizacion As RichTextBox
    Friend WithEvents BtnFuenteFolioCotizacion As Button
    Friend WithEvents txtFuenteFolioCotizacion As TextBox
    Friend WithEvents LblFuenteFolioCotizacion As Label
    Friend WithEvents TpgTextoEncabezado As TabPage
    Friend WithEvents BtnColorTextoEncabezado As Button
    Friend WithEvents PnlColorTextoEncabezado As Panel
    Friend WithEvents LblColorTextoEncabezado As Label
    Friend WithEvents txtTestFuenteTextoEncabezado As RichTextBox
    Friend WithEvents BtnFuenteTextoEncabezado As Button
    Friend WithEvents txtFuenteTextoEncabezado As TextBox
    Friend WithEvents LblFuenteTextoEncabezado As Label
    Friend WithEvents TpgEncabezadoPrincipal As TabPage
    Friend WithEvents BtnColorEncabezadoPrincipal As Button
    Friend WithEvents PnlColorEncabezadoPrincipal As Panel
    Friend WithEvents LblColorEncabezadoPrincipal As Label
    Friend WithEvents txtTestFuenteEncabezadoPrincipal As RichTextBox
    Friend WithEvents BtnFuenteEncabezadoPrincipal As Button
    Friend WithEvents txtFuenteEncabezadoPrincipal As TextBox
    Friend WithEvents LblFuenteEncabezadoPrincipal As Label
    Friend WithEvents TpgEncabezadoSecundario As TabPage
    Friend WithEvents BtnColorEncabezadoSecundario As Button
    Friend WithEvents PnlColorEncabezadoSecundario As Panel
    Friend WithEvents LblColorEncabezadoSecundario As Label
    Friend WithEvents txtTestFuenteEncabezadoSecundario As RichTextBox
    Friend WithEvents BtnFuenteEncabezadoSecundario As Button
    Friend WithEvents txtFuenteEncabezadoSecundario As TextBox
    Friend WithEvents LblFuenteEncabezadoSecundario As Label
    Friend WithEvents TpgTextoEstandar As TabPage
    Friend WithEvents BtnColorTextEstandar As Button
    Friend WithEvents PnlColorTextEstandar As Panel
    Friend WithEvents LblColorTextEstandar As Label
    Friend WithEvents txtTestFuenteTextEstandar As RichTextBox
    Friend WithEvents BtnFuenteTextEstandar As Button
    Friend WithEvents txtFuenteTextEstandar As TextBox
    Friend WithEvents LblFuenteTextEstandar As Label
    Private WithEvents CrvReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
