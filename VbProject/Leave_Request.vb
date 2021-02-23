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
        Dim cmdtext = "Select * from leaves"
        Dim result = ConnectDB.QueryAdapter(cmdtext)
        dtg_empleave.DataSource = result.Tables("data")
    End Sub

    Private Sub btn_admin_leave_Click(sender As Object, e As EventArgs) Handles btn_admin_leave.Click
        Dim form = New Leave_User(status)
        form.Show()
        Me.Close()
    End Sub
End Class