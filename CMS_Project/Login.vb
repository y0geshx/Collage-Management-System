Imports System.Windows.Controls
Imports MySql.Data.MySqlClient
Public Class Login
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=cmsdbx")
    Private Sub LoginButton1_Click(sender As Object, e As EventArgs) Handles LoginButton1.Click
        'If Username1.Text = "" Or Password1.Text = "" Then
        'MsgBox("Enter Username and Password")

        'ElseIf Username1.Text = "admin" And Password1.Text = "password" Then
        'Dim obj = New Students
        'obj.Show()
        'Me.Hide()
        'Else
        'MsgBox("Wrong Username or Password")
        'Username1.Text = ""
        'Password1.Text = ""
        'End If
        objdatapter = New MySqlDataAdapter("select username,password from users where username='" & Username1.Text & "' AND password='" & Password1.Text & "'", myconnection.open)
        dtable.Clear()
        objdatapter.Fill(dtable)
        If Username1.Text = "" Or Password1.Text = "" Then
            MsgBox("Enter Username and Password ! ")
        ElseIf dtable.Rows.Count = Nothing Then
            MsgBox("Invalid Username or Password !")
        Else
            Dim obj = New Dashboard
            obj.Show()
            Me.Hide()
        End If
        myconnection.close()

    End Sub
    Private Sub Resetme_Click(sender As Object, e As EventArgs) Handles Resetme.Click
        Username1.Text = ""
        Password1.Text = ""
    End Sub

    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Showpass.CheckedChanged
        If Showpass.Checked = True Then
            Password1.UseSystemPasswordChar = False
        Else
            Password1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginAsFaculty_Click(sender As Object, e As EventArgs) Handles LoginAsFaculty.Click
        Dim obj = New FacultyLogin
        obj.Show()
        Me.Hide()
    End Sub
End Class
