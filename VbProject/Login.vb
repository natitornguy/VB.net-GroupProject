Public Class Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Main_Menu(0) คือล็อกอินเป็นแอดมิน (1) คือ ผู้ใช้ธรรมดา
        Dim main = New Main_Menu(1)
        main.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
