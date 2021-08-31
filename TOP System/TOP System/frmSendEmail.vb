Imports System.Net.Mail
Public Class frmSendEmail
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim ben_password As String
    Dim sender_password As String = "tabernacle"
    Dim mail_subject As String = "Password Recovery"
    Private Sub frmSendEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        AcceptButton = BTN_SEND
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        lbl_email_warning.Hide()

    End Sub

    Private Sub BTN_CLOSE_BEN_INFO_WINDOW_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE_BEN_INFO_WINDOW.Click
        Me.Close()
        frmLogin.pnl_Login.Show()
        TXT_BEN_EMAIL.ResetText()
    End Sub

    Private Sub BTN_SEND_Click(sender As Object, e As EventArgs) Handles BTN_SEND.Click
        Dim check_email As String = _get_value("SELECT EMAIL FROM EFAS_BENEFICIARY;", "EMAIL")
        If Not TXT_BEN_EMAIL.Text = check_email Then
            lbl_email_warning.Show()
            TXT_BEN_EMAIL.ResetText()
        ElseIf TXT_BEN_EMAIL.Text = Nothing Then
            MsgBox("Email is required!", vbInformation)
        Else
            Try
                ben_password = _get_value("SELECT PASSWORD FROM EFAS_BENEFICIARY WHERE EMAIL = '" & TXT_BEN_EMAIL.Text & "';", "PASSWORD")
                Dim smtpServer As New SmtpClient
                Dim email As New MailMessage
                With smtpServer
                    .UseDefaultCredentials = False
                    .Credentials = New Net.NetworkCredential(TXT_FROM.Text, sender_password)
                    .Port = 587
                    .EnableSsl = True
                    .Host = "smtp.gmail.com"
                End With
                email = New MailMessage
                With email
                    .From = New MailAddress(TXT_FROM.Text)
                    .To.Add(TXT_BEN_EMAIL.Text)
                    .Subject = mail_subject.ToUpper
                    .Body = "Your password: " + ben_password
                    .IsBodyHtml = False
                End With
                smtpServer.Send(email)
                MsgBox("Your password was successfully send to your email.", vbInformation)
                TXT_BEN_EMAIL.ResetText()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TXT_BEN_EMAIL_Enter(sender As Object, e As EventArgs) Handles TXT_BEN_EMAIL.Enter
        TXT_BEN_EMAIL.LineColor = Color.RoyalBlue
        lbl_email_warning.Hide()
    End Sub
End Class