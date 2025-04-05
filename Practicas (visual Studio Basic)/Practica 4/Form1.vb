Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim radio, altura As Double
        Dim Basearea, Lateralarea, Totalarea As Double
        Dim volumen As Double

        radio = Val(TextBox1.Text)
        altura = Val(TextBox2.Text)

        Basearea = radio * radio * Math.PI
        Lateralarea = 2 * Math.PI * radio * altura
        Totalarea = 2 * Math.PI * radio * (altura + radio)
        volumen = Math.PI * radio * radio * altura

        TextBox3.Text = Basearea
        TextBox4.Text = Lateralarea
        TextBox5.Text = Totalarea
        TextBox6.Text = volumen

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub
End Class
