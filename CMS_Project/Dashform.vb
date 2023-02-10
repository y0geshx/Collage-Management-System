Imports MySql.Data.MySqlClient

Public Class Dashform
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
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

    Private Sub Dashform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Facutly_Count()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateLabel.Text = DateTime.Now.ToString()
    End Sub


End Class