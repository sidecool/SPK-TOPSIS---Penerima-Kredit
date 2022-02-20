<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_ganti_paswd
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
        Me.PJudul = New System.Windows.Forms.Panel
        Me.lbJudul = New System.Windows.Forms.Label
        Me.TBLama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBBaru = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBKonfirmasi = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBTampil = New System.Windows.Forms.CheckBox
        Me.BtnGanti = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PJudul.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PJudul
        '
        Me.PJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PJudul.Controls.Add(Me.lbJudul)
        Me.PJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.PJudul.Location = New System.Drawing.Point(0, 0)
        Me.PJudul.Name = "PJudul"
        Me.PJudul.Size = New System.Drawing.Size(416, 54)
        Me.PJudul.TabIndex = 25
        '
        'lbJudul
        '
        Me.lbJudul.BackColor = System.Drawing.SystemColors.Control
        Me.lbJudul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbJudul.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJudul.Location = New System.Drawing.Point(0, 0)
        Me.lbJudul.Name = "lbJudul"
        Me.lbJudul.Size = New System.Drawing.Size(414, 52)
        Me.lbJudul.TabIndex = 0
        Me.lbJudul.Text = "GANTI PASSWORD"
        Me.lbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBLama
        '
        Me.TBLama.Location = New System.Drawing.Point(164, 75)
        Me.TBLama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBLama.Name = "TBLama"
        Me.TBLama.Size = New System.Drawing.Size(218, 24)
        Me.TBLama.TabIndex = 27
        Me.TBLama.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Password Lama"
        '
        'TBBaru
        '
        Me.TBBaru.Location = New System.Drawing.Point(164, 127)
        Me.TBBaru.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBBaru.Name = "TBBaru"
        Me.TBBaru.Size = New System.Drawing.Size(218, 24)
        Me.TBBaru.TabIndex = 29
        Me.TBBaru.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Password Baru"
        '
        'TBKonfirmasi
        '
        Me.TBKonfirmasi.Location = New System.Drawing.Point(164, 159)
        Me.TBKonfirmasi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBKonfirmasi.Name = "TBKonfirmasi"
        Me.TBKonfirmasi.Size = New System.Drawing.Size(218, 24)
        Me.TBKonfirmasi.TabIndex = 31
        Me.TBKonfirmasi.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Konfirmasi Password"
        '
        'CBTampil
        '
        Me.CBTampil.AutoSize = True
        Me.CBTampil.Location = New System.Drawing.Point(294, 198)
        Me.CBTampil.Name = "CBTampil"
        Me.CBTampil.Size = New System.Drawing.Size(88, 21)
        Me.CBTampil.TabIndex = 33
        Me.CBTampil.Text = "Tampilkan"
        Me.CBTampil.UseVisualStyleBackColor = True
        '
        'BtnGanti
        '
        Me.BtnGanti.Location = New System.Drawing.Point(164, 190)
        Me.BtnGanti.Name = "BtnGanti"
        Me.BtnGanti.Size = New System.Drawing.Size(112, 35)
        Me.BtnGanti.TabIndex = 32
        Me.BtnGanti.Text = "&Ganti Password"
        Me.BtnGanti.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_ganti_paswd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(416, 253)
        Me.Controls.Add(Me.CBTampil)
        Me.Controls.Add(Me.BtnGanti)
        Me.Controls.Add(Me.TBKonfirmasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBBaru)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBLama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PJudul)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "f_ganti_paswd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Ganti Password"
        Me.TopMost = True
        Me.PJudul.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PJudul As System.Windows.Forms.Panel
    Friend WithEvents lbJudul As System.Windows.Forms.Label
    Friend WithEvents TBLama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBBaru As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBKonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBTampil As System.Windows.Forms.CheckBox
    Friend WithEvents BtnGanti As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
