<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHakAkses
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
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.cbLevel = New System.Windows.Forms.ComboBox()
        Me.chkPengguna = New System.Windows.Forms.CheckBox()
        Me.chkJenis = New System.Windows.Forms.CheckBox()
        Me.chkSatuan = New System.Windows.Forms.CheckBox()
        Me.chkBarang = New System.Windows.Forms.CheckBox()
        Me.chkSupplier = New System.Windows.Forms.CheckBox()
        Me.chkPelanggan = New System.Windows.Forms.CheckBox()
        Me.chkPembelian = New System.Windows.Forms.CheckBox()
        Me.chkPenjualan = New System.Windows.Forms.CheckBox()
        Me.chkHakAkses = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.gbSistem = New System.Windows.Forms.GroupBox()
        Me.gbMasterData = New System.Windows.Forms.GroupBox()
        Me.gbTransaksi = New System.Windows.Forms.GroupBox()
        Me.chkLprPenjualan = New System.Windows.Forms.CheckBox()
        Me.chkLprPembelian = New System.Windows.Forms.CheckBox()
        Me.chkLprBarang = New System.Windows.Forms.CheckBox()
        Me.chkLprPelanggan = New System.Windows.Forms.CheckBox()
        Me.chkLprSupplier = New System.Windows.Forms.CheckBox()
        Me.gbLaporan = New System.Windows.Forms.GroupBox()
        Me.gbSistem.SuspendLayout()
        Me.gbMasterData.SuspendLayout()
        Me.gbTransaksi.SuspendLayout()
        Me.gbLaporan.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(28, 20)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(116, 20)
        Me.lblLevel.TabIndex = 0
        Me.lblLevel.Text = "Level            :"
        '
        'cbLevel
        '
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Location = New System.Drawing.Point(154, 17)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(161, 28)
        Me.cbLevel.TabIndex = 1
        '
        'chkPengguna
        '
        Me.chkPengguna.AutoSize = True
        Me.chkPengguna.Location = New System.Drawing.Point(19, 44)
        Me.chkPengguna.Name = "chkPengguna"
        Me.chkPengguna.Size = New System.Drawing.Size(108, 24)
        Me.chkPengguna.TabIndex = 2
        Me.chkPengguna.Text = "Pengguna"
        Me.chkPengguna.UseVisualStyleBackColor = True
        '
        'chkJenis
        '
        Me.chkJenis.AutoSize = True
        Me.chkJenis.Location = New System.Drawing.Point(17, 33)
        Me.chkJenis.Name = "chkJenis"
        Me.chkJenis.Size = New System.Drawing.Size(72, 24)
        Me.chkJenis.TabIndex = 3
        Me.chkJenis.Text = "Jenis"
        Me.chkJenis.UseVisualStyleBackColor = True
        '
        'chkSatuan
        '
        Me.chkSatuan.AutoSize = True
        Me.chkSatuan.Location = New System.Drawing.Point(17, 63)
        Me.chkSatuan.Name = "chkSatuan"
        Me.chkSatuan.Size = New System.Drawing.Size(87, 24)
        Me.chkSatuan.TabIndex = 4
        Me.chkSatuan.Text = "Satuan"
        Me.chkSatuan.UseVisualStyleBackColor = True
        '
        'chkBarang
        '
        Me.chkBarang.AutoSize = True
        Me.chkBarang.Location = New System.Drawing.Point(17, 115)
        Me.chkBarang.Name = "chkBarang"
        Me.chkBarang.Size = New System.Drawing.Size(87, 24)
        Me.chkBarang.TabIndex = 5
        Me.chkBarang.Text = "Barang"
        Me.chkBarang.UseVisualStyleBackColor = True
        '
        'chkSupplier
        '
        Me.chkSupplier.AutoSize = True
        Me.chkSupplier.Location = New System.Drawing.Point(17, 145)
        Me.chkSupplier.Name = "chkSupplier"
        Me.chkSupplier.Size = New System.Drawing.Size(93, 24)
        Me.chkSupplier.TabIndex = 6
        Me.chkSupplier.Text = "Supplier"
        Me.chkSupplier.UseVisualStyleBackColor = True
        '
        'chkPelanggan
        '
        Me.chkPelanggan.AutoSize = True
        Me.chkPelanggan.Location = New System.Drawing.Point(17, 175)
        Me.chkPelanggan.Name = "chkPelanggan"
        Me.chkPelanggan.Size = New System.Drawing.Size(111, 24)
        Me.chkPelanggan.TabIndex = 7
        Me.chkPelanggan.Text = "Pelanggan"
        Me.chkPelanggan.UseVisualStyleBackColor = True
        '
        'chkPembelian
        '
        Me.chkPembelian.AutoSize = True
        Me.chkPembelian.Location = New System.Drawing.Point(36, 38)
        Me.chkPembelian.Name = "chkPembelian"
        Me.chkPembelian.Size = New System.Drawing.Size(109, 24)
        Me.chkPembelian.TabIndex = 8
        Me.chkPembelian.Text = "Pembelian"
        Me.chkPembelian.UseVisualStyleBackColor = True
        '
        'chkPenjualan
        '
        Me.chkPenjualan.AutoSize = True
        Me.chkPenjualan.Location = New System.Drawing.Point(36, 69)
        Me.chkPenjualan.Name = "chkPenjualan"
        Me.chkPenjualan.Size = New System.Drawing.Size(105, 24)
        Me.chkPenjualan.TabIndex = 9
        Me.chkPenjualan.Text = "Penjualan"
        Me.chkPenjualan.UseVisualStyleBackColor = True
        '
        'chkHakAkses
        '
        Me.chkHakAkses.AutoSize = True
        Me.chkHakAkses.Location = New System.Drawing.Point(349, 533)
        Me.chkHakAkses.Name = "chkHakAkses"
        Me.chkHakAkses.Size = New System.Drawing.Size(112, 24)
        Me.chkHakAkses.TabIndex = 15
        Me.chkHakAkses.Text = "Hak Akses"
        Me.chkHakAkses.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(32, 543)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 37)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'gbSistem
        '
        Me.gbSistem.Controls.Add(Me.chkPengguna)
        Me.gbSistem.Location = New System.Drawing.Point(28, 82)
        Me.gbSistem.Name = "gbSistem"
        Me.gbSistem.Size = New System.Drawing.Size(246, 163)
        Me.gbSistem.TabIndex = 17
        Me.gbSistem.TabStop = False
        Me.gbSistem.Text = "Sistem"
        '
        'gbMasterData
        '
        Me.gbMasterData.Controls.Add(Me.chkPelanggan)
        Me.gbMasterData.Controls.Add(Me.chkSupplier)
        Me.gbMasterData.Controls.Add(Me.chkBarang)
        Me.gbMasterData.Controls.Add(Me.chkSatuan)
        Me.gbMasterData.Controls.Add(Me.chkJenis)
        Me.gbMasterData.Location = New System.Drawing.Point(30, 259)
        Me.gbMasterData.Name = "gbMasterData"
        Me.gbMasterData.Size = New System.Drawing.Size(245, 220)
        Me.gbMasterData.TabIndex = 18
        Me.gbMasterData.TabStop = False
        Me.gbMasterData.Text = "Master Data"
        '
        'gbTransaksi
        '
        Me.gbTransaksi.Controls.Add(Me.chkPenjualan)
        Me.gbTransaksi.Controls.Add(Me.chkPembelian)
        Me.gbTransaksi.Location = New System.Drawing.Point(313, 93)
        Me.gbTransaksi.Name = "gbTransaksi"
        Me.gbTransaksi.Size = New System.Drawing.Size(272, 151)
        Me.gbTransaksi.TabIndex = 19
        Me.gbTransaksi.TabStop = False
        Me.gbTransaksi.Text = "Transaksi"
        '
        'chkLprPenjualan
        '
        Me.chkLprPenjualan.AutoSize = True
        Me.chkLprPenjualan.Location = New System.Drawing.Point(40, 216)
        Me.chkLprPenjualan.Name = "chkLprPenjualan"
        Me.chkLprPenjualan.Size = New System.Drawing.Size(168, 24)
        Me.chkLprPenjualan.TabIndex = 19
        Me.chkLprPenjualan.Text = "Laporan Penjualan"
        Me.chkLprPenjualan.UseVisualStyleBackColor = True
        '
        'chkLprPembelian
        '
        Me.chkLprPembelian.AutoSize = True
        Me.chkLprPembelian.Location = New System.Drawing.Point(40, 176)
        Me.chkLprPembelian.Name = "chkLprPembelian"
        Me.chkLprPembelian.Size = New System.Drawing.Size(172, 24)
        Me.chkLprPembelian.TabIndex = 18
        Me.chkLprPembelian.Text = "Laporan Pembelian"
        Me.chkLprPembelian.UseVisualStyleBackColor = True
        '
        'chkLprBarang
        '
        Me.chkLprBarang.AutoSize = True
        Me.chkLprBarang.Location = New System.Drawing.Point(40, 116)
        Me.chkLprBarang.Name = "chkLprBarang"
        Me.chkLprBarang.Size = New System.Drawing.Size(150, 24)
        Me.chkLprBarang.TabIndex = 17
        Me.chkLprBarang.Text = "Laporan Barang"
        Me.chkLprBarang.UseVisualStyleBackColor = True
        '
        'chkLprPelanggan
        '
        Me.chkLprPelanggan.AutoSize = True
        Me.chkLprPelanggan.Location = New System.Drawing.Point(40, 64)
        Me.chkLprPelanggan.Name = "chkLprPelanggan"
        Me.chkLprPelanggan.Size = New System.Drawing.Size(174, 24)
        Me.chkLprPelanggan.TabIndex = 16
        Me.chkLprPelanggan.Text = "Laporan Pelanggan"
        Me.chkLprPelanggan.UseVisualStyleBackColor = True
        '
        'chkLprSupplier
        '
        Me.chkLprSupplier.AutoSize = True
        Me.chkLprSupplier.Location = New System.Drawing.Point(40, 34)
        Me.chkLprSupplier.Name = "chkLprSupplier"
        Me.chkLprSupplier.Size = New System.Drawing.Size(156, 24)
        Me.chkLprSupplier.TabIndex = 15
        Me.chkLprSupplier.Text = "Laporan Supplier"
        Me.chkLprSupplier.UseVisualStyleBackColor = True
        '
        'gbLaporan
        '
        Me.gbLaporan.Controls.Add(Me.chkLprPenjualan)
        Me.gbLaporan.Controls.Add(Me.chkLprPembelian)
        Me.gbLaporan.Controls.Add(Me.chkLprSupplier)
        Me.gbLaporan.Controls.Add(Me.chkLprPelanggan)
        Me.gbLaporan.Controls.Add(Me.chkLprBarang)
        Me.gbLaporan.Location = New System.Drawing.Point(309, 258)
        Me.gbLaporan.Name = "gbLaporan"
        Me.gbLaporan.Size = New System.Drawing.Size(275, 252)
        Me.gbLaporan.TabIndex = 20
        Me.gbLaporan.TabStop = False
        Me.gbLaporan.Text = "Laporan"
        '
        'FrmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 594)
        Me.Controls.Add(Me.gbLaporan)
        Me.Controls.Add(Me.gbTransaksi)
        Me.Controls.Add(Me.gbMasterData)
        Me.Controls.Add(Me.gbSistem)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.chkHakAkses)
        Me.Controls.Add(Me.cbLevel)
        Me.Controls.Add(Me.lblLevel)
        Me.Name = "FrmHakAkses"
        Me.Text = "Hak Akses"
        Me.gbSistem.ResumeLayout(False)
        Me.gbSistem.PerformLayout()
        Me.gbMasterData.ResumeLayout(False)
        Me.gbMasterData.PerformLayout()
        Me.gbTransaksi.ResumeLayout(False)
        Me.gbTransaksi.PerformLayout()
        Me.gbLaporan.ResumeLayout(False)
        Me.gbLaporan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents cbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents chkPengguna As System.Windows.Forms.CheckBox
    Friend WithEvents chkJenis As System.Windows.Forms.CheckBox
    Friend WithEvents chkSatuan As System.Windows.Forms.CheckBox
    Friend WithEvents chkBarang As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chkPelanggan As System.Windows.Forms.CheckBox
    Friend WithEvents chkPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents chkPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents chkHakAkses As System.Windows.Forms.CheckBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents gbSistem As System.Windows.Forms.GroupBox
    Friend WithEvents gbMasterData As System.Windows.Forms.GroupBox
    Friend WithEvents gbTransaksi As System.Windows.Forms.GroupBox
    Friend WithEvents chkLprPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprBarang As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprPelanggan As System.Windows.Forms.CheckBox
    Friend WithEvents chkLprSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents gbLaporan As System.Windows.Forms.GroupBox
End Class
