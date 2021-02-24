Imports System.Data.SQLite

Public Class Show_Bonus

    Dim status As Integer
    Dim id As Integer
    Public Sub New(status As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.id = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub showdata()
        Dim cmdtext = "Select CONCAT(emp_fname,' ',emp_lname),leave_count,emp_salary,g.MAS_GRADE_NAME,emp_bonus
                        from employees e
                        JOIN mas_grade g
                        ON g.MAS_GRADE_ID = e.GRADE
                        where emp_id = " & id
        '' (!,?) ? = จำนวน colum ที่ select ใน sql
        Dim result = ConnectDB.QueryReader(cmdtext, 5)
        showstagement(result.count, result)

    End Sub
    Private Sub showstagement(count, result)
        If count <> 0 Then
            lbl_empname.Text = result(0)
            lbl_leavedate.Text = result(1)
            lbl_salary.Text = result(2)
            lbl_grade.Text = result(3)
            lbl_bonus.Text = result(4)
            lbl_sum_salary.Text = result(2) + result(4)
        Else
            Dim cmdtext = "Select CONCAT(emp_fname,' ',emp_lname),leave_count,emp_salary,grade,emp_bonus
                        From employees e
                        where emp_id = " & id
            result = ConnectDB.QueryReader(cmdtext, 5)
            lbl_empname.Text = result(0)
            lbl_leavedate.Text = result(1)
            lbl_salary.Text = result(2)
            lbl_grade.Text = If(IsDBNull(result(3)), "ยังไม่ถูกประเมิน", result(3))
            lbl_bonus.Text = result(4)
            lbl_sum_salary.Text = result(2) + result(4)
        End If
    End Sub

    Private Sub Show_Bonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        If status = 1 Then
            Dim fbonusemp As New Bonus_Empinfo(status, id)
            fbonusemp.Show()
            Me.Close()
        ElseIf status = 2 Then
            Dim fmain As New Main_Menu(status, id)
            fmain.Show()
            Me.Close()
        End If

    End Sub
End Class