Public Class DisplayLogEntry
    
    Private Sub DisplayLogEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(SampleCatalog.LogFileListBox.SelectedItem.ToString())
        If fileReader.Trim.Length > 0 Then
            SampleEntryListBoxFill()
        Else
            MessageBox.Show("Contents of Log file is empty.  Please Add Samples")
        End If
    End Sub

    Private Sub SampleEntryListBoxFill()
        ' Fill Sample Entries From the Log File to the SampleEntryListBox
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText(SampleCatalog.LogFileListBox.SelectedItem.ToString())
        Dim Name As New List(Of String)
        Dim RestOf As New List(Of String)
        Dim IsName As New Boolean

        SampleEntryListBox.Items.Clear()
        Do Until sr.EndOfStream
            IsName = Not IsName
            Dim Line As String = sr.ReadLine()
            If Line = "Name:" Then
                SampleEntryListBox.Items.Add(sr.ReadLine())
            Else
                RestOf.Add(Line)
            End If
        Loop
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        If SampleEntryListBox.SelectedIndex = -1 Then
            ' nothing selected
            MessageBox.Show("Please Select a Sample Before Pressing a Button.")
        Else
            ' remove item selected
            SampleDisplay.Show()
        End If
    End Sub

End Class