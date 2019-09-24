


Public Class FormInventarios


    Dim id_sector As Integer



    Private Sub FormInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        ' Solicitamos los sectores del almacén seleccionado
        Dim sectores As DataTable = Almacen.listarSectoresAlmacen("1")
        cboSectores.DataSource = sectores
        cboSectores.ValueMember = sectores.Columns(0).ColumnName
        cboSectores.DisplayMember = sectores.Columns(1).ColumnName



    End Sub

    Private Sub cboSectores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSectores.SelectedIndexChanged


        TextBox2.Text = cboSectores.SelectedValue.ToString
        'TextBox1.Text = Convert.ToString(cboSectores.SelectedValue)




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click






    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged




        id_sector = Convert.ToString(cboSectores.SelectedValue)



        ' id_sector = CType(cboSectores.SelectedValue, Integer)

        Dim ubicaciones As DataTable
        ubicaciones = Ubicacion.listarPorSector(id_sector)
        dataGridView1.DataSource = ubicaciones




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As Integer
        row = dataGridView1.CurrentRow.Index
        Dim UBICACION As String = dataGridView1.Item(0, row).Value.ToString










    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim cod As Integer
        Dim ubic As String

        cod = dataGridView1(0, dataGridView1.CurrentRow.Index).Value

        ubic = dataGridView1(2, dataGridView1.CurrentRow.Index).Value

        dataGridView2.Rows.Add(cod, ubic)


        dataGridView1.Rows.Remove(dataGridView1.CurrentRow)




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class