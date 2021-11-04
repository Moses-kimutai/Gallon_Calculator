Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Gallons As Double
        Dim Miles As Double
        Dim Miles_Per_Gallon As Double
        Try
            Gallons = CDbl(TextBox1.Text)

        Catch ex As Exception
            MessageBox.Show("Number entered is not double, try again.")
        End Try

        Try
            Miles = CDbl(TextBox2.Text)
        Catch ex As Exception
            MessageBox.Show("Number entered is not double, try again.")
        End Try

        Miles_Per_Gallon = Miles / Gallons

        Label4.Text = Miles_Per_Gallon.ToString("n2")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
        Label4.ResetText()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
