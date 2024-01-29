<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBarang))
        Me.lblKodeBarang = New System.Windows.Forms.Label()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.lblJenisBarang = New System.Windows.Forms.Label()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.lblhargaBeli = New System.Windows.Forms.Label()
        Me.lblHargaJual = New System.Windows.Forms.Label()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.txtstoklbl = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.cbJenisBarang = New System.Windows.Forms.ComboBox()
        Me.cbSatuan = New System.Windows.Forms.ComboBox()
        Me.txthargaBeli = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.rbStok = New System.Windows.Forms.RadioButton()
        Me.rbNamaBarang = New System.Windows.Forms.RadioButton()
        Me.rbKodeBarang = New System.Windows.Forms.RadioButton()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKodeBarang
        '
        Me.lblKodeBarang.AutoSize = True
        Me.lblKodeBarang.Location = New System.Drawing.Point(37, 32)
        Me.lblKodeBarang.Name = "lblKodeBarang"
        Me.lblKodeBarang.Size = New System.Drawing.Size(102, 20)
        Me.lblKodeBarang.TabIndex = 0
        Me.lblKodeBarang.Text = "Kode Barang"
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.AutoSize = True
        Me.lblNamaBarang.Location = New System.Drawing.Point(37, 62)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(107, 20)
        Me.lblNamaBarang.TabIndex = 1
        Me.lblNamaBarang.Text = "Nama Barang"
        '
        'lblJenisBarang
        '
        Me.lblJenisBarang.AutoSize = True
        Me.lblJenisBarang.Location = New System.Drawing.Point(37, 95)
        Me.lblJenisBarang.Name = "lblJenisBarang"
        Me.lblJenisBarang.Size = New System.Drawing.Size(102, 20)
        Me.lblJenisBarang.TabIndex = 2
        Me.lblJenisBarang.Text = "Jenis Barang"
        '
        'lblSatuan
        '
        Me.lblSatuan.AutoSize = True
        Me.lblSatuan.Location = New System.Drawing.Point(37, 129)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(61, 20)
        Me.lblSatuan.TabIndex = 3
        Me.lblSatuan.Text = "Satuan"
        '
        'lblhargaBeli
        '
        Me.lblhargaBeli.AutoSize = True
        Me.lblhargaBeli.Location = New System.Drawing.Point(372, 38)
        Me.lblhargaBeli.Name = "lblhargaBeli"
        Me.lblhargaBeli.Size = New System.Drawing.Size(83, 20)
        Me.lblhargaBeli.TabIndex = 4
        Me.lblhargaBeli.Text = "Harga Beli"
        '
        'lblHargaJual
        '
        Me.lblHargaJual.AutoSize = True
        Me.lblHargaJual.Location = New System.Drawing.Point(372, 70)
        Me.lblHargaJual.Name = "lblHargaJual"
        Me.lblHargaJual.Size = New System.Drawing.Size(86, 20)
        Me.lblHargaJual.TabIndex = 5
        Me.lblHargaJual.Text = "Harga Jual"
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.Location = New System.Drawing.Point(372, 103)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(42, 20)
        Me.lblStok.TabIndex = 6
        Me.lblStok.Text = "Stok"
        '
        'txtstoklbl
        '
        Me.txtstoklbl.AutoSize = True
        Me.txtstoklbl.BackColor = System.Drawing.Color.White
        Me.txtstoklbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtstoklbl.Location = New System.Drawing.Point(480, 101)
        Me.txtstoklbl.Name = "txtstoklbl"
        Me.txtstoklbl.Size = New System.Drawing.Size(20, 22)
        Me.txtstoklbl.TabIndex = 7
        Me.txtstoklbl.Text = "0"
        Me.txtstoklbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(155, 29)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(100, 26)
        Me.txtKodeBarang.TabIndex = 8
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(155, 62)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(100, 26)
        Me.txtNamaBarang.TabIndex = 9
        '
        'cbJenisBarang
        '
        Me.cbJenisBarang.FormattingEnabled = True
        Me.cbJenisBarang.Location = New System.Drawing.Point(155, 95)
        Me.cbJenisBarang.Name = "cbJenisBarang"
        Me.cbJenisBarang.Size = New System.Drawing.Size(121, 28)
        Me.cbJenisBarang.TabIndex = 10
        '
        'cbSatuan
        '
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Location = New System.Drawing.Point(155, 129)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.Size = New System.Drawing.Size(121, 28)
        Me.cbSatuan.TabIndex = 11
        '
        'txthargaBeli
        '
        Me.txthargaBeli.Location = New System.Drawing.Point(480, 32)
        Me.txthargaBeli.Name = "txthargaBeli"
        Me.txthargaBeli.Size = New System.Drawing.Size(100, 26)
        Me.txthargaBeli.TabIndex = 12
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(480, 64)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(100, 26)
        Me.txtHargaJual.TabIndex = 13
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsimpan.Location = New System.Drawing.Point(422, 156)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 66)
        Me.btnsimpan.TabIndex = 14
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(505, 156)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 66)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(586, 156)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 66)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(667, 156)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 66)
        Me.btnBatal.TabIndex = 17
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTutup.Location = New System.Drawing.Point(748, 156)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 66)
        Me.btnTutup.TabIndex = 18
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariData)
        Me.GroupBox1.Controls.Add(Me.rbStok)
        Me.GroupBox1.Controls.Add(Me.rbNamaBarang)
        Me.GroupBox1.Controls.Add(Me.rbKodeBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 61)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'txtCariData
        '
        Me.txtCariData.Location = New System.Drawing.Point(403, 23)
        Me.txtCariData.Name = "txtCariData"
        Me.txtCariData.Size = New System.Drawing.Size(345, 26)
        Me.txtCariData.TabIndex = 20
        '
        'rbStok
        '
        Me.rbStok.AutoSize = True
        Me.rbStok.Location = New System.Drawing.Point(304, 25)
        Me.rbStok.Name = "rbStok"
        Me.rbStok.Size = New System.Drawing.Size(67, 24)
        Me.rbStok.TabIndex = 2
        Me.rbStok.TabStop = True
        Me.rbStok.Text = "Stok"
        Me.rbStok.UseVisualStyleBackColor = True
        '
        'rbNamaBarang
        '
        Me.rbNamaBarang.AutoSize = True
        Me.rbNamaBarang.Location = New System.Drawing.Point(152, 25)
        Me.rbNamaBarang.Name = "rbNamaBarang"
        Me.rbNamaBarang.Size = New System.Drawing.Size(132, 24)
        Me.rbNamaBarang.TabIndex = 1
        Me.rbNamaBarang.TabStop = True
        Me.rbNamaBarang.Text = "Nama Barang"
        Me.rbNamaBarang.UseVisualStyleBackColor = True
        '
        'rbKodeBarang
        '
        Me.rbKodeBarang.AutoSize = True
        Me.rbKodeBarang.Location = New System.Drawing.Point(6, 25)
        Me.rbKodeBarang.Name = "rbKodeBarang"
        Me.rbKodeBarang.Size = New System.Drawing.Size(127, 24)
        Me.rbKodeBarang.TabIndex = 0
        Me.rbKodeBarang.TabStop = True
        Me.rbKodeBarang.Text = "Kode Barang"
        Me.rbKodeBarang.UseVisualStyleBackColor = True
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(15, 309)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.RowTemplate.Height = 28
        Me.DGBarang.Size = New System.Drawing.Size(891, 312)
        Me.DGBarang.TabIndex = 20
        '
        'formBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 633)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.txthargaBeli)
        Me.Controls.Add(Me.cbSatuan)
        Me.Controls.Add(Me.cbJenisBarang)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.txtstoklbl)
        Me.Controls.Add(Me.lblStok)
        Me.Controls.Add(Me.lblHargaJual)
        Me.Controls.Add(Me.lblhargaBeli)
        Me.Controls.Add(Me.lblSatuan)
        Me.Controls.Add(Me.lblJenisBarang)
        Me.Controls.Add(Me.lblNamaBarang)
        Me.Controls.Add(Me.lblKodeBarang)
        Me.Name = "formBarang"
        Me.Text = "Data Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKodeBarang As System.Windows.Forms.Label
    Friend WithEvents lblNamaBarang As System.Windows.Forms.Label
    Friend WithEvents lblJenisBarang As System.Windows.Forms.Label
    Friend WithEvents lblSatuan As System.Windows.Forms.Label
    Friend WithEvents lblhargaBeli As System.Windows.Forms.Label
    Friend WithEvents lblHargaJual As System.Windows.Forms.Label
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents txtstoklbl As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents cbJenisBarang As System.Windows.Forms.ComboBox
    Friend WithEvents cbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents txthargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCariData As System.Windows.Forms.TextBox
    Friend WithEvents rbStok As System.Windows.Forms.RadioButton
    Friend WithEvents rbNamaBarang As System.Windows.Forms.RadioButton
    Friend WithEvents rbKodeBarang As System.Windows.Forms.RadioButton
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
End Class
