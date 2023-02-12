Imports MySql.Data.MySqlClient

Public Class Dashform
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable

    Private Sub Student_Count()
        Dim StuNum As String
        Dim query As String
        query = "SELECT COUNT(*) FROM  cmsdbx.students"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(query, myconnection.open)
        StuNum = cmd.ExecuteScalar
        StuCount.Text = StuNum
        myconnection.close()
    End Sub
    Private Sub Facutly_Count()
        Dim FacNum As String
        Dim query As String
        query = "SELECT COUNT(*) FROM  cmsdbx.faculties"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(query, myconnection.open)
        FacNum = cmd.ExecuteScalar
        FacCount.Text = FacNum
        myconnection.close()
    End Sub
    Private Sub Course_Count()
        Dim CouNum As String
        Dim query As String
        query = "SELECT COUNT(*) FROM  cmsdbx.courses"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(query, myconnection.open)
        CouNum = cmd.ExecuteScalar
        CouCount.Text = CouNum
        myconnection.close()
    End Sub
    Private Sub Subject_Count()
        Dim SubNum As String
        Dim query As String
        query = "SELECT COUNT(*) FROM  cmsdbx.subject"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(query, myconnection.open)
        SubNum = cmd.ExecuteScalar
        SubCount.Text = SubNum
        myconnection.close()
    End Sub
    Private Sub User_Count()
        Dim UserNum As String
        Dim query As String
        query = "SELECT COUNT(*) FROM  cmsdbx.users"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(query, myconnection.open)
        UserNum = cmd.ExecuteScalar
        UserCount.Text = UserNum
        myconnection.close()
    End Sub
    Private Sub Dashform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Student_Count()
        Facutly_Count()
        Course_Count()
        Subject_Count()
        User_Count()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateLabel.Text = DateTime.Now.ToString()
    End Sub


End Class