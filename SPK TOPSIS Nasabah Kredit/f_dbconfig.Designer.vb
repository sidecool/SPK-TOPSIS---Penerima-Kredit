<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_dbconfig
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnTutup = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnCek = New System.Windows.Forms.Button
        Me.TBDatabase = New System.Windows.Forms.TextBox
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.TBUser = New System.Windows.Forms.TextBox
        Me.TBPort = New System.Windows.Forms.TextBox
        Me.TBServer = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.TBPimpinan = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBPimpinan)
        Me.GroupBox1.Controls.Add(Me.btnTutup)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnCek)
        Me.GroupBox1.Controls.Add(Me.TBDatabase)
        Me.GroupBox1.Controls.Add(Me.TBPass)
        Me.GroupBox1.Controls.Add(Me.TBUser)
        Me.GroupBox1.Controls.Add(Me.TBPort)
        Me.GroupBox1.Controls.Add(Me.TBServer)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   Database Config   "
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(280, 214)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 30)
        Me.btnTutup.TabIndex = 46
        Me.btnTutup.TabStop = False
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(35, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "NAMA DATABASE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(35, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(35, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "USER DATABASE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(35, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "PORT NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "SERVER HOST"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(199, 214)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 30)
        Me.btnSimpan.TabIndex = 45
        Me.btnSimpan.TabStop = False
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(38, 214)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(122, 30)
        Me.btnCek.TabIndex = 44
        Me.btnCek.TabStop = False
        Me.btnCek.Text = "&Cek Koneksi"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'TBDatabase
        '
        Me.TBDatabase.Location = New System.Drawing.Point(152, 134)
        Me.TBDatabase.Name = "TBDatabase"
        Me.TBDatabase.Size = New System.Drawing.Size(203, 23)
        Me.TBDatabase.TabIndex = 43
        '
        'TBPass
        '
        Me.TBPass.Location = New System.Drawing.Point(152, 108)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(203, 23)
        Me.TBPass.TabIndex = 42
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(152, 82)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(203, 23)
        Me.TBUser.TabIndex = 41
        '
        'TBPort
        '
        Me.TBPort.Location = New System.Drawing.Point(152, 56)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(96, 23)
        Me.TBPort.TabIndex = 40
        '
        'TBServer
        '
        Me.TBServer.Location = New System.Drawing.Point(152, 30)
        Me.TBServer.Name = "TBServer"
        Me.TBServer.Size = New System.Drawing.Size(203, 23)
        Me.TBServer.TabIndex = 39
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(35, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "NAMA PIMPINAN"
        '
        'TBPimpinan
        '
        Me.TBPimpinan.Location = New System.Drawing.Point(152, 161)
        Me.TBPimpinan.Name = "TBPimpinan"
        Me.TBPimpinan.Size = New System.Drawing.Size(203, 23)
        Me.TBPimpinan.TabIndex = 52
        '
        'f_dbconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 255)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_dbconfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Config"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents TBDatabase As System.Windows.Forms.TextBox
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents TBServer As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBPimpinan As System.Windows.Forms.TextBox
End Class
