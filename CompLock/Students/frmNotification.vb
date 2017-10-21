Public Class frmNotification
    Dim GoUp As Boolean = True
    Dim GoRight As Boolean = True
    Dim TimerLife = 0

    Private Sub frmNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Dim evenOrOdd As Integer = 0
    Dim counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerLife += 1
        If TimerLife = 100 Then
            Timer1.Stop()
            Close()
        End If

        counter += 1
        If counter = 10 Then
            If evenOrOdd Mod 2 = 0 Then
                GoRight = Not GoRight
                GoUp = Not GoUp
            Else
                GoRight = Not GoRight
                GoUp = Not GoUp
            End If
            counter = 0
            evenOrOdd += 1
        End If


        If GoUp Then
            Height += 1
        Else
            Height -= 1
        End If

        If GoRight Then
            Width += 1
        Else
            Width -= 1
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class