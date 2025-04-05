Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim count As Integer = 0
        Dim limite As Integer
        If Integer.TryParse(TextBox1.Text, n) AndAlso Integer.TryParse(TextBox2.Text, limite) Then
            Do While count < limite
                ListBox1.Items.Add(n & " x " & count & " = " & (n * count))
                count += 1
            Loop
        Else
        End If
    End Sub
End Class
