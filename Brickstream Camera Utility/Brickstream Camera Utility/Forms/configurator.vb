Public Class configurator

    Property p_dhcp As String

    Public Function GetDHCP()
        If dhcp_yes.Checked Then
            p_DHCP = "1"
        Else
            p_DHCP = "2"
        End If

        Return p_DHCP
    End Function

    Public Function GetHOST()
        Return hostname.Text
    End Function

    Public Function GetIP()
        Return ip_address.Text
    End Function

    Public Function GetSUB()
        Return subnet_mask.Text
    End Function

    Public Function GetGate()
        Return gateway.Text
    End Function

    Public Function GetDNS()
        Return dns.Text
    End Function

    Public Function GetSITEID()
        Return site_id.Text
    End Function

    Public Function GetSITENAME()
        Return site_name.Text
    End Function

    Public Function GetDEVID()
        Return dev_id.Text
    End Function

    Public Function GetDEVNAME()
        Return dev_name.Text
    End Function

    Private Sub dhcp_yes_CheckedChanged(sender As Object, e As EventArgs) Handles dhcp_yes.CheckedChanged
        Dim varDHCP As String = p_DHCP
    End Sub

    Private Sub hostname_TextChanged(sender As Object, e As EventArgs) Handles hostname.TextChanged
        Dim varHOST As String = hostname.Text
    End Sub

    Private Sub ip_address_TextChanged(sender As Object, e As EventArgs) Handles ip_address.TextChanged
        Dim varIP As String = ip_address.Text
    End Sub

    Private Sub subnet_mask_TextChanged(sender As Object, e As EventArgs) Handles subnet_mask.TextChanged
        Dim varSUB As String = subnet_mask.Text
    End Sub

    Private Sub gateway_TextChanged(sender As Object, e As EventArgs) Handles gateway.TextChanged
        Dim varGATE As String = gateway.Text
    End Sub

    Private Sub dns_TextChanged(sender As Object, e As EventArgs) Handles dns.TextChanged
        Dim varDNS As String = dns.Text
    End Sub

    Private Sub site_id_TextChanged(sender As Object, e As EventArgs) Handles site_id.TextChanged
        Dim varSITEID As String = site_id.Text
    End Sub

    Private Sub site_name_TextChanged(sender As Object, e As EventArgs) Handles site_name.TextChanged
        Dim varSITENAME As String = site_name.Text
    End Sub

    Private Sub dev_id_TextChanged(sender As Object, e As EventArgs) Handles dev_id.TextChanged
        Dim varDEVID As String = dev_id.Text
    End Sub

    Private Sub dev_name_TextChanged(sender As Object, e As EventArgs) Handles dev_name.TextChanged
        Dim varDEVNAME As String = dev_name.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class