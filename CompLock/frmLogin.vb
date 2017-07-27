
Imports System.Data.OleDb
Imports Newtonsoft.Json
Imports System.Net.Http
Imports CompLock.ResponseOjects
Public Class frmLogin
    Private AllowWindowToClose As Boolean = False


    Private Async Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        If txtUsername.Text = "" Then          'validation: Presence Check
            MsgBox("Please enter your username")
            txtUsername.Focus()

        ElseIf txtPassword.Text = "" Then           'validation: Presence Check
            MsgBox("Enter your password")
            txtPassword.Focus()
        Else 'Presence Check Passed.
            Dim pairs As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            pairs.Add("username", txtUsername.Text)
            pairs.Add("password", txtPassword.Text)

            Dim formContent As FormUrlEncodedContent = New FormUrlEncodedContent(pairs)

            Try

                Dim http = New HttpClient()
                http.BaseAddress = New Uri("http://localhost:3000")
                Dim response = Await http.PostAsync("/auth/login", formContent)
                Dim json = Await response.Content.ReadAsStringAsync

                Dim Student As New Student()

                If response.StatusCode = 200 Then
                    Dim r As Success = JsonConvert.DeserializeObject(Of Success)(json)
                    MsgBox("success fully logged in " + r.user.type)
                Else
                    Dim r As Errors = JsonConvert.DeserializeObject(Of Errors)(json)
                    MsgBox("Access denied " + r.message)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

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