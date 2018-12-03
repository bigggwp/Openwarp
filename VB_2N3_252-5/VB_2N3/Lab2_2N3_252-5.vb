Public Class Lab2_2N3_252_5

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim SaleVG As Double = txtSaleVG.Text
        Dim SaleFG As Double = txtSaleFG.Text
        Dim Com5 As Double = SaleVG * 0.05
        Dim Com10 As Double = SaleFG * 0.1
        Dim TotalSale As Double = SaleVG + SaleFG
        Dim TotalCom As Double = Com5 + Com10
        lblCom5.Text = Com5
        lblCom10.Text = Com10
        lblSales.Text = TotalSale
        lblCom.Text = TotalCom

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class