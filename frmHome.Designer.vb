<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDevices = New System.Windows.Forms.Button()
        Me.btnBookings = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.tlpMain.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.mnuNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 3
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpMain.Controls.Add(Me.btnDevices, 1, 1)
        Me.tlpMain.Controls.Add(Me.btnBookings, 0, 1)
        Me.tlpMain.Controls.Add(Me.btnUsers, 2, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.Padding = New System.Windows.Forms.Padding(100)
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1894, 1009)
        Me.tlpMain.TabIndex = 2
        '
        'btnDevices
        '
        Me.btnDevices.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevices.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDevices.ForeColor = System.Drawing.Color.White
        Me.btnDevices.Location = New System.Drawing.Point(684, 374)
        Me.btnDevices.Margin = New System.Windows.Forms.Padding(20)
        Me.btnDevices.Name = "btnDevices"
        Me.btnDevices.Size = New System.Drawing.Size(524, 260)
        Me.btnDevices.TabIndex = 1
        Me.btnDevices.Text = "Devices"
        Me.btnDevices.UseVisualStyleBackColor = False
        '
        'btnBookings
        '
        Me.btnBookings.AutoSize = True
        Me.btnBookings.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnBookings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookings.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBookings.ForeColor = System.Drawing.Color.White
        Me.btnBookings.Location = New System.Drawing.Point(120, 374)
        Me.btnBookings.Margin = New System.Windows.Forms.Padding(20)
        Me.btnBookings.Name = "btnBookings"
        Me.btnBookings.Size = New System.Drawing.Size(524, 260)
        Me.btnBookings.TabIndex = 0
        Me.btnBookings.Text = "Bookings"
        Me.btnBookings.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(1248, 374)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(20)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(526, 260)
        Me.btnUsers.TabIndex = 2
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = False
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
        Me.tlpNav.Controls.Add(Me.mnuNav, 2, 0)
        Me.tlpNav.Controls.Add(Me.Button3, 3, 0)
        Me.tlpNav.Controls.Add(Me.btnNavNext, 1, 0)
        Me.tlpNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpNav.Location = New System.Drawing.Point(0, 0)
        Me.tlpNav.Name = "tlpNav"
        Me.tlpNav.RowCount = 1
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.Size = New System.Drawing.Size(1894, 94)
        Me.tlpNav.TabIndex = 3
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
        'mnuNav
        '
        Me.mnuNav.BackColor = System.Drawing.Color.Transparent
        Me.mnuNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnuNav.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mnuNav.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BookingsToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.mnuNav.Location = New System.Drawing.Point(200, 0)
        Me.mnuNav.Name = "mnuNav"
        Me.mnuNav.Size = New System.Drawing.Size(1594, 94)
        Me.mnuNav.TabIndex = 3
        Me.mnuNav.Text = "Menu"
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
        Me.DevicesToolStripMenuItem.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.Button3.Location = New System.Drawing.Point(1797, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 88)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
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
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.tlpNav)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Futura Bk BT", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1300, 600)
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnDevices As Button
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents btnNavPrev As Button
    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents btnNavNext As Button
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUsers As Button
End Class
