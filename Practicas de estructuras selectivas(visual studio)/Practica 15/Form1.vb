Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sueldo, nsue
        sueldo = Double.Parse(TextBox1.Text)
        If (sueldo < 400000.0) Then nsue = sueldo * 1.15 Else nsue = sueldo * 1.08
        TextBox2.Text = nsue.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
