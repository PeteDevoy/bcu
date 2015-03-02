Imports System.Text

'--------------------------------------------------------------------------
'- 	 Company: Brickstream Corp
'- Developer: James P. Walters | james.walters@brickstream.com
'- Copyright: 2014 - Brickstream Corp
'- 	 Version: 2.0
'- 	   Usage: Model 1100 & 2300
'- 	 Purpose: This class is designed to act as an example of how to
'- 			  communicate with Brickstream devices for the purpose of
'-			  helping optimize device preparation and pre-installation processes.
'--------------------------------------------------------------------------

Namespace Camera

    Public Class Legacy

        Const fsoForReading = 1
        Const fsoForWriting = 2
        Const fsoForAppending = 8

        Structure HTTP_ACTION
            Const HTTP_GET = "GET"
            Const HTTP_POST = "POST"
        End Structure

        Const IMPORT_CGI = "webImport.cgi"
        Const EXPORT_CONFIG_CGI = "getConfigExportFile.cgi"
        Const REBOOT_CGI = "webReboot.cgi"
        Const CONFIG_WEB_PARAMS_CGI = "configWebParams.cgi"
        Const GET_PARAMS = "getParams.cgi"
        Const WEB_UPGRADE_FLASH = "webUpgradeFlash.cgi"
        Const LICENSE_UPGRADE = "licenseUpgrade.cgi"
        Const LICENSE_RESET = "licenseReset.cgi"

        'license key types
        Const ADVANCED_COUNTING_NEW_IN_2013 = "Advanced Counting (New in 2013)"
        Const ADVANCED_FIRMWARE_NEW_IN_2013 = "Advanced Firmware (New in 2013)"
        Const ADVANCED_SOFTWARE_6_ZONES = "Advanced Software (6 Zones)"
        Const ADVANCED_SOFTWARE_32_ZONES = "Advanced Software (32 Zones)"
        Const QUEUE_SOFTWARE = "Queue Software"
        Const SERVICE_SOFTWARE_6_ZONES = "Service Software (6 Zones)"
        Const SERVICE_SOFTWARE_32_ZONES = "Service Software (32 Zones)"
        Const TILT = "Tilt"
        Const PRIVACY = "Privacy"
        Const DATA_ENCRYPTION = "Data Encryption"
        Const REPORT_INTERFACE = "Report Interface"
        Const PRIVACY_PLUS_DATA_ENCRYPTION = "Privacy + Data Encryption"
        Const PRIVACY_PLUS_REPORT_INTERFACE = "Privacy + Report Interface"
        Const PRIVACY_PLUS_DATA_ENCRYPTION_PLUS_REPORT_INTERFACE = "Privacy + Data Encryption + Report Interface"
        Const DATA_ENCRYPTION_PLUS_REPORT_INTERFACE = "Data Encryption + Report Interface"
        Const PATH_LINKING = "Path Linking"
        Const TRAFFIC_MAPS = "Traffic Maps"
        Const PATH_LINKING_PLUS_TRAFFIC_MAPS = "Path Linking + Traffic Maps"
        Const ADVANCED_SOFTWARE_32_ZONES_PLUS_ALL_OPTIONS = "Advanced Software (32 Zones) + All Options"
        Const ADVANCED_SOFTWARE_32_ZONES_PLUS_ALL_OPTIONS_MINUS_PATH_LINKING = "Advanced Software (32 Zones) + All Options - Path Linking"

        ''' <summary>
        ''' Get Serial Number
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        ''' <returns>Serial Number as String</returns>
        Public Shared Function GetSerialNumber(p_ipAddress As String) As String
            Dim t_serialNumber As String = ""

            Try
                Utilities.Logger.LogInfo("Get Serial Number: " & p_ipAddress)

                Dim t_configDictionary As Dictionary(Of String, String) = AddKeyValuesToMap(Send(p_ipAddress, HTTP_ACTION.HTTP_POST, GET_PARAMS, "PARAM=REL_INFO&ACTION=GET", ""))

                If t_configDictionary Is Nothing Then
                    Return ""
                End If

                If t_configDictionary.TryGetValue("SERIAL_NUM", t_serialNumber) Then
                    Utilities.Logger.LogInfo("   Serial Number: " & t_serialNumber)
                    Utilities.Logger.LogInfo("     Mac Address: " & t_configDictionary("MAC_ADDRESS"))
                    Utilities.Logger.LogDebug("Firmware Version: " & t_configDictionary("BS_COUNTING_REL"))

                    Dim t_model As String = ""
                    If t_configDictionary.TryGetValue("DEVICE_MODEL", t_model) Then
                        Utilities.Logger.LogDebug("    Device Model: " & t_model)
                    End If

                End If

                Return t_serialNumber

            Catch ex As Exception
                Return ""
            End Try

        End Function

        ''' <summary>
        ''' Get Device Info
        ''' </summary>
        ''' <param name="p_ipAddress"></param>
        ''' <param name="p_param">Parameter Name</param>
        ''' <returns>Value of Parameter</returns>
        ''' <remarks>Example Parameter Names: Serial Number = SERIAL_NUM, Mac Address = MAC_ADDRESS, Firmware Version = BS_COUNTING_REL, Device Model = DEVICE_MODEL</remarks>
        Public Shared Function GetInfo(p_ipAddress As String, p_param As String) As String
            Utilities.Logger.LogVerbose("Get Device Info: " & p_ipAddress & " | " & p_param)
            Dim t_configDictionary As Dictionary(Of String, String) = AddKeyValuesToMap(Send(p_ipAddress, HTTP_ACTION.HTTP_POST, GET_PARAMS, "PARAM=REL_INFO&ACTION=GET", ""))

            Utilities.Logger.LogVerbose(p_param & ": " & t_configDictionary(p_param))

            Return t_configDictionary(p_param)

        End Function

        ''' <summary>
        ''' Generate License Key
        ''' </summary>
        ''' <param name="p_serialNumber">Device Serial Number</param>
        ''' <param name="p_keyParams"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GenerateLicenseKey(p_serialNumber As String, p_keyParams As String) As String
            Utilities.Logger.LogInfo("Generate License Key for Serial Number: " & p_serialNumber & " | params: " & p_keyParams)

            Dim goWSH : goWSH = CreateObject("WScript.Shell")

            Dim aRet : aRet = goWSH.exec("cmd.exe /c """ & Environment.CurrentDirectory & "\ClarityKeyGen.exe"" -n " & p_serialNumber & " " & p_keyParams & " -o " & My.Resources.key & "")
            Dim execStdOut, t_tempArray, t_licArray

            execStdOut = aRet.StdOut.ReadAll()
            Utilities.Logger.LogVerbose(execStdOut)

            t_tempArray = Split(execStdOut, ":")
            t_licArray = Split(Trim(t_tempArray(1)), vbCrLf)

            Utilities.Logger.LogVerbose("License Key: " & t_licArray(0))

            Return Trim(t_licArray(0))
        End Function


        ''' <summary>
        ''' Gets the key params based on common license key names.
        ''' </summary>
        ''' <param name="p_licenseType"></param>
        ''' <returns>Key Generation Parameters</returns>
        ''' <remarks>Example Key Type: ADVANCED_SOFTWARE_32_ZONES_PLUS_ALL_OPTIONS</remarks>
        Public Shared Function GetLicenseKeyParams(p_licenseType As String) As String

            Utilities.Logger.LogVerbose("Get License Key Params for Key Type: " & p_licenseType)

            Dim t_params As String

            t_params = ""

            Select Case p_licenseType
                Case "Advanced Counting (New in 2013)"
                    t_params = " -l -c 6 -r 90"
                Case "Advanced Firmware (New in 2013)"
                    t_params = " -l -c 6 -r 90 -s 6 -d 6 -q 6 -f"
                Case "Advanced Software (6 Zones)"
                    t_params = " -c 6 -s 6 -d 6 -q 6 -r 90"
                Case "Advanced Software (32 Zones)"
                    t_params = " -c 32 -s 32 -d 32 -q 32 -r 90"
                Case "Queue Software"
                    t_params = " -c 1 -q 1 -r 10"
                Case "Service Software (6 Zones)"
                    t_params = " -s 6 -r 90"
                Case "Service Software (32 Zones)"
                    t_params = " -s 32 -r 90"
                Case "Tilt"
                    t_params = " -r 90"
                Case "Privacy"
                    t_params = " -p"
                Case "Data Encryption"
                    t_params = " -e"
                Case "Report Interface"
                    t_params = " -m"
                Case "Privacy + Data Encryption"
                    t_params = " -p -e"
                Case "Privacy + Report Interface"
                    t_params = " -p -m"
                Case "Privacy + Data Encryption + Report Interface"
                    t_params = " -p -e -m"
                Case "Data Encryption + Report Interface"
                    t_params = " -e -m"
                Case "Path Linking"
                    t_params = " -l"
                Case "Traffic Maps"
                    t_params = " -f"
                Case "Path Linking + Traffic Maps"
                    t_params = " -l -f"
                Case "Advanced Software (32 Zones) + All Options"
                    t_params = " -c 32 -s 32 -d 32 -q 32 -r 90 -p -m -e -l -f"
                Case "Advanced Software (32 Zones) + All Options - Path Linking"
                    t_params = " -c 32 -s 32 -d 32 -q 32 -r 90 -p -m -e -f"
                Case Else
                    Utilities.Logger.LogError(" -- key type not found --")
            End Select

            Return t_params

        End Function

        ''' <summary>
        ''' Get License Info
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        Public Shared Function GetLicenseInfo(p_ipAddress As String) As String
            Utilities.Logger.LogInfo("Get License Info: " & p_ipAddress)

            Dim t_configDictionary As Dictionary(Of String, String) = AddKeyValuesToMap(ExportConfig(p_ipAddress))
            Dim t_licInfo As StringBuilder = New StringBuilder()

            Utilities.Logger.LogVerbose("")
            For Each kvp As KeyValuePair(Of String, String) In t_configDictionary
                If Len(kvp.Key) Then
                    If Left(kvp.Key, 4) = "LIC_" Then
                        t_licInfo.Append(If(t_licInfo.Length > 0, "&", "") & kvp.Key & "=" & kvp.Value)
                        Utilities.Logger.LogVerbose(kvp.Key & "=" & kvp.Value)
                    End If
                End If
            Next

            Utilities.Logger.LogVerbose("")

            Return t_licInfo.ToString()

        End Function

        ''' <summary>
        ''' Set License Key
        ''' </summary>
        ''' <param name="p_ipAddress"></param>
        ''' <param name="p_licenseKey"></param>
        ''' <returns>Status As Boolean</returns>
        Public Shared Function SetLicenseKey(p_ipAddress As String, p_licenseKey As String) As Boolean
            Utilities.Logger.LogInfo("Set License Key: " & p_ipAddress & " | " & p_licenseKey)
            Dim t_httpResponse As String
            Dim t_status As Boolean = True

            t_httpResponse = Send(p_ipAddress, HTTP_ACTION.HTTP_POST, LICENSE_UPGRADE, "LICENSE_APP_MODE=31&SOFTWARE_LICENSE=" & p_licenseKey, "")

            If InStr(t_httpResponse, "invalid license key") > 0 Then
                Utilities.Logger.LogError("")
                Utilities.Logger.LogError("ERROR - The license key was not applied to the camera.")
                Utilities.Logger.LogError("")
                t_status = False
            End If

            Return t_status

        End Function

        ''' <summary>
        ''' Reset License
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        ''' <returns>Status As Boolean</returns>
        Public Shared Function ResetLicense(p_ipAddress As String) As Boolean
            Utilities.Logger.LogInfo("Reset License: " & p_ipAddress)
            Dim t_httpResponse As String
            Dim t_status As Boolean = True

            t_httpResponse = Send(p_ipAddress, HTTP_ACTION.HTTP_POST, LICENSE_RESET, "", "")

            If InStr(t_httpResponse, "successfully") = 0 Then
                Utilities.Logger.LogError("")
                Utilities.Logger.LogError("ERROR - The license key could not be reset.")
                Utilities.Logger.LogError("")
                t_status = False
            End If

            Return t_status

        End Function

        ''' <summary>
        ''' Firmware Upgrade
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        ''' <param name="p_tftpServer">TFTP Server Address</param>
        ''' <param name="p_binFileName">Bin File Name</param>
        Public Shared Sub FirmwareUpgrade(p_ipAddress As String, p_tftpServer As String, p_binFileName As String)
            Utilities.Logger.LogInfo("Firmware Upgrade: " & p_ipAddress)
            Call Send(p_ipAddress, HTTP_ACTION.HTTP_POST, WEB_UPGRADE_FLASH, "UPGRADE_SERVER=" & p_tftpServer & "&UPGRADE_FILE_NAME=\bs\firmware\" & p_binFileName, "")
        End Sub

        ''' <summary>
        ''' Check Firmware Upgrade Status
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        ''' <returns>Statas As String</returns>
        Public Shared Function FirmwareUpgradeStatus(p_ipAddress As String) As Integer

            '----------------------------------------------------------------------
            '-	1  = Ready (to be Upgraded)
            '-	2  = Uploading File
            '-  3  = Flash in Progress
            '-	4  = Upgrade Successful
            '-
            '-	Failure Status:
            '-	5  = File Transfer Failure
            '-	6  = Write To Flash Failure
            '-	7  = Memory Allocation Failure
            '-	8  = Not Enough Buffer Space to Hold Upgrade File
            '-	9  = Flash Erase Error
            '-	10  = Upgrade file too big
            '-	11 = Activation Error
            '-	12 = Flash Unlock Error
            '-  -1 = Unknown State
            '----------------------------------------------------------------------

            Utilities.Logger.LogInfo("Checking Firmware Upgrade Status: " & p_ipAddress)
            Dim t_configDictionary As Dictionary(Of String, String)
            Try
                t_configDictionary = AddKeyValuesToMap(Send(p_ipAddress, HTTP_ACTION.HTTP_POST, GET_PARAMS, "PARAM=REL_INFO&ACTION=GET", ""))
            Catch ex As Exception
                Return -1
            End Try

            If t_configDictionary Is Nothing Then
                Return -1
            End If

            Utilities.Logger.LogInfo("         Upgrade State:" & t_configDictionary("UPGRADE_STATE"))
            Utilities.Logger.LogInfo("Is Upgrade In Progress:" & t_configDictionary("IS_UPGRADE_IN_PROGRESS"))

            
            Select Case t_configDictionary("UPGRADE_STATE")
                Case "Ready"
                    Return 1
                Case "Uploading File"
                    Return 2
                Case "Flash in Progress"
                    Return 3
                Case "Upgrade Successful"
                    Return 4
                Case "File Transfer Failure"
                    Return 5
                Case "Write To Flash Failure"
                    Return 6
                Case "Memory Allocation Failure"
                    Return 7
                Case "Not Enough Buffer Space to Hold Upgrade File"
                    Return 8
                Case "Flash Erase Error"
                    Return 9
                Case "Upgrade file too big"
                    Return 10
                Case "Activation Error"
                    Return 11
                Case "Flash Unlock Error"
                    Return 12
                Case Else
                    Return -1
            End Select

        End Function

        ''' <summary>
        ''' Update Network Setting
        ''' </summary>
        ''' <param name="p_currentDeviceIp">(required) In case you are changing the ip address</param>
        ''' <param name="p_enableDHCP">(optional) p_enableDHCP: 1 = Yes/Enable, 2=No/Disable</param>
        ''' <param name="p_hostName">(optional) p_hostName: Host Name</param>
        ''' <param name="p_ipAddress">(optional) p_ipAddress: New IP Address of Device</param>
        ''' <param name="p_networkMask">(optional) p_networkMask: Network Mask - 255.255.255.0</param>
        ''' <param name="p_defaultGateway">(optional) p_defaultGateway: Default Gateway</param>
        ''' <param name="p_dnsServer">(optional) p_dnsServer: DNS Server</param>
        ''' <returns>Status as Boolean</returns>
        ''' <remarks>WARNING: The device will auto reboot after any changes</remarks>
        Public Shared Function UpdateNetworkSettings(p_currentDeviceIp As String, p_enableDHCP As String, p_hostName As String, p_ipAddress As String, p_networkMask As String, p_defaultGateway As String, p_dnsServer As String) As Boolean

            Dim t_status As Boolean = True

            '- Note: If you don't supply a value it will keep the current setting
            '- 			from the device. When possibly explicit setting all parameters
            '-			to avoid any issues.

            Utilities.Logger.LogInfo("Updating Network Settings: " & p_currentDeviceIp)
            Utilities.Logger.LogVerbose("           DHCP:" & p_enableDHCP)
            Utilities.Logger.LogVerbose("      Home Name:" & p_hostName)
            Utilities.Logger.LogVerbose("     IP Address:" & p_ipAddress)
            Utilities.Logger.LogVerbose("   Network Mask:" & p_networkMask)
            Utilities.Logger.LogVerbose("Default Gateway:" & p_defaultGateway)
            Utilities.Logger.LogVerbose("     DNS Server:" & p_dnsServer)

            'In order to update the network settings the device requires that we send 
            ' all fields from the "basic settings" page which include network settings
            ' plus data and time, logging, proxy and data delivery settings
            'This call gets the current values of all the params we need
            Dim t_configDictionary As Dictionary(Of String, String) = AddKeyValuesToMap(ExportConfig(p_currentDeviceIp))

            If Not t_configDictionary Is Nothing Then

                If Len(p_enableDHCP) > 0 Then
                    t_configDictionary.Item("NETWORK_STARTUP") = p_enableDHCP
                End If

                If Len(p_hostName) > 0 Then
                    t_configDictionary.Item("CAM_HOST_NAME") = p_hostName
                End If

                If Len(p_ipAddress) > 0 Then
                    t_configDictionary.Item("IP_ADDRESS") = p_ipAddress
                End If

                If Len(p_networkMask) > 0 Then
                    t_configDictionary.Item("SUBNET_MASK") = p_networkMask
                End If

                If Len(p_defaultGateway) > 0 Then
                    t_configDictionary.Item("DEFAULT_GATEWAY") = p_defaultGateway
                End If

                If Len(p_dnsServer) > 0 Then
                    t_configDictionary.Item("DNS_SERVER") = p_dnsServer
                End If

                Dim t_httpMessageBody As StringBuilder = New StringBuilder()
                t_httpMessageBody.Append("PARAM=basic&tab_index=1")
                For Each key As KeyValuePair(Of String, String) In t_configDictionary
                    t_httpMessageBody.Append("&" & key.Key & "=" & key.Value)
                Next

                Utilities.Logger.LogDebug("Param List: " & t_httpMessageBody.ToString())

                Dim t_httpResponse As String
                t_httpResponse = Send(p_currentDeviceIp, HTTP_ACTION.HTTP_POST, CONFIG_WEB_PARAMS_CGI, t_httpMessageBody.ToString(), "")

                If InStr(t_httpResponse, "Unable to save your settings") > 0 Then
                    Utilities.Logger.LogError("Update Status: Failed")
                    Utilities.Logger.LogWarning("Device may still reboot.")
                    t_status = False
                Else
                    Utilities.Logger.LogInfo("Update Status: Successful")
                    Utilities.Logger.LogInfo("Device will reboot.")
                End If

            Else
                t_status = False

            End If

            Return t_status

        End Function

        ''' <summary>
        ''' Update Device Identification
        ''' </summary>
        ''' <param name="p_ipAddress">(required) p_ipAddress: device ip address</param>
        ''' <param name="p_siteId">(required) p_siteId: 1 = Yes/Enable, 2=No/Disable</param>
        ''' <param name="p_siteName">(required) p_siteName: Host Name</param>
        ''' <param name="p_divisionId">(optional) p_divisionId: New IP Address of Device</param>
        ''' <param name="p_deviceId">(required) p_deviceId: Network Mask - 255.255.255.0</param>
        ''' <param name="p_deviceName">(required) p_deviceName: Default Gateway</param>
        ''' <returns>Status as Boolean</returns>
        Public Shared Function UpdateDeviceIdentification(p_ipAddress As String, p_siteId As String, p_siteName As String, p_divisionId As String, p_deviceId As String, p_deviceName As String) As Boolean

            Utilities.Logger.LogInfo("Updating Device Identification: " & p_ipAddress)
            Utilities.Logger.LogVerbose("     Site ID:" & p_siteId)
            Utilities.Logger.LogVerbose("   Site Name:" & p_siteName)
            Utilities.Logger.LogVerbose(" Division ID:" & p_divisionId)
            Utilities.Logger.LogVerbose("   Device ID:" & p_deviceId)
            Utilities.Logger.LogInfo(" Device Name:" & p_deviceName)

            Dim t_status As Boolean = True

            'In order to update the device identification settings the device requires that we send 
            ' all fields from the "basic settings" page which include network settings
            ' plus data and time, logging, proxy and data delivery settings
            'This call gets the current values of all the params we need
            Dim t_configDictionary As Dictionary(Of String, String) = AddKeyValuesToMap(ExportConfig(p_ipAddress))

            'Validate Input
            If Len(p_siteId) = 0 Or Len(p_siteName) = 0 Or Len(p_deviceId) = 0 Or Len(p_deviceName) = 0 Then
                Utilities.Logger.LogError("Update Status: Failed - Missing Required Parameters")
                UpdateDeviceIdentification = False
            End If

            t_configDictionary.Item("SITE_ID") = p_siteId
            t_configDictionary.Item("SITE_NAME") = p_siteName
            t_configDictionary.Item("DIVISION_ID") = p_divisionId
            t_configDictionary.Item("DEVICE_ID") = p_deviceId
            t_configDictionary.Item("DEVICE_NAME") = p_deviceName

            Dim t_httpMessageBody As StringBuilder = New StringBuilder()
            t_httpMessageBody.Append("PARAM=basic&tab_index=1")
            For Each key As KeyValuePair(Of String, String) In t_configDictionary
                t_httpMessageBody.Append("&" & key.Key & "=" & key.Value)
            Next

            Utilities.Logger.LogDebug("Param List: " & t_httpMessageBody.ToString())

            Dim t_httpResponse As String
            t_httpResponse = Send(p_ipAddress, HTTP_ACTION.HTTP_POST, CONFIG_WEB_PARAMS_CGI, t_httpMessageBody.ToString(), "")

            If InStr(t_httpResponse, "Unable to save your settings") > 0 Then
                Utilities.Logger.LogError("Update Status: Failed")
                t_status = False
            Else
                Utilities.Logger.LogInfo("Update Status: Successful")
            End If

            Return t_status

        End Function

        ''' <summary>
        ''' Reboots a device
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        Public Shared Sub Reboot(p_ipAddress As String)
            Utilities.Logger.LogInfo("Reboot Device: " & p_ipAddress)
            Call Send(p_ipAddress, HTTP_ACTION.HTTP_POST, REBOOT_CGI, "", "")
        End Sub

        ''' <summary>
        ''' Import a Configuration File
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        ''' <param name="p_filePath">File Path</param>
        ''' <returns>Status as Boolean</returns>
        Public Shared Function ImportFile(p_ipAddress As String, p_filePath As String) As Boolean
            Utilities.Logger.LogInfo("Import Config to Device: " & p_ipAddress & " | File: " & p_filePath)

            Dim p_response As String
            Dim p_status As Boolean = True

            p_response = Send(p_ipAddress, HTTP_ACTION.HTTP_POST, IMPORT_CGI, "", p_filePath)

            If Len(p_response) > 0 Then
                Utilities.Logger.LogInfo("Status: Successful")
            Else
                Utilities.Logger.LogError("Status: Failed")
                p_status = False
            End If

            Return p_status

        End Function

        ''' <summary>
        ''' Export Configuration
        ''' </summary>
        ''' <param name="p_ipAddress">Device IP</param>
        ''' <returns>Config File as String</returns>
        ''' <remarks>This could be used to help verify configuration has been properly set.</remarks>
        Public Shared Function ExportConfig(p_ipAddress As String) As String
            Utilities.Logger.LogVerbose("Export Config from Device: " & p_ipAddress)

            Dim t_exportConfig As String
            t_exportConfig = Send(p_ipAddress, HTTP_ACTION.HTTP_GET, EXPORT_CONFIG_CGI, "", "")
            Utilities.Logger.LogVerbose("Exported Configuration:")
            Utilities.Logger.LogVerbose(t_exportConfig)

            Return t_exportConfig

        End Function

        ''' <summary>
        ''' Add Key Value Pairs (ie Device Configuration) to a global map.
        ''' </summary>
        ''' <param name="p_keyValuePairs">String of Pairs Separated by Ampersand</param>
        ''' <returns>Dictionary of Key Value Pairs</returns>
        ''' <remarks>This could be used to help get or evaluate individual key value pairs.</remarks>
        Private Shared Function AddKeyValuesToMap(p_keyValuePairs As String) As Dictionary(Of String, String)

            If String.IsNullOrEmpty(p_keyValuePairs) Then
                Return Nothing
            End If

            Dim t_configDictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)

            Dim t_configArray As String()
            t_configArray = p_keyValuePairs.Split("&")

            For Each pair As String In t_configArray
                Dim keyValue As String()
                keyValue = Split(pair, "=")

                If keyValue.Length = 2 Then
                    t_configDictionary.Add(keyValue(0), keyValue(1))
                End If
            Next

            For Each element As KeyValuePair(Of String, String) In t_configDictionary
                Utilities.Logger.LogVerbose("key:" & element.Key & " | Value:" & element.Value)
            Next

            Return t_configDictionary

        End Function

        ''' <summary>
        ''' This function will send an HTTP message to a device and return whatever comes back from device. The return string may not be helpful.
        ''' </summary>
        ''' <param name="p_ipAddress">Device's IP</param>
        ''' <param name="p_action">HTTP_ACTION = GET or POST</param>
        ''' <param name="p_page">(optional) Name of Page - Example: *.cgi</param>
        ''' <param name="p_body">(optional) Content Body - Example: key=value&amp;key1=value2</param>
        ''' <param name="p_filePath">(optional) Full file path to upload</param>
        ''' <returns>HTML / String</returns>
        Public Shared Function Send(p_ipAddress As String, p_action As String, p_page As String, p_body As String, p_filePath As String) As String

            Dim objHttp = CreateObject("MSXML2.ServerXMLHTTP")
            'objHttp.setTimeouts(1000, 1000, 1000, 1000)  '-- Timeout

            Try

                Dim sUrl As String

                Dim t_multipart_boundary
                t_multipart_boundary = "-----------------------------191691572411478"

                Dim t_fileContent As StringBuilder = New StringBuilder()

                sUrl = "http://" & p_ipAddress & "/" & p_page

                Utilities.Logger.LogVerbose("")
                Utilities.Logger.LogVerbose("Preparing to Send HTTP Command...")
                Utilities.Logger.LogVerbose("  URL:" & sUrl)
                Utilities.Logger.LogVerbose("  Action:" & p_action)
                Utilities.Logger.LogVerbose("  Content Body:" & p_body)
                Utilities.Logger.LogVerbose("")

                If Len(p_filePath) > 0 Then
                    t_fileContent.Append(t_multipart_boundary)
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append("Content-Disposition: form-data name=""IMPORT_SETTINGS"" filename=""ConfigExport.txt""")
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append("Content-Type: text/plain")
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append(ReadFile(p_filePath)) 'Read file and add the file content
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append(t_multipart_boundary)
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append("Content-Disposition: form-data name=""IMPORT_CALIB_DATA""")
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append("0")
                    t_fileContent.Append(vbCrLf)
                    t_fileContent.Append(t_multipart_boundary & "--")
                    t_fileContent.Append(vbCrLf)
                End If

                Utilities.Logger.LogDebug("Sending command ... Please Wait")
                objHttp.Open(p_action, sUrl, False)

                If t_fileContent.Length > 0 Then
                    objHttp.setRequestHeader("Content-Type", "multipart/form-data boundary=" & t_multipart_boundary)
                Else
                    t_fileContent.Append(p_body)
                    objHttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                End If

                objHttp.Send(t_fileContent.ToString())

                Utilities.Logger.LogVerbose(objHttp.responseText)

                Utilities.Logger.LogDebug("Send complete")

            Catch ex As Exception

                'Utilities.Logger.LogError(ex)
                Return ""
            End Try

            If objHttp.Status = 200 Then
                Return objHttp.responseText
            End If

            Return ""

        End Function

        ''' <summary>
        ''' Read from a file
        ''' </summary>
        ''' <param name="p_filePath">Full file path</param>
        ''' <returns>Contents of File</returns>
        Public Shared Function ReadFile(p_filePath As String) As String
            Dim fso
            Dim f = Nothing

            Try
                fso = CreateObject("Scripting.FileSystemObject")
                f = fso.OpenTextFile(p_filePath, fsoForReading)
                Return f.ReadAll
            Finally
                If (f IsNot Nothing) Then
                    f.Close()
                End If
            End Try

        End Function

    End Class

End Namespace


