Public Class Form1

    Dim f_num As Single
    Dim Total As Single = 0

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Total.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(TextBox1.Text)
        f_num = Single.Parse(TextBox1.Text)
        Total += f_num
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

End Class

