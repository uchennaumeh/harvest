﻿Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Text
Namespace Numtowords

    Public Class Words

        Public Function changeNumericToWords(ByVal numb As Double) As [String]
            Dim num As [String] = numb.ToString()
            Return changeToWords(num, False)
        End Function

        Public Function changeCurrencyToWords(ByVal numb As [String]) As [String]
            Return changeToWords(numb, True)
        End Function

        Public Function changeNumericToWords(ByVal numb As [String]) As [String]
            Return changeToWords(numb, False)
        End Function

        Public Function changeCurrencyToWords(ByVal numb As Double) As [String]
            Return changeToWords(numb.ToString(), True)
        End Function

        Private Function changeToWords(ByVal numb As [String], ByVal isCurrency As Boolean) As [String]
            Dim val As [String] = "", wholeNo As [String] = numb, points As [String] = "", andStr As [String] = "", pointStr As [String] = ""
            Dim endStr As [String] = If((isCurrency), ("Only"), (""))
            Try
                Dim decimalPlace As Integer = numb.IndexOf(".")
                If decimalPlace > 0 Then
                    wholeNo = numb.Substring(0, decimalPlace)
                    points = numb.Substring(decimalPlace + 1)
                    If Convert.ToInt32(points) > 0 Then
                        andStr = If((isCurrency), ("Naira, "), ("."))
                        ' just to separate whole numbers from points/Naira
                        endStr = If((isCurrency), ("Kobo " & endStr), (""))
                        pointStr = translateNaira(points)
                    End If
                End If
                val = [String].Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr)
            Catch


            End Try
            Return val
        End Function

        Private Function translateWholeNumber(ByVal number As [String]) As [String]
            Dim word As String = ""
            Try
                Dim beginsZero As Boolean = False
                'tests for 0XX
                Dim isDone As Boolean = False
                'test if already translated
                Dim dblAmt As Double = (Convert.ToDouble(number))
                'if ((dblAmt > 0) && number.StartsWith("0"))

                If dblAmt > 0 Then
                    'test for zero or digit zero in a nuemric
                    beginsZero = number.StartsWith("0")
                    Dim numDigits As Integer = number.Length
                    Dim pos As Integer = 0
                    'store digit grouping
                    Dim place As [String] = ""
                    'digit grouping name:hundres,thousand,etc...
                    Select Case numDigits
                        Case 1
                            'ones' range
                            word = ones(number)
                            isDone = True
                            Exit Select
                        Case 2
                            'tens' range
                            word = tens(number)
                            isDone = True
                            Exit Select
                        Case 3
                            'hundreds' range
                            pos = (numDigits Mod 3) + 1
                            place = " Hundred "
                            Exit Select
                            'thousands' range
                        Case 4, 5, 6
                            pos = (numDigits Mod 4) + 1
                            place = " Thousand "
                            Exit Select
                            'millions' range
                        Case 7, 8, 9
                            pos = (numDigits Mod 7) + 1
                            place = " Million "
                            Exit Select
                        Case 10
                            'Billions's range
                            pos = (numDigits Mod 10) + 1
                            place = " Billion "
                            Exit Select
                        Case Else
                            'add extra case options for anything above Billion...
                            isDone = True
                            Exit Select
                    End Select
                    If Not isDone Then
                        'if transalation is not done, continue...(Recursion comes in now!!)
                        word = translateWholeNumber(number.Substring(0, pos)) & place & translateWholeNumber(number.Substring(pos))
                        'check for trailing zeros
                        If beginsZero Then
                            word = " and " & word.Trim()
                        End If
                    End If
                    'ignore digit grouping names
                    If word.Trim().Equals(place.Trim()) Then
                        word = ""
                    End If
                End If
            Catch


            End Try
            Return word.Trim()
        End Function

        Private Function tens(ByVal digit As [String]) As [String]
            Dim digt As Integer = Convert.ToInt32(digit)
            Dim name As [String] = Nothing
            Select Case digt
                Case 10
                    name = "Ten"
                    Exit Select
                Case 11
                    name = "Eleven"
                    Exit Select
                Case 12
                    name = "Twelve"
                    Exit Select
                Case 13
                    name = "Thirteen"
                    Exit Select
                Case 14
                    name = "Fourteen"
                    Exit Select
                Case 15
                    name = "Fifteen"
                    Exit Select
                Case 16
                    name = "Sixteen"
                    Exit Select
                Case 17
                    name = "Seventeen"
                    Exit Select
                Case 18
                    name = "Eighteen"
                    Exit Select
                Case 19
                    name = "Nineteen"
                    Exit Select
                Case 20
                    name = "Twenty"
                    Exit Select
                Case 30
                    name = "Thirty"
                    Exit Select
                Case 40
                    name = "Fourty"
                    Exit Select
                Case 50
                    name = "Fifty"
                    Exit Select
                Case 60
                    name = "Sixty"
                    Exit Select
                Case 70
                    name = "Seventy"
                    Exit Select
                Case 80
                    name = "Eighty"
                    Exit Select
                Case 90
                    name = "Ninety"
                    Exit Select
                Case Else
                    If digt > 0 Then
                        name = tens(digit.Substring(0, 1) & "0") & " " & ones(digit.Substring(1))
                    End If
                    Exit Select
            End Select
            Return name
        End Function

        Private Function ones(ByVal digit As [String]) As [String]
            Dim digt As Integer = Convert.ToInt32(digit)
            Dim name As [String] = ""
            Select Case digt
                Case 1
                    name = "One"
                    Exit Select
                Case 2
                    name = "Two"
                    Exit Select
                Case 3
                    name = "Three"
                    Exit Select
                Case 4
                    name = "Four"
                    Exit Select
                Case 5
                    name = "Five"
                    Exit Select
                Case 6
                    name = "Six"
                    Exit Select
                Case 7
                    name = "Seven"
                    Exit Select
                Case 8
                    name = "Eight"
                    Exit Select
                Case 9
                    name = "Nine"
                    Exit Select
            End Select
            Return name
        End Function

        Private Function translateNaira(ByVal Naira As [String]) As [String]
            Dim cts As [String] = "", digit As [String] = "", engOne As [String] = ""
            For i As Integer = 0 To Naira.Length - 1
                digit = Naira(i).ToString()
                If digit.Equals("0") Then
                    engOne = "Zero"
                Else
                    engOne = ones(digit)
                End If
                cts += " " & engOne
            Next
            Return cts
        End Function
    End Class
End Namespace


