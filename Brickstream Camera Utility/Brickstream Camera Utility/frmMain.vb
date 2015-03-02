Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Net.NetworkInformation
Imports System.Media

Public Class frmMain

    Property serialDict As Dictionary(Of String, String)
    Property m_cameraDictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilities.Logger.LogInfo("Starting Up")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutCameraUtilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCameraUtilityToolStripMenuItem.Click
        Dim t_about As About = New About()
        t_about.ShowDialog()
    End Sub

#Region "dhcp"
    Private Sub leg_dhcp_Click_1(sender As Object, e As EventArgs) Handles leg_dhcp.Click
        Dim t_leg_dhcp As dhcp = New dhcp()

        If t_leg_dhcp.ShowDialog() Then
            serialDict = t_leg_dhcp.getSerialDict()
        End If
    End Sub
#End Region

#Region "static"
    Private Sub leg_static_Click(sender As Object, e As EventArgs) Handles leg_static.Click
        leg_staticBW.RunWorkerAsync()
    End Sub

    Private Sub leg_staticBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_staticBW.DoWork
        Call getDic()
        For Each t_value As KeyValuePair(Of String, String) In m_cameraDictionary
            Dim t_host As String = t_value.Value
            Dim t_serial As String = t_value.Key
            If cam_static(t_host, t_serial) Then
            End If
        Next
        m_cameraDictionary.Clear()
    End Sub

    Private Sub leg_staticBW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles leg_staticBW.RunWorkerCompleted
        Utilities.Logger.LogInfo("All cameras should be back in static IP mode")
    End Sub
#End Region

#Region "Firmware"
    Public Class firmwareWorkerArgs
        Public t_case As String
        Public t_firmFile As String
    End Class

    Private Sub single_leg_firm_Click(sender As Object, e As EventArgs) Handles single_leg_firm.Click
        Dim arguments As New firmwareWorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_firmFile = GetFirm()
        If arguments.t_firmFile Is Nothing Then Exit Sub
        leg_single_firm_uploadBW.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_single_firm_uploadBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_single_firm_uploadBW.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As firmwareWorkerArgs = DirectCast(e.Argument, firmwareWorkerArgs)

        Dim t_host As String = "192.168.1.7"
        Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host)

        Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting camera firmware flash using firmware file *" & arguments.t_firmFile & "*")
        Try
            If firmware(arguments.t_case, t_host, t_serial, arguments.t_firmFile) Then
                Call Camera.Legacy.Reboot(t_host)
            Else
                Utilities.Logger.LogError("Error: Camera " & t_serial & " - firmware flash failed")
            End If
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
        End Try
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & "  - Firmware upgrade with firmware file *" & arguments.t_firmFile & "* is complete, camera will reboot.")
        _finish_sound.Play()
    End Sub

    Private Sub multi_leg_firm_Click(sender As Object, e As EventArgs) Handles mutli_leg_firm.Click
        Dim arguments As New firmwareWorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_firmFile = GetFirm()
        If arguments.t_firmFile Is Nothing Then Exit Sub
        leg_multi_firm_uploadBW.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_multi_firm_uploadBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_multi_firm_uploadBW.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As firmwareWorkerArgs = DirectCast(e.Argument, firmwareWorkerArgs)

        Call getDic()
        Dim t_list As List(Of String) = New List(Of String)
        For Each t_value As KeyValuePair(Of String, String) In m_cameraDictionary
            t_list.Add(t_value.Value)
        Next

        Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting multi camera firmware flash using firmware file *" & arguments.t_firmFile & "*")
        Parallel.ForEach(t_list, Sub(t_host As String)
                                     Try
                                         Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host)
                                         If firmware(arguments.t_case, t_host, t_serial, arguments.t_firmFile) Then
                                             Call cam_static(t_host, t_serial)
                                         Else
                                             Utilities.Logger.LogError("Error: Camera " & t_serial & " - firmware flash failed")
                                         End If
                                     Catch ex As Exception
                                         Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
                                     End Try
                                 End Sub)
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & "  - Firmware upgrade with firmware file *" & arguments.t_firmFile & "* is complete.")
        _finish_sound.Play()
        m_cameraDictionary.Clear()
    End Sub
