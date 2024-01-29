Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class frmJenisBarang
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblJnsBarang As DataTable

    Sub Data_Record()
        tblJnsBarang = Proses.ExecuteQuery("Select * From TblJenis_Barang order by no asc")
        dgJenisBarang.DataSource = tblJnsBarang
        dgJenisBarang.Columns(1).Width = 130
    End Sub

    Sub Kode_Otomatis()
        tblJnsBarang = Proses.ExecuteQuery("Select * From TblJenis_Barang order by no desc")
        If tblJnsBarang.Rows.Count = 0 Then
            txtkodejenis.Text = "1"
        Else
            With tblJnsBarang.Rows(0)
                txtkodejenis.Text = .Item("No")
            End With
            txtkodejenis.Text = Val(txtkodejenis.Text) + 1
        End If
    End Sub

    Sub Bersih()
        Call Kode_Otomatis()
        Call Data_Record()
        btnsimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        txtkodejenis.Enabled = False
        txtjenisbarang.Text = ""
        txtjenisbarang.Focus()
    End Sub

    Private Sub frmJenisBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtjenisbarang.Text = "" Then
            txtjenisbarang.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblJenis_Barang values ('" & txtkodejenis.Text & "','" & txtjenisbarang.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        If txtjenisbarang.Text = "" Then
            txtjenisbarang.Focus()
            Exit Sub
        End If
        SQL = "Update TblJenis_Barang set Jenis = '" & txtjenisbarang.Text & "' Where No = '" & txtkodejenis.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        SQL = "Delete from TblJenis_Barang Where No = '" & txtkodejenis.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil dihapus..!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub dgJenisBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJenisBarang.CellClick
        Dim i As Integer
        With dgJenisBarang
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtkodejenis.Text = .Rows(i).Cells("No").Value.ToString
                txtjenisbarang.Text = .Rows(i).Cells("Jenis").Value.ToString
                btnUbah.Enabled = True
                btnHapus.Enabled = True
                btnsimpan.Enabled = False
            End If
        End With
    End Sub

    Private Sub dgJenisBarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJenisBarang.CellContentClick

    End Sub
End Class