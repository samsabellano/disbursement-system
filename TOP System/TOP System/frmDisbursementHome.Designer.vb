<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDisbursementHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisbursementHome))
        Me.Ttip_AddBeneficiary = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl_BenMain = New Guna.UI.WinForms.GunaShadowPanel()
        Me.pnl_frmHolder_Ben = New Guna.UI.WinForms.GunaGradientPanel()
        Me.pnl_pnlFormHolder = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_search_beneficiary = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_search_beneficiary = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.pnl_BenMain.SuspendLayout()
        Me.pnl_frmHolder_Ben.SuspendLayout()
        Me.pnl_pnlFormHolder.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ttip_AddBeneficiary
        '
        Me.Ttip_AddBeneficiary.AutoPopDelay = 5000
        Me.Ttip_AddBeneficiary.BackColor = System.Drawing.SystemColors.Highlight
        Me.Ttip_AddBeneficiary.ForeColor = System.Drawing.Color.White
        Me.Ttip_AddBeneficiary.InitialDelay = 300
        Me.Ttip_AddBeneficiary.IsBalloon = True
        Me.Ttip_AddBeneficiary.OwnerDraw = True
        Me.Ttip_AddBeneficiary.ReshowDelay = 100
        '
        'pnl_BenMain
        '
        Me.pnl_BenMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_BenMain.BackColor = System.Drawing.Color.Transparent
        Me.pnl_BenMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_BenMain.Controls.Add(Me.pnl_frmHolder_Ben)
        Me.pnl_BenMain.Location = New System.Drawing.Point(0, 53)
        Me.pnl_BenMain.Name = "pnl_BenMain"
        Me.pnl_BenMain.Radius = 2
        Me.pnl_BenMain.ShadowColor = System.Drawing.Color.Black
        Me.pnl_BenMain.ShadowDepth = 20
        Me.pnl_BenMain.Size = New System.Drawing.Size(886, 521)
        Me.pnl_BenMain.TabIndex = 3
        '
        'pnl_frmHolder_Ben
        '
        Me.pnl_frmHolder_Ben.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_frmHolder_Ben.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_frmHolder_Ben.BackgroundImage = CType(resources.GetObject("pnl_frmHolder_Ben.BackgroundImage"), System.Drawing.Image)
        Me.pnl_frmHolder_Ben.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_frmHolder_Ben.Controls.Add(Me.pnl_pnlFormHolder)
        Me.pnl_frmHolder_Ben.GradientColor1 = System.Drawing.Color.Gainsboro
        Me.pnl_frmHolder_Ben.GradientColor2 = System.Drawing.Color.White
        Me.pnl_frmHolder_Ben.GradientColor3 = System.Drawing.Color.White
        Me.pnl_frmHolder_Ben.GradientColor4 = System.Drawing.Color.White
        Me.pnl_frmHolder_Ben.Location = New System.Drawing.Point(11, 16)
        Me.pnl_frmHolder_Ben.Name = "pnl_frmHolder_Ben"
        Me.pnl_frmHolder_Ben.Size = New System.Drawing.Size(862, 491)
        Me.pnl_frmHolder_Ben.TabIndex = 0
        Me.pnl_frmHolder_Ben.Text = "GunaGradientPanel1"
        '
        'pnl_pnlFormHolder
        '
        Me.pnl_pnlFormHolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_pnlFormHolder.Controls.Add(Me.GunaShadowPanel2)
        Me.pnl_pnlFormHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_pnlFormHolder.Location = New System.Drawing.Point(0, 0)
        Me.pnl_pnlFormHolder.Name = "pnl_pnlFormHolder"
        Me.pnl_pnlFormHolder.Size = New System.Drawing.Size(862, 491)
        Me.pnl_pnlFormHolder.TabIndex = 1
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.PictureBox1)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel2.Controls.Add(Me.Panel2)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel4)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel2)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(127, 25)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 3
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel2.ShadowDepth = 50
        Me.GunaShadowPanel2.ShadowShift = 6
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(596, 367)
        Me.GunaShadowPanel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(67, 197)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(64, 73)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(205, 16)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Search beneficiary by School ID."
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btn_search_beneficiary)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(67, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 39)
        Me.Panel2.TabIndex = 1
        '
        'btn_search_beneficiary
        '
        Me.btn_search_beneficiary.AnimationHoverSpeed = 0.07!
        Me.btn_search_beneficiary.AnimationSpeed = 0.03!
        Me.btn_search_beneficiary.BackColor = System.Drawing.Color.Transparent
        Me.btn_search_beneficiary.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btn_search_beneficiary.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_search_beneficiary.BorderSize = 1
        Me.btn_search_beneficiary.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_search_beneficiary.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_search_beneficiary.CheckedForeColor = System.Drawing.Color.White
        Me.btn_search_beneficiary.CheckedImage = CType(resources.GetObject("btn_search_beneficiary.CheckedImage"), System.Drawing.Image)
        Me.btn_search_beneficiary.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_search_beneficiary.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_search_beneficiary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_search_beneficiary.FocusedColor = System.Drawing.Color.Empty
        Me.btn_search_beneficiary.Font = New System.Drawing.Font("SF Pro Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_beneficiary.ForeColor = System.Drawing.Color.White
        Me.btn_search_beneficiary.Image = CType(resources.GetObject("btn_search_beneficiary.Image"), System.Drawing.Image)
        Me.btn_search_beneficiary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_search_beneficiary.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_search_beneficiary.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_search_beneficiary.Location = New System.Drawing.Point(398, 0)
        Me.btn_search_beneficiary.Name = "btn_search_beneficiary"
        Me.btn_search_beneficiary.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btn_search_beneficiary.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.btn_search_beneficiary.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_search_beneficiary.OnHoverImage = Nothing
        Me.btn_search_beneficiary.OnHoverLineColor = System.Drawing.Color.Gainsboro
        Me.btn_search_beneficiary.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btn_search_beneficiary.Radius = 2
        Me.btn_search_beneficiary.Size = New System.Drawing.Size(69, 39)
        Me.btn_search_beneficiary.TabIndex = 2
        Me.btn_search_beneficiary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_search_beneficiary)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(398, 39)
        Me.Panel3.TabIndex = 1
        '
        'txt_search_beneficiary
        '
        Me.txt_search_beneficiary.BackColor = System.Drawing.Color.Transparent
        Me.txt_search_beneficiary.BaseColor = System.Drawing.Color.White
        Me.txt_search_beneficiary.BorderColor = System.Drawing.Color.Gainsboro
        Me.txt_search_beneficiary.BorderSize = 1
        Me.txt_search_beneficiary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search_beneficiary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_search_beneficiary.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_search_beneficiary.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.txt_search_beneficiary.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_search_beneficiary.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_beneficiary.ForeColor = System.Drawing.Color.Gray
        Me.txt_search_beneficiary.Location = New System.Drawing.Point(0, 0)
        Me.txt_search_beneficiary.MaxLength = 500
        Me.txt_search_beneficiary.Name = "txt_search_beneficiary"
        Me.txt_search_beneficiary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search_beneficiary.Radius = 2
        Me.txt_search_beneficiary.Size = New System.Drawing.Size(398, 39)
        Me.txt_search_beneficiary.TabIndex = 0
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(134, 265)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(73, 16)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "Thank you!"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(134, 232)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(318, 16)
        Me.GunaLabel3.TabIndex = 4
        Me.GunaLabel3.Text = "We recommend to search the beneficiary's School ID."
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Nova", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(134, 200)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(183, 20)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Beneficiary is secured!"
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 2
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 20
        Me.GunaShadowPanel1.ShadowShift = 4
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(889, 55)
        Me.GunaShadowPanel1.TabIndex = 4
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.SeaGreen
        Me.GunaLabel5.Location = New System.Drawing.Point(34, 20)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(108, 18)
        Me.GunaLabel5.TabIndex = 1
        Me.GunaLabel5.Text = "Disbursement"
        '
        'frmDisbursementHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(889, 579)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.pnl_BenMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDisbursementHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBeneficiary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_BenMain.ResumeLayout(False)
        Me.pnl_frmHolder_Ben.ResumeLayout(False)
        Me.pnl_pnlFormHolder.ResumeLayout(False)
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ttip_AddBeneficiary As ToolTip
    Friend WithEvents pnl_BenMain As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents pnl_frmHolder_Ben As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents pnl_pnlFormHolder As Panel
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_search_beneficiary As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_search_beneficiary As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
End Class
