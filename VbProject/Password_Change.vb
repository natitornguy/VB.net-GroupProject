Public Class Password_Change
    Dim status As Integer
    Dim id As Integer

    Public Sub New(status As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.id = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cleartxt()
        txt_cpass.Clear()
        txt_npass.Clear()
        txt_opass.Clear()
    End Sub

    Private Sub updatepass()
        If txt_npass.Text = txt_cpass.Text Then
            Dim npw = txt_npass.Text
            Dim cuser = ConnectDB.QueryGetone("SELECT  count(username)
                                                FROM users
                                                WHERE username = '" & txt_username.Text &
                                                "' AND PASSWORD = '" & txt_opass.Text & "'")
            If cuser = 1 Then
                ConnectDB.ExecuteData("update users 
                            set password = '" & npw & "'" &
                           " where emp_id = " & id)
                MessageBox.Show("แก้ไขรหัสผ่านแล้ว", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim fmain As New Main_Menu(status, id)
                fmain.Show()
                Me.Close()
            Else
                MessageBox.Show("รหัสผ่านเก่าไม่ถูกต้อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cleartxt()
            End If
        Else
            MessageBox.Show("รหัสผ่านใหม่ไม่ตรงกัน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cleartxt()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        updatepass()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status, id)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Password_Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username = ConnectDB.QueryGetone("SELECT username
                                            FROM users
                                            WHERE emp_id = " & id)
        txt_username.Text = username

    End Sub
End Class