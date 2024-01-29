<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJenisBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJenisBarang))
        Me.lbljenisbarang = New System.Windows.Forms.Label()
        Me.lblkodejenis = New System.Windows.Forms.Label()
        Me.txtjenisbarang = New System.Windows.Forms.TextBox()
        Me.txtkodejenis = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.dgJenisBarang = New System.Windows.Forms.DataGridView()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.dgJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljenisbarang
        '
        Me.lbljenisbarang.AutoSize = True
        Me.lbljenisbarang.Location = New System.Drawing.Point(57, 78)
        Me.lbljenisbarang.Name = "lbljenisbarang"
        Me.lbljenisbarang.Size = New System.Drawing.Size(102, 20)
        Me.lbljenisbarang.TabIndex = 0
        Me.lbljenisbarang.Text = "Jenis Barang"
        '
        'lblkodejenis
        '
        Me.lblkodejenis.AutoSize = True
        Me.lblkodejenis.Location = New System.Drawing.Point(61, 36)
        Me.lblkodejenis.Name = "lblkodejenis"
        Me.lblkodejenis.Size = New System.Drawing.Size(87, 20)
        Me.lblkodejenis.TabIndex = 1
        Me.lblkodejenis.Text = "Kode Jenis"
        '
        'txtjenisbarang
        '
        Me.txtjenisbarang.Location = New System.Drawing.Point(194, 78)
        Me.txtjenisbarang.Name = "txtjenisbarang"
        Me.txtjenisbarang.Size = New System.Drawing.Size(170, 26)
        Me.txtjenisbarang.TabIndex = 2
        '
        'txtkodejenis
        '
        Me.txtkodejenis.Location = New System.Drawing.Point(194, 36)
        Me.txtkodejenis.Name = "txtkodejenis"
        Me.txtkodejenis.Size = New System.Drawing.Size(170, 26)
        Me.txtkodejenis.TabIndex = 3
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsimpan.Location = New System.Drawing.Point(86, 133)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(91, 65)
        Me.btnsimpan.TabIndex = 4
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'dgJenisBarang
        '
        Me.dgJenisBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgJenisBarang.Location = New System.Drawing.Point(12, 216)
        Me.dgJenisBarang.Name = "dgJenisBarang"
        Me.dgJenisBarang.RowTemplate.Height = 28
        Me.dgJenisBarang.Size = New System.Drawing.Size(487, 193)
        Me.dgJenisBarang.TabIndex = 7
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(208, 133)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(81, 65)
        Me.btnUbah.TabIndex = 8
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(321, 133)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(81, 65)
        Me.btnHapus.TabIndex = 9
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'frmJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 421)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.dgJenisBarang)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtkodejenis)
        Me.Controls.Add(Me.txtjenisbarang)
        Me.Controls.Add(Me.lblkodejenis)
        Me.Controls.Add(Me.lbljenisbarang)
        Me.Name = "frmJenisBarang"
        Me.Text = "Form Jenis Barang"
        CType(Me.dgJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljenisbarang As System.Windows.Forms.Label
    Friend WithEvents lblkodejenis As System.Windows.Forms.Label
    Friend WithEvents txtjenisbarang As System.Windows.Forms.TextBox
    Friend WithEvents txtkodejenis As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents dgJenisBarang As System.Windows.Forms.DataGridView
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
End Class
