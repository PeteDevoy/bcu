<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firmpick
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(firmpick))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbFirmFile = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Advanced Counting (New in 2013)", "Advanced Firmware (New in 2013)", "Advanced Software (6 Zones)", "Advanced Software (32 Zones)", "Queue Software", "Service Software (6 Zones)", "Service Software (32 Zones)", "Tilt", "Privacy", "Data Encryption", "Report Interface", "Privacy + Data Encryption", "Privacy + Report Interface", "Privacy + Data Encryption + Report Interface", "Data Encryption + Report Interface", "Path Linking", "Traffic Maps", "Path Linking + Traffic Maps", "Advanced Software (32 Zones) + All Options", "Advanced Software (32 Zones) + All Options - Path Linking"})
        Me.ComboBox1.Location = New System.Drawing.Point(-10, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(304, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'cbFirmFile
        '
        Me.cbFirmFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFirmFile.FormattingEnabled = True
        Me.cbFirmFile.Location = New System.Drawing.Point(12, 12)
        Me.cbFirmFile.Name = "cbFirmFile"
        Me.cbFirmFile.Size = New System.Drawing.Size(304, 21)
        Me.cbFirmFile.TabIndex = 2
        '
        'firmpick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 45)
        Me.Controls.Add(Me.cbFirmFile)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "firmpick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select the firmware file:"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbFirmFile As System.Windows.Forms.ComboBox
End Class
