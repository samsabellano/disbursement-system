Public Class frmBeneficiaryProfile
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim BEN_FNAME As String
    Dim ID As Integer

    Private Sub frmBeneficiaryProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        With frmBeneficiaryInformation
            BTN_BEN_INFO_PROFILE.Checked = True
            .TopLevel = False
            PNL_BENEFICIARY_INFO_HOLDER.Controls.Add(frmBeneficiaryInformation)
            .BringToFront()
            .Show()
        End With
        ID = frmDashboard.BEN_EFAS_ID
        TXT_BEN_FNAME.Text = _get_value("SELECT FIRST_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "FIRST_NAME")
        TXT_BEN_STATUS.Text = _get_value("SELECT BENEFICIARY_STATUS FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "BENEFICIARY_STATUS")
        LBL_BEN_SCHOOL_NAME.Text = _get_value("SELECT SCHOOL_NAME FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "SCHOOL_NAME")
        LBL_BEN_ADDRESS.Text = _get_value("SELECT ADDRESS FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "ADDRESS")
        LBL_BEN_CONTACT_NUMBER.Text = _get_value("SELECT CONTACT_NUMBER FROM EFAS_BENEFICIARY WHERE EFAS_BENEFICIARY_ID = " & ID & ";", "CONTACT_NUMBER")
    End Sub


    Private Sub PNL_HEADER_MouseDown(sender As Object, e As MouseEventArgs) Handles PNL_HEADER.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PNL_HEADER_MouseMove(sender As Object, e As MouseEventArgs) Handles PNL_HEADER.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PNL_HEADER_MouseUp(sender As Object, e As MouseEventArgs) Handles PNL_HEADER.MouseUp
        draggable = False
    End Sub

    Private Sub BTN_BEN_INFO_PROFILE_Click_1(sender As Object, e As EventArgs) Handles BTN_BEN_INFO_PROFILE.Click
        With frmBeneficiaryInformation
            .TopLevel = False
            PNL_BENEFICIARY_INFO_HOLDER.Controls.Add(frmBeneficiaryInformation)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PB_CLOSE_BEN_INFO_WIN_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE_BEN_INFO_WINDOW.Click
        Me.Close()
        Me.Refresh()
        frmBeneficiaryInformation.Close()
        frmAmountReturnedDetails.Close()
        frmAmountDisbursedDetails.Close()
        frmAmountBalanceDetails.Close()
        BTN_BEN_INFO_AMOUNT_DISBURSE.Checked = False
        BTN_BEN_INFO_AMOUNT_RETURN.Checked = False
        BTN_BEN_INFO_BALANCE.Checked = False
    End Sub

    Private Sub BTN_BEN_INFO_AMOUNT_RETURN_Click(sender As Object, e As EventArgs) Handles BTN_BEN_INFO_AMOUNT_RETURN.Click
        With frmAmountReturnedDetails
            .TopLevel = False
            PNL_BENEFICIARY_INFO_HOLDER.Controls.Add(frmAmountReturnedDetails)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BTN_BEN_INFO_AMOUNT_DISBURSE_Click(sender As Object, e As EventArgs) Handles BTN_BEN_INFO_AMOUNT_DISBURSE.Click
        With frmAmountDisbursedDetails
            .TopLevel = False
            PNL_BENEFICIARY_INFO_HOLDER.Controls.Add(frmAmountDisbursedDetails)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles BTN_BEN_INFO_BALANCE.Click
        With frmAmountBalanceDetails
            .TopLevel = False
            PNL_BENEFICIARY_INFO_HOLDER.Controls.Add(frmAmountBalanceDetails)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class