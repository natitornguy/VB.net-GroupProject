Public Class Cal_Bonus
    Dim status As Integer
    Dim userid As Integer
    Dim id As Integer
    Public Sub New(status As Integer, curid As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.userid = curid
        Me.id = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loaddata()
        Dim sqltext = "select emp_fname,emp_lname,emp_salary,d.DEP_NAME,grade 
                        from employees e
                        JOIN departments d
                        ON e.DEP_ID = d.DEP_ID
                        where emp_id = " & id
        Dim result As ArrayList = ConnectDB.QueryReader(sqltext, 5)
        txt_fname.Text = result(0)
        txt_lname.Text = result(1)
        txt_salary.Text = result(2)
        txt_department.Text = result(3)
        cbo_grade.SelectedIndex = If(IsDBNull(result(4)), -1, result(4) - 1)
    End Sub

    Private Sub evaluate_emp()
        Dim gradeid = cbo_grade.SelectedIndex + 1
        Dim sqltext = "select mas_grade_bonus from mas_grade where mas_grade_id = " & gradeid
        Dim gradenum = ConnectDB.QueryGetone(sqltext)
        Dim data = ConnectDB.QueryReader("select emp_salary,CONCAT(emp_fname,' ',emp_lname) from employees where emp_id = " & id, 2)
        Dim salary As Double = data(0)
        Dim fullname = data(1)
        Dim bonus = salary * gradenum
        Debug.WriteLine(bonus)
        Dim sqlupdate = "update employees 
                            set grade = " & gradeid & ",emp_bonus = " & bonus &
                           " where emp_id = " & id

        If ConnectDB.ExecuteData(sqlupdate) Then
            MessageBox.Show("ประเมินพนักงาน " & fullname & " เรียบร้อย", "Update Grade", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim fbonus_info As New Bonus_Empinfo(status, userid)
            fbonus_info.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fbonus_info As New Bonus_Empinfo(status, userid)
        fbonus_info.Show()
        Me.Close()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim index = cbo_grade.SelectedIndex
        If index <> -1 Then
            evaluate_emp()
        Else
            MessageBox.Show("กรุณาประเมินพนักงานด้วย !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Cal_Bonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class