Imports System.Data.SQLite
Public Class Leave_User

    Dim status As Integer
    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn_send_leave_Click(sender As Object, e As EventArgs) Handles btn_send_leave.Click
        Dim fleave As New Leave_Request(status)
        fleave.Show()
        Me.Close()
    End Sub

    Private Sub Leave_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SQLiteConnection("Data Source=E:\TNI\VBProject\VBProject\VbProject\Database\HRDB.db;version=3")
        connection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = connection

        cmd.CommandText = "Select * from leaves"
        Dim red As SQLiteDataReader = cmd.ExecuteReader
        connection.Close()
    End Sub
End Class