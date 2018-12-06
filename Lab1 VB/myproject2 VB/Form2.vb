Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalsale, total1, comision1 As Double
        Dim totalsaleGluta, total2, comision2 As Double
        Dim sumcom As Double

        totalsaleGluta = txtGluta.Text
        totalsale = txt520x.Text

        total1 = totalsaleGluta + totalsale
        lbltotal.Text = total1

        comision1 = totalsaleGluta * 5 / 100
        comision2 = totalsale * 10 / 100
        sumcom = comision1 + comision2
        total2 = totalsaleGluta + totalsale

        lblcommision1.Text = comision1
        lblcomision2.Text = comision2
        totalcomision.Text = sumcom

    End Sub
End Class
