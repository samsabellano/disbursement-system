Imports Guna.UI.WinForms

Public Class frmDisbursementHome
    Dim pnl_ben As Boolean = True
    Public Shared get_first_name As String
    Public Shared get_last_name As String
    Public Shared get_id_num As Integer
    Public Shared get_status As String
    Public Shared get_year_level As String

    Public Shared getPanel As GunaGradientPanel

    Private Sub frmBeneficiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        pnl_BenMain.Visible = True
        ' Ttip_AddBeneficiary.SetToolTip(btn_addBeneficiary, "Add Beneficiary")
        With pnl_pnlFormHolder
            pnl_frmHolder_Ben.Controls.Add(pnl_pnlFormHolder)
            .BringToFront()
            .Show()
        End With

        ' AcceptButton = btn_search_beneficiary

    End Sub

    Private Sub btn_AddBeneficiary_Click(sender As Object, e As EventArgs)
        pnl_BenMain.Visible = True
    End Sub

    Private Sub btn_addBeneficiary_Click_1(sender As Object, e As EventArgs)
        'pnl_btn_beneficiary.Visible = False

        With frmAddBeneficiary
            .TopLevel = False
            pnl_frmHolder_Ben.Controls.Add(frmAddBeneficiary)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Beneficiary1_Click(sender As Object, e As EventArgs)
        With frmDisbursement
            .TopLevel = False
            pnl_frmHolder_Ben.Controls.Add(frmDisbursement)
            .BringToFront()
            .Show()
            ' pnl_btn_beneficiary.Visible = False
        End With

    End Sub

    Private Sub txt_search_beneficiary_TextChanged(sender As Object, e As EventArgs) Handles txt_search_beneficiary.TextChanged
        Dim get_search As String
        Dim strQuerySearch = "Select * from efas_beneficiary where efas_beneficiary_id like '%" & txt_search_beneficiary.Text & "%' or school_id like '%" & txt_search_beneficiary.Text & "%'"
        get_search = strQuerySearch
        'displayRecords(strQuerySearch, dg)
    End Sub

    Private Sub btn_search_beneficiary_Click(sender As Object, e As EventArgs) Handles btn_search_beneficiary.Click
        If txt_search_beneficiary.Text = "" Then
            MessageBox.Show("This field should not be empty!", "Warning")
        ElseIf Not _isFound_School_ID("SELECT * FROM EFAS_BENEFICIARY", "SCHOOL_ID", txt_search_beneficiary.Text) Then
            MessageBox.Show("Ops! ID did not match!", "Warning")
            txt_search_beneficiary.Text = ""
        Else
            If _isFound_School_ID("SELECT * FROM EFAS_BENEFICIARY", "SCHOOL_ID", txt_search_beneficiary.Text) Then
                get_first_name = _get_value("Select FIRST_NAME from EFAS_BENEFICIARY where SCHOOL_ID = '" & txt_search_beneficiary.Text & "';", "FIRST_NAME")
                get_last_name = _get_value("Select LAST_NAME from EFAS_BENEFICIARY where SCHOOL_ID = '" & txt_search_beneficiary.Text & "';", "LAST_NAME")
                get_id_num = _get_value("Select SCHOOL_ID from EFAS_BENEFICIARY where SCHOOL_ID = '" & txt_search_beneficiary.Text & "';", "SCHOOL_ID")
                get_status = _get_value("Select BENEFICIARY_STATUS from EFAS_BENEFICIARY where SCHOOL_ID = '" & txt_search_beneficiary.Text & "';", "BENEFICIARY_STATUS")
                get_year_level = _get_value("Select STATUS_DESCRIPTION from EFAS_STUDENT_STATUS where SCHOOL_ID = '" & txt_search_beneficiary.Text & "';", "STATUS_DESCRIPTION")

                frmDisbursement.hold_ben_fname = get_first_name
                frmDisbursement.hold_ben_lname = get_last_name
                frmDisbursement.hold_id_num = get_id_num
                frmDisbursement.hold_stud_status = get_status
                frmDisbursement.hold_year_level = get_year_level
                txt_search_beneficiary.Text = ""
                Me.Refresh()
                With frmDisbursement
                    .TopLevel = False
                    pnl_frmHolder_Ben.Controls.Add(frmDisbursement)
                    .BringToFront()
                    .Show()
                    .Refresh()
                    ' pnl_btn_beneficiary.Visible = False
                End With
            End If
        End If

    End Sub

    Private Sub btn_Add_Beneficiary_Click(sender As Object, e As EventArgs)
        With frmAddBeneficiary
            .TopLevel = False
            pnl_frmHolder_Ben.Controls.Add(frmAddBeneficiary)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaShadowPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel2.Paint
        AcceptButton = btn_search_beneficiary
    End Sub
End Class