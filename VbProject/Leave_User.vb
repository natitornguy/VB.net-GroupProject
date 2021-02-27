Imports System.Data.SQLite
Imports System.Text
Public Class Leave_User
    Dim status As Integer
    Dim userid As Integer = 1
    Public Sub New(status As Integer, userid As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.status = status
        Me.userid = userid
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn_send_leave_Click(sender As Object, e As EventArgs) Handles btn_send_leave.Click
        Dim emp_id = CInt(txtEmpID.Text)
        Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
        Dim dateFromEng As DateTime = Convert.ToDateTime(dtp_start.Value, _cultureEnInfo)
        Dim dateToEng As DateTime = Convert.ToDateTime(dtp_end.Value, _cultureEnInfo)
        Dim fromDate = dateFromEng.ToString("yyyy-MM-dd", _cultureEnInfo)
        Dim toDate = dateToEng.ToString("yyyy-MM-dd", _cultureEnInfo)
        Dim reason = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_reason.Text))

        Dim sql = "INSERT INTO leaves (EMP_ID,LEAVE_STATUS,LEAVE_FROM,LEAVE_TO,LEAVE_REASON) VALUES (" & emp_id & ", 1 , '" & fromDate & "' , '" & toDate & "' ,'" & reason & "')"
        If ConnectDB.ExecuteData(sql) Then
            MessageBox.Show("ทำการบันทึกแบบฟอร์มการลาเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim fleave As New Leave_Request(status, userid)
            fleave.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Leave_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_start.MinDate = Date.Now
        dtp_end.Enabled = False
        txtEmpID.Text = userid
        Dim result = ConnectDB.QueryReader("SELECT CONCAT(e.EMP_FNAME, ' ', e.EMP_LNAME) AS FullName, e.LEAVE_COUNT FROM employees e WHERE e.EMP_ID = " & userid, 2)
        txtFullname.Text = result(0)
        txtRemaining.Text = result(1)
    End Sub

    Private Sub dtp_start_ValueChanged(sender As Object, e As EventArgs) Handles dtp_start.ValueChanged
        dtp_end.Enabled = True
        dtp_end.MinDate = dtp_start.MinDate.AddYears(-10)
        dtp_end.MaxDate = dtp_start.MinDate.AddYears(10)
        dtp_end.Value = dtp_start.Value
        dtp_end.MinDate = dtp_start.Value
        dtp_end.MaxDate = dtp_start.Value.AddDays(3).AddHours(1)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim requests = New Leave_Request(status, userid)
        requests.Show()
        Me.Close()
    End Sub
End Class