<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddBeneficiary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBeneficiary))
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.BTN_BACK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_SUBMIT_BENEFICIARY = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.CBO_B_EC_RELATIONSHIP = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_EC_CNUMBER = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_EC_LNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_EC_FNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_PASSWORD = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_USERNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_EMAIL = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_SCHOOL_ID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.RB_4TH = New Guna.UI.WinForms.GunaRadioButton()
        Me.RB_3RD = New Guna.UI.WinForms.GunaRadioButton()
        Me.RB_2ND = New Guna.UI.WinForms.GunaRadioButton()
        Me.RB_1ST = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_SCHOOL_NAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.CBO_B_MARITAL_STATUS = New Guna.UI.WinForms.GunaComboBox()
        Me.CBO_B_GENDER = New Guna.UI.WinForms.GunaComboBox()
        Me.TXT_B_FNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.TXT_B_CNUMBER = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_LNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_B_ADDRESS = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel1.AutoScroll = True
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.Panel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaSeparator1)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(85, 29)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 3
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 40
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(841, 632)
        Me.GunaShadowPanel1.TabIndex = 80
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GunaElipsePanel1)
        Me.Panel1.Location = New System.Drawing.Point(25, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 541)
        Me.Panel1.TabIndex = 76
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.Empty
        Me.GunaElipsePanel1.Controls.Add(Me.BTN_BACK)
        Me.GunaElipsePanel1.Controls.Add(Me.BTN_SUBMIT_BENEFICIARY)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel19)
        Me.GunaElipsePanel1.Controls.Add(Me.CBO_B_EC_RELATIONSHIP)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel18)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_EC_CNUMBER)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel15)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_EC_LNAME)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel16)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel17)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_EC_FNAME)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel14)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_PASSWORD)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel13)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_USERNAME)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel12)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_EMAIL)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel11)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_SCHOOL_ID)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel10)
        Me.GunaElipsePanel1.Controls.Add(Me.RB_4TH)
        Me.GunaElipsePanel1.Controls.Add(Me.RB_3RD)
        Me.GunaElipsePanel1.Controls.Add(Me.RB_2ND)
        Me.GunaElipsePanel1.Controls.Add(Me.RB_1ST)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel9)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel8)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_SCHOOL_NAME)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaElipsePanel1.Controls.Add(Me.CBO_B_MARITAL_STATUS)
        Me.GunaElipsePanel1.Controls.Add(Me.CBO_B_GENDER)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_FNAME)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_CNUMBER)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_LNAME)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel1.Controls.Add(Me.TXT_B_ADDRESS)
        Me.GunaElipsePanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(12, 14)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 5
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(744, 860)
        Me.GunaElipsePanel1.TabIndex = 62
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
        Me.BTN_BACK.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_BACK.Image = Nothing
        Me.BTN_BACK.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_BACK.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_BACK.Location = New System.Drawing.Point(48, 771)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_BACK.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.OnHoverForeColor = System.Drawing.Color.DimGray
        Me.BTN_BACK.OnHoverImage = Nothing
        Me.BTN_BACK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_BACK.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BACK.Radius = 5
        Me.BTN_BACK.Size = New System.Drawing.Size(114, 36)
        Me.BTN_BACK.TabIndex = 108
        Me.BTN_BACK.Text = "Back"
        Me.BTN_BACK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_SUBMIT_BENEFICIARY
        '
        Me.BTN_SUBMIT_BENEFICIARY.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_SUBMIT_BENEFICIARY.Animated = True
        Me.BTN_SUBMIT_BENEFICIARY.AnimationHoverSpeed = 0.07!
        Me.BTN_SUBMIT_BENEFICIARY.AnimationSpeed = 0.03!
        Me.BTN_SUBMIT_BENEFICIARY.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SUBMIT_BENEFICIARY.BaseColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BTN_SUBMIT_BENEFICIARY.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SUBMIT_BENEFICIARY.BorderSize = 1
        Me.BTN_SUBMIT_BENEFICIARY.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_SUBMIT_BENEFICIARY.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SUBMIT_BENEFICIARY.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_SUBMIT_BENEFICIARY.CheckedImage = CType(resources.GetObject("BTN_SUBMIT_BENEFICIARY.CheckedImage"), System.Drawing.Image)
        Me.BTN_SUBMIT_BENEFICIARY.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_SUBMIT_BENEFICIARY.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_SUBMIT_BENEFICIARY.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_SUBMIT_BENEFICIARY.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SUBMIT_BENEFICIARY.ForeColor = System.Drawing.Color.White
        Me.BTN_SUBMIT_BENEFICIARY.Image = Nothing
        Me.BTN_SUBMIT_BENEFICIARY.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_SUBMIT_BENEFICIARY.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SUBMIT_BENEFICIARY.Location = New System.Drawing.Point(179, 772)
        Me.BTN_SUBMIT_BENEFICIARY.Name = "BTN_SUBMIT_BENEFICIARY"
        Me.BTN_SUBMIT_BENEFICIARY.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BTN_SUBMIT_BENEFICIARY.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SUBMIT_BENEFICIARY.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_SUBMIT_BENEFICIARY.OnHoverImage = Nothing
        Me.BTN_SUBMIT_BENEFICIARY.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SUBMIT_BENEFICIARY.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_SUBMIT_BENEFICIARY.Radius = 5
        Me.BTN_SUBMIT_BENEFICIARY.Size = New System.Drawing.Size(114, 36)
        Me.BTN_SUBMIT_BENEFICIARY.TabIndex = 74
        Me.BTN_SUBMIT_BENEFICIARY.Text = "Submit"
        Me.BTN_SUBMIT_BENEFICIARY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel19.Location = New System.Drawing.Point(389, 662)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(77, 16)
        Me.GunaLabel19.TabIndex = 106
        Me.GunaLabel19.Text = "Relationship"
        '
        'CBO_B_EC_RELATIONSHIP
        '
        Me.CBO_B_EC_RELATIONSHIP.BackColor = System.Drawing.Color.Transparent
        Me.CBO_B_EC_RELATIONSHIP.BaseColor = System.Drawing.Color.White
        Me.CBO_B_EC_RELATIONSHIP.BorderColor = System.Drawing.Color.Silver
        Me.CBO_B_EC_RELATIONSHIP.BorderSize = 1
        Me.CBO_B_EC_RELATIONSHIP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_B_EC_RELATIONSHIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_B_EC_RELATIONSHIP.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_B_EC_RELATIONSHIP.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_B_EC_RELATIONSHIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.CBO_B_EC_RELATIONSHIP.FormattingEnabled = True
        Me.CBO_B_EC_RELATIONSHIP.ItemHeight = 24
        Me.CBO_B_EC_RELATIONSHIP.Location = New System.Drawing.Point(392, 688)
        Me.CBO_B_EC_RELATIONSHIP.Name = "CBO_B_EC_RELATIONSHIP"
        Me.CBO_B_EC_RELATIONSHIP.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_B_EC_RELATIONSHIP.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_B_EC_RELATIONSHIP.Radius = 4
        Me.CBO_B_EC_RELATIONSHIP.Size = New System.Drawing.Size(171, 30)
        Me.CBO_B_EC_RELATIONSHIP.TabIndex = 73
        '
        'GunaLabel18
        '
        Me.GunaLabel18.AutoSize = True
        Me.GunaLabel18.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel18.Location = New System.Drawing.Point(45, 662)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel18.TabIndex = 103
        Me.GunaLabel18.Text = "Contact #"
        '
        'TXT_B_EC_CNUMBER
        '
        Me.TXT_B_EC_CNUMBER.Animated = True
        Me.TXT_B_EC_CNUMBER.BackColor = System.Drawing.Color.White
        Me.TXT_B_EC_CNUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_EC_CNUMBER.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_EC_CNUMBER.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_EC_CNUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_EC_CNUMBER.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_EC_CNUMBER.LineSize = 2
        Me.TXT_B_EC_CNUMBER.Location = New System.Drawing.Point(48, 691)
        Me.TXT_B_EC_CNUMBER.MaxLength = 11
        Me.TXT_B_EC_CNUMBER.Name = "TXT_B_EC_CNUMBER"
        Me.TXT_B_EC_CNUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_EC_CNUMBER.Size = New System.Drawing.Size(317, 29)
        Me.TXT_B_EC_CNUMBER.TabIndex = 72
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel15.Location = New System.Drawing.Point(389, 588)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel15.TabIndex = 101
        Me.GunaLabel15.Text = "Lastname"
        '
        'TXT_B_EC_LNAME
        '
        Me.TXT_B_EC_LNAME.Animated = True
        Me.TXT_B_EC_LNAME.BackColor = System.Drawing.Color.White
        Me.TXT_B_EC_LNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_EC_LNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_EC_LNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_EC_LNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_EC_LNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_EC_LNAME.LineSize = 2
        Me.TXT_B_EC_LNAME.Location = New System.Drawing.Point(392, 617)
        Me.TXT_B_EC_LNAME.Name = "TXT_B_EC_LNAME"
        Me.TXT_B_EC_LNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_EC_LNAME.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_EC_LNAME.TabIndex = 71
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Arial Nova", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.Color.Purple
        Me.GunaLabel16.Location = New System.Drawing.Point(41, 544)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(149, 20)
        Me.GunaLabel16.TabIndex = 100
        Me.GunaLabel16.Text = "Emergency Contact"
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel17.Location = New System.Drawing.Point(42, 588)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(65, 16)
        Me.GunaLabel17.TabIndex = 98
        Me.GunaLabel17.Text = "Firstname"
        '
        'TXT_B_EC_FNAME
        '
        Me.TXT_B_EC_FNAME.Animated = True
        Me.TXT_B_EC_FNAME.BackColor = System.Drawing.Color.White
        Me.TXT_B_EC_FNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_EC_FNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_EC_FNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_EC_FNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_EC_FNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_EC_FNAME.LineSize = 2
        Me.TXT_B_EC_FNAME.Location = New System.Drawing.Point(45, 617)
        Me.TXT_B_EC_FNAME.Name = "TXT_B_EC_FNAME"
        Me.TXT_B_EC_FNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_EC_FNAME.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_EC_FNAME.TabIndex = 70
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel14.Location = New System.Drawing.Point(389, 237)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(63, 16)
        Me.GunaLabel14.TabIndex = 96
        Me.GunaLabel14.Text = "Password"
        '
        'TXT_B_PASSWORD
        '
        Me.TXT_B_PASSWORD.Animated = True
        Me.TXT_B_PASSWORD.BackColor = System.Drawing.Color.White
        Me.TXT_B_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_PASSWORD.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_PASSWORD.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_PASSWORD.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_PASSWORD.LineSize = 2
        Me.TXT_B_PASSWORD.Location = New System.Drawing.Point(392, 266)
        Me.TXT_B_PASSWORD.Name = "TXT_B_PASSWORD"
        Me.TXT_B_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXT_B_PASSWORD.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_PASSWORD.TabIndex = 63
        Me.TXT_B_PASSWORD.UseSystemPasswordChar = True
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel13.Location = New System.Drawing.Point(42, 237)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(67, 16)
        Me.GunaLabel13.TabIndex = 94
        Me.GunaLabel13.Text = "Username"
        '
        'TXT_B_USERNAME
        '
        Me.TXT_B_USERNAME.Animated = True
        Me.TXT_B_USERNAME.BackColor = System.Drawing.Color.White
        Me.TXT_B_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_USERNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_USERNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_USERNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_USERNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_USERNAME.LineSize = 2
        Me.TXT_B_USERNAME.Location = New System.Drawing.Point(45, 266)
        Me.TXT_B_USERNAME.Name = "TXT_B_USERNAME"
        Me.TXT_B_USERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_USERNAME.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_USERNAME.TabIndex = 62
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(389, 163)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(40, 16)
        Me.GunaLabel12.TabIndex = 92
        Me.GunaLabel12.Text = "Email"
        '
        'TXT_B_EMAIL
        '
        Me.TXT_B_EMAIL.Animated = True
        Me.TXT_B_EMAIL.BackColor = System.Drawing.Color.White
        Me.TXT_B_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_EMAIL.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_EMAIL.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_EMAIL.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_EMAIL.LineSize = 2
        Me.TXT_B_EMAIL.Location = New System.Drawing.Point(392, 192)
        Me.TXT_B_EMAIL.Name = "TXT_B_EMAIL"
        Me.TXT_B_EMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_EMAIL.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_EMAIL.TabIndex = 61
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(389, 372)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel11.TabIndex = 90
        Me.GunaLabel11.Text = "School ID"
        '
        'TXT_B_SCHOOL_ID
        '
        Me.TXT_B_SCHOOL_ID.Animated = True
        Me.TXT_B_SCHOOL_ID.BackColor = System.Drawing.Color.White
        Me.TXT_B_SCHOOL_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_SCHOOL_ID.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_SCHOOL_ID.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_SCHOOL_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_SCHOOL_ID.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_SCHOOL_ID.LineSize = 2
        Me.TXT_B_SCHOOL_ID.Location = New System.Drawing.Point(392, 401)
        Me.TXT_B_SCHOOL_ID.Name = "TXT_B_SCHOOL_ID"
        Me.TXT_B_SCHOOL_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_SCHOOL_ID.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_SCHOOL_ID.TabIndex = 65
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Arial Nova", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.Purple
        Me.GunaLabel10.Location = New System.Drawing.Point(41, 328)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(142, 20)
        Me.GunaLabel10.TabIndex = 77
        Me.GunaLabel10.Text = "School Information"
        '
        'RB_4TH
        '
        Me.RB_4TH.BaseColor = System.Drawing.SystemColors.Control
        Me.RB_4TH.CheckedOffColor = System.Drawing.Color.Gainsboro
        Me.RB_4TH.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RB_4TH.FillColor = System.Drawing.Color.White
        Me.RB_4TH.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_4TH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RB_4TH.Location = New System.Drawing.Point(217, 481)
        Me.RB_4TH.Name = "RB_4TH"
        Me.RB_4TH.Size = New System.Drawing.Size(53, 22)
        Me.RB_4TH.TabIndex = 69
        Me.RB_4TH.Text = "4th"
        '
        'RB_3RD
        '
        Me.RB_3RD.BaseColor = System.Drawing.SystemColors.Control
        Me.RB_3RD.CheckedOffColor = System.Drawing.Color.Gainsboro
        Me.RB_3RD.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RB_3RD.FillColor = System.Drawing.Color.White
        Me.RB_3RD.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_3RD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RB_3RD.Location = New System.Drawing.Point(160, 481)
        Me.RB_3RD.Name = "RB_3RD"
        Me.RB_3RD.Size = New System.Drawing.Size(48, 20)
        Me.RB_3RD.TabIndex = 68
        Me.RB_3RD.Text = "3rd"
        '
        'RB_2ND
        '
        Me.RB_2ND.BaseColor = System.Drawing.SystemColors.Control
        Me.RB_2ND.CheckedOffColor = System.Drawing.Color.Gainsboro
        Me.RB_2ND.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RB_2ND.FillColor = System.Drawing.Color.White
        Me.RB_2ND.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_2ND.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RB_2ND.Location = New System.Drawing.Point(100, 481)
        Me.RB_2ND.Name = "RB_2ND"
        Me.RB_2ND.Size = New System.Drawing.Size(57, 22)
        Me.RB_2ND.TabIndex = 67
        Me.RB_2ND.Text = "2nd"
        '
        'RB_1ST
        '
        Me.RB_1ST.BaseColor = System.Drawing.SystemColors.Control
        Me.RB_1ST.CheckedOffColor = System.Drawing.Color.Gainsboro
        Me.RB_1ST.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RB_1ST.FillColor = System.Drawing.Color.White
        Me.RB_1ST.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_1ST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RB_1ST.Location = New System.Drawing.Point(45, 481)
        Me.RB_1ST.Name = "RB_1ST"
        Me.RB_1ST.Size = New System.Drawing.Size(51, 22)
        Me.RB_1ST.TabIndex = 66
        Me.RB_1ST.Text = "1st "
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(42, 446)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel9.TabIndex = 69
        Me.GunaLabel9.Text = "Year level"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(42, 372)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(48, 16)
        Me.GunaLabel8.TabIndex = 66
        Me.GunaLabel8.Text = "School"
        '
        'TXT_B_SCHOOL_NAME
        '
        Me.TXT_B_SCHOOL_NAME.Animated = True
        Me.TXT_B_SCHOOL_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_B_SCHOOL_NAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_SCHOOL_NAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_SCHOOL_NAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_SCHOOL_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_SCHOOL_NAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_SCHOOL_NAME.LineSize = 2
        Me.TXT_B_SCHOOL_NAME.Location = New System.Drawing.Point(45, 401)
        Me.TXT_B_SCHOOL_NAME.Name = "TXT_B_SCHOOL_NAME"
        Me.TXT_B_SCHOOL_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_SCHOOL_NAME.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_SCHOOL_NAME.TabIndex = 64
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(188, 163)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(86, 16)
        Me.GunaLabel7.TabIndex = 65
        Me.GunaLabel7.Text = "Marital status"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(42, 163)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(51, 16)
        Me.GunaLabel5.TabIndex = 64
        Me.GunaLabel5.Text = "Gender"
        '
        'CBO_B_MARITAL_STATUS
        '
        Me.CBO_B_MARITAL_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.CBO_B_MARITAL_STATUS.BaseColor = System.Drawing.Color.White
        Me.CBO_B_MARITAL_STATUS.BorderColor = System.Drawing.Color.Silver
        Me.CBO_B_MARITAL_STATUS.BorderSize = 1
        Me.CBO_B_MARITAL_STATUS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_B_MARITAL_STATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_B_MARITAL_STATUS.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_B_MARITAL_STATUS.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_B_MARITAL_STATUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.CBO_B_MARITAL_STATUS.FormattingEnabled = True
        Me.CBO_B_MARITAL_STATUS.ItemHeight = 24
        Me.CBO_B_MARITAL_STATUS.Location = New System.Drawing.Point(191, 195)
        Me.CBO_B_MARITAL_STATUS.Name = "CBO_B_MARITAL_STATUS"
        Me.CBO_B_MARITAL_STATUS.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_B_MARITAL_STATUS.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_B_MARITAL_STATUS.Radius = 4
        Me.CBO_B_MARITAL_STATUS.Size = New System.Drawing.Size(171, 30)
        Me.CBO_B_MARITAL_STATUS.TabIndex = 60
        '
        'CBO_B_GENDER
        '
        Me.CBO_B_GENDER.BackColor = System.Drawing.Color.Transparent
        Me.CBO_B_GENDER.BaseColor = System.Drawing.Color.White
        Me.CBO_B_GENDER.BorderColor = System.Drawing.Color.Silver
        Me.CBO_B_GENDER.BorderSize = 1
        Me.CBO_B_GENDER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_B_GENDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_B_GENDER.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_B_GENDER.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_B_GENDER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.CBO_B_GENDER.FormattingEnabled = True
        Me.CBO_B_GENDER.ItemHeight = 24
        Me.CBO_B_GENDER.Location = New System.Drawing.Point(45, 195)
        Me.CBO_B_GENDER.Name = "CBO_B_GENDER"
        Me.CBO_B_GENDER.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_B_GENDER.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_B_GENDER.Radius = 4
        Me.CBO_B_GENDER.Size = New System.Drawing.Size(123, 30)
        Me.CBO_B_GENDER.TabIndex = 59
        '
        'TXT_B_FNAME
        '
        Me.TXT_B_FNAME.Animated = True
        Me.TXT_B_FNAME.BackColor = System.Drawing.Color.White
        Me.TXT_B_FNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_FNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_FNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_FNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_FNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_FNAME.LineSize = 2
        Me.TXT_B_FNAME.Location = New System.Drawing.Point(45, 45)
        Me.TXT_B_FNAME.Name = "TXT_B_FNAME"
        Me.TXT_B_FNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_FNAME.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_FNAME.TabIndex = 55
        '
        'TXT_B_CNUMBER
        '
        Me.TXT_B_CNUMBER.Animated = True
        Me.TXT_B_CNUMBER.BackColor = System.Drawing.Color.White
        Me.TXT_B_CNUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_CNUMBER.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_CNUMBER.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_CNUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_CNUMBER.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_CNUMBER.LineSize = 2
        Me.TXT_B_CNUMBER.Location = New System.Drawing.Point(392, 120)
        Me.TXT_B_CNUMBER.MaxLength = 11
        Me.TXT_B_CNUMBER.Name = "TXT_B_CNUMBER"
        Me.TXT_B_CNUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_CNUMBER.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_CNUMBER.TabIndex = 58
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(389, 16)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel2.TabIndex = 56
        Me.GunaLabel2.Text = "Lastname"
        '
        'TXT_B_LNAME
        '
        Me.TXT_B_LNAME.Animated = True
        Me.TXT_B_LNAME.BackColor = System.Drawing.Color.White
        Me.TXT_B_LNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_LNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_LNAME.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_LNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_LNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_LNAME.LineSize = 2
        Me.TXT_B_LNAME.Location = New System.Drawing.Point(392, 45)
        Me.TXT_B_LNAME.Name = "TXT_B_LNAME"
        Me.TXT_B_LNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_LNAME.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_LNAME.TabIndex = 56
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(389, 91)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(64, 16)
        Me.GunaLabel4.TabIndex = 60
        Me.GunaLabel4.Text = "Contact #"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(42, 16)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(65, 16)
        Me.GunaLabel6.TabIndex = 54
        Me.GunaLabel6.Text = "Firstname"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(42, 91)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(55, 16)
        Me.GunaLabel3.TabIndex = 58
        Me.GunaLabel3.Text = "Address"
        '
        'TXT_B_ADDRESS
        '
        Me.TXT_B_ADDRESS.Animated = True
        Me.TXT_B_ADDRESS.BackColor = System.Drawing.Color.White
        Me.TXT_B_ADDRESS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_B_ADDRESS.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_B_ADDRESS.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_ADDRESS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TXT_B_ADDRESS.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_B_ADDRESS.LineSize = 2
        Me.TXT_B_ADDRESS.Location = New System.Drawing.Point(45, 120)
        Me.TXT_B_ADDRESS.Name = "TXT_B_ADDRESS"
        Me.TXT_B_ADDRESS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_B_ADDRESS.Size = New System.Drawing.Size(317, 33)
        Me.TXT_B_ADDRESS.TabIndex = 57
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(48, 24)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(298, 23)
        Me.GunaLabel1.TabIndex = 75
        Me.GunaLabel1.Text = "Signup | Beneficiary Information"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(52, 54)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(729, 10)
        Me.GunaSeparator1.TabIndex = 74
        Me.GunaSeparator1.Thickness = 2
        '
        'frmAddBeneficiary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1017, 686)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddBeneficiary"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents TXT_B_FNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_ADDRESS As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_LNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents TXT_B_CNUMBER As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_SCHOOL_NAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CBO_B_MARITAL_STATUS As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents CBO_B_GENDER As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents RB_4TH As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RB_3RD As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RB_2ND As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RB_1ST As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_PASSWORD As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_USERNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_EMAIL As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_SCHOOL_ID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CBO_B_EC_RELATIONSHIP As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_EC_CNUMBER As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_EC_LNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_B_EC_FNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BTN_SUBMIT_BENEFICIARY As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_BACK As Guna.UI.WinForms.GunaAdvenceButton
End Class
