Public Class DetallePersonal
    Dim totalGeneral As Integer = 0
    Property dtPersonal As New DataTable

    Dim txtFechaInicioPlanificada As TextBox

    Sub New(ByRef _txtFechaInicioPlanificada As TextBox)
        Try
            InitializeComponent()
            txtFechaInicioPlanificada = _txtFechaInicioPlanificada
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        LlenarDatatable()
        Me.Close()
    End Sub

    Private Sub DetallePersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla("")
    End Sub

    Private Sub actualizarTabla(ByVal descripcion As String)
        Dim persona As DataTable
        persona = Personal.buscar(descripcion)
        dgvPersonal.DataSource = persona
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If todoCorrecto() Then
            agregarFila()
        End If
    End Sub
    Private Function todoCorrecto()

        If (txtCantidad.Text.Trim = "") Then
            ErrorProvider.SetError(txtCantidad, "Ingrese una cantidad.")
            Return False
        Else
            ErrorProvider.SetError(txtCantidad, Nothing)
        End If

        If (txtHoras.Text.Trim = "") Then
            ErrorProvider.SetError(txtHoras, "Ingrese las horas.")
            Return False
        Else
            ErrorProvider.SetError(txtHoras, Nothing)
        End If

        Try
            Dim temporal = CInt(txtCantidad.Text.Trim)
            ErrorProvider.SetError(txtCantidad, Nothing)

        Catch ex As Exception
            errorProvider.SetError(txtCantidad, "Ingrese una cantidad válida.")
            Return False
        End Try

        Return True
    End Function

    Public Sub AgregarPersonal()
        
    End Sub
    Private Sub agregarFila()

        Dim row As Integer
        Dim codigo As Integer
        Dim descripcion As String
        Dim fecha As Date

        Try
            ' Cargamos los datos de personal
            row = dgvPersonal.CurrentRow.Index
            codigo = dgvPersonal.Item(0, row).Value
            descripcion = dgvPersonal.Item(1, row).Value.ToString
            fecha = txtFechaInicioPlanificada.Text

            ' Buscamos si el material ya se registró antes
            For j As Integer = 0 To dgDetalle.Rows.Count - 1
                Dim dato As String = descripcion
                If dgDetalle.Rows(j).Cells(1).Value.ToString = dato Then

                    If deseaSumarCantidad() Then
                        sumarCantidad(j)
                    End If

                    ' Termina con el método, ya no se agrega fila
                    actualizarTotales()
                    Return

                End If
            Next

            ' Es un personal, se añade una nueva fila
            dgDetalle.Rows.Add(codigo, descripcion, txtCantidad.Text, txtHoras.Text, totalGeneral, fecha)

            ' Sea por el aumento o por la nueva fila insertada
            actualizarTotales()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarTotales()

        Try
            For Each row As DataGridViewRow In dgDetalle.Rows
                Dim cantidad As Decimal = CDec(row.Cells(2).Value)
                Dim horas As Integer = CDec(row.Cells(3).Value)
                Dim total As Integer = cantidad * horas

                row.Cells(4).Value = total
                totalGeneral += total
            Next

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub sumarCantidad(ByVal j As String)
        Try
            Dim cantidadPrevia As Integer = CDbl(dgDetalle.Rows(j).Cells(2).Value.ToString)
            Dim cantAdicional As Integer = CDbl(txtCantidad.Text)
            dgDetalle.Rows(j).Cells(2).Value = CStr(cantidadPrevia + cantAdicional)
        Catch
            MessageBox.Show("Por favor ingrese cantidades válidas.")
        End Try
    End Sub

    Private Function deseaSumarCantidad() As Boolean
        Dim msg As String = "El material ya ha sido agregado, desea añadir la cantidad indicada?"
        Dim title As String = "Sugerencia"
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or _
           MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

        ' Mostrar la caja de entrada
        response = MsgBox(msg, style, title)

        ' Devuelve TRUE si aceptó
        Return response = MsgBoxResult.Yes
    End Function

    Public Sub LlenarDatatable()
        Try

            Dim nuevoDT As New DataTable
            Dim nuevaColumna As DataColumn
            Dim nuevaFila As DataRow
            Dim totalColumnas As Integer

            For Each columna As DataGridViewColumn In dgDetalle.Columns
                nuevaColumna = New DataColumn(columna.Name)
                nuevoDT.Columns.Add(nuevaColumna)
            Next
            totalColumnas = nuevoDT.Columns.Count

            For Each filaDatos As Windows.Forms.DataGridViewRow In dgDetalle.Rows
                nuevaFila = nuevoDT.NewRow()
                For i As Integer = 0 To totalColumnas - 1
                    nuevaFila(i) = filaDatos.Cells(i).Value
                Next
                nuevoDT.Rows.Add(nuevaFila)
            Next

            dtPersonal = nuevoDT
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

End Class