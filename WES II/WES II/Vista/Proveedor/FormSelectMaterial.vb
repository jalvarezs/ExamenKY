Public Class FormSelectMaterial

    Dim txtProducto As TextBox
    'Dim codigo As String
    'Dim precioRef As String
    Dim ID_proveedor As String = ""

    Dim sinAceptar As Boolean = True
    Dim listaMateriales As List(Of String) = New List(Of String)

    Sub New(ByRef producto As TextBox)
        InitializeComponent()
        ID_proveedor = ""
        txtProducto = producto
    End Sub

    Sub New()
        InitializeComponent()
        txtProducto = Nothing
    End Sub
    Public Sub iniProveedor(ByVal prov As String)
        ID_proveedor = prov
    End Sub

    Private Sub ExamProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla("", ID_proveedor)
    End Sub

    Private Sub actualizarTabla(ByVal nombre As String, ByVal prov As String)
        Try
            Dim productos As DataTable

            ' Consultamos por todos los tipos de producto
            productos = Material.buscar(nombre, prov)

            ' Mostramos tales tipos en el dataGridView correspondiente
            dgvProducto.DataSource = productos
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer

        If dgvProducto.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvProducto.CurrentRow.Index
        End If

        sinAceptar = False
        'If Not IsNothing(txtProducto) Then txtProducto.Text = dgvProducto.Item(1, row).Value.ToString()
        'codigo = dgvProducto.Item(0, row).Value.ToString()
        'precioRef = dgvProducto.Item(3, row).Value.ToString()

        Me.Close()
    End Sub

    Public Function getCodes() As List(Of String)
        Return listaMateriales
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtProductoNombre.TextChanged
        actualizarTabla(txtProductoNombre.Text, ID_proveedor)

        listaMateriales = New List(Of String)

    End Sub

    Private Sub ExamProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            If Not IsNothing(txtProducto) Then txtProducto.Text = ""
            'codigo = ""
            'precioRef = ""
            listaMateriales = New List(Of String)
        End If

    End Sub

    Private Sub dgvProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellClick
        Try
            Dim row As Integer
            Dim codigo As String

            row = dgvProducto.CurrentRow.Index

            Dim chk As DataGridViewCheckBoxCell = dgvProducto.Rows(e.RowIndex).Cells(0)
            codigo = dgvProducto.Rows(e.RowIndex).Cells(1).Value

            If chk.Value Is Nothing Or chk.Value = False Then
                chk.Value = True

                listaMateriales.Add(codigo)

                Return
            End If

            If chk.Value = True Then
                chk.Value = False

                listaMateriales.Remove(codigo)

                Return
            End If

        Catch ex As Exception

        End Try
    End Sub


End Class