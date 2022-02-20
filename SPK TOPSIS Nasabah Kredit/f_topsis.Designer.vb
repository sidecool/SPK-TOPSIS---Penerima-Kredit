<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_topsis
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
        Me.PJudul = New System.Windows.Forms.Panel
        Me.lbJudul = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TP1 = New System.Windows.Forms.TabPage
        Me.DGVAnalisa = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.CBSubKriteria = New System.Windows.Forms.ComboBox
        Me.CBKriteria = New System.Windows.Forms.ComboBox
        Me.BtnCari = New System.Windows.Forms.Button
        Me.TBNama = New System.Windows.Forms.TextBox
        Me.TP2 = New System.Windows.Forms.TabPage
        Me.DGVNormalisasi = New System.Windows.Forms.DataGridView
        Me.TP3 = New System.Windows.Forms.TabPage
        Me.DGVNormalisasiTerbobot = New System.Windows.Forms.DataGridView
        Me.TP4 = New System.Windows.Forms.TabPage
        Me.DGVSolusiIdeal = New System.Windows.Forms.DataGridView
        Me.TP5 = New System.Windows.Forms.TabPage
        Me.DGVJarakSolusi = New System.Windows.Forms.DataGridView
        Me.PJarakSolusi = New System.Windows.Forms.Panel
        Me.RBNegatif = New System.Windows.Forms.RadioButton
        Me.RBPositif = New System.Windows.Forms.RadioButton
        Me.TP6 = New System.Windows.Forms.TabPage
        Me.DGVPreferensi = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnCetak = New System.Windows.Forms.Button
        Me.PJudul.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TP1.SuspendLayout()
        CType(Me.DGVAnalisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TP2.SuspendLayout()
        CType(Me.DGVNormalisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP3.SuspendLayout()
        CType(Me.DGVNormalisasiTerbobot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP4.SuspendLayout()
        CType(Me.DGVSolusiIdeal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP5.SuspendLayout()
        CType(Me.DGVJarakSolusi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PJarakSolusi.SuspendLayout()
        Me.TP6.SuspendLayout()
        CType(Me.DGVPreferensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PJudul
        '
        Me.PJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PJudul.Controls.Add(Me.lbJudul)
        Me.PJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.PJudul.Location = New System.Drawing.Point(0, 0)
        Me.PJudul.Name = "PJudul"
        Me.PJudul.Size = New System.Drawing.Size(590, 54)
        Me.PJudul.TabIndex = 25
        '
        'lbJudul
        '
        Me.lbJudul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbJudul.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJudul.Location = New System.Drawing.Point(0, 0)
        Me.lbJudul.Name = "lbJudul"
        Me.lbJudul.Size = New System.Drawing.Size(588, 52)
        Me.lbJudul.TabIndex = 0
        Me.lbJudul.Text = "KEPUTUSAN PENERIMAAN"
        Me.lbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TP1)
        Me.TabControl1.Controls.Add(Me.TP2)
        Me.TabControl1.Controls.Add(Me.TP3)
        Me.TabControl1.Controls.Add(Me.TP4)
        Me.TabControl1.Controls.Add(Me.TP5)
        Me.TabControl1.Controls.Add(Me.TP6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TabControl1.Location = New System.Drawing.Point(0, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 420)
        Me.TabControl1.TabIndex = 26
        '
        'TP1
        '
        Me.TP1.Controls.Add(Me.DGVAnalisa)
        Me.TP1.Controls.Add(Me.Panel1)
        Me.TP1.Location = New System.Drawing.Point(4, 30)
        Me.TP1.Name = "TP1"
        Me.TP1.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1.Size = New System.Drawing.Size(582, 386)
        Me.TP1.TabIndex = 5
        Me.TP1.Text = "Analisa Penerima"
        Me.TP1.UseVisualStyleBackColor = True
        '
        'DGVAnalisa
        '
        Me.DGVAnalisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAnalisa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAnalisa.Location = New System.Drawing.Point(3, 190)
        Me.DGVAnalisa.Name = "DGVAnalisa"
        Me.DGVAnalisa.Size = New System.Drawing.Size(576, 193)
        Me.DGVAnalisa.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnSimpan)
        Me.Panel1.Controls.Add(Me.CBSubKriteria)
        Me.Panel1.Controls.Add(Me.CBKriteria)
        Me.Panel1.Controls.Add(Me.BtnCari)
        Me.Panel1.Controls.Add(Me.TBNama)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 187)
        Me.Panel1.TabIndex = 0
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.BtnHapus.Location = New System.Drawing.Point(225, 135)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 33)
        Me.BtnHapus.TabIndex = 30
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(22, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Sub-Kriteria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Kriteria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nama Nasabah"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.BtnSimpan.Location = New System.Drawing.Point(144, 135)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.BtnSimpan.TabIndex = 24
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'CBSubKriteria
        '
        Me.CBSubKriteria.FormattingEnabled = True
        Me.CBSubKriteria.Location = New System.Drawing.Point(144, 89)
        Me.CBSubKriteria.Name = "CBSubKriteria"
        Me.CBSubKriteria.Size = New System.Drawing.Size(316, 25)
        Me.CBSubKriteria.TabIndex = 3
        '
        'CBKriteria
        '
        Me.CBKriteria.FormattingEnabled = True
        Me.CBKriteria.Location = New System.Drawing.Point(144, 58)
        Me.CBKriteria.Name = "CBKriteria"
        Me.CBKriteria.Size = New System.Drawing.Size(316, 25)
        Me.CBKriteria.TabIndex = 2
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.BtnCari.Location = New System.Drawing.Point(396, 28)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(64, 24)
        Me.BtnCari.TabIndex = 1
        Me.BtnCari.Text = "Cari [F3]"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TBNama
        '
        Me.TBNama.Location = New System.Drawing.Point(144, 28)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.ReadOnly = True
        Me.TBNama.Size = New System.Drawing.Size(246, 24)
        Me.TBNama.TabIndex = 0
        '
        'TP2
        '
        Me.TP2.Controls.Add(Me.DGVNormalisasi)
        Me.TP2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TP2.Location = New System.Drawing.Point(4, 30)
        Me.TP2.Name = "TP2"
        Me.TP2.Padding = New System.Windows.Forms.Padding(3)
        Me.TP2.Size = New System.Drawing.Size(582, 386)
        Me.TP2.TabIndex = 0
        Me.TP2.Text = "Normalisasi"
        Me.TP2.UseVisualStyleBackColor = True
        '
        'DGVNormalisasi
        '
        Me.DGVNormalisasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNormalisasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVNormalisasi.Location = New System.Drawing.Point(3, 3)
        Me.DGVNormalisasi.Name = "DGVNormalisasi"
        Me.DGVNormalisasi.Size = New System.Drawing.Size(576, 380)
        Me.DGVNormalisasi.TabIndex = 0
        '
        'TP3
        '
        Me.TP3.Controls.Add(Me.DGVNormalisasiTerbobot)
        Me.TP3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TP3.Location = New System.Drawing.Point(4, 30)
        Me.TP3.Name = "TP3"
        Me.TP3.Padding = New System.Windows.Forms.Padding(3)
        Me.TP3.Size = New System.Drawing.Size(582, 386)
        Me.TP3.TabIndex = 1
        Me.TP3.Text = "Normalisasi Terbobot"
        Me.TP3.UseVisualStyleBackColor = True
        '
        'DGVNormalisasiTerbobot
        '
        Me.DGVNormalisasiTerbobot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNormalisasiTerbobot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVNormalisasiTerbobot.Location = New System.Drawing.Point(3, 3)
        Me.DGVNormalisasiTerbobot.Name = "DGVNormalisasiTerbobot"
        Me.DGVNormalisasiTerbobot.Size = New System.Drawing.Size(576, 380)
        Me.DGVNormalisasiTerbobot.TabIndex = 1
        '
        'TP4
        '
        Me.TP4.Controls.Add(Me.DGVSolusiIdeal)
        Me.TP4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TP4.Location = New System.Drawing.Point(4, 30)
        Me.TP4.Name = "TP4"
        Me.TP4.Padding = New System.Windows.Forms.Padding(3)
        Me.TP4.Size = New System.Drawing.Size(582, 386)
        Me.TP4.TabIndex = 2
        Me.TP4.Text = "Matrix Solusi Ideal"
        Me.TP4.UseVisualStyleBackColor = True
        '
        'DGVSolusiIdeal
        '
        Me.DGVSolusiIdeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSolusiIdeal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVSolusiIdeal.Location = New System.Drawing.Point(3, 3)
        Me.DGVSolusiIdeal.Name = "DGVSolusiIdeal"
        Me.DGVSolusiIdeal.Size = New System.Drawing.Size(576, 380)
        Me.DGVSolusiIdeal.TabIndex = 1
        '
        'TP5
        '
        Me.TP5.Controls.Add(Me.DGVJarakSolusi)
        Me.TP5.Controls.Add(Me.PJarakSolusi)
        Me.TP5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TP5.Location = New System.Drawing.Point(4, 30)
        Me.TP5.Name = "TP5"
        Me.TP5.Padding = New System.Windows.Forms.Padding(3)
        Me.TP5.Size = New System.Drawing.Size(582, 386)
        Me.TP5.TabIndex = 3
        Me.TP5.Text = "Jarak Solusi Ideal"
        Me.TP5.UseVisualStyleBackColor = True
        '
        'DGVJarakSolusi
        '
        Me.DGVJarakSolusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVJarakSolusi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVJarakSolusi.Location = New System.Drawing.Point(3, 91)
        Me.DGVJarakSolusi.Name = "DGVJarakSolusi"
        Me.DGVJarakSolusi.Size = New System.Drawing.Size(576, 292)
        Me.DGVJarakSolusi.TabIndex = 3
        '
        'PJarakSolusi
        '
        Me.PJarakSolusi.Controls.Add(Me.RBNegatif)
        Me.PJarakSolusi.Controls.Add(Me.RBPositif)
        Me.PJarakSolusi.Dock = System.Windows.Forms.DockStyle.Top
        Me.PJarakSolusi.Location = New System.Drawing.Point(3, 3)
        Me.PJarakSolusi.Name = "PJarakSolusi"
        Me.PJarakSolusi.Size = New System.Drawing.Size(576, 88)
        Me.PJarakSolusi.TabIndex = 2
        '
        'RBNegatif
        '
        Me.RBNegatif.AutoSize = True
        Me.RBNegatif.Location = New System.Drawing.Point(38, 45)
        Me.RBNegatif.Name = "RBNegatif"
        Me.RBNegatif.Size = New System.Drawing.Size(68, 21)
        Me.RBNegatif.TabIndex = 1
        Me.RBNegatif.TabStop = True
        Me.RBNegatif.Text = "Negatif"
        Me.RBNegatif.UseVisualStyleBackColor = True
        '
        'RBPositif
        '
        Me.RBPositif.AutoSize = True
        Me.RBPositif.Location = New System.Drawing.Point(38, 18)
        Me.RBPositif.Name = "RBPositif"
        Me.RBPositif.Size = New System.Drawing.Size(61, 21)
        Me.RBPositif.TabIndex = 0
        Me.RBPositif.TabStop = True
        Me.RBPositif.Text = "Positif"
        Me.RBPositif.UseVisualStyleBackColor = True
        '
        'TP6
        '
        Me.TP6.Controls.Add(Me.DGVPreferensi)
        Me.TP6.Controls.Add(Me.Panel2)
        Me.TP6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TP6.Location = New System.Drawing.Point(4, 30)
        Me.TP6.Name = "TP6"
        Me.TP6.Padding = New System.Windows.Forms.Padding(3)
        Me.TP6.Size = New System.Drawing.Size(582, 386)
        Me.TP6.TabIndex = 4
        Me.TP6.Text = "Nilai Preferensi"
        Me.TP6.UseVisualStyleBackColor = True
        '
        'DGVPreferensi
        '
        Me.DGVPreferensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPreferensi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPreferensi.Location = New System.Drawing.Point(3, 34)
        Me.DGVPreferensi.Name = "DGVPreferensi"
        Me.DGVPreferensi.Size = New System.Drawing.Size(576, 349)
        Me.DGVPreferensi.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCetak)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(576, 31)
        Me.Panel2.TabIndex = 2
        '
        'BtnCetak
        '
        Me.BtnCetak.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCetak.Location = New System.Drawing.Point(424, 0)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(152, 31)
        Me.BtnCetak.TabIndex = 0
        Me.BtnCetak.Text = "Cetak"
        Me.BtnCetak.UseVisualStyleBackColor = True
        Me.BtnCetak.Visible = False
        '
        'f_topsis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 474)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PJudul)
        Me.KeyPreview = True
        Me.Name = "f_topsis"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form Proses"
        Me.PJudul.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TP1.ResumeLayout(False)
        CType(Me.DGVAnalisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TP2.ResumeLayout(False)
        CType(Me.DGVNormalisasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP3.ResumeLayout(False)
        CType(Me.DGVNormalisasiTerbobot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP4.ResumeLayout(False)
        CType(Me.DGVSolusiIdeal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP5.ResumeLayout(False)
        CType(Me.DGVJarakSolusi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PJarakSolusi.ResumeLayout(False)
        Me.PJarakSolusi.PerformLayout()
        Me.TP6.ResumeLayout(False)
        CType(Me.DGVPreferensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PJudul As System.Windows.Forms.Panel
    Friend WithEvents lbJudul As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TP2 As System.Windows.Forms.TabPage
    Friend WithEvents TP3 As System.Windows.Forms.TabPage
    Friend WithEvents TP4 As System.Windows.Forms.TabPage
    Friend WithEvents TP5 As System.Windows.Forms.TabPage
    Friend WithEvents TP6 As System.Windows.Forms.TabPage
    Friend WithEvents TP1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CBSubKriteria As System.Windows.Forms.ComboBox
    Friend WithEvents CBKriteria As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents DGVAnalisa As System.Windows.Forms.DataGridView
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents DGVNormalisasi As System.Windows.Forms.DataGridView
    Friend WithEvents DGVNormalisasiTerbobot As System.Windows.Forms.DataGridView
    Friend WithEvents DGVSolusiIdeal As System.Windows.Forms.DataGridView
    Friend WithEvents DGVJarakSolusi As System.Windows.Forms.DataGridView
    Friend WithEvents PJarakSolusi As System.Windows.Forms.Panel
    Friend WithEvents RBNegatif As System.Windows.Forms.RadioButton
    Friend WithEvents RBPositif As System.Windows.Forms.RadioButton
    Friend WithEvents DGVPreferensi As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
End Class
