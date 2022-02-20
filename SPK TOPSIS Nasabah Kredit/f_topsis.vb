Imports MySql.Data.MySqlClient

Public Class f_topsis

    Private Sub f_topsis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterParent
        Me.WindowState = FormWindowState.Maximized

        BtnHapus.Enabled = False

        TabControl1.SelectedIndex = 0
        TabControl1_SelectedIndexChanged(sender, e)
    End Sub

#Region "Analisa"

    Private Sub TampilMatriksAnalisa()
        Dim ArrNM_KRITERIA(4) As String
        SQL = "SELECT kd_kriteria, nm_kriteria FROM tbl_kriteria ORDER BY kd_kriteria"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If MyDataReader.HasRows Then
            Dim i = 0
            Do While MyDataReader.Read
                ArrNM_KRITERIA(i) = MyDataReader!nm_kriteria
                i += 1
            Loop
        End If
        MyConn.Close()
        MyConn.Open()

        SQL = "SELECT kd_alternatif AS 'Kode', nm_alternatif AS 'Nama Pemohon', " _
            & "MAX(CASE WHEN kd_kriteria='C1' THEN keterangan ELSE NULL END) AS '[C1] " & ArrNM_KRITERIA(0) & "', " _
            & "MAX(CASE WHEN kd_kriteria='C2' THEN keterangan ELSE NULL END) AS '[C2] " & ArrNM_KRITERIA(1) & "', " _
            & "MAX(CASE WHEN kd_kriteria='C3' THEN keterangan ELSE NULL END) AS '[C3] " & ArrNM_KRITERIA(2) & "', " _
            & "MAX(CASE WHEN kd_kriteria='C4' THEN keterangan ELSE NULL END) AS '[C4] " & ArrNM_KRITERIA(3) & "' " _
            & "FROM v_analisa " _
            & "GROUP BY kd_alternatif"

        MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "v_analisa")
        DGVAnalisa.DataSource = DS.Tables("v_analisa")

        'Properties DGV            
        DGVAnalisa.ShowEditingIcon = False
        DGVAnalisa.AllowUserToAddRows = False
        DGVAnalisa.AllowUserToDeleteRows = False
        DGVAnalisa.AllowUserToResizeRows = False
        DGVAnalisa.MultiSelect = False
        DGVAnalisa.ReadOnly = True
        DGVAnalisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVAnalisa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DGVAnalisa.EnableHeadersVisualStyles = False
        For i = 0 To DGVAnalisa.Columns.Count - 1
            DGVAnalisa.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            DGVAnalisa.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVAnalisa.Columns(i).HeaderCell.Style.BackColor = Color.Navy
            DGVAnalisa.Columns(i).HeaderCell.Style.ForeColor = Color.White
            DGVAnalisa.Columns(i).HeaderCell.Style.Font = New Font(DGVAnalisa.Font, FontStyle.Bold)
        Next
        'End Properties DGV

        MyConn.Close()
        MyConn.Open()
    End Sub

    Dim KD_ALTERNATIF As String
    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Dim Form_Pencarian As New f_cari
        Form_Pencarian.ShowDialog()
        Form_Pencarian.TopMost = True
        KD_ALTERNATIF = Form_Pencarian.KODE
        TBNama.Text = Form_Pencarian.NAMA        
    End Sub

    Private Sub TBNama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBNama.KeyDown
        If e.KeyValue = Keys.F3 Then
            e.SuppressKeyPress = True
            BtnCari_Click(sender, e)
        End If
    End Sub

    Private Sub TBNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNama.TextChanged
        CBKriteria.Items.Clear()
        CBSubKriteria.Items.Clear()
        If Not TBNama.Text = "" Then
            BtnHapus.Enabled = True
            Call IsiKriteria()
        End If
    End Sub

    Dim ArrKD_KRITERIA() As String
    Dim ArrN_BOBOT() As String
    Dim ArrN_ATRIBUT() As String
    Private Sub IsiKriteria()
        SQL = "SELECT COUNT(*) AS jumlah FROM tbl_kriteria"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        Dim JmlBaris = MyDataReader!jumlah
        ReDim ArrKD_KRITERIA(JmlBaris)
        ReDim ArrN_BOBOT(JmlBaris)
        ReDim ArrN_ATRIBUT(JmlBaris)
        MyConn.Close()
        MyConn.Open()

        SQL = "SELECT kd_kriteria, nm_kriteria, n_bobot, n_atribut FROM tbl_kriteria ORDER BY kd_kriteria"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If MyDataReader.HasRows Then
            CBKriteria.Items.Clear()
            Dim i = 0
            Do While MyDataReader.Read
                CBKriteria.Items.Add(MyDataReader!nm_kriteria)
                ArrKD_KRITERIA(i) = MyDataReader!kd_kriteria
                ArrN_BOBOT(i) = MyDataReader!n_bobot
                ArrN_ATRIBUT(i) = MyDataReader!n_atribut
                i += 1
            Loop
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub CBKriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBKriteria.SelectedIndexChanged
        If CBKriteria.SelectedIndex >= 0 Then
            CBSubKriteria.Items.Clear()
            Call IsiSubKriteria(ArrKD_KRITERIA(CBKriteria.SelectedIndex))
        End If
    End Sub

    Dim ArrKD_SUB_KRITERIA() As String
    Dim ArrKD_SUB() As String
    Private Sub IsiSubKriteria(ByVal KD_KRITERIA As String)
        SQL = "SELECT COUNT(*) AS jumlah FROM tbl_sub_kriteria"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        Dim JmlBaris = MyDataReader!jumlah
        ReDim ArrKD_SUB_KRITERIA(JmlBaris)
        ReDim ArrKD_SUB(JmlBaris)
        MyConn.Close()
        MyConn.Open()

        SQL = "SELECT kd_sub_kriteria, kd_kriteria, kd_sub, keterangan FROM tbl_sub_kriteria WHERE kd_kriteria='" & KD_KRITERIA & "' ORDER BY kd_sub"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader()
        If MyDataReader.HasRows Then
            Dim i = 0
            Do While MyDataReader.Read
                CBSubKriteria.Items.Add(MyDataReader!keterangan)
                ArrKD_SUB_KRITERIA(i) = MyDataReader!kd_sub_kriteria
                ArrKD_SUB(i) = MyDataReader!kd_sub
                i += 1
            Loop
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If Not TBNama.Text = "" Then
            If CBKriteria.SelectedIndex >= 0 Then
                If CBSubKriteria.SelectedIndex >= 0 Then
                    SQL = "INSERT INTO tbl_matriks_kriteria (kd_matriks, " _
                        & "                                  kd_alternatif, " _
                        & "                                  kd_sub_kriteria, " _
                        & "                                  kd_kriteria, " _
                        & "                                  kd_sub) " _
                        & "VALUES (?, ?, ?, ?, ?) " _
                        & "ON DUPLICATE KEY UPDATE kd_sub_kriteria=VALUES(kd_sub_kriteria), " _
                        & "                        kd_kriteria=VALUES(kd_kriteria), " _
                        & "                        kd_sub=VALUES(kd_sub) "

                    MyCommand = New MySqlCommand(SQL, MyConn)
                    MyCommand.Parameters.Add("@kd_matriks", MySqlDbType.VarString).Value = "M" + KD_ALTERNATIF + ArrKD_KRITERIA(CBKriteria.SelectedIndex)
                    MyCommand.Parameters.Add("@kd_alternatif", MySqlDbType.VarString).Value = KD_ALTERNATIF
                    MyCommand.Parameters.Add("@kd_sub_kriteria", MySqlDbType.VarString).Value = ArrKD_SUB_KRITERIA(CBSubKriteria.SelectedIndex)
                    MyCommand.Parameters.Add("@kd_kriteria", MySqlDbType.VarString).Value = ArrKD_KRITERIA(CBKriteria.SelectedIndex)
                    MyCommand.Parameters.Add("@kd_sub", MySqlDbType.VarString).Value = ArrKD_SUB(CBSubKriteria.SelectedIndex)
                    MyCommand.ExecuteNonQuery()
                    MyConn.Close()
                    MyConn.Open()

                    SQL = "UPDATE tbl_alternatif SET is_aktif='A' WHERE kd_alternatif='" + KD_ALTERNATIF + "'"
                    MyCommand = New MySqlCommand(SQL, MyConn)
                    MyCommand.ExecuteNonQuery()
                    MyConn.Close()
                    MyConn.Open()

                    Call IsiNormalisasi()
                    Call IsiNormalisasiTerbobot()
                    Call IsiJarakSolusi()
                    Call IsiRanking()

                    Call TampilMatriksAnalisa()

                    CBKriteria.SelectedIndex = -1
                    CBSubKriteria.SelectedIndex = -1
                    CBKriteria.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        SQL = "DELETE FROM tbl_matriks_kriteria WHERE kd_alternatif='" & KD_ALTERNATIF & "'"

        If TBNama.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus.", MsgBoxStyle.Exclamation, "Error")
            TBNama.Focus()
        Else
            If MessageBox.Show("Apakah Anda ingin menghapus data '" & TBNama.Text & "' ?", "Konfirmasi", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBNama.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilMatriksAnalisa()

                    TBNama.Clear()

                    SQL = "UPDATE tbl_alternatif SET is_aktif='N' WHERE kd_alternatif='" + KD_ALTERNATIF + "'"
                    MyCommand = New MySqlCommand(SQL, MyConn)
                    MyCommand.ExecuteNonQuery()
                    MyConn.Close()
                    MyConn.Open()

                    BtnHapus.Enabled = False
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                    TBNama.Focus()
                End Try
            End If
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

#End Region

#Region "Normalisasi"
    Private Sub IsiNormalisasi()
        SQL = "INSERT INTO tbl_matriks_kriteria (kd_matriks, " _
            & "                                  n_normalisasi) " _
            & "VALUES (?, ?) " _
            & "ON DUPLICATE KEY UPDATE n_normalisasi=VALUES(n_normalisasi) "

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyCommand.Parameters.Add("@kd_matriks", MySqlDbType.VarString).Value = "M" + KD_ALTERNATIF + ArrKD_KRITERIA(CBKriteria.SelectedIndex)
        MyCommand.Parameters.Add("@n_normalisasi", MySqlDbType.Double).Value = ArrKD_SUB(CBSubKriteria.SelectedIndex) ^ 2
        MyCommand.ExecuteNonQuery()
        MyConn.Close()
        MyConn.Open()
    End Sub
#End Region

#Region "Normalisasi Terbobot"
    Private Sub IsiNormalisasiTerbobot()
        SQL = "SELECT kd_matriks, normalisasi_terbobot FROM v_normalisasi_terbobot ORDER BY kd_matriks"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If MyDataReader.HasRows Then
            Do While MyDataReader.Read
                SQL = "INSERT INTO tbl_matriks_kriteria (kd_matriks, " _
                    & "                                  n_bobot_normalisasi) " _
                    & "VALUES (?, ?) " _
                    & "ON DUPLICATE KEY UPDATE n_bobot_normalisasi=VALUES(n_bobot_normalisasi) "

                RearMyCommand = New MySqlCommand(SQL, RearConn)
                RearMyCommand.Parameters.Add("@kd_matriks", MySqlDbType.VarString).Value = MyDataReader!kd_matriks
                RearMyCommand.Parameters.Add("@n_bobot_normalisasi", MySqlDbType.Double).Value = MyDataReader!normalisasi_terbobot
                RearMyCommand.ExecuteNonQuery()
                RearConn.Close()
                RearConn.Open()
            Loop
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub
#End Region

#Region "Jarak Solusi"
    Private Sub IsiJarakSolusi()
        SQL = "SELECT kd_matriks, jarak_solusi_positif, jarak_solusi_negatif FROM v_jarak_solusi ORDER BY kd_matriks"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If MyDataReader.HasRows Then
            Do While MyDataReader.Read
                SQL = "INSERT INTO tbl_matriks_kriteria (kd_matriks, " _
                    & "                                  jarak_positif, " _
                    & "                                  jarak_negatif) " _
                    & "VALUES (?, ?, ?) " _
                    & "ON DUPLICATE KEY UPDATE jarak_positif=VALUES(jarak_positif), jarak_negatif=VALUES(jarak_negatif) "

                RearMyCommand = New MySqlCommand(SQL, RearConn)
                RearMyCommand.Parameters.Add("@kd_matriks", MySqlDbType.VarString).Value = MyDataReader!kd_matriks
                RearMyCommand.Parameters.Add("@jarak_positif", MySqlDbType.Double).Value = MyDataReader!jarak_solusi_positif
                RearMyCommand.Parameters.Add("@jarak_negatif", MySqlDbType.Double).Value = MyDataReader!jarak_solusi_negatif
                RearMyCommand.ExecuteNonQuery()
                RearConn.Close()
                RearConn.Open()
            Loop
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub
#End Region

#Region "Perankingan"
    Private Sub IsiRanking()
        SQL = "SELECT kd_alternatif, positif, negatif, (CASE WHEN preferensi is NULL THEN 0 ELSE preferensi END) AS preferensi FROM v_preferensi ORDER BY preferensi DESC"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If MyDataReader.HasRows Then
            Dim i = 1
            Do While MyDataReader.Read
                SQL = "INSERT INTO tbl_matriks_preferensi (kd_alternatif, " _
                    & "                                    n_positif, " _
                    & "                                    n_negatif, " _
                    & "                                    preferensi, " _
                    & "                                    rank) " _
                    & "VALUES (?, ?, ?, ?, ?) " _
                    & "ON DUPLICATE KEY UPDATE n_positif=VALUES(n_positif), n_negatif=VALUES(n_negatif), preferensi=VALUES(preferensi), rank=VALUES(rank) "

                RearMyCommand = New MySqlCommand(SQL, RearConn)
                RearMyCommand.Parameters.Add("@kd_alternatif", MySqlDbType.VarString).Value = MyDataReader!kd_alternatif
                RearMyCommand.Parameters.Add("@n_positif", MySqlDbType.Double).Value = MyDataReader!positif
                RearMyCommand.Parameters.Add("@n_negatif", MySqlDbType.Double).Value = MyDataReader!negatif
                RearMyCommand.Parameters.Add("@preferensi", MySqlDbType.Double).Value = MyDataReader!preferensi
                RearMyCommand.Parameters.Add("@rank", MySqlDbType.Int64).Value = i
                RearMyCommand.ExecuteNonQuery()
                RearConn.Close()
                RearConn.Open()
                i += 1
            Loop
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub
#End Region

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then 'Analisa
            Call TampilMatriksAnalisa()
        ElseIf TabControl1.SelectedIndex = 1 Then 'View Normalisasi
            Dim ArrNM_KRITERIA(4) As String
            SQL = "SELECT kd_kriteria, nm_kriteria FROM tbl_kriteria ORDER BY kd_kriteria"

            MyCommand = New MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader
            If MyDataReader.HasRows Then
                Dim i = 0
                Do While MyDataReader.Read
                    ArrNM_KRITERIA(i) = MyDataReader!nm_kriteria
                    i += 1
                Loop
            End If
            MyConn.Close()
            MyConn.Open()

            SQL = "SELECT kd_alternatif AS 'Kode', nm_alternatif AS 'Nama Pemohon', " _
                & "MAX(CASE WHEN kd_kriteria='C1' THEN normalisasi ELSE NULL END) AS '[C1] " & ArrNM_KRITERIA(0) & "', " _
                & "MAX(CASE WHEN kd_kriteria='C2' THEN normalisasi ELSE NULL END) AS '[C2] " & ArrNM_KRITERIA(1) & "', " _
                & "MAX(CASE WHEN kd_kriteria='C3' THEN normalisasi ELSE NULL END) AS '[C3] " & ArrNM_KRITERIA(2) & "', " _
                & "MAX(CASE WHEN kd_kriteria='C4' THEN normalisasi ELSE NULL END) AS '[C4] " & ArrNM_KRITERIA(3) & "' " _
                & "FROM v_normalisasi_terbobot " _
                & "GROUP BY kd_alternatif"

            MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
            DS = New DataSet
            MyDataAdapter.Fill(DS, "v_normalisasi_terbobot")
            DGVNormalisasi.DataSource = DS.Tables("v_normalisasi_terbobot")

            'Properties DGV            
            DGVNormalisasi.ShowEditingIcon = False
            DGVNormalisasi.AllowUserToAddRows = False
            DGVNormalisasi.AllowUserToDeleteRows = False
            DGVNormalisasi.AllowUserToResizeRows = False
            DGVNormalisasi.MultiSelect = False
            DGVNormalisasi.ReadOnly = True
            DGVNormalisasi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVNormalisasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            DGVNormalisasi.EnableHeadersVisualStyles = False
            For i = 0 To DGVNormalisasi.Columns.Count - 1
                DGVNormalisasi.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVNormalisasi.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVNormalisasi.Columns(i).HeaderCell.Style.BackColor = Color.Navy
                DGVNormalisasi.Columns(i).HeaderCell.Style.ForeColor = Color.White
                DGVNormalisasi.Columns(i).HeaderCell.Style.Font = New Font(DGVNormalisasi.Font, FontStyle.Bold)                
            Next
            'End Properties DGV

            MyConn.Close()
            MyConn.Open()
        ElseIf TabControl1.SelectedIndex = 2 Then 'View Normalisasi Terbobot
            Dim ArrNM_KRITERIA(4) As String
            SQL = "SELECT kd_kriteria, nm_kriteria FROM tbl_kriteria ORDER BY kd_kriteria"

            MyCommand = New MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader
            If MyDataReader.HasRows Then
                Dim i = 0
                Do While MyDataReader.Read
                    ArrNM_KRITERIA(i) = MyDataReader!nm_kriteria
                    i += 1
                Loop
            End If
            MyConn.Close()
            MyConn.Open()

            SQL = "SELECT * FROM (SELECT '' AS Kode, 'BOBOT' AS Keterangan, " _
                & "MAX(CASE WHEN kd_kriteria='C1' THEN n_bobot/100 ELSE NULL END) AS '[C1] " & ArrNM_KRITERIA(0) & "', " _
                & "MAX(CASE WHEN kd_kriteria='C2' THEN n_bobot/100 ELSE NULL END) AS '[C2] " & ArrNM_KRITERIA(1) & "', " _
                & "MAX(CASE WHEN kd_kriteria='C3' THEN n_bobot/100 ELSE NULL END) AS '[C3] " & ArrNM_KRITERIA(2) & "', " _
                & "MAX(CASE WHEN kd_kriteria='C4' THEN n_bobot/100 ELSE NULL END) AS '[C4] " & ArrNM_KRITERIA(3) & "' " _
                & "FROM tbl_kriteria " _
                & "UNION ALL " _
                & "SELECT kd_alternatif, nm_alternatif, " _
                & "MAX(CASE WHEN kd_kriteria='C1' THEN normalisasi_terbobot ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C2' THEN normalisasi_terbobot ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C3' THEN normalisasi_terbobot ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C4' THEN normalisasi_terbobot ELSE NULL END) " _
                & "FROM v_normalisasi_terbobot " _
                & "GROUP BY kd_alternatif " _
                & "UNION ALL " _
                & "SELECT '', 'MAX', " _
                & "MAX(CASE WHEN kd_kriteria='C1' THEN max_normal ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C2' THEN max_normal ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C3' THEN max_normal ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C4' THEN max_normal ELSE NULL END) " _
                & "FROM v_max_min_normalisasi " _
                & "UNION ALL " _
                & "SELECT '', 'MIN', " _
                & "MAX(CASE WHEN kd_kriteria='C1' THEN min_normal ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C2' THEN min_normal ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C3' THEN min_normal ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C4' THEN min_normal ELSE NULL END) " _
                & "FROM v_max_min_normalisasi) AS TNT"

            MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
            DS = New DataSet
            MyDataAdapter.Fill(DS, "TNT")
            DGVNormalisasiTerbobot.DataSource = DS.Tables("TNT")

            'Properties DGV            
            DGVNormalisasiTerbobot.ShowEditingIcon = False
            DGVNormalisasiTerbobot.AllowUserToAddRows = False
            DGVNormalisasiTerbobot.AllowUserToDeleteRows = False
            DGVNormalisasiTerbobot.AllowUserToResizeRows = False
            DGVNormalisasiTerbobot.MultiSelect = False
            DGVNormalisasiTerbobot.ReadOnly = True
            DGVNormalisasiTerbobot.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVNormalisasiTerbobot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            DGVNormalisasiTerbobot.EnableHeadersVisualStyles = False
            For i = 0 To DGVNormalisasiTerbobot.Columns.Count - 1
                DGVNormalisasiTerbobot.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVNormalisasiTerbobot.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVNormalisasiTerbobot.Columns(i).HeaderCell.Style.BackColor = Color.Navy
                DGVNormalisasiTerbobot.Columns(i).HeaderCell.Style.ForeColor = Color.White
                DGVNormalisasiTerbobot.Columns(i).HeaderCell.Style.Font = New Font(DGVNormalisasiTerbobot.Font, FontStyle.Bold)
            Next
            'End Properties DGV

            MyConn.Close()
            MyConn.Open()
        ElseIf TabControl1.SelectedIndex = 3 Then 'View Solusi Ideal
            Dim ArrNM_KRITERIA(4) As String
            SQL = "SELECT kd_kriteria, nm_kriteria FROM tbl_kriteria ORDER BY kd_kriteria"

            MyCommand = New MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader
            If MyDataReader.HasRows Then
                Dim i = 0
                Do While MyDataReader.Read
                    ArrNM_KRITERIA(i) = MyDataReader!nm_kriteria
                    i += 1
                Loop
            End If
            MyConn.Close()
            MyConn.Open()

            SQL = "SELECT * FROM (SELECT 'Attribute' AS Keterangan, " _
                & "MAX(CASE WHEN n_atribut='B' THEN 'Benefit' ELSE 'Cost' END) AS '[C1] " & ArrNM_KRITERIA(0) & "', " _
                & "MAX(CASE WHEN n_atribut='B' THEN 'Benefit' ELSE 'Cost' END) AS '[C2] " & ArrNM_KRITERIA(1) & "', " _
                & "MAX(CASE WHEN n_atribut='B' THEN 'Benefit' ELSE 'Cost' END) AS '[C3] " & ArrNM_KRITERIA(2) & "', " _
                & "MAX(CASE WHEN n_atribut='B' THEN 'Benefit' ELSE 'Cost' END) AS '[C4] " & ArrNM_KRITERIA(3) & "' " _
                & "FROM v_matrix_solusi_ideal " _
                & "UNION ALL " _
                & "SELECT 'Positif', " _
                & "MAX(CASE WHEN kd_kriteria='C1' THEN positif ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C2' THEN positif ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C3' THEN positif ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C4' THEN positif ELSE NULL END) " _
                & "FROM v_matrix_solusi_ideal " _
                & "UNION ALL " _
                & "SELECT 'Negatif', " _
                & "MAX(CASE WHEN kd_kriteria='C1' THEN negatif ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C2' THEN negatif ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C3' THEN negatif ELSE NULL END), " _
                & "MAX(CASE WHEN kd_kriteria='C4' THEN negatif ELSE NULL END) " _
                & "FROM v_matrix_solusi_ideal) AS TSI"

            MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
            DS = New DataSet
            MyDataAdapter.Fill(DS, "TSI")
            DGVSolusiIdeal.DataSource = DS.Tables("TSI")

            'Properties DGV            
            DGVSolusiIdeal.ShowEditingIcon = False
            DGVSolusiIdeal.AllowUserToAddRows = False
            DGVSolusiIdeal.AllowUserToDeleteRows = False
            DGVSolusiIdeal.AllowUserToResizeRows = False
            DGVSolusiIdeal.MultiSelect = False
            DGVSolusiIdeal.ReadOnly = True
            DGVSolusiIdeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVSolusiIdeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            DGVSolusiIdeal.EnableHeadersVisualStyles = False
            For i = 0 To DGVSolusiIdeal.Columns.Count - 1
                DGVSolusiIdeal.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVSolusiIdeal.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVSolusiIdeal.Columns(i).HeaderCell.Style.BackColor = Color.Navy
                DGVSolusiIdeal.Columns(i).HeaderCell.Style.ForeColor = Color.White
                DGVSolusiIdeal.Columns(i).HeaderCell.Style.Font = New Font(DGVSolusiIdeal.Font, FontStyle.Bold)
            Next
            'End Properties DGV

            MyConn.Close()
            MyConn.Open()
        ElseIf TabControl1.SelectedIndex = 4 Then 'View Jarak Solusi
            RBPositif.Checked = False
            RBPositif.Checked = True
        ElseIf TabControl1.SelectedIndex = 5 Then 'View Nilai Preferensi
            SQL = "SELECT * FROM (SELECT A.kd_alternatif AS Kode, B.nm_pemohon AS 'Nama Pemohon', " _
                & "A.n_positif AS Positif, A.n_negatif AS Negatif, A.preferensi AS Preferensi, A.rank AS Rank, " _
                & "IF(A.preferensi >= 0.5, 'Layak', 'Tidak Layak') AS Keterangan " _
                & "FROM tbl_matriks_preferensi A LEFT OUTER JOIN tbl_pemohon B ON (A.kd_alternatif=B.kd_pemohon)) AS TRANK " _
                & "ORDER BY Rank"

            MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
            DS = New DataSet
            MyDataAdapter.Fill(DS, "TRANK")
            DGVPreferensi.DataSource = DS.Tables("TRANK")

            'Properties DGV            
            DGVPreferensi.ShowEditingIcon = False
            DGVPreferensi.AllowUserToAddRows = False
            DGVPreferensi.AllowUserToDeleteRows = False
            DGVPreferensi.AllowUserToResizeRows = False
            DGVPreferensi.MultiSelect = False
            DGVPreferensi.ReadOnly = True
            DGVPreferensi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVPreferensi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            DGVPreferensi.EnableHeadersVisualStyles = False
            For i = 0 To DGVPreferensi.Columns.Count - 1
                DGVPreferensi.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVPreferensi.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVPreferensi.Columns(i).HeaderCell.Style.BackColor = Color.Navy
                DGVPreferensi.Columns(i).HeaderCell.Style.ForeColor = Color.White
                DGVPreferensi.Columns(i).HeaderCell.Style.Font = New Font(DGVPreferensi.Font, FontStyle.Bold)
            Next
            'End Properties DGV

            MyConn.Close()
            MyConn.Open()
        End If
    End Sub

    Private Sub RBPositif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPositif.CheckedChanged, RBNegatif.CheckedChanged
        Dim ArrNM_KRITERIA(4) As String
        SQL = "SELECT kd_kriteria, nm_kriteria FROM tbl_kriteria ORDER BY kd_kriteria"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If MyDataReader.HasRows Then
            Dim i = 0
            Do While MyDataReader.Read
                ArrNM_KRITERIA(i) = MyDataReader!nm_kriteria
                i += 1
            Loop
        End If
        MyConn.Close()
        MyConn.Open()

        If RBPositif.Checked Then
            SQL = "SELECT * FROM (SELECT A.kd_alternatif AS 'Kode', A.nm_alternatif AS 'Nama Pemohon', " _
                & "MAX(CASE WHEN A.kd_kriteria='C1' THEN A.jarak_solusi_positif ELSE NULL END) AS '[C1] " & ArrNM_KRITERIA(0) & "', " _
                & "MAX(CASE WHEN A.kd_kriteria='C2' THEN A.jarak_solusi_positif ELSE NULL END) AS '[C2] " & ArrNM_KRITERIA(1) & "', " _
                & "MAX(CASE WHEN A.kd_kriteria='C3' THEN A.jarak_solusi_positif ELSE NULL END) AS '[C3] " & ArrNM_KRITERIA(2) & "', " _
                & "MAX(CASE WHEN A.kd_kriteria='C4' THEN A.jarak_solusi_positif ELSE NULL END) AS '[C4] " & ArrNM_KRITERIA(3) & "', " _
                & "B.positif AS Total " _
                & "FROM v_jarak_solusi A LEFT OUTER JOIN v_preferensi B ON (A.kd_alternatif=B.kd_alternatif) " _
                & "GROUP BY A.kd_alternatif) AS TJS"
        ElseIf RBNegatif.Checked Then
            SQL = "SELECT * FROM (SELECT A.kd_alternatif AS 'Kode', A.nm_alternatif AS 'Nama Pemohon', " _
                & "MAX(CASE WHEN A.kd_kriteria='C1' THEN A.jarak_solusi_negatif ELSE NULL END) AS '[C1] " & ArrNM_KRITERIA(0) & "', " _
                & "MAX(CASE WHEN A.kd_kriteria='C2' THEN A.jarak_solusi_negatif ELSE NULL END) AS '[C2] " & ArrNM_KRITERIA(1) & "', " _
                & "MAX(CASE WHEN A.kd_kriteria='C3' THEN A.jarak_solusi_negatif ELSE NULL END) AS '[C3] " & ArrNM_KRITERIA(2) & "', " _
                & "MAX(CASE WHEN A.kd_kriteria='C4' THEN A.jarak_solusi_negatif ELSE NULL END) AS '[C4] " & ArrNM_KRITERIA(3) & "', " _
                & "B.negatif AS Total " _
                & "FROM v_jarak_solusi A LEFT OUTER JOIN v_preferensi B ON (A.kd_alternatif=B.kd_alternatif) " _
                & "GROUP BY A.kd_alternatif) AS TJS"
        End If


        MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "TJS")
        DGVJarakSolusi.DataSource = DS.Tables("TJS")

        'Properties DGV            
        DGVJarakSolusi.ShowEditingIcon = False
        DGVJarakSolusi.AllowUserToAddRows = False
        DGVJarakSolusi.AllowUserToDeleteRows = False
        DGVJarakSolusi.AllowUserToResizeRows = False
        DGVJarakSolusi.MultiSelect = False
        DGVJarakSolusi.ReadOnly = True
        DGVJarakSolusi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVJarakSolusi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DGVJarakSolusi.EnableHeadersVisualStyles = False
        For i = 0 To DGVJarakSolusi.Columns.Count - 1
            DGVJarakSolusi.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            DGVJarakSolusi.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVJarakSolusi.Columns(i).HeaderCell.Style.BackColor = Color.Navy
            DGVJarakSolusi.Columns(i).HeaderCell.Style.ForeColor = Color.White
            DGVJarakSolusi.Columns(i).HeaderCell.Style.Font = New Font(DGVJarakSolusi.Font, FontStyle.Bold)
        Next
        'End Properties DGV

        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click        
        If f_laporan Is MdiChildren Then
            f_laporan.Close()
        End If

        Dim dt As New DataTable
        With dt
            .Columns.Add("Kode")
            .Columns.Add("Nama Pemohon")
            .Columns.Add("Positif")
            .Columns.Add("Negatif")
            .Columns.Add("Preferensi")
            .Columns.Add("Rank")
        End With
        For Each dgr As DataGridViewRow In Me.DGVPreferensi.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value)
        Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New CRPreferensi
        reportDocument.SetDataSource(dt)
        f_laporan.CRV.ReportSource = reportDocument
        f_laporan.CRV.Refresh()
        f_laporan.ShowDialog()
        f_laporan.Dispose()
    End Sub

    Private Sub DGVAnalisa_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVAnalisa.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            KD_ALTERNATIF = sender.Rows(e.RowIndex).Cells(0).Value
            TBNama.Text = sender.Rows(e.RowIndex).Cells(1).Value
            CBKriteria.Focus()
        End If
    End Sub

    Private Sub f_topsis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown        
        If e.KeyCode = Keys.F3 Then
            If TabControl1.SelectedIndex = 0 Then
                e.SuppressKeyPress = True
                BtnCari_Click(sender, e)
            End If
        End If
    End Sub
End Class