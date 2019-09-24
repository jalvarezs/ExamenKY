Imports CrystalDecisions.CrystalReports.Engine

Public Class Reporte_Cotizacion
    Public Sub New()
        Try
            InitializeComponent()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub New(ByVal codigoCotizacion As String)
        Try
            InitializeComponent()

            BtnbuscarCotizacion.Enabled = False
            txtCotizacion.Text = codigoCotizacion

            GetDataInicial()

        Catch ex As Exception

        End Try
    End Sub

    Private Property DataSource As List(Of RegistroCotizacion)

    Private Sub BtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtnGenerarReporte.Click
        Try
            Dim report As New WES_II.Informe_Cotizacion()
            TabMain.SelectedIndex = 2

            Dim source As DataTable = Cotizacion.CotizacionInforme(txtCotizacion.Text)
            report.SetDataSource(source)

            report.SetParameterValue("LugarCotizacion", txtLugarCotizacion.Text)
            report.SetParameterValue("FechaCotizacion", Date.Now)
            report.SetParameterValue("PrefijoCliente", cmbPrefijoCliente.Text)
            report.SetParameterValue("TextEncabezado", txtEncabezadoReporte.Text)

            SetFieldFormat(report, "FldLugarFecha", txtTestFuenteLugarFecha.Font, txtTestFuenteLugarFecha.ForeColor, "to")
            SetFieldFormat(report, "FldDestinatario", txtTestFuenteDestinatario.Font, txtTestFuenteDestinatario.ForeColor, "to")
            SetFieldFormat(report, "FldCotizacion", txtTestFuenteFolioCotizacion.Font, txtTestFuenteFolioCotizacion.ForeColor, "to")
            SetFieldFormat(report, "TxtEncabezado", txtTestFuenteTextoEncabezado.Font, txtTestFuenteTextoEncabezado.ForeColor, "to")
            SetFieldFormat(report, "GroupNameGrupoPrincipal", txtTestFuenteEncabezadoPrincipal.Font, txtTestFuenteEncabezadoPrincipal.ForeColor, "fo")
            SetFieldFormat(report, "FieldHead1", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead2", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead3", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead4", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead5", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead6", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead7", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead8", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "FieldHead9", txtTestFuenteEncabezadoSecundario.Font, txtTestFuenteEncabezadoSecundario.ForeColor, "to")
            SetFieldFormat(report, "IDMaterial", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "Material", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "Cantidad", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "PrecioUnitario", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "Descuento", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "PrecioTotal", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "Personal", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "CantidadPersonal", txtTestFuenteTextEstandar.Font, txtTestFuenteTextEstandar.ForeColor, "fo")
            SetFieldFormat(report, "ValorTotal", txtTestFuenteEncabezadoPrincipal.Font, txtTestFuenteEncabezadoPrincipal.ForeColor, "fo")

            CrvReport.ReportSource = report
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención!")
        End Try
    End Sub

    Private Sub SetFieldFormat(report As ReportDocument, fieldName As String, fieldFont As Font, textColor As Color, fieldType As String)
        Select Case fieldType
            Case "to"
                Dim field As TextObject
                field = report.ReportDefinition.ReportObjects(fieldName)
                field.Color = textColor
                field.ApplyFont(fieldFont)
            Case "fo"
                Dim field As FieldObject
                field = report.ReportDefinition.ReportObjects(fieldName)
                field.Color = textColor
                field.ApplyFont(fieldFont)
            Case Else
                Dim field As TextObject
                field = report.ReportDefinition.ReportObjects(fieldName)
                field.Color = textColor
                field.ApplyFont(fieldFont)
        End Select

    End Sub

    Private Sub BtnFuente_Click(sender As Object, e As EventArgs) Handles BtnFuenteTextoEncabezado.Click, BtnFuenteTextEstandar.Click, BtnFuenteLugarFecha.Click, BtnFuenteFolioCotizacion.Click, BtnFuenteEncabezadoSecundario.Click, BtnFuenteEncabezadoPrincipal.Click, BtnFuenteDestinatario.Click
        Try
            Dim fuente As Font
            Dim fuenteStr As String = String.Empty
            Dim origen As Button = sender

            If FontSelector.ShowDialog() = DialogResult.OK Then
                fuente = FontSelector.Font
                fuenteStr = String.Concat(fuente.Name, ", ", IIf(fuente.Italic, "Cursiva, ", ""),
                                                     IIf(fuente.Bold, "Negrita, ", ""), "Tamaño: ", fuente.Size)
            Else
                Return
            End If

            Select Case origen.Name
                Case "BtnFuenteLugarFecha"
                    txtFuenteLugarFecha.Text = fuenteStr
                    txtTestFuenteLugarFecha.Font = fuente
                    Exit Select
                Case "BtnFuenteDestinatario"
                    txtFuenteDestinatario.Text = fuenteStr
                    txtTestFuenteDestinatario.Font = fuente
                    Exit Select
                Case "BtnFuenteFolioCotizacion"
                    txtFuenteFolioCotizacion.Text = fuenteStr
                    txtTestFuenteFolioCotizacion.Font = fuente
                    Exit Select
                Case "BtnFuenteTextoEncabezado"
                    txtFuenteTextoEncabezado.Text = fuenteStr
                    txtTestFuenteTextoEncabezado.Font = fuente
                    Exit Select
                Case "BtnFuenteEncabezadoPrincipal"
                    txtFuenteEncabezadoPrincipal.Text = fuenteStr
                    txtTestFuenteEncabezadoPrincipal.Font = fuente
                    Exit Select
                Case "BtnFuenteEncabezadoSecundario"
                    txtFuenteEncabezadoSecundario.Text = fuenteStr
                    txtTestFuenteEncabezadoSecundario.Font = fuente
                    Exit Select
                Case "BtnFuenteTextEstandar"
                    txtFuenteTextEstandar.Text = fuenteStr
                    txtTestFuenteTextEstandar.Font = fuente
                    Exit Select
            End Select
        Catch ex As ArgumentException
            MessageBox.Show("El reporte solo permite el uso de fuentes de tipo TrueType.", "Atención.")
        End Try
    End Sub

    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColorTextoEncabezado.Click, BtnColorTextEstandar.Click, BtnColorLugarFecha.Click, BtnColorFolioCotizacion.Click, BtnColorEncabezadoSecundario.Click, BtnColorEncabezadoPrincipal.Click, BtnColorDestinatario.Click
        Dim color As Color
        Dim origen As Button = sender

        If ColorSelector.ShowDialog() = DialogResult.OK Then
            color = ColorSelector.Color
        Else
            Return
        End If

        Select Case origen.Name
            Case "BtnColorLugarFecha"
                pnlColorLugarFecha.BackColor = color
                txtTestFuenteLugarFecha.ForeColor = color
                Exit Select
            Case "BtnColorDestinatario"
                PnlColorDestinatario.BackColor = color
                txtTestFuenteDestinatario.ForeColor = color
                Exit Select
            Case "BtnColorFolioCotizacion"
                PnlColorFolioCotizacion.BackColor = color
                txtTestFuenteFolioCotizacion.ForeColor = color
                Exit Select
            Case "BtnColorTextoEncabezado"
                PnlColorTextoEncabezado.BackColor = color
                txtTestFuenteTextoEncabezado.ForeColor = color
                Exit Select
            Case "BtnColorEncabezadoPrincipal"
                PnlColorEncabezadoPrincipal.BackColor = color
                txtTestFuenteEncabezadoPrincipal.ForeColor = color
                Exit Select
            Case "BtnColorEncabezadoSecundario"
                PnlColorEncabezadoSecundario.BackColor = color
                txtTestFuenteEncabezadoSecundario.ForeColor = color
                Exit Select
            Case "BtnColorTextEstandar"
                PnlColorTextEstandar.BackColor = color
                txtTestFuenteTextEstandar.ForeColor = color
                Exit Select
        End Select
    End Sub

    Private Sub BtnbuscarCotizacion_Click(sender As Object, e As EventArgs) Handles BtnbuscarCotizacion.Click
        Try

            Dim ventana As New ExamCotizacion(txtCotizacion)
            ventana.ShowDialog()
            GetDataInicial()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetDataInicial()
        Try
            If String.IsNullOrWhiteSpace(txtCotizacion.Text) Then
                Throw New Exception("No se ha seleccionado una cotización.")
            End If

            'DataSource = New List(Of RegistroCotizacion)

            Dim cotizacionSeleccionada As DataTable = Cotizacion.Buscar(Integer.Parse(txtCotizacion.Text) - 10000)
            If cotizacionSeleccionada Is Nothing Or cotizacionSeleccionada.Rows.Count = 0 Then
                Throw New Exception("No se ha encontrado la cotización seleccionada.")
            End If

            Dim rowCoti As DataRow = cotizacionSeleccionada.AsEnumerable.FirstOrDefault

            Dim clienteCotizacion As DataTable = Cliente.buscarPorId(rowCoti("ID_Cliente"))
            If clienteCotizacion Is Nothing Then
                Throw New Exception("No se ha encontrado el cliente de ésta contización.")
            End If

            Dim rowCliente As DataRow = clienteCotizacion.AsEnumerable.FirstOrDefault

            txtRuc.Text = rowCliente("RUC")
            txtCliente.Text = rowCliente("Nombre")

            Dim detallesCotizacion As DataTable = Cotizacion.ListarDetalles(rowCoti("Código Cotización") - 10000)
            If detallesCotizacion Is Nothing Then
                Throw New Exception("No se han encontrado detalles para ésta cotización.")
            End If

            Dim personalCotizacion As DataTable = Cotizacion.ListarPersonalCotizacion(rowCoti("Código Cotización") - 10000)
            If personalCotizacion Is Nothing Then
                Throw New Exception("No se han encontrado datos de personal para ésta cotización.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención")
        End Try
    End Sub
End Class