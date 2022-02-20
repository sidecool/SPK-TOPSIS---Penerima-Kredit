<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_nasabah
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CBWaktu = New System.Windows.Forms.ComboBox
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TBJangkaWaktu = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TBPlafonKredit = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TBIbu = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CBStatus = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TBPekerjaan = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TBNoTelp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TBAlamat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBJenisKelamin = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBNama = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBKTP = New System.Windows.Forms.TextBox
        Me.DGView = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PJudul.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PJudul.Size = New System.Drawing.Size(576, 54)
        Me.PJudul.TabIndex = 25
        '
        'lbJudul
        '
        Me.lbJudul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbJudul.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJudul.Location = New System.Drawing.Point(0, 0)
        Me.lbJudul.Name = "lbJudul"
        Me.lbJudul.Size = New System.Drawing.Size(574, 52)
        Me.lbJudul.TabIndex = 0
        Me.lbJudul.Text = "DATA NASABAH"
        Me.lbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.CBWaktu)
        Me.Panel1.Controls.Add(Me.BtnTutup)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.BtnSimpan)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TBJangkaWaktu)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TBPlafonKredit)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TBIbu)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CBStatus)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TBPekerjaan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TBNoTelp)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TBAlamat)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CBJenisKelamin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TBNama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TBKTP)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 504)
        Me.Panel1.TabIndex = 26
        '
        'CBWaktu
        '
        Me.CBWaktu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBWaktu.FormattingEnabled = True
        Me.CBWaktu.Location = New System.Drawing.Point(141, 408)
        Me.CBWaktu.Name = "CBWaktu"
        Me.CBWaktu.Size = New System.Drawing.Size(153, 24)
        Me.CBWaktu.TabIndex = 26
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(222, 462)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 33)
        Me.BtnTutup.TabIndex = 25
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(93, 462)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 33)
        Me.BtnHapus.TabIndex = 24
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(12, 462)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.BtnSimpan.TabIndex = 23
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 392)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Jangka Waktu"
        '
        'TBJangkaWaktu
        '
        Me.TBJangkaWaktu.Location = New System.Drawing.Point(12, 408)
        Me.TBJangkaWaktu.Name = "TBJangkaWaktu"
        Me.TBJangkaWaktu.Size = New System.Drawing.Size(93, 24)
        Me.TBJangkaWaktu.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Plafon Kredit"
        '
        'TBPlafonKredit
        '
        Me.TBPlafonKredit.Location = New System.Drawing.Point(12, 362)
        Me.TBPlafonKredit.Name = "TBPlafonKredit"
        Me.TBPlafonKredit.Size = New System.Drawing.Size(285, 24)
        Me.TBPlafonKredit.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nama Ibu Kandung"
        '
        'TBIbu
        '
        Me.TBIbu.Location = New System.Drawing.Point(12, 315)
        Me.TBIbu.Name = "TBIbu"
        Me.TBIbu.Size = New System.Drawing.Size(285, 24)
        Me.TBIbu.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Status Pernikahan"
        '
        'CBStatus
        '
        Me.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStatus.FormattingEnabled = True
        Me.CBStatus.Location = New System.Drawing.Point(144, 265)
        Me.CBStatus.Name = "CBStatus"
        Me.CBStatus.Size = New System.Drawing.Size(153, 24)
        Me.CBStatus.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pekerjaan"
        '
        'TBPekerjaan
        '
        Me.TBPekerjaan.Location = New System.Drawing.Point(12, 239)
        Me.TBPekerjaan.Name = "TBPekerjaan"
        Me.TBPekerjaan.Size = New System.Drawing.Size(285, 24)
        Me.TBPekerjaan.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No. Telephone / HP"
        '
        'TBNoTelp
        '
        Me.TBNoTelp.Location = New System.Drawing.Point(12, 194)
        Me.TBNoTelp.Name = "TBNoTelp"
        Me.TBNoTelp.Size = New System.Drawing.Size(285, 24)
        Me.TBNoTelp.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alamat"
        '
        'TBAlamat
        '
        Me.TBAlamat.Location = New System.Drawing.Point(12, 149)
        Me.TBAlamat.Name = "TBAlamat"
        Me.TBAlamat.Size = New System.Drawing.Size(285, 24)
        Me.TBAlamat.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Kelamin"
        '
        'CBJenisKelamin
        '
        Me.CBJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJenisKelamin.FormattingEnabled = True
        Me.CBJenisKelamin.Location = New System.Drawing.Point(144, 103)
        Me.CBJenisKelamin.Name = "CBJenisKelamin"
        Me.CBJenisKelamin.Size = New System.Drawing.Size(153, 24)
        Me.CBJenisKelamin.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'TBNama
        '
        Me.TBNama.Location = New System.Drawing.Point(12, 77)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(285, 24)
        Me.TBNama.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. KTP"
        '
        'TBKTP
        '
        Me.TBKTP.Location = New System.Drawing.Point(12, 32)
        Me.TBKTP.Name = "TBKTP"
        Me.TBKTP.Size = New System.Drawing.Size(285, 24)
        Me.TBKTP.TabIndex = 0
        '
        'DGView
        '
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGView.Location = New System.Drawing.Point(315, 54)
        Me.DGView.Name = "DGView"
        Me.DGView.Size = New System.Drawing.Size(261, 504)
        Me.DGView.TabIndex = 27
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_nasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 558)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PJudul)
        Me.Name = "f_nasabah"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form Data Nasabah"
        Me.PJudul.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PJudul As System.Windows.Forms.Panel
    Friend WithEvents lbJudul As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DGView As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBNoTelp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBKTP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TBJangkaWaktu As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBPlafonKredit As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBIbu As System.Windows.Forms.TextBox
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CBWaktu As System.Windows.Forms.ComboBox
End Class
