Imports Guna.UI2.HtmlRenderer.Adapters
Imports MySql.Data.MySqlClient

Public Class AddUsers
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
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
                Dim query = "insert into users ( username, lastname, emailid, phone, password )value
                                                 ('" & UserFirstName.Text & "','" & UserLastNmae.Text & "','" & UserEmail.Text & "','" & UserNumber.Text & "','" & UserPassword1.Text & "')"
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(query, myconnection.open)
                cmd.ExecuteNonQuery()
                myconnection.close()
                MsgBox("Successfully Saved in database", MsgBoxStyle.Information, "Record Saved")
                UserFirstName.Clear()
                UserLastNmae.Clear()
                UserEmail.Clear()
                UserNumber.Clear()
                UserPassword1.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub
End Class