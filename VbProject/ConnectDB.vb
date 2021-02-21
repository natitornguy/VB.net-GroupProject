Imports System.Data.SQLite
Public Class ConnectDB
    Dim connection As New SQLiteConnection("Data Source=E:\TNI\VBProject\VBProject\VbProject\Database\HRDB.db;version=3")
    Public Function Noname() As String
        connection.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = connection
        cmd.CommandText = "Select * from leaves"
        Dim rdr As SQLiteDataReader = cmd.ExecuteReader
        Debug.WriteLine(rdr)
        connection.Close()
        Return True
    End Function
End Class
