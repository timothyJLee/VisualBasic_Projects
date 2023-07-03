<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSample
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
        Me.SamplePictureBox = New System.Windows.Forms.PictureBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.FieldTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.FieldLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.DesciptionLabel = New System.Windows.Forms.Label()
        Me.ImagePathTextBox = New System.Windows.Forms.TextBox()
        Me.BrowseDialogButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.PictureFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SamplePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SamplePictureBox
        '
        Me.SamplePictureBox.Location = New System.Drawing.Point(255, 25)
        Me.SamplePictureBox.Name = "SamplePictureBox"
        Me.SamplePictureBox.Size = New System.Drawing.Size(214, 197)
        Me.SamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SamplePictureBox.TabIndex = 0
        Me.SamplePictureBox.TabStop = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(12, 52)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(147, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'FieldTextBox
        '
        Me.FieldTextBox.Location = New System.Drawing.Point(12, 113)
        Me.FieldTextBox.Name = "FieldTextBox"
        Me.FieldTextBox.Size = New System.Drawing.Size(147, 20)
        Me.FieldTextBox.TabIndex = 2
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(12, 174)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(147, 20)
        Me.TypeTextBox.TabIndex = 3
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(12, 254)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(241, 85)
        Me.DescriptionTextBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 33)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'FieldLabel
        '
        Me.FieldLabel.AutoSize = True
        Me.FieldLabel.Location = New System.Drawing.Point(12, 94)
        Me.FieldLabel.Name = "FieldLabel"
        Me.FieldLabel.Size = New System.Drawing.Size(29, 13)
        Me.FieldLabel.TabIndex = 6
        Me.FieldLabel.Text = "Field"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(12, 155)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(31, 13)
        Me.TypeLabel.TabIndex = 7
        Me.TypeLabel.Text = "Type"
        '
        'DesciptionLabel
        '
        Me.DesciptionLabel.AutoSize = True
        Me.DesciptionLabel.Location = New System.Drawing.Point(12, 235)
        Me.DesciptionLabel.Name = "DesciptionLabel"
        Me.DesciptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.DesciptionLabel.TabIndex = 8
        Me.DesciptionLabel.Text = "Description"
        '
        'ImagePathTextBox
        '
        Me.ImagePathTextBox.Location = New System.Drawing.Point(272, 267)
        Me.ImagePathTextBox.Name = "ImagePathTextBox"
        Me.ImagePathTextBox.Size = New System.Drawing.Size(125, 20)
        Me.ImagePathTextBox.TabIndex = 9
        '
        'BrowseDialogButton
        '
        Me.BrowseDialogButton.Location = New System.Drawing.Point(413, 263)
        Me.BrowseDialogButton.Name = "BrowseDialogButton"
        Me.BrowseDialogButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseDialogButton.TabIndex = 10
        Me.BrowseDialogButton.Text = "Browse"
        Me.BrowseDialogButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(385, 316)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(103, 23)
        Me.SubmitButton.TabIndex = 11
        Me.SubmitButton.Text = "Submit Sample"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'PictureFileDialog
        '
        Me.PictureFileDialog.FileName = "PictureFileDialog"
        '
        'AddSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 364)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.BrowseDialogButton)
        Me.Controls.Add(Me.ImagePathTextBox)
        Me.Controls.Add(Me.DesciptionLabel)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.FieldLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.FieldTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.SamplePictureBox)
        Me.Name = "AddSample"
        Me.Text = "Add Sample"
        CType(Me.SamplePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SamplePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FieldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents FieldLabel As System.Windows.Forms.Label
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents DesciptionLabel As System.Windows.Forms.Label
    Friend WithEvents ImagePathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowseDialogButton As System.Windows.Forms.Button
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents PictureFileDialog As System.Windows.Forms.OpenFileDialog
End Class
