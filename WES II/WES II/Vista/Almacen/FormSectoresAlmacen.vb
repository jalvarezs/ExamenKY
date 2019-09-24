Public Class FormSectoresAlmacen
    Private idAlmacen, nombre As String
    Private Sub FormSectoresAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombreSectorAlmacen.Text = nombre
        actualizarTabla()
    End Sub

    Sub New(ByVal _idAlmacen As String, ByVal _nombre As String)
        InitializeComponent()
        idAlmacen = _idAlmacen
        nombre = _nombre
    End Sub

    Private Sub actualizarTabla()

        Try
            Dim sectoresAlmacen As New DataTable
            sectoresAlmacen = Almacen.listarSectoresAlmacen(idAlmacen)
            dgvSectoresAlmacen.DataSource = sectoresAlmacen

            With dgvSectoresAlmacen
                .Columns(0).Width = 60
                .Columns(1).Width = 100
                .Columns(2).Width = 60
                .Columns(2).Width = 100
                .Columns(3).Width = 60
                .Columns(3).Width = 60
                .Columns(3).Width = 60
                .Columns(3).Width = 60
            End With

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAgregarSector_Click(sender As Object, e As EventArgs) Handles btnAgregarSector.Click
        Dim form As New FormNuevoSector(idAlmacen)
        form.ShowDialog()
        actualizarTabla()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer

        Try
            If dgvSectoresAlmacen.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvSectoresAlmacen.CurrentRow.Index
            End If

            Dim id As String = dgvSectoresAlmacen.Item(0, row).Value.ToString
            Dim nombre As String = dgvSectoresAlmacen.Item(1, row).Value.ToString
            Dim codigo As String = dgvSectoresAlmacen.Item(2, row).Value.ToString
            Dim estado As String = dgvSectoresAlmacen.Item(3, row).Value.ToString
            Dim pasillos As String = dgvSectoresAlmacen.Item(4, row).Value.ToString
            Dim columnas As String = dgvSectoresAlmacen.Item(5, row).Value.ToString
            Dim niveles As String = dgvSectoresAlmacen.Item(6, row).Value.ToString

            Dim form As New ModifSectoresAlmacen(id, nombre, codigo, idAlmacen, estado, pasillos, columnas, niveles)
            form.ShowDialog()
            actualizarTabla()

        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim row As Integer

        Try

            If dgvSectoresAlmacen.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvSectoresAlmacen.CurrentRow.Index
            End If

            Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim IdSector As Integer = dgvSectoresAlmacen.Item(0, row).Value
                ' Comprobar si esta asociado a un requerimiento

                Dim rpta As String = Sector.eliminar(IdSector)
                MessageBox.Show(rpta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                actualizarTabla()
            End If

        Catch ex As Exception
            'MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class