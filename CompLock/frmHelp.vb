Public Class frmHelp


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub btnViewHelp_Click(sender As Object, e As EventArgs) Handles btnViewHelp.Click
        tabInfo.SelectedIndex = 0
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        tabInfo.SelectedIndex = 1
    End Sub
End Class