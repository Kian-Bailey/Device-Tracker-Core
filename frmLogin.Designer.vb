<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.tlpMain.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.txtPassword, 0, 2)
        Me.tlpMain.Controls.Add(Me.btnLogin, 0, 3)
        Me.tlpMain.Controls.Add(Me.txtEmail, 0, 1)
        Me.tlpMain.Controls.Add(Me.picLogo, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.MaximumSize = New System.Drawing.Size(1600, 1600)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.Padding = New System.Windows.Forms.Padding(50)
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpMain.Size = New System.Drawing.Size(578, 844)
        Me.tlpMain.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Font = New System.Drawing.Font("Futura Bk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(100, 490)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(50)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(378, 36)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Enter Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(100, 644)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(50)
        Me.btnLogin.MinimumSize = New System.Drawing.Size(150, 100)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(378, 100)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Font = New System.Drawing.Font("Futura Bk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(100, 318)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(50)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(378, 36)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.Text = "Enter Email Address"
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(53, 53)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(472, 194)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 844)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Futura Bk BT", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1600, 1600)
        Me.MinimumSize = New System.Drawing.Size(600, 900)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents btnLogin As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
