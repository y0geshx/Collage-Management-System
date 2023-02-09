Imports MySql.Data.MySqlClient

Public Class Teacher
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource

    Private Sub load_Data()
        Try
            Dim query As String
            query = "SELECT facultyid as 'Faculty ID',facultyfirstname as 'First Name', facultylastname as 'Last Name', gender as 'Gender', dob as 'Date of Birth', age as 'Age', contactnumber as 'Phone Number', emailid as 'Email ID', address as 'Address', city as 'City', state as 'State', qualification as 'Qualification', experience as 'Experience' , profilepic as 'Photo', activestatus as 'Status', joindate as 'Joined Date' FROM cmsdbx.faculties"
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
    Private Sub ddFacultyButton1_Click(sender As Object, e As EventArgs) Handles AddFacultyButton1.Click
        Dim facultyform1 As New AddFaculty
        facultyform1.ShowDialog()
    End Sub

    Private Sub LoadButton1_Click(sender As Object, e As EventArgs) 
        dtable.Rows.Clear()
        dtable.Columns.Clear()

        Try
            Dim query As String
            query = "SELECT facultyid as 'Faculty ID',facultyfirstname as 'First Name', facultylastname as 'Last Name', gender as 'Gender', dob as 'Date of Birth', age as 'Age', contactnumber as 'Phone Number', emailid as 'Email ID', address as 'Address', city as 'City', state as 'State', qualification as 'Qualification', experience as 'Experience' , profilepic as 'Photo', activestatus as 'Status', joindate as 'Joined Date' FROM cmsdbx.faculties"
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

End Class