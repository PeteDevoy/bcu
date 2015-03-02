<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3_IN_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_3_IN_1))
        Me.cbFirmFile = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cbLicType = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.cbConfFile = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbFirmFile
        '
        Me.cbFirmFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFirmFile.FormattingEnabled = True
        Me.cbFirmFile.Location = New System.Drawing.Point(136, 39)
        Me.cbFirmFile.Name = "cbFirmFile"
        Me.cbFirmFile.Size = New System.Drawing.Size(296, 21)
        Me.cbFirmFile.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Firmware File:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(72, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "License Type:"
        '
        'cbLicType
        '
        Me.cbLicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLicType.FormattingEnabled = True
        Me.cbLicType.Items.AddRange(New Object() {"Advanced Counting (New in 2013)", "Advanced Firmware (New in 2013)", "Advanced Software (6 Zones)", "Advanced Software (32 Zones)", "Queue Software", "Service Software (6 Zones)", "Service Software (32 Zones)", "Tilt", "Privacy", "Data Encryption", "Report Interface", "Privacy + Data Encryption", "Privacy + Report Interface", "Privacy + Data Encryption + Report Interface", "Data Encryption + Report Interface", "Path Linking", "Traffic Maps", "Path Linking + Traffic Maps", "Advanced Software (32 Zones) + All Options", "Advanced Software (32 Zones) + All Options - Path Linking"})
        Me.cbLicType.Location = New System.Drawing.Point(136, 95)
        Me.cbLicType.Name = "cbLicType"
        Me.cbLicType.Size = New System.Drawing.Size(296, 21)
        Me.cbLicType.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(72, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "Config File:"
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(171, 197)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(102, 36)
        Me.submit.TabIndex = 6
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'cbConfFile
        '
        Me.cbConfFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConfFile.FormattingEnabled = True
        Me.cbConfFile.Location = New System.Drawing.Point(136, 154)
        Me.cbConfFile.Name = "cbConfFile"
        Me.cbConfFile.Size = New System.Drawing.Size(296, 21)
        Me.cbConfFile.TabIndex = 7
        '
        '_3_IN_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 245)
        Me.Controls.Add(Me.cbConfFile)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.cbLicType)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbFirmFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_3_IN_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Multi-Camera 3-IN-1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbFirmFile As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cbLicType As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents cbConfFile As System.Windows.Forms.ComboBox
End Class
