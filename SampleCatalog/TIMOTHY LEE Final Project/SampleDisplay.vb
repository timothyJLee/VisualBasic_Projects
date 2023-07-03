Public Class SampleDisplay

    Private Sub SampleDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ChosenSample As New Sample
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText(SampleCatalog.LogFileListBox.SelectedItem.ToString())
        Dim Name As New List(Of String)
        Dim RestOf As New List(Of String)
        Dim IsName As New Boolean

        Do Until sr.EndOfStream
            IsName = Not IsName
            Dim Line As String = sr.ReadLine()
            Select Case True
                Case Line = DisplayLogEntry.SampleEntryListBox.SelectedItem.ToString
                    ChosenSample.Name = Line
                    sr.ReadLine()
                    ChosenSample.Field = sr.ReadLine()
                    sr.ReadLine()
                    ChosenSample.Type = sr.ReadLine()
                    sr.ReadLine()
                    ChosenSample.ImagePath = sr.ReadLine()
                    Do Until Line = "EndSample"
                        Line = sr.ReadLine()
                        If Line = "Description:" And Line <> "EndSample" Then
                            Do Until Line = "EndSample"
                                Line = sr.ReadLine()
                                If Line <> "EndSample" Then
                                    If ChosenSample.Description <> String.Empty Then
                                        ChosenSample.Description += Environment.NewLine & Line
                                    Else
                                        ChosenSample.Description = Line
                                    End If
                                End If
                            Loop
                        End If
                    Loop
                Case Else
            End Select
        Loop

        SampleNameTextLabel.Text = ChosenSample.Name
        FieldTextLabel.Text = ChosenSample.Field
        TypeTextLabel.Text = ChosenSample.Type
        SamplePictureBox.ImageLocation = ChosenSample.ImagePath
        DescriptionTextLabel.Text = ChosenSample.Description
    End Sub

End Class