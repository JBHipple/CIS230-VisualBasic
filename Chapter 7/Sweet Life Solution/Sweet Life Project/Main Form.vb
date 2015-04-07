Public Class frmMain

    Private Function FindDoughnut(ByVal strDoughnut As String) As Double
        ' Use strDoughnut to find and return correct price of Doughnut selected
        Dim dblPrice

        Select Case strDoughnut
            Case "G", "S"
                dblPrice = 0.65
            Case "C"
                dblPrice = 0.85
            Case "F"
                dblPrice = 1.0
        End Select

        Return dblPrice
    End Function

    Private Function FindCoffee(ByVal strCoffee As String) As Double
        ' Use strCoffee to find and return correct price of Coffee selected
        Dim dblPrice As Double

        Select Case strCoffee
            Case "N"
                dblPrice = 0.0
            Case "R"
                dblPrice = 1.8
            Case "C"
                dblPrice = 2.5
        End Select

        Return dblPrice
    End Function

    Private Function FindTax(ByVal dblSubTotal As Double, ByVal dblRate As Double) As Double
        ' Find the tax on the subtotal
        Dim dblTax As Double

        dblTax = dblSubTotal * dblRate

        Return dblTax
    End Function

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Verify the user wants to leave the application
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Sweet Life", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        ' If "no" was selected, don't close the form
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Set Default checked radio buttons
        radGlazed.Checked = True
        radNone.Checked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare Variales
        Const dblTAX_RATE As Double = 0.03
        Dim dblCoffee As Double
        Dim dblDoughnut As Double
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblTotal As Double
        Dim strDoughnut As String
        Dim strCoffee As String

        ' Determine which doughnut and which coffee were selected
        If radGlazed.Checked Then
            strDoughnut = "G"
        ElseIf radSugar.Checked Then
            strDoughnut = "S"
        ElseIf radChocolate.Checked Then
            strDoughnut = "C"
        Else
            strDoughnut = "F"
        End If
        If radNone.Checked Then
            strCoffee = "N"
        ElseIf radRegular.Checked Then
            strCoffee = "R"
        Else
            strCoffee = "C"
        End If

        ' Find Price of doughnut and coffee selected
        dblDoughnut = FindDoughnut(strDoughnut)
        dblCoffee = FindCoffee(strCoffee)

        ' Calculate the subtotal
        dblSubTotal = dblDoughnut + dblCoffee

        ' Calculate the tax
        dblTax = FindTax(dblSubTotal, dblTAX_RATE)

        ' Calculate the total
        dblTotal = dblSubTotal + dblTax

        ' Display the results
        lblSubtotal.Text = dblSubTotal.ToString("C2")
        lblTax.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles radCappuccino.CheckedChanged,
                                                                      radChocolate.CheckedChanged,
                                                                      radFilled.CheckedChanged,
                                                                      radGlazed.CheckedChanged,
                                                                      radNone.CheckedChanged,
                                                                      radRegular.CheckedChanged,
                                                                      radSugar.CheckedChanged
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
