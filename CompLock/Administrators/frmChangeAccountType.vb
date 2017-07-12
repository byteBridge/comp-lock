Public Class frmChangeAccountType

    Dim _student As New Student
    Sub New(Student As Student)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _student = Student
        lblCurrentAccount.Text = Student.FirstName & " " & Student.Surname
        lblCurrentAccountType.Text = Student.Type
        cboAccountTypes.DataSource = Administrator.GetNonAdminAccountTypes
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Are you sure you want to change the account type for this account?" & vbLf & "Changing one's account also changes some of that user's priviledges. If you are sure click Yes, else click No.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'change account type here


            If _student.ChangeAccountType(_student.Username, cboAccountTypes.Text) Then
                MsgBox("success")
                Close()
            Else
                MsgBox("failed")
                Close()
            End If
        Else
            MsgBox("Account type was not changed")
            Close()
        End If
    End Sub

    Private Sub frmChangeAccountType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class