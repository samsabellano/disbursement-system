<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBeneficiaryLoginInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeneficiaryLoginInformation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PNL_CURRENT_PASS = New System.Windows.Forms.Panel()
        Me.PB_CURRENT_PASS = New System.Windows.Forms.PictureBox()
        Me.lbl_current_pass = New System.Windows.Forms.Label()
        Me.TXT_CURRENT_PASSWORD = New Guna.UI.WinForms.GunaLineTextBox()
        Me.BTN_SAVE_NEW_PASSWORD = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnl_SH_BTN_2 = New System.Windows.Forms.Panel()
        Me.BTN_show_hide_confirm_password = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnl_SH_BTN_1 = New System.Windows.Forms.Panel()
        Me.BTN_show_hide_new_password = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lbl_new_pass = New System.Windows.Forms.Label()
        Me.TXT_CONFIRM_PASSWORD = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lbl_confirm_pass = New System.Windows.Forms.Label()
        Me.TXT_NEW_PASSWORD = New Guna.UI.WinForms.GunaLineTextBox()
        Me.LOGIN_PICTURE_BOX = New System.Windows.Forms.PictureBox()
        Me.LBL_PASSWORD_ALERT = New System.Windows.Forms.Label()
        Me.timer_success = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.PNL_CURRENT_PASS.SuspendLayout()
        CType(Me.PB_CURRENT_PASS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_SH_BTN_2.SuspendLayout()
        Me.pnl_SH_BTN_1.SuspendLayout()
        CType(Me.LOGIN_PICTURE_BOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GunaShadowPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 504)
        Me.Panel1.TabIndex = 108
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.PNL_CURRENT_PASS)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_current_pass)
        Me.GunaShadowPanel1.Controls.Add(Me.TXT_CURRENT_PASSWORD)
        Me.GunaShadowPanel1.Controls.Add(Me.BTN_SAVE_NEW_PASSWORD)
        Me.GunaShadowPanel1.Controls.Add(Me.pnl_SH_BTN_2)
        Me.GunaShadowPanel1.Controls.Add(Me.pnl_SH_BTN_1)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_new_pass)
        Me.GunaShadowPanel1.Controls.Add(Me.TXT_CONFIRM_PASSWORD)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_confirm_pass)
        Me.GunaShadowPanel1.Controls.Add(Me.TXT_NEW_PASSWORD)
        Me.GunaShadowPanel1.Controls.Add(Me.LOGIN_PICTURE_BOX)
        Me.GunaShadowPanel1.Controls.Add(Me.LBL_PASSWORD_ALERT)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(126, 32)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 3
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel1.ShadowDepth = 50
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(499, 440)
        Me.GunaShadowPanel1.TabIndex = 175
        '
        'PNL_CURRENT_PASS
        '
        Me.PNL_CURRENT_PASS.Controls.Add(Me.PB_CURRENT_PASS)
        Me.PNL_CURRENT_PASS.Location = New System.Drawing.Point(349, 136)
        Me.PNL_CURRENT_PASS.Name = "PNL_CURRENT_PASS"
        Me.PNL_CURRENT_PASS.Size = New System.Drawing.Size(55, 26)
        Me.PNL_CURRENT_PASS.TabIndex = 186
        Me.PNL_CURRENT_PASS.Visible = False
        '
        'PB_CURRENT_PASS
        '
        Me.PB_CURRENT_PASS.Dock = System.Windows.Forms.DockStyle.Right
        Me.PB_CURRENT_PASS.Image = CType(resources.GetObject("PB_CURRENT_PASS.Image"), System.Drawing.Image)
        Me.PB_CURRENT_PASS.Location = New System.Drawing.Point(18, 0)
        Me.PB_CURRENT_PASS.Name = "PB_CURRENT_PASS"
        Me.PB_CURRENT_PASS.Size = New System.Drawing.Size(37, 26)
        Me.PB_CURRENT_PASS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_CURRENT_PASS.TabIndex = 189
        Me.PB_CURRENT_PASS.TabStop = False
        '
        'lbl_current_pass
        '
        Me.lbl_current_pass.AutoSize = True
        Me.lbl_current_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current_pass.ForeColor = System.Drawing.Color.Teal
        Me.lbl_current_pass.Location = New System.Drawing.Point(96, 107)
        Me.lbl_current_pass.Name = "lbl_current_pass"
        Me.lbl_current_pass.Size = New System.Drawing.Size(186, 15)
        Me.lbl_current_pass.TabIndex = 188
        Me.lbl_current_pass.Text = "Enter your current password"
        '
        'TXT_CURRENT_PASSWORD
        '
        Me.TXT_CURRENT_PASSWORD.Animated = True
        Me.TXT_CURRENT_PASSWORD.BackColor = System.Drawing.Color.White
        Me.TXT_CURRENT_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CURRENT_PASSWORD.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.TXT_CURRENT_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CURRENT_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_CURRENT_PASSWORD.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_CURRENT_PASSWORD.LineSize = 2
        Me.TXT_CURRENT_PASSWORD.Location = New System.Drawing.Point(93, 134)
        Me.TXT_CURRENT_PASSWORD.Name = "TXT_CURRENT_PASSWORD"
        Me.TXT_CURRENT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXT_CURRENT_PASSWORD.Size = New System.Drawing.Size(305, 33)
        Me.TXT_CURRENT_PASSWORD.TabIndex = 187
        Me.TXT_CURRENT_PASSWORD.UseSystemPasswordChar = True
        '
        'BTN_SAVE_NEW_PASSWORD
        '
        Me.BTN_SAVE_NEW_PASSWORD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_SAVE_NEW_PASSWORD.Animated = True
        Me.BTN_SAVE_NEW_PASSWORD.AnimationHoverSpeed = 0.07!
        Me.BTN_SAVE_NEW_PASSWORD.AnimationSpeed = 0.03!
        Me.BTN_SAVE_NEW_PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SAVE_NEW_PASSWORD.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_SAVE_NEW_PASSWORD.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SAVE_NEW_PASSWORD.BorderSize = 1
        Me.BTN_SAVE_NEW_PASSWORD.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_SAVE_NEW_PASSWORD.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SAVE_NEW_PASSWORD.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_SAVE_NEW_PASSWORD.CheckedImage = CType(resources.GetObject("BTN_SAVE_NEW_PASSWORD.CheckedImage"), System.Drawing.Image)
        Me.BTN_SAVE_NEW_PASSWORD.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_SAVE_NEW_PASSWORD.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_SAVE_NEW_PASSWORD.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_SAVE_NEW_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE_NEW_PASSWORD.ForeColor = System.Drawing.Color.White
        Me.BTN_SAVE_NEW_PASSWORD.Image = Nothing
        Me.BTN_SAVE_NEW_PASSWORD.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_SAVE_NEW_PASSWORD.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SAVE_NEW_PASSWORD.Location = New System.Drawing.Point(93, 364)
        Me.BTN_SAVE_NEW_PASSWORD.Name = "BTN_SAVE_NEW_PASSWORD"
        Me.BTN_SAVE_NEW_PASSWORD.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_SAVE_NEW_PASSWORD.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SAVE_NEW_PASSWORD.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_SAVE_NEW_PASSWORD.OnHoverImage = Nothing
        Me.BTN_SAVE_NEW_PASSWORD.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SAVE_NEW_PASSWORD.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_SAVE_NEW_PASSWORD.Radius = 5
        Me.BTN_SAVE_NEW_PASSWORD.Size = New System.Drawing.Size(305, 37)
        Me.BTN_SAVE_NEW_PASSWORD.TabIndex = 111
        Me.BTN_SAVE_NEW_PASSWORD.Text = "Save New Password"
        Me.BTN_SAVE_NEW_PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnl_SH_BTN_2
        '
        Me.pnl_SH_BTN_2.Controls.Add(Me.BTN_show_hide_confirm_password)
        Me.pnl_SH_BTN_2.Location = New System.Drawing.Point(349, 298)
        Me.pnl_SH_BTN_2.Name = "pnl_SH_BTN_2"
        Me.pnl_SH_BTN_2.Size = New System.Drawing.Size(55, 26)
        Me.pnl_SH_BTN_2.TabIndex = 186
        Me.pnl_SH_BTN_2.Visible = False
        '
        'BTN_show_hide_confirm_password
        '
        Me.BTN_show_hide_confirm_password.Animated = True
        Me.BTN_show_hide_confirm_password.AnimationHoverSpeed = 0.07!
        Me.BTN_show_hide_confirm_password.AnimationSpeed = 0.03!
        Me.BTN_show_hide_confirm_password.BackColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.BaseColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.BorderColor = System.Drawing.Color.Black
        Me.BTN_show_hide_confirm_password.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton
        Me.BTN_show_hide_confirm_password.CheckedBaseColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_show_hide_confirm_password.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.CheckedImage = CType(resources.GetObject("BTN_show_hide_confirm_password.CheckedImage"), System.Drawing.Image)
        Me.BTN_show_hide_confirm_password.CheckedLineColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_show_hide_confirm_password.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_show_hide_confirm_password.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_show_hide_confirm_password.FocusedColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_show_hide_confirm_password.ForeColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.Image = CType(resources.GetObject("BTN_show_hide_confirm_password.Image"), System.Drawing.Image)
        Me.BTN_show_hide_confirm_password.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_show_hide_confirm_password.LineColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.Location = New System.Drawing.Point(18, 0)
        Me.BTN_show_hide_confirm_password.Name = "BTN_show_hide_confirm_password"
        Me.BTN_show_hide_confirm_password.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_show_hide_confirm_password.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.OnHoverImage = Nothing
        Me.BTN_show_hide_confirm_password.OnHoverLineColor = System.Drawing.Color.White
        Me.BTN_show_hide_confirm_password.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_show_hide_confirm_password.Size = New System.Drawing.Size(37, 26)
        Me.BTN_show_hide_confirm_password.TabIndex = 185
        '
        'pnl_SH_BTN_1
        '
        Me.pnl_SH_BTN_1.Controls.Add(Me.BTN_show_hide_new_password)
        Me.pnl_SH_BTN_1.Location = New System.Drawing.Point(349, 217)
        Me.pnl_SH_BTN_1.Name = "pnl_SH_BTN_1"
        Me.pnl_SH_BTN_1.Size = New System.Drawing.Size(55, 26)
        Me.pnl_SH_BTN_1.TabIndex = 184
        Me.pnl_SH_BTN_1.Visible = False
        '
        'BTN_show_hide_new_password
        '
        Me.BTN_show_hide_new_password.Animated = True
        Me.BTN_show_hide_new_password.AnimationHoverSpeed = 0.07!
        Me.BTN_show_hide_new_password.AnimationSpeed = 0.03!
        Me.BTN_show_hide_new_password.BackColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.BaseColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.BorderColor = System.Drawing.Color.Black
        Me.BTN_show_hide_new_password.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton
        Me.BTN_show_hide_new_password.CheckedBaseColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_show_hide_new_password.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.CheckedImage = CType(resources.GetObject("BTN_show_hide_new_password.CheckedImage"), System.Drawing.Image)
        Me.BTN_show_hide_new_password.CheckedLineColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_show_hide_new_password.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_show_hide_new_password.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_show_hide_new_password.FocusedColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_show_hide_new_password.ForeColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.Image = CType(resources.GetObject("BTN_show_hide_new_password.Image"), System.Drawing.Image)
        Me.BTN_show_hide_new_password.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_show_hide_new_password.LineColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.Location = New System.Drawing.Point(18, 0)
        Me.BTN_show_hide_new_password.Name = "BTN_show_hide_new_password"
        Me.BTN_show_hide_new_password.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_show_hide_new_password.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.OnHoverImage = Nothing
        Me.BTN_show_hide_new_password.OnHoverLineColor = System.Drawing.Color.White
        Me.BTN_show_hide_new_password.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_show_hide_new_password.Size = New System.Drawing.Size(37, 26)
        Me.BTN_show_hide_new_password.TabIndex = 185
        '
        'lbl_new_pass
        '
        Me.lbl_new_pass.AutoSize = True
        Me.lbl_new_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_pass.ForeColor = System.Drawing.Color.Teal
        Me.lbl_new_pass.Location = New System.Drawing.Point(96, 188)
        Me.lbl_new_pass.Name = "lbl_new_pass"
        Me.lbl_new_pass.Size = New System.Drawing.Size(101, 15)
        Me.lbl_new_pass.TabIndex = 182
        Me.lbl_new_pass.Text = "New Password"
        '
        'TXT_CONFIRM_PASSWORD
        '
        Me.TXT_CONFIRM_PASSWORD.Animated = True
        Me.TXT_CONFIRM_PASSWORD.BackColor = System.Drawing.Color.White
        Me.TXT_CONFIRM_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CONFIRM_PASSWORD.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CONFIRM_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CONFIRM_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_CONFIRM_PASSWORD.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_CONFIRM_PASSWORD.LineSize = 2
        Me.TXT_CONFIRM_PASSWORD.Location = New System.Drawing.Point(93, 297)
        Me.TXT_CONFIRM_PASSWORD.Name = "TXT_CONFIRM_PASSWORD"
        Me.TXT_CONFIRM_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXT_CONFIRM_PASSWORD.Size = New System.Drawing.Size(305, 32)
        Me.TXT_CONFIRM_PASSWORD.TabIndex = 189
        Me.TXT_CONFIRM_PASSWORD.UseSystemPasswordChar = True
        '
        'lbl_confirm_pass
        '
        Me.lbl_confirm_pass.AutoSize = True
        Me.lbl_confirm_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirm_pass.ForeColor = System.Drawing.Color.Teal
        Me.lbl_confirm_pass.Location = New System.Drawing.Point(96, 270)
        Me.lbl_confirm_pass.Name = "lbl_confirm_pass"
        Me.lbl_confirm_pass.Size = New System.Drawing.Size(123, 15)
        Me.lbl_confirm_pass.TabIndex = 180
        Me.lbl_confirm_pass.Text = "Confirm Password"
        '
        'TXT_NEW_PASSWORD
        '
        Me.TXT_NEW_PASSWORD.Animated = True
        Me.TXT_NEW_PASSWORD.BackColor = System.Drawing.Color.White
        Me.TXT_NEW_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NEW_PASSWORD.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NEW_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NEW_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_NEW_PASSWORD.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_NEW_PASSWORD.LineSize = 2
        Me.TXT_NEW_PASSWORD.Location = New System.Drawing.Point(93, 215)
        Me.TXT_NEW_PASSWORD.Name = "TXT_NEW_PASSWORD"
        Me.TXT_NEW_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXT_NEW_PASSWORD.Size = New System.Drawing.Size(305, 33)
        Me.TXT_NEW_PASSWORD.TabIndex = 188
        Me.TXT_NEW_PASSWORD.UseSystemPasswordChar = True
        '
        'LOGIN_PICTURE_BOX
        '
        Me.LOGIN_PICTURE_BOX.Image = CType(resources.GetObject("LOGIN_PICTURE_BOX.Image"), System.Drawing.Image)
        Me.LOGIN_PICTURE_BOX.Location = New System.Drawing.Point(93, 34)
        Me.LOGIN_PICTURE_BOX.Name = "LOGIN_PICTURE_BOX"
        Me.LOGIN_PICTURE_BOX.Size = New System.Drawing.Size(55, 47)
        Me.LOGIN_PICTURE_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGIN_PICTURE_BOX.TabIndex = 177
        Me.LOGIN_PICTURE_BOX.TabStop = False
        '
        'LBL_PASSWORD_ALERT
        '
        Me.LBL_PASSWORD_ALERT.AutoSize = True
        Me.LBL_PASSWORD_ALERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PASSWORD_ALERT.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LBL_PASSWORD_ALERT.Location = New System.Drawing.Point(154, 50)
        Me.LBL_PASSWORD_ALERT.Name = "LBL_PASSWORD_ALERT"
        Me.LBL_PASSWORD_ALERT.Size = New System.Drawing.Size(190, 16)
        Me.LBL_PASSWORD_ALERT.TabIndex = 175
        Me.LBL_PASSWORD_ALERT.Text = "Create your new password"
        '
        'timer_success
        '
        '
        'frmBeneficiaryLoginInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 504)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBeneficiaryLoginInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBeneficiaryLoginInformation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.PNL_CURRENT_PASS.ResumeLayout(False)
        CType(Me.PB_CURRENT_PASS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_SH_BTN_2.ResumeLayout(False)
        Me.pnl_SH_BTN_1.ResumeLayout(False)
        CType(Me.LOGIN_PICTURE_BOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents timer_success As Timer
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents lbl_new_pass As Label
    Friend WithEvents TXT_CONFIRM_PASSWORD As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lbl_confirm_pass As Label
    Friend WithEvents TXT_NEW_PASSWORD As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BTN_SAVE_NEW_PASSWORD As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents LOGIN_PICTURE_BOX As PictureBox
    Friend WithEvents LBL_PASSWORD_ALERT As Label
    Friend WithEvents pnl_SH_BTN_1 As Panel
    Friend WithEvents BTN_show_hide_new_password As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnl_SH_BTN_2 As Panel
    Friend WithEvents BTN_show_hide_confirm_password As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lbl_current_pass As Label
    Friend WithEvents TXT_CURRENT_PASSWORD As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PNL_CURRENT_PASS As Panel
    Friend WithEvents PB_CURRENT_PASS As PictureBox
End Class
