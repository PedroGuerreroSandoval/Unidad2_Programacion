Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer = Integer.Parse(TextBox1.Text)
        Dim factorial As Integer = 1

        For i As Integer = 1 To numero
            ListBox1.Items.Add(i)
            factorial *= i
        Next

        TextBox2.Text = numero.ToString()
        TextBox3.Text = factorial.ToString()
    End Sub
End Class
