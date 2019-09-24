Public Class ModifContenedor

    Private id As String

    Sub New(ByVal _id As String)
        Try
            InitializeComponent()
            id = _id
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ModifContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = id
        listarDetallesContenedor()
    End Sub

    Private Sub listarDetallesContenedor()
        Try
            Dim detallesContenedor As DataTable
            detallesContenedor = Contenedor.listarDetalles(id)
            dgvDetalleContenedor.DataSource = detallesContenedor
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim formDetalle As New AgregarDetalleCont(id)
            formDetalle.ShowDialog()
            listarDetallesContenedor()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If dgvDetalleContenedor.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim idProducto As String
            Dim nombreProducto As String
            Dim cantidad As String
            Dim estado As String

            idProducto = dgvDetalleContenedor.CurrentRow.Cells(1).Value.ToString.Trim
            nombreProducto = dgvDetalleContenedor.CurrentRow.Cells(2).Value.ToString.Trim
            cantidad = dgvDetalleContenedor.CurrentRow.Cells(3).Value.ToString.Trim
            estado = dgvDetalleContenedor.CurrentRow.Cells(5).Value.ToString.Trim

            Dim formDetalle As New ModifStock(id, idProducto, nombreProducto, cantidad, estado)
            formDetalle.ShowDialog()
            listarDetallesContenedor()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        Try

            If dgvDetalleContenedor.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvDetalleContenedor.CurrentRow.Index()
            End If

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim idContenedor As String = dgvDetalleContenedor.Item(0, row).Value.ToString
                Dim idProducto As String = dgvDetalleContenedor.Item(1, row).Value.ToString
                Dim rpta As String = DetalleContenedor.eliminar(idContenedor, idProducto)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                listarDetallesContenedor()
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class