Public Class frmAmountDisbursedDetails
    Dim ID As Integer
    Dim SCHOOL_ID As String
    Private Sub frmAmountDisbursedDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        ID = frmDashboard.BEN_EFAS_ID
        SCHOOL_ID = frmBeneficiaryInformation.TXT_BEN_SCHOOL_ID.Text
        displayRecords("SELECT DISBURSE_AMOUNT, CONTRACT_ID, DISBURSEMENT_DATE, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_DISBURSEMENT EDES
                        WHERE EAD.EFAS_ADMIN_ID = EDES.EFAS_ADMIN_ID AND EDES.SCHOOL_ID = " & SCHOOL_ID & ";", DG_AMOUNT_DISBURSE_DETAILS)
        _loadToComboBox("SELECT MONTH FROM EFAS_MONTH ", CBO_MONTH, "MONTH", "MONTH")
        _loadToComboBox("SELECT YEAR FROM EFAS_YEAR ", CBO_YEAR, "YEAR", "YEAR")
    End Sub

    Private Sub CBO_MONTH_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBO_MONTH.SelectionChangeCommitted
        displayRecords("SELECT DISBURSE_AMOUNT, CONTRACT_ID, DISBURSEMENT_DATE, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_DISBURSEMENT EDES
                         WHERE EAD.EFAS_ADMIN_ID = EDES.EFAS_ADMIN_ID AND EDES.SCHOOL_ID = " & SCHOOL_ID & " AND EDES.DISBURSEMENT_DATE LIKE  '%" & CBO_YEAR.SelectedValue & "%' 
                        AND EDES.DISBURSEMENT_DATE LIKE '%" & CBO_MONTH.SelectedValue & "%' ;", DG_AMOUNT_DISBURSE_DETAILS)
        If CBO_MONTH.SelectedValue = "All" Then
            displayRecords("SELECT DISBURSE_AMOUNT, CONTRACT_ID, DISBURSEMENT_DATE, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_DISBURSEMENT EDES
                        WHERE EAD.EFAS_ADMIN_ID = EDES.EFAS_ADMIN_ID AND EDES.SCHOOL_ID = " & SCHOOL_ID & ";", DG_AMOUNT_DISBURSE_DETAILS)
        End If
    End Sub

    Private Sub CBO_YEAR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBO_YEAR.SelectionChangeCommitted
        displayRecords("SELECT DISBURSE_AMOUNT, CONTRACT_ID, DISBURSEMENT_DATE, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_DISBURSEMENT EDES
                         WHERE EAD.EFAS_ADMIN_ID = EDES.EFAS_ADMIN_ID AND EDES.SCHOOL_ID = " & SCHOOL_ID & " AND EDES.DISBURSEMENT_DATE LIKE  '%" & CBO_YEAR.SelectedValue & "%' 
                        AND EDES.DISBURSEMENT_DATE LIKE '%" & CBO_MONTH.SelectedValue & "%' ;", DG_AMOUNT_DISBURSE_DETAILS)
        If CBO_YEAR.SelectedValue = "All" Then
            displayRecords("SELECT DISBURSE_AMOUNT, CONTRACT_ID, DISBURSEMENT_DATE, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_DISBURSEMENT EDES
                        WHERE EAD.EFAS_ADMIN_ID = EDES.EFAS_ADMIN_ID AND EDES.SCHOOL_ID = " & SCHOOL_ID & ";", DG_AMOUNT_DISBURSE_DETAILS)
        End If
    End Sub
End Class