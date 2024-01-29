<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelanggan))
        Me.DGPelanggan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.rbNamaPelanggan = New System.Windows.Forms.RadioButton()
        Me.rbKodePelanggan = New System.Windows.Forms.RadioButton()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.txtkodePelanggan = New System.Windows.Forms.TextBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblnamaPelanggan = New System.Windows.Forms.Label()
        Me.lblkodepelanggan = New System.Windows.Forms.Label()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGPelanggan
        '
        Me.DGPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPelanggan.Location = New System.Drawing.Point(31, 330)
        Me.DGPelanggan.Name = "DGPelanggan"
        Me.DGPelanggan.RowTemplate.Height = 28
        Me.DGPelanggan.Size = New System.Drawing.Size(841, 303)
        Me.DGPelanggan.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariData)
        Me.GroupBox1.Controls.Add(Me.rbNamaPelanggan)
        Me.GroupBox1.Controls.Add(Me.rbKodePelanggan)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 61)
        Me.GroupBox1.TabIndex = 40
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
        'rbNamaPelanggan
        '
        Me.rbNamaPelanggan.AutoSize = True
        Me.rbNamaPelanggan.Location = New System.Drawing.Point(175, 25)
        Me.rbNamaPelanggan.Name = "rbNamaPelanggan"
        Me.rbNamaPelanggan.Size = New System.Drawing.Size(156, 24)
        Me.rbNamaPelanggan.TabIndex = 1
        Me.rbNamaPelanggan.TabStop = True
        Me.rbNamaPelanggan.Text = "Nama Pelanggan"
        Me.rbNamaPelanggan.UseVisualStyleBackColor = True
        '
        'rbKodePelanggan
        '
        Me.rbKodePelanggan.AutoSize = True
        Me.rbKodePelanggan.Location = New System.Drawing.Point(6, 25)
        Me.rbKodePelanggan.Name = "rbKodePelanggan"
        Me.rbKodePelanggan.Size = New System.Drawing.Size(151, 24)
        Me.rbKodePelanggan.TabIndex = 0
        Me.rbKodePelanggan.TabStop = True
        Me.rbKodePelanggan.Text = "Kode Pelanggan"
        Me.rbKodePelanggan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(661, 183)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 66)
        Me.btnBatal.TabIndex = 38
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(580, 183)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 66)
        Me.btnHapus.TabIndex = 37
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(499, 183)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 66)
        Me.btnEdit.TabIndex = 36
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTutup.Location = New System.Drawing.Point(742, 183)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 66)
        Me.btnTutup.TabIndex = 39
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsimpan.Location = New System.Drawing.Point(418, 183)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 66)
        Me.btnsimpan.TabIndex = 35
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(150, 198)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(188, 26)
        Me.txtTelepon.TabIndex = 33
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(150, 85)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(238, 100)
        Me.txtalamat.TabIndex = 32
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(150, 52)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(238, 26)
        Me.txtNamaPelanggan.TabIndex = 31
        '
        'txtkodePelanggan
        '
        Me.txtkodePelanggan.Location = New System.Drawing.Point(150, 15)
        Me.txtkodePelanggan.Name = "txtkodePelanggan"
        Me.txtkodePelanggan.Size = New System.Drawing.Size(100, 26)
        Me.txtkodePelanggan.TabIndex = 30
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(17, 198)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(66, 20)
        Me.lblTelepon.TabIndex = 28
        Me.lblTelepon.Text = "Telepon"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(17, 87)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(59, 20)
        Me.lblAlamat.TabIndex = 27
        Me.lblAlamat.Text = "Alamat"
        '
        'lblnamaPelanggan
        '
        Me.lblnamaPelanggan.AutoSize = True
        Me.lblnamaPelanggan.Location = New System.Drawing.Point(17, 53)
        Me.lblnamaPelanggan.Name = "lblnamaPelanggan"
        Me.lblnamaPelanggan.Size = New System.Drawing.Size(131, 20)
        Me.lblnamaPelanggan.TabIndex = 26
        Me.lblnamaPelanggan.Text = "Nama Pelanggan"
        '
        'lblkodepelanggan
        '
        Me.lblkodepelanggan.AutoSize = True
        Me.lblkodepelanggan.Location = New System.Drawing.Point(17, 17)
        Me.lblkodepelanggan.Name = "lblkodepelanggan"
        Me.lblkodepelanggan.Size = New System.Drawing.Size(126, 20)
        Me.lblkodepelanggan.TabIndex = 25
        Me.lblkodepelanggan.Text = "Kode Pelanggan"
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 640)
        Me.Controls.Add(Me.DGPelanggan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.txtkodePelanggan)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblnamaPelanggan)
        Me.Controls.Add(Me.lblkodepelanggan)
        Me.Name = "FormPelanggan"
        Me.Text = "Form Pelanggan"
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCariData As System.Windows.Forms.TextBox
    Friend WithEvents rbNamaPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents rbKodePelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents txtkodePelanggan As System.Windows.Forms.TextBox
    Friend WithEvents lblTelepon As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblnamaPelanggan As System.Windows.Forms.Label
    Friend WithEvents lblkodepelanggan As System.Windows.Forms.Label
End Class
