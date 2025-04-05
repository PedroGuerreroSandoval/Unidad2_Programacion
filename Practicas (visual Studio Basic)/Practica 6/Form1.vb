Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v1, farh1 As Double
        v1 = Double.Parse(TextBox1.Text)
        farh1 = (v1 * 9.0 / 5.0) + 32
        TextBox2.Text = farh1.ToString()
        Label2.Text = "Fahrenheit"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim v1, cent1 As Double
        v1 = Double.Parse(TextBox1.Text)
        cent1 = (v1 - 32) * (5.0 / 9.0)
        TextBox2.Text = cent1.ToString()
        Label2.Text = "Centígrados"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label2.Text = "Grados:"
    End Sub
End Class

