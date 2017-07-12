Public Class frmNotification
    Dim GoUp As Boolean
    Dim GoRight As Boolean
    Dim TimerLife = 0

    Private Sub frmNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerLife += 1
        If TimerLife = 100 Then
            Timer1.Stop()
            Close()
        End If
        If Me.Height <= 85 Then
            If Height = 78 Then
                GoUp = True
            End If
            If Height = 85 Then
                GoUp = False
            End If
        End If

        If Me.Width <= 435 Then
            If Width = 430 Then
                GoRight = True
            End If
            If Width = 435 Then
                GoRight = False
            End If
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