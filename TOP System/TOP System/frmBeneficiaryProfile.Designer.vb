<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBeneficiaryProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeneficiaryProfile))
        Me.PNL_HEADER = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE_BEN_INFO_WINDOW = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.BTN_BEN_INFO_BALANCE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_BEN_INFO_PROFILE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_BEN_INFO_AMOUNT_RETURN = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PNL_BENEFICIARY_INFO_HOLDER = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.LBL_BEN_CONTACT_NUMBER = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LBL_BEN_ADDRESS = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LBL_BEN_SCHOOL_NAME = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXT_BEN_STATUS = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_BEN_FNAME = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.PNL_HEADER.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_HEADER
        '
        Me.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PNL_HEADER.Controls.Add(Me.BTN_CLOSE_BEN_INFO_WINDOW)
        Me.PNL_HEADER.Controls.Add(Me.GunaLabel2)
        Me.PNL_HEADER.Controls.Add(Me.GunaCirclePictureBox1)
        Me.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_HEADER.Location = New System.Drawing.Point(0, 0)
        Me.PNL_HEADER.Name = "PNL_HEADER"
        Me.PNL_HEADER.Size = New System.Drawing.Size(1025, 46)
        Me.PNL_HEADER.TabIndex = 0
        '
        'BTN_CLOSE_BEN_INFO_WINDOW
        '
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Animated = True
        Me.BTN_CLOSE_BEN_INFO_WINDOW.AnimationHoverSpeed = 0.07!
        Me.BTN_CLOSE_BEN_INFO_WINDOW.AnimationSpeed = 0.03!
        Me.BTN_CLOSE_BEN_INFO_WINDOW.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BTN_CLOSE_BEN_INFO_WINDOW.BorderColor = System.Drawing.Color.Black
        Me.BTN_CLOSE_BEN_INFO_WINDOW.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_CLOSE_BEN_INFO_WINDOW.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_CLOSE_BEN_INFO_WINDOW.ForeColor = System.Drawing.Color.White
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Image = CType(resources.GetObject("BTN_CLOSE_BEN_INFO_WINDOW.Image"), System.Drawing.Image)
        Me.BTN_CLOSE_BEN_INFO_WINDOW.ImageSize = New System.Drawing.Size(17, 17)
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Location = New System.Drawing.Point(982, 9)
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Name = "BTN_CLOSE_BEN_INFO_WINDOW"
        Me.BTN_CLOSE_BEN_INFO_WINDOW.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BTN_CLOSE_BEN_INFO_WINDOW.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_CLOSE_BEN_INFO_WINDOW.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_CLOSE_BEN_INFO_WINDOW.OnHoverImage = Nothing
        Me.BTN_CLOSE_BEN_INFO_WINDOW.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Size = New System.Drawing.Size(30, 30)
        Me.BTN_CLOSE_BEN_INFO_WINDOW.TabIndex = 89
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GunaLabel2.Location = New System.Drawing.Point(45, 15)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(152, 16)
        Me.GunaLabel2.TabIndex = 53
        Me.GunaLabel2.Text = "Beneficiary Information"
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
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 6
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.BTN_BEN_INFO_BALANCE)
        Me.GunaShadowPanel1.Controls.Add(Me.BTN_BEN_INFO_PROFILE)
        Me.GunaShadowPanel1.Controls.Add(Me.BTN_BEN_INFO_AMOUNT_RETURN)
        Me.GunaShadowPanel1.Controls.Add(Me.BTN_BEN_INFO_AMOUNT_DISBURSE)
        Me.GunaShadowPanel1.Controls.Add(Me.PNL_BENEFICIARY_INFO_HOLDER)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaShadowPanel2)
        Me.GunaShadowPanel1.Controls.Add(Me.PNL_HEADER)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 10
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 0
        Me.GunaShadowPanel1.ShadowShift = 0
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(1025, 546)
        Me.GunaShadowPanel1.TabIndex = 1
        '
        'BTN_BEN_INFO_BALANCE
        '
        Me.BTN_BEN_INFO_BALANCE.Animated = True
        Me.BTN_BEN_INFO_BALANCE.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_INFO_BALANCE.AnimationSpeed = 0.03!
        Me.BTN_BEN_INFO_BALANCE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_BALANCE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_BALANCE.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_BALANCE.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_INFO_BALANCE.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_BALANCE.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_BALANCE.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BTN_BEN_INFO_BALANCE.CheckedImage = Nothing
        Me.BTN_BEN_INFO_BALANCE.CheckedLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_BALANCE.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_BEN_INFO_BALANCE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_INFO_BALANCE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_INFO_BALANCE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_INFO_BALANCE.ForeColor = System.Drawing.Color.Gray
        Me.BTN_BEN_INFO_BALANCE.Image = Nothing
        Me.BTN_BEN_INFO_BALANCE.ImageSize = New System.Drawing.Size(25, 25)
        Me.BTN_BEN_INFO_BALANCE.LineBottom = 3
        Me.BTN_BEN_INFO_BALANCE.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_BALANCE.Location = New System.Drawing.Point(610, 52)
        Me.BTN_BEN_INFO_BALANCE.Name = "BTN_BEN_INFO_BALANCE"
        Me.BTN_BEN_INFO_BALANCE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTN_BEN_INFO_BALANCE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_BALANCE.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BTN_BEN_INFO_BALANCE.OnHoverImage = Nothing
        Me.BTN_BEN_INFO_BALANCE.OnHoverLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_BALANCE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_BALANCE.Size = New System.Drawing.Size(94, 47)
        Me.BTN_BEN_INFO_BALANCE.TabIndex = 99
        Me.BTN_BEN_INFO_BALANCE.Text = "Balance"
        Me.BTN_BEN_INFO_BALANCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_BEN_INFO_PROFILE
        '
        Me.BTN_BEN_INFO_PROFILE.Animated = True
        Me.BTN_BEN_INFO_PROFILE.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_INFO_PROFILE.AnimationSpeed = 0.03!
        Me.BTN_BEN_INFO_PROFILE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_PROFILE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_PROFILE.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_PROFILE.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_INFO_PROFILE.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_PROFILE.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_PROFILE.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BTN_BEN_INFO_PROFILE.CheckedImage = Nothing
        Me.BTN_BEN_INFO_PROFILE.CheckedLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_PROFILE.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_BEN_INFO_PROFILE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_INFO_PROFILE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_INFO_PROFILE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_INFO_PROFILE.ForeColor = System.Drawing.Color.Gray
        Me.BTN_BEN_INFO_PROFILE.Image = Nothing
        Me.BTN_BEN_INFO_PROFILE.ImageSize = New System.Drawing.Size(25, 25)
        Me.BTN_BEN_INFO_PROFILE.LineBottom = 3
        Me.BTN_BEN_INFO_PROFILE.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_PROFILE.Location = New System.Drawing.Point(325, 52)
        Me.BTN_BEN_INFO_PROFILE.Name = "BTN_BEN_INFO_PROFILE"
        Me.BTN_BEN_INFO_PROFILE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTN_BEN_INFO_PROFILE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_PROFILE.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BTN_BEN_INFO_PROFILE.OnHoverImage = Nothing
        Me.BTN_BEN_INFO_PROFILE.OnHoverLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_PROFILE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_PROFILE.Size = New System.Drawing.Size(94, 47)
        Me.BTN_BEN_INFO_PROFILE.TabIndex = 98
        Me.BTN_BEN_INFO_PROFILE.Text = "Profile"
        Me.BTN_BEN_INFO_PROFILE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedImage = Nothing
        Me.BTN_BEN_INFO_AMOUNT_RETURN.CheckedLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_BEN_INFO_AMOUNT_RETURN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_INFO_AMOUNT_RETURN.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.ForeColor = System.Drawing.Color.Gray
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Image = Nothing
        Me.BTN_BEN_INFO_AMOUNT_RETURN.ImageSize = New System.Drawing.Size(25, 25)
        Me.BTN_BEN_INFO_AMOUNT_RETURN.LineBottom = 3
        Me.BTN_BEN_INFO_AMOUNT_RETURN.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Location = New System.Drawing.Point(515, 52)
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Name = "BTN_BEN_INFO_AMOUNT_RETURN"
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverImage = Nothing
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnHoverLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_AMOUNT_RETURN.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Size = New System.Drawing.Size(94, 47)
        Me.BTN_BEN_INFO_AMOUNT_RETURN.TabIndex = 6
        Me.BTN_BEN_INFO_AMOUNT_RETURN.Text = "Return"
        Me.BTN_BEN_INFO_AMOUNT_RETURN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_BEN_INFO_AMOUNT_DISBURSE
        '
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Animated = True
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.AnimationHoverSpeed = 0.07!
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.AnimationSpeed = 0.03!
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.BorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.CheckedImage = Nothing
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.CheckedLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.ForeColor = System.Drawing.Color.Gray
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Image = Nothing
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.ImageSize = New System.Drawing.Size(25, 25)
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.LineBottom = 3
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.LineColor = System.Drawing.Color.Transparent
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Location = New System.Drawing.Point(420, 52)
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Name = "BTN_BEN_INFO_AMOUNT_DISBURSE"
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.OnHoverImage = Nothing
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.OnHoverLineColor = System.Drawing.Color.DodgerBlue
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Size = New System.Drawing.Size(94, 47)
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.TabIndex = 5
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.Text = "Disbursement"
        Me.BTN_BEN_INFO_AMOUNT_DISBURSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PNL_BENEFICIARY_INFO_HOLDER
        '
        Me.PNL_BENEFICIARY_INFO_HOLDER.BackColor = System.Drawing.Color.Transparent
        Me.PNL_BENEFICIARY_INFO_HOLDER.BaseColor = System.Drawing.Color.White
        Me.PNL_BENEFICIARY_INFO_HOLDER.Location = New System.Drawing.Point(315, 105)
        Me.PNL_BENEFICIARY_INFO_HOLDER.Name = "PNL_BENEFICIARY_INFO_HOLDER"
        Me.PNL_BENEFICIARY_INFO_HOLDER.Radius = 2
        Me.PNL_BENEFICIARY_INFO_HOLDER.ShadowColor = System.Drawing.Color.Black
        Me.PNL_BENEFICIARY_INFO_HOLDER.ShadowDepth = 50
        Me.PNL_BENEFICIARY_INFO_HOLDER.ShadowShift = 2
        Me.PNL_BENEFICIARY_INFO_HOLDER.Size = New System.Drawing.Size(683, 400)
        Me.PNL_BENEFICIARY_INFO_HOLDER.TabIndex = 97
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.GunaSeparator2)
        Me.GunaShadowPanel2.Controls.Add(Me.LBL_BEN_CONTACT_NUMBER)
        Me.GunaShadowPanel2.Controls.Add(Me.PictureBox3)
        Me.GunaShadowPanel2.Controls.Add(Me.LBL_BEN_ADDRESS)
        Me.GunaShadowPanel2.Controls.Add(Me.PictureBox2)
        Me.GunaShadowPanel2.Controls.Add(Me.LBL_BEN_SCHOOL_NAME)
        Me.GunaShadowPanel2.Controls.Add(Me.PictureBox1)
        Me.GunaShadowPanel2.Controls.Add(Me.TXT_BEN_STATUS)
        Me.GunaShadowPanel2.Controls.Add(Me.TXT_BEN_FNAME)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaCirclePictureBox2)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(29, 105)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 2
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowDepth = 50
        Me.GunaShadowPanel2.ShadowShift = 2
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(275, 400)
        Me.GunaShadowPanel2.TabIndex = 9
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaSeparator2.Location = New System.Drawing.Point(3, 227)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(269, 14)
        Me.GunaSeparator2.TabIndex = 92
        '
        'LBL_BEN_CONTACT_NUMBER
        '
        Me.LBL_BEN_CONTACT_NUMBER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_BEN_CONTACT_NUMBER.AutoSize = True
        Me.LBL_BEN_CONTACT_NUMBER.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BEN_CONTACT_NUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LBL_BEN_CONTACT_NUMBER.Location = New System.Drawing.Point(62, 347)
        Me.LBL_BEN_CONTACT_NUMBER.Name = "LBL_BEN_CONTACT_NUMBER"
        Me.LBL_BEN_CONTACT_NUMBER.Size = New System.Drawing.Size(50, 14)
        Me.LBL_BEN_CONTACT_NUMBER.TabIndex = 91
        Me.LBL_BEN_CONTACT_NUMBER.Text = "Phone #"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(34, 341)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 90
        Me.PictureBox3.TabStop = False
        '
        'LBL_BEN_ADDRESS
        '
        Me.LBL_BEN_ADDRESS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_BEN_ADDRESS.AutoSize = True
        Me.LBL_BEN_ADDRESS.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BEN_ADDRESS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LBL_BEN_ADDRESS.Location = New System.Drawing.Point(62, 310)
        Me.LBL_BEN_ADDRESS.Name = "LBL_BEN_ADDRESS"
        Me.LBL_BEN_ADDRESS.Size = New System.Drawing.Size(52, 14)
        Me.LBL_BEN_ADDRESS.TabIndex = 89
        Me.LBL_BEN_ADDRESS.Text = "Address"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(34, 304)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'LBL_BEN_SCHOOL_NAME
        '
        Me.LBL_BEN_SCHOOL_NAME.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_BEN_SCHOOL_NAME.AutoSize = True
        Me.LBL_BEN_SCHOOL_NAME.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BEN_SCHOOL_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LBL_BEN_SCHOOL_NAME.Location = New System.Drawing.Point(62, 274)
        Me.LBL_BEN_SCHOOL_NAME.Name = "LBL_BEN_SCHOOL_NAME"
        Me.LBL_BEN_SCHOOL_NAME.Size = New System.Drawing.Size(44, 14)
        Me.LBL_BEN_SCHOOL_NAME.TabIndex = 87
        Me.LBL_BEN_SCHOOL_NAME.Text = "School"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 268)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TXT_BEN_STATUS
        '
        Me.TXT_BEN_STATUS.BaseColor = System.Drawing.Color.White
        Me.TXT_BEN_STATUS.BorderColor = System.Drawing.Color.Silver
        Me.TXT_BEN_STATUS.BorderSize = 0
        Me.TXT_BEN_STATUS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BEN_STATUS.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_BEN_STATUS.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BEN_STATUS.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_BEN_STATUS.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BEN_STATUS.ForeColor = System.Drawing.Color.DarkGray
        Me.TXT_BEN_STATUS.Location = New System.Drawing.Point(15, 184)
        Me.TXT_BEN_STATUS.Name = "TXT_BEN_STATUS"
        Me.TXT_BEN_STATUS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BEN_STATUS.Size = New System.Drawing.Size(245, 32)
        Me.TXT_BEN_STATUS.TabIndex = 1
        Me.TXT_BEN_STATUS.Text = "Status"
        Me.TXT_BEN_STATUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_BEN_FNAME
        '
        Me.TXT_BEN_FNAME.BaseColor = System.Drawing.Color.White
        Me.TXT_BEN_FNAME.BorderColor = System.Drawing.Color.Silver
        Me.TXT_BEN_FNAME.BorderSize = 0
        Me.TXT_BEN_FNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BEN_FNAME.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_BEN_FNAME.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BEN_FNAME.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_BEN_FNAME.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BEN_FNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.TXT_BEN_FNAME.Location = New System.Drawing.Point(15, 157)
        Me.TXT_BEN_FNAME.Name = "TXT_BEN_FNAME"
        Me.TXT_BEN_FNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BEN_FNAME.Size = New System.Drawing.Size(245, 32)
        Me.TXT_BEN_FNAME.TabIndex = 0
        Me.TXT_BEN_FNAME.Text = "Samuel C. Sabellano"
        Me.TXT_BEN_FNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(78, 37)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(120, 114)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox2.TabIndex = 0
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'frmBeneficiaryProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 546)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBeneficiaryProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beneficiary Information"
        Me.PNL_HEADER.ResumeLayout(False)
        Me.PNL_HEADER.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PNL_HEADER As Panel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents BTN_BEN_INFO_AMOUNT_DISBURSE As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_BEN_INFO_AMOUNT_RETURN As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents PNL_BENEFICIARY_INFO_HOLDER As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents TXT_BEN_FNAME As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_BEN_STATUS As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBL_BEN_SCHOOL_NAME As Label
    Friend WithEvents LBL_BEN_CONTACT_NUMBER As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LBL_BEN_ADDRESS As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BTN_BEN_INFO_PROFILE As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents BTN_CLOSE_BEN_INFO_WINDOW As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents BTN_BEN_INFO_BALANCE As Guna.UI.WinForms.GunaAdvenceButton
End Class
