

'PROGRAM:  Pythagoras Object Oriented
'AUTHOR:  Timothy Lee
'Purpose: The Purpose of this program is to build an object oriented version of the Pythagoras Project we've been working on.  


'TODO:  Find Something To Do


Option Explicit On
Option Strict On


Public Class Form1
    Dim PythagorasCalculatorObject As New PythagorasCalculator

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub SetDefaults()
        aTextBox.Text = String.Empty
        bTextBox.Text = String.Empty
        cTextBox.Text = String.Empty
    End Sub



    Private Sub CalculateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Validate that values entered can be numbers
        ' and are converted to numbers.
        ' Do we have to know about too much, too little?

        Dim CalculateDecisionObject As New CalculateDecision

        Dim SideA As Decimal = 0
        Dim SideB As Decimal = 0
        Dim SideC As Decimal = 0
        Dim ErrorMessage As String = String.Empty

        Select Case True


            'Case Not Decimal.TryParse(aTextBox.Text, SideA)
            '    ' Failed to Convert
            '    ErrorMessage = "Not a value for Leg A"
            '    CalculateDecisionObject.CalculateNo()
            'Case Not Decimal.TryParse(bTextBox.Text, SideB)
            '    ' Failed to Convert
            '    ErrorMessage = "Not a Value For Leg B"
            '    CalculateDecisionObject.CalculateNo()
            'Case Not Decimal.TryParse(cTextBox.Text, SideC)
            '    ' Failed to Convert
            '    ErrorMessage = "Not a Value For Hypotenuse C"
            '    CalculateDecisionObject.CalculateNo()

            Case aTextBox.Text.Trim.Length > 0 And bTextBox.Text.Trim.Length > 0 And cTextBox.Text.Trim.Length > 0
                ' Too Much
                ErrorMessage = "Entered too many Values.  Please Delete One."
                CalculateDecisionObject.CalculateNo()

            Case aTextBox.Text.Trim.Length = 0 And bTextBox.Text.Trim.Length = 0
                ' can't calc C
                ErrorMessage = "Please enter at least two values."
                CalculateDecisionObject.CalculateNo()
            Case aTextBox.Text.Trim.Length = 0 And cTextBox.Text.Trim.Length = 0
                ' Can't Calc B
                ErrorMessage = "Please enter at least two values."
                CalculateDecisionObject.CalculateNo()
            Case bTextBox.Text.Trim.Length = 0 And cTextBox.Text.Trim.Length = 0
                ' Can't Calc A
                ErrorMessage = "Please enter at least two values."
                CalculateDecisionObject.CalculateNo()
            Case aTextBox.Text.Trim.Length = 0 And bTextBox.Text.Trim.Length = 0 And cTextBox.Text.Trim.Length = 0
                ' No Data
                ErrorMessage = "Entered No Data.  Please enter at least two values."
                CalculateDecisionObject.CalculateNo()

            Case aTextBox.Text.Trim.Length > 0 And bTextBox.Text.Trim.Length > 0
                If Not Decimal.TryParse(bTextBox.Text, SideB) Then
                    ErrorMessage = "That is not a number for B"
                    CalculateDecisionObject.CalculateNo()
                ElseIf Not Decimal.TryParse(aTextBox.Text, SideA) Then
                    ErrorMessage = "That is not a number for A"
                    CalculateDecisionObject.CalculateNo()
                Else
                    CalculateDecisionObject.CalculateYes()
                End If

            Case bTextBox.Text.Trim.Length > 0 And cTextBox.Text.Trim.Length > 0
                If Not Decimal.TryParse(bTextBox.Text, SideB) Then
                    ErrorMessage = "That is not a number for B"
                    CalculateDecisionObject.CalculateNo()
                ElseIf Not Decimal.TryParse(cTextBox.Text, SideC) Then
                    ErrorMessage = "That is not a number for C"
                    CalculateDecisionObject.CalculateNo()
                Else
                    CalculateDecisionObject.CalculateYes()
                End If

            Case cTextBox.Text.Trim.Length > 0 And aTextBox.Text.Trim.Length > 0
                If Not Decimal.TryParse(cTextBox.Text, SideC) Then
                    ErrorMessage = "That is not a number for C"
                    CalculateDecisionObject.CalculateNo()
                ElseIf Not Decimal.TryParse(aTextBox.Text, SideA) Then
                    ErrorMessage = "That is not a number for A"
                    CalculateDecisionObject.CalculateNo()
                Else
                    CalculateDecisionObject.CalculateYes()
                End If

            Case Else
                ' Need to handle true Exceptions(Unknowns)
                ' Run Equation
                ' worked
                ' Display Values
                CalculateDecisionObject.CalculateNo()
                ErrorMessage = "Unknown Error"
        End Select

        If CalculateDecisionObject.Calculate = True Then
            Select Case True
                Case bTextBox.Text.Trim.Length > 0 And cTextBox.Text.Trim.Length > 0
                    aTextBox.Text = PythagorasCalculatorObject.Calculate(SideA, SideB, SideC)
                Case aTextBox.Text.Trim.Length > 0 And cTextBox.Text.Trim.Length > 0
                    bTextBox.Text = PythagorasCalculatorObject.Calculate(SideA, SideB, SideC)
                Case aTextBox.Text.Trim.Length > 0 And bTextBox.Text.Trim.Length > 0
                    cTextBox.Text = PythagorasCalculatorObject.Calculate(SideA, SideB, SideC)
                Case Else
                    ErrorMessage = "Unknown Error"
            End Select
        Else
            MessageBox.Show(ErrorMessage)
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        aTextBox.Text = String.Empty
        bTextBox.Text = String.Empty
        cTextBox.Text = String.Empty
    End Sub
End Class


