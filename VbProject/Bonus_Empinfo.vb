Public Class Bonus_Empinfo

    Dim status As Integer
    Dim id As Integer
    Public Sub New(status As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.id = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loaddata(param)
        Dim sqltext = "select emp_id as ID,
                        CONCAT(emp_fname,' ',emp_lname) as 'ชื่อนามสกุล',
                        emp_salary as 'เงินเดือน',
                        emp_bonus as 'โบนัส',
                        leave_count as 'วันลาที่เหลือ',
                        dep_name as 'แผนก',
                        grade as 'เกรด'
                        from employees e
                        JOIN departments d
                        ON e.DEP_ID = d.DEP_ID
                        where emp_fname like '%" & param & "%' or
                        emp_lname like '%" & param & "%'"
        Dim result = ConnectDB.QueryAdapter(sqltext)
        dtg_empinfo.DataSource = result.Tables("data")
    End Sub

    Private Sub setdtg()
        dtg_empinfo.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtg_empinfo.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub Bonus_Empinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata("")
        setdtg()

        If status = 1 Then
            btn_showbonus.Visible = True
        End If
    End Sub

    Private Sub btn_evaluate_Click(sender As Object, e As EventArgs) Handles btn_evaluate.Click
        Dim id = dtg_empinfo.SelectedRows.Item(0).Cells(0).Value
        Debug.WriteLine(id & Me.id)
        If id = Me.id Then
            MessageBox.Show("คุณไม่สามารถประเมินตนเองได้ !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim fcal_bonus = New Cal_Bonus(status, Me.id, id)
            fcal_bonus.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status, id)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim name = txt_fname_search.Text
        loaddata(name)
    End Sub

    Private Sub btn_showbonus_Click(sender As Object, e As EventArgs) Handles btn_showbonus.Click
        Dim fshowbo As New Show_Bonus(status, id)
        fshowbo.Show()
        Me.Close()
    End Sub
End Class