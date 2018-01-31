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
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnCheckComputerRegistration = New System.Windows.Forms.Button()
        Me.btnOpenAdminConsole = New System.Windows.Forms.Button()
        Me.btnOpenSettings = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.panel1.Controls.Add(Me.btnOpenSettings)
        Me.panel1.Controls.Add(Me.lblName)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(829, 100)
        Me.panel1.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(36, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(341, 37)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Hello, Kudakwashe Paradzayi"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(827, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 201)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(2, 301)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(827, 2)
        Me.Panel4.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 203)
        Me.Panel5.TabIndex = 12
        '
        'btnCheckComputerRegistration
        '
        Me.btnCheckComputerRegistration.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckComputerRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnCheckComputerRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckComputerRegistration.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnCheckComputerRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnCheckComputerRegistration.Image = Global.CompLock.My.Resources.Resources.Computer_Desktop_teal_128
        Me.btnCheckComputerRegistration.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCheckComputerRegistration.Location = New System.Drawing.Point(437, 136)
        Me.btnCheckComputerRegistration.Name = "btnCheckComputerRegistration"
        Me.btnCheckComputerRegistration.Size = New System.Drawing.Size(353, 123)
        Me.btnCheckComputerRegistration.TabIndex = 16
        Me.btnCheckComputerRegistration.Text = "Check Computer Registration"
        Me.btnCheckComputerRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheckComputerRegistration.UseVisualStyleBackColor = False
        '
        'btnOpenAdminConsole
        '
        Me.btnOpenAdminConsole.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenAdminConsole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOpenAdminConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenAdminConsole.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnOpenAdminConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnOpenAdminConsole.Image = Global.CompLock.My.Resources.Resources.OpenWebPage_128px
        Me.btnOpenAdminConsole.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOpenAdminConsole.Location = New System.Drawing.Point(43, 136)
        Me.btnOpenAdminConsole.Name = "btnOpenAdminConsole"
        Me.btnOpenAdminConsole.Size = New System.Drawing.Size(353, 123)
        Me.btnOpenAdminConsole.TabIndex = 15
        Me.btnOpenAdminConsole.Text = "Open Admin Console"
        Me.btnOpenAdminConsole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpenAdminConsole.UseVisualStyleBackColor = False
        '
        'btnOpenSettings
        '
        Me.btnOpenSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenSettings.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnOpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenSettings.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnOpenSettings.ForeColor = System.Drawing.Color.White
        Me.btnOpenSettings.Image = Global.CompLock.My.Resources.Resources.Settings_48px
        Me.btnOpenSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOpenSettings.Location = New System.Drawing.Point(585, 12)
        Me.btnOpenSettings.Name = "btnOpenSettings"
        Me.btnOpenSettings.Size = New System.Drawing.Size(205, 54)
        Me.btnOpenSettings.TabIndex = 16
        Me.btnOpenSettings.Text = "Application Settings"
        Me.btnOpenSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpenSettings.UseVisualStyleBackColor = False
        '
        'frmAdminMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 303)
        Me.Controls.Add(Me.btnCheckComputerRegistration)
        Me.Controls.Add(Me.btnOpenAdminConsole)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Management System - Administrator Control Panel"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnOpenAdminConsole As Button
    Friend WithEvents btnOpenSettings As Button
    Friend WithEvents btnCheckComputerRegistration As Button
End Class
