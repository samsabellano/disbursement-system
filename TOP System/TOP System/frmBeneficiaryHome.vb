Public Class frmBeneficiaryHome
    Private Sub btn_Add_Beneficiary_Click_1(sender As Object, e As EventArgs) Handles btn_Add_Beneficiary.Click
        With frmAddBeneficiary
            .TopLevel = False
            pnl_ben_account.Controls.Add(frmAddBeneficiary)
            .BringToFront()
            .Show()
        End With
        Me.Refresh()
    End Sub

    Private Sub btn_Edit_Beneficiary_Click_1(sender As Object, e As EventArgs) Handles btn_Edit_Beneficiary.Click
        With frmGetBeneciaryInformationToEdit_Admin
            .TopLevel = False
            pnl_ben_account.Controls.Add(frmGetBeneciaryInformationToEdit_Admin)
            .BringToFront()
            .Show()
        End With
        Me.Refresh()
    End Sub
End Class