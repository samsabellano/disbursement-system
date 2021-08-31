<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturnAmount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturnAmount))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PNL_PREV_BALANCE = New System.Windows.Forms.Panel()
        Me.LBL_PREVIOUS_BALANCE = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LBL_OUTSTANDING_BALANCE = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LBL_GET_DATE = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBL_ADMIN_NAME = New System.Windows.Forms.Label()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PNL_SUCCESS = New System.Windows.Forms.Panel()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_exit_account = New Guna.UI.WinForms.GunaCircleButton()
        Me.BTN_RETURN_AMOUNT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_AMOUNT_TO_RETURN = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBL_BENEFICIARY_FULLNAME = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_STUD_ID = New System.Windows.Forms.Label()
        Me.LBL_STATUS = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.timer_success = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.PNL_PREV_BALANCE.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.PNL_SUCCESS.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaShadowPanel1)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 589)
        Me.Panel1.TabIndex = 0
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.PNL_PREV_BALANCE)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel9)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaSeparator1)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel7)
        Me.GunaShadowPanel1.Controls.Add(Me.Label4)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel8)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(613, 77)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 3
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel1.ShadowDepth = 50
        Me.GunaShadowPanel1.ShadowShift = 6
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(340, 410)
        Me.GunaShadowPanel1.TabIndex = 51
        '
        'PNL_PREV_BALANCE
        '
        Me.PNL_PREV_BALANCE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_PREV_BALANCE.Controls.Add(Me.LBL_PREVIOUS_BALANCE)
        Me.PNL_PREV_BALANCE.Controls.Add(Me.Label8)
        Me.PNL_PREV_BALANCE.Location = New System.Drawing.Point(61, 310)
        Me.PNL_PREV_BALANCE.Name = "PNL_PREV_BALANCE"
        Me.PNL_PREV_BALANCE.Size = New System.Drawing.Size(224, 53)
        Me.PNL_PREV_BALANCE.TabIndex = 88
        '
        'LBL_PREVIOUS_BALANCE
        '
        Me.LBL_PREVIOUS_BALANCE.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_PREVIOUS_BALANCE.AutoSize = True
        Me.LBL_PREVIOUS_BALANCE.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PREVIOUS_BALANCE.ForeColor = System.Drawing.Color.Teal
        Me.LBL_PREVIOUS_BALANCE.Location = New System.Drawing.Point(32, 7)
        Me.LBL_PREVIOUS_BALANCE.Name = "LBL_PREVIOUS_BALANCE"
        Me.LBL_PREVIOUS_BALANCE.Size = New System.Drawing.Size(39, 18)
        Me.LBL_PREVIOUS_BALANCE.TabIndex = 58
        Me.LBL_PREVIOUS_BALANCE.Text = "0.00"
        Me.LBL_PREVIOUS_BALANCE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(30, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Previous balance"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.LBL_OUTSTANDING_BALANCE)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Location = New System.Drawing.Point(61, 226)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(224, 82)
        Me.Panel9.TabIndex = 87
        '
        'LBL_OUTSTANDING_BALANCE
        '
        Me.LBL_OUTSTANDING_BALANCE.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_OUTSTANDING_BALANCE.AutoSize = True
        Me.LBL_OUTSTANDING_BALANCE.Font = New System.Drawing.Font("Arial Nova", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_OUTSTANDING_BALANCE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LBL_OUTSTANDING_BALANCE.Location = New System.Drawing.Point(29, 17)
        Me.LBL_OUTSTANDING_BALANCE.Name = "LBL_OUTSTANDING_BALANCE"
        Me.LBL_OUTSTANDING_BALANCE.Size = New System.Drawing.Size(71, 35)
        Me.LBL_OUTSTANDING_BALANCE.TabIndex = 58
        Me.LBL_OUTSTANDING_BALANCE.Text = "0.00"
        Me.LBL_OUTSTANDING_BALANCE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(32, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Outstanding balance"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaSeparator1.Location = New System.Drawing.Point(61, 206)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(224, 10)
        Me.GunaSeparator1.TabIndex = 86
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.LBL_GET_DATE)
        Me.Panel7.Controls.Add(Me.PictureBox9)
        Me.Panel7.Location = New System.Drawing.Point(61, 143)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 41)
        Me.Panel7.TabIndex = 85
        '
        'LBL_GET_DATE
        '
        Me.LBL_GET_DATE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_GET_DATE.AutoSize = True
        Me.LBL_GET_DATE.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GET_DATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LBL_GET_DATE.Location = New System.Drawing.Point(36, 16)
        Me.LBL_GET_DATE.Name = "LBL_GET_DATE"
        Me.LBL_GET_DATE.Size = New System.Drawing.Size(31, 15)
        Me.LBL_GET_DATE.TabIndex = 84
        Me.LBL_GET_DATE.Text = "Date"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(5, 12)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 61
        Me.PictureBox9.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(58, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Recievd by"
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.PictureBox10)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.LBL_ADMIN_NAME)
        Me.Panel8.Location = New System.Drawing.Point(61, 74)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 59)
        Me.Panel8.TabIndex = 84
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(5, 9)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 61
        Me.PictureBox10.TabStop = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(36, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Admin"
        '
        'LBL_ADMIN_NAME
        '
        Me.LBL_ADMIN_NAME.AutoSize = True
        Me.LBL_ADMIN_NAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ADMIN_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.LBL_ADMIN_NAME.Location = New System.Drawing.Point(36, 17)
        Me.LBL_ADMIN_NAME.Name = "LBL_ADMIN_NAME"
        Me.LBL_ADMIN_NAME.Size = New System.Drawing.Size(97, 18)
        Me.LBL_ADMIN_NAME.TabIndex = 68
        Me.LBL_ADMIN_NAME.Text = "Admin name"
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.PNL_SUCCESS)
        Me.GunaShadowPanel2.Controls.Add(Me.btn_exit_account)
        Me.GunaShadowPanel2.Controls.Add(Me.BTN_RETURN_AMOUNT)
        Me.GunaShadowPanel2.Controls.Add(Me.Label15)
        Me.GunaShadowPanel2.Controls.Add(Me.TXT_AMOUNT_TO_RETURN)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaSeparator3)
        Me.GunaShadowPanel2.Controls.Add(Me.Label3)
        Me.GunaShadowPanel2.Controls.Add(Me.Panel3)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(52, 77)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 3
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel2.ShadowDepth = 50
        Me.GunaShadowPanel2.ShadowShift = 6
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(555, 410)
        Me.GunaShadowPanel2.TabIndex = 1
        '
        'PNL_SUCCESS
        '
        Me.PNL_SUCCESS.Controls.Add(Me.GunaCirclePictureBox2)
        Me.PNL_SUCCESS.Controls.Add(Me.Label9)
        Me.PNL_SUCCESS.Location = New System.Drawing.Point(353, 178)
        Me.PNL_SUCCESS.Name = "PNL_SUCCESS"
        Me.PNL_SUCCESS.Size = New System.Drawing.Size(110, 100)
        Me.PNL_SUCCESS.TabIndex = 51
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(31, 16)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox2.TabIndex = 89
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(29, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Success!"
        '
        'btn_exit_account
        '
        Me.btn_exit_account.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit_account.Animated = True
        Me.btn_exit_account.AnimationHoverSpeed = 0.07!
        Me.btn_exit_account.AnimationSpeed = 0.03!
        Me.btn_exit_account.BaseColor = System.Drawing.Color.White
        Me.btn_exit_account.BorderColor = System.Drawing.Color.Black
        Me.btn_exit_account.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_exit_account.FocusedColor = System.Drawing.Color.Empty
        Me.btn_exit_account.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_exit_account.ForeColor = System.Drawing.Color.White
        Me.btn_exit_account.Image = CType(resources.GetObject("btn_exit_account.Image"), System.Drawing.Image)
        Me.btn_exit_account.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_exit_account.Location = New System.Drawing.Point(492, 38)
        Me.btn_exit_account.Name = "btn_exit_account"
        Me.btn_exit_account.OnHoverBaseColor = System.Drawing.Color.White
        Me.btn_exit_account.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_exit_account.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_exit_account.OnHoverImage = Nothing
        Me.btn_exit_account.OnPressedColor = System.Drawing.Color.Black
        Me.btn_exit_account.Size = New System.Drawing.Size(30, 30)
        Me.btn_exit_account.TabIndex = 88
        '
        'BTN_RETURN_AMOUNT
        '
        Me.BTN_RETURN_AMOUNT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_RETURN_AMOUNT.Animated = True
        Me.BTN_RETURN_AMOUNT.AnimationHoverSpeed = 0.07!
        Me.BTN_RETURN_AMOUNT.AnimationSpeed = 0.03!
        Me.BTN_RETURN_AMOUNT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RETURN_AMOUNT.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_RETURN_AMOUNT.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_RETURN_AMOUNT.BorderSize = 1
        Me.BTN_RETURN_AMOUNT.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_RETURN_AMOUNT.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_RETURN_AMOUNT.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_RETURN_AMOUNT.CheckedImage = CType(resources.GetObject("BTN_RETURN_AMOUNT.CheckedImage"), System.Drawing.Image)
        Me.BTN_RETURN_AMOUNT.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_RETURN_AMOUNT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_RETURN_AMOUNT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_RETURN_AMOUNT.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RETURN_AMOUNT.ForeColor = System.Drawing.Color.White
        Me.BTN_RETURN_AMOUNT.Image = Nothing
        Me.BTN_RETURN_AMOUNT.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_RETURN_AMOUNT.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_RETURN_AMOUNT.Location = New System.Drawing.Point(51, 286)
        Me.BTN_RETURN_AMOUNT.Name = "BTN_RETURN_AMOUNT"
        Me.BTN_RETURN_AMOUNT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_RETURN_AMOUNT.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_RETURN_AMOUNT.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_RETURN_AMOUNT.OnHoverImage = Nothing
        Me.BTN_RETURN_AMOUNT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_RETURN_AMOUNT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_RETURN_AMOUNT.Radius = 5
        Me.BTN_RETURN_AMOUNT.Size = New System.Drawing.Size(97, 32)
        Me.BTN_RETURN_AMOUNT.TabIndex = 87
        Me.BTN_RETURN_AMOUNT.Text = "Ok"
        Me.BTN_RETURN_AMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(48, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 16)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Amount to return:"
        '
        'TXT_AMOUNT_TO_RETURN
        '
        Me.TXT_AMOUNT_TO_RETURN.Animated = True
        Me.TXT_AMOUNT_TO_RETURN.BackColor = System.Drawing.Color.White
        Me.TXT_AMOUNT_TO_RETURN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_AMOUNT_TO_RETURN.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_AMOUNT_TO_RETURN.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AMOUNT_TO_RETURN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.TXT_AMOUNT_TO_RETURN.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_AMOUNT_TO_RETURN.LineSize = 2
        Me.TXT_AMOUNT_TO_RETURN.Location = New System.Drawing.Point(51, 236)
        Me.TXT_AMOUNT_TO_RETURN.MaxLength = 11
        Me.TXT_AMOUNT_TO_RETURN.Name = "TXT_AMOUNT_TO_RETURN"
        Me.TXT_AMOUNT_TO_RETURN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_AMOUNT_TO_RETURN.Size = New System.Drawing.Size(249, 29)
        Me.TXT_AMOUNT_TO_RETURN.TabIndex = 85
        Me.TXT_AMOUNT_TO_RETURN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator3.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaSeparator3.Location = New System.Drawing.Point(171, 149)
        Me.GunaSeparator3.Name = "GunaSeparator3"
        Me.GunaSeparator3.Size = New System.Drawing.Size(325, 10)
        Me.GunaSeparator3.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(48, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Amount Returning"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LBL_BENEFICIARY_FULLNAME)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.LBL_STUD_ID)
        Me.Panel3.Controls.Add(Me.LBL_STATUS)
        Me.Panel3.Location = New System.Drawing.Point(135, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 80)
        Me.Panel3.TabIndex = 50
        '
        'LBL_BENEFICIARY_FULLNAME
        '
        Me.LBL_BENEFICIARY_FULLNAME.AutoSize = True
        Me.LBL_BENEFICIARY_FULLNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BENEFICIARY_FULLNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.LBL_BENEFICIARY_FULLNAME.Location = New System.Drawing.Point(11, 8)
        Me.LBL_BENEFICIARY_FULLNAME.Name = "LBL_BENEFICIARY_FULLNAME"
        Me.LBL_BENEFICIARY_FULLNAME.Size = New System.Drawing.Size(156, 18)
        Me.LBL_BENEFICIARY_FULLNAME.TabIndex = 0
        Me.LBL_BENEFICIARY_FULLNAME.Text = "Samuel Sabellano Jr."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account #: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status:"
        '
        'LBL_STUD_ID
        '
        Me.LBL_STUD_ID.AutoSize = True
        Me.LBL_STUD_ID.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_STUD_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.LBL_STUD_ID.Location = New System.Drawing.Point(70, 36)
        Me.LBL_STUD_ID.Name = "LBL_STUD_ID"
        Me.LBL_STUD_ID.Size = New System.Drawing.Size(64, 14)
        Me.LBL_STUD_ID.TabIndex = 0
        Me.LBL_STUD_ID.Text = "ID Number"
        '
        'LBL_STATUS
        '
        Me.LBL_STATUS.AutoSize = True
        Me.LBL_STATUS.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_STATUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.LBL_STATUS.Location = New System.Drawing.Point(53, 56)
        Me.LBL_STATUS.Name = "LBL_STATUS"
        Me.LBL_STATUS.Size = New System.Drawing.Size(40, 14)
        Me.LBL_STATUS.TabIndex = 0
        Me.LBL_STATUS.Text = "status"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(51, 38)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(78, 80)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox1.TabIndex = 49
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'timer_success
        '
        '
        'frmReturnAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1005, 589)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturnAmount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReturnAmount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.PNL_PREV_BALANCE.ResumeLayout(False)
        Me.PNL_PREV_BALANCE.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        Me.PNL_SUCCESS.ResumeLayout(False)
        Me.PNL_SUCCESS.PerformLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBL_BENEFICIARY_FULLNAME As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_STUD_ID As Label
    Friend WithEvents LBL_STATUS As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TXT_AMOUNT_TO_RETURN As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BTN_RETURN_AMOUNT As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LBL_ADMIN_NAME As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LBL_GET_DATE As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Panel9 As Panel
    Friend WithEvents LBL_OUTSTANDING_BALANCE As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PNL_PREV_BALANCE As Panel
    Friend WithEvents LBL_PREVIOUS_BALANCE As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_exit_account As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents PNL_SUCCESS As Panel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents timer_success As Timer
End Class
