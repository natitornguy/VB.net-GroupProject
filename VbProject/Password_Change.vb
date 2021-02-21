Public Class Password_Change
    Dim status As Integer

    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Password_Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class