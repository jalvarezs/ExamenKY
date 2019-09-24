Public Class FormColumnaUbicacion

    Private Sector As String
    Private dataTable As DataTable

    Sub New(ByVal _Sector As String)
        InitializeComponent()
        Sector = _Sector

        'Tipos de ubicaciones
        dataTable = New DataTable
        dataTable = TipoUbicacion.listar()
        cboTipoUbicacion.DataSource = dataTable
        cboTipoUbicacion.ValueMember = dataTable.Columns(0).ToString
        cboTipoUbicacion.DisplayMember = dataTable.Columns(1).ToString

        'Pasillos de un sector
        dataTable = Ubicacion.listarPasillosSector(Sector)
        cboPasillos.DataSource = dataTable
        cboPasillos.DisplayMember = dataTable.Columns(0).ToString

    End Sub

    '' Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardarAC.Click
    ''Dim Pasillo As String = cboPasillos.Text
    ''Dim Niveles As String = txtNiveles.Text.Trim
    ''Dim TipoUbic As String = cboTipoUbicacion.SelectedValue.ToString
    ''Dim Capacidad As String = txtCapacidad.Text.Trim
    ''Dim rpta As String = Ubicacion.guardarColumna(Sector, Pasillo, Niveles, TipoUbic, Capacidad)
    ''  MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)

    ''End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As System.EventArgs) Handles btnGuardarAC.Click

        Dim Pasillo As String = cboPasillos.Text
        Dim Niveles As String = txtNiveles.Text.Trim
        Dim TipoUbic As String = cboTipoUbicacion.SelectedValue.ToString
        Dim Capacidad As String = txtCapacidad.Text.Trim
        Dim rpta As String = Ubicacion.guardarColumna(Sector, Pasillo, Niveles, TipoUbic, Capacidad)
        MessageBox.Show(rpta, "Respuesta Handles btnGuardarAC.Click", MessageBoxButtons.OK, MessageBoxIcon.Information)




    End Sub

    Private Sub FormColumnaUbicacion_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class