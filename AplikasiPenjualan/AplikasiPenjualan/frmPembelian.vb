Public Class frmPembelian
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblBeli As DataTable

    Sub Data_Record()
        tblBeli = Proses.ExecuteQuery("Select tblPembelian_Rinci.No, tblPembelian_Rinci.Kode_Barang,tblBarang.Nama_Barang, tblPembelian_Rinci.Harga_Beli,tblPembelian_Rinci.Jumlah, tblPembelian_Rinci.Sub_Total From tblPembelian_Rinci Inner Join tblBarang on tblPembelian_Rinci.Kode_Barang = tblBarang.Kode_Barang Where tblPembelian_Rinci.Faktur_Pembelian = '" & txtFakturPembelian.Text & "' order by tblPembelian_Rinci.no asc")
        DGPembelian.DataSource = tblBeli
        DGPembelian.Columns(0).Width = 50
        DGPembelian.Columns(1).Width = 98
        DGPembelian.Columns(2).Width = 150
        DGPembelian.Columns(4).Width = 50
    End Sub

    Sub Supplier()
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier order by Kode_Supplier asc")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbSupplier.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbSupplier.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Barang()
        tblBeli = Proses.ExecuteQuery("Select * From TblBarang order by Kode_Barang asc")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbBarang.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbBarang.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Faktur_Otomatis()
        tblBeli = Proses.ExecuteQuery("Select * From TblPembelian order by Faktur_Pembelian desc")
        If tblBeli.Rows.Count = 0 Then
            txtFakturPembelian.Text = "0001"
        Else
            With tblBeli.Rows(0)
                txtFakturPembelian.Text = .Item("Faktur_Pembelian")
            End With
            txtFakturPembelian.Text = Val(txtFakturPembelian.Text) + 1
            If Len(txtFakturPembelian.Text) = 1 Then
                txtFakturPembelian.Text = "000" & txtFakturPembelian.Text & ""
            ElseIf Len(txtFakturPembelian.Text) = 2 Then
                txtFakturPembelian.Text = "00" & txtFakturPembelian.Text & ""
            ElseIf Len(txtFakturPembelian.Text) = 3 Then
                txtFakturPembelian.Text = "0" & txtFakturPembelian.Text & ""
            ElseIf Len(txtFakturPembelian.Text) = 4 Then
                txtFakturPembelian.Text = "" & txtFakturPembelian.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        cmbBarang.Text = ""
        txtNamaBarang.Text = ""
        txtHarga.Text = ""
        txtStok.Text = ""
        txtJumlah.Text = ""
        txtDisc.Text = ""
        txtHargaBersih.Text = ""
        cmbSupplier.Enabled = True
        cmbBarang.Enabled = True
        cmbBarang.Focus()
        Call Supplier()
        Call Barang()
        Call Faktur_Otomatis()
        Call Data_Record()
        On Error Resume Next
        Dim Total_Seluruh As Single
        Dim i As Integer
        If DGPembelian.RowCount > 1 Then
            i = DGPembelian.CurrentRow.Index
            For i = 0 To DGPembelian.Rows.Count - 1
                Total_Seluruh = Val(Total_Seluruh) + Val(DGPembelian.Item(5, i).Value)
            Next
            txtHargaKotor.Text = Total_Seluruh.ToString("#,#")
        End If
    End Sub

    Private Sub frmPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()
        btnsimpan.Enabled = False
    End Sub

    Private Sub cmbSupplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSupplier.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbSupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplier.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier where Kode_Supplier ='" & Mid(cmbSupplier.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            txtNmSupplier.Text = tblBeli.Rows(0).Item("Nama_Supplier")
        End If
    End Sub

    Private Sub cmbBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBarang.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cmbBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBarang.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblBarang where Kode_Barang ='" & Mid(cmbBarang.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            txtNamaBarang.Text = tblBeli.Rows(0).Item("Nama_Barang")
            txtHarga.Text = tblBeli.Rows(0).Item("Harga_Beli")
            txtStok.Text = tblBeli.Rows(0).Item("Stock")
            txtJumlah.Focus()
        End If
    End Sub

    Private Sub txtNamaBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaBarang.Click

    End Sub

    Private Sub txtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txtJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tblBeli = Proses.ExecuteQuery("Select * From TblPembelian_Rinci where Faktur_Pembelian ='" & txtFakturPembelian.Text & "' and Kode_Barang ='" & Mid(cmbBarang.Text, 1, 6) & "'")
                If tblBeli.Rows.Count = 0 Then
                    Dim Total = Val(txtHarga.Text) * Val(txtJumlah.Text)
                    SQL = "Insert Into TblPembelian_Rinci values ('" & txtFakturPembelian.Text & "','" & DGPembelian.RowCount & "','" & Mid(cmbBarang.Text, 1, 6) & "','" & Val(txtHarga.Text) & "','" & txtJumlah.Text & "','" & Total & "')"
                    Proses.ExecuteNonQuery(SQL)
                    btnsimpan.Enabled = True
                Else
                    MsgBox("Proses pembelian tidak dapat dilakukan !")
                End If
                Call Bersih()
                Dim Total_Seluruh As Single
                Dim i As Integer
                i = DGPembelian.CurrentRow.Index
                For i = 0 To DGPembelian.Rows.Count - 1
                    Total_Seluruh = Val(Total_Seluruh) + Val(DGPembelian.Item(5, i).Value)
                Next
                txtHargaKotor.Text = Total_Seluruh.ToString("#,#")
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtDisc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisc.TextChanged
        If txtDisc.Text = "" Then
            txtDisc.Text = "0"
        End If
        Dim Disc As Single
        Disc = (Val(Replace(txtHargaKotor.Text, ".", "") * txtDisc.Text)) / 100
        txtHargaBersih.Text = (Val(Replace(txtHargaKotor.Text, ".", "") - Val(Disc))).ToString("#,#")
    End Sub

    Private Sub txtHargaBersih_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHargaBersih.TextChanged
        If txtHargaBersih.Text = "" Then
            txtHargaBersih.Text = "0"
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtHargaKotor.Text = "" Then
            Exit Sub
        End If
        If txtDisc.Text = "" Then
            txtDisc.Text = "0"
        End If
        SQL = "Insert Into TblPembelian values ('" & txtFakturPembelian.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Microsoft.VisualBasic.Left(cmbSupplier.Text, 6) & "','" & txtDisc.Text & "','" & Val(Replace(txtHargaBersih.Text, ",", "")) & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
        cmbSupplier.Text = ""
        txtNmSupplier.Text = ""
        txtHargaKotor.Text = ""
        cmbSupplier.Focus()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            tblBeli = Proses.ExecuteQuery("Select * From TblBarang where Kode_Barang ='" & DGPembelian.Item(2, i).Value & "'")
            If tblBeli.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblBeli.Rows(0).Item("Stock")) - Val(DGPembelian.Item(4, i).Value)
                SQL = "Update TblBarang set Stock ='" & CInt(Jumlah) & "' where Kode_Barang ='" & DGPembelian.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next
        SQL = "Delete From TblPembelian_Rinci where Faktur_Pembelian ='" & txtFakturPembelian.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        txtHargaKotor.Text = "Rp,"
        Call Bersih()
Keluar:
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim No = InputBox("Masukkan no faktur")
        If No = "" Then
            Exit Sub
        Else
            FrmFakturPembelian.CrystalReportViewer1.SelectionFormula = "{vw_pembelian.faktur_pembelian} Like '" + No + "'"
            FrmFakturPembelian.CrystalReportViewer1.RefreshReport()
            FrmFakturPembelian.Show()
        End If
    End Sub

    Private Sub cmbBarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBarang.SelectedIndexChanged

    End Sub
End Class