#End Region

#Region "config upload"
    Public Class configuploadWorkerArgs
        Public t_case As String
        Public t_configFile As String
    End Class

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim arguments As New configuploadWorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_configFile = GetConfig()
        If arguments.t_configFile Is Nothing Then Exit Sub
        leg_single_config_upload.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_single_config_upload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_single_config_upload.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As configuploadWorkerArgs = DirectCast(e.Argument, configuploadWorkerArgs)

        Dim t_host As String = "192.168.1.7"
        Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host)

        Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting config upload using config file *" & arguments.t_configFile & "*")
        Try
            If config_upload(arguments.t_case, t_host, t_serial, arguments.t_configFile) Then
            Else
                Utilities.Logger.LogError("Error: Camera " & t_serial & " - config upload failed")
            End If
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
        End Try
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & "  - Config upload with config file *" & arguments.t_configFile & "* is complete")
        _finish_sound.Play()
    End Sub

    Private Sub multi_leg_config_Click(sender As Object, e As EventArgs) Handles multi_leg_config.Click
        Dim arguments As New configuploadWorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_configFile = GetConfig()
        If arguments.t_configFile Is Nothing Then Exit Sub
        leg_multi_config_uploadBW.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_multi_config_uploadBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_multi_config_uploadBW.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As configuploadWorkerArgs = DirectCast(e.Argument, configuploadWorkerArgs)

        Call getDic()

        For Each t_host As KeyValuePair(Of String, String) In m_cameraDictionary
            Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting config upload using config file *" & arguments.t_configFile & "*")
            Try
                Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host.Value)
                If config_upload(arguments.t_case, t_host.Value, t_serial, arguments.t_configFile) Then
                    Call cam_static(t_host.Value, t_serial)
                Else
                    Utilities.Logger.LogError("Error: Case #" & arguments.t_case & " - config upload failed")
                End If
            Catch ex As Exception
                Utilities.Logger.LogError("Error: " & t_host.Value & " | " & ex.ToString())
            End Try
        Next
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & "  - Config upload with config file *" & arguments.t_configFile & "* is complete, camera will reboot.")
        _finish_sound.Play()
        m_cameraDictionary.Clear()
    End Sub
#End Region

#Region "license"
    Private Class licenseWorkerArgs
        Public t_case As String
        Public t_licKey As String
    End Class

    Private Sub single_leg_license_Click(sender As Object, e As EventArgs) Handles single_leg_license.Click
        Dim arguments As New licenseWorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_licKey = GetLicense()
        If arguments.t_licKey Is Nothing Then Exit Sub
        leg_single_license.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_single_license_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_single_license.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As licenseWorkerArgs = DirectCast(e.Argument, licenseWorkerArgs)

        Dim t_host As String = "192.168.1.7"
        Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host)

        Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting license upload using license key *" & arguments.t_licKey & "*")
        Try
            Dim t_keyParams As String = Camera.Legacy.GetLicenseKeyParams(arguments.t_licKey.ToString)
            Dim t_camKey As String = Camera.Legacy.GenerateLicenseKey(t_serial, t_keyParams)
            If license_key(arguments.t_case, t_host, t_serial, t_camKey) Then
            Else
                Utilities.Logger.LogError("Error: Camera " & t_serial & " - license upload failed")
            End If
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
        End Try
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & "  - License upload with license key *" & arguments.t_licKey & "* is complete")
        _finish_sound.Play()
    End Sub

    Private Sub multi_leg_license_Click(sender As Object, e As EventArgs) Handles multi_leg_license.Click
        Dim arguments As New licenseWorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_licKey = GetLicense()
        If arguments.t_licKey Is Nothing Then Exit Sub
        leg_multi_licenseBW.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_multi_licenseBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_multi_licenseBW.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As licenseWorkerArgs = DirectCast(e.Argument, licenseWorkerArgs)

        Call getDic()

        For Each t_host As KeyValuePair(Of String, String) In m_cameraDictionary
            Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting multi camera license upload using license key *" & arguments.t_licKey & "*")
            Try
                Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host.Value)
                Dim t_keyParams As String = Camera.Legacy.GetLicenseKeyParams(arguments.t_licKey.ToString)
                Dim t_camKey As String = Camera.Legacy.GenerateLicenseKey(t_serial, t_keyParams)
                If license_key(arguments.t_case, t_host.Value, t_serial, t_camKey) Then
                    Call cam_static(t_host.Value, t_serial)
                Else
                    Utilities.Logger.LogError("Error: Camera " & t_serial & " - license upload failed")
                End If
            Catch ex As Exception
                Utilities.Logger.LogError("Error: " & t_host.Value & " | " & ex.ToString())
            End Try
        Next
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - License uploads with license key *" & arguments.t_licKey & "* is complete")
        _finish_sound.Play()
        m_cameraDictionary.Clear()
    End Sub
