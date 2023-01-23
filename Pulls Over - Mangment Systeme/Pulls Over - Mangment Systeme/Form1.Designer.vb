<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ProgBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.PerLabelle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'ProgBar
        '
        Me.ProgBar.Controls.Add(Me.PerLabelle)
        Me.ProgBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ProgBar.FillThickness = 10
        Me.ProgBar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ProgBar.ForeColor = System.Drawing.Color.White
        Me.ProgBar.Location = New System.Drawing.Point(273, 122)
        Me.ProgBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgBar.Minimum = 0
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.ProgressThickness = 10
        Me.ProgBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProgBar.Size = New System.Drawing.Size(145, 145)
        Me.ProgBar.TabIndex = 1
        Me.ProgBar.Text = "Guna2CircleProgressBar1"
        '
        'PerLabelle
        '
        Me.PerLabelle.BackColor = System.Drawing.Color.Transparent
        Me.PerLabelle.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerLabelle.ForeColor = System.Drawing.Color.White
        Me.PerLabelle.Location = New System.Drawing.Point(56, 54)
        Me.PerLabelle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PerLabelle.Name = "PerLabelle"
        Me.PerLabelle.Size = New System.Drawing.Size(25, 30)
        Me.PerLabelle.TabIndex = 2
        Me.PerLabelle.Text = "%"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Pulls-Over Mangment Systeme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(210, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Powred By ZairiMedRami"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(717, 350)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgBar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgBar.ResumeLayout(False)
        Me.ProgBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ProgBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents PerLabelle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
