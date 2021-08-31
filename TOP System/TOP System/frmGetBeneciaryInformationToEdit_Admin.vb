Public Class frmGetBeneciaryInformationToEdit_Admin
    Dim ADDRESS As String
    Dim GENDER As String
    Dim STUDENT_LEVEL As String
    Dim CONTACT_NUMBER As String
    Dim MARITAL_STATUS As String
    Dim EC_RELATIONSHIP As String
    Dim ben_id As String
    Private Sub frmGetBeneciaryInformationToEdit_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        displayRecords("SELECT FIRST_NAME, LAST_NAME, EFAS_BENEFICIARY_ID AS ID FROM EFAS_BENEFICIARY;", DG_BEN_INFO)
        PNL_BEN_INFO_2.Hide()
        PNL_BEN_INFO_3.Hide()

    End Sub

    Private Sub LBL_MORE_INFO_Click(sender As Object, e As EventArgs) Handles LBL_MORE_INFO.Click
        PNL_BEN_INFO_2.Show()
        PNL_BEN_INFO_3.Show()
        Me.LBL_MORE_INFO.Hide()
    End Sub


    Private Sub TXT_SEARCH_BEN_TO_EDIT_Enter(sender As Object, e As EventArgs) Handles TXT_SEARCH_BEN_TO_EDIT.Enter
        If TXT_SEARCH_BEN_TO_EDIT.Text = "Type here to search" Then
            TXT_SEARCH_BEN_TO_EDIT.Text = Nothing
        End If

    End Sub

    Private Sub TXT_SEARCH_BEN_TO_EDIT_Leave(sender As Object, e As EventArgs) Handles TXT_SEARCH_BEN_TO_EDIT.Leave
        If TXT_SEARCH_BEN_TO_EDIT.Text = Nothing Then
            TXT_SEARCH_BEN_TO_EDIT.Text = "Type here to search"
        End If
        displayRecords("SELECT FIRST_NAME, LAST_NAME, EFAS_BENEFICIARY_ID AS ID FROM EFAS_BENEFICIARY;", DG_BEN_INFO)
    End Sub

    Private Sub DG_BEN_INFO_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DG_BEN_INFO.CellEnter
        Try
            Dim ID As Integer
            Dim i = e.RowIndex
            With DG_BEN_INFO
                ID = .Item("ID", i).Value
                TXT_EDIT_BEN_FNAME.Text = .Item("FIRST_NAME", i).Value
                TXT_EDIT_BEN_LNAME.Text = .Item("LAST_NAME", i).Value
                TXT_EDIT_BEN_ADDRESS.Text = _get_value("SELECT ADDRESS FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "ADDRESS")
                TXT_EDIT_BEN_CNUMBER.Text = _get_value("SELECT CONTACT_NUMBER FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "CONTACT_NUMBER")
                TXT_EDIT_BEN_SCHOOL_NAME.Text = _get_value("SELECT SCHOOL_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "SCHOOL_NAME")
                TXT_EDIT_BEN_SCHOOL_ID.Text = _get_value("SELECT SCHOOL_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "SCHOOL_ID")
                LBL_BEN_SCHOOL_ID.Text = _get_value("SELECT SCHOOL_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "SCHOOL_ID")
                TXT_EDIT_BEN_EC_FNAME.Text = _get_value("SELECT EC_FIRST_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_FIRST_NAME")
                TXT_EDIT_BEN_EC_LNAME.Text = _get_value("SELECT EC_LAST_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_LAST_NAME")
                TXT_EDIT_BEN_EC_CNUMBR.Text = _get_value("SELECT EC_CONTACT_NUMBER FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_CONTACT_NUMBER")
                LBL_BEN_STATUS.Text = _get_value("SELECT BENEFICIARY_STATUS FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "BENEFICIARY_STATUS")

                '-->> GETTING THE BENEFICIARY'S MARITAL STATUS
                MARITAL_STATUS = _get_value("SELECT MARITAL_STATUS FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "MARITAL_STATUS")
                If MARITAL_STATUS = "Single" Then
                    RB_SINGLE.Checked = True
                ElseIf MARITAL_STATUS = "Married" Then
                    RB_MARRIED.Checked = True
                ElseIf MARITAL_STATUS = "Separated" Then
                    RB_SEPARATED.Checked = True
                End If
                'END <<--

                '-->> GETTING THE BENEFICIARY'S GENDER
                GENDER = _get_value("SELECT GENDER FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "GENDER")
                If GENDER = "Male" Then
                    RB_MALE.Checked = True
                ElseIf GENDER = "Female" Then
                    RB_FEMALE.Checked = True
                End If
                'END <<--

                '-->> GETTING THE YEAR LEVEL
                STUDENT_LEVEL = _get_value("SELECT STUDENT_YEAR_LEVEL_ID FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "STUDENT_YEAR_LEVEL_ID")
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

                '-->> GETTING THE BENEFICIARY'S EMERGENCY CONTACT
                EC_RELATIONSHIP = _get_value("SELECT EC_RELATIONSHIP FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "EC_RELATIONSHIP")
                If EC_RELATIONSHIP = "Mother" Then
                    RB_MOTHER.Checked = True
                ElseIf EC_RELATIONSHIP = "Father" Then
                    RB_FATHER.Checked = True
                ElseIf EC_RELATIONSHIP = "Brother" Then
                    RB_BROTHER.Checked = True
                ElseIf EC_RELATIONSHIP = "Sister" Then
                    RB_SISTER.Checked = True
                ElseIf EC_RELATIONSHIP = "Guardian" Then
                    RB_GUIARDIAN.Checked = True
                End If
                'END <<--
            End With

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frmBeneficiaryHome.Show()
        DG_BEN_INFO.Refresh()
        CB_PNL_PERSONAL_INFO.Checked = False
        CB_PNL_SCHOOL_INFO.Checked = False
        CB_PNL_EM_CON.Checked = False
        Me.Hide()
    End Sub

    Private Sub TXT_SEARCH_BEN_TO_EDIT_TextChanged(sender As Object, e As EventArgs) Handles TXT_SEARCH_BEN_TO_EDIT.TextChanged
        Dim strQuerySearchBeneficiary = "SELECT FIRST_NAME, LAST_NAME, EFAS_BENEFICIARY_ID FROM EFAS_BENEFICIARY WHERE FIRST_NAME LIKE '%" & TXT_SEARCH_BEN_TO_EDIT.Text & "%' OR LAST_NAME LIKE '%" & TXT_SEARCH_BEN_TO_EDIT.Text & "%' OR EFAS_BENEFICIARY_ID LIKE '%" & TXT_SEARCH_BEN_TO_EDIT.Text & "%'"
        displayRecords(strQuerySearchBeneficiary, DG_BEN_INFO)
    End Sub

    Private Sub CB_PNL_PERSONAL_INFO_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PNL_PERSONAL_INFO.CheckedChanged
        TXT_EDIT_BEN_FNAME.Enabled = True
        TXT_EDIT_BEN_LNAME.Enabled = True
        TXT_EDIT_BEN_ADDRESS.Enabled = True
        TXT_EDIT_BEN_CNUMBER.Enabled = True
        RB_MALE.Enabled = True
        RB_FEMALE.Enabled = True
        RB_SINGLE.Enabled = True
        RB_MARRIED.Enabled = True
        RB_SEPARATED.Enabled = True

        If CB_PNL_PERSONAL_INFO.Checked = False Then
            TXT_EDIT_BEN_FNAME.Enabled = False
            TXT_EDIT_BEN_LNAME.Enabled = False
            TXT_EDIT_BEN_ADDRESS.Enabled = False
            TXT_EDIT_BEN_CNUMBER.Enabled = False
            RB_SINGLE.Enabled = False
            RB_MARRIED.Enabled = False
            RB_SEPARATED.Enabled = False
            RB_MALE.Enabled = False
            RB_FEMALE.Enabled = False
        ElseIf CB_PNL_PERSONAL_INFO.Checked = True Then
            CB_PNL_SCHOOL_INFO.Checked = False
            CB_PNL_EM_CON.Checked = False

        End If
    End Sub

    Private Sub CB_PNL_SCHOOL_INFO_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PNL_SCHOOL_INFO.CheckedChanged
        TXT_EDIT_BEN_SCHOOL_NAME.Enabled = True
        TXT_EDIT_BEN_SCHOOL_ID.Enabled = True
        RB_1ST.Enabled = True
        RB_2ND.Enabled = True
        RB_3RD.Enabled = True
        RB_4TH.Enabled = True

        If CB_PNL_SCHOOL_INFO.Checked = False Then
            TXT_EDIT_BEN_SCHOOL_NAME.Enabled = False
            TXT_EDIT_BEN_SCHOOL_ID.Enabled = False
            RB_1ST.Enabled = False
            RB_2ND.Enabled = False
            RB_3RD.Enabled = False
            RB_4TH.Enabled = False
        ElseIf CB_PNL_SCHOOL_INFO.Checked = True Then
            CB_PNL_PERSONAL_INFO.Checked = False
            CB_PNL_EM_CON.Checked = False

        End If
    End Sub

    Private Sub CB_PNL_EM_CON_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PNL_EM_CON.CheckedChanged
        TXT_EDIT_BEN_EC_FNAME.Enabled = True
        TXT_EDIT_BEN_EC_LNAME.Enabled = True
        TXT_EDIT_BEN_EC_CNUMBR.Enabled = True
        RB_MOTHER.Enabled = True
        RB_FATHER.Enabled = True
        RB_BROTHER.Enabled = True
        RB_SISTER.Enabled = True
        RB_GUIARDIAN.Enabled = True


        If CB_PNL_EM_CON.Checked = False Then
            TXT_EDIT_BEN_EC_FNAME.Enabled = False
            TXT_EDIT_BEN_EC_LNAME.Enabled = False
            TXT_EDIT_BEN_EC_CNUMBR.Enabled = False
            RB_MOTHER.Enabled = False
            RB_FATHER.Enabled = False
            RB_BROTHER.Enabled = False
            RB_SISTER.Enabled = False
            RB_GUIARDIAN.Enabled = False
        ElseIf CB_PNL_EM_CON.Checked = True Then
            CB_PNL_PERSONAL_INFO.Checked = False
            CB_PNL_SCHOOL_INFO.Checked = False
        End If

    End Sub

    Private Sub btn_Edit_Beneficiary_Click(sender As Object, e As EventArgs) Handles btn_Edit_Beneficiary.Click
        Dim gender = ""
        Dim mar_stats = ""
        Dim relationship = ""
        Dim yr_level As Integer
        If CB_PNL_PERSONAL_INFO.Checked = True Then
            If RB_MALE.Checked = True Then
                gender = "Male"
            ElseIf RB_FEMALE.Checked = True Then
                gender = "Female"
            End If

            If RB_SINGLE.Checked = True Then
                mar_stats = "Single"
            ElseIf RB_MARRIED.Checked = True Then
                mar_stats = "Married"
            ElseIf RB_SEPARATED.Checked = True Then
                mar_stats = "Separated"
            End If

            Dim UpdateBeneficiaryQuery = "UPDATE EFAS_BENEFICIARY SET FIRST_NAME = '" & TXT_EDIT_BEN_FNAME.Text & "', LAST_NAME = '" & TXT_EDIT_BEN_LNAME.Text & "', CONTACT_NUMBER = '" & TXT_EDIT_BEN_CNUMBER.Text & "', GENDER = '" & gender & "', MARITAL_STATUS = '" & mar_stats & "' WHERE SCHOOL_ID = '" & LBL_BEN_SCHOOL_ID.Text & "';"
            MessageBox.Show("Personal Information was successfully updated.", "INFORMATION")
            _SQLManager(UpdateBeneficiaryQuery)
            CB_PNL_PERSONAL_INFO.Checked = False
            Me.Close()
            frmBeneficiaryHome.Show()

        ElseIf CB_PNL_SCHOOL_INFO.Checked = True Then
            If RB_1ST.Checked = True Then
                yr_level = 1
            ElseIf RB_2ND.Checked = True Then
                yr_level = 2
            ElseIf RB_3RD.Checked = True Then
                yr_level = 3
            ElseIf RB_4TH.Checked = True Then
                yr_level = 4
            End If

            Dim UpdateBeneficiaryQuery = "UPDATE EFAS_BENEFICIARY SET SCHOOL_NAME = '" & TXT_EDIT_BEN_SCHOOL_NAME.Text & "', SCHOOL_ID = '" & TXT_EDIT_BEN_SCHOOL_ID.Text & "', STUDENT_YEAR_LEVEL_ID = " & yr_level & " WHERE SCHOOL_ID = '" & LBL_BEN_SCHOOL_ID.Text & "';"
            MessageBox.Show("School Information was successfully updated.", "INFORMATION")
            _SQLManager(UpdateBeneficiaryQuery)
            CB_PNL_SCHOOL_INFO.Checked = False
            Me.Close()
            frmBeneficiaryHome.Show()

        ElseIf CB_PNL_EM_CON.Checked = True Then
            If RB_MOTHER.Checked = True Then
                relationship = "Mother"
            ElseIf RB_FATHER.Checked = True Then
                relationship = "Father"
            ElseIf RB_BROTHER.Checked = True Then
                relationship = "Brother"
            ElseIf RB_SISTER.Checked = True Then
                relationship = "Sister"
            ElseIf RB_GUIARDIAN.Checked = True Then
                relationship = "Guardian"
            End If

            Dim UpdateBeneficiaryQuery = "UPDATE EFAS_BENEFICIARY SET EC_FIRST_NAME = '" & TXT_EDIT_BEN_EC_FNAME.Text & "', EC_LAST_NAME = '" & TXT_EDIT_BEN_EC_LNAME.Text & "', C_CONTACT_NUMBER = '" & TXT_EDIT_BEN_EC_CNUMBR.Text & "', EC_RELATIONSHIP = '" & relationship & "' WHERE SCHOOL_ID = '" & LBL_BEN_SCHOOL_ID.Text & "';"
            MessageBox.Show("Emergency Contact was successfully updated.", "INFORMATION")
            _SQLManager(UpdateBeneficiaryQuery)
            CB_PNL_EM_CON.Checked = False
            Me.Close()
            frmBeneficiaryHome.Show()

        End If
    End Sub

End Class