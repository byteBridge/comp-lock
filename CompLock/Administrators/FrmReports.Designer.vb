<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReports
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOnlineUsers = New System.Windows.Forms.Button()
        Me.btnBlockedAccounts = New System.Windows.Forms.Button()
        Me.btnListOfAccounts = New System.Windows.Forms.Button()
        Me.btnGeneralReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveReport = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnTodayLogins = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Reports"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Location = New System.Drawing.Point(-13, 73)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(767, 1)
        Me.Panel5.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTodayLogins)
        Me.GroupBox1.Controls.Add(Me.btnOnlineUsers)
        Me.GroupBox1.Controls.Add(Me.btnBlockedAccounts)
        Me.GroupBox1.Controls.Add(Me.btnListOfAccounts)
        Me.GroupBox1.Controls.Add(Me.btnGeneralReport)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(16, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 235)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Type"
        '
        'btnOnlineUsers
        '
        Me.btnOnlineUsers.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOnlineUsers.FlatAppearance.BorderSize = 0
        Me.btnOnlineUsers.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnOnlineUsers.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnOnlineUsers.Location = New System.Drawing.Point(15, 108)
        Me.btnOnlineUsers.Name = "btnOnlineUsers"
        Me.btnOnlineUsers.Size = New System.Drawing.Size(160, 28)
        Me.btnOnlineUsers.TabIndex = 23
        Me.btnOnlineUsers.Text = "Online Users"
        Me.btnOnlineUsers.UseVisualStyleBackColor = False
        '
        'btnBlockedAccounts
        '
        Me.btnBlockedAccounts.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBlockedAccounts.FlatAppearance.BorderSize = 0
        Me.btnBlockedAccounts.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnBlockedAccounts.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnBlockedAccounts.Location = New System.Drawing.Point(15, 188)
        Me.btnBlockedAccounts.Name = "btnBlockedAccounts"
        Me.btnBlockedAccounts.Size = New System.Drawing.Size(160, 28)
        Me.btnBlockedAccounts.TabIndex = 21
        Me.btnBlockedAccounts.Text = "Blocked Accounts"
        Me.btnBlockedAccounts.UseVisualStyleBackColor = False
        '
        'btnListOfAccounts
        '
        Me.btnListOfAccounts.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnListOfAccounts.FlatAppearance.BorderSize = 0
        Me.btnListOfAccounts.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnListOfAccounts.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnListOfAccounts.Location = New System.Drawing.Point(15, 148)
        Me.btnListOfAccounts.Name = "btnListOfAccounts"
        Me.btnListOfAccounts.Size = New System.Drawing.Size(160, 28)
        Me.btnListOfAccounts.TabIndex = 20
        Me.btnListOfAccounts.Text = "List of Accounts"
        Me.btnListOfAccounts.UseVisualStyleBackColor = False
        '
        'btnGeneralReport
        '
        Me.btnGeneralReport.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGeneralReport.FlatAppearance.BorderSize = 0
        Me.btnGeneralReport.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGeneralReport.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnGeneralReport.Location = New System.Drawing.Point(15, 28)
        Me.btnGeneralReport.Name = "btnGeneralReport"
        Me.btnGeneralReport.Size = New System.Drawing.Size(160, 28)
        Me.btnGeneralReport.TabIndex = 19
        Me.btnGeneralReport.Text = "Today's log ins"
        Me.btnGeneralReport.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(219, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 30)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Summary"
        '
        'lblReportTitle
        '
        Me.lblReportTitle.AutoSize = True
        Me.lblReportTitle.BackColor = System.Drawing.Color.DarkCyan
        Me.lblReportTitle.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.lblReportTitle.ForeColor = System.Drawing.Color.White
        Me.lblReportTitle.Location = New System.Drawing.Point(119, 39)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Size = New System.Drawing.Size(135, 30)
        Me.lblReportTitle.TabIndex = 27
        Me.lblReportTitle.Text = "- Report Title"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveReport)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(16, 437)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 146)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btnSaveReport
        '
        Me.btnSaveReport.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSaveReport.FlatAppearance.BorderSize = 0
        Me.btnSaveReport.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSaveReport.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnSaveReport.Image = Global.CompLock.My.Resources.Resources.Adobe_PDF_Export_teal
        Me.btnSaveReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveReport.Location = New System.Drawing.Point(18, 96)
        Me.btnSaveReport.Name = "btnSaveReport"
        Me.btnSaveReport.Size = New System.Drawing.Size(171, 28)
        Me.btnSaveReport.TabIndex = 26
        Me.btnSaveReport.Text = "Save as a pdf file"
        Me.btnSaveReport.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnPrint.Image = Global.CompLock.My.Resources.Resources.Preview_teal
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(18, 49)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(171, 28)
        Me.btnPrint.TabIndex = 24
        Me.btnPrint.Text = "Print / Preview"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgvReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(224, 146)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReport.Size = New System.Drawing.Size(500, 437)
        Me.dgvReport.TabIndex = 29
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(743, 85)
        Me.panel1.TabIndex = 30
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(611, 35)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 34)
        Me.btnClose.TabIndex = 68
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 525)
        Me.Panel2.TabIndex = 54
        '
        'Panel6
        '
        Me.Panel6.AllowDrop = True
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(741, 87)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(2, 525)
        Me.Panel6.TabIndex = 53
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 612)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(743, 2)
        Me.Panel3.TabIndex = 52
        '
        'Panel4
        '
        Me.Panel4.AllowDrop = True
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(743, 2)
        Me.Panel4.TabIndex = 51
        '
        'btnTodayLogins
        '
        Me.btnTodayLogins.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTodayLogins.FlatAppearance.BorderSize = 0
        Me.btnTodayLogins.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnTodayLogins.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnTodayLogins.Location = New System.Drawing.Point(15, 68)
        Me.btnTodayLogins.Name = "btnTodayLogins"
        Me.btnTodayLogins.Size = New System.Drawing.Size(160, 28)
        Me.btnTodayLogins.TabIndex = 24
        Me.btnTodayLogins.Text = "All log in sessions"
        Me.btnTodayLogins.UseVisualStyleBackColor = False
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 614)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblReportTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "FrmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anderson Computer Management System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOnlineUsers As Button
    Friend WithEvents btnBlockedAccounts As Button
    Friend WithEvents btnListOfAccounts As Button
    Friend WithEvents btnGeneralReport As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblReportTitle As Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSaveReport As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnTodayLogins As System.Windows.Forms.Button
End Class
