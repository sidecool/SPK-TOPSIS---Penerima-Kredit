Public Class f_sub_kriteria

    Private Sub TampilKriteria()
        SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM TBL_KRITERIA ORDER BY KD_KRITERIA"

        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader()

        If MyDataReader.HasRows = 0 Then
            MsgBox("Data Kriteria tidak ditemukan, silahkan isi terlebih dahulu", MsgBoxStyle.Exclamation, "Error Data")
            f_kriteria.ShowDialog()
        End If

        Do While MyDataReader.Read
            CBKriteria.Items.Add(New With {.Text = MyDataReader!NM_KRITERIA, .Value = MyDataReader!KD_KRITERIA})
        Loop
        CBKriteria.DisplayMember = "Text"
        CBKriteria.ValueMember = "Value"        

        MyConn.Close()
        MyConn.Open()
        CBKriteria.SelectedIndex = 0
    End Sub

    Private Sub f_sub_kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        TampilKriteria()

        BtnHapus.Enabled = False
    End Sub

    Private Sub TampilData(ByVal kd_kriteria As String)
        SQL = "SELECT * FROM (SELECT A.KD_SUB_KRITERIA, B.NM_KRITERIA, A.KETERANGAN, A.KD_SUB " _
            & "FROM TBL_SUB_KRITERIA A JOIN TBL_KRITERIA B ON A.KD_KRITERIA=B.KD_KRITERIA " _
            & "WHERE A.KD_KRITERIA='" & kd_kriteria & "' ORDER BY KD_SUB_KRITERIA) AS TABEL"

        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "TABEL")
        DGView.DataSource = DS.Tables("TABEL")

        DGView.Columns(0).HeaderText = "KODE"
        DGView.Columns(1).HeaderText = "NAMA KRITERIA"
        DGView.Columns(2).HeaderText = "NAMA SUB KRITERIA"
        DGView.Columns(3).HeaderText = ""
        DGView.Columns(3).Visible = False

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

    Private Sub CBKriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBKriteria.SelectedIndexChanged
        TampilData(CBKriteria.SelectedItem.Value)
    End Sub

    Private Sub TBKode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKode.KeyDown, TBNama.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is CBKriteria Then
                TBKode.Focus()
            ElseIf sender Is TBKode Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        SQL = "INSERT INTO TBL_SUB_KRITERIA VALUES ('" & CBKriteria.SelectedItem.Value & "." & TBKode.Text & "'," _
            & "'" & CBKriteria.SelectedItem.Value & "','" & TBKode.Text & "','" & TBNama.Text & "')" _
            & "ON DUPLICATE KEY UPDATE KETERANGAN='" & TBNama.Text & "'"

        ErrorProvider1.Clear()
        If TBKode.Text = "" Then
            ErrorProvider1.SetError(TBKode, "Kode tidak boleh kosong.")
            TBKode.Focus()
        ElseIf TBNama.Text = "" Then
            ErrorProvider1.SetError(TBNama, "Kriteria tidak boleh kosong.")
            TBNama.Focus()
        Else
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

            Try
                MyCommand.ExecuteNonQuery()
                MsgBox("Data '" & TBKode.Text & "' berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")                
                TampilData(CBKriteria.SelectedItem.Value)

                TBKode.Clear()
                TBNama.Clear()                
                CBKriteria.Focus()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
            End Try
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        SQL = "DELETE FROM TBL_SUB_KRITERIA WHERE KD_SUB_KRITERIA='" & CBKriteria.SelectedItem.Value & "." & TBKode.Text & "'"

        If TBKode.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus.", MsgBoxStyle.Exclamation, "Error")
            TBKode.Focus()
        Else
            If MessageBox.Show("Apakah Anda ingin menghapus data '" & CBKriteria.SelectedItem.Value & "." & TBKode.Text & "' ?", "Konfirmasi", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBKode.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilData(CBKriteria.SelectedItem.Value)

                    TBKode.Clear()
                    TBNama.Clear()
                    CBKriteria.Focus()

                    BtnHapus.Enabled = False
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                    TBKode.Focus()
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

    Private Sub TBKode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBKode.Leave
        SQL = "SELECT * FROM TBL_SUB_KRITERIA WHERE KD_KRITERIA='" & CBKriteria.SelectedItem.Value & "' AND KD_SUB='" & TBKode.Text & "'"

        If TBKode.Text <> "" Then
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                TBNama.Clear()
                
                BtnHapus.Enabled = False
            Else
                MyDataReader.Read()
                TBNama.Text = MyDataReader!KETERANGAN

                BtnHapus.Enabled = True
            End If
        Else
            TBNama.Clear()            
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub DGView_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGView.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells(1).Value) Then
                TBKode.Text = sender.Rows(e.RowIndex).Cells(3).Value
                TBKode_Leave(sender, e)
                TBNama.Focus()
            End If
        End If
    End Sub

End Class