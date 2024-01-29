<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUbahPassword
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
        Me.lblPwLama = New System.Windows.Forms.Label()
        Me.lblPwBaru = New System.Windows.Forms.Label()
        Me.txtPwLama = New System.Windows.Forms.TextBox()
        Me.txtPwBaru = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPwLama
        '
        Me.lblPwLama.AutoSize = True
        Me.lblPwLama.Location = New System.Drawing.Point(38, 21)
        Me.lblPwLama.Name = "lblPwLama"
        Me.lblPwLama.Size = New System.Drawing.Size(122, 20)
        Me.lblPwLama.TabIndex = 0
        Me.lblPwLama.Text = "Password Lama"
        '
        'lblPwBaru
        '
        Me.lblPwBaru.AutoSize = True
        Me.lblPwBaru.Location = New System.Drawing.Point(38, 67)
        Me.lblPwBaru.Name = "lblPwBaru"
        Me.lblPwBaru.Size = New System.Drawing.Size(116, 20)
        Me.lblPwBaru.TabIndex = 1
        Me.lblPwBaru.Text = "Password Baru"
        '
        'txtPwLama
        '
        Me.txtPwLama.Location = New System.Drawing.Point(182, 18)
        Me.txtPwLama.Name = "txtPwLama"
        Me.txtPwLama.Size = New System.Drawing.Size(178, 26)
        Me.txtPwLama.TabIndex = 2
        '
        'txtPwBaru
        '
        Me.txtPwBaru.Location = New System.Drawing.Point(182, 61)
        Me.txtPwBaru.Name = "txtPwBaru"
        Me.txtPwBaru.Size = New System.Drawing.Size(178, 26)
        Me.txtPwBaru.TabIndex = 3
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(97, 127)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 30)
        Me.btnUbah.TabIndex = 4
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(236, 127)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 30)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'FrmUbahPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 183)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.txtPwBaru)
        Me.Controls.Add(Me.txtPwLama)
        Me.Controls.Add(Me.lblPwBaru)
        Me.Controls.Add(Me.lblPwLama)
        Me.Name = "FrmUbahPassword"
        Me.Text = "Ubah Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPwLama As System.Windows.Forms.Label
    Friend WithEvents lblPwBaru As System.Windows.Forms.Label
    Friend WithEvents txtPwLama As System.Windows.Forms.TextBox
    Friend WithEvents txtPwBaru As System.Windows.Forms.TextBox
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
