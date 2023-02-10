Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class EditFaculty
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




    Private Sub EditCloseButton1_Click(sender As Object, e As EventArgs) Handles EditCloseButton1.Click
        Me.Close()
    End Sub

    Private Sub PicSelectButton_Click(sender As Object, e As EventArgs) Handles PicSelectButton.Click
        Try
            With OpenFileDialog1
                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True

                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True

                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"

                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False



                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub PicClearButton_Click(sender As Object, e As EventArgs) Handles PicClearButton.Click
        PictureBox1.Image = Nothing

    End Sub

    Private Sub FacultyDeleteButton_Click(sender As Object, e As EventArgs) Handles FacultyDeleteButton.Click
        Try
            If FID.Text = "" Or
                    FFirstNameTB.Text = "" Or
                    FLastNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Delete the Record !", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "delete from cmsdbx.faculties where facultyid='" & FID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Deleted in database", MsgBoxStyle.Information, "Record Deleted")
                    FID.Clear()
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
                    GenderComboBox.SelectedIndex = -1
                    StatusComboBox.SelectedIndex = -1
                Else
                    MessageBox.Show("Operation Cancelled")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub
End Class