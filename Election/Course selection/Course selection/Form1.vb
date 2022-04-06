Public Class Form1
    Private Sub cmdRating_Click(sender As Object, e As EventArgs) Handles cmdRating.Click

        Dim Score As Integer
        Score = txtScore.Text
        Select Case Score
            Case 0 To 49
                txtRating.Text = "Below Average"
            Case 50 To 59
                txtRating.Text = "Above Average"
            Case 60 To 69
                txtRating.Text = "Good Performance"
            Case Else
                txtRating.Text = "Distinction"

        End Select

    End Sub
End Class
