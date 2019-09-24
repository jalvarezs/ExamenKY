Public Class FormMaterialesAsociados
    Private idProveedor, nombre As String

    Sub New(ByVal _id As String, ByVal _nombre As String)
        InitializeComponent()

        idProveedor = _id 'ID_Proveedor
        nombre = _nombre
    End Sub

    Private Sub FormMaterialesAsociados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProveedor.Text = nombre
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()
        Dim materiales As DataTable

        ' Consultamos por todos los tipos de producto
        materiales = Proveedor.listarMateriales(idProveedor)

        ' Mostramos tales tipos en el dataGridView correspondiente
        dgvMaterialesProveedor.DataSource = materiales
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        If dgvMaterialesProveedor.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvMaterialesProveedor.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim idMaterial As String = dgvMaterialesProveedor.Item(1, row).Value.ToString
            Proveedor.eliminarMaterial(idProveedor, idMaterial)
            actualizarTabla()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim formExamMateriales As New FormSelectMaterial()
            formExamMateriales.iniProveedor("")
            formExamMateriales.ShowDialog()

            Dim codigos As List(Of String) = formExamMateriales.getCodes()

            For Each codigo In codigos
                Proveedor.agregarMaterial(idProveedor, CInt(codigo) - 10000)
            Next

            actualizarTabla()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
    End Sub
End Class