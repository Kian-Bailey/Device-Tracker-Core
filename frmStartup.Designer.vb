<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStartup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartup))
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLoading
        '
        Me.lblLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoading.Font = New System.Drawing.Font("Futura Bk BT", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(0, 0)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(900, 450)
        Me.lblLoading.TabIndex = 0
        Me.lblLoading.Text = "Loading..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStartup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.lblLoading)
        Me.Font = New System.Drawing.Font("Futura Bk BT", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(48, 23, 48, 23)
        Me.Name = "frmStartup"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLoading As Label
End Class
