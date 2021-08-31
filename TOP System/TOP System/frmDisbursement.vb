
Public Class frmDisbursement
    Public Shared hold_ben_fname As String
    Public Shared hold_ben_lname As String
    Public Shared hold_id_num As String
    Public Shared hold_stud_status As String
    Public Shared hold_year_level As String
    Public Shared hold_date As String
    Public Shared hold_admin_id As String
    Public Shared get_beneficiary_id As String
    Dim sql_insert_disbursement As String
    Dim get_beneficiary_no_permit As String
    Dim get_admin_fname As String
    Dim get_admin_lname As String
    Public Shared ben_id_pref = "B-"
    Dim no_permit = "NO PERMIT"
    Dim ver_permit As String

    Private Sub frmBeneficiaryAccount_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        PNL_DISBURSEMENT_LOGIN.BringToFront()
        lb_benef_full_name.Text = hold_ben_fname + " " + hold_ben_lname
        LBL_STUD_ID.Text = hold_id_num
        lbl_status.Text = hold_stud_status
        LBL_ADMIN_NAME.Text = frmMain.txt_Get_Name.Text

        LBL_GET_DATE.Text = Date.Now.ToString("MMMM d, yyyy")
        LBL_ENTER_B_PASS.Text = "Enter " + hold_ben_fname + "'s password."
        tool_tip_exit.SetToolTip(btn_exit_account, "Exit")
        beneficiary_animatedWindow.Start()
        lbl_disburse_amount.Visible = False

        get_beneficiary_id = _get_value("Select EFAS_BENEFICIARY_ID from EFAS_BENEFICIARY where SCHOOL_ID= '" & LBL_STUD_ID.Text & "';", "EFAS_BENEFICIARY_ID")
        _loadToComboBox("SELECT CONCAT(SY.SY_DESCRIPTION, '/', SEM.SEM_DESCRIPTION,  '/B-', EFAS_BENEFICIARY_ID) AS CONTRACT, START_DATE FROM EFAS_CONTRACT EC, EFAS_SCHOOL_YEAR SY, EFAS_SEMESTER SEM WHERE SY.SY_ID= EC.SY_ID AND SEM.SEM_ID=EC.SEM_ID AND EFAS_BENEFICIARY_ID = " & get_beneficiary_id & ";", CBO_GET_CONTRACT_ID, "CONTRACT", "START_DATE")
        _loadToComboBox("SELECT PURPOSE_DESCRIPTION, PURPOSE_ID FROM EFAS_PURPOSE ", CBO_GET_PURPOSE, "PURPOSE_DESCRIPTION", "PURPOSE_ID")
        _loadToComboBox("SELECT CONTRACT_ID FROM EFAS_DISBURSEMENT WHERE PERMIT_NUMBER = '" & no_permit & "' AND SCHOOL_ID = '" & LBL_STUD_ID.Text & "'", CBO_NO_PERMIT_CONT_ID, "CONTRACT_ID", "CONTRACT_ID")

        LBL_GET_TOTAL_DISBURSED.Text = FormatCurrency(Val(_get_value("Select SUM(DISBURSE_AMOUNT) from EFAS_DISBURSEMENT where SCHOOL_ID = '" & LBL_STUD_ID.Text & "';", "SUM(DISBURSE_AMOUNT)")))
        PNL_CURRENT_DISB_AMOUNT.Hide()
        LBL_GET_CURRENT_DISB_AMOUNT.Text = LBL_GET_TOTAL_DISBURSED.Text

        CBO_GET_CONTRACT_ID.SelectedIndex = -1
        CBO_GET_PURPOSE.SelectedIndex = -1
    End Sub

    Private Sub btn_exit_account_Click(sender As Object, e As EventArgs) Handles btn_exit_account.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to Logout?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Me.Refresh()
            Me.Close()
            frmDisbursementHome.Show()
            PNL_DISBURSE.BringToFront()
        End If
    End Sub

    Private Sub btn_dsbursement_ben_login_Click(sender As Object, e As EventArgs) Handles btn_dsbursement_ben_login.Click
        dbConnection()
        If txt_disbursement_ben_pass.Text = "" Then
            MessageBox.Show("Please enter the password", "WARNING")
        ElseIf Not _isValid("SELECT * FROM EFAS_BENEFICIARY", "PASSWORD", "SCHOOL_ID", txt_disbursement_ben_pass.Text, LBL_STUD_ID.Text) Then
            MessageBox.Show("Password not matched!", "WARNING")
            txt_disbursement_ben_pass.Text = ""
        Else
            If _isValid("SELECT * FROM EFAS_BENEFICIARY", "PASSWORD", "SCHOOL_ID", txt_disbursement_ben_pass.Text, LBL_STUD_ID.Text) Then
                PNL_DISBURSEMENT_LOGIN.SendToBack()
                PNL_DISBURSE.BringToFront()
                txt_disbursement_ben_pass.Text = ""
            Else
                MessageBox.Show("Please check the password!", "WARNING")
                txt_disbursement_ben_pass.Text = ""
            End If
        End If
    End Sub

    Private Sub TXT_NEW_DISBURSE_AMOUNT_TextChanged(sender As Object, e As EventArgs) Handles TXT_NEW_DISBURSE_AMOUNT.TextChanged
        Dim curr_total_amt As Double = Val(_get_value("Select SUM(DISBURSE_AMOUNT) from EFAS_DISBURSEMENT where SCHOOL_ID = '" & LBL_STUD_ID.Text & "';", "SUM(DISBURSE_AMOUNT)"))
        Dim disb_amt As Double = Val(TXT_NEW_DISBURSE_AMOUNT.Text)
        LBL_GET_TOTAL_DISBURSED.Text = FormatCurrency(curr_total_amt + disb_amt)
        PNL_CURRENT_DISB_AMOUNT.Show()
        If LBL_GET_CURRENT_DISB_AMOUNT.Text = LBL_GET_TOTAL_DISBURSED.Text Then
            PNL_CURRENT_DISB_AMOUNT.Hide()
        End If
    End Sub

    Private Sub TXT_NEW_DISBURSE_AMOUNT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NEW_DISBURSE_AMOUNT.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MessageBox.Show("Allow number and decimal only.")
        End If
    End Sub

    Private Sub BTN_SUBMIT_DISBURSEMENT_Click(sender As Object, e As EventArgs) Handles BTN_SUBMIT_DISBURSEMENT.Click
        Dim dAmount As Double
        Dim AMOUNT As Double
        If CBO_GET_CONTRACT_ID.SelectedIndex = -1 Then
            MsgBox("Please choose a Contract ID for your disbursement.", MsgBoxStyle.Information)
        ElseIf CBO_GET_PURPOSE.SelectedIndex = -1 Then
            MsgBox("Please select a purpose for your disbursement.", MsgBoxStyle.Information)
        ElseIf TXT_NEW_DISBURSE_AMOUNT.Text = Nothing Then
            MsgBox("Please enter an amount for your disbursement.", MsgBoxStyle.Information)
        Else
            If txt_permit_no.Text = Nothing Then
                TXT_NEW_PERMIT_NUMBER.Text = no_permit
                dAmount = TXT_NEW_DISBURSE_AMOUNT.Text
                AMOUNT = FormatNumber(dAmount, 2)
                sql_insert_disbursement = "INSERT INTO EFAS_DISBURSEMENT VALUE(null, '" & CBO_GET_CONTRACT_ID.Text & "', " & hold_admin_id & ", " & LBL_STUD_ID.Text & ", '" & LBL_GET_DATE.Text & "', '" & TXT_NEW_PERMIT_NUMBER.Text.ToUpper & "', " & AMOUNT & ", " & CBO_GET_PURPOSE.SelectedValue & ");"
                SQLProcess(sql_insert_disbursement)
                MessageBox.Show("Success!")
                frmDashboard.Close()
                frmReturnAmount.Close()
                frmAmountBalanceDetails.Close()
                TXT_NEW_DISBURSE_AMOUNT.ResetText()
                TXT_NEW_PERMIT_NUMBER.ResetText()
                CBO_GET_CONTRACT_ID.SelectedIndex = -1
                CBO_GET_PURPOSE.SelectedIndex = -1
                LBL_GET_TOTAL_DISBURSED.Text = FormatCurrency(Val(_get_value("Select SUM(DISBURSE_AMOUNT) from EFAS_DISBURSEMENT where SCHOOL_ID = '" & LBL_STUD_ID.Text & "';", "SUM(DISBURSE_AMOUNT)")))
                LBL_GET_CURRENT_DISB_AMOUNT.Text = LBL_GET_TOTAL_DISBURSED.Text
                PNL_CURRENT_DISB_AMOUNT.Hide()
                Me.Refresh()
                CBO_NO_PERMIT_CONT_ID.Refresh()
            End If
        End If
    End Sub

    Private Sub GunaShadowPanel5_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel5.Paint
        AcceptButton = btn_dsbursement_ben_login
    End Sub

    Private Sub GunaShadowPanel7_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel7.Paint
        AcceptButton = BTN_SUBMIT_DISBURSEMENT
    End Sub

    Private Sub BTN_UPDATE_PERMIT_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE_PERMIT.Click
        If CBO_NO_PERMIT_CONT_ID.SelectedIndex = -1 Then
            MsgBox("Please select a Contract ID to update.", MsgBoxStyle.Information)
        ElseIf TXT_UPDATE_PERMIT_NUMBER.Text = Nothing Then
            MsgBox("Opps! Permit number is required.", MsgBoxStyle.Information)
        Else
            Dim UpdatePermitQuery = "UPDATE EFAS_DISBURSEMENT SET PERMIT_NUMBER = '" & TXT_UPDATE_PERMIT_NUMBER.Text.ToUpper & "' WHERE CONTRACT_ID = '" & CBO_NO_PERMIT_CONT_ID.Text & "'"
            _SQLManager(UpdatePermitQuery)
            TXT_UPDATE_PERMIT_NUMBER.ResetText()
            CBO_NO_PERMIT_CONT_ID.Refresh()
            CBO_NO_PERMIT_CONT_ID.SelectedIndex = -1
            MsgBox("Permit was succesfully updated.", vbInformation)
            _loadToComboBox("SELECT CONTRACT_ID FROM EFAS_DISBURSEMENT WHERE PERMIT_NUMBER = '" & no_permit & "' AND SCHOOL_ID = '" & LBL_STUD_ID.Text & "'", CBO_NO_PERMIT_CONT_ID, "CONTRACT_ID", "CONTRACT_ID")
        End If

    End Sub
End Class