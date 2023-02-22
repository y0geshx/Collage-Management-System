Imports CMS_Project.MemoryStream
Imports MySql.Data.MySqlClient

Public Class ChangeSubject
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource
    Private Sub Subject_load()
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                Dim subName = READER.GetString("subjectname")
                SubCB.Items.Add(subName)
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChangeSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FacultyID.Text = faculityid
        FNameTB.Text = faculityname
        Subject_load()
        FacultyID.Enabled = False
        FNameTB.Enabled = False

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If FacultyID.Text = "" Or
             FNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Update the Record !", "Record Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "update faculties set subjectname='" & SubCB.Text & "' where facultyid='" & FacultyID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Updated in database", MsgBoxStyle.Information, "Record Updated")
                    Me.Close()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class