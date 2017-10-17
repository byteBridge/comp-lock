<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.Settings = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTimeLimits = New System.Windows.Forms.TextBox()
        Me.btnSaveTimeLimits = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAccountType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMinutes = New System.Windows.Forms.ComboBox()
        Me.cboHours = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCleaeOnlineUsers = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSetEmergencyPassword = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNewEmergencyPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCurrentEmergencyPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConfirmNewAdminPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewAdminPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCurrentAdminPassword = New System.Windows.Forms.TextBox()
        Me.btnChangeAdminPassword = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAdministratorAccounts = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSetServerPath = New System.Windows.Forms.Button()
        Me.txtServerPort = New System.Windows.Forms.TextBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Settings.ForeColor = System.Drawing.Color.White
        Me.Settings.Location = New System.Drawing.Point(12, 9)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(105, 37)
        Me.Settings.TabIndex = 12
        Me.Settings.Text = "Settings"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Location = New System.Drawing.Point(-6, 54)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(834, 1)
        Me.Panel5.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTimeLimits)
        Me.GroupBox2.Controls.Add(Me.btnSaveTimeLimits)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboAccountType)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboMinutes)
        Me.GroupBox2.Controls.Add(Me.cboHours)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 206)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time settings"
        '
        'txtTimeLimits
        '
        Me.txtTimeLimits.Location = New System.Drawing.Point(18, 133)
        Me.txtTimeLimits.Name = "txtTimeLimits"
        Me.txtTimeLimits.Size = New System.Drawing.Size(159, 29)
        Me.txtTimeLimits.TabIndex = 71
        Me.txtTimeLimits.Text = "0:30"
        '
        'btnSaveTimeLimits
        '
        Me.btnSaveTimeLimits.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSaveTimeLimits.FlatAppearance.BorderSize = 0
        Me.btnSaveTimeLimits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveTimeLimits.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSaveTimeLimits.ForeColor = System.Drawing.Color.White
        Me.btnSaveTimeLimits.Location = New System.Drawing.Point(17, 172)
        Me.btnSaveTimeLimits.Name = "btnSaveTimeLimits"
        Me.btnSaveTimeLimits.Size = New System.Drawing.Size(265, 28)
        Me.btnSaveTimeLimits.TabIndex = 12
        Me.btnSaveTimeLimits.Text = "Save new time settings"
        Me.btnSaveTimeLimits.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(14, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select Account type"
        '
        'cboAccountType
        '
        Me.cboAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountType.FormattingEnabled = True
        Me.cboAccountType.Items.AddRange(New Object() {"M", "F"})
        Me.cboAccountType.Location = New System.Drawing.Point(17, 58)
        Me.cboAccountType.Name = "cboAccountType"
        Me.cboAccountType.Size = New System.Drawing.Size(265, 29)
        Me.cboAccountType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(14, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Time limits"
        '
        'cboMinutes
        '
        Me.cboMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinutes.FormattingEnabled = True
        Me.cboMinutes.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cboMinutes.Location = New System.Drawing.Point(201, 126)
        Me.cboMinutes.Name = "cboMinutes"
        Me.cboMinutes.Size = New System.Drawing.Size(82, 29)
        Me.cboMinutes.TabIndex = 1
        Me.cboMinutes.Visible = False
        '
        'cboHours
        '
        Me.cboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHours.FormattingEnabled = True
        Me.cboHours.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboHours.Location = New System.Drawing.Point(203, 92)
        Me.cboHours.Name = "cboHours"
        Me.cboHours.Size = New System.Drawing.Size(62, 29)
        Me.cboHours.TabIndex = 0
        Me.cboHours.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCleaeOnlineUsers)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Location = New System.Drawing.Point(6, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 138)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clear Online users"
        '
        'btnCleaeOnlineUsers
        '
        Me.btnCleaeOnlineUsers.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCleaeOnlineUsers.FlatAppearance.BorderSize = 0
        Me.btnCleaeOnlineUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCleaeOnlineUsers.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnCleaeOnlineUsers.ForeColor = System.Drawing.Color.White
        Me.btnCleaeOnlineUsers.Location = New System.Drawing.Point(18, 102)
        Me.btnCleaeOnlineUsers.Name = "btnCleaeOnlineUsers"
        Me.btnCleaeOnlineUsers.Size = New System.Drawing.Size(265, 28)
        Me.btnCleaeOnlineUsers.TabIndex = 13
        Me.btnCleaeOnlineUsers.Text = "Clear Users"
        Me.btnCleaeOnlineUsers.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(289, 57)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sometimes when computers unexpectedly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " shut down (e.g due to power cut), click " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on the button below so that users can log in." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnSetEmergencyPassword)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNewEmergencyPassword)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtCurrentEmergencyPassword)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtConfirmNewAdminPassword)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtNewAdminPassword)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCurrentAdminPassword)
        Me.GroupBox3.Controls.Add(Me.btnChangeAdminPassword)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cboAdministratorAccounts)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox3.Location = New System.Drawing.Point(366, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 478)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Administrator Security"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(0, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1)
        Me.Panel1.TabIndex = 23
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(244, -39)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 32)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSetEmergencyPassword
        '
        Me.btnSetEmergencyPassword.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSetEmergencyPassword.FlatAppearance.BorderSize = 0
        Me.btnSetEmergencyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetEmergencyPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSetEmergencyPassword.ForeColor = System.Drawing.Color.White
        Me.btnSetEmergencyPassword.Location = New System.Drawing.Point(193, 432)
        Me.btnSetEmergencyPassword.Name = "btnSetEmergencyPassword"
        Me.btnSetEmergencyPassword.Size = New System.Drawing.Size(132, 28)
        Me.btnSetEmergencyPassword.TabIndex = 14
        Me.btnSetEmergencyPassword.Text = "Set Password"
        Me.btnSetEmergencyPassword.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(14, 411)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 19)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Enter new password"
        '
        'txtNewEmergencyPassword
        '
        Me.txtNewEmergencyPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtNewEmergencyPassword.Location = New System.Drawing.Point(18, 435)
        Me.txtNewEmergencyPassword.Name = "txtNewEmergencyPassword"
        Me.txtNewEmergencyPassword.Size = New System.Drawing.Size(156, 25)
        Me.txtNewEmergencyPassword.TabIndex = 21
        Me.txtNewEmergencyPassword.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(14, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(225, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Enter current emergency password"
        '
        'txtCurrentEmergencyPassword
        '
        Me.txtCurrentEmergencyPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtCurrentEmergencyPassword.Location = New System.Drawing.Point(18, 383)
        Me.txtCurrentEmergencyPassword.Name = "txtCurrentEmergencyPassword"
        Me.txtCurrentEmergencyPassword.Size = New System.Drawing.Size(156, 25)
        Me.txtCurrentEmergencyPassword.TabIndex = 19
        Me.txtCurrentEmergencyPassword.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(14, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(311, 57)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Set the emergency exit password to safely close" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the application when it failes " &
    "to connect to the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "database."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Confirm new password"
        '
        'txtConfirmNewAdminPassword
        '
        Me.txtConfirmNewAdminPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtConfirmNewAdminPassword.Location = New System.Drawing.Point(18, 241)
        Me.txtConfirmNewAdminPassword.Name = "txtConfirmNewAdminPassword"
        Me.txtConfirmNewAdminPassword.Size = New System.Drawing.Size(156, 25)
        Me.txtConfirmNewAdminPassword.TabIndex = 17
        Me.txtConfirmNewAdminPassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Enter new password"
        '
        'txtNewAdminPassword
        '
        Me.txtNewAdminPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtNewAdminPassword.Location = New System.Drawing.Point(18, 181)
        Me.txtNewAdminPassword.Name = "txtNewAdminPassword"
        Me.txtNewAdminPassword.Size = New System.Drawing.Size(156, 25)
        Me.txtNewAdminPassword.TabIndex = 15
        Me.txtNewAdminPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Enter current password"
        '
        'txtCurrentAdminPassword
        '
        Me.txtCurrentAdminPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtCurrentAdminPassword.Location = New System.Drawing.Point(18, 129)
        Me.txtCurrentAdminPassword.Name = "txtCurrentAdminPassword"
        Me.txtCurrentAdminPassword.Size = New System.Drawing.Size(156, 25)
        Me.txtCurrentAdminPassword.TabIndex = 13
        Me.txtCurrentAdminPassword.UseSystemPasswordChar = True
        '
        'btnChangeAdminPassword
        '
        Me.btnChangeAdminPassword.BackColor = System.Drawing.Color.DarkCyan
        Me.btnChangeAdminPassword.FlatAppearance.BorderSize = 0
        Me.btnChangeAdminPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeAdminPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnChangeAdminPassword.ForeColor = System.Drawing.Color.White
        Me.btnChangeAdminPassword.Location = New System.Drawing.Point(191, 238)
        Me.btnChangeAdminPassword.Name = "btnChangeAdminPassword"
        Me.btnChangeAdminPassword.Size = New System.Drawing.Size(134, 28)
        Me.btnChangeAdminPassword.TabIndex = 12
        Me.btnChangeAdminPassword.Text = "Change Password"
        Me.btnChangeAdminPassword.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(14, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Select Administrator Account"
        '
        'cboAdministratorAccounts
        '
        Me.cboAdministratorAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAdministratorAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAdministratorAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdministratorAccounts.FormattingEnabled = True
        Me.cboAdministratorAccounts.Items.AddRange(New Object() {"M", "F"})
        Me.cboAdministratorAccounts.Location = New System.Drawing.Point(17, 58)
        Me.cboAdministratorAccounts.Name = "cboAdministratorAccounts"
        Me.cboAdministratorAccounts.Size = New System.Drawing.Size(265, 29)
        Me.cboAdministratorAccounts.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(741, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 526)
        Me.Panel3.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 526)
        Me.Panel2.TabIndex = 17
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(743, 2)
        Me.Panel6.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel7.Controls.Add(Me.Settings)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(743, 60)
        Me.Panel7.TabIndex = 70
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(2, 587)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(739, 1)
        Me.Panel4.TabIndex = 19
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox4.Location = New System.Drawing.Point(6, 236)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(302, 93)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Windows Startup"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(168, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 28)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(6, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(271, 42)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Always run the program when windows " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "loads."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 508)
        Me.TabControl1.TabIndex = 71
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnSetServerPath)
        Me.TabPage2.Controls.Add(Me.txtServerPort)
        Me.TabPage2.Controls.Add(Me.txtServerName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 482)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSetServerPath
        '
        Me.btnSetServerPath.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSetServerPath.FlatAppearance.BorderSize = 0
        Me.btnSetServerPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetServerPath.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSetServerPath.ForeColor = System.Drawing.Color.White
        Me.btnSetServerPath.Location = New System.Drawing.Point(90, 132)
        Me.btnSetServerPath.Name = "btnSetServerPath"
        Me.btnSetServerPath.Size = New System.Drawing.Size(283, 34)
        Me.btnSetServerPath.TabIndex = 22
        Me.btnSetServerPath.Text = "Set server path"
        Me.btnSetServerPath.UseVisualStyleBackColor = False
        '
        'txtServerPort
        '
        Me.txtServerPort.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtServerPort.Location = New System.Drawing.Point(319, 80)
        Me.txtServerPort.MaxLength = 4
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(54, 25)
        Me.txtServerPort.TabIndex = 24
        Me.txtServerPort.UseSystemPasswordChar = True
        '
        'txtServerName
        '
        Me.txtServerName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtServerName.Location = New System.Drawing.Point(90, 80)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(188, 25)
        Me.txtServerName.TabIndex = 23
        Me.txtServerName.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(86, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Computer name of the server"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(315, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Port"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 588)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anderson Computer Management System"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Settings As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents cboHours As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveTimeLimits As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCleaeOnlineUsers As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangeAdminPassword As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAdministratorAccounts As System.Windows.Forms.ComboBox
    Friend WithEvents txtCurrentAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmNewAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNewAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSetEmergencyPassword As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNewEmergencyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentEmergencyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtTimeLimits As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSetServerPath As Button
    Friend WithEvents txtServerPort As TextBox
    Friend WithEvents txtServerName As TextBox
End Class
