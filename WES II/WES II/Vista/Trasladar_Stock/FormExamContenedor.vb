Public Class FormExamContenedor

    Private Sub FormExamContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarTabla(txtEtiqueta.Text)
    End Sub

    Dim txtDestino As TextBox
    Property IdContenedor As String = ""
    Property EtiquetaContenedor As String = ""
    Property Cantidad As Integer
    Property idMaterial As String

    Sub New(ByRef contenedor As TextBox)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        txtDestino = contenedor
        ' No hay filtro por material
        idMaterial = String.Empty
    End Sub

    ' Sobrecargamos el constructor
    Sub New(ByVal _idMaterial As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        txtDestino = Nothing
        idMaterial = _idMaterial
    End Sub

    Private Sub actualizarTabla(ByVal etiqueta As String)
        Dim contenedores As DataTable

        If idMaterial = String.Empty Then
            ' Consultamos los contenedores que iniciquen con la etiqueta indicada
            contenedores = Contenedor.buscarEtiqueta(txtEtiqueta.Text.Trim)
        Else
            contenedores = Contenedor.buscarMaterial(idMaterial)
        End If

        ' Mostramos tales contenedores
        dgvContenedor.DataSource = contenedores
    End Sub

    Private Sub txtEtiqueta_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEtiqueta.KeyUp
        actualizarTabla(txtEtiqueta.Text)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim row As Integer

        If dgvContenedor.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvContenedor.CurrentRow.Index
        End If

        IdContenedor = dgvContenedor.Item(0, row).Value.ToString()

        EtiquetaContenedor = dgvContenedor.Item(2, row).Value.ToString()

        Integer.TryParse(dgvContenedor.Item(4, row).Value.ToString(), Cantidad)

        If Not IsNothing(txtDestino) Then
            txtDestino.Text = dgvContenedor.Item(2, row).Value.ToString()
        End If

        Me.Dispose()
    End Sub
End Class