<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte_Stock_Articulo_Sumarizado
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_Stock_Articulo_Sumarizado))
        Me.SP_Stock_Sumarizado_ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Wes_II_TestB = New WES_II.DS_Wes_II_TestB()
        Me.SP_ReporteStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExaminarContenedor = New System.Windows.Forms.Button()
        Me.txtContenedor = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.reportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_Stock_Sumarizado_ArticuloTableAdapter = New WES_II.DS_Wes_II_TestBTableAdapters.SP_Stock_Sumarizado_ArticuloTableAdapter()
        Me.TableAdapterManager = New WES_II.DS_Wes_II_TestBTableAdapters.TableAdapterManager()
        CType(Me.SP_Stock_Sumarizado_ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Wes_II_TestB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_Stock_Sumarizado_ArticuloBindingSource
        '
        Me.SP_Stock_Sumarizado_ArticuloBindingSource.DataMember = "SP_Stock_Sumarizado_Articulo"
        Me.SP_Stock_Sumarizado_ArticuloBindingSource.DataSource = Me.DS_Wes_II_TestB
        '
        'DS_Wes_II_TestB
        '
        Me.DS_Wes_II_TestB.DataSetName = "DS_Wes_II_TestB"
        Me.DS_Wes_II_TestB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteStockBindingSource
        '
        Me.SP_ReporteStockBindingSource.DataMember = "SP_Stock_Sumarizado_Articulo"
        Me.SP_ReporteStockBindingSource.DataSource = Me.DS_Wes_II_TestB
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.WES_II.My.Resources.Resources.flat_light
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 60)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte Stock Articulo Sumarizado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seleccione Contenedor:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(568, 9)
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
        Me.Panel2.Controls.Add(Me.btnExaminarContenedor)
        Me.Panel2.Controls.Add(Me.txtContenedor)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnGenerar)
        Me.Panel2.Location = New System.Drawing.Point(3, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 49)
        Me.Panel2.TabIndex = 11
        '
        'btnExaminarContenedor
        '
        Me.btnExaminarContenedor.Location = New System.Drawing.Point(264, 9)
        Me.btnExaminarContenedor.Name = "btnExaminarContenedor"
        Me.btnExaminarContenedor.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarContenedor.TabIndex = 12
        Me.btnExaminarContenedor.Text = "Examinar"
        Me.btnExaminarContenedor.UseVisualStyleBackColor = True
        '
        'txtContenedor
        '
        Me.txtContenedor.Location = New System.Drawing.Point(131, 10)
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(128, 20)
        Me.txtContenedor.TabIndex = 11
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 461)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'reportViewer
        '
        Me.reportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet_Stock"
        ReportDataSource1.Value = Me.SP_Stock_Sumarizado_ArticuloBindingSource
        Me.reportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reportViewer.LocalReport.ReportEmbeddedResource = "WES_II.Informe_Stock_Articulo_Sum.rdlc"
        Me.reportViewer.Location = New System.Drawing.Point(3, 124)
        Me.reportViewer.Name = "reportViewer"
        Me.reportViewer.ServerReport.BearerToken = Nothing
        Me.reportViewer.Size = New System.Drawing.Size(778, 335)
        Me.reportViewer.TabIndex = 5
        '
        'SP_Stock_Sumarizado_ArticuloTableAdapter
        '
        Me.SP_Stock_Sumarizado_ArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WES_II.DS_Wes_II_TestBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Reporte_Stock_Articulo_Sumarizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reporte_Stock_Articulo_Sumarizado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDA - Reportes - Reporte Stock Articulo Sumarizado"
        CType(Me.SP_Stock_Sumarizado_ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Wes_II_TestB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnExaminarContenedor As System.Windows.Forms.Button
    Friend WithEvents txtContenedor As System.Windows.Forms.TextBox
    Friend WithEvents reportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteStockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Wes_II_TestB As WES_II.DS_Wes_II_TestB
    Friend WithEvents SP_Stock_Sumarizado_ArticuloTableAdapter As DS_Wes_II_TestBTableAdapters.SP_Stock_Sumarizado_ArticuloTableAdapter
    Friend WithEvents TableAdapterManager As DS_Wes_II_TestBTableAdapters.TableAdapterManager
    Friend WithEvents SP_Stock_Sumarizado_ArticuloBindingSource As BindingSource
End Class
