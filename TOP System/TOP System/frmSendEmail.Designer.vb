<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSendEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendEmail))
        Me.PNL_HEADER = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CLOSE_BEN_INFO_WINDOW = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.gmail_logo = New System.Windows.Forms.PictureBox()
        Me.PNL_BENEFICIARY = New Guna.UI.WinForms.GunaShadowPanel()
        Me.lbl_email_warning = New System.Windows.Forms.Label()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.BTN_SEND = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lbl_new_pass = New System.Windows.Forms.Label()
        Me.TXT_BEN_EMAIL = New Guna.UI.WinForms.GunaLineTextBox()
        Me.TXT_FROM = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PNL_HEADER.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gmail_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_BENEFICIARY.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL_HEADER
        '
        Me.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PNL_HEADER.Controls.Add(Me.PictureBox1)
        Me.PNL_HEADER.Controls.Add(Me.BTN_CLOSE_BEN_INFO_WINDOW)
        Me.PNL_HEADER.Controls.Add(Me.GunaLabel2)
        Me.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_HEADER.Location = New System.Drawing.Point(0, 0)
        Me.PNL_HEADER.Name = "PNL_HEADER"
        Me.PNL_HEADER.Size = New System.Drawing.Size(827, 46)
        Me.PNL_HEADER.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
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
        Me.BTN_CLOSE_BEN_INFO_WINDOW.Location = New System.Drawing.Point(784, 9)
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
        Me.GunaLabel2.Location = New System.Drawing.Point(41, 14)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(121, 16)
        Me.GunaLabel2.TabIndex = 53
        Me.GunaLabel2.Text = "Recover Password"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 6
        Me.GunaElipse1.TargetControl = Me
        '
        'gmail_logo
        '
        Me.gmail_logo.Image = CType(resources.GetObject("gmail_logo.Image"), System.Drawing.Image)
        Me.gmail_logo.Location = New System.Drawing.Point(90, 137)
        Me.gmail_logo.Name = "gmail_logo"
        Me.gmail_logo.Size = New System.Drawing.Size(120, 88)
        Me.gmail_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gmail_logo.TabIndex = 91
        Me.gmail_logo.TabStop = False
        '
        'PNL_BENEFICIARY
        '
        Me.PNL_BENEFICIARY.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PNL_BENEFICIARY.BackColor = System.Drawing.Color.Transparent
        Me.PNL_BENEFICIARY.BaseColor = System.Drawing.Color.White
        Me.PNL_BENEFICIARY.Controls.Add(Me.lbl_email_warning)
        Me.PNL_BENEFICIARY.Controls.Add(Me.GunaLabel4)
        Me.PNL_BENEFICIARY.Controls.Add(Me.BTN_SEND)
        Me.PNL_BENEFICIARY.Controls.Add(Me.lbl_new_pass)
        Me.PNL_BENEFICIARY.Controls.Add(Me.TXT_BEN_EMAIL)
        Me.PNL_BENEFICIARY.Location = New System.Drawing.Point(286, 86)
        Me.PNL_BENEFICIARY.Name = "PNL_BENEFICIARY"
        Me.PNL_BENEFICIARY.Radius = 3
        Me.PNL_BENEFICIARY.ShadowColor = System.Drawing.Color.DimGray
        Me.PNL_BENEFICIARY.ShadowDepth = 50
        Me.PNL_BENEFICIARY.ShadowShift = 4
        Me.PNL_BENEFICIARY.Size = New System.Drawing.Size(467, 299)
        Me.PNL_BENEFICIARY.TabIndex = 184
        '
        'lbl_email_warning
        '
        Me.lbl_email_warning.AutoSize = True
        Me.lbl_email_warning.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email_warning.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_email_warning.Image = CType(resources.GetObject("lbl_email_warning.Image"), System.Drawing.Image)
        Me.lbl_email_warning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_email_warning.Location = New System.Drawing.Point(70, 165)
        Me.lbl_email_warning.Name = "lbl_email_warning"
        Me.lbl_email_warning.Size = New System.Drawing.Size(276, 14)
        Me.lbl_email_warning.TabIndex = 190
        Me.lbl_email_warning.Text = "      Invalid email. Please check your email and try again."
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(70, 51)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(164, 18)
        Me.GunaLabel4.TabIndex = 189
        Me.GunaLabel4.Text = "Request for password"
        '
        'BTN_SEND
        '
        Me.BTN_SEND.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_SEND.Animated = True
        Me.BTN_SEND.AnimationHoverSpeed = 0.07!
        Me.BTN_SEND.AnimationSpeed = 0.03!
        Me.BTN_SEND.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SEND.BaseColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BTN_SEND.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SEND.BorderSize = 1
        Me.BTN_SEND.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_SEND.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SEND.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_SEND.CheckedImage = CType(resources.GetObject("BTN_SEND.CheckedImage"), System.Drawing.Image)
        Me.BTN_SEND.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_SEND.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_SEND.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_SEND.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SEND.ForeColor = System.Drawing.Color.White
        Me.BTN_SEND.Image = Nothing
        Me.BTN_SEND.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_SEND.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SEND.Location = New System.Drawing.Point(73, 202)
        Me.BTN_SEND.Name = "BTN_SEND"
        Me.BTN_SEND.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.BTN_SEND.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SEND.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_SEND.OnHoverImage = Nothing
        Me.BTN_SEND.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SEND.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_SEND.Radius = 5
        Me.BTN_SEND.Size = New System.Drawing.Size(305, 37)
        Me.BTN_SEND.TabIndex = 188
        Me.BTN_SEND.Text = "Send"
        Me.BTN_SEND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_new_pass
        '
        Me.lbl_new_pass.AutoSize = True
        Me.lbl_new_pass.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_pass.ForeColor = System.Drawing.Color.Teal
        Me.lbl_new_pass.Location = New System.Drawing.Point(70, 98)
        Me.lbl_new_pass.Name = "lbl_new_pass"
        Me.lbl_new_pass.Size = New System.Drawing.Size(42, 16)
        Me.lbl_new_pass.TabIndex = 185
        Me.lbl_new_pass.Text = "Email"
        '
        'TXT_BEN_EMAIL
        '
        Me.TXT_BEN_EMAIL.Animated = True
        Me.TXT_BEN_EMAIL.BackColor = System.Drawing.Color.White
        Me.TXT_BEN_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BEN_EMAIL.FocusedLineColor = System.Drawing.Color.RoyalBlue
        Me.TXT_BEN_EMAIL.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BEN_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_BEN_EMAIL.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_BEN_EMAIL.LineSize = 2
        Me.TXT_BEN_EMAIL.Location = New System.Drawing.Point(73, 126)
        Me.TXT_BEN_EMAIL.Name = "TXT_BEN_EMAIL"
        Me.TXT_BEN_EMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BEN_EMAIL.Size = New System.Drawing.Size(305, 33)
        Me.TXT_BEN_EMAIL.TabIndex = 184
        '
        'TXT_FROM
        '
        Me.TXT_FROM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_FROM.BackColor = System.Drawing.Color.Transparent
        Me.TXT_FROM.BaseColor = System.Drawing.Color.White
        Me.TXT_FROM.BorderColor = System.Drawing.Color.Silver
        Me.TXT_FROM.BorderSize = 1
        Me.TXT_FROM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_FROM.Enabled = False
        Me.TXT_FROM.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_FROM.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_FROM.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_FROM.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROM.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXT_FROM.Location = New System.Drawing.Point(55, 275)
        Me.TXT_FROM.Name = "TXT_FROM"
        Me.TXT_FROM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_FROM.Radius = 15
        Me.TXT_FROM.Size = New System.Drawing.Size(186, 30)
        Me.TXT_FROM.TabIndex = 191
        Me.TXT_FROM.Text = "topefas20@gmail.com"
        Me.TXT_FROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_FROM.TextOffsetX = 10
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(118, 242)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(79, 18)
        Me.GunaLabel1.TabIndex = 190
        Me.GunaLabel1.Text = "TOP EFAS"
        '
        'frmSendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(827, 445)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TXT_FROM)
        Me.Controls.Add(Me.PNL_BENEFICIARY)
        Me.Controls.Add(Me.gmail_logo)
        Me.Controls.Add(Me.PNL_HEADER)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSendEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PNL_HEADER.ResumeLayout(False)
        Me.PNL_HEADER.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gmail_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_BENEFICIARY.ResumeLayout(False)
        Me.PNL_BENEFICIARY.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL_HEADER As Panel
    Friend WithEvents BTN_CLOSE_BEN_INFO_WINDOW As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gmail_logo As PictureBox
    Friend WithEvents PNL_BENEFICIARY As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents lbl_new_pass As Label
    Friend WithEvents TXT_BEN_EMAIL As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BTN_SEND As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_FROM As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lbl_email_warning As Label
End Class
