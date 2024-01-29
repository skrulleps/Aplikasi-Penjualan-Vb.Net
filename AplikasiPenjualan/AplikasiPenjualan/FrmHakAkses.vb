Public Class FrmHakAkses
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblHakAkses As DataTable

    Sub kosong()
        chkPengguna.Checked = False
        chkJenis.Checked = False
        chkSatuan.Checked = False
        chkBarang.Checked = False
        chkSupplier.Checked = False
        chkPelanggan.Checked = False
        chkPembelian.Checked = False
        chkPenjualan.Checked = False
        chkLprSupplier.Checked = False
        chkLprPelanggan.Checked = False
        chkLprBarang.Checked = False
        chkLprPembelian.Checked = False
        chkLprPenjualan.Checked = False
        chkHakAkses.Checked = False
    End Sub

    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level ='" & cbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            Call kosong()
        Else
            With tblHakAkses.Rows(0)
                chkPengguna.Checked = .Item("pengguna")
                chkJenis.Checked = .Item("jenis_barang")
                chkSatuan.Checked = .Item("satuan")
                chkBarang.Checked = .Item("barang")
                chkSupplier.Checked = .Item("supplier")
                chkPelanggan.Checked = .Item("pelanggan")
                chkPembelian.Checked = .Item("pembelian")
                chkPenjualan.Checked = .Item("penjualan")
                chkLprSupplier.Checked = .Item("lprsupplier")
                chkLprPelanggan.Checked = .Item("lprpelanggan")
                chkLprBarang.Checked = .Item("lprbarang")
                chkLprPembelian.Checked = .Item("lprpembelian")
                chkLprPenjualan.Checked = .Item("lprpenjualan")
                chkHakAkses.Checked = .Item("hakakses")
            End With
        End If
    End Sub

    Private Sub FrmHakAkses_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Hak_Akses()
    End Sub

    Private Sub FrmHakAkses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbLevel.Items.Add("ADMIN")
        cbLevel.Items.Add("OPERATOR")
    End Sub

    Private Sub cbLevel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLevel.TextChanged
        Call Hak_Akses()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cbLevel.Text = "" Then Exit Sub

        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level ='" & cbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            SQL = "Insert Into Tblhakakses Values ('" & cbLevel.Text & "','" &
            CInt(chkPengguna.Checked) * -1 & "','" & CInt(chkJenis.Checked) * -1 & "','" &
            CInt(chkSatuan.Checked) * -1 & "','" & CInt(chkBarang.Checked) * -1 & "','" &
            CInt(chkSupplier.Checked) * -1 & "','" & CInt(chkPelanggan.Checked) * -1 & "','" &
            CInt(chkPembelian.Checked) * -1 & "','" & CInt(chkPenjualan.Checked) * -1 & "','" &
            CInt(chkLprSupplier.Checked) * -1 & "','" & CInt(chkLprPelanggan.Checked) * -1 & "','" &
            CInt(chkLprBarang.Checked) * -1 & "','" & CInt(chkLprPembelian.Checked) * -1 & "','" &
            CInt(chkLprPenjualan.Checked) * -1 & "','" & CInt(chkHakAkses.Checked) * -1 & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SQL = "Update Tblhakakses Set Pengguna = '" & CInt(chkPengguna.Checked) * -1 & "',jenis_barang = '" &
            CInt(chkJenis.Checked) * -1 & "',satuan = '" & CInt(chkSatuan.Checked) * -1 & "', barang = '" &
            CInt(chkBarang.Checked) * -1 & "',supplier= '" & CInt(chkSupplier.Checked) * -1 & "',pelanggan = '" &
            CInt(chkPelanggan.Checked) * -1 & "',pembelian = '" & CInt(chkPembelian.Checked) * -1 & "',penjualan = '" &
            CInt(chkPenjualan.Checked) * -1 & "',LprSupplier ='" & CInt(chkLprSupplier.Checked) * -1 & "',LprPelanggan = '" &
            CInt(chkLprPelanggan.Checked) * -1 & "',LprBarang = '" & CInt(chkLprBarang.Checked) * -1 & "',LprPembelian = '" &
            CInt(chkLprPembelian.Checked) * -1 & "',LprPenjualan = '" & CInt(chkLprPenjualan.Checked) * -1 &
            "',HakAkses = '" & CInt(chkHakAkses.Checked) * -1 & "' where Level = '" & cbLevel.Text & "' "
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class