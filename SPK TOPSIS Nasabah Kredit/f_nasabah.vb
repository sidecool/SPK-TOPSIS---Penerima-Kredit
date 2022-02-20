Public Class f_nasabah

    Private Sub TampilData()
        SQL = "SELECT NO_KTP, NM_PEMOHON, ALAMAT, NO_TELP FROM TBL_PEMOHON ORDER BY NO_KTP"

        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "TBL_PEMOHON")
        DGView.DataSource = DS.Tables("TBL_PEMOHON")

        DGView.Columns(0).HeaderText = "NO KTP"
        DGView.Columns(1).HeaderText = "NAMA PEMOHON"
        DGView.Columns(2).HeaderText = "ALAMAT"
        DGView.Columns(3).HeaderText = "NO TELP"

        'Properties DGView
        DGView.ShowEditingIcon = False
        DGView.AllowUserToAddRows = False
        DGView.AllowUserToDeleteRows = False
        DGView.AllowUserToResizeRows = False
        DGView.MultiSelect = False
        DGView.ReadOnly = True
        DGView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'End Properties DGV

        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub f_nasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterParent
        Me.WindowState = FormWindowState.Maximized

        CBJenisKelamin.DisplayMember = "Text"
        CBJenisKelamin.ValueMember = "Value"
        CBJenisKelamin.Items.Add(New With {.Text = "Laki-laki", .Value = "L"})
        CBJenisKelamin.Items.Add(New With {.Text = "Perempuan", .Value = "P"})
        CBJenisKelamin.SelectedIndex = 0

        CBStatus.DisplayMember = "Text"
        CBStatus.ValueMember = "Value"
        CBStatus.Items.Add(New With {.Text = "Sudah", .Value = "S"})
        CBStatus.Items.Add(New With {.Text = "Belum", .Value = "B"})
        CBStatus.Items.Add(New With {.Text = "Cerai", .Value = "C"})
        CBStatus.SelectedIndex = 0

        CBWaktu.DisplayMember = "Text"
        CBWaktu.ValueMember = "Value"
        CBWaktu.Items.Add(New With {.Text = "Minggu", .Value = "M"})
        CBWaktu.Items.Add(New With {.Text = "Bulan", .Value = "B"})
        CBWaktu.SelectedIndex = 0

        TampilData()
    End Sub

    Private Sub TBKTP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKTP.KeyDown, TBPlafonKredit.KeyDown, TBPekerjaan.KeyDown, TBNoTelp.KeyDown, TBNama.KeyDown, TBJangkaWaktu.KeyDown, TBIbu.KeyDown, TBAlamat.KeyDown, CBStatus.KeyDown, CBJenisKelamin.KeyDown, CBWaktu.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBKTP Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                CBJenisKelamin.Focus()
            ElseIf sender Is CBJenisKelamin Then
                TBAlamat.Focus()
            ElseIf sender Is TBAlamat Then
                TBNoTelp.Focus()
            ElseIf sender Is TBNoTelp Then
                TBPekerjaan.Focus()
            ElseIf sender Is TBPekerjaan Then
                CBStatus.Focus()
            ElseIf sender Is CBStatus Then
                TBIbu.Focus()
            ElseIf sender Is TBIbu Then
                TBPlafonKredit.Focus()
            ElseIf sender Is TBPlafonKredit Then
                TBJangkaWaktu.Focus()
            ElseIf sender Is TBJangkaWaktu Then
                CBWaktu.Focus()
            ElseIf sender Is CBWaktu Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TBKTP_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBKTP.Leave
        SQL = "SELECT * FROM TBL_PEMOHON WHERE NO_KTP='" & TBKTP.Text & "'"

        If TBKTP.Text <> "" Then
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                Kode = ""
                TBNama.Clear()
                CBJenisKelamin.SelectedIndex = 0
                TBAlamat.Clear()
                TBNoTelp.Clear()
                TBPekerjaan.Clear()
                CBStatus.SelectedIndex = 0
                TBIbu.Clear()
                TBPlafonKredit.Clear()
                TBJangkaWaktu.Clear()
                CBWaktu.SelectedIndex = 0

                BtnHapus.Enabled = False
            Else
                MyDataReader.Read()
                Kode = MyDataReader!KD_PEMOHON                
                TBNama.Text = MyDataReader!NM_PEMOHON
                If MyDataReader!JENIS_KELAMIN = "L" Or MyDataReader!JENIS_KELAMIN = "" Then
                    CBJenisKelamin.SelectedIndex = CBJenisKelamin.FindStringExact("Laki-laki")
                ElseIf MyDataReader!JENIS_KELAMIN = "P" Then
                    CBJenisKelamin.SelectedIndex = CBJenisKelamin.FindStringExact("Perempuan")
                End If
                TBAlamat.Text = MyDataReader!ALAMAT
                TBNoTelp.Text = MyDataReader!NO_TELP
                TBPekerjaan.Text = MyDataReader!PEKERJAAN
                If MyDataReader!IS_MENIKAH = "S" Or MyDataReader!IS_MENIKAH = "" Then
                    CBStatus.SelectedIndex = CBStatus.FindStringExact("Sudah")
                ElseIf MyDataReader!IS_MENIKAH = "B" Then
                    CBStatus.SelectedIndex = CBStatus.FindStringExact("Belum")
                ElseIf MyDataReader!IS_MENIKAH = "C" Then
                    CBStatus.SelectedIndex = CBStatus.FindStringExact("Cerai")
                End If
                TBIbu.Text = MyDataReader!NM_IBU
                TBPlafonKredit.Text = MyDataReader!PLAFON
                TBJangkaWaktu.Text = MyDataReader!JANGKA_WAKTU
                If MyDataReader!WAKTU = "M" Or MyDataReader!WAKTU = "" Then
                    CBWaktu.SelectedIndex = CBWaktu.FindStringExact("Minggu")
                ElseIf MyDataReader!WAKTU = "B" Then
                    CBWaktu.SelectedIndex = CBWaktu.FindStringExact("Bulan")
                End If

                BtnHapus.Enabled = True
            End If
        Else
            TBNama.Clear()
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Dim Kode As String
    Private Sub BuatKode()
        SQL = "SELECT KD_PEMOHON FROM TBL_PEMOHON ORDER BY KD_PEMOHON DESC"

        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader()

        MyDataReader.Read()
        If Not MyDataReader.HasRows Then
            Kode = "A" + "0001"
        Else
            Kode = Val(Microsoft.VisualBasic.Mid(MyDataReader.Item("KD_PEMOHON").ToString, 3)) + 1

            If Len(Kode) = 1 Then
                Kode = "A000" & Kode & ""
            ElseIf Len(Kode) = 2 Then
                Kode = "A00" & Kode & ""
            ElseIf Len(Kode) = 3 Then
                Kode = "A0" & Kode & ""
            End If
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If Kode = "" Then
            BuatKode()
        End If

        SQL = "INSERT INTO TBL_PEMOHON VALUES ('" & Kode & "','" & TBNama.Text & "','" & TBKTP.Text & "','" & TBAlamat.Text & "','" & CBJenisKelamin.SelectedItem.Value & "','" & TBNoTelp.Text & "','" & CBStatus.SelectedItem.Value & "','" & TBPekerjaan.Text & "','" & TBIbu.Text & "'," & TBPlafonKredit.Text & "," & TBJangkaWaktu.Text & ",'" & CBWaktu.SelectedItem.Value & "') " _
            & "ON DUPLICATE KEY UPDATE NM_PEMOHON='" & TBNama.Text & "'," _
            & "NO_KTP='" & TBKTP.Text & "'," _
            & "JENIS_KELAMIN='" & CBJenisKelamin.SelectedItem.Value & "'," _
            & "ALAMAT='" & TBAlamat.Text & "'," _
            & "NO_TELP='" & TBNoTelp.Text & "'," _
            & "PEKERJAAN='" & TBPekerjaan.Text & "'," _
            & "IS_MENIKAH='" & CBStatus.SelectedItem.Value & "'," _
            & "NM_IBU='" & TBIbu.Text & "'," _
            & "PLAFON=" & TBPlafonKredit.Text & "," _
            & "JANGKA_WAKTU=" & TBJangkaWaktu.Text & "," _
            & "WAKTU='" & CBWaktu.SelectedItem.Value & "'"

        ErrorProvider1.Clear()
        If TBKTP.Text = "" Then
            ErrorProvider1.SetError(TBKTP, "KTP tidak boleh kosong.")
            TBKTP.Focus()
        ElseIf TBNama.Text = "" Then
            ErrorProvider1.SetError(TBNama, "Nama Pemohon tidak boleh kosong.")
            TBNama.Focus()
        Else
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

            Try
                MyCommand.ExecuteNonQuery()
                MsgBox("Data '" & TBKTP.Text & "' berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
                TampilData()

                TBKTP.Clear()
                TBNama.Clear()
                CBJenisKelamin.SelectedIndex = 0
                TBAlamat.Clear()
                TBNoTelp.Clear()
                TBPekerjaan.Clear()
                CBStatus.SelectedIndex = 0
                TBIbu.Clear()
                TBPlafonKredit.Clear()
                TBJangkaWaktu.Clear()
                CBWaktu.SelectedIndex = 0

                TBKTP.Focus()
                ErrorProvider1.Clear()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
            End Try
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        SQL = "DELETE FROM TBL_PEMOHON WHERE KD_PEMOHON='" & Kode & "'"

        If TBKTP.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus.", MsgBoxStyle.Exclamation, "Error")
            TBKTP.Focus()
        Else
            If MessageBox.Show("Apakah Anda ingin menghapus data '" & TBKTP.Text & "' ?", "Konfirmasi", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBKTP.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilData()

                    TBKTP.Clear()
                    TBNama.Clear()
                    CBJenisKelamin.SelectedIndex = 0
                    TBAlamat.Clear()
                    TBNoTelp.Clear()
                    TBPekerjaan.Clear()
                    CBStatus.SelectedIndex = 0
                    TBIbu.Clear()
                    TBPlafonKredit.Clear()
                    TBJangkaWaktu.Clear()
                    CBWaktu.SelectedIndex = 0

                    TBKTP.Focus()

                    BtnHapus.Enabled = False
                    ErrorProvider1.Clear()
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                    TBKTP.Focus()
                End Try
            End If
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub DGView_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGView.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells(1).Value) Then
                TBKTP.Text = sender.Rows(e.RowIndex).Cells(0).Value
                TBKTP_Leave(sender, e)
                TBNama.Focus()
            End If
        End If
    End Sub

    Private Sub TBPlafonKredit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBPlafonKredit.KeyPress, TBJangkaWaktu.KeyPress, TBNoTelp.KeyPress
        ErrorProvider1.Clear()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            If sender Is TBPlafonKredit Then
                ErrorProvider1.SetError(sender, "Plafon kredit hanya diisi angka. ex: 1000000")
                TBPlafonKredit.Focus()
            ElseIf sender Is TBJangkaWaktu Then
                ErrorProvider1.SetError(sender, "Jangka waktu hanya diisi angka dalam Minggu/Bulan (pilihan). ex: 15 (dibaca 15 Minggu/Bulan)")
                TBJangkaWaktu.Focus()
            ElseIf sender Is TBNoTelp Then
                ErrorProvider1.SetError(sender, "Nomor telepon hanya diisi angka. ex: 081122223333")
                TBNoTelp.Focus()
            End If
        End If
    End Sub
End Class