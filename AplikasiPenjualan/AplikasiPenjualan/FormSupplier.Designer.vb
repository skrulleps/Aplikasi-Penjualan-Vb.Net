<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSupplier))
        Me.lblkodesupplier = New System.Windows.Forms.Label()
        Me.lblnamaSupplier = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblKontak = New System.Windows.Forms.Label()
        Me.txtkodeSupplier = New System.Windows.Forms.TextBox()
        Me.txtNamaSupplier = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.rbCariKontak = New System.Windows.Forms.RadioButton()
        Me.rbNamaSupplier = New System.Windows.Forms.RadioButton()
        Me.rbKodeSupplier = New System.Windows.Forms.RadioButton()
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblkodesupplier
        '
        Me.lblkodesupplier.AutoSize = True
        Me.lblkodesupplier.Location = New System.Drawing.Point(12, 34)
        Me.lblkodesupplier.Name = "lblkodesupplier"
        Me.lblkodesupplier.Size = New System.Drawing.Size(108, 20)
        Me.lblkodesupplier.TabIndex = 0
        Me.lblkodesupplier.Text = "Kode Supplier"
        '
        'lblnamaSupplier
        '
        Me.lblnamaSupplier.AutoSize = True
        Me.lblnamaSupplier.Location = New System.Drawing.Point(12, 70)
        Me.lblnamaSupplier.Name = "lblnamaSupplier"
        Me.lblnamaSupplier.Size = New System.Drawing.Size(113, 20)
        Me.lblnamaSupplier.TabIndex = 1
        Me.lblnamaSupplier.Text = "Nama Supplier"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(12, 104)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(59, 20)
        Me.lblAlamat.TabIndex = 2
        Me.lblAlamat.Text = "Alamat"
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(12, 215)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(66, 20)
        Me.lblTelepon.TabIndex = 3
        Me.lblTelepon.Text = "Telepon"
        '
        'lblKontak
        '
        Me.lblKontak.AutoSize = True
        Me.lblKontak.Location = New System.Drawing.Point(12, 248)
        Me.lblKontak.Name = "lblKontak"
        Me.lblKontak.Size = New System.Drawing.Size(59, 20)
        Me.lblKontak.TabIndex = 4
        Me.lblKontak.Text = "Kontak"
        '
        'txtkodeSupplier
        '
        Me.txtkodeSupplier.Location = New System.Drawing.Point(145, 32)
        Me.txtkodeSupplier.Name = "txtkodeSupplier"
        Me.txtkodeSupplier.Size = New System.Drawing.Size(100, 26)
        Me.txtkodeSupplier.TabIndex = 5
        '
        'txtNamaSupplier
        '
        Me.txtNamaSupplier.Location = New System.Drawing.Point(145, 69)
        Me.txtNamaSupplier.Name = "txtNamaSupplier"
        Me.txtNamaSupplier.Size = New System.Drawing.Size(238, 26)
        Me.txtNamaSupplier.TabIndex = 6
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(145, 102)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(238, 100)
        Me.txtalamat.TabIndex = 7
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(145, 215)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(188, 26)
        Me.txtTelepon.TabIndex = 8
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(145, 248)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(188, 26)
        Me.txtKontak.TabIndex = 9
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsimpan.Location = New System.Drawing.Point(413, 200)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 66)
        Me.btnsimpan.TabIndex = 15
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTutup.Location = New System.Drawing.Point(737, 200)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 66)
        Me.btnTutup.TabIndex = 22
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(656, 200)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 66)
        Me.btnBatal.TabIndex = 21
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(575, 200)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 66)
        Me.btnHapus.TabIndex = 20
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(494, 200)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 66)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariData)
        Me.GroupBox1.Controls.Add(Me.rbCariKontak)
        Me.GroupBox1.Controls.Add(Me.rbNamaSupplier)
        Me.GroupBox1.Controls.Add(Me.rbKodeSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 61)
        Me.GroupBox1.TabIndex = 23
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
        'rbCariKontak
        '
        Me.rbCariKontak.AutoSize = True
        Me.rbCariKontak.Location = New System.Drawing.Point(304, 25)
        Me.rbCariKontak.Name = "rbCariKontak"
        Me.rbCariKontak.Size = New System.Drawing.Size(84, 24)
        Me.rbCariKontak.TabIndex = 2
        Me.rbCariKontak.TabStop = True
        Me.rbCariKontak.Text = "Kontak"
        Me.rbCariKontak.UseVisualStyleBackColor = True
        '
        'rbNamaSupplier
        '
        Me.rbNamaSupplier.AutoSize = True
        Me.rbNamaSupplier.Location = New System.Drawing.Point(152, 25)
        Me.rbNamaSupplier.Name = "rbNamaSupplier"
        Me.rbNamaSupplier.Size = New System.Drawing.Size(138, 24)
        Me.rbNamaSupplier.TabIndex = 1
        Me.rbNamaSupplier.TabStop = True
        Me.rbNamaSupplier.Text = "Nama Supplier"
        Me.rbNamaSupplier.UseVisualStyleBackColor = True
        '
        'rbKodeSupplier
        '
        Me.rbKodeSupplier.AutoSize = True
        Me.rbKodeSupplier.Location = New System.Drawing.Point(6, 25)
        Me.rbKodeSupplier.Name = "rbKodeSupplier"
        Me.rbKodeSupplier.Size = New System.Drawing.Size(133, 24)
        Me.rbKodeSupplier.TabIndex = 0
        Me.rbKodeSupplier.TabStop = True
        Me.rbKodeSupplier.Text = "Kode Supplier"
        Me.rbKodeSupplier.UseVisualStyleBackColor = True
        '
        'DGSupplier
        '
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(26, 347)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.RowTemplate.Height = 28
        Me.DGSupplier.Size = New System.Drawing.Size(841, 303)
        Me.DGSupplier.TabIndex = 24
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 662)
        Me.Controls.Add(Me.DGSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtKontak)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtNamaSupplier)
        Me.Controls.Add(Me.txtkodeSupplier)
        Me.Controls.Add(Me.lblKontak)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblnamaSupplier)
        Me.Controls.Add(Me.lblkodesupplier)
        Me.Name = "FormSupplier"
        Me.Text = "Data Supplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblkodesupplier As System.Windows.Forms.Label
    Friend WithEvents lblnamaSupplier As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblTelepon As System.Windows.Forms.Label
    Friend WithEvents lblKontak As System.Windows.Forms.Label
    Friend WithEvents txtkodeSupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtKontak As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCariData As System.Windows.Forms.TextBox
    Friend WithEvents rbCariKontak As System.Windows.Forms.RadioButton
    Friend WithEvents rbNamaSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents rbKodeSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents DGSupplier As System.Windows.Forms.DataGridView
End Class
