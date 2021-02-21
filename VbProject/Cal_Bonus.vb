Public Class Cal_Bonus
    Dim status As Integer
    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fbonus_info As New Bonus_Empinfo(status)
        fbonus_info.Show()
        Me.Close()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim fbonus_info As New Bonus_Empinfo(status)
        fbonus_info.Show()
        Me.Close()
    End Sub

    Private Sub Cal_Bonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class