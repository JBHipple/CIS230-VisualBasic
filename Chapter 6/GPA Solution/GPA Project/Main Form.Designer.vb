<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lstGPA = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFemaleStudents = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMaleStudents = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAllStudents = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Checked = True
        Me.radFemale.Location = New System.Drawing.Point(11, 21)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(78, 24)
        Me.radFemale.TabIndex = 0
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(11, 56)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(63, 24)
        Me.radMale.TabIndex = 1
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(137, 31)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(40, 20)
        Me.lblGPA.TabIndex = 1
        Me.lblGPA.Text = "GPA:"
        '
        'lstGPA
        '
        Me.lstGPA.FormattingEnabled = True
        Me.lstGPA.HorizontalScrollbar = True
        Me.lstGPA.ItemHeight = 20
        Me.lstGPA.Location = New System.Drawing.Point(141, 54)
        Me.lstGPA.Name = "lstGPA"
        Me.lstGPA.Size = New System.Drawing.Size(87, 104)
        Me.lstGPA.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(248, 31)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(116, 38)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(248, 75)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFemaleStudents)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblMaleStudents)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblAllStudents)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 258)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Average GPA"
        '
        'lblFemaleStudents
        '
        Me.lblFemaleStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFemaleStudents.Location = New System.Drawing.Point(26, 203)
        Me.lblFemaleStudents.Name = "lblFemaleStudents"
        Me.lblFemaleStudents.Size = New System.Drawing.Size(112, 32)
        Me.lblFemaleStudents.TabIndex = 5
        Me.lblFemaleStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Female Students:"
        '
        'lblMaleStudents
        '
        Me.lblMaleStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaleStudents.Location = New System.Drawing.Point(26, 130)
        Me.lblMaleStudents.Name = "lblMaleStudents"
        Me.lblMaleStudents.Size = New System.Drawing.Size(112, 32)
        Me.lblMaleStudents.TabIndex = 3
        Me.lblMaleStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Male Students:"
        '
        'lblAllStudents
        '
        Me.lblAllStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllStudents.Location = New System.Drawing.Point(26, 60)
        Me.lblAllStudents.Name = "lblAllStudents"
        Me.lblAllStudents.Size = New System.Drawing.Size(112, 32)
        Me.lblAllStudents.TabIndex = 1
        Me.lblAllStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All Students:"
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Location = New System.Drawing.Point(24, 31)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(101, 101)
        Me.grpGender.TabIndex = 0
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Gender"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 482)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lstGPA)
        Me.Controls.Add(Me.lblGPA)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "GPA Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblGPA As System.Windows.Forms.Label
    Friend WithEvents lstGPA As System.Windows.Forms.ListBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFemaleStudents As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMaleStudents As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAllStudents As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpGender As System.Windows.Forms.GroupBox

End Class
