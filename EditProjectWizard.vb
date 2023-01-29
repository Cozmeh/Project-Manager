Public Class EditProjectWizard

    Private Sub EditProjectWizard_closeing(sender As Object, e As EventArgs) Handles MyBase.Closing
        ManagerHomePage.Enabled = True
    End Sub

    Private Sub EditProjectWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Filling all the fields
        ProjectName.Text = NewProjectWizard.ProjectName.Text
        Deadline.Value = NewProjectWizard.DeadlineDuration.Value
        Count.Text = NewProjectWizard.PeopleCount.Value
    End Sub

    'Private Sub Cancel_Click(sender As Object, e As EventArgs)
    '    ManagerHomePage.Enabled = True
    '    Me.Close()
    'End Sub

    'Private Sub Delete_Click(sender As Object, e As EventArgs)
    '    Dim responce As String = MsgBox("Do you want to delete " & ProjectName.Text, vbYesNo, "Are You Sure?")
    '    If responce = vbYes Then
    '        'delete the row from database
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        ManagerHomePage.Enabled = True
        Me.Close()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        EditProjectDetails.Show()
        Me.Enabled = False
    End Sub
End Class