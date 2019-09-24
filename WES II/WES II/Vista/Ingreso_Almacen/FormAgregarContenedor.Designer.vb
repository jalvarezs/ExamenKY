<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgregarContenedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarContenedor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCantidadEntrante = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQtyContenedorBase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQtyContenedorAdicional = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExamCont = New System.Windows.Forms.Button()
        Me.txtContenedorAdicional = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtyAdicionales = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 83)
        Me.Panel1.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Agregar Contenedor"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(208, 245)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 47)
        Me.btnAceptar.TabIndex = 45
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCantidadEntrante
        '
        Me.txtCantidadEntrante.Enabled = False
        Me.txtCantidadEntrante.Location = New System.Drawing.Point(261, 96)
        Me.txtCantidadEntrante.Name = "txtCantidadEntrante"
        Me.txtCantidadEntrante.ReadOnly = True
        Me.txtCantidadEntrante.Size = New System.Drawing.Size(92, 20)
        Me.txtCantidadEntrante.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Cantidad Entrante:"
        '
        'txtQtyContenedorBase
        '
        Me.txtQtyContenedorBase.Enabled = False
        Me.txtQtyContenedorBase.Location = New System.Drawing.Point(261, 124)
        Me.txtQtyContenedorBase.Name = "txtQtyContenedorBase"
        Me.txtQtyContenedorBase.ReadOnly = True
        Me.txtQtyContenedorBase.Size = New System.Drawing.Size(92, 20)
        Me.txtQtyContenedorBase.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Cantidad Contenedor Base:"
        '
        'txtQtyContenedorAdicional
        '
        Me.txtQtyContenedorAdicional.Location = New System.Drawing.Point(261, 177)
        Me.txtQtyContenedorAdicional.Name = "txtQtyContenedorAdicional"
        Me.txtQtyContenedorAdicional.Size = New System.Drawing.Size(92, 20)
        Me.txtQtyContenedorAdicional.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "(*) Cantidad Contenedor Adicional:"
        '
        'btnExamCont
        '
        Me.btnExamCont.Location = New System.Drawing.Point(362, 204)
        Me.btnExamCont.Name = "btnExamCont"
        Me.btnExamCont.Size = New System.Drawing.Size(82, 23)
        Me.btnExamCont.TabIndex = 61
        Me.btnExamCont.Text = "Examinar"
        Me.btnExamCont.UseVisualStyleBackColor = True
        '
        'txtContenedorAdicional
        '
        Me.txtContenedorAdicional.Enabled = False
        Me.txtContenedorAdicional.Location = New System.Drawing.Point(199, 206)
        Me.txtContenedorAdicional.Name = "txtContenedorAdicional"
        Me.txtContenedorAdicional.ReadOnly = True
        Me.txtContenedorAdicional.Size = New System.Drawing.Size(154, 20)
        Me.txtContenedorAdicional.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 15)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "(*) Contenedor Adicional:"
        '
        'txtQtyAdicionales
        '
        Me.txtQtyAdicionales.Enabled = False
        Me.txtQtyAdicionales.Location = New System.Drawing.Point(261, 150)
        Me.txtQtyAdicionales.Name = "txtQtyAdicionales"
        Me.txtQtyAdicionales.ReadOnly = True
        Me.txtQtyAdicionales.Size = New System.Drawing.Size(92, 20)
        Me.txtQtyAdicionales.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 15)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Cantidad Contenedores Adicionales:"
        '
        'FormAgregarContenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 321)
        Me.Controls.Add(Me.txtQtyAdicionales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExamCont)
        Me.Controls.Add(Me.txtContenedorAdicional)
        Me.Controls.Add(Me.txtQtyContenedorAdicional)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQtyContenedorBase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCantidadEntrante)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAgregarContenedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Agregar Contenedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtCantidadEntrante As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQtyContenedorBase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQtyContenedorAdicional As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExamCont As Button
    Friend WithEvents txtContenedorAdicional As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtyAdicionales As TextBox
    Friend WithEvents Label5 As Label
End Class
