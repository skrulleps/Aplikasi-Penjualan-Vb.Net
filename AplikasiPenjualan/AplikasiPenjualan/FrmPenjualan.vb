Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class FrmPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblJual As DataTable

    Sub Data_Record()
        tblJual = Proses.ExecuteQuery("Select tblPenjualan_Rinci.No, tblPenjualan_Rinci.Kode_Barang,tblBarang.Nama_Barang, tblPenjualan_Rinci.Harga_Jual,tblPenjualan_Rinci.Jumlah, tblPenjualan_Rinci.Sub_Total From tblPenjualan_Rinci Inner Join tblBarang on tblPenjualan_Rinci.Kode_Barang = tblBarang.Kode_Barang Where tblPenjualan_Rinci.Faktur_Penjualan = '" & lbltxtFaktur.Text & "' order by tblPenjualan_Rinci.no asc")
        DGPenjualan.DataSource = tblJual
        DGPenjualan.Columns(0).Width = 50
        DGPenjualan.Columns(1).Width = 98
        DGPenjualan.Columns(2).Width = 150
        DGPenjualan.Columns(4).Width = 50
    End Sub

    Sub Pelanggan()
        tblJual = Proses.ExecuteQuery("Select * From TblPelanggan order by Kode_Pelanggan asc")
        If tblJual.Rows.Count = 0 Then
        Else
            cbPelanggan.Items.Clear()
            With tblJual.Columns(1)
                For a = 0 To tblJual.Rows.Count - 1
                    cbPelanggan.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Barang()
        tblJual = Proses.ExecuteQuery("Select * From TblBarang order by Kode_Barang asc")
        If tblJual.Rows.Count = 0 Then
        Else
            cbBarang.Items.Clear()
            With tblJual.Columns(1)
                For a = 0 To tblJual.Rows.Count - 1
                    cbBarang.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Faktur_Otomatis()
        tblJual = Proses.ExecuteQuery("Select * From TblPenjualan order by Faktur_Penjualan desc")
        If tblJual.Rows.Count = 0 Then
            lbltxtFaktur.Text = "0001"
        Else
            With tblJual.Rows(0)
                lbltxtFaktur.Text = .Item("Faktur_Penjualan")
            End With
            lbltxtFaktur.Text = Val(lbltxtFaktur.Text) + 1
            If Len(lbltxtFaktur.Text) = 1 Then
                lbltxtFaktur.Text = "000" & lbltxtFaktur.Text & ""
            ElseIf Len(lbltxtFaktur.Text) = 2 Then
                lbltxtFaktur.Text = "00" & lbltxtFaktur.Text & ""
            ElseIf Len(lbltxtFaktur.Text) = 3 Then
                lbltxtFaktur.Text = "0" & lbltxtFaktur.Text & ""
            ElseIf Len(lbltxtFaktur.Text) = 4 Then
                lbltxtFaktur.Text = "" & lbltxtFaktur.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        cbBarang.Text = ""
        lbltxtnmBarang.Text = ""
        lbltxtHarga.Text = ""
        lbltxtStok.Text = ""
        txtJumlah.Text = ""
        txtDiscount.Text = ""
        lbltxtHrgBersih.Text = ""
        lblHrgTotal.Text = ""
        cbPelanggan.Enabled = True
        cbBarang.Enabled = True
        cbBarang.Focus()
        Call Pelanggan()
        Call Barang()
        Call Faktur_Otomatis()
        Call Data_Record()
        On Error Resume Next
        Dim Total_Seluruh As Single
        Dim i As Integer
        If DGPenjualan.RowCount > 1 Then
            i = DGPenjualan.CurrentRow.Index
            For i = 0 To DGPenjualan.Rows.Count - 1
                Total_Seluruh = Val(Total_Seluruh) + Val(DGPenjualan.Item(5, i).Value)
            Next
            lbltxtHrgKotor.Text = Total_Seluruh.ToString("#,#")
            lblHrgTotal.Text = lbltxtHrgKotor.Text
        End If
    End Sub

    Private Sub FrmPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()
        btnsimpan.Enabled = True
    End Sub

    Private Sub cbPelanggan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbPelanggan.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cbPelanggan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPelanggan.SelectedIndexChanged
        tblJual = Proses.ExecuteQuery("Select * From TblPelanggan where Kode_Pelanggan ='" & Mid(cbPelanggan.Text, 1, 6) & "'")
        If tblJual.Rows.Count = 0 Then
        Else
            lbltxtnmPelanggan.Text = tblJual.Rows(0).Item("Nama_Pelanggan")
        End If
    End Sub

    Private Sub cbBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbBarang.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cbBarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBarang.SelectedIndexChanged
        tblJual = Proses.ExecuteQuery("Select * From TblBarang where Kode_Barang ='" & Mid(cbBarang.Text, 1, 6) & "'")
        If tblJual.Rows.Count = 0 Then
        Else
            lblnmPelanggan.Text = tblJual.Rows(0).Item("Nama_Barang")
            lbltxtHarga.Text = tblJual.Rows(0).Item("Harga_Jual")
            lbltxtStok.Text = tblJual.Rows(0).Item("Stock")
            txtJumlah.Focus()
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txtJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tblJual = Proses.ExecuteQuery("Select * From TblPenjualan_Rinci where Faktur_Penjualan ='" & lbltxtFaktur.Text & "' and Kode_Barang ='" & Mid(cbBarang.Text, 1, 6) & "'")
                If tblJual.Rows.Count = 0 Then
                    Dim Total = Val(lbltxtHarga.Text) * Val(txtJumlah.Text)
                    SQL = "Insert Into TblPenjualan_Rinci values ('" & lbltxtFaktur.Text & "','" & DGPenjualan.RowCount & "','" & Mid(cbBarang.Text, 1, 6) & "','" & Val(lbltxtHarga.Text) & "','" & txtJumlah.Text & "','" & Total & "')"
                    Proses.ExecuteNonQuery(SQL)
                    btnsimpan.Enabled = True
                Else
                    MsgBox("Proses Penjualan tidak dapat dilakukan !")
                End If
                Call Bersih()
                Dim Total_Seluruh As Single
                Dim i As Integer
                i = DGPenjualan.CurrentRow.Index
                For i = 0 To DGPenjualan.Rows.Count - 1
                    Total_Seluruh = Val(Total_Seluruh) + Val(DGPenjualan.Item(5, i).Value)
                Next
                lbltxtHrgKotor.Text = Total_Seluruh.ToString("#,#")
                lblHrgTotal.Text = lbltxtHrgKotor.Text
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtJumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlah.TextChanged

    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If txtDiscount.Text = "" Then
            txtDiscount.Text = "0"
        End If
        Dim Disc As Single
        Disc = (Val(Replace(lbltxtHrgKotor.Text, ".", "") * txtDiscount.Text)) / 100
        lbltxtHrgBersih.Text = (Val(Replace(lbltxtHrgKotor.Text, ".", "") - Val(Disc))).ToString("#,#")
    End Sub

    Private Sub lbltxtHrgBersih_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbltxtHrgBersih.TextChanged
        If lbltxtHrgBersih.Text = "" Then
            lbltxtHrgBersih.Text = "0"
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If lbltxtHrgKotor.Text = "" Then
            Exit Sub
        End If
        If txtDiscount.Text = "" Then
            txtDiscount.Text = "0"
        End If
        SQL = "Insert Into TblPenjualan values ('" & lbltxtFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Microsoft.VisualBasic.Left(cbPelanggan.Text, 6) & "','" & txtDiscount.Text & "','" & Val(Replace(lbltxtHrgBersih.Text, ".", "")) & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
        cbPelanggan.Text = ""
        lblnmPelanggan.Text = ""
        lbltxtHrgKotor.Text = ""
        cbPelanggan.Focus()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPenjualan.CurrentRow.Index
        For i = 0 To DGPenjualan.Rows.Count - 1
            tblJual = Proses.ExecuteQuery("Select * From TblBarang where Kode_Barang ='" & DGPenjualan.Item(2, i).Value & "'")
            If tblJual.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblJual.Rows(0).Item("Stock")) - Val(DGPenjualan.Item(4, i).Value)
                SQL = "Update TblBarang set Stock ='" & CInt(Jumlah) & "' where Kode_Barang ='" & DGPenjualan.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next
        SQL = "Delete From TblPenjualan_Rinci where Faktur_Penjualan ='" & lbltxtFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        lbltxtHrgKotor.Text = "Rp,"
        Call Bersih()
Keluar:
    End Sub

    Private Sub lbltxtnmPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltxtnmPelanggan.Click

    End Sub

    Private Sub lbltxtFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltxtFaktur.Click

    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim No = InputBox("Masukkan no faktur")
        If No = "" Then
            Exit Sub
        Else
            FrmFakturPenjualan.CrystalReportViewer1.SelectionFormula = "{vw_penjualan.faktur_penjualan} Like '" + No + "'"
            FrmFakturPenjualan.CrystalReportViewer1.RefreshReport()
            FrmFakturPenjualan.Show()
        End If
    End Sub
End Class