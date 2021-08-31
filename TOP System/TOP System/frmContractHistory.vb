Public Class frmContractHistory
    Private Sub frmContractHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        displayRecords("SELECT CONCAT(SY.SY_DESCRIPTION, '/', SEM.SEM_DESCRIPTION,  '/B-', ECON.EFAS_BENEFICIARY_ID) AS CONTRACT, EBEN.FIRST_NAME, EBEN.LAST_NAME, ECON.START_DATE, ECON.END_DATE FROM efas_contract ECON, efas_beneficiary EBEN ,EFAS_SCHOOL_YEAR SY, EFAS_SEMESTER SEM WHERE ECON.EFAS_BENEFICIARY_ID = EBEN.EFAS_BENEFICIARY_ID AND ECON.SY_ID= SY.SY_ID AND ECON.SEM_ID=SEM.SEM_ID ORDER BY SY.SY_ID, SEM.SEM_ID;", DG_CONTRACT_HISTORY)

    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        Me.Hide()
        frmContractManagement.Show()
    End Sub

End Class