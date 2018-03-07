
Option Strict On

''' Program Name : Lab 2 - Semester Average
''' Author: Spence McComb
''' Student ID: 100426427
''' Last Edited: February 20, 2018
''' Course Code: NETD 2202-04
''' 
''' Description: The purpose of this program is to accept six grades then calculate and display an average.
'''              Afterward, the user has the option to reset or exit the form.
'''              The program uses the concepts of nested if statements, loops, and functions to make the
'''              writing of the code simpler and the delivery more effective.


Public Class frmGradesEntry

    'Declare and initialize the global constant and variable.
    Const MAXIMUM_ARRAY_SIZE As Integer = 6
    Dim averageArray(MAXIMUM_ARRAY_SIZE) As Double

    Function determineLetter(grade As Double) As String

        'This function is designed to determine which letter grade is appropriate for the provided mark.
        'Input: grade (double)
        'Output: courseLetter (string)

        'First, declare the courseLetter variable.
        Dim courseLetter As String = ""

        'Determine the appropriate letter grade.
        If (grade < 50) Then
            courseLetter = "F"
        ElseIf (grade < 53) Then
            courseLetter = "D-"
        ElseIf (grade < 57) Then
            courseLetter = "D"
        ElseIf (grade < 60) Then
            courseLetter = "D+"
        ElseIf (grade < 63) Then
            courseLetter = "C-"
        ElseIf (grade < 67) Then
            courseLetter = "C"
        ElseIf (grade < 70) Then
            courseLetter = "C+"
        ElseIf (grade < 73) Then
            courseLetter = "B-"
        ElseIf (grade < 77) Then
            courseLetter = "B"
        ElseIf (grade < 80) Then
            courseLetter = "B+"
        ElseIf (grade < 83) Then
            courseLetter = "A-"
        ElseIf (grade < 90) Then
            courseLetter = "A"
        Else
            courseLetter = "A+"
        End If

        'Return the decided upon letter whenever the function is called.
        Return courseLetter
    End Function

    Private Sub txtCourseOne_LostFocus(sender As Object, e As EventArgs) Handles txtCourseOne.LostFocus

        'Declare and initialize the grade storage variable as well as the validation boolean variable.
        Dim grade As Double = 0
        Dim isDouble As Boolean = False

        'Data validation to ensure that the course is entered as a double.
        If Double.TryParse(txtCourseOne.Text, CDbl(isDouble)) = False Then

            'If the validation fails, instruct the user to correct their error.
            lblWarnings.Text = "Error! Please ensure data entered for Course 1 is a value between 1 and 100, inclusive."

            'Clear the calculated letter grade and disable the other input textboxes.
            lblCourseOneLetterGrade.Text = ""
            txtCourseTwo.ReadOnly = True
            txtCourseThree.ReadOnly = True
            txtCourseFour.ReadOnly = True
            txtCourseFive.ReadOnly = True
            txtCourseSix.ReadOnly = True
            btnCalculate.Enabled = False

            'Highlight the data that needs to be changed for ease of use.
            txtCourseOne.ReadOnly = False
            txtCourseOne.Focus()
            txtCourseOne.SelectAll()

        Else
            'The data is numeric. Enable any textboxes that were disabled due to error.
            txtCourseTwo.ReadOnly = False
            txtCourseThree.ReadOnly = False
            txtCourseFour.ReadOnly = False
            txtCourseFive.ReadOnly = False
            txtCourseSix.ReadOnly = False

            'Derive the grade from the associated textbox.
            grade = CDbl(txtCourseOne.Text)

            'Data validation to ensure the grade is within an acceptable range.
            If ((grade < 0) Or (grade > 100)) Then

                'Data outside of range. Inform the user.
                lblWarnings.Text = "Error! Please ensure data entered for Course 1 is a value between 1 and 100, inclusive."

                'Clear the calculated letter grade and disable the other input textboxes.
                lblCourseOneLetterGrade.Text = ""
                txtCourseTwo.ReadOnly = True
                txtCourseThree.ReadOnly = True
                txtCourseFour.ReadOnly = True
                txtCourseFive.ReadOnly = True
                txtCourseSix.ReadOnly = True
                btnCalculate.Enabled = False

                'Highlight the data that needs to be changed for ease of use.
                txtCourseOne.ReadOnly = False
                txtCourseOne.Focus()
                txtCourseOne.SelectAll()

            Else
                'Data is within range, call the function.
                lblCourseOneLetterGrade.Text = determineLetter(grade)

                'Append the entered grade to the appropriate location in the array.
                averageArray(0) = grade
                btnCalculate.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCourseTwo_LostFocus(sender As Object, e As EventArgs) Handles txtCourseTwo.LostFocus

        'Declare and initialize the grade storage variable as well as the validation boolean variable.
        Dim grade As Double = 0
        Dim isDouble As Boolean = False

        'Data validation to ensure that the course is entered as a double.
        If Double.TryParse(txtCourseTwo.Text, CDbl(isDouble)) = False Then

            'If the validation fails, instruct the user to correct their error.
            lblWarnings.Text = "Error! Please ensure data entered for Course 2 is a value between 1 and 100, inclusive."

            'Clear the calculated letter grade and disable the other input textboxes.
            lblCourseTwoLetterGrade.Text = ""
            txtCourseOne.ReadOnly = True
            txtCourseThree.ReadOnly = True
            txtCourseFour.ReadOnly = True
            txtCourseFive.ReadOnly = True
            txtCourseSix.ReadOnly = True
            btnCalculate.Enabled = False

            'Highlight the data that needs to be changed for ease of use.
            txtCourseTwo.ReadOnly = False
            txtCourseTwo.Focus()
            txtCourseTwo.SelectAll()

        Else
            'The data is numeric. Enable any textboxes that were disabled due to error.
            txtCourseOne.ReadOnly = False
            txtCourseThree.ReadOnly = False
            txtCourseFour.ReadOnly = False
            txtCourseFive.ReadOnly = False
            txtCourseSix.ReadOnly = False

            'Derive the grade from the associated textbox.
            grade = CDbl(txtCourseTwo.Text)

            'Data validation to ensure the grade is within an acceptable range.
            If ((grade < 0) Or (grade > 100)) Then

                'Data outside of range. Inform the user.
                lblWarnings.Text = "Error! Please ensure data entered for Course 2 is a value between 1 and 100, inclusive."

                'Clear the calculated letter grade and disable the other input textboxes.
                lblCourseTwoLetterGrade.Text = ""
                txtCourseOne.ReadOnly = True
                txtCourseThree.ReadOnly = True
                txtCourseFour.ReadOnly = True
                txtCourseFive.ReadOnly = True
                txtCourseSix.ReadOnly = True
                btnCalculate.Enabled = False

                'Highlight the data that needs to be changed for ease of use.
                txtCourseTwo.ReadOnly = False
                txtCourseTwo.Focus()
                txtCourseTwo.SelectAll()

            Else
                'Data is within range, call the function.
                lblCourseTwoLetterGrade.Text = determineLetter(grade)

                'Append the entered grade to the appropriate location in the array.
                averageArray(1) = grade
                btnCalculate.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCourseThree_LostFocus(sender As Object, e As EventArgs) Handles txtCourseThree.LostFocus

        'Declare and initialize the grade storage variable as well as the validation boolean variable.
        Dim grade As Double = 0
        Dim isDouble As Boolean = False

        'Data validation to ensure that the course is entered as a double.
        If Double.TryParse(txtCourseThree.Text, CDbl(isDouble)) = False Then
            lblWarnings.Text = "Error! Please ensure data entered for Course 3 is a value between 1 and 100, inclusive."

            'Clear the calculated letter grade and disable the other input textboxes.
            lblCourseThreeLetterGrade.Text = ""
            txtCourseOne.ReadOnly = True
            txtCourseTwo.ReadOnly = True
            txtCourseFour.ReadOnly = True
            txtCourseFive.ReadOnly = True
            txtCourseSix.ReadOnly = True
            btnCalculate.Enabled = False

            'Highlight the data that needs to be changed for ease of use.
            txtCourseThree.ReadOnly = False
            txtCourseThree.Focus()
            txtCourseThree.SelectAll()

        Else
            'The data is numeric. Enable any textboxes that were disabled due to error.
            txtCourseOne.ReadOnly = False
            txtCourseTwo.ReadOnly = False
            txtCourseFour.ReadOnly = False
            txtCourseFive.ReadOnly = False
            txtCourseSix.ReadOnly = False


            'Derive the grade from the associated textbox.
            grade = CDbl(txtCourseThree.Text)

            'Data validation to ensure the grade is within an acceptable range.
            If ((grade < 0) Or (grade > 100)) Then

                'Data outside of range. Inform the user.
                lblWarnings.Text = "Error! Please ensure data entered for Course 3 is a value between 1 and 100, inclusive."

                'Clear the calculated letter grade and disable the other input textboxes.
                lblCourseThreeLetterGrade.Text = ""
                txtCourseOne.ReadOnly = True
                txtCourseTwo.ReadOnly = True
                txtCourseFour.ReadOnly = True
                txtCourseFive.ReadOnly = True
                txtCourseSix.ReadOnly = True
                btnCalculate.Enabled = False

                'Highlight the data that needs to be changed for ease of use.
                txtCourseThree.ReadOnly = False
                txtCourseThree.Focus()
                txtCourseThree.SelectAll()

            Else
                'Data is within range, call the function.
                lblCourseThreeLetterGrade.Text = determineLetter(grade)

                'Append the entered grade to the appropriate location in the array.
                averageArray(2) = grade
                btnCalculate.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCourseFour_LostFocus(sender As Object, e As EventArgs) Handles txtCourseFour.LostFocus

        'Declare and initialize the grade storage variable as well as the validation boolean variable.
        Dim grade As Double = 0
        Dim isDouble As Boolean = False

        'Data validation to ensure that the course is entered as a double.
        If Double.TryParse(txtCourseFour.Text, CDbl(isDouble)) = False Then
            lblWarnings.Text = "Error! Please ensure data entered for Course 4 is a value between 1 and 100, inclusive."

            'Clear the calculated letter grade and disable the other input textboxes.
            lblCourseFourLetterGrade.Text = ""
            txtCourseOne.ReadOnly = True
            txtCourseTwo.ReadOnly = True
            txtCourseThree.ReadOnly = True
            txtCourseFive.ReadOnly = True
            txtCourseSix.ReadOnly = True
            btnCalculate.Enabled = False

            'Highlight the data that needs to be changed for ease of use.
            txtCourseFour.ReadOnly = False
            txtCourseFour.Focus()
            txtCourseFour.SelectAll()

        Else
            'The data is numeric. Enable any textboxes that were disabled due to error.
            txtCourseOne.ReadOnly = False
            txtCourseTwo.ReadOnly = False
            txtCourseThree.ReadOnly = False
            txtCourseFive.ReadOnly = False
            txtCourseSix.ReadOnly = False

            'Derive the grade from the associated textbox.
            grade = CDbl(txtCourseFour.Text)

            'Data validation to ensure the grade is within an acceptable range.
            If ((grade < 0) Or (grade > 100)) Then

                'Data outside of range. Inform the user.
                lblWarnings.Text = "Error! Please ensure data entered for Course 4 is a value between 1 and 100, inclusive."

                'Clear the calculated letter grade and disable the other input textboxes.
                lblCourseFourLetterGrade.Text = ""
                txtCourseOne.ReadOnly = True
                txtCourseTwo.ReadOnly = True
                txtCourseThree.ReadOnly = True
                txtCourseFive.ReadOnly = True
                txtCourseSix.ReadOnly = True
                btnCalculate.Enabled = False

                'Highlight the data that needs to be changed for ease of use.
                txtCourseFour.ReadOnly = False
                txtCourseFour.Focus()
                txtCourseFour.SelectAll()

            Else
                'Data is within range, call the function.
                lblCourseFourLetterGrade.Text = determineLetter(grade)

                'Append the entered grade to the appropriate location in the array.
                averageArray(3) = grade
                btnCalculate.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCourseFive_LostFocus(sender As Object, e As EventArgs) Handles txtCourseFive.LostFocus

        'Declare and initialize the grade storage variable as well as the validation boolean variable.
        Dim grade As Double = 0
        Dim isDouble As Boolean = False

        'Data validation to ensure that the course is entered as a double.
        If Double.TryParse(txtCourseFive.Text, CDbl(isDouble)) = False Then
            lblWarnings.Text = "Error! Please ensure data entered for Course 5 is a value between 1 and 100, inclusive."

            'Clear the calculated letter grade and disable the other input textboxes.
            lblCourseFiveLetterGrade.Text = ""
            txtCourseOne.ReadOnly = True
            txtCourseTwo.ReadOnly = True
            txtCourseThree.ReadOnly = True
            txtCourseFour.ReadOnly = True
            txtCourseSix.ReadOnly = True
            btnCalculate.Enabled = False

            'Highlight the data that needs to be changed for ease of use.
            txtCourseFive.ReadOnly = False
            txtCourseFive.Focus()
            txtCourseFive.SelectAll()

        Else
            'The data is numeric. Enable any textboxes that were disabled due to error.
            txtCourseOne.ReadOnly = False
            txtCourseTwo.ReadOnly = False
            txtCourseThree.ReadOnly = False
            txtCourseFour.ReadOnly = False
            txtCourseSix.ReadOnly = False

            'Derive the grade from the associated textbox.
            grade = CDbl(txtCourseFive.Text)

            'Data validation to ensure the grade is within an acceptable range.
            If ((grade < 0) Or (grade > 100)) Then

                'Data outside of range. Inform the user.
                lblWarnings.Text = "Error! Please ensure data entered for Course 5 is a value between 1 and 100, inclusive."

                'Clear the calculated letter grade and disable the other input textboxes.
                lblCourseFiveLetterGrade.Text = ""
                txtCourseOne.ReadOnly = True
                txtCourseTwo.ReadOnly = True
                txtCourseThree.ReadOnly = True
                txtCourseFour.ReadOnly = True
                txtCourseSix.ReadOnly = True
                btnCalculate.Enabled = False

                'Highlight the data that needs to be changed for ease of use.
                txtCourseFive.ReadOnly = False
                txtCourseFive.Focus()
                txtCourseFive.SelectAll()

            Else
                'Data is within range, call the function.
                lblCourseFiveLetterGrade.Text = determineLetter(grade)

                'Append the entered grade to the appropriate location in the array.
                averageArray(4) = grade
                btnCalculate.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCourseSix_LostFocus(sender As Object, e As EventArgs) Handles txtCourseSix.LostFocus

        'Declare and initialize the grade storage variable as well as the validation boolean variable.
        Dim grade As Double = 0
        Dim isDouble As Boolean = False

        'Data validation to ensure that the course is entered as a double.
        If Double.TryParse(txtCourseSix.Text, CDbl(isDouble)) = False Then
            lblWarnings.Text = "Error! Please ensure data entered for Course 6 is a value between 1 and 100, inclusive."

            'Clear the calculated letter grade and disable the other input textboxes.
            lblCourseSixLetterGrade.Text = ""
            txtCourseOne.ReadOnly = True
            txtCourseTwo.ReadOnly = True
            txtCourseThree.ReadOnly = True
            txtCourseFour.ReadOnly = True
            txtCourseFive.ReadOnly = True
            btnCalculate.Enabled = False

            'Highlight the data that needs to be changed for ease of use.
            txtCourseSix.ReadOnly = False
            txtCourseSix.Focus()
            txtCourseSix.SelectAll()

        Else
            'The data is numeric. Enable any textboxes that were disabled due to error.
            txtCourseOne.ReadOnly = False
            txtCourseTwo.ReadOnly = False
            txtCourseThree.ReadOnly = False
            txtCourseFour.ReadOnly = False
            txtCourseFive.ReadOnly = False

            'Derive the grade from the associated textbox.
            grade = CDbl(txtCourseSix.Text)

            'Data validation to ensure the grade is within an acceptable range.
            If ((grade < 0) Or (grade > 100)) Then

                'Data outside of range. Inform the user.
                lblWarnings.Text = "Error! Please ensure data entered for Course 6 is a value between 1 and 100, inclusive."

                'Clear the calculated letter grade and disable the other input textboxes.
                lblCourseSixLetterGrade.Text = ""
                txtCourseOne.ReadOnly = True
                txtCourseTwo.ReadOnly = True
                txtCourseThree.ReadOnly = True
                txtCourseFour.ReadOnly = True
                txtCourseFive.ReadOnly = True
                btnCalculate.Enabled = False

                'Highlight the data that needs to be changed for ease of use.
                txtCourseSix.ReadOnly = False
                txtCourseSix.Focus()
                txtCourseSix.SelectAll()

            Else
                'Data is within range, call the function.
                lblCourseSixLetterGrade.Text = determineLetter(grade)

                'Append the entered grade to the appropriate location in the array.
                averageArray(5) = grade
                btnCalculate.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Takes the focus off any remaining textboxes.
        btnReset.Focus()

        'Declare the variable that will be used to house the semester's average grade.
        Dim semesterAverage As Double = 0

        'Loops through each entry in the array and adds it to the average variable.
        For i = 1 To MAXIMUM_ARRAY_SIZE
            semesterAverage += averageArray(i - 1)
        Next

        'Adjusts the average variable so that it holds a true average (as opposed to a sum).
        semesterAverage = (semesterAverage / MAXIMUM_ARRAY_SIZE)

        'Outputs the numerical average.
        lblAverageMark.Text = CStr(Math.Round(semesterAverage, 2))

        'Determines the appropriate letter grade to assign to the average grade.
        lblAverageLetterGrade.Text = determineLetter(semesterAverage)

        'Prevents the user from changing data or clicking the calculate button until the form is reset.
        txtCourseOne.ReadOnly = True
        txtCourseTwo.ReadOnly = True
        txtCourseThree.ReadOnly = True
        txtCourseFour.ReadOnly = True
        txtCourseFive.ReadOnly = True
        txtCourseSix.ReadOnly = True
        btnCalculate.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Allows the user to exit the form by click the Exit button.
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Resets the array (unnecessary in this instance, but likely a good habit).
        For i = 0 To (MAXIMUM_ARRAY_SIZE - 1)
            averageArray(i) = 0
        Next

        'Clears the textboxes.
        txtCourseOne.Text = ""
        txtCourseTwo.Text = ""
        txtCourseThree.Text = ""
        txtCourseFour.Text = ""
        txtCourseFive.Text = ""
        txtCourseSix.Text = ""

        'Clears the letter grade labels.
        lblCourseOneLetterGrade.Text = ""
        lblCourseTwoLetterGrade.Text = ""
        lblCourseThreeLetterGrade.Text = ""
        lblCourseFourLetterGrade.Text = ""
        lblCourseFiveLetterGrade.Text = ""
        lblCourseSixLetterGrade.Text = ""

        'Clears the average labels.
        lblAverageMark.Text = ""
        lblAverageLetterGrade.Text = ""

        'Enables the textboxes for entry and calculation button for the average calculation.
        txtCourseOne.ReadOnly = False
        txtCourseTwo.ReadOnly = False
        txtCourseThree.ReadOnly = False
        txtCourseFour.ReadOnly = False
        txtCourseFive.ReadOnly = False
        txtCourseSix.ReadOnly = False
        btnCalculate.Enabled = True

        'Reset the warnings (since the text has changed).
        lblWarnings.Text = ""

        'Give focus to the first textbox for ease of use.
        txtCourseOne.Focus()
    End Sub
End Class
