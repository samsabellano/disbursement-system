Public Class frmReturnAmount
    Dim get_beneficiary_id As String
    Dim admin_id As String
    Dim time_returned As String
    Dim day_returned As String
    Dim day_name As String
    Dim outstanding_balance As Double
    Dim total_disburse_amount As Double
    Dim total_return_amount As Double
    Dim timer_count As Integer = 15
    Private Sub frmReturnAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        PNL_SUCCESS.Hide()
        PNL_PREV_BALANCE.Hide()
        admin_id = frmLogin.get_admin_id
        time_returned = frmMain.lbl_Time.Text
        day_returned = frmMain.lbl_Date.Text
        'day_name = Date.Today.ToString("ddd")
        LBL_ADMIN_NAME.Text = frmLogin.get_account_fname + " " + frmLogin.get_account_lname
        LBL_GET_DATE.Text = Date.Now.ToString("MMMM d, yyyy")
        get_beneficiary_id = _get_value("Select EFAS_BENEFICIARY_ID from EFAS_BENEFICIARY where SCHOOL_ID= '" & frmLoanReturn.get_id_num & "';", "EFAS_BENEFICIARY_ID")

        total_disburse_amount = Val(_get_value("Select SUM(DISBURSE_AMOUNT) from EFAS_DISBURSEMENT where SCHOOL_ID ='" & LBL_STUD_ID.Text & "';", "SUM(DISBURSE_AMOUNT)"))
        total_return_amount = Val(_get_value("Select SUM(RETURN_AMOUNT) from EFAS_RETURN where BENEFICIARY_ID = " & get_beneficiary_id & ";", "SUM(RETURN_AMOUNT)"))
        outstanding_balance = total_disburse_amount - total_return_amount
        LBL_OUTSTANDING_BALANCE.Text = FormatCurrency(outstanding_balance)
        LBL_PREVIOUS_BALANCE.Text = LBL_OUTSTANDING_BALANCE.Text
    End Sub

    Private Sub TXT_NEW_DISBURSE_AMOUNT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_AMOUNT_TO_RETURN.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MessageBox.Show("Allow number and decimal only.")
        End If
    End Sub

    Private Sub TXT_NEW_DISBURSE_AMOUNT_TextChanged(sender As Object, e As EventArgs) Handles TXT_AMOUNT_TO_RETURN.TextChanged
        Dim amt_return As Double = Val(TXT_AMOUNT_TO_RETURN.Text)
        LBL_OUTSTANDING_BALANCE.Text = FormatCurrency(outstanding_balance - amt_return)
        PNL_PREV_BALANCE.Show()
        If LBL_OUTSTANDING_BALANCE.Text = LBL_PREVIOUS_BALANCE.Text Then
            PNL_PREV_BALANCE.Hide()
        ElseIf LBL_OUTSTANDING_BALANCE.Text < 0 Then
            MessageBox.Show("Overpaid.", "Information")
            TXT_AMOUNT_TO_RETURN.Text = Nothing
            LBL_OUTSTANDING_BALANCE.Text = LBL_PREVIOUS_BALANCE.Text
        ElseIf LBL_OUTSTANDING_BALANCE.Text = "0.00" Then
            Dim balance_status = "PAID"
            LBL_OUTSTANDING_BALANCE.Text = LBL_OUTSTANDING_BALANCE.Text + " / " + balance_status
        End If
    End Sub

    Private Sub BTN_RETURN_AMOUNT_Click(sender As Object, e As EventArgs) Handles BTN_RETURN_AMOUNT.Click
        If TXT_AMOUNT_TO_RETURN.Text = Nothing Then
            MessageBox.Show("Please enter amount to return.", "Information")
            TXT_AMOUNT_TO_RETURN.LineColor = Color.Red
        Else
            Dim get_school_id = _get_value("SELECT SCHOOL_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & get_beneficiary_id & ";", "SCHOOL_ID")
            Dim sql_return_amount = "INSERT INTO EFAS_RETURN VALUES(null," & get_beneficiary_id & ", " & get_school_id & ", " & TXT_AMOUNT_TO_RETURN.Text & ",'" & LBL_GET_DATE.Text & "', '" & time_returned & "', " & admin_id & ");"
            SQLProcess(sql_return_amount)
            frmDashboard.Close()
            frmAmountBalanceDetails.Close()
            timer_success.Start()
            PNL_SUCCESS.Show()
            TXT_AMOUNT_TO_RETURN.Text = Nothing
            Me.Refresh()
            total_disburse_amount = Val(_get_value("Select SUM(DISBURSE_AMOUNT) from EFAS_DISBURSEMENT where SCHOOL_ID ='" & LBL_STUD_ID.Text & "';", "SUM(DISBURSE_AMOUNT)"))
            total_return_amount = Val(_get_value("Select SUM(RETURN_AMOUNT) from EFAS_RETURN where BENEFICIARY_ID = " & get_beneficiary_id & ";", "SUM(RETURN_AMOUNT)"))
            outstanding_balance = total_disburse_amount - total_return_amount
            LBL_OUTSTANDING_BALANCE.Text = FormatCurrency(outstanding_balance)
            LBL_PREVIOUS_BALANCE.Text = LBL_OUTSTANDING_BALANCE.Text
        End If
    End Sub

    Private Sub btn_exit_account_Click(sender As Object, e As EventArgs) Handles btn_exit_account.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to Logout?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Me.Refresh()
            Me.Close()
            frmLoanReturn.Show()

        End If
    End Sub

    Private Sub timer_success_Tick(sender As Object, e As EventArgs) Handles timer_success.Tick
        If timer_count = 0 Then
            timer_success.Stop()
            PNL_SUCCESS.Hide()
            timer_count = 15
        Else
            timer_count -= 1
        End If
    End Sub
End Class