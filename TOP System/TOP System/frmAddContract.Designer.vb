<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddContract
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddContract))
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.pnl_contract_info = New Guna.UI.WinForms.GunaShadowPanel()
        Me.TXT_TERMS_OF_CONTRACT = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.CB_AGREE = New Guna.UI.WinForms.GunaCheckBox()
        Me.DTP_START_DATE = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BTN_BACK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_CONTINUE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.CBO_SEMESTER = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.CBO_SCHOOL_YEAR = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.CBO_BENEFICIARY_NAME_LIST = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.PNL_CONTRACT_ID = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PNL_LOGIN_AGREE_CONTRACT = New System.Windows.Forms.Panel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.BTN_CANCEL_AGREEMENT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_CONFIRM_AGREEMENT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TXT_BENEFICIARY_PASSWORD = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_GET_CONTRACT_ID_TO_SHOW = New Guna.UI.WinForms.GunaTextBox()
        Me.BTN_DONE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.pnl_contract_info.SuspendLayout()
        Me.PNL_CONTRACT_ID.SuspendLayout()
        Me.PNL_LOGIN_AGREE_CONTRACT.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.pnl_contract_info)
        Me.GunaShadowPanel1.Controls.Add(Me.PNL_CONTRACT_ID)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 60
        Me.GunaShadowPanel1.ShadowShift = 4
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(1064, 682)
        Me.GunaShadowPanel1.TabIndex = 0
        '
        'pnl_contract_info
        '
        Me.pnl_contract_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_contract_info.BackColor = System.Drawing.Color.Transparent
        Me.pnl_contract_info.BaseColor = System.Drawing.Color.White
        Me.pnl_contract_info.Controls.Add(Me.TXT_TERMS_OF_CONTRACT)
        Me.pnl_contract_info.Controls.Add(Me.GunaSeparator1)
        Me.pnl_contract_info.Controls.Add(Me.CB_AGREE)
        Me.pnl_contract_info.Controls.Add(Me.DTP_START_DATE)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel2)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel1)
        Me.pnl_contract_info.Controls.Add(Me.BTN_BACK)
        Me.pnl_contract_info.Controls.Add(Me.BTN_CONTINUE)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel7)
        Me.pnl_contract_info.Controls.Add(Me.CBO_SEMESTER)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel5)
        Me.pnl_contract_info.Controls.Add(Me.CBO_SCHOOL_YEAR)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel4)
        Me.pnl_contract_info.Controls.Add(Me.CBO_BENEFICIARY_NAME_LIST)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel6)
        Me.pnl_contract_info.Location = New System.Drawing.Point(140, 42)
        Me.pnl_contract_info.Name = "pnl_contract_info"
        Me.pnl_contract_info.Radius = 3
        Me.pnl_contract_info.ShadowColor = System.Drawing.Color.Gray
        Me.pnl_contract_info.ShadowDepth = 50
        Me.pnl_contract_info.ShadowShift = 6
        Me.pnl_contract_info.Size = New System.Drawing.Size(789, 593)
        Me.pnl_contract_info.TabIndex = 48
        '
        'TXT_TERMS_OF_CONTRACT
        '
        Me.TXT_TERMS_OF_CONTRACT.BackColor = System.Drawing.Color.Transparent
        Me.TXT_TERMS_OF_CONTRACT.BaseColor = System.Drawing.Color.White
        Me.TXT_TERMS_OF_CONTRACT.BorderColor = System.Drawing.Color.LightGray
        Me.TXT_TERMS_OF_CONTRACT.BorderSize = 1
        Me.TXT_TERMS_OF_CONTRACT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TERMS_OF_CONTRACT.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_TERMS_OF_CONTRACT.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TERMS_OF_CONTRACT.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_TERMS_OF_CONTRACT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TERMS_OF_CONTRACT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.TXT_TERMS_OF_CONTRACT.Location = New System.Drawing.Point(108, 339)
        Me.TXT_TERMS_OF_CONTRACT.MultiLine = True
        Me.TXT_TERMS_OF_CONTRACT.Name = "TXT_TERMS_OF_CONTRACT"
        Me.TXT_TERMS_OF_CONTRACT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TERMS_OF_CONTRACT.Radius = 5
        Me.TXT_TERMS_OF_CONTRACT.Size = New System.Drawing.Size(574, 87)
        Me.TXT_TERMS_OF_CONTRACT.TabIndex = 72
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(108, 68)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(574, 18)
        Me.GunaSeparator1.TabIndex = 71
        Me.GunaSeparator1.Thickness = 2
        '
        'CB_AGREE
        '
        Me.CB_AGREE.BaseColor = System.Drawing.Color.White
        Me.CB_AGREE.CheckedOffColor = System.Drawing.Color.Turquoise
        Me.CB_AGREE.CheckedOnColor = System.Drawing.Color.Tomato
        Me.CB_AGREE.FillColor = System.Drawing.Color.White
        Me.CB_AGREE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_AGREE.ForeColor = System.Drawing.Color.SkyBlue
        Me.CB_AGREE.Location = New System.Drawing.Point(108, 432)
        Me.CB_AGREE.Name = "CB_AGREE"
        Me.CB_AGREE.Size = New System.Drawing.Size(191, 20)
        Me.CB_AGREE.TabIndex = 67
        Me.CB_AGREE.Text = "Agree the terms of contract"
        '
        'DTP_START_DATE
        '
        Me.DTP_START_DATE.BackColor = System.Drawing.Color.Transparent
        Me.DTP_START_DATE.BaseColor = System.Drawing.Color.White
        Me.DTP_START_DATE.BorderColor = System.Drawing.Color.MistyRose
        Me.DTP_START_DATE.BorderSize = 1
        Me.DTP_START_DATE.CustomFormat = Nothing
        Me.DTP_START_DATE.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTP_START_DATE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTP_START_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_START_DATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DTP_START_DATE.Location = New System.Drawing.Point(108, 267)
        Me.DTP_START_DATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_START_DATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_START_DATE.Name = "DTP_START_DATE"
        Me.DTP_START_DATE.OnHoverBaseColor = System.Drawing.Color.White
        Me.DTP_START_DATE.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTP_START_DATE.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTP_START_DATE.OnPressedColor = System.Drawing.Color.Black
        Me.DTP_START_DATE.Radius = 5
        Me.DTP_START_DATE.Size = New System.Drawing.Size(293, 30)
        Me.DTP_START_DATE.TabIndex = 66
        Me.DTP_START_DATE.Text = "Tuesday, 7 April 2020"
        Me.DTP_START_DATE.Value = New Date(2020, 4, 7, 10, 51, 7, 340)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(105, 245)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(119, 16)
        Me.GunaLabel2.TabIndex = 65
        Me.GunaLabel2.Text = "Contract Start Date"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(103, 39)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(196, 24)
        Me.GunaLabel1.TabIndex = 64
        Me.GunaLabel1.Text = "Contract Information"
        '
        'BTN_BACK
        '
        Me.BTN_BACK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_BACK.Animated = True
        Me.BTN_BACK.AnimationHoverSpeed = 0.07!
        Me.BTN_BACK.AnimationSpeed = 0.03!
        Me.BTN_BACK.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BACK.BaseColor = System.Drawing.Color.White
        Me.BTN_BACK.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_BACK.BorderSize = 1
        Me.BTN_BACK.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_BACK.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_BACK.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_BACK.CheckedImage = CType(resources.GetObject("BTN_BACK.CheckedImage"), System.Drawing.Image)
        Me.BTN_BACK.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_BACK.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BACK.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BTN_BACK.Image = Nothing
        Me.BTN_BACK.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_BACK.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_BACK.Location = New System.Drawing.Point(108, 494)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_BACK.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.OnHoverForeColor = System.Drawing.Color.DimGray
        Me.BTN_BACK.OnHoverImage = Nothing
        Me.BTN_BACK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_BACK.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BACK.Radius = 5
        Me.BTN_BACK.Size = New System.Drawing.Size(103, 31)
        Me.BTN_BACK.TabIndex = 63
        Me.BTN_BACK.Text = "Back"
        Me.BTN_BACK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_CONTINUE
        '
        Me.BTN_CONTINUE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_CONTINUE.Animated = True
        Me.BTN_CONTINUE.AnimationHoverSpeed = 0.07!
        Me.BTN_CONTINUE.AnimationSpeed = 0.03!
        Me.BTN_CONTINUE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CONTINUE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_CONTINUE.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CONTINUE.BorderSize = 1
        Me.BTN_CONTINUE.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_CONTINUE.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CONTINUE.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_CONTINUE.CheckedImage = CType(resources.GetObject("BTN_CONTINUE.CheckedImage"), System.Drawing.Image)
        Me.BTN_CONTINUE.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_CONTINUE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_CONTINUE.Enabled = False
        Me.BTN_CONTINUE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CONTINUE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONTINUE.ForeColor = System.Drawing.Color.White
        Me.BTN_CONTINUE.Image = Nothing
        Me.BTN_CONTINUE.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_CONTINUE.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CONTINUE.Location = New System.Drawing.Point(236, 494)
        Me.BTN_CONTINUE.Name = "BTN_CONTINUE"
        Me.BTN_CONTINUE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_CONTINUE.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CONTINUE.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_CONTINUE.OnHoverImage = Nothing
        Me.BTN_CONTINUE.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CONTINUE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CONTINUE.Radius = 5
        Me.BTN_CONTINUE.Size = New System.Drawing.Size(103, 31)
        Me.BTN_CONTINUE.TabIndex = 62
        Me.BTN_CONTINUE.Text = "Continue"
        Me.BTN_CONTINUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(105, 315)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(111, 16)
        Me.GunaLabel7.TabIndex = 56
        Me.GunaLabel7.Text = "Terms of contract"
        '
        'CBO_SEMESTER
        '
        Me.CBO_SEMESTER.BackColor = System.Drawing.Color.Transparent
        Me.CBO_SEMESTER.BaseColor = System.Drawing.Color.White
        Me.CBO_SEMESTER.BorderColor = System.Drawing.Color.MistyRose
        Me.CBO_SEMESTER.BorderSize = 1
        Me.CBO_SEMESTER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_SEMESTER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_SEMESTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_SEMESTER.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_SEMESTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_SEMESTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CBO_SEMESTER.FormattingEnabled = True
        Me.CBO_SEMESTER.ItemHeight = 24
        Me.CBO_SEMESTER.Location = New System.Drawing.Point(316, 201)
        Me.CBO_SEMESTER.Name = "CBO_SEMESTER"
        Me.CBO_SEMESTER.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_SEMESTER.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_SEMESTER.Radius = 5
        Me.CBO_SEMESTER.Size = New System.Drawing.Size(219, 30)
        Me.CBO_SEMESTER.TabIndex = 53
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(318, 177)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(66, 16)
        Me.GunaLabel5.TabIndex = 52
        Me.GunaLabel5.Text = "Semester"
        '
        'CBO_SCHOOL_YEAR
        '
        Me.CBO_SCHOOL_YEAR.BackColor = System.Drawing.Color.Transparent
        Me.CBO_SCHOOL_YEAR.BaseColor = System.Drawing.Color.White
        Me.CBO_SCHOOL_YEAR.BorderColor = System.Drawing.Color.MistyRose
        Me.CBO_SCHOOL_YEAR.BorderSize = 1
        Me.CBO_SCHOOL_YEAR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_SCHOOL_YEAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_SCHOOL_YEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_SCHOOL_YEAR.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_SCHOOL_YEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_SCHOOL_YEAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CBO_SCHOOL_YEAR.FormattingEnabled = True
        Me.CBO_SCHOOL_YEAR.ItemHeight = 24
        Me.CBO_SCHOOL_YEAR.Location = New System.Drawing.Point(108, 201)
        Me.CBO_SCHOOL_YEAR.Name = "CBO_SCHOOL_YEAR"
        Me.CBO_SCHOOL_YEAR.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_SCHOOL_YEAR.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_SCHOOL_YEAR.Radius = 5
        Me.CBO_SCHOOL_YEAR.Size = New System.Drawing.Size(202, 30)
        Me.CBO_SCHOOL_YEAR.TabIndex = 49
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(105, 177)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(82, 16)
        Me.GunaLabel4.TabIndex = 50
        Me.GunaLabel4.Text = "School Year"
        '
        'CBO_BENEFICIARY_NAME_LIST
        '
        Me.CBO_BENEFICIARY_NAME_LIST.BackColor = System.Drawing.Color.Transparent
        Me.CBO_BENEFICIARY_NAME_LIST.BaseColor = System.Drawing.Color.White
        Me.CBO_BENEFICIARY_NAME_LIST.BorderColor = System.Drawing.Color.MistyRose
        Me.CBO_BENEFICIARY_NAME_LIST.BorderSize = 1
        Me.CBO_BENEFICIARY_NAME_LIST.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_BENEFICIARY_NAME_LIST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_BENEFICIARY_NAME_LIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_BENEFICIARY_NAME_LIST.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_BENEFICIARY_NAME_LIST.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_BENEFICIARY_NAME_LIST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CBO_BENEFICIARY_NAME_LIST.FormattingEnabled = True
        Me.CBO_BENEFICIARY_NAME_LIST.ItemHeight = 24
        Me.CBO_BENEFICIARY_NAME_LIST.Location = New System.Drawing.Point(107, 132)
        Me.CBO_BENEFICIARY_NAME_LIST.Name = "CBO_BENEFICIARY_NAME_LIST"
        Me.CBO_BENEFICIARY_NAME_LIST.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_BENEFICIARY_NAME_LIST.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_BENEFICIARY_NAME_LIST.Radius = 5
        Me.CBO_BENEFICIARY_NAME_LIST.Size = New System.Drawing.Size(428, 30)
        Me.CBO_BENEFICIARY_NAME_LIST.TabIndex = 6
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(105, 108)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(123, 16)
        Me.GunaLabel6.TabIndex = 46
        Me.GunaLabel6.Text = "List of Beneficiaries"
        '
        'PNL_CONTRACT_ID
        '
        Me.PNL_CONTRACT_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PNL_CONTRACT_ID.BackColor = System.Drawing.Color.Transparent
        Me.PNL_CONTRACT_ID.BaseColor = System.Drawing.Color.White
        Me.PNL_CONTRACT_ID.Controls.Add(Me.PNL_LOGIN_AGREE_CONTRACT)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.GunaVSeparator1)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.Panel2)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.Label1)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.Label2)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.Panel1)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.BTN_DONE)
        Me.PNL_CONTRACT_ID.Location = New System.Drawing.Point(167, 134)
        Me.PNL_CONTRACT_ID.Name = "PNL_CONTRACT_ID"
        Me.PNL_CONTRACT_ID.Radius = 4
        Me.PNL_CONTRACT_ID.ShadowColor = System.Drawing.Color.Blue
        Me.PNL_CONTRACT_ID.ShadowDepth = 0
        Me.PNL_CONTRACT_ID.ShadowShift = 0
        Me.PNL_CONTRACT_ID.Size = New System.Drawing.Size(733, 405)
        Me.PNL_CONTRACT_ID.TabIndex = 65
        '
        'PNL_LOGIN_AGREE_CONTRACT
        '
        Me.PNL_LOGIN_AGREE_CONTRACT.Controls.Add(Me.GunaLabel3)
        Me.PNL_LOGIN_AGREE_CONTRACT.Controls.Add(Me.BTN_CANCEL_AGREEMENT)
        Me.PNL_LOGIN_AGREE_CONTRACT.Controls.Add(Me.BTN_CONFIRM_AGREEMENT)
        Me.PNL_LOGIN_AGREE_CONTRACT.Controls.Add(Me.TXT_BENEFICIARY_PASSWORD)
        Me.PNL_LOGIN_AGREE_CONTRACT.Location = New System.Drawing.Point(23, 18)
        Me.PNL_LOGIN_AGREE_CONTRACT.Name = "PNL_LOGIN_AGREE_CONTRACT"
        Me.PNL_LOGIN_AGREE_CONTRACT.Size = New System.Drawing.Size(687, 363)
        Me.PNL_LOGIN_AGREE_CONTRACT.TabIndex = 71
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(189, 67)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(243, 16)
        Me.GunaLabel3.TabIndex = 191
        Me.GunaLabel3.Text = "Enter beneficiary's password to confirm."
        '
        'BTN_CANCEL_AGREEMENT
        '
        Me.BTN_CANCEL_AGREEMENT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_CANCEL_AGREEMENT.Animated = True
        Me.BTN_CANCEL_AGREEMENT.AnimationHoverSpeed = 0.07!
        Me.BTN_CANCEL_AGREEMENT.AnimationSpeed = 0.03!
        Me.BTN_CANCEL_AGREEMENT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CANCEL_AGREEMENT.BaseColor = System.Drawing.Color.White
        Me.BTN_CANCEL_AGREEMENT.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CANCEL_AGREEMENT.BorderSize = 1
        Me.BTN_CANCEL_AGREEMENT.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_CANCEL_AGREEMENT.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CANCEL_AGREEMENT.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_CANCEL_AGREEMENT.CheckedImage = CType(resources.GetObject("BTN_CANCEL_AGREEMENT.CheckedImage"), System.Drawing.Image)
        Me.BTN_CANCEL_AGREEMENT.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_CANCEL_AGREEMENT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_CANCEL_AGREEMENT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CANCEL_AGREEMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCEL_AGREEMENT.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_CANCEL_AGREEMENT.Image = Nothing
        Me.BTN_CANCEL_AGREEMENT.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_CANCEL_AGREEMENT.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CANCEL_AGREEMENT.Location = New System.Drawing.Point(192, 229)
        Me.BTN_CANCEL_AGREEMENT.Name = "BTN_CANCEL_AGREEMENT"
        Me.BTN_CANCEL_AGREEMENT.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_CANCEL_AGREEMENT.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.BTN_CANCEL_AGREEMENT.OnHoverForeColor = System.Drawing.Color.DimGray
        Me.BTN_CANCEL_AGREEMENT.OnHoverImage = Nothing
        Me.BTN_CANCEL_AGREEMENT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CANCEL_AGREEMENT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CANCEL_AGREEMENT.Radius = 5
        Me.BTN_CANCEL_AGREEMENT.Size = New System.Drawing.Size(305, 37)
        Me.BTN_CANCEL_AGREEMENT.TabIndex = 190
        Me.BTN_CANCEL_AGREEMENT.Text = "Back"
        Me.BTN_CANCEL_AGREEMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_CONFIRM_AGREEMENT
        '
        Me.BTN_CONFIRM_AGREEMENT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_CONFIRM_AGREEMENT.Animated = True
        Me.BTN_CONFIRM_AGREEMENT.AnimationHoverSpeed = 0.07!
        Me.BTN_CONFIRM_AGREEMENT.AnimationSpeed = 0.03!
        Me.BTN_CONFIRM_AGREEMENT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CONFIRM_AGREEMENT.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_CONFIRM_AGREEMENT.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CONFIRM_AGREEMENT.BorderSize = 1
        Me.BTN_CONFIRM_AGREEMENT.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_CONFIRM_AGREEMENT.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CONFIRM_AGREEMENT.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_CONFIRM_AGREEMENT.CheckedImage = CType(resources.GetObject("BTN_CONFIRM_AGREEMENT.CheckedImage"), System.Drawing.Image)
        Me.BTN_CONFIRM_AGREEMENT.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_CONFIRM_AGREEMENT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_CONFIRM_AGREEMENT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CONFIRM_AGREEMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONFIRM_AGREEMENT.ForeColor = System.Drawing.Color.White
        Me.BTN_CONFIRM_AGREEMENT.Image = Nothing
        Me.BTN_CONFIRM_AGREEMENT.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_CONFIRM_AGREEMENT.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CONFIRM_AGREEMENT.Location = New System.Drawing.Point(192, 177)
        Me.BTN_CONFIRM_AGREEMENT.Name = "BTN_CONFIRM_AGREEMENT"
        Me.BTN_CONFIRM_AGREEMENT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_CONFIRM_AGREEMENT.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CONFIRM_AGREEMENT.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_CONFIRM_AGREEMENT.OnHoverImage = Nothing
        Me.BTN_CONFIRM_AGREEMENT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CONFIRM_AGREEMENT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CONFIRM_AGREEMENT.Radius = 5
        Me.BTN_CONFIRM_AGREEMENT.Size = New System.Drawing.Size(305, 37)
        Me.BTN_CONFIRM_AGREEMENT.TabIndex = 189
        Me.BTN_CONFIRM_AGREEMENT.Text = "Proceed"
        Me.BTN_CONFIRM_AGREEMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_BENEFICIARY_PASSWORD
        '
        Me.TXT_BENEFICIARY_PASSWORD.Animated = True
        Me.TXT_BENEFICIARY_PASSWORD.BackColor = System.Drawing.Color.White
        Me.TXT_BENEFICIARY_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BENEFICIARY_PASSWORD.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.TXT_BENEFICIARY_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BENEFICIARY_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_BENEFICIARY_PASSWORD.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_BENEFICIARY_PASSWORD.LineSize = 2
        Me.TXT_BENEFICIARY_PASSWORD.Location = New System.Drawing.Point(192, 122)
        Me.TXT_BENEFICIARY_PASSWORD.Name = "TXT_BENEFICIARY_PASSWORD"
        Me.TXT_BENEFICIARY_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXT_BENEFICIARY_PASSWORD.Size = New System.Drawing.Size(305, 33)
        Me.TXT_BENEFICIARY_PASSWORD.TabIndex = 188
        Me.TXT_BENEFICIARY_PASSWORD.UseSystemPasswordChar = True
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaVSeparator1.Location = New System.Drawing.Point(345, 29)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 342)
        Me.GunaVSeparator1.TabIndex = 70
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GunaCirclePictureBox3)
        Me.Panel2.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Panel2.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(54, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 236)
        Me.Panel2.TabIndex = 69
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox3.Image = CType(resources.GetObject("GunaCirclePictureBox3.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(56, 112)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(18, 19)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox3.TabIndex = 71
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(56, 84)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(18, 19)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox2.TabIndex = 70
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(56, 56)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(18, 19)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox1.TabIndex = 69
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(88, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "School Year"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(88, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Beneficiary ID (EFAS)"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(88, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Term"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(234, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(421, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This will be the beneficiary's Contract ID."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TXT_GET_CONTRACT_ID_TO_SHOW)
        Me.Panel1.Location = New System.Drawing.Point(372, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 46)
        Me.Panel1.TabIndex = 64
        '
        'TXT_GET_CONTRACT_ID_TO_SHOW
        '
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.BaseColor = System.Drawing.Color.White
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.BorderColor = System.Drawing.Color.Silver
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.BorderSize = 0
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Enabled = False
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Location = New System.Drawing.Point(0, 0)
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Name = "TXT_GET_CONTRACT_ID_TO_SHOW"
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Size = New System.Drawing.Size(338, 46)
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.TabIndex = 0
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.Text = "2019-2020/1st/B-30"
        Me.TXT_GET_CONTRACT_ID_TO_SHOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_DONE
        '
        Me.BTN_DONE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_DONE.Animated = True
        Me.BTN_DONE.AnimationHoverSpeed = 0.07!
        Me.BTN_DONE.AnimationSpeed = 0.03!
        Me.BTN_DONE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_DONE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BTN_DONE.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_DONE.BorderSize = 1
        Me.BTN_DONE.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_DONE.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_DONE.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_DONE.CheckedImage = CType(resources.GetObject("BTN_DONE.CheckedImage"), System.Drawing.Image)
        Me.BTN_DONE.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_DONE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_DONE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_DONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DONE.ForeColor = System.Drawing.Color.White
        Me.BTN_DONE.Image = Nothing
        Me.BTN_DONE.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_DONE.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_DONE.Location = New System.Drawing.Point(486, 214)
        Me.BTN_DONE.Name = "BTN_DONE"
        Me.BTN_DONE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BTN_DONE.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_DONE.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_DONE.OnHoverImage = Nothing
        Me.BTN_DONE.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_DONE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_DONE.Radius = 5
        Me.BTN_DONE.Size = New System.Drawing.Size(114, 37)
        Me.BTN_DONE.TabIndex = 63
        Me.BTN_DONE.Text = "Done"
        Me.BTN_DONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAddContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 682)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddContract"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddContract"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.pnl_contract_info.ResumeLayout(False)
        Me.pnl_contract_info.PerformLayout()
        Me.PNL_CONTRACT_ID.ResumeLayout(False)
        Me.PNL_CONTRACT_ID.PerformLayout()
        Me.PNL_LOGIN_AGREE_CONTRACT.ResumeLayout(False)
        Me.PNL_LOGIN_AGREE_CONTRACT.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents pnl_contract_info As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents CBO_BENEFICIARY_NAME_LIST As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CBO_SEMESTER As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CBO_SCHOOL_YEAR As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTN_CONTINUE As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_BACK As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PNL_CONTRACT_ID As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DTP_START_DATE As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PNL_LOGIN_AGREE_CONTRACT As Panel
    Friend WithEvents TXT_BENEFICIARY_PASSWORD As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BTN_CONFIRM_AGREEMENT As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents CB_AGREE As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_GET_CONTRACT_ID_TO_SHOW As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BTN_DONE As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_CANCEL_AGREEMENT As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TXT_TERMS_OF_CONTRACT As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
