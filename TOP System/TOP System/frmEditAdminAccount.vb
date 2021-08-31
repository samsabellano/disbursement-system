Public Class frmEditAdminAccount
    Dim ADMIN_ID As Integer
    Dim ADMIN_FNAME As String
    Dim ADMIN_LNAME As String
    Dim ADMIN_CNUMBER As String
    Dim ADMIN_ADDRESS As String
    Dim ADMIN_EMAIL As String

    Private Sub frmEditAdminAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        ADMIN_ID = frmLogin.get_admin_id

        ADMIN_FNAME = _get_value("SELECT ADMIN_FIRST_NAME FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_FIRST_NAME")
        ADMIN_LNAME = _get_value("SELECT ADMIN_LAST_NAME FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_LAST_NAME")
        ADMIN_CNUMBER = _get_value("SELECT ADMIN_CONTACT_NUMBER FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_CONTACT_NUMBER")
        ADMIN_ADDRESS = _get_value("SELECT ADMIN_ADDRESS FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_ADDRESS")
        ADMIN_EMAIL = _get_value("SELECT ADMIN_EMAIL FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_EMAIL")

        TXT_ADMIN_FNAME.Text = ADMIN_FNAME
        TXT_ADMIN_LNAME.Text = ADMIN_LNAME
        TXT_ADMIN_CNUMBER.Text = ADMIN_CNUMBER
        TXT_ADMIN_ADDRESS.Text = ADMIN_ADDRESS
        TXT_ADMIN_EMAIL.Text = ADMIN_EMAIL

        pnl_edit_lname.Hide()
        pnl_edit_cnumber.Hide()
        pnl_edit_address.Hide()
        BTN_REG_ADMIN.Enabled = False

    End Sub

    Private Sub CB_UPDATE_ADMIN_ACCNT_CheckedChanged(sender As Object, e As EventArgs) Handles CB_UPDATE_ADMIN_ACCNT.CheckedChanged
        If CB_UPDATE_ADMIN_ACCNT.Checked = True Then
            TXT_ADMIN_LNAME.ReadOnly = False
            TXT_ADMIN_CNUMBER.ReadOnly = False
            TXT_ADMIN_ADDRESS.ReadOnly = False

            pnl_edit_lname.Show()
            pnl_edit_cnumber.Show()
            pnl_edit_address.Show()
            BTN_REG_ADMIN.Enabled = True
            CB_UPDATE_ADMIN_ACCNT.Text = "Uncheck to cancel"
        Else
            TXT_ADMIN_LNAME.ReadOnly = True
            TXT_ADMIN_CNUMBER.ReadOnly = True
            TXT_ADMIN_ADDRESS.ReadOnly = True

            pnl_edit_lname.Hide()
            pnl_edit_cnumber.Hide()
            pnl_edit_address.Hide()
            BTN_REG_ADMIN.Enabled = False

            TXT_ADMIN_FNAME.Text = ADMIN_FNAME
            TXT_ADMIN_LNAME.Text = ADMIN_LNAME
            TXT_ADMIN_CNUMBER.Text = ADMIN_CNUMBER
            TXT_ADMIN_ADDRESS.Text = ADMIN_ADDRESS
            TXT_ADMIN_EMAIL.Text = ADMIN_EMAIL
            CB_UPDATE_ADMIN_ACCNT.Text = "Check to edit"
        End If
    End Sub

    Private Sub BTN_REG_ADMIN_Click(sender As Object, e As EventArgs) Handles BTN_REG_ADMIN.Click
        If TXT_ADMIN_LNAME.Text = Nothing Then
            MsgBox("Your lastname should not be empty.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_CNUMBER.Text = Nothing Then
            MsgBox("Your contact number should not be empty.", MsgBoxStyle.Information)
        ElseIf TXT_ADMIN_ADDRESS.Text = Nothing Then
            MsgBox("Your address should not be empty.", MsgBoxStyle.Information)
        Else
            Dim UpdateContractQuery = "UPDATE EFAS_ADMIN SET ADMIN_LAST_NAME = '" & TXT_ADMIN_LNAME.Text & "', ADMIN_CONTACT_NUMBER = '" & TXT_ADMIN_CNUMBER.Text & "', ADMIN_ADDRESS = '" & TXT_ADMIN_ADDRESS.Text & "' WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";"
            _SQLManager(UpdateContractQuery)
            CB_UPDATE_ADMIN_ACCNT.Checked = False

            MsgBox("Your account was successfully updated.", MsgBoxStyle.OkOnly)
            ADMIN_FNAME = _get_value("SELECT ADMIN_FIRST_NAME FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_FIRST_NAME")
            ADMIN_LNAME = _get_value("SELECT ADMIN_LAST_NAME FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_LAST_NAME")
            ADMIN_CNUMBER = _get_value("SELECT ADMIN_CONTACT_NUMBER FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_CONTACT_NUMBER")
            ADMIN_ADDRESS = _get_value("SELECT ADMIN_ADDRESS FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_ADDRESS")
            ADMIN_EMAIL = _get_value("SELECT ADMIN_EMAIL FROM EFAS_ADMIN WHERE EFAS_ADMIN_ID = " & ADMIN_ID & ";", "ADMIN_EMAIL")

            TXT_ADMIN_FNAME.Text = ADMIN_FNAME
            TXT_ADMIN_LNAME.Text = ADMIN_LNAME
            TXT_ADMIN_CNUMBER.Text = ADMIN_CNUMBER
            TXT_ADMIN_ADDRESS.Text = ADMIN_ADDRESS
            TXT_ADMIN_EMAIL.Text = ADMIN_EMAIL

            frmMain.txt_Get_Name.Text = ADMIN_FNAME + " " + ADMIN_LNAME

        End If
    End Sub
End Class