Public Class frmBeneficiaryLoginInformation
    Dim timer_count As Integer = 16
    Dim ID As Integer
    Dim ver_pass As String
    Private Sub frmBeneficiaryLoginInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        AcceptButton = BTN_SAVE_NEW_PASSWORD
        ID = frmLogin.ben_id
        ver_pass = _get_value("SELECT PASSWORD FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "PASSWORD")

    End Sub

    Private Sub timer_success_Tick(sender As Object, e As EventArgs) Handles timer_success.Tick
        If timer_count = 0 Then
            timer_success.Stop()
            TXT_NEW_PASSWORD.Enabled = False
            LBL_PASSWORD_ALERT.Text = "Create your new password"
            LBL_PASSWORD_ALERT.ForeColor = Color.Teal
            timer_count = 16
        Else
            timer_count -= 1
        End If
    End Sub

    Private Sub TXT_CURRENT_PASSWORD_TextChanged(sender As Object, e As EventArgs) Handles TXT_CURRENT_PASSWORD.TextChanged
        TXT_CURRENT_PASSWORD.ForeColor = Color.Teal
    End Sub

    Private Sub TXT_CURRENT_PASSWORD_Enter(sender As Object, e As EventArgs) Handles TXT_CURRENT_PASSWORD.Enter
        lbl_current_pass.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub TXT_NEW_PASSWORD_Enter(sender As Object, e As EventArgs) Handles TXT_NEW_PASSWORD.Enter
        pnl_SH_BTN_1.Visible = True
        lbl_new_pass.ForeColor = Color.DodgerBlue
        If TXT_CURRENT_PASSWORD.Text = Nothing Then
            MessageBox.Show("Please enter the current password.")
        ElseIf TXT_CURRENT_PASSWORD.Text = ver_pass Then
            PNL_CURRENT_PASS.Visible = True
            TXT_CURRENT_PASSWORD.ForeColor = Color.Teal
            TXT_CURRENT_PASSWORD.LineColor = Color.DodgerBlue
            PNL_CURRENT_PASS.Hide()
        Else
            PNL_CURRENT_PASS.Visible = True
            TXT_CURRENT_PASSWORD.ForeColor = Color.Red
            TXT_CURRENT_PASSWORD.LineColor = Color.Red
            PNL_CURRENT_PASS.Show()
        End If

    End Sub

    Private Sub TXT_NEW_PASSWORD_Leave(sender As Object, e As EventArgs) Handles TXT_NEW_PASSWORD.Leave
        pnl_SH_BTN_1.Visible = False
        pnl_SH_BTN_1.Hide()
        If TXT_NEW_PASSWORD.Text = Nothing Then
            lbl_new_pass.ForeColor = Color.Teal
        End If
    End Sub

    Private Sub TXT_CONFIRM_PASSWORD_Enter(sender As Object, e As EventArgs) Handles TXT_CONFIRM_PASSWORD.Enter
        pnl_SH_BTN_2.Visible = True
        lbl_confirm_pass.ForeColor = Color.DodgerBlue
        If TXT_CURRENT_PASSWORD.Text = Nothing Then
            MessageBox.Show("Please enter the current password.")
        End If
    End Sub

    Private Sub TXT_CONFIRM_PASSWORD_Leave(sender As Object, e As EventArgs) Handles TXT_CONFIRM_PASSWORD.Leave
        pnl_SH_BTN_2.Visible = False
        pnl_SH_BTN_2.Hide()
        If TXT_CONFIRM_PASSWORD.Text = Nothing Then
            lbl_confirm_pass.ForeColor = Color.Teal
        End If
    End Sub

    Private Sub BTN_SAVE_NEW_PASSWORD_Click(sender As Object, e As EventArgs) Handles BTN_SAVE_NEW_PASSWORD.Click

        If TXT_NEW_PASSWORD.Text = Nothing Then
            MessageBox.Show("Password is required!", "INFORMATION")
        ElseIf TXT_NEW_PASSWORD.Text = "Enter new password" Then
            MessageBox.Show("Enter your new password.")
        ElseIf Not TXT_NEW_PASSWORD.Text = TXT_CONFIRM_PASSWORD.Text Then
            MessageBox.Show("Password not matched!", "WARNING")
            'Password verification
        ElseIf TXT_NEW_PASSWORD.Text = ver_pass Then
            MessageBox.Show("The password that you entered is already in use. Please try another password. ")
            TXT_NEW_PASSWORD.Text = Nothing
            TXT_CONFIRM_PASSWORD.Text = Nothing
            lbl_new_pass.ForeColor = Color.Teal
            lbl_confirm_pass.ForeColor = Color.Teal
        Else
            Dim UpdateLoginInfoQuery = "UPDATE EFAS_BENEFICIARY SET PASSWORD = '" & TXT_NEW_PASSWORD.Text & "' WHERE EFAS_BENEFICIARY_ID = " & ID & ";"
            SQLProcess(UpdateLoginInfoQuery)
            timer_success.Start()
            LBL_PASSWORD_ALERT.Text = "Password successfully updated!"
            LBL_PASSWORD_ALERT.ForeColor = Color.Blue
            TXT_CURRENT_PASSWORD.Text = Nothing
            TXT_NEW_PASSWORD.Text = Nothing
            TXT_CONFIRM_PASSWORD.Text = Nothing
            Me.Close()
            frmBeneficiaryAccount.BTN_BEN_LOG_INFO.Checked = False
            frmBeneficiaryAccount.BTN_BEN_DASHBOARD.Checked = True
            frmBeneficiaryDasboard.Show()
        End If
    End Sub

    Private Sub BTN_show_hide_new_password_Click(sender As Object, e As EventArgs) Handles BTN_show_hide_new_password.Click
        If BTN_show_hide_new_password.Checked = True Then
            TXT_NEW_PASSWORD.PasswordChar = Nothing
            TXT_NEW_PASSWORD.UseSystemPasswordChar = False
        Else
            TXT_NEW_PASSWORD.UseSystemPasswordChar = True
            pnl_SH_BTN_1.Show()
        End If
    End Sub

    Private Sub BTN_show_hide_confirm_password_Click(sender As Object, e As EventArgs) Handles BTN_show_hide_confirm_password.Click
        If BTN_show_hide_confirm_password.Checked = True Then
            TXT_CONFIRM_PASSWORD.PasswordChar = Nothing
            TXT_CONFIRM_PASSWORD.UseSystemPasswordChar = False
        Else
            TXT_CONFIRM_PASSWORD.UseSystemPasswordChar = True
            pnl_SH_BTN_2.Show()
        End If
    End Sub
End Class