
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer

        numero = Integer.Parse(TextBox1.Text)

        If (numero Mod 2 = 0) Then
            MessageBox.Show("EL NUMERO ES PAR")
        ElseIf (numero Mod 3 = 0) Then
            MessageBox.Show("EL NUMERO ES IMPAR Y DIVISIBLE POR 3")
        Else
            MessageBox.Show("EL NUMERO ES IMPAR")
        End If
    End Sub
End Class

