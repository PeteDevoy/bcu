Imports System.IO

Public Class _3_IN_1

    Private m_configfileInfo As List(Of FileInformation)
    Private m_firmfileInfo As List(Of FileInformation)

    Public Structure FileInformation
        Public fileName As String
        Public fileFullName As String
    End Structure

    Public Function GetFirmType()
        Return cbFirmFile.Text
    End Function

    Private Sub cbFirmFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFirmFile.SelectedIndexChanged
        Dim info As FileInformation = SelectedFirmFile
        Me.cbFirmFile.Text = info.fileFullName
        If Me.cbFirmFile.Text Is Nothing Then Exit Sub
    End Sub

    Public Function GetKeyType()
        Return cbLicType.Text
    End Function

    Private Sub cbLicType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLicType.SelectedIndexChanged
        Dim varKeyType As String = cbLicType.Text
    End Sub

    Public Function GetConfigFile()
        Return cbConfFile.Text
    End Function

    Private Sub cbConfFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConfFile.SelectedIndexChanged
        Dim info As FileInformation = SelectedConfigFile
        Me.cbConfFile.Text = info.fileFullName
        If Me.cbConfFile.Text Is Nothing Then Exit Sub
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Me.Close()
    End Sub

    Private Sub _3_IN_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_configfileInfo = PopulateConfigFileInfo()
        m_firmfileInfo = PopulateFirmFileInfo()
        Me.cbConfFile.Items.AddRange((From item As FileInformation In m_configfileInfo Select item.fileName).ToArray)
        Me.cbFirmFile.Items.AddRange((From item As FileInformation In m_firmfileInfo Select item.fileName).ToArray)
    End Sub

    Private Function PopulateConfigFileInfo() As List(Of FileInformation)
        Dim dir As New DirectoryInfo(Application.StartupPath & "\configs\")
        Dim files = dir.GetFiles
        Return (From line In files
               Select New FileInformation With {
                   .fileName = line.Name,
                   .fileFullName = line.FullName
               }).ToList()
    End Function

    Private Function PopulateFirmFileInfo() As List(Of FileInformation)
        Dim dir As New DirectoryInfo("c:\tftp-root\bs\firmware")
        Dim files = dir.GetFiles
        Return (From line In files
               Select New FileInformation With {
                   .fileName = line.Name,
                   .fileFullName = line.FullName
               }).ToList()
    End Function

    Private ReadOnly Property SelectedConfigFile() As FileInformation
        Get
            Return m_configfileInfo(Me.cbConfFile.SelectedIndex)
        End Get
    End Property

    Private ReadOnly Property SelectedFirmFile() As FileInformation
        Get
            Return m_firmfileInfo(Me.cbFirmFile.SelectedIndex)
        End Get
    End Property

End Class