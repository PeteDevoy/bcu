<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ibCase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ibCase))
        Me.tbCase = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbCase
        '
        Me.tbCase.AcceptsReturn = True
        Me.tbCase.AcceptsTab = True
        Me.tbCase.Location = New System.Drawing.Point(12, 12)
        Me.tbCase.Name = "tbCase"
        Me.tbCase.Size = New System.Drawing.Size(198, 20)
        Me.tbCase.TabIndex = 0
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(74, 38)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 1
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'ibCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 69)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.tbCase)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ibCase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter the Case #"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCase As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
End Class
