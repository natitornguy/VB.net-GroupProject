Imports System.Data.SQLite

Public Class Show_Bonus

    Dim status As Integer
    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Show_Bonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdtext = "Select CONCAT(emp_fname,' ',emp_lname),leave_count,emp_salary,g.MAS_GRADE_NAME,emp_bonus
                        from employees e
                        JOIN mas_grade g
                        ON g.MAS_GRADE_ID = e.GRADE
                        where emp_id = 1"
        '' (!,?) ? = จำนวน colum ที่ select ใน sql
        Dim result = ConnectDB.QueryReader(cmdtext, 5)
        lbl_empname.Text = result(0)
        lbl_leavedate.Text = result(1)
        lbl_salary.Text = result(2)
        lbl_grade.Text = result(3)
        lbl_bonus.Text = result(4)
        lbl_sum_salary.Text = result(2) + result(4)



    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub
End Class