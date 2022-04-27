Option Strict On
Imports System.Math

Public Class frmMain
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim inputArray(txtInput.Text.Trim.Length) As Char
        Dim outputArray(txtInput.Text.Trim.Length) As Char
        Dim tempValue As Integer

        If radEncrypt.Checked = True Then
            inputArray = txtInput.Text.ToLower.ToCharArray
            For c = 0 To inputArray.Length - 1
                If Asc(inputArray(c)) < 97 OrElse Asc(inputArray(c)) > 122 Then
                    outputArray(c) = inputArray(c)
                Else
                    tempValue = Lett2Num(inputArray(c))
                    outputArray(c) = Num2Lett((Convert.ToInt32(txtA.Text) * tempValue + Convert.ToInt32(txtB.Text)) Mod 26)
                End If
            Next
            txtOutput.Text = New String(outputArray)
        Else
            inputArray = txtInput.Text.ToLower.ToCharArray
            For c = 0 To inputArray.Length - 1
                If Asc(inputArray(c)) < 97 OrElse Asc(inputArray(c)) > 122 Then
                    outputArray(c) = inputArray(c)
                Else
                    tempValue = Lett2Num(inputArray(c))
                    outputArray(c) = Num2Lett((Convert.ToInt32(txtA.Text) * tempValue + Convert.ToInt32(txtB.Text)) Mod 26)
                End If
            Next
            txtOutput.Text = New String(outputArray)
        End If

        'GCF NOT WORKING
        txtValid.Text = Convert.ToString(GCF(Convert.ToInt32(txtA.Text)))
    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        radEncrypt.Checked = True
        txtA.Text = ""
        txtB.Text = ""
        txtInput.Text = ""
        txtOutput.Text = ""
        txtA.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function Lett2Num(ByVal Lett As Char) As Integer
        Select Case Lett
            Case "a"c : Return 0
            Case "b"c : Return 1
            Case "c"c : Return 2
            Case "d"c : Return 3
            Case "e"c : Return 4
            Case "f"c : Return 5
            Case "g"c : Return 6
            Case "h"c : Return 7
            Case "i"c : Return 8
            Case "j"c : Return 9
            Case "k"c : Return 10
            Case "l"c : Return 11
            Case "m"c : Return 12
            Case "n"c : Return 13
            Case "o"c : Return 14
            Case "p"c : Return 15
            Case "q"c : Return 16
            Case "r"c : Return 17
            Case "s"c : Return 18
            Case "t"c : Return 19
            Case "u"c : Return 20
            Case "v"c : Return 21
            Case "w"c : Return 22
            Case "x"c : Return 23
            Case "y"c : Return 24
            Case Else : Return 25
        End Select
    End Function

    Private Function Num2Lett(ByVal Num As Integer) As Char
        Select Case Num
            Case 0 : Return "a"c
            Case 1 : Return "b"c
            Case 2 : Return "c"c
            Case 3 : Return "d"c
            Case 4 : Return "e"c
            Case 5 : Return "f"c
            Case 6 : Return "g"c
            Case 7 : Return "h"c
            Case 8 : Return "i"c
            Case 9 : Return "j"c
            Case 10 : Return "k"c
            Case 11 : Return "l"c
            Case 12 : Return "m"c
            Case 13 : Return "n"c
            Case 14 : Return "o"c
            Case 15 : Return "p"c
            Case 16 : Return "q"c
            Case 17 : Return "r"c
            Case 18 : Return "s"c
            Case 19 : Return "t"c
            Case 20 : Return "u"c
            Case 21 : Return "v"c
            Case 22 : Return "w"c
            Case 23 : Return "x"c
            Case 24 : Return "y"c
            Case Else : Return "z"c
        End Select
    End Function

    'THIS DOESN'T WORK YET
    Private Function GCF(ByVal num As Integer) As Integer
        Dim a As Integer = Math.Max(num, 26)
        Dim b As Integer = Math.Min(num, 26)
        Dim c As Integer = a \ b
        Dim d As Integer

        While d <> 0
            d = a - c * b
            If d = 0 Then
                Exit While
            Else
                a = b
                b = d
                c = a \ b
            End If
        End While

        Return c
    End Function
End Class
