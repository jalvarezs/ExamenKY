Public Class FormAgregarContenedor

    Property IdContenedor As String = String.Empty
    Property CantidadContenedor As Integer
    Property CantidadContenedorAdicional As Integer
    Property TotalContenedorBase As Integer
    Property EtiquetaContenedor As String = String.Empty
    Property QtyEntrante As String
    Property IdMaterial As String

    Dim _ListDetalleMaterial As List(Of IngresoMaterialDetalle)

    Sub New(ByRef listDetalleMaterial As List(Of IngresoMaterialDetalle), ByVal _cantidadEntrante As String, ByVal idMaterial_ As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        _ListDetalleMaterial = listDetalleMaterial

        QtyEntrante = _cantidadEntrante

        IdMaterial = idMaterial_

    End Sub

    Private Sub FormExamContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCantidadEntrante.Text = QtyEntrante

            CalcularTotalContenedorBase()

            CalcularTotalContenedorAdicionales()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If (CantidadContenedor - CantidadContenedorAdicional < 0) Then
                MessageBox.Show(
                    String.Format("El contenedor solo tiene espacio para {0} elementos. Debe modificar la cantidad para el contenedor adicional o seleccionar otro contenedor",
                                  CantidadContenedor),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                txtQtyContenedorAdicional.Select()
                Return
            End If

            If (TotalContenedorBase - CantidadContenedorAdicional <= 0) Then
                MessageBox.Show(
                    "El cantidad del contenedor adicional no puede ser igual o mayor que la del contenedor base",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                txtQtyContenedorAdicional.Select()
                Return
            End If

            Dim detalleNuevo As New IngresoMaterialDetalle

            For Each detalle As IngresoMaterialDetalle In _ListDetalleMaterial
                If detalle.TipoContenedor = UtilConstantes.TipoContenedor.Base And detalle.CodigoMaterial.Equals(IdMaterial) Then
                    detalle.CantidadEntrante = TotalContenedorBase - CantidadContenedorAdicional

                    detalleNuevo.OrdenCompra = detalle.OrdenCompra
                    detalleNuevo.CodigoMaterial = detalle.CodigoMaterial
                    detalleNuevo.Material = detalle.Material
                    detalleNuevo.CantidadSolicitada = detalle.CantidadSolicitada
                    detalleNuevo.CantidadRecibida = detalle.CantidadRecibida
                    detalleNuevo.PrecioReferencial = detalle.PrecioReferencial
                    detalleNuevo.CantidadEntrante = CantidadContenedorAdicional
                    detalleNuevo.Contenedor = IdContenedor
                    detalleNuevo.TipoContenedor = UtilConstantes.TipoContenedor.Adicional

                End If
            Next

            _ListDetalleMaterial.Add(detalleNuevo)

            MessageBox.Show("Se ha agregado un contenedor adicional.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Dispose()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExamCont_Click(sender As Object, e As EventArgs) Handles btnExamCont.Click
        Try

            If Not (UtilConvertidor.GetInteger(txtQtyContenedorAdicional.Text) > 0) Then
                MessageBox.Show("Ingrese una cantidad válida para el contenedor adicional.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQtyContenedorAdicional.Select()
                Return
            End If

            Dim frmExamContenedor As New FormExamContenedor(txtContenedorAdicional)
            frmExamContenedor.ShowDialog()

            IdContenedor = frmExamContenedor.IdContenedor
            CantidadContenedor = frmExamContenedor.Cantidad
            CantidadContenedorAdicional = UtilConvertidor.GetInteger(txtQtyContenedorAdicional.Text)

            If (VerificarExisteContenedor(IdContenedor)) Then
                MessageBox.Show(
                    "El contenedor seleccionado ya ha sido agregado, debe seleccionar un contenedor distinto",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                btnExamCont.Select()

                IdContenedor = String.Empty
                CantidadContenedor = 0
                txtContenedorAdicional.Text = String.Empty

                Return
            End If

            If (CantidadContenedor - CantidadContenedorAdicional < 0) Then
                MessageBox.Show(
                    String.Format("El contenedor solo tiene espacio para {0} elementos. Debe modificar la cantidad para el contenedor adicional o seleccionar otro contenedor", CantidadContenedor),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                txtQtyContenedorAdicional.Select()

                IdContenedor = String.Empty
                CantidadContenedor = 0
                txtContenedorAdicional.Text = String.Empty

                Return
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcularTotalContenedorAdicionales()
        Try
            Dim totalAdicionales As Integer = 0

            For Each detalle As IngresoMaterialDetalle In _ListDetalleMaterial
                If detalle.TipoContenedor = UtilConstantes.TipoContenedor.Adicional And detalle.CodigoMaterial.Equals(IdMaterial) Then
                    totalAdicionales = totalAdicionales + detalle.CantidadEntrante
                End If
            Next

            txtQtyAdicionales.Text = totalAdicionales

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcularTotalContenedorBase()
        Try

            For Each detalle As IngresoMaterialDetalle In _ListDetalleMaterial
                If detalle.TipoContenedor = UtilConstantes.TipoContenedor.Base And detalle.CodigoMaterial.Equals(IdMaterial) Then
                    TotalContenedorBase = TotalContenedorBase + detalle.CantidadEntrante
                End If
            Next

            txtQtyContenedorBase.Text = TotalContenedorBase

        Catch ex As Exception

        End Try
    End Sub

    Private Function VerificarExisteContenedor(ByVal IdContenedor As String) As Boolean
        Dim resultado As Boolean = False
        Try

            For Each detalle As IngresoMaterialDetalle In _ListDetalleMaterial
                If detalle.Contenedor = IdContenedor And detalle.CodigoMaterial.Equals(IdMaterial) Then
                    resultado = True
                End If
            Next

        Catch ex As Exception

        End Try

        Return resultado
    End Function

    Private Sub txtQtyContenedorAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtQtyContenedorAdicional.TextChanged
        Try
            CantidadContenedorAdicional = UtilConvertidor.GetInteger(txtQtyContenedorAdicional.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class