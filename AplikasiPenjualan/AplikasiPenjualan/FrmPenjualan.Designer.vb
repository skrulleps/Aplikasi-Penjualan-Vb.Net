<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPenjualan))
        Me.lblPelanggan = New System.Windows.Forms.Label()
        Me.cbPelanggan = New System.Windows.Forms.ComboBox()
        Me.cbBarang = New System.Windows.Forms.ComboBox()
        Me.lblnmPelanggan = New System.Windows.Forms.Label()
        Me.lblBarang = New System.Windows.Forms.Label()
        Me.lbltxtnmPelanggan = New System.Windows.Forms.Label()
        Me.lblFakPenjualan = New System.Windows.Forms.Label()
        Me.lbltxtFaktur = New System.Windows.Forms.Label()
        Me.lbltxtnmBarang = New System.Windows.Forms.Label()
        Me.lbltxtHarga = New System.Windows.Forms.Label()
        Me.lbltxtStok = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.lblHrgKotor = New System.Windows.Forms.Label()
        Me.lblDisc = New System.Windows.Forms.Label()
        Me.lblHrgBersih = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lbltxtHrgKotor = New System.Windows.Forms.Label()
        Me.lblHrgTotal = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.lbltxtHrgBersih = New System.Windows.Forms.Label()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPelanggan
        '
        Me.lblPelanggan.AutoSize = True
        Me.lblPelanggan.Location = New System.Drawing.Point(12, 9)
        Me.lblPelanggan.Name = "lblPelanggan"
        Me.lblPelanggan.Size = New System.Drawing.Size(85, 20)
        Me.lblPelanggan.TabIndex = 0
        Me.lblPelanggan.Text = "Pelanggan"
        '
        'cbPelanggan
        '
        Me.cbPelanggan.FormattingEnabled = True
        Me.cbPelanggan.Location = New System.Drawing.Point(159, 6)
        Me.cbPelanggan.Name = "cbPelanggan"
        Me.cbPelanggan.Size = New System.Drawing.Size(121, 28)
        Me.cbPelanggan.TabIndex = 1
        '
        'cbBarang
        '
        Me.cbBarang.FormattingEnabled = True
        Me.cbBarang.Location = New System.Drawing.Point(159, 79)
        Me.cbBarang.Name = "cbBarang"
        Me.cbBarang.Size = New System.Drawing.Size(121, 28)
        Me.cbBarang.TabIndex = 2
        '
        'lblnmPelanggan
        '
        Me.lblnmPelanggan.AutoSize = True
        Me.lblnmPelanggan.Location = New System.Drawing.Point(12, 46)
        Me.lblnmPelanggan.Name = "lblnmPelanggan"
        Me.lblnmPelanggan.Size = New System.Drawing.Size(131, 20)
        Me.lblnmPelanggan.TabIndex = 3
        Me.lblnmPelanggan.Text = "Nama Pelanggan"
        '
        'lblBarang
        '
        Me.lblBarang.AutoSize = True
        Me.lblBarang.Location = New System.Drawing.Point(12, 79)
        Me.lblBarang.Name = "lblBarang"
        Me.lblBarang.Size = New System.Drawing.Size(61, 20)
        Me.lblBarang.TabIndex = 4
        Me.lblBarang.Text = "Barang"
        '
        'lbltxtnmPelanggan
        '
        Me.lbltxtnmPelanggan.AutoSize = True
        Me.lbltxtnmPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxtnmPelanggan.Location = New System.Drawing.Point(159, 46)
        Me.lbltxtnmPelanggan.Name = "lbltxtnmPelanggan"
        Me.lbltxtnmPelanggan.Size = New System.Drawing.Size(59, 22)
        Me.lbltxtnmPelanggan.TabIndex = 5
        Me.lbltxtnmPelanggan.Text = "Label4"
        '
        'lblFakPenjualan
        '
        Me.lblFakPenjualan.AutoSize = True
        Me.lblFakPenjualan.Location = New System.Drawing.Point(600, 14)
        Me.lblFakPenjualan.Name = "lblFakPenjualan"
        Me.lblFakPenjualan.Size = New System.Drawing.Size(129, 20)
        Me.lblFakPenjualan.TabIndex = 6
        Me.lblFakPenjualan.Text = "Faktur Penjualan"
        '
        'lbltxtFaktur
        '
        Me.lbltxtFaktur.AutoSize = True
        Me.lbltxtFaktur.BackColor = System.Drawing.Color.Yellow
        Me.lbltxtFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxtFaktur.Location = New System.Drawing.Point(785, 12)
        Me.lbltxtFaktur.Name = "lbltxtFaktur"
        Me.lbltxtFaktur.Size = New System.Drawing.Size(59, 22)
        Me.lbltxtFaktur.TabIndex = 7
        Me.lbltxtFaktur.Text = "Label6"
        '
        'lbltxtnmBarang
        '
        Me.lbltxtnmBarang.AutoSize = True
        Me.lbltxtnmBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxtnmBarang.Location = New System.Drawing.Point(343, 87)
        Me.lbltxtnmBarang.Name = "lbltxtnmBarang"
        Me.lbltxtnmBarang.Size = New System.Drawing.Size(53, 22)
        Me.lbltxtnmBarang.TabIndex = 8
        Me.lbltxtnmBarang.Text = "label7"
        '
        'lbltxtHarga
        '
        Me.lbltxtHarga.AutoSize = True
        Me.lbltxtHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxtHarga.Location = New System.Drawing.Point(452, 87)
        Me.lbltxtHarga.Name = "lbltxtHarga"
        Me.lbltxtHarga.Size = New System.Drawing.Size(20, 22)
        Me.lbltxtHarga.TabIndex = 9
        Me.lbltxtHarga.Text = "0"
        '
        'lbltxtStok
        '
        Me.lbltxtStok.AutoSize = True
        Me.lbltxtStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxtStok.Location = New System.Drawing.Point(672, 87)
        Me.lbltxtStok.Name = "lbltxtStok"
        Me.lbltxtStok.Size = New System.Drawing.Size(20, 22)
        Me.lbltxtStok.TabIndex = 10
        Me.lbltxtStok.Text = "0"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(785, 81)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 26)
        Me.txtJumlah.TabIndex = 11
        '
        'DGPenjualan
        '
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(12, 125)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.RowTemplate.Height = 28
        Me.DGPenjualan.Size = New System.Drawing.Size(904, 267)
        Me.DGPenjualan.TabIndex = 12
        '
        'lblHrgKotor
        '
        Me.lblHrgKotor.AutoSize = True
        Me.lblHrgKotor.Location = New System.Drawing.Point(571, 395)
        Me.lblHrgKotor.Name = "lblHrgKotor"
        Me.lblHrgKotor.Size = New System.Drawing.Size(103, 20)
        Me.lblHrgKotor.TabIndex = 13
        Me.lblHrgKotor.Text = "Harga Kotor :"
        '
        'lblDisc
        '
        Me.lblDisc.AutoSize = True
        Me.lblDisc.Location = New System.Drawing.Point(571, 427)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(48, 20)
        Me.lblDisc.TabIndex = 14
        Me.lblDisc.Text = "Disc :"
        '
        'lblHrgBersih
        '
        Me.lblHrgBersih.AutoSize = True
        Me.lblHrgBersih.Location = New System.Drawing.Point(571, 459)
        Me.lblHrgBersih.Name = "lblHrgBersih"
        Me.lblHrgBersih.Size = New System.Drawing.Size(110, 20)
        Me.lblHrgBersih.TabIndex = 15
        Me.lblHrgBersih.Text = "Harga Bersih :"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(737, 425)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 26)
        Me.txtDiscount.TabIndex = 17
        '
        'lbltxtHrgKotor
        '
        Me.lbltxtHrgKotor.AutoSize = True
        Me.lbltxtHrgKotor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxtHrgKotor.Location = New System.Drawing.Point(734, 395)
        Me.lbltxtHrgKotor.Name = "lbltxtHrgKotor"
        Me.lbltxtHrgKotor.Size = New System.Drawing.Size(36, 22)
        Me.lbltxtHrgKotor.TabIndex = 16
        Me.lbltxtHrgKotor.Text = "Rp,"
        '
        'lblHrgTotal
        '
        Me.lblHrgTotal.AutoSize = True
        Me.lblHrgTotal.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblHrgTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHrgTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHrgTotal.Location = New System.Drawing.Point(819, 58)
        Me.lblHrgTotal.Name = "lblHrgTotal"
        Me.lblHrgTotal.Size = New System.Drawing.Size(68, 22)
        Me.lblHrgTotal.TabIndex = 19
        Me.lblHrgTotal.Text = "Label15"
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsimpan.Location = New System.Drawing.Point(16, 413)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 66)
        Me.btnsimpan.TabIndex = 20
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(178, 413)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 66)
        Me.btnBatal.TabIndex = 21
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCetak.Location = New System.Drawing.Point(97, 413)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 85)
        Me.btnCetak.TabIndex = 22
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'lbltxtHrgBersih
        '
        Me.lbltxtHrgBersih.AutoSize = True
        Me.lbltxtHrgBersih.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxtHrgBersih.ForeColor = System.Drawing.Color.Red
        Me.lbltxtHrgBersih.Location = New System.Drawing.Point(734, 459)
        Me.lbltxtHrgBersih.Name = "lbltxtHrgBersih"
        Me.lbltxtHrgBersih.Size = New System.Drawing.Size(36, 22)
        Me.lbltxtHrgBersih.TabIndex = 23
        Me.lbltxtHrgBersih.Text = "Rp,"
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 497)
        Me.Controls.Add(Me.lbltxtHrgBersih)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.lblHrgTotal)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.lbltxtHrgKotor)
        Me.Controls.Add(Me.lblHrgBersih)
        Me.Controls.Add(Me.lblDisc)
        Me.Controls.Add(Me.lblHrgKotor)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.lbltxtStok)
        Me.Controls.Add(Me.lbltxtHarga)
        Me.Controls.Add(Me.lbltxtnmBarang)
        Me.Controls.Add(Me.lbltxtFaktur)
        Me.Controls.Add(Me.lblFakPenjualan)
        Me.Controls.Add(Me.lbltxtnmPelanggan)
        Me.Controls.Add(Me.lblBarang)
        Me.Controls.Add(Me.lblnmPelanggan)
        Me.Controls.Add(Me.cbBarang)
        Me.Controls.Add(Me.cbPelanggan)
        Me.Controls.Add(Me.lblPelanggan)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmPenjualan"
        Me.Text = "Penjualan"
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPelanggan As System.Windows.Forms.Label
    Friend WithEvents cbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents cbBarang As System.Windows.Forms.ComboBox
    Friend WithEvents lblnmPelanggan As System.Windows.Forms.Label
    Friend WithEvents lblBarang As System.Windows.Forms.Label
    Friend WithEvents lbltxtnmPelanggan As System.Windows.Forms.Label
    Friend WithEvents lblFakPenjualan As System.Windows.Forms.Label
    Friend WithEvents lbltxtFaktur As System.Windows.Forms.Label
    Friend WithEvents lbltxtnmBarang As System.Windows.Forms.Label
    Friend WithEvents lbltxtHarga As System.Windows.Forms.Label
    Friend WithEvents lbltxtStok As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents DGPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents lblHrgKotor As System.Windows.Forms.Label
    Friend WithEvents lblDisc As System.Windows.Forms.Label
    Friend WithEvents lblHrgBersih As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lbltxtHrgKotor As System.Windows.Forms.Label
    Friend WithEvents lblHrgTotal As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents lbltxtHrgBersih As System.Windows.Forms.Label
End Class
