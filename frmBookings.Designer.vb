<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookings))
        Me.grdBookings = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deviceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBookings = New System.Windows.Forms.Label()
        Me.btnAddBooking = New System.Windows.Forms.Button()
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        CType(Me.grdBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuNav.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdBookings
        '
        Me.grdBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Futura Bk BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBookings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBookings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dateStart, Me.dateEnd, Me.usedBy, Me.description, Me.deviceID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Futura Bk BT", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdBookings.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdBookings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdBookings.Location = New System.Drawing.Point(2, 114)
        Me.grdBookings.Margin = New System.Windows.Forms.Padding(2)
        Me.grdBookings.Name = "grdBookings"
        Me.grdBookings.RowHeadersVisible = False
        Me.grdBookings.RowHeadersWidth = 82
        Me.grdBookings.RowTemplate.Height = 33
        Me.grdBookings.Size = New System.Drawing.Size(1340, 349)
        Me.grdBookings.TabIndex = 2
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.Frozen = True
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 50
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 90
        '
        'dateStart
        '
        Me.dateStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dateStart.HeaderText = "Start Date"
        Me.dateStart.MinimumWidth = 100
        Me.dateStart.Name = "dateStart"
        Me.dateStart.ReadOnly = True
        Me.dateStart.Width = 210
        '
        'dateEnd
        '
        Me.dateEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dateEnd.HeaderText = "End Date"
        Me.dateEnd.MinimumWidth = 100
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.ReadOnly = True
        Me.dateEnd.Width = 200
        '
        'usedBy
        '
        Me.usedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.usedBy.HeaderText = "Used By"
        Me.usedBy.MinimumWidth = 100
        Me.usedBy.Name = "usedBy"
        Me.usedBy.ReadOnly = True
        Me.usedBy.Width = 183
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.description.HeaderText = "Description"
        Me.description.MinimumWidth = 100
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Width = 232
        '
        'deviceID
        '
        Me.deviceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deviceID.HeaderText = "Device ID"
        Me.deviceID.MinimumWidth = 100
        Me.deviceID.Name = "deviceID"
        Me.deviceID.ReadOnly = True
        Me.deviceID.Width = 206
        '
        'lblBookings
        '
        Me.lblBookings.AutoSize = True
        Me.lblBookings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBookings.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBookings.ForeColor = System.Drawing.Color.Black
        Me.lblBookings.Location = New System.Drawing.Point(15, 15)
        Me.lblBookings.Margin = New System.Windows.Forms.Padding(15)
        Me.lblBookings.Name = "lblBookings"
        Me.lblBookings.Size = New System.Drawing.Size(1314, 82)
        Me.lblBookings.TabIndex = 0
        Me.lblBookings.Text = "Bookings"
        Me.lblBookings.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAddBooking
        '
        Me.btnAddBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAddBooking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBooking.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddBooking.ForeColor = System.Drawing.Color.White
        Me.btnAddBooking.Location = New System.Drawing.Point(112, 503)
        Me.btnAddBooking.Margin = New System.Windows.Forms.Padding(112, 38, 112, 38)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(1120, 74)
        Me.btnAddBooking.TabIndex = 1
        Me.btnAddBooking.Text = "Book a Device"
        Me.btnAddBooking.UseVisualStyleBackColor = False
        '
        'mnuNav
        '
        Me.mnuNav.BackColor = System.Drawing.Color.Transparent
        Me.mnuNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnuNav.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mnuNav.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BookingsToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.mnuNav.Location = New System.Drawing.Point(150, 0)
        Me.mnuNav.Name = "mnuNav"
        Me.mnuNav.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuNav.Size = New System.Drawing.Size(1191, 71)
        Me.mnuNav.TabIndex = 3
        Me.mnuNav.Text = "mnuNav"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(84, 67)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(112, 67)
        Me.BookingsToolStripMenuItem.Text = "Bookings"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(97, 67)
        Me.DevicesToolStripMenuItem.Text = "Devices"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(79, 67)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblBookings, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grdBookings, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddBooking, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 113)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(38)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1344, 615)
        Me.TableLayoutPanel1.TabIndex = 5
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
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1420, 766)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'tlpNav
        '
        Me.tlpNav.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tlpNav.ColumnCount = 4
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.Controls.Add(Me.mnuNav)
        Me.tlpNav.Controls.Add(Me.Button3)
        Me.tlpNav.Controls.Add(Me.btnNavNext, 1, 0)
        Me.tlpNav.Controls.Add(Me.btnNavPrev, 0, 0)
        Me.tlpNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNav.Location = New System.Drawing.Point(2, 2)
        Me.tlpNav.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpNav.Name = "tlpNav"
        Me.tlpNav.RowCount = 1
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.Size = New System.Drawing.Size(1416, 71)
        Me.tlpNav.TabIndex = 0
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
        Me.Button3.Location = New System.Drawing.Point(1343, 2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 67)
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
        Me.btnNavNext.Location = New System.Drawing.Point(77, 2)
        Me.btnNavNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(71, 67)
        Me.btnNavNext.TabIndex = 1
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
        Me.btnNavPrev.TabIndex = 0
        Me.btnNavPrev.UseVisualStyleBackColor = False
        '
        'frmBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1420, 766)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuNav
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(816, 822)
        Me.Name = "frmBookings"
        Me.Text = "Bookings"
        CType(Me.grdBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdBookings As DataGridView
    Friend WithEvents lblBookings As Label
    Friend WithEvents btnAddBooking As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents dateStart As DataGridViewTextBoxColumn
    Friend WithEvents dateEnd As DataGridViewTextBoxColumn
    Friend WithEvents usedBy As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents deviceID As DataGridViewTextBoxColumn
    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents btnNavPrev As Button
    Friend WithEvents btnNavNext As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
End Class
