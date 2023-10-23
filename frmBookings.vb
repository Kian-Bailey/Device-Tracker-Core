Imports System.IO

Public Class frmBookings
    Private Sub btnAddBooking_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmAddBooking)
    End Sub

    Private Sub frmBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayNavItems(mnuNav)
        Dim deviceFileLength = File.ReadAllLines("bookings.csv").Length
        Dim booking As New Bookings
        Using sr As New StreamReader("bookings.csv")
            For i = 0 To deviceFileLength - 1
                Dim deviceLine As String = sr.ReadLine
                Dim splitLine As String() = deviceLine.Split(",")
                With booking
                    .id = splitLine(0)
                    .dateStart = splitLine(1)
                    .dateEnd = splitLine(2)
                    .usedBy = splitLine(3).Replace("&comma;", ",") 'Replaces the formatted comma to display correctly
                    .description = splitLine(4).Replace("&comma;", ",")
                    .deviceID = splitLine(5)
                    grdBookings.Rows.Add(.id, .dateStart.ToShortDateString, .dateEnd.ToShortDateString, .usedBy, .description, .deviceID)
                End With
            Next
        End Using
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmHome)
    End Sub

    Private Sub DevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevicesToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmDevices)
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