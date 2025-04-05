Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = 1
        While a <= 20
            ListBox1.Items.Add(a)
            a += 1
        End While
    End Sub
End Class
