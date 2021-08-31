Public Class frmADD_ADMIN
    Dim ver_uname As String
    Dim ver_ben_uname As String
    Dim sql_add_admin As String
    Private Sub frmADD_ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        AcceptButton = BTN_REGISTER_ADMIN
        ver_uname = _get_value("SELECT ADMIN_USERNAME FROM EFAS_ADMIN", "ADMIN_USERNAME")
        ver_ben_uname = _get_value("SELECT USERNAME FROM EFAS_BENEFICIARY", "USERNAME")

    End Sub

    Private Sub BTN_REGISTER_ADMIN_Click(sender As Object, e As EventArgs) Handles BTN_REGISTER_ADMIN.Click
        If TXT_ADMIN_FNAME.Text = Nothing Then
            MsgBox("Firstname is required.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_LNAME.Text = Nothing Then
            MsgBox("Lastname is required.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_CNUMBER.Text = Nothing Then
            MsgBox("Contact number is required.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_CNUMBER.Text.Length <= 10 Then
            MsgBox("Contact number must be 11 digits.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_EMAIL.Text = Nothing Then
            MsgBox("Email is required.", MsgBoxStyle.Information)
        ElseIf Not TXT_ADMIN_EMAIL.Text.Contains("@") Then
            MsgBox("Invalid email.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_USERNAME.Text = Nothing Then
            MsgBox("Username is required", MsgBoxStyle.Information)
        ElseIf ver_uname = TXT_ADMIN_USERNAME.Text Or ver_ben_uname = TXT_ADMIN_USERNAME.Text Then
            MsgBox("Username is already exist.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_PASSWORD.Text = Nothing Then
            MsgBox("Password is required.", MsgBoxStyle.Information)
        Else
            sql_add_admin = "INSERT INTO EFAS_ADMIN VALUES(null, '" & TXT_ADMIN_FNAME.Text & "', '" & TXT_ADMIN_LNAME.Text & "', '" & TXT_ADMIN_CNUMBER.Text & "', '" & TXT_ADMIN_ADDRESS.Text & "', '" & TXT_ADMIN_EMAIL.Text & "', '" & TXT_ADMIN_USERNAME.Text & "', '" & TXT_ADMIN_PASSWORD.Text & "');"
            MsgBox("A new admin was successfully added.", MsgBoxStyle.OkOnly)
            SQLProcess(sql_add_admin)
            TXT_ADMIN_FNAME.ResetText()
            TXT_ADMIN_LNAME.ResetText()
            TXT_ADMIN_CNUMBER.ResetText()
            TXT_ADMIN_ADDRESS.ResetText()
            TXT_ADMIN_EMAIL.ResetText()
            TXT_ADMIN_USERNAME.ResetText()
            TXT_ADMIN_PASSWORD.ResetText()
        End If
        frmDashboard.Close()
    End Sub

    Private Sub TXT_ADMIN_CNUMBER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ADMIN_CNUMBER.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MsgBox("Number only for contact number.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TXT_ADMIN_PASSWORD_Enter(sender As Object, e As EventArgs) Handles TXT_ADMIN_PASSWORD.Enter
        pnl_SH_BTN.Visible = True
    End Sub

    Private Sub TXT_ADMIN_PASSWORD_Leave(sender As Object, e As EventArgs) Handles TXT_ADMIN_PASSWORD.Leave
        pnl_SH_BTN.Visible = False
    End Sub

    Private Sub BTN_show_hide_confirm_password_Click(sender As Object, e As EventArgs) Handles BTN_show_hide_confirm_password.Click
        If BTN_show_hide_confirm_password.Checked = True Then
            TXT_ADMIN_PASSWORD.PasswordChar = Nothing
            TXT_ADMIN_PASSWORD.UseSystemPasswordChar = False
        Else
            TXT_ADMIN_PASSWORD.UseSystemPasswordChar = True
            pnl_SH_BTN.Show()
        End If
    End Sub
End Class