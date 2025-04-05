Public Class Form1
    Private Sub Decision_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lado1, lado2, lado3 As Double

        lado1 = Double.Parse(TextBox1.Text)
        lado2 = Double.Parse(TextBox2.Text)
        lado3 = Double.Parse(TextBox3.Text)

        If (lado1 = lado2) And (lado2 = lado3) Then
            TextBox4.Text = "Equilátero"
        ElseIf (lado1 = lado2) Or (lado1 = lado3) Or (lado2 = lado3) Then
            TextBox4.Text = "Isósceles"
        Else
            TextBox4.Text = "Escaleno"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class

