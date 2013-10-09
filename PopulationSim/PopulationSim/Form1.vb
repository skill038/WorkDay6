Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim currentY As Integer
        Dim currentP As Double

        currentY = 2012
        currentP = 7000

        Do While (currentP > 6)
            currentY = currentY - 50
            currentP = currentP / 2
        Loop

        MessageBox.Show("The year is " & currentY)

    End Sub
End Class
