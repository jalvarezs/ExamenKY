Public Class FormExamRequerimiento

    Dim txtRequerimiento, txtProyecto, txtCodOrdenCompra, txtAlmacen As TextBox
    Dim ultimoCodigo As Integer = -1
    Dim sinAceptar As Boolean = True

    Private Sub FormExamRequerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub New(ByRef _txtRequerimiento As TextBox, ByRef _txtProyecto As TextBox, ByRef _txtCodOrdenCompra As TextBox, ByRef _txtAlmacen As TextBox)
        InitializeComponent()
        txtRequerimiento = _txtRequerimiento
        txtProyecto = _txtProyecto
        txtCodOrdenCompra = _txtCodOrdenCompra
        txtAlmacen = _txtAlmacen
    End Sub

    Private Sub actualizarTabla()
        Dim requeriemientodt As DataTable
        requeriemientodt = Requerimiento.listarReqPorFechas(dtpFechaInicio.Text, dtpFechaFin.Text, "Aprobado,Entregado Parcialmente")
        dgvRequerimientos.DataSource = requeriemientodt
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer
        sinAceptar = False
        If dgvRequerimientos.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvRequerimientos.CurrentRow.Index
        End If
        txtRequerimiento.Text = dgvRequerimientos.Item(0, row).Value.ToString()
        txtProyecto.Text = dgvRequerimientos.Item(2, row).Value.ToString()
        txtCodOrdenCompra.Text = dgvRequerimientos.Item(4, row).Value.ToString()
        txtAlmacen.Text = dgvRequerimientos.Item(5, row).Value.ToString()
        Me.Dispose()
    End Sub

    Private Sub btnListarR_Click(sender As Object, e As EventArgs) Handles btnListarR.Click
        actualizarTabla()
    End Sub

    Private Sub dgvRequerimientos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRequerimientos.SelectionChanged
        Dim nuevaSeleccion As Integer
        If dgvRequerimientos.CurrentRow Is Nothing Then
            Return
        Else
            nuevaSeleccion = dgvRequerimientos.CurrentRow.Index
        End If

        Dim id As Integer = dgvRequerimientos.Item(0, nuevaSeleccion).Value.ToString()
        actualizarDetalles(id)
    End Sub

    Private Sub actualizarDetalles(ByVal id As String)
        Dim idReq As Integer
        idReq = CInt(id) - 10000
        If ultimoCodigo <> id Then
            Dim detallesOrden As DataTable
            detallesOrden = Requerimiento.listarDetalles(idReq)
            dgvDetalles.DataSource = detallesOrden

            ultimoCodigo = id
        End If
    End Sub
End Class