<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUsers))
        Me.lblAddDevices = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblIsAdmin = New System.Windows.Forms.Label()
        Me.chkIsAdmin = New System.Windows.Forms.CheckBox()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.mnuNav.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddDevices
        '
        Me.lblAddDevices.AutoSize = True
        Me.lblAddDevices.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAddDevices.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddDevices.Location = New System.Drawing.Point(2, 0)
        Me.lblAddDevices.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddDevices.Name = "lblAddDevices"
        Me.lblAddDevices.Size = New System.Drawing.Size(249, 75)
        Me.lblAddDevices.TabIndex = 0
        Me.lblAddDevices.Text = "Add Users"
        '
        'txtUserID
        '
        Me.txtUserID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUserID.Enabled = False
        Me.txtUserID.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUserID.Location = New System.Drawing.Point(672, 2)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(666, 55)
        Me.txtUserID.TabIndex = 2
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUserID.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUserID.Location = New System.Drawing.Point(2, 0)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(666, 68)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "User ID"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmail.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEmail.Location = New System.Drawing.Point(2, 68)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(666, 68)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(672, 70)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(666, 55)
        Me.txtEmail.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPassword.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(672, 138)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(666, 55)
        Me.txtPassword.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPassword.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.Location = New System.Drawing.Point(2, 136)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(666, 68)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(672, 206)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(666, 55)
        Me.txtName.TabIndex = 8
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(2, 204)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(666, 68)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRole.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRole.Location = New System.Drawing.Point(2, 272)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(666, 68)
        Me.lblRole.TabIndex = 9
        Me.lblRole.Text = "Role"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(2, 492)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(1340, 112)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'mnuNav
        '
        Me.mnuNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnuNav.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mnuNav.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BookingsToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.mnuNav.Location = New System.Drawing.Point(150, 0)
        Me.mnuNav.Name = "mnuNav"
        Me.mnuNav.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuNav.Size = New System.Drawing.Size(1191, 71)
        Me.mnuNav.TabIndex = 15
        Me.mnuNav.Text = "Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(84, 67)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(112, 67)
        Me.BookingsToolStripMenuItem.Text = "Bookings"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(97, 67)
        Me.DevicesToolStripMenuItem.Text = "Devices"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(79, 67)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblAddDevices, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSubmit, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 113)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(38)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(638, 525)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1344, 606)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblIsAdmin, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblUserID, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblEmail, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPassword, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtName, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblRole, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPassword, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblName, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEmail, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtUserID, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkIsAdmin, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtRole, 1, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 77)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1340, 411)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblIsAdmin
        '
        Me.lblIsAdmin.AutoSize = True
        Me.lblIsAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIsAdmin.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIsAdmin.Location = New System.Drawing.Point(2, 340)
        Me.lblIsAdmin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIsAdmin.Name = "lblIsAdmin"
        Me.lblIsAdmin.Size = New System.Drawing.Size(666, 71)
        Me.lblIsAdmin.TabIndex = 11
        Me.lblIsAdmin.Text = "Is Admin?"
        '
        'chkIsAdmin
        '
        Me.chkIsAdmin.AutoSize = True
        Me.chkIsAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkIsAdmin.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkIsAdmin.Location = New System.Drawing.Point(672, 342)
        Me.chkIsAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.chkIsAdmin.Name = "chkIsAdmin"
        Me.chkIsAdmin.Size = New System.Drawing.Size(666, 67)
        Me.chkIsAdmin.TabIndex = 12
        Me.chkIsAdmin.UseVisualStyleBackColor = True
        '
        'txtRole
        '
        Me.txtRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRole.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRole.Location = New System.Drawing.Point(672, 274)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(666, 55)
        Me.txtRole.TabIndex = 13
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tlpNav, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1420, 757)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'tlpNav
        '
        Me.tlpNav.ColumnCount = 4
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.Controls.Add(Me.btnNavNext, 1, 0)
        Me.tlpNav.Controls.Add(Me.btnNavPrev, 0, 0)
        Me.tlpNav.Controls.Add(Me.mnuNav, 2, 0)
        Me.tlpNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNav.Location = New System.Drawing.Point(2, 2)
        Me.tlpNav.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpNav.Name = "tlpNav"
        Me.tlpNav.RowCount = 1
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.Size = New System.Drawing.Size(1416, 71)
        Me.tlpNav.TabIndex = 0
        '
        'btnNavNext
        '
        Me.btnNavNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnNavNext.BackgroundImage = CType(resources.GetObject("btnNavNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNavNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNavNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNavNext.FlatAppearance.BorderSize = 0
        Me.btnNavNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavNext.Font = New System.Drawing.Font("Futura Bk BT", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNavNext.ForeColor = System.Drawing.Color.White
        Me.btnNavNext.Location = New System.Drawing.Point(77, 2)
        Me.btnNavNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(71, 67)
        Me.btnNavNext.TabIndex = 17
        Me.btnNavNext.UseVisualStyleBackColor = False
        '
        'btnNavPrev
        '
        Me.btnNavPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnNavPrev.BackgroundImage = CType(resources.GetObject("btnNavPrev.BackgroundImage"), System.Drawing.Image)
        Me.btnNavPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNavPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNavPrev.FlatAppearance.BorderSize = 0
        Me.btnNavPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPrev.Font = New System.Drawing.Font("Futura Bk BT", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNavPrev.ForeColor = System.Drawing.Color.White
        Me.btnNavPrev.Location = New System.Drawing.Point(2, 2)
        Me.btnNavPrev.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(71, 67)
        Me.btnNavPrev.TabIndex = 16
        Me.btnNavPrev.UseVisualStyleBackColor = False
        '
        'frmAddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1420, 757)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddUsers"
        Me.Text = "Add Users"
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNavPrev As Button
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents btnNavNext As Button
    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblAddDevices As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblIsAdmin As Label
    Friend WithEvents chkIsAdmin As CheckBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
End Class
