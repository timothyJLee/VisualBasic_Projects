



'PROGRAM:  Pythagoras Object Oriented
'AUTHOR:  Timothy Lee
'Purpose: The Purpose of this program is to build an object oriented version of the Pythagoras Project we've been working on. 
' PURPOSE OF CLASS: To Calculate Each Leg of a Right Triangle Based on Input given on the Form


Option Explicit On
Option Strict On


Public Class PythagorasCalculator

#Region " PRIVATE "

    ' Class Level (Module Level) Declarations
    ' Each Side as Variables
    Private _SideA As Decimal
    Private _SideB As Decimal
    Private _SideC As Decimal

    Private _ErrorMessage As String

    ' Subs, Functions
    ' ? Calculate steps for each side
    Private Sub SetDefaults()
        _SideA = 0
        _SideB = 0
        _SideC = 0

        _ErrorMessage = String.Empty
    End Sub

    Private Function CalculateA(ByVal _SideC As Decimal, ByVal _SideB As Decimal) As String
        Dim ReturnValue As Boolean = False

        If _SideB < _SideC Then
            _SideA = Convert.ToDecimal(Math.Sqrt(Math.Pow(_SideC, 2) - Math.Pow(_SideB, 2)))
            ReturnValue = True
        Else
            _ErrorMessage = "B must be less than C"
            ReturnValue = False
        End If

        If ReturnValue = True Then
            Return (_SideA).ToString
        Else
            Return _ErrorMessage
        End If
    End Function

    Private Function CalculateB(ByVal _SideC As Decimal, ByVal _SideA As Decimal) As String
        Dim ReturnValue As Boolean = False

        If _SideA < _SideC Then
            _SideB = Convert.ToDecimal(Math.Sqrt(Math.Pow(_SideC, 2) - Math.Pow(_SideA, 2)))
            ReturnValue = True
        Else
            _ErrorMessage = "A must be less than C"
            ReturnValue = False
        End If

        If ReturnValue = True Then
            Return (_SideB).ToString
        Else
            Return _ErrorMessage
        End If
    End Function

    Private Function CalculateC(ByVal _SideA As Decimal, ByVal _SideB As Decimal) As String
        Dim ReturnValue As Boolean = False

        _SideC = Convert.ToDecimal(Math.Sqrt(Math.Pow(_SideA, 2) + Math.Pow(_SideB, 2)))
        ReturnValue = True

        If ReturnValue = True Then
            Return (_SideC).ToString
        Else
            Return _ErrorMessage
        End If
    End Function

#End Region


#Region " PUBLIC "

    ' PROPERTIES
    ' Side a, b, c
    ' Property SideA As Decimal ' Automatic Property can only be Read/Write.  No Write or Read Only.
    ReadOnly Property SideA As Decimal ' SideA used outside of class(PUBLIC)
        Get
            Return _SideA ' _SideA used inside the class(PRIVATE)
        End Get
    End Property

    ReadOnly Property SideB As Decimal
        Get
            Return _SideB
        End Get
    End Property

    ReadOnly Property SideC As Decimal
        Get
            Return _SideC
        End Get
    End Property

    ReadOnly Property ErrorMessage As String
        Get
            Return _ErrorMessage
        End Get
    End Property

    ' METHODS
    Public Sub New()    ' Constructor
        ' First Stuff to Happen
        SetDefaults()
        ' setting defaults (Call to Local Sub)
    End Sub


    'Public Function Calculate() As Boolean

    '    Return True
    'End Function

    ''' <summary>
    ''' Calculates Side that is zero. Requires 2 numbers > 0.
    ''' </summary>
    ''' <param name="A"></param>
    ''' <param name="B"></param>
    ''' <param name="C"></param>
    ''' <returns>Boolean - true if calculation successful</returns>
    ''' <remarks></remarks>
    Public Function Calculate(ByVal A As Decimal, ByVal B As Decimal, ByVal C As Decimal) As String
        Dim ReturnValue As String = String.Empty

        Select Case True
            Case Form1.bTextBox.Text.Trim.Length > 0 And Form1.cTextBox.Text.Trim.Length > 0
                ReturnValue = CalculateA(C, B)
            Case Form1.aTextBox.Text.Trim.Length > 0 And Form1.cTextBox.Text.Trim.Length > 0
                ReturnValue = CalculateB(C, A)
            Case Form1.aTextBox.Text.Trim.Length > 0 And Form1.bTextBox.Text.Trim.Length > 0
                ReturnValue = CalculateC(A, B)
            Case Else
                _ErrorMessage = "Unknown Error"
                Return _ErrorMessage
        End Select

        Return ReturnValue
    End Function

#End Region


End Class
