<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeneficiaryEmergencyContact
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.TXT_EC_RELATIONSHIP = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_EC_CNUMBER = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_EC_LNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.TXT_EC_FNAME = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_DATE_CREATED = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 431)
        Me.Panel1.TabIndex = 107
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.GunaVSeparator1)
        Me.Panel2.Controls.Add(Me.TXT_EC_RELATIONSHIP)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TXT_EC_CNUMBER)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TXT_EC_LNAME)
        Me.Panel2.Controls.Add(Me.TXT_EC_FNAME)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LBL_DATE_CREATED)
        Me.Panel2.Location = New System.Drawing.Point(38, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 407)
        Me.Panel2.TabIndex = 137
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GunaVSeparator1.Location = New System.Drawing.Point(31, 32)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 202)
        Me.GunaVSeparator1.TabIndex = 170
        Me.GunaVSeparator1.Thickness = 2
        '
        'TXT_EC_RELATIONSHIP
        '
        Me.TXT_EC_RELATIONSHIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_EC_RELATIONSHIP.BackColor = System.Drawing.Color.White
        Me.TXT_EC_RELATIONSHIP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_EC_RELATIONSHIP.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EC_RELATIONSHIP.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EC_RELATIONSHIP.ForeColor = System.Drawing.Color.Gray
        Me.TXT_EC_RELATIONSHIP.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_EC_RELATIONSHIP.LineSize = 2
        Me.TXT_EC_RELATIONSHIP.Location = New System.Drawing.Point(361, 205)
        Me.TXT_EC_RELATIONSHIP.Name = "TXT_EC_RELATIONSHIP"
        Me.TXT_EC_RELATIONSHIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_EC_RELATIONSHIP.ReadOnly = True
        Me.TXT_EC_RELATIONSHIP.Size = New System.Drawing.Size(252, 29)
        Me.TXT_EC_RELATIONSHIP.TabIndex = 137
        Me.TXT_EC_RELATIONSHIP.Text = "Relationship"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(363, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Relationship"
        '
        'TXT_EC_CNUMBER
        '
        Me.TXT_EC_CNUMBER.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_EC_CNUMBER.BackColor = System.Drawing.Color.White
        Me.TXT_EC_CNUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_EC_CNUMBER.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EC_CNUMBER.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EC_CNUMBER.ForeColor = System.Drawing.Color.Gray
        Me.TXT_EC_CNUMBER.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_EC_CNUMBER.LineSize = 2
        Me.TXT_EC_CNUMBER.Location = New System.Drawing.Point(71, 205)
        Me.TXT_EC_CNUMBER.Name = "TXT_EC_CNUMBER"
        Me.TXT_EC_CNUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_EC_CNUMBER.ReadOnly = True
        Me.TXT_EC_CNUMBER.Size = New System.Drawing.Size(290, 29)
        Me.TXT_EC_CNUMBER.TabIndex = 138
        Me.TXT_EC_CNUMBER.Text = "Contact #"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(74, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Contact #"
        '
        'TXT_EC_LNAME
        '
        Me.TXT_EC_LNAME.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_EC_LNAME.BackColor = System.Drawing.Color.White
        Me.TXT_EC_LNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_EC_LNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EC_LNAME.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EC_LNAME.ForeColor = System.Drawing.Color.Gray
        Me.TXT_EC_LNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_EC_LNAME.LineSize = 2
        Me.TXT_EC_LNAME.Location = New System.Drawing.Point(361, 110)
        Me.TXT_EC_LNAME.Name = "TXT_EC_LNAME"
        Me.TXT_EC_LNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_EC_LNAME.ReadOnly = True
        Me.TXT_EC_LNAME.Size = New System.Drawing.Size(251, 29)
        Me.TXT_EC_LNAME.TabIndex = 139
        Me.TXT_EC_LNAME.Text = "Last name"
        '
        'TXT_EC_FNAME
        '
        Me.TXT_EC_FNAME.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_EC_FNAME.BackColor = System.Drawing.Color.White
        Me.TXT_EC_FNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_EC_FNAME.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EC_FNAME.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EC_FNAME.ForeColor = System.Drawing.Color.Gray
        Me.TXT_EC_FNAME.LineColor = System.Drawing.Color.Gainsboro
        Me.TXT_EC_FNAME.LineSize = 2
        Me.TXT_EC_FNAME.Location = New System.Drawing.Point(71, 110)
        Me.TXT_EC_FNAME.Name = "TXT_EC_FNAME"
        Me.TXT_EC_FNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_EC_FNAME.ReadOnly = True
        Me.TXT_EC_FNAME.Size = New System.Drawing.Size(290, 29)
        Me.TXT_EC_FNAME.TabIndex = 140
        Me.TXT_EC_FNAME.Text = "First name"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(363, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Nova", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "First Name"
        '
        'LBL_DATE_CREATED
        '
        Me.LBL_DATE_CREATED.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBL_DATE_CREATED.AutoSize = True
        Me.LBL_DATE_CREATED.Font = New System.Drawing.Font("Arial Nova", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DATE_CREATED.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.LBL_DATE_CREATED.Location = New System.Drawing.Point(74, 29)
        Me.LBL_DATE_CREATED.Name = "LBL_DATE_CREATED"
        Me.LBL_DATE_CREATED.Size = New System.Drawing.Size(203, 16)
        Me.LBL_DATE_CREATED.TabIndex = 141
        Me.LBL_DATE_CREATED.Text = "Emergency Contact Information"
        '
        'frmBeneficiaryEmergencyContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(747, 431)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBeneficiaryEmergencyContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBeneficiaryEmergencyContact"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TXT_EC_RELATIONSHIP As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_EC_CNUMBER As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_EC_LNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents TXT_EC_FNAME As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_DATE_CREATED As Label
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
End Class
