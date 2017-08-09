Imports CompLock
Imports System.Net.Http
Public Class frmRemainingTime
    Private Student As Student
    Private AllowWindowToClose As Boolean = False

    Private StartTime As DateTime = DateTime.Now.ToString("HH:mm:ss")
    Private Duration As DateTime = "00:00:00"
    Private TodayDate As String = DateTime.Today.ToString("MM/dd/yyyy")
    Private TimeSpanDuration As TimeSpan
    Private TotalTimeUsed As DateTime = "00:00:00"
    Private TimeLimits As DateTime = "00:00:00"
    Private RemainingTime As DateTime = "00:00:00"


    'these variables keep track of the count downn
    Private Hours, Minutes, Seconds As Integer

    Public Sub New(student As Student)
        'initialize the form first
        InitializeComponent()


        Me.Student = student
        'greet the student
        lblHelloStudentName.Text = student.FullName()

        'Get the values of the Total time used by the student and the time limit from the database
        TotalTimeUsed = student.TotalTimeUsed 'TimeOperations.GetTotalUpTime(student.Username)
        TimeLimits = student.TimeLimits 'TimeOperations.GetTimeLimits(student.Type)

        'Calculate the amount of time used by the student by determining the differrence between the total time used and the time limits set by the administrator
        TimeSpanDuration = TimeLimits - TotalTimeUsed
        RemainingTime = TimeSpanDuration.Hours & ":" & TimeSpanDuration.Minutes & ":" & TimeSpanDuration.Seconds

        'Populate the labels with the initial data from the database and give them appropriate formatting
        lblStartTime.Text = StartTime
        lblDuration.Text = CDate(TotalTimeUsed).ToString("HH:mm:ss")
        lblMaxTimeAllowed.Text = CDate(TimeLimits).ToString("HH:mm:ss")
        lblRemainingTime.Text = RemainingTime
        lblComputerName.Text = Environment.UserName
        'Start the timer so that count down begins
        tmrStudentSession.Start()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        AllowWindowToClose = True
        frmLogin.Show()
        Close()
    End Sub




    Private Sub frmRemainingTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If AllowWindowToClose = True Then
            Student.Logout(StartTime, Duration.ToString("HH:mm:ss"), TodayDate, Environment.UserName)
            'close the notification window if it is open
            frmNotification.Close()
        Else
            'record the entries of today's log session even when the computer is being shutdown or the app is being closed remotely
            If e.CloseReason <> CloseReason.UserClosing Then
                Student.Logout(StartTime, Duration.ToString("HH:mm:ss"), TodayDate, Environment.UserName)

                'close the notification window if it is open
                frmNotification.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub tmrStudentSession_Tick(sender As Object, e As EventArgs) Handles tmrStudentSession.Tick

        'Total time used
        TotalTimeUsed = TotalTimeUsed.AddSeconds(1)
        Duration = Duration.AddSeconds(1)
        lblDuration.Text = CDate(TotalTimeUsed).ToString("HH:mm:ss")

        'Remaining time
        TimeSpanDuration = TimeLimits - TotalTimeUsed
        lblRemainingTime.Text = TimeSpanDuration.ToString()

        NotifyRemainingTime(TimeSpanDuration)
        If TotalTimeUsed = TimeLimits Then
            AllowWindowToClose = True
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmRemainingTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' NotifyIcon1.ShowBalloonTip(0)
        Dim Rect As New Rectangle
        Rect = Screen.GetWorkingArea(New Point(0, 0))
        Me.Location = New Point(10, Rect.Height - 250)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NotifyIcon1.ShowBalloonTip(2000)
        NotifyIcon1.Visible = True
    End Sub

    ''' <summary>
    ''' Moves the window upwards by the number of pixels specified.
    ''' Negative pixel count = positive y-axis translation.
    ''' Positive pixel count = negative y-axis translation.
    ''' </summary>
    Private Sub MoveWindow(PixelsUp As Integer)
        'Set the new y - location
        Dim y As Integer = Me.Location.Y + PixelsUp
        Me.Location = New Point(Me.Location.X, y)


    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Try
            Process.Start("http://localhost:3000/#students/" + Student.Username)
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' WRITTEN BY: Kudakwashe Paradzayi
    ''' PURPOSE: It displays the notification form that informs the student that time is running out.
    ''' DATE: Sunday 22 May 2016
    ''' </summary>
    Private Sub NotifyRemainingTime(TimeSpanDuration As TimeSpan)
        'The time remaining before the user is logged out.
        Dim RemainingTime As Date = CDate(TimeSpanDuration.ToString())

        If RemainingTime.Hour = 0 Then
            If RemainingTime.Minute = 5 And RemainingTime.Second = 55 Then
                'only show the notification form when 5 minutes is left
                frmNotification.Show()
            End If
        End If
    End Sub

    Private Sub btnViewHelp_Click(sender As Object, e As EventArgs) Handles btnViewHelp.Click
        Try
            Process.Start("http://localhost:3000/#help")
        Catch ex As Exception

        End Try
    End Sub
End Class