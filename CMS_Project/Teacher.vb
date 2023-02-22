Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Teacher
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource

    Private Sub load_Data()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.faculties"
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
    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()
    End Sub
    Private Sub AddFacultyButton1_Click(sender As Object, e As EventArgs) Handles AddFacultyButton1.Click
        Dim facultyform1 As New AddFaculty
        facultyform1.ShowDialog()
    End Sub

    Private Sub LoadButton1_Click(sender As Object, e As EventArgs) Handles LoadButton1.Click
        dtable.Rows.Clear()
        dtable.Columns.Clear()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.faculties"
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
            Dim ef As New EditFaculty
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            ' UserID.Text = row.Cells("id").Value.ToString
            ef.FID.Text = row.Cells(0).Value.ToString
            ef.FFirstNameTB.Text = row.Cells(1).Value.ToString
            ef.FLastNameTB.Text = row.Cells(2).Value.ToString
            ef.FGenderComboBox.Text = row.Cells(3).Value.ToString
            ef.FDOBDateTimePicker.Text = row.Cells(4).Value.ToString
            ef.FAgeTB.Text = row.Cells(5).Value.ToString
            ef.FPhoneTB.Text = row.Cells(6).Value.ToString
            ef.FemailTB.Text = row.Cells(7).Value.ToString
            ef.FAddressTB.Text = row.Cells(8).Value.ToString
            ef.FCityTB.Text = row.Cells(9).Value.ToString
            ef.FStateTB.Text = row.Cells(10).Value.ToString
            ef.FPINCodeTB.Text = row.Cells(11).Value.ToString
            ef.FQualiTB.Text = row.Cells(12).Value.ToString
            ef.FExpTB.Text = row.Cells(13).Value.ToString
            ef.FsubjectTB.Text = row.Cells(14).Value.ToString
            ef.FPasswordTB.Text = row.Cells(16).Value.ToString
            ef.StatusComboBox.Text = row.Cells(17).Value.ToString
            Dim bytes As Byte() = DataGridView1.CurrentRow.Cells(15).Value
            Using ms As New IO.MemoryStream(bytes)
                ef.PictureBox1.Image = Image.FromStream(ms)
            End Using
            ef.ShowDialog()
        End If
    End Sub
End Class