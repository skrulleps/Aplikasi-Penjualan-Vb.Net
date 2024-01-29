<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPembelian))
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblNamaSupplier = New System.Windows.Forms.Label()
        Me.lblBarang = New System.Windows.Forms.Label()
        Me.txtNmSupplier = New System.Windows.Forms.Label()
        Me.lblFakturPembelian = New System.Windows.Forms.Label()
        Me.lblHargaKotor = New System.Windows.Forms.Label()
        Me.lblDisc = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGPembelian = New System.Windows.Forms.DataGridView()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbBarang = New System.Windows.Forms.ComboBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.txtFakturPembelian = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.Label()
        Me.txtHargaKotor = New System.Windows.Forms.Label()
        Me.txtHargaBersih = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(26, 29)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(67, 20)
        Me.lblSupplier.TabIndex = 0
        Me.lblSupplier.Text = "Supplier"
        '
        'lblNamaSupplier
        '
        Me.lblNamaSupplier.AutoSize = True
        Me.lblNamaSupplier.Location = New System.Drawing.Point(25, 63)
        Me.lblNamaSupplier.Name = "lblNamaSupplier"
        Me.lblNamaSupplier.Size = New System.Drawing.Size(113, 20)
        Me.lblNamaSupplier.TabIndex = 1
        Me.lblNamaSupplier.Text = "Nama Supplier"
        '
        'lblBarang
        '
        Me.lblBarang.AutoSize = True
        Me.lblBarang.Location = New System.Drawing.Point(25, 97)
        Me.lblBarang.Name = "lblBarang"
        Me.lblBarang.Size = New System.Drawing.Size(61, 20)
        Me.lblBarang.TabIndex = 2
        Me.lblBarang.Text = "Barang"
        '
        'txtNmSupplier
        '
        Me.txtNmSupplier.AutoSize = True
        Me.txtNmSupplier.BackColor = System.Drawing.Color.White
        Me.txtNmSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNmSupplier.Location = New System.Drawing.Point(162, 62)
        Me.txtNmSupplier.Name = "txtNmSupplier"
        Me.txtNmSupplier.Size = New System.Drawing.Size(59, 22)
        Me.txtNmSupplier.TabIndex = 3
        Me.txtNmSupplier.Text = "            "
        '
        'lblFakturPembelian
        '
        Me.lblFakturPembelian.AutoSize = True
        Me.lblFakturPembelian.Location = New System.Drawing.Point(653, 31)
        Me.lblFakturPembelian.Name = "lblFakturPembelian"
        Me.lblFakturPembelian.Size = New System.Drawing.Size(133, 20)
        Me.lblFakturPembelian.TabIndex = 4
        Me.lblFakturPembelian.Text = "Faktur Pembelian"
        '
        'lblHargaKotor
        '
        Me.lblHargaKotor.AutoSize = True
        Me.lblHargaKotor.Location = New System.Drawing.Point(683, 471)
        Me.lblHargaKotor.Name = "lblHargaKotor"
        Me.lblHargaKotor.Size = New System.Drawing.Size(107, 20)
        Me.lblHargaKotor.TabIndex = 9
        Me.lblHargaKotor.Text = "Harga Kotor  :"
        Me.lblHargaKotor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDisc
        '
        Me.lblDisc.AutoSize = True
        Me.lblDisc.Location = New System.Drawing.Point(683, 508)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(108, 20)
        Me.lblDisc.TabIndex = 10
        Me.lblDisc.Text = "DISC              :"
        Me.lblDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(683, 543)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Harga Bersih :"
        '
        'DGPembelian
        '
        Me.DGPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPembelian.Location = New System.Drawing.Point(12, 141)
        Me.DGPembelian.Name = "DGPembelian"
        Me.DGPembelian.RowTemplate.Height = 28
        Me.DGPembelian.Size = New System.Drawing.Size(974, 316)
        Me.DGPembelian.TabIndex = 14
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(160, 23)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(121, 28)
        Me.cmbSupplier.TabIndex = 16
        '
        'cmbBarang
        '
        Me.cmbBarang.FormattingEnabled = True
        Me.cmbBarang.Location = New System.Drawing.Point(160, 96)
        Me.cmbBarang.Name = "cmbBarang"
        Me.cmbBarang.Size = New System.Drawing.Size(121, 28)
        Me.cmbBarang.TabIndex = 17
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(813, 96)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(173, 26)
        Me.txtJumlah.TabIndex = 19
        '
        'txtDisc
        '
        Me.txtDisc.Location = New System.Drawing.Point(804, 502)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(160, 26)
        Me.txtDisc.TabIndex = 20
        '
        'txtFakturPembelian
        '
        Me.txtFakturPembelian.AutoSize = True
        Me.txtFakturPembelian.BackColor = System.Drawing.Color.White
        Me.txtFakturPembelian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtFakturPembelian.Location = New System.Drawing.Point(794, 31)
        Me.txtFakturPembelian.Name = "txtFakturPembelian"
        Me.txtFakturPembelian.Size = New System.Drawing.Size(59, 22)
        Me.txtFakturPembelian.TabIndex = 24
        Me.txtFakturPembelian.Text = "            "
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.AutoSize = True
        Me.txtNamaBarang.BackColor = System.Drawing.Color.White
        Me.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNamaBarang.Location = New System.Drawing.Point(312, 102)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(123, 22)
        Me.txtNamaBarang.TabIndex = 25
        Me.txtNamaBarang.Text = "                            "
        '
        'txtHarga
        '
        Me.txtHarga.AutoSize = True
        Me.txtHarga.BackColor = System.Drawing.Color.White
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtHarga.Location = New System.Drawing.Point(456, 102)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(20, 22)
        Me.txtHarga.TabIndex = 26
        Me.txtHarga.Text = "0"
        '
        'txtStok
        '
        Me.txtStok.AutoSize = True
        Me.txtStok.BackColor = System.Drawing.Color.White
        Me.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtStok.Location = New System.Drawing.Point(626, 102)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(20, 22)
        Me.txtStok.TabIndex = 27
        Me.txtStok.Text = "0"
        '
        'txtHargaKotor
        '
        Me.txtHargaKotor.AutoSize = True
        Me.txtHargaKotor.BackColor = System.Drawing.Color.White
        Me.txtHargaKotor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtHargaKotor.Location = New System.Drawing.Point(804, 470)
        Me.txtHargaKotor.Name = "txtHargaKotor"
        Me.txtHargaKotor.Size = New System.Drawing.Size(36, 22)
        Me.txtHargaKotor.TabIndex = 28
        Me.txtHargaKotor.Text = "Rp,"
        Me.txtHargaKotor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHargaBersih
        '
        Me.txtHargaBersih.AutoSize = True
        Me.txtHargaBersih.BackColor = System.Drawing.Color.White
        Me.txtHargaBersih.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtHargaBersih.ForeColor = System.Drawing.Color.Red
        Me.txtHargaBersih.Location = New System.Drawing.Point(804, 541)
        Me.txtHargaBersih.Name = "txtHargaBersih"
        Me.txtHargaBersih.Size = New System.Drawing.Size(36, 22)
        Me.txtHargaBersih.TabIndex = 29
        Me.txtHargaBersih.Text = "Rp,"
        Me.txtHargaBersih.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(18, 471)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 92)
        Me.btnsimpan.TabIndex = 30
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCetak.Location = New System.Drawing.Point(108, 471)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 92)
        Me.btnCetak.TabIndex = 31
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.Location = New System.Drawing.Point(203, 471)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(78, 92)
        Me.btnBatal.TabIndex = 32
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'frmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 585)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtHargaBersih)
        Me.Controls.Add(Me.txtHargaKotor)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtFakturPembelian)
        Me.Controls.Add(Me.txtDisc)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.cmbBarang)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.DGPembelian)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblDisc)
        Me.Controls.Add(Me.lblHargaKotor)
        Me.Controls.Add(Me.lblFakturPembelian)
        Me.Controls.Add(Me.txtNmSupplier)
        Me.Controls.Add(Me.lblBarang)
        Me.Controls.Add(Me.lblNamaSupplier)
        Me.Controls.Add(Me.lblSupplier)
        Me.Name = "frmPembelian"
        Me.Text = "Pembelian"
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents lblBarang As System.Windows.Forms.Label
    Friend WithEvents txtNmSupplier As System.Windows.Forms.Label
    Friend WithEvents lblFakturPembelian As System.Windows.Forms.Label
    Friend WithEvents lblHargaKotor As System.Windows.Forms.Label
    Friend WithEvents lblDisc As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DGPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBarang As System.Windows.Forms.ComboBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents txtFakturPembelian As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.Label
    Friend WithEvents txtHargaKotor As System.Windows.Forms.Label
    Friend WithEvents txtHargaBersih As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
