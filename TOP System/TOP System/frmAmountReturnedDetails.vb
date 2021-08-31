Public Class frmAmountReturnedDetails
    Dim ID As Integer
    Dim ADMIN_NAME As String

    Private Sub frmAmountReturnDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        ID = frmDashboard.BEN_EFAS_ID
        displayRecords("SELECT RETURN_AMOUNT, DATE_RETURNED, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_RETURN ERET
                        WHERE EAD.EFAS_ADMIN_ID = ERET.ADMIN_ID AND ERET.BENEFICIARY_ID = " & ID & ";", DG_AMOUNT_RETURN_DETAILS)
        _loadToComboBox("SELECT MONTH FROM EFAS_MONTH ", CBO_MONTH, "MONTH", "MONTH")
        _loadToComboBox("SELECT YEAR FROM EFAS_YEAR ", CBO_YEAR, "YEAR", "YEAR")
    End Sub

    Private Sub CBO_MONTH_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBO_MONTH.SelectionChangeCommitted
        displayRecords("SELECT RETURN_AMOUNT, DATE_RETURNED, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_RETURN ERET
                        WHERE EAD.EFAS_ADMIN_ID = ERET.ADMIN_ID AND ERET.BENEFICIARY_ID = " & ID & " AND ERET.DATE_RETURNED LIKE '%" & CBO_MONTH.SelectedValue & "%';", DG_AMOUNT_RETURN_DETAILS)
        If CBO_MONTH.SelectedValue = "All" Then
            displayRecords("SELECT RETURN_AMOUNT, DATE_RETURNED, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_RETURN ERET
                            WHERE EAD.EFAS_ADMIN_ID = ERET.ADMIN_ID AND ERET.BENEFICIARY_ID = " & ID & ";", DG_AMOUNT_RETURN_DETAILS)
        End If
    End Sub

    Private Sub CBO_YEAR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBO_YEAR.SelectionChangeCommitted
        displayRecords("SELECT RETURN_AMOUNT, DATE_RETURNED, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_RETURN ERET
                        WHERE EAD.EFAS_ADMIN_ID = ERET.ADMIN_ID AND ERET.BENEFICIARY_ID = " & ID & " AND ERET.DATE_RETURNED LIKE '%" & CBO_YEAR.SelectedValue & "%' 
                        AND ERET.DATE_RETURNED LIKE '%" & CBO_MONTH.SelectedValue & "%' ;", DG_AMOUNT_RETURN_DETAILS)
        If CBO_YEAR.SelectedValue = "All" Then
            displayRecords("SELECT RETURN_AMOUNT, DATE_RETURNED, EAD.ADMIN_FIRST_NAME, EAD.ADMIN_LAST_NAME FROM EFAS_ADMIN EAD, EFAS_RETURN ERET
                        WHERE EAD.EFAS_ADMIN_ID = ERET.ADMIN_ID AND ERET.BENEFICIARY_ID = " & ID & ";", DG_AMOUNT_RETURN_DETAILS)
        End If

    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs) Handles GunaSeparator1.Click

    End Sub
End Class