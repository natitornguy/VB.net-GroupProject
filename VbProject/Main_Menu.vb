Public Class Main_Menu

    Dim status As Integer
    Dim id As Integer

    Public Sub New(status As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        Me.status = status
        Me.id = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Page()
        Debug.WriteLine(status)
        If status = 1 Then
            P_Admin.BringToFront()
        ElseIf status = 2 Then
            P_Employee.BringToFront()
        End If
        lbl_empid.Text = "User ID : " & id
        lbl_empname.Text = ConnectDB.QueryGetone("select CONCAT(emp_fname,' ',emp_lname) from employees where emp_id = " & id)
    End Sub


    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Page()

    End Sub

    Private Sub btn_bonus_cal_Click(sender As Object, e As EventArgs) Handles btn_bonus_cal.Click
        Dim fbonus = New Bonus_Empinfo(status, id)
        fbonus.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim flogin As New Login()
        flogin.Show()
        Me.Close()
    End Sub

    Private Sub btn_empinfo_Click(sender As Object, e As EventArgs) Handles btn_empinfo.Click
        Dim femp As New Show_Employee(status, id)
        femp.Show()
        Me.Close()
    End Sub

    Private Sub btn_changepw_admin_Click(sender As Object, e As EventArgs) Handles btn_changepw_admin.Click
        Dim fchangepw As New Password_Change(status,id)
        fchangepw.Show()
        Me.Close()
    End Sub

    Private Sub btn_leave_admin_Click(sender As Object, e As EventArgs) Handles btn_leave_admin.Click
        Dim fleave As New Leave_Request(status, id)
        fleave.Show()
        Me.Close()
    End Sub

    Private Sub btn_leave_send_Click(sender As Object, e As EventArgs) Handles btn_leave_send.Click
        Dim fleave As New Leave_Request(status, id)
        fleave.Show()
        Me.Close()
    End Sub

    Private Sub btn_bonus_view_Click(sender As Object, e As EventArgs) Handles btn_bonus_view.Click
        Dim fbonus As New Show_Bonus(status, id)
        fbonus.Show()
        Me.Close()
    End Sub

    Private Sub btn_changepw_user_Click(sender As Object, e As EventArgs) Handles btn_changepw_user.Click
        Dim fchangepw As New Password_Change(status, id)
        fchangepw.Show()
        Me.Close()
    End Sub


End Class