<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.single_cam = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.single_leg_firm = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.single_leg_license = New System.Windows.Forms.Button()
        Me.leg_configurator = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.multi_cam = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.mutli_leg_firm = New System.Windows.Forms.Button()
        Me.multi_leg_config = New System.Windows.Forms.Button()
        Me.multi_leg_license = New System.Windows.Forms.Button()
        Me.leg_3n1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.live_3n1 = New System.Windows.Forms.Button()
        Me.utils = New System.Windows.Forms.TabPage()
        Me.leg_dhcp = New System.Windows.Forms.Button()
        Me.leg_static = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LoggerTextBox2 = New Brickstream_Camera_Utility.LoggerTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCameraUtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.leg_staticBW = New System.ComponentModel.BackgroundWorker()
        Me.leg_multi_licenseBW = New System.ComponentModel.BackgroundWorker()
        Me.leg_multi_config_uploadBW = New System.ComponentModel.BackgroundWorker()
        Me.leg_multi_firm_uploadBW = New System.ComponentModel.BackgroundWorker()
        Me.leg_3n1BW = New System.ComponentModel.BackgroundWorker()
        Me.leg_3n1_firmcheck = New System.ComponentModel.BackgroundWorker()
        Me.leg_single_firm_uploadBW = New System.ComponentModel.BackgroundWorker()
        Me.fw_recheckBW = New System.ComponentModel.BackgroundWorker()
        Me.LoggerTextBox1 = New Brickstream_Camera_Utility.LoggerTextBox()
        Me.leg_single_config_upload = New System.ComponentModel.BackgroundWorker()
        Me.leg_single_license = New System.ComponentModel.BackgroundWorker()
        Me.leg_single_configurator = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.single_cam.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.multi_cam.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.utils.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.single_cam)
        Me.TabControl1.Controls.Add(Me.multi_cam)
        Me.TabControl1.Controls.Add(Me.utils)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(40, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(506, 136)
        Me.TabControl1.TabIndex = 3
        '
        'single_cam
        '
        Me.single_cam.BackColor = System.Drawing.Color.White
        Me.single_cam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.single_cam.Controls.Add(Me.FlowLayoutPanel1)
        Me.single_cam.Location = New System.Drawing.Point(4, 22)
        Me.single_cam.Name = "single_cam"
        Me.single_cam.Size = New System.Drawing.Size(498, 110)
        Me.single_cam.TabIndex = 1
        Me.single_cam.Text = "Single Camera Functions"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.single_leg_firm)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.single_leg_license)
        Me.FlowLayoutPanel1.Controls.Add(Me.leg_configurator)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button12)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button10)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button11)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button9)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(498, 110)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'single_leg_firm
        '
        Me.single_leg_firm.AllowDrop = True
        Me.single_leg_firm.Location = New System.Drawing.Point(3, 3)
        Me.single_leg_firm.Name = "single_leg_firm"
        Me.single_leg_firm.Size = New System.Drawing.Size(118, 49)
        Me.single_leg_firm.TabIndex = 0
        Me.single_leg_firm.Text = "Legacy Firmware Upgrade"
        Me.single_leg_firm.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(127, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Legacy Config Upload"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'single_leg_license
        '
        Me.single_leg_license.Location = New System.Drawing.Point(251, 3)
        Me.single_leg_license.Name = "single_leg_license"
        Me.single_leg_license.Size = New System.Drawing.Size(118, 49)
        Me.single_leg_license.TabIndex = 1
        Me.single_leg_license.Text = "Legacy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Licensing"
        Me.single_leg_license.UseVisualStyleBackColor = True
        '
        'leg_configurator
        '
        Me.leg_configurator.Location = New System.Drawing.Point(375, 3)
        Me.leg_configurator.Name = "leg_configurator"
        Me.leg_configurator.Size = New System.Drawing.Size(118, 49)
        Me.leg_configurator.TabIndex = 3
        Me.leg_configurator.Text = "Legacy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Configurator"
        Me.leg_configurator.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(3, 58)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(118, 49)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = "Live Firmware Upgrade"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(127, 58)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(118, 49)
        Me.Button10.TabIndex = 6
        Me.Button10.Text = "Live Config" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Upload"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(251, 58)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(118, 49)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "Live" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Licensing"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(375, 58)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(118, 49)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "Live" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Configurator"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'multi_cam
        '
        Me.multi_cam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.multi_cam.Controls.Add(Me.FlowLayoutPanel2)
        Me.multi_cam.Location = New System.Drawing.Point(4, 22)
        Me.multi_cam.Name = "multi_cam"
        Me.multi_cam.Size = New System.Drawing.Size(498, 110)
        Me.multi_cam.TabIndex = 2
        Me.multi_cam.Text = "Multi Camera Functions"
        Me.multi_cam.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.mutli_leg_firm)
        Me.FlowLayoutPanel2.Controls.Add(Me.multi_leg_config)
        Me.FlowLayoutPanel2.Controls.Add(Me.multi_leg_license)
        Me.FlowLayoutPanel2.Controls.Add(Me.leg_3n1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button7)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button8)
        Me.FlowLayoutPanel2.Controls.Add(Me.live_3n1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(498, 110)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'mutli_leg_firm
        '
        Me.mutli_leg_firm.Location = New System.Drawing.Point(3, 3)
        Me.mutli_leg_firm.Name = "mutli_leg_firm"
        Me.mutli_leg_firm.Size = New System.Drawing.Size(118, 49)
        Me.mutli_leg_firm.TabIndex = 9
        Me.mutli_leg_firm.Text = "Legacy Firmware Upgrade"
        Me.mutli_leg_firm.UseVisualStyleBackColor = True
        '
        'multi_leg_config
        '
        Me.multi_leg_config.Location = New System.Drawing.Point(127, 3)
        Me.multi_leg_config.Name = "multi_leg_config"
        Me.multi_leg_config.Size = New System.Drawing.Size(118, 49)
        Me.multi_leg_config.TabIndex = 11
        Me.multi_leg_config.Text = "Legacy Config Upload"
        Me.multi_leg_config.UseVisualStyleBackColor = True
        '
        'multi_leg_license
        '
        Me.multi_leg_license.Location = New System.Drawing.Point(251, 3)
        Me.multi_leg_license.Name = "multi_leg_license"
        Me.multi_leg_license.Size = New System.Drawing.Size(118, 49)
        Me.multi_leg_license.TabIndex = 8
        Me.multi_leg_license.Text = "Legacy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Licensing"
        Me.multi_leg_license.UseVisualStyleBackColor = True
        '
        'leg_3n1
        '
        Me.leg_3n1.Location = New System.Drawing.Point(375, 3)
        Me.leg_3n1.Name = "leg_3n1"
        Me.leg_3n1.Size = New System.Drawing.Size(118, 49)
        Me.leg_3n1.TabIndex = 16
        Me.leg_3n1.Text = "Legacy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3-IN-1"
        Me.leg_3n1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(3, 58)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(118, 49)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Live Firmware Upgrade"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(127, 58)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 49)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Live Config" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Upload"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(251, 58)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(118, 49)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Live" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Licensing"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'live_3n1
        '
        Me.live_3n1.Location = New System.Drawing.Point(375, 58)
        Me.live_3n1.Name = "live_3n1"
        Me.live_3n1.Size = New System.Drawing.Size(118, 49)
        Me.live_3n1.TabIndex = 17
        Me.live_3n1.Text = "Live" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3-IN-1"
        Me.live_3n1.UseVisualStyleBackColor = True
        '
        'utils
        '
        Me.utils.Controls.Add(Me.leg_dhcp)
        Me.utils.Controls.Add(Me.leg_static)
        Me.utils.Location = New System.Drawing.Point(4, 22)
        Me.utils.Name = "utils"
        Me.utils.Padding = New System.Windows.Forms.Padding(3)
        Me.utils.Size = New System.Drawing.Size(498, 110)
        Me.utils.TabIndex = 3
        Me.utils.Text = "Utilities"
        Me.utils.UseVisualStyleBackColor = True
        '
        'leg_dhcp
        '
        Me.leg_dhcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leg_dhcp.Location = New System.Drawing.Point(70, 9)
        Me.leg_dhcp.Name = "leg_dhcp"
        Me.leg_dhcp.Size = New System.Drawing.Size(155, 98)
        Me.leg_dhcp.TabIndex = 11
        Me.leg_dhcp.Text = "DHCPifier"
        Me.leg_dhcp.UseVisualStyleBackColor = True
        '
        'leg_static
        '
        Me.leg_static.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leg_static.Location = New System.Drawing.Point(271, 9)
        Me.leg_static.Name = "leg_static"
        Me.leg_static.Size = New System.Drawing.Size(158, 98)
        Me.leg_static.TabIndex = 12
        Me.leg_static.Text = "STATICifier"
        Me.leg_static.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox3.Location = New System.Drawing.Point(0, 735)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(586, 13)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "Brickstream Camera Utility powered by TSC"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 137)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(40, 10, 40, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LoggerTextBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(586, 598)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 7
        '
        'LoggerTextBox2
        '
        Me.LoggerTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoggerTextBox2.Location = New System.Drawing.Point(0, 0)
        Me.LoggerTextBox2.Name = "LoggerTextBox2"
        Me.LoggerTextBox2.Size = New System.Drawing.Size(586, 438)
        Me.LoggerTextBox2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 137)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Brickstream Camera Utility"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Brickstream_Camera_Utility.My.Resources.Resources.telaid1
        Me.PictureBox2.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 45)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Brickstream_Camera_Utility.My.Resources.Resources.TSC
        Me.PictureBox1.Location = New System.Drawing.Point(483, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutCameraUtilityToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutCameraUtilityToolStripMenuItem
        '
        Me.AboutCameraUtilityToolStripMenuItem.Name = "AboutCameraUtilityToolStripMenuItem"
        Me.AboutCameraUtilityToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AboutCameraUtilityToolStripMenuItem.Text = "About Camera Utility"
        '
        'leg_staticBW
        '
        '
        'leg_multi_licenseBW
        '
        '
        'leg_multi_config_uploadBW
        '
        '
        'leg_multi_firm_uploadBW
        '
        '
        'leg_3n1BW
        '
        '
        'leg_single_firm_uploadBW
        '
        '
        'LoggerTextBox1
        '
        Me.LoggerTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoggerTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.LoggerTextBox1.Name = "LoggerTextBox1"
        Me.LoggerTextBox1.Size = New System.Drawing.Size(760, 441)
        Me.LoggerTextBox1.TabIndex = 0
        '
        'leg_single_config_upload
        '
        '
        'leg_single_license
        '
        '
        'leg_single_configurator
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(586, 748)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brickstream Camera Utility powered by TSC"
        Me.TabControl1.ResumeLayout(False)
        Me.single_cam.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.multi_cam.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.utils.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents single_cam As System.Windows.Forms.TabPage
    Friend WithEvents multi_cam As System.Windows.Forms.TabPage
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents single_leg_firm As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents leg_configurator As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents single_leg_license As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents multi_leg_config As System.Windows.Forms.Button
    Friend WithEvents mutli_leg_firm As System.Windows.Forms.Button
    Friend WithEvents multi_leg_license As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutCameraUtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoggerTextBox1 As Brickstream_Camera_Utility.LoggerTextBox
    Friend WithEvents utils As System.Windows.Forms.TabPage
    Friend WithEvents leg_static As System.Windows.Forms.Button
    Friend WithEvents leg_dhcp As System.Windows.Forms.Button
    Friend WithEvents LoggerTextBox2 As Brickstream_Camera_Utility.LoggerTextBox
    Friend WithEvents leg_staticBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents leg_multi_licenseBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents leg_multi_config_uploadBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents leg_multi_firm_uploadBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents leg_3n1 As System.Windows.Forms.Button
    Friend WithEvents live_3n1 As System.Windows.Forms.Button
    Friend WithEvents leg_3n1BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents leg_3n1_firmcheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents leg_single_firm_uploadBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents fw_recheckBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents leg_single_config_upload As System.ComponentModel.BackgroundWorker
    Friend WithEvents leg_single_license As System.ComponentModel.BackgroundWorker
    Friend WithEvents leg_single_configurator As System.ComponentModel.BackgroundWorker

End Class
