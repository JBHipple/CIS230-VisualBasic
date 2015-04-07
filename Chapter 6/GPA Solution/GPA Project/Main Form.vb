Public Class frmMain

    Private Sub lstGPA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGPA.SelectedIndexChanged

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For decGPA As Decimal = 1D To 4D Step 0.1D
            ' Populate lstGPA

            lstGPA.Items.Add(decGPA.ToString("N1"))
            lblAllStudents.Text = "0.0"
            lblFemaleStudents.Text = "0.0"
            lblMaleStudents.Text = "0.0"
        Next decGPA
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application

        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' add GPA to appropriate averages

        ' Declare varaibles
        Static intNumMale As Integer
        Static decTotalMale As Decimal
        Static intNumFemale As Integer
        Static decTotalFemale As Decimal
        Dim decNewGPA As Decimal

        '

        ' Retrieve new GPA
        Decimal.TryParse(lstGPA.SelectedItem.ToString, decNewGPA)

        ' Add to appropriate total and average
        If radFemale.Checked Then
            intNumFemale += 1
            decTotalFemale += decNewGPA
            lblAllStudents.Text = ((decTotalFemale + decTotalMale) / (intNumFemale + intNumMale)).ToString("N1")
            lblFemaleStudents.Text = (decTotalFemale / intNumFemale).ToString("N1")
        Else
            intNumMale += 1
            decTotalMale += decNewGPA
            lblAllStudents.Text = ((decTotalFemale + decTotalMale) / (intNumFemale + intNumMale)).ToString("N1")
            lblMaleStudents.Text = (decTotalMale / intNumMale).ToString("N1")
        End If


    End Sub
End Class
