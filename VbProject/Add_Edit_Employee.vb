Public Class Add_Edit_Employee

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim femp_info As New Show_Employee()
        femp_info.Show()
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim femp_info As New Show_Employee()
        femp_info.Show()
        Me.Close()
    End Sub
End Class