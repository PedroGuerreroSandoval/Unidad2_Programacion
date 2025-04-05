Imports System.Globalization

Public Class Form1
    Dim Num1 As Double
    Dim Num2 As Double
    Dim Resultado As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Num1 = Val(TextBox1.Text)
        Num2 = Val(TextBox2.Text)
        Label3.Text = Num1 + Num2



    End Sub
End Class
