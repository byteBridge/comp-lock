
Imports System.Data.OleDb
Imports Newtonsoft.Json
Imports System.Net.Http
Imports CompLock.ResponseOjects
Public Class frmLogin
    Private AllowWindowToClose As Boolean = False

    ''' <summary>
    ''' Change the state of the signin button (text and enabled)
    ''' to show that the app is loading
    ''' </summary>
    ''' <param name="show">If true the progress shows, else it does not</param>
    Sub showProgress(show As Boolean)
        progSignin.Visible = show
    End Sub

    Private Async Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        showProgress(True)

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
                Dim response = Await http.PostAsync("/auth/login?app=desktop&computer_name=" + Environment.UserName, formContent)
                Dim json = Await response.Content.ReadAsStringAsync

                Dim Student As New Student()
                If response.StatusCode = 200 Then
                    Dim r As Success = JsonConvert.DeserializeObject(Of Success)(json)
                    MsgBox("success fully logged in " + r.user.type)
                    With r.user
                        Student.Blocked = .blocked
                        Student.FirstName = .f_name
                        Student.Surname = .s_name
                        Student.Type = .type
                        Student.Username = .username

                    End With

                    If Student.Type.ToLower() <> "administrator" Then
                        With r.user
                            Student.TotalTimeUsed = .used_time
                            Student.TimeLimits = .time_limit
                            Student.RemainingTime = .remaining_time
                        End With
                        Dim StudentForm As New frmRemainingTime(Student)
                        StudentForm.Show()
                        AllowWindowToClose = True
                        Me.Close()
                        'MsgBox("non admin " + Student.Type)
                    Else
                        MsgBox("admin" + Student.Type)
                    End If
                Else
                    Dim r As Errors = JsonConvert.DeserializeObject(Of Errors)(json)
                    showProgress(False)
                    MsgBox("Access denied " + r.message)
                End If

            Catch ex As Exception
                showProgress(False)
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