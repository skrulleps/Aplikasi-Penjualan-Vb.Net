<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPengguna))
        Me.lblKdPengguna = New System.Windows.Forms.Label()
        Me.lblNmPengguna = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUlangPwd = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.txtKdPengguna = New System.Windows.Forms.TextBox()
        Me.txtNmPengguna = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtUlangPwd = New System.Windows.Forms.TextBox()
        Me.cblevel = New System.Windows.Forms.ComboBox()
        Me.DGPengguna = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKdPengguna
        '
        Me.lblKdPengguna.AutoSize = True
        Me.lblKdPengguna.Location = New System.Drawing.Point(22, 25)
        Me.lblKdPengguna.Name = "lblKdPengguna"
        Me.lblKdPengguna.Size = New System.Drawing.Size(123, 20)
        Me.lblKdPengguna.TabIndex = 0
        Me.lblKdPengguna.Text = "Kode Pengguna"
        '
        'lblNmPengguna
        '
        Me.lblNmPengguna.AutoSize = True
        Me.lblNmPengguna.Location = New System.Drawing.Point(22, 64)
        Me.lblNmPengguna.Name = "lblNmPengguna"
        Me.lblNmPengguna.Size = New System.Drawing.Size(128, 20)
        Me.lblNmPengguna.TabIndex = 1
        Me.lblNmPengguna.Text = "Nama Pengguna"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(22, 102)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblUlangPwd
        '
        Me.lblUlangPwd.AutoSize = True
        Me.lblUlangPwd.Location = New System.Drawing.Point(22, 143)
        Me.lblUlangPwd.Name = "lblUlangPwd"
        Me.lblUlangPwd.Size = New System.Drawing.Size(124, 20)
        Me.lblUlangPwd.TabIndex = 3
        Me.lblUlangPwd.Text = "Ulang Password"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(22, 185)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(46, 20)
        Me.lblLevel.TabIndex = 4
        Me.lblLevel.Text = "Level"
        '
        'txtKdPengguna
        '
        Me.txtKdPengguna.Location = New System.Drawing.Point(154, 25)
        Me.txtKdPengguna.Name = "txtKdPengguna"
        Me.txtKdPengguna.Size = New System.Drawing.Size(147, 26)
        Me.txtKdPengguna.TabIndex = 5
        '
        'txtNmPengguna
        '
        Me.txtNmPengguna.Location = New System.Drawing.Point(154, 64)
        Me.txtNmPengguna.Name = "txtNmPengguna"
        Me.txtNmPengguna.Size = New System.Drawing.Size(147, 26)
        Me.txtNmPengguna.TabIndex = 6
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(154, 99)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(147, 26)
        Me.txtPwd.TabIndex = 7
        '
        'txtUlangPwd
        '
        Me.txtUlangPwd.Location = New System.Drawing.Point(154, 140)
        Me.txtUlangPwd.Name = "txtUlangPwd"
        Me.txtUlangPwd.Size = New System.Drawing.Size(147, 26)
        Me.txtUlangPwd.TabIndex = 8
        '
        'cblevel
        '
        Me.cblevel.FormattingEnabled = True
        Me.cblevel.Location = New System.Drawing.Point(154, 185)
        Me.cblevel.Name = "cblevel"
        Me.cblevel.Size = New System.Drawing.Size(172, 28)
        Me.cblevel.TabIndex = 9
        '
        'DGPengguna
        '
        Me.DGPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPengguna.Location = New System.Drawing.Point(36, 301)
        Me.DGPengguna.Name = "DGPengguna"
        Me.DGPengguna.RowTemplate.Height = 28
        Me.DGPengguna.Size = New System.Drawing.Size(608, 211)
        Me.DGPengguna.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.AplikasiPenjualan.My.Resources.Resources.key2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(324, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 103)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cari"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTutup.Location = New System.Drawing.Point(362, 229)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 66)
        Me.btnTutup.TabIndex = 23
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(281, 229)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 66)
        Me.btnBatal.TabIndex = 22
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(200, 229)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 66)
        Me.btnHapus.TabIndex = 21
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(119, 229)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 66)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsimpan.Location = New System.Drawing.Point(36, 229)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 66)
        Me.btnsimpan.TabIndex = 19
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'FrmPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 524)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DGPengguna)
        Me.Controls.Add(Me.cblevel)
        Me.Controls.Add(Me.txtUlangPwd)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtNmPengguna)
        Me.Controls.Add(Me.txtKdPengguna)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblUlangPwd)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblNmPengguna)
        Me.Controls.Add(Me.lblKdPengguna)
        Me.Name = "FrmPengguna"
        Me.Text = "Pengguna"
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKdPengguna As System.Windows.Forms.Label
    Friend WithEvents lblNmPengguna As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUlangPwd As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents txtKdPengguna As System.Windows.Forms.TextBox
    Friend WithEvents txtNmPengguna As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtUlangPwd As System.Windows.Forms.TextBox
    Friend WithEvents cblevel As System.Windows.Forms.ComboBox
    Friend WithEvents DGPengguna As System.Windows.Forms.DataGridView
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
