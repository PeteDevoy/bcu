<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ib_config_upload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ib_config_upload))
        Me.cb_config = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cb_config
        '
        Me.cb_config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_config.FormattingEnabled = True
        Me.cb_config.Location = New System.Drawing.Point(12, 12)
        Me.cb_config.Name = "cb_config"
        Me.cb_config.Size = New System.Drawing.Size(324, 21)
        Me.cb_config.TabIndex = 4
        '
        'ib_config_upload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 52)
        Me.Controls.Add(Me.cb_config)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ib_config_upload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Name of config file:"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_config As System.Windows.Forms.ComboBox
End Class
