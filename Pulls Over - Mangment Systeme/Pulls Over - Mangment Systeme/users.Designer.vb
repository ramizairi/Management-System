<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(users))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.UserDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EditBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ResetBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PasswordTxt = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.Label()
        Me.PhoneTxt = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.Label()
        Me.PasswordTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddressTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PhoneTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UnameTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'UserDGV
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.UserDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.UserDGV.ColumnHeadersHeight = 29
        Me.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserDGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.UserDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.Location = New System.Drawing.Point(310, 335)
        Me.UserDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.UserDGV.Name = "UserDGV"
        Me.UserDGV.RowHeadersVisible = False
        Me.UserDGV.RowHeadersWidth = 51
        Me.UserDGV.RowTemplate.Height = 24
        Me.UserDGV.Size = New System.Drawing.Size(956, 302)
        Me.UserDGV.TabIndex = 38
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.UserDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UserDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.UserDGV.ThemeStyle.HeaderStyle.Height = 29
        Me.UserDGV.ThemeStyle.ReadOnly = False
        Me.UserDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UserDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UserDGV.ThemeStyle.RowsStyle.Height = 24
        Me.UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(719, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 31)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Users List"
        '
        'EditBtn
        '
        Me.EditBtn.Animated = True
        Me.EditBtn.AutoRoundedCorners = True
        Me.EditBtn.BorderColor = System.Drawing.Color.White
        Me.EditBtn.BorderRadius = 24
        Me.EditBtn.BorderThickness = 1
        Me.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.EditBtn.FillColor = System.Drawing.Color.Gray
        Me.EditBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(574, 209)
        Me.EditBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(180, 50)
        Me.EditBtn.TabIndex = 34
        Me.EditBtn.Text = "Edit"
        '
        'ResetBtn
        '
        Me.ResetBtn.Animated = True
        Me.ResetBtn.AutoRoundedCorners = True
        Me.ResetBtn.BorderColor = System.Drawing.Color.White
        Me.ResetBtn.BorderRadius = 24
        Me.ResetBtn.BorderThickness = 1
        Me.ResetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ResetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ResetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ResetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ResetBtn.FillColor = System.Drawing.Color.Gray
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(1051, 209)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(180, 50)
        Me.ResetBtn.TabIndex = 33
        Me.ResetBtn.Text = "Reset"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Animated = True
        Me.DeleteBtn.AutoRoundedCorners = True
        Me.DeleteBtn.BorderColor = System.Drawing.Color.White
        Me.DeleteBtn.BorderRadius = 24
        Me.DeleteBtn.BorderThickness = 1
        Me.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteBtn.FillColor = System.Drawing.Color.Gray
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(817, 209)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(180, 50)
        Me.DeleteBtn.TabIndex = 32
        Me.DeleteBtn.Text = "Delete"
        '
        'SaveBtn
        '
        Me.SaveBtn.Animated = True
        Me.SaveBtn.AutoRoundedCorners = True
        Me.SaveBtn.BorderColor = System.Drawing.Color.White
        Me.SaveBtn.BorderRadius = 24
        Me.SaveBtn.BorderThickness = 1
        Me.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SaveBtn.FillColor = System.Drawing.Color.Gray
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(365, 209)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(180, 50)
        Me.SaveBtn.TabIndex = 31
        Me.SaveBtn.Text = "Save"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.AutoSize = True
        Me.PasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.ForeColor = System.Drawing.Color.White
        Me.PasswordTxt.Location = New System.Drawing.Point(1073, 104)
        Me.PasswordTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(98, 25)
        Me.PasswordTxt.TabIndex = 30
        Me.PasswordTxt.Text = "Password"
        '
        'AddressTxt
        '
        Me.AddressTxt.AutoSize = True
        Me.AddressTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTxt.ForeColor = System.Drawing.Color.White
        Me.AddressTxt.Location = New System.Drawing.Point(810, 104)
        Me.AddressTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(85, 25)
        Me.AddressTxt.TabIndex = 29
        Me.AddressTxt.Text = "Address"
        '
        'PhoneTxt
        '
        Me.PhoneTxt.AutoSize = True
        Me.PhoneTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTxt.ForeColor = System.Drawing.Color.White
        Me.PhoneTxt.Location = New System.Drawing.Point(566, 104)
        Me.PhoneTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhoneTxt.Name = "PhoneTxt"
        Me.PhoneTxt.Size = New System.Drawing.Size(69, 25)
        Me.PhoneTxt.TabIndex = 27
        Me.PhoneTxt.Text = "Phone"
        '
        'NameTxt
        '
        Me.NameTxt.AutoSize = True
        Me.NameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.ForeColor = System.Drawing.Color.White
        Me.NameTxt.Location = New System.Drawing.Point(357, 104)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(64, 25)
        Me.NameTxt.TabIndex = 26
        Me.NameTxt.Text = "Name"
        '
        'PasswordTb
        '
        Me.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTb.DefaultText = ""
        Me.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTb.Location = New System.Drawing.Point(1078, 132)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTb.PlaceholderText = ""
        Me.PasswordTb.SelectedText = ""
        Me.PasswordTb.Size = New System.Drawing.Size(153, 41)
        Me.PasswordTb.TabIndex = 25
        '
        'AddressTb
        '
        Me.AddressTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressTb.DefaultText = ""
        Me.AddressTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddressTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddressTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddressTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTb.Location = New System.Drawing.Point(815, 132)
        Me.AddressTb.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddressTb.PlaceholderText = ""
        Me.AddressTb.SelectedText = ""
        Me.AddressTb.Size = New System.Drawing.Size(199, 49)
        Me.AddressTb.TabIndex = 24
        '
        'PhoneTb
        '
        Me.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneTb.DefaultText = ""
        Me.PhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneTb.Location = New System.Drawing.Point(571, 132)
        Me.PhoneTb.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneTb.Name = "PhoneTb"
        Me.PhoneTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneTb.PlaceholderText = ""
        Me.PhoneTb.SelectedText = ""
        Me.PhoneTb.Size = New System.Drawing.Size(183, 41)
        Me.PhoneTb.TabIndex = 22
        '
        'UnameTb
        '
        Me.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UnameTb.DefaultText = ""
        Me.UnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnameTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnameTb.Location = New System.Drawing.Point(362, 132)
        Me.UnameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UnameTb.PlaceholderText = ""
        Me.UnameTb.SelectedText = ""
        Me.UnameTb.Size = New System.Drawing.Size(183, 41)
        Me.UnameTb.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(538, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 38)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Pulls-Over Mangment Systeme"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(11, 46)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(248, 596)
        Me.Guna2Panel1.TabIndex = 59
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.BorderColor = System.Drawing.Color.White
        Me.Guna2Button4.BorderThickness = 1
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Gray
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = Global.Pulls_Over___Mangment_Systeme.My.Resources.Resources.logout
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button4.Location = New System.Drawing.Point(18, 515)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(216, 67)
        Me.Guna2Button4.TabIndex = 61
        Me.Guna2Button4.Text = "LogOut"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderColor = System.Drawing.Color.White
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Gray
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.Pulls_Over___Mangment_Systeme.My.Resources.Resources.tshirt
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.Location = New System.Drawing.Point(18, 22)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(216, 67)
        Me.Guna2Button1.TabIndex = 59
        Me.Guna2Button1.Text = "  Pulls-Over"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BorderColor = System.Drawing.Color.White
        Me.Guna2Button3.BorderThickness = 1
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Gray
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = Global.Pulls_Over___Mangment_Systeme.My.Resources.Resources.speedometer
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button3.Location = New System.Drawing.Point(18, 264)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(216, 67)
        Me.Guna2Button3.TabIndex = 62
        Me.Guna2Button3.Text = "  DashBoard"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BorderColor = System.Drawing.Color.White
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Black
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = Global.Pulls_Over___Mangment_Systeme.My.Resources.Resources.user_2
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button2.Location = New System.Drawing.Point(18, 145)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(216, 67)
        Me.Guna2Button2.TabIndex = 60
        Me.Guna2Button2.Text = "Users"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(11, 30)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1281, 10)
        Me.Guna2Separator1.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 23)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Pull-Over Mangment Systeme"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(8, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox1.TabIndex = 61
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1196, 1)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(44, 27)
        Me.Guna2ControlBox1.TabIndex = 64
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1248, 1)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(44, 27)
        Me.Guna2ControlBox2.TabIndex = 63
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserDGV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.PhoneTxt)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.AddressTb)
        Me.Controls.Add(Me.PhoneTb)
        Me.Controls.Add(Me.UnameTb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "users"
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents UserDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents EditBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ResetBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PasswordTxt As Label
    Friend WithEvents AddressTxt As Label
    Friend WithEvents PhoneTxt As Label
    Friend WithEvents NameTxt As Label
    Friend WithEvents PasswordTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddressTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PhoneTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UnameTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
End Class
