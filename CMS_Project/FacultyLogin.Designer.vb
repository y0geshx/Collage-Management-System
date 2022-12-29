<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacultyLogin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacultyLogin))
        Me.GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Resetme = New System.Windows.Forms.Label()
        Me.Showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LoginButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Password2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Username2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginAsAdmin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Controls.Add(Me.Label3)
        Me.GradientPanel1.Controls.Add(Me.Label5)
        Me.GradientPanel1.Controls.Add(Me.Label4)
        Me.GradientPanel1.Controls.Add(Me.Label6)
        Me.GradientPanel1.Controls.Add(Me.PictureBox1)
        Me.GradientPanel1.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.GradientPanel1.FillColor2 = System.Drawing.Color.Turquoise
        Me.GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.ShadowDecoration.Parent = Me.GradientPanel1
        Me.GradientPanel1.Size = New System.Drawing.Size(373, 468)
        Me.GradientPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(157, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "continue access"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(106, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Login to "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 45)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Welcome back!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(55, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "CMS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Resetme
        '
        Me.Resetme.AutoSize = True
        Me.Resetme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Resetme.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetme.Location = New System.Drawing.Point(515, 328)
        Me.Resetme.Name = "Resetme"
        Me.Resetme.Size = New System.Drawing.Size(41, 17)
        Me.Resetme.TabIndex = 15
        Me.Resetme.Text = "Reset"
        '
        'Showpass
        '
        Me.Showpass.AutoSize = True
        Me.Showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Showpass.CheckedState.BorderRadius = 2
        Me.Showpass.CheckedState.BorderThickness = 0
        Me.Showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Showpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Showpass.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Showpass.Location = New System.Drawing.Point(488, 255)
        Me.Showpass.Name = "Showpass"
        Me.Showpass.Size = New System.Drawing.Size(108, 19)
        Me.Showpass.TabIndex = 14
        Me.Showpass.Text = "Show Password"
        Me.Showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Showpass.UncheckedState.BorderRadius = 2
        Me.Showpass.UncheckedState.BorderThickness = 0
        Me.Showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Showpass.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(509, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'LoginButton2
        '
        Me.LoginButton2.Animated = True
        Me.LoginButton2.AutoRoundedCorners = True
        Me.LoginButton2.BorderRadius = 21
        Me.LoginButton2.CheckedState.Parent = Me.LoginButton2
        Me.LoginButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton2.CustomImages.Parent = Me.LoginButton2
        Me.LoginButton2.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.LoginButton2.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.LoginButton2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton2.ForeColor = System.Drawing.Color.White
        Me.LoginButton2.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.LoginButton2.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.LoginButton2.HoverState.Parent = Me.LoginButton2
        Me.LoginButton2.Location = New System.Drawing.Point(447, 280)
        Me.LoginButton2.Name = "LoginButton2"
        Me.LoginButton2.PressedColor = System.Drawing.Color.Teal
        Me.LoginButton2.PressedDepth = 50
        Me.LoginButton2.ShadowDecoration.Parent = Me.LoginButton2
        Me.LoginButton2.Size = New System.Drawing.Size(180, 45)
        Me.LoginButton2.TabIndex = 12
        Me.LoginButton2.Text = "Login"
        '
        'Password2
        '
        Me.Password2.AutoRoundedCorners = True
        Me.Password2.BorderColor = System.Drawing.Color.Silver
        Me.Password2.BorderRadius = 17
        Me.Password2.BorderThickness = 2
        Me.Password2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password2.DefaultText = ""
        Me.Password2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password2.DisabledState.Parent = Me.Password2
        Me.Password2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password2.FocusedState.BorderColor = System.Drawing.Color.Turquoise
        Me.Password2.FocusedState.Parent = Me.Password2
        Me.Password2.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Password2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password2.ForeColor = System.Drawing.Color.Black
        Me.Password2.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Password2.HoverState.Parent = Me.Password2
        Me.Password2.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkTurquoise
        Me.Password2.IconLeft = CType(resources.GetObject("Password2.IconLeft"), System.Drawing.Image)
        Me.Password2.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.Password2.Location = New System.Drawing.Point(426, 213)
        Me.Password2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Password2.Name = "Password2"
        Me.Password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password2.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Password2.PlaceholderText = "Password"
        Me.Password2.SelectedText = ""
        Me.Password2.ShadowDecoration.Parent = Me.Password2
        Me.Password2.Size = New System.Drawing.Size(230, 36)
        Me.Password2.TabIndex = 11
        Me.Password2.UseSystemPasswordChar = True
        '
        'Username2
        '
        Me.Username2.Animated = True
        Me.Username2.AutoRoundedCorners = True
        Me.Username2.BorderColor = System.Drawing.Color.Silver
        Me.Username2.BorderRadius = 17
        Me.Username2.BorderThickness = 2
        Me.Username2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username2.DefaultText = ""
        Me.Username2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username2.DisabledState.Parent = Me.Username2
        Me.Username2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username2.FocusedState.BorderColor = System.Drawing.Color.Turquoise
        Me.Username2.FocusedState.Parent = Me.Username2
        Me.Username2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username2.ForeColor = System.Drawing.Color.Black
        Me.Username2.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Username2.HoverState.Parent = Me.Username2
        Me.Username2.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkTurquoise
        Me.Username2.IconLeft = CType(resources.GetObject("Username2.IconLeft"), System.Drawing.Image)
        Me.Username2.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.Username2.Location = New System.Drawing.Point(426, 147)
        Me.Username2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Username2.Name = "Username2"
        Me.Username2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username2.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Username2.PlaceholderText = "User Name"
        Me.Username2.SelectedText = ""
        Me.Username2.ShadowDecoration.Parent = Me.Username2
        Me.Username2.Size = New System.Drawing.Size(230, 36)
        Me.Username2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(454, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 33)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Faculty Login"
        '
        'LoginAsAdmin
        '
        Me.LoginAsAdmin.Animated = True
        Me.LoginAsAdmin.AutoRoundedCorners = True
        Me.LoginAsAdmin.BorderColor = System.Drawing.Color.Transparent
        Me.LoginAsAdmin.BorderRadius = 10
        Me.LoginAsAdmin.CheckedState.Parent = Me.LoginAsAdmin
        Me.LoginAsAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginAsAdmin.CustomImages.Parent = Me.LoginAsAdmin
        Me.LoginAsAdmin.FillColor = System.Drawing.Color.White
        Me.LoginAsAdmin.FillColor2 = System.Drawing.Color.White
        Me.LoginAsAdmin.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginAsAdmin.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LoginAsAdmin.HoverState.FillColor = System.Drawing.Color.White
        Me.LoginAsAdmin.HoverState.FillColor2 = System.Drawing.Color.White
        Me.LoginAsAdmin.HoverState.Image = CType(resources.GetObject("LoginAsAdmin.HoverState.Image"), System.Drawing.Image)
        Me.LoginAsAdmin.HoverState.Parent = Me.LoginAsAdmin
        Me.LoginAsAdmin.Location = New System.Drawing.Point(447, 359)
        Me.LoginAsAdmin.Name = "LoginAsAdmin"
        Me.LoginAsAdmin.PressedColor = System.Drawing.Color.Turquoise
        Me.LoginAsAdmin.PressedDepth = 50
        Me.LoginAsAdmin.ShadowDecoration.Parent = Me.LoginAsAdmin
        Me.LoginAsAdmin.Size = New System.Drawing.Size(174, 22)
        Me.LoginAsAdmin.TabIndex = 17
        Me.LoginAsAdmin.Text = "Login as admin"
        '
        'FacultyLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 466)
        Me.Controls.Add(Me.LoginAsAdmin)
        Me.Controls.Add(Me.Resetme)
        Me.Controls.Add(Me.Showpass)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LoginButton2)
        Me.Controls.Add(Me.Password2)
        Me.Controls.Add(Me.Username2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GradientPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacultyLogin"
        Me.TransparencyKey = System.Drawing.Color.DarkTurquoise
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Resetme As Label
    Friend WithEvents Showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LoginButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Password2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Username2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginAsAdmin As Guna.UI2.WinForms.Guna2GradientButton
End Class
