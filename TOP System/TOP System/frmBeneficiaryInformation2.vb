Public Class frmBeneficiaryInformation2
    Dim ID As Integer
    Dim GENDER As String
    Dim MARITAL_STATUS As String
    Dim STUDENT_LEVEL As String
    Private Sub frmBeneficiaryInformation2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        ID = frmLogin.ben_id
        TXT_BEN_ADDRESS.Text = _get_value("SELECT ADDRESS FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "ADDRESS")
        TXT_BEN_CNUMBER.Text = _get_value("SELECT CONTACT_NUMBER FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "CONTACT_NUMBER")
        TXT_BEN_SCHOOL_NAME.Text = _get_value("SELECT SCHOOL_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = '" & ID & "';", "SCHOOL_NAME")
        TXT_BEN_SCHOOL_ID.Text = _get_value("SELECT SCHOOL_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = '" & ID & "';", "SCHOOL_ID")
        '-->> GETTING THE BENEFICIARY'S GENDER
        GENDER = _get_value("SELECT GENDER FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = '" & ID & "';", "GENDER")
        If GENDER = "Male" Then
            RB_MALE.Checked = True
        ElseIf GENDER = "Female" Then
            RB_FEMALE.Checked = True
        End If
        'END <<--
        '-->> GETTING THE BENEFICIARY'S MARITAL STATUS
        MARITAL_STATUS = _get_value("SELECT MARITAL_STATUS FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = '" & ID & "';", "MARITAL_STATUS")
        If MARITAL_STATUS = "Single" Then
            RB_SINGLE.Checked = True
        ElseIf MARITAL_STATUS = "Married" Then
            RB_MARRIED.Checked = True
        ElseIf MARITAL_STATUS = "Separated" Then
            RB_SEPARATED.Checked = True
        End If
        'END <<--
        '-->> GETTING THE YEAR LEVEL
        STUDENT_LEVEL = _get_value("SELECT STUDENT_YEAR_LEVEL_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = '" & ID & "';", "STUDENT_YEAR_LEVEL_ID")
        If STUDENT_LEVEL = 1 Then
            RB_1ST.Checked = True
        ElseIf STUDENT_LEVEL = 2 Then
            RB_2ND.Checked = True
        ElseIf STUDENT_LEVEL = 3 Then
            RB_3RD.Checked = True
        ElseIf STUDENT_LEVEL = 4 Then
            RB_4TH.Checked = True
        End If
        'END <<--
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class