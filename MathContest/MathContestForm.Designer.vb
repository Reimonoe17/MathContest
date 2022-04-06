<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.ProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.FunctionGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InformationGroupBox.SuspendLayout()
        Me.ProblemGroupBox.SuspendLayout()
        Me.TypeGroupBox.SuspendLayout()
        Me.FunctionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.Controls.Add(Me.NameLabel)
        Me.InformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.InformationGroupBox.Controls.Add(Me.GradeLabel)
        Me.InformationGroupBox.Controls.Add(Me.AgeLabel)
        Me.InformationGroupBox.Controls.Add(Me.GradeTextBox)
        Me.InformationGroupBox.Controls.Add(Me.AgeTextBox)
        Me.InformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(406, 100)
        Me.InformationGroupBox.TabIndex = 14
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Student Information"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 32)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(51, 20)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 55)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(218, 26)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter the name of the Student")
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(319, 32)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(54, 20)
        Me.GradeLabel.TabIndex = 3
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(257, 32)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 2
        Me.AgeLabel.Text = "Age"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(333, 55)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(26, 26)
        Me.GradeTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.GradeTextBox, "Enter the grade of the Student (1st - 4th)")
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(261, 55)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(26, 26)
        Me.AgeTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AgeTextBox, "Enter the age of the Student (7-11)")
        '
        'ProblemGroupBox
        '
        Me.ProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.ProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.ProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.ProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.ProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.ProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.ProblemGroupBox.Location = New System.Drawing.Point(12, 118)
        Me.ProblemGroupBox.Name = "ProblemGroupBox"
        Me.ProblemGroupBox.Size = New System.Drawing.Size(200, 219)
        Me.ProblemGroupBox.TabIndex = 15
        Me.ProblemGroupBox.TabStop = False
        Me.ProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 154)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(123, 20)
        Me.StudentAnswerLabel.TabIndex = 9
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Enabled = False
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(6, 177)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(173, 26)
        Me.StudentAnswerTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.StudentAnswerTextBox, "Enter the Student's answer")
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(6, 94)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(96, 20)
        Me.SecondNumberLabel.TabIndex = 7
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(6, 117)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(173, 26)
        Me.SecondNumberTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.SecondNumberTextBox, "Second Number")
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(6, 31)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(91, 20)
        Me.FirstNumberLabel.TabIndex = 6
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(6, 54)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(173, 26)
        Me.FirstNumberTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.FirstNumberTextBox, "First Number")
        '
        'TypeGroupBox
        '
        Me.TypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.TypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.TypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.TypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.TypeGroupBox.Location = New System.Drawing.Point(218, 118)
        Me.TypeGroupBox.Name = "TypeGroupBox"
        Me.TypeGroupBox.Size = New System.Drawing.Size(200, 219)
        Me.TypeGroupBox.TabIndex = 16
        Me.TypeGroupBox.TabStop = False
        Me.TypeGroupBox.Text = "Current Math Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(20, 130)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(77, 24)
        Me.DivideRadioButton.TabIndex = 9
        Me.DivideRadioButton.Text = "Divide"
        Me.ToolTip1.SetToolTip(Me.DivideRadioButton, "Division problem")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(20, 100)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(86, 24)
        Me.MultiplyRadioButton.TabIndex = 8
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.ToolTip1.SetToolTip(Me.MultiplyRadioButton, "Multiplication problem")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(20, 70)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(95, 24)
        Me.SubtractRadioButton.TabIndex = 7
        Me.SubtractRadioButton.Text = "Subtract"
        Me.ToolTip1.SetToolTip(Me.SubtractRadioButton, "Subtraction problem")
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Checked = True
        Me.AddRadioButton.Location = New System.Drawing.Point(20, 40)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(63, 24)
        Me.AddRadioButton.TabIndex = 6
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.AddRadioButton, "Addition problem")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'FunctionGroupBox
        '
        Me.FunctionGroupBox.Controls.Add(Me.ExitButton)
        Me.FunctionGroupBox.Controls.Add(Me.SummaryButton)
        Me.FunctionGroupBox.Controls.Add(Me.ClearButton)
        Me.FunctionGroupBox.Controls.Add(Me.SubmitButton)
        Me.FunctionGroupBox.Location = New System.Drawing.Point(424, 12)
        Me.FunctionGroupBox.Name = "FunctionGroupBox"
        Me.FunctionGroupBox.Size = New System.Drawing.Size(200, 325)
        Me.FunctionGroupBox.TabIndex = 17
        Me.FunctionGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(6, 231)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(188, 62)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Enabled = False
        Me.SummaryButton.Location = New System.Drawing.Point(6, 163)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(188, 62)
        Me.SummaryButton.TabIndex = 12
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Generates the results for the Student")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(6, 95)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(188, 62)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears all information (ESC)")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(6, 27)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(188, 62)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Submit the Student's answer (ENTER)")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(635, 349)
        Me.Controls.Add(Me.FunctionGroupBox)
        Me.Controls.Add(Me.TypeGroupBox)
        Me.Controls.Add(Me.ProblemGroupBox)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.ProblemGroupBox.ResumeLayout(False)
        Me.ProblemGroupBox.PerformLayout()
        Me.TypeGroupBox.ResumeLayout(False)
        Me.TypeGroupBox.PerformLayout()
        Me.FunctionGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents ProblemGroupBox As GroupBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents TypeGroupBox As GroupBox
    Friend WithEvents FunctionGroupBox As GroupBox
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
