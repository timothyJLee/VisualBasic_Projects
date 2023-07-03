Public Class AddSample

    Private Sub BrowseDialogButton_Click(sender As Object, e As EventArgs) Handles BrowseDialogButton.Click
        PictureFileDialog.Title = "Please Select an Image File."
        PictureFileDialog.InitialDirectory = "C:\Users\judy\Desktop\School\CompSci\Visual Basic\Projects\TIMOTHY LEE Final Project\TIMOTHY LEE Final Project\Images"
        PictureFileDialog.ShowDialog()
    End Sub

    Private Sub PictureFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PictureFileDialog.FileOk
        Dim strm As System.IO.Stream
        strm = PictureFileDialog.OpenFile
        ImagePathTextBox.Text = PictureFileDialog.FileName.ToString
        SamplePictureBox.ImageLocation = ImagePathTextBox.Text
    End Sub
    
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim NewSampleObject As New Sample

        NewSampleObject.Name = NameTextBox.Text
        NewSampleObject.Field = FieldTextBox.Text
        NewSampleObject.Type = TypeTextBox.Text
        NewSampleObject.Description = DescriptionTextBox.Text
        NewSampleObject.ImagePath = ImagePathTextBox.Text

        WriteLogEntry("BeginSample")
        WriteLogEntry("Date:")
        WriteLogEntry(Date.Now.ToString)
        WriteLogEntry("Name:")
        WriteLogEntry(NewSampleObject.Name)
        WriteLogEntry("Field:")
        WriteLogEntry(NewSampleObject.Field)
        WriteLogEntry("Type:")
        WriteLogEntry(NewSampleObject.Type)
        WriteLogEntry("ImagePath:")
        WriteLogEntry(NewSampleObject.ImagePath)
        WriteLogEntry("Description:")
        WriteLogEntry(NewSampleObject.Description)
        WriteLogEntry("EndSample")

        EditLogFile.SampleEntryEditListboxFill()
    End Sub

    Private Sub WriteLogEntry(ByVal TheLogEntry As String)
        ' writing log files
        '   - location: drive:\folders(\)\filename.log
        '   - errors (handle via try/catch/finally)
        '   - what to write, what is a separator
        '   - new files (create) or old files (append, overwrite)

        Dim FileNamePath As String = SampleCatalog.LogFileListBox.SelectedItem.ToString
        Dim StreamWriterObject As System.IO.StreamWriter = Nothing

        Try
            StreamWriterObject = New System.IO.StreamWriter(FileNamePath, True)
            StreamWriterObject.WriteLine(TheLogEntry)
        Catch ex As Exception
            ' bad happenings: WriteLogEntry(ex.Message)
            MessageBox.Show(ex.Message)
        Finally
            ' always runs - error or not
            If StreamWriterObject Is Nothing Then
                ' closed or never opened, continue.
            Else
                StreamWriterObject.Close()
            End If
        End Try
    End Sub

End Class