Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class FrmMenuUtama
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblHakAkses As DataTable

    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level ='" & TsLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            PenggunaToolStripMenuItem.Enabled = False
            HakAksesToolStripMenuItem.Enabled = False
            JenisBarangToolStripMenuItem.Enabled = False
            SatuanToolStripMenuItem.Enabled = False
            BarangToolStripMenuItem.Enabled = False
            SupplierToolStripMenuItem.Enabled = False
            PelangganToolStripMenuItem.Enabled = False
            PembelianToolStripMenuItem.Enabled = False
            PenjualanToolStripMenuItem.Enabled = False
            SupplierToolStripMenuItem1.Enabled = False
            PelangganToolStripMenuItem1.Enabled = False
            BarangToolStripMenuItem1.Enabled = False
            PembelianToolStripMenuItem1.Enabled = False
            PenjualanToolStripMenuItem1.Enabled = False
            ToolStripButton1.Enabled = False
            ToolStripButton3.Enabled = False
            ToolStripButton4.Enabled = False
            ToolStripButton5.Enabled = False
            ToolStripButton6.Enabled = False
            ToolStripButton7.Enabled = False
            With tblHakAkses.Rows(0)
                PenggunaToolStripMenuItem.Enabled = .Item("pengguna")
                ToolStripButton1.Enabled = .Item("pengguna")
                HakAksesToolStripMenuItem.Enabled = .Item("hakakses")
                JenisBarangToolStripMenuItem.Enabled = .Item("jenis_barang")
                SatuanToolStripMenuItem.Enabled = .Item("satuan")
                BarangToolStripMenuItem.Enabled = .Item("barang")
                ToolStripButton3.Enabled = .Item("barang")
                SupplierToolStripMenuItem.Enabled = .Item("supplier")
                ToolStripButton4.Enabled = .Item("supplier")
                PelangganToolStripMenuItem.Enabled = .Item("pelanggan")
                ToolStripButton5.Enabled = .Item("pelanggan")
                PembelianToolStripMenuItem.Enabled = .Item("pembelian")
                ToolStripButton6.Enabled = .Item("pembelian")
                PenjualanToolStripMenuItem.Enabled = .Item("penjualan")
                ToolStripButton7.Enabled = .Item("penjualan")
                SupplierToolStripMenuItem1.Enabled = .Item("lprsupplier")
                PelangganToolStripMenuItem1.Enabled = .Item("lprpelanggan")
                BarangToolStripMenuItem1.Enabled = .Item("lprbarang")
                PembelianToolStripMenuItem1.Enabled = .Item("lprpembelian")
                PenjualanToolStripMenuItem1.Enabled = .Item("lprpenjualan")
            End With
        End If
    End Sub


    Private Sub JenisBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisBarangToolStripMenuItem.Click
        frmJenisBarang.Show()
        frmJenisBarang.MdiParent = Me

    End Sub

    Private Sub SatuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SatuanToolStripMenuItem.Click
        formsatuan.Show()
        formsatuan.MdiParent = Me
    End Sub

    Private Sub FrmMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmLogin.Show()
        Call Hak_Akses()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        formBarang.Show()
        formBarang.MdiParent = Me
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        FormPelanggan.Show()
        formBarang.MdiParent = Me
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        FormSupplier.Show()
        FormSupplier.MdiParent = Me
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        frmPembelian.Show()
        frmPembelian.MdiParent = Me
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FrmPenjualan.Show()
        FrmPenjualan.MdiParent = Me
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem1.Click
        FrmLprSupplier.Show()
        FrmLprSupplier.MdiParent = Me
    End Sub

    Private Sub PelangganToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem1.Click
        FrmLprPelanggan.Show()
        FrmLprPelanggan.MdiParent = Me
    End Sub

    Private Sub BarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem1.Click
        FrmLprBarang.Show()
        FrmLprBarang.MdiParent = Me
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        FrmUbahPassword.MdiParent = Me
        FrmUbahPassword.Show()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HakAksesToolStripMenuItem.Click
        FrmHakAkses.Show()
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggunaToolStripMenuItem.Click
        FrmPengguna.Show()
    End Sub
End Class
