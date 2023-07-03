<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLogFile
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
        Me.SampleEntryEditListBox = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddDeleteLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SampleEntryEditListBox
        '
        Me.SampleEntryEditListBox.FormattingEnabled = True
        Me.SampleEntryEditListBox.Location = New System.Drawing.Point(12, 41)
        Me.SampleEntryEditListBox.Name = "SampleEntryEditListBox"
        Me.SampleEntryEditListBox.Size = New System.Drawing.Size(164, 303)
        Me.SampleEntryEditListBox.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(205, 150)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(205, 189)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AddDeleteLabel
        '
        Me.AddDeleteLabel.AutoSize = True
        Me.AddDeleteLabel.Location = New System.Drawing.Point(13, 13)
        Me.AddDeleteLabel.Name = "AddDeleteLabel"
        Me.AddDeleteLabel.Size = New System.Drawing.Size(121, 13)
        Me.AddDeleteLabel.TabIndex = 3
        Me.AddDeleteLabel.Text = "Pick a Sample to Delete"
        '
        'EditLogFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 359)
        Me.Controls.Add(Me.AddDeleteLabel)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SampleEntryEditListBox)
        Me.Name = "EditLogFile"
        Me.Text = "Edit Log File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleEntryEditListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents AddDeleteLabel As System.Windows.Forms.Label
End Class
