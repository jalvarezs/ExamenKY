Public Class ExamFamilia

    Dim txtCodigoTemp As TextBox
    Dim txtDescripcionTemp As TextBox

    Dim sinAceptar As Boolean = True
    Property DatosSubFamilia As ExaminarSubFamilia

    Sub New(ByRef _txtCodigo As TextBox, ByRef _txtDescripcion As TextBox)
        Try
            InitializeComponent()

            txtCodigoTemp = _txtCodigo
            txtDescripcionTemp = _txtDescripcion

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ExamOrdenServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ActualizarTabla("")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ActualizarTabla(ByVal nombre As String)
        Try
            Dim dtFamiliaSubFamilia As DataTable
            dtFamiliaSubFamilia = Familia.ExaminarFamiliaSubFamilia(nombre)
            dgvFamiliaSubFamilia.DataSource = dtFamiliaSubFamilia
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rowIndex As Integer

        Try
            If dgvFamiliaSubFamilia.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                rowIndex = dgvFamiliaSubFamilia.CurrentRow.Index
            End If

            sinAceptar = False

            'Set Examinar Sub-Familia
            Dim _idFamilia As String = dgvFamiliaSubFamilia.Rows(rowIndex).Cells("Codigo Familia").Value.ToString()
            Dim _idSubFamilia As String = dgvFamiliaSubFamilia.Rows(rowIndex).Cells("Codigo SubFamilia").Value.ToString()

            DatosSubFamilia = New ExaminarSubFamilia
            DatosSubFamilia.IdFamilia = CInt(_idFamilia) - 10000
            DatosSubFamilia.NombreFamilia = dgvFamiliaSubFamilia.Rows(rowIndex).Cells("Familia").Value.ToString()

            DatosSubFamilia.NombreSubFamilia = dgvFamiliaSubFamilia.Rows(rowIndex).Cells("Sub-Familia").Value.ToString()

            If _idSubFamilia.Equals("") Then
                txtCodigoTemp.Text = _idFamilia
                txtDescripcionTemp.Text = DatosSubFamilia.NombreFamilia

                DatosSubFamilia.IdSubFamilia = 0
            Else
                txtCodigoTemp.Text = _idFamilia & " | " & _idSubFamilia
                txtDescripcionTemp.Text = DatosSubFamilia.NombreFamilia & " | " & DatosSubFamilia.NombreSubFamilia

                DatosSubFamilia.IdSubFamilia = CInt(_idSubFamilia) - 10000

            End If

            Me.Close()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ExamCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtCodigoTemp.Text = ""
            txtDescripcionTemp.Text = ""
            DatosSubFamilia = New ExaminarSubFamilia
        End If
    End Sub

    Private Sub txtNroOrdenServicio_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Try

            ActualizarTabla(txtNombre.Text.Trim)

        Catch ex As Exception

        End Try
    End Sub

    Public Function GetExaminarSubFamilia() As ExaminarSubFamilia
        Return DatosSubFamilia
    End Function

End Class