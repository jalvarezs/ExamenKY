﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion

    ' Objecto de conexión a la BD5
    Private connection As SqlConnection

    ' DataAdapter listo para devolver objetos DataTable
    Private dataAdapter As SqlDataAdapter

    ' DataTable que se rellenará para ser devuelto
    Private dataTable As DataTable

    ' Comando usado para ejecutar operaciones INSERT, UPDATE y DELETE
    Private comando As SqlCommand

    ' Para el uso específico de transacciones
    Private transaccion As SqlTransaction
    Private hayTransaccion As Boolean

    ' Constructor de la clase Conexion
    Sub New(ByVal nombreBD As String)
        ' Cadena para conectarnos a la BD
        Dim cadenaConexion As String = ""
        cadenaConexion &= "Server =cnx2.cyhocrwk02ku.us-east-1.rds.amazonaws.com;"
        cadenaConexion &= "Database = " & nombreBD & ";"
        cadenaConexion &= "User Id = adminrh;"
        cadenaConexion &= "Password = isidrocasanova2000;"

        connection = New SqlConnection(cadenaConexion)

        ' Instanciamos nuestro dataAdapter
        dataAdapter = New SqlDataAdapter("", connection)

        ' Por defecto no hay transacciones
        hayTransaccion = False
    End Sub

    ' Método para ejecutar un SP de consulta (SELECT2)
    Public Function consultarSP(ByVal SP As String) As DataTable
        ' Instanciamos nuestro dataTable
        dataTable = New DataTable

        ' Definimos el SP a usar y cargamos nuestro dataTable
        With dataAdapter.SelectCommand
            .CommandType = CommandType.StoredProcedure
            .CommandText = SP
        End With
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    ' Método para realizar una consulta directa (SELECT)
    Public Function consultar(ByVal consulta As String) As DataTable
        ' Instanciamos nuestro dataTable
        dataTable = New DataTable

        ' Definimos la consulta y cargamos nuestro dataTable
        Try
            With dataAdapter.SelectCommand
                .CommandType = CommandType.Text
                .CommandText = consulta
                If hayTransaccion Then .Transaction = transaccion
            End With

            dataAdapter.Fill(dataTable)
            Return dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return dataTable
        End Try

    End Function

    ' Método para preparar un SP de INSERT, UPDATE o DELETE
    Public Sub prepararSP(ByVal SP As String)
        comando = New SqlCommand(SP, connection)
        comando.CommandType = CommandType.StoredProcedure
        If hayTransaccion Then
            comando.Transaction = transaccion
        End If
    End Sub

    ' INICIO: Métodos para cargar parámetros en un SP preparado
    Public Sub agregarCadena(ByVal campo As String, ByVal valor As String)
        comando.Parameters.Add(New SqlParameter(campo, SqlDbType.NVarChar))
        comando.Parameters(campo).Value = valor
    End Sub

    Public Sub agregarDecimal(ByVal campo As String, ByVal valor As Decimal)
        Dim prm As SqlParameter = New SqlParameter(campo, SqlDbType.Decimal)
        prm.Value = valor
        prm.Precision = 6
        prm.Scale = 3
        comando.Parameters.Add(prm)
    End Sub

    Public Sub agregarEntero(ByVal campo As String, ByVal valor As Integer)
        comando.Parameters.Add(New SqlParameter(campo, SqlDbType.Int))
        comando.Parameters(campo).Value = valor
    End Sub

    Public Sub agregarFecha(ByVal campo As String, ByVal valor As Date)
        comando.Parameters.Add(New SqlParameter(campo, SqlDbType.Date))
        comando.Parameters(campo).Value = valor
    End Sub

    Public Sub agregarHora(ByVal campo As String, ByVal valor As TimeSpan)
        comando.Parameters.Add(New SqlParameter(campo, SqlDbType.Time))
        comando.Parameters(campo).Value = valor
    End Sub
    ' FIN: Métodos para c44argar parámetros en un SP preparado

    ' Método para ejecutar un SP ya preparado y obtener un String
    Public Function ejecutarSP_String() As String
        ' Asumimos que no hay errores
        Dim errores As String = ""

        Try
            If Not hayTransaccion Then
                connection.Open()
            End If
            comando.ExecuteNonQuery()


        Catch ex As Exception
            'errores = ex.Message
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            MsgBox("Detalle: " & ex.Message.ToString, MsgBoxStyle.Critical, "Error")

            errores = ex.Message + " -  " + comando.Parameters(1).Value




        End Try

        If Not hayTransaccion Then
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End If

        Return errores
    End Function

    ' Método para ejecutar un SP ya preparado y obtener un DataTable
    Public Function ejecutarSP_DataTable() As DataTable
        ' Instanciamos nuestro dataTable
        dataTable = New DataTable

        Try
            If hayTransaccion Then comando.Transaction = transaccion
            dataAdapter.SelectCommand = comando
            dataAdapter.Fill(dataTable)
            comando.Parameters.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return dataTable
    End Function

    ' En adelante, métodos para el uso de transacciones
    Public Sub iniciarTransaccion()
        connection.Open()
        transaccion = connection.BeginTransaction()
        comando.Transaction = transaccion
        hayTransaccion = True
    End Sub

    Public Sub hacerCommit()
        transaccion.Commit()
        connection.Close()
        hayTransaccion = False
    End Sub

    Public Sub hacerRollBack()
        transaccion.Rollback()
        connection.Close()
        hayTransaccion = False
    End Sub



End Class
