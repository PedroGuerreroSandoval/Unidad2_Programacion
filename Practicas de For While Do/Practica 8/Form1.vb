Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 1 To 5
            ListBox1.Items.Add(i)
        Next
    End Sub

End Class
