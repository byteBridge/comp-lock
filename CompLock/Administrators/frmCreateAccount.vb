Public Class frmCreateAccount
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If cboAccountType.SelectedIndex > -1 And txtFirstName.Text <> String.Empty And txtSurname.Text <> String.Empty And cboGender.SelectedIndex > -1 And txtPassword.Text <> String.Empty And txtConfirmPassword.Text <> String.Empty Then
            If txtPassword.Text = txtConfirmPassword.Text Then
                'code here
                Dim student As New Student()

                student.FirstName = txtFirstName.Text
                student.Surname = txtSurname.Text
                student.Username = lblUsername.Text
                student.Gender = cboGender.SelectedItem
                student.Password = txtPassword.Text
                student.Type = cboAccountType.SelectedItem

                If student.Create() Then
                    MessageBox.Show("Successfully created a " & student.Type & " account for " & student.FirstName + student.Surname & ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                Else
                    MessageBox.Show("An error occured and " & student.FirstName & " " & student.Surname & "'s account could not be created. Please try again later.", "Password mismatch.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            Else
                MessageBox.Show("The passwords you entered do not match. Try again.", "Password mismatch.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
            MessageBox.Show("You have left out some fields. Please complete every field.", "Incomplete details.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        If txtFirstName.Text <> String.Empty Then

            Dim username As String = txtSurname.Text & txtFirstName.Text.Substring(0, 1)
            lblUsername.Text = Student.CreateValidUsername(username.ToLower()).ToLower()

        Else
            txtFirstName.Focus()
        End If
    End Sub

    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAccountType.DataSource = Administrator.GetAccountTypes()
    End Sub

    Private Sub btnAddAccountType_Click(sender As Object, e As EventArgs) Handles btnAddAccountType.Click
        frmAddNewaccountType.ShowDialog()

        'refresh the combobox to reflect the changes made.
        cboAccountType.DataSource = Administrator.GetNonAdminAccountTypes()

    End Sub

    ''' <summary>
    ''' Clear all the fields except the commomn  fields e.g. user type
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearFields()
        'Clear the fields
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        lblUsername.Text = ""

        'then fiocus the cursor to the first name text box
        txtFirstName.Focus()
    End Sub

 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
End Class