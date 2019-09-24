Public Class ExamInicioTrabajo

    Dim txtIdInicioTrabajo As TextBox
    Dim txtCodigo As TextBox

    Dim sinAceptar As Boolean = True


    Sub New(ByRef _txtIdInicioTrabajo As TextBox, ByRef _txtCodigo As TextBox)
        Try
            InitializeComponent()

            txtIdInicioTrabajo = _txtIdInicioTrabajo
            txtCodigo = _txtCodigo

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ActualizarTabla()
        Try
            Dim dt As DataTable
            dt = InicioTrabajo.ExaminarInicioTrabajo
            dgvInicioTrabajo.DataSource = dt
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rowIndex As Integer

        Try
            If dgvInicioTrabajo.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                rowIndex = dgvInicioTrabajo.CurrentRow.Index
            End If

            sinAceptar = False

            'Set Examinar 
            Dim _idInicioTrabajo As String = dgvInicioTrabajo.Rows(rowIndex).Cells("Inicio Trabajo").Value.ToString()
            Dim _codigo As String = dgvInicioTrabajo.Rows(rowIndex).Cells("Codigo").Value.ToString()

            txtCodigo.Text = _codigo
            txtIdInicioTrabajo.Text = _idInicioTrabajo


            Me.Close()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Try
            ActualizarTabla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExamInicioTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ActualizarTabla()
        Catch ex As Exception

        End Try
    End Sub
End Class