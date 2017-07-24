
Imports System.Data.OleDb
Public Class frmLogin
    Private AllowWindowToClose As Boolean = False


    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        If txtUsername.Text = "" Then          'validation: Presence Check
            MsgBox("Please enter your username")
            txtUsername.Focus()

        ElseIf txtPassword.Text = ""           'validation: Presence Check
            MsgBox("Enter your password")
            txtPassword.Focus()
        Else 'Presence Check Passed.
            Dim Student As New Student()
            Student.Initialize(txtUsername.Text)
            Try
                Dim LoginSuccess As Boolean = Student.Login(txtUsername.Text, txtPassword.Text)
                Select Case LoginSuccess
                    Case True
                        If Student.Type.ToLower <> "administrator" Then
                            Dim StudentForm As New frmRemainingTime(Student)
                            StudentForm.Show()
                            AllowWindowToClose = True
                            Me.Close()
                        ElseIf Student.Type.ToLower = "administrator"
                            Dim AdminForm As New frmAdminMainMenu
                            AdminForm.NameOfAdministrator = Student.FullName()
                            AdminForm.Show()
                            AllowWindowToClose = True
                            Me.Close()
                        End If

                    Case False
                        MessageBox.Show("The System could not log you in. You have entered invalid credentials, try again", "Invalid details", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If



    End Sub

    Private Sub btnEmergencyExit_Click(sender As Object, e As EventArgs) Handles btnEmergencyExit.Click
        Dim EmergencyShutdown As New frmInputEmergencyPassword
        EmergencyShutdown.ShowDialog()
        If My.Settings.EmergencyPassword = EmergencyShutdown.EmergencyPassword Then
            AllowWindowToClose = True
            Application.Exit()
        End If
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If AllowWindowToClose = True Then
            'allow window to close
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.ShowDialog()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tlstrpEmergencyExit_Click(sender As Object, e As EventArgs) Handles tlstrpEmergencyExit.Click
        Dim EmergencyShutdown As New frmInputEmergencyPassword
        EmergencyShutdown.ShowDialog()
        If My.Settings.EmergencyPassword = EmergencyShutdown.EmergencyPassword Then
            AllowWindowToClose = True
            Application.Exit()
        End If
    End Sub

    Private Sub tlstrpHelp_Click(sender As Object, e As EventArgs) Handles tlstrpHelp.Click
        frmHelp.ShowDialog()

    End Sub
End Class