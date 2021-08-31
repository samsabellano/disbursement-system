<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmountBalanceDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.LBL_PASSWORD_ALERT = New System.Windows.Forms.Label()
        Me.TXT_BEN_TOTAL_BALANCE = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.TXT_BEN_TOTAL_BALANCE)
        Me.GunaShadowPanel1.Controls.Add(Me.LBL_PASSWORD_ALERT)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(146, 84)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 3
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel1.ShadowDepth = 50
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(499, 279)
        Me.GunaShadowPanel1.TabIndex = 176
        '
        'LBL_PASSWORD_ALERT
        '
        Me.LBL_PASSWORD_ALERT.AutoSize = True
        Me.LBL_PASSWORD_ALERT.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PASSWORD_ALERT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_PASSWORD_ALERT.Location = New System.Drawing.Point(182, 129)
        Me.LBL_PASSWORD_ALERT.Name = "LBL_PASSWORD_ALERT"
        Me.LBL_PASSWORD_ALERT.Size = New System.Drawing.Size(132, 16)
        Me.LBL_PASSWORD_ALERT.TabIndex = 175
        Me.LBL_PASSWORD_ALERT.Text = "CURRENT BALANCE"
        '
        'TXT_BEN_TOTAL_BALANCE
        '
        Me.TXT_BEN_TOTAL_BALANCE.BackColor = System.Drawing.Color.White
        Me.TXT_BEN_TOTAL_BALANCE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BEN_TOTAL_BALANCE.Enabled = False
        Me.TXT_BEN_TOTAL_BALANCE.FocusedLineColor = System.Drawing.Color.White
        Me.TXT_BEN_TOTAL_BALANCE.Font = New System.Drawing.Font("Arial Nova", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BEN_TOTAL_BALANCE.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TXT_BEN_TOTAL_BALANCE.LineColor = System.Drawing.Color.White
        Me.TXT_BEN_TOTAL_BALANCE.LineSize = 1
        Me.TXT_BEN_TOTAL_BALANCE.Location = New System.Drawing.Point(68, 69)
        Me.TXT_BEN_TOTAL_BALANCE.Name = "TXT_BEN_TOTAL_BALANCE"
        Me.TXT_BEN_TOTAL_BALANCE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BEN_TOTAL_BALANCE.Size = New System.Drawing.Size(363, 46)
        Me.TXT_BEN_TOTAL_BALANCE.TabIndex = 177
        Me.TXT_BEN_TOTAL_BALANCE.Text = "0.00"
        Me.TXT_BEN_TOTAL_BALANCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAmountBalanceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAmountBalanceDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAmountBalanceDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents LBL_PASSWORD_ALERT As Label
    Friend WithEvents TXT_BEN_TOTAL_BALANCE As Guna.UI.WinForms.GunaLineTextBox
End Class
