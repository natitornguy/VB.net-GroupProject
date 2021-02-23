Imports System.Data.SQLite
Public Class ConnectDB
    Private Shared connection As New SQLiteConnection("Data Source=E:\TNI\VBProject\VBProject\VbProject\Database\HRDB.db;version=3")
    Public Shared Function QueryAdapter(cmdtext As String) 'As DataSet
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = cmdtext
        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "leave")

        connection.Close()
        Return data
    End Function

    Public Shared Function QueryReader(cmdtext As String, rangecol As Integer)
        '' rangecol = จำนวน colum ที่ select ใน sql
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = cmdtext
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim datalist As New ArrayList
        'Debug.WriteLine(rangecol)
        While reader.Read
            For i As Integer = 0 To rangecol - 1 Step 1
                'Debug.WriteLine(reader(i))
                datalist.Add(reader(i))
            Next
        End While
        connection.Close()

        Return datalist
    End Function

    Public Shared Function editData(cmdtext As String)
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = "UPDATE "
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim datalist As New ArrayList
        'Debug.WriteLine(rangecol)
        While reader.Read
            For i As Integer = 0 To -1 Step 1
                'Debug.WriteLine(reader(i))
                datalist.Add(reader(i))
            Next
        End While
        connection.Close()
        Return True
    End Function
End Class
