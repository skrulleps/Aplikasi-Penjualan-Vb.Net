Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class formsatuan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblSatuan As DataTable

    Sub Data_Record()
        tblSatuan = Proses.ExecuteQuery("Select * From TblSatuan order by no asc")
        DGSatuan.DataSource = tblSatuan
        DGSatuan.Columns(1).Width = 130
    End Sub

    Sub Kode_Otomatis()
        tblSatuan = Proses.ExecuteQuery("Select * From TblSatuan order by No desc")
        If tblSatuan.Rows.Count = 0 Then
            txtkodesatuan.Text = "1"
        Else
            With tblSatuan.Rows(0)
                txtkodesatuan.Text = .Item("No")
            End With
            txtkodesatuan.Text = Val(txtkodesatuan.Text) + 1
        End If
    End Sub

    Sub Bersih()
        Call Kode_Otomatis()
        Call Data_Record()
        btnsimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        txtkodesatuan.Enabled = False
        txtsatuan.Text = ""
        txtsatuan.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSatuan.CellContentClick
        Dim i As Integer
        With DGSatuan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtkodesatuan.Text = .Rows(i).Cells("No").Value.ToString
                txtsatuan.Text = .Rows(i).Cells("Satuan").Value.ToString
                btnEdit.Enabled = True
                btnHapus.Enabled = True
                btnsimpan.Enabled = False
            End If
        End With
    End Sub

    Private Sub formsatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtsatuan.Text = "" Then
            txtsatuan.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblSatuan values ('" & txtkodesatuan.Text & "','" & txtsatuan.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtsatuan.Text = "" Then
            txtsatuan.Focus()
            Exit Sub
        End If
        SQL = "Update TblSatuan set Satuan = '" & txtsatuan.Text & "' Where No = '" & txtkodesatuan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        SQL = "Delete from TblSatuan Where No = '" & txtkodesatuan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil dihapus..!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
End Class