<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRemainingTime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHelloStudentName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblMaxTimeAllowed = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tmrStudentSession = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnViewHelp = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblComputerName = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnViewMyAccount = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHelloStudentName
        '
        Me.lblHelloStudentName.AutoSize = True
        Me.lblHelloStudentName.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lblHelloStudentName.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblHelloStudentName.Location = New System.Drawing.Point(59, 15)
        Me.lblHelloStudentName.Name = "lblHelloStudentName"
        Me.lblHelloStudentName.Size = New System.Drawing.Size(160, 21)
        Me.lblHelloStudentName.TabIndex = 3
        Me.lblHelloStudentName.Text = "Kudakwashe Paradzayi"
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(11, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 1)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(443, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "More Actions"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblDuration.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblDuration.Location = New System.Drawing.Point(216, 188)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(56, 25)
        Me.lblDuration.TabIndex = 37
        Me.lblDuration.Text = "29:30"
        '
        'lblMaxTimeAllowed
        '
        Me.lblMaxTimeAllowed.AutoSize = True
        Me.lblMaxTimeAllowed.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblMaxTimeAllowed.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblMaxTimeAllowed.Location = New System.Drawing.Point(216, 154)
        Me.lblMaxTimeAllowed.Name = "lblMaxTimeAllowed"
        Me.lblMaxTimeAllowed.Size = New System.Drawing.Size(91, 25)
        Me.lblMaxTimeAllowed.TabIndex = 36
        Me.lblMaxTimeAllowed.Text = "30:00 min"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblStartTime.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblStartTime.Location = New System.Drawing.Point(216, 120)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(53, 25)
        Me.lblStartTime.TabIndex = 35
        Me.lblStartTime.Text = "10:34"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Maximum time allowed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Signed in at "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(12, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Session duration"
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblRemainingTime.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblRemainingTime.Location = New System.Drawing.Point(58, 36)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(66, 30)
        Me.lblRemainingTime.TabIndex = 34
        Me.lblRemainingTime.Text = "10:30"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.Label7.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label7.Location = New System.Drawing.Point(40, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Time Summary"
        '
        'tmrStudentSession
        '
        Me.tmrStudentSession.Interval = 1000
        '
        'btnViewHelp
        '
        Me.btnViewHelp.BackColor = System.Drawing.Color.Teal
        Me.btnViewHelp.FlatAppearance.BorderSize = 0
        Me.btnViewHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewHelp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnViewHelp.ForeColor = System.Drawing.Color.White
        Me.btnViewHelp.Image = Global.CompLock.My.Resources.Resources.Help_teal
        Me.btnViewHelp.Location = New System.Drawing.Point(276, 8)
        Me.btnViewHelp.Name = "btnViewHelp"
        Me.btnViewHelp.Size = New System.Drawing.Size(57, 29)
        Me.btnViewHelp.TabIndex = 49
        Me.btnViewHelp.Text = "Help"
        Me.ToolTip1.SetToolTip(Me.btnViewHelp, "View Help")
        Me.btnViewHelp.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Teal
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(276, 43)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(134, 30)
        Me.btnSettings.TabIndex = 48
        Me.btnSettings.Text = "My Accout"
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Settings | Change your password")
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.Color.White
        Me.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignOut.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSignOut.Location = New System.Drawing.Point(339, 8)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(71, 29)
        Me.btnSignOut.TabIndex = 7
        Me.btnSignOut.Text = "Sign out"
        Me.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.btnSignOut, "Sign out")
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(448, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 46)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "View Help"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Hello there"
        Me.NotifyIcon1.BalloonTipTitle = "librae"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(183, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(430, 2)
        Me.Panel3.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.AllowDrop = True
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 224)
        Me.Panel4.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.AllowDrop = True
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(2, 224)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(428, 2)
        Me.Panel5.TabIndex = 45
        '
        'Panel6
        '
        Me.Panel6.AllowDrop = True
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(428, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(2, 222)
        Me.Panel6.TabIndex = 46
        '
        'Panel7
        '
        Me.Panel7.AllowDrop = True
        Me.Panel7.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel7.Location = New System.Drawing.Point(255, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(2, 64)
        Me.Panel7.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Location = New System.Drawing.Point(215, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 31)
        Me.Panel1.TabIndex = 7
        '
        'lblComputerName
        '
        Me.lblComputerName.AutoSize = True
        Me.lblComputerName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblComputerName.ForeColor = System.Drawing.Color.Gray
        Me.lblComputerName.Location = New System.Drawing.Point(244, 89)
        Me.lblComputerName.Name = "lblComputerName"
        Me.lblComputerName.Size = New System.Drawing.Size(128, 21)
        Me.lblComputerName.TabIndex = 50
        Me.lblComputerName.Text = "Computer name"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CompLock.My.Resources.Resources.Computer_teal_48
        Me.PictureBox3.Location = New System.Drawing.Point(216, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CompLock.My.Resources.Resources.User_48px
        Me.PictureBox2.Location = New System.Drawing.Point(2, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CompLock.My.Resources.Resources.clock_teal_48px
        Me.PictureBox1.Location = New System.Drawing.Point(14, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'btnViewMyAccount
        '
        Me.btnViewMyAccount.BackColor = System.Drawing.Color.DarkCyan
        Me.btnViewMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnViewMyAccount.FlatAppearance.BorderSize = 0
        Me.btnViewMyAccount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnViewMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewMyAccount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnViewMyAccount.ForeColor = System.Drawing.Color.White
        Me.btnViewMyAccount.Image = Global.CompLock.My.Resources.Resources.User_white_48px
        Me.btnViewMyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewMyAccount.Location = New System.Drawing.Point(448, 93)
        Me.btnViewMyAccount.Name = "btnViewMyAccount"
        Me.btnViewMyAccount.Size = New System.Drawing.Size(224, 46)
        Me.btnViewMyAccount.TabIndex = 6
        Me.btnViewMyAccount.Text = "View My Account"
        Me.btnViewMyAccount.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.AllowDrop = True
        Me.Panel8.BackColor = System.Drawing.Color.DarkGray
        Me.Panel8.Location = New System.Drawing.Point(12, 118)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(408, 1)
        Me.Panel8.TabIndex = 8
        '
        'frmRemainingTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.lblComputerName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnViewHelp)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblMaxTimeAllowed)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblHelloStudentName)
        Me.Controls.Add(Me.lblRemainingTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnViewMyAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemainingTime"
        Me.ShowInTaskbar = False
        Me.Text = "My portal"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHelloStudentName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents btnViewMyAccount As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblMaxTimeAllowed As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrStudentSession As Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnViewHelp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblComputerName As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
End Class
