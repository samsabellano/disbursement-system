<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoanReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoanReturn))
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.PNL_LOAN_HOLDER = New Guna.UI.WinForms.GunaShadowPanel()
        Me.pnl_frmHolder_Ben = New Guna.UI.WinForms.GunaGradientPanel()
        Me.pnl_pnlFormHolder = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.BTN_SEARCH_TO_RETURN_LOAN = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TXT_SEARCH_BEN_ID_4RETURN = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.PNL_LOAN_HOLDER.SuspendLayout()
        Me.pnl_frmHolder_Ben.SuspendLayout()
        Me.pnl_pnlFormHolder.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel1.ShadowDepth = 20
        Me.GunaShadowPanel1.ShadowShift = 4
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(947, 55)
        Me.GunaShadowPanel1.TabIndex = 5
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.SeaGreen
        Me.GunaLabel5.Location = New System.Drawing.Point(34, 20)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(94, 18)
        Me.GunaLabel5.TabIndex = 1
        Me.GunaLabel5.Text = "Loan Return"
        '
        'PNL_LOAN_HOLDER
        '
        Me.PNL_LOAN_HOLDER.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_LOAN_HOLDER.BackColor = System.Drawing.Color.Transparent
        Me.PNL_LOAN_HOLDER.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PNL_LOAN_HOLDER.Controls.Add(Me.pnl_frmHolder_Ben)
        Me.PNL_LOAN_HOLDER.Location = New System.Drawing.Point(0, 52)
        Me.PNL_LOAN_HOLDER.Name = "PNL_LOAN_HOLDER"
        Me.PNL_LOAN_HOLDER.Radius = 2
        Me.PNL_LOAN_HOLDER.ShadowColor = System.Drawing.Color.Black
        Me.PNL_LOAN_HOLDER.ShadowDepth = 20
        Me.PNL_LOAN_HOLDER.ShadowShift = 3
        Me.PNL_LOAN_HOLDER.Size = New System.Drawing.Size(947, 511)
        Me.PNL_LOAN_HOLDER.TabIndex = 6
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
        Me.pnl_frmHolder_Ben.Size = New System.Drawing.Size(923, 481)
        Me.pnl_frmHolder_Ben.TabIndex = 0
        Me.pnl_frmHolder_Ben.Text = "GunaGradientPanel1"
        '
        'pnl_pnlFormHolder
        '
        Me.pnl_pnlFormHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_pnlFormHolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_pnlFormHolder.Controls.Add(Me.GunaShadowPanel2)
        Me.pnl_pnlFormHolder.Location = New System.Drawing.Point(0, 0)
        Me.pnl_pnlFormHolder.Name = "pnl_pnlFormHolder"
        Me.pnl_pnlFormHolder.Size = New System.Drawing.Size(923, 481)
        Me.pnl_pnlFormHolder.TabIndex = 1
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel2)
        Me.GunaShadowPanel2.Controls.Add(Me.PictureBox1)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaVSeparator1)
        Me.GunaShadowPanel2.Controls.Add(Me.BTN_SEARCH_TO_RETURN_LOAN)
        Me.GunaShadowPanel2.Controls.Add(Me.TXT_SEARCH_BEN_ID_4RETURN)
        Me.GunaShadowPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(109, 56)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 3
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel2.ShadowDepth = 50
        Me.GunaShadowPanel2.ShadowShift = 6
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(698, 370)
        Me.GunaShadowPanel2.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(431, 246)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(171, 15)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "Search by Acct. No.(School ID)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaVSeparator1.Location = New System.Drawing.Point(349, 40)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 289)
        Me.GunaVSeparator1.TabIndex = 4
        '
        'BTN_SEARCH_TO_RETURN_LOAN
        '
        Me.BTN_SEARCH_TO_RETURN_LOAN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_SEARCH_TO_RETURN_LOAN.AnimationHoverSpeed = 0.07!
        Me.BTN_SEARCH_TO_RETURN_LOAN.AnimationSpeed = 0.03!
        Me.BTN_SEARCH_TO_RETURN_LOAN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SEARCH_TO_RETURN_LOAN.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_SEARCH_TO_RETURN_LOAN.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SEARCH_TO_RETURN_LOAN.BorderSize = 1
        Me.BTN_SEARCH_TO_RETURN_LOAN.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_SEARCH_TO_RETURN_LOAN.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SEARCH_TO_RETURN_LOAN.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_SEARCH_TO_RETURN_LOAN.CheckedImage = CType(resources.GetObject("BTN_SEARCH_TO_RETURN_LOAN.CheckedImage"), System.Drawing.Image)
        Me.BTN_SEARCH_TO_RETURN_LOAN.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_SEARCH_TO_RETURN_LOAN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_SEARCH_TO_RETURN_LOAN.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_SEARCH_TO_RETURN_LOAN.Font = New System.Drawing.Font("Arial Nova", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SEARCH_TO_RETURN_LOAN.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_SEARCH_TO_RETURN_LOAN.Image = CType(resources.GetObject("BTN_SEARCH_TO_RETURN_LOAN.Image"), System.Drawing.Image)
        Me.BTN_SEARCH_TO_RETURN_LOAN.ImageSize = New System.Drawing.Size(15, 15)
        Me.BTN_SEARCH_TO_RETURN_LOAN.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SEARCH_TO_RETURN_LOAN.Location = New System.Drawing.Point(460, 167)
        Me.BTN_SEARCH_TO_RETURN_LOAN.Name = "BTN_SEARCH_TO_RETURN_LOAN"
        Me.BTN_SEARCH_TO_RETURN_LOAN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTN_SEARCH_TO_RETURN_LOAN.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.BTN_SEARCH_TO_RETURN_LOAN.OnHoverForeColor = System.Drawing.Color.Teal
        Me.BTN_SEARCH_TO_RETURN_LOAN.OnHoverImage = Nothing
        Me.BTN_SEARCH_TO_RETURN_LOAN.OnHoverLineColor = System.Drawing.Color.Gainsboro
        Me.BTN_SEARCH_TO_RETURN_LOAN.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTN_SEARCH_TO_RETURN_LOAN.Radius = 2
        Me.BTN_SEARCH_TO_RETURN_LOAN.Size = New System.Drawing.Size(110, 31)
        Me.BTN_SEARCH_TO_RETURN_LOAN.TabIndex = 2
        Me.BTN_SEARCH_TO_RETURN_LOAN.Text = "    Search"
        Me.BTN_SEARCH_TO_RETURN_LOAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_SEARCH_BEN_ID_4RETURN
        '
        Me.TXT_SEARCH_BEN_ID_4RETURN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_SEARCH_BEN_ID_4RETURN.Animated = True
        Me.TXT_SEARCH_BEN_ID_4RETURN.BackColor = System.Drawing.Color.White
        Me.TXT_SEARCH_BEN_ID_4RETURN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_SEARCH_BEN_ID_4RETURN.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_SEARCH_BEN_ID_4RETURN.Font = New System.Drawing.Font("Arial Nova", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SEARCH_BEN_ID_4RETURN.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXT_SEARCH_BEN_ID_4RETURN.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_SEARCH_BEN_ID_4RETURN.Location = New System.Drawing.Point(434, 98)
        Me.TXT_SEARCH_BEN_ID_4RETURN.MaxLength = 9
        Me.TXT_SEARCH_BEN_ID_4RETURN.Name = "TXT_SEARCH_BEN_ID_4RETURN"
        Me.TXT_SEARCH_BEN_ID_4RETURN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_SEARCH_BEN_ID_4RETURN.Size = New System.Drawing.Size(168, 46)
        Me.TXT_SEARCH_BEN_ID_4RETURN.TabIndex = 3
        Me.TXT_SEARCH_BEN_ID_4RETURN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(99, 246)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(157, 15)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Search an active beneficiary"
        '
        'frmLoanReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 562)
        Me.Controls.Add(Me.PNL_LOAN_HOLDER)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoanReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoanReturn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.PNL_LOAN_HOLDER.ResumeLayout(False)
        Me.pnl_frmHolder_Ben.ResumeLayout(False)
        Me.pnl_pnlFormHolder.ResumeLayout(False)
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PNL_LOAN_HOLDER As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents pnl_frmHolder_Ben As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents pnl_pnlFormHolder As Panel
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTN_SEARCH_TO_RETURN_LOAN As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TXT_SEARCH_BEN_ID_4RETURN As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
End Class
