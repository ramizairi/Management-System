<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class products1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(products1))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.CatCb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PriceeTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.QuantityTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PriceTb = New System.Windows.Forms.Label()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ResetBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.EditBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RefreshBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PullsDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Filtredcap = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SizeCb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.RefTab = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PullsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CatCb
        '
        Me.CatCb.BackColor = System.Drawing.Color.Transparent
        Me.CatCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CatCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CatCb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatCb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CatCb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CatCb.ItemHeight = 30
        Me.CatCb.Items.AddRange(New Object() {"Nike", "Adidas", "Puma", "Zara", "Elu", "Gucci", "Lacost"})
        Me.CatCb.Location = New System.Drawing.Point(713, 125)
        Me.CatCb.Margin = New System.Windows.Forms.Padding(4)
        Me.CatCb.Name = "CatCb"
        Me.CatCb.Size = New System.Drawing.Size(185, 36)
        Me.CatCb.TabIndex = 4
        '
        'PriceeTb
        '
        Me.PriceeTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceeTb.DefaultText = ""
        Me.PriceeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PriceeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PriceeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceeTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PriceeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceeTb.Location = New System.Drawing.Point(1107, 125)
        Me.PriceeTb.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceeTb.Name = "PriceeTb"
        Me.PriceeTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceeTb.PlaceholderText = ""
        Me.PriceeTb.SelectedText = ""
        Me.PriceeTb.Size = New System.Drawing.Size(153, 41)
        Me.PriceeTb.TabIndex = 6
        '
        'QuantityTb
        '
        Me.QuantityTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityTb.DefaultText = ""
        Me.QuantityTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.QuantityTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTb.Location = New System.Drawing.Point(932, 125)
        Me.QuantityTb.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTb.Name = "QuantityTb"
        Me.QuantityTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTb.PlaceholderText = ""
        Me.QuantityTb.SelectedText = ""
        Me.QuantityTb.Size = New System.Drawing.Size(152, 41)
        Me.QuantityTb.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(288, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pull reference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(497, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(708, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 25)
        Me.Label3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(927, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity"
        '
        'PriceTb
        '
        Me.PriceTb.AutoSize = True
        Me.PriceTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTb.ForeColor = System.Drawing.Color.White
        Me.PriceTb.Location = New System.Drawing.Point(1101, 97)
        Me.PriceTb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(56, 25)
        Me.PriceTb.TabIndex = 11
        Me.PriceTb.Text = "Price"
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
        Me.SaveBtn.Location = New System.Drawing.Point(393, 194)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(180, 50)
        Me.SaveBtn.TabIndex = 12
        Me.SaveBtn.Text = "Save"
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
        Me.ResetBtn.Location = New System.Drawing.Point(993, 194)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(180, 50)
        Me.ResetBtn.TabIndex = 15
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
        Me.DeleteBtn.Location = New System.Drawing.Point(793, 194)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(180, 50)
        Me.DeleteBtn.TabIndex = 14
        Me.DeleteBtn.Text = "Delete"
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
        Me.EditBtn.Location = New System.Drawing.Point(596, 194)
        Me.EditBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(180, 50)
        Me.EditBtn.TabIndex = 16
        Me.EditBtn.Text = "Edit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(707, 251)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 31)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Pull List"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Animated = True
        Me.RefreshBtn.AutoRoundedCorners = True
        Me.RefreshBtn.BorderColor = System.Drawing.Color.White
        Me.RefreshBtn.BorderRadius = 17
        Me.RefreshBtn.BorderThickness = 1
        Me.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RefreshBtn.FillColor = System.Drawing.Color.Gray
        Me.RefreshBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RefreshBtn.ForeColor = System.Drawing.Color.White
        Me.RefreshBtn.Location = New System.Drawing.Point(932, 295)
        Me.RefreshBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(180, 36)
        Me.RefreshBtn.TabIndex = 19
        Me.RefreshBtn.Text = "Refresh"
        '
        'PullsDGV
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.PullsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PullsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.PullsDGV.ColumnHeadersHeight = 29
        Me.PullsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PullsDGV.DefaultCellStyle = DataGridViewCellStyle12
        Me.PullsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PullsDGV.Location = New System.Drawing.Point(293, 341)
        Me.PullsDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.PullsDGV.Name = "PullsDGV"
        Me.PullsDGV.RowHeadersVisible = False
        Me.PullsDGV.RowHeadersWidth = 51
        Me.PullsDGV.RowTemplate.Height = 24
        Me.PullsDGV.Size = New System.Drawing.Size(967, 302)
        Me.PullsDGV.TabIndex = 39
        Me.PullsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PullsDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PullsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PullsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PullsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PullsDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PullsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PullsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PullsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PullsDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PullsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PullsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PullsDGV.ThemeStyle.HeaderStyle.Height = 29
        Me.PullsDGV.ThemeStyle.ReadOnly = False
        Me.PullsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PullsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PullsDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PullsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PullsDGV.ThemeStyle.RowsStyle.Height = 24
        Me.PullsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PullsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(527, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(470, 38)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Pulls-Over Mangment Systeme"
        '
        'Filtredcap
        '
        Me.Filtredcap.BackColor = System.Drawing.Color.Transparent
        Me.Filtredcap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Filtredcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Filtredcap.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Filtredcap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Filtredcap.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Filtredcap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Filtredcap.ItemHeight = 30
        Me.Filtredcap.Items.AddRange(New Object() {"Nike", "Adidas", "Puma", "Zara", "Elu", "Gucci", "Lacost"})
        Me.Filtredcap.Location = New System.Drawing.Point(666, 295)
        Me.Filtredcap.Margin = New System.Windows.Forms.Padding(4)
        Me.Filtredcap.Name = "Filtredcap"
        Me.Filtredcap.Size = New System.Drawing.Size(232, 36)
        Me.Filtredcap.TabIndex = 41
        '
        'SizeCb
        '
        Me.SizeCb.BackColor = System.Drawing.Color.Transparent
        Me.SizeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SizeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeCb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SizeCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SizeCb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SizeCb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SizeCb.ItemHeight = 30
        Me.SizeCb.Items.AddRange(New Object() {"S", "M", "L", "XL", "XXL", "XXXL"})
        Me.SizeCb.Location = New System.Drawing.Point(502, 125)
        Me.SizeCb.Margin = New System.Windows.Forms.Padding(4)
        Me.SizeCb.Name = "SizeCb"
        Me.SizeCb.Size = New System.Drawing.Size(185, 36)
        Me.SizeCb.TabIndex = 43
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(6, 44)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(248, 599)
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
        Me.Guna2Button4.Location = New System.Drawing.Point(18, 510)
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
        Me.Guna2Button1.FillColor = System.Drawing.Color.Black
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
        Me.Guna2Button3.BackColor = System.Drawing.Color.DarkGray
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
        Me.Guna2Button2.FillColor = System.Drawing.Color.Gray
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
        Me.Guna2Separator1.Location = New System.Drawing.Point(6, 31)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1281, 10)
        Me.Guna2Separator1.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(42, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 23)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Pull-Over Mangment Systeme"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(6, 1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.Guna2PictureBox1.TabIndex = 62
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1191, 3)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(44, 27)
        Me.Guna2ControlBox1.TabIndex = 65
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1243, 3)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(44, 27)
        Me.Guna2ControlBox2.TabIndex = 64
        '
        'RefTab
        '
        Me.RefTab.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RefTab.DefaultText = ""
        Me.RefTab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RefTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RefTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RefTab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RefTab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefTab.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RefTab.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefTab.Location = New System.Drawing.Point(293, 124)
        Me.RefTab.Margin = New System.Windows.Forms.Padding(4)
        Me.RefTab.Name = "RefTab"
        Me.RefTab.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RefTab.PlaceholderText = ""
        Me.RefTab.SelectedText = ""
        Me.RefTab.Size = New System.Drawing.Size(182, 41)
        Me.RefTab.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(708, 96)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 25)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Mark"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(508, 298)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 25)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Filtred By Mark"
        '
        'products1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RefTab)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.SizeCb)
        Me.Controls.Add(Me.Filtredcap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PullsDGV)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.PriceTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PriceeTb)
        Me.Controls.Add(Me.QuantityTb)
        Me.Controls.Add(Me.CatCb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "products1"
        Me.Text = "products"
        CType(Me.PullsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents RefreshBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents EditBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ResetBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PriceTb As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PriceeTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents QuantityTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CatCb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PullsDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Filtredcap As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SizeCb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents RefTab As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
