Imports System.Data.SQLite

Public Class Show_Bonus

    Dim status As Integer
    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Show_Bonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdtext = "Select * from employees where emp_id = 1"
        '' rangecol = จำนวน colum ที่ select ใน sql
        Dim rangecol = 11
        Dim result = ConnectDB.QueryReader(cmdtext, rangecol)
        For Each value In result
            Debug.WriteLine(value)
        Next

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub
End Class