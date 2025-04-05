Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim cua As Integer
        Dim cub As Integer
        Dim zeta As Integer

        For i = 1 To 50
            cua = i * i
            cub = i * i * i
            zeta = cua + cub

            ListBox1.Items.Add(i)
            ListBox2.Items.Add(cua)
            ListBox3.Items.Add(cub)
            ListBox4.Items.Add(zeta)
        Next
    End Sub

End Class
