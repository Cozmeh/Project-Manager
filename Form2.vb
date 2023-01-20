Public Class Form2
    Private Sub LogoutManager_Click(sender As Object, e As EventArgs) Handles LogoutManager.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub NewProject_Click(sender As Object, e As EventArgs) Handles NewProject.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class