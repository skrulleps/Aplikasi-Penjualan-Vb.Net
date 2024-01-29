Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class formBarang
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblBarang As DataTable

    Sub Data_Record()
        tblBarang = Proses.ExecuteQuery("Select * From vw_barang order by kode_barang asc")
        DGBarang.DataSource = tblBarang
        DGBarang.Columns(1).Width = 250
        DGBarang.Columns(2).Width = 200
    End Sub

    Sub Jenis_Barang()
        tblBarang = Proses.ExecuteQuery("Select * From TblJenis_barang order by no asc")
        If tblBarang.Rows.Count = 0 Then
        Else
            cbJenisBarang.Items.Clear()
            With tblBarang.Columns(1)
                For a = 0 To tblBarang.Rows.Count - 1
                    cbJenisBarang.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Satuan()
        tblBarang = Proses.ExecuteQuery("Select * From TblSatuan order by no asc")
        If tblBarang.Rows.Count = 0 Then
        Else
            cbSatuan.Items.Clear()
            With tblBarang.Columns(1)
                For a = 0 To tblBarang.Rows.Count - 1
                    cbSatuan.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Kode_Otomatis()
        tblBarang = Proses.ExecuteQuery("Select * From Tblbarang order by kode_barang desc")
        If tblBarang.Rows.Count = 0 Then
            txtKodeBarang.Text = "KB-001"
        Else
            With tblBarang.Rows(0)
                txtKodeBarang.Text = .Item("kode_barang")
                txtKodeBarang.Focus()
            End With
            txtKodeBarang.Text = Val(Microsoft.VisualBasic.Mid(txtKodeBarang.Text, 4, 3)) + 1
            If Len(txtKodeBarang.Text) = 1 Then
                txtKodeBarang.Text = "KB-00" & txtKodeBarang.Text & ""
            ElseIf Len(txtKodeBarang.Text) = 2 Then
                txtKodeBarang.Text = "KB-0" & txtKodeBarang.Text & ""
            ElseIf Len(txtKodeBarang.Text) = 3 Then
                txtKodeBarang.Text = "KB-" & txtKodeBarang.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtKodeBarang.Enabled = False
        txtNamaBarang.Text = ""
        cbJenisBarang.Text = ""
        cbSatuan.Text = ""
        txthargaBeli.Text = ""
        txtHargaJual.Text = ""
        txtstoklbl.Text = "0"
        txtNamaBarang.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        Call Jenis_Barang()
        Call Satuan()
        btnsimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Private Sub formBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub txthargaBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthargaBeli.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txthargaBeli.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtHargaJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaJual.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txtHargaJual.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtCariData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariData.TextChanged
        If rbKodeBarang.Checked = True Then
            tblBarang = Proses.ExecuteQuery("Select * From vw_barang where Kode_Barang Like '%" & txtCariData.Text & "%'")
            If tblBarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblBarang
                txtCariData.Focus()
            Else
                DGBarang.DataSource = tblBarang
            End If
        ElseIf rbNamaBarang.Checked = True Then
            tblBarang = Proses.ExecuteQuery("Select * From vw_barang where Nama_Barang Like '%" & txtCariData.Text & "%'")
            If tblBarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblBarang
                txtCariData.Focus()
            Else
                DGBarang.DataSource = tblBarang
            End If
        ElseIf rbStok.Checked = True Then
            tblBarang = Proses.ExecuteQuery("Select * From vw_barang where Stock Like '%" & txtCariData.Text & "%'")
            If tblBarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblBarang
                txtCariData.Focus()
            Else
                DGBarang.DataSource = tblBarang
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtNamaBarang.Text = "" Then
            txtNamaBarang.Focus()
            Exit Sub
        End If
        If cbJenisBarang.Text = "" Then
            cbJenisBarang.Focus()
            Exit Sub
        End If
        If cbSatuan.Text = "" Then
            cbSatuan.Focus()
            Exit Sub
        End If
        If txthargaBeli.Text = "" Then
            txthargaBeli.Focus()
            Exit Sub
        End If
        If txtHargaJual.Text = "" Then
            txtHargaJual.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblBarang values ('" & txtKodeBarang.Text & "','" & txtNamaBarang.Text & "','" & Val(cbJenisBarang.Text) & "','" & Val(cbSatuan.Text) & "','" & txthargaBeli.Text & "','" & txtHargaJual.Text & "','" & txtstoklbl.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNamaBarang.Text = "" Then
            txtNamaBarang.Focus()
            Exit Sub
        End If
        If cbJenisBarang.Text = "" Then
            cbJenisBarang.Focus()
            Exit Sub
        End If
        If cbSatuan.Text = "" Then
            cbSatuan.Focus()
            Exit Sub
        End If
        If txthargaBeli.Text = "" Then
            txthargaBeli.Focus()
            Exit Sub
        End If
        If txtHargaJual.Text = "" Then
            txtHargaJual.Focus()
            Exit Sub
        End If
        SQL = "Update TblBarang set nama_barang = '" & txtNamaBarang.Text & "',Jenis = '" & Val(cbJenisBarang.Text) & "',Satuan = '" & Val(cbSatuan.Text) & "',Harga_Beli = '" & txthargaBeli.Text & "',harga_Jual = '" & txtHargaJual.Text & "',Stock = '" & lblStok.Text & "' Where Kode_Barang = '" & txtKodeBarang.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtKodeBarang.Focus()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblBarang Where Kode_Barang = '" & txtKodeBarang.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBarang.CellClick
        Dim i As Integer
        With DGBarang
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodeBarang.Text = .Rows(i).Cells("Kode_Barang").Value.ToString
                txtNamaBarang.Text = .Rows(i).Cells("Nama_Barang").Value.ToString
                cbJenisBarang.Text = .Rows(i).Cells("Jenis").Value.ToString
                txthargaBeli.Text = .Rows(i).Cells("Harga_Beli").Value.ToString
                txtHargaJual.Text = .Rows(i).Cells("Harga_Jual").Value.ToString
                txtstoklbl.Text = .Rows(i).Cells("Stock").Value.ToString
                btnEdit.Enabled = True
                btnHapus.Enabled = True
                btnsimpan.Enabled = False
            End If
        End With
    End Sub
End Class