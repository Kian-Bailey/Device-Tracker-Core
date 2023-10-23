Imports System.IO

Public Class frmAddDevices
    Private Sub tbcInputs_TabIndexChanged(sender As Object, e As EventArgs) Handles tbcInputs.TabIndexChanged

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim activeDGV As DataGridView = (tbcInputs.SelectedTab.Controls.OfType(Of DataGridView))(0)
        Dim lineOutput As String
        With activeDGV.Rows(0)
            Dim id As Integer = .Cells(0).Value
            Dim model As String = .Cells(1).Value.ToString
            Dim serialNumber As String = .Cells(2).Value.ToString
            Dim status As String = .Cells(3).Value.ToString
            If model = "" Or serialNumber = "" Or status = "" Then
                MsgBox("Error: Empty Fields." & vbCrLf &
                   "Please make sure you have filled in the device model, serial number and status" & vbCrLf &
                           "The device has NOT been saved.", MsgBoxStyle.Critical, "Error")
                resetFields()
                Exit Sub
            End If
            Select Case tbcInputs.SelectedTab.Text
                Case "Laptop"
                    Dim laptop As New Laptops
                    lineOutput = laptop.setLineOutput(id, model, serialNumber, status, .Cells("deviceName").Value.ToString, .Cells("processor").Value.ToString, .Cells("ram").Value.ToString, .Cells("screenSize").Value.ToString)
                Case "Desktop"
                    Dim desktop As New Desktops
                    lineOutput = desktop.setLineOutput(id, model, serialNumber, .Cells(3).Value.ToString)
                Case "Camera"
                    Dim camera As New Cameras
                    lineOutput = camera.setLineOutput(id, model, serialNumber, status, .Cells(4).Value.ToString)
                Case "Mobile Phone"
                    Dim mobilePhone As New MobilePhones
                    lineOutput = mobilePhone.setLineOutput(id, model, serialNumber, status, .Cells(4).Value.ToString, .Cells(5).Value.ToString)
                Case "TV"
                    Dim tv As New Televisions
                    tv.isSmart = CBool(.Cells(4).Value)
                    lineOutput = tv.setLineOutput(id, model, serialNumber, .Cells(3).Value.ToString, tv.isSmart)
                Case "Printer"
                    Dim printer As New Printers
                    lineOutput = printer.setLineOutput(id, model, serialNumber, .Cells(3).Value.ToString, .Cells(4).Value.ToString)
                Case Else
                    Dim device As New Devices
                    lineOutput = device.setLineOutput(id, model, serialNumber, status)
            End Select
        End With
        Dim sw As New StreamWriter("devices.csv", True)

        sw.WriteLine(lineOutput) 'Writes the line to the file
        MsgBox("Device Added")
        sw.Close()
        resetFields()
    End Sub

    Private Sub frmAddDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayNavItems(mnuNav)
        resetFields()
    End Sub

    Private Sub resetFields() 'resets all input fields and loads default values
        For Each tabPage As TabPage In tbcInputs.Controls.OfType(Of TabPage)
            For Each inputGrid As DataGridView In tabPage.Controls.OfType(Of DataGridView)
                inputGrid.Rows.Clear()
                inputGrid.Rows.Add(GetLastID("devices.csv"))
            Next
        Next
    End Sub

    Private Sub DevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevicesToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        loadNewForm(Me, frmDevices)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        loadNewForm(Me, frmHome)
    End Sub

    Private Sub BookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingsToolStripMenuItem.Click
        navStackPrev.Push([GetType])
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