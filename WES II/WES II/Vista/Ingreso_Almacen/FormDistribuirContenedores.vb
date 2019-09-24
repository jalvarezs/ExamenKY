Public Class FormDistribuirContenedores

    Dim txtDestino As TextBox
    Property IdContenedor As String = ""
    Property EtiquetaContenedor As String = ""
    Property QtyEntrante As String
    Property IdMaterial As String


    Dim _ListDetalleMaterial As List(Of IngresoMaterialDetalle)

    Sub New(ByRef listDetalleMaterial As List(Of IngresoMaterialDetalle), ByVal codigoMaterial_ As String, ByVal pCantidadEntrante As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        _ListDetalleMaterial = listDetalleMaterial

        dgvContenedores.AutoGenerateColumns = False

        QtyEntrante = pCantidadEntrante

        IdMaterial = codigoMaterial_

    End Sub

    Private Sub FormExamContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCantidadEntrante.Text = QtyEntrante

            CargarDetallesContenedores()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnDistContenedor_Click(sender As Object, e As EventArgs) Handles btnDistContenedor.Click
        Try

            Dim frmAgregarContenedor As New FormAgregarContenedor(_ListDetalleMaterial, QtyEntrante, IdMaterial)
            frmAgregarContenedor.ShowDialog()

            CargarDetallesContenedores()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarDetallesContenedores()
        Try

            dgvContenedores.DataSource = Nothing
            dgvContenedores.Refresh()

            dgvContenedores.DataSource = _ListDetalleMaterial.Where(Function(x) x.CodigoMaterial.Equals(IdMaterial)).ToList

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarContenedor_Click(sender As Object, e As EventArgs) Handles btnEliminarContenedor.Click
        Try

            Dim row As Integer
            Dim codigoContenedor As String
            Dim tipoContenedor As String
            Dim cantidadEntrante As Integer

            If dgvContenedores.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvContenedores.CurrentRow.Index
            End If

            tipoContenedor = dgvContenedores.Item(6, row).Value

            If tipoContenedor = UtilConstantes.TipoContenedor.Base Then
                MessageBox.Show("No se puede eliminar el contenedor base", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            codigoContenedor = dgvContenedores.Item(5, row).Value
            cantidadEntrante = UtilConvertidor.GetInteger(dgvContenedores.Item(4, row).Value)

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim f As IngresoMaterialDetalle
                f = _ListDetalleMaterial.Where(Function(x) x.Contenedor.Equals(codigoContenedor)).FirstOrDefault
                _ListDetalleMaterial.Remove(f)

                For Each detalle As IngresoMaterialDetalle In _ListDetalleMaterial
                    If detalle.TipoContenedor = UtilConstantes.TipoContenedor.Base Then
                        detalle.CantidadEntrante = detalle.CantidadEntrante + cantidadEntrante
                    End If
                Next
            End If

            CargarDetallesContenedores()

        Catch ex As Exception

        End Try
    End Sub
End Class