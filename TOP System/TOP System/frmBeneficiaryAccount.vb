Public Class frmBeneficiaryAccount
    Dim beneficiary_id As Integer

    Private Sub frmBeneficiaryAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        lbl_Time.Text = TimeOfDay.ToString("hh:mm tt")
        lbl_Date.Text = Date.Now.ToString("MMMM d, yyyy")
        beneficiary_id = frmLogin.ben_id
        With frmBeneficiaryDasboard
            BTN_BEN_DASHBOARD.Checked = True
            .TopLevel = False
            PNL_BENEFICIARY_ACCOUNT.Controls.Add(frmBeneficiaryDasboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to Logout?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Me.Refresh()
            frmBeneficiaryDasboard.Close()
            frmBeneficiaryInformation2.Close()
            frmBeneficiaryEmergencyContact.Close()
            frmBeneficiaryLoginInformation.Close()
            Me.Close()
            frmLogin.Show()
            frmDashboard.BringToFront()
        End If
    End Sub

    Private Sub BTN_BEN_MAIN_INFO_Click(sender As Object, e As EventArgs) Handles BTN_BEN_MAIN_INFO.Click
        With frmBeneficiaryInformation2
            .TopLevel = False
            PNL_BENEFICIARY_ACCOUNT.Controls.Add(frmBeneficiaryInformation2)
            .BringToFront()
            .Show()
        End With
        frmBeneficiaryLoginInformation.Close()
    End Sub

    Private Sub BTN_BEN_EC_Click(sender As Object, e As EventArgs) Handles BTN_BEN_EC.Click
        With frmBeneficiaryEmergencyContact
            .TopLevel = False
            PNL_BENEFICIARY_ACCOUNT.Controls.Add(frmBeneficiaryEmergencyContact)
            .BringToFront()
            .Show()
        End With
        frmBeneficiaryLoginInformation.Close()
    End Sub

    Private Sub BTN_BEN_LOG_INFO_Click(sender As Object, e As EventArgs) Handles BTN_BEN_LOG_INFO.Click
        With frmBeneficiaryLoginInformation
            .TopLevel = False
            PNL_BENEFICIARY_ACCOUNT.Controls.Add(frmBeneficiaryLoginInformation)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BTN_BEN_DASHBOARD_Click(sender As Object, e As EventArgs) Handles BTN_BEN_DASHBOARD.Click
        With frmBeneficiaryDasboard
            .TopLevel = False
            PNL_BENEFICIARY_ACCOUNT.Controls.Add(frmBeneficiaryDasboard)
            .BringToFront()
            .Show()
        End With
        frmBeneficiaryLoginInformation.Close()
    End Sub

    Private Sub GunaShadowPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel2.Paint

    End Sub
End Class