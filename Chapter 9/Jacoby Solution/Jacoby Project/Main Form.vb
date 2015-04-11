' Name:         Jacoby Project
' Purpose:      Displays a grade based on the number of points the user enters
' Programmer:   Joshua Hipple on 4/10/15
' Class:        CIS 230 - W1

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Declare array of ranges
    Dim intPoints() As Integer = {0, 300, 350, 400, 450}
    Dim strGrades() As String = {"F", "D", "C", "B", "A"}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPoints_Enter(sender As Object, e As EventArgs) Handles txtPoints.Enter
        txtPoints.SelectAll()
    End Sub

    Private Sub txtPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoints.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPoints_TextChanged(sender As Object, e As EventArgs) Handles txtPoints.TextChanged
        lblGrade.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Declare variables
        Dim intGradesIn As Integer
        Dim strLetterGrade As String

        ' Take input and assign to variable
        Integer.TryParse(txtPoints.Text, intGradesIn)

        ' Find which range the grade falls in, and assign the grade based in the corresponding
        ' index of strGrades.  This allows easy changing of the grades range in the class level arrays.
        Select Case intGradesIn
            Case intPoints(0) To (intPoints(1) - 1)
                strLetterGrade = strGrades(0)
            Case intPoints(1) To (intPoints(2) - 1)
                strLetterGrade = strGrades(1)
            Case intPoints(2) To (intPoints(3) - 1)
                strLetterGrade = strGrades(2)
            Case intPoints(3) To (intPoints(4) - 1)
                strLetterGrade = strGrades(3)
            Case Is >= intPoints(4)
                strLetterGrade = strGrades(4)
        End Select

        ' Output the result to lblGrade
        lblGrade.Text = strLetterGrade

        ' Highlight the textbox to make entering a new value faster and easier.
        txtPoints.SelectAll()
    End Sub
End Class
