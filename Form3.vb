Public Class Form3
    Private Sub BackToManHome_Click(sender As Object, e As EventArgs)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ProjectName.Text = Nothing Then
            MsgBox("Please enter the project name")
        End If
    End Sub
End Class