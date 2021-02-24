Public Class Show_Employee
    Dim status As Integer
    Dim id As Integer

    Public Sub New(status As Integer, id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.id = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub setdtg()
        dtg_empinfo.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dtg_empinfo.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtg_empinfo.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub

    Private Sub showdata(param)
        Dim cmdtext = "Select emp_id as 'รหัสพนักงาน',
                        concat(emp_fname,' ', emp_lname) as 'ชื่อนามสกุล',
                        emp_phone as 'เบอร์โทร',
                        emp_email as 'อีเมล',
emp_address as 'ที่อยู่',
emp_salary as 'เงินเดือน',
emp_bonus as 'โบนัส',
leave_count as 'วันลาที่เหลือ',
dep_id as 'แผนก',
grade as 'เกรด'
                        from employees
                        where emp_fname like '%" & param & "%' or
                        emp_lname like '%" & param & "%'"
        Dim result = ConnectDB.QueryAdapter(cmdtext)
        dtg_empinfo.DataSource = result.Tables("data")
        setdtg()
    End Sub

    Private Sub deletedata()
        Dim result As DialogResult = MessageBox.Show("คุณต้องการลบ " & dtg_empinfo.SelectedRows.Item(0).Cells(1).Value & " หรือไม่", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim id As Integer = dtg_empinfo.SelectedRows.Item(0).Cells(0).Value
            Dim cmdtext = "Delete from employees where emp_id= " & id
            'Dim result = ConnectDB.ExecuteData(cmdtext)

            If ConnectDB.ExecuteData(cmdtext) And ConnectDB.ExecuteData("delete from users where emp_id =" & id) Then
                MessageBox.Show("ลบข้อมููลเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showdata("")
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status, id)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Show_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata("")

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        deletedata()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim dtgid As Integer = dtg_empinfo.SelectedRows.Item(0).Cells(0).Value
        Dim addfrom As New Add_Edit_Employee(id, dtgid, 0, status)
        addfrom.Show()
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim dtgid As Integer = dtg_empinfo.SelectedRows.Item(0).Cells(0).Value
        Dim updatefrom As New Add_Edit_Employee(id, dtgid, 1, status)
        updatefrom.Show()
        Me.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim name = txt_fname_search.Text
        showdata(name)
    End Sub
End Class