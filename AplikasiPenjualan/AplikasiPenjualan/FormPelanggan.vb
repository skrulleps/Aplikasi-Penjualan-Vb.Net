Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class FormPelanggan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblPelanggan As DataTable

    Sub Data_Record()
        tblPelanggan = Proses.ExecuteQuery("Select * From TblPelanggan order by kode_pelanggan asc")
        DGPelanggan.DataSource = tblPelanggan
        DGPelanggan.Columns(1).Width = 150
        DGPelanggan.Columns(2).Width = 435
    End Sub

    Sub Kode_Otomatis()
        tblPelanggan = Proses.ExecuteQuery("Select * From TblPelanggan order by kode_pelanggan desc")
        If tblPelanggan.Rows.Count = 0 Then
            txtkodePelanggan.Text = "KP-001"
        Else
            With tblPelanggan.Rows(0)
                txtkodePelanggan.Text = .Item("kode_pelanggan")
                txtkodePelanggan.Focus()
            End With
            txtkodePelanggan.Text = Val(Microsoft.VisualBasic.Mid(txtkodePelanggan.Text, 4, 3)) + 1
            If Len(txtkodePelanggan.Text) = 1 Then
                txtkodePelanggan.Text = "KP-00" & txtkodePelanggan.Text & ""
            ElseIf Len(txtkodePelanggan.Text) = 2 Then
                txtkodePelanggan.Text = "KP-0" & txtkodePelanggan.Text & ""
            ElseIf Len(txtkodePelanggan.Text) = 3 Then
                txtkodePelanggan.Text = "KP-" & txtkodePelanggan.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtkodePelanggan.Enabled = False
        txtNamaPelanggan.Text = ""
        txtalamat.Text = ""
        txtTelepon.Text = ""
        txtNamaPelanggan.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        btnsimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Private Sub FormPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub txtCariData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariData.TextChanged
        If rbKodePelanggan.Checked = True Then
            tblPelanggan = Proses.ExecuteQuery("Select * From TblPelanggan where Kode_Pelanggan Like '%" & txtCariData.Text & "%'")
            If tblPelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblPelanggan
                txtCariData.Focus()
            Else
                DGPelanggan.DataSource = tblPelanggan
            End If
        ElseIf rbNamaPelanggan.Checked = True Then
            tblPelanggan = Proses.ExecuteQuery("Select * From TblPelanggan where Nama_Pelanggan Like '%" & txtCariData.Text & "%'")
            If tblPelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblPelanggan
                txtCariData.Focus()
            Else
                DGPelanggan.DataSource = tblPelanggan
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtNamaPelanggan.Text = "" Then
            txtNamaPelanggan.Focus()
            Exit Sub
        End If
        If txtalamat.Text = "" Then
            txtalamat.Focus()
            Exit Sub
        End If
        If txtTelepon.Text = "" Then
            txtTelepon.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblPelanggan values ('" & txtkodePelanggan.Text & "','" & txtNamaPelanggan.Text & "','" & txtalamat.Text & "','" & txtTelepon.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNamaPelanggan.Text = "" Then
            txtNamaPelanggan.Focus()
            Exit Sub
        End If
        If txtalamat.Text = "" Then
            txtalamat.Focus()
            Exit Sub
        End If
        If txtTelepon.Text = "" Then
            txtTelepon.Focus()
            Exit Sub
        End If
        SQL = "Update TblPelanggan set Nama_Pelanggan = '" & txtNamaPelanggan.Text & "',Alamat = '" & txtalamat.Text & "',Telepon = '" & txtTelepon.Text & "' Where Kode_Pelanggan = '" & txtkodePelanggan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtkodePelanggan.Focus()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblPelanggan Where Kode_Pelanggan = '" & txtkodePelanggan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGPelanggan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPelanggan.CellContentClick
        Dim i As Integer
        With DGPelanggan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtkodePelanggan.Text = .Rows(i).Cells("Kode_Pelanggan").Value.ToString
                txtNamaPelanggan.Text = .Rows(i).Cells("Nama_Pelanggan").Value.ToString
                txtalamat.Text = .Rows(i).Cells("Alamat").Value.ToString
                txtTelepon.Text = .Rows(i).Cells("Telepon").Value.ToString
                btnEdit.Enabled = True
                btnHapus.Enabled = True
                btnsimpan.Enabled = False
            End If
        End With
    End Sub
End Class