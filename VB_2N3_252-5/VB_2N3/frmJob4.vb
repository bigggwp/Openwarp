Public Class frmJob4

    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS As Double = 0.2
        Dim decR_ALLOW As Double = 0.01
        Dim decR_TAX As Double = 0.07
        Dim dblYearSalary As Double
        Dim dblBonus As Double
        Dim dblAllIncome As Double
        Dim dblAllowance As Double
        Dim dblTax As Double

        dblYearSalary = Val(txtSalary.Text * 12)
        dblBonus = Val(txtSale.Text * decR_BONUS)
        dblAllIncome = Val(dblYearSalary + dblBonus)
        dblAllowance = Val(dblAllIncome * decR_ALLOW)
        dblTax = Val(dblAllIncome - dblAllowance) * decR_TAX


        lblYearSalary.Text = Val(dblYearSalary)
        lblBonus.Text = Val(dblBonus)
        lblAllIncome.Text = Val(dblAllIncome)
        lblAllowance.Text = Val(dblAllowance)
        lblTax.Text = Val(dblTax)




    End Sub




    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = Date.Now

    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Date.Now.ToLongDateString
    End Sub


End Class