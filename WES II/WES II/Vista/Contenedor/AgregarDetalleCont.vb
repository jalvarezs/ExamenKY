Public Class AgregarDetalleCont
    Private id As String

    Sub New(ByVal _id As String)

        Try

            InitializeComponent()
            id = _id
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub AgregarDetalleCont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCodigo.Text = id
            ListarMateriales()

            CargarEstadoMercancia()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListarMateriales()

        Try
            Dim listarMateriales As DataTable
            listarMateriales = Material.listar()
            With cboMateriales
                .DataSource = listarMateriales
                .ValueMember = listarMateriales.Columns(0).ColumnName
                .DisplayMember = listarMateriales.Columns(1).ColumnName
            End With
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click

        Try
            Dim idContenedor As String = txtCodigo.Text
            Dim cantidad As String = txtStock.Text
            Dim idMaterial As String = cboMateriales.SelectedValue

            'Validar que no exista el material agregado al contenedor
            Dim dtDetalle As DataTable
            dtDetalle = DetalleContenedor.ObtenerDetalleContenedorPorMaterial(idContenedor, idMaterial)

            If dtDetalle IsNot Nothing Then
                If dtDetalle.Rows.Count > 0 Then
                    MessageBox.Show("El material ya ha sido agregado al contenedor, no es posible realizar esta acción", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If


            validarCampos(1)

            If (hayErrores()) Then
                MessageBox.Show("Hay campos obligatorios sin llenar.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rpta As String = DetalleContenedor.registrar(idContenedor, idMaterial, cantidad, cboEstadoMercancia.SelectedValue)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function hayErrores() As Boolean
        If (ErrorDetalleCont.GetError(txtStock) = Nothing) Then
            Return False
        End If
        Return True
    End Function

    Private Sub validarCampos(ByVal nivel As Integer)
        If txtStock.Text.Trim.Length < 1 And nivel >= 1 Then
            ErrorDetalleCont.SetError(txtStock, "Debe ingresar un número al menos.")
        ElseIf (nivel = 1) Then
            ErrorDetalleCont.SetError(txtStock, Nothing)
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
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