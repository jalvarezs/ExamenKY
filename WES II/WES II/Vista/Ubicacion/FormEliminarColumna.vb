Public Class FormEliminarColumna
    Private Sector As String
    Private dataTable As DataTable

    Sub New(ByVal _Sector As String)
        InitializeComponent()
        Sector = _Sector

        'Listado  de Pasillos
        dataTable = Ubicacion.listarPasillosSector(Sector)
        cboPasillos.DataSource = dataTable
        cboPasillos.DisplayMember = dataTable.Columns(0).ToString
    End Sub

    Private Sub FormEliminarColumna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Listado de Columnas
        dataTable = Ubicacion.listarColumnasSector(Sector, Convert.ToInt16(cboPasillos.Text))
        cboColumnas.DataSource = dataTable
        cboColumnas.DisplayMember = dataTable.Columns(0).ToString
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim rpta As String = Ubicacion.eliminarColumna(Sector, Convert.ToInt16(cboPasillos.Text), Convert.ToInt16(cboColumnas.Text))
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub cboPasillos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPasillos.SelectionChangeCommitted
        'Listado de Columnas
        dataTable = New DataTable()
        dataTable = Ubicacion.listarColumnasSector(Sector, Convert.ToInt16(cboPasillos.Text))
        cboColumnas.DataSource = dataTable
        cboColumnas.DisplayMember = dataTable.Columns(0).ToString
    End Sub
End Class