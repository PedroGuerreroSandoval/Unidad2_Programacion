Public Class Form1
    Private Sub BotonImprime_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rangoInferior As Integer
        Dim rangoSuperior As Integer
        Dim suma As Integer = 0

        rangoInferior = Integer.Parse(TextBox1.Text)
        rangoSuperior = Integer.Parse(TextBox2.Text)

        For i As Integer = rangoInferior To rangoSuperior
            ListBox1.Items.Add(i)
            suma += i
        Next

        TextBox3.Text = suma.ToString()
    End Sub

End Class
