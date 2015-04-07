' Name:         Timbers Project
' Purpose:      Calculates 20% discount on original price
' Programmer:   Joshua Hipple
' Class:        CIS230 - W1
Public Class timbersForm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application when clicked
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear Original Price text box, and Discount and New Price labels
        txtPrice.Text = String.Empty
        lblDiscountAmount.Text = String.Empty
        lblNewPriceAmount.Text = String.Empty
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Print the reciept

        ' Resize form and remove border
        Me.Width = Me.Width - 125
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ' Print to Preview
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        ' Restore form size and border
        Me.Width = Me.Width + 125
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate discount and apply to price

        ' Calculate discount
        lblDiscountAmount.Text = Val(txtPrice.Text) * 0.2
        ' Subtract discount from price
        lblNewPriceAmount.Text = Val(txtPrice.Text) - Val(lblDiscountAmount.Text)
        ' Format labels to proper display
        lblDiscountAmount.Text = Format(lblDiscountAmount.Text, "Standard")
        lblNewPriceAmount.Text = Format(lblNewPriceAmount.Text, "Standard")

    End Sub
End Class
