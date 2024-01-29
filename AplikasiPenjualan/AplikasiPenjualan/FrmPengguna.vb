

Public Class FrmPengguna
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblPengguna As DataTable

    Sub Data_Record()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna")
        DGPengguna.DataSource = tblPengguna
        DGPengguna.Columns(1).Width = 200
        DGPengguna.Columns(2).Visible = False
    End Sub

    Sub Kode_Otomatis()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna order by kode_pengguna desc")
        If tblPengguna.Rows.Count = 0 Then
            txtKdPengguna.Text = "PGN-001"
        Else
            With tblPengguna.Rows(0)
                txtKdPengguna.Text = .Item("Kode_Pengguna")
                txtKdPengguna.Focus()
            End With
            txtKdPengguna.Text = Val(Microsoft.VisualBasic.Mid(txtKdPengguna.Text, 5, 3)) + 1
            If Len(txtKdPengguna.Text) = 1 Then
                txtKdPengguna.Text = "PGN-00" & txtKdPengguna.Text & ""
            ElseIf Len(txtKdPengguna.Text) = 2 Then
                txtKdPengguna.Text = "PGN-0" & txtKdPengguna.Text & ""
            ElseIf Len(txtKdPengguna.Text) = 3 Then
                txtKdPengguna.Text = "PGN-" & txtKdPengguna.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtKdPengguna.Enabled = True
        txtKdPengguna.Text = ""
        txtNmPengguna.Text = ""
        txtPwd.Text = ""
        txtUlangPwd.Text = ""
        cblevel.Text = ""
        Call Kode_Otomatis()
        Call Data_Record()
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnBatal.Enabled = False
        btnTutup.Enabled = True
        txtKdPengguna.Enabled = False
        txtPwd.Enabled = True
        txtUlangPwd.Enabled = True
        txtPwd.Text = ""
    End Sub

    Private Sub FrmPengguna_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Data_Record()
    End Sub
    Private Sub FrmPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = 0
        Top = 0
        Call Bersih()
        cblevel.Items.Add("ADMIN")
        cblevel.Items.Add("OPERATOR")
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtNmPengguna.Text = "" Then
            txtNmPengguna.Focus()
            Exit Sub
        End If
        If txtPwd.Text = "" Then
            txtPwd.Focus()
            Exit Sub
        End If
        If txtUlangPwd.Text = "" Then
            txtUlangPwd.Focus()
            Exit Sub
        End If
        If cblevel.Text = "" Then
            cblevel.Focus()
            Exit Sub
        End If
        If txtPwd.Text <> txtUlangPwd.Text Then
            MsgBox("Ulangi, password keliru!!!", MsgBoxStyle.Critical, "Password")
            txtUlangPwd.Focus()
            Exit Sub
        Else
            SQL = "Insert Into TblPengguna values ('" & txtKdPengguna.Text & "','" & txtNmPengguna.Text & "','" & txtPwd.Text & "','" & cblevel.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Bersih()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNmPengguna.Text = "" Then
            txtNmPengguna.Focus()
            Exit Sub
        End If
        If cblevel.Text = "" Then
            cblevel.Focus()
            Exit Sub
        Else
            SQL = "Update TblPengguna Set Nama_pengguna = '" & txtNmPengguna.Text & "',Level =  '" & cblevel.Text & "' Where Kode_Pengguna = '" & txtKdPengguna.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Bersih()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtKdPengguna.Focus()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblPengguna Where Kode_Pengguna = '" & txtKdPengguna.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtKdPengguna.Text = InputBox("Masukkan kode pengguna !!!")
        If txtKdPengguna.Text = "" Then
            Call Kode_Otomatis()
            txtNmPengguna.Focus()
            Exit Sub
        End If

        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna Where Kode_Pengguna = '" & txtKdPengguna.Text & "'")
        If tblPengguna.Rows.Count = 0 Then
            MessageBox.Show("Data Pengguna Tidak Ditemukan..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNmPengguna.Focus()
            Call Kode_Otomatis()
        Else
            With tblPengguna.Rows(0)
                txtKdPengguna.Text = .Item("Kode_Pengguna")
                txtNmPengguna.Text = .Item("Nama_Pengguna")
                txtPwd.Text = .Item("Password")
                txtPwd.Enabled = False
                txtUlangPwd.Enabled = False
                cblevel.Text = .Item("Level")
            End With
            btnsimpan.Enabled = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
            btnBatal.Enabled = True
        End If
    End Sub

    Private Sub DGPengguna_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPengguna.CellClick
        Dim i As Integer

        With DGPengguna
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index

                txtKdPengguna.Text = .Rows(i).Cells("Kode_pengguna").Value.ToString
                txtNmPengguna.Text = .Rows(i).Cells("Nama_pengguna").Value.ToString

                btnEdit.Enabled = True
                btnHapus.Enabled = True
                btnBatal.Enabled = True
                btnsimpan.Enabled = False
            End If
        End With
    End Sub

    Private Sub DGPengguna_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPengguna.CellContentClick
        btnHapus.Enabled = True
        btnEdit.Enabled = True

        Dim value As Object = DGPengguna.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If IsDBNull(value) Then
            Call Kode_Otomatis()
            txtNmPengguna.Focus()
        Else
            txtKdPengguna.Text = CType(value, String)
        End If
    End Sub
End Class