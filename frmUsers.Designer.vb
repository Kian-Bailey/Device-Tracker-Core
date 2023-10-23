<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.grdUsers = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameOfUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.mnuNav.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuNav
        '
        Me.mnuNav.BackColor = System.Drawing.Color.Transparent
        Me.mnuNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnuNav.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mnuNav.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BookingsToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.mnuNav.Location = New System.Drawing.Point(200, 0)
        Me.mnuNav.Name = "mnuNav"
        Me.mnuNav.Size = New System.Drawing.Size(1588, 94)
        Me.mnuNav.TabIndex = 3
        Me.mnuNav.Text = "mnuNav"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(84, 90)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(112, 90)
        Me.BookingsToolStripMenuItem.Text = "Bookings"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(97, 90)
        Me.DevicesToolStripMenuItem.Text = "Devices"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(79, 90)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Futura Bk BT", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1791, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 88)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tlpNav
        '
        Me.tlpNav.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tlpNav.ColumnCount = 4
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpNav.Controls.Add(Me.btnNavPrev, 0, 0)
        Me.tlpNav.Controls.Add(Me.Button3, 3, 0)
        Me.tlpNav.Controls.Add(Me.mnuNav, 2, 0)
        Me.tlpNav.Controls.Add(Me.btnNavNext, 1, 0)
        Me.tlpNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNav.Location = New System.Drawing.Point(3, 3)
        Me.tlpNav.Name = "tlpNav"
        Me.tlpNav.RowCount = 1
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.Size = New System.Drawing.Size(1888, 94)
        Me.tlpNav.TabIndex = 0
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
        Me.btnNavPrev.Location = New System.Drawing.Point(3, 3)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(94, 88)
        Me.btnNavPrev.TabIndex = 0
        Me.btnNavPrev.UseVisualStyleBackColor = False
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
        Me.btnNavNext.Location = New System.Drawing.Point(103, 3)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(94, 88)
        Me.btnNavNext.TabIndex = 1
        Me.btnNavNext.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.tlpNav, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1894, 1009)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblUsers, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grdUsers, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddUser, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 150)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(50)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1794, 809)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsers.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUsers.ForeColor = System.Drawing.Color.Black
        Me.lblUsers.Location = New System.Drawing.Point(20, 20)
        Me.lblUsers.Margin = New System.Windows.Forms.Padding(20)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(1754, 110)
        Me.lblUsers.TabIndex = 0
        Me.lblUsers.Text = "Users"
        Me.lblUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grdUsers
        '
        Me.grdUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.email, Me.nameOfUser, Me.role, Me.permission})
        Me.grdUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdUsers.Location = New System.Drawing.Point(3, 153)
        Me.grdUsers.Name = "grdUsers"
        Me.grdUsers.RowHeadersVisible = False
        Me.grdUsers.RowHeadersWidth = 82
        Me.grdUsers.RowTemplate.Height = 33
        Me.grdUsers.Size = New System.Drawing.Size(1788, 453)
        Me.grdUsers.TabIndex = 2
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.Frozen = True
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 50
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 61
        '
        'email
        '
        Me.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.email.HeaderText = "Email Address"
        Me.email.MinimumWidth = 10
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 134
        '
        'nameOfUser
        '
        Me.nameOfUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.nameOfUser.HeaderText = "Name"
        Me.nameOfUser.MinimumWidth = 10
        Me.nameOfUser.Name = "nameOfUser"
        Me.nameOfUser.ReadOnly = True
        Me.nameOfUser.Width = 88
        '
        'role
        '
        Me.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.role.HeaderText = "Role"
        Me.role.MinimumWidth = 10
        Me.role.Name = "role"
        Me.role.ReadOnly = True
        Me.role.Width = 75
        '
        'permission
        '
        Me.permission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.permission.HeaderText = "Permission Level"
        Me.permission.MinimumWidth = 10
        Me.permission.Name = "permission"
        Me.permission.ReadOnly = True
        Me.permission.Width = 147
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAddUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(150, 659)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(150, 50, 150, 50)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(1494, 100)
        Me.btnAddUser.TabIndex = 1
        Me.btnAddUser.Text = "Add a User"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Futura Bk BT", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 350)
        Me.Name = "frmUsers"
        Me.Text = "Users"
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents btnNavNext As Button
    Friend WithEvents btnNavPrev As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblUsers As Label
    Friend WithEvents grdUsers As DataGridView
    Friend WithEvents btnAddUser As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents nameOfUser As DataGridViewTextBoxColumn
    Friend WithEvents role As DataGridViewTextBoxColumn
    Friend WithEvents permission As DataGridViewTextBoxColumn
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
End Class
