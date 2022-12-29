<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Resetme = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Password1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Username1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LoginAsFaculty = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(455, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin Login"
        '
        'LoginButton1
        '
        Me.LoginButton1.AutoRoundedCorners = True
        Me.LoginButton1.BorderRadius = 21
        Me.LoginButton1.CheckedState.Parent = Me.LoginButton1
        Me.LoginButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton1.CustomImages.Parent = Me.LoginButton1
        Me.LoginButton1.FillColor = System.Drawing.Color.SlateBlue
        Me.LoginButton1.FillColor2 = System.Drawing.Color.Orchid
        Me.LoginButton1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton1.ForeColor = System.Drawing.Color.White
        Me.LoginButton1.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.LoginButton1.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.LoginButton1.HoverState.Parent = Me.LoginButton1
        Me.LoginButton1.Location = New System.Drawing.Point(448, 281)
        Me.LoginButton1.Name = "LoginButton1"
        Me.LoginButton1.PressedColor = System.Drawing.Color.Teal
        Me.LoginButton1.PressedDepth = 50
        Me.LoginButton1.ShadowDecoration.Parent = Me.LoginButton1
        Me.LoginButton1.Size = New System.Drawing.Size(180, 45)
        Me.LoginButton1.TabIndex = 5
        Me.LoginButton1.Text = "Login"
        '
        'Showpass
        '
        Me.Showpass.AutoSize = True
        Me.Showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Showpass.CheckedState.BorderRadius = 2
        Me.Showpass.CheckedState.BorderThickness = 0
        Me.Showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Showpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Showpass.Location = New System.Drawing.Point(489, 256)
        Me.Showpass.Name = "Showpass"
        Me.Showpass.Size = New System.Drawing.Size(109, 19)
        Me.Showpass.TabIndex = 7
        Me.Showpass.Text = "Show Password"
        Me.Showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Showpass.UncheckedState.BorderRadius = 2
        Me.Showpass.UncheckedState.BorderThickness = 0
        Me.Showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Showpass.UseVisualStyleBackColor = True
        '
        'Resetme
        '
        Me.Resetme.AutoSize = True
        Me.Resetme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Resetme.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetme.Location = New System.Drawing.Point(516, 329)
        Me.Resetme.Name = "Resetme"
        Me.Resetme.Size = New System.Drawing.Size(41, 17)
        Me.Resetme.TabIndex = 8
        Me.Resetme.Text = "Reset"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(373, 468)
        Me.Guna2GradientPanel1.TabIndex = 9
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
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CMS"
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
        Me.Label3.TabIndex = 14
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
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Login to "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 45)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Welcome admin !"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(510, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Password1
        '
        Me.Password1.AutoRoundedCorners = True
        Me.Password1.BorderColor = System.Drawing.Color.Silver
        Me.Password1.BorderRadius = 17
        Me.Password1.BorderThickness = 2
        Me.Password1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password1.DefaultText = ""
        Me.Password1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password1.DisabledState.Parent = Me.Password1
        Me.Password1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password1.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.Password1.FocusedState.Parent = Me.Password1
        Me.Password1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password1.ForeColor = System.Drawing.Color.Black
        Me.Password1.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.Password1.HoverState.Parent = Me.Password1
        Me.Password1.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.Password1.IconLeft = CType(resources.GetObject("Password1.IconLeft"), System.Drawing.Image)
        Me.Password1.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.Password1.Location = New System.Drawing.Point(427, 214)
        Me.Password1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Password1.Name = "Password1"
        Me.Password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password1.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Password1.PlaceholderText = "Password"
        Me.Password1.SelectedText = ""
        Me.Password1.ShadowDecoration.Parent = Me.Password1
        Me.Password1.Size = New System.Drawing.Size(230, 36)
        Me.Password1.TabIndex = 3
        Me.Password1.UseSystemPasswordChar = True
        '
        'Username1
        '
        Me.Username1.Animated = True
        Me.Username1.AutoRoundedCorners = True
        Me.Username1.BorderColor = System.Drawing.Color.Silver
        Me.Username1.BorderRadius = 17
        Me.Username1.BorderThickness = 2
        Me.Username1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username1.DefaultText = ""
        Me.Username1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username1.DisabledState.Parent = Me.Username1
        Me.Username1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username1.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.Username1.FocusedState.Parent = Me.Username1
        Me.Username1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username1.ForeColor = System.Drawing.Color.Black
        Me.Username1.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.Username1.HoverState.Parent = Me.Username1
        Me.Username1.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.Username1.IconLeft = CType(resources.GetObject("Username1.IconLeft"), System.Drawing.Image)
        Me.Username1.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.Username1.Location = New System.Drawing.Point(427, 148)
        Me.Username1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Username1.Name = "Username1"
        Me.Username1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username1.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Username1.PlaceholderText = "User Name"
        Me.Username1.SelectedText = ""
        Me.Username1.ShadowDecoration.Parent = Me.Username1
        Me.Username1.Size = New System.Drawing.Size(230, 36)
        Me.Username1.TabIndex = 2
        '
        'LoginAsFaculty
        '
        Me.LoginAsFaculty.Animated = True
        Me.LoginAsFaculty.AutoRoundedCorners = True
        Me.LoginAsFaculty.BorderColor = System.Drawing.Color.Transparent
        Me.LoginAsFaculty.BorderRadius = 10
        Me.LoginAsFaculty.CheckedState.Parent = Me.LoginAsFaculty
        Me.LoginAsFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginAsFaculty.CustomImages.Parent = Me.LoginAsFaculty
        Me.LoginAsFaculty.FillColor = System.Drawing.Color.White
        Me.LoginAsFaculty.FillColor2 = System.Drawing.Color.White
        Me.LoginAsFaculty.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginAsFaculty.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LoginAsFaculty.HoverState.FillColor = System.Drawing.Color.White
        Me.LoginAsFaculty.HoverState.FillColor2 = System.Drawing.Color.White
        Me.LoginAsFaculty.HoverState.Parent = Me.LoginAsFaculty
        Me.LoginAsFaculty.Image = CType(resources.GetObject("LoginAsFaculty.Image"), System.Drawing.Image)
        Me.LoginAsFaculty.Location = New System.Drawing.Point(454, 362)
        Me.LoginAsFaculty.Name = "LoginAsFaculty"
        Me.LoginAsFaculty.PressedColor = System.Drawing.Color.Orchid
        Me.LoginAsFaculty.PressedDepth = 50
        Me.LoginAsFaculty.ShadowDecoration.Parent = Me.LoginAsFaculty
        Me.LoginAsFaculty.Size = New System.Drawing.Size(174, 22)
        Me.LoginAsFaculty.TabIndex = 18
        Me.LoginAsFaculty.Text = "Login as faculty"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 467)
        Me.Controls.Add(Me.LoginAsFaculty)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Resetme)
        Me.Controls.Add(Me.Showpass)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LoginButton1)
        Me.Controls.Add(Me.Password1)
        Me.Controls.Add(Me.Username1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(23, 69, 23, 23)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.TransparencyKey = System.Drawing.Color.SlateBlue
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Username1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Resetme As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LoginAsFaculty As Guna.UI2.WinForms.Guna2GradientButton
End Class
