<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBooking))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblUsage = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblDeviceModel = New System.Windows.Forms.Label()
        Me.lblDeviceID = New System.Windows.Forms.Label()
        Me.lblBookDevice = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.grdDevices = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deviceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDeviceID = New System.Windows.Forms.TextBox()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        CType(Me.grdDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuNav.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(2, 495)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(1340, 109)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblUsage
        '
        Me.lblUsage.AutoSize = True
        Me.lblUsage.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsage.Location = New System.Drawing.Point(2, 243)
        Me.lblUsage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsage.Name = "lblUsage"
        Me.lblUsage.Size = New System.Drawing.Size(137, 48)
        Me.lblUsage.TabIndex = 7
        Me.lblUsage.Text = "Device"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSerialNumber.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSerialNumber.Location = New System.Drawing.Point(2, 0)
        Me.lblSerialNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(264, 79)
        Me.lblSerialNumber.TabIndex = 7
        Me.lblSerialNumber.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDescription.Location = New System.Drawing.Point(270, 2)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(1068, 55)
        Me.txtDescription.TabIndex = 11
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDeviceName.Location = New System.Drawing.Point(2, 162)
        Me.lblDeviceName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(100, 48)
        Me.lblDeviceName.TabIndex = 5
        Me.lblDeviceName.Text = "User"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUser.Location = New System.Drawing.Point(335, 164)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(252, 55)
        Me.txtUser.TabIndex = 6
        '
        'lblDeviceModel
        '
        Me.lblDeviceModel.AutoSize = True
        Me.lblDeviceModel.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDeviceModel.Location = New System.Drawing.Point(2, 81)
        Me.lblDeviceModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDeviceModel.Name = "lblDeviceModel"
        Me.lblDeviceModel.Size = New System.Drawing.Size(181, 48)
        Me.lblDeviceModel.TabIndex = 3
        Me.lblDeviceModel.Text = "End Date"
        '
        'lblDeviceID
        '
        Me.lblDeviceID.AutoSize = True
        Me.lblDeviceID.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDeviceID.Location = New System.Drawing.Point(2, 0)
        Me.lblDeviceID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDeviceID.Name = "lblDeviceID"
        Me.lblDeviceID.Size = New System.Drawing.Size(193, 48)
        Me.lblDeviceID.TabIndex = 1
        Me.lblDeviceID.Text = "Start Date"
        '
        'lblBookDevice
        '
        Me.lblBookDevice.AutoSize = True
        Me.lblBookDevice.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBookDevice.Location = New System.Drawing.Point(2, 0)
        Me.lblBookDevice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookDevice.Name = "lblBookDevice"
        Me.lblBookDevice.Size = New System.Drawing.Size(339, 57)
        Me.lblBookDevice.TabIndex = 0
        Me.lblBookDevice.Text = "Book a Device"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(335, 2)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(252, 55)
        Me.dtpStartDate.TabIndex = 2
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(335, 83)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(252, 55)
        Me.dtpEndDate.TabIndex = 4
        '
        'grdDevices
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Futura Bk BT", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grdDevices.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdDevices.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grdDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDevices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.model, Me.deviceName, Me.serialNumber})
        Me.grdDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDevices.Location = New System.Drawing.Point(672, 2)
        Me.grdDevices.Margin = New System.Windows.Forms.Padding(2)
        Me.grdDevices.Name = "grdDevices"
        Me.grdDevices.RowHeadersVisible = False
        Me.grdDevices.RowHeadersWidth = 82
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Futura Bk BT", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grdDevices.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdDevices.RowTemplate.Height = 33
        Me.grdDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDevices.Size = New System.Drawing.Size(666, 327)
        Me.grdDevices.TabIndex = 8
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
        'model
        '
        Me.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.model.HeaderText = "Model"
        Me.model.MinimumWidth = 100
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        '
        'deviceName
        '
        Me.deviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deviceName.HeaderText = "Name"
        Me.deviceName.MinimumWidth = 100
        Me.deviceName.Name = "deviceName"
        Me.deviceName.ReadOnly = True
        '
        'serialNumber
        '
        Me.serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.serialNumber.HeaderText = "Serial Number"
        Me.serialNumber.MinimumWidth = 100
        Me.serialNumber.Name = "serialNumber"
        Me.serialNumber.ReadOnly = True
        Me.serialNumber.Width = 147
        '
        'txtDeviceID
        '
        Me.txtDeviceID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDeviceID.Enabled = False
        Me.txtDeviceID.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDeviceID.Location = New System.Drawing.Point(2, 2)
        Me.txtDeviceID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDeviceID.Name = "txtDeviceID"
        Me.txtDeviceID.Size = New System.Drawing.Size(56, 55)
        Me.txtDeviceID.TabIndex = 9
        '
        'txtDeviceName
        '
        Me.txtDeviceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDeviceName.Enabled = False
        Me.txtDeviceName.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDeviceName.Location = New System.Drawing.Point(62, 2)
        Me.txtDeviceName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(265, 55)
        Me.txtDeviceName.TabIndex = 10
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
        Me.mnuNav.TabIndex = 14
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
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblBookDevice, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSubmit, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 113)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(38)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(638, 525)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1344, 606)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.grdDevices, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 77)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1340, 331)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblDeviceID, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dtpStartDate, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dtpEndDate, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblUsage, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.lblDeviceModel, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblDeviceName, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtUser, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(666, 327)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtDeviceName, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txtDeviceID, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(335, 245)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(329, 80)
        Me.TableLayoutPanel5.TabIndex = 8
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtDescription, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSerialNumber, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 412)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1340, 79)
        Me.TableLayoutPanel3.TabIndex = 15
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.tlpNav, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1420, 757)
        Me.TableLayoutPanel6.TabIndex = 16
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
        Me.tlpNav.TabIndex = 16
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
        Me.btnNavNext.TabIndex = 16
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
        Me.btnNavPrev.TabIndex = 15
        Me.btnNavPrev.UseVisualStyleBackColor = False
        '
        'frmAddBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1420, 757)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Font = New System.Drawing.Font("Futura Bk BT", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddBooking"
        Me.Text = "Add Booking"
        CType(Me.grdDevices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblUsage As Label
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDeviceName As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblDeviceModel As Label
    Friend WithEvents lblDeviceID As Label
    Friend WithEvents lblBookDevice As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents grdDevices As DataGridView
    Friend WithEvents txtDeviceID As TextBox
    Friend WithEvents txtDeviceName As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents model As DataGridViewTextBoxColumn
    Friend WithEvents deviceName As DataGridViewTextBoxColumn
    Friend WithEvents serialNumber As DataGridViewTextBoxColumn
    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents btnNavPrev As Button
    Friend WithEvents btnNavNext As Button
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
End Class
