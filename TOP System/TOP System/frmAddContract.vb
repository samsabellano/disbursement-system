Public Class frmAddContract
    Dim get_ben_id As String
    Dim get_sem_desc As String
    Dim get_sy_year As String
    Dim sql_add_contract As String
    Dim contract_id As String

    Private Sub frmAddContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        PNL_CONTRACT_ID.Hide()
        PNL_LOGIN_AGREE_CONTRACT.Hide()
        _loadToComboBox("SELECT SY_DESCRIPTION, SY_ID FROM EFAS_SCHOOL_YEAR; ", CBO_SCHOOL_YEAR, "SY_DESCRIPTION", "SY_ID")
        _loadToComboBox("SELECT SEM_DESCRIPTION, SEM_ID FROM EFAS_SEMESTER; ", CBO_SEMESTER, "SEM_DESCRIPTION", "SEM_ID")
        _loadToComboBox("SELECT EFAS_BENEFICIARY_ID, concat(FIRST_NAME,' ',LAST_NAME) as FULLNAME FROM EFAS_BENEFICIARY;", CBO_BENEFICIARY_NAME_LIST, "FULLNAME", "EFAS_BENEFICIARY_ID")
        CBO_BENEFICIARY_NAME_LIST.SelectedIndex = -1
        CBO_SCHOOL_YEAR.SelectedIndex = -1
        CBO_SEMESTER.SelectedIndex = -1
    End Sub

    Private Sub BTN_CONTINUE_CONTRACT_ID_Click(sender As Object, e As EventArgs) Handles BTN_DONE.Click
        PNL_CONTRACT_ID.Hide()
        pnl_contract_info.Show()
        CB_AGREE.Checked = False
        CBO_BENEFICIARY_NAME_LIST.SelectedIndex = -1
        CBO_SCHOOL_YEAR.SelectedIndex = -1
        CBO_SEMESTER.SelectedIndex = -1
        frmDisbursement.Close()
        Me.Refresh()
    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        Me.Hide()
        frmContractManagement.Show()
    End Sub

    Private Sub pnl_contract_info_Paint(sender As Object, e As PaintEventArgs) Handles pnl_contract_info.Paint
        AcceptButton = BTN_CONTINUE
    End Sub

    Private Sub CB_AGREE_CheckedChanged(sender As Object, e As EventArgs) Handles CB_AGREE.CheckedChanged
        If CB_AGREE.Checked = True Then
            CB_AGREE.ForeColor = Color.DodgerBlue
            BTN_CONTINUE.Enabled = True
        Else
            CB_AGREE.ForeColor = Color.SkyBlue
            BTN_CONTINUE.Enabled = False
        End If
    End Sub

    Private Sub BTN_CONTINUE_Click(sender As Object, e As EventArgs) Handles BTN_CONTINUE.Click
        If TXT_TERMS_OF_CONTRACT.Text = Nothing Then
            MsgBox("Terms is required", MsgBoxStyle.Exclamation)
            BTN_CONTINUE.Enabled = False
            CB_AGREE.Checked = False
            pnl_contract_info.Show()
        Else
            PNL_CONTRACT_ID.Show()
            PNL_LOGIN_AGREE_CONTRACT.Show()
            pnl_contract_info.Hide()

        End If

    End Sub

    Private Sub BTN_CANCEL_AGREEMENT_Click(sender As Object, e As EventArgs) Handles BTN_CANCEL_AGREEMENT.Click
        PNL_CONTRACT_ID.Hide()
        pnl_contract_info.Show()
        CB_AGREE.Checked = False
        TXT_BENEFICIARY_PASSWORD.ResetText()

    End Sub

    Private Sub BTN_CONFIRM_AGREEMENT_Click(sender As Object, e As EventArgs) Handles BTN_CONFIRM_AGREEMENT.Click
        Dim ben_password As String
        get_ben_id = _get_value("SELECT EFAS_BENEFICIARY_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = '" & CBO_BENEFICIARY_NAME_LIST.SelectedValue & "';", "EFAS_BENEFICIARY_ID")
        ben_password = _get_value("SELECT PASSWORD FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & get_ben_id & ";", "PASSWORD")

        If TXT_BENEFICIARY_PASSWORD.Text <> ben_password Then
            MsgBox("Password not matched. Please try again.", MsgBoxStyle.Exclamation)
            TXT_BENEFICIARY_PASSWORD.Text = Nothing
        Else
            get_sy_year = _get_value("SELECT SY_DESCRIPTION FROM EFAS_SCHOOL_YEAR WHERE SY_ID = '" & CBO_SCHOOL_YEAR.SelectedValue & "';", "SY_DESCRIPTION")
            get_sem_desc = _get_value("SELECT SEM_DESCRIPTION FROM EFAS_SEMESTER WHERE SEM_ID = '" & CBO_SEMESTER.SelectedValue & "';", "SEM_DESCRIPTION")
            sql_add_contract = "INSERT INTO EFAS_CONTRACT VALUES('" & TXT_TERMS_OF_CONTRACT.Text & "','" & DTP_START_DATE.Text & "', 'NO DATE YET', 'N/A'," & get_ben_id & "," & CBO_SCHOOL_YEAR.SelectedValue & ", " & CBO_SEMESTER.SelectedValue & " );"
            SQLProcess(sql_add_contract)
            TXT_BENEFICIARY_PASSWORD.ResetText()
            PNL_CONTRACT_ID.BringToFront()
            PNL_LOGIN_AGREE_CONTRACT.Hide()
            TXT_GET_CONTRACT_ID_TO_SHOW.Text = get_sy_year + "/" + get_sem_desc + "/B-" + get_ben_id
            TXT_TERMS_OF_CONTRACT.ResetText()
            Me.Refresh()
            frmContractHistory.Close()

            _loadToComboBox("SELECT SY_DESCRIPTION, SY_ID FROM EFAS_SCHOOL_YEAR; ", CBO_SCHOOL_YEAR, "SY_DESCRIPTION", "SY_ID")
            _loadToComboBox("SELECT SEM_DESCRIPTION, SEM_ID FROM EFAS_SEMESTER; ", CBO_SEMESTER, "SEM_DESCRIPTION", "SEM_ID")
            _loadToComboBox("SELECT EFAS_BENEFICIARY_ID, concat(FIRST_NAME,' ',LAST_NAME) as FULLNAME FROM EFAS_BENEFICIARY;", CBO_BENEFICIARY_NAME_LIST, "FULLNAME", "EFAS_BENEFICIARY_ID")
            End If
    End Sub

End Class