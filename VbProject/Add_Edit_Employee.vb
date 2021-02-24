Public Class Add_Edit_Employee

    Dim id As Integer
    Dim status As Integer
    Public Sub New(id As Integer, mode As Integer)
        InitializeComponent()
        Me.id = id
        Me.status = mode
    End Sub

    Private Sub loadcbo()
        Dim data = ConnectDB.QueryReader("SELECT dep_name
                                            FROM departments
                                            ", 1)
        For Each temp In data
            cbo_department.Items.Add(temp)
        Next
    End Sub

    Private Sub loaddata()
        loadcbo()
        Dim sqltext = "select emp_fname,emp_lname,emp_phone,emp_email,emp_address,emp_salary,dep_id
                        from employees
                         where emp_id = " & id
        Dim data = ConnectDB.QueryReader(sqltext, 7)
        txt_fname.Text = data(0)
        txt_lname.Text = data(1)
        txt_phone.Text = data(2)
        txt_email.Text = data(3)
        txt_address.Text = data(4)
        txt_salary.Text = data(5)
        cbo_department.SelectedIndex = data(6) - 1


    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim femp_info As New Show_Employee()
        femp_info.Show()
        Me.Close()
    End Sub

    Private Function findAdmin()
        If cbo_department.SelectedIndex > 0 Then
            Return 1
        Else
            Return 2
        End If
    End Function

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If status = 0 Then
            Dim sql As String = "insert into employees (emp_fname,emp_lname,emp_phone,emp_email,emp_address,emp_salary,leave_count,dep_id)
                VALUES ('" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_phone.Text & "','" & txt_email.Text & "','" & txt_address.Text & "'
            ," & txt_salary.Text & ",30," & cbo_department.SelectedIndex + 1 & ")"

            If ConnectDB.ExecuteData(sql) Then
                MessageBox.Show("เพื่มข้อมูลสำเร็จแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Dim femp_info As New Show_Employee()
            femp_info.Show()
            Me.Close()
        ElseIf status = 1 Then
            Dim sqlupdateemp = "update employees 
                            set emp_fname = '" & txt_fname.Text & "' ,emp_lname = '" & txt_lname.Text & "' ,emp_phone = '" & txt_phone.Text & "' ,emp_email = '" & txt_email.Text &
                       "' ,emp_address = '" & txt_address.Text & "' ,emp_salary = " & txt_salary.Text & " ,dep_id = " & cbo_department.SelectedIndex + 1 & " where emp_id = " & id
            Dim sqlupdateuser = "update users
                                   set role_id = " & findAdmin() & "
                                    where emp_id = " & id
            Dim bonusnum = ConnectDB.QueryGetone("select mas_grade_bonus from mas_grade where mas_grade_id = ")
            If ConnectDB.ExecuteData(sqlupdateemp) Then
                If ConnectDB.ExecuteData(sqlupdateuser) Then
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
            Dim femp_info As New Show_Employee()
            femp_info.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Add_Edit_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If status = 0 Then
            loadcbo()
        Else
            loaddata()
        End If
    End Sub
End Class