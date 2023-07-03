<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleDisplay
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
        Me.DesciptionLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.FieldLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SamplePictureBox = New System.Windows.Forms.PictureBox()
        Me.SampleNameTextLabel = New System.Windows.Forms.Label()
        Me.FieldTextLabel = New System.Windows.Forms.Label()
        Me.TypeTextLabel = New System.Windows.Forms.Label()
        Me.DescriptionTextLabel = New System.Windows.Forms.Label()
        CType(Me.SamplePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DesciptionLabel
        '
        Me.DesciptionLabel.AutoSize = True
        Me.DesciptionLabel.Location = New System.Drawing.Point(12, 240)
        Me.DesciptionLabel.Name = "DesciptionLabel"
        Me.DesciptionLabel.Size = New System.Drawing.Size(63, 13)
        Me.DesciptionLabel.TabIndex = 20
        Me.DesciptionLabel.Text = "Description:"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(12, 141)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(34, 13)
        Me.TypeLabel.TabIndex = 19
        Me.TypeLabel.Text = "Type:"
        '
        'FieldLabel
        '
        Me.FieldLabel.AutoSize = True
        Me.FieldLabel.Location = New System.Drawing.Point(12, 80)
        Me.FieldLabel.Name = "FieldLabel"
        Me.FieldLabel.Size = New System.Drawing.Size(32, 13)
        Me.FieldLabel.TabIndex = 18
        Me.FieldLabel.Text = "Field:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 19)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 17
        Me.NameLabel.Text = "Name:"
        '
        'SamplePictureBox
        '
        Me.SamplePictureBox.Location = New System.Drawing.Point(168, 19)
        Me.SamplePictureBox.Name = "SamplePictureBox"
        Me.SamplePictureBox.Size = New System.Drawing.Size(214, 197)
        Me.SamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SamplePictureBox.TabIndex = 12
        Me.SamplePictureBox.TabStop = False
        '
        'SampleNameTextLabel
        '
        Me.SampleNameTextLabel.AutoSize = True
        Me.SampleNameTextLabel.Location = New System.Drawing.Point(13, 36)
        Me.SampleNameTextLabel.Name = "SampleNameTextLabel"
        Me.SampleNameTextLabel.Size = New System.Drawing.Size(0, 13)
        Me.SampleNameTextLabel.TabIndex = 21
        '
        'FieldTextLabel
        '
        Me.FieldTextLabel.AutoSize = True
        Me.FieldTextLabel.Location = New System.Drawing.Point(15, 97)
        Me.FieldTextLabel.Name = "FieldTextLabel"
        Me.FieldTextLabel.Size = New System.Drawing.Size(0, 13)
        Me.FieldTextLabel.TabIndex = 22
        '
        'TypeTextLabel
        '
        Me.TypeTextLabel.AutoSize = True
        Me.TypeTextLabel.Location = New System.Drawing.Point(15, 158)
        Me.TypeTextLabel.Name = "TypeTextLabel"
        Me.TypeTextLabel.Size = New System.Drawing.Size(0, 13)
        Me.TypeTextLabel.TabIndex = 23
        '
        'DescriptionTextLabel
        '
        Me.DescriptionTextLabel.AutoSize = True
        Me.DescriptionTextLabel.Location = New System.Drawing.Point(13, 257)
        Me.DescriptionTextLabel.Name = "DescriptionTextLabel"
        Me.DescriptionTextLabel.Size = New System.Drawing.Size(0, 13)
        Me.DescriptionTextLabel.TabIndex = 24
        '
        'SampleDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 353)
        Me.Controls.Add(Me.DescriptionTextLabel)
        Me.Controls.Add(Me.TypeTextLabel)
        Me.Controls.Add(Me.FieldTextLabel)
        Me.Controls.Add(Me.SampleNameTextLabel)
        Me.Controls.Add(Me.DesciptionLabel)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.FieldLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SamplePictureBox)
        Me.Name = "SampleDisplay"
        Me.Text = "Sample"
        CType(Me.SamplePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DesciptionLabel As System.Windows.Forms.Label
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents FieldLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents SamplePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SampleNameTextLabel As System.Windows.Forms.Label
    Friend WithEvents FieldTextLabel As System.Windows.Forms.Label
    Friend WithEvents TypeTextLabel As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextLabel As System.Windows.Forms.Label
End Class
