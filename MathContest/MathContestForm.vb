'Jamison Burton
'RCET0265
'Spring 2022
'Math Contest
'https://github.com/Reimonoe17/MathContest

Public Class MathContestForm
    Sub Validate()
        Dim valid As Boolean = True
        Dim errorMsg As String
        Dim age As String
        Dim grade As String

        If NameTextBox.Text = "" Then
            errorMsg &= "Name required" & vbNewLine
            valid = False
        End If

        If AgeTextBox.Text = "" Then
            errorMsg &= "Age required" & vbNewLine
            valid = False
        Else
            Try
                age = CInt(AgeTextBox.Text)
            Catch ex As Exception
                errorMsg &= "Age must be a number" & vbNewLine
                valid = False
            End Try
        End If

        If GradeTextBox.Text = "" Then
            errorMsg &= "Grade required" & vbNewLine
            valid = False
        Else
            Try
                grade = CInt(GradeTextBox.Text)
            Catch ex As Exception
                errorMsg &= "Grade must be a number" & vbNewLine
                valid = False
            End Try
        End If

        If StudentAnswerTextBox.Enabled = False Then
            errorMsg &= "Select a Math Problem"
            valid = False
        End If

        If valid = True Then
            SubmitButton.Enabled = True
            SummaryButton.Enabled = True
        End If

    End Sub
    Function RandomInteger() As Integer
        Randomize()
        Dim value As Integer = CInt(Int((10 * Rnd()) + 1))
        Return value 'Outputs a random value between 1 and 6
    End Function
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged, SubtractRadioButton.CheckedChanged, MultiplyRadioButton.CheckedChanged, DivideRadioButton.CheckedChanged
        FirstNumberTextBox.Text = RandomInteger()
        SecondNumberTextBox.Text = RandomInteger()
        StudentAnswerTextBox.Enabled = True
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
