Public Class FrmUbahPassword
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblUbahPwd As DataTable

    Sub bersih()
        txtPwLama.Text = ""
        txtPwBaru.Text = ""
        txtPwLama.Focus()
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        If txtPwLama.Text = "" Then
            txtPwLama.Focus()
            Exit Sub
        End If
        If txtPwBaru.Text = "" Then
            txtPwBaru.Focus()
            Exit Sub
        End If
        tblUbahPwd = Proses.ExecuteQuery("Select * From TblPengguna Where password = '" & txtPwLama.Text & "'")
        If tblUbahPwd.Rows.Count = 0 Then
            MessageBox.Show("Perubahan password tidak berhasil...!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPwLama.SelectedText = txtPwLama.Text
            txtPwLama.Focus()
        Else
            SQL = "Update TblPengguna Set password = '" & txtPwBaru.Text & "' where kode_pengguna = '" & FrmMenuUtama.tsPengguna.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Password telah diubah..!!", "Perubahan Password Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call bersih()
            Me.Close()
        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class