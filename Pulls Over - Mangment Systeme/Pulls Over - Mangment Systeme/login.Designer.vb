<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UNameTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PasswordTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'LoginBtn
        '
        Me.LoginBtn.Animated = True
        Me.LoginBtn.AutoRoundedCorners = True
        Me.LoginBtn.BorderColor = System.Drawing.Color.White
        Me.LoginBtn.BorderRadius = 26
        Me.LoginBtn.BorderThickness = 1
        Me.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBtn.FillColor = System.Drawing.Color.Transparent
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Location = New System.Drawing.Point(335, 251)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(304, 55)
        Me.LoginBtn.TabIndex = 5
        Me.LoginBtn.Text = "Login"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(705, 4)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(44, 27)
        Me.Guna2ControlBox2.TabIndex = 8
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(653, 4)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(44, 27)
        Me.Guna2ControlBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(313, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Pulls-Over Mangment Systeme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(437, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ADMIN"
        '
        'UNameTb
        '
        Me.UNameTb.Animated = True
        Me.UNameTb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UNameTb.DefaultText = ""
        Me.UNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UNameTb.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UNameTb.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.UNameTb.ForeColor = System.Drawing.Color.White
        Me.UNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UNameTb.IconLeft = Global.Pulls_Over___Mangment_Systeme.My.Resources.Resources.user
        Me.UNameTb.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.UNameTb.Location = New System.Drawing.Point(335, 131)
        Me.UNameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.UNameTb.MaxLength = 10
        Me.UNameTb.Name = "UNameTb"
        Me.UNameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UNameTb.PlaceholderText = "USERNAME"
        Me.UNameTb.SelectedText = ""
        Me.UNameTb.Size = New System.Drawing.Size(304, 49)
        Me.UNameTb.TabIndex = 7
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Pulls_Over___Mangment_Systeme.My.Resources.Resources.Pullover1
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(13, 70)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(240, 271)
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'PasswordTb
        '
        Me.PasswordTb.Animated = True
        Me.PasswordTb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PasswordTb.DefaultText = ""
        Me.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTb.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTb.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.PasswordTb.ForeColor = System.Drawing.Color.White
        Me.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTb.IconLeft = Global.Pulls_Over___Mangment_Systeme.My.Resources.Resources.password
        Me.PasswordTb.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.PasswordTb.IconRightSize = New System.Drawing.Size(30, 30)
        Me.PasswordTb.Location = New System.Drawing.Point(335, 188)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTb.PlaceholderText = "PASSWORD"
        Me.PasswordTb.SelectedText = ""
        Me.PasswordTb.Size = New System.Drawing.Size(304, 49)
        Me.PasswordTb.TabIndex = 4
        Me.PasswordTb.UseSystemPasswordChar = True
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(254, 47)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(32, 322)
        Me.Guna2VSeparator1.TabIndex = 17
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(-288, 31)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1281, 10)
        Me.Guna2Separator1.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(32, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 23)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Pull-Over Mangment Systeme"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 64
        Me.Guna2PictureBox2.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 380)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.UNameTb)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordTb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "login"
        Me.Text = "login"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UNameTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PasswordTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
