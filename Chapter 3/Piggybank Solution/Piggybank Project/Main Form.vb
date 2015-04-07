' Name:         Piggy Bank
' Purpose:      Take input of amount of quarters,
'               nickels and dimes, and output
'               number of coins and total amount.
'Programmer:    Joshua Hipple
'Class:         CIS 230 - W1

Public Class frmName


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form

        txtQuarters.Text = String.Empty
        txtDimes.Text = String.Empty
        txtNickels.Text = String.Empty
        lblNumOfCoins.Text = String.Empty
        lblTotalAmount.Text = String.Empty
        lblMessageBox.Text = String.Empty
        txtQuarters.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Print screenshot of form as reciept

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Add total coins together as well as calculate total value of coins
        ' and Output to appropriate labels

        ' Initialize variables used
        Dim intQuarters As Integer = 0
        Dim intDimes As Integer = 0
        Dim intNickels As Integer = 0
        Dim intNumOfCoins As Integer = 0
        Dim decTotalValue As Decimal = 0

        ' Get values of text boxes, assign to variables
        Integer.TryParse(txtQuarters.Text, intQuarters)
        Integer.TryParse(txtDimes.Text, intDimes)
        Integer.TryParse(txtNickels.Text, intNickels)

        ' Calculate total coins and value
        intNumOfCoins = intQuarters + intDimes + intNickels
        decTotalValue = (intQuarters * 0.25) + (intDimes * 0.1) + (intNickels * 0.05)

        ' Output to text boxes.
        lblNumOfCoins.Text = Convert.ToString(intNumOfCoins)
        lblTotalAmount.Text = decTotalValue.ToString("C2")
    End Sub
End Class
