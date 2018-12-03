Public Class Lab1_2N3_252_5


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim s As Double = txtSalary.Text * 12
        lblSalary.Text = s
        lblTax.Text = s * 0.05
        lblResult.Text = Val(s) - Val(lblTax.Text)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class