<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBeneficiaryHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeneficiaryHome))
        Me.pnl_BenMain = New Guna.UI.WinForms.GunaShadowPanel()
        Me.pnl_ben_account = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_Edit_Beneficiary = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_Add_Beneficiary = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.pnl_BenMain.SuspendLayout()
        Me.pnl_ben_account.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GunaShadowPanel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_BenMain
        '
        Me.pnl_BenMain.BackColor = System.Drawing.Color.Transparent
        Me.pnl_BenMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_BenMain.Controls.Add(Me.pnl_ben_account)
        Me.pnl_BenMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_BenMain.Location = New System.Drawing.Point(0, 55)
        Me.pnl_BenMain.Name = "pnl_BenMain"
        Me.pnl_BenMain.Radius = 2
        Me.pnl_BenMain.ShadowColor = System.Drawing.Color.Black
        Me.pnl_BenMain.ShadowDepth = 20
        Me.pnl_BenMain.ShadowShift = 1
        Me.pnl_BenMain.Size = New System.Drawing.Size(916, 517)
        Me.pnl_BenMain.TabIndex = 6
        '
        'pnl_ben_account
        '
        Me.pnl_ben_account.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_ben_account.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_ben_account.Controls.Add(Me.Panel1)
        Me.pnl_ben_account.Location = New System.Drawing.Point(3, 6)
        Me.pnl_ben_account.Name = "pnl_ben_account"
        Me.pnl_ben_account.Size = New System.Drawing.Size(910, 494)
        Me.pnl_ben_account.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel3)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel2)
        Me.Panel1.Location = New System.Drawing.Point(15, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 475)
        Me.Panel1.TabIndex = 2
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel3.Controls.Add(Me.btn_Edit_Beneficiary)
        Me.GunaShadowPanel3.Controls.Add(Me.GunaLabel3)
        Me.GunaShadowPanel3.Controls.Add(Me.PictureBox2)
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(442, 28)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.Radius = 3
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Teal
        Me.GunaShadowPanel3.ShadowDepth = 50
        Me.GunaShadowPanel3.ShadowShift = 4
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(337, 330)
        Me.GunaShadowPanel3.TabIndex = 7
        '
        'btn_Edit_Beneficiary
        '
        Me.btn_Edit_Beneficiary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Edit_Beneficiary.Animated = True
        Me.btn_Edit_Beneficiary.AnimationHoverSpeed = 0.07!
        Me.btn_Edit_Beneficiary.AnimationSpeed = 0.03!
        Me.btn_Edit_Beneficiary.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit_Beneficiary.BaseColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Edit_Beneficiary.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Edit_Beneficiary.BorderSize = 1
        Me.btn_Edit_Beneficiary.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_Edit_Beneficiary.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Edit_Beneficiary.CheckedForeColor = System.Drawing.Color.White
        Me.btn_Edit_Beneficiary.CheckedImage = CType(resources.GetObject("btn_Edit_Beneficiary.CheckedImage"), System.Drawing.Image)
        Me.btn_Edit_Beneficiary.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_Edit_Beneficiary.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Edit_Beneficiary.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Edit_Beneficiary.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit_Beneficiary.ForeColor = System.Drawing.Color.White
        Me.btn_Edit_Beneficiary.Image = Nothing
        Me.btn_Edit_Beneficiary.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_Edit_Beneficiary.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Edit_Beneficiary.Location = New System.Drawing.Point(132, 212)
        Me.btn_Edit_Beneficiary.Name = "btn_Edit_Beneficiary"
        Me.btn_Edit_Beneficiary.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_Edit_Beneficiary.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Edit_Beneficiary.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Edit_Beneficiary.OnHoverImage = Nothing
        Me.btn_Edit_Beneficiary.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Edit_Beneficiary.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Edit_Beneficiary.Radius = 5
        Me.btn_Edit_Beneficiary.Size = New System.Drawing.Size(76, 29)
        Me.btn_Edit_Beneficiary.TabIndex = 0
        Me.btn_Edit_Beneficiary.Text = "Edit"
        Me.btn_Edit_Beneficiary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(58, 160)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(221, 16)
        Me.GunaLabel3.TabIndex = 6
        Me.GunaLabel3.Text = "Edit existing beneficiary's information"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(125, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.btn_Add_Beneficiary)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel2.Controls.Add(Me.PictureBox1)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(88, 28)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 3
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Teal
        Me.GunaShadowPanel2.ShadowDepth = 50
        Me.GunaShadowPanel2.ShadowShift = 4
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(337, 330)
        Me.GunaShadowPanel2.TabIndex = 1
        '
        'btn_Add_Beneficiary
        '
        Me.btn_Add_Beneficiary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Add_Beneficiary.Animated = True
        Me.btn_Add_Beneficiary.AnimationHoverSpeed = 0.07!
        Me.btn_Add_Beneficiary.AnimationSpeed = 0.03!
        Me.btn_Add_Beneficiary.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_Beneficiary.BaseColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Add_Beneficiary.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Add_Beneficiary.BorderSize = 1
        Me.btn_Add_Beneficiary.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_Add_Beneficiary.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Add_Beneficiary.CheckedForeColor = System.Drawing.Color.White
        Me.btn_Add_Beneficiary.CheckedImage = CType(resources.GetObject("btn_Add_Beneficiary.CheckedImage"), System.Drawing.Image)
        Me.btn_Add_Beneficiary.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_Add_Beneficiary.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Add_Beneficiary.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Add_Beneficiary.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_Beneficiary.ForeColor = System.Drawing.Color.White
        Me.btn_Add_Beneficiary.Image = Nothing
        Me.btn_Add_Beneficiary.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_Add_Beneficiary.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Add_Beneficiary.Location = New System.Drawing.Point(127, 212)
        Me.btn_Add_Beneficiary.Name = "btn_Add_Beneficiary"
        Me.btn_Add_Beneficiary.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_Add_Beneficiary.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Add_Beneficiary.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Add_Beneficiary.OnHoverImage = Nothing
        Me.btn_Add_Beneficiary.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Add_Beneficiary.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Add_Beneficiary.Radius = 5
        Me.btn_Add_Beneficiary.Size = New System.Drawing.Size(76, 29)
        Me.btn_Add_Beneficiary.TabIndex = 0
        Me.btn_Add_Beneficiary.Text = "Add"
        Me.btn_Add_Beneficiary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(105, 160)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(125, 16)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "Add new beneficiary"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(123, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.SeaGreen
        Me.GunaLabel5.Location = New System.Drawing.Point(34, 20)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(88, 18)
        Me.GunaLabel5.TabIndex = 2
        Me.GunaLabel5.Text = "Beneficiary"
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
        Me.GunaShadowPanel1.ShadowDepth = 15
        Me.GunaShadowPanel1.ShadowShift = 4
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(916, 55)
        Me.GunaShadowPanel1.TabIndex = 5
        '
        'frmBeneficiaryHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(916, 572)
        Me.Controls.Add(Me.pnl_BenMain)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBeneficiaryHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMyAccount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_BenMain.ResumeLayout(False)
        Me.pnl_ben_account.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GunaShadowPanel3.ResumeLayout(False)
        Me.GunaShadowPanel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_BenMain As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents pnl_ben_account As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_Edit_Beneficiary As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_Add_Beneficiary As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
