Imports System.IO
Imports System.Security.Cryptography

Public Class frmUsers
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayNavItems(mnuNav)
        Dim userFileLength = File.ReadAllLines("users.csv").Length
        Dim user As New Users
        Using sr As New StreamReader("users.csv")
            For i = 0 To userFileLength - 1
                Dim userLine As String = sr.ReadLine
                Dim splitLine As String() = userLine.Split(",")
                With user
                    .id = splitLine(0)
                    .encryptionKeyString = splitLine(1).Replace("&comma;", ",") 'Replaces the formatted comma to display correctly

                    Dim encryptionKey As New Simple3Des(.encryptionKeyString)
                    .email = encryptionKey.DecryptData(splitLine(2).Replace("&comma;", ","))
                    .password = encryptionKey.DecryptData(splitLine(3).Replace("&comma;", ","))
                    .name = encryptionKey.DecryptData(splitLine(4).Replace("&comma;", ","))
                    .role = encryptionKey.DecryptData(splitLine(5).Replace("&comma;", ","))
                    .isAdmin = encryptionKey.DecryptData(splitLine(6).Replace("&comma;", ","))
                    Dim permissionLevelString As String
                    Select Case .isAdmin
                        Case True
                            permissionLevelString = "Admin"
                        Case Else
                            permissionLevelString = "User"
                    End Select
                    grdUsers.Rows.Add(.id, .email, .name, .role, permissionLevelString)
                End With
            Next
        End Using
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

    Private Sub btnNavPrev_Click(sender As Object, e As EventArgs) Handles btnNavPrev.Click
        NavigationFunctions.btnNavPrev_Click(Me)
    End Sub

    Private Sub btnNavNext_Click(sender As Object, e As EventArgs) Handles btnNavNext.Click
        NavigationFunctions.btnNavNext_Click(Me)
    End Sub

    Private Sub BookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingsToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmBookings)
    End Sub

    Private Sub DevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevicesToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmDevices)
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmAddUsers)
    End Sub
End Class