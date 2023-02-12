Imports System.Threading
Imports Mysqlx.XDevAPI.Common

Public Class Dashboard
    Private Sub DashBoardButton_Click(sender As Object, e As EventArgs) Handles DashBoardButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Dashform
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Dashform)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Dashbord"
    End Sub
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
    End Sub

    Private Sub TeacherButton_Click(sender As Object, e As EventArgs) Handles TeacherButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Teacher
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Teacher)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Faculty"
    End Sub
    Private Sub CourseButton_Click(sender As Object, e As EventArgs) Handles CourseButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Courses
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Courses)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Cources"
    End Sub

    Private Sub SubjectButton_Click(sender As Object, e As EventArgs) Handles SubjectButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Subject
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Subject)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Subjects"
    End Sub


    Private Sub EmailButton_Click(sender As Object, e As EventArgs) Handles EmailButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Search
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Search)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Email"
    End Sub
    Private Sub AddUsersButton_Click(sender As Object, e As EventArgs) Handles AddUsersButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With AddUsers
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(AddUsers)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Add Users"
    End Sub
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With AboutBox1
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(AboutBox1)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "About"
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DateLabel2.Text = DateTime.Now.ToString()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want close the app !", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    '' Private Sub MainPanal_Scroll(sender As Object, e As ScrollEventArgs) Handles MainPanal.Scroll
    ''If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
    ''      MainPanal.VerticalScroll.Value = e.NewValue
    ''End If
    ''If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
    ''      MainPanal.HorizontalScroll.Value = e.NewValue
    ''End If
    ''End Sub
End Class