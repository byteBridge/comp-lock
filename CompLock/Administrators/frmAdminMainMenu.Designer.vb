<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMainMenu))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnShutDown = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnViewAccounts = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.panel1.Controls.Add(Me.btnMinimise)
        Me.panel1.Controls.Add(Me.btnSignOut)
        Me.panel1.Controls.Add(Me.lblName)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(727, 100)
        Me.panel1.TabIndex = 4
        '
        'btnMinimise
        '
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimise.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnMinimise.ForeColor = System.Drawing.Color.White
        Me.btnMinimise.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMinimise.Location = New System.Drawing.Point(449, 40)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(95, 36)
        Me.btnMinimise.TabIndex = 15
        Me.btnMinimise.Text = "Minimize"
        Me.btnMinimise.UseVisualStyleBackColor = False
        '
        'btnSignOut
        '
        Me.btnSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSignOut.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignOut.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.Image = Global.CompLock.My.Resources.Resources.signout_white_48px
        Me.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignOut.Location = New System.Drawing.Point(550, 31)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(161, 46)
        Me.btnSignOut.TabIndex = 7
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(13, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(341, 37)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Hello, Kudakwashe Paradzayi"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(19, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 1)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(725, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 447)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(2, 547)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(725, 2)
        Me.Panel4.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 449)
        Me.Panel5.TabIndex = 12
        '
        'btnShutDown
        '
        Me.btnShutDown.BackColor = System.Drawing.Color.Transparent
        Me.btnShutDown.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShutDown.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnShutDown.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnShutDown.Image = Global.CompLock.My.Resources.Resources.ShutDown_orangered_128px
        Me.btnShutDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShutDown.Location = New System.Drawing.Point(512, 387)
        Me.btnShutDown.Name = "btnShutDown"
        Me.btnShutDown.Size = New System.Drawing.Size(161, 135)
        Me.btnShutDown.TabIndex = 11
        Me.btnShutDown.Text = "Quit Program"
        Me.btnShutDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShutDown.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnReports.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnReports.Image = Global.CompLock.My.Resources.Resources.Report_teal_128px
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReports.Location = New System.Drawing.Point(512, 207)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(161, 135)
        Me.btnReports.TabIndex = 10
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Button3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button3.Image = Global.CompLock.My.Resources.Resources.Settings_teal_128px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(54, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 135)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Settings"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnViewAccounts
        '
        Me.btnViewAccounts.BackColor = System.Drawing.Color.Transparent
        Me.btnViewAccounts.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnViewAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAccounts.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnViewAccounts.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnViewAccounts.Image = Global.CompLock.My.Resources.Resources.ViewAccounts_teal_128px
        Me.btnViewAccounts.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewAccounts.Location = New System.Drawing.Point(283, 207)
        Me.btnViewAccounts.Name = "btnViewAccounts"
        Me.btnViewAccounts.Size = New System.Drawing.Size(161, 135)
        Me.btnViewAccounts.TabIndex = 6
        Me.btnViewAccounts.Text = "View Accounts"
        Me.btnViewAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnViewAccounts.UseVisualStyleBackColor = False
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAccount.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnCreateAccount.Image = Global.CompLock.My.Resources.Resources.AddUser_teal_128px
        Me.btnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreateAccount.Location = New System.Drawing.Point(54, 207)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(161, 135)
        Me.btnCreateAccount.TabIndex = 5
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'frmAdminMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 549)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnShutDown)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnViewAccounts)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anderson Computer Management System - Administrator Control Panel"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents btnSignOut As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnViewAccounts As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReports As Button
    Friend WithEvents btnShutDown As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnMinimise As System.Windows.Forms.Button
End Class
