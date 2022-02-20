Public Class f_login

    Private Sub TBUsername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBUsername.KeyDown, TBPassword.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBUsername Then
                TBPassword.Focus()
            ElseIf sender Is TBPassword Then
                BtnLogin_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub CBTampil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTampil.CheckedChanged
        If CBTampil.Checked Then
            TBPassword.UseSystemPasswordChar = False
        Else
            TBPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If TBUsername.Text = "" Then
            MsgBox("Username tidak boleh kosong. Silahkan diisi terlebih dahulu", MsgBoxStyle.Exclamation, "Error")
            TBUsername.Focus()
        ElseIf TBPassword.Text = "" Then
            MsgBox("Password tidak boleh kosong. Silahkan diisi terlebih dahulu", MsgBoxStyle.Exclamation, "Error")
            TBPassword.Focus()
        Else
            Try
                SQL = "SELECT * FROM TBL_USER " _
                    & "WHERE USERNAME='" & TBUsername.Text & "' " _
                    & "AND PASSWORD='" & TBPassword.Text & "' "

                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
                MyDataReader = MyCommand.ExecuteReader()

                If MyDataReader.HasRows = 0 Then
                    MsgBox("Login gagal, silahkan ulangi lagi dengan benar.", MsgBoxStyle.Exclamation, "Error Login")
                    TBUsername.Clear()
                    TBPassword.Clear()
                    TBUsername.Focus()
                Else
                    MyDataReader.Read()
                    MsgBox("Selamat Datang " & MyDataReader!NM_USER, MsgBoxStyle.Information, "Login Berhasil")
                    USERLOGIN = MyDataReader!USERNAME
                    f_menu.ToolStripStatusLabel3.Text = "Login as : " & MyDataReader!NM_USER
                    f_menu.ToolStripStatusLabel3.Visible = True
                    If MyDataReader!LEVEL = 0 Then 'Admin
                        f_menu.MenuStrip1.Visible = True
                    ElseIf MyDataReader!LEVEL = 1 Then 'Kepala
                        f_menu.MenuStrip1.Visible = True
                        f_menu.MasterDataToolStripMenuItem.Visible = False
                        f_menu.AnalisisKeputusanToolStripMenuItem.Visible = False
                    End If
                    Me.Dispose()
                    Me.Close()
                End If
                MyConn.Close()
                MyConn.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Login")
            End Try
        End If
    End Sub

    Private Sub f_login_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            End
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub f_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim sc As String
        'sc = (System.Threading.Thread.CurrentThread.CurrentCulture.ToString)
        'If sc <> "id-ID" Then
        'If MessageBox.Show("Settingan Region dan Language Anda bukan Indonesia. " + vbLf + vbLf + _
        '                   "Apakah Anda akan tetap menggunakan Settingan Region dan Language " + _
        '                   System.Globalization.CultureInfo.CurrentCulture.DisplayName + " ? " + vbLf + _
        '                   "[Yes] Melanjutkan" + vbLf + _
        '                   "[No] Mengubah Settingan Regional Language", _
        '                   "Konfigurasi Regional dan Language", _
        '                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        'System.Diagnostics.Process.Start("intl.cpl")
        'End If
        'End If
    End Sub
End Class