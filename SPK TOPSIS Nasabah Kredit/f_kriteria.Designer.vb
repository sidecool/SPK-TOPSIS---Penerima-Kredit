<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_kriteria
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
        Me.RBAtributCost = New System.Windows.Forms.RadioButton
        Me.RBAtributBenefit = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.TBBobot = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TBNama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBKode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGView = New System.Windows.Forms.DataGridView
        Me.PForm = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PJudul.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PForm.SuspendLayout()
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
        Me.PJudul.Size = New System.Drawing.Size(568, 54)
        Me.PJudul.TabIndex = 24
        '
        'lbJudul
        '
        Me.lbJudul.BackColor = System.Drawing.SystemColors.Control
        Me.lbJudul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbJudul.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJudul.Location = New System.Drawing.Point(0, 0)
        Me.lbJudul.Name = "lbJudul"
        Me.lbJudul.Size = New System.Drawing.Size(566, 52)
        Me.lbJudul.TabIndex = 0
        Me.lbJudul.Text = "DATA KRITERIA"
        Me.lbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(459, 221)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 33)
        Me.BtnTutup.TabIndex = 23
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(263, 221)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 33)
        Me.BtnHapus.TabIndex = 22
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(182, 221)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.BtnSimpan.TabIndex = 21
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'RBAtributCost
        '
        Me.RBAtributCost.AutoSize = True
        Me.RBAtributCost.Location = New System.Drawing.Point(257, 169)
        Me.RBAtributCost.Name = "RBAtributCost"
        Me.RBAtributCost.Size = New System.Drawing.Size(54, 21)
        Me.RBAtributCost.TabIndex = 20
        Me.RBAtributCost.TabStop = True
        Me.RBAtributCost.Text = "Cost"
        Me.RBAtributCost.UseVisualStyleBackColor = True
        '
        'RBAtributBenefit
        '
        Me.RBAtributBenefit.AutoSize = True
        Me.RBAtributBenefit.Location = New System.Drawing.Point(182, 169)
        Me.RBAtributBenefit.Name = "RBAtributBenefit"
        Me.RBAtributBenefit.Size = New System.Drawing.Size(67, 21)
        Me.RBAtributBenefit.TabIndex = 19
        Me.RBAtributBenefit.TabStop = True
        Me.RBAtributBenefit.Text = "Benefit"
        Me.RBAtributBenefit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Atribut"
        '
        'TBBobot
        '
        Me.TBBobot.Location = New System.Drawing.Point(182, 135)
        Me.TBBobot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBBobot.Name = "TBBobot"
        Me.TBBobot.Size = New System.Drawing.Size(67, 24)
        Me.TBBobot.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Bobot"
        '
        'TBNama
        '
        Me.TBNama.Location = New System.Drawing.Point(182, 103)
        Me.TBNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(352, 24)
        Me.TBNama.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nama Kriteria"
        '
        'TBKode
        '
        Me.TBKode.Location = New System.Drawing.Point(182, 71)
        Me.TBKode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBKode.Name = "TBKode"
        Me.TBKode.Size = New System.Drawing.Size(67, 24)
        Me.TBKode.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode"
        '
        'DGView
        '
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGView.Location = New System.Drawing.Point(0, 272)
        Me.DGView.Name = "DGView"
        Me.DGView.Size = New System.Drawing.Size(568, 216)
        Me.DGView.TabIndex = 15
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.Color.Turquoise
        Me.PForm.Controls.Add(Me.PJudul)
        Me.PForm.Controls.Add(Me.BtnTutup)
        Me.PForm.Controls.Add(Me.BtnHapus)
        Me.PForm.Controls.Add(Me.BtnSimpan)
        Me.PForm.Controls.Add(Me.RBAtributCost)
        Me.PForm.Controls.Add(Me.RBAtributBenefit)
        Me.PForm.Controls.Add(Me.Label4)
        Me.PForm.Controls.Add(Me.TBBobot)
        Me.PForm.Controls.Add(Me.Label3)
        Me.PForm.Controls.Add(Me.TBNama)
        Me.PForm.Controls.Add(Me.Label2)
        Me.PForm.Controls.Add(Me.TBKode)
        Me.PForm.Controls.Add(Me.Label1)
        Me.PForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.PForm.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PForm.Location = New System.Drawing.Point(0, 0)
        Me.PForm.Name = "PForm"
        Me.PForm.Size = New System.Drawing.Size(568, 272)
        Me.PForm.TabIndex = 14
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_kriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 488)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.PForm)
        Me.Name = "f_kriteria"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Kriteria"
        Me.TopMost = True
        Me.PJudul.ResumeLayout(False)
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PForm.ResumeLayout(False)
        Me.PForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PJudul As System.Windows.Forms.Panel
    Friend WithEvents lbJudul As System.Windows.Forms.Label
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents RBAtributCost As System.Windows.Forms.RadioButton
    Friend WithEvents RBAtributBenefit As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBBobot As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBKode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGView As System.Windows.Forms.DataGridView
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
