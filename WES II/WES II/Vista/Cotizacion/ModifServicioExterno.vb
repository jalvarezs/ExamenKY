Public Class ModifServicioExterno

    'Variables Servicios Externos
    Private ID_ProveedorOSE As Integer = 0
    Private ID_CotizacionOSE As Integer = 0

    Private CodigoServicioExterno As Integer

    Private Sub txtPrecioUnitarioOSE_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitarioOSE.TextChanged
        Try
            txtTotalOSE.Text = ""

            Dim cantidadOSE As Decimal = 0
            cantidadOSE = CInt(txtCantidadOSE.Text.Trim)

            Dim precioUnitarioOSE As Decimal = 0
            precioUnitarioOSE = CDbl(txtPrecioUnitarioOSE.Text.Trim)

            Dim totalOSE As Decimal = cantidadOSE * precioUnitarioOSE

            txtTotalOSE.Text = totalOSE.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCantidadOSE_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadOSE.TextChanged
        Try
            txtTotalOSE.Text = ""

            Dim cantidadOSE As Decimal = 0
            cantidadOSE = CInt(txtCantidadOSE.Text.Trim)

            Dim precioUnitarioOSE As Decimal = 0
            precioUnitarioOSE = CDbl(txtPrecioUnitarioOSE.Text.Trim)

            Dim totalOSE As Decimal = cantidadOSE * precioUnitarioOSE

            txtTotalOSE.Text = totalOSE.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Sub New(ByVal _codigoServicioExterno As Integer)
        Try
            InitializeComponent()

            CodigoServicioExterno = _codigoServicioExterno

            Dim dtServicioExterno As DataTable = Cotizacion.BuscarServicioExterno(_codigoServicioExterno)

            If dtServicioExterno IsNot Nothing Then

                Dim row As DataRow = dtServicioExterno.AsEnumerable.FirstOrDefault

                txtProveedor.Text = row("NombreProveedor")
                txtRuc.Text = row("RUCProveedor")
                txtDirproveedor.Text = row("DireccionProveedor")

                txtCotizacionOSE.Text = row("Cotizacion")

                ID_ProveedorOSE = row("ID_Proveedor")
                ID_CotizacionOSE = row("ID_Cotizacion")

                txtCantidadOSE.Text = row("Cantidad")
                txtPrecioUnitarioOSE.Text = row("Precio_Unitario")
                txtTotalOSE.Text = row("Total")

                txtDetalleOSE.Text = row("Detalle")

                Dim inicioTrabajo As Object = row("ID_Inicio_Trabajo")

                If Not inicioTrabajo.Equals(DBNull.Value) Then
                    btnGuardar.Enabled = False
                    txtDetalleOSE.Enabled = False
                    txtCantidadOSE.Enabled = False
                    txtPrecioUnitarioOSE.Enabled = False
                    btnBuscarProveedor.Enabled = False
                    btnCotizacionOSE.Enabled = False

                    MessageBox.Show("La Orden de Servicio está asociada a una Orden de Trabajo, no se puede modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtProveedor.Text.Trim = "" Then
            MessageBox.Show("Seleccione un Proveedor.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtCotizacionOSE.Text.Trim = "" Then
            MessageBox.Show("Seleccione una Cotización.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtCantidadOSE.Text.Trim = "" Then
            MessageBox.Show("Ingrese una cantidad", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Validar cantidad OSE
        Dim cantidadOSE As Decimal = 0
        Try
            cantidadOSE = CInt(txtCantidadOSE.Text.Trim)
        Catch ex As Exception
            MessageBox.Show("Ingrese una cantidad válida", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        If txtPrecioUnitarioOSE.Text.Trim = "" Then
            MessageBox.Show("Ingrese una Precio Unitario", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Validar cantidad OSE
        Dim precioUnitarioOSE As Decimal = 0
        Try
            precioUnitarioOSE = CDbl(txtPrecioUnitarioOSE.Text.Trim)
        Catch ex As Exception
            MessageBox.Show("Ingrese un Precio Unitario válido", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        Dim totalOSE As Decimal = cantidadOSE * precioUnitarioOSE

        If txtDetalleOSE.Text.Trim = "" Then
            MessageBox.Show("Ingrese el detalle del Servicio Externo", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim rpta As String = Cotizacion.ModificarServicioExterno(CodigoServicioExterno, ID_CotizacionOSE, ID_ProveedorOSE, txtDetalleOSE.Text, cantidadOSE, precioUnitarioOSE, totalOSE)
            If rpta <> "" Then Throw New Exception(rpta)
            MessageBox.Show("El Servicio Externo ha sido actualizado correctamente", "Modificar Servicio Externo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Dim frmExProv As New ExamProveedor(txtProveedor, txtRuc, txtDirproveedor)
        frmExProv.ShowDialog()
        ID_ProveedorOSE = frmExProv.getIdProv()
    End Sub

    Private Sub btnCotizacionOSE_Click(sender As Object, e As EventArgs) Handles btnCotizacionOSE.Click
        Dim form As New ExaminarCotizaciones(txtCotizacionOSE)
        Try

            form.ShowDialog()
            ID_CotizacionOSE = form.idCotizacion - 10000

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class