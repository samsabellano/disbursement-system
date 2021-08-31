<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContractManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContractManagement))
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_BenMain = New Guna.UI.WinForms.GunaShadowPanel()
        Me.pnl_contract_holder = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_CM_ADD_CONTRACT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_CM_CONTRACT_HISTORY = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnl_choose_contract_management = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_BenMain.SuspendLayout()
        Me.pnl_contract_holder.SuspendLayout()
        Me.GunaShadowPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 2
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 15
        Me.GunaShadowPanel1.ShadowShift = 4
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(1004, 55)
        Me.GunaShadowPanel1.TabIndex = 7
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.SeaGreen
        Me.GunaLabel5.Location = New System.Drawing.Point(34, 20)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(165, 18)
        Me.GunaLabel5.TabIndex = 2
        Me.GunaLabel5.Text = "Contract Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnl_BenMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 545)
        Me.Panel1.TabIndex = 8
        '
        'pnl_BenMain
        '
        Me.pnl_BenMain.BackColor = System.Drawing.Color.Transparent
        Me.pnl_BenMain.BaseColor = System.Drawing.Color.White
        Me.pnl_BenMain.Controls.Add(Me.pnl_contract_holder)
        Me.pnl_BenMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_BenMain.Location = New System.Drawing.Point(0, 0)
        Me.pnl_BenMain.Name = "pnl_BenMain"
        Me.pnl_BenMain.Radius = 2
        Me.pnl_BenMain.ShadowColor = System.Drawing.Color.Black
        Me.pnl_BenMain.ShadowDepth = 20
        Me.pnl_BenMain.Size = New System.Drawing.Size(1004, 545)
        Me.pnl_BenMain.TabIndex = 4
        '
        'pnl_contract_holder
        '
        Me.pnl_contract_holder.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_contract_holder.Controls.Add(Me.GunaShadowPanel3)
        Me.pnl_contract_holder.Controls.Add(Me.pnl_choose_contract_management)
        Me.pnl_contract_holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_contract_holder.Location = New System.Drawing.Point(0, 0)
        Me.pnl_contract_holder.Name = "pnl_contract_holder"
        Me.pnl_contract_holder.Size = New System.Drawing.Size(1004, 545)
        Me.pnl_contract_holder.TabIndex = 2
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel3.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaShadowPanel3.Controls.Add(Me.BTN_CM_ADD_CONTRACT)
        Me.GunaShadowPanel3.Controls.Add(Me.BTN_CM_CONTRACT_HISTORY)
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(94, 51)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.Radius = 4
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel3.ShadowDepth = 50
        Me.GunaShadowPanel3.ShadowShift = 6
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(816, 461)
        Me.GunaShadowPanel3.TabIndex = 13
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Arial Nova", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageOffsetX = 50
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(32, 32)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.LineLeft = 3
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(80, 280)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(650, 120)
        Me.GunaAdvenceButton1.TabIndex = 94
        Me.GunaAdvenceButton1.Text = "  Update Contract"
        '
        'BTN_CM_ADD_CONTRACT
        '
        Me.BTN_CM_ADD_CONTRACT.Animated = True
        Me.BTN_CM_ADD_CONTRACT.AnimationHoverSpeed = 0.07!
        Me.BTN_CM_ADD_CONTRACT.AnimationSpeed = 0.03!
        Me.BTN_CM_ADD_CONTRACT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CM_ADD_CONTRACT.BaseColor = System.Drawing.Color.White
        Me.BTN_CM_ADD_CONTRACT.BorderColor = System.Drawing.Color.Black
        Me.BTN_CM_ADD_CONTRACT.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BTN_CM_ADD_CONTRACT.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_CM_ADD_CONTRACT.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_CM_ADD_CONTRACT.CheckedImage = Nothing
        Me.BTN_CM_ADD_CONTRACT.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_CM_ADD_CONTRACT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_CM_ADD_CONTRACT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CM_ADD_CONTRACT.Font = New System.Drawing.Font("Arial Nova", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CM_ADD_CONTRACT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BTN_CM_ADD_CONTRACT.Image = CType(resources.GetObject("BTN_CM_ADD_CONTRACT.Image"), System.Drawing.Image)
        Me.BTN_CM_ADD_CONTRACT.ImageOffsetX = 50
        Me.BTN_CM_ADD_CONTRACT.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTN_CM_ADD_CONTRACT.LineColor = System.Drawing.Color.White
        Me.BTN_CM_ADD_CONTRACT.LineLeft = 3
        Me.BTN_CM_ADD_CONTRACT.Location = New System.Drawing.Point(80, 158)
        Me.BTN_CM_ADD_CONTRACT.Name = "BTN_CM_ADD_CONTRACT"
        Me.BTN_CM_ADD_CONTRACT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTN_CM_ADD_CONTRACT.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_CM_ADD_CONTRACT.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BTN_CM_ADD_CONTRACT.OnHoverImage = Nothing
        Me.BTN_CM_ADD_CONTRACT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_CM_ADD_CONTRACT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CM_ADD_CONTRACT.Radius = 5
        Me.BTN_CM_ADD_CONTRACT.Size = New System.Drawing.Size(650, 120)
        Me.BTN_CM_ADD_CONTRACT.TabIndex = 93
        Me.BTN_CM_ADD_CONTRACT.Text = "  Add New Contract"
        '
        'BTN_CM_CONTRACT_HISTORY
        '
        Me.BTN_CM_CONTRACT_HISTORY.Animated = True
        Me.BTN_CM_CONTRACT_HISTORY.AnimationHoverSpeed = 0.07!
        Me.BTN_CM_CONTRACT_HISTORY.AnimationSpeed = 0.03!
        Me.BTN_CM_CONTRACT_HISTORY.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CM_CONTRACT_HISTORY.BaseColor = System.Drawing.Color.White
        Me.BTN_CM_CONTRACT_HISTORY.BorderColor = System.Drawing.Color.Black
        Me.BTN_CM_CONTRACT_HISTORY.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BTN_CM_CONTRACT_HISTORY.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_CM_CONTRACT_HISTORY.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_CM_CONTRACT_HISTORY.CheckedImage = Nothing
        Me.BTN_CM_CONTRACT_HISTORY.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_CM_CONTRACT_HISTORY.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_CM_CONTRACT_HISTORY.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CM_CONTRACT_HISTORY.Font = New System.Drawing.Font("Arial Nova", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CM_CONTRACT_HISTORY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BTN_CM_CONTRACT_HISTORY.Image = CType(resources.GetObject("BTN_CM_CONTRACT_HISTORY.Image"), System.Drawing.Image)
        Me.BTN_CM_CONTRACT_HISTORY.ImageOffsetX = 50
        Me.BTN_CM_CONTRACT_HISTORY.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTN_CM_CONTRACT_HISTORY.LineColor = System.Drawing.Color.White
        Me.BTN_CM_CONTRACT_HISTORY.LineLeft = 3
        Me.BTN_CM_CONTRACT_HISTORY.Location = New System.Drawing.Point(80, 36)
        Me.BTN_CM_CONTRACT_HISTORY.Name = "BTN_CM_CONTRACT_HISTORY"
        Me.BTN_CM_CONTRACT_HISTORY.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTN_CM_CONTRACT_HISTORY.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_CM_CONTRACT_HISTORY.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BTN_CM_CONTRACT_HISTORY.OnHoverImage = Nothing
        Me.BTN_CM_CONTRACT_HISTORY.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_CM_CONTRACT_HISTORY.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CM_CONTRACT_HISTORY.Radius = 5
        Me.BTN_CM_CONTRACT_HISTORY.Size = New System.Drawing.Size(650, 120)
        Me.BTN_CM_CONTRACT_HISTORY.TabIndex = 92
        Me.BTN_CM_CONTRACT_HISTORY.Text = "  View Contract History"
        '
        'pnl_choose_contract_management
        '
        Me.pnl_choose_contract_management.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_choose_contract_management.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_choose_contract_management.Location = New System.Drawing.Point(12, 6)
        Me.pnl_choose_contract_management.Name = "pnl_choose_contract_management"
        Me.pnl_choose_contract_management.Size = New System.Drawing.Size(980, 527)
        Me.pnl_choose_contract_management.TabIndex = 14
        '
        'frmContractManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmContractManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmContractManagement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnl_BenMain.ResumeLayout(False)
        Me.pnl_contract_holder.ResumeLayout(False)
        Me.GunaShadowPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_BenMain As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents pnl_contract_holder As Panel
    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents pnl_choose_contract_management As Panel
    Friend WithEvents BTN_CM_CONTRACT_HISTORY As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_CM_ADD_CONTRACT As Guna.UI.WinForms.GunaAdvenceButton
End Class
