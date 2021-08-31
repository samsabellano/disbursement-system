<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAdminAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditAdminAccount))
        Me.PNL_ADMIN_HOLDER = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.CB_UPDATE_ADMIN_ACCNT = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_REG_ADMIN = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnl_edit_cnumber = New System.Windows.Forms.Panel()
        Me.pb_edit_cnumber = New System.Windows.Forms.PictureBox()
        Me.pnl_edit_address = New System.Windows.Forms.Panel()
        Me.pb_edit_address = New System.Windows.Forms.PictureBox()
        Me.pnl_edit_lname = New System.Windows.Forms.Panel()
        Me.pb_edit_lname = New System.Windows.Forms.PictureBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_ADMIN_EMAIL = New Guna.UI.WinForms.GunaLineTextBox()
        Me.TXT_ADMIN_FNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.TXT_ADMIN_CNUMBER = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_ADMIN_LNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_ADMIN_ADDRESS = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PNL_ADMIN_HOLDER.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_edit_cnumber.SuspendLayout()
        CType(Me.pb_edit_cnumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_edit_address.SuspendLayout()
        CType(Me.pb_edit_address, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_edit_lname.SuspendLayout()
        CType(Me.pb_edit_lname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_ADMIN_HOLDER
        '
        Me.PNL_ADMIN_HOLDER.Controls.Add(Me.GunaShadowPanel1)
        Me.PNL_ADMIN_HOLDER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_ADMIN_HOLDER.Location = New System.Drawing.Point(0, 0)
        Me.PNL_ADMIN_HOLDER.Name = "PNL_ADMIN_HOLDER"
        Me.PNL_ADMIN_HOLDER.Size = New System.Drawing.Size(988, 599)
        Me.PNL_ADMIN_HOLDER.TabIndex = 84
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel1.AutoScroll = True
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.CB_UPDATE_ADMIN_ACCNT)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaSeparator1)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel1)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(116, 90)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 1
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 10
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(762, 452)
        Me.GunaShadowPanel1.TabIndex = 137
        '
        'CB_UPDATE_ADMIN_ACCNT
        '
        Me.CB_UPDATE_ADMIN_ACCNT.BaseColor = System.Drawing.Color.White
        Me.CB_UPDATE_ADMIN_ACCNT.CheckedOffColor = System.Drawing.Color.Turquoise
        Me.CB_UPDATE_ADMIN_ACCNT.CheckedOnColor = System.Drawing.Color.Tomato
        Me.CB_UPDATE_ADMIN_ACCNT.FillColor = System.Drawing.Color.White
        Me.CB_UPDATE_ADMIN_ACCNT.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_UPDATE_ADMIN_ACCNT.ForeColor = System.Drawing.Color.Teal
        Me.CB_UPDATE_ADMIN_ACCNT.Location = New System.Drawing.Point(576, 37)
        Me.CB_UPDATE_ADMIN_ACCNT.Name = "CB_UPDATE_ADMIN_ACCNT"
        Me.CB_UPDATE_ADMIN_ACCNT.Size = New System.Drawing.Size(109, 20)
        Me.CB_UPDATE_ADMIN_ACCNT.TabIndex = 122
        Me.CB_UPDATE_ADMIN_ACCNT.Text = "Check to edit"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(50, 34)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(182, 23)
        Me.GunaLabel1.TabIndex = 86
        Me.GunaLabel1.Text = "Acount Information"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(54, 60)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(651, 14)
        Me.GunaSeparator1.TabIndex = 85
        Me.GunaSeparator1.Thickness = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BTN_REG_ADMIN)
        Me.Panel1.Controls.Add(Me.pnl_edit_cnumber)
        Me.Panel1.Controls.Add(Me.pnl_edit_address)
        Me.Panel1.Controls.Add(Me.pnl_edit_lname)
        Me.Panel1.Controls.Add(Me.GunaLabel12)
        Me.Panel1.Controls.Add(Me.TXT_ADMIN_EMAIL)
        Me.Panel1.Controls.Add(Me.TXT_ADMIN_FNAME)
        Me.Panel1.Controls.Add(Me.TXT_ADMIN_CNUMBER)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.TXT_ADMIN_LNAME)
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.GunaLabel6)
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.TXT_ADMIN_ADDRESS)
        Me.Panel1.Location = New System.Drawing.Point(32, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 353)
        Me.Panel1.TabIndex = 84
        '
        'BTN_REG_ADMIN
        '
        Me.BTN_REG_ADMIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_REG_ADMIN.Animated = True
        Me.BTN_REG_ADMIN.AnimationHoverSpeed = 0.07!
        Me.BTN_REG_ADMIN.AnimationSpeed = 0.03!
        Me.BTN_REG_ADMIN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REG_ADMIN.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_REG_ADMIN.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_REG_ADMIN.BorderSize = 1
        Me.BTN_REG_ADMIN.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_REG_ADMIN.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_REG_ADMIN.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_REG_ADMIN.CheckedImage = CType(resources.GetObject("BTN_REG_ADMIN.CheckedImage"), System.Drawing.Image)
        Me.BTN_REG_ADMIN.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_REG_ADMIN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_REG_ADMIN.Enabled = False
        Me.BTN_REG_ADMIN.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_REG_ADMIN.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REG_ADMIN.ForeColor = System.Drawing.Color.White
        Me.BTN_REG_ADMIN.Image = Nothing
        Me.BTN_REG_ADMIN.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_REG_ADMIN.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_REG_ADMIN.Location = New System.Drawing.Point(22, 267)
        Me.BTN_REG_ADMIN.Name = "BTN_REG_ADMIN"
        Me.BTN_REG_ADMIN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_REG_ADMIN.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_REG_ADMIN.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_REG_ADMIN.OnHoverImage = Nothing
        Me.BTN_REG_ADMIN.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_REG_ADMIN.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_REG_ADMIN.Radius = 5
        Me.BTN_REG_ADMIN.Size = New System.Drawing.Size(111, 35)
        Me.BTN_REG_ADMIN.TabIndex = 126
        Me.BTN_REG_ADMIN.Text = "Save"
        Me.BTN_REG_ADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnl_edit_cnumber
        '
        Me.pnl_edit_cnumber.Controls.Add(Me.pb_edit_cnumber)
        Me.pnl_edit_cnumber.Location = New System.Drawing.Point(286, 136)
        Me.pnl_edit_cnumber.Name = "pnl_edit_cnumber"
        Me.pnl_edit_cnumber.Size = New System.Drawing.Size(42, 22)
        Me.pnl_edit_cnumber.TabIndex = 125
        '
        'pb_edit_cnumber
        '
        Me.pb_edit_cnumber.Dock = System.Windows.Forms.DockStyle.Right
        Me.pb_edit_cnumber.Image = CType(resources.GetObject("pb_edit_cnumber.Image"), System.Drawing.Image)
        Me.pb_edit_cnumber.Location = New System.Drawing.Point(24, 0)
        Me.pb_edit_cnumber.Name = "pb_edit_cnumber"
        Me.pb_edit_cnumber.Size = New System.Drawing.Size(18, 22)
        Me.pb_edit_cnumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_edit_cnumber.TabIndex = 123
        Me.pb_edit_cnumber.TabStop = False
        '
        'pnl_edit_address
        '
        Me.pnl_edit_address.Controls.Add(Me.pb_edit_address)
        Me.pnl_edit_address.Location = New System.Drawing.Point(631, 212)
        Me.pnl_edit_address.Name = "pnl_edit_address"
        Me.pnl_edit_address.Size = New System.Drawing.Size(42, 22)
        Me.pnl_edit_address.TabIndex = 124
        '
        'pb_edit_address
        '
        Me.pb_edit_address.Dock = System.Windows.Forms.DockStyle.Right
        Me.pb_edit_address.Image = CType(resources.GetObject("pb_edit_address.Image"), System.Drawing.Image)
        Me.pb_edit_address.Location = New System.Drawing.Point(24, 0)
        Me.pb_edit_address.Name = "pb_edit_address"
        Me.pb_edit_address.Size = New System.Drawing.Size(18, 22)
        Me.pb_edit_address.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_edit_address.TabIndex = 123
        Me.pb_edit_address.TabStop = False
        '
        'pnl_edit_lname
        '
        Me.pnl_edit_lname.Controls.Add(Me.pb_edit_lname)
        Me.pnl_edit_lname.Location = New System.Drawing.Point(631, 61)
        Me.pnl_edit_lname.Name = "pnl_edit_lname"
        Me.pnl_edit_lname.Size = New System.Drawing.Size(42, 22)
        Me.pnl_edit_lname.TabIndex = 123
        '
        'pb_edit_lname
        '
        Me.pb_edit_lname.Dock = System.Windows.Forms.DockStyle.Right
        Me.pb_edit_lname.Image = CType(resources.GetObject("pb_edit_lname.Image"), System.Drawing.Image)
        Me.pb_edit_lname.Location = New System.Drawing.Point(24, 0)
        Me.pb_edit_lname.Name = "pb_edit_lname"
        Me.pb_edit_lname.Size = New System.Drawing.Size(18, 22)
        Me.pb_edit_lname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_edit_lname.TabIndex = 123
        Me.pb_edit_lname.TabStop = False
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(363, 112)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(40, 16)
        Me.GunaLabel12.TabIndex = 120
        Me.GunaLabel12.Text = "Email"
        '
        'TXT_ADMIN_EMAIL
        '
        Me.TXT_ADMIN_EMAIL.Animated = True
        Me.TXT_ADMIN_EMAIL.BackColor = System.Drawing.Color.White
        Me.TXT_ADMIN_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ADMIN_EMAIL.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ADMIN_EMAIL.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ADMIN_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_ADMIN_EMAIL.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_ADMIN_EMAIL.LineSize = 2
        Me.TXT_ADMIN_EMAIL.Location = New System.Drawing.Point(366, 132)
        Me.TXT_ADMIN_EMAIL.Name = "TXT_ADMIN_EMAIL"
        Me.TXT_ADMIN_EMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ADMIN_EMAIL.ReadOnly = True
        Me.TXT_ADMIN_EMAIL.Size = New System.Drawing.Size(307, 33)
        Me.TXT_ADMIN_EMAIL.TabIndex = 117
        '
        'TXT_ADMIN_FNAME
        '
        Me.TXT_ADMIN_FNAME.Animated = True
        Me.TXT_ADMIN_FNAME.BackColor = System.Drawing.Color.White
        Me.TXT_ADMIN_FNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ADMIN_FNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ADMIN_FNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ADMIN_FNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_ADMIN_FNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_ADMIN_FNAME.LineSize = 2
        Me.TXT_ADMIN_FNAME.Location = New System.Drawing.Point(21, 57)
        Me.TXT_ADMIN_FNAME.Name = "TXT_ADMIN_FNAME"
        Me.TXT_ADMIN_FNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ADMIN_FNAME.ReadOnly = True
        Me.TXT_ADMIN_FNAME.Size = New System.Drawing.Size(307, 33)
        Me.TXT_ADMIN_FNAME.TabIndex = 112
        '
        'TXT_ADMIN_CNUMBER
        '
        Me.TXT_ADMIN_CNUMBER.Animated = True
        Me.TXT_ADMIN_CNUMBER.BackColor = System.Drawing.Color.White
        Me.TXT_ADMIN_CNUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ADMIN_CNUMBER.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ADMIN_CNUMBER.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ADMIN_CNUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_ADMIN_CNUMBER.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_ADMIN_CNUMBER.LineSize = 2
        Me.TXT_ADMIN_CNUMBER.Location = New System.Drawing.Point(22, 132)
        Me.TXT_ADMIN_CNUMBER.Name = "TXT_ADMIN_CNUMBER"
        Me.TXT_ADMIN_CNUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ADMIN_CNUMBER.ReadOnly = True
        Me.TXT_ADMIN_CNUMBER.Size = New System.Drawing.Size(306, 33)
        Me.TXT_ADMIN_CNUMBER.TabIndex = 115
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(362, 37)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel2.TabIndex = 113
        Me.GunaLabel2.Text = "Lastname"
        '
        'TXT_ADMIN_LNAME
        '
        Me.TXT_ADMIN_LNAME.Animated = True
        Me.TXT_ADMIN_LNAME.BackColor = System.Drawing.Color.White
        Me.TXT_ADMIN_LNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ADMIN_LNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ADMIN_LNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ADMIN_LNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_ADMIN_LNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_ADMIN_LNAME.LineSize = 2
        Me.TXT_ADMIN_LNAME.Location = New System.Drawing.Point(366, 57)
        Me.TXT_ADMIN_LNAME.Name = "TXT_ADMIN_LNAME"
        Me.TXT_ADMIN_LNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ADMIN_LNAME.ReadOnly = True
        Me.TXT_ADMIN_LNAME.Size = New System.Drawing.Size(307, 33)
        Me.TXT_ADMIN_LNAME.TabIndex = 114
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(18, 112)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel4.TabIndex = 119
        Me.GunaLabel4.Text = "Contact #"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(18, 37)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(65, 16)
        Me.GunaLabel6.TabIndex = 111
        Me.GunaLabel6.Text = "Firstname"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(19, 189)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(55, 16)
        Me.GunaLabel3.TabIndex = 116
        Me.GunaLabel3.Text = "Address"
        '
        'TXT_ADMIN_ADDRESS
        '
        Me.TXT_ADMIN_ADDRESS.Animated = True
        Me.TXT_ADMIN_ADDRESS.BackColor = System.Drawing.Color.White
        Me.TXT_ADMIN_ADDRESS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ADMIN_ADDRESS.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ADMIN_ADDRESS.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ADMIN_ADDRESS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_ADMIN_ADDRESS.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_ADMIN_ADDRESS.LineSize = 2
        Me.TXT_ADMIN_ADDRESS.Location = New System.Drawing.Point(22, 208)
        Me.TXT_ADMIN_ADDRESS.Name = "TXT_ADMIN_ADDRESS"
        Me.TXT_ADMIN_ADDRESS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ADMIN_ADDRESS.ReadOnly = True
        Me.TXT_ADMIN_ADDRESS.Size = New System.Drawing.Size(651, 33)
        Me.TXT_ADMIN_ADDRESS.TabIndex = 118
        '
        'frmEditAdminAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(988, 599)
        Me.Controls.Add(Me.PNL_ADMIN_HOLDER)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditAdminAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditAdminAccount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNL_ADMIN_HOLDER.ResumeLayout(False)
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_edit_cnumber.ResumeLayout(False)
        CType(Me.pb_edit_cnumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_edit_address.ResumeLayout(False)
        CType(Me.pb_edit_address, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_edit_lname.ResumeLayout(False)
        CType(Me.pb_edit_lname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PNL_ADMIN_HOLDER As Panel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents CB_UPDATE_ADMIN_ACCNT As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_REG_ADMIN As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnl_edit_cnumber As Panel
    Friend WithEvents pb_edit_cnumber As PictureBox
    Friend WithEvents pnl_edit_address As Panel
    Friend WithEvents pb_edit_address As PictureBox
    Friend WithEvents pnl_edit_lname As Panel
    Friend WithEvents pb_edit_lname As PictureBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_ADMIN_EMAIL As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents TXT_ADMIN_FNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents TXT_ADMIN_CNUMBER As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_ADMIN_LNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_ADMIN_ADDRESS As Guna.UI.WinForms.GunaLineTextBox
End Class
