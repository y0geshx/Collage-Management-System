Imports Guna.UI2.HtmlRenderer.Adapters
Imports MySql.Data.MySqlClient

Public Class AddUsers
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource

    Private Sub load_Data()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.users"
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
    Private Sub AddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()
        UserID.Enabled = False
    End Sub
    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Showpass.CheckedChanged
        If Showpass.Checked = True Then
            UserPassword1.UseSystemPasswordChar = False
        Else
            UserPassword1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub SaveButton2_Click(sender As Object, e As EventArgs) Handles SaveButton2.Click
        Try
            If UserFirstName.Text = "" Or
                    UserLastNmae.Text = "" Or
                    UserEmail.Text = "" Or
                    UserNumber.Text = "" Or
                    UserPassword1.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Save the Record !", "Record Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "insert into users ( username, lastname, emailid, phone, password )value
                                                 ('" & UserFirstName.Text & "','" & UserLastNmae.Text & "','" & UserEmail.Text & "','" & UserNumber.Text & "','" & UserPassword1.Text & "')"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Saved in database", MsgBoxStyle.Information, "Record Saved")
                    UserID.Clear()
                    UserFirstName.Clear()
                    UserLastNmae.Clear()
                    UserEmail.Clear()
                    UserNumber.Clear()
                    UserPassword1.Clear()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub

    Private Sub UpdateButton3_Click(sender As Object, e As EventArgs) Handles UpdateButton3.Click
        Try
            If UserFirstName.Text = "" Or
                    UserLastNmae.Text = "" Or
                    UserEmail.Text = "" Or
                    UserNumber.Text = "" Or
                    UserPassword1.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Update the Record !", "Record Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "update users set id='" & UserID.Text & "',username='" & UserFirstName.Text & "',lastname='" & UserLastNmae.Text & "',emailid='" & UserEmail.Text & "',phone='" & UserNumber.Text & "',password='" & UserPassword1.Text & "' where id='" & UserID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Updated in database", MsgBoxStyle.Information, "Record Updated")
                    UserID.Clear()
                    UserFirstName.Clear()
                    UserLastNmae.Clear()
                    UserEmail.Clear()
                    UserNumber.Clear()
                    UserPassword1.Clear()
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
            query = "SELECT * FROM cmsdbx.users"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            objdatapter.SelectCommand = cmd
            objdatapter.Fill(dtable)
            'bSource.DataSource = dtable
            DataGridView1.DataSource = dtable
            'objdatapter.Update(dtable)
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            UserID.Text = row.Cells("id").Value.ToString
            UserFirstName.Text = row.Cells("username").Value.ToString
            UserLastNmae.Text = row.Cells("lastname").Value.ToString
            UserEmail.Text = row.Cells("emailid").Value.ToString
            UserNumber.Text = row.Cells("phone").Value.ToString
            UserPassword1.Text = row.Cells("password").Value.ToString
        End If
    End Sub
    Private Sub DeleteButton1_Click(sender As Object, e As EventArgs) Handles DeleteButton1.Click
        Try
            If UserFirstName.Text = "" Or
                    UserLastNmae.Text = "" Or
                    UserEmail.Text = "" Or
                    UserNumber.Text = "" Or
                    UserPassword1.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Delete the Record !", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "delete from users where id='" & UserID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Deleted in database", MsgBoxStyle.Information, "Record Deleted")
                    UserID.Clear()
                    UserFirstName.Clear()
                    UserLastNmae.Clear()
                    UserEmail.Clear()
                    UserNumber.Clear()
                    UserPassword1.Clear()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        UserID.Clear()
        UserFirstName.Clear()
        UserLastNmae.Clear()
        UserEmail.Clear()
        UserNumber.Clear()
        UserPassword1.Clear()
    End Sub


End Class