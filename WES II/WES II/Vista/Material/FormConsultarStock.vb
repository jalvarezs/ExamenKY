Public Class FormConsultarStock

    Property nuevaSeleccion As Integer = -1
    Property ultimoCodigo As Integer = -1

    Property idMaterial As String
    Dim sinAceptar As Boolean = True

    Public Sub New()
        InitializeComponent()
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()
        Dim listaStock As DataTable

        listaStock = Material.listarStocks()

        dgvStockMateriales.DataSource = listaStock
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer

        If dgvStockMateriales.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvStockMateriales.CurrentRow.Index
        End If

        sinAceptar = False

        idMaterial = dgvStockMateriales.Item(0, row).Value.ToString()

        Me.Close()


        Me.Dispose()
    End Sub

    Private Sub dgvStockMateriales_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStockMateriales.SelectionChanged
        ' Verifica que la sección sea válida, y da la orden de actualizar
        Dim nuevaSeleccion As Integer
        If dgvStockMateriales.CurrentRow Is Nothing Then
            Return
        Else
            nuevaSeleccion = dgvStockMateriales.CurrentRow.Index
        End If

        Dim id As Integer = dgvStockMateriales.Item(0, nuevaSeleccion).Value.ToString()
        actualizarDetalles(id)
    End Sub

    Private Sub actualizarDetalles(ByVal id As String)
        ' Recibe el código en cadena, lo transforma a entero y trae los datos

        Dim idMaterial As Integer
        idMaterial = CInt(id) - 10000
        If ultimoCodigo <> id Then
            Dim proveedoresSegunMaterial As DataTable
            proveedoresSegunMaterial = Proveedor.listarSegunMaterial(idMaterial)
            dgvProveedores.DataSource = proveedoresSegunMaterial

            ultimoCodigo = id
        End If
    End Sub

    Private Sub FormConsultarStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class