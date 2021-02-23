Imports System.Data.SQLite
Public Class ConnectDB
    Private Shared connection As New SQLiteConnection("Data Source=C:\Users\Aum\Desktop\VB Final Project\VbProject\VbProject\Database\HRDB.db;version=3")
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

    Public Shared Function QueryReader(cmdtext As String)
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = cmdtext
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim datalist As ArrayList
        Dim i As Integer
        While (reader.Read())
            datalist.Add(reader)
            i = i + 1
        End While
        connection.Close()

        Return reader
    End Function
End Class
