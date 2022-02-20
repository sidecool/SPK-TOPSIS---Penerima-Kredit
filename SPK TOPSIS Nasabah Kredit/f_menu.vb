Imports MySql.Data.MySqlClient

Public Class f_menu

    Private Sub f_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Sistem Pendukung Keputusan - Penentuan Kelayakan Nasabah Kredit"
        MenuStrip1.Visible = False
        Label1.Text = "SISTEM PENDUKUNG KEPUTUSAN" & vbLf _
                    & "PENENTUAN KELAYAKAN NASABAH PENERIMA KREDIT" & vbLf _
                    & "MENGGUNAKAN METODE TOPSIS"

        Label1.Left = (Label1.Parent.Width \ 2) - (Label1.Width \ 2)
        PictureBox1.Left = (PictureBox1.Parent.Width \ 2) - (PictureBox1.Width \ 2)

        ToolStripStatusLabel1.Text = "Tanggal : " & Format(Date.Today, "dd/MM/yyyy")
        ToolStripStatusLabel3.Visible = False
        Timer1.Start()

        'Koneksi Database

        'menyiapkan string untuk menampung lokasi file .ini 
        Dim FilePath As String = Application.StartupPath & "\setting.ini"
        
        Dim Server = ReadIni(FilePath, "ConfigDB", "Server", "")
        Dim Port = ReadIni(FilePath, "ConfigDB", "Port", "")
        Dim User = ReadIni(FilePath, "ConfigDB", "User", "")
        Dim Pass = ReadIni(FilePath, "ConfigDB", "Password", "")
        Dim DBName = ReadIni(FilePath, "ConfigDB", "DBName", "")
                
        If cek_koneksi(Server, Port, User, Pass, DBName) = True Then
            f_login.ShowDialog()
        Else
            f_dbconfig.ShowDialog()
            MsgBox("Database tidak ditemukan.", MsgBoxStyle.Exclamation, "Error Database")
            End
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = "Jam : " & Format(TimeOfDay, "hh:mm:ss")
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        MenuStrip1.Visible = False
        ToolStripStatusLabel3.Text = "Login as : "
        ToolStripStatusLabel3.Visible = False

        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_login.ShowDialog()
    End Sub

    Public Sub LogoutClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoginToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub DataKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKriteriaToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_kriteria.MdiParent = Me
        f_kriteria.Show()
    End Sub

    Private Sub DataSubkriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSubkriteriaToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_sub_kriteria.MdiParent = Me
        f_sub_kriteria.Show()
    End Sub

    Private Sub DataNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNasabahToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_nasabah.MdiParent = Me
        f_nasabah.Show()
    End Sub

    Private Sub AnalisisKeputusanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalisisKeputusanToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_topsis.MdiParent = Me
        f_topsis.Show()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_ganti_paswd.MdiParent = Me
        f_ganti_paswd.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub


    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_laporan.MdiParent = Me
        f_laporan.WindowState = FormWindowState.Maximized
        f_laporan.Show()

        'Dim DS As New DSPreferensi
        'MyDataAdapter = New MySqlDataAdapter("SELECT * FROM v_laporan", MyConn)
        'MyDataAdapter.Fill(DS, "v_laporan")

        'Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'reportDocument = New CRLaporan
        'reportDocument.SetDataSource(DS)
        'f_laporan.CRV.ReportSource = reportDocument
        'f_laporan.CRV.Refresh()

        'MyConn.Close()
        'MyConn.Open()
    End Sub
End Class
