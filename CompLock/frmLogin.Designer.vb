﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mnuOptions = New System.Windows.Forms.MenuStrip()
        Me.tlstrpEmergencyExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstrpHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.progSignin = New System.Windows.Forms.ProgressBar()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.mnuOptions.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(375, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(283, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(351, 394)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(295, 25)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(351, 331)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(295, 25)
        Me.txtUsername.TabIndex = 0
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(344, 203)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(92, 37)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Sign In"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.label4.Location = New System.Drawing.Point(375, 306)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 19)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Username"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label8.Location = New System.Drawing.Point(583, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = " "
        '
        'mnuOptions
        '
        Me.mnuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstrpEmergencyExit, Me.tlstrpHelp})
        Me.mnuOptions.Location = New System.Drawing.Point(0, 0)
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(1334, 24)
        Me.mnuOptions.TabIndex = 14
        Me.mnuOptions.Text = "MenuStrip1"
        '
        'tlstrpEmergencyExit
        '
        Me.tlstrpEmergencyExit.Name = "tlstrpEmergencyExit"
        Me.tlstrpEmergencyExit.Size = New System.Drawing.Size(99, 20)
        Me.tlstrpEmergencyExit.Text = "Emergency exit"
        '
        'tlstrpHelp
        '
        Me.tlstrpHelp.Name = "tlstrpHelp"
        Me.tlstrpHelp.Size = New System.Drawing.Size(44, 20)
        Me.tlstrpHelp.Text = "Help"
        '
        'progSignin
        '
        Me.progSignin.Dock = System.Windows.Forms.DockStyle.Top
        Me.progSignin.Location = New System.Drawing.Point(0, 24)
        Me.progSignin.MarqueeAnimationSpeed = 1
        Me.progSignin.Name = "progSignin"
        Me.progSignin.Size = New System.Drawing.Size(1334, 5)
        Me.progSignin.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progSignin.TabIndex = 15
        Me.progSignin.Visible = False
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = Global.CompLock.My.Resources.Resources.Password
        Me.pictureBox4.Location = New System.Drawing.Point(342, 364)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(39, 35)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 9
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.CompLock.My.Resources.Resources.User_48px
        Me.pictureBox3.Location = New System.Drawing.Point(342, 290)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(39, 35)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 8
        Me.pictureBox3.TabStop = False
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnSignIn.FlatAppearance.BorderSize = 0
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSignIn.Location = New System.Drawing.Point(349, 464)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(297, 46)
        Me.btnSignIn.TabIndex = 2
        Me.btnSignIn.Text = "Sign in"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1334, 669)
        Me.ControlBox = False
        Me.Controls.Add(Me.progSignin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mnuOptions)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.mnuOptions
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuOptions.ResumeLayout(False)
        Me.mnuOptions.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private pictureBox4 As System.Windows.Forms.PictureBox
    Private pictureBox3 As System.Windows.Forms.PictureBox
    Friend label4 As System.Windows.Forms.Label
    Friend label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents mnuOptions As MenuStrip
    Friend WithEvents tlstrpEmergencyExit As ToolStripMenuItem
    Friend WithEvents tlstrpHelp As ToolStripMenuItem
    Friend WithEvents progSignin As ProgressBar
    Friend WithEvents btnSignIn As Button
End Class
