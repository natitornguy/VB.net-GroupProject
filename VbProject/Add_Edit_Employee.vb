Imports System.Text.RegularExpressions
Public Class Add_Edit_Employee

    Dim id As Integer
    Dim dtgid As Integer
    Dim status As Integer
    Dim userstatus As Integer
    Public Sub New(id As Integer, dtgid As Integer, mode As Integer, status As Integer)
        InitializeComponent()
        Me.id = id
        Me.dtgid = dtgid
        Me.status = mode
        Me.userstatus = status
    End Sub

    Private Function showMatch(ByVal text As String, ByVal expr As String)
        Dim regex As New Regex(expr)
        Dim match As Match = regex.Match(text)
        If match.Success Then
            Return True
        Else
            Return False
        End If
        'For Each m In mc
        '    Debug.WriteLine(m)
        'Next m
    End Function

    Public Sub NumeberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If

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
                         where emp_id = " & dtgid
        Dim data = ConnectDB.QueryReader(sqltext, 7)
        txt_fname.Text = data(0)
        txt_lname.Text = data(1)
        txt_phone.Text = data(2)
        txt_email.Text = data(3)
        txt_address.Text = data(4)
        txt_salary.Text = data(5)
        cbo_department.SelectedIndex = data(6) - 1


    End Sub
    Private Sub idgenerate()
        Dim fname = txt_fname.Text
        Dim lname = txt_lname.Text
        Dim pphone = txt_phone.Text.Replace("-", "")
        Dim username = lname.Substring(0, 2) & "." & fname
        Dim sqlempid As Integer = ConnectDB.QueryGetone("SELECT emp_id 
                                                        FROM employees 
                                                        WHERE emp_fname = '" & fname & "' AND emp_lname = '" & lname & "' AND emp_phone = '" & pphone & "'")

        ConnectDB.ExecuteData("insert into users (username, password, emp_id, role_id)
                                VALUES ('" & username & "','" & pphone & "','" & sqlempid & "','" & findAdmin() & "')")
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim femp_info As New Show_Employee(userstatus, id)
        femp_info.Show()
        Me.Close()
    End Sub

    Private Function findAdmin()
        If cbo_department.SelectedIndex > 0 Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Private Sub insertData()
        'Dim sql As String = "insert into employees (emp_fname,emp_lname,emp_phone,emp_email,emp_address,emp_salary,emp_bonus,leave_count,dep_id)
        '        VALUES ('" & txt_fname.Text &
        '        "','" & txt_lname.Text &
        '        "','" & txt_phone.Text &
        '        "','" & txt_email.Text &
        '        "','" & txt_address.Text &
        '        "'," & txt_salary.Text &
        '        "0,30," & cbo_department.SelectedIndex + 1 & ")"
        Dim sql = "insert into employees (emp_fname,emp_lname,emp_phone,emp_email,emp_address,emp_salary,emp_bonus,leave_count,dep_id)
                VALUES ('" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_phone.Text & "','" & txt_email.Text & "','" & txt_address.Text & "'," & txt_salary.Text & ",0,30," & cbo_department.SelectedIndex + 1 & ")"

        If ConnectDB.ExecuteData(sql) Then
            MessageBox.Show("เพื่มข้อมูลสำเร็จแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            idgenerate()
        End If
        Dim femp_info As New Show_Employee(userstatus, id)
        femp_info.Show()
        Me.Close()
    End Sub

    Private Function nullgrade()
        Dim grade = ConnectDB.QueryGetone("select grade from employees where emp_id = " & dtgid)
        Dim emp_bonus As Double
        If IsDBNull(grade) Then
            emp_bonus = 0
        Else
            Dim bonusnum = ConnectDB.QueryGetone("select mas_grade_bonus from mas_grade where mas_grade_id = " & grade)
            emp_bonus = CDbl(txt_salary.Text) * CDbl(bonusnum)
        End If
        Return emp_bonus
    End Function

    Private Sub updateData()

        Dim currstatus As Integer
        ' find null at bonus
        Dim emp_bonus = nullgrade()
        ' update sql in employee
        Dim sqlupdateemp = "update employees 
                            set emp_fname = '" & txt_fname.Text &
                            "' ,emp_lname = '" & txt_lname.Text &
                            "' ,emp_phone = '" & txt_phone.Text &
                            "' ,emp_email = '" & txt_email.Text &
                            "' ,emp_address = '" & txt_address.Text &
                            "' ,emp_salary = " & txt_salary.Text &
                            " ,emp_bonus = " & emp_bonus &
                            " ,dep_id = " & cbo_department.SelectedIndex + 1 &
                            " where emp_id = " & dtgid
        'if can update employee
        If ConnectDB.ExecuteData(sqlupdateemp) Then
            ' update user permission
            Dim sqlupdateuser = "update users
                                 set role_id = " & findAdmin() &
                                 " where emp_id = " & dtgid
            ' if can update user permission
            If ConnectDB.ExecuteData(sqlupdateuser) Then
                MessageBox.Show("แก้ไขข้อมูลสำเร็จแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' set current status if HR change there role
                currstatus = ConnectDB.QueryGetone("select role_id from users where emp_id = " & id)
                ' if HR change there role go back to main
                If currstatus <> userstatus Then
                    Dim fmain As New Main_Menu(currstatus, id)
                    fmain.Show()
                    Me.Close()
                    ' if not change close this window
                Else
                    Dim femp_info As New Show_Employee(currstatus, id)
                    femp_info.Show()
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim checkemail = showMatch(txt_email.Text, "^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")

        Dim checkfname = showMatch(txt_fname.Text, "^[a-zA-Z\s]+$")
        Dim checkfnameth = showMatch(txt_fname.Text, "^[ก-๏\s]+$")

        Dim checklname = showMatch(txt_lname.Text, "^[a-zA-Z\s]+$")
        Dim checklnameth = showMatch(txt_lname.Text, "^[ก-๏\s]+$")

        If (checkfname Or checkfnameth) Then
            If (checklname Or checklnameth) Then
                If checkemail Then
                    If status = 0 Then
                        insertData()
                    ElseIf status = 1 Then
                        updateData()
                    End If
                Else
                    MessageBox.Show("กรุณากรอกอีเมล .com", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("กรุณากรอกนามสกุลด้วยตัวอักษรเท่านั้น", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("กรุณากรอกชื่อด้วยตัวอักษรเท่านั้น", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub Add_Edit_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If status = 0 Then
            loadcbo()
            btn_save.Text = "เพิ่มข้อมูล"
            lbl_status.Text = "เพิ่มข้อมูลพนักงาน"
            Me.Text = "Insert Data"
        Else
            loaddata()
            btn_save.Text = "แก้ไขข้อมูล"
            lbl_status.Text = "แก้ไขข้อมูลพนักงาน"
            Me.Text = "Update Data"
        End If
    End Sub

    Private Sub txt_phone_TextChanged(sender As Object, e As EventArgs) Handles txt_phone.KeyPress
        NumeberOnly(e)
        txt_phone.MaxLength = 10
    End Sub

    Private Sub txt_salary_TextChanged(sender As Object, e As EventArgs) Handles txt_salary.KeyPress
        NumeberOnly(e)
        txt_salary.MaxLength = 6
    End Sub
End Class