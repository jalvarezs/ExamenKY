<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Movimientos_Stock
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_Movimientos_Stock))
        Me.SP_ReporteStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Wes_II_TestB = New WES_II.DS_Wes_II_TestB()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExamMaterial = New System.Windows.Forms.Button()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.reportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_ReporteStockTableAdapter = New WES_II.DS_Wes_II_TestBTableAdapters.SP_MovimientosStockTableAdapter()
        CType(Me.SP_ReporteStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Wes_II_TestB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_ReporteStockBindingSource
        '
        Me.SP_ReporteStockBindingSource.DataMember = "SP_MovimientosStock"
        Me.SP_ReporteStockBindingSource.DataSource = Me.DS_Wes_II_TestB
        '
        'DS_Wes_II_TestB
        '
        Me.DS_Wes_II_TestB.DataSetName = "DS_Wes_II_TestB"
        Me.DS_Wes_II_TestB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 60)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte de movimientos de stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seleccione material:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(572, 13)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 23)
        Me.btnGenerar.TabIndex = 10
        Me.btnGenerar.Text = "Generar reporte"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnExamMaterial)
        Me.Panel2.Controls.Add(Me.txtMaterial)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnGenerar)
        Me.Panel2.Location = New System.Drawing.Point(3, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 49)
        Me.Panel2.TabIndex = 11
        '
        'btnExamMaterial
        '
        Me.btnExamMaterial.Location = New System.Drawing.Point(225, 10)
        Me.btnExamMaterial.Name = "btnExamMaterial"
        Me.btnExamMaterial.Size = New System.Drawing.Size(75, 23)
        Me.btnExamMaterial.TabIndex = 12
        Me.btnExamMaterial.Text = "Examinar"
        Me.btnExamMaterial.UseVisualStyleBackColor = True
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(119, 10)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterial.TabIndex = 11
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.reportViewer, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(699, 462)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'reportViewer
        '
        Me.reportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet_Stock"
        ReportDataSource1.Value = Me.SP_ReporteStockBindingSource
        Me.reportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reportViewer.LocalReport.ReportEmbeddedResource = "WES_II.Informe_Stock.rdlc"
        Me.reportViewer.Location = New System.Drawing.Point(3, 124)
        Me.reportViewer.Name = "reportViewer"
        Me.reportViewer.Size = New System.Drawing.Size(693, 335)
        Me.reportViewer.TabIndex = 5
        '
        'SP_ReporteStockTableAdapter
        '
        Me.SP_ReporteStockTableAdapter.ClearBeforeFill = True
        '
        'Reporte_Movimientos_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reporte_Movimientos_Stock"
        Me.Text = "GDA - Reportes - Reporte de movimientos de stock"
        CType(Me.SP_ReporteStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Wes_II_TestB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnExamMaterial As System.Windows.Forms.Button
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents reportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteStockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Wes_II_TestB As WES_II.DS_Wes_II_TestB
    Friend WithEvents SP_ReporteStockTableAdapter As WES_II.DS_Wes_II_TestBTableAdapters.SP_MovimientosStockTableAdapter
End Class
