' program: Sample Catalog
' author: Timothy Lee
' date: 6/20/12
' PURPOSE:  To use listboxes, objects, log files, forms, and various ways to read and write strings to make a program that
'           Allows you to store Samples of Data, which a picture, for various fields and types.
' BUSINESS: Allows you to store data on Various samples that may need to be loaded or saved at different times.
'-------------------------------------------

Option Strict On
Option Explicit On



Public Class SampleCatalog

    Private Sub SampleCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Log Files into LogFileListBox
        LogFileListBoxFill()
        ToolStripStatusLabel.Text = "Ready..."
    End Sub

    Private Sub LogFileListBoxFill()
        For Each File As String In
            My.Computer.FileSystem.GetFiles("C:\Users\judy\Desktop\School\CompSci\Visual Basic\Projects\TIMOTHY LEE Final Project\TIMOTHY LEE Final Project\LogFiles", FileIO.SearchOption.SearchAllSubDirectories)
            LogFileListBox.Items.Add(File)
        Next
    End Sub

    Private Sub DisplayLogFileButton_Click(sender As Object, e As EventArgs) Handles DisplayLogFileButton.Click
        If LogFileListBox.SelectedIndex = -1 Then
            ' nothing selected
            MessageBox.Show("Please Select a Log File Before Pressing a Button.")
        Else
            ' remove item selected
            DisplayLogEntry.Show()
        End If
    End Sub

    Private Sub EditLogFileButton_Click(sender As Object, e As EventArgs) Handles EditLogFileButton.Click
        If LogFileListBox.SelectedIndex = -1 Then
            ' nothing selected
            MessageBox.Show("Please Select a Log File Before Pressing a Button.")
        Else
            ' remove item selected
            EditLogFile.Show()
        End If
    End Sub

    Private Sub AddLogFileButton_Click(sender As Object, e As EventArgs) Handles AddLogFileButton.Click
        ' Show browse dialog to add Log Files
        AddLogFileOpenDialog.Title = "Please Select a .log File."
        AddLogFileOpenDialog.InitialDirectory = "C:\Users\judy\Desktop\School\CompSci\Visual Basic\Projects\TIMOTHY LEE Final Project\TIMOTHY LEE Final Project\LogFiles"
        AddLogFileOpenDialog.Filter = "*.log | *.log"
        AddLogFileOpenDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddLogFileOpenDialog.FileOk
        Dim strm As System.IO.Stream
        strm = AddLogFileOpenDialog.OpenFile
        LogFileListBox.Items.Add(AddLogFileOpenDialog.FileName.ToString())
    End Sub

    Private Sub DeleteLogFileButton_Click(sender As Object, e As EventArgs) Handles DeleteLogFileButton.Click
        If LogFileListBox.SelectedIndex = -1 Then
            ' nothing selected
            MessageBox.Show("Nothing Selected")
        Else
            ' remove item selected
            LogFileListBox.Items.RemoveAt(LogFileListBox.SelectedIndex)
        End If
    End Sub


#Region "Menu Items"
    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        ' Show Documentation
        MessageBox.Show("To add new log files on startup please put them in the default folder" & Environment.NewLine _
                        & "Some directories may need to be changed in order for program to run on your specific machine" & Environment.NewLine & Environment.NewLine _
                        & "Please refer to Online Documentation, Faqs, and Message Boards for more help or info at:" & Environment.NewLine _
                        & "           www.FakeWebSite.com")
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        MessageBox.Show("Sponsors/ProjectTeam: Timothy Lee" & Environment.NewLine & "Email: timmyjoe12345@yahoo.com")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("The Purpose of this program is to Calalog Samples for viewing later." & Environment.NewLine & Environment.NewLine & "Timothy Lee" _
                        & Environment.NewLine & Environment.NewLine & "All Images used in the software examples belong to the respective copyright holders.", "About")
    End Sub

    Private Sub OpenLogFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenLogFileToolStripMenuItem.Click
        AddLogFileOpenDialog.Title = "Please Select a .log File."
        AddLogFileOpenDialog.InitialDirectory = "C:\Users\judy\Desktop\School\CompSci\Visual Basic\Projects\TIMOTHY LEE Final Project\TIMOTHY LEE Final Project\LogFiles"
        AddLogFileOpenDialog.Filter = "*.log | *.log"
        AddLogFileOpenDialog.ShowDialog()
    End Sub

    Private Sub OpenLogFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenLogFileDialog.FileOk
        Dim strm As System.IO.Stream
        strm = AddLogFileOpenDialog.OpenFile
        LogFileListBox.Items.Add(AddLogFileOpenDialog.FileName.ToString())
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region


End Class
