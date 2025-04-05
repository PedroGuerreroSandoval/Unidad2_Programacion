Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cal
        cal = Double.Parse(TextBox1.Text)
        If (cal < 3.0) Then MessageBox.Show("REPROBADO") Else MessageBox.Show("APROBADO")
    End Sub
End Class
