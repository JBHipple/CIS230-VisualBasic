' Name:         Marshall Sales Corporation
' Purpose:      Take input of sales amount and
'               calculate commission as well as
'               travel and veteran bonuses
'Programmer:    Joshua Hipple
'Class:         CIS 230 - W1
Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate total commission and bonuses

        ' Declare named constants and variables
        Const intTEN_YEARS As Integer = 500
        Const intTRAVELER As Integer = 700
        Dim decSales As Decimal
        Dim decCommission As Decimal
        Dim decTotal As Decimal

        ' Get sales amount
        Decimal.TryParse(txtSales.Text, decSales)

        ' Calculate raw commission
        Select Case decSales
            Case 1 To 100000.99
                decCommission = decSales * 0.02
            Case 100001 To 400000.99
                decCommission = 2000 + ((decSales - 100000) * 0.05)
            Case Is >= 400001
                decCommission = 17000 + ((decSales - 400000) * 0.1)
            Case Else
                decCommission = 0
        End Select

        ' Determine if 10 year or traveler bonuses should be added
        If chkTenYears.Checked Then
            decCommission = decCommission + intTEN_YEARS
        End If
        If chkTraveling.Checked Then
            decCommission = decCommission + intTRAVELER
        End If

        ' Output comission to message box, formatted to currency
        lblTotalCommission.Text = decCommission.ToString("C2")

        ' Send focus back to txtSales
        txtSales.Focus()
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        ' Highlight all text in txtSales when entered

        txtSales.SelectAll()
    End Sub
End Class
