Public Class NewProjectWizard

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'Enable manager home page
        ManagerHomePage.Enabled = True
        Me.Close()
    End Sub

    Private Sub DeadlineDuration_ValueChanged(sender As Object, e As EventArgs) Handles DeadlineDuration.ValueChanged
        'store project name in grpbox legend
        If ProjectName.Text <> Nothing Then
            ProjectGrpBox.Text = ProjectName.Text
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Create.Click
        'check if the project details has been updated
        If ProjectName.Text = Nothing Then
            MsgBox("Please enter the project name")
            Return
        End If
        'opens the calender for further updation
        EditProjectWizard.Show()
        Me.Close()
    End Sub

    Private Sub NewProjectWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'diable manager HomePage
        ManagerHomePage.Enabled = False

        'this should add one month to minimum date threshold
        DeadlineDuration.MinDate = DateTime.Now.AddMonths(1)
    End Sub

    Private Sub NewProjectWizard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ManagerHomePage.Enabled = True
    End Sub
End Class