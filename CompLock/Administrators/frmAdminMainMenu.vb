Public Class frmAdminMainMenu

    ''' <summary>
    ''' The administrator's full name. Also appears on the reports that are created.
    ''' </summary>
    Property NameOfAdministrator As String

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        frmCreateAccount.ShowDialog()
    End Sub

    Private Sub btnViewAccounts_Click(sender As Object, e As EventArgs) Handles btnViewAccounts.Click
        frmViewAccounts.NameOfAdministrator = NameOfAdministrator
        frmViewAccounts.ShowDialog()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        FrmReports.NameOfAdministrator = NameOfAdministrator
        FrmReports.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub btnShutDown_Click(sender As Object, e As EventArgs) Handles btnShutDown.Click
        If MessageBox.Show("Are you sure you want to quit this program?", "Really sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub frmAdminMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = "Hello, " & NameOfAdministrator
    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmAdminMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason <> CloseReason.ApplicationExitCall Then
            frmLogin.Show()

        End If
    End Sub
End Class