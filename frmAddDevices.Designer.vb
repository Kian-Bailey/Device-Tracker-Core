<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddDevices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDevices))
        Me.lblAddDevices = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbcInputs = New System.Windows.Forms.TabControl()
        Me.tabLaptop = New System.Windows.Forms.TabPage()
        Me.dgvLaptop = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.laptopStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deviceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.processor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ram = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.screenSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabDesktop = New System.Windows.Forms.TabPage()
        Me.dgvDesktop = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabMobilePhone = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabCamera = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabTV = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isSmart = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabPrinter = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabOther = New System.Windows.Forms.TabPage()
        Me.dgvOther = New System.Windows.Forms.DataGridView()
        Me.deviceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deviceModel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.mnuNav.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tbcInputs.SuspendLayout()
        Me.tabLaptop.SuspendLayout()
        CType(Me.dgvLaptop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDesktop.SuspendLayout()
        CType(Me.dgvDesktop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMobilePhone.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCamera.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTV.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrinter.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOther.SuspendLayout()
        CType(Me.dgvOther, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblAddDevices.Size = New System.Drawing.Size(295, 75)
        Me.lblAddDevices.TabIndex = 0
        Me.lblAddDevices.Text = "Add Devices"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(2, 477)
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
        Me.TableLayoutPanel1.Controls.Add(Me.btnSubmit, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbcInputs, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 113)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(38)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(638, 525)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1344, 606)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'tbcInputs
        '
        Me.tbcInputs.Controls.Add(Me.tabLaptop)
        Me.tbcInputs.Controls.Add(Me.tabDesktop)
        Me.tbcInputs.Controls.Add(Me.tabMobilePhone)
        Me.tbcInputs.Controls.Add(Me.tabCamera)
        Me.tbcInputs.Controls.Add(Me.tabTV)
        Me.tbcInputs.Controls.Add(Me.tabPrinter)
        Me.tbcInputs.Controls.Add(Me.tabOther)
        Me.tbcInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcInputs.Font = New System.Drawing.Font("Futura Bk BT", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbcInputs.Location = New System.Drawing.Point(2, 77)
        Me.tbcInputs.Margin = New System.Windows.Forms.Padding(2)
        Me.tbcInputs.Name = "tbcInputs"
        Me.tbcInputs.SelectedIndex = 0
        Me.tbcInputs.Size = New System.Drawing.Size(1340, 396)
        Me.tbcInputs.TabIndex = 12
        '
        'tabLaptop
        '
        Me.tabLaptop.Controls.Add(Me.dgvLaptop)
        Me.tabLaptop.Location = New System.Drawing.Point(4, 35)
        Me.tabLaptop.Margin = New System.Windows.Forms.Padding(2)
        Me.tabLaptop.Name = "tabLaptop"
        Me.tabLaptop.Padding = New System.Windows.Forms.Padding(2)
        Me.tabLaptop.Size = New System.Drawing.Size(1332, 357)
        Me.tabLaptop.TabIndex = 0
        Me.tabLaptop.Text = "Laptop"
        Me.tabLaptop.UseVisualStyleBackColor = True
        '
        'dgvLaptop
        '
        Me.dgvLaptop.AllowUserToAddRows = False
        Me.dgvLaptop.AllowUserToDeleteRows = False
        Me.dgvLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaptop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.laptopStatus, Me.deviceName, Me.processor, Me.ram, Me.screenSize})
        Me.dgvLaptop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLaptop.Location = New System.Drawing.Point(2, 2)
        Me.dgvLaptop.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvLaptop.Name = "dgvLaptop"
        Me.dgvLaptop.RowHeadersVisible = False
        Me.dgvLaptop.RowHeadersWidth = 82
        Me.dgvLaptop.RowTemplate.Height = 33
        Me.dgvLaptop.Size = New System.Drawing.Size(1328, 353)
        Me.dgvLaptop.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Device Model"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 177
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 187
        '
        'laptopStatus
        '
        Me.laptopStatus.HeaderText = "Status"
        Me.laptopStatus.MinimumWidth = 10
        Me.laptopStatus.Name = "laptopStatus"
        Me.laptopStatus.Width = 200
        '
        'deviceName
        '
        Me.deviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deviceName.HeaderText = "Device Name"
        Me.deviceName.MinimumWidth = 10
        Me.deviceName.Name = "deviceName"
        Me.deviceName.Width = 177
        '
        'processor
        '
        Me.processor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.processor.HeaderText = "Processor"
        Me.processor.MinimumWidth = 10
        Me.processor.Name = "processor"
        Me.processor.Width = 140
        '
        'ram
        '
        Me.ram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ram.HeaderText = "RAM"
        Me.ram.MinimumWidth = 10
        Me.ram.Name = "ram"
        Me.ram.Width = 92
        '
        'screenSize
        '
        Me.screenSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.screenSize.HeaderText = "Screen Size"
        Me.screenSize.MinimumWidth = 10
        Me.screenSize.Name = "screenSize"
        Me.screenSize.Width = 153
        '
        'tabDesktop
        '
        Me.tabDesktop.Controls.Add(Me.dgvDesktop)
        Me.tabDesktop.Location = New System.Drawing.Point(4, 35)
        Me.tabDesktop.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDesktop.Name = "tabDesktop"
        Me.tabDesktop.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDesktop.Size = New System.Drawing.Size(1332, 357)
        Me.tabDesktop.TabIndex = 2
        Me.tabDesktop.Text = "Desktop"
        Me.tabDesktop.UseVisualStyleBackColor = True
        '
        'dgvDesktop
        '
        Me.dgvDesktop.AllowUserToAddRows = False
        Me.dgvDesktop.AllowUserToDeleteRows = False
        Me.dgvDesktop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDesktop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.dgvDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDesktop.Location = New System.Drawing.Point(2, 2)
        Me.dgvDesktop.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDesktop.Name = "dgvDesktop"
        Me.dgvDesktop.RowHeadersVisible = False
        Me.dgvDesktop.RowHeadersWidth = 82
        Me.dgvDesktop.RowTemplate.Height = 33
        Me.dgvDesktop.Size = New System.Drawing.Size(1328, 353)
        Me.dgvDesktop.TabIndex = 3
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Device Model"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 177
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 187
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Device Name"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 177
        '
        'tabMobilePhone
        '
        Me.tabMobilePhone.Controls.Add(Me.DataGridView1)
        Me.tabMobilePhone.Location = New System.Drawing.Point(4, 35)
        Me.tabMobilePhone.Margin = New System.Windows.Forms.Padding(2)
        Me.tabMobilePhone.Name = "tabMobilePhone"
        Me.tabMobilePhone.Size = New System.Drawing.Size(1332, 357)
        Me.tabMobilePhone.TabIndex = 3
        Me.tabMobilePhone.Text = "Mobile Phone"
        Me.tabMobilePhone.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1332, 357)
        Me.DataGridView1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.Frozen = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Device Model"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 162
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 171
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 200
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 177
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.HeaderText = "Camera Resolution"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 212
        '
        'tabCamera
        '
        Me.tabCamera.Controls.Add(Me.DataGridView2)
        Me.tabCamera.Location = New System.Drawing.Point(4, 35)
        Me.tabCamera.Margin = New System.Windows.Forms.Padding(2)
        Me.tabCamera.Name = "tabCamera"
        Me.tabCamera.Size = New System.Drawing.Size(1332, 357)
        Me.tabCamera.TabIndex = 4
        Me.tabCamera.Text = "Camera"
        Me.tabCamera.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 82
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(1332, 357)
        Me.DataGridView2.TabIndex = 4
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.Frozen = True
        Me.DataGridViewTextBoxColumn14.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.HeaderText = "Device Model"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 162
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 171
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 200
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.HeaderText = "Camera Resolution"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 212
        '
        'tabTV
        '
        Me.tabTV.Controls.Add(Me.DataGridView3)
        Me.tabTV.Location = New System.Drawing.Point(4, 35)
        Me.tabTV.Margin = New System.Windows.Forms.Padding(2)
        Me.tabTV.Name = "tabTV"
        Me.tabTV.Size = New System.Drawing.Size(1332, 357)
        Me.tabTV.TabIndex = 5
        Me.tabTV.Text = "TV"
        Me.tabTV.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn24, Me.isSmart})
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 82
        Me.DataGridView3.RowTemplate.Height = 33
        Me.DataGridView3.Size = New System.Drawing.Size(1332, 357)
        Me.DataGridView3.TabIndex = 4
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.Frozen = True
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 70
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.HeaderText = "Device Model"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 177
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 187
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.HeaderText = "Screen Size"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 153
        '
        'isSmart
        '
        Me.isSmart.HeaderText = "Is Smart?"
        Me.isSmart.MinimumWidth = 10
        Me.isSmart.Name = "isSmart"
        Me.isSmart.Width = 200
        '
        'tabPrinter
        '
        Me.tabPrinter.Controls.Add(Me.DataGridView4)
        Me.tabPrinter.Location = New System.Drawing.Point(4, 35)
        Me.tabPrinter.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPrinter.Name = "tabPrinter"
        Me.tabPrinter.Size = New System.Drawing.Size(1332, 357)
        Me.tabPrinter.TabIndex = 6
        Me.tabPrinter.Text = "Printer"
        Me.tabPrinter.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28})
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidth = 82
        Me.DataGridView4.RowTemplate.Height = 33
        Me.DataGridView4.Size = New System.Drawing.Size(1332, 357)
        Me.DataGridView4.TabIndex = 4
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.Frozen = True
        Me.DataGridViewTextBoxColumn22.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 70
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.HeaderText = "Device Model"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 177
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 187
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Ink Model"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 200
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn28.HeaderText = "Link to Ink"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 146
        '
        'tabOther
        '
        Me.tabOther.Controls.Add(Me.dgvOther)
        Me.tabOther.Location = New System.Drawing.Point(4, 35)
        Me.tabOther.Margin = New System.Windows.Forms.Padding(2)
        Me.tabOther.Name = "tabOther"
        Me.tabOther.Padding = New System.Windows.Forms.Padding(2)
        Me.tabOther.Size = New System.Drawing.Size(1332, 357)
        Me.tabOther.TabIndex = 1
        Me.tabOther.Text = "Other"
        Me.tabOther.UseVisualStyleBackColor = True
        '
        'dgvOther
        '
        Me.dgvOther.AllowUserToAddRows = False
        Me.dgvOther.AllowUserToDeleteRows = False
        Me.dgvOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOther.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.deviceID, Me.deviceModel, Me.serialNumber, Me.status})
        Me.dgvOther.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOther.Location = New System.Drawing.Point(2, 2)
        Me.dgvOther.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOther.Name = "dgvOther"
        Me.dgvOther.RowHeadersVisible = False
        Me.dgvOther.RowHeadersWidth = 82
        Me.dgvOther.RowTemplate.Height = 33
        Me.dgvOther.Size = New System.Drawing.Size(1328, 353)
        Me.dgvOther.TabIndex = 0
        '
        'deviceID
        '
        Me.deviceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deviceID.Frozen = True
        Me.deviceID.HeaderText = "ID"
        Me.deviceID.MinimumWidth = 10
        Me.deviceID.Name = "deviceID"
        Me.deviceID.ReadOnly = True
        Me.deviceID.Width = 70
        '
        'deviceModel
        '
        Me.deviceModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deviceModel.HeaderText = "Device Model"
        Me.deviceModel.MinimumWidth = 10
        Me.deviceModel.Name = "deviceModel"
        Me.deviceModel.Width = 177
        '
        'serialNumber
        '
        Me.serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.serialNumber.HeaderText = "Serial Number"
        Me.serialNumber.MinimumWidth = 10
        Me.serialNumber.Name = "serialNumber"
        Me.serialNumber.Width = 187
        '
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 10
        Me.status.Name = "status"
        Me.status.Width = 105
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
        Me.TableLayoutPanel3.TabIndex = 17
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
        'frmAddDevices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1420, 757)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddDevices"
        Me.Text = "Add Devices"
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tbcInputs.ResumeLayout(False)
        Me.tabLaptop.ResumeLayout(False)
        CType(Me.dgvLaptop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDesktop.ResumeLayout(False)
        CType(Me.dgvDesktop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMobilePhone.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCamera.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTV.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrinter.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOther.ResumeLayout(False)
        CType(Me.dgvOther, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAddDevices As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents btnNavPrev As Button
    Friend WithEvents btnNavNext As Button
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbcInputs As TabControl
    Friend WithEvents tabLaptop As TabPage
    Friend WithEvents tabOther As TabPage
    Friend WithEvents dgvOther As DataGridView
    Friend WithEvents dgvLaptop As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents laptopStatus As DataGridViewTextBoxColumn
    Friend WithEvents deviceName As DataGridViewTextBoxColumn
    Friend WithEvents processor As DataGridViewTextBoxColumn
    Friend WithEvents ram As DataGridViewTextBoxColumn
    Friend WithEvents screenSize As DataGridViewTextBoxColumn
    Friend WithEvents deviceID As DataGridViewTextBoxColumn
    Friend WithEvents deviceModel As DataGridViewTextBoxColumn
    Friend WithEvents serialNumber As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents tabDesktop As TabPage
    Friend WithEvents dgvDesktop As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents tabMobilePhone As TabPage
    Friend WithEvents tabCamera As TabPage
    Friend WithEvents tabTV As TabPage
    Friend WithEvents tabPrinter As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents isSmart As DataGridViewCheckBoxColumn
End Class
