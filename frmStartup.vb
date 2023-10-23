Imports System.IO

Public Class frmStartup
    Private Sub frmStartup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isUserAdmin = True
        Dim filePaths As String() = {
            "bookings.csv",
            "devices.csv",
            "users.csv"
        }

        For Each filePath In filePaths
            If Not File.Exists(filePath) Then
                Dim fileStream As FileStream = File.Create(filePath)
                fileStream.Close()
            End If
        Next
        frmLogin.Show()
        Close()


    End Sub


End Class