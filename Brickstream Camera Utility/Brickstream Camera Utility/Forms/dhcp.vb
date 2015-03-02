Public Class dhcp

    Private m_serialDictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private m_counts As Integer = 0

    Public Sub dhcp_start_Click(sender As Object, e As EventArgs) Handles dhcp_start.Click
        dhcp_start.Enabled = False
        dhcp_stop.Enabled = True
        dhcpifier.RunWorkerAsync()
    End Sub

    Public Sub stop_dhcp_Click(sender As Object, e As EventArgs) Handles dhcp_stop.Click
        dhcp_start.Enabled = True
        dhcp_stop.Enabled = False
        Me.Close()
    End Sub

    Private Sub dhcpifier_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles dhcpifier.DoWork
        Dim strHost As String = "192.168.1.7"
        Dim varCamSerial As String = ""
        Dim varPreviousSerial As String = ""
        Dim pingvalue As Boolean = My.Computer.Network.Ping(strHost, 1000)

        Do While dhcp_start.Enabled = False
            Dim arp As New Process()
            arp.StartInfo.FileName = "arp.exe"
            arp.StartInfo.Arguments = " -d 192.168.1.7"
            arp.StartInfo.CreateNoWindow = True
            arp.StartInfo.UseShellExecute = False
            arp.StartInfo.RedirectStandardOutput = True
            arp.StartInfo.RedirectStandardError = True
            arp.Start()
            arp.WaitForExit()

            If pingvalue = True Then
                varCamSerial = Camera.Legacy.GetSerialNumber(strHost)
                If Not String.IsNullOrEmpty(varCamSerial) AndAlso Not varPreviousSerial = varCamSerial Then
                    If Camera.Legacy.UpdateNetworkSettings(strHost, "1", "Cam-" & varCamSerial & "", "", "", "", "") Then
                        Call updateCount(varCamSerial)
                    Else
                        Utilities.Logger.LogError("Serial - " & varCamSerial & "could not be counted/updated")
                    End If
                End If
                varPreviousSerial = varCamSerial
            End If
        Loop
    End Sub

    Private Sub updateCount(p1 As String)
        If lblCounts.InvokeRequired Then
            lblCounts.BeginInvoke(DirectCast(Sub() updateCount(p1), MethodInvoker))
            Return
        End If

        If Not m_serialDictionary.ContainsKey(p1) Then
            m_serialDictionary.Add(p1, p1)
            m_counts += 1
        End If

        lblCounts.Text = m_counts.ToString()
    End Sub

    Private Sub dhcpifier_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles dhcpifier.RunWorkerCompleted
        Me.Close()
    End Sub

    Public Function getSerialDict() As Dictionary(Of String, String)
        Return m_serialDictionary
    End Function

End Class