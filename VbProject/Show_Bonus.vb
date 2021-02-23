Imports System.Data.SQLite

Public Class Show_Bonus

    Dim status As Integer
    Private connection As New SQLiteConnection("Data Source=C:\Users\Aum\Desktop\VB Final Project\VbProject\VbProject\Database\HRDB.db;version=3")
    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Show_Bonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdtext = "Select * from employees where emp_id = 1"
        Dim result = ConnectDB.QueryReader(cmdtext)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub
End Class