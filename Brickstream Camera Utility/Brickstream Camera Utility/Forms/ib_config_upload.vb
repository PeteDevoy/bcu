Imports System.IO

Public Class ib_config_upload

    Private m_fileInfo As List(Of FileInformation)

    Public Structure FileInformation
        Public fileName As String
        Public fileFullName As String
    End Structure

    Public Function GetConfigFile() As String
        Return cb_config.Text
    End Function

    Private Sub cb_config_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_config.SelectedIndexChanged
        Dim info As FileInformation = SelectedFile
        Me.cb_config.Text = info.fileFullName
        Me.Close()
    End Sub

    Private Sub ib_config_upload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_fileInfo = PopulateFileInfo()
        Me.cb_config.Items.AddRange((From item As FileInformation In m_fileInfo Select item.fileName).ToArray)
    End Sub

    Private Function PopulateFileInfo() As List(Of FileInformation)
        Dim dir As New DirectoryInfo(Application.StartupPath & "\configs")
        Dim files = dir.GetFiles
        Return (From line In files
               Select New FileInformation With {
                   .fileName = line.Name,
                   .fileFullName = line.FullName
               }).ToList()
    End Function

    Private ReadOnly Property SelectedFile() As FileInformation
        Get
            Return m_fileInfo(Me.cb_config.SelectedIndex)
        End Get
    End Property

End Class