Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmDashboard
    Dim sql_con As New MySqlConnection("server=localhost; user=root; password=; database= top_efas")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Public Shared BEN_EFAS_ID As Integer
    Dim total_amount_disbursed As Double
    Dim total_amount_returned As Double
    Dim total_balance As Double
    Dim ver_return_amount As Double
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        displayRecords("select efas.efas_beneficiary_id, efas.school_id, efas.first_name, efas.last_name, e1.sumdis, sum(return_amount)
                        from (select school_id, sum(disburse_amount) sumdis from efas_disbursement group by school_id) e1 left join efas_beneficiary efas on efas.school_id=e1.school_id 
                        left join efas_return e2 on e2.school_id=efas.school_id group by efas.school_id;", DG_BENEFICIARY_RECORDS)
        LBL_TOTAL_AMOUNT_DISBURSED.Text = FormatCurrency(Val(_get_value("Select SUM(DISBURSE_AMOUNT) from EFAS_DISBURSEMENT;", "SUM(DISBURSE_AMOUNT)")))
        LBL_TOTAL_AMOUNT_RETURNED.Text = FormatCurrency(Val(_get_value("Select SUM(RETURN_AMOUNT) from EFAS_RETURN;", "SUM(RETURN_AMOUNT)")))
        LBL_TOTAL_BALANCE.Text = FormatCurrency(LBL_TOTAL_AMOUNT_DISBURSED.Text - LBL_TOTAL_AMOUNT_RETURNED.Text)

        '//COUNT NUMBER OF BENEFICIARY

        Try
            sql_con.Open()
            cmd.Connection = sql_con
            cmd.CommandText = "SELECT COUNT(efas_beneficiary_id) FROM EFAS_BENEFICIARY;"
            Dim res_count_ben As Object
            res_count_ben = cmd.ExecuteScalar
            Dim ben_result As String
            ben_result = res_count_ben
            txt_count_beneficiary.Text = ben_result
        Catch ex As Exception
            MessageBox.Show("no beneficiaries")

        End Try
        sql_con.Close()

        '//COUNT NUMBER OF ADMIN
        Try
            sql_con.Open()
            cmd.Connection = sql_con
            cmd.CommandText = "SELECT COUNT(efas_admin_id) FROM EFAS_ADMIN;"
            Dim res_count_admin As Object
            res_count_admin = cmd.ExecuteScalar
            Dim admin_result As String
            admin_result = res_count_admin
            txt_count_admin.Text = admin_result
        Catch ex As Exception
            MessageBox.Show("no beneficiaries")

        End Try
        sql_con.Close()

        'DISPLAY DATA TO CHART

        Try
            sql_con.Open()
            Dim disburse_query As String
            disburse_query = "SELECT SUM(DISBURSE_AMOUNT) AS DISBURSE_AMOUNT, SUBSTRING(DISBURSEMENT_DATE,1,3) AS MONTH FROM EFAS_DISBURSEMENT GROUP BY MONTH"
            cmd = New MySqlCommand(disburse_query, sql_con)
            dr = cmd.ExecuteReader
            While dr.Read
                CHART_DISBURSEMENT.Series("Disbursement").Points.AddXY(dr.GetString("MONTH"), dr.GetDouble("DISBURSE_AMOUNT"))
            End While
            sql_con.Close()

            Dim return_query As String
            sql_con.Open()
            return_query = "SELECT SUM(RETURN_AMOUNT) AS RETURN_AMOUNT, SUBSTRING(DATE_RETURNED,1,3) AS MONTH FROM EFAS_RETURN GROUP BY MONTH"
            cmd = New MySqlCommand(return_query, sql_con)
            dr = cmd.ExecuteReader
            While dr.Read
                CHART_RETURN.Series("Return").Points.AddXY(dr.GetString("MONTH"), dr.GetDouble("RETURN_AMOUNT"))
            End While
            sql_con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sql_con.Dispose()
        End Try
    End Sub

    Private Sub DG_BENEFICIARY_RECORDS_DoubleClick_1(sender As Object, e As EventArgs) Handles DG_BENEFICIARY_RECORDS.DoubleClick
        BEN_EFAS_ID = DG_BENEFICIARY_RECORDS.CurrentRow.Cells(0).Value.ToString()
        frmBeneficiaryProfile.ShowDialog()

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
        displayRecords("select efas.efas_beneficiary_id, efas.school_id, efas.first_name, efas.last_name, e1.sumdis, sum(return_amount)
                        from (select school_id, sum(disburse_amount) sumdis from efas_disbursement group by school_id) e1 left join efas_beneficiary efas on efas.school_id=e1.school_id 
                        left join efas_return e2 on e2.school_id=efas.school_id group by efas.school_id;", DG_BENEFICIARY_RECORDS)
    End Sub

    Private Sub TXT_SEARCH_BEN_TO_EDIT_TextChanged(sender As Object, e As EventArgs) Handles TXT_SEARCH_BEN_TO_EDIT.TextChanged
        Dim strQuerySearchBeneficiary = "select efas.efas_beneficiary_id, efas.school_id, efas.first_name, efas.last_name, e1.sumdis, sum(return_amount)
                        from (select school_id, sum(disburse_amount) sumdis from efas_disbursement group by school_id) e1 left join efas_beneficiary efas on efas.school_id=e1.school_id 
                        left join efas_return e2 on e2.school_id=efas.school_id WHERE FIRST_NAME LIKE '%" & TXT_SEARCH_BEN_TO_EDIT.Text & "%' OR LAST_NAME LIKE '%" & TXT_SEARCH_BEN_TO_EDIT.Text & "%' OR efas.SCHOOL_ID LIKE '%" & TXT_SEARCH_BEN_TO_EDIT.Text & "%' group by efas.school_id"
        displayRecords(strQuerySearchBeneficiary, DG_BENEFICIARY_RECORDS)
    End Sub
End Class