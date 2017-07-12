Public Class frmMyAccount
    Enum AccessLevel
        Administrator
        Student
    End Enum

    Dim _student As New Student
    Dim _administrator As New Administrator

    ''' <summary>
    ''' The administrator's full name. Also appears on the reports that are created.
    ''' </summary>
    Property NameOfAdministrator As String
    Sub New(Student As Student, OpenedBy As AccessLevel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _student = Student

        lblName.Text = Student.FirstName
        lblSurname.Text = Student.Surname
        lblGender.Text = Student.Gender
        lblAccountType.Text = Student.Type

        lblUsername.Text = Student.Username

        'if inititiated by administrator enable the edit account type button
        Select Case OpenedBy
            Case AccessLevel.Administrator
                btnChangeAccountType.Enabled = True
                grpChangePassword.Enabled = False
                Me.Size = New Size(916, 574)

                'get the student logging data from the database
                dgvLoginSummary.DataSource = Student.GetLoginSummary(Student.Username)
            Case AccessLevel.Student
                btnChangeAccountType.Enabled = False
                Me.Size = New Size(375, 574)
        End Select

    End Sub

  

    Private Sub frmMyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChangeAccountType_Click(sender As Object, e As EventArgs) Handles btnChangeAccountType.Click
        Dim Change As New frmChangeAccountType(_student)
        Change.ShowDialog()
        _student.Initialize(_student.Username)
        lblAccountType.Text = _student.Type
    End Sub

  

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnPrintStudentLogin_Click(sender As Object, e As EventArgs) Handles btnPrintStudentLogin.Click

        Dim ReportTitle As String = "Login summary for " & _student.FullName()
        _administrator.PrintReport(dgvLoginSummary, ReportTitle, NameOfAdministrator, False)

    End Sub
End Class