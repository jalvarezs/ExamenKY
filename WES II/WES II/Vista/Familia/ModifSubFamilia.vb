Public Class ModifSubFamilia

    Private IdSubFamilia, IdFamilia As Integer
    Private Nombre, Descripcion As String

    Sub New(ByVal _idSubFamilia As Integer)
        Try
            InitializeComponent()

            IdSubFamilia = _idSubFamilia

            Dim subFamilia As DataTable = Familia.ObtenerSubFamiliaPorId(_idSubFamilia)

            If subFamilia IsNot Nothing Then
                If subFamilia.Rows.Count > 0 Then

                    Dim row As DataRow = subFamilia.AsEnumerable.FirstOrDefault
                    IdSubFamilia = row("ID_SubFamilia_Material")
                    IdFamilia = row("ID_Familia_Material")
                    Nombre = row("Nombre")
                    Descripcion = row("Descripcion")
                End If
            End If

            CargarFamilias()

            cbFamilia.SelectedValue = IdFamilia
            txtNombre.Text = Nombre
            txtDescripcion.Text = Descripcion

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CargarFamilias()
        Dim lista As New List(Of EntidadDropDown)

        Dim entidadNuevoItem As New EntidadDropDown
        entidadNuevoItem.Id = 0
        entidadNuevoItem.Descripcion = "Seleccione"
        lista.Add(entidadNuevoItem)

        Dim dtFamilias As DataTable = Familia.ListarFamilias


        For Each dr As DataRow In dtFamilias.Rows
            Dim entidad As New EntidadDropDown
            entidad.Id = dr("ID_Familia_Material")
            entidad.Descripcion = dr("Nombre")
            lista.Add(entidad)
        Next

        cbFamilia.DataSource = lista
        cbFamilia.ValueMember = "Id"
        cbFamilia.DisplayMember = "Descripcion"

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim idFamilia As Integer = cbFamilia.SelectedValue

            If idFamilia.Equals(0) Then
                MessageBox.Show("Por favor, seleccione una Familia", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If txtNombre.Text.Trim.Equals("") Then
                MessageBox.Show("Por favor, ingrese el nombre de la Sub-Familia", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim nombre As String = txtNombre.Text
            Dim descripcion As String = txtDescripcion.Text

            Dim rpta As String = Familia.ModificarSubFamilia(IdSubFamilia, idFamilia, nombre, descripcion)

            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Dispose()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorFamilia.SetError(sender, "")
        Else
            ErrorFamilia.SetError(sender, "El nombre es un dato obligatorio.")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

    End Sub
End Class