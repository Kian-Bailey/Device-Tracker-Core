Imports System.IO
Imports System.Security.Cryptography

Public Class frmLogin


    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        inputGotFocus(txtEmail)
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        inputLostFocus(txtEmail)
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        inputGotFocus(txtPassword)
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        inputLostFocus(txtPassword)
    End Sub

    Private Sub inputLostFocus(textboxControl As TextBox)
        With textboxControl
            If .Text = "" Then
                .ForeColor = Color.Gray
                Select Case .Name
                    Case "txtEmail"
                        .Text = "Enter Email Address"
                    Case "txtPassword"
                        .Text = "Enter Password"
                        .UseSystemPasswordChar = True
                End Select
            End If
        End With
    End Sub

    Private Sub inputGotFocus(textboxControl As TextBox)
        With textboxControl
            If (.Name = "txtEmail" And .Text = "Enter Email Address") Or (.Name = "txtPassword" And .Text = "Enter Password") Then
                .Text = ""
                .ForeColor = Color.Black
                If .Name = "txtPassword" Then .UseSystemPasswordChar = False
            End If
        End With
    End Sub

    Private Sub inputTextbox_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged, txtPassword.TextChanged
        With btnLogin
            If txtEmail.Text <> "" And txtEmail.Text <> "Enter Email Address" And txtPassword.Text <> "" And txtPassword.Text <> "Enter Password" Then
                .Enabled = True
                .BackColor = Color.FromArgb(44, 158, 221)
            Else
                .Enabled = False
                .BackColor = Color.Gray
            End If
        End With
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userFileLength = File.ReadAllLines("users.csv").Length
        Dim user As New Users
        Using sr As New StreamReader("users.csv")
            For i = 0 To userFileLength - 1
                Dim userLine As String = sr.ReadLine
                Dim splitLine As String() = userLine.Split(",")
                With user
                    .id = splitLine(0)
                    .encryptionKeyString = splitLine(1).Replace("&comma;", ",")
                    Dim encryptionKey As New Simple3Des(.encryptionKeyString)
                    Dim inputEmailEncrypted = encryptionKey.EncryptData(txtEmail.Text.ToLower).Replace(",", "&comma;")
                    Dim inputPasswordEncrypted = encryptionKey.EncryptData(txtPassword.Text).Replace(",", "&comma;")
                    .email = splitLine(2)
                    .password = splitLine(3)
                    If inputEmailEncrypted = .email And inputPasswordEncrypted = .password Then
                        userName = encryptionKey.DecryptData(splitLine(4).Replace("&comma;", ","))
                        isUserAdmin = Convert.ToBoolean(encryptionKey.DecryptData(splitLine(6).Replace("&comma;", ",")))
                        'Launch application in maximized state if screen width is not greater than 1080px
                        With frmHome
                            If Screen.PrimaryScreen.Bounds.Height > 1080 Then
                                .Width = Screen.PrimaryScreen.Bounds.Width * 0.75
                                .Height = Screen.PrimaryScreen.Bounds.Height * 0.75
                                .WindowState = FormWindowState.Normal
                            Else
                                .WindowState = FormWindowState.Maximized
                            End If
                            .updateNavButtons()
                            .Show()
                        End With

                        Close()
                        Exit Sub
                    End If
                End With
            Next
        End Using
        MsgBox("Email or password is incorrect")
    End Sub


End Class