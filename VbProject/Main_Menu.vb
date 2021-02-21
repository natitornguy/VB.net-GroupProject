Public Class Main_Menu

    Dim status As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If status = 0 Then
            P_Admin.BringToFront()
        Else
            P_Employee.BringToFront()
        End If

    End Sub

    Private Sub btn_bonus_cal_Click(sender As Object, e As EventArgs) Handles btn_bonus_cal.Click
        Dim fbonus = New Bonus_Empinfo(status)
        fbonus.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim flogin As New Login()
        flogin.Show()
        Me.Close()
    End Sub

    Private Sub btn_empinfo_Click(sender As Object, e As EventArgs) Handles btn_empinfo.Click
        Dim femp As New Show_Employee()
        femp.Show()
        Me.Close()
    End Sub

    Private Sub btn_changepw_admin_Click(sender As Object, e As EventArgs) Handles btn_changepw_admin.Click
        Dim fchangepw As New Password_Change(status)
        fchangepw.Show()
        Me.Close()
    End Sub

    Private Sub btn_leave_admin_Click(sender As Object, e As EventArgs) Handles btn_leave_admin.Click
        Dim fleave As New Leave_Request(status)
        fleave.Show()
        Me.Close()
    End Sub

    Private Sub btn_leave_send_Click(sender As Object, e As EventArgs) Handles btn_leave_send.Click
        Dim fleave As New Leave_Request(status)
        fleave.Show()
        Me.Close()
    End Sub

    Private Sub btn_bonus_view_Click(sender As Object, e As EventArgs) Handles btn_bonus_view.Click
        Dim fbonus As New Bonus_Empinfo(status)
        fbonus.Show()
        Me.Close()
    End Sub

    Private Sub btn_changepw_user_Click(sender As Object, e As EventArgs) Handles btn_changepw_user.Click
        Dim fchangepw As New Password_Change(status)
        fchangepw.Show()
        Me.Close()
    End Sub
End Class