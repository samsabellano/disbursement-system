Public Class frmBeneficiaryEmergencyContact
    Dim ID As Integer
    Private Sub frmBeneficiaryEmergencyContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        ID = frmLogin.ben_id

        TXT_EC_FNAME.Text = _get_value("SELECT EC_FIRST_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_FIRST_NAME")
        TXT_EC_LNAME.Text = _get_value("SELECT EC_LAST_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_LAST_NAME")
        TXT_EC_CNUMBER.Text = _get_value("SELECT EC_CONTACT_NUMBER FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_CONTACT_NUMBER")
        TXT_EC_RELATIONSHIP.Text = _get_value("SELECT EC_RELATIONSHIP FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_RELATIONSHIP")

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GunaVSeparator1_Click(sender As Object, e As EventArgs) Handles GunaVSeparator1.Click

    End Sub
End Class