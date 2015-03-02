Imports System.Threading

Namespace Utilities

    Public Class Logger

        Public Shared Event ERRORS As EventHandler
        Public Shared Event WARNING As EventHandler
        Public Shared Event DEBUG As EventHandler
        Public Shared Event INFO As EventHandler
        Public Shared Event VERBOS As EventHandler

        Public Shared Sub LogError(p_error As String)

            If ERRORSEvent IsNot Nothing Then
                RaiseEvent ERRORS("| " & If(Thread.CurrentThread.ManagedThreadId.ToString().Length = 1, " ", "") & Thread.CurrentThread.ManagedThreadId & " | " & p_error, Nothing)
            End If

        End Sub

        Public Shared Sub LogError(p_error As Exception)

            If Not ERRORSEvent = Nothing And Not p_error Is Nothing Then
                RaiseEvent ERRORS("| " & If(Thread.CurrentThread.ManagedThreadId.ToString().Length = 1, " ", "") & Thread.CurrentThread.ManagedThreadId & " | " & p_error.ToString(), Nothing)
            End If
        End Sub

        Public Shared Sub LogWarning(p_warning As String)

            If Not WARNINGEvent = Nothing And Not p_warning = Nothing Then
                RaiseEvent WARNING("| " & If(Thread.CurrentThread.ManagedThreadId.ToString().Length = 1, " ", "") & Thread.CurrentThread.ManagedThreadId & " | " & p_warning, Nothing)
            End If
        End Sub

        Public Shared Sub LogDebug(p_debug As String)

            If Not DEBUGEvent = Nothing And Not p_debug = Nothing Then
                RaiseEvent DEBUG("| " & If(Thread.CurrentThread.ManagedThreadId.ToString().Length = 1, " ", "") & Thread.CurrentThread.ManagedThreadId & " | " & p_debug, Nothing)
            End If
        End Sub

        Public Shared Sub LogVerbose(p_verbos As String)


#If DEBUG Then
            If Not VERBOSEvent = Nothing And Not p_verbos = Nothing Then
                RaiseEvent VERBOS("| " & If(Thread.CurrentThread.ManagedThreadId.ToString().Length = 1, " ", "") & Thread.CurrentThread.ManagedThreadId & " | " & p_verbos, Nothing)
            End If
#End If
        End Sub

        Public Shared Sub LogInfo(p_info As String)

            If Not INFOEvent = Nothing And Not p_info = Nothing Then
                RaiseEvent INFO("| " & If(Thread.CurrentThread.ManagedThreadId.ToString().Length = 1, " ", "") & Thread.CurrentThread.ManagedThreadId & " | " & p_info, Nothing)
            End If
        End Sub

    End Class

End Namespace
