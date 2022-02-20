<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_sub_kriteria
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
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.PForm = New System.Windows.Forms.Panel
        Me.lbKriteria = New System.Windows.Forms.Label
        Me.CBKriteria = New System.Windows.Forms.ComboBox
        Me.TBNama = New System.Windows.Forms.TextBox
        Me.lbNamaSub = New System.Windows.Forms.Label
        Me.TBKode = New System.Windows.Forms.TextBox
        Me.lbKodeSub = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DGView = New System.Windows.Forms.DataGridView
        Me.PJudul.SuspendLayout()
        Me.PForm.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PJudul
        '
        Me.PJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PJudul.Controls.Add(Me.lbJudul)
        Me.PJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.PJudul.Location = New System.Drawing.Point(0, 0)
        Me.PJudul.Name = "PJudul"
        Me.PJudul.Size = New System.Drawing.Size(559, 54)
        Me.PJudul.TabIndex = 24
        '
        'lbJudul
        '
        Me.lbJudul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbJudul.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJudul.Location = New System.Drawing.Point(0, 0)
        Me.lbJudul.Name = "lbJudul"
        Me.lbJudul.Size = New System.Drawing.Size(557, 52)
        Me.lbJudul.TabIndex = 0
        Me.lbJudul.Text = "DATA SUB-KRITERIA"
        Me.lbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(459, 190)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 33)
        Me.BtnTutup.TabIndex = 5
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(263, 190)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 33)
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(182, 190)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.Color.Turquoise
        Me.PForm.Controls.Add(Me.lbKriteria)
        Me.PForm.Controls.Add(Me.CBKriteria)
        Me.PForm.Controls.Add(Me.PJudul)
        Me.PForm.Controls.Add(Me.BtnTutup)
        Me.PForm.Controls.Add(Me.BtnHapus)
        Me.PForm.Controls.Add(Me.BtnSimpan)
        Me.PForm.Controls.Add(Me.TBNama)
        Me.PForm.Controls.Add(Me.lbNamaSub)
        Me.PForm.Controls.Add(Me.TBKode)
        Me.PForm.Controls.Add(Me.lbKodeSub)
        Me.PForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.PForm.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PForm.Location = New System.Drawing.Point(0, 0)
        Me.PForm.Name = "PForm"
        Me.PForm.Size = New System.Drawing.Size(559, 236)
        Me.PForm.TabIndex = 16
        '
        'lbKriteria
        '
        Me.lbKriteria.AutoSize = True
        Me.lbKriteria.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKriteria.Location = New System.Drawing.Point(30, 80)
        Me.lbKriteria.Name = "lbKriteria"
        Me.lbKriteria.Size = New System.Drawing.Size(95, 16)
        Me.lbKriteria.TabIndex = 26
        Me.lbKriteria.Text = "Nama Kriteria"
        '
        'CBKriteria
        '
        Me.CBKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBKriteria.FormattingEnabled = True
        Me.CBKriteria.Location = New System.Drawing.Point(182, 77)
        Me.CBKriteria.Name = "CBKriteria"
        Me.CBKriteria.Size = New System.Drawing.Size(352, 24)
        Me.CBKriteria.TabIndex = 0
        '
        'TBNama
        '
        Me.TBNama.Location = New System.Drawing.Point(182, 142)
        Me.TBNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(352, 24)
        Me.TBNama.TabIndex = 2
        '
        'lbNamaSub
        '
        Me.lbNamaSub.AutoSize = True
        Me.lbNamaSub.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamaSub.Location = New System.Drawing.Point(30, 146)
        Me.lbNamaSub.Name = "lbNamaSub"
        Me.lbNamaSub.Size = New System.Drawing.Size(123, 16)
        Me.lbNamaSub.TabIndex = 14
        Me.lbNamaSub.Text = "Nama Sub Kriteria"
        '
        'TBKode
        '
        Me.TBKode.Location = New System.Drawing.Point(182, 110)
        Me.TBKode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBKode.Name = "TBKode"
        Me.TBKode.Size = New System.Drawing.Size(67, 24)
        Me.TBKode.TabIndex = 1
        '
        'lbKodeSub
        '
        Me.lbKodeSub.AutoSize = True
        Me.lbKodeSub.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKodeSub.Location = New System.Drawing.Point(30, 114)
        Me.lbKodeSub.Name = "lbKodeSub"
        Me.lbKodeSub.Size = New System.Drawing.Size(120, 16)
        Me.lbKodeSub.TabIndex = 12
        Me.lbKodeSub.Text = "Kode Sub Kriteria"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DGView
        '
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGView.Location = New System.Drawing.Point(0, 236)
        Me.DGView.Name = "DGView"
        Me.DGView.Size = New System.Drawing.Size(559, 275)
        Me.DGView.TabIndex = 18
        '
        'f_sub_kriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 511)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.PForm)
        Me.Name = "f_sub_kriteria"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Sub Kriteria"
        Me.PJudul.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.PForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PJudul As System.Windows.Forms.Panel
    Friend WithEvents lbJudul As System.Windows.Forms.Label
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents lbNamaSub As System.Windows.Forms.Label
    Friend WithEvents TBKode As System.Windows.Forms.TextBox
    Friend WithEvents lbKodeSub As System.Windows.Forms.Label
    Friend WithEvents lbKriteria As System.Windows.Forms.Label
    Friend WithEvents CBKriteria As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DGView As System.Windows.Forms.DataGridView
End Class
