Public Class ModifStock
    Private id As String
    Private idProducto As String
    Private nombreProducto As String
    Private cantidad As String
    Private estado As String

    Sub New(ByVal _id As String, ByVal _idProducto As String, ByVal _nombreProducto As String, ByVal _cantidad As String, ByVal _estado As String)
        Try
            InitializeComponent()

            id = _id
            idProducto = _idProducto
            nombreProducto = _nombreProducto
            cantidad = _cantidad
            estado = _estado

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub ModifStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCodigo.Text = id
            txtProducto.Text = idProducto
            txtNombre.Text = nombreProducto
            txtCantidad.Text = cantidad

            CargarEstadoMercancia()

            cboEstadoMercancia.SelectedValue = estado

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            Dim idContenedor As String = txtCodigo.Text
            Dim cantidad As String = txtCantidad.Text
            Dim idProducto As String = txtProducto.Text
            validarCampos(1)
            If (hayErrores()) Then
                MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rpta As String = DetalleContenedor.modificar(idContenedor, idProducto, cantidad, cboEstadoMercancia.SelectedValue)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function hayErrores() As Boolean
        If (ErrorModifStock.GetError(txtCantidad) = Nothing) Then
            Return False
        End If
        Return True
    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtCantidad.Text.Trim.Length < 1 And nivel >= 1 Then
            ErrorModifStock.SetError(txtCantidad, "Debe ingresar un número al menos.")
        ElseIf (nivel = 1) Then
            ErrorModifStock.SetError(txtCantidad, Nothing)
        End If
    End Sub

    Private Sub CargarEstadoMercancia()
        Dim lista As New List(Of EntidadDropDown)

        Dim entidadNuevoItem As New EntidadDropDown
        entidadNuevoItem.IdStr = String.Empty
        entidadNuevoItem.Descripcion = "Seleccione"
        lista.Add(entidadNuevoItem)

        Dim dt As DataTable = Parametro.ObtenerParametrosPorGrupo(UtilConstantes.Parametro.Grupo.EstadoMercancia)

        For Each dr As DataRow In dt.Rows
            Dim entidad As New EntidadDropDown
            entidad.IdStr = dr("Code")
            entidad.Descripcion = dr("Valor")
            lista.Add(entidad)
        Next

        cboEstadoMercancia.DataSource = lista
        cboEstadoMercancia.ValueMember = "IdStr"
        cboEstadoMercancia.DisplayMember = "Descripcion"

    End Sub

End Class