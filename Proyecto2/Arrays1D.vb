﻿Public Class Arrays1D
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num() As Integer = {1, 2, -4}
        Dim i As Integer
        Dim n, n2, n3 As String

        For i = 0 To 2
            n = num(i).ToString
            n2 = (Math.Pow(num(i), 2)).ToString
            n3 = (Math.Pow(num(i), 3)).ToString
            TextBox1.Text += n + ", " + n2 + ", " + n3 + vbNewLine
        Next
    End Sub
End Class