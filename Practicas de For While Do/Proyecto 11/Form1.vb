Public Class Form1
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        Dim x1 As Double = 1
        While x1 <= 10
            ListBox1.Items.Add(x1)
            Dim fx As Double = x1 / (1.0 + x1 * x1)
            ListBox2.Items.Add(fx)
            x1 += 1
        End While
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        Dim x2 As Double = 1
        Do
            ListBox1.Items.Add(x2)
            Dim fx As Double = x2 / (1.0 + x2 * x2)
            ListBox2.Items.Add(fx)
            x2 += 1
        Loop While x2 <= 10
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        Dim x As Double
        For x = 1 To 10
            ListBox1.Items.Add(x)
            Dim fx As Double = x / (1.0 + x * x)
            ListBox2.Items.Add(fx)
        Next
    End Sub

    Private Sub buttonSalir_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class
