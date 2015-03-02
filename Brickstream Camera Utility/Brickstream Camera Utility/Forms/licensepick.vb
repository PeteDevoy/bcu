Public Class licensepick

    Public Function GetKeyType() As String
        Return ComboBox1.Text
    End Function

    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim varKeyType As String = ComboBox1.Text
        Me.Close()
    End Sub

End Class