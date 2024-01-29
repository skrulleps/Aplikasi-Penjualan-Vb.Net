<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formsatuan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formsatuan))
        Me.lblkodesatuan = New System.Windows.Forms.Label()
        Me.lblsatuan = New System.Windows.Forms.Label()
        Me.txtkodesatuan = New System.Windows.Forms.TextBox()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DGSatuan = New System.Windows.Forms.DataGridView()
        CType(Me.DGSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblkodesatuan
        '
        Me.lblkodesatuan.AutoSize = True
        Me.lblkodesatuan.Location = New System.Drawing.Point(52, 30)
        Me.lblkodesatuan.Name = "lblkodesatuan"
        Me.lblkodesatuan.Size = New System.Drawing.Size(102, 20)
        Me.lblkodesatuan.TabIndex = 0
        Me.lblkodesatuan.Text = "Kode Satuan"
        '
        'lblsatuan
        '
        Me.lblsatuan.AutoSize = True
        Me.lblsatuan.Location = New System.Drawing.Point(52, 66)
        Me.lblsatuan.Name = "lblsatuan"
        Me.lblsatuan.Size = New System.Drawing.Size(61, 20)
        Me.lblsatuan.TabIndex = 1
        Me.lblsatuan.Text = "Satuan"
        '
        'txtkodesatuan
        '
        Me.txtkodesatuan.Location = New System.Drawing.Point(181, 30)
        Me.txtkodesatuan.Name = "txtkodesatuan"
        Me.txtkodesatuan.Size = New System.Drawing.Size(100, 26)
        Me.txtkodesatuan.TabIndex = 2
        '
        'txtsatuan
        '
        Me.txtsatuan.Location = New System.Drawing.Point(181, 66)
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(225, 26)
        Me.txtsatuan.TabIndex = 3
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsimpan.Location = New System.Drawing.Point(98, 127)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 66)
        Me.btnsimpan.TabIndex = 4
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(206, 127)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 66)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(318, 127)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 66)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'DGSatuan
        '
        Me.DGSatuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSatuan.Location = New System.Drawing.Point(26, 215)
        Me.DGSatuan.Name = "DGSatuan"
        Me.DGSatuan.RowTemplate.Height = 28
        Me.DGSatuan.Size = New System.Drawing.Size(441, 199)
        Me.DGSatuan.TabIndex = 7
        '
        'formsatuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 436)
        Me.Controls.Add(Me.DGSatuan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtsatuan)
        Me.Controls.Add(Me.txtkodesatuan)
        Me.Controls.Add(Me.lblsatuan)
        Me.Controls.Add(Me.lblkodesatuan)
        Me.Name = "formsatuan"
        Me.Text = "Form Satuan"
        CType(Me.DGSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblkodesatuan As System.Windows.Forms.Label
    Friend WithEvents lblsatuan As System.Windows.Forms.Label
    Friend WithEvents txtkodesatuan As System.Windows.Forms.TextBox
    Friend WithEvents txtsatuan As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents DGSatuan As System.Windows.Forms.DataGridView
End Class
