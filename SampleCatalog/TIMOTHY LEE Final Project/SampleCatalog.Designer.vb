<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleCatalog
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
        Me.MenuItems = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLogFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LogFileListBox = New System.Windows.Forms.ListBox()
        Me.LogFileLabel = New System.Windows.Forms.Label()
        Me.DisplayLogFileButton = New System.Windows.Forms.Button()
        Me.EditLogFileButton = New System.Windows.Forms.Button()
        Me.AddLogFileButton = New System.Windows.Forms.Button()
        Me.DeleteLogFileButton = New System.Windows.Forms.Button()
        Me.AddLogFileOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenLogFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuItems.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuItems
        '
        Me.MenuItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuItems.Location = New System.Drawing.Point(0, 0)
        Me.MenuItems.Name = "MenuItems"
        Me.MenuItems.Size = New System.Drawing.Size(405, 24)
        Me.MenuItems.TabIndex = 0
        Me.MenuItems.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenLogFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(31, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenLogFileToolStripMenuItem
        '
        Me.OpenLogFileToolStripMenuItem.Name = "OpenLogFileToolStripMenuItem"
        Me.OpenLogFileToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.OpenLogFileToolStripMenuItem.Text = "Open Log File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.ContactToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 326)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(405, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'LogFileListBox
        '
        Me.LogFileListBox.FormattingEnabled = True
        Me.LogFileListBox.Location = New System.Drawing.Point(12, 50)
        Me.LogFileListBox.Name = "LogFileListBox"
        Me.LogFileListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LogFileListBox.Size = New System.Drawing.Size(381, 147)
        Me.LogFileListBox.TabIndex = 2
        '
        'LogFileLabel
        '
        Me.LogFileLabel.AutoSize = True
        Me.LogFileLabel.Location = New System.Drawing.Point(12, 34)
        Me.LogFileLabel.Name = "LogFileLabel"
        Me.LogFileLabel.Size = New System.Drawing.Size(140, 13)
        Me.LogFileLabel.TabIndex = 3
        Me.LogFileLabel.Text = "Pick a Log File From the List"
        '
        'DisplayLogFileButton
        '
        Me.DisplayLogFileButton.Location = New System.Drawing.Point(54, 238)
        Me.DisplayLogFileButton.Name = "DisplayLogFileButton"
        Me.DisplayLogFileButton.Size = New System.Drawing.Size(98, 23)
        Me.DisplayLogFileButton.TabIndex = 4
        Me.DisplayLogFileButton.Text = "Display Log File"
        Me.DisplayLogFileButton.UseVisualStyleBackColor = True
        '
        'EditLogFileButton
        '
        Me.EditLogFileButton.Location = New System.Drawing.Point(54, 268)
        Me.EditLogFileButton.Name = "EditLogFileButton"
        Me.EditLogFileButton.Size = New System.Drawing.Size(98, 23)
        Me.EditLogFileButton.TabIndex = 5
        Me.EditLogFileButton.Text = "Edit Log File"
        Me.EditLogFileButton.UseVisualStyleBackColor = True
        '
        'AddLogFileButton
        '
        Me.AddLogFileButton.Location = New System.Drawing.Point(204, 238)
        Me.AddLogFileButton.Name = "AddLogFileButton"
        Me.AddLogFileButton.Size = New System.Drawing.Size(98, 23)
        Me.AddLogFileButton.TabIndex = 6
        Me.AddLogFileButton.Text = "Add Log File"
        Me.AddLogFileButton.UseVisualStyleBackColor = True
        '
        'DeleteLogFileButton
        '
        Me.DeleteLogFileButton.Location = New System.Drawing.Point(204, 268)
        Me.DeleteLogFileButton.Name = "DeleteLogFileButton"
        Me.DeleteLogFileButton.Size = New System.Drawing.Size(98, 23)
        Me.DeleteLogFileButton.TabIndex = 7
        Me.DeleteLogFileButton.Text = "Delete Log File"
        Me.DeleteLogFileButton.UseVisualStyleBackColor = True
        '
        'AddLogFileOpenDialog
        '
        Me.AddLogFileOpenDialog.FileName = "AddLogFileOpenDialog"
        '
        'OpenLogFileDialog
        '
        Me.OpenLogFileDialog.FileName = "OpenLogFileDialog"
        '
        'SampleCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 348)
        Me.Controls.Add(Me.DeleteLogFileButton)
        Me.Controls.Add(Me.AddLogFileButton)
        Me.Controls.Add(Me.EditLogFileButton)
        Me.Controls.Add(Me.DisplayLogFileButton)
        Me.Controls.Add(Me.LogFileLabel)
        Me.Controls.Add(Me.LogFileListBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuItems)
        Me.MainMenuStrip = Me.MenuItems
        Me.Name = "SampleCatalog"
        Me.Text = "Sample Catalog"
        Me.MenuItems.ResumeLayout(False)
        Me.MenuItems.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuItems As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LogFileListBox As System.Windows.Forms.ListBox
    Friend WithEvents LogFileLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayLogFileButton As System.Windows.Forms.Button
    Friend WithEvents EditLogFileButton As System.Windows.Forms.Button
    Friend WithEvents AddLogFileButton As System.Windows.Forms.Button
    Friend WithEvents DeleteLogFileButton As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLogFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddLogFileOpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenLogFileDialog As System.Windows.Forms.OpenFileDialog

End Class
