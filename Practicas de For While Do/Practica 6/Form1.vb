Public Class Form1
    Private Sub BtnVerifica_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer = Integer.Parse(TextBox1.Text)

        If numero Mod 2 = 0 Then
            ListBox1.Items.Add(numero & " Par")
        Else
            ListBox1.Items.Add(numero & " Impar")
        End If

        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

End Class
