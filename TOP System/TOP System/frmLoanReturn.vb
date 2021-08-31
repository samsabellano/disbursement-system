Public Class frmLoanReturn
    Public Shared get_id_num As String
    Private Sub frmLoanReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
    End Sub

    Private Sub BTN_SEARCH_TO_RETURN_LOAN_Click(sender As Object, e As EventArgs) Handles BTN_SEARCH_TO_RETURN_LOAN.Click
        If TXT_SEARCH_BEN_ID_4RETURN.Text = Nothing Then
            MessageBox.Show("This field should not be empty!", "Warning")
        ElseIf Not _isFound_School_ID("SELECT * FROM EFAS_DISBURSEMENT", "SCHOOL_ID", TXT_SEARCH_BEN_ID_4RETURN.Text) Then
            MessageBox.Show("Ops! ID did not match. It seems that this account does not have a disbursement." & vbNewLine & "Please make a disbursement and try again.", "Warning")
            TXT_SEARCH_BEN_ID_4RETURN.Text = Nothing
        Else
            If _isFound_School_ID("SELECT * FROM EFAS_DISBURSEMENT", "SCHOOL_ID", TXT_SEARCH_BEN_ID_4RETURN.Text) Then
                Dim get_first_name = _get_value("Select FIRST_NAME from EFAS_BENEFICIARY where SCHOOL_ID = '" & TXT_SEARCH_BEN_ID_4RETURN.Text & "';", "FIRST_NAME")
                Dim get_last_name = _get_value("Select LAST_NAME from EFAS_BENEFICIARY where SCHOOL_ID = '" & TXT_SEARCH_BEN_ID_4RETURN.Text & "';", "LAST_NAME")
                get_id_num = _get_value("Select SCHOOL_ID from EFAS_BENEFICIARY where SCHOOL_ID = '" & TXT_SEARCH_BEN_ID_4RETURN.Text & "';", "SCHOOL_ID")
                Dim get_status = _get_value("Select BENEFICIARY_STATUS from EFAS_BENEFICIARY where SCHOOL_ID = '" & TXT_SEARCH_BEN_ID_4RETURN.Text & "';", "BENEFICIARY_STATUS")
                Dim get_year_level = _get_value("Select STATUS_DESCRIPTION from EFAS_STUDENT_STATUS where SCHOOL_ID = '" & TXT_SEARCH_BEN_ID_4RETURN.Text & "';", "STATUS_DESCRIPTION")
                frmReturnAmount.LBL_BENEFICIARY_FULLNAME.Text = get_first_name + " " + get_last_name
                frmReturnAmount.LBL_STUD_ID.Text = get_id_num
                frmReturnAmount.LBL_STATUS.Text = get_status
                TXT_SEARCH_BEN_ID_4RETURN.Text = Nothing
                With frmReturnAmount
                    .TopLevel = False
                    PNL_LOAN_HOLDER.Controls.Add(frmReturnAmount)
                    .BringToFront()
                    .Show()
                End With
                Me.Refresh()
            End If
        End If

    End Sub

    Private Sub GunaShadowPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel2.Paint
        AcceptButton = BTN_SEARCH_TO_RETURN_LOAN
    End Sub
End Class