Imports Brickstream_Camera_Utility.Utilities

Public Class LoggerTextBox

    Private m_enableErrors As Boolean = True
    Private m_enableWarnings As Boolean = True
    Private m_enableDebugging As Boolean = False
    Private m_enableInfo As Boolean = True
    Private m_enableVerbose As Boolean = False
    Private m_verboseTimeOut As Int16 = 0

    Public Enum LogLevel
        ERRORS
        WARNING
        DEBUG
        INFO
        VERBOSE
    End Enum


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        AddHandler Utilities.Logger.ERRORS, AddressOf Me.Errors
        AddHandler Utilities.Logger.WARNING, AddressOf Me.Warning
        AddHandler Utilities.Logger.DEBUG, AddressOf Me.Debug
        AddHandler Utilities.Logger.INFO, AddressOf Me.Info
        AddHandler Utilities.Logger.VERBOS, AddressOf Me.Verbos

    End Sub

    Private Sub Errors(p_error As Object, p_args As EventArgs)
        If (m_enableErrors) Then
            UpdateStatus(Convert.ToString(p_error), LogLevel.ERRORS)
        End If
    End Sub

    Private Sub Warning(p_error As Object, p_args As EventArgs)
        If (m_enableWarnings) Then
            UpdateStatus(Convert.ToString(p_error), LogLevel.WARNING)
        End If
    End Sub

    Private Sub Debug(p_error As Object, p_args As EventArgs)
        If (m_enableDebugging) Then
            UpdateStatus(Convert.ToString(p_error), LogLevel.DEBUG)
        End If
    End Sub

    Private Sub Info(p_error As Object, p_args As EventArgs)
        If (m_enableInfo) Then
            UpdateStatus(Convert.ToString(p_error), LogLevel.INFO)
        End If
    End Sub

    Private Sub Verbos(p_error As Object, p_args As EventArgs)
        If (m_enableVerbose) Then
            UpdateStatus(Convert.ToString(p_error), LogLevel.VERBOSE)
        End If
    End Sub

    Public Sub UpdateStatus(p_message As String, p_logLevel As LogLevel)

        If txtLogViewer.InvokeRequired Then
            txtLogViewer.BeginInvoke(DirectCast(Sub() UpdateStatus(p_message, p_logLevel), MethodInvoker))
            Return
        End If

        Dim t_blankSpace As String = "    "

        Dim t_output As String = t_blankSpace.Substring(0, 8 - p_logLevel.ToString().Length) + "[" + p_logLevel.ToString() + "] " + DateTime.Now.ToString() + ": " + p_message

        If (Not p_logLevel = LogLevel.VERBOSE) Then
            txtLogViewer.AppendText(t_output + Environment.NewLine)
        End If

#If DEBUG Then
        If (m_enableVerbose) Then
            Console.WriteLine(t_output)
        End If
#End If
    End Sub

    Private Sub ErrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorToolStripMenuItem.Click
        m_enableErrors = ErrorToolStripMenuItem.Checked
    End Sub

    Private Sub WarningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarningToolStripMenuItem.Click
        m_enableWarnings = WarningToolStripMenuItem.Checked
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        m_enableInfo = InfoToolStripMenuItem.Checked
    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        m_enableDebugging = DebugToolStripMenuItem.Checked
    End Sub

    Private Sub VerboseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerboseToolStripMenuItem.Click
        m_enableVerbose = VerboseToolStripMenuItem.Checked
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtLogViewer.Focus()
        txtLogViewer.SelectAll()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtLogViewer.Copy()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        txtLogViewer.Clear()
    End Sub
End Class
