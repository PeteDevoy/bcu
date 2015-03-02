<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoggerTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.txtLogViewer = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerboseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLogViewer
        '
        Me.txtLogViewer.BackColor = System.Drawing.Color.Black
        Me.txtLogViewer.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtLogViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLogViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogViewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtLogViewer.Location = New System.Drawing.Point(0, 0)
        Me.txtLogViewer.MaxLength = 999999999
        Me.txtLogViewer.Multiline = True
        Me.txtLogViewer.Name = "txtLogViewer"
        Me.txtLogViewer.ReadOnly = True
        Me.txtLogViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogViewer.Size = New System.Drawing.Size(575, 199)
        Me.txtLogViewer.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.CopyToolStripMenuItem, Me.ToolStripMenuItem1, Me.ErrorToolStripMenuItem, Me.WarningToolStripMenuItem, Me.InfoToolStripMenuItem, Me.DebugToolStripMenuItem, Me.VerboseToolStripMenuItem, Me.ToolStripMenuItem2, Me.ClearAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 192)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 6)
        '
        'ErrorToolStripMenuItem
        '
        Me.ErrorToolStripMenuItem.Checked = True
        Me.ErrorToolStripMenuItem.CheckOnClick = True
        Me.ErrorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ErrorToolStripMenuItem.Name = "ErrorToolStripMenuItem"
        Me.ErrorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ErrorToolStripMenuItem.Text = "Error"
        '
        'WarningToolStripMenuItem
        '
        Me.WarningToolStripMenuItem.Checked = True
        Me.WarningToolStripMenuItem.CheckOnClick = True
        Me.WarningToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WarningToolStripMenuItem.Name = "WarningToolStripMenuItem"
        Me.WarningToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.WarningToolStripMenuItem.Text = "Warning"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Checked = True
        Me.InfoToolStripMenuItem.CheckOnClick = True
        Me.InfoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.CheckOnClick = True
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'VerboseToolStripMenuItem
        '
        Me.VerboseToolStripMenuItem.CheckOnClick = True
        Me.VerboseToolStripMenuItem.Name = "VerboseToolStripMenuItem"
        Me.VerboseToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VerboseToolStripMenuItem.Text = "Verbose"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(161, 6)
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'LoggerTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtLogViewer)
        Me.Name = "LoggerTextBox"
        Me.Size = New System.Drawing.Size(575, 199)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogViewer As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WarningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerboseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
