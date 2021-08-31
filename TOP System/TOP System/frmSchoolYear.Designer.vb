<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolYear))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTN_CONTINUE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXT_SY_TO = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_SY_FROM = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.DG_SCHOOL_YEAR = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_OTHER_UPDATE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_BEN_INFO_AMOUNT_RETURN = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PNL_HEADER = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DG_SCHOOL_YEAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PNL_HEADER.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 6
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.Panel4)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel2)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel1)
        Me.GunaShadowPanel1.Controls.Add(Me.PNL_HEADER)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 10
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 0
        Me.GunaShadowPanel1.ShadowShift = 0
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(702, 441)
        Me.GunaShadowPanel1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BTN_CONTINUE)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.TXT_SY_TO)
        Me.Panel4.Controls.Add(Me.GunaLabel3)
        Me.Panel4.Controls.Add(Me.TXT_SY_FROM)
        Me.Panel4.Controls.Add(Me.GunaLabel6)
        Me.Panel4.Location = New System.Drawing.Point(385, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 319)
        Me.Panel4.TabIndex = 106
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
        Me.BTN_CONTINUE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CONTINUE.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONTINUE.ForeColor = System.Drawing.Color.White
        Me.BTN_CONTINUE.Image = Nothing
        Me.BTN_CONTINUE.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_CONTINUE.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CONTINUE.Location = New System.Drawing.Point(27, 167)
        Me.BTN_CONTINUE.Name = "BTN_CONTINUE"
        Me.BTN_CONTINUE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_CONTINUE.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_CONTINUE.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_CONTINUE.OnHoverImage = Nothing
        Me.BTN_CONTINUE.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_CONTINUE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CONTINUE.Radius = 5
        Me.BTN_CONTINUE.Size = New System.Drawing.Size(243, 36)
        Me.BTN_CONTINUE.TabIndex = 111
        Me.BTN_CONTINUE.Text = "Save"
        Me.BTN_CONTINUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'TXT_SY_TO
        '
        Me.TXT_SY_TO.Animated = True
        Me.TXT_SY_TO.BackColor = System.Drawing.Color.White
        Me.TXT_SY_TO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_SY_TO.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_SY_TO.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SY_TO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_SY_TO.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_SY_TO.LineSize = 2
        Me.TXT_SY_TO.Location = New System.Drawing.Point(170, 76)
        Me.TXT_SY_TO.MaxLength = 4
        Me.TXT_SY_TO.Name = "TXT_SY_TO"
        Me.TXT_SY_TO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_SY_TO.Size = New System.Drawing.Size(89, 33)
        Me.TXT_SY_TO.TabIndex = 109
        Me.TXT_SY_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(207, 112)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(22, 16)
        Me.GunaLabel3.TabIndex = 108
        Me.GunaLabel3.Text = "To"
        '
        'TXT_SY_FROM
        '
        Me.TXT_SY_FROM.Animated = True
        Me.TXT_SY_FROM.BackColor = System.Drawing.Color.White
        Me.TXT_SY_FROM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_SY_FROM.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_SY_FROM.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SY_FROM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_SY_FROM.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_SY_FROM.LineSize = 2
        Me.TXT_SY_FROM.Location = New System.Drawing.Point(27, 76)
        Me.TXT_SY_FROM.MaxLength = 4
        Me.TXT_SY_FROM.Name = "TXT_SY_FROM"
        Me.TXT_SY_FROM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_SY_FROM.Size = New System.Drawing.Size(89, 33)
        Me.TXT_SY_FROM.TabIndex = 107
        Me.TXT_SY_FROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(63, 112)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(38, 16)
        Me.GunaLabel6.TabIndex = 106
        Me.GunaLabel6.Text = "From"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DG_SCHOOL_YEAR)
        Me.Panel2.Location = New System.Drawing.Point(35, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 319)
        Me.Panel2.TabIndex = 101
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.GunaLabel1)
        Me.Panel3.Controls.Add(Me.GunaLabel4)
        Me.Panel3.Location = New System.Drawing.Point(0, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(314, 30)
        Me.Panel3.TabIndex = 56
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(170, 8)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(100, 14)
        Me.GunaLabel1.TabIndex = 54
        Me.GunaLabel1.Text = "S.Y DESCRIPTION"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(58, 8)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(37, 14)
        Me.GunaLabel4.TabIndex = 53
        Me.GunaLabel4.Text = "S.Y ID"
        '
        'DG_SCHOOL_YEAR
        '
        Me.DG_SCHOOL_YEAR.AllowUserToAddRows = False
        Me.DG_SCHOOL_YEAR.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DG_SCHOOL_YEAR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DG_SCHOOL_YEAR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_SCHOOL_YEAR.BackgroundColor = System.Drawing.Color.White
        Me.DG_SCHOOL_YEAR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_SCHOOL_YEAR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_SCHOOL_YEAR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_SCHOOL_YEAR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DG_SCHOOL_YEAR.ColumnHeadersHeight = 4
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_SCHOOL_YEAR.DefaultCellStyle = DataGridViewCellStyle15
        Me.DG_SCHOOL_YEAR.EnableHeadersVisualStyles = False
        Me.DG_SCHOOL_YEAR.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_SCHOOL_YEAR.Location = New System.Drawing.Point(6, 44)
        Me.DG_SCHOOL_YEAR.Name = "DG_SCHOOL_YEAR"
        Me.DG_SCHOOL_YEAR.ReadOnly = True
        Me.DG_SCHOOL_YEAR.RowHeadersVisible = False
        Me.DG_SCHOOL_YEAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_SCHOOL_YEAR.Size = New System.Drawing.Size(302, 261)
        Me.DG_SCHOOL_YEAR.TabIndex = 57
        Me.DG_SCHOOL_YEAR.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DG_SCHOOL_YEAR.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_SCHOOL_YEAR.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DG_SCHOOL_YEAR.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DG_SCHOOL_YEAR.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DG_SCHOOL_YEAR.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DG_SCHOOL_YEAR.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DG_SCHOOL_YEAR.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_SCHOOL_YEAR.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_SCHOOL_YEAR.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_SCHOOL_YEAR.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_SCHOOL_YEAR.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DG_SCHOOL_YEAR.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DG_SCHOOL_YEAR.ThemeStyle.HeaderStyle.Height = 4
        Me.DG_SCHOOL_YEAR.ThemeStyle.ReadOnly = True
        Me.DG_SCHOOL_YEAR.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_SCHOOL_YEAR.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_SCHOOL_YEAR.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_SCHOOL_YEAR.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DG_SCHOOL_YEAR.ThemeStyle.RowsStyle.Height = 22
        Me.DG_SCHOOL_YEAR.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_SCHOOL_YEAR.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BTN_OTHER_UPDATE)
        Me.Panel1.Controls.Add(Me.BTN_BEN_INFO_AMOUNT_RETURN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 47)
        Me.Panel1.TabIndex = 100
        '
        'BTN_OTHER_UPDATE
        '
        Me.BTN_OTHER_UPDATE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_OTHER_UPDATE.Animated = True
        Me.BTN_OTHER_UPDATE.AnimationHoverSpeed = 0.07!
        Me.BTN_OTHER_UPDATE.AnimationSpeed = 0.03!
        Me.BTN_OTHER_UPDATE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OTHER_UPDATE.BaseColor = System.Drawing.Color.SteelBlue
        Me.BTN_OTHER_UPDATE.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_OTHER_UPDATE.BorderSize = 1
        Me.BTN_OTHER_UPDATE.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_OTHER_UPDATE.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_OTHER_UPDATE.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_OTHER_UPDATE.CheckedImage = CType(resources.GetObject("BTN_OTHER_UPDATE.CheckedImage"), System.Drawing.Image)
        Me.BTN_OTHER_UPDATE.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_OTHER_UPDATE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_OTHER_UPDATE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_OTHER_UPDATE.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_OTHER_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BTN_OTHER_UPDATE.Image = CType(resources.GetObject("BTN_OTHER_UPDATE.Image"), System.Drawing.Image)
        Me.BTN_OTHER_UPDATE.ImageOffsetX = 4
        Me.BTN_OTHER_UPDATE.ImageSize = New System.Drawing.Size(15, 15)
        Me.BTN_OTHER_UPDATE.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_OTHER_UPDATE.Location = New System.Drawing.Point(571, 10)
        Me.BTN_OTHER_UPDATE.Name = "BTN_OTHER_UPDATE"
        Me.BTN_OTHER_UPDATE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTN_OTHER_UPDATE.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_OTHER_UPDATE.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_OTHER_UPDATE.OnHoverImage = Nothing
        Me.BTN_OTHER_UPDATE.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_OTHER_UPDATE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_OTHER_UPDATE.Radius = 5
        Me.BTN_OTHER_UPDATE.Size = New System.Drawing.Size(99, 27)
        Me.BTN_OTHER_UPDATE.TabIndex = 139
        Me.BTN_OTHER_UPDATE.Text = "Add S.Y"
        Me.BTN_OTHER_UPDATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BTN_OTHER_UPDATE.TextOffsetX = 15
        '
        'BTN_BEN_INFO_AMOUNT_RETURN
        '
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Animated = True
        Me.BTN_BEN_INFO_AMOUNT_RETURN.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_INFO_AMOUNT_RETURN.AnimationSpeed = 0.03!
        Me.BTN_BEN_INFO_AMOUNT_RETURN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_AMOUNT_RETURN.BaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_RETURN.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Checked = True
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedImage = Nothing
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedLineColor = System.Drawing.Color.SpringGreen
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_BEN_INFO_AMOUNT_RETURN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_BEN_INFO_AMOUNT_RETURN.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.ForeColor = System.Drawing.Color.Gray
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Image = Nothing
        Me.BTN_BEN_INFO_AMOUNT_RETURN.ImageSize = New System.Drawing.Size(25, 25)
        Me.BTN_BEN_INFO_AMOUNT_RETURN.LineBottom = 2
        Me.BTN_BEN_INFO_AMOUNT_RETURN.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Location = New System.Drawing.Point(0, 0)
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Name = "BTN_BEN_INFO_AMOUNT_RETURN"
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverImage = Nothing
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Size = New System.Drawing.Size(147, 47)
        Me.BTN_BEN_INFO_AMOUNT_RETURN.TabIndex = 6
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Text = "Upate School Year"
        Me.BTN_BEN_INFO_AMOUNT_RETURN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PNL_HEADER
        '
        Me.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PNL_HEADER.Controls.Add(Me.BTN_CLOSE)
        Me.PNL_HEADER.Controls.Add(Me.GunaLabel2)
        Me.PNL_HEADER.Controls.Add(Me.GunaCirclePictureBox1)
        Me.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_HEADER.Location = New System.Drawing.Point(0, 0)
        Me.PNL_HEADER.Name = "PNL_HEADER"
        Me.PNL_HEADER.Size = New System.Drawing.Size(702, 46)
        Me.PNL_HEADER.TabIndex = 0
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.Animated = True
        Me.BTN_CLOSE.AnimationHoverSpeed = 0.07!
        Me.BTN_CLOSE.AnimationSpeed = 0.03!
        Me.BTN_CLOSE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BTN_CLOSE.BorderColor = System.Drawing.Color.Black
        Me.BTN_CLOSE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_CLOSE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_CLOSE.ForeColor = System.Drawing.Color.White
        Me.BTN_CLOSE.Image = CType(resources.GetObject("BTN_CLOSE.Image"), System.Drawing.Image)
        Me.BTN_CLOSE.ImageSize = New System.Drawing.Size(17, 17)
        Me.BTN_CLOSE.Location = New System.Drawing.Point(659, 9)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BTN_CLOSE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_CLOSE.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_CLOSE.OnHoverImage = Nothing
        Me.BTN_CLOSE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_CLOSE.TabIndex = 89
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GunaLabel2.Location = New System.Drawing.Point(45, 13)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(43, 16)
        Me.GunaLabel2.TabIndex = 53
        Me.GunaLabel2.Text = "Other"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox1.TabIndex = 54
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'frmSchoolYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 441)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSchoolYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSchoolYear"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DG_SCHOOL_YEAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PNL_HEADER.ResumeLayout(False)
        Me.PNL_HEADER.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents BTN_BEN_INFO_AMOUNT_RETURN As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PNL_HEADER As Panel
    Friend WithEvents BTN_CLOSE As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DG_SCHOOL_YEAR As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents BTN_OTHER_UPDATE As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TXT_SY_TO As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_SY_FROM As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTN_CONTINUE As Guna.UI.WinForms.GunaAdvenceButton
End Class
