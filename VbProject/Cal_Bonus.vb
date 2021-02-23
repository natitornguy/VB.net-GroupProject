Public Class Cal_Bonus
    Dim status As Integer
    Dim id As Integer
    Public Sub New(status As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.id = id
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
        Dim sqltext = "select emp_fname,emp_lname,emp_salary,dep_id from employees where emp_id = " & id
        Dim result As ArrayList = ConnectDB.QueryReader(sqltext, 4)
        txt_fname.Text = result(0)
        txt_lname.Text = result(1)
        txt_salary.Text = result(2)
        Dim dep_data = ConnectDB.QueryAllDepartmentName("select * from departments", 3)
        For Each temp In dep_data
            cbo_department.Items.Add(temp)
            Debug.WriteLine(temp)
            Debug.WriteLine(temp)
            Debug.WriteLine(temp)
        Next
        cbo_department.SelectedIndex = result(3) - 1

    End Sub
End Class