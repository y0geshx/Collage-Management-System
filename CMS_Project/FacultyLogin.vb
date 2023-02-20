Imports System.Windows.Controls
Imports MySql.Data.MySqlClient
Public Class FacultyLogin
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable

    Private Sub LoginButton2_Click(sender As Object, e As EventArgs) Handles LoginButton2.Click
        objdatapter = New MySqlDataAdapter("select facultyfirstname,password from faculties where facultyfirstname='" & Username2.Text & "' AND password='" & Password2.Text & "'", myconnection.open)
        dtable.Clear()
        objdatapter.Fill(dtable)
        If Username2.Text = "" Or Password2.Text = "" Then
            MsgBox("Enter Username and Password ! ")
        ElseIf dtable.Rows.Count = Nothing Then
            MsgBox("Invalid Username or Password !")
        Else
            Dim obj = New FacultyDashBoard
            obj.Show()
            Me.Hide()
        End If
        myconnection.close()
    End Sub
    Private Sub Resetme_Click(sender As Object, e As EventArgs) Handles Resetme.Click
        Username2.Text = ""
        Password2.Text = ""
    End Sub

    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Showpass.CheckedChanged
        If Showpass.Checked = True Then
            Password2.UseSystemPasswordChar = False
        Else
            Password2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginAsAdmin_Click(sender As Object, e As EventArgs) Handles LoginAsAdmin.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub


End Class