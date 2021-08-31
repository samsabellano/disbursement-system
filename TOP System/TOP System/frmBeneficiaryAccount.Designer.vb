<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBeneficiaryAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeneficiaryAccount))
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.LBL_BENEFICIARY_USERNAME = New System.Windows.Forms.Label()
        Me.LBL_BENEFICIARY_EMAIL = New System.Windows.Forms.Label()
        Me.BTN_LOGOUT = New Guna.UI.WinForms.GunaCircleButton()
        Me.LBL_BENEFICIARY_NAME = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PNL_BENEFICIARY_ACCOUNT = New System.Windows.Forms.Panel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.BTN_BEN_DASHBOARD = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_BEN_MAIN_INFO = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_BEN_EC = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_BEN_LOG_INFO = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaShadowPanel3.SuspendLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel3.Controls.Add(Me.LBL_BENEFICIARY_USERNAME)
        Me.GunaShadowPanel3.Controls.Add(Me.LBL_BENEFICIARY_EMAIL)
        Me.GunaShadowPanel3.Controls.Add(Me.BTN_LOGOUT)
        Me.GunaShadowPanel3.Controls.Add(Me.LBL_BENEFICIARY_NAME)
        Me.GunaShadowPanel3.Controls.Add(Me.GunaCirclePictureBox3)
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(68, 86)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.Radius = 2
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Teal
        Me.GunaShadowPanel3.ShadowDepth = 50
        Me.GunaShadowPanel3.ShadowShift = 3
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(830, 103)
        Me.GunaShadowPanel3.TabIndex = 6
        '
        'LBL_BENEFICIARY_USERNAME
        '
        Me.LBL_BENEFICIARY_USERNAME.AutoSize = True
        Me.LBL_BENEFICIARY_USERNAME.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BENEFICIARY_USERNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LBL_BENEFICIARY_USERNAME.Image = CType(resources.GetObject("LBL_BENEFICIARY_USERNAME.Image"), System.Drawing.Image)
        Me.LBL_BENEFICIARY_USERNAME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBL_BENEFICIARY_USERNAME.Location = New System.Drawing.Point(117, 70)
        Me.LBL_BENEFICIARY_USERNAME.Name = "LBL_BENEFICIARY_USERNAME"
        Me.LBL_BENEFICIARY_USERNAME.Size = New System.Drawing.Size(75, 14)
        Me.LBL_BENEFICIARY_USERNAME.TabIndex = 90
        Me.LBL_BENEFICIARY_USERNAME.Text = "      Username"
        Me.LBL_BENEFICIARY_USERNAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_BENEFICIARY_EMAIL
        '
        Me.LBL_BENEFICIARY_EMAIL.AutoSize = True
        Me.LBL_BENEFICIARY_EMAIL.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BENEFICIARY_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LBL_BENEFICIARY_EMAIL.Image = CType(resources.GetObject("LBL_BENEFICIARY_EMAIL.Image"), System.Drawing.Image)
        Me.LBL_BENEFICIARY_EMAIL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBL_BENEFICIARY_EMAIL.Location = New System.Drawing.Point(117, 48)
        Me.LBL_BENEFICIARY_EMAIL.Name = "LBL_BENEFICIARY_EMAIL"
        Me.LBL_BENEFICIARY_EMAIL.Size = New System.Drawing.Size(51, 14)
        Me.LBL_BENEFICIARY_EMAIL.TabIndex = 83
        Me.LBL_BENEFICIARY_EMAIL.Text = "      Email"
        Me.LBL_BENEFICIARY_EMAIL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_LOGOUT
        '
        Me.BTN_LOGOUT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_LOGOUT.Animated = True
        Me.BTN_LOGOUT.AnimationHoverSpeed = 0.07!
        Me.BTN_LOGOUT.AnimationSpeed = 0.03!
        Me.BTN_LOGOUT.BaseColor = System.Drawing.Color.White
        Me.BTN_LOGOUT.BorderColor = System.Drawing.Color.Black
        Me.BTN_LOGOUT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_LOGOUT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_LOGOUT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_LOGOUT.ForeColor = System.Drawing.Color.White
        Me.BTN_LOGOUT.Image = CType(resources.GetObject("BTN_LOGOUT.Image"), System.Drawing.Image)
        Me.BTN_LOGOUT.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_LOGOUT.Location = New System.Drawing.Point(739, 35)
        Me.BTN_LOGOUT.Name = "BTN_LOGOUT"
        Me.BTN_LOGOUT.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_LOGOUT.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_LOGOUT.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_LOGOUT.OnHoverImage = Nothing
        Me.BTN_LOGOUT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_LOGOUT.Size = New System.Drawing.Size(28, 28)
        Me.BTN_LOGOUT.TabIndex = 89
        '
        'LBL_BENEFICIARY_NAME
        '
        Me.LBL_BENEFICIARY_NAME.AutoSize = True
        Me.LBL_BENEFICIARY_NAME.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BENEFICIARY_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_BENEFICIARY_NAME.Location = New System.Drawing.Point(117, 24)
        Me.LBL_BENEFICIARY_NAME.Name = "LBL_BENEFICIARY_NAME"
        Me.LBL_BENEFICIARY_NAME.Size = New System.Drawing.Size(114, 16)
        Me.LBL_BENEFICIARY_NAME.TabIndex = 50
        Me.LBL_BENEFICIARY_NAME.Text = "Beneficiary Name"
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox3.Image = CType(resources.GetObject("GunaCirclePictureBox3.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(42, 18)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(69, 66)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox3.TabIndex = 52
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.PNL_BENEFICIARY_ACCOUNT)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLinePanel1)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(68, 193)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 2
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Teal
        Me.GunaShadowPanel2.ShadowDepth = 50
        Me.GunaShadowPanel2.ShadowShift = 3
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(830, 464)
        Me.GunaShadowPanel2.TabIndex = 5
        '
        'PNL_BENEFICIARY_ACCOUNT
        '
        Me.PNL_BENEFICIARY_ACCOUNT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_BENEFICIARY_ACCOUNT.Location = New System.Drawing.Point(7, 66)
        Me.PNL_BENEFICIARY_ACCOUNT.Name = "PNL_BENEFICIARY_ACCOUNT"
        Me.PNL_BENEFICIARY_ACCOUNT.Size = New System.Drawing.Size(815, 386)
        Me.PNL_BENEFICIARY_ACCOUNT.TabIndex = 58
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel1.Controls.Add(Me.BTN_BEN_DASHBOARD)
        Me.GunaLinePanel1.Controls.Add(Me.BTN_BEN_MAIN_INFO)
        Me.GunaLinePanel1.Controls.Add(Me.BTN_BEN_EC)
        Me.GunaLinePanel1.Controls.Add(Me.BTN_BEN_LOG_INFO)
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(3, 3)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(824, 57)
        Me.GunaLinePanel1.TabIndex = 0
        '
        'BTN_BEN_DASHBOARD
        '
        Me.BTN_BEN_DASHBOARD.Animated = True
        Me.BTN_BEN_DASHBOARD.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_DASHBOARD.AnimationSpeed = 0.03!
        Me.BTN_BEN_DASHBOARD.BaseColor = System.Drawing.Color.White
        Me.BTN_BEN_DASHBOARD.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_DASHBOARD.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_DASHBOARD.CheckedBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_DASHBOARD.CheckedBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_DASHBOARD.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_DASHBOARD.CheckedImage = Nothing
        Me.BTN_BEN_DASHBOARD.CheckedLineColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_DASHBOARD.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_DASHBOARD.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_DASHBOARD.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_DASHBOARD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_DASHBOARD.Image = Nothing
        Me.BTN_BEN_DASHBOARD.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_BEN_DASHBOARD.LineBottom = 3
        Me.BTN_BEN_DASHBOARD.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_DASHBOARD.Location = New System.Drawing.Point(23, 9)
        Me.BTN_BEN_DASHBOARD.Name = "BTN_BEN_DASHBOARD"
        Me.BTN_BEN_DASHBOARD.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_DASHBOARD.OnHoverBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_DASHBOARD.OnHoverForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_DASHBOARD.OnHoverImage = Nothing
        Me.BTN_BEN_DASHBOARD.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_DASHBOARD.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_DASHBOARD.Size = New System.Drawing.Size(115, 47)
        Me.BTN_BEN_DASHBOARD.TabIndex = 58
        Me.BTN_BEN_DASHBOARD.Text = "Dashboard"
        Me.BTN_BEN_DASHBOARD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_BEN_MAIN_INFO
        '
        Me.BTN_BEN_MAIN_INFO.Animated = True
        Me.BTN_BEN_MAIN_INFO.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_MAIN_INFO.AnimationSpeed = 0.03!
        Me.BTN_BEN_MAIN_INFO.BaseColor = System.Drawing.Color.White
        Me.BTN_BEN_MAIN_INFO.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_MAIN_INFO.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_MAIN_INFO.CheckedBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_MAIN_INFO.CheckedBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_MAIN_INFO.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_MAIN_INFO.CheckedImage = Nothing
        Me.BTN_BEN_MAIN_INFO.CheckedLineColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_MAIN_INFO.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_MAIN_INFO.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_MAIN_INFO.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_MAIN_INFO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_MAIN_INFO.Image = Nothing
        Me.BTN_BEN_MAIN_INFO.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_BEN_MAIN_INFO.LineBottom = 3
        Me.BTN_BEN_MAIN_INFO.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_MAIN_INFO.Location = New System.Drawing.Point(139, 9)
        Me.BTN_BEN_MAIN_INFO.Name = "BTN_BEN_MAIN_INFO"
        Me.BTN_BEN_MAIN_INFO.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_MAIN_INFO.OnHoverBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_MAIN_INFO.OnHoverForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_MAIN_INFO.OnHoverImage = Nothing
        Me.BTN_BEN_MAIN_INFO.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_MAIN_INFO.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_MAIN_INFO.Size = New System.Drawing.Size(115, 47)
        Me.BTN_BEN_MAIN_INFO.TabIndex = 54
        Me.BTN_BEN_MAIN_INFO.Text = "Main Information"
        Me.BTN_BEN_MAIN_INFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_BEN_EC
        '
        Me.BTN_BEN_EC.Animated = True
        Me.BTN_BEN_EC.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_EC.AnimationSpeed = 0.03!
        Me.BTN_BEN_EC.BaseColor = System.Drawing.Color.White
        Me.BTN_BEN_EC.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_EC.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_EC.CheckedBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_EC.CheckedBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_EC.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_EC.CheckedImage = Nothing
        Me.BTN_BEN_EC.CheckedLineColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_EC.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_EC.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_EC.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_EC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_EC.Image = Nothing
        Me.BTN_BEN_EC.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_BEN_EC.LineBottom = 3
        Me.BTN_BEN_EC.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_EC.Location = New System.Drawing.Point(255, 12)
        Me.BTN_BEN_EC.Name = "BTN_BEN_EC"
        Me.BTN_BEN_EC.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_EC.OnHoverBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_EC.OnHoverForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_EC.OnHoverImage = Nothing
        Me.BTN_BEN_EC.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_EC.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_EC.Size = New System.Drawing.Size(136, 44)
        Me.BTN_BEN_EC.TabIndex = 55
        Me.BTN_BEN_EC.Text = "Emergency Contact"
        Me.BTN_BEN_EC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_BEN_LOG_INFO
        '
        Me.BTN_BEN_LOG_INFO.Animated = True
        Me.BTN_BEN_LOG_INFO.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_LOG_INFO.AnimationSpeed = 0.03!
        Me.BTN_BEN_LOG_INFO.BaseColor = System.Drawing.Color.White
        Me.BTN_BEN_LOG_INFO.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_LOG_INFO.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_LOG_INFO.CheckedBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_LOG_INFO.CheckedBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_LOG_INFO.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_LOG_INFO.CheckedImage = Nothing
        Me.BTN_BEN_LOG_INFO.CheckedLineColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_LOG_INFO.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_LOG_INFO.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_LOG_INFO.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_LOG_INFO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BTN_BEN_LOG_INFO.Image = Nothing
        Me.BTN_BEN_LOG_INFO.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_BEN_LOG_INFO.LineBottom = 3
        Me.BTN_BEN_LOG_INFO.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_LOG_INFO.Location = New System.Drawing.Point(392, 12)
        Me.BTN_BEN_LOG_INFO.Name = "BTN_BEN_LOG_INFO"
        Me.BTN_BEN_LOG_INFO.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_BEN_LOG_INFO.OnHoverBorderColor = System.Drawing.Color.White
        Me.BTN_BEN_LOG_INFO.OnHoverForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_BEN_LOG_INFO.OnHoverImage = Nothing
        Me.BTN_BEN_LOG_INFO.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_LOG_INFO.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_LOG_INFO.Size = New System.Drawing.Size(136, 44)
        Me.BTN_BEN_LOG_INFO.TabIndex = 56
        Me.BTN_BEN_LOG_INFO.Text = "Update Password"
        Me.BTN_BEN_LOG_INFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Date)
        Me.Panel1.Controls.Add(Me.lbl_Time)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 61)
        Me.Panel1.TabIndex = 7
        '
        'lbl_Date
        '
        Me.lbl_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Date.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Date.Location = New System.Drawing.Point(850, 9)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(30, 14)
        Me.lbl_Date.TabIndex = 30
        Me.lbl_Date.Text = "Date"
        Me.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Time
        '
        Me.lbl_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Time.AutoSize = True
        Me.lbl_Time.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Time.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Time.Location = New System.Drawing.Point(850, 35)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(30, 14)
        Me.lbl_Time.TabIndex = 29
        Me.lbl_Time.Text = "Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(64, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Tabernacle of Philippines"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmBeneficiaryAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(979, 693)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaShadowPanel3)
        Me.Controls.Add(Me.GunaShadowPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBeneficiaryAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditBeneficiaryInformation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaShadowPanel3.ResumeLayout(False)
        Me.GunaShadowPanel3.PerformLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents BTN_BEN_LOG_INFO As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_BEN_EC As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_BEN_MAIN_INFO As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_Date As Label
    Friend WithEvents lbl_Time As Label
    Friend WithEvents LBL_BENEFICIARY_NAME As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents BTN_LOGOUT As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents LBL_BENEFICIARY_EMAIL As Label
    Friend WithEvents BTN_BEN_DASHBOARD As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents PNL_BENEFICIARY_ACCOUNT As Panel
    Friend WithEvents LBL_BENEFICIARY_USERNAME As Label
End Class
