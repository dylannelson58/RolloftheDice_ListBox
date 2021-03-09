Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Roll of the Dice
'https://github.com/dylannelson58/RolloftheDice

Public Class RolloftheDice_ListBox

    Dim randomNumbers(10) As Integer
    Dim header As Integer
    Dim result As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Formatting()

    End Sub


    Private Function GetRandomNumber(maxNumber As Integer) As Integer                               'function to get a random number for 2-12
        Randomize(DateTime.Now.Millisecond)                                                         'randomizes the number down to the current milisecond
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))                                            'returns a random number equal to or less than the maxNumber + 1
    End Function                                                                                    'ends function

    Private Function GetSecondRandomNumber(maxNumber As Integer) As Integer                         'function to get a random number for 2-12
        Randomize(DateTime.Now.Millisecond)                                                         'randomizes the number down to the current milisecond
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))                                            'returns a random number equal to or less than the maxNumber + 1
    End Function

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click

        DiceOutcomeTextBox.Text = ""

        For i = 0 To 1000                                                                           'executes 1000 rolls of the two dice
            result = GetRandomNumber(5) + GetSecondRandomNumber(5)                                  'adds the two functions into a variable that can be called later
            randomNumbers(result) += 1                                                              'adds 1 to the formatting ensuring that 0-1 is never recorded
        Next

        Formatting()

    End Sub



    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        Formatting()
    End Sub

    Public Function Formatting() As Integer
        header = CInt((110 - 16) / 2)                                                                '77 because that is the amount of "-"s used 16 is the length of "roll of the dice" phrase /2 to center the header
        DiceOutcomeTextBox.Text &= (StrDup(header, " ") & "Roll of the Dice" & StrDup(header, " ")) & vbNewLine & _            'Applying the header variable to the "roll of the dice"
        (StrDup(110, "-")) & vbNewLine                                                                                                       'Adding dashes to format

        For i = 2 To 12                                                                             '2-12 is the combinations of possible dice sum outcomes 
            DiceOutcomeTextBox.Text &= (Str(i).PadLeft(8) & "|")                                                  'More formatting
        Next                                                                                        'ends the for loop

        DiceOutcomeTextBox.Text &= vbNewLine & (StrDup(110, "-")) & vbNewLine                                                                                         'ends the line

        For i = 0 To UBound(randomNumbers)
            DiceOutcomeTextBox.Text &= (CStr(randomNumbers(i)).PadLeft(8) & "|")
        Next
    End Function

End Class
