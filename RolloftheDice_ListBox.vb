Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Roll of the Dice
'https://github.com/dylannelson58/RolloftheDice_ListBox

Public Class RolloftheDice_ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Formatting()

    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        DiceOutcomeListBox.Items.Clear()
        Dim numberString As String
        Dim randomNumbers(10) As Integer
        Dim result As Integer

        For i = 0 To 1000
            result = GetRandomNumber(5) + GetSecondRandomNumber(5)
            randomNumbers(result) += 1
        Next

        Formatting()

        For i = 0 To UBound(randomNumbers)
            numberString &= CStr(randomNumbers(i)).PadLeft(6) & "|"
        Next

        DiceOutcomeListBox.Items.Add(numberString)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        Dim numberString As String
        Dim randomNumbers(10) As Integer
        Dim result As Integer

        DiceOutcomeListBox.Items.Clear()

        For i = 0 To 1000
            result = GetRandomNumber(5) + GetSecondRandomNumber(5)
            randomNumbers(result) = 0
        Next

        Formatting()

        For i = 0 To UBound(randomNumbers)
            numberString &= CStr(0).PadLeft(6) & "|"
        Next

        DiceOutcomeListBox.Items.Add(numberString)
    End Sub

    Public Function Formatting() As Integer


        Dim diceNumbersString As String
        Dim header As Integer

        header = CInt((77 - 16) / 2)
        DiceOutcomeListBox.Items.Add((StrDup(header, " ") & "Roll of the Dice" & StrDup(header, " ")))
        DiceOutcomeListBox.Items.Add((StrDup(77, "-")))

        For i = 2 To 12
            diceNumbersString &= ((Str(i).PadLeft(6) & "|"))
        Next

        DiceOutcomeListBox.Items.Add(diceNumbersString)

        DiceOutcomeListBox.Items.Add((StrDup(77, "-")))

    End Function

    Private Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

    Private Function GetSecondRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
