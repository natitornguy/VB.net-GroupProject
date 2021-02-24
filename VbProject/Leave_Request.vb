Public Class Leave_Request
    Dim status As Integer
    'Dim connectDB As ConnectDB
    Public Sub New(status As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Leave_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addLeaveRequestsToTable()
    End Sub

    Private Sub addLeaveRequestsToTable()
        Dim cmdtext
        If status = 0 Then
            cmdtext = "SELECT l.emp_id, (e.emp_fname ||' '||e.emp_lname) AS FullName, ml.leave_name AS Status from LEAVES l INNER JOIN EMPLOYEES e ON l.emp_id = e.emp_id INNER JOIN MAS_LEAVE_STATUS ml ON l.leave_status = ml.leave_id Where leave_status = 1"
        Else
            cmdtext = "Select * from leaves Where emp_id = 1"
        End If
        Dim result = ConnectDB.QueryAdapter(cmdtext)
        dtg_empleave.DataSource = result.Tables("Leave")
    End Sub
    Private Sub btn_admin_leave_Click(sender As Object, e As EventArgs) Handles btn_admin_leave.Click
        Dim form = New Leave_User(status)
        form.Show()
        Me.Close()
    End Sub

    Private Sub btn_approve_Click(sender As Object, e As EventArgs) Handles btn_approve.Click
        Dim id As Integer = dtg_empleave.SelectedRows.Item(0).Cells("emp_id").Value
        Dim cmdtext = "UPDATE LEAVES SET leave_status = 2 WHERE leave_id = " & id
        If ConnectDB.editData(cmdtext) Then
            MessageBox.Show("ยอมรับคำร้องขอการลาเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addLeaveRequestsToTable()
        End If

    End Sub

    Private Sub btn_disapprove_Click(sender As Object, e As EventArgs) Handles btn_disapprove.Click
        Dim id As Integer = dtg_empleave.SelectedRows.Item(0).Cells("emp_id").Value
        Dim cmdtext = "UPDATE LEAVES SET leave_status = 3 WHERE leave_id = " & id
        If ConnectDB.editData(cmdtext) Then
            MessageBox.Show("ปฏิเสธคำร้องขอการลาเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addLeaveRequestsToTable()
        End If
    End Sub
End Class