<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_cari
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
        Me.PCari = New System.Windows.Forms.Panel
        Me.BtnCari = New System.Windows.Forms.Button
        Me.TBKey = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGVCari = New System.Windows.Forms.DataGridView
        Me.PCari.SuspendLayout()
        CType(Me.DGVCari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCari
        '
        Me.PCari.Controls.Add(Me.BtnCari)
        Me.PCari.Controls.Add(Me.TBKey)
        Me.PCari.Controls.Add(Me.Label1)
        Me.PCari.Dock = System.Windows.Forms.DockStyle.Top
        Me.PCari.Location = New System.Drawing.Point(0, 0)
        Me.PCari.Name = "PCari"
        Me.PCari.Size = New System.Drawing.Size(388, 78)
        Me.PCari.TabIndex = 0
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(338, 29)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(38, 23)
        Me.BtnCari.TabIndex = 2
        Me.BtnCari.Text = "..."
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TBKey
        '
        Me.TBKey.Location = New System.Drawing.Point(81, 31)
        Me.TBKey.Name = "TBKey"
        Me.TBKey.Size = New System.Drawing.Size(251, 20)
        Me.TBKey.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Keyword"
        '
        'DGVCari
        '
        Me.DGVCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCari.Location = New System.Drawing.Point(0, 78)
        Me.DGVCari.Name = "DGVCari"
        Me.DGVCari.Size = New System.Drawing.Size(388, 357)
        Me.DGVCari.TabIndex = 1
        '
        'f_cari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVCari)
        Me.Controls.Add(Me.PCari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "f_cari"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian"
        Me.PCari.ResumeLayout(False)
        Me.PCari.PerformLayout()
        CType(Me.DGVCari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PCari As System.Windows.Forms.Panel
    Friend WithEvents DGVCari As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents TBKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
