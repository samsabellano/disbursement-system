Imports System.Text
Public Class frmLogin

    Public Shared get_account_fname As String
    Public Shared get_account_lname As String
    Public Shared get_admin_id As String
    Dim ben_status As String
    Dim email As String
    Dim username As String
    Public Shared stud_id As String
    Public Shared ver_pass As String
    Public Shared ben_id As Integer
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        lbl_login_time.Text = TimeOfDay.ToString("hh:mm tt")
        lbl_login_date.Text = Date.Now.ToString("MMMM d, yyyy")
        AcceptButton = btn_Login
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If (txt_uname.Text = "") And (txt_password.Text = "") Then
            MessageBox.Show("Required Username and Password!")
        ElseIf (txt_uname.Text = "") Then
            MessageBox.Show("Username is required!")
            txt_uname.BorderColor = Color.Red
        ElseIf (txt_password.Text = "") Then
            MessageBox.Show("Password is required!")
            txt_password.BorderColor = Color.Red
        Else
            If _isValidAccount("SELECT * FROM EFAS_BENEFICIARY", "USERNAME", "PASSWORD", txt_uname.Text, txt_password.Text) Then
                get_account_fname = _get_fname("Select FIRST_NAME from efas_beneficiary where USERNAME = '" & txt_uname.Text & "' AND PASSWORD = '" & txt_password.Text & "';", "FIRST_NAME")
                get_account_lname = _get_lname("Select LAST_NAME from efas_beneficiary where USERNAME= '" & txt_uname.Text & "' AND PASSWORD = '" & txt_password.Text & "';", "LAST_NAME")
                email = _get_value("Select EMAIL from efas_beneficiary where USERNAME= '" & txt_uname.Text & "' AND PASSWORD = '" & txt_password.Text & "';", "EMAIL")
                username = _get_value("Select USERNAME from efas_beneficiary where USERNAME= '" & txt_uname.Text & "' AND PASSWORD = '" & txt_password.Text & "';", "USERNAME")
                ben_id = _get_value("Select EFAS_BENEFICIARY_ID from efas_beneficiary where USERNAME= '" & txt_uname.Text & "' AND PASSWORD = '" & txt_password.Text & "';", "EFAS_BENEFICIARY_ID")
                stud_id = _get_value("Select SCHOOL_ID from EFAS_BENEFICIARY where USERNAME = '" & txt_uname.Text & "' AND PASSWORD = '" & txt_password.Text & "' AND EFAS_BENEFICIARY_ID = " & ben_id & ";", "SCHOOL_ID")
                ben_status = _get_value("Select BENEFICIARY_STATUS from efas_beneficiary where USERNAME= '" & txt_uname.Text & "' AND PASSWORD = '" & txt_password.Text & "';", "BENEFICIARY_STATUS")
                Me.Hide()
                frmBeneficiaryAccount.Show()
                frmBeneficiaryAccount.LBL_BENEFICIARY_NAME.Text = get_account_fname + " " + get_account_lname
                frmBeneficiaryAccount.LBL_BENEFICIARY_EMAIL.Text = "       " + email
                frmBeneficiaryAccount.LBL_BENEFICIARY_USERNAME.Text = "       " + username + "  |  " + ben_status.ToUpper
                frmBeneficiaryAccount.BTN_BEN_DASHBOARD.Checked = True
                txt_uname.Text = ""
                txt_password.Text = ""

            ElseIf _isValidAccount("SELECT * FROM EFAS_ADMIN", "ADMIN_USERNAME", "ADMIN_PASSWORD", txt_uname.Text, txt_password.Text) Then
                get_account_fname = _get_fname("Select ADMIN_FIRST_NAME from EFAS_ADMIN where ADMIN_USERNAME= '" & txt_uname.Text & "' AND ADMIN_PASSWORD = '" & txt_password.Text & "';", "ADMIN_FIRST_NAME")
                get_account_lname = _get_lname("Select ADMIN_LAST_NAME from EFAS_ADMIN where ADMIN_USERNAME= '" & txt_uname.Text & "' AND ADMIN_PASSWORD = '" & txt_password.Text & "';", "ADMIN_LAST_NAME")
                get_admin_id = _get_value("Select EFAS_ADMIN_ID from EFAS_ADMIN where ADMIN_USERNAME= '" & txt_uname.Text & "' AND ADMIN_PASSWORD = '" & txt_password.Text & "';", "EFAS_ADMIN_ID")
                Timer1.Start()
                Me.Hide()
                frmMain.Show()
                frmMain.txt_Get_Name.Text = get_account_fname + " " + get_account_lname
                frmDisbursement.hold_admin_id = get_admin_id
                frmDisbursement.LBL_ADMIN_NAME.Text = get_account_fname + " " + get_account_lname
                frmReturnAmount.LBL_ADMIN_NAME.Text = get_account_fname + " " + get_account_lname
                txt_uname.Text = ""
                txt_password.Text = ""
                frmMain.btn_Disbursement.Show()
                frmMain.btn_Dashboard.Show()
                frmMain.btn_Beneficiary.Checked = False
                frmMain.btn_Dashboard.Checked = True
                frmDashboard.pnl_count_beneficiary.Refresh()
                frmDashboard.txt_count_beneficiary.Refresh()
            Else
                MessageBox.Show("Login failed! Please check your email or password.")
                txt_uname.Text = ""
                txt_password.Text = ""
            End If

        End If
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub link_forgot_password_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_forgot_password.LinkClicked
        pnl_Login.Hide()
        frmSendEmail.ShowDialog()
    End Sub
End Class
