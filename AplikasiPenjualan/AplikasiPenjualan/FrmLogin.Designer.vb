<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.lblKdPengguna = New System.Windows.Forms.Label()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.txtKdPengguna = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKdPengguna
        '
        Me.lblKdPengguna.AutoSize = True
        Me.lblKdPengguna.Location = New System.Drawing.Point(23, 29)
        Me.lblKdPengguna.Name = "lblKdPengguna"
        Me.lblKdPengguna.Size = New System.Drawing.Size(123, 20)
        Me.lblKdPengguna.TabIndex = 0
        Me.lblKdPengguna.Text = "Kode Pengguna"
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Location = New System.Drawing.Point(23, 70)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(78, 20)
        Me.lblPwd.TabIndex = 1
        Me.lblPwd.Text = "Password"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(23, 114)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(46, 20)
        Me.lblLevel.TabIndex = 2
        Me.lblLevel.Text = "Level"
        '
        'txtKdPengguna
        '
        Me.txtKdPengguna.Location = New System.Drawing.Point(155, 29)
        Me.txtKdPengguna.Name = "txtKdPengguna"
        Me.txtKdPengguna.Size = New System.Drawing.Size(142, 26)
        Me.txtKdPengguna.TabIndex = 3
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(155, 70)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(142, 26)
        Me.txtPwd.TabIndex = 4
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(155, 111)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(142, 26)
        Me.txtLevel.TabIndex = 5
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(155, 173)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 33)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(246, 173)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 33)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 244)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtKdPengguna)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblPwd)
        Me.Controls.Add(Me.lblKdPengguna)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKdPengguna As System.Windows.Forms.Label
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents txtKdPengguna As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
