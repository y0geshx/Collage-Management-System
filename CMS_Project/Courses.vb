Imports System.ComponentModel
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Courses
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource
    Private Sub load_Data()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.courses"
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
    Private Sub Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()
        CourseIDTB.Enabled = False
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        dtable.Rows.Clear()
        dtable.Columns.Clear()

        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.courses"
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If CourseNameTB.Text = "" Or
                    CourseSemYearCB.Text = "" Or
                    TotalSemYearTB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Save the Record !", "Record Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "insert into cmsdbx.courses ( coursename, semoryear, totalsemoryear )value
                                                 ('" & CourseNameTB.Text & "','" & CourseSemYearCB.Text & "','" & TotalSemYearTB.Text & "')"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Saved in database", MsgBoxStyle.Information, "Record Saved")
                    CourseIDTB.Clear()
                    CourseNameTB.Clear()
                    CourseSemYearCB.SelectedIndex = -1
                    TotalSemYearTB.Clear()
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
            If CourseNameTB.Text = "" Or
                    CourseSemYearCB.Text = "" Or
                    TotalSemYearTB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Delete the Record !", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "delete from cmsdbx.courses where courseid='" & CourseIDTB.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Deleted in database", MsgBoxStyle.Information, "Record Deleted")
                    CourseIDTB.Clear()
                    CourseNameTB.Clear()
                    CourseSemYearCB.SelectedIndex = -1
                    TotalSemYearTB.Clear()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            CourseIDTB.Text = row.Cells("courseid").Value.ToString
            CourseNameTB.Text = row.Cells("coursename").Value.ToString
            CourseSemYearCB.Text = row.Cells("semoryear").Value.ToString
            TotalSemYearTB.Text = row.Cells("totalsemoryear").Value.ToString
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If CourseNameTB.Text = "" Or
                    CourseSemYearCB.Text = "" Or
                    TotalSemYearTB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Update the Record !", "Record Updatead", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "update cmsdbx.courses set courseid='" & CourseIDTB.Text & "',  coursename='" & CourseNameTB.Text & "', semoryear='" & CourseSemYearCB.Text & "', totalsemoryear='" & TotalSemYearTB.Text & "'  where courseid='" & CourseIDTB.Text & "'adm"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Updated in database", MsgBoxStyle.Information, "Record Updated")
                    CourseIDTB.Clear()
                    CourseNameTB.Clear()
                    CourseSemYearCB.SelectedIndex = -1
                    TotalSemYearTB.Clear()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try

    End Sub

    Private Sub TotalSemYearTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalSemYearTB.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter digit Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CourseNameTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CourseNameTB.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TotalSemYearTB_Validating(sender As Object, e As CancelEventArgs) Handles TotalSemYearTB.Validating
        Dim dd As Integer
        dd = Len(TotalSemYearTB.Text)
        If (dd <= 2) Then
            'Do nothing
        Else
            MessageBox.Show("Phone number should be < 50 ) ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TotalSemYearTB.Clear()
        End If
    End Sub
End Class