Public Class FormControlServicios

    Private nroProforma, idCliente As Integer
    Private trabajo, contacto, estado As String
    Private fecha As Date
    Private horaInicio As TimeSpan
    Dim dt As DataTable
    Private avance As Integer
    Private codigoControlServicio As Integer
    Dim banderaPersonal As Integer = 0

    ' Actualizar Tabla
    Private Sub actualizarTabla()
        Dim servicios As DataTable

        Try
            servicios = ControlServicio.listar()
            dgvControlServicios.DataSource = servicios
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    ' Load
    Private Sub FormControlServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla()

        banderaPersonal = 0
    End Sub

    ' Examinar Cotización
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim form As New ExaminarCotizaciones(txtProforma, txtCliente, txtTrabajo, txtFecha, txtContacto,
                                             txtFechaInicioPlanificada, txtFechaFinPlanificada, txtHoraInicioPlanificada,
                                            txtHoraFinPlanificada, txtEstado)
        Try

            form.ShowDialog()
            nroProforma = form.idCotizacion - 10000
            idCliente = form.idCliente
            trabajo = form.trabajo
            contacto = form.contacto
            fecha = form.fecha
            horaInicio = form.hora
            estado = form.Estado
            txtTotalHoras.Text = form.duracionHoras

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    ' Aceptar
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    ' Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim responsable As String = txtResponsable.Text
        Dim fechaInicioPlan As Date = dtpFechaInicioPlanificada.Value.Date
        Dim horaInicioPlan As TimeSpan = dtpHoraInicioPlanificada.Value.TimeOfDay
        Dim fechaFinPlan As Date = dtpFechaFinPlanificada.Value.Date
        Dim horaFinPlan As TimeSpan = dtpHoraFinPlanificada.Value.TimeOfDay
        Dim fechaInicioReal As Date = dtpFechaInicioReal.Value.Date
        Dim horaInicioReal As TimeSpan = dtpHoraInicioReal.Value.TimeOfDay
        Dim fechaFinReal As Date = dtpFechaFinReal.Value.Date
        Dim horaFinReal As TimeSpan = dtpHoraFinReal.Value.TimeOfDay
        Dim retrasos As String = txtRetrasos.Text
        Dim estado1 As String = txtEstado.Text

        Try

            If txtCliente.Text = "" Then
                MessageBox.Show("Debe cargar un cliente previamente.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If banderaPersonal = 0 Then
                MessageBox.Show("Debe cargar el personal.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Registrar control de servicio
            Dim rpta As String = ControlServicio.registrar(idCliente, trabajo, fecha, contacto, responsable,
                                                           fechaInicioPlan, horaInicioPlan, fechaFinPlan, horaFinPlan,
                                                           fechaInicioReal, horaInicioReal, fechaFinReal, horaFinReal,
                                                           avance, retrasos, estado1, nroProforma)

            If rpta <> "" Then
                Throw New System.Exception(rpta)
            End If

            Dim idControlServicio As Integer
            idControlServicio = ControlServicio.obtenerUltimoID()

            ' Registrar detalle personal
            Dim i As Integer
            Dim idPersonal, cantidad, horas, total As Integer
            Dim fechaDetalle As Date

            For i = 0 To dt.Rows.Count - 1
                idPersonal = dt.Rows(i).Item(0)
                cantidad = dt.Rows(i).Item(2)
                horas = dt.Rows(i).Item(3)
                total = dt.Rows(i).Item(4)
                fechaDetalle = dt.Rows(i).Item(5)

                Dim rpta2 As String = ControlServicio.registrarDetalle(idControlServicio, idPersonal, cantidad, horas, total, fechaDetalle)

                If rpta2 <> "" Then
                    Throw New System.Exception(rpta2)
                End If
            Next


            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarTabla()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    ' Botón Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        Try
            If dgvControlServicios.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvControlServicios.CurrentRow.Index
            End If

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim id As String = dgvControlServicios.Item(0, row).Value.ToString
                Dim rpta As String = ControlServicio.eliminar(id)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    ' Horas
    Private Sub btnHoras_Click(sender As Object, e As EventArgs)
        Dim difHora As TimeSpan
        Dim difFecha As String
        Dim d1, d2 As Date

        difHora = dtpHoraFinPlanificada.Value.Subtract(dtpHoraInicioPlanificada.Value)
        txtHoraFinPlanificada.Text = difHora.ToString

        d1 = dtpFechaFinPlanificada.Value
        d2 = dtpFechaInicioPlanificada.Value

        difFecha = DateDiff(DateInterval.Day, d2, d1)
        txtFechaFinPlanificada.Text = difFecha

    End Sub

    ' Personal
    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        Dim p As New DetallePersonal(txtFechaInicioPlanificada)

        Try

            If (txtProforma.Text.Trim = "") Then
                ErrorProvider.SetError(txtProforma, "Debe cargar el número de proforma previamente.")
                MessageBox.Show("Debe cargar el número de proforma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                ErrorProvider.SetError(txtProforma, Nothing)
            End If

            p.ShowDialog()
            dt = p.dtPersonal

            If dt.Rows.Count <> 0 Then
                lblPersonal.Text = "Personal Cargado"
                lblPersonal.ForeColor = Color.Green
            End If

            Dim subTotal, total As Integer
            For i = 0 To dt.Rows.Count - 1
                subTotal = dt.Rows(i).Item(4)
                total = total + subTotal
            Next

            txtHorasDia.Text = total

            'Mostrando avance
            Dim totalHorasPlanificadas, avanceHoras As Integer

            totalHorasPlanificadas = txtTotalHoras.Text
            avanceHoras = (total * 100) / totalHorasPlanificadas
            txtAvance.Text = avanceHoras
            avance = txtAvance.Text

            banderaPersonal = 1

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    ' Click en Grilla
    Private Sub dgvControlServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvControlServicios.CellClick
        Dim row As Integer
        Try

            row = dgvControlServicios.CurrentRow.Index
            codigoControlServicio = dgvControlServicios.Item(0, row).Value
            actualizarTablaDetalle()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    ' Actualizar Tabla
    Private Sub actualizarTablaDetalle()
        Dim detallePersonal As DataTable

        detallePersonal = ControlServicio.buscarPersonal(codigoControlServicio)
        dgDetallePersonal.DataSource = detallePersonal
    End Sub
End Class