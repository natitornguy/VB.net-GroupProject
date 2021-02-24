Public Class Show_Employee
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim fmain As New Main_Menu()
        fmain.Show()
        Me.Close()
    End Sub

    Private Sub Show_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class