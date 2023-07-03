<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayLogEntry
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
        Me.SampleLabel = New System.Windows.Forms.Label()
        Me.SampleEntryListBox = New System.Windows.Forms.ListBox()
        Me.PickSampleLabel = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SampleLabel
        '
        Me.SampleLabel.AutoSize = True
        Me.SampleLabel.Location = New System.Drawing.Point(12, 32)
        Me.SampleLabel.Name = "SampleLabel"
        Me.SampleLabel.Size = New System.Drawing.Size(88, 13)
        Me.SampleLabel.TabIndex = 0
        Me.SampleLabel.Text = "Sample Entry List"
        '
        'SampleEntryListBox
        '
        Me.SampleEntryListBox.FormattingEnabled = True
        Me.SampleEntryListBox.Location = New System.Drawing.Point(12, 58)
        Me.SampleEntryListBox.Name = "SampleEntryListBox"
        Me.SampleEntryListBox.Size = New System.Drawing.Size(171, 264)
        Me.SampleEntryListBox.TabIndex = 1
        '
        'PickSampleLabel
        '
        Me.PickSampleLabel.AutoSize = True
        Me.PickSampleLabel.Location = New System.Drawing.Point(219, 81)
        Me.PickSampleLabel.Name = "PickSampleLabel"
        Me.PickSampleLabel.Size = New System.Drawing.Size(162, 13)
        Me.PickSampleLabel.TabIndex = 2
        Me.PickSampleLabel.Text = "Pick a Sample and Click Display."
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(252, 142)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(75, 23)
        Me.DisplayButton.TabIndex = 3
        Me.DisplayButton.Text = "Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'DisplayLogEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 344)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.PickSampleLabel)
        Me.Controls.Add(Me.SampleEntryListBox)
        Me.Controls.Add(Me.SampleLabel)
        Me.Name = "DisplayLogEntry"
        Me.Text = "Display Log Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleLabel As System.Windows.Forms.Label
    Friend WithEvents SampleEntryListBox As System.Windows.Forms.ListBox
    Friend WithEvents PickSampleLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
End Class
