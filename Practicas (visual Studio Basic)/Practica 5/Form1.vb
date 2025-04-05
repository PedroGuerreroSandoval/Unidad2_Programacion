Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim base, altura, area, are As Single
        base = TextBox1.Text
        altura = TextBox2.Text
        area = base * altura / 2
        TextBox3.Text = area
    End Sub
End Class
