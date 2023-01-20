Public Class Form3
    Private Sub BackToManHome_Click(sender As Object, e As EventArgs) Handles BackToManHome.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub DeadlineDuration_ValueChanged(sender As Object, e As EventArgs) Handles DeadlineDuration.ValueChanged
        If ProjectName.Text <> Nothing Then
            ProjectGrpBox.Text = ProjectName.Text
        End If
    End Sub
End Class