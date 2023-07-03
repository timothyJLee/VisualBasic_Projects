

'PROGRAM:  Pythagoras Object Oriented
'AUTHOR:  Timothy Lee
'Purpose: The Purpose of this program is to build an object oriented version of the Pythagoras Project we've been working on. 
' PURPOSE OF CLASS: To Set and Define the Value that Decides Whether to Calculate or Not


Option Explicit On
Option Strict On


Public Class CalculateDecision

    Private Decision As Boolean = False

    ReadOnly Property Calculate As Boolean
        Get
            Return Decision
        End Get
    End Property

    'ReadOnly Property DontCalculate As Boolean
    '    Get
    '        Return Not Decision
    '    End Get
    'End Property

    Public Sub CalculateYes()
        Decision = True
    End Sub

    Public Sub CalculateNo()
        Decision = False
    End Sub

End Class
