<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeneficiaryDasboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeneficiaryDasboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TXT_BEN_TOTAL_BALANCE = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PNL_RETURN = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_BEN_TOTAL_R_AMOUNT = New System.Windows.Forms.Label()
        Me.PNL_DISBURSE = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_BEN_TOTAL_D_AMOUNT = New System.Windows.Forms.Label()
        Me.ToolTip_Disburse = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_Return = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PNL_RETURN.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PNL_DISBURSE.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GunaShadowPanel1)
        Me.Panel1.Controls.Add(Me.PNL_RETURN)
        Me.Panel1.Controls.Add(Me.PNL_DISBURSE)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 431)
        Me.Panel1.TabIndex = 0
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel4)
        Me.GunaShadowPanel1.ForeColor = System.Drawing.Color.Coral
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(71, 54)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 3
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 60
        Me.GunaShadowPanel1.ShadowShift = 3
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(599, 141)
        Me.GunaShadowPanel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TXT_BEN_TOTAL_BALANCE)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(107, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(478, 80)
        Me.Panel4.TabIndex = 0
        '
        'TXT_BEN_TOTAL_BALANCE
        '
        Me.TXT_BEN_TOTAL_BALANCE.BackColor = System.Drawing.Color.White
        Me.TXT_BEN_TOTAL_BALANCE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BEN_TOTAL_BALANCE.Enabled = False
        Me.TXT_BEN_TOTAL_BALANCE.FocusedLineColor = System.Drawing.Color.White
        Me.TXT_BEN_TOTAL_BALANCE.Font = New System.Drawing.Font("Arial Nova", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BEN_TOTAL_BALANCE.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TXT_BEN_TOTAL_BALANCE.LineColor = System.Drawing.Color.White
        Me.TXT_BEN_TOTAL_BALANCE.LineSize = 1
        Me.TXT_BEN_TOTAL_BALANCE.Location = New System.Drawing.Point(152, 25)
        Me.TXT_BEN_TOTAL_BALANCE.Name = "TXT_BEN_TOTAL_BALANCE"
        Me.TXT_BEN_TOTAL_BALANCE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BEN_TOTAL_BALANCE.Size = New System.Drawing.Size(295, 40)
        Me.TXT_BEN_TOTAL_BALANCE.TabIndex = 2
        Me.TXT_BEN_TOTAL_BALANCE.Text = "0.00"
        Me.TXT_BEN_TOTAL_BALANCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(11, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MY BALANCE"
        '
        'PNL_RETURN
        '
        Me.PNL_RETURN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PNL_RETURN.BackColor = System.Drawing.Color.Transparent
        Me.PNL_RETURN.BaseColor = System.Drawing.Color.White
        Me.PNL_RETURN.Controls.Add(Me.GunaCirclePictureBox2)
        Me.PNL_RETURN.Controls.Add(Me.Panel3)
        Me.PNL_RETURN.Location = New System.Drawing.Point(383, 216)
        Me.PNL_RETURN.Name = "PNL_RETURN"
        Me.PNL_RETURN.Radius = 3
        Me.PNL_RETURN.ShadowColor = System.Drawing.Color.Black
        Me.PNL_RETURN.ShadowDepth = 60
        Me.PNL_RETURN.ShadowShift = 3
        Me.PNL_RETURN.Size = New System.Drawing.Size(287, 141)
        Me.PNL_RETURN.TabIndex = 1
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(25, 35)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(75, 75)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 4
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.LBL_BEN_TOTAL_R_AMOUNT)
        Me.Panel3.Location = New System.Drawing.Point(106, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(167, 80)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AMOUNT RETURNED"
        '
        'LBL_BEN_TOTAL_R_AMOUNT
        '
        Me.LBL_BEN_TOTAL_R_AMOUNT.AutoSize = True
        Me.LBL_BEN_TOTAL_R_AMOUNT.Font = New System.Drawing.Font("Arial Nova", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BEN_TOTAL_R_AMOUNT.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.LBL_BEN_TOTAL_R_AMOUNT.Location = New System.Drawing.Point(10, 41)
        Me.LBL_BEN_TOTAL_R_AMOUNT.Name = "LBL_BEN_TOTAL_R_AMOUNT"
        Me.LBL_BEN_TOTAL_R_AMOUNT.Size = New System.Drawing.Size(48, 23)
        Me.LBL_BEN_TOTAL_R_AMOUNT.TabIndex = 0
        Me.LBL_BEN_TOTAL_R_AMOUNT.Text = "0.00"
        '
        'PNL_DISBURSE
        '
        Me.PNL_DISBURSE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PNL_DISBURSE.BackColor = System.Drawing.Color.Transparent
        Me.PNL_DISBURSE.BaseColor = System.Drawing.Color.White
        Me.PNL_DISBURSE.Controls.Add(Me.GunaCirclePictureBox1)
        Me.PNL_DISBURSE.Controls.Add(Me.Panel2)
        Me.PNL_DISBURSE.Location = New System.Drawing.Point(71, 216)
        Me.PNL_DISBURSE.Name = "PNL_DISBURSE"
        Me.PNL_DISBURSE.Radius = 3
        Me.PNL_DISBURSE.ShadowColor = System.Drawing.Color.Black
        Me.PNL_DISBURSE.ShadowDepth = 60
        Me.PNL_DISBURSE.ShadowShift = 3
        Me.PNL_DISBURSE.Size = New System.Drawing.Size(287, 141)
        Me.PNL_DISBURSE.TabIndex = 0
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(26, 35)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 2
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LBL_BEN_TOTAL_D_AMOUNT)
        Me.Panel2.Location = New System.Drawing.Point(107, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(167, 80)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AMOUNT DISBURSED"
        '
        'LBL_BEN_TOTAL_D_AMOUNT
        '
        Me.LBL_BEN_TOTAL_D_AMOUNT.AutoSize = True
        Me.LBL_BEN_TOTAL_D_AMOUNT.Font = New System.Drawing.Font("Arial Nova", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BEN_TOTAL_D_AMOUNT.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.LBL_BEN_TOTAL_D_AMOUNT.Location = New System.Drawing.Point(10, 41)
        Me.LBL_BEN_TOTAL_D_AMOUNT.Name = "LBL_BEN_TOTAL_D_AMOUNT"
        Me.LBL_BEN_TOTAL_D_AMOUNT.Size = New System.Drawing.Size(48, 23)
        Me.LBL_BEN_TOTAL_D_AMOUNT.TabIndex = 0
        Me.LBL_BEN_TOTAL_D_AMOUNT.Text = "0.00"
        '
        'frmBeneficiaryDasboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 431)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBeneficiaryDasboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBeneficiaryDasboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GunaShadowPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PNL_RETURN.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PNL_DISBURSE.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PNL_DISBURSE As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents PNL_RETURN As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBL_BEN_TOTAL_D_AMOUNT As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBL_BEN_TOTAL_R_AMOUNT As Label
    Friend WithEvents ToolTip_Disburse As ToolTip
    Friend WithEvents ToolTip_Return As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TXT_BEN_TOTAL_BALANCE As Guna.UI.WinForms.GunaLineTextBox
End Class
