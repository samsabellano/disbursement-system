<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDisbursement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisbursement))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_BenMain = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lb_benef_full_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_STUD_ID = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PNL_DISBURSE = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel7 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.LBL_LEAVE_PERMITNUM_BLANK = New System.Windows.Forms.Label()
        Me.BTN_SUBMIT_DISBURSEMENT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.CBO_GET_PURPOSE = New Guna.UI.WinForms.GunaComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBO_GET_CONTRACT_ID = New Guna.UI.WinForms.GunaComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_NEW_PERMIT_NUMBER = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_NEW_DISBURSE_AMOUNT = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel6 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.PNL_CURRENT_DISB_AMOUNT = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.LBL_GET_CURRENT_DISB_AMOUNT = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LBL_GET_DATE = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.LBL_ADMIN_NAME = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.LBL_GET_TOTAL_DISBURSED = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PNL_DISBURSEMENT_LOGIN = New Guna.UI.WinForms.GunaPanel()
        Me.GunaShadowPanel5 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.LBL_ENTER_B_PASS = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_dsbursement_ben_login = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txt_disbursement_ben_pass = New Guna.UI.WinForms.GunaTextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PNL_UPDATE_PERMIT = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.BTN_UPDATE_PERMIT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBO_NO_PERMIT_CONT_ID = New Guna.UI.WinForms.GunaComboBox()
        Me.TXT_UPDATE_PERMIT_NUMBER = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_exit_account = New Guna.UI.WinForms.GunaCircleButton()
        Me.beneficiary_animatedWindow = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.tool_tip_exit = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_disburse_amount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.cbo_purpose = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_disburse_amount = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_permit_no = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_amount_to_disburse = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cbo_purpose_of_money = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_submit_disburse = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_contract_id = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaShadowPanel4 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_total_disburse_amount = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_get_admin_fullname = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.pnl_current_disbursed_amount = New System.Windows.Forms.Panel()
        Me.label = New System.Windows.Forms.Label()
        Me.lbl_current_disbursed_amount = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.txt_dsbrsment_bpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_go = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_attention_bname = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_search_beneficiary = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_Add_Beneficiary = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1.SuspendLayout()
        Me.pnl_BenMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PNL_DISBURSE.SuspendLayout()
        Me.GunaShadowPanel7.SuspendLayout()
        Me.GunaShadowPanel6.SuspendLayout()
        Me.PNL_CURRENT_DISB_AMOUNT.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_DISBURSEMENT_LOGIN.SuspendLayout()
        Me.GunaShadowPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.PNL_UPDATE_PERMIT.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnl_BenMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 610)
        Me.Panel1.TabIndex = 41
        '
        'pnl_BenMain
        '
        Me.pnl_BenMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_BenMain.AutoScroll = True
        Me.pnl_BenMain.BackColor = System.Drawing.Color.Transparent
        Me.pnl_BenMain.BaseColor = System.Drawing.Color.White
        Me.pnl_BenMain.Controls.Add(Me.Panel3)
        Me.pnl_BenMain.Controls.Add(Me.GunaCirclePictureBox1)
        Me.pnl_BenMain.Controls.Add(Me.Panel4)
        Me.pnl_BenMain.Controls.Add(Me.btn_exit_account)
        Me.pnl_BenMain.Location = New System.Drawing.Point(12, 13)
        Me.pnl_BenMain.Name = "pnl_BenMain"
        Me.pnl_BenMain.Radius = 3
        Me.pnl_BenMain.ShadowColor = System.Drawing.Color.DarkGray
        Me.pnl_BenMain.ShadowDepth = 50
        Me.pnl_BenMain.ShadowShift = 8
        Me.pnl_BenMain.Size = New System.Drawing.Size(931, 585)
        Me.pnl_BenMain.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lb_benef_full_name)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.LBL_STUD_ID)
        Me.Panel3.Controls.Add(Me.lbl_status)
        Me.Panel3.Location = New System.Drawing.Point(143, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 94)
        Me.Panel3.TabIndex = 48
        '
        'lb_benef_full_name
        '
        Me.lb_benef_full_name.AutoSize = True
        Me.lb_benef_full_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_benef_full_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lb_benef_full_name.Location = New System.Drawing.Point(11, 8)
        Me.lb_benef_full_name.Name = "lb_benef_full_name"
        Me.lb_benef_full_name.Size = New System.Drawing.Size(208, 24)
        Me.lb_benef_full_name.TabIndex = 0
        Me.lb_benef_full_name.Text = "Samuel Sabellano Jr."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account #: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status:"
        '
        'LBL_STUD_ID
        '
        Me.LBL_STUD_ID.AutoSize = True
        Me.LBL_STUD_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_STUD_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.LBL_STUD_ID.Location = New System.Drawing.Point(82, 34)
        Me.LBL_STUD_ID.Name = "LBL_STUD_ID"
        Me.LBL_STUD_ID.Size = New System.Drawing.Size(88, 18)
        Me.LBL_STUD_ID.TabIndex = 0
        Me.LBL_STUD_ID.Text = "ID Number"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lbl_status.Location = New System.Drawing.Point(58, 58)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(54, 18)
        Me.lbl_status.TabIndex = 0
        Me.lbl_status.Text = "status"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(32, 16)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(123, 107)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox1.TabIndex = 1
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.TabControl1)
        Me.Panel4.Location = New System.Drawing.Point(10, 140)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(911, 432)
        Me.Panel4.TabIndex = 51
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(911, 432)
        Me.TabControl1.TabIndex = 47
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.PNL_DISBURSE)
        Me.TabPage3.Controls.Add(Me.PNL_DISBURSEMENT_LOGIN)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(903, 401)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Disbursement"
        '
        'PNL_DISBURSE
        '
        Me.PNL_DISBURSE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_DISBURSE.BackColor = System.Drawing.Color.White
        Me.PNL_DISBURSE.Controls.Add(Me.GunaShadowPanel7)
        Me.PNL_DISBURSE.Controls.Add(Me.GunaShadowPanel6)
        Me.PNL_DISBURSE.Location = New System.Drawing.Point(7, 6)
        Me.PNL_DISBURSE.Name = "PNL_DISBURSE"
        Me.PNL_DISBURSE.Size = New System.Drawing.Size(888, 386)
        Me.PNL_DISBURSE.TabIndex = 0
        '
        'GunaShadowPanel7
        '
        Me.GunaShadowPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaShadowPanel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel7.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel7.Controls.Add(Me.LBL_LEAVE_PERMITNUM_BLANK)
        Me.GunaShadowPanel7.Controls.Add(Me.BTN_SUBMIT_DISBURSEMENT)
        Me.GunaShadowPanel7.Controls.Add(Me.CBO_GET_PURPOSE)
        Me.GunaShadowPanel7.Controls.Add(Me.Label17)
        Me.GunaShadowPanel7.Controls.Add(Me.CBO_GET_CONTRACT_ID)
        Me.GunaShadowPanel7.Controls.Add(Me.Label14)
        Me.GunaShadowPanel7.Controls.Add(Me.TXT_NEW_PERMIT_NUMBER)
        Me.GunaShadowPanel7.Controls.Add(Me.Label15)
        Me.GunaShadowPanel7.Controls.Add(Me.TXT_NEW_DISBURSE_AMOUNT)
        Me.GunaShadowPanel7.Controls.Add(Me.Label16)
        Me.GunaShadowPanel7.Location = New System.Drawing.Point(11, 17)
        Me.GunaShadowPanel7.Name = "GunaShadowPanel7"
        Me.GunaShadowPanel7.Radius = 4
        Me.GunaShadowPanel7.ShadowColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel7.ShadowDepth = 60
        Me.GunaShadowPanel7.Size = New System.Drawing.Size(554, 351)
        Me.GunaShadowPanel7.TabIndex = 78
        '
        'LBL_LEAVE_PERMITNUM_BLANK
        '
        Me.LBL_LEAVE_PERMITNUM_BLANK.AutoSize = True
        Me.LBL_LEAVE_PERMITNUM_BLANK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LEAVE_PERMITNUM_BLANK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LBL_LEAVE_PERMITNUM_BLANK.Location = New System.Drawing.Point(122, 120)
        Me.LBL_LEAVE_PERMITNUM_BLANK.Name = "LBL_LEAVE_PERMITNUM_BLANK"
        Me.LBL_LEAVE_PERMITNUM_BLANK.Size = New System.Drawing.Size(218, 13)
        Me.LBL_LEAVE_PERMITNUM_BLANK.TabIndex = 82
        Me.LBL_LEAVE_PERMITNUM_BLANK.Text = "(Please leave this field blank if no permit yet.)"
        '
        'BTN_SUBMIT_DISBURSEMENT
        '
        Me.BTN_SUBMIT_DISBURSEMENT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_SUBMIT_DISBURSEMENT.Animated = True
        Me.BTN_SUBMIT_DISBURSEMENT.AnimationHoverSpeed = 0.07!
        Me.BTN_SUBMIT_DISBURSEMENT.AnimationSpeed = 0.03!
        Me.BTN_SUBMIT_DISBURSEMENT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SUBMIT_DISBURSEMENT.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_SUBMIT_DISBURSEMENT.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SUBMIT_DISBURSEMENT.BorderSize = 1
        Me.BTN_SUBMIT_DISBURSEMENT.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_SUBMIT_DISBURSEMENT.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SUBMIT_DISBURSEMENT.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_SUBMIT_DISBURSEMENT.CheckedImage = CType(resources.GetObject("BTN_SUBMIT_DISBURSEMENT.CheckedImage"), System.Drawing.Image)
        Me.BTN_SUBMIT_DISBURSEMENT.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_SUBMIT_DISBURSEMENT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_SUBMIT_DISBURSEMENT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_SUBMIT_DISBURSEMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SUBMIT_DISBURSEMENT.ForeColor = System.Drawing.Color.White
        Me.BTN_SUBMIT_DISBURSEMENT.Image = Nothing
        Me.BTN_SUBMIT_DISBURSEMENT.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_SUBMIT_DISBURSEMENT.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SUBMIT_DISBURSEMENT.Location = New System.Drawing.Point(59, 292)
        Me.BTN_SUBMIT_DISBURSEMENT.Name = "BTN_SUBMIT_DISBURSEMENT"
        Me.BTN_SUBMIT_DISBURSEMENT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BTN_SUBMIT_DISBURSEMENT.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_SUBMIT_DISBURSEMENT.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_SUBMIT_DISBURSEMENT.OnHoverImage = Nothing
        Me.BTN_SUBMIT_DISBURSEMENT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_SUBMIT_DISBURSEMENT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_SUBMIT_DISBURSEMENT.Radius = 5
        Me.BTN_SUBMIT_DISBURSEMENT.Size = New System.Drawing.Size(93, 33)
        Me.BTN_SUBMIT_DISBURSEMENT.TabIndex = 5
        Me.BTN_SUBMIT_DISBURSEMENT.Text = "Submit"
        Me.BTN_SUBMIT_DISBURSEMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBO_GET_PURPOSE
        '
        Me.CBO_GET_PURPOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBO_GET_PURPOSE.BackColor = System.Drawing.Color.Transparent
        Me.CBO_GET_PURPOSE.BaseColor = System.Drawing.Color.White
        Me.CBO_GET_PURPOSE.BorderColor = System.Drawing.Color.Gainsboro
        Me.CBO_GET_PURPOSE.BorderSize = 1
        Me.CBO_GET_PURPOSE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_GET_PURPOSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_GET_PURPOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_GET_PURPOSE.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_GET_PURPOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_GET_PURPOSE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.CBO_GET_PURPOSE.FormattingEnabled = True
        Me.CBO_GET_PURPOSE.Location = New System.Drawing.Point(253, 60)
        Me.CBO_GET_PURPOSE.Name = "CBO_GET_PURPOSE"
        Me.CBO_GET_PURPOSE.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_GET_PURPOSE.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_GET_PURPOSE.Radius = 4
        Me.CBO_GET_PURPOSE.Size = New System.Drawing.Size(249, 25)
        Me.CBO_GET_PURPOSE.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(56, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Contract ID"
        '
        'CBO_GET_CONTRACT_ID
        '
        Me.CBO_GET_CONTRACT_ID.BackColor = System.Drawing.Color.Transparent
        Me.CBO_GET_CONTRACT_ID.BaseColor = System.Drawing.Color.White
        Me.CBO_GET_CONTRACT_ID.BorderColor = System.Drawing.Color.Gainsboro
        Me.CBO_GET_CONTRACT_ID.BorderSize = 1
        Me.CBO_GET_CONTRACT_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_GET_CONTRACT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_GET_CONTRACT_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_GET_CONTRACT_ID.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_GET_CONTRACT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_GET_CONTRACT_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.CBO_GET_CONTRACT_ID.FormattingEnabled = True
        Me.CBO_GET_CONTRACT_ID.Location = New System.Drawing.Point(59, 60)
        Me.CBO_GET_CONTRACT_ID.Name = "CBO_GET_CONTRACT_ID"
        Me.CBO_GET_CONTRACT_ID.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_GET_CONTRACT_ID.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_GET_CONTRACT_ID.Radius = 4
        Me.CBO_GET_CONTRACT_ID.Size = New System.Drawing.Size(249, 25)
        Me.CBO_GET_CONTRACT_ID.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(250, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Purpose:"
        '
        'TXT_NEW_PERMIT_NUMBER
        '
        Me.TXT_NEW_PERMIT_NUMBER.Animated = True
        Me.TXT_NEW_PERMIT_NUMBER.BackColor = System.Drawing.Color.White
        Me.TXT_NEW_PERMIT_NUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NEW_PERMIT_NUMBER.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NEW_PERMIT_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NEW_PERMIT_NUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.TXT_NEW_PERMIT_NUMBER.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_NEW_PERMIT_NUMBER.LineSize = 2
        Me.TXT_NEW_PERMIT_NUMBER.Location = New System.Drawing.Point(59, 147)
        Me.TXT_NEW_PERMIT_NUMBER.Name = "TXT_NEW_PERMIT_NUMBER"
        Me.TXT_NEW_PERMIT_NUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NEW_PERMIT_NUMBER.Size = New System.Drawing.Size(249, 29)
        Me.TXT_NEW_PERMIT_NUMBER.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(56, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Amount:"
        '
        'TXT_NEW_DISBURSE_AMOUNT
        '
        Me.TXT_NEW_DISBURSE_AMOUNT.Animated = True
        Me.TXT_NEW_DISBURSE_AMOUNT.BackColor = System.Drawing.Color.White
        Me.TXT_NEW_DISBURSE_AMOUNT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NEW_DISBURSE_AMOUNT.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NEW_DISBURSE_AMOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NEW_DISBURSE_AMOUNT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.TXT_NEW_DISBURSE_AMOUNT.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_NEW_DISBURSE_AMOUNT.LineSize = 2
        Me.TXT_NEW_DISBURSE_AMOUNT.Location = New System.Drawing.Point(59, 229)
        Me.TXT_NEW_DISBURSE_AMOUNT.Name = "TXT_NEW_DISBURSE_AMOUNT"
        Me.TXT_NEW_DISBURSE_AMOUNT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NEW_DISBURSE_AMOUNT.Size = New System.Drawing.Size(249, 29)
        Me.TXT_NEW_DISBURSE_AMOUNT.TabIndex = 4
        Me.TXT_NEW_DISBURSE_AMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(56, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 16)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Permit #:"
        '
        'GunaShadowPanel6
        '
        Me.GunaShadowPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaShadowPanel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel6.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel6.Controls.Add(Me.PNL_CURRENT_DISB_AMOUNT)
        Me.GunaShadowPanel6.Controls.Add(Me.GunaSeparator3)
        Me.GunaShadowPanel6.Controls.Add(Me.Panel7)
        Me.GunaShadowPanel6.Controls.Add(Me.Panel8)
        Me.GunaShadowPanel6.Controls.Add(Me.Panel9)
        Me.GunaShadowPanel6.Controls.Add(Me.Label12)
        Me.GunaShadowPanel6.Location = New System.Drawing.Point(571, 17)
        Me.GunaShadowPanel6.Name = "GunaShadowPanel6"
        Me.GunaShadowPanel6.Radius = 4
        Me.GunaShadowPanel6.ShadowColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel6.ShadowDepth = 60
        Me.GunaShadowPanel6.Size = New System.Drawing.Size(306, 351)
        Me.GunaShadowPanel6.TabIndex = 77
        '
        'PNL_CURRENT_DISB_AMOUNT
        '
        Me.PNL_CURRENT_DISB_AMOUNT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_CURRENT_DISB_AMOUNT.Controls.Add(Me.PictureBox12)
        Me.PNL_CURRENT_DISB_AMOUNT.Controls.Add(Me.LBL_GET_CURRENT_DISB_AMOUNT)
        Me.PNL_CURRENT_DISB_AMOUNT.Controls.Add(Me.Label8)
        Me.PNL_CURRENT_DISB_AMOUNT.Location = New System.Drawing.Point(43, 174)
        Me.PNL_CURRENT_DISB_AMOUNT.Name = "PNL_CURRENT_DISB_AMOUNT"
        Me.PNL_CURRENT_DISB_AMOUNT.Size = New System.Drawing.Size(224, 60)
        Me.PNL_CURRENT_DISB_AMOUNT.TabIndex = 82
        '
        'PictureBox12
        '
        Me.PictureBox12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox12.Location = New System.Drawing.Point(5, 15)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 60
        Me.PictureBox12.TabStop = False
        '
        'LBL_GET_CURRENT_DISB_AMOUNT
        '
        Me.LBL_GET_CURRENT_DISB_AMOUNT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_GET_CURRENT_DISB_AMOUNT.AutoSize = True
        Me.LBL_GET_CURRENT_DISB_AMOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GET_CURRENT_DISB_AMOUNT.ForeColor = System.Drawing.Color.Teal
        Me.LBL_GET_CURRENT_DISB_AMOUNT.Location = New System.Drawing.Point(38, 15)
        Me.LBL_GET_CURRENT_DISB_AMOUNT.Name = "LBL_GET_CURRENT_DISB_AMOUNT"
        Me.LBL_GET_CURRENT_DISB_AMOUNT.Size = New System.Drawing.Size(40, 18)
        Me.LBL_GET_CURRENT_DISB_AMOUNT.TabIndex = 58
        Me.LBL_GET_CURRENT_DISB_AMOUNT.Text = "0.00"
        Me.LBL_GET_CURRENT_DISB_AMOUNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(36, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 15)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Previous total disbursed amount"
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator3.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaSeparator3.Location = New System.Drawing.Point(43, 156)
        Me.GunaSeparator3.Name = "GunaSeparator3"
        Me.GunaSeparator3.Size = New System.Drawing.Size(224, 10)
        Me.GunaSeparator3.TabIndex = 83
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.LBL_GET_DATE)
        Me.Panel7.Controls.Add(Me.PictureBox9)
        Me.Panel7.Location = New System.Drawing.Point(43, 105)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 41)
        Me.Panel7.TabIndex = 83
        '
        'LBL_GET_DATE
        '
        Me.LBL_GET_DATE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_GET_DATE.AutoSize = True
        Me.LBL_GET_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GET_DATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LBL_GET_DATE.Location = New System.Drawing.Point(36, 16)
        Me.LBL_GET_DATE.Name = "LBL_GET_DATE"
        Me.LBL_GET_DATE.Size = New System.Drawing.Size(33, 15)
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
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.PictureBox10)
        Me.Panel8.Controls.Add(Me.LBL_ADMIN_NAME)
        Me.Panel8.Location = New System.Drawing.Point(43, 36)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 41)
        Me.Panel8.TabIndex = 82
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 61
        Me.PictureBox10.TabStop = False
        '
        'LBL_ADMIN_NAME
        '
        Me.LBL_ADMIN_NAME.AutoSize = True
        Me.LBL_ADMIN_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ADMIN_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.LBL_ADMIN_NAME.Location = New System.Drawing.Point(38, 17)
        Me.LBL_ADMIN_NAME.Name = "LBL_ADMIN_NAME"
        Me.LBL_ADMIN_NAME.Size = New System.Drawing.Size(100, 18)
        Me.LBL_ADMIN_NAME.TabIndex = 68
        Me.LBL_ADMIN_NAME.Text = "Admin name"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.PictureBox11)
        Me.Panel9.Controls.Add(Me.LBL_GET_TOTAL_DISBURSED)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Location = New System.Drawing.Point(43, 238)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(224, 60)
        Me.Panel9.TabIndex = 69
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox11.Location = New System.Drawing.Point(5, 6)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 60
        Me.PictureBox11.TabStop = False
        '
        'LBL_GET_TOTAL_DISBURSED
        '
        Me.LBL_GET_TOTAL_DISBURSED.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_GET_TOTAL_DISBURSED.AutoSize = True
        Me.LBL_GET_TOTAL_DISBURSED.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GET_TOTAL_DISBURSED.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LBL_GET_TOTAL_DISBURSED.Location = New System.Drawing.Point(36, 6)
        Me.LBL_GET_TOTAL_DISBURSED.Name = "LBL_GET_TOTAL_DISBURSED"
        Me.LBL_GET_TOTAL_DISBURSED.Size = New System.Drawing.Size(62, 29)
        Me.LBL_GET_TOTAL_DISBURSED.TabIndex = 58
        Me.LBL_GET_TOTAL_DISBURSED.Text = "0.00"
        Me.LBL_GET_TOTAL_DISBURSED.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(36, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 16)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Current total disbursed amount"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(79, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 16)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Disbursed by Admin"
        '
        'PNL_DISBURSEMENT_LOGIN
        '
        Me.PNL_DISBURSEMENT_LOGIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_DISBURSEMENT_LOGIN.Controls.Add(Me.GunaShadowPanel5)
        Me.PNL_DISBURSEMENT_LOGIN.Location = New System.Drawing.Point(9, 18)
        Me.PNL_DISBURSEMENT_LOGIN.Name = "PNL_DISBURSEMENT_LOGIN"
        Me.PNL_DISBURSEMENT_LOGIN.Size = New System.Drawing.Size(886, 374)
        Me.PNL_DISBURSEMENT_LOGIN.TabIndex = 0
        '
        'GunaShadowPanel5
        '
        Me.GunaShadowPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GunaShadowPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaShadowPanel5.Controls.Add(Me.GunaLabel4)
        Me.GunaShadowPanel5.Controls.Add(Me.btn_dsbursement_ben_login)
        Me.GunaShadowPanel5.Controls.Add(Me.txt_disbursement_ben_pass)
        Me.GunaShadowPanel5.Location = New System.Drawing.Point(190, 68)
        Me.GunaShadowPanel5.Name = "GunaShadowPanel5"
        Me.GunaShadowPanel5.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel5.ShadowDepth = 14
        Me.GunaShadowPanel5.ShadowShift = 3
        Me.GunaShadowPanel5.Size = New System.Drawing.Size(507, 236)
        Me.GunaShadowPanel5.TabIndex = 1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.PictureBox7)
        Me.GunaPanel1.Controls.Add(Me.PictureBox8)
        Me.GunaPanel1.Controls.Add(Me.LBL_ENTER_B_PASS)
        Me.GunaPanel1.Location = New System.Drawing.Point(3, 2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(501, 44)
        Me.GunaPanel1.TabIndex = 0
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(469, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(26, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 39
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(21, 14)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(26, 20)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 38
        Me.PictureBox8.TabStop = False
        '
        'LBL_ENTER_B_PASS
        '
        Me.LBL_ENTER_B_PASS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBL_ENTER_B_PASS.AutoSize = True
        Me.LBL_ENTER_B_PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ENTER_B_PASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.LBL_ENTER_B_PASS.Location = New System.Drawing.Point(46, 17)
        Me.LBL_ENTER_B_PASS.Name = "LBL_ENTER_B_PASS"
        Me.LBL_ENTER_B_PASS.Size = New System.Drawing.Size(114, 13)
        Me.LBL_ENTER_B_PASS.TabIndex = 0
        Me.LBL_ENTER_B_PASS.Text = "Beneficiary's password"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel4.Location = New System.Drawing.Point(66, 90)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "Password"
        '
        'btn_dsbursement_ben_login
        '
        Me.btn_dsbursement_ben_login.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_dsbursement_ben_login.Animated = True
        Me.btn_dsbursement_ben_login.AnimationHoverSpeed = 0.07!
        Me.btn_dsbursement_ben_login.AnimationSpeed = 0.03!
        Me.btn_dsbursement_ben_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_dsbursement_ben_login.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_dsbursement_ben_login.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_dsbursement_ben_login.BorderSize = 1
        Me.btn_dsbursement_ben_login.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_dsbursement_ben_login.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_dsbursement_ben_login.CheckedForeColor = System.Drawing.Color.White
        Me.btn_dsbursement_ben_login.CheckedImage = CType(resources.GetObject("btn_dsbursement_ben_login.CheckedImage"), System.Drawing.Image)
        Me.btn_dsbursement_ben_login.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_dsbursement_ben_login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_dsbursement_ben_login.FocusedColor = System.Drawing.Color.Empty
        Me.btn_dsbursement_ben_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dsbursement_ben_login.ForeColor = System.Drawing.Color.White
        Me.btn_dsbursement_ben_login.Image = Nothing
        Me.btn_dsbursement_ben_login.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_dsbursement_ben_login.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_dsbursement_ben_login.Location = New System.Drawing.Point(209, 163)
        Me.btn_dsbursement_ben_login.Name = "btn_dsbursement_ben_login"
        Me.btn_dsbursement_ben_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btn_dsbursement_ben_login.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_dsbursement_ben_login.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_dsbursement_ben_login.OnHoverImage = Nothing
        Me.btn_dsbursement_ben_login.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_dsbursement_ben_login.OnPressedColor = System.Drawing.Color.Black
        Me.btn_dsbursement_ben_login.Radius = 5
        Me.btn_dsbursement_ben_login.Size = New System.Drawing.Size(93, 33)
        Me.btn_dsbursement_ben_login.TabIndex = 2
        Me.btn_dsbursement_ben_login.Text = "Go"
        Me.btn_dsbursement_ben_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_disbursement_ben_pass
        '
        Me.txt_disbursement_ben_pass.BackColor = System.Drawing.Color.Transparent
        Me.txt_disbursement_ben_pass.BaseColor = System.Drawing.Color.White
        Me.txt_disbursement_ben_pass.BorderColor = System.Drawing.Color.Gainsboro
        Me.txt_disbursement_ben_pass.BorderSize = 1
        Me.txt_disbursement_ben_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_disbursement_ben_pass.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_disbursement_ben_pass.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.txt_disbursement_ben_pass.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_disbursement_ben_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disbursement_ben_pass.ForeColor = System.Drawing.Color.Gray
        Me.txt_disbursement_ben_pass.Location = New System.Drawing.Point(56, 98)
        Me.txt_disbursement_ben_pass.Name = "txt_disbursement_ben_pass"
        Me.txt_disbursement_ben_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_disbursement_ben_pass.Radius = 4
        Me.txt_disbursement_ben_pass.Size = New System.Drawing.Size(398, 49)
        Me.txt_disbursement_ben_pass.TabIndex = 1
        Me.txt_disbursement_ben_pass.UseSystemPasswordChar = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PNL_UPDATE_PERMIT)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(903, 401)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Update Permit No."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PNL_UPDATE_PERMIT
        '
        Me.PNL_UPDATE_PERMIT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_UPDATE_PERMIT.BackColor = System.Drawing.Color.Transparent
        Me.PNL_UPDATE_PERMIT.BaseColor = System.Drawing.Color.White
        Me.PNL_UPDATE_PERMIT.Controls.Add(Me.GunaLabel3)
        Me.PNL_UPDATE_PERMIT.Controls.Add(Me.BTN_UPDATE_PERMIT)
        Me.PNL_UPDATE_PERMIT.Controls.Add(Me.Label11)
        Me.PNL_UPDATE_PERMIT.Controls.Add(Me.CBO_NO_PERMIT_CONT_ID)
        Me.PNL_UPDATE_PERMIT.Controls.Add(Me.TXT_UPDATE_PERMIT_NUMBER)
        Me.PNL_UPDATE_PERMIT.Controls.Add(Me.Label20)
        Me.PNL_UPDATE_PERMIT.Location = New System.Drawing.Point(190, 25)
        Me.PNL_UPDATE_PERMIT.Name = "PNL_UPDATE_PERMIT"
        Me.PNL_UPDATE_PERMIT.Radius = 4
        Me.PNL_UPDATE_PERMIT.ShadowColor = System.Drawing.Color.DimGray
        Me.PNL_UPDATE_PERMIT.ShadowDepth = 60
        Me.PNL_UPDATE_PERMIT.Size = New System.Drawing.Size(505, 351)
        Me.PNL_UPDATE_PERMIT.TabIndex = 79
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(105, 41)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(166, 20)
        Me.GunaLabel3.TabIndex = 77
        Me.GunaLabel3.Text = "Update Permint No."
        '
        'BTN_UPDATE_PERMIT
        '
        Me.BTN_UPDATE_PERMIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_UPDATE_PERMIT.Animated = True
        Me.BTN_UPDATE_PERMIT.AnimationHoverSpeed = 0.07!
        Me.BTN_UPDATE_PERMIT.AnimationSpeed = 0.03!
        Me.BTN_UPDATE_PERMIT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_UPDATE_PERMIT.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BTN_UPDATE_PERMIT.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_UPDATE_PERMIT.BorderSize = 1
        Me.BTN_UPDATE_PERMIT.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTN_UPDATE_PERMIT.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_UPDATE_PERMIT.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_UPDATE_PERMIT.CheckedImage = CType(resources.GetObject("BTN_UPDATE_PERMIT.CheckedImage"), System.Drawing.Image)
        Me.BTN_UPDATE_PERMIT.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_UPDATE_PERMIT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_UPDATE_PERMIT.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_UPDATE_PERMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE_PERMIT.ForeColor = System.Drawing.Color.White
        Me.BTN_UPDATE_PERMIT.Image = CType(resources.GetObject("BTN_UPDATE_PERMIT.Image"), System.Drawing.Image)
        Me.BTN_UPDATE_PERMIT.ImageSize = New System.Drawing.Size(17, 17)
        Me.BTN_UPDATE_PERMIT.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_UPDATE_PERMIT.Location = New System.Drawing.Point(118, 276)
        Me.BTN_UPDATE_PERMIT.Name = "BTN_UPDATE_PERMIT"
        Me.BTN_UPDATE_PERMIT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BTN_UPDATE_PERMIT.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_UPDATE_PERMIT.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_UPDATE_PERMIT.OnHoverImage = Nothing
        Me.BTN_UPDATE_PERMIT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_UPDATE_PERMIT.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_PERMIT.Radius = 5
        Me.BTN_UPDATE_PERMIT.Size = New System.Drawing.Size(117, 31)
        Me.BTN_UPDATE_PERMIT.TabIndex = 5
        Me.BTN_UPDATE_PERMIT.Text = "     Update now"
        Me.BTN_UPDATE_PERMIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(106, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Contract ID"
        '
        'CBO_NO_PERMIT_CONT_ID
        '
        Me.CBO_NO_PERMIT_CONT_ID.BackColor = System.Drawing.Color.Transparent
        Me.CBO_NO_PERMIT_CONT_ID.BaseColor = System.Drawing.Color.White
        Me.CBO_NO_PERMIT_CONT_ID.BorderColor = System.Drawing.Color.Gainsboro
        Me.CBO_NO_PERMIT_CONT_ID.BorderSize = 1
        Me.CBO_NO_PERMIT_CONT_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_NO_PERMIT_CONT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_NO_PERMIT_CONT_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_NO_PERMIT_CONT_ID.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_NO_PERMIT_CONT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_NO_PERMIT_CONT_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.CBO_NO_PERMIT_CONT_ID.FormattingEnabled = True
        Me.CBO_NO_PERMIT_CONT_ID.Location = New System.Drawing.Point(109, 135)
        Me.CBO_NO_PERMIT_CONT_ID.Name = "CBO_NO_PERMIT_CONT_ID"
        Me.CBO_NO_PERMIT_CONT_ID.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_NO_PERMIT_CONT_ID.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_NO_PERMIT_CONT_ID.Radius = 4
        Me.CBO_NO_PERMIT_CONT_ID.Size = New System.Drawing.Size(276, 25)
        Me.CBO_NO_PERMIT_CONT_ID.TabIndex = 1
        '
        'TXT_UPDATE_PERMIT_NUMBER
        '
        Me.TXT_UPDATE_PERMIT_NUMBER.Animated = True
        Me.TXT_UPDATE_PERMIT_NUMBER.BackColor = System.Drawing.Color.White
        Me.TXT_UPDATE_PERMIT_NUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_UPDATE_PERMIT_NUMBER.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_UPDATE_PERMIT_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_UPDATE_PERMIT_NUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.TXT_UPDATE_PERMIT_NUMBER.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_UPDATE_PERMIT_NUMBER.LineSize = 2
        Me.TXT_UPDATE_PERMIT_NUMBER.Location = New System.Drawing.Point(118, 222)
        Me.TXT_UPDATE_PERMIT_NUMBER.Name = "TXT_UPDATE_PERMIT_NUMBER"
        Me.TXT_UPDATE_PERMIT_NUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_UPDATE_PERMIT_NUMBER.Size = New System.Drawing.Size(267, 29)
        Me.TXT_UPDATE_PERMIT_NUMBER.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(115, 193)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 16)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Permit #:"
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
        Me.btn_exit_account.Location = New System.Drawing.Point(842, 30)
        Me.btn_exit_account.Name = "btn_exit_account"
        Me.btn_exit_account.OnHoverBaseColor = System.Drawing.Color.White
        Me.btn_exit_account.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_exit_account.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_exit_account.OnHoverImage = Nothing
        Me.btn_exit_account.OnPressedColor = System.Drawing.Color.Black
        Me.btn_exit_account.Size = New System.Drawing.Size(48, 48)
        Me.btn_exit_account.TabIndex = 0
        '
        'beneficiary_animatedWindow
        '
        Me.beneficiary_animatedWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.beneficiary_animatedWindow.Interval = 100
        Me.beneficiary_animatedWindow.TargetControl = Me
        '
        'lbl_disburse_amount
        '
        Me.lbl_disburse_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_disburse_amount.AutoSize = True
        Me.lbl_disburse_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_disburse_amount.Location = New System.Drawing.Point(585, 185)
        Me.lbl_disburse_amount.Name = "lbl_disburse_amount"
        Me.lbl_disburse_amount.Size = New System.Drawing.Size(112, 15)
        Me.lbl_disburse_amount.TabIndex = 62
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(42, 99)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(58, 15)
        Me.GunaLabel10.TabIndex = 64
        '
        'cbo_purpose
        '
        Me.cbo_purpose.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbo_purpose.BackColor = System.Drawing.Color.Transparent
        Me.cbo_purpose.BaseColor = System.Drawing.Color.White
        Me.cbo_purpose.BorderColor = System.Drawing.Color.Silver
        Me.cbo_purpose.BorderSize = 1
        Me.cbo_purpose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_purpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_purpose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_purpose.FocusedColor = System.Drawing.Color.Empty
        Me.cbo_purpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_purpose.ForeColor = System.Drawing.Color.Black
        Me.cbo_purpose.FormattingEnabled = True
        Me.cbo_purpose.Location = New System.Drawing.Point(45, 117)
        Me.cbo_purpose.Name = "cbo_purpose"
        Me.cbo_purpose.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_purpose.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbo_purpose.Radius = 5
        Me.cbo_purpose.Size = New System.Drawing.Size(231, 23)
        Me.cbo_purpose.TabIndex = 63
        '
        'GunaLabel6
        '
        Me.GunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(42, 37)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(72, 15)
        Me.GunaLabel6.TabIndex = 69
        '
        'GunaTextBox3
        '
        Me.GunaTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox3.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.BorderColor = System.Drawing.Color.LightGray
        Me.GunaTextBox3.BorderSize = 1
        Me.GunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox3.FocusedForeColor = System.Drawing.Color.Black
        Me.GunaTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox3.Location = New System.Drawing.Point(45, 54)
        Me.GunaTextBox3.Name = "GunaTextBox3"
        Me.GunaTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox3.Radius = 5
        Me.GunaTextBox3.Size = New System.Drawing.Size(272, 29)
        Me.GunaTextBox3.TabIndex = 68
        Me.GunaTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_disburse_amount
        '
        Me.txt_disburse_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_disburse_amount.BackColor = System.Drawing.Color.White
        Me.txt_disburse_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_disburse_amount.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.txt_disburse_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disburse_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_disburse_amount.LineColor = System.Drawing.Color.SeaGreen
        Me.txt_disburse_amount.Location = New System.Drawing.Point(572, 224)
        Me.txt_disburse_amount.Name = "txt_disburse_amount"
        Me.txt_disburse_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_disburse_amount.Size = New System.Drawing.Size(160, 31)
        Me.txt_disburse_amount.TabIndex = 71
        Me.txt_disburse_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(10, 22)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.Radius = 4
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Navy
        Me.GunaShadowPanel3.ShadowDepth = 40
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(560, 332)
        Me.GunaShadowPanel3.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(47, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 69
        '
        'txt_permit_no
        '
        Me.txt_permit_no.Animated = True
        Me.txt_permit_no.BackColor = System.Drawing.Color.White
        Me.txt_permit_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_permit_no.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_permit_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_permit_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.txt_permit_no.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_permit_no.LineSize = 2
        Me.txt_permit_no.Location = New System.Drawing.Point(48, 127)
        Me.txt_permit_no.Name = "txt_permit_no"
        Me.txt_permit_no.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_permit_no.Size = New System.Drawing.Size(265, 29)
        Me.txt_permit_no.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(47, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 71
        '
        'txt_amount_to_disburse
        '
        Me.txt_amount_to_disburse.Animated = True
        Me.txt_amount_to_disburse.BackColor = System.Drawing.Color.White
        Me.txt_amount_to_disburse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount_to_disburse.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amount_to_disburse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount_to_disburse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.txt_amount_to_disburse.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_amount_to_disburse.LineSize = 2
        Me.txt_amount_to_disburse.Location = New System.Drawing.Point(50, 196)
        Me.txt_amount_to_disburse.MaxLength = 11
        Me.txt_amount_to_disburse.Name = "txt_amount_to_disburse"
        Me.txt_amount_to_disburse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amount_to_disburse.Size = New System.Drawing.Size(263, 29)
        Me.txt_amount_to_disburse.TabIndex = 72
        Me.txt_amount_to_disburse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbo_purpose_of_money
        '
        Me.cbo_purpose_of_money.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_purpose_of_money.BackColor = System.Drawing.Color.Transparent
        Me.cbo_purpose_of_money.BaseColor = System.Drawing.Color.White
        Me.cbo_purpose_of_money.BorderColor = System.Drawing.SystemColors.Control
        Me.cbo_purpose_of_money.BorderSize = 1
        Me.cbo_purpose_of_money.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_purpose_of_money.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_purpose_of_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_purpose_of_money.FocusedColor = System.Drawing.Color.Empty
        Me.cbo_purpose_of_money.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_purpose_of_money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.cbo_purpose_of_money.FormattingEnabled = True
        Me.cbo_purpose_of_money.Location = New System.Drawing.Point(239, 55)
        Me.cbo_purpose_of_money.Name = "cbo_purpose_of_money"
        Me.cbo_purpose_of_money.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_purpose_of_money.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbo_purpose_of_money.Radius = 4
        Me.cbo_purpose_of_money.Size = New System.Drawing.Size(263, 25)
        Me.cbo_purpose_of_money.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(255, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 74
        '
        'btn_submit_disburse
        '
        Me.btn_submit_disburse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_submit_disburse.Animated = True
        Me.btn_submit_disburse.AnimationHoverSpeed = 0.07!
        Me.btn_submit_disburse.AnimationSpeed = 0.03!
        Me.btn_submit_disburse.BackColor = System.Drawing.Color.Transparent
        Me.btn_submit_disburse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_submit_disburse.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_submit_disburse.BorderSize = 1
        Me.btn_submit_disburse.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_submit_disburse.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_submit_disburse.CheckedForeColor = System.Drawing.Color.White
        Me.btn_submit_disburse.CheckedImage = CType(resources.GetObject("btn_submit_disburse.CheckedImage"), System.Drawing.Image)
        Me.btn_submit_disburse.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_submit_disburse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_submit_disburse.FocusedColor = System.Drawing.Color.Empty
        Me.btn_submit_disburse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit_disburse.ForeColor = System.Drawing.Color.White
        Me.btn_submit_disburse.Image = Nothing
        Me.btn_submit_disburse.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_submit_disburse.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_submit_disburse.Location = New System.Drawing.Point(50, 280)
        Me.btn_submit_disburse.Name = "btn_submit_disburse"
        Me.btn_submit_disburse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btn_submit_disburse.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_submit_disburse.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_submit_disburse.OnHoverImage = Nothing
        Me.btn_submit_disburse.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_submit_disburse.OnPressedColor = System.Drawing.Color.Black
        Me.btn_submit_disburse.Radius = 5
        Me.btn_submit_disburse.Size = New System.Drawing.Size(93, 33)
        Me.btn_submit_disburse.TabIndex = 62
        Me.btn_submit_disburse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(47, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 75
        '
        'cbo_contract_id
        '
        Me.cbo_contract_id.BackColor = System.Drawing.Color.Transparent
        Me.cbo_contract_id.BaseColor = System.Drawing.Color.White
        Me.cbo_contract_id.BorderColor = System.Drawing.SystemColors.Control
        Me.cbo_contract_id.BorderSize = 1
        Me.cbo_contract_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_contract_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_contract_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_contract_id.FocusedColor = System.Drawing.Color.Empty
        Me.cbo_contract_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_contract_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.cbo_contract_id.FormattingEnabled = True
        Me.cbo_contract_id.Items.AddRange(New Object() {"2019-2020/2/6"})
        Me.cbo_contract_id.Location = New System.Drawing.Point(50, 55)
        Me.cbo_contract_id.Name = "cbo_contract_id"
        Me.cbo_contract_id.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_contract_id.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbo_contract_id.Radius = 4
        Me.cbo_contract_id.Size = New System.Drawing.Size(263, 25)
        Me.cbo_contract_id.TabIndex = 77
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaSeparator1.Location = New System.Drawing.Point(50, 250)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(452, 12)
        Me.GunaSeparator1.TabIndex = 84
        '
        'GunaShadowPanel4
        '
        Me.GunaShadowPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaShadowPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel4.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel4.Location = New System.Drawing.Point(576, 22)
        Me.GunaShadowPanel4.Name = "GunaShadowPanel4"
        Me.GunaShadowPanel4.Radius = 4
        Me.GunaShadowPanel4.ShadowColor = System.Drawing.Color.Navy
        Me.GunaShadowPanel4.ShadowDepth = 40
        Me.GunaShadowPanel4.Size = New System.Drawing.Size(306, 332)
        Me.GunaShadowPanel4.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(79, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 67
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(43, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 60)
        Me.Panel2.TabIndex = 69
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(38, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 16)
        Me.Label13.TabIndex = 81
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'lbl_total_disburse_amount
        '
        Me.lbl_total_disburse_amount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_total_disburse_amount.AutoSize = True
        Me.lbl_total_disburse_amount.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_disburse_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lbl_total_disburse_amount.Location = New System.Drawing.Point(36, 5)
        Me.lbl_total_disburse_amount.Name = "lbl_total_disburse_amount"
        Me.lbl_total_disburse_amount.Size = New System.Drawing.Size(58, 28)
        Me.lbl_total_disburse_amount.TabIndex = 58
        Me.lbl_total_disburse_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Location = New System.Drawing.Point(43, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 41)
        Me.Panel5.TabIndex = 82
        '
        'lbl_get_admin_fullname
        '
        Me.lbl_get_admin_fullname.AutoSize = True
        Me.lbl_get_admin_fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_get_admin_fullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lbl_get_admin_fullname.Location = New System.Drawing.Point(38, 17)
        Me.lbl_get_admin_fullname.Name = "lbl_get_admin_fullname"
        Me.lbl_get_admin_fullname.Size = New System.Drawing.Size(97, 18)
        Me.lbl_get_admin_fullname.TabIndex = 68
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 61
        Me.PictureBox4.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Location = New System.Drawing.Point(43, 107)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 41)
        Me.Panel6.TabIndex = 83
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(5, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 61
        Me.PictureBox5.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbl_date.Location = New System.Drawing.Point(36, 16)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(31, 15)
        Me.lbl_date.TabIndex = 84
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaSeparator2.Location = New System.Drawing.Point(43, 164)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(219, 10)
        Me.GunaSeparator2.TabIndex = 83
        '
        'pnl_current_disbursed_amount
        '
        Me.pnl_current_disbursed_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_current_disbursed_amount.Location = New System.Drawing.Point(43, 264)
        Me.pnl_current_disbursed_amount.Name = "pnl_current_disbursed_amount"
        Me.pnl_current_disbursed_amount.Size = New System.Drawing.Size(219, 44)
        Me.pnl_current_disbursed_amount.TabIndex = 85
        '
        'label
        '
        Me.label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.label.Location = New System.Drawing.Point(37, 23)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(162, 14)
        Me.label.TabIndex = 84
        Me.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_current_disbursed_amount
        '
        Me.lbl_current_disbursed_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_current_disbursed_amount.AutoSize = True
        Me.lbl_current_disbursed_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current_disbursed_amount.ForeColor = System.Drawing.Color.Teal
        Me.lbl_current_disbursed_amount.Location = New System.Drawing.Point(38, 7)
        Me.lbl_current_disbursed_amount.Name = "lbl_current_disbursed_amount"
        Me.lbl_current_disbursed_amount.Size = New System.Drawing.Size(33, 16)
        Me.lbl_current_disbursed_amount.TabIndex = 85
        Me.lbl_current_disbursed_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 61
        Me.PictureBox6.TabStop = False
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(190, 38)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 14
        Me.GunaShadowPanel1.ShadowShift = 3
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(507, 236)
        Me.GunaShadowPanel1.TabIndex = 0
        '
        'txt_dsbrsment_bpassword
        '
        Me.txt_dsbrsment_bpassword.BackColor = System.Drawing.Color.Transparent
        Me.txt_dsbrsment_bpassword.BaseColor = System.Drawing.Color.White
        Me.txt_dsbrsment_bpassword.BorderColor = System.Drawing.Color.Gainsboro
        Me.txt_dsbrsment_bpassword.BorderSize = 1
        Me.txt_dsbrsment_bpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_dsbrsment_bpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_dsbrsment_bpassword.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.txt_dsbrsment_bpassword.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_dsbrsment_bpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dsbrsment_bpassword.ForeColor = System.Drawing.Color.Gray
        Me.txt_dsbrsment_bpassword.Location = New System.Drawing.Point(56, 98)
        Me.txt_dsbrsment_bpassword.Name = "txt_dsbrsment_bpassword"
        Me.txt_dsbrsment_bpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_dsbrsment_bpassword.Radius = 4
        Me.txt_dsbrsment_bpassword.Size = New System.Drawing.Size(398, 49)
        Me.txt_dsbrsment_bpassword.TabIndex = 1
        Me.txt_dsbrsment_bpassword.UseSystemPasswordChar = True
        '
        'btn_go
        '
        Me.btn_go.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_go.Animated = True
        Me.btn_go.AnimationHoverSpeed = 0.07!
        Me.btn_go.AnimationSpeed = 0.03!
        Me.btn_go.BackColor = System.Drawing.Color.Transparent
        Me.btn_go.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_go.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_go.BorderSize = 1
        Me.btn_go.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_go.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_go.CheckedForeColor = System.Drawing.Color.White
        Me.btn_go.CheckedImage = CType(resources.GetObject("btn_go.CheckedImage"), System.Drawing.Image)
        Me.btn_go.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_go.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_go.FocusedColor = System.Drawing.Color.Empty
        Me.btn_go.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.ForeColor = System.Drawing.Color.White
        Me.btn_go.Image = Nothing
        Me.btn_go.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_go.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_go.Location = New System.Drawing.Point(209, 163)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btn_go.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_go.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_go.OnHoverImage = Nothing
        Me.btn_go.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_go.OnPressedColor = System.Drawing.Color.Black
        Me.btn_go.Radius = 5
        Me.btn_go.Size = New System.Drawing.Size(93, 33)
        Me.btn_go.TabIndex = 2
        Me.btn_go.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel2.Location = New System.Drawing.Point(66, 90)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(62, 15)
        Me.GunaLabel2.TabIndex = 0
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GunaPanel2.Location = New System.Drawing.Point(3, 2)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(501, 44)
        Me.GunaPanel2.TabIndex = 0
        '
        'lbl_attention_bname
        '
        Me.lbl_attention_bname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_attention_bname.AutoSize = True
        Me.lbl_attention_bname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_attention_bname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lbl_attention_bname.Location = New System.Drawing.Point(46, 17)
        Me.lbl_attention_bname.Name = "lbl_attention_bname"
        Me.lbl_attention_bname.Size = New System.Drawing.Size(117, 14)
        Me.lbl_attention_bname.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(469, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(894, 393)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 5
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowDepth = 33
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(10, 10)
        Me.GunaShadowPanel2.TabIndex = 33
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel1.Location = New System.Drawing.Point(-193, -62)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(237, 16)
        Me.GunaLabel1.TabIndex = 4
        '
        'txt_search_beneficiary
        '
        Me.txt_search_beneficiary.BackColor = System.Drawing.Color.Transparent
        Me.txt_search_beneficiary.BaseColor = System.Drawing.Color.White
        Me.txt_search_beneficiary.BorderColor = System.Drawing.Color.Gainsboro
        Me.txt_search_beneficiary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search_beneficiary.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_search_beneficiary.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.txt_search_beneficiary.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_search_beneficiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_beneficiary.ForeColor = System.Drawing.Color.Gray
        Me.txt_search_beneficiary.Location = New System.Drawing.Point(43, 68)
        Me.txt_search_beneficiary.Name = "txt_search_beneficiary"
        Me.txt_search_beneficiary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_search_beneficiary.Radius = 4
        Me.txt_search_beneficiary.Size = New System.Drawing.Size(373, 39)
        Me.txt_search_beneficiary.TabIndex = 0
        Me.txt_search_beneficiary.UseSystemPasswordChar = True
        '
        'btn_Add_Beneficiary
        '
        Me.btn_Add_Beneficiary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Add_Beneficiary.Animated = True
        Me.btn_Add_Beneficiary.AnimationHoverSpeed = 0.07!
        Me.btn_Add_Beneficiary.AnimationSpeed = 0.03!
        Me.btn_Add_Beneficiary.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add_Beneficiary.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btn_Add_Beneficiary.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Add_Beneficiary.BorderSize = 1
        Me.btn_Add_Beneficiary.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_Add_Beneficiary.CheckedBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Add_Beneficiary.CheckedForeColor = System.Drawing.Color.White
        Me.btn_Add_Beneficiary.CheckedImage = CType(resources.GetObject("btn_Add_Beneficiary.CheckedImage"), System.Drawing.Image)
        Me.btn_Add_Beneficiary.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_Add_Beneficiary.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Add_Beneficiary.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Add_Beneficiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_Beneficiary.ForeColor = System.Drawing.Color.White
        Me.btn_Add_Beneficiary.Image = Nothing
        Me.btn_Add_Beneficiary.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_Add_Beneficiary.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Add_Beneficiary.Location = New System.Drawing.Point(-43, 124)
        Me.btn_Add_Beneficiary.Name = "btn_Add_Beneficiary"
        Me.btn_Add_Beneficiary.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btn_Add_Beneficiary.OnHoverBorderColor = System.Drawing.Color.Gainsboro
        Me.btn_Add_Beneficiary.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Add_Beneficiary.OnHoverImage = Nothing
        Me.btn_Add_Beneficiary.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_Add_Beneficiary.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Add_Beneficiary.Radius = 5
        Me.btn_Add_Beneficiary.Size = New System.Drawing.Size(77, 41)
        Me.btn_Add_Beneficiary.TabIndex = 5
        Me.btn_Add_Beneficiary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDisbursement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(955, 610)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDisbursement"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnl_BenMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.PNL_DISBURSE.ResumeLayout(False)
        Me.GunaShadowPanel7.ResumeLayout(False)
        Me.GunaShadowPanel7.PerformLayout()
        Me.GunaShadowPanel6.ResumeLayout(False)
        Me.GunaShadowPanel6.PerformLayout()
        Me.PNL_CURRENT_DISB_AMOUNT.ResumeLayout(False)
        Me.PNL_CURRENT_DISB_AMOUNT.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_DISBURSEMENT_LOGIN.ResumeLayout(False)
        Me.GunaShadowPanel5.ResumeLayout(False)
        Me.GunaShadowPanel5.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.PNL_UPDATE_PERMIT.ResumeLayout(False)
        Me.PNL_UPDATE_PERMIT.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_BenMain As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_benef_full_name As Label
    Friend WithEvents beneficiary_animatedWindow As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents LBL_STUD_ID As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_exit_account As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents tool_tip_exit As ToolTip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_disburse_amount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbo_purpose As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_disburse_amount As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PNL_DISBURSEMENT_LOGIN As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PNL_DISBURSE As Panel
    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_permit_no As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_amount_to_disburse As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cbo_purpose_of_money As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_submit_disburse As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_contract_id As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaShadowPanel4 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_total_disburse_amount As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_get_admin_fullname As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents pnl_current_disbursed_amount As Panel
    Friend WithEvents label As Label
    Friend WithEvents lbl_current_disbursed_amount As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents txt_dsbrsment_bpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_go As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_attention_bname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_search_beneficiary As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_Add_Beneficiary As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaShadowPanel5 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents LBL_ENTER_B_PASS As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_dsbursement_ben_login As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txt_disbursement_ben_pass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaShadowPanel7 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents CBO_GET_PURPOSE As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CBO_GET_CONTRACT_ID As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXT_NEW_PERMIT_NUMBER As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXT_NEW_DISBURSE_AMOUNT As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GunaShadowPanel6 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LBL_GET_DATE As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents LBL_ADMIN_NAME As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents LBL_GET_TOTAL_DISBURSED As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PNL_CURRENT_DISB_AMOUNT As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents LBL_GET_CURRENT_DISB_AMOUNT As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTN_SUBMIT_DISBURSEMENT As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PNL_UPDATE_PERMIT As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents BTN_UPDATE_PERMIT As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label11 As Label
    Friend WithEvents CBO_NO_PERMIT_CONT_ID As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents TXT_UPDATE_PERMIT_NUMBER As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBL_LEAVE_PERMITNUM_BLANK As Label
End Class
