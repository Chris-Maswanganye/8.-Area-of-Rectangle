Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim L As Double
        Dim H As Double
        Dim A As Double

        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)

        A = L * H
        TextBox3.Text = A

    End Sub
End Class
