<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesEntry
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
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.txtCourseOne = New System.Windows.Forms.TextBox()
        Me.lblCourseOneLetterGrade = New System.Windows.Forms.Label()
        Me.lblCourseTwoLetterGrade = New System.Windows.Forms.Label()
        Me.txtCourseTwo = New System.Windows.Forms.TextBox()
        Me.lblCourseTwo = New System.Windows.Forms.Label()
        Me.lblCourseThreeLetterGrade = New System.Windows.Forms.Label()
        Me.txtCourseThree = New System.Windows.Forms.TextBox()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.lblCourseFourLetterGrade = New System.Windows.Forms.Label()
        Me.txtCourseFour = New System.Windows.Forms.TextBox()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.lblCourseFiveLetterGrade = New System.Windows.Forms.Label()
        Me.txtCourseFive = New System.Windows.Forms.TextBox()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.lblCourseSixLetterGrade = New System.Windows.Forms.Label()
        Me.txtCourseSix = New System.Windows.Forms.TextBox()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.lblAverageLetterGrade = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblAverageMark = New System.Windows.Forms.Label()
        Me.lblWarnings = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Location = New System.Drawing.Point(12, 26)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(52, 13)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course &1:"
        Me.lblCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCourseOne
        '
        Me.txtCourseOne.Location = New System.Drawing.Point(66, 23)
        Me.txtCourseOne.Name = "txtCourseOne"
        Me.txtCourseOne.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseOne.TabIndex = 1
        Me.txtCourseOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourseOne, "Enter the corresponding course's number grade here.")
        '
        'lblCourseOneLetterGrade
        '
        Me.lblCourseOneLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseOneLetterGrade.Location = New System.Drawing.Point(172, 23)
        Me.lblCourseOneLetterGrade.Name = "lblCourseOneLetterGrade"
        Me.lblCourseOneLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseOneLetterGrade.TabIndex = 0
        Me.lblCourseOneLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourseOneLetterGrade, "The corresponding course's letter grade will be displayed here.")
        '
        'lblCourseTwoLetterGrade
        '
        Me.lblCourseTwoLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseTwoLetterGrade.Location = New System.Drawing.Point(172, 49)
        Me.lblCourseTwoLetterGrade.Name = "lblCourseTwoLetterGrade"
        Me.lblCourseTwoLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseTwoLetterGrade.TabIndex = 0
        Me.lblCourseTwoLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourseTwoLetterGrade, "The corresponding course's letter grade will be displayed here.")
        '
        'txtCourseTwo
        '
        Me.txtCourseTwo.Location = New System.Drawing.Point(66, 49)
        Me.txtCourseTwo.Name = "txtCourseTwo"
        Me.txtCourseTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseTwo.TabIndex = 2
        Me.txtCourseTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourseTwo, "Enter the corresponding course's number grade here.")
        '
        'lblCourseTwo
        '
        Me.lblCourseTwo.Location = New System.Drawing.Point(12, 52)
        Me.lblCourseTwo.Name = "lblCourseTwo"
        Me.lblCourseTwo.Size = New System.Drawing.Size(52, 13)
        Me.lblCourseTwo.TabIndex = 0
        Me.lblCourseTwo.Text = "Course &2:"
        Me.lblCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseThreeLetterGrade
        '
        Me.lblCourseThreeLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseThreeLetterGrade.Location = New System.Drawing.Point(172, 75)
        Me.lblCourseThreeLetterGrade.Name = "lblCourseThreeLetterGrade"
        Me.lblCourseThreeLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseThreeLetterGrade.TabIndex = 0
        Me.lblCourseThreeLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourseThreeLetterGrade, "The corresponding course's letter grade will be displayed here.")
        '
        'txtCourseThree
        '
        Me.txtCourseThree.Location = New System.Drawing.Point(66, 75)
        Me.txtCourseThree.Name = "txtCourseThree"
        Me.txtCourseThree.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseThree.TabIndex = 3
        Me.txtCourseThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourseThree, "Enter the corresponding course's number grade here.")
        '
        'lblCourseThree
        '
        Me.lblCourseThree.Location = New System.Drawing.Point(12, 78)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(52, 13)
        Me.lblCourseThree.TabIndex = 0
        Me.lblCourseThree.Text = "Course &3:"
        Me.lblCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFourLetterGrade
        '
        Me.lblCourseFourLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFourLetterGrade.Location = New System.Drawing.Point(172, 101)
        Me.lblCourseFourLetterGrade.Name = "lblCourseFourLetterGrade"
        Me.lblCourseFourLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseFourLetterGrade.TabIndex = 0
        Me.lblCourseFourLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourseFourLetterGrade, "The corresponding course's letter grade will be displayed here.")
        '
        'txtCourseFour
        '
        Me.txtCourseFour.Location = New System.Drawing.Point(66, 101)
        Me.txtCourseFour.Name = "txtCourseFour"
        Me.txtCourseFour.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseFour.TabIndex = 4
        Me.txtCourseFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourseFour, "Enter the corresponding course's number grade here.")
        '
        'lblCourseFour
        '
        Me.lblCourseFour.Location = New System.Drawing.Point(12, 104)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(52, 13)
        Me.lblCourseFour.TabIndex = 0
        Me.lblCourseFour.Text = "Course &4:"
        Me.lblCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFiveLetterGrade
        '
        Me.lblCourseFiveLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFiveLetterGrade.Location = New System.Drawing.Point(172, 127)
        Me.lblCourseFiveLetterGrade.Name = "lblCourseFiveLetterGrade"
        Me.lblCourseFiveLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseFiveLetterGrade.TabIndex = 0
        Me.lblCourseFiveLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourseFiveLetterGrade, "The corresponding course's letter grade will be displayed here.")
        '
        'txtCourseFive
        '
        Me.txtCourseFive.Location = New System.Drawing.Point(66, 127)
        Me.txtCourseFive.Name = "txtCourseFive"
        Me.txtCourseFive.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseFive.TabIndex = 5
        Me.txtCourseFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourseFive, "Enter the corresponding course's number grade here.")
        '
        'lblCourseFive
        '
        Me.lblCourseFive.Location = New System.Drawing.Point(12, 130)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(52, 13)
        Me.lblCourseFive.TabIndex = 0
        Me.lblCourseFive.Text = "Course &5:"
        Me.lblCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseSixLetterGrade
        '
        Me.lblCourseSixLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseSixLetterGrade.Location = New System.Drawing.Point(172, 153)
        Me.lblCourseSixLetterGrade.Name = "lblCourseSixLetterGrade"
        Me.lblCourseSixLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseSixLetterGrade.TabIndex = 0
        Me.lblCourseSixLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourseSixLetterGrade, "The corresponding course's letter grade will be displayed here.")
        '
        'txtCourseSix
        '
        Me.txtCourseSix.Location = New System.Drawing.Point(66, 153)
        Me.txtCourseSix.Name = "txtCourseSix"
        Me.txtCourseSix.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseSix.TabIndex = 6
        Me.txtCourseSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourseSix, "Enter the corresponding course's number grade here.")
        '
        'lblCourseSix
        '
        Me.lblCourseSix.Location = New System.Drawing.Point(12, 156)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(52, 13)
        Me.lblCourseSix.TabIndex = 0
        Me.lblCourseSix.Text = "Course &6:"
        Me.lblCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverageLetterGrade
        '
        Me.lblAverageLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageLetterGrade.Location = New System.Drawing.Point(172, 179)
        Me.lblAverageLetterGrade.Name = "lblAverageLetterGrade"
        Me.lblAverageLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblAverageLetterGrade.TabIndex = 0
        Me.lblAverageLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblAverageLetterGrade, "The semester's letter grade will be displayed here.")
        '
        'lblSemester
        '
        Me.lblSemester.Location = New System.Drawing.Point(10, 180)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(54, 13)
        Me.lblSemester.TabIndex = 0
        Me.lblSemester.Text = "&Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverageMark
        '
        Me.lblAverageMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageMark.Location = New System.Drawing.Point(66, 179)
        Me.lblAverageMark.Name = "lblAverageMark"
        Me.lblAverageMark.Size = New System.Drawing.Size(100, 20)
        Me.lblAverageMark.TabIndex = 0
        Me.lblAverageMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblAverageMark, "The semester's average will be displayed here.")
        '
        'lblWarnings
        '
        Me.lblWarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWarnings.Location = New System.Drawing.Point(15, 215)
        Me.lblWarnings.Name = "lblWarnings"
        Me.lblWarnings.Size = New System.Drawing.Size(257, 212)
        Me.lblWarnings.TabIndex = 0
        Me.lblWarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblWarnings, "This is where any error messages will be displayed.")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 442)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTips.SetToolTip(Me.btnCalculate, "Calculates the semester's average.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(107, 442)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.ToolTips.SetToolTip(Me.btnReset, "Resets the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.ToolTips.SetToolTip(Me.btnExit, "Exits the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGradesEntry
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 477)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblWarnings)
        Me.Controls.Add(Me.lblAverageMark)
        Me.Controls.Add(Me.lblAverageLetterGrade)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblCourseSixLetterGrade)
        Me.Controls.Add(Me.txtCourseSix)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.lblCourseFiveLetterGrade)
        Me.Controls.Add(Me.txtCourseFive)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.lblCourseFourLetterGrade)
        Me.Controls.Add(Me.txtCourseFour)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.lblCourseThreeLetterGrade)
        Me.Controls.Add(Me.txtCourseThree)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.lblCourseTwoLetterGrade)
        Me.Controls.Add(Me.txtCourseTwo)
        Me.Controls.Add(Me.lblCourseTwo)
        Me.Controls.Add(Me.lblCourseOneLetterGrade)
        Me.Controls.Add(Me.txtCourseOne)
        Me.Controls.Add(Me.lblCourseOne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGradesEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourseOne As Label
    Friend WithEvents txtCourseOne As TextBox
    Friend WithEvents lblCourseOneLetterGrade As Label
    Friend WithEvents lblCourseTwoLetterGrade As Label
    Friend WithEvents txtCourseTwo As TextBox
    Friend WithEvents lblCourseTwo As Label
    Friend WithEvents lblCourseThreeLetterGrade As Label
    Friend WithEvents txtCourseThree As TextBox
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents lblCourseFourLetterGrade As Label
    Friend WithEvents txtCourseFour As TextBox
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents lblCourseFiveLetterGrade As Label
    Friend WithEvents txtCourseFive As TextBox
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents lblCourseSixLetterGrade As Label
    Friend WithEvents txtCourseSix As TextBox
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents lblAverageLetterGrade As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblAverageMark As Label
    Friend WithEvents lblWarnings As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTips As ToolTip
End Class
