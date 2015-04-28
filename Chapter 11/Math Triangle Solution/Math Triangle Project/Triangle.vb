' Name:         Triangle Project
' Purpose:      Displays a grade based on the number of points the user enters
' Programmer:   Joshua Hipple on 4/28/15
' Class:        CIS 230 - W1

Public Class Triangle
    Private _dblBase As Double
    Private _dblHeight As Double

    Public Property Base As Double
        Get
            Return _dblBase
        End Get
        Set(value As Double)
            If value > 0 Then
                _dblBase = value
            Else
                _dblBase = 0
            End If
        End Set
    End Property
    Public Property Height As Double
        Get
            Return _dblHeight
        End Get
        Set(value As Double)
            If value > 0 Then
                _dblHeight = value
            Else
                _dblHeight = 0
            End If
        End Set
    End Property

    Public Sub New()
        Base = 0
        Height = 0
    End Sub

    Public Function GetArea() As Double
        Return ((_dblBase * _dblHeight) / 2)
    End Function

    Public Function GetPerimeter() As Double
        Return (_dblBase * 3)
    End Function
End Class
