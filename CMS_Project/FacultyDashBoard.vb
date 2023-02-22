Imports System.Threading

Public Class FacultyDashBoard
    Private Sub StudentButton_Click(sender As Object, e As EventArgs) Handles StudentButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Student
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Student)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Students"
        Dim obj As New Student
        obj.AddStudentButton.Visible = False
    End Sub

    Private Sub AttendanceButton_Click(sender As Object, e As EventArgs) Handles AttendanceButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Attandance
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Attandance)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Attandance"
    End Sub

    Private Sub MarksButton_Click(sender As Object, e As EventArgs) Handles MarksButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Marks
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Marks)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Marks"
    End Sub

    Private Sub EmailButton_Click(sender As Object, e As EventArgs) Handles EmailButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With EmailWeb
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(EmailWeb)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Email"
    End Sub
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to logout", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = Windows.Forms.DialogResult.Yes Then
            End
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateLabel2.Text = DateTime.Now.ToString()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub FacultyDashBoard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want close the app !", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub


End Class