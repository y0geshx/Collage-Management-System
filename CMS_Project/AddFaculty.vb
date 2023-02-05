Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AddFaculty
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Private Sub AddFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timelable.Text = DateTime.Now.ToString()
    End Sub

    Private Sub FFirstNameTB_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FLastNameTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FFirstNameTB.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub FDOBDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FDOBDateTimePicker.ValueChanged
        Dim ts As TimeSpan = DateTime.Now.Date - FDOBDateTimePicker.Value
        FAgeTB.Text = String.Format("{0:n0}", (ts.TotalDays / 365))
    End Sub

    Private Sub FPhoneTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FPhoneTB.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub FemailTB_Validating(sender As Object, e As CancelEventArgs) Handles FemailTB.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(FemailTB.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            'MessageBox.Show("Success", "Checking")
        Else
            MessageBox.Show("Please enter a valid Email ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FemailTB.Clear()
        End If
    End Sub

    Private Sub FPINCodeTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FPINCodeTB.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter six digit PIN Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FShowpass_CheckedChanged(sender As Object, e As EventArgs) Handles FShowpass.CheckedChanged
        If FShowpass.Checked = True Then
            FPasswordTB.UseSystemPasswordChar = False
        Else
            FPasswordTB.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FacultyResetButton_Click(sender As Object, e As EventArgs) Handles FacultyResetButton.Click
        FLastNameTB.Clear()
        FFirstNameTB.Clear()
        FAgeTB.Clear()
        FPhoneTB.Clear()
        FemailTB.Clear()
        FAddressTB.Clear()
        FCityTB.Clear()
        FStateTB.Clear()
        FPINCodeTB.Clear()
        FQualiTB.Clear()
        FExpTB.Clear()
        FPasswordTB.Clear()
        FGenderComboBox.SelectedIndex = -1
    End Sub

    Private Sub FacultySaveButton_Click(sender As Object, e As EventArgs) Handles FacultySaveButton.Click
        Try
            If FLastNameTB.Text = "" Or
            FFirstNameTB.Text = "" Or
            FAgeTB.Text = " " Or
            FPhoneTB.Text = "" Or
            FemailTB.Text = "" Or
            FAddressTB.Text = "" Or
            FCityTB.Text = "" Or
            FStateTB.Text = "" Or
            FPINCodeTB.Text = "" Or
            FQualiTB.Text = "" Or
            FExpTB.Text = "" Or
            FPasswordTB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim query = "insert into faculties (facultyfirstname, facultylastname, gender, dob, age, contactnumber, emailid, address, city, state, pincode, qualification, experience, password, activestatus, joindate )values
                                               ('" & FLastNameTB.Text & "','" & FFirstNameTB.Text & "','" & FGenderComboBox.Text & "','" & FDOBDateTimePicker.Text & "','" & FAgeTB.Text & "','" & FPhoneTB.Text & "','" & FemailTB.Text & "','" & FAddressTB.Text & "', '" & FCityTB.Text & "','" & FStateTB.Text & "','" & FPINCodeTB.Text & "','" & FQualiTB.Text & "','" & FExpTB.Text & "','" & FPasswordTB.Text & "','" & "Active" & "','" & timelable.Text & "' ) "

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(query, myconnection.open)

                cmd.ExecuteNonQuery()
                myconnection.close()
                MsgBox("Successfully Saved in database", MsgBoxStyle.Information, "Record Saved")
                FLastNameTB.Clear()
                FFirstNameTB.Clear()
                FAgeTB.Clear()
                FPhoneTB.Clear()
                FemailTB.Clear()
                FAddressTB.Clear()
                FCityTB.Clear()
                FStateTB.Clear()
                FPINCodeTB.Clear()
                FQualiTB.Clear()
                FExpTB.Clear()
                FPasswordTB.Clear()
                FGenderComboBox.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub

    Private Sub AddCloseButton1_Click(sender As Object, e As EventArgs) Handles AddCloseButton1.Click
        Me.Close()
    End Sub


End Class