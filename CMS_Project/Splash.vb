Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadingBar1.Increment(1)
        If LoadingBar1.Value = 100 Then
            Me.Hide()
            Dim log = New FacultyLogin
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub LoadingBar1_ValueChanged(sender As Object, e As EventArgs) Handles LoadingBar1.ValueChanged

    End Sub
End Class
