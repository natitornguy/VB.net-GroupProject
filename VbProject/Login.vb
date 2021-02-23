Public Class Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Main_Menu(0) คือล็อกอินเป็นแอดมิน (1) คือ ผู้ใช้ธรรมดา
        Dim user As Integer
        If txt_username.Text = "admin" Then
            user = 0
        ElseIf txt_username.Text = "user" Then
            user = 1
        End If
        Dim main = New Main_Menu(user)
            main.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
