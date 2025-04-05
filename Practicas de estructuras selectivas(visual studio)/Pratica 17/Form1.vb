Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declaración de variables
        Dim A, B, C As Integer

        ' Obtener valores de los TextBox
        A = Integer.Parse(TextBox1.Text)
        B = Integer.Parse(TextBox2.Text)
        C = Integer.Parse(TextBox3.Text)

        ' Ordenar los números de mayor a menor
        If (A > B) Then
            If (B > C) Then
                TextBox4.Text = A.ToString()
                TextBox5.Text = B.ToString()
                TextBox6.Text = C.ToString()
            Else
                If (A > C) Then
                    TextBox4.Text = A.ToString()
                    TextBox5.Text = C.ToString()
                    TextBox6.Text = B.ToString()
                Else
                    TextBox4.Text = C.ToString()
                    TextBox5.Text = A.ToString()
                    TextBox6.Text = B.ToString()
                End If
            End If
        Else
            If (B > C) Then
                If (A > C) Then
                    TextBox4.Text = B.ToString()
                    TextBox5.Text = A.ToString()
                    TextBox6.Text = C.ToString()
                Else
                    TextBox4.Text = B.ToString()
                    TextBox5.Text = C.ToString()
                    TextBox6.Text = A.ToString()
                End If
            Else
                TextBox4.Text = C.ToString()
                TextBox5.Text = B.ToString()
                TextBox6.Text = A.ToString()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub
End Class

