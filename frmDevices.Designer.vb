<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDevices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevices))
        Me.btnAddDevice = New System.Windows.Forms.Button()
        Me.grdDevices = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deviceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDevices = New System.Windows.Forms.Label()
        CType(Me.grdDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuNav.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddDevice
        '
        Me.btnAddDevice.AutoSize = True
        Me.btnAddDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAddDevice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDevice.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddDevice.ForeColor = System.Drawing.Color.White
        Me.btnAddDevice.Location = New System.Drawing.Point(150, 546)
        Me.btnAddDevice.Margin = New System.Windows.Forms.Padding(112, 38, 112, 38)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(1120, 74)
        Me.btnAddDevice.TabIndex = 1
        Me.btnAddDevice.Text = "Add Device"
        Me.btnAddDevice.UseVisualStyleBackColor = False
        '
        'grdDevices
        '
        Me.grdDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdDevices.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Futura Bk BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDevices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDevices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.deviceType, Me.model, Me.serialNumber, Me.status})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Futura Bk BT", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDevices.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDevices.Location = New System.Drawing.Point(40, 152)
        Me.grdDevices.Margin = New System.Windows.Forms.Padding(2)
        Me.grdDevices.Name = "grdDevices"
        Me.grdDevices.RowHeadersVisible = False
        Me.grdDevices.RowHeadersWidth = 82
        Me.grdDevices.RowTemplate.Height = 33
        Me.grdDevices.Size = New System.Drawing.Size(1340, 354)
        Me.grdDevices.TabIndex = 2
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
        'deviceType
        '
        Me.deviceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deviceType.HeaderText = "Device Type"
        Me.deviceType.MinimumWidth = 10
        Me.deviceType.Name = "deviceType"
        Me.deviceType.ReadOnly = True
        Me.deviceType.Width = 245
        '
        'model
        '
        Me.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.model.HeaderText = "Model"
        Me.model.MinimumWidth = 100
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        Me.model.Width = 154
        '
        'serialNumber
        '
        Me.serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.serialNumber.HeaderText = "Serial Number"
        Me.serialNumber.MinimumWidth = 100
        Me.serialNumber.Name = "serialNumber"
        Me.serialNumber.ReadOnly = True
        Me.serialNumber.Width = 287
        '
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 10
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 147
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
        Me.mnuNav.Size = New System.Drawing.Size(1195, 70)
        Me.mnuNav.TabIndex = 3
        Me.mnuNav.Text = "Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(84, 66)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(112, 66)
        Me.BookingsToolStripMenuItem.Text = "Bookings"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DevicesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(97, 66)
        Me.DevicesToolStripMenuItem.Text = "Devices"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(79, 66)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'tlpNav
        '
        Me.tlpNav.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tlpNav.ColumnCount = 4
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpNav.Controls.Add(Me.btnNavPrev, 0, 0)
        Me.tlpNav.Controls.Add(Me.mnuNav, 2, 0)
        Me.tlpNav.Controls.Add(Me.Button3, 3, 0)
        Me.tlpNav.Controls.Add(Me.btnNavNext, 1, 0)
        Me.tlpNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpNav.Location = New System.Drawing.Point(0, 0)
        Me.tlpNav.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpNav.Name = "tlpNav"
        Me.tlpNav.RowCount = 1
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.Size = New System.Drawing.Size(1420, 70)
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
        Me.btnNavPrev.Location = New System.Drawing.Point(2, 2)
        Me.btnNavPrev.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(71, 66)
        Me.btnNavPrev.TabIndex = 0
        Me.btnNavPrev.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(1347, 2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 66)
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
        Me.btnNavNext.Size = New System.Drawing.Size(71, 66)
        Me.btnNavNext.TabIndex = 1
        Me.btnNavNext.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnAddDevice, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.grdDevices, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblDevices, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 70)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(38)
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1420, 696)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'lblDevices
        '
        Me.lblDevices.AutoSize = True
        Me.lblDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevices.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDevices.ForeColor = System.Drawing.Color.Black
        Me.lblDevices.Location = New System.Drawing.Point(53, 53)
        Me.lblDevices.Margin = New System.Windows.Forms.Padding(15)
        Me.lblDevices.Name = "lblDevices"
        Me.lblDevices.Size = New System.Drawing.Size(1314, 82)
        Me.lblDevices.TabIndex = 0
        Me.lblDevices.Text = "Devices"
        Me.lblDevices.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmDevices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1420, 766)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.tlpNav)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuNav
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(816, 822)
        Me.Name = "frmDevices"
        Me.Text = "Devices"
        CType(Me.grdDevices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddDevice As Button
    Friend WithEvents grdDevices As DataGridView
    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnNavNext As Button
    Friend WithEvents btnNavPrev As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblDevices As Label
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents deviceType As DataGridViewTextBoxColumn
    Friend WithEvents model As DataGridViewTextBoxColumn
    Friend WithEvents serialNumber As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
