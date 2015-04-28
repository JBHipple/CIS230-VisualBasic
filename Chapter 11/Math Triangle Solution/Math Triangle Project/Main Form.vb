' Name:         Triangle Project
' Purpose:      Displays a grade based on the number of points the user enters
' Programmer:   Joshua Hipple on 4/28/15
' Class:        CIS 230 - W1
Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application

        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare the variables
        Dim dblAnswer As Double
        Dim theTriangle As New Triangle

        ' Prompt user for base and height, assign to variables
        theTriangle.Base = InputBox("Enter the base", "Triangle Base")
        theTriangle.Height = InputBox("Enter the height", "Triangle Height")

        ' Determine which radio button clicked, perform corresponding calculation
        If rdoArea.Checked Then
            dblAnswer = theTriangle.GetArea
        Else
            dblAnswer = theTriangle.GetPerimeter
        End If

        ' Assign answer to label
        lblAnswer.Text = dblAnswer.ToString("N2")
    End Sub
End Class
