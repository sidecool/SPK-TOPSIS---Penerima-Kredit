Public Class f_ganti_paswd

    Private Sub f_ganti_paswd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TBLama.Focus()
    End Sub

    Private Sub CBTampil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTampil.CheckedChanged
        If CBTampil.Checked Then
            TBLama.UseSystemPasswordChar = False
            TBBaru.UseSystemPasswordChar = False
            TBKonfirmasi.UseSystemPasswordChar = False
        Else
            TBLama.UseSystemPasswordChar = True
            TBBaru.UseSystemPasswordChar = True
            TBKonfirmasi.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TBLama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBLama.KeyDown, TBBaru.KeyDown, TBKonfirmasi.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBLama Then
                TBBaru.Focus()
            ElseIf sender Is TBBaru Then
                TBKonfirmasi.Focus()
            ElseIf sender Is TBKonfirmasi Then
                BtnGanti_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnGanti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGanti.Click
        ErrorProvider1.Clear()
        If TBLama.Text = "" Then
            ErrorProvider1.SetError(TBLama, "Password Lama tidak boleh kosong.")
            TBLama.Focus()
        ElseIf TBBaru.Text = "" Then
            ErrorProvider1.SetError(TBBaru, "Password Baru tidak boleh kosong.")
            TBBaru.Focus()
        ElseIf TBKonfirmasi.Text <> TBBaru.Text Then
            ErrorProvider1.SetError(TBKonfirmasi, "Konfirmasi Password tidak sama dengan Password Baru, silahkan diisi dengan benar.")
            TBKonfirmasi.Clear()
            TBKonfirmasi.Focus()
        Else
            MyConn.Close()
            SQL = "SELECT PASSWORD FROM TBL_USER WHERE USERNAME='" & USERLOGIN & "'"            
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows Then
                MyDataReader.Read()

                If TBLama.Text = MyDataReader!PASSWORD Then
                    MyConn.Close()
                    SQL = "UPDATE TBL_USER SET PASSWORD='" & TBKonfirmasi.Text & "' WHERE USERNAME='" & USERLOGIN & "'"
                    MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
                    MyConn.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MsgBox("Password berhasil diperbaharui.", MsgBoxStyle.Information, "Berhasil")
                        TBLama.Clear()
                        TBBaru.Clear()
                        TBKonfirmasi.Clear()
                        TBLama.Focus()
                        f_menu.LogoutClick(sender, e)
                    Catch ex As MySql.Data.MySqlClient.MySqlException
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                    End Try
                Else
                    ErrorProvider1.SetError(TBLama, "Password Lama tidak sesuai, silahkan diisi dengan benar." _
                                           & vbLf & "Perhatikan besar dan kecil huruf")
                    TBLama.Focus()
                End If
            End If
        End If
    End Sub
End Class