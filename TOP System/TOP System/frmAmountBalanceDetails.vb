Public Class frmAmountBalanceDetails
    Dim ID As String
    Dim total_amount_disbursed As Double
    Dim total_amount_returned As Double
    Dim SCHOOL_ID As String
    Private Sub frmAmountBalanceDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        ID = frmDashboard.BEN_EFAS_ID
        SCHOOL_ID = _get_value("SELECT SCHOOL_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "SCHOOL_ID")
        total_amount_disbursed = FormatCurrency(Val(_get_value("SELECT SUM(DISBURSE_AMOUNT) FROM EFAS_DISBURSEMENT WHERE SCHOOL_ID = '" & SCHOOL_ID & "';", "SUM(DISBURSE_AMOUNT)")))
        total_amount_returned = FormatCurrency(Val(_get_value("SELECT SUM(RETURN_AMOUNT) FROM EFAS_RETURN WHERE SCHOOL_ID = '" & SCHOOL_ID & "' AND BENEFICIARY_ID = " & ID & ";", "SUM(RETURN_AMOUNT)")))
        TXT_BEN_TOTAL_BALANCE.Text = FormatCurrency(total_amount_disbursed - total_amount_returned)
    End Sub
End Class