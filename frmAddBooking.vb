Imports System.IO

Public Class frmAddBooking
    Private Sub frmAddBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayNavItems(mnuNav)
        ResetFields()
    End Sub

    Private Sub ResetFields() 'resets all input fields and loads default values
        dtpStartDate.Value = Date.Today
        dtpEndDate.Value = DateAdd("ww", 1, Date.Today)
        txtUser.Text = ""
        txtDescription.Text = ""
        txtDeviceID.Text = ""
        txtDeviceName.Text = ""
        GetDevices()
    End Sub

    Private Sub GetDevices() 'Retrieves devices and populates the grid
        grdDevices.Rows.Clear()
        If dtpStartDate.Text <> "" And dtpEndDate.Text <> "" Then 'Checks if date fields are not empty
            Dim deviceFileLength = File.ReadAllLines("devices.csv").Length
            Dim device As New Devices
            Using srDevice As New StreamReader("devices.csv")
                For d = 0 To deviceFileLength - 1 'Reads each line of devices file
                    Dim deviceLine As String = srDevice.ReadLine
                    Dim deviceSplitLine As String() = deviceLine.Split(",") 'Retrieves fields for records
                    With device
                        .status = deviceSplitLine(4)
                        If .status = "Spare" Then
                            .id = deviceSplitLine(0)
                            .deviceType = deviceSplitLine(1)
                            .model = deviceSplitLine(2)
                            .serialNumber = deviceSplitLine(3)
                            Dim bookingFileLength = File.ReadAllLines("bookings.csv").Length
                            Dim booking As New Bookings
                            Dim inUse As Boolean = False
                            Using srBooking As New StreamReader("bookings.csv")
                                For b = 0 To bookingFileLength - 1 'Checks each line of booking file
                                    Dim bookingLine As String = srBooking.ReadLine
                                    Dim bookingSplitLine As String() = bookingLine.Split(",")
                                    With booking
                                        .deviceID = bookingSplitLine(5)
                                        If device.id = .deviceID Then 'If current device ID matches device in current booking
                                            .dateStart = bookingSplitLine(1)
                                            .dateEnd = bookingSplitLine(2)
                                            Dim newDateStart As Date = dtpStartDate.Value.Date
                                            Dim newDateEnd As Date = dtpEndDate.Value.Date
                                            If Not ((newDateStart < .dateStart And newDateEnd < .dateStart) Or
                                                (newDateStart > .dateEnd And newDateEnd > .dateEnd)) Then 'Checks if device is in use during selected dates
                                                inUse = True 'Flags that device is currently being used
                                            End If
                                        End If
                                    End With
                                Next
                            End Using
                            If Not inUse Then 'Adds device details of devices that are Spare and are not in use during selected dates
                                grdDevices.Rows.Add(device.id, device.deviceType, device.model,
                                                    device.serialNumber)
                            End If
                        End If
                    End With
                Next
            End Using
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click 'When submit button is clicked
        'Check if all necessary fields are filled
        If txtUser.Text = "" Or txtDeviceID.Text = "" Or dtpStartDate.Value = Nothing Or dtpEndDate.Value = Nothing Then
            MsgBox("Error: Empty Fields." & vbCrLf &
                   "Please make sure you have entered a user and selected a device." & vbCrLf &
                   "The booking has NOT been submitted.", MsgBoxStyle.Critical, "Error")
            ResetFields()
            Exit Sub
        End If
        Dim booking As New Bookings With {
            .id = GetLastID("bookings.csv")
        }
        Dim sw As New StreamWriter("bookings.csv", True)
        With booking
            .dateStart = dtpStartDate.Value.Date
            .dateEnd = dtpEndDate.Value.Date
            .usedBy = txtUser.Text.Replace(",", "&comma;") 'Ensures that the format of the CSV functions correctly
            .description = txtDescription.Text.Replace(",", "&comma;")
            .deviceID = txtDeviceID.Text
            'Converts the fields into a formatted string
            Dim lineOutput As String = $"{ .id},{ .dateStart},{ .dateEnd},{ .usedBy },{ .description},{ .deviceID}"
            sw.WriteLine(lineOutput) 'Writes the line to the file
        End With

        MsgBox("Device Added")
        sw.Close()
        ResetFields()
    End Sub

    Private Sub grdDevices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDevices.CellContentClick
        'Gets device ID and name selected in grid
        txtDeviceID.Text = grdDevices.CurrentRow.Cells(0).Value
        txtDeviceName.Text = grdDevices.CurrentRow.Cells(2).Value
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        dateUpdated()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        dateUpdated()
    End Sub

    Private Sub dateUpdated()
        If dtpEndDate.Value.Date < dtpStartDate.Value.Date Then 'Stops end date from being before the start date
            dtpEndDate.Value = dtpStartDate.Value
            MsgBox("The booking end date msut be after the start date", vbCritical, "Error")
        End If
        grdDevices.ClearSelection()
        GetDevices()

    End Sub

    Private Sub DevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevicesToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmDevices)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmHome)
    End Sub

    Private Sub BookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingsToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmBookings)
    End Sub

    Private Sub btnNavPrev_Click(sender As Object, e As EventArgs) Handles btnNavPrev.Click
        NavigationFunctions.btnNavPrev_Click(Me)
    End Sub

    Private Sub btnNavNext_Click(sender As Object, e As EventArgs) Handles btnNavNext.Click
        NavigationFunctions.btnNavNext_Click(Me)
    End Sub

    Public Sub updateNavButtons()
        With btnNavPrev
            If navStackPrev.Count < 1 Then
                .Enabled = False
                .BackColor = Color.Gray
                navStackPrev.Clear()
            Else
                .Enabled = True
                .BackColor = Color.FromArgb(44, 158, 221)
            End If
        End With
        With btnNavNext
            If navStackNext.Count = 0 OrElse navStackNext.Peek.Name = Name Then
                .Enabled = False
                .BackColor = Color.Gray
                navStackNext.Clear()
            Else
                .Enabled = True
                .BackColor = Color.FromArgb(44, 158, 221)
            End If
        End With
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmUsers)
    End Sub
End Class