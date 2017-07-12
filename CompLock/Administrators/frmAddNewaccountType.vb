Public Class frmAddNewaccountType
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboHours.Text <> "" And cboMinutes.SelectedIndex > -1 Then
            Dim TimeLimit As String = cboHours.SelectedItem & ":" & cboMinutes.SelectedItem & ":00"
            Dim Administrator As New Administrator
            Administrator.CreateNewAccountType(txtAccountTypeTitle.Text, TimeLimit)
            MessageBox.Show("Successfully created a new account type.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Me.Dispose()
        Else
            MsgBox("I need you to select the time limits for the new account type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub


End Class