Public Class Login

    Private Sub checklogin(user, pw)

        Dim dbuser = ConnectDB.QueryReader("SELECT emp_id,role_id 
                                            FROM users 
                                            WHERE username = '" & user &
                                            "' AND PASSWORD = '" & pw & "'", 2)
        If dbuser.count > 0 Then
            Debug.WriteLine(dbuser(1))
            Dim main = New Main_Menu(dbuser(1), dbuser(0))
            main.Show()
            Me.Close()
        Else
            MessageBox.Show("ไม่มี username หรือ password ไม่ตรง", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_password.Clear()
        End If



    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim username = txt_username.Text
        Dim pass = txt_password.Text
        checklogin(username, pass)


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login_Click(sender, e)
        End If
    End Sub
End Class
