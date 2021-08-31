<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_Get_Name = New System.Windows.Forms.TextBox()
        Me.user_profile_pic = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btn_Logout = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PB_MINIMIZE = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_NavBar = New Guna.UI.WinForms.GunaPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PNL_LBL_BENEFICIARY = New System.Windows.Forms.Panel()
        Me.LBL_BENEFICIARY = New Guna.UI.WinForms.GunaLabel()
        Me.btn_Dashboard = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_Beneficiary = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_ContractManagement = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_Disbursement = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_Return = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PNL_LBL_ADMIN = New System.Windows.Forms.Panel()
        Me.LBL_ADMIN = New Guna.UI.WinForms.GunaLabel()
        Me.BTN_MANAGE_ADMIN = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_ADD_ADMIN = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_UPDATE_ADMIN = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTN_UPDATE_SY = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBL_MENU = New System.Windows.Forms.Label()
        Me.btn_hideNavBar = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_showNavBar = New Guna.UI.WinForms.GunaCircleButton()
        Me.pnl_main = New Guna.UI.WinForms.GunaPanel()
        Me.Ttip_Dashboard = New System.Windows.Forms.ToolTip(Me.components)
        Me.Ttip_Beneficiary = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tttip_Contract = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tttip_Disbursement = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tttip_Loan_Return = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tttip_Manage_Admin = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tttip_Add_new_admin = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tttip_Update_admin_account = New System.Windows.Forms.ToolTip(Me.components)
        Me.GunaPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.user_profile_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_MINIMIZE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_NavBar.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PNL_LBL_BENEFICIARY.SuspendLayout()
        Me.PNL_LBL_ADMIN.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.Panel4)
        Me.GunaPanel1.Controls.Add(Me.Panel3)
        Me.GunaPanel1.Controls.Add(Me.Panel1)
        Me.GunaPanel1.Controls.Add(Me.Label3)
        Me.GunaPanel1.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.GunaPanel1, "GunaPanel1")
        Me.GunaPanel1.Name = "GunaPanel1"
        '
        'Panel4
        '
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Controls.Add(Me.lbl_Date)
        Me.Panel4.Controls.Add(Me.lbl_Time)
        Me.Panel4.Name = "Panel4"
        '
        'lbl_Date
        '
        resources.ApplyResources(Me.lbl_Date, "lbl_Date")
        Me.lbl_Date.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Date.Name = "lbl_Date"
        '
        'lbl_Time
        '
        resources.ApplyResources(Me.lbl_Time, "lbl_Time")
        Me.lbl_Time.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Time.Name = "lbl_Time"
        '
        'Panel3
        '
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Controls.Add(Me.txt_Get_Name)
        Me.Panel3.Controls.Add(Me.user_profile_pic)
        Me.Panel3.Controls.Add(Me.btn_Logout)
        Me.Panel3.Name = "Panel3"
        '
        'txt_Get_Name
        '
        resources.ApplyResources(Me.txt_Get_Name, "txt_Get_Name")
        Me.txt_Get_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_Get_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Get_Name.ForeColor = System.Drawing.Color.Gainsboro
        Me.txt_Get_Name.Name = "txt_Get_Name"
        '
        'user_profile_pic
        '
        Me.user_profile_pic.BaseColor = System.Drawing.Color.White
        resources.ApplyResources(Me.user_profile_pic, "user_profile_pic")
        Me.user_profile_pic.Name = "user_profile_pic"
        Me.user_profile_pic.TabStop = False
        Me.user_profile_pic.UseTransfarantBackground = False
        '
        'btn_Logout
        '
        resources.ApplyResources(Me.btn_Logout, "btn_Logout")
        Me.btn_Logout.Animated = True
        Me.btn_Logout.AnimationHoverSpeed = 0.07!
        Me.btn_Logout.AnimationSpeed = 0.03!
        Me.btn_Logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_Logout.BaseColor = System.Drawing.Color.Transparent
        Me.btn_Logout.BorderColor = System.Drawing.Color.Transparent
        Me.btn_Logout.BorderSize = 1
        Me.btn_Logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Logout.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Logout.ForeColor = System.Drawing.Color.White
        Me.btn_Logout.Image = CType(resources.GetObject("btn_Logout.Image"), System.Drawing.Image)
        Me.btn_Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_Logout.ImageSize = New System.Drawing.Size(18, 18)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_Logout.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_Logout.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Logout.OnHoverImage = Nothing
        Me.btn_Logout.OnPressedColor = System.Drawing.Color.RoyalBlue
        Me.btn_Logout.Radius = 15
        Me.btn_Logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.PB_MINIMIZE)
        Me.Panel1.Name = "Panel1"
        '
        'PB_MINIMIZE
        '
        resources.ApplyResources(Me.PB_MINIMIZE, "PB_MINIMIZE")
        Me.PB_MINIMIZE.Name = "PB_MINIMIZE"
        Me.PB_MINIMIZE.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'pnl_NavBar
        '
        Me.pnl_NavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_NavBar.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnl_NavBar.Controls.Add(Me.Panel2)
        resources.ApplyResources(Me.pnl_NavBar, "pnl_NavBar")
        Me.pnl_NavBar.Name = "pnl_NavBar"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.PNL_LBL_BENEFICIARY)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Dashboard)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Beneficiary)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_ContractManagement)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Disbursement)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Return)
        Me.FlowLayoutPanel1.Controls.Add(Me.PNL_LBL_ADMIN)
        Me.FlowLayoutPanel1.Controls.Add(Me.BTN_MANAGE_ADMIN)
        Me.FlowLayoutPanel1.Controls.Add(Me.BTN_ADD_ADMIN)
        Me.FlowLayoutPanel1.Controls.Add(Me.BTN_UPDATE_ADMIN)
        Me.FlowLayoutPanel1.Controls.Add(Me.BTN_UPDATE_SY)
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'PNL_LBL_BENEFICIARY
        '
        Me.PNL_LBL_BENEFICIARY.Controls.Add(Me.LBL_BENEFICIARY)
        resources.ApplyResources(Me.PNL_LBL_BENEFICIARY, "PNL_LBL_BENEFICIARY")
        Me.PNL_LBL_BENEFICIARY.Name = "PNL_LBL_BENEFICIARY"
        '
        'LBL_BENEFICIARY
        '
        resources.ApplyResources(Me.LBL_BENEFICIARY, "LBL_BENEFICIARY")
        Me.LBL_BENEFICIARY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.LBL_BENEFICIARY.Name = "LBL_BENEFICIARY"
        '
        'btn_Dashboard
        '
        Me.btn_Dashboard.Animated = True
        Me.btn_Dashboard.AnimationHoverSpeed = 0.07!
        Me.btn_Dashboard.AnimationSpeed = 0.03!
        Me.btn_Dashboard.BackColor = System.Drawing.Color.Transparent
        Me.btn_Dashboard.BaseColor = System.Drawing.Color.Transparent
        Me.btn_Dashboard.BorderColor = System.Drawing.Color.Black
        Me.btn_Dashboard.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btn_Dashboard.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_Dashboard.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_Dashboard.CheckedForeColor = System.Drawing.Color.Silver
        Me.btn_Dashboard.CheckedImage = CType(resources.GetObject("btn_Dashboard.CheckedImage"), System.Drawing.Image)
        Me.btn_Dashboard.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Dashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Dashboard.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.btn_Dashboard, "btn_Dashboard")
        Me.btn_Dashboard.ForeColor = System.Drawing.Color.Silver
        Me.btn_Dashboard.Image = CType(resources.GetObject("btn_Dashboard.Image"), System.Drawing.Image)
        Me.btn_Dashboard.ImageOffsetX = 18
        Me.btn_Dashboard.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_Dashboard.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_Dashboard.LineLeft = 3
        Me.btn_Dashboard.Name = "btn_Dashboard"
        Me.btn_Dashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Dashboard.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Dashboard.OnHoverForeColor = System.Drawing.Color.Silver
        Me.btn_Dashboard.OnHoverImage = Nothing
        Me.btn_Dashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Dashboard.OnPressedColor = System.Drawing.Color.Black
        '
        'btn_Beneficiary
        '
        Me.btn_Beneficiary.Animated = True
        Me.btn_Beneficiary.AnimationHoverSpeed = 0.07!
        Me.btn_Beneficiary.AnimationSpeed = 0.03!
        Me.btn_Beneficiary.BackColor = System.Drawing.Color.Transparent
        Me.btn_Beneficiary.BaseColor = System.Drawing.Color.Transparent
        Me.btn_Beneficiary.BorderColor = System.Drawing.Color.Black
        Me.btn_Beneficiary.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btn_Beneficiary.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_Beneficiary.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_Beneficiary.CheckedForeColor = System.Drawing.Color.Silver
        Me.btn_Beneficiary.CheckedImage = CType(resources.GetObject("btn_Beneficiary.CheckedImage"), System.Drawing.Image)
        Me.btn_Beneficiary.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Beneficiary.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Beneficiary.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Beneficiary.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.btn_Beneficiary, "btn_Beneficiary")
        Me.btn_Beneficiary.ForeColor = System.Drawing.Color.Silver
        Me.btn_Beneficiary.Image = CType(resources.GetObject("btn_Beneficiary.Image"), System.Drawing.Image)
        Me.btn_Beneficiary.ImageOffsetX = 18
        Me.btn_Beneficiary.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_Beneficiary.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_Beneficiary.LineLeft = 3
        Me.btn_Beneficiary.Name = "btn_Beneficiary"
        Me.btn_Beneficiary.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Beneficiary.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Beneficiary.OnHoverForeColor = System.Drawing.Color.Silver
        Me.btn_Beneficiary.OnHoverImage = Nothing
        Me.btn_Beneficiary.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Beneficiary.OnPressedColor = System.Drawing.Color.Black
        '
        'btn_ContractManagement
        '
        Me.btn_ContractManagement.Animated = True
        Me.btn_ContractManagement.AnimationHoverSpeed = 0.07!
        Me.btn_ContractManagement.AnimationSpeed = 0.03!
        Me.btn_ContractManagement.BackColor = System.Drawing.Color.Transparent
        Me.btn_ContractManagement.BaseColor = System.Drawing.Color.Transparent
        Me.btn_ContractManagement.BorderColor = System.Drawing.Color.Black
        Me.btn_ContractManagement.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btn_ContractManagement.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_ContractManagement.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_ContractManagement.CheckedForeColor = System.Drawing.Color.Silver
        Me.btn_ContractManagement.CheckedImage = CType(resources.GetObject("btn_ContractManagement.CheckedImage"), System.Drawing.Image)
        Me.btn_ContractManagement.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_ContractManagement.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ContractManagement.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_ContractManagement.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.btn_ContractManagement, "btn_ContractManagement")
        Me.btn_ContractManagement.ForeColor = System.Drawing.Color.Silver
        Me.btn_ContractManagement.Image = CType(resources.GetObject("btn_ContractManagement.Image"), System.Drawing.Image)
        Me.btn_ContractManagement.ImageOffsetX = 18
        Me.btn_ContractManagement.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_ContractManagement.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_ContractManagement.LineLeft = 3
        Me.btn_ContractManagement.Name = "btn_ContractManagement"
        Me.btn_ContractManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ContractManagement.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_ContractManagement.OnHoverForeColor = System.Drawing.Color.Silver
        Me.btn_ContractManagement.OnHoverImage = Nothing
        Me.btn_ContractManagement.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_ContractManagement.OnPressedColor = System.Drawing.Color.Black
        '
        'btn_Disbursement
        '
        Me.btn_Disbursement.Animated = True
        Me.btn_Disbursement.AnimationHoverSpeed = 0.07!
        Me.btn_Disbursement.AnimationSpeed = 0.03!
        Me.btn_Disbursement.BackColor = System.Drawing.Color.Transparent
        Me.btn_Disbursement.BaseColor = System.Drawing.Color.Transparent
        Me.btn_Disbursement.BorderColor = System.Drawing.Color.Black
        Me.btn_Disbursement.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btn_Disbursement.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_Disbursement.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_Disbursement.CheckedForeColor = System.Drawing.Color.Silver
        Me.btn_Disbursement.CheckedImage = CType(resources.GetObject("btn_Disbursement.CheckedImage"), System.Drawing.Image)
        Me.btn_Disbursement.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Disbursement.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Disbursement.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Disbursement.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.btn_Disbursement, "btn_Disbursement")
        Me.btn_Disbursement.ForeColor = System.Drawing.Color.Silver
        Me.btn_Disbursement.Image = CType(resources.GetObject("btn_Disbursement.Image"), System.Drawing.Image)
        Me.btn_Disbursement.ImageOffsetX = 18
        Me.btn_Disbursement.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_Disbursement.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_Disbursement.LineLeft = 3
        Me.btn_Disbursement.Name = "btn_Disbursement"
        Me.btn_Disbursement.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Disbursement.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Disbursement.OnHoverForeColor = System.Drawing.Color.Silver
        Me.btn_Disbursement.OnHoverImage = Nothing
        Me.btn_Disbursement.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Disbursement.OnPressedColor = System.Drawing.Color.Black
        '
        'btn_Return
        '
        Me.btn_Return.Animated = True
        Me.btn_Return.AnimationHoverSpeed = 0.07!
        Me.btn_Return.AnimationSpeed = 0.03!
        Me.btn_Return.BackColor = System.Drawing.Color.Transparent
        Me.btn_Return.BaseColor = System.Drawing.Color.Transparent
        Me.btn_Return.BorderColor = System.Drawing.Color.Black
        Me.btn_Return.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btn_Return.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_Return.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_Return.CheckedForeColor = System.Drawing.Color.Silver
        Me.btn_Return.CheckedImage = CType(resources.GetObject("btn_Return.CheckedImage"), System.Drawing.Image)
        Me.btn_Return.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Return.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Return.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Return.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.btn_Return, "btn_Return")
        Me.btn_Return.ForeColor = System.Drawing.Color.Silver
        Me.btn_Return.Image = CType(resources.GetObject("btn_Return.Image"), System.Drawing.Image)
        Me.btn_Return.ImageOffsetX = 18
        Me.btn_Return.ImageSize = New System.Drawing.Size(23, 23)
        Me.btn_Return.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_Return.LineLeft = 3
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Return.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Return.OnHoverForeColor = System.Drawing.Color.Silver
        Me.btn_Return.OnHoverImage = Nothing
        Me.btn_Return.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_Return.OnPressedColor = System.Drawing.Color.Black
        '
        'PNL_LBL_ADMIN
        '
        Me.PNL_LBL_ADMIN.Controls.Add(Me.LBL_ADMIN)
        resources.ApplyResources(Me.PNL_LBL_ADMIN, "PNL_LBL_ADMIN")
        Me.PNL_LBL_ADMIN.Name = "PNL_LBL_ADMIN"
        '
        'LBL_ADMIN
        '
        resources.ApplyResources(Me.LBL_ADMIN, "LBL_ADMIN")
        Me.LBL_ADMIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.LBL_ADMIN.Name = "LBL_ADMIN"
        '
        'BTN_MANAGE_ADMIN
        '
        Me.BTN_MANAGE_ADMIN.Animated = True
        Me.BTN_MANAGE_ADMIN.AnimationHoverSpeed = 0.07!
        Me.BTN_MANAGE_ADMIN.AnimationSpeed = 0.03!
        Me.BTN_MANAGE_ADMIN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_MANAGE_ADMIN.BaseColor = System.Drawing.Color.Transparent
        Me.BTN_MANAGE_ADMIN.BorderColor = System.Drawing.Color.Black
        Me.BTN_MANAGE_ADMIN.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton
        Me.BTN_MANAGE_ADMIN.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_MANAGE_ADMIN.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_MANAGE_ADMIN.CheckedForeColor = System.Drawing.Color.Silver
        Me.BTN_MANAGE_ADMIN.CheckedImage = CType(resources.GetObject("BTN_MANAGE_ADMIN.CheckedImage"), System.Drawing.Image)
        Me.BTN_MANAGE_ADMIN.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_MANAGE_ADMIN.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_MANAGE_ADMIN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_MANAGE_ADMIN.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.BTN_MANAGE_ADMIN, "BTN_MANAGE_ADMIN")
        Me.BTN_MANAGE_ADMIN.ForeColor = System.Drawing.Color.Silver
        Me.BTN_MANAGE_ADMIN.Image = CType(resources.GetObject("BTN_MANAGE_ADMIN.Image"), System.Drawing.Image)
        Me.BTN_MANAGE_ADMIN.ImageOffsetX = 18
        Me.BTN_MANAGE_ADMIN.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_MANAGE_ADMIN.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTN_MANAGE_ADMIN.LineLeft = 3
        Me.BTN_MANAGE_ADMIN.Name = "BTN_MANAGE_ADMIN"
        Me.BTN_MANAGE_ADMIN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_MANAGE_ADMIN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_MANAGE_ADMIN.OnHoverForeColor = System.Drawing.Color.Silver
        Me.BTN_MANAGE_ADMIN.OnHoverImage = Nothing
        Me.BTN_MANAGE_ADMIN.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_MANAGE_ADMIN.OnPressedColor = System.Drawing.Color.Black
        '
        'BTN_ADD_ADMIN
        '
        Me.BTN_ADD_ADMIN.Animated = True
        Me.BTN_ADD_ADMIN.AnimationHoverSpeed = 0.07!
        Me.BTN_ADD_ADMIN.AnimationSpeed = 0.03!
        Me.BTN_ADD_ADMIN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ADD_ADMIN.BaseColor = System.Drawing.Color.Transparent
        Me.BTN_ADD_ADMIN.BorderColor = System.Drawing.Color.Black
        Me.BTN_ADD_ADMIN.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_ADD_ADMIN.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_ADD_ADMIN.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_ADD_ADMIN.CheckedForeColor = System.Drawing.Color.Silver
        Me.BTN_ADD_ADMIN.CheckedImage = CType(resources.GetObject("BTN_ADD_ADMIN.CheckedImage"), System.Drawing.Image)
        Me.BTN_ADD_ADMIN.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_ADD_ADMIN.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_ADD_ADMIN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_ADD_ADMIN.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.BTN_ADD_ADMIN, "BTN_ADD_ADMIN")
        Me.BTN_ADD_ADMIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTN_ADD_ADMIN.Image = CType(resources.GetObject("BTN_ADD_ADMIN.Image"), System.Drawing.Image)
        Me.BTN_ADD_ADMIN.ImageOffsetX = 47
        Me.BTN_ADD_ADMIN.ImageSize = New System.Drawing.Size(19, 19)
        Me.BTN_ADD_ADMIN.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTN_ADD_ADMIN.LineLeft = 3
        Me.BTN_ADD_ADMIN.Name = "BTN_ADD_ADMIN"
        Me.BTN_ADD_ADMIN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_ADD_ADMIN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_ADD_ADMIN.OnHoverForeColor = System.Drawing.Color.Silver
        Me.BTN_ADD_ADMIN.OnHoverImage = Nothing
        Me.BTN_ADD_ADMIN.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_ADD_ADMIN.OnPressedColor = System.Drawing.Color.Black
        '
        'BTN_UPDATE_ADMIN
        '
        Me.BTN_UPDATE_ADMIN.Animated = True
        Me.BTN_UPDATE_ADMIN.AnimationHoverSpeed = 0.07!
        Me.BTN_UPDATE_ADMIN.AnimationSpeed = 0.03!
        Me.BTN_UPDATE_ADMIN.BackColor = System.Drawing.Color.Transparent
        Me.BTN_UPDATE_ADMIN.BaseColor = System.Drawing.Color.Transparent
        Me.BTN_UPDATE_ADMIN.BorderColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_ADMIN.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_UPDATE_ADMIN.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_UPDATE_ADMIN.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_ADMIN.CheckedForeColor = System.Drawing.Color.Silver
        Me.BTN_UPDATE_ADMIN.CheckedImage = CType(resources.GetObject("BTN_UPDATE_ADMIN.CheckedImage"), System.Drawing.Image)
        Me.BTN_UPDATE_ADMIN.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_UPDATE_ADMIN.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_UPDATE_ADMIN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_UPDATE_ADMIN.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.BTN_UPDATE_ADMIN, "BTN_UPDATE_ADMIN")
        Me.BTN_UPDATE_ADMIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTN_UPDATE_ADMIN.Image = CType(resources.GetObject("BTN_UPDATE_ADMIN.Image"), System.Drawing.Image)
        Me.BTN_UPDATE_ADMIN.ImageOffsetX = 47
        Me.BTN_UPDATE_ADMIN.ImageSize = New System.Drawing.Size(19, 19)
        Me.BTN_UPDATE_ADMIN.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTN_UPDATE_ADMIN.LineLeft = 3
        Me.BTN_UPDATE_ADMIN.Name = "BTN_UPDATE_ADMIN"
        Me.BTN_UPDATE_ADMIN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_UPDATE_ADMIN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_ADMIN.OnHoverForeColor = System.Drawing.Color.Silver
        Me.BTN_UPDATE_ADMIN.OnHoverImage = Nothing
        Me.BTN_UPDATE_ADMIN.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_UPDATE_ADMIN.OnPressedColor = System.Drawing.Color.Black
        '
        'BTN_UPDATE_SY
        '
        Me.BTN_UPDATE_SY.Animated = True
        Me.BTN_UPDATE_SY.AnimationHoverSpeed = 0.07!
        Me.BTN_UPDATE_SY.AnimationSpeed = 0.03!
        Me.BTN_UPDATE_SY.BackColor = System.Drawing.Color.Transparent
        Me.BTN_UPDATE_SY.BaseColor = System.Drawing.Color.Transparent
        Me.BTN_UPDATE_SY.BorderColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_SY.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.BTN_UPDATE_SY.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_UPDATE_SY.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_SY.CheckedForeColor = System.Drawing.Color.Silver
        Me.BTN_UPDATE_SY.CheckedImage = CType(resources.GetObject("BTN_UPDATE_SY.CheckedImage"), System.Drawing.Image)
        Me.BTN_UPDATE_SY.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_UPDATE_SY.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_UPDATE_SY.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_UPDATE_SY.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.BTN_UPDATE_SY, "BTN_UPDATE_SY")
        Me.BTN_UPDATE_SY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTN_UPDATE_SY.Image = CType(resources.GetObject("BTN_UPDATE_SY.Image"), System.Drawing.Image)
        Me.BTN_UPDATE_SY.ImageOffsetX = 47
        Me.BTN_UPDATE_SY.ImageSize = New System.Drawing.Size(19, 19)
        Me.BTN_UPDATE_SY.LineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTN_UPDATE_SY.LineLeft = 3
        Me.BTN_UPDATE_SY.Name = "BTN_UPDATE_SY"
        Me.BTN_UPDATE_SY.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_UPDATE_SY.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_UPDATE_SY.OnHoverForeColor = System.Drawing.Color.Silver
        Me.BTN_UPDATE_SY.OnHoverImage = Nothing
        Me.BTN_UPDATE_SY.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.BTN_UPDATE_SY.OnPressedColor = System.Drawing.Color.Black
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LBL_MENU)
        Me.Panel2.Controls.Add(Me.btn_hideNavBar)
        Me.Panel2.Controls.Add(Me.btn_showNavBar)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'LBL_MENU
        '
        resources.ApplyResources(Me.LBL_MENU, "LBL_MENU")
        Me.LBL_MENU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_MENU.Name = "LBL_MENU"
        '
        'btn_hideNavBar
        '
        Me.btn_hideNavBar.AnimationHoverSpeed = 0.15!
        Me.btn_hideNavBar.AnimationSpeed = 0.08!
        Me.btn_hideNavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_hideNavBar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_hideNavBar.BorderColor = System.Drawing.Color.Black
        Me.btn_hideNavBar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_hideNavBar.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.btn_hideNavBar, "btn_hideNavBar")
        Me.btn_hideNavBar.ForeColor = System.Drawing.Color.White
        Me.btn_hideNavBar.Image = CType(resources.GetObject("btn_hideNavBar.Image"), System.Drawing.Image)
        Me.btn_hideNavBar.ImageSize = New System.Drawing.Size(9, 9)
        Me.btn_hideNavBar.Name = "btn_hideNavBar"
        Me.btn_hideNavBar.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_hideNavBar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_hideNavBar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_hideNavBar.OnHoverImage = Nothing
        Me.btn_hideNavBar.OnPressedColor = System.Drawing.Color.Black
        '
        'btn_showNavBar
        '
        Me.btn_showNavBar.Animated = True
        Me.btn_showNavBar.AnimationHoverSpeed = 0.07!
        Me.btn_showNavBar.AnimationSpeed = 0.03!
        Me.btn_showNavBar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_showNavBar.BorderColor = System.Drawing.Color.Black
        Me.btn_showNavBar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_showNavBar.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.btn_showNavBar, "btn_showNavBar")
        Me.btn_showNavBar.ForeColor = System.Drawing.Color.White
        Me.btn_showNavBar.Image = CType(resources.GetObject("btn_showNavBar.Image"), System.Drawing.Image)
        Me.btn_showNavBar.ImageSize = New System.Drawing.Size(18, 18)
        Me.btn_showNavBar.Name = "btn_showNavBar"
        Me.btn_showNavBar.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_showNavBar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_showNavBar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_showNavBar.OnHoverImage = Nothing
        Me.btn_showNavBar.OnPressedColor = System.Drawing.Color.Black
        '
        'pnl_main
        '
        Me.pnl_main.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.pnl_main, "pnl_main")
        Me.pnl_main.Name = "pnl_main"
        '
        'Ttip_Dashboard
        '
        Me.Ttip_Dashboard.AutomaticDelay = 200
        Me.Ttip_Dashboard.AutoPopDelay = 5000
        Me.Ttip_Dashboard.InitialDelay = 200
        Me.Ttip_Dashboard.IsBalloon = True
        Me.Ttip_Dashboard.ReshowDelay = 40
        '
        'Ttip_Beneficiary
        '
        Me.Ttip_Beneficiary.AutomaticDelay = 200
        Me.Ttip_Beneficiary.AutoPopDelay = 5000
        Me.Ttip_Beneficiary.InitialDelay = 200
        Me.Ttip_Beneficiary.IsBalloon = True
        Me.Ttip_Beneficiary.ReshowDelay = 40
        '
        'Tttip_Contract
        '
        Me.Tttip_Contract.AutomaticDelay = 200
        Me.Tttip_Contract.AutoPopDelay = 5000
        Me.Tttip_Contract.InitialDelay = 200
        Me.Tttip_Contract.IsBalloon = True
        Me.Tttip_Contract.ReshowDelay = 40
        '
        'Tttip_Disbursement
        '
        Me.Tttip_Disbursement.AutomaticDelay = 200
        Me.Tttip_Disbursement.AutoPopDelay = 5000
        Me.Tttip_Disbursement.InitialDelay = 200
        Me.Tttip_Disbursement.IsBalloon = True
        Me.Tttip_Disbursement.ReshowDelay = 40
        '
        'Tttip_Loan_Return
        '
        Me.Tttip_Loan_Return.AutomaticDelay = 200
        Me.Tttip_Loan_Return.AutoPopDelay = 5000
        Me.Tttip_Loan_Return.InitialDelay = 200
        Me.Tttip_Loan_Return.IsBalloon = True
        Me.Tttip_Loan_Return.ReshowDelay = 40
        '
        'Tttip_Manage_Admin
        '
        Me.Tttip_Manage_Admin.AutomaticDelay = 200
        Me.Tttip_Manage_Admin.AutoPopDelay = 5000
        Me.Tttip_Manage_Admin.InitialDelay = 200
        Me.Tttip_Manage_Admin.IsBalloon = True
        Me.Tttip_Manage_Admin.ReshowDelay = 40
        '
        'Tttip_Add_new_admin
        '
        Me.Tttip_Add_new_admin.AutomaticDelay = 200
        Me.Tttip_Add_new_admin.AutoPopDelay = 5000
        Me.Tttip_Add_new_admin.InitialDelay = 200
        Me.Tttip_Add_new_admin.IsBalloon = True
        Me.Tttip_Add_new_admin.ReshowDelay = 40
        '
        'Tttip_Update_admin_account
        '
        Me.Tttip_Update_admin_account.AutomaticDelay = 200
        Me.Tttip_Update_admin_account.AutoPopDelay = 5000
        Me.Tttip_Update_admin_account.InitialDelay = 200
        Me.Tttip_Update_admin_account.IsBalloon = True
        Me.Tttip_Update_admin_account.ReshowDelay = 40
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.pnl_NavBar)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.user_profile_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PB_MINIMIZE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_NavBar.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PNL_LBL_BENEFICIARY.ResumeLayout(False)
        Me.PNL_LBL_BENEFICIARY.PerformLayout()
        Me.PNL_LBL_ADMIN.ResumeLayout(False)
        Me.PNL_LBL_ADMIN.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_NavBar As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnl_main As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btn_Dashboard As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_ContractManagement As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PB_MINIMIZE As PictureBox
    Friend WithEvents btn_Logout As Guna.UI.WinForms.GunaButton
    Friend WithEvents user_profile_pic As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Beneficiary As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Ttip_Dashboard As ToolTip
    Friend WithEvents Ttip_Beneficiary As ToolTip
    Friend WithEvents Tttip_Contract As ToolTip
    Friend WithEvents btn_Disbursement As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Tttip_Disbursement As ToolTip
    Friend WithEvents btn_hideNavBar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_showNavBar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_Date As Label
    Friend WithEvents lbl_Time As Label
    Friend WithEvents LBL_MENU As Label
    Friend WithEvents txt_Get_Name As TextBox
    Friend WithEvents btn_Return As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents LBL_BENEFICIARY As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PNL_LBL_BENEFICIARY As Panel
    Friend WithEvents PNL_LBL_ADMIN As Panel
    Friend WithEvents LBL_ADMIN As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTN_MANAGE_ADMIN As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_ADD_ADMIN As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTN_UPDATE_ADMIN As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Tttip_Loan_Return As ToolTip
    Friend WithEvents Tttip_Manage_Admin As ToolTip
    Friend WithEvents Tttip_Add_new_admin As ToolTip
    Friend WithEvents Tttip_Update_admin_account As ToolTip
    Friend WithEvents BTN_UPDATE_SY As Guna.UI.WinForms.GunaAdvenceButton
End Class
