<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewAccounts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearchAccounts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.cboSearchFilter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnViewPersonalRecord = New System.Windows.Forms.Button()
        Me.btnUnblockAccount = New System.Windows.Forms.Button()
        Me.btnDeleteAccount = New System.Windows.Forms.Button()
        Me.btnBlockAccount = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "View Accounts"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 585)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(739, 3)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(741, 60)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 528)
        Me.Panel3.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 528)
        Me.Panel1.TabIndex = 15
        '
        'txtSearchAccounts
        '
        Me.txtSearchAccounts.Location = New System.Drawing.Point(6, 45)
        Me.txtSearchAccounts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchAccounts.Name = "txtSearchAccounts"
        Me.txtSearchAccounts.Size = New System.Drawing.Size(162, 25)
        Me.txtSearchAccounts.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(34, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Search User"
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        Me.dgvAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(24, 199)
        Me.dgvAccounts.MultiSelect = False
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        Me.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccounts.Size = New System.Drawing.Size(695, 349)
        Me.dgvAccounts.TabIndex = 22
        '
        'cboSearchFilter
        '
        Me.cboSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchFilter.FormattingEnabled = True
        Me.cboSearchFilter.Items.AddRange(New Object() {"FirstName", "Surname", "Username"})
        Me.cboSearchFilter.Location = New System.Drawing.Point(174, 45)
        Me.cboSearchFilter.Name = "cboSearchFilter"
        Me.cboSearchFilter.Size = New System.Drawing.Size(126, 25)
        Me.cboSearchFilter.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(203, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Search Filter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSearchFilter)
        Me.GroupBox1.Controls.Add(Me.txtSearchAccounts)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 77)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CompLock.My.Resources.Resources.UserFind_teal_48px
        Me.PictureBox2.Location = New System.Drawing.Point(2, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CompLock.My.Resources.Resources.SearchFilter_teal_48px
        Me.PictureBox3.Location = New System.Drawing.Point(174, 19)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnViewPersonalRecord)
        Me.GroupBox2.Controls.Add(Me.btnUnblockAccount)
        Me.GroupBox2.Controls.Add(Me.btnDeleteAccount)
        Me.GroupBox2.Controls.Add(Me.btnBlockAccount)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Location = New System.Drawing.Point(364, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 100)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btnViewPersonalRecord
        '
        Me.btnViewPersonalRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnViewPersonalRecord.Location = New System.Drawing.Point(160, 60)
        Me.btnViewPersonalRecord.Name = "btnViewPersonalRecord"
        Me.btnViewPersonalRecord.Size = New System.Drawing.Size(177, 28)
        Me.btnViewPersonalRecord.TabIndex = 3
        Me.btnViewPersonalRecord.Text = "View personal records"
        Me.btnViewPersonalRecord.UseVisualStyleBackColor = True
        '
        'btnUnblockAccount
        '
        Me.btnUnblockAccount.BackColor = System.Drawing.Color.Green
        Me.btnUnblockAccount.Enabled = False
        Me.btnUnblockAccount.FlatAppearance.BorderSize = 0
        Me.btnUnblockAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnblockAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnUnblockAccount.ForeColor = System.Drawing.Color.White
        Me.btnUnblockAccount.Location = New System.Drawing.Point(15, 63)
        Me.btnUnblockAccount.Name = "btnUnblockAccount"
        Me.btnUnblockAccount.Size = New System.Drawing.Size(122, 26)
        Me.btnUnblockAccount.TabIndex = 2
        Me.btnUnblockAccount.Text = "Unblock"
        Me.btnUnblockAccount.UseVisualStyleBackColor = False
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDeleteAccount.Enabled = False
        Me.btnDeleteAccount.FlatAppearance.BorderSize = 0
        Me.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnDeleteAccount.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAccount.Location = New System.Drawing.Point(202, 22)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(132, 26)
        Me.btnDeleteAccount.TabIndex = 1
        Me.btnDeleteAccount.Text = "Delete"
        Me.btnDeleteAccount.UseVisualStyleBackColor = False
        '
        'btnBlockAccount
        '
        Me.btnBlockAccount.BackColor = System.Drawing.Color.OrangeRed
        Me.btnBlockAccount.Enabled = False
        Me.btnBlockAccount.FlatAppearance.BorderSize = 0
        Me.btnBlockAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlockAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnBlockAccount.ForeColor = System.Drawing.Color.White
        Me.btnBlockAccount.Location = New System.Drawing.Point(15, 22)
        Me.btnBlockAccount.Name = "btnBlockAccount"
        Me.btnBlockAccount.Size = New System.Drawing.Size(122, 26)
        Me.btnBlockAccount.TabIndex = 0
        Me.btnBlockAccount.Text = "Block"
        Me.btnBlockAccount.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(743, 60)
        Me.Panel7.TabIndex = 71
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(601, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnRefresh.Image = Global.CompLock.My.Resources.Resources.Reload_WF_teal_32
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(24, 81)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(311, 28)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmViewAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 588)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel7)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmViewAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anderson Computer Management System"
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearchAccounts As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents cboSearchFilter As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnViewPersonalRecord As Button
    Friend WithEvents btnUnblockAccount As Button
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents btnBlockAccount As Button
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
