Public Class FormExamUbicacion

    ' Código del último sector seleccionado
    Private ultimaSeleccion As Integer = -1

    ' Datos que serán devueltos al form invocador
    Public etiqueta As String ' Etiqueta de la ubicación
    Public idUbicacion As Integer ' ID real en la BD

    Sub New()

        Try
            InitializeComponent()

            ' Por defecto, si no se pulsa aceptar:
            etiqueta = ""
            idUbicacion = -1
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ModifUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            listarAlmacenes()
            If cboAlmacenes.Items.Count > 0 Then
                listarSectores(cboAlmacenes.SelectedValue)
            End If
            actualizarUbicaciones(cboSectores.SelectedValue)
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub listarAlmacenes()
        Try
            Dim almacenes As DataTable = Almacen.listar()
            With cboAlmacenes
                .DataSource = almacenes
                .DisplayMember = almacenes.Columns(1).ColumnName
                .ValueMember = almacenes.Columns(0).ColumnName
            End With
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim row As Integer
            If dgvUbicaciones.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione un elemento de la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                row = dgvUbicaciones.CurrentRow.Index
            End If

            etiqueta = dgvUbicaciones.Item(2, row).Value.ToString()
            idUbicacion = CInt(dgvUbicaciones.Item(0, row).Value) ' No es necesario restar

            Me.Close()
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cboAlmacenes_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            listarSectores(Convert.ToInt16(cboAlmacenes.Text))
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub listarSectores(ByVal idAlmacen As Integer)
        Try

            ' Solicitamos los sectores del almacén seleccionado
            Dim sectores As DataTable = Almacen.listarSectoresAlmacen(idAlmacen)
            cboSectores.DataSource = sectores
            cboSectores.ValueMember = sectores.Columns(0).ColumnName
            cboSectores.DisplayMember = sectores.Columns(1).ColumnName
        Catch ex As Exception
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cboSectores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSectores.SelectionChangeCommitted
        Dim nuevaSeleccion As Integer = cboSectores.SelectedValue

        If ultimaSeleccion <> nuevaSeleccion Then
            ultimaSeleccion = nuevaSeleccion

            actualizarUbicaciones(ultimaSeleccion)
        End If
    End Sub

    Private Sub actualizarUbicaciones(ByVal idSector As Integer)
        Dim ubicaciones As DataTable
        ubicaciones = Ubicacion.listarPorSector(idSector)
        dgvUbicaciones.DataSource = ubicaciones
    End Sub

End Class