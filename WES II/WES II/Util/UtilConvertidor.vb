Imports System.IO
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports ExcelDataReader

Public Class UtilConvertidor

    Public Shared Function GetStringVal(value As Object) As String
        Dim resultado = String.Empty
        Try
            resultado = If(value Is Nothing, String.Empty, Convert.ToString(value).Trim)

        Catch generatedExceptionName As Exception
        End Try
        Return resultado
    End Function

    Public Shared Function GetDecimal(value As Object) As Decimal
        Dim resultado = 0D
        Try
            resultado = If(value Is Nothing, 0D, Convert.ToDecimal(value))

        Catch generatedExceptionName As Exception
        End Try
        Return resultado
    End Function

    Public Shared Function GetInteger(value As Object) As Integer
        Dim resultado = 0
        Try
            resultado = If(value Is Nothing, 0, Convert.ToInt32(value))

        Catch generatedExceptionName As Exception
        End Try
        Return resultado
    End Function

    Public Shared Function ConvertExcelToDataTable(ByVal stream As System.IO.Stream) As DataTable
        Dim dt As DataTable
        Dim workbook As OfficeOpenXml.ExcelWorkbook
        Dim worksheet As OfficeOpenXml.ExcelWorksheet

        Using package As New OfficeOpenXml.ExcelPackage(stream)
            workbook = package.Workbook

            For Each ws In workbook.Worksheets.AsEnumerable
                worksheet = ws
            Next

            Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateOpenXmlReader(stream)

            Dim ds = excelReader.AsDataSet

            dt = ds.Tables(0)

            Dim intColumn As Integer = 0

            For Each dataColumn As DataColumn In dt.Columns
                dataColumn.ColumnName = dt.Rows(0)(intColumn)
                intColumn = intColumn + 1
            Next

            dt.Rows.RemoveAt(0)
            dt.AcceptChanges()


        End Using

        dt = RemoveNulls(dt)

        Return dt
    End Function

    Public Shared Function RemoveNulls(ByVal dt As DataTable) As DataTable
        For a As Integer = 0 To dt.Rows.Count - 1
            For i As Integer = 0 To dt.Columns.Count - 1
                If DBNull.Value.Equals(dt.Rows(a)(i)) Then
                    dt.Rows(a)(i) = String.Empty
                End If
            Next
        Next
        Return dt
    End Function
    Public Shared Function GetString(ByVal dr As DataRow, ByVal index As Integer) As String
        Dim val As String

        If IsDBNull(dr(index)) Then
            val = String.Empty
        Else
            val = dr(index)
        End If

        Return val

    End Function

    Public Shared Function GetInteger(ByVal dr As DataRow, ByVal index As Integer) As Integer
        Dim val As Integer

        If IsDBNull(dr(index)) Then
            val = 0
        Else
            val = dr(index)
        End If

        Return val

    End Function

End Class
