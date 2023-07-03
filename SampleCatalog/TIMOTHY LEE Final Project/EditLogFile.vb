


Public Class EditLogFile

    Dim SampleObjectArray() As Sample

    Private Sub EditLogFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(SampleCatalog.LogFileListBox.SelectedItem.ToString())
        If fileReader.Trim.Length > 0 Then
            SampleEntryEditListboxFill()
        Else
            MessageBox.Show("Contents of Log file is empty.  Please Add Samples")
        End If
    End Sub

    Public Sub SampleEntryEditListboxFill()
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText(SampleCatalog.LogFileListBox.SelectedItem.ToString())
        Dim Name As New List(Of String)
        Dim RestOf As New List(Of String)
        Dim IsName As New Boolean

        SampleEntryEditListBox.Items.Clear()
        Do Until sr.EndOfStream
            IsName = Not IsName
            Dim Line As String = sr.ReadLine()
            If Line = "Name:" Then
                SampleEntryEditListBox.Items.Add(sr.ReadLine())
            Else
                RestOf.Add(Line)
            End If
        Loop
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
            AddSample.Show()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If SampleEntryEditListBox.SelectedIndex = -1 Then
            ' nothing selected
            MessageBox.Show("Nothing Selected")
        Else
            ' remove item selected
            SampleEntryEditListBox.Items.RemoveAt(SampleEntryEditListBox.SelectedIndex)
        End If
    End Sub
End Class