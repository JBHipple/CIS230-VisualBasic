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
        Me.components = New System.ComponentModel.Container()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CoursesDataSet = New College_Courses_Project.CoursesDataSet()
        Me.TblCoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCoursesTableAdapter = New College_Courses_Project.CoursesDataSetTableAdapters.tblCoursesTableAdapter()
        Me.TableAdapterManager = New College_Courses_Project.CoursesDataSetTableAdapters.TableAdapterManager()
        Me.TblCoursesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CoursesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCoursesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(275, 379)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(114, 34)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "&Grade Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(529, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(140, 379)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(129, 34)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "&Previous Record"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(27, 379)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 34)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next Record"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TblCoursesDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 284)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CoursesDataSet
        '
        Me.CoursesDataSet.DataSetName = "CoursesDataSet"
        Me.CoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCoursesBindingSource
        '
        Me.TblCoursesBindingSource.DataMember = "tblCourses"
        Me.TblCoursesBindingSource.DataSource = Me.CoursesDataSet
        '
        'TblCoursesTableAdapter
        '
        Me.TblCoursesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCoursesTableAdapter = Me.TblCoursesTableAdapter
        Me.TableAdapterManager.UpdateOrder = College_Courses_Project.CoursesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCoursesDataGridView
        '
        Me.TblCoursesDataGridView.AllowUserToAddRows = False
        Me.TblCoursesDataGridView.AllowUserToDeleteRows = False
        Me.TblCoursesDataGridView.AutoGenerateColumns = False
        Me.TblCoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCoursesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblCoursesDataGridView.DataSource = Me.TblCoursesBindingSource
        Me.TblCoursesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblCoursesDataGridView.Enabled = False
        Me.TblCoursesDataGridView.Location = New System.Drawing.Point(3, 25)
        Me.TblCoursesDataGridView.Name = "TblCoursesDataGridView"
        Me.TblCoursesDataGridView.ReadOnly = True
        Me.TblCoursesDataGridView.RowHeadersVisible = False
        Me.TblCoursesDataGridView.RowTemplate.Height = 24
        Me.TblCoursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblCoursesDataGridView.Size = New System.Drawing.Size(571, 256)
        Me.TblCoursesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CreditHours"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CreditHours"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Grade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Grade"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 452)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Courses"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CoursesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCoursesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CoursesDataSet As College_Courses_Project.CoursesDataSet
    Friend WithEvents TblCoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCoursesTableAdapter As College_Courses_Project.CoursesDataSetTableAdapters.tblCoursesTableAdapter
    Friend WithEvents TableAdapterManager As College_Courses_Project.CoursesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCoursesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