#End Region

#Region "configurator"
    Public Class configuratorWorkerArgs
        Public t_case As String
        Public t_configuratorForm As Object
    End Class

    Sub leg_configurator_Click(sender As Object, e As EventArgs) Handles leg_configurator.Click
        Dim arguments As New configuratorWorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_configuratorForm = GetConfigurator()
        leg_single_configurator.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_single_configurator_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_single_configurator.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As configuratorWorkerArgs = DirectCast(e.Argument, configuratorWorkerArgs)

        Dim t_host As String = "192.168.1.7"
        Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host)

        Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting configuration of camera *" & t_serial & "*")
        Try
            If configurator(arguments.t_case, t_host, t_serial, arguments.t_configuratorForm) Then
            Else
                Utilities.Logger.LogError("Error: Case #" & arguments.t_case & " - configuration failed")
            End If
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
        End Try
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & "  - Configuration of camera *" & t_serial & "* is complete, camera will reboot.")
        _finish_sound.Play()
    End Sub
#End Region

#Region "3-IN-1"
    Private Class _3n1WorkerArgs
        Public t_case As String
        Public t_3in1Form As Object
    End Class

    Private Sub leg_3n1_Click(sender As Object, e As EventArgs) Handles leg_3n1.Click
        Dim arguments As New _3n1WorkerArgs
        arguments.t_case = GetCase()
        If arguments.t_case Is Nothing Then Exit Sub
        arguments.t_3in1Form = Get3n1()
        leg_3n1BW.RunWorkerAsync(arguments)
    End Sub

    Private Sub leg_3n1BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles leg_3n1BW.DoWork
        Dim _finish_sound As New SoundPlayer(My.Resources.Duh_Duh)

        Dim arguments As _3n1WorkerArgs = DirectCast(e.Argument, _3n1WorkerArgs)

        Call getDic()

        Dim t_list As List(Of String) = New List(Of String)
        For Each t_value As KeyValuePair(Of String, String) In m_cameraDictionary
            t_list.Add(t_value.Value)
        Next

        Utilities.Logger.LogInfo("Case #" & arguments.t_case & " - Starting multi camera 3-IN-1 operation with firmware file *" & arguments.t_3in1Form.getfirmtype & "*, license key *" _
                                 & arguments.t_3in1Form.GetKeyType & "*, and config file *" & arguments.t_3in1Form.GetConfigFile & "*")
        Parallel.ForEach(t_list, Sub(t_host As String)
                                     Try
                                         Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_host)
                                         If firmware(arguments.t_case, t_host, t_serial, arguments.t_3in1Form.GetFirmType) Then
                                             Dim t_keyParams As String = Camera.Legacy.GetLicenseKeyParams(arguments.t_3in1Form.GetKeyType.ToString)
                                             Dim t_camKey As String = Camera.Legacy.GenerateLicenseKey(t_serial, t_keyParams)
                                             If license_key(arguments.t_case, t_host, t_serial, t_camKey) And config_upload(arguments.t_case, t_host, t_serial, arguments.t_3in1Form.GetConfigFile) Then
                                                 Call cam_static(t_host, t_serial)
                                             Else
                                                 Utilities.Logger.LogError("Error: Camera " & t_serial & " - 3-In-1 update failed")
                                             End If
                                         Else
                                             Utilities.Logger.LogError("Error: Camera " & t_serial & " - firmware flash failed, cannot proceed")
                                         End If
                                     Catch ex As Exception
                                         Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
                                     End Try
                                 End Sub)
        Utilities.Logger.LogInfo("Case #" & arguments.t_case & "  - Multi camera 3-IN-1 operation with firmware file *" & arguments.t_3in1Form.GetFirmType & "*, license key *" _
                                 & arguments.t_3in1Form.GetKeyType & "*, and config file *" & arguments.t_3in1Form.GetConfigFile & "* is complete.")
        _finish_sound.Play()
        m_cameraDictionary.Clear()
    End Sub
