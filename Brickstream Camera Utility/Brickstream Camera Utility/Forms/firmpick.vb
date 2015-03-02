Imports System.IO

Public Class firmpick

    Private m_fileInfo As List(Of FileInformation)

    Public Structure FileInformation
        Public fileName As String
        Public fileFullName As String
    End Structure

    Public Function GetFirmType() As String
        Return cbFirmFile.Text
    End Function

    Private Sub cbFirmFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFirmFile.SelectedIndexChanged
        Dim info As FileInformation = SelectedFile
        Me.cbFirmFile.Text = info.fileFullName
        Me.Close()
    End Sub

    Private Sub firmpick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_fileInfo = PopulateFileInfo()
        Me.cbFirmFile.Items.AddRange((From item As FileInformation In m_fileInfo Select item.fileName).ToArray)
    End Sub

    Private Function PopulateFileInfo() As List(Of FileInformation)
        Dim dir As New DirectoryInfo("c:\TFTP-Root\bs\firmware")
        Dim files = dir.GetFiles
        Return (From line In files
               Select New FileInformation With {
                   .fileName = line.Name,
                   .fileFullName = line.FullName
               }).ToList()
    End Function

    Private ReadOnly Property SelectedFile() As FileInformation
        Get
            Return m_fileInfo(Me.cbFirmFile.SelectedIndex)
        End Get
    End Property

End Class