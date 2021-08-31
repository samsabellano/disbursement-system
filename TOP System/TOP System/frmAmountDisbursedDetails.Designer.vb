<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAmountDisbursedDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.CBO_YEAR = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.CBO_MONTH = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DG_AMOUNT_DISBURSE_DETAILS = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DG_AMOUNT_DISBURSE_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.CBO_YEAR)
        Me.Panel1.Controls.Add(Me.GunaSeparator1)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.CBO_MONTH)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 333)
        Me.Panel1.TabIndex = 0
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(239, 16)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(31, 15)
        Me.GunaLabel3.TabIndex = 67
        Me.GunaLabel3.Text = "Year"
        '
        'CBO_YEAR
        '
        Me.CBO_YEAR.BackColor = System.Drawing.Color.Transparent
        Me.CBO_YEAR.BaseColor = System.Drawing.Color.White
        Me.CBO_YEAR.BorderColor = System.Drawing.Color.Gainsboro
        Me.CBO_YEAR.BorderSize = 1
        Me.CBO_YEAR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_YEAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_YEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_YEAR.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_YEAR.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_YEAR.ForeColor = System.Drawing.Color.Teal
        Me.CBO_YEAR.FormattingEnabled = True
        Me.CBO_YEAR.ItemHeight = 17
        Me.CBO_YEAR.Location = New System.Drawing.Point(276, 12)
        Me.CBO_YEAR.Name = "CBO_YEAR"
        Me.CBO_YEAR.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_YEAR.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_YEAR.Radius = 4
        Me.CBO_YEAR.Size = New System.Drawing.Size(133, 23)
        Me.CBO_YEAR.TabIndex = 68
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaSeparator1.Location = New System.Drawing.Point(9, 47)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(705, 10)
        Me.GunaSeparator1.TabIndex = 66
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 16)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(61, 15)
        Me.GunaLabel2.TabIndex = 63
        Me.GunaLabel2.Text = "Search by"
        '
        'CBO_MONTH
        '
        Me.CBO_MONTH.BackColor = System.Drawing.Color.Transparent
        Me.CBO_MONTH.BaseColor = System.Drawing.Color.White
        Me.CBO_MONTH.BorderColor = System.Drawing.Color.Gainsboro
        Me.CBO_MONTH.BorderSize = 1
        Me.CBO_MONTH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBO_MONTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_MONTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_MONTH.FocusedColor = System.Drawing.Color.Empty
        Me.CBO_MONTH.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_MONTH.ForeColor = System.Drawing.Color.Teal
        Me.CBO_MONTH.FormattingEnabled = True
        Me.CBO_MONTH.ItemHeight = 17
        Me.CBO_MONTH.Location = New System.Drawing.Point(79, 12)
        Me.CBO_MONTH.Name = "CBO_MONTH"
        Me.CBO_MONTH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_MONTH.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CBO_MONTH.Radius = 4
        Me.CBO_MONTH.Size = New System.Drawing.Size(133, 23)
        Me.CBO_MONTH.TabIndex = 65
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.DG_AMOUNT_DISBURSE_DETAILS)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(9, 57)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(709, 264)
        Me.Panel6.TabIndex = 64
        '
        'DG_AMOUNT_DISBURSE_DETAILS
        '
        Me.DG_AMOUNT_DISBURSE_DETAILS.AllowUserToAddRows = False
        Me.DG_AMOUNT_DISBURSE_DETAILS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DG_AMOUNT_DISBURSE_DETAILS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_AMOUNT_DISBURSE_DETAILS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_AMOUNT_DISBURSE_DETAILS.BackgroundColor = System.Drawing.Color.White
        Me.DG_AMOUNT_DISBURSE_DETAILS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_AMOUNT_DISBURSE_DETAILS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_AMOUNT_DISBURSE_DETAILS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_AMOUNT_DISBURSE_DETAILS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_AMOUNT_DISBURSE_DETAILS.ColumnHeadersHeight = 4
        Me.DG_AMOUNT_DISBURSE_DETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_AMOUNT_DISBURSE_DETAILS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_AMOUNT_DISBURSE_DETAILS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_AMOUNT_DISBURSE_DETAILS.EnableHeadersVisualStyles = False
        Me.DG_AMOUNT_DISBURSE_DETAILS.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DG_AMOUNT_DISBURSE_DETAILS.Location = New System.Drawing.Point(0, 38)
        Me.DG_AMOUNT_DISBURSE_DETAILS.Name = "DG_AMOUNT_DISBURSE_DETAILS"
        Me.DG_AMOUNT_DISBURSE_DETAILS.ReadOnly = True
        Me.DG_AMOUNT_DISBURSE_DETAILS.RowHeadersVisible = False
        Me.DG_AMOUNT_DISBURSE_DETAILS.RowTemplate.DividerHeight = 1
        Me.DG_AMOUNT_DISBURSE_DETAILS.RowTemplate.Height = 33
        Me.DG_AMOUNT_DISBURSE_DETAILS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_AMOUNT_DISBURSE_DETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_AMOUNT_DISBURSE_DETAILS.Size = New System.Drawing.Size(709, 226)
        Me.DG_AMOUNT_DISBURSE_DETAILS.TabIndex = 57
        Me.DG_AMOUNT_DISBURSE_DETAILS.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.HeaderStyle.Height = 4
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.ReadOnly = True
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.RowsStyle.Height = 33
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_AMOUNT_DISBURSE_DETAILS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.GunaLabel5)
        Me.Panel7.Controls.Add(Me.GunaLabel1)
        Me.Panel7.Controls.Add(Me.GunaLabel7)
        Me.Panel7.Controls.Add(Me.GunaLabel4)
        Me.Panel7.Controls.Add(Me.GunaLabel6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(709, 38)
        Me.Panel7.TabIndex = 56
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(166, 9)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(68, 14)
        Me.GunaLabel5.TabIndex = 58
        Me.GunaLabel5.Text = "Contract ID"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(437, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(65, 14)
        Me.GunaLabel1.TabIndex = 57
        Me.GunaLabel1.Text = "First Name"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(572, 9)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(62, 14)
        Me.GunaLabel7.TabIndex = 56
        Me.GunaLabel7.Text = "Last Name"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(318, 9)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(31, 14)
        Me.GunaLabel4.TabIndex = 54
        Me.GunaLabel4.Text = "Date"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Arial Nova", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(14, 9)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(108, 14)
        Me.GunaLabel6.TabIndex = 53
        Me.GunaLabel6.Text = "Amount Disbursed"
        '
        'frmAmountDisbursedDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 333)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAmountDisbursedDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAmountDisbursedDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.DG_AMOUNT_DISBURSE_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CBO_YEAR As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CBO_MONTH As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DG_AMOUNT_DISBURSE_DETAILS As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
End Class
