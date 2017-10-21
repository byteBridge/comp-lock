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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSetEmergencyPassword = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNewEmergencyPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCurrentEmergencyPassword = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSetServerPath = New System.Windows.Forms.Button()
        Me.txtServerPort = New System.Windows.Forms.TextBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpServerName = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDeveloperPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCheckDeveloperPassword = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpServerName.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 512)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(380, 1)
        Me.Panel5.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnSetEmergencyPassword)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNewEmergencyPassword)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtCurrentEmergencyPassword)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 380)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Change emergency password"
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
        Me.btnSetEmergencyPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSetEmergencyPassword.FlatAppearance.BorderSize = 0
        Me.btnSetEmergencyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetEmergencyPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSetEmergencyPassword.ForeColor = System.Drawing.Color.White
        Me.btnSetEmergencyPassword.Location = New System.Drawing.Point(16, 337)
        Me.btnSetEmergencyPassword.Name = "btnSetEmergencyPassword"
        Me.btnSetEmergencyPassword.Size = New System.Drawing.Size(317, 33)
        Me.btnSetEmergencyPassword.TabIndex = 14
        Me.btnSetEmergencyPassword.Text = "Change Password"
        Me.btnSetEmergencyPassword.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 19)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Enter new password"
        '
        'txtNewEmergencyPassword
        '
        Me.txtNewEmergencyPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtNewEmergencyPassword.Location = New System.Drawing.Point(16, 229)
        Me.txtNewEmergencyPassword.Name = "txtNewEmergencyPassword"
        Me.txtNewEmergencyPassword.Size = New System.Drawing.Size(317, 25)
        Me.txtNewEmergencyPassword.TabIndex = 21
        Me.txtNewEmergencyPassword.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(12, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(225, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Enter current emergency password"
        '
        'txtCurrentEmergencyPassword
        '
        Me.txtCurrentEmergencyPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtCurrentEmergencyPassword.Location = New System.Drawing.Point(16, 168)
        Me.txtCurrentEmergencyPassword.Name = "txtCurrentEmergencyPassword"
        Me.txtCurrentEmergencyPassword.Size = New System.Drawing.Size(317, 25)
        Me.txtCurrentEmergencyPassword.TabIndex = 19
        Me.txtCurrentEmergencyPassword.UseSystemPasswordChar = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(378, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 450)
        Me.Panel3.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 450)
        Me.Panel2.TabIndex = 17
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(380, 2)
        Me.Panel6.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Settings)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(380, 60)
        Me.Panel7.TabIndex = 70
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(2, 511)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 1)
        Me.Panel4.TabIndex = 19
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 67)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(369, 437)
        Me.TabControl1.TabIndex = 71
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(361, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(361, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(235, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Computer name of the server"
        '
        'btnSetServerPath
        '
        Me.btnSetServerPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSetServerPath.FlatAppearance.BorderSize = 0
        Me.btnSetServerPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetServerPath.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSetServerPath.ForeColor = System.Drawing.Color.White
        Me.btnSetServerPath.Location = New System.Drawing.Point(10, 78)
        Me.btnSetServerPath.Name = "btnSetServerPath"
        Me.btnSetServerPath.Size = New System.Drawing.Size(283, 39)
        Me.btnSetServerPath.TabIndex = 22
        Me.btnSetServerPath.Text = "Set server path"
        Me.btnSetServerPath.UseVisualStyleBackColor = False
        '
        'txtServerPort
        '
        Me.txtServerPort.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtServerPort.Location = New System.Drawing.Point(239, 39)
        Me.txtServerPort.MaxLength = 4
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(54, 25)
        Me.txtServerPort.TabIndex = 24
        '
        'txtServerName
        '
        Me.txtServerName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtServerName.Location = New System.Drawing.Point(10, 39)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(188, 25)
        Me.txtServerName.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 76)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "In the unlikely case that the application fails to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "communicate with the server a" &
    "nd you can not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "log into it, use the emergency password to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quit the applicatio" &
    "n"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 100)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(16, 295)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(317, 25)
        Me.txtConfirmPassword.TabIndex = 25
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Confirm new password"
        '
        'grpServerName
        '
        Me.grpServerName.Controls.Add(Me.btnSetServerPath)
        Me.grpServerName.Controls.Add(Me.Label12)
        Me.grpServerName.Controls.Add(Me.txtServerName)
        Me.grpServerName.Controls.Add(Me.Label4)
        Me.grpServerName.Controls.Add(Me.txtServerPort)
        Me.grpServerName.Enabled = False
        Me.grpServerName.Location = New System.Drawing.Point(20, 253)
        Me.grpServerName.Name = "grpServerName"
        Me.grpServerName.Size = New System.Drawing.Size(304, 131)
        Me.grpServerName.TabIndex = 27
        Me.grpServerName.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.Panel8)
        Me.GroupBox4.Controls.Add(Me.btnCheckDeveloperPassword)
        Me.GroupBox4.Controls.Add(Me.txtDeveloperPassword)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.grpServerName)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 390)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enter name of server hosting application"
        '
        'txtDeveloperPassword
        '
        Me.txtDeveloperPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtDeveloperPassword.Location = New System.Drawing.Point(20, 180)
        Me.txtDeveloperPassword.Name = "txtDeveloperPassword"
        Me.txtDeveloperPassword.Size = New System.Drawing.Size(240, 25)
        Me.txtDeveloperPassword.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Enter developer password to proceed"
        '
        'btnCheckDeveloperPassword
        '
        Me.btnCheckDeveloperPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnCheckDeveloperPassword.FlatAppearance.BorderSize = 0
        Me.btnCheckDeveloperPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckDeveloperPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnCheckDeveloperPassword.ForeColor = System.Drawing.Color.White
        Me.btnCheckDeveloperPassword.Image = Global.CompLock.My.Resources.Resources.unlock_32px
        Me.btnCheckDeveloperPassword.Location = New System.Drawing.Point(271, 176)
        Me.btnCheckDeveloperPassword.Name = "btnCheckDeveloperPassword"
        Me.btnCheckDeveloperPassword.Size = New System.Drawing.Size(42, 31)
        Me.btnCheckDeveloperPassword.TabIndex = 27
        Me.btnCheckDeveloperPassword.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 518)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 1)
        Me.Panel1.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(20, 237)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(303, 2)
        Me.Panel8.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 100)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(280, 76)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "This section is reserved for the developers of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the system. If you tamper around " &
    "with this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "setting you might end up being unable to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unlock the application."
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSetEmergencyPassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 513)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpServerName.ResumeLayout(False)
        Me.grpServerName.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Settings As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetEmergencyPassword As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNewEmergencyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentEmergencyPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSetServerPath As Button
    Friend WithEvents txtServerPort As TextBox
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCheckDeveloperPassword As Button
    Friend WithEvents txtDeveloperPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grpServerName As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel8 As Panel
End Class
