Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmAddUsers

    Private Sub frmAddDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayNavItems(mnuNav)
        resetFields()
    End Sub

    Private Sub resetFields() 'resets all input fields and loads default values
        txtUserID.Text = GetLastID("users.csv")
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtName.Text = ""
        txtRole.Text = ""
        chkIsAdmin.Checked = False
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Check if all necessary fields are filled
        If txtUserID.Text = "" Or txtEmail.Text = "" Or txtPassword.Text = "" Or txtName.Text = "" Then
            MsgBox("Error: Empty Fields." & vbCrLf &
                   "Please make sure you have filled in all of the fields" & vbCrLf &
                   "The device has NOT been saved.", MsgBoxStyle.Critical, "Error")
            resetFields()
            Exit Sub
        End If
        Dim user As New Users
        Dim sw As New StreamWriter("users.csv", True)
        With user
            .id = txtUserID.Text
            .email = txtEmail.Text.ToLower.Replace(",", "&comma;") 'Ensures that the format of the CSV functions correctly
            .password = txtPassword.Text.Replace(",", "&comma;")
            .name = txtName.Text.Replace(",", "&comma;")
            .role = txtRole.Text.Replace(",", "&comma;")
            .isAdmin = chkIsAdmin.Checked
            user = encryptUserFields(user)
            'Converts the fields into a formatted string
            Dim lineOutput As String = $"{ .id },{ .encryptionKeyString },{ .email },{ .password },{ .name},{ .role},{ .isAdmin}"
            sw.WriteLine(lineOutput) 'Writes the line to the file
        End With


        MsgBox("User Added")
        sw.Close()
        resetFields()
    End Sub

    Private Function encryptUserFields(user As Users)
        With user
            Dim encryptionKeyString As String = createEncryptionKey(.id)
            Dim wrapper As New Simple3Des(encryptionKeyString)
            .email = wrapper.EncryptData(.email).Replace(",", "&comma;")
            .password = wrapper.EncryptData(.password).Replace(",", "&comma;")
            .name = wrapper.EncryptData(.name).Replace(",", "&comma;")
            .role = wrapper.EncryptData(.role).Replace(",", "&comma;")
            .isAdmin = wrapper.EncryptData(.isAdmin).Replace(",", "&comma;")
            user.encryptionKeyString = encryptionKeyString.Replace(",", "&comma;")
        End With
        Return user
    End Function
    Private Function createEncryptionKey(id As Integer)
        Dim saltBytes = New Byte(id) {}

        Using saltProvider = New RNGCryptoServiceProvider()
            saltProvider.GetNonZeroBytes(saltBytes)
        End Using
        Return Convert.ToBase64String(saltBytes)

    End Function

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmUsers)
    End Sub
End Class