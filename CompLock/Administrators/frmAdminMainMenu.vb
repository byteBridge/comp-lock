Public Class frmAdminMainMenu

    ''' <summary>
    ''' The administrator's full name. Also appears on the reports that are created.
    ''' </summary>
    Property NameOfAdministrator As String

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs)
        frmCreateAccount.ShowDialog()
    End Sub

    Private Sub btnViewAccounts_Click(sender As Object, e As EventArgs)
        frmViewAccounts.NameOfAdministrator = NameOfAdministrator
        frmViewAccounts.ShowDialog()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs)
        FrmReports.NameOfAdministrator = NameOfAdministrator
        FrmReports.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmSettings.ShowDialog()
    End Sub

    Private Sub btnShutDown_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to quit this program?", "Really sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub frmAdminMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = "Hello, " & NameOfAdministrator
    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmAdminMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason <> CloseReason.ApplicationExitCall Then
            frmLogin.Show()

        End If
    End Sub

    Private Sub btnOpenAdminConsole_Click(sender As Object, e As EventArgs) Handles btnOpenAdminConsole.Click
        Try
            Dim ApiUrlAndPort As String = My.Settings.ApiServerURL & ":" & My.Settings.ApiServerPort
            Process.Start(ApiUrlAndPort & "/#/admin")
        Catch ex As Exception

        End Try
    End Sub

End Class