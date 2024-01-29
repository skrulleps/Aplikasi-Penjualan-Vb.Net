Public Class FrmLogin
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblLogin As DataTable

    Sub Bersih()
        txtKdPengguna.Text = ""
        txtPwd.Text = ""
        txtKdPengguna.Focus()
    End Sub

    Sub Login()
        If txtKdPengguna.Text = "" Then
            txtKdPengguna.Focus()
            Exit Sub
        End If
        If txtPwd.Text = "" Then
            txtPwd.Focus()
            Exit Sub
        End If
        tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where kode_pengguna = '" & txtKdPengguna.Text & "' and password ='" & txtPwd.Text & "'")
        If tblLogin.Rows.Count = 0 Then
            MessageBox.Show("Login tidak berhasil..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKdPengguna.Focus()
        Else
            FrmMenuUtama.tsPengguna.Text = txtKdPengguna.Text
            FrmMenuUtama.TsLevel.Text = txtLevel.Text
            Me.Hide()
            FrmMenuUtama.Show()
        End If
    End Sub
    
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Call Login()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        End
    End Sub

    Private Sub txtPwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPwd.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    Private Sub txtPwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub txtKdPengguna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdPengguna.KeyPress
        If e.KeyChar = Chr(13) Then
            tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where kode_pengguna = '" & txtKdPengguna.Text & "'")
            If tblLogin.Rows.Count = 0 Then
                MessageBox.Show("Kode tidak ditemukan..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtKdPengguna.Focus()
            Else
                txtLevel.Text = tblLogin.Rows(0).Item("level")
                txtPwd.Focus()
            End If
        End If
    End Sub

    Private Sub txtKdPengguna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdPengguna.TextChanged

    End Sub
End Class