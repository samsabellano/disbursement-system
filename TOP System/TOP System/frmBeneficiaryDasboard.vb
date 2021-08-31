Public Class frmBeneficiaryDasboard
    Dim ID As Integer
    Dim SCHOOL_ID As String
    Dim total_disbursed As Double
    Dim outstanding_balance As Double

    Private Sub frmBeneficiaryDasboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        ID = frmLogin.ben_id
        SCHOOL_ID = frmLogin.stud_id
        LBL_BEN_TOTAL_D_AMOUNT.Text = FormatCurrency(Val(_get_value("Select SUM(DISBURSE_AMOUNT) from EFAS_DISBURSEMENT where school_id = '" & SCHOOL_ID & "';", "SUM(DISBURSE_AMOUNT)")))
        LBL_BEN_TOTAL_R_AMOUNT.Text = FormatCurrency(Val(_get_value("Select SUM(RETURN_AMOUNT) from EFAS_RETURN where BENEFICIARY_ID = " & ID & " AND SCHOOL_ID = '" & SCHOOL_ID & "';", "SUM(RETURN_AMOUNT)")))
        outstanding_balance = LBL_BEN_TOTAL_D_AMOUNT.Text - LBL_BEN_TOTAL_R_AMOUNT.Text
        TXT_BEN_TOTAL_BALANCE.Text = FormatCurrency(outstanding_balance)
        ToolTip_Disburse.SetToolTip(PNL_DISBURSE, "Total Amount Disbursed")
        ToolTip_Return.SetToolTip(PNL_RETURN, "Total Amount Returned")

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        If TXT_BEN_TOTAL_BALANCE.Enabled = False Then
            TXT_BEN_TOTAL_BALANCE.ForeColor = Color.MediumSeaGreen
        End If

    End Sub

End Class