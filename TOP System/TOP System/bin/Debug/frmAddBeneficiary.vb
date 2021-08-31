
Public Class frmAddBeneficiary
    Dim result As Integer
    Dim sql_add_beneficiary As String
    Dim year_level As Integer
    Public Shared getSchool_id As Integer

    Private Sub frmAddBeneficiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        CBO_B_GENDER.Items.Add("Male")
        CBO_B_GENDER.Items.Add("Female")

        CBO_B_MARITAL_STATUS.Items.Add("Single")
        CBO_B_MARITAL_STATUS.Items.Add("Married")
        CBO_B_MARITAL_STATUS.Items.Add("Separated")

        CBO_B_EC_RELATIONSHIP.Items.Add("Mother")
        CBO_B_EC_RELATIONSHIP.Items.Add("Father")
        CBO_B_EC_RELATIONSHIP.Items.Add("Sister")
        CBO_B_EC_RELATIONSHIP.Items.Add("Brother")
        CBO_B_EC_RELATIONSHIP.Items.Add("Guardian")
        AcceptButton = BTN_SUBMIT_BENEFICIARY

    End Sub

    Private Sub BTN_SUBMIT_BENEFICIARY_Click(sender As Object, e As EventArgs) Handles BTN_SUBMIT_BENEFICIARY.Click
        If TXT_B_FNAME.Text = Nothing And TXT_B_LNAME.Text = Nothing And TXT_B_ADDRESS.Text = Nothing And TXT_B_CNUMBER.Text = Nothing And TXT_B_EMAIL.Text = Nothing And TXT_B_USERNAME.Text = Nothing And TXT_B_PASSWORD.Text = Nothing And TXT_B_SCHOOL_NAME.Text = Nothing And TXT_B_SCHOOL_ID.Text = Nothing And TXT_B_EC_FNAME.Text = Nothing And TXT_B_EC_LNAME.Text = Nothing And TXT_B_EC_CNUMBER.Text = Nothing Then
            MsgBox("Please fill the empty fields.", MsgBoxStyle.Information)
        ElseIf TXT_B_FNAME.Text = Nothing Then
            MsgBox("Firstname is required.", MsgBoxStyle.Exclamation)
        ElseIf TXT_B_LNAME.Text = Nothing Then
            MsgBox("Lastname is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_ADDRESS.Text = Nothing Then
            MsgBox("Address is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_CNUMBER.Text = Nothing Then
            MsgBox("Contact number is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_CNUMBER.Text.Length <= 10 Then
            MsgBox("Contact number must contain 11 digits.", MsgBoxStyle.Information)
        ElseIf TXT_B_EMAIL.Text = Nothing Then
            MsgBox("Emial s required.", MsgBoxStyle.Information)
        ElseIf Not TXT_B_EMAIL.Text.Contains("@") Then
            MsgBox("Email must include ""@"".", MsgBoxStyle.Information)
        ElseIf TXT_B_USERNAME.Text = Nothing Then
            MsgBox("Usernmae is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_PASSWORD.Text = Nothing Then
            MsgBox("Password is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_SCHOOL_NAME.Text = Nothing Then
            MsgBox("Name of school is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_SCHOOL_ID.Text = Nothing Then
            MsgBox("School ID is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_EC_FNAME.Text = Nothing Then
            MsgBox("Firstname of beneficiary is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_EC_LNAME.Text = Nothing Then
            MsgBox("Lastname of beneficiary is required.", MsgBoxStyle.Information)
        ElseIf TXT_B_EC_CNUMBER.Text = Nothing Then
            MsgBox("Contact number of beneficiary is required.", MsgBoxStyle.Information)
        ElseIf CBO_B_GENDER.SelectedIndex = -1 Then
            MsgBox("Gender is required.", MsgBoxStyle.Information)
        ElseIf CBO_B_MARITAL_STATUS.SelectedIndex = -1 Then
            MsgBox("Marital status is required.", MsgBoxStyle.Information)
        ElseIf CBO_B_EC_RELATIONSHIP.SelectedIndex = -1 Then
            MsgBox("Beneficiary relationship is required.", MsgBoxStyle.Information)
        ElseIf RB_1ST.Checked = False And RB_2ND.Checked = False And RB_3RD.Checked = False And RB_4TH.Checked = False Then
            MsgBox("Year level is required.", MsgBoxStyle.Information)

        Else

            If RB_1ST.Checked = True Then
                year_level = 1
            ElseIf RB_2ND.Checked = True Then
                year_level = 2
            ElseIf RB_3RD.Checked = True Then
                year_level = 3
            ElseIf RB_4TH.Checked = True Then
                year_level = 4
            End If
            sql_add_beneficiary = "INSERT INTO EFAS_BENEFICIARY VALUES(null, '" & TXT_B_FNAME.Text & "', '" & TXT_B_LNAME.Text & "', '" & TXT_B_ADDRESS.Text & "', " & TXT_B_CNUMBER.Text & ",  '" & CBO_B_GENDER.SelectedItem & "', '" & CBO_B_MARITAL_STATUS.SelectedItem & "', '" & TXT_B_SCHOOL_NAME.Text & "', " & year_level & ", '" & TXT_B_SCHOOL_ID.Text & "', '" & TXT_B_EMAIL.Text & "', '" & TXT_B_USERNAME.Text & "', '" & TXT_B_PASSWORD.Text & "', '" & TXT_B_EC_FNAME.Text & "', '" & TXT_B_EC_LNAME.Text & "', " & TXT_B_EC_CNUMBER.Text & ", '" & CBO_B_EC_RELATIONSHIP.SelectedItem & "', 'Active')"
            SQLProcess(sql_add_beneficiary)
            MsgBox("New beneficiary was successfully added.", MsgBoxStyle.SystemModal)
            TXT_B_FNAME.ResetText()
            TXT_B_LNAME.ResetText()
            TXT_B_ADDRESS.ResetText()
            TXT_B_CNUMBER.ResetText()
            TXT_B_EMAIL.ResetText()
            TXT_B_USERNAME.ResetText()
            TXT_B_PASSWORD.ResetText()
            TXT_B_SCHOOL_NAME.ResetText()
            TXT_B_SCHOOL_ID.ResetText()
            TXT_B_EC_FNAME.ResetText()
            TXT_B_EC_LNAME.ResetText()
            TXT_B_EC_CNUMBER.ResetText()
            CBO_B_GENDER.SelectedIndex = -1
            CBO_B_MARITAL_STATUS.SelectedIndex = -1
            CBO_B_EC_RELATIONSHIP.SelectedIndex = -1
            RB_1ST.Checked = False
            RB_2ND.Checked = False
            RB_3RD.Checked = False
            RB_4TH.Checked = False
            frmDashboard.Close()

        End If
    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        Me.Hide()
        Me.Refresh()
        frmBeneficiaryHome.Show()
        TXT_B_FNAME.ResetText()
        TXT_B_LNAME.ResetText()
        TXT_B_ADDRESS.ResetText()
        TXT_B_CNUMBER.ResetText()
        TXT_B_EMAIL.ResetText()
        TXT_B_USERNAME.ResetText()
        TXT_B_PASSWORD.ResetText()
        TXT_B_SCHOOL_NAME.ResetText()
        TXT_B_SCHOOL_ID.ResetText()
        TXT_B_EC_FNAME.ResetText()
        TXT_B_EC_LNAME.ResetText()
        TXT_B_EC_CNUMBER.ResetText()
        CBO_B_GENDER.SelectedIndex = -1
        CBO_B_MARITAL_STATUS.SelectedIndex = -1
        CBO_B_EC_RELATIONSHIP.SelectedIndex = -1
        RB_1ST.Checked = False
        RB_2ND.Checked = False
        RB_3RD.Checked = False
        RB_4TH.Checked = False
    End Sub

    Private Sub TXT_B_EC_CNUMBER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_B_EC_CNUMBER.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MsgBox("Number only for contact number.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TXT_B_CNUMBER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_B_CNUMBER.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MsgBox("Number only for contact number.", MsgBoxStyle.Information)
        End If
    End Sub
End Class