<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeAccountType
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.grpTimeLimits = New System.Windows.Forms.GroupBox()
        Me.lblCurrentAccountType = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAccountTypes = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCurrentAccount = New System.Windows.Forms.Label()
        Me.grpTimeLimits.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Change account type"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Location = New System.Drawing.Point(-9, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(422, 1)
        Me.Panel5.TabIndex = 16
        '
        'grpTimeLimits
        '
        Me.grpTimeLimits.Controls.Add(Me.lblCurrentAccountType)
        Me.grpTimeLimits.Controls.Add(Me.Panel2)
        Me.grpTimeLimits.Controls.Add(Me.Label4)
        Me.grpTimeLimits.Controls.Add(Me.Label3)
        Me.grpTimeLimits.Controls.Add(Me.cboAccountTypes)
        Me.grpTimeLimits.Controls.Add(Me.btnCancel)
        Me.grpTimeLimits.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpTimeLimits.Location = New System.Drawing.Point(15, 93)
        Me.grpTimeLimits.Name = "grpTimeLimits"
        Me.grpTimeLimits.Size = New System.Drawing.Size(385, 83)
        Me.grpTimeLimits.TabIndex = 18
        Me.grpTimeLimits.TabStop = False
        '
        'lblCurrentAccountType
        '
        Me.lblCurrentAccountType.AutoSize = True
        Me.lblCurrentAccountType.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblCurrentAccountType.ForeColor = System.Drawing.Color.Gray
        Me.lblCurrentAccountType.Location = New System.Drawing.Point(12, 45)
        Me.lblCurrentAccountType.Name = "lblCurrentAccountType"
        Me.lblCurrentAccountType.Size = New System.Drawing.Size(68, 21)
        Me.lblCurrentAccountType.TabIndex = 28
        Me.lblCurrentAccountType.Text = "Student"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(174, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 52)
        Me.Panel2.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(189, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Select New Account Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Current Account Type"
        '
        'cboAccountTypes
        '
        Me.cboAccountTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountTypes.FormattingEnabled = True
        Me.cboAccountTypes.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cboAccountTypes.Location = New System.Drawing.Point(193, 45)
        Me.cboAccountTypes.Name = "cboAccountTypes"
        Me.cboAccountTypes.Size = New System.Drawing.Size(177, 25)
        Me.cboAccountTypes.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(15, 189)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(385, 28)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Change account type"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(2, 227)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(408, 2)
        Me.Panel6.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(408, 2)
        Me.Panel4.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 229)
        Me.Panel1.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(410, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 229)
        Me.Panel3.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnCancel.Location = New System.Drawing.Point(299, -28)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblCurrentAccount
        '
        Me.lblCurrentAccount.AutoSize = True
        Me.lblCurrentAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.lblCurrentAccount.ForeColor = System.Drawing.Color.Gray
        Me.lblCurrentAccount.Location = New System.Drawing.Point(10, 64)
        Me.lblCurrentAccount.Name = "lblCurrentAccount"
        Me.lblCurrentAccount.Size = New System.Drawing.Size(78, 25)
        Me.lblCurrentAccount.TabIndex = 27
        Me.lblCurrentAccount.Text = "Student"
        '
        'frmChangeAccountType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 229)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCurrentAccount)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.grpTimeLimits)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmChangeAccountType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anderson Computer Management System"
        Me.grpTimeLimits.ResumeLayout(False)
        Me.grpTimeLimits.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents grpTimeLimits As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAccountTypes As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentAccount As System.Windows.Forms.Label
    Friend WithEvents lblCurrentAccountType As System.Windows.Forms.Label
End Class
