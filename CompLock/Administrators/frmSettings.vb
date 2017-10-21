Public Class frmSettings

    Private Sub btnSetEmergencyPassword_Click(sender As Object, e As EventArgs) Handles btnSetEmergencyPassword.Click
        If txtCurrentEmergencyPassword.Text = "" And txtNewEmergencyPassword.Text = "" And txtConfirmPassword.Text = "" Then
            MsgBox("Please enter the current emergency password and the new emergency password.")
        Else
            If (txtNewEmergencyPassword.Text <> txtConfirmPassword.Text) Then
                MessageBox.Show("You should enter matching passwords")
                Return
            End If
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


    Private Sub btnSetServerPath_Click(sender As Object, e As EventArgs) Handles btnSetServerPath.Click
        If (txtServerName.Text.Length > 3 And txtServerPort.Text.Length = 4) Then
            My.Settings.ApiServerURL = "http://" & txtServerName.Text
            My.Settings.ApiServerPort = txtServerPort.Text
            MsgBox("success")
        Else
            MsgBox("Fill in correctly")
        End If
    End Sub

    Private Sub btnCheckDeveloperPassword_Click(sender As Object, e As EventArgs) Handles btnCheckDeveloperPassword.Click
        If (txtDeveloperPassword.Text = My.Settings.DeveloperPassword) Then
            grpServerName.Enabled = True
        Else
            MsgBox("Please enter the correct developer password. This feature is mean to be used by the developers of the system to map the application to the server hosting it.")
        End If
    End Sub
End Class