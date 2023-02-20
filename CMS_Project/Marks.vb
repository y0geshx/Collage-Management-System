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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim vm As New ViewMarks
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            vm.StudentID.Text = row.Cells(0).Value.ToString
            vm.StuNameTB.Text = row.Cells(1).Value.ToString
            vm.stuLastNameTB.Text = row.Cells(2).Value.ToString
            vm.CourseTB.Text = row.Cells(3).Value.ToString
            vm.SemorYear.Text = row.Cells(4).Value.ToString

            vm.SubTB1.Text = row.Cells(5).Value.ToString
            vm.SubTMax1.Text = row.Cells(6).Value.ToString
            vm.SubOMarks1.Text = row.Cells(7).Value.ToString
            vm.SubPMax1.Text = row.Cells(8).Value.ToString
            vm.SubOPMarks1.Text = row.Cells(9).Value.ToString

            vm.SubTB2.Text = row.Cells(10).Value.ToString
            vm.SubTMax2.Text = row.Cells(11).Value.ToString
            vm.SubOMarks2.Text = row.Cells(12).Value.ToString
            vm.SubPMax2.Text = row.Cells(13).Value.ToString
            vm.SubOPMarks2.Text = row.Cells(14).Value.ToString

            vm.SubTB3.Text = row.Cells(15).Value.ToString
            vm.SubTMax3.Text = row.Cells(16).Value.ToString
            vm.SubOMarks3.Text = row.Cells(17).Value.ToString
            vm.SubPMax3.Text = row.Cells(18).Value.ToString
            vm.SubOPMarks3.Text = row.Cells(19).Value.ToString

            vm.SubTB4.Text = row.Cells(20).Value.ToString
            vm.SubTMax4.Text = row.Cells(21).Value.ToString
            vm.SubOMarks4.Text = row.Cells(22).Value.ToString
            vm.SubPMax4.Text = row.Cells(23).Value.ToString
            vm.SubOPMarks4.Text = row.Cells(24).Value.ToString

            vm.SubTB5.Text = row.Cells(25).Value.ToString
            vm.SubTMax5.Text = row.Cells(26).Value.ToString
            vm.SubOMarks5.Text = row.Cells(27).Value.ToString
            vm.SubPMax5.Text = row.Cells(28).Value.ToString
            vm.SubOPMarks5.Text = row.Cells(29).Value.ToString

            vm.SubTB6.Text = row.Cells(30).Value.ToString
            vm.SubTMax6.Text = row.Cells(31).Value.ToString
            vm.SubOMarks6.Text = row.Cells(32).Value.ToString
            vm.SubPMax6.Text = row.Cells(33).Value.ToString
            vm.SubOPMarks6.Text = row.Cells(34).Value.ToString

            vm.TotalTheory.Text = row.Cells(35).Value.ToString
            vm.TotalObtainMarks.Text = row.Cells(36).Value.ToString
            vm.TotalPractical.Text = row.Cells(37).Value.ToString
            vm.TotalObtinedPMarks.Text = row.Cells(38).Value.ToString

            vm.ShowDialog()
        End If
    End Sub


End Class