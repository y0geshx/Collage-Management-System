Imports MySql.Data.MySqlClient

Public Class Marks
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource

    Private Sub load_Data()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.marks"
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
    Private Sub Marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data()
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        dtable.Rows.Clear()
        dtable.Columns.Clear()
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.marks"
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

    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        Dim Marksform1 As New EnterMarks
        Marksform1.ShowDialog()
    End Sub
End Class