Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class frmMain
    Public DBoard As New frmDashboard
    Public CHistory As New frmDisbursementHome
    Public Shadows get_date As String
    Dim forDash As Boolean = False
    Dim getPanel As Panel

    Dim sql_con As New MySqlConnection("server=localhost; user=root; password=; database= top_efas")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        lbl_Time.Text = TimeOfDay.ToString("hh:mm tt")
        lbl_Date.Text = Date.Now.ToString("MMMM d, yyyy")
        get_date = lbl_Date.Text
        frmDisbursement.hold_date = get_date

        With frmDashboard
            .TopLevel = False
            pnl_main.Controls.Add(frmDashboard)
            .BringToFront()
            .Show()
        End With
        btn_Dashboard.Checked = True

        BTN_ADD_ADMIN.Hide()
        BTN_UPDATE_ADMIN.Hide()
        BTN_UPDATE_SY.Hide()
    End Sub

    Private Sub btn_hideNavBar_Click(sender As Object, e As EventArgs) Handles btn_hideNavBar.Click
        pnl_NavBar.Size = New Size(72, 416)
        pnl_main.Size = New Size(802, 416)
        btn_showNavBar.Visible = True
        LBL_MENU.Hide()

        DBoard.Refresh()
        CHistory.Refresh()

        Ttip_Dashboard.SetToolTip(btn_Dashboard, "Dashboard")
        Ttip_Beneficiary.SetToolTip(btn_Beneficiary, "Beneficiary")
        Tttip_Contract.SetToolTip(btn_ContractManagement, "Contract Management")
        Tttip_Disbursement.SetToolTip(btn_Disbursement, "Disbursement")
        Tttip_Loan_Return.SetToolTip(btn_Return, "Loan Return")
        Tttip_Manage_Admin.SetToolTip(BTN_MANAGE_ADMIN, "Manage Admin")
        Tttip_Add_new_admin.SetToolTip(BTN_ADD_ADMIN, "Add new admin")
        Tttip_Update_admin_account.SetToolTip(BTN_UPDATE_ADMIN, "Edit Admin Account")

        btn_Dashboard.ImageOffsetX = 14
        btn_Beneficiary.ImageOffsetX = 14
        btn_ContractManagement.ImageOffsetX = 14
        btn_Disbursement.ImageOffsetX = 14
        btn_Return.ImageOffsetX = 14
        BTN_MANAGE_ADMIN.ImageOffsetX = 14
        BTN_ADD_ADMIN.ImageOffsetX = 14
        BTN_UPDATE_ADMIN.ImageOffsetX = 14

        LBL_BENEFICIARY.Hide()
        LBL_ADMIN.Hide()

    End Sub

    Private Sub btn_showNavBar_Click(sender As Object, e As EventArgs) Handles btn_showNavBar.Click
        pnl_NavBar.Size = New Size(230, 416)
        btn_showNavBar.Visible = False
        LBL_MENU.Show()
        LBL_BENEFICIARY.Show()
        LBL_ADMIN.Show()
        Me.Refresh()
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to Logout?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Me.Refresh()
            Me.Close()
            frmLogin.Show()
            btn_Dashboard.Checked = True
            frmDashboard.BringToFront()
        End If
    End Sub

    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click

        frmDashboard.LBL_TOTAL_AMOUNT_DISBURSED.Refresh()
        frmDashboard.LBL_TOTAL_AMOUNT_RETURNED.Refresh()
        With frmDashboard
            .TopLevel = False
            pnl_main.Controls.Add(frmDashboard)
            .BringToFront()
            .Show()
            Try
                sql_con.Open()
                cmd.Connection = sql_con
                cmd.CommandText = "select count(efas_beneficiary_id) from efas_beneficiary;"
                Dim sql_result As Object
                sql_result = cmd.ExecuteScalar
                Dim str As String
                str = sql_result
                frmDashboard.txt_count_beneficiary.Text = str

            Catch ex As Exception
                MessageBox.Show("no beneficiaries")

            End Try
            sql_con.Close()

        End With
    End Sub

    Private Sub btn_Disbursement_Click(sender As Object, e As EventArgs) Handles btn_Disbursement.Click
        dbConnection()
        frmDisbursementHome.Refresh()
        With frmDisbursementHome
            .TopLevel = False
            pnl_main.Controls.Add(frmDisbursementHome)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_myAccount_Click(sender As Object, e As EventArgs) Handles btn_Beneficiary.Click
        With frmBeneficiaryHome
            .TopLevel = False
            pnl_main.Controls.Add(frmBeneficiaryHome)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_ContractManagement_Click(sender As Object, e As EventArgs) Handles btn_ContractManagement.Click
        With frmContractManagement
            .TopLevel = False
            pnl_main.Controls.Add(frmContractManagement)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click
        With frmLoanReturn
            .TopLevel = False
            pnl_main.Controls.Add(frmLoanReturn)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BTN_ADMIN_SETTINGS_Click(sender As Object, e As EventArgs) Handles BTN_MANAGE_ADMIN.Click
        If BTN_MANAGE_ADMIN.Checked = True Then
            BTN_ADD_ADMIN.Show()
            BTN_UPDATE_ADMIN.Show()
            BTN_UPDATE_SY.Show()
        Else
            BTN_ADD_ADMIN.Hide()
            BTN_UPDATE_ADMIN.Hide()
            BTN_UPDATE_SY.Hide()
            BTN_ADD_ADMIN.Checked = False
            BTN_UPDATE_ADMIN.Checked = False
            BTN_UPDATE_SY.Checked = False
        End If
    End Sub

    Private Sub BTN_ADD_ADMIN_Click(sender As Object, e As EventArgs) Handles BTN_ADD_ADMIN.Click
        With frmADD_ADMIN
            .TopLevel = False
            pnl_main.Controls.Add(frmADD_ADMIN)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BTN_UPDATE_ADMIN_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE_ADMIN.Click
        With frmEditAdminAccount
            .TopLevel = False
            pnl_main.Controls.Add(frmEditAdminAccount)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BTN_UPDATE_SY_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE_SY.Click
        frmSchoolYear.ShowDialog()
    End Sub

    Private Sub PB_MINIMIZE_Click(sender As Object, e As EventArgs) Handles PB_MINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
