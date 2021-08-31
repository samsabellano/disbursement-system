<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnl_Login = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.link_forgot_password = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaCirclePictureBox4 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_uname = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btn_Login = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.txt_password = New Guna.UI.WinForms.GunaTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_login_date = New System.Windows.Forms.Label()
        Me.lbl_login_time = New System.Windows.Forms.Label()
        Me.pnl_Login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_Login
        '
        Me.pnl_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_Login.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Login.BaseColor = System.Drawing.Color.White
        Me.pnl_Login.Controls.Add(Me.PictureBox1)
        Me.pnl_Login.Controls.Add(Me.link_forgot_password)
        Me.pnl_Login.Controls.Add(Me.Panel1)
        Me.pnl_Login.Controls.Add(Me.Label4)
        Me.pnl_Login.Controls.Add(Me.Label5)
        Me.pnl_Login.Controls.Add(Me.Label7)
        Me.pnl_Login.Controls.Add(Me.GunaLabel4)
        Me.pnl_Login.Controls.Add(Me.GunaLabel1)
        Me.pnl_Login.Controls.Add(Me.txt_uname)
        Me.pnl_Login.Controls.Add(Me.Panel3)
        Me.pnl_Login.Controls.Add(Me.btn_Login)
        Me.pnl_Login.Controls.Add(Me.Panel4)
        Me.pnl_Login.Controls.Add(Me.txt_password)
        Me.pnl_Login.Location = New System.Drawing.Point(146, 47)
        Me.pnl_Login.Name = "pnl_Login"
        Me.pnl_Login.Radius = 8
        Me.pnl_Login.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_Login.ShadowDepth = 80
        Me.pnl_Login.ShadowShift = 7
        Me.pnl_Login.Size = New System.Drawing.Size(474, 545)
        Me.pnl_Login.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(192, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'link_forgot_password
        '
        Me.link_forgot_password.AutoSize = True
        Me.link_forgot_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_forgot_password.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.link_forgot_password.Location = New System.Drawing.Point(178, 489)
        Me.link_forgot_password.Name = "link_forgot_password"
        Me.link_forgot_password.Size = New System.Drawing.Size(116, 16)
        Me.link_forgot_password.TabIndex = 0
        Me.link_forgot_password.TabStop = True
        Me.link_forgot_password.Text = "Forgot password?"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GunaCirclePictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(364, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(36, 26)
        Me.Panel1.TabIndex = 49
        '
        'GunaCirclePictureBox4
        '
        Me.GunaCirclePictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaCirclePictureBox4.Image = CType(resources.GetObject("GunaCirclePictureBox4.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox4.Location = New System.Drawing.Point(10, 0)
        Me.GunaCirclePictureBox4.Name = "GunaCirclePictureBox4"
        Me.GunaCirclePictureBox4.Size = New System.Drawing.Size(26, 26)
        Me.GunaCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox4.TabIndex = 0
        Me.GunaCirclePictureBox4.TabStop = False
        Me.GunaCirclePictureBox4.UseTransfarantBackground = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(164, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "492 South St. DBP Village"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(184, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Ma-a, Davao City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(146, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 18)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Tabernacle of Philippines"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Teal
        Me.GunaLabel4.Location = New System.Drawing.Point(73, 234)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(109, 16)
        Me.GunaLabel4.TabIndex = 54
        Me.GunaLabel4.Text = "Email/Username"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Teal
        Me.GunaLabel1.Location = New System.Drawing.Point(73, 316)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(68, 16)
        Me.GunaLabel1.TabIndex = 55
        Me.GunaLabel1.Text = "Password"
        '
        'txt_uname
        '
        Me.txt_uname.BackColor = System.Drawing.Color.Transparent
        Me.txt_uname.BaseColor = System.Drawing.Color.White
        Me.txt_uname.BorderColor = System.Drawing.Color.Gainsboro
        Me.txt_uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_uname.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_uname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_uname.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_uname.Location = New System.Drawing.Point(71, 260)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_uname.Radius = 7
        Me.txt_uname.Size = New System.Drawing.Size(333, 36)
        Me.txt_uname.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(360, 265)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(36, 26)
        Me.Panel3.TabIndex = 49
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(10, 0)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 0
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'btn_Login
        '
        Me.btn_Login.Animated = True
        Me.btn_Login.AnimationHoverSpeed = 0.07!
        Me.btn_Login.AnimationSpeed = 0.03!
        Me.btn_Login.BackColor = System.Drawing.Color.Transparent
        Me.btn_Login.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btn_Login.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Login.BorderSize = 1
        Me.btn_Login.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_Login.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_Login.CheckedForeColor = System.Drawing.Color.White
        Me.btn_Login.CheckedImage = CType(resources.GetObject("btn_Login.CheckedImage"), System.Drawing.Image)
        Me.btn_Login.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_Login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Login.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.ForeColor = System.Drawing.Color.White
        Me.btn_Login.Image = Nothing
        Me.btn_Login.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Login.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Login.Location = New System.Drawing.Point(71, 403)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_Login.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Login.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Login.OnHoverImage = Nothing
        Me.btn_Login.OnHoverLineColor = System.Drawing.Color.LightGray
        Me.btn_Login.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Login.Radius = 7
        Me.btn_Login.Size = New System.Drawing.Size(333, 39)
        Me.btn_Login.TabIndex = 3
        Me.btn_Login.Text = "Login"
        Me.btn_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(364, 347)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(36, 26)
        Me.Panel4.TabIndex = 50
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(10, 0)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 0
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Transparent
        Me.txt_password.BaseColor = System.Drawing.Color.White
        Me.txt_password.BorderColor = System.Drawing.Color.Gainsboro
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_password.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(71, 342)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.Radius = 7
        Me.txt_password.Size = New System.Drawing.Size(333, 36)
        Me.txt_password.TabIndex = 2
        Me.txt_password.UseSystemPasswordChar = True
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.MintCream
        Me.GunaLabel3.Location = New System.Drawing.Point(4, 10)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(51, 19)
        Me.GunaLabel3.TabIndex = 61
        Me.GunaLabel3.Text = "Press ["
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GunaLabel5.Location = New System.Drawing.Point(50, 8)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(40, 22)
        Me.GunaLabel5.TabIndex = 62
        Me.GunaLabel5.Text = "Esc"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.MintCream
        Me.GunaLabel6.Location = New System.Drawing.Point(83, 10)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(55, 19)
        Me.GunaLabel6.TabIndex = 63
        Me.GunaLabel6.Text = "] to exit"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.GunaLabel6)
        Me.Panel2.Controls.Add(Me.GunaLabel3)
        Me.Panel2.Controls.Add(Me.GunaLabel5)
        Me.Panel2.Location = New System.Drawing.Point(12, 625)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(145, 39)
        Me.Panel2.TabIndex = 64
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.lbl_login_date)
        Me.Panel5.Controls.Add(Me.lbl_login_time)
        Me.Panel5.Location = New System.Drawing.Point(578, 587)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(172, 75)
        Me.Panel5.TabIndex = 65
        '
        'lbl_login_date
        '
        Me.lbl_login_date.AutoSize = True
        Me.lbl_login_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_date.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_login_date.Location = New System.Drawing.Point(18, 52)
        Me.lbl_login_date.Name = "lbl_login_date"
        Me.lbl_login_date.Size = New System.Drawing.Size(39, 18)
        Me.lbl_login_date.TabIndex = 28
        Me.lbl_login_date.Text = "Date"
        '
        'lbl_login_time
        '
        Me.lbl_login_time.AutoSize = True
        Me.lbl_login_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_time.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_login_time.Location = New System.Drawing.Point(16, 8)
        Me.lbl_login_time.Name = "lbl_login_time"
        Me.lbl_login_time.Size = New System.Drawing.Size(81, 33)
        Me.lbl_login_time.TabIndex = 27
        Me.lbl_login_time.Text = "Time"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 676)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_Login.ResumeLayout(False)
        Me.pnl_Login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_Login As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_uname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btn_Login As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents txt_password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaCirclePictureBox4 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents link_forgot_password As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_login_date As Label
    Friend WithEvents lbl_login_time As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
