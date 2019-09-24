<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControlServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormControlServicios))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtHoraInicioPlanificada = New System.Windows.Forms.TextBox()
        Me.txtFechaInicioPlanificada = New System.Windows.Forms.TextBox()
        Me.txtFechaFinPlanificada = New System.Windows.Forms.TextBox()
        Me.txtHorasDia = New System.Windows.Forms.TextBox()
        Me.txtTotalHoras = New System.Windows.Forms.TextBox()
        Me.txtHoraFinPlanificada = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblPersonal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpHoraFinReal = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFinPlanificada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicioReal = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicioPlanificada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinReal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinPlanificada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicioReal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicioPlanificada = New System.Windows.Forms.DateTimePicker()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtRetrasos = New System.Windows.Forms.TextBox()
        Me.txtAvance = New System.Windows.Forms.TextBox()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtTrabajo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProforma = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgDetallePersonal = New System.Windows.Forms.DataGridView()
        Me.dgvControlServicios = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgDetallePersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvControlServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 447)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtHoraInicioPlanificada)
        Me.TabPage1.Controls.Add(Me.txtFechaInicioPlanificada)
        Me.TabPage1.Controls.Add(Me.txtFechaFinPlanificada)
        Me.TabPage1.Controls.Add(Me.txtHorasDia)
        Me.TabPage1.Controls.Add(Me.txtTotalHoras)
        Me.TabPage1.Controls.Add(Me.txtHoraFinPlanificada)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.lblPersonal)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dtpHoraFinReal)
        Me.TabPage1.Controls.Add(Me.dtpHoraFinPlanificada)
        Me.TabPage1.Controls.Add(Me.dtpHoraInicioReal)
        Me.TabPage1.Controls.Add(Me.dtpHoraInicioPlanificada)
        Me.TabPage1.Controls.Add(Me.dtpFechaFinReal)
        Me.TabPage1.Controls.Add(Me.dtpFechaFinPlanificada)
        Me.TabPage1.Controls.Add(Me.dtpFechaInicioReal)
        Me.TabPage1.Controls.Add(Me.dtpFechaInicioPlanificada)
        Me.TabPage1.Controls.Add(Me.btnPersonal)
        Me.TabPage1.Controls.Add(Me.btnExaminar)
        Me.TabPage1.Controls.Add(Me.txtEstado)
        Me.TabPage1.Controls.Add(Me.txtRetrasos)
        Me.TabPage1.Controls.Add(Me.txtAvance)
        Me.TabPage1.Controls.Add(Me.txtResponsable)
        Me.TabPage1.Controls.Add(Me.txtContacto)
        Me.TabPage1.Controls.Add(Me.txtFecha)
        Me.TabPage1.Controls.Add(Me.txtTrabajo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtCliente)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtProforma)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(753, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Servicio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtHoraInicioPlanificada
        '
        Me.txtHoraInicioPlanificada.Location = New System.Drawing.Point(617, 55)
        Me.txtHoraInicioPlanificada.Name = "txtHoraInicioPlanificada"
        Me.txtHoraInicioPlanificada.ReadOnly = True
        Me.txtHoraInicioPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.txtHoraInicioPlanificada.TabIndex = 15
        Me.txtHoraInicioPlanificada.Text = " "
        '
        'txtFechaInicioPlanificada
        '
        Me.txtFechaInicioPlanificada.Location = New System.Drawing.Point(439, 55)
        Me.txtFechaInicioPlanificada.Name = "txtFechaInicioPlanificada"
        Me.txtFechaInicioPlanificada.ReadOnly = True
        Me.txtFechaInicioPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.txtFechaInicioPlanificada.TabIndex = 15
        Me.txtFechaInicioPlanificada.Text = " "
        '
        'txtFechaFinPlanificada
        '
        Me.txtFechaFinPlanificada.Location = New System.Drawing.Point(439, 89)
        Me.txtFechaFinPlanificada.Name = "txtFechaFinPlanificada"
        Me.txtFechaFinPlanificada.ReadOnly = True
        Me.txtFechaFinPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.txtFechaFinPlanificada.TabIndex = 15
        Me.txtFechaFinPlanificada.Text = " "
        '
        'txtHorasDia
        '
        Me.txtHorasDia.Location = New System.Drawing.Point(617, 238)
        Me.txtHorasDia.Name = "txtHorasDia"
        Me.txtHorasDia.ReadOnly = True
        Me.txtHorasDia.Size = New System.Drawing.Size(91, 20)
        Me.txtHorasDia.TabIndex = 15
        Me.txtHorasDia.Text = " "
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.Location = New System.Drawing.Point(617, 125)
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.ReadOnly = True
        Me.txtTotalHoras.Size = New System.Drawing.Size(91, 20)
        Me.txtTotalHoras.TabIndex = 15
        Me.txtTotalHoras.Text = " "
        '
        'txtHoraFinPlanificada
        '
        Me.txtHoraFinPlanificada.Location = New System.Drawing.Point(617, 89)
        Me.txtHoraFinPlanificada.Name = "txtHoraFinPlanificada"
        Me.txtHoraFinPlanificada.ReadOnly = True
        Me.txtHoraFinPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.txtHoraFinPlanificada.TabIndex = 15
        Me.txtHoraFinPlanificada.Text = " "
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = Global.WES_II.My.Resources.Resources.Tick_32x32
        Me.btnAceptar.Location = New System.Drawing.Point(592, 350)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Image = Global.WES_II.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(476, 350)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 47)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(355, 319)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Estado"
        '
        'lblPersonal
        '
        Me.lblPersonal.AutoSize = True
        Me.lblPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonal.ForeColor = System.Drawing.Color.Red
        Me.lblPersonal.Location = New System.Drawing.Point(93, 285)
        Me.lblPersonal.Name = "lblPersonal"
        Me.lblPersonal.Size = New System.Drawing.Size(125, 15)
        Me.lblPersonal.TabIndex = 4
        Me.lblPersonal.Text = "Personal No Cargado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Personal"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(355, 283)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Retrasos"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(536, 245)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 15)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(355, 245)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Avance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Responsable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Contacto"
        '
        'dtpHoraFinReal
        '
        Me.dtpHoraFinReal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFinReal.Location = New System.Drawing.Point(617, 200)
        Me.dtpHoraFinReal.Name = "dtpHoraFinReal"
        Me.dtpHoraFinReal.Size = New System.Drawing.Size(91, 20)
        Me.dtpHoraFinReal.TabIndex = 3
        '
        'dtpHoraFinPlanificada
        '
        Me.dtpHoraFinPlanificada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFinPlanificada.Location = New System.Drawing.Point(105, 376)
        Me.dtpHoraFinPlanificada.Name = "dtpHoraFinPlanificada"
        Me.dtpHoraFinPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.dtpHoraFinPlanificada.TabIndex = 3
        Me.dtpHoraFinPlanificada.Value = New Date(2016, 6, 27, 18, 0, 0, 0)
        Me.dtpHoraFinPlanificada.Visible = False
        '
        'dtpHoraInicioReal
        '
        Me.dtpHoraInicioReal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicioReal.Location = New System.Drawing.Point(617, 166)
        Me.dtpHoraInicioReal.Name = "dtpHoraInicioReal"
        Me.dtpHoraInicioReal.Size = New System.Drawing.Size(91, 20)
        Me.dtpHoraInicioReal.TabIndex = 3
        '
        'dtpHoraInicioPlanificada
        '
        Me.dtpHoraInicioPlanificada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicioPlanificada.Location = New System.Drawing.Point(8, 376)
        Me.dtpHoraInicioPlanificada.Name = "dtpHoraInicioPlanificada"
        Me.dtpHoraInicioPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.dtpHoraInicioPlanificada.TabIndex = 3
        Me.dtpHoraInicioPlanificada.Value = New Date(2016, 6, 27, 9, 0, 0, 0)
        Me.dtpHoraInicioPlanificada.Visible = False
        '
        'dtpFechaFinReal
        '
        Me.dtpFechaFinReal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinReal.Location = New System.Drawing.Point(439, 200)
        Me.dtpFechaFinReal.Name = "dtpFechaFinReal"
        Me.dtpFechaFinReal.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaFinReal.TabIndex = 3
        '
        'dtpFechaFinPlanificada
        '
        Me.dtpFechaFinPlanificada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinPlanificada.Location = New System.Drawing.Point(105, 350)
        Me.dtpFechaFinPlanificada.Name = "dtpFechaFinPlanificada"
        Me.dtpFechaFinPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaFinPlanificada.TabIndex = 3
        Me.dtpFechaFinPlanificada.Visible = False
        '
        'dtpFechaInicioReal
        '
        Me.dtpFechaInicioReal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicioReal.Location = New System.Drawing.Point(439, 166)
        Me.dtpFechaInicioReal.Name = "dtpFechaInicioReal"
        Me.dtpFechaInicioReal.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaInicioReal.TabIndex = 3
        '
        'dtpFechaInicioPlanificada
        '
        Me.dtpFechaInicioPlanificada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicioPlanificada.Location = New System.Drawing.Point(8, 350)
        Me.dtpFechaInicioPlanificada.Name = "dtpFechaInicioPlanificada"
        Me.dtpFechaInicioPlanificada.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaInicioPlanificada.TabIndex = 3
        Me.dtpFechaInicioPlanificada.Visible = False
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(92, 254)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(157, 23)
        Me.btnPersonal.TabIndex = 2
        Me.btnPersonal.Text = "Agregar Personal ..."
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(257, 27)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 2
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(429, 316)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(157, 20)
        Me.txtEstado.TabIndex = 1
        '
        'txtRetrasos
        '
        Me.txtRetrasos.Location = New System.Drawing.Point(429, 280)
        Me.txtRetrasos.Name = "txtRetrasos"
        Me.txtRetrasos.Size = New System.Drawing.Size(157, 20)
        Me.txtRetrasos.TabIndex = 1
        '
        'txtAvance
        '
        Me.txtAvance.Location = New System.Drawing.Point(429, 242)
        Me.txtAvance.Name = "txtAvance"
        Me.txtAvance.ReadOnly = True
        Me.txtAvance.Size = New System.Drawing.Size(101, 20)
        Me.txtAvance.TabIndex = 1
        Me.txtAvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(92, 217)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(157, 20)
        Me.txtResponsable.TabIndex = 1
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(92, 178)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.ReadOnly = True
        Me.txtContacto.Size = New System.Drawing.Size(157, 20)
        Me.txtContacto.TabIndex = 1
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(92, 140)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(157, 20)
        Me.txtFecha.TabIndex = 1
        '
        'txtTrabajo
        '
        Me.txtTrabajo.Location = New System.Drawing.Point(92, 101)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.ReadOnly = True
        Me.txtTrabajo.Size = New System.Drawing.Size(157, 20)
        Me.txtTrabajo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Trabajo"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(92, 62)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(157, 20)
        Me.txtCliente.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cliente"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(549, 203)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Hora Fin"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(549, 128)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Total hrs"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(549, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Hora Fin"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(549, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Hora Inicio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(549, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Hora Inicio"
        '
        'txtProforma
        '
        Me.txtProforma.Location = New System.Drawing.Point(92, 27)
        Me.txtProforma.Name = "txtProforma"
        Me.txtProforma.ReadOnly = True
        Me.txtProforma.Size = New System.Drawing.Size(157, 20)
        Me.txtProforma.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 203)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Fecha Fin"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Fecha Fin"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(354, 169)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Fecha Inicio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(354, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Fecha Inicio"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(354, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tiempo Real"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(354, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tiempo Planificado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nº Proforma"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnEliminar)
        Me.TabPage2.Controls.Add(Me.dgDetallePersonal)
        Me.TabPage2.Controls.Add(Me.dgvControlServicios)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(753, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Servicios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.Image = Global.WES_II.My.Resources.Resources.Delete_32x32
        Me.btnEliminar.Location = New System.Drawing.Point(615, 400)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 14)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'dgDetallePersonal
        '
        Me.dgDetallePersonal.AllowUserToAddRows = False
        Me.dgDetallePersonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetallePersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetallePersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetallePersonal.Location = New System.Drawing.Point(13, 179)
        Me.dgDetallePersonal.Name = "dgDetallePersonal"
        Me.dgDetallePersonal.ReadOnly = True
        Me.dgDetallePersonal.Size = New System.Drawing.Size(712, 215)
        Me.dgDetallePersonal.TabIndex = 5
        '
        'dgvControlServicios
        '
        Me.dgvControlServicios.AllowUserToAddRows = False
        Me.dgvControlServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvControlServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvControlServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvControlServicios.Location = New System.Drawing.Point(13, 28)
        Me.dgvControlServicios.Name = "dgvControlServicios"
        Me.dgvControlServicios.ReadOnly = True
        Me.dgvControlServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvControlServicios.Size = New System.Drawing.Size(712, 125)
        Me.dgvControlServicios.TabIndex = 5
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 161)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(141, 15)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Listado Detalle Personal"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(158, 15)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Listado Control de Servicios"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 75)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control de Servicios"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FormControlServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 529)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormControlServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Control de Servicios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgDetallePersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvControlServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents txtProforma As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents txtTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraFinReal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraFinPlanificada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraInicioReal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraInicioPlanificada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinReal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinPlanificada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicioReal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicioPlanificada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRetrasos As System.Windows.Forms.TextBox
    Friend WithEvents txtAvance As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dgvControlServicios As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtHoraFinPlanificada As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaFinPlanificada As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraInicioPlanificada As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaInicioPlanificada As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents btnPersonal As System.Windows.Forms.Button
    Friend WithEvents lblPersonal As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtHorasDia As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dgDetallePersonal As System.Windows.Forms.DataGridView
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
