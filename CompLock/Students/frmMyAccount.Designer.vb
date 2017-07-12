<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtConfirmNewPAssword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChangeAccountType = New System.Windows.Forms.Button()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.grpChangePassword = New System.Windows.Forms.GroupBox()
        Me.dgvLoginSummary = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPrintStudentLogin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.grpChangePassword.SuspendLayout()
        CType(Me.dgvLoginSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(16, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(303, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Change"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblUsername.Location = New System.Drawing.Point(197, 33)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(92, 25)
        Me.lblUsername.TabIndex = 36
        Me.lblUsername.Text = "Username"
        '
        'lblSurname
        '
        Me.lblSurname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblSurname.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblSurname.Location = New System.Drawing.Point(167, 66)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(82, 25)
        Me.lblSurname.TabIndex = 35
        Me.lblSurname.Text = "Surname"
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblName.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblName.Location = New System.Drawing.Point(167, 31)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 25)
        Me.lblName.TabIndex = 34
        Me.lblName.Text = "Name"
        '
        'txtConfirmNewPAssword
        '
        Me.txtConfirmNewPAssword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtConfirmNewPAssword.Location = New System.Drawing.Point(202, 144)
        Me.txtConfirmNewPAssword.Name = "txtConfirmNewPAssword"
        Me.txtConfirmNewPAssword.Size = New System.Drawing.Size(114, 25)
        Me.txtConfirmNewPAssword.TabIndex = 33
        Me.txtConfirmNewPAssword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNewPassword.Location = New System.Drawing.Point(202, 111)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(114, 25)
        Me.txtNewPassword.TabIndex = 32
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCurrentPassword.Location = New System.Drawing.Point(202, 73)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(114, 25)
        Me.txtCurrentPassword.TabIndex = 31
        Me.txtCurrentPassword.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(12, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 21)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Confirm new password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(11, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 21)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "New password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(11, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Current password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(12, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(12, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Username"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnChangeAccountType)
        Me.GroupBox1.Controls.Add(Me.lblAccountType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblSurname)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Location = New System.Drawing.Point(11, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 205)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'btnChangeAccountType
        '
        Me.btnChangeAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeAccountType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnChangeAccountType.ForeColor = System.Drawing.Color.Teal
        Me.btnChangeAccountType.Image = Global.CompLock.My.Resources.Resources.admin_color
        Me.btnChangeAccountType.Location = New System.Drawing.Point(172, 169)
        Me.btnChangeAccountType.Name = "btnChangeAccountType"
        Me.btnChangeAccountType.Size = New System.Drawing.Size(95, 28)
        Me.btnChangeAccountType.TabIndex = 40
        Me.btnChangeAccountType.Text = "Change..."
        Me.btnChangeAccountType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChangeAccountType.UseVisualStyleBackColor = True
        '
        'lblAccountType
        '
        Me.lblAccountType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountType.AutoSize = True
        Me.lblAccountType.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblAccountType.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblAccountType.Location = New System.Drawing.Point(167, 134)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(82, 25)
        Me.lblAccountType.TabIndex = 39
        Me.lblAccountType.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(11, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Account Type"
        '
        'lblGender
        '
        Me.lblGender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblGender.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblGender.Location = New System.Drawing.Point(167, 100)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(82, 25)
        Me.lblGender.TabIndex = 37
        Me.lblGender.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(11, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 21)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 30)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "My Account"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(900, 62)
        Me.Panel7.TabIndex = 70
        '
        'grpChangePassword
        '
        Me.grpChangePassword.Controls.Add(Me.Button2)
        Me.grpChangePassword.Controls.Add(Me.Label10)
        Me.grpChangePassword.Controls.Add(Me.lblUsername)
        Me.grpChangePassword.Controls.Add(Me.Label9)
        Me.grpChangePassword.Controls.Add(Me.txtConfirmNewPAssword)
        Me.grpChangePassword.Controls.Add(Me.txtCurrentPassword)
        Me.grpChangePassword.Controls.Add(Me.Label6)
        Me.grpChangePassword.Controls.Add(Me.Label3)
        Me.grpChangePassword.Controls.Add(Me.txtNewPassword)
        Me.grpChangePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.grpChangePassword.ForeColor = System.Drawing.Color.DarkCyan
        Me.grpChangePassword.Location = New System.Drawing.Point(12, 287)
        Me.grpChangePassword.Name = "grpChangePassword"
        Me.grpChangePassword.Size = New System.Drawing.Size(334, 229)
        Me.grpChangePassword.TabIndex = 71
        Me.grpChangePassword.TabStop = False
        Me.grpChangePassword.Text = "Change Password"
        '
        'dgvLoginSummary
        '
        Me.dgvLoginSummary.AllowUserToAddRows = False
        Me.dgvLoginSummary.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgvLoginSummary.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLoginSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLoginSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLoginSummary.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvLoginSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoginSummary.Location = New System.Drawing.Point(379, 133)
        Me.dgvLoginSummary.Name = "dgvLoginSummary"
        Me.dgvLoginSummary.ReadOnly = True
        Me.dgvLoginSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoginSummary.Size = New System.Drawing.Size(512, 390)
        Me.dgvLoginSummary.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label8.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label8.Location = New System.Drawing.Point(374, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 30)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Student login summary"
        '
        'btnPrintStudentLogin
        '
        Me.btnPrintStudentLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnPrintStudentLogin.ForeColor = System.Drawing.Color.Teal
        Me.btnPrintStudentLogin.Location = New System.Drawing.Point(747, 94)
        Me.btnPrintStudentLogin.Name = "btnPrintStudentLogin"
        Me.btnPrintStudentLogin.Size = New System.Drawing.Size(144, 27)
        Me.btnPrintStudentLogin.TabIndex = 41
        Me.btnPrintStudentLogin.Text = "Print"
        Me.btnPrintStudentLogin.UseVisualStyleBackColor = True
        '
        'frmMyAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 535)
        Me.Controls.Add(Me.btnPrintStudentLogin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvLoginSummary)
        Me.Controls.Add(Me.grpChangePassword)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMyAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anderson Computer Management System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.grpChangePassword.ResumeLayout(False)
        Me.grpChangePassword.PerformLayout()
        CType(Me.dgvLoginSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtConfirmNewPAssword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents grpChangePassword As System.Windows.Forms.GroupBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblAccountType As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvLoginSummary As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnChangeAccountType As System.Windows.Forms.Button
    Friend WithEvents btnPrintStudentLogin As System.Windows.Forms.Button
End Class
