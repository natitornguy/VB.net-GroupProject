Public Class Leave_Request
    Dim status As Integer
    Dim userid As Integer
    Public Sub New(status As Integer, id As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.userid = id
        ' Add any initialization after the InitializeComponent() call.
        Select Case Me.status
            Case 1
                btn_approve.Show()
                btn_disapprove.Show()
                Exit Select
            Case 2
                btn_approve.Hide()
                btn_disapprove.Hide()
                Exit Select
        End Select
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu(status, userid)
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Leave_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addLeaveRequestsToTable()
    End Sub

    Private Sub addLeaveRequestsToTable()
        Dim cmdtext As String
        If status = 1 Then
            cmdtext = "SELECT l.LEAVE_ID AS 'ลำดับคำร้องขอ' ,
                        l.emp_id AS 'รหัสประจำตัวพนักงาน',
                        concat(e.emp_fname,' ', e.emp_lname) AS 'ชื่อพนักงาน',
                        ml.mas_leave_name AS 'สถานะคำร้องขอ',
                        l.LEAVE_FROM as 'วันที่ลา',l.LEAVE_TO as 'ถึงวันที่',
                        l.LEAVE_REASON AS 'เหตุผล' 
                        from LEAVES l 
                        INNER JOIN EMPLOYEES e ON l.emp_id = e.emp_id 
                        INNER JOIN MAS_LEAVE_STATUS ml ON l.leave_status = ml.mas_leave_id 
                        Where leave_status = 1 or l.emp_id = " & userid
        Else
            cmdtext = "SELECT l.LEAVE_ID AS 'ลำดับคำร้องขอ' ,
                        l.emp_id AS 'Employee ID',
                        concat(e.emp_fname,' ', e.emp_lname) AS 'Employee Name',
                        ml.mas_leave_name AS 'Status',
                        l.LEAVE_FROM as 'วันที่ลา',
                        l.LEAVE_TO as 'ถึงวันที่',
                        l.LEAVE_REASON AS 'เหตุผล' 
                        from LEAVES l 
                        INNER JOIN EMPLOYEES e ON l.emp_id = e.emp_id 
                        INNER JOIN MAS_LEAVE_STATUS ml ON l.leave_status = ml.mas_leave_id 
                        Where l.emp_id = " & userid
        End If
        Dim result = ConnectDB.QueryAdapter(cmdtext)
        dtgLeaveRequests.DataSource = result.Tables("data")
        dtgLeaveRequests.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgLeaveRequests.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgLeaveRequests.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtgLeaveRequests.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgLeaveRequests.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgLeaveRequests.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgLeaveRequests.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub btn_admin_leave_Click(sender As Object, e As EventArgs) Handles btn_admin_leave.Click
        Dim form = New Leave_User(status, userid)
        form.Show()
        Me.Close()
    End Sub

    Private Function findDateDiff(fromDate, toDate)
        If fromDate = toDate Then
            Return 1
        End If
        Return DateDiff(DateInterval.Day, fromDate, toDate)
    End Function

    Private Sub btn_approve_Click(sender As Object, e As EventArgs) Handles btn_approve.Click
        Try
            Dim request_id As Integer = dtgLeaveRequests.SelectedRows.Item(0).Cells("ลำดับคำร้องขอ").Value
            Dim emp_id As Integer = dtgLeaveRequests.SelectedRows.Item(0).Cells("รหัสประจำตัวพนักงาน").Value
            Dim fromDate = dtgLeaveRequests.SelectedRows.Item(0).Cells("วันที่ลา").Value
            Dim toDate = dtgLeaveRequests.SelectedRows.Item(0).Cells("ถึงวันที่").Value
            Dim cmdtext = "UPDATE LEAVES SET leave_status = 2 WHERE leave_id = " & request_id
            Dim decreaseCount = "UPDATE employees SET leave_count = leave_count - " & findDateDiff(fromDate, toDate) & " WHERE emp_id = " & emp_id
            If userid = emp_id Then
                MessageBox.Show("ไม่อนุญาตให้ยืนยันคำร้องขอของตนเอง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If ConnectDB.ExecuteData(cmdtext) And ConnectDB.ExecuteData(decreaseCount) Then
                    MessageBox.Show("ยอมรับคำร้องขอการลาเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    addLeaveRequestsToTable()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ไม่มีข้อมูลที่ถูกเลือกไว้", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btn_disapprove_Click(sender As Object, e As EventArgs) Handles btn_disapprove.Click
        Try
            Dim request_id As Integer = dtgLeaveRequests.SelectedRows.Item(0).Cells("ลำดับคำร้องขอ").Value
            Dim emp_id As Integer = dtgLeaveRequests.SelectedRows.Item(0).Cells("รหัสประจำตัวพนักงาน").Value
            Dim cmdtext = "UPDATE LEAVES SET leave_status = 3 WHERE leave_id = " & request_id
            If userid = emp_id Then
                MessageBox.Show("ไม่อนุญาตให้ปฏิเสธคำร้องขอของตนเอง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If ConnectDB.ExecuteData(cmdtext) Then
                    MessageBox.Show("ปฏิเสธคำร้องขอการลาเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    addLeaveRequestsToTable()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ไม่มีข้อมูลที่ถูกเลือกไว้", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        addLeaveRequestsToTable()
    End Sub
End Class