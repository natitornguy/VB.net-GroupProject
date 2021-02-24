Public Class Bonus_Empinfo

    Dim status As Integer

    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loaddata()
        Dim sqltext = "select emp_id,CONCAT(emp_fname,' ',emp_lname) as name,emp_salary,emp_bonus,leave_count,dep_name,grade
                        from employees e
                        JOIN departments d
                        ON e.DEP_ID = d.DEP_ID"
        Dim result = ConnectDB.QueryAdapter(sqltext)
        dtg_empinfo.DataSource = result.Tables("data")
    End Sub

    Private Sub searchdata(name)
        If name <> "" Then
            Dim sqltext = "select emp_id,CONCAT(emp_fname,' ',emp_lname) as name,emp_salary,emp_bonus,leave_count,dep_name,grade
                        from employees e
                        JOIN departments d
                        ON e.DEP_ID = d.DEP_ID
                        where emp_fname like '%" & name & "%' or
                        emp_lname like '%" & name & "%'"
            Dim result = ConnectDB.QueryAdapter(sqltext)
            dtg_empinfo.DataSource = result.Tables("data")
        Else
            loaddata()
        End If

    End Sub
    Private Sub Bonus_Empinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btn_evaluate_Click(sender As Object, e As EventArgs) Handles btn_evaluate.Click
        Dim id = dtg_empinfo.SelectedRows.Item(0).Cells(0).Value
        Dim fcal_bonus = New Cal_Bonus(status, id)
        fcal_bonus.Show()
        Me.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim name = txt_fname_search.Text
        searchdata(name)
    End Sub
End Class