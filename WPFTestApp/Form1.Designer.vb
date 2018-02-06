<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnShowDefaultOutlookProfile = New System.Windows.Forms.Button()
        Me.btnSetSlowKeyboard = New System.Windows.Forms.Button()
        Me.btnSetNormalKeyboard = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShowDefaultOutlookProfile
        '
        Me.btnShowDefaultOutlookProfile.Location = New System.Drawing.Point(82, 30)
        Me.btnShowDefaultOutlookProfile.Name = "btnShowDefaultOutlookProfile"
        Me.btnShowDefaultOutlookProfile.Size = New System.Drawing.Size(222, 36)
        Me.btnShowDefaultOutlookProfile.TabIndex = 0
        Me.btnShowDefaultOutlookProfile.Text = "Show Default Outlook Profile"
        Me.btnShowDefaultOutlookProfile.UseVisualStyleBackColor = True
        '
        'btnSetSlowKeyboard
        '
        Me.btnSetSlowKeyboard.Location = New System.Drawing.Point(82, 85)
        Me.btnSetSlowKeyboard.Name = "btnSetSlowKeyboard"
        Me.btnSetSlowKeyboard.Size = New System.Drawing.Size(222, 32)
        Me.btnSetSlowKeyboard.TabIndex = 2
        Me.btnSetSlowKeyboard.Text = "Set Slow Keyboard"
        Me.btnSetSlowKeyboard.UseVisualStyleBackColor = True
        '
        'btnSetNormalKeyboard
        '
        Me.btnSetNormalKeyboard.Location = New System.Drawing.Point(82, 135)
        Me.btnSetNormalKeyboard.Name = "btnSetNormalKeyboard"
        Me.btnSetNormalKeyboard.Size = New System.Drawing.Size(222, 37)
        Me.btnSetNormalKeyboard.TabIndex = 3
        Me.btnSetNormalKeyboard.Text = "Set Normal Keyboard"
        Me.btnSetNormalKeyboard.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(383, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 244)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSetNormalKeyboard)
        Me.Controls.Add(Me.btnSetSlowKeyboard)
        Me.Controls.Add(Me.btnShowDefaultOutlookProfile)
        Me.Name = "Form1"
        Me.Text = "Outlook Test"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowDefaultOutlookProfile As Button
    Friend WithEvents btnSetSlowKeyboard As Button
    Friend WithEvents btnSetNormalKeyboard As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
