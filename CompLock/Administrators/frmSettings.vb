Public Class frmSettings

#Region "time Limits"

    ''' <summary>
    ''' PROGRAM NAME: SaveTimeLimits
    ''' WRITTEN BY: Kudakwashe Paradzayi
    ''' PURPOSE: Validates the time input by the admin and then updates 
    '''          the time limits if the iput passes all validation rules.
    ''' DATE: Sunday 21 February 2016
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSaveTimeLimits_Click(sender As Object, e As EventArgs) Handles btnSaveTimeLimits.Click

        Try 'Hamndle any errors that may arise as the code executes
            If cboAccountType.Text = "" Then 'has the user has selected any account type 
                MsgBox("I need you to select the account type.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'create a new array with the hour at index 0, minutes at index 1 and seconds at index 2
                Dim timeArray As String() = Split(txtTimeLimits.Text, ":")
                Dim time As New Time 'class with functions to save time to the database
                'Check if the user has entered tyme in the correct format
                If timeArray.Length = 2 Or timeArray.Length = 3 Then
                    'check if the user has actuallly entered anything in between the colons
                    If timeArray(0) <> "" And timeArray(1) <> "" Then
                        'Check if the user has entered valid digit for the hours and minutes
                        If IsNumeric(timeArray(0)) And IsNumeric(timeArray(1)) Then
                            time.Hours = timeArray(0) ' hours
                            time.Minutes = timeArray(1) ' minutes
                            time.Seconds = 0
                        Else
                            MessageBox.Show("Strings are not allowed. Enter time as digits.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        'Check if saving the time is successful and notify the user
                        If time.SaveTimeSetting(cboAccountType.Text) Then
                            MessageBox.Show("Successfully set the new time settings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                            Me.Dispose()
                        Else 'saving the new time limit has failed
                            MessageBox.Show("Failed to set the new time settings.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else 'User has not entered the time limits. Notify the user
                        MsgBox("I need you to enter the time limits for the new account type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else 'The time enterd is not in the correct format
                    MessageBox.Show("Enter the time in the correct format. The format is hours:minutes, e.g 1:30 .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception 'an error has occured, notify the user 
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the combo boxes with data from the database

        'Load Non Administrative account types
        cboAccountType.DataSource = Administrator.GetNonAdminAccountTypes()

        'load administrative account types
        cboAdministratorAccounts.DataSource = Administrator.GetAdminAccounts()

        'Display the time limits of the currently selected user type
        txtTimeLimits.Text = TimeOperations.GetTimeLimits(cboAccountType.Items(0))
    End Sub

#End Region
#Region "Admin Security"
    Private Sub btnChangeAdminPassword_Click(sender As Object, e As EventArgs) Handles btnChangeAdminPassword.Click


        'chek if the user has selected an account from the combobox
        If cboAdministratorAccounts.Text <> "" Then
            'check if the user has entered any passwords in the given fields
            If txtCurrentAdminPassword.Text <> "" And txtNewAdminPassword.Text <> "" And txtConfirmNewAdminPassword.Text <> "" Then
                'success, validate the current password
                Dim Administrator As New Student
                Administrator.Initialize(cboAdministratorAccounts.Text)
                If txtCurrentAdminPassword.Text = Administrator.Password Then
                    'success, compare the new passwords
                    If txtNewAdminPassword.Text = txtConfirmNewAdminPassword.Text Then
                        'Change the password
                        If Administrator.ChangePassword(cboAdministratorAccounts.Text, txtNewAdminPassword.Text) Then
                            MsgBox("Successfully changed your password.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Error preventing password change
                            MsgBox("An error occured that has prevented your password from being changed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Else
                        'Password do not match
                        MsgBox("The new paswords do not match. Please enter matching passwords.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    'The user has entered the wrong current password
                    MsgBox("You have entered the wrong current password. Please enter the correct password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                'user has left out one or more fileds empty. notify user
                MsgBox("Some password fields have been left out. Fill them in please.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            'The user has not selected the account
            MsgBox("I do not know who you are. Please select your account from the list above.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub



    Private Sub btnCleaeOnlineUsers_Click(sender As Object, e As EventArgs) Handles btnCleaeOnlineUsers.Click
        If Student.ClearOnlineUsers() = True Then
            MsgBox("Successfully Cleared Online Users.")
        Else
            MsgBox("An error occured. Try again later.")
        End If
    End Sub

    Private Sub btnSetEmergencyPassword_Click(sender As Object, e As EventArgs) Handles btnSetEmergencyPassword.Click
        If txtCurrentEmergencyPassword.Text = "" And txtNewEmergencyPassword.Text = "" Then
            MsgBox("Please enter the current emergency password and the new emergency password.")
        Else
            If txtCurrentEmergencyPassword.Text = My.Settings.EmergencyPassword Then
                Dim response = MsgBox("Are you sure you want to change the emergency password. " & vbLf & "NOTE: Please do not forget the new emergency password.", MsgBoxStyle.YesNo, "Are you sure")
                If response = MsgBoxResult.Yes Then
                    My.Settings.EmergencyPassword = txtNewEmergencyPassword.Text
                    My.Settings.Save()
                    MsgBox("The emergency password has been successfully changed.")

                Else
                    MsgBox("The emergency password has not been changed.")
                End If
            Else
                MsgBox("The Emergency exit password you entred is incorrect. Try again.")
            End If
        End If

    End Sub

    Private Sub cboAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccountType.SelectedIndexChanged
        txtTimeLimits.Text = TimeOperations.GetTimeLimits(cboAccountType.SelectedItem)
    End Sub

    Private Sub btnSetServerPath_Click(sender As Object, e As EventArgs) Handles btnSetServerPath.Click
        If (txtServerName.Text.Length > 3 And txtServerPort.Text.Length = 4) Then
            My.Settings.ApiServerURL = "http://" & txtServerName.Text
            My.Settings.ApiServerPort = txtServerPort.Text
            MsgBox("success")
        Else
            MsgBox("Fill in correctly")
        End If
    End Sub
End Class