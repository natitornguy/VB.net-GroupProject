Public Class Show_Employee

    Private Sub showdata()
        Dim cmdtext = "Select * from employees"
        Dim result = ConnectDB.QueryAdapter(cmdtext)
        dtg_empinfo.DataSource = result.Tables("data")
    End Sub

    Private Sub deletedata()
        Dim result As DialogResult = MessageBox.Show("คุณต้องการลบ " & dtg_empinfo.SelectedRows.Item(0).Cells(1).Value & " หรือไม่", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim id As Integer = dtg_empinfo.SelectedRows.Item(0).Cells("emp_id").Value
            Dim cmdtext = "Delete from employees where emp_id= " & id
            'Dim result = ConnectDB.ExecuteData(cmdtext)

            If ConnectDB.ExecuteData(cmdtext) Then
                MessageBox.Show("ลบข้อมููลเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showdata()
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu()
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Show_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        deletedata()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim id As Integer = dtg_empinfo.SelectedRows.Item(0).Cells(0).Value
        Dim addfrom As New Add_Edit_Employee(id, 0)
        addfrom.Show()
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim id As Integer = dtg_empinfo.SelectedRows.Item(0).Cells(0).Value
        Dim updatefrom As New Add_Edit_Employee(id, 1)
        updatefrom.Show()
        Me.Close()
    End Sub
End Class