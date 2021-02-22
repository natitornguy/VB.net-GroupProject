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

    End Sub
End Class