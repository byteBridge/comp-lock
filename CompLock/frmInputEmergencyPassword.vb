Public Class frmInputEmergencyPassword

    Dim _EmergencyPassword As String

    Public ReadOnly Property EmergencyPassword As String
        Get
            Return _EmergencyPassword
        End Get
    End Property
    Private Sub frmInputEmergencyPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        _EmergencyPassword = txtEmergencyPassword.Text
        If My.Settings.EmergencyPassword = EmergencyPassword Then
            Close()
        Else
            MessageBox.Show("Invalid password. Try again.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmergencyPassword.Focus()
        End If
    End Sub
End Class