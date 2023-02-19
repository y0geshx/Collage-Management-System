Imports MySql.Data.MySqlClient

Public Class Student
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource

    Private Sub load_Data()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.students"
            'query = "SELECT facultyid as 'Faculty ID',facultyfirstname as 'First Name', facultylastname as 'Last Name', gender as 'Gender', dob as 'Date of Birth', age as 'Age', contactnumber as 'Phone Number', emailid as 'Email ID', address as 'Address', city as 'City', state as 'State', qualification as 'Qualification', experience as 'Experience' , profilepic as 'Photo', activestatus as 'Status', joindate as 'Joined Date' FROM cmsdbx.faculties"
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
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()

    End Sub
    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        Dim studentform1 As New AddStudent
        studentform1.ShowDialog()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        dtable.Rows.Clear()
        dtable.Columns.Clear()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.students"
            'query = "SELECT facultyid as 'Faculty ID',facultyfirstname as 'First Name', facultylastname as 'Last Name', gender as 'Gender', dob as 'Date of Birth', age as 'Age', contactnumber as 'Phone Number', emailid as 'Email ID', address as 'Address', city as 'City', state as 'State', qualification as 'Qualification', experience as 'Experience' , profilepic as 'Photo', activestatus as 'Status', joindate as 'Joined Date' FROM cmsdbx.faculties"
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
            Dim current_row As Integer = DataGridView1.CurrentRow.Index
            Dim es As New EditStudent
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            ' UserID.Text = row.Cells("id").Value.ToString
            es.SID.Text = row.Cells(0).Value.ToString
            es.StuFirstNameTB.Text = row.Cells(1).Value.ToString
            es.StuLastNameTB.Text = row.Cells(2).Value.ToString
            es.StuGenderCB.Text = row.Cells(3).Value.ToString
            es.StuDateTimePicker.Text = row.Cells(4).Value.ToString
            es.StuAgeTB.Text = row.Cells(5).Value.ToString
            es.StuFatherTB.Text = row.Cells(6).Value.ToString
            es.StuMotherTB.Text = row.Cells(7).Value.ToString
            es.StuPhoneTB.Text = row.Cells(8).Value.ToString
            es.StuEmaliTB.Text = row.Cells(9).Value.ToString
            es.StuAddressTB.Text = row.Cells(10).Value.ToString
            es.StuCityTB.Text = row.Cells(11).Value.ToString
            es.StuStateTB.Text = row.Cells(12).Value.ToString
            es.StuPINTB.Text = row.Cells(13).Value.ToString
            es.CourseTB.Text = row.Cells(15).Value.ToString
            es.StuAdmissionTB.Text = row.Cells(16).Value.ToString
            es.StatusComboBox.Text = row.Cells(17).Value.ToString
            Dim bytes As Byte() = DataGridView1.CurrentRow.Cells(14).Value
            Using ms As New IO.MemoryStream(bytes)
                es.PictureBox1.Image = Image.FromStream(ms)
            End Using
            es.ShowDialog()
        End If
    End Sub
End Class