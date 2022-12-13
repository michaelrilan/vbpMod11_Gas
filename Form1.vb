Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input_val As Double
        Dim totall As Double
        input_val = input_usd.Text

        totall = input_val * 0.76 / 3.79

        results.Text = "The price of gas in CAD/liter is " & totall
    End Sub
End Class
