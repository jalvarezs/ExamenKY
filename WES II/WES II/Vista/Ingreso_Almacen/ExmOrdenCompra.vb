Public Class ExmOrdenCompra

    Private conexion As Conexion
    'Private tablaProductos As DataTable = New DataTable()
    Private sinaceptar As Boolean = True

    Private Sub ExmOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim ordenCompradt As DataTable
    Dim ultimoCodigo As Integer = -1

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ordenCompradt = OrdenCompra.listarPorFechas(dtpInicio.Text.ToString, dtpFin.Text.ToString)
        dgvOrden.DataSource = ordenCompradt
    End Sub

    Private Sub dgvOrden_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrden.SelectionChanged
        Try
            Dim nuevaSeleccion As Integer
            If dgvOrden.CurrentRow Is Nothing Then
                Return
            Else
                nuevaSeleccion = dgvOrden.CurrentRow.Index
            End If

            Dim id As Integer = dgvOrden.Item(0, nuevaSeleccion).Value.ToString()
            actualizarDetalles(id)
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub actualizarDetalles(ByVal id As String)
        Try
            Dim OrdenID As Integer
            OrdenID = CInt(id) - 10000
            If ultimoCodigo <> id Then
                Dim detallesOrden As DataTable
                detallesOrden = OrdenCompra.listarDetalles(OrdenID)
                dgvDetalles.DataSource = detallesOrden
                ultimoCodigo = id
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function getOrdenCompra() As String
        Return codigo
    End Function

    Public Function getProveedor() As String
        Return proveedor
    End Function

    Public Function getProyecto() As String
        Return proyecto
    End Function

    Public Function getOferta() As String
        Return oferta
    End Function

    Private Sub ExmOrdenCompra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sinaceptar Then
            codigo = ""
        End If
    End Sub

    Dim codigo As String = ""
    Dim proveedor As String
    Dim proyecto As String
    Dim oferta As String

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer
        sinaceptar = False
        If dgvOrden.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvOrden.CurrentRow.Index
        End If
        codigo = dgvOrden.Item(0, row).Value.ToString()
        proveedor = dgvOrden.Item(4, row).Value.ToString()
        proyecto = dgvOrden.Item(5, row).Value.ToString()
        oferta = dgvOrden.Item(6, row).Value.ToString()
        Me.Close()
    End Sub
End Class