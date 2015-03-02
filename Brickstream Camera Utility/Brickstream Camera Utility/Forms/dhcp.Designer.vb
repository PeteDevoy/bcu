<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dhcp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dhcp))
        Me.dhcp_start = New System.Windows.Forms.Button()
        Me.dhcp_stop = New System.Windows.Forms.Button()
        Me.dhcpifier = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCounts = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dhcp_start
        '
        Me.dhcp_start.Location = New System.Drawing.Point(12, 14)
        Me.dhcp_start.Name = "dhcp_start"
        Me.dhcp_start.Size = New System.Drawing.Size(109, 50)
        Me.dhcp_start.TabIndex = 0
        Me.dhcp_start.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DHCPifier"
        Me.dhcp_start.UseVisualStyleBackColor = True
        '
        'dhcp_stop
        '
        Me.dhcp_stop.Location = New System.Drawing.Point(158, 14)
        Me.dhcp_stop.Name = "dhcp_stop"
        Me.dhcp_stop.Size = New System.Drawing.Size(109, 50)
        Me.dhcp_stop.TabIndex = 1
        Me.dhcp_stop.Text = "Stop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DHCPifier"
        Me.dhcp_stop.UseVisualStyleBackColor = True
        '
        'dhcpifier
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cameras DHCP'd:"
        '
        'lblCounts
        '
        Me.lblCounts.AutoSize = True
        Me.lblCounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounts.Location = New System.Drawing.Point(194, 73)
        Me.lblCounts.Name = "lblCounts"
        Me.lblCounts.Size = New System.Drawing.Size(35, 37)
        Me.lblCounts.TabIndex = 3
        Me.lblCounts.Text = "0"
        '
        'dhcp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 125)
        Me.Controls.Add(Me.lblCounts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dhcp_stop)
        Me.Controls.Add(Me.dhcp_start)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dhcp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DHCPifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dhcp_start As System.Windows.Forms.Button
    Friend WithEvents dhcp_stop As System.Windows.Forms.Button
    Friend WithEvents dhcpifier As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCounts As System.Windows.Forms.Label
End Class
