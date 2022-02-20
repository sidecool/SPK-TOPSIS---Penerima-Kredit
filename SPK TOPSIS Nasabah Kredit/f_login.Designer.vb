<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_login))
        Me.PLogo = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.CBTampil = New System.Windows.Forms.CheckBox
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.TBPassword = New System.Windows.Forms.TextBox
        Me.TBUsername = New System.Windows.Forms.TextBox
        Me.LPassword = New System.Windows.Forms.Label
        Me.LUsername = New System.Windows.Forms.Label
        Me.PLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLogo
        '
        Me.PLogo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PLogo.Controls.Add(Me.Label1)
        Me.PLogo.Controls.Add(Me.PictureBox1)
        Me.PLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogo.Location = New System.Drawing.Point(0, 0)
        Me.PLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(366, 92)
        Me.PLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KOPERASI SIMPAN PINJAM " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SASANDO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.CBTampil)
        Me.GroupBox1.Controls.Add(Me.BtnLogin)
        Me.GroupBox1.Controls.Add(Me.TBPassword)
        Me.GroupBox1.Controls.Add(Me.TBUsername)
        Me.GroupBox1.Controls.Add(Me.LPassword)
        Me.GroupBox1.Controls.Add(Me.LUsername)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 191)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(259, 136)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 35)
        Me.BtnCancel.TabIndex = 14
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'CBTampil
        '
        Me.CBTampil.AutoSize = True
        Me.CBTampil.Location = New System.Drawing.Point(135, 100)
        Me.CBTampil.Name = "CBTampil"
        Me.CBTampil.Size = New System.Drawing.Size(150, 21)
        Me.CBTampil.TabIndex = 13
        Me.CBTampil.Text = "Tampilkan Password"
        Me.CBTampil.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(135, 136)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 35)
        Me.BtnLogin.TabIndex = 12
        Me.BtnLogin.Text = "&Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(135, 60)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(199, 24)
        Me.TBPassword.TabIndex = 11
        Me.TBPassword.UseSystemPasswordChar = True
        '
        'TBUsername
        '
        Me.TBUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBUsername.Location = New System.Drawing.Point(135, 19)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(199, 24)
        Me.TBUsername.TabIndex = 10
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPassword.Location = New System.Drawing.Point(33, 63)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(90, 17)
        Me.LPassword.TabIndex = 9
        Me.LPassword.Text = "PASSWORD"
        '
        'LUsername
        '
        Me.LUsername.AutoSize = True
        Me.LUsername.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsername.Location = New System.Drawing.Point(33, 22)
        Me.LUsername.Name = "LUsername"
        Me.LUsername.Size = New System.Drawing.Size(88, 17)
        Me.LUsername.TabIndex = 8
        Me.LUsername.Text = "USERNAME"
        '
        'f_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(366, 283)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PLogo)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "f_login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_login"
        Me.PLogo.ResumeLayout(False)
        Me.PLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PLogo As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CBTampil As System.Windows.Forms.CheckBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents TBPassword As System.Windows.Forms.TextBox
    Friend WithEvents TBUsername As System.Windows.Forms.TextBox
    Friend WithEvents LPassword As System.Windows.Forms.Label
    Friend WithEvents LUsername As System.Windows.Forms.Label
End Class
