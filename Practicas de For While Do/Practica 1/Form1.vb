Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 0

        Do
            ListBox1.Items.Add(x)
            x += 1
        Loop While x <= 10
    End Sub
End Class
