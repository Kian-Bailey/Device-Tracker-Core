Imports System.IO

Public Class frmDevices

    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayNavItems(mnuNav)
        Dim deviceFileLength = File.ReadAllLines("devices.csv").Length
        Dim device As New Devices
        Using sr As New StreamReader("devices.csv")
            For i = 0 To deviceFileLength - 1
                Dim deviceLine As String = sr.ReadLine
                Dim splitLine As String() = deviceLine.Split(",")
                With device
                    .id = splitLine(0)
                    .deviceType = splitLine(1).Replace("&comma;", ",") 'Replaces the formatted comma to display correctly
                    .model = splitLine(2).Replace("&comma;", ",")
                    .serialNumber = splitLine(3).Replace("&comma;", ",")
                    .status = splitLine(4).Replace("&comma;", ",")
                    grdDevices.Rows.Add(.id, .deviceType, .model, .serialNumber, .status)
                End With
            Next
        End Using

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

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmAddDevices)
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