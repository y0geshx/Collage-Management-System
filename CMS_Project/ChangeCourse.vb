
Imports CMS_Project.MemoryStream
Imports MySql.Data.MySqlClient

Public Class ChangeCourse
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
                CourseCB1.Items.Add(sName)
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ChangeCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentID.Text = stuid
        StuNameTB.Text = stuname
        Course_load()
        StudentID.Enabled = False
        StuNameTB.Enabled = False
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If StudentID.Text = "" Or
             StuNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Update the Record !", "Record Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "update students set coursename='" & CourseCB1.Text & "' where studentid='" & StudentID.Text & "'"
                    'Dim query = "update students set studentid='" & SID.Text & "',firstname='" & StuFirstNameTB.Text & "', lastname='" & StuLastNameTB.Text & "', gender='" & StuGenderCB.Text & "', dob='" & StuDateTimePicker.Text & "', age='" & StuAgeTB.Text & "', fathername='" & StuFatherTB.Text & "', mothername='" & StuMotherTB.Text & "', contactnumber='" & StuPhoneTB.Text & "', emailid='" & StuEmaliTB.Text & "', address='" & StuAddressTB.Text & "', city='" & StuCityTB.Text & "', state='" & StuStateTB.Text & "', pincode='" & StuPINTB.Text & "', coursename='" & CourseTB.Text & "', admissiondate='" & StuAdmissionTB.Text & "',activestatus='" & StatusComboBox.Text & "' where facultyid='" & SID.Text & "'"
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

End Class