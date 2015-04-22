' Name:         Glovers Project
' Purpose:      Displays the price of an item
' Programmer:   Joshua Hipple on 4-17-2015
' Course:       CIS 230 - W1

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Structure Product
        Public strNumber As String
        Public dblPrice As Double
    End Structure

    Public productsList(4) As Product

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim inFile As IO.StreamReader
        Dim strPriceIn As String
        Dim strNumberIn As String


        If IO.File.Exists("ItemInfo.txt") Then
            inFile = IO.File.OpenText("ItemInfo.txt")
            For intIndex As Integer = 0 To 4
                strNumberIn = inFile.ReadLine
                productsList(intIndex).strNumber = strNumberIn
                strPriceIn = inFile.ReadLine
                Double.TryParse(strPriceIn, productsList(intIndex).dblPrice)
                lstNumbers.Items.Add(productsList(intIndex).strNumber)
            Next
        Else
            MessageBox.Show("File not found", "Glovers Industries", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lstNumbers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNumbers.SelectedIndexChanged
        Dim intIndex As Integer
        Dim strOutput As String

        intIndex = lstNumbers.SelectedIndex
        strOutput = productsList(intIndex).dblPrice.ToString("C2")

        lblPrice.Text = strOutput
    End Sub
End Class
