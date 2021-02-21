Public Class Show_Employee
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu()
        fmain.Show()
        Me.Close()
    End Sub
End Class