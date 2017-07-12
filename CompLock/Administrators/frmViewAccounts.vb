Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmViewAccounts
    Dim Student As New Student
    ''' <summary>
    ''' The administrator's full name. Also appears on the reports that are created.
    ''' </summary>
    Property NameOfAdministrator As String

    Private Sub frmViewAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill the datagrid with the accounts from the database
        dgvAccounts.DataSource = Student.FillAccounts

    End Sub

    Private Sub txtSearchAccounts_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAccounts.TextChanged

        'as the user types it queries the database
        dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)
    End Sub

    Private Sub cboSearchFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchFilter.SelectedIndexChanged
        'as the selects the it queries the database
        dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)

    End Sub


    Private Sub btnViewPersonalRecord_Click(sender As Object, e As EventArgs) Handles btnViewPersonalRecord.Click
        Dim ViewAccount As New frmMyAccount(Student, frmMyAccount.AccessLevel.Administrator)
        ViewAccount.NameOfAdministrator = NameOfAdministrator
        ViewAccount.ShowDialog()
        dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)

        'MsgBox("I should get data from the db as a datatable and then write student info in .txt file and open it")
    End Sub

    Private Sub dgvAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellClick

        Try

       
        Dim cell1 As DataGridViewCell
        'Me.dgvAccounts.Rows(e.RowIndex).Selected = True
        cell1 = Me.dgvAccounts.Rows(e.RowIndex).Cells("USERNAME")
        Student.Username = cell1.Value.ToString
        Me.Student.Initialize(Student.Username)
        If Me.Student.Type.ToLower <> "administrator" Then

            If Student.Blocked Then
                Me.btnBlockAccount.Enabled = False
                btnUnblockAccount.Enabled = True
                btnDeleteAccount.Enabled = True
                btnViewPersonalRecord.Enabled = True
            Else
                Me.btnBlockAccount.Enabled = True
                btnUnblockAccount.Enabled = False
                btnDeleteAccount.Enabled = True
                btnViewPersonalRecord.Enabled = True

            End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBlockAccount_Click(sender As Object, e As EventArgs) Handles btnBlockAccount.Click
        If MessageBox.Show("Are you sure you want to block this student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Student.Block(Student.Username) = True Then
                MessageBox.Show("Successfully blocked the account", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)
                'Refresh the accounts
                dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)

            Else
                MessageBox.Show("Failed to block the account", "fail", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick

    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        If MessageBox.Show("Are you sure you want to delete this student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Student.DeleteMember(Student.Username) = True Then
                MessageBox.Show("Successfully deleted the account", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)
                'Refresh the accounts
                dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)
            Else
                MessageBox.Show("Failed to delete the account", "fail", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnUnblockAccount_Click(sender As Object, e As EventArgs) Handles btnUnblockAccount.Click
        If MessageBox.Show("Are you sure you want to unblock this student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Student.UnBlock(Student.Username) = True Then
                MessageBox.Show("Successfully unblocked the account", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Refresh the accounts
                dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)
            Else
                MessageBox.Show("Failed to unblock the account", "fail", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvAccounts.DataSource = Student.SearchAsYouType(txtSearchAccounts.Text, cboSearchFilter.Text, False)
    End Sub
End Class