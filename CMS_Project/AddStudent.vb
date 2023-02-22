Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AddStudent
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
                StuCourseTB.Items.Add(sName)
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Course_load()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timelable.Text = DateTime.Now.ToString()
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

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        StuLastNameTB.Clear()
        StuFirstNameTB.Clear()
        StuAgeTB.Clear()
        StuFatherTB.Clear()
        StuMotherTB.Clear()
        StuPhoneTB.Clear()
        StuEmaliTB.Clear()
        StuAddressTB.Clear()
        StuCityTB.Clear()
        StuStateCB.SelectedIndex = -1
        StuPINTB.Clear()
        StuCourseTB.SelectedIndex = -1
        StuGenderCB.SelectedIndex = -1
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim filename As String = OpenFileDialog1.FileName + ".jpg"
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()

        Try
            If StuLastNameTB.Text = "" Or
        StuFirstNameTB.Text = " " Or
        StuAgeTB.Text = "" Or
        StuFatherTB.Text = "" Or
        StuMotherTB.Text = "" Or
        StuPhoneTB.Text = "" Or
        StuEmaliTB.Text = "" Or
        StuAddressTB.Text = "" Or
        StuCityTB.Text = "" Or
        StuStateCB.Text = "" Or
        StuPINTB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim query = "insert into students (firstname, lastname, gender, dob, age,fathername,mothername, contactnumber, emailid, address, city, state, pincode, coursename, admissiondate, activestatus, profilepic )values
                                               ('" & StuFirstNameTB.Text & "','" & StuLastNameTB.Text & "','" & StuGenderCB.Text & "','" & StuDateTimePicker.Text & "','" & StuAgeTB.Text & "','" & StuFatherTB.Text & "','" & StuMotherTB.Text & "','" & StuPhoneTB.Text & "','" & StuEmaliTB.Text & "','" & StuAddressTB.Text & "', '" & StuCityTB.Text & "','" & StuStateCB.Text & "','" & StuPINTB.Text & "','" & StuCourseTB.Text & "','" & StuAdmissionTB.Text & "','" & "Active" & "', @ImageFile ) "

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(query, myconnection.open)
                cmd.Parameters.AddWithValue("@ImageFile", arrImage)
                cmd.ExecuteNonQuery()
                myconnection.close()
                MsgBox("Successfully Saved in database", MsgBoxStyle.Information, "Record Saved")
                StuLastNameTB.Clear()
                StuFirstNameTB.Clear()
                StuAgeTB.Clear()
                StuFatherTB.Clear()
                StuMotherTB.Clear()
                StuPhoneTB.Clear()
                StuEmaliTB.Clear()
                StuAddressTB.Clear()
                StuCityTB.Clear()
                StuStateCB.SelectedIndex = -1
                StuPINTB.Clear()
                StuCourseTB.SelectedIndex = -1
                StuGenderCB.SelectedIndex = -1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub
    Private Sub AddCloseButton1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub StuPhoneTB_Validating(sender As Object, e As CancelEventArgs) Handles StuPhoneTB.Validating
        Dim dd As Integer
        dd = Len(StuPhoneTB.Text)
        If (dd = 10) Then
            'Do nothing
        Else
            MessageBox.Show("Phone number should be 10 digit ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StuPhoneTB.Clear()
        End If
    End Sub


    Private Sub StuFatherTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StuFatherTB.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub StuMotherTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StuMotherTB.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StuAgeTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StuAgeTB.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Plese Numbers < 100.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StuPINTB_Validated(sender As Object, e As EventArgs) Handles StuPINTB.Validated
        Dim dd As Integer
        dd = Len(StuPINTB.Text)
        If (dd = 6) Then
            'Do nothing
        Else
            MessageBox.Show("PIN number should be 6 digit ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StuPINTB.Clear()
        End If
    End Sub
End Class