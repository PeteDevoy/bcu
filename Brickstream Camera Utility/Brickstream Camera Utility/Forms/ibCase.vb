Public Class ibCase

    Private Property varCase As String

    Public Function GetCase() As String
        If tbCase.TextLength = 0 Then Return Nothing
        Return tbCase.Text
    End Function

    Private Sub tbCase_TextChanged(sender As Object, e As EventArgs) Handles tbCase.TextChanged
        varCase = tbCase.Text
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Me.Close()
    End Sub

    Private Sub tbCase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbCase.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit.PerformClick()
        End If
    End Sub

End Class