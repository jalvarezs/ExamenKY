Public Class FormUbicaciones

    ' Código del último sector seleccionado
    Private ultimaSeleccion As Integer = -1

    Private Sub ModifUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarAlmacenes()
        If cboAlmacenes.Items.Count > 0 Then
            listarSectores(cboAlmacenes.SelectedValue)
        End If
        actualizarUbicaciones(cboSectores.SelectedValue)
    End Sub

    Private Sub listarAlmacenes()
        Dim almacenes As DataTable = Almacen.listar()
        With cboAlmacenes
            .DataSource = almacenes
            .DisplayMember = almacenes.Columns(1).ColumnName
            .ValueMember = almacenes.Columns(0).ColumnName
        End With
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub cboAlmacenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlmacenes.SelectionChangeCommitted
        listarSectores(cboAlmacenes.SelectedValue)
    End Sub

    Private Sub listarSectores(ByVal idAlmacen As Integer)
        ' Solicitamos los sectores del almacén seleccionado
        Dim sectores As DataTable = Almacen.listarSectoresAlmacen(idAlmacen)
        cboSectores.DataSource = sectores
        cboSectores.ValueMember = sectores.Columns(0).ColumnName
        cboSectores.DisplayMember = sectores.Columns(1).ColumnName

        If cboSectores.Items.Count > 0 Then
            actualizarUbicaciones(cboSectores.SelectedValue)
        End If
    End Sub

    Private Sub cboSectores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSectores.SelectionChangeCommitted
        Dim nuevaSeleccion As Integer = cboSectores.SelectedValue

        If ultimaSeleccion <> nuevaSeleccion Then
            ultimaSeleccion = nuevaSeleccion

            actualizarUbicaciones(ultimaSeleccion)
        End If
    End Sub

    Public Sub actualizarUbicaciones(ByVal idSector As Integer)
        Dim ubicaciones As DataTable
        ubicaciones = Ubicacion.listarPorSector(idSector)
        dgvUbicaciones.DataSource = ubicaciones
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim row As Integer

        If dgvUbicaciones.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvUbicaciones.CurrentRow.Index
        End If

        Dim ID_Ubicacion As String = dgvUbicaciones.Item(0, row).Value.ToString
        Dim ID_TipoUbicacion As String = dgvUbicaciones.Item(3, row).Value.ToString
        Dim Pasillo As String = dgvUbicaciones.Item(4, row).Value.ToString
        Dim Columna As String = dgvUbicaciones.Item(5, row).Value.ToString
        Dim Nivel As String = dgvUbicaciones.Item(6, row).Value.ToString
        Dim Compartimiento As String = dgvUbicaciones.Item(7, row).Value.ToString
        Dim Estado As String = dgvUbicaciones.Item(8, row).Value.ToString
        Dim Capacidad As String = dgvUbicaciones.Item(9, row).Value.ToString

        Dim form As New ModifUbicacion(ID_Ubicacion, ID_TipoUbicacion, Pasillo, Columna, Nivel, Compartimiento, Estado, Capacidad)
        form.ShowDialog()
        actualizarUbicaciones(cboSectores.SelectedValue)
    End Sub

    Private Sub btnAgregarColumna_Click(sender As Object, e As EventArgs) Handles btnAgregarColumna.Click
        If cboSectores.SelectedValue = -1 Then
            MessageBox.Show("Debe seleccionar un sector, para añadir una columna.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Form As New FormColumnaUbicacion(cboSectores.Text)
        Form.ShowDialog()
        actualizarUbicaciones(cboSectores.SelectedValue)
    End Sub


    Private Sub btnEliminarUbicacion_Click(sender As Object, e As EventArgs) Handles btnEliminarUbicacion.Click
        Dim row As Integer

        If dgvUbicaciones.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            row = dgvUbicaciones.CurrentRow.Index
        End If

        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim ID_Ubicacion As String = dgvUbicaciones.Item(0, row).Value.ToString
            Dim rpta As String = Ubicacion.eliminarUbicacion(ID_Ubicacion)
            MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizarUbicaciones(cboSectores.SelectedValue)
        End If
    End Sub

    Private Sub btnEliminarColumna_Click(sender As Object, e As EventArgs) Handles btnEliminarColumna.Click
        If cboSectores.SelectedValue Is Nothing Then
            MessageBox.Show("Debe seleccionar un sector, para eliminar una columna.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Form As New FormEliminarColumna(cboSectores.Text)
        Form.ShowDialog()
        actualizarUbicaciones(cboSectores.SelectedValue)
    End Sub

    Private Sub cboSectores_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboSectores.SelectedIndexChanged

    End Sub
End Class