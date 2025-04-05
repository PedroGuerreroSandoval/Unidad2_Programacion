Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cal
        cal = Double.Parse(TextBox1.Text)
        If (Cal < 3.0) Then MessageBox.Show("Reprobado")
    End Sub
End Class
