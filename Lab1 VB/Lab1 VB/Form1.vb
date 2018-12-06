Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Dim salary, tax, total
        salary = Val(txtsalary.Text) * 12
        tax = salary * 5 / 100
        total = salary - tax
        lblsalary.Text = salary
        lbltotaltax.Text = tax
        lbltotal.Text = total
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btncal2_Click(sender As Object, e As EventArgs)


    End Sub
End Class
