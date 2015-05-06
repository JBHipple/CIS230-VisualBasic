' Name:         College Courses Project
' Purpose:      Display the contents of a dataset
'               Allow the user to display the records for a specific grade
' Programmer:   Joshua Hipple on 5/5/2015

Option Explicit On
Option Strict On
Option Infer On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoursesDataSet.tblCourses' table. You can move, or remove it, as needed.
        Me.TblCoursesTableAdapter.Fill(Me.CoursesDataSet.tblCourses)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Move to the next record in the table

        TblCoursesBindingSource.MoveNext()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Move to the previous record in the table

        TblCoursesBindingSource.MovePrevious()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display all the records of a certain grade

        Dim strInput As String

        strInput = InputBox("Enter the grade.  Leave blank to retrieve all records", "Grade")

        Dim records = From Course In CoursesDataSet.tblCourses
                      Where Course.Grade.ToUpper Like strInput.ToUpper & "*"
                      Select Course

        TblCoursesBindingSource.DataSource = records.AsDataView

    End Sub
End Class
