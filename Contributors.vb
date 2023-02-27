Imports System.Data.SqlClient

Public Class Contributors
    Private Sub Contributors_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to update contibutors", vbYesNo, "Update Contributors")
        ProjectLayout.Enabled = True
    End Sub

    Private Sub Contributors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        projectId.Text = "Project Id: " + ProjectLayout.ProjectId.Text
        DataLoader()
    End Sub

    Public Sub DataLoader()
        'change project id datatype
        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT * FROM Contributors WHERE PID = '" & ProjectLayout.ProjectId.Text & "'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        ContributorDataGrid.DataSource = Consoledata.Tables(0)
    End Sub
End Class