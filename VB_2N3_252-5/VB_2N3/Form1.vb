Public Class Form1

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'ค่าจ้าง = ชั่วโมงการทำงาน * อัตราค่าจ้าง
        'ชั่วโมงการทำงาน => txtHours.text
        'อัตราค่าจ้าง => txtPayRate.text
        '=> lblResult.text

        lblResult.Text = Val(txtHours.Text) * Val(txtPayRate.Text)
        lblResult.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
