Public Class Bonus_Empinfo

    Dim status As Integer

    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Bonus_Empinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_evaluate_Click(sender As Object, e As EventArgs) Handles btn_evaluate.Click
        Dim fcal_bonus = New Cal_Bonus(status)
        fcal_bonus.Show()
        Me.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub
End Class