Imports Npgsql

Public Class FrmReports
    Dim Student As New Student
    Dim Administrator As New Administrator
    Sub New()
        InitializeComponent()
        lblReportTitle.Text = "- Not specified"

    End Sub
    Sub New(Username As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization afbter the InitializeComponent() call.
        Dim _student As New Student()
        _student.Initialize(Username)
        Student = _student
        lblReportTitle.Text = "- " & Student.GetFullName(Student.Username)
        dgvReport.DataSource = _student.GetMemberHistory(Student.Username)
    End Sub

    ''' <summary>
    ''' The administrator's full name. Also appears on the reports that are created.
    ''' </summary>
    Shared Property NameOfAdministrator As String

    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOnlineUsers_Click(sender As Object, e As EventArgs) Handles btnOnlineUsers.Click
        lblReportTitle.Text = "- Online Users Report"
        dgvReport.DataSource = Administrator.GetOnlineUsers()
    End Sub

    Private Sub btnListOfAccounts_Click(sender As Object, e As EventArgs) Handles btnListOfAccounts.Click
        lblReportTitle.Text = "- List of accounts Report"
        dgvReport.DataSource = Administrator.GetAllAccounts()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnGeneralReport_Click(sender As Object, e As EventArgs) Handles btnGeneralReport.Click
        lblReportTitle.Text = "- Today's Login Sessions Report"
        dgvReport.DataSource = Administrator.CreateTodayReport()
    End Sub

    Private Sub btnBlockedAccounts_Click(sender As Object, e As EventArgs) Handles btnBlockedAccounts.Click
        lblReportTitle.Text = "- Today's login session Report"
        dgvReport.DataSource = Administrator.GetAllBlockedUsers()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Administrator.PrintReport(dgvReport, lblReportTitle.Text, NameOfAdministrator, False)
    End Sub

    Private Sub btnSaveReport_Click(sender As Object, e As EventArgs) Handles btnSaveReport.Click
        Administrator.PrintReport(dgvReport, lblReportTitle.Text, NameOfAdministrator, True)

    End Sub

  
    Private Sub btnTodayLogins_Click(sender As Object, e As EventArgs) Handles btnTodayLogins.Click
        lblReportTitle.Text = "- All Login Sessions Report"
        dgvReport.DataSource = Administrator.CreateGeneralReport()
    End Sub
End Class