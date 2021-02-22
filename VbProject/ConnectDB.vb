Imports System.Data.SQLite
Public Class ConnectDB
    Private Shared connection As New SQLiteConnection("Data Source=E:\TNI\VBProject\VBProject\VbProject\Database\HRDB.db;version=3")
    Public Shared Function Noname() 'As DataSet
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = "Select * from leaves"
        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "leave")

        connection.Close()
        Return data
    End Function
End Class
