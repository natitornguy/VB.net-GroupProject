Public Class Leave_Request
    Dim status As Integer
    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Leave_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class