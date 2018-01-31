<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterComputer
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
        Me.btnRegisterComputer = New System.Windows.Forms.Button()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.pnlRegistered = New System.Windows.Forms.Panel()
        Me.btnUnregisterComputer = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlNotRegistered = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.progSignin = New System.Windows.Forms.ProgressBar()
        Me.pnlRegistered.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotRegistered.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegisterComputer
        '
        Me.btnRegisterComputer.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnRegisterComputer.FlatAppearance.BorderSize = 0
        Me.btnRegisterComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterComputer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRegisterComputer.ForeColor = System.Drawing.Color.White
        Me.btnRegisterComputer.Location = New System.Drawing.Point(14, 85)
        Me.btnRegisterComputer.Name = "btnRegisterComputer"
        Me.btnRegisterComputer.Size = New System.Drawing.Size(309, 44)
        Me.btnRegisterComputer.TabIndex = 55
        Me.btnRegisterComputer.Text = "Register Computer"
        Me.btnRegisterComputer.UseVisualStyleBackColor = False
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblRemainingTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblRemainingTime.Location = New System.Drawing.Point(74, 29)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(204, 25)
        Me.lblRemainingTime.TabIndex = 53
        Me.lblRemainingTime.Text = "Computer is registered"
        '
        'pnlRegistered
        '
        Me.pnlRegistered.Controls.Add(Me.btnUnregisterComputer)
        Me.pnlRegistered.Controls.Add(Me.PictureBox2)
        Me.pnlRegistered.Controls.Add(Me.lblRemainingTime)
        Me.pnlRegistered.Location = New System.Drawing.Point(20, 20)
        Me.pnlRegistered.Name = "pnlRegistered"
        Me.pnlRegistered.Size = New System.Drawing.Size(332, 137)
        Me.pnlRegistered.TabIndex = 57
        Me.pnlRegistered.Visible = False
        '
        'btnUnregisterComputer
        '
        Me.btnUnregisterComputer.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnUnregisterComputer.FlatAppearance.BorderSize = 0
        Me.btnUnregisterComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnregisterComputer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnUnregisterComputer.ForeColor = System.Drawing.Color.White
        Me.btnUnregisterComputer.Location = New System.Drawing.Point(17, 85)
        Me.btnUnregisterComputer.Name = "btnUnregisterComputer"
        Me.btnUnregisterComputer.Size = New System.Drawing.Size(306, 44)
        Me.btnUnregisterComputer.TabIndex = 56
        Me.btnUnregisterComputer.Text = "Unregister Computer"
        Me.btnUnregisterComputer.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CompLock.My.Resources.Resources.Check
        Me.PictureBox2.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'pnlNotRegistered
        '
        Me.pnlNotRegistered.Controls.Add(Me.PictureBox3)
        Me.pnlNotRegistered.Controls.Add(Me.PictureBox1)
        Me.pnlNotRegistered.Controls.Add(Me.btnRegisterComputer)
        Me.pnlNotRegistered.Controls.Add(Me.Label1)
        Me.pnlNotRegistered.Location = New System.Drawing.Point(20, 20)
        Me.pnlNotRegistered.Name = "pnlNotRegistered"
        Me.pnlNotRegistered.Size = New System.Drawing.Size(329, 137)
        Me.pnlNotRegistered.TabIndex = 58
        Me.pnlNotRegistered.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CompLock.My.Resources.Resources.Chat___Cancel_orange_32
        Me.PictureBox3.Location = New System.Drawing.Point(43, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CompLock.My.Resources.Resources.Computer_Desktop_orange_48
        Me.PictureBox1.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(77, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Computer is not registered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(39, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 25)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Loading computer status..."
        '
        'progSignin
        '
        Me.progSignin.Dock = System.Windows.Forms.DockStyle.Top
        Me.progSignin.Location = New System.Drawing.Point(0, 0)
        Me.progSignin.MarqueeAnimationSpeed = 1
        Me.progSignin.Name = "progSignin"
        Me.progSignin.Size = New System.Drawing.Size(371, 5)
        Me.progSignin.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progSignin.TabIndex = 60
        Me.progSignin.Visible = False
        '
        'frmRegisterComputer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 168)
        Me.Controls.Add(Me.progSignin)
        Me.Controls.Add(Me.pnlNotRegistered)
        Me.Controls.Add(Me.pnlRegistered)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRegisterComputer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Status"
        Me.pnlRegistered.ResumeLayout(False)
        Me.pnlRegistered.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotRegistered.ResumeLayout(False)
        Me.pnlNotRegistered.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegisterComputer As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents pnlRegistered As Panel
    Friend WithEvents pnlNotRegistered As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents progSignin As ProgressBar
    Friend WithEvents btnUnregisterComputer As Button
End Class
