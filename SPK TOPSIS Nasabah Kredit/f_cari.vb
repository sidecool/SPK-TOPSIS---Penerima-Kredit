Imports MySql.Data.MySqlClient
Public Class f_cari
    Private Sub f_cari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQL = "SELECT kd_alternatif, nm_alternatif FROM tbl_alternatif WHERE is_aktif='N' ORDER BY nm_alternatif"

        MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "tbl_alternatif")
        DGVCari.DataSource = DS.Tables("tbl_alternatif")

        DGVCari.Columns(0).HeaderText = "KODE"
        DGVCari.Columns(1).HeaderText = "NAMA NASABAH"
        DGVCari.Columns(0).Visible = False

        'Properties DGView
        DGVCari.ShowEditingIcon = False
        DGVCari.AllowUserToAddRows = False
        DGVCari.AllowUserToDeleteRows = False
        DGVCari.AllowUserToResizeRows = False
        DGVCari.MultiSelect = False
        DGVCari.ReadOnly = True
        DGVCari.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVCari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'End Properties DGV

        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        SQL = "SELECT kd_alternatif, nm_alternatif FROM tbl_alternatif WHERE is_aktif='N' AND nm_alternatif LIKE '%" & TBKey.Text & "%' ORDER BY nm_alternatif"

        MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "tbl_alternatif")
        DGVCari.DataSource = DS.Tables("tbl_alternatif")

        MyConn.Close()
        MyConn.Open()
    End Sub

    Private Sub TBKey_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKey.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnCari_Click(sender, e)
            DGVCari.Focus()
        End If
    End Sub

    Private Sub f_cari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            e.SuppressKeyPress = True
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Public KODE, NAMA As String
    Private Sub DGVCari_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVCari.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            KODE = sender.Rows(e.RowIndex).Cells(0).Value
            NAMA = sender.Rows(e.RowIndex).Cells(1).Value
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub DGVCari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVCari.KeyDown
        If e.KeyValue = Keys.Enter Then
            KODE = DGVCari.CurrentRow.Cells(0).Value
            NAMA = DGVCari.CurrentRow.Cells(1).Value
            Me.Dispose()
            Me.Close()
        End If
    End Sub
End Class