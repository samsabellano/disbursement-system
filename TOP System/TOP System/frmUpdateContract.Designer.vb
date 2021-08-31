<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateContract
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateContract))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_contract_info = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.DTP_END_DATE = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PNL_GET_START_DATE = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.LBL_GET_START_DATE = New System.Windows.Forms.Label()
        Me.CBO_GET_CONTRACT_ID = New Guna.UI.WinForms.GunaComboBox()
        Me.CBO_SEARCH_BENEFICIARY = New Guna.UI.WinForms.GunaComboBox()
        Me.TXT_REMARKS = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_cancel_contract = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_UPDATE_CONTRACT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1.SuspendLayout()
        Me.pnl_contract_info.SuspendLayout()
        Me.PNL_GET_START_DATE.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnl_contract_info)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 589)
        Me.Panel1.TabIndex = 0
        '
        'pnl_contract_info
        '
        Me.pnl_contract_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_contract_info.BackColor = System.Drawing.Color.Transparent
        Me.pnl_contract_info.BaseColor = System.Drawing.Color.White
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel6)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel8)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel9)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel5)
        Me.pnl_contract_info.Controls.Add(Me.GunaSeparator1)
        Me.pnl_contract_info.Controls.Add(Me.DTP_END_DATE)
        Me.pnl_contract_info.Controls.Add(Me.GunaLabel1)
        Me.pnl_contract_info.Controls.Add(Me.PNL_GET_START_DATE)
        Me.pnl_contract_info.Controls.Add(Me.CBO_GET_CONTRACT_ID)
        Me.pnl_contract_info.Controls.Add(Me.CBO_SEARCH_BENEFICIARY)
        Me.pnl_contract_info.Controls.Add(Me.TXT_REMARKS)
        Me.pnl_contract_info.Controls.Add(Me.btn_cancel_contract)
        Me.pnl_contract_info.Controls.Add(Me.BTN_UPDATE_CONTRACT)
        Me.pnl_contract_info.Location = New System.Drawing.Point(154, 31)
        Me.pnl_contract_info.Name = "pnl_contract_info"
        Me.pnl_contract_info.Radius = 3
        Me.pnl_contract_info.ShadowColor = System.Drawing.Color.Gray
        Me.pnl_contract_info.ShadowDepth = 50
        Me.pnl_contract_info.ShadowShift = 6
        Me.pnl_contract_info.Size = New System.Drawing.Size(729, 546)
        Me.pnl_contract_info.TabIndex = 52
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(108, 102)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(123, 16)
        Me.GunaLabel6.TabIndex = 98
        Me.GunaLabel6.Text = "List of Beneficiaries"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(107, 311)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(63, 16)
        Me.GunaLabel8.TabIndex = 97
        Me.GunaLabel8.Text = "Remarks"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(107, 241)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(116, 16)
        Me.GunaLabel9.TabIndex = 96
        Me.GunaLabel9.Text = "Contract End Date"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(107, 172)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(73, 16)
        Me.GunaLabel5.TabIndex = 95
        Me.GunaLabel5.Text = "Contract ID"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(108, 67)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(518, 10)
        Me.GunaSeparator1.TabIndex = 93
        Me.GunaSeparator1.Thickness = 2
        '
        'DTP_END_DATE
        '
        Me.DTP_END_DATE.BackColor = System.Drawing.Color.Transparent
        Me.DTP_END_DATE.BaseColor = System.Drawing.Color.White
        Me.DTP_END_DATE.BorderColor = System.Drawing.Color.MistyRose
        Me.DTP_END_DATE.BorderSize = 1
        Me.DTP_END_DATE.CustomFormat = Nothing
        Me.DTP_END_DATE.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTP_END_DATE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTP_END_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_END_DATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DTP_END_DATE.Location = New System.Drawing.Point(108, 265)
        Me.DTP_END_DATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_END_DATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_END_DATE.Name = "DTP_END_DATE"
        Me.DTP_END_DATE.OnHoverBaseColor = System.Drawing.Color.White
        Me.DTP_END_DATE.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTP_END_DATE.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTP_END_DATE.OnPressedColor = System.Drawing.Color.Black
        Me.DTP_END_DATE.Radius = 5
        Me.DTP_END_DATE.Size = New System.Drawing.Size(293, 30)
        Me.DTP_END_DATE.TabIndex = 92
        Me.DTP_END_DATE.Text = "Tuesday, 7 April 2020"
        Me.DTP_END_DATE.Value = New Date(2020, 4, 7, 10, 51, 7, 340)
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(106, 34)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(159, 24)
        Me.GunaLabel1.TabIndex = 47
        Me.GunaLabel1.Text = "Update Contract"
        '
        'PNL_GET_START_DATE
        '
        Me.PNL_GET_START_DATE.BackColor = System.Drawing.Color.Transparent
        Me.PNL_GET_START_DATE.BaseColor = System.Drawing.Color.White
        Me.PNL_GET_START_DATE.Controls.Add(Me.GunaLabel3)
        Me.PNL_GET_START_DATE.Controls.Add(Me.PictureBox9)
        Me.PNL_GET_START_DATE.Controls.Add(Me.LBL_GET_START_DATE)
        Me.PNL_GET_START_DATE.Location = New System.Drawing.Point(394, 166)
        Me.PNL_GET_START_DATE.Name = "PNL_GET_START_DATE"
        Me.PNL_GET_START_DATE.Radius = 4
        Me.PNL_GET_START_DATE.ShadowColor = System.Drawing.Color.Black
        Me.PNL_GET_START_DATE.ShadowDepth = 0
        Me.PNL_GET_START_DATE.ShadowShift = 0
        Me.PNL_GET_START_DATE.Size = New System.Drawing.Size(265, 79)
        Me.PNL_GET_START_DATE.TabIndex = 90
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(16, 6)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(59, 15)
        Me.GunaLabel3.TabIndex = 97
        Me.GunaLabel3.Text = "Start date"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(15, 36)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 86
        Me.PictureBox9.TabStop = False
        '
        'LBL_GET_START_DATE
        '
        Me.LBL_GET_START_DATE.AutoSize = True
        Me.LBL_GET_START_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GET_START_DATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LBL_GET_START_DATE.Location = New System.Drawing.Point(38, 37)
        Me.LBL_GET_START_DATE.Name = "LBL_GET_START_DATE"
        Me.LBL_GET_START_DATE.Size = New System.Drawing.Size(37, 16)
        Me.LBL_GET_START_DATE.TabIndex = 85
        Me.LBL_GET_START_DATE.Text = "Date"
        '
        'CBO_GET_CONTRACT_ID
        '
        Me.CBO_GET_CONTRACT_ID.BackColor = System.Drawing.Color.Transparent
        Me.CBO_GET_CONTRACT_ID.BaseColor = System.Drawing.Color.White
        Me.CBO_GET_CONTRACT_ID.BorderColor = System.Drawing.Color.MistyRose
        Me.CBO_GET_CONTRACT_ID.BorderSize = 1
        Me.CBO_GET_CONTRACT_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_GET_CONTRACT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_GET_CONTRACT_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_GET_CONTRACT_ID.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_GET_CONTRACT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_GET_CONTRACT_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CBO_GET_CONTRACT_ID.FormattingEnabled = True
        Me.CBO_GET_CONTRACT_ID.ItemHeight = 24
        Me.CBO_GET_CONTRACT_ID.Location = New System.Drawing.Point(108, 196)
        Me.CBO_GET_CONTRACT_ID.Name = "CBO_GET_CONTRACT_ID"
        Me.CBO_GET_CONTRACT_ID.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_GET_CONTRACT_ID.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_GET_CONTRACT_ID.Radius = 5
        Me.CBO_GET_CONTRACT_ID.Size = New System.Drawing.Size(261, 30)
        Me.CBO_GET_CONTRACT_ID.TabIndex = 89
        '
        'CBO_SEARCH_BENEFICIARY
        '
        Me.CBO_SEARCH_BENEFICIARY.BackColor = System.Drawing.Color.Transparent
        Me.CBO_SEARCH_BENEFICIARY.BaseColor = System.Drawing.Color.White
        Me.CBO_SEARCH_BENEFICIARY.BorderColor = System.Drawing.Color.MistyRose
        Me.CBO_SEARCH_BENEFICIARY.BorderSize = 1
        Me.CBO_SEARCH_BENEFICIARY.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_SEARCH_BENEFICIARY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_SEARCH_BENEFICIARY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_SEARCH_BENEFICIARY.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_SEARCH_BENEFICIARY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_SEARCH_BENEFICIARY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CBO_SEARCH_BENEFICIARY.FormattingEnabled = True
        Me.CBO_SEARCH_BENEFICIARY.ItemHeight = 24
        Me.CBO_SEARCH_BENEFICIARY.Location = New System.Drawing.Point(108, 126)
        Me.CBO_SEARCH_BENEFICIARY.Name = "CBO_SEARCH_BENEFICIARY"
        Me.CBO_SEARCH_BENEFICIARY.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_SEARCH_BENEFICIARY.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_SEARCH_BENEFICIARY.Radius = 5
        Me.CBO_SEARCH_BENEFICIARY.Size = New System.Drawing.Size(407, 30)
        Me.CBO_SEARCH_BENEFICIARY.TabIndex = 87
        '
        'TXT_REMARKS
        '
        Me.TXT_REMARKS.BackColor = System.Drawing.Color.Transparent
        Me.TXT_REMARKS.BaseColor = System.Drawing.Color.White
        Me.TXT_REMARKS.BorderColor = System.Drawing.Color.MistyRose
        Me.TXT_REMARKS.BorderSize = 1
        Me.TXT_REMARKS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_REMARKS.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_REMARKS.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_REMARKS.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_REMARKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_REMARKS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.TXT_REMARKS.Location = New System.Drawing.Point(108, 335)
        Me.TXT_REMARKS.MultiLine = True
        Me.TXT_REMARKS.Name = "TXT_REMARKS"
        Me.TXT_REMARKS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_REMARKS.Radius = 5
        Me.TXT_REMARKS.Size = New System.Drawing.Size(518, 90)
        Me.TXT_REMARKS.TabIndex = 64
        '
        'btn_cancel_contract
        '
        Me.btn_cancel_contract.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_contract.Animated = True
        Me.btn_cancel_contract.AnimationHoverSpeed = 0.07!
        Me.btn_cancel_contract.AnimationSpeed = 0.03!
        Me.btn_cancel_contract.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel_contract.BaseColor = System.Drawing.Color.White
        Me.btn_cancel_contract.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_cancel_contract.BorderSize = 1
        Me.btn_cancel_contract.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_cancel_contract.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_cancel_contract.CheckedForeColor = System.Drawing.Color.White
        Me.btn_cancel_contract.CheckedImage = CType(resources.GetObject("btn_cancel_contract.CheckedImage"), System.Drawing.Image)
        Me.btn_cancel_contract.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_cancel_contract.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cancel_contract.FocusedColor = System.Drawing.Color.Empty
        Me.btn_cancel_contract.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_contract.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cancel_contract.Image = Nothing
        Me.btn_cancel_contract.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_cancel_contract.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cancel_contract.Location = New System.Drawing.Point(111, 454)
        Me.btn_cancel_contract.Name = "btn_cancel_contract"
        Me.btn_cancel_contract.OnHoverBaseColor = System.Drawing.Color.White
        Me.btn_cancel_contract.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.btn_cancel_contract.OnHoverForeColor = System.Drawing.Color.DimGray
        Me.btn_cancel_contract.OnHoverImage = Nothing
        Me.btn_cancel_contract.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cancel_contract.OnPressedColor = System.Drawing.Color.Black
        Me.btn_cancel_contract.Radius = 5
        Me.btn_cancel_contract.Size = New System.Drawing.Size(103, 31)
        Me.btn_cancel_contract.TabIndex = 63
        Me.btn_cancel_contract.Text = "Cancel"
        Me.btn_cancel_contract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_UPDATE_CONTRACT
        '
        Me.BTN_UPDATE_CONTRACT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_UPDATE_CONTRACT.Animated = True
        Me.BTN_UPDATE_CONTRACT.AnimationHoverSpeed = 0.07!
        Me.BTN_UPDATE_CONTRACT.AnimationSpeed = 0.03!
        Me.BTN_UPDATE_CONTRACT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_UPDATE_CONTRACT.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_UPDATE_CONTRACT.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_UPDATE_CONTRACT.BorderSize = 1
        Me.BTN_UPDATE_CONTRACT.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_UPDATE_CONTRACT.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_UPDATE_CONTRACT.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_UPDATE_CONTRACT.CheckedImage = CType(resources.GetObject("BTN_UPDATE_CONTRACT.CheckedImage"), System.Drawing.Image)
        Me.BTN_UPDATE_CONTRACT.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_UPDATE_CONTRACT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_UPDATE_CONTRACT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_UPDATE_CONTRACT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE_CONTRACT.ForeColor = System.Drawing.Color.White
        Me.BTN_UPDATE_CONTRACT.Image = Nothing
        Me.BTN_UPDATE_CONTRACT.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_UPDATE_CONTRACT.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_UPDATE_CONTRACT.Location = New System.Drawing.Point(242, 454)
        Me.BTN_UPDATE_CONTRACT.Name = "BTN_UPDATE_CONTRACT"
        Me.BTN_UPDATE_CONTRACT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_UPDATE_CONTRACT.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_UPDATE_CONTRACT.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_UPDATE_CONTRACT.OnHoverImage = Nothing
        Me.BTN_UPDATE_CONTRACT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_UPDATE_CONTRACT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_CONTRACT.Radius = 5
        Me.BTN_UPDATE_CONTRACT.Size = New System.Drawing.Size(103, 31)
        Me.BTN_UPDATE_CONTRACT.TabIndex = 62
        Me.BTN_UPDATE_CONTRACT.Text = "Update"
        Me.BTN_UPDATE_CONTRACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmUpdateContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 589)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateContract"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReturn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnl_contract_info.ResumeLayout(False)
        Me.pnl_contract_info.PerformLayout()
        Me.PNL_GET_START_DATE.ResumeLayout(False)
        Me.PNL_GET_START_DATE.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pnl_contract_info As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_cancel_contract As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_UPDATE_CONTRACT As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TXT_REMARKS As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LBL_GET_START_DATE As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents CBO_SEARCH_BENEFICIARY As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents CBO_GET_CONTRACT_ID As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents PNL_GET_START_DATE As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents DTP_END_DATE As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
End Class