#End Region

#Region "Form Functions"
    Function GetCase() As String
        Dim t_caseForm As ibCase = New ibCase
        t_caseForm.ShowDialog()

        Return t_caseForm.GetCase()
    End Function

    Function GetFirm() As String
        Dim t_firmForm As firmpick = New firmpick
        t_firmForm.ShowDialog()

        Return t_firmForm.GetFirmType()
    End Function

    Function GetConfig() As String
        Dim t_confForm As ib_config_upload = New ib_config_upload
        t_confForm.ShowDialog()

        Return t_confForm.GetConfigFile()
    End Function

    Function GetLicense()
        Dim t_licForm As licensepick = New licensepick()
        t_licForm.ShowDialog()

        Return t_licForm.GetKeyType()
    End Function

    Function GetConfigurator() As Object
        Dim t_configuratorForm As configurator = New configurator
        t_configuratorForm.ShowDialog()

        Return t_configuratorForm
    End Function

    Function Get3n1() As Object
        Dim t_3in1Form As _3_IN_1 = New _3_IN_1
        t_3in1Form.ShowDialog()

        Return t_3in1Form
    End Function
#End Region

#Region "cam_functions"
    Private Function firmware(t_case As String, t_host As String, t_serial As String, t_firmFile As String)
        Try
            Call Camera.Legacy.FirmwareUpgrade(t_host, "192.168.1.254", t_firmFile)
            Dim t_camStatus As Integer
            Do
                Try
                    t_camStatus = Camera.Legacy.FirmwareUpgradeStatus(t_host)
                    If t_camStatus = 4 Then
                        Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " has received firmware file *" & t_firmFile & "*")
                        Call WriteToLog(t_case, t_serial, t_msg)
                        Return True
                        Exit Do
                    ElseIf t_camStatus > 4 Then
                        Utilities.Logger.LogError("Error: [ " & Now & " ] Serial - " & t_serial & " at IP " & t_host & " needs to be rechecked")
                        Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " firmware update has failed")
                        Call WriteToLog(t_case, t_serial, t_msg)
                        Return False
                        Exit Do
                    End If
                Catch ex As Exception
                    Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
                End Try
                Threading.Thread.Sleep(5000)
            Loop
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
            Return False
        End Try
    End Function

    Private Function config_upload(t_case As String, t_host As String, t_serial As String, t_configFile As String)
        Try
            Dim t_filePath As String = (Application.StartupPath & "\configs\" & t_configFile & "")
            If Camera.Legacy.ImportFile(t_host, t_filePath) Then
                Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " has received config file *" & t_configFile & "*")
                Call WriteToLog(t_case, t_serial, t_msg)
                Return True
            Else
                Utilities.Logger.LogError("Error: [ " & Now & " ] Serial - " & t_serial & " at IP " & t_host & " needs to be rechecked")
                Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " config upload has failed")
                Call WriteToLog(t_case, t_serial, t_msg)
                Return False
            End If
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
            Return False
        End Try
    End Function

    Private Function license_key(t_case As String, t_host As String, t_serial As String, t_camKey As String)
        Try
            If Camera.Legacy.SetLicenseKey(t_host, t_camKey) Then
                Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " has received license key *" & t_camKey & "*")
                Call WriteToLog(t_case, t_serial, t_msg)
                Return True
            Else
                Utilities.Logger.LogError("Error: [ " & Now & " ] Serial - " & t_serial & " at IP " & t_host & " needs to be rechecked")
                Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " license key upload has failed")
                Call WriteToLog(t_case, t_serial, t_msg)
                Return False
            End If
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
            Return False
        End Try
    End Function

    Private Function configurator(t_case As String, t_host As String, t_serial As String, t_configuratorForm As Object)
        Try
            If Camera.Legacy.UpdateDeviceIdentification(t_host, t_configuratorForm.GetSITEID, t_configuratorForm.GetSITENAME, "", t_configuratorForm.GetDEVID, _
                                                        t_configuratorForm.GetDEVNAME) And Camera.Legacy.UpdateNetworkSettings(t_host, t_configuratorForm.GetDHCP, _
                                                        t_configuratorForm.GetHOST, t_configuratorForm.GetIP, t_configuratorForm.GetSUB, _
                                                        t_configuratorForm.GetGate, t_configuratorForm.GetDNS) Then
                Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " has been configured as *" & t_configuratorForm.GetDEVID & "*")
                Call WriteToLog(t_case, t_serial, t_msg)
                Return True
            Else
                Dim t_msg As String = ("[ " & Now & " ] Serial - " & t_serial & " configuration has failed")
                Call WriteToLog(t_case, t_serial, t_msg)
                Return False
            End If
        Catch ex As Exception
            Utilities.Logger.LogError("Error: " & t_host & " | " & ex.ToString())
            Return False
        End Try
    End Function

    Private Function cam_static(t_host As String, t_serial As String)
        If Camera.Legacy.UpdateNetworkSettings(t_host, "2", "Cam-" & t_serial & "", "192.168.1.7", "255.255.255.0", "192.168.1.1", "192.168.1.10") Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "logging"
    Public Sub WriteToLog(ByVal t_case As String, ByVal t_serial As String, ByVal t_msg As String)
        Dim t_title As String = "Brickstream Camera Utility"
        'Check and make directory
        If Not System.IO.Directory.Exists(Application.StartupPath & "\logs\" & t_case & "\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\logs\" & t_case & "\")
        End If

        'Check and make file
        Dim fs As FileStream = New FileStream(Application.StartupPath & "\logs\" & t_case & "\" & t_serial & ".log", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'Logging
        Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\logs\" & t_case & "\" & t_serial & ".log", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        s1.Write("Title: " & t_title & vbCrLf)
        s1.Write("Message: " & t_msg & vbCrLf)
        s1.Write("================================================" & vbCrLf)
        s1.Close()
        fs1.Close()
    End Sub
#End Region

#Region "Camera Dictionary"
    Function getDic() As Dictionary(Of String, String)
        Dim dhcpContent As String = My.Resources.dhcp
        Dim t_ips As List(Of String)
        t_ips = dhcpContent.Split(vbCrLf).ToList()
        Parallel.ForEach(t_ips, Sub(ip As String)
                                    Dim t_ping As Ping = New Ping()
                                    Dim t_ipAddress As String = ip.Trim()
                                    Try
                                        If Not String.IsNullOrEmpty(t_ipAddress) AndAlso t_ping.Send(t_ipAddress, 1000).Status = IPStatus.Success Then
                                            Dim t_serial As String = Camera.Legacy.GetSerialNumber(t_ipAddress)
                                            If Not String.IsNullOrEmpty(t_serial) Then
                                                m_cameraDictionary.Add(t_serial, t_ipAddress)
                                            End If
                                        End If
                                    Catch ex As Exception
                                        Utilities.Logger.LogError("Error: " & t_ipAddress & " | " & ex.ToString())
                                    End Try
                                End Sub)
        Utilities.Logger.LogInfo("Count: " & m_cameraDictionary.Count.ToString())

        Return m_cameraDictionary()
    End Function
#End Region

End Class
