Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Subject
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource
    Private Sub load_Data()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            objdatapter.SelectCommand = cmd
            objdatapter.Fill(dtable)
            bSource.DataSource = dtable
            DataGridView1.DataSource = bSource
            objdatapter.Update(dtable)
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Course_load()
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.courses"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("coursename")
                SelectCourseCB.Items.Add(sName)
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Course_load()
        load_Data()
        SubjectIDTB.Enabled = False
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If SelectCourseCB.Text = "" Or
                    SubjectNameTB.Text = "" Or
                    SelectSemYearCB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Save the Record !", "Record Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "insert into cmsdbx.subject ( coursename, semoryear, subjectname, subjecttype, theorymarks, practicalmarks )value
                                                 ('" & SelectCourseCB.Text & "','" & SelectSemYearCB.Text & "','" & SubjectNameTB.Text & "','" & SubjectTypeCB.Text & "','" & TheoryMarksTB.Text & "','" & PracticalMarksTB.Text & "')"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Saved in database", MsgBoxStyle.Information, "Record Saved")
                    SelectCourseCB.SelectedIndex = -1
                    SelectSemYearCB.SelectedIndex = -1
                    SubjectIDTB.Clear()
                    SubjectNameTB.Clear()
                    SubjectTypeCB.SelectedIndex = -1
                    TheoryMarksTB.Clear()
                    PracticalMarksTB.Clear()

                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If SelectCourseCB.Text = "" Or
                    SubjectNameTB.Text = "" Or
                    SelectSemYearCB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Delete the Record !", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "delete from cmsdbx.subject where subjectid='" & SubjectIDTB.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Deleted in database", MsgBoxStyle.Information, "Record Deleted")
                    SelectCourseCB.SelectedIndex = -1
                    SelectSemYearCB.SelectedIndex = -1
                    SubjectIDTB.Clear()
                    SubjectNameTB.Clear()
                    SubjectTypeCB.SelectedIndex = -1
                    TheoryMarksTB.Clear()
                    PracticalMarksTB.Clear()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If SelectCourseCB.Text = "" Or
                    SubjectNameTB.Text = "" Or
                    SelectSemYearCB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Update the Record !", "Record Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "update cmsdbx.subject set coursename='" & SelectCourseCB.Text & "', semoryear='" & SelectSemYearCB.Text & "', subjectid='" & SubjectIDTB.Text & "', subjectname='" & SubjectNameTB.Text & "', subjecttype='" & SubjectTypeCB.Text & "', theorymarks='" & TheoryMarksTB.Text & "', practicalmarks='" & PracticalMarksTB.Text & "' where subjectid='" & SubjectIDTB.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Updated in database", MsgBoxStyle.Information, "Record Updated")
                    SelectCourseCB.SelectedIndex = -1
                    SelectSemYearCB.SelectedIndex = -1
                    SubjectIDTB.Clear()
                    SubjectNameTB.Clear()
                    SubjectTypeCB.SelectedIndex = -1
                    TheoryMarksTB.Clear()
                    PracticalMarksTB.Clear()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        dtable.Rows.Clear()
        dtable.Columns.Clear()

        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            objdatapter.SelectCommand = cmd
            objdatapter.Fill(dtable)
            bSource.DataSource = dtable
            DataGridView1.DataSource = bSource
            objdatapter.Update(dtable)
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            SelectCourseCB.Text = row.Cells("coursename").Value.ToString
            SelectSemYearCB.Text = row.Cells("semoryear").Value.ToString
            SubjectIDTB.Text = row.Cells("subjectid").Value.ToString
            SubjectNameTB.Text = row.Cells("subjectname").Value.ToString
            SubjectTypeCB.Text = row.Cells("subjecttype").Value.ToString
            TheoryMarksTB.Text = row.Cells("theorymarks").Value.ToString
            PracticalMarksTB.Text = row.Cells("practicalmarks").Value.ToString
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        SelectCourseCB.SelectedIndex = -1
        SelectSemYearCB.SelectedIndex = -1
        SubjectIDTB.Clear()
        SubjectNameTB.Clear()
        SubjectTypeCB.SelectedIndex = -1
        TheoryMarksTB.Clear()
        PracticalMarksTB.Clear()
    End Sub


End Class