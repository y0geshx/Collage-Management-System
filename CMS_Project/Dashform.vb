Public Class Dashform
    Private Sub Dashform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateLabel.Text = DateTime.Now.ToString()
    End Sub


End Class