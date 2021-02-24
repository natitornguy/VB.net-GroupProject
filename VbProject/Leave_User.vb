Imports System.Data.SQLite
Public Class Leave_User

    Dim status As Integer
    Dim id As Integer
    Public Sub New(status As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.id = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn_send_leave_Click(sender As Object, e As EventArgs) Handles btn_send_leave.Click
        Dim fleave As New Leave_Request(status, id)
        fleave.Show()
        Me.Close()
    End Sub

    Private Sub Leave_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dtp_start_ValueChanged(sender As Object, e As EventArgs) Handles dtp_start.ValueChanged

    End Sub
End Class