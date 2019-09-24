Public Class ExamProveedor

    Private conexion As Conexion
    Dim txtproveedor As TextBox
    Dim txtrucproveedor As TextBox
    Dim txtdirproveedor As TextBox
    Dim idproveedor As String
    Dim sinAceptar As Boolean = True

    Sub New(ByRef proveedor As TextBox, ByVal ruc As TextBox, ByVal direccion As TextBox)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        txtproveedor = proveedor
        txtrucproveedor = ruc
        txtdirproveedor = direccion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Sub New(ByRef proveedor As TextBox, ByVal ruc As TextBox)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        txtproveedor = proveedor
        txtrucproveedor = ruc


    End Sub

    Private Sub ExamProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla("")
    End Sub

    Private Sub actualizarTabla(ByVal nombre As String)
        Dim proveedordt As DataTable

        ' Consultamos por todos los tipos de producto
        proveedordt = Proveedor.buscar(nombre)

        ' Mostramos tales tipos en el dataGridView correspondiente
        dgvProveedor.DataSource = proveedordt
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer
        sinAceptar = False
        If dgvProveedor.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvProveedor.CurrentRow.Index
        End If
        txtproveedor.Text = dgvProveedor.Item(1, row).Value.ToString()

        If txtdirproveedor IsNot Nothing Then
            txtdirproveedor.Text = dgvProveedor.Item(2, row).Value.ToString()
        End If

        txtrucproveedor.Text = dgvProveedor.Item(3, row).Value.ToString()
        idproveedor = dgvProveedor.Item(0, row).Value.ToString()
        Me.Close()

    End Sub

    Public Function getIdProv() As String
        Return idproveedor
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProveedor.TextChanged
        actualizarTabla(txtNombreProveedor.Text)
    End Sub

    Private Sub ExamProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinAceptar Then
            txtproveedor.Text = ""
            idproveedor = ""
        End If
    End Sub
End Class