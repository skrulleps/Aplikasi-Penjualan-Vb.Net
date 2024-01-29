Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class FormSupplier
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblSupplier As DataTable

    Sub Data_Record()
        tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier order by kode_supplier asc")
        DGSupplier.DataSource = tblSupplier
        DGSupplier.Columns(1).Width = 150
        DGSupplier.Columns(2).Width = 435
    End Sub

    Sub Kode_Otomatis()
        tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier order by kode_supplier desc")
        If tblSupplier.Rows.Count = 0 Then
            txtkodeSupplier.Text = "KS-001"
        Else
            With tblSupplier.Rows(0)
                txtkodeSupplier.Text = .Item("kode_supplier")
                txtkodeSupplier.Focus()
            End With
            txtkodeSupplier.Text = Val(Microsoft.VisualBasic.Mid(txtkodeSupplier.Text, 4, 3)) + 1
            If Len(txtkodeSupplier.Text) = 1 Then
                txtkodeSupplier.Text = "KS-00" & txtkodeSupplier.Text & ""
            ElseIf Len(txtkodeSupplier.Text) = 2 Then
                txtkodeSupplier.Text = "KS-0" & txtkodeSupplier.Text & ""
            ElseIf Len(txtkodeSupplier.Text) = 3 Then
                txtkodeSupplier.Text = "KS-" & txtkodeSupplier.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtkodeSupplier.Enabled = False
        txtNamaSupplier.Text = ""
        txtalamat.Text = ""
        txtTelepon.Text = ""
        txtKontak.Text = ""
        txtNamaSupplier.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        btnsimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub FormSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub txtCariData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariData.TextChanged
        If rbKodeSupplier.Checked = True Then
            tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier where Kode_Supplier Like '%" & txtCariData.Text & "%'")
            If tblSupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblSupplier
                txtCariData.Focus()
            Else
                DGSupplier.DataSource = tblSupplier
            End If
        ElseIf rbNamaSupplier.Checked = True Then
            tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier where Nama_Supplier Like '%" & txtCariData.Text & "%'")
            If tblSupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblSupplier
                txtCariData.Focus()
            Else
                DGSupplier.DataSource = tblSupplier
            End If
        ElseIf rbCariKontak.Checked = True Then
            tblSupplier = Proses.ExecuteQuery("Select * From TblSupplier where KOntak Like '%" & txtCariData.Text & "%'")
            If tblSupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblSupplier
                txtCariData.Focus()
            Else
                DGSupplier.DataSource = tblSupplier
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtNamaSupplier.Text = "" Then
            txtNamaSupplier.Focus()
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
        If txtKontak.Text = "" Then
            txtKontak.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblSupplier values ('" & txtkodeSupplier.Text & "','" & txtNamaSupplier.Text & "','" & txtalamat.Text & "','" & txtTelepon.Text & "','" &
        txtKontak.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNamaSupplier.Text = "" Then
            txtNamaSupplier.Focus()
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
        If txtKontak.Text = "" Then
            txtKontak.Focus()
            Exit Sub
        End If
        SQL = "Update TblSupplier set Nama_Supplier = '" & txtNamaSupplier.Text & "',Alamat = '" & txtalamat.Text & "',Telepon = '" & txtTelepon.Text & "',Kontak ='" & txtKontak.Text & "' Where Kode_Supplier = '" & txtkodeSupplier.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        SQL = "Delete From TblSupplier Where Kode_Supplier = '" & txtkodeSupplier.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub DGSupplier_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSupplier.CellClick
        Dim i As Integer
        With DGSupplier
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtkodeSupplier.Text = .Rows(i).Cells("Kode_Supplier").Value.ToString
                txtNamaSupplier.Text = .Rows(i).Cells("Nama_Supplier").Value.ToString
                txtalamat.Text = .Rows(i).Cells("Alamat").Value.ToString
                txtTelepon.Text = .Rows(i).Cells("Telepon").Value.ToString
                txtKontak.Text = .Rows(i).Cells("Kontak").Value.ToString
                btnEdit.Enabled = True
                btnHapus.Enabled = True
                btnsimpan.Enabled = False
            End If
        End With
    End Sub

    Private Sub DGSupplier_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSupplier.CellContentClick

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Bersih()
        txtkodeSupplier.Focus()
    End Sub
End Class