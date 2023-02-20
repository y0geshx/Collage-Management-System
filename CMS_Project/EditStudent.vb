Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports CMS_Project.MemoryStream

Public Class EditStudent
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource

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
                'SCourseTB.Items.Add(sName)
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub EditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Course_load()
        SID.Enabled = False
        CourseTB.Enabled = False
    End Sub
    Private Sub StuFirstNameTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StuFirstNameTB.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub StuLastNameTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StuLastNameTB.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StuDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles StuDateTimePicker.ValueChanged
        Dim ts As TimeSpan = DateTime.Now.Date - StuDateTimePicker.Value
        StuAgeTB.Text = String.Format("{0:n0}", (ts.TotalDays / 365))
    End Sub

    Private Sub StuPhoneTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StuPhoneTB.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StuEmaliTB_Validating(sender As Object, e As CancelEventArgs) Handles StuEmaliTB.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(StuEmaliTB.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            'MessageBox.Show("Success", "Checking")
        Else
            MessageBox.Show("Please enter a valid Email ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StuEmaliTB.Clear()
        End If
    End Sub

    Private Sub StuPINTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StuPINTB.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter six digit PIN Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
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

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PictureBox1.Image = Nothing
    End Sub

    Public Sub ChangeCourseButton_Click(sender As Object, e As EventArgs) Handles ChangeCourseButton.Click
        Dim cc As New ChangeCourse()
        stuid = SID.Text
        stuname = StuFirstNameTB.Text
        cc.ShowDialog()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If SID.Text = "" Or
                    StuFirstNameTB.Text = "" Or
                    StuLastNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Delete the Record !", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "delete from cmsdbx.students where studentid='" & SID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Deleted in database", MsgBoxStyle.Information, "Record Deleted")
                    Me.Close()
                    'FID.Clear()
                    'FLastNameTB.Clear()
                    'FFirstNameTB.Clear()
                    'FAgeTB.Clear()
                    'FPhoneTB.Clear()
                    'FemailTB.Clear()
                    'FAddressTB.Clear()
                    'FCityTB.Clear()
                    'FStateTB.Clear()
                    'FPINCodeTB.Clear()
                    'FQualiTB.Clear()
                    'FExpTB.Clear()
                    'FPasswordTB.Clear()
                    'FGenderComboBox.SelectedIndex = -1
                    'StatusComboBox.SelectedIndex = -1
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
            If SID.Text = "" Or
            StuLastNameTB.Text = "" Or
            StuFirstNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Update the Record !", "Record Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then

                    Dim query = "update students set studentid='" & SID.Text & "',firstname='" & StuFirstNameTB.Text & "', lastname='" & StuLastNameTB.Text & "', gender='" & StuGenderCB.Text & "', dob='" & StuDateTimePicker.Text & "', age='" & StuAgeTB.Text & "', fathername='" & StuFatherTB.Text & "', mothername='" & StuMotherTB.Text & "', contactnumber='" & StuPhoneTB.Text & "', emailid='" & StuEmaliTB.Text & "', address='" & StuAddressTB.Text & "', city='" & StuCityTB.Text & "', state='" & StuStateTB.Text & "', pincode='" & StuPINTB.Text & "', coursename='" & CourseTB.Text & "', admissiondate='" & StuAdmissionTB.Text & "',activestatus='" & StatusComboBox.Text & "' where studentid='" & SID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Updated in database", MsgBoxStyle.Information, "Record Updated")
                    Me.Close()
                    'FID.Clear()
                    'FLastNameTB.Clear()
                    'FFirstNameTB.Clear()
                    'FAgeTB.Clear()
                    'FPhoneTB.Clear()
                    'FemailTB.Clear()
                    'FAddressTB.Clear()
                    'FCityTB.Clear()
                    'FStateTB.Clear()
                    'FPINCodeTB.Clear()
                    'FQualiTB.Clear()
                    'FExpTB.Clear()
                    'FPasswordTB.Clear()
                    'FGenderComboBox.SelectedIndex = -1
                    'StatusComboBox.SelectedIndex = -1

                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try

    End Sub
End Class