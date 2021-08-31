<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContractHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContractHistory))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL_CONTRACT_ID = New Guna.UI.WinForms.GunaShadowPanel()
        Me.BTN_BACK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DG_CONTRACT_HISTORY = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PNL_CONTRACT_ID.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DG_CONTRACT_HISTORY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL_CONTRACT_ID
        '
        Me.PNL_CONTRACT_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_CONTRACT_ID.BackColor = System.Drawing.Color.Transparent
        Me.PNL_CONTRACT_ID.BaseColor = System.Drawing.Color.White
        Me.PNL_CONTRACT_ID.Controls.Add(Me.BTN_BACK)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.GunaLabel1)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.GunaSeparator1)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.Panel2)
        Me.PNL_CONTRACT_ID.Controls.Add(Me.Label1)
        Me.PNL_CONTRACT_ID.Location = New System.Drawing.Point(40, 39)
        Me.PNL_CONTRACT_ID.Name = "PNL_CONTRACT_ID"
        Me.PNL_CONTRACT_ID.Radius = 4
        Me.PNL_CONTRACT_ID.ShadowColor = System.Drawing.Color.Blue
        Me.PNL_CONTRACT_ID.ShadowDepth = 0
        Me.PNL_CONTRACT_ID.ShadowShift = 0
        Me.PNL_CONTRACT_ID.Size = New System.Drawing.Size(1007, 523)
        Me.PNL_CONTRACT_ID.TabIndex = 66
        '
        'BTN_BACK
        '
        Me.BTN_BACK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.BTN_BACK.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_BACK.Image = Nothing
        Me.BTN_BACK.ImageSize = New System.Drawing.Size(23, 23)
        Me.BTN_BACK.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_BACK.Location = New System.Drawing.Point(896, 28)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.OnHoverBaseColor = System.Drawing.Color.White
        Me.BTN_BACK.OnHoverBorderColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.OnHoverForeColor = System.Drawing.Color.DimGray
        Me.BTN_BACK.OnHoverImage = Nothing
        Me.BTN_BACK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_BACK.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_BACK.Radius = 5
        Me.BTN_BACK.Size = New System.Drawing.Size(70, 25)
        Me.BTN_BACK.TabIndex = 109
        Me.BTN_BACK.Text = "Back"
        Me.BTN_BACK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(38, 28)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(159, 23)
        Me.GunaLabel1.TabIndex = 73
        Me.GunaLabel1.Text = "Contract History"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(42, 58)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(924, 10)
        Me.GunaSeparator1.TabIndex = 70
        Me.GunaSeparator1.Thickness = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DG_CONTRACT_HISTORY)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Location = New System.Drawing.Point(42, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 419)
        Me.Panel2.TabIndex = 69
        '
        'DG_CONTRACT_HISTORY
        '
        Me.DG_CONTRACT_HISTORY.AllowUserToAddRows = False
        Me.DG_CONTRACT_HISTORY.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.DG_CONTRACT_HISTORY.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DG_CONTRACT_HISTORY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_CONTRACT_HISTORY.BackgroundColor = System.Drawing.Color.White
        Me.DG_CONTRACT_HISTORY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_CONTRACT_HISTORY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_CONTRACT_HISTORY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_CONTRACT_HISTORY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DG_CONTRACT_HISTORY.ColumnHeadersHeight = 4
        Me.DG_CONTRACT_HISTORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_CONTRACT_HISTORY.DefaultCellStyle = DataGridViewCellStyle12
        Me.DG_CONTRACT_HISTORY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_CONTRACT_HISTORY.EnableHeadersVisualStyles = False
        Me.DG_CONTRACT_HISTORY.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DG_CONTRACT_HISTORY.Location = New System.Drawing.Point(0, 33)
        Me.DG_CONTRACT_HISTORY.Name = "DG_CONTRACT_HISTORY"
        Me.DG_CONTRACT_HISTORY.ReadOnly = True
        Me.DG_CONTRACT_HISTORY.RowHeadersVisible = False
        Me.DG_CONTRACT_HISTORY.RowTemplate.DividerHeight = 1
        Me.DG_CONTRACT_HISTORY.RowTemplate.Height = 40
        Me.DG_CONTRACT_HISTORY.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_CONTRACT_HISTORY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CONTRACT_HISTORY.Size = New System.Drawing.Size(924, 386)
        Me.DG_CONTRACT_HISTORY.TabIndex = 58
        Me.DG_CONTRACT_HISTORY.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DG_CONTRACT_HISTORY.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_CONTRACT_HISTORY.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DG_CONTRACT_HISTORY.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DG_CONTRACT_HISTORY.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DG_CONTRACT_HISTORY.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DG_CONTRACT_HISTORY.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DG_CONTRACT_HISTORY.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DG_CONTRACT_HISTORY.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_CONTRACT_HISTORY.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_CONTRACT_HISTORY.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_CONTRACT_HISTORY.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DG_CONTRACT_HISTORY.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DG_CONTRACT_HISTORY.ThemeStyle.HeaderStyle.Height = 4
        Me.DG_CONTRACT_HISTORY.ThemeStyle.ReadOnly = True
        Me.DG_CONTRACT_HISTORY.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_CONTRACT_HISTORY.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_CONTRACT_HISTORY.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_CONTRACT_HISTORY.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DG_CONTRACT_HISTORY.ThemeStyle.RowsStyle.Height = 40
        Me.DG_CONTRACT_HISTORY.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_CONTRACT_HISTORY.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.GunaLabel15)
        Me.Panel7.Controls.Add(Me.GunaLabel3)
        Me.Panel7.Controls.Add(Me.GunaLabel8)
        Me.Panel7.Controls.Add(Me.GunaLabel7)
        Me.Panel7.Controls.Add(Me.GunaLabel4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(924, 33)
        Me.Panel7.TabIndex = 57
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel15.Location = New System.Drawing.Point(390, 9)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel15.TabIndex = 59
        Me.GunaLabel15.Text = "Last Name"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(778, 9)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(58, 15)
        Me.GunaLabel3.TabIndex = 58
        Me.GunaLabel3.Text = "End Date"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(583, 9)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel8.TabIndex = 57
        Me.GunaLabel8.Text = "Start Date"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(196, 9)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel7.TabIndex = 56
        Me.GunaLabel7.Text = "First Name"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(6, 9)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(73, 15)
        Me.GunaLabel4.TabIndex = 54
        Me.GunaLabel4.Text = "Contract ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(234, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 65
        '
        'frmContractHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1088, 588)
        Me.Controls.Add(Me.PNL_CONTRACT_ID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmContractHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmContractHistory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNL_CONTRACT_ID.ResumeLayout(False)
        Me.PNL_CONTRACT_ID.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DG_CONTRACT_HISTORY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL_CONTRACT_ID As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DG_CONTRACT_HISTORY As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents BTN_BACK As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
