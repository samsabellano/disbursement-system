Public Class frmContractManagement

    Private Sub BTN_CM_CONTRACT_HISTORY_Click(sender As Object, e As EventArgs) Handles BTN_CM_CONTRACT_HISTORY.Click
        With frmContractHistory
            .TopLevel = False
            pnl_contract_holder.Controls.Add(frmContractHistory)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BTN_CM_ADD_CONTRACT_Click(sender As Object, e As EventArgs) Handles BTN_CM_ADD_CONTRACT.Click
        With frmAddContract
            .TopLevel = False
            pnl_contract_holder.Controls.Add(frmAddContract)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        With frmUpdateContract
            .TopLevel = False
            pnl_contract_holder.Controls.Add(frmUpdateContract)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class