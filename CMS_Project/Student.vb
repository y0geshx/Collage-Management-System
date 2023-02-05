Public Class Student
    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        Dim studentform1 As New AddStudent
        studentform1.ShowDialog()
    End Sub
End Class