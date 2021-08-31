Public Class frmUpdateContract
    Dim get_beneficiary_id As String
    Dim cid As String
    Dim contract_num As String
    Dim contract_bid As String
    Dim get_date_now As String
    Dim get_time_now As String
    Dim ver_end_date As String
    Private Sub frmUpdateContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        get_date_now = Date.Now.ToString("MMMM d, yyyy")
        get_time_now = TimeOfDay.ToString("hh:mm tt")
        _loadToComboBox("SELECT EFAS_BENEFICIARY_ID, concat(FIRST_NAME,' ',LAST_NAME) as FULLNAME FROM EFAS_BENEFICIARY;", CBO_SEARCH_BENEFICIARY, "FULLNAME", "EFAS_BENEFICIARY_ID")
        PNL_GET_START_DATE.Hide()
        CBO_SEARCH_BENEFICIARY.SelectedIndex = -1
    End Sub

    Private Sub CBO_SEARCH_BENEFICIARY_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBO_SEARCH_BENEFICIARY.SelectionChangeCommitted
        get_beneficiary_id = CBO_SEARCH_BENEFICIARY.SelectedValue.ToString
        ver_end_date = _get_value("SELECT END_DATE FROM EFAS_CONTRACT WHERE EFAS_BENEFICIARY_ID = " & get_beneficiary_id & ";", "END_DATE")
        _loadToComboBox("SELECT CONCAT(SY.SY_DESCRIPTION, '/', SEM.SEM_DESCRIPTION,  '/B-', EFAS_BENEFICIARY_ID) AS CONTRACT, START_DATE FROM EFAS_CONTRACT EC, EFAS_SCHOOL_YEAR SY, EFAS_SEMESTER SEM WHERE SY.SY_ID= EC.SY_ID AND SEM.SEM_ID=EC.SEM_ID AND EFAS_BENEFICIARY_ID = '" & get_beneficiary_id & "' ;", CBO_GET_CONTRACT_ID, "CONTRACT", "START_DATE")
        LBL_GET_START_DATE.Text = CBO_GET_CONTRACT_ID.SelectedValue
        PNL_GET_START_DATE.Show()
        If CBO_GET_CONTRACT_ID.Items.Count = 0 Then
            PNL_GET_START_DATE.Hide()
            MsgBox("BENEFICIARY DOES NOT HAVE ANY CONTRACTS.", vbCritical)
        Else
            If Not ver_end_date = "NO DATE YET" Then
                PNL_GET_START_DATE.Hide()
                CBO_GET_CONTRACT_ID.SelectedIndex = -1
                MsgBox("This Contract ID is already updated.", vbInformation)
            End If
        End If
    End Sub

    Private Sub CBO_GET_CONTRACT_ID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBO_GET_CONTRACT_ID.SelectionChangeCommitted
        LBL_GET_START_DATE.Text = CBO_GET_CONTRACT_ID.SelectedValue
        cid = CBO_GET_CONTRACT_ID.Text
    End Sub

    Private Sub BTN_UPDATE_CONTRACT_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE_CONTRACT.Click
        If TXT_REMARKS.Text = Nothing Then
            MessageBox.Show("Please enter remarks.")
        ElseIf CBO_GET_CONTRACT_ID.SelectedIndex = -1 Then
            MessageBox.Show("Contract ID is required. Please choose.")
        Else
            contract_num = CBO_GET_CONTRACT_ID.Text
            Dim contractArr() As String
            contractArr = contract_num.Split("/")
            Dim contract_yr = contractArr(0)
            Dim contract_sem = contractArr(1)
            contract_bid = contractArr(2).Split("-").Last()

            Dim UpdateContractQuery = "UPDATE EFAS_CONTRACT SET END_DATE = '" & DTP_END_DATE.Text & "', REMARKS = '" & TXT_REMARKS.Text.ToUpper & "'  where EFAS_BENEFICIARY_ID = '" & contract_bid & "' AND SY_ID = (SELECT SY_ID FROM EFAS_SCHOOL_YEAR WHERE SY_DESCRIPTION= '" & contract_yr & "' ) 
                                       AND SEM_ID = (SELECT SEM_ID FROM EFAS_SEMESTER WHERE SEM_DESCRIPTION = '" & contract_sem & "');"
            _SQLManager(UpdateContractQuery)
            MessageBox.Show("Contract Succesfully Updated.")
            frmContractHistory.Close()
            TXT_REMARKS.Text = Nothing
            Me.Refresh()
            PNL_GET_START_DATE.Hide()
            CBO_GET_CONTRACT_ID.SelectedIndex = -1
            CBO_SEARCH_BENEFICIARY.SelectedIndex = -1
        End If
    End Sub

    Private Sub btn_cancel_contract_Click(sender As Object, e As EventArgs) Handles btn_cancel_contract.Click
        Me.Hide()
        frmContractManagement.Show()
        PNL_GET_START_DATE.Hide()
        CBO_GET_CONTRACT_ID.SelectedIndex = -1
        CBO_SEARCH_BENEFICIARY.SelectedIndex = -1
        TXT_REMARKS.ResetText()
    End Sub

    Private Sub CBO_SEARCH_BENEFICIARY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_SEARCH_BENEFICIARY.SelectedIndexChanged

    End Sub
End Class