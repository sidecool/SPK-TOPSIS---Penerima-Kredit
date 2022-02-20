Public Class f_kriteria

    Private Sub TampilData()
        SQL = "SELECT * FROM TBL_KRITERIA ORDER BY KD_KRITERIA"

        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "TBL_KRITERIA")
        DGView.DataSource = DS.Tables("TBL_KRITERIA")

        DGView.Columns(0).HeaderText = "KODE"
        DGView.Columns(1).HeaderText = "NAMA KRITERIA"
        DGView.Columns(2).HeaderText = "BOBOT"
        DGView.Columns(3).HeaderText = "ATRIBUT"

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

    Private Sub f_kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilData()

        BtnHapus.Enabled = False
    End Sub

    Private Sub TBKode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKode.KeyDown, TBNama.KeyDown, TBBobot.KeyDown, RBAtributBenefit.KeyDown, RBAtributCost.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBKode Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                TBBobot.Focus()
            ElseIf sender Is TBBobot Then
                RBAtributBenefit.Focus()
            ElseIf sender Is RBAtributBenefit Then
                BtnSimpan_Click(sender, e)
            ElseIf sender Is RBAtributCost Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim Atribut As String = ""

        If RBAtributBenefit.Checked Then
            Atribut = "B"
        ElseIf RBAtributCost.Checked Then
            Atribut = "C"
        End If

        SQL = "INSERT INTO TBL_KRITERIA VALUES ('" & TBKode.Text & "','" & TBNama.Text & "'," & TBBobot.Text & ",'" & Atribut & "') " _
            & "ON DUPLICATE KEY UPDATE NM_KRITERIA='" & TBNama.Text & "', N_BOBOT=" & TBBobot.Text & ", N_ATRIBUT='" & Atribut & "'"        

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
                TampilData()

                TBKode.Clear()
                TBNama.Clear()
                TBBobot.Clear()
                RBAtributBenefit.Checked = False
                RBAtributCost.Checked = False
                TBKode.Focus()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
            End Try
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        SQL = "DELETE FROM TBL_KRITERIA WHERE KD_KRITERIA='" & TBKode.Text & "'"

        If TBKode.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus.", MsgBoxStyle.Exclamation, "Error")
            TBKode.Focus()
        Else
            If MessageBox.Show("Apakah Anda ingin menghapus data '" & TBKode.Text & "' ?", "Konfirmasi", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBKode.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilData()

                    TBKode.Clear()
                    TBNama.Clear()
                    TBBobot.Clear()
                    RBAtributBenefit.Checked = False
                    RBAtributCost.Checked = False
                    TBKode.Focus()

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
        SQL = "SELECT * FROM TBL_KRITERIA WHERE KD_KRITERIA='" & TBKode.Text & "'"

        If TBKode.Text <> "" Then
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                TBNama.Clear()
                TBBobot.Clear()
                RBAtributBenefit.Checked = False
                RBAtributCost.Checked = False

                BtnHapus.Enabled = False
            Else
                MyDataReader.Read()                
                TBNama.Text = MyDataReader!NM_KRITERIA
                TBBobot.Text = MyDataReader!N_BOBOT
                If MyDataReader!N_ATRIBUT = "B" Then
                    RBAtributBenefit.Checked = True
                ElseIf MyDataReader!N_ATRIBUT = "C" Then
                    RBAtributCost.Checked = True
                End If
                BtnHapus.Enabled = True
            End If
        Else
            TBNama.Clear()
            TBBobot.Clear()
            RBAtributBenefit.Checked = False
            RBAtributCost.Checked = False
        End If
        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub DGView_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGView.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells(1).Value) Then
                TBKode.Text = sender.Rows(e.RowIndex).Cells(0).Value
                TBKode_Leave(sender, e)
                TBNama.Focus()
            End If
        End If
    End Sub
End Class