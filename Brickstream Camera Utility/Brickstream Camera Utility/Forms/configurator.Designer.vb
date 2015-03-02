<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configurator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configurator))
        Me.dhcp_yes = New System.Windows.Forms.RadioButton()
        Me.dhcp_no = New System.Windows.Forms.RadioButton()
        Me.hostname = New System.Windows.Forms.TextBox()
        Me.ip_address = New System.Windows.Forms.TextBox()
        Me.subnet_mask = New System.Windows.Forms.TextBox()
        Me.gateway = New System.Windows.Forms.TextBox()
        Me.dns = New System.Windows.Forms.TextBox()
        Me.site_id = New System.Windows.Forms.TextBox()
        Me.site_name = New System.Windows.Forms.TextBox()
        Me.dev_id = New System.Windows.Forms.TextBox()
        Me.dev_name = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dhcp_yes
        '
        Me.dhcp_yes.AutoSize = True
        Me.dhcp_yes.Location = New System.Drawing.Point(213, 21)
        Me.dhcp_yes.Name = "dhcp_yes"
        Me.dhcp_yes.Size = New System.Drawing.Size(43, 17)
        Me.dhcp_yes.TabIndex = 1
        Me.dhcp_yes.Text = "Yes"
        Me.dhcp_yes.UseVisualStyleBackColor = True
        '
        'dhcp_no
        '
        Me.dhcp_no.AutoSize = True
        Me.dhcp_no.Checked = True
        Me.dhcp_no.Location = New System.Drawing.Point(137, 21)
        Me.dhcp_no.Name = "dhcp_no"
        Me.dhcp_no.Size = New System.Drawing.Size(39, 17)
        Me.dhcp_no.TabIndex = 2
        Me.dhcp_no.TabStop = True
        Me.dhcp_no.Text = "No"
        Me.dhcp_no.UseVisualStyleBackColor = True
        '
        'hostname
        '
        Me.hostname.Location = New System.Drawing.Point(137, 44)
        Me.hostname.Name = "hostname"
        Me.hostname.Size = New System.Drawing.Size(151, 20)
        Me.hostname.TabIndex = 4
        '
        'ip_address
        '
        Me.ip_address.Location = New System.Drawing.Point(137, 71)
        Me.ip_address.Name = "ip_address"
        Me.ip_address.Size = New System.Drawing.Size(151, 20)
        Me.ip_address.TabIndex = 6
        '
        'subnet_mask
        '
        Me.subnet_mask.Location = New System.Drawing.Point(137, 96)
        Me.subnet_mask.Name = "subnet_mask"
        Me.subnet_mask.Size = New System.Drawing.Size(151, 20)
        Me.subnet_mask.TabIndex = 8
        '
        'gateway
        '
        Me.gateway.Location = New System.Drawing.Point(137, 121)
        Me.gateway.Name = "gateway"
        Me.gateway.Size = New System.Drawing.Size(151, 20)
        Me.gateway.TabIndex = 10
        '
        'dns
        '
        Me.dns.Location = New System.Drawing.Point(137, 146)
        Me.dns.Name = "dns"
        Me.dns.Size = New System.Drawing.Size(151, 20)
        Me.dns.TabIndex = 12
        '
        'site_id
        '
        Me.site_id.Location = New System.Drawing.Point(137, 171)
        Me.site_id.Name = "site_id"
        Me.site_id.Size = New System.Drawing.Size(151, 20)
        Me.site_id.TabIndex = 14
        '
        'site_name
        '
        Me.site_name.Location = New System.Drawing.Point(137, 196)
        Me.site_name.Name = "site_name"
        Me.site_name.Size = New System.Drawing.Size(151, 20)
        Me.site_name.TabIndex = 16
        '
        'dev_id
        '
        Me.dev_id.Location = New System.Drawing.Point(137, 221)
        Me.dev_id.Name = "dev_id"
        Me.dev_id.Size = New System.Drawing.Size(151, 20)
        Me.dev_id.TabIndex = 18
        '
        'dev_name
        '
        Me.dev_name.Location = New System.Drawing.Point(137, 248)
        Me.dev_name.Name = "dev_name"
        Me.dev_name.Size = New System.Drawing.Size(151, 20)
        Me.dev_name.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "DHCP?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Hostname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "IP Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Subnet Mask"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Gateway"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "DNS Server"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Site ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Site Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Device ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Device Name"
        '
        'configurator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 340)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dev_name)
        Me.Controls.Add(Me.dev_id)
        Me.Controls.Add(Me.site_name)
        Me.Controls.Add(Me.site_id)
        Me.Controls.Add(Me.dns)
        Me.Controls.Add(Me.gateway)
        Me.Controls.Add(Me.subnet_mask)
        Me.Controls.Add(Me.ip_address)
        Me.Controls.Add(Me.hostname)
        Me.Controls.Add(Me.dhcp_no)
        Me.Controls.Add(Me.dhcp_yes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "configurator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Configuration Info:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dhcp_yes As System.Windows.Forms.RadioButton
    Friend WithEvents dhcp_no As System.Windows.Forms.RadioButton
    Friend WithEvents hostname As System.Windows.Forms.TextBox
    Friend WithEvents ip_address As System.Windows.Forms.TextBox
    Friend WithEvents subnet_mask As System.Windows.Forms.TextBox
    Friend WithEvents gateway As System.Windows.Forms.TextBox
    Friend WithEvents dns As System.Windows.Forms.TextBox
    Friend WithEvents site_id As System.Windows.Forms.TextBox
    Friend WithEvents site_name As System.Windows.Forms.TextBox
    Friend WithEvents dev_id As System.Windows.Forms.TextBox
    Friend WithEvents dev_name As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
