<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUsers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserLastNmae = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserPassword1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UserPassword2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LoginButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LoginButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(129, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add New Admin"
        '
        'UserFirstName
        '
        Me.UserFirstName.Animated = True
        Me.UserFirstName.BorderColor = System.Drawing.Color.Silver
        Me.UserFirstName.BorderThickness = 2
        Me.UserFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserFirstName.DefaultText = ""
        Me.UserFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserFirstName.DisabledState.Parent = Me.UserFirstName
        Me.UserFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserFirstName.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.UserFirstName.FocusedState.Parent = Me.UserFirstName
        Me.UserFirstName.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserFirstName.ForeColor = System.Drawing.Color.Black
        Me.UserFirstName.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.UserFirstName.HoverState.Parent = Me.UserFirstName
        Me.UserFirstName.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.UserFirstName.IconLeft = CType(resources.GetObject("UserFirstName.IconLeft"), System.Drawing.Image)
        Me.UserFirstName.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.UserFirstName.Location = New System.Drawing.Point(71, 142)
        Me.UserFirstName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserFirstName.Name = "UserFirstName"
        Me.UserFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserFirstName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UserFirstName.PlaceholderText = "User Name"
        Me.UserFirstName.SelectedText = ""
        Me.UserFirstName.ShadowDecoration.Parent = Me.UserFirstName
        Me.UserFirstName.Size = New System.Drawing.Size(230, 36)
        Me.UserFirstName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(65, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(400, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'UserLastNmae
        '
        Me.UserLastNmae.Animated = True
        Me.UserLastNmae.BorderColor = System.Drawing.Color.Silver
        Me.UserLastNmae.BorderThickness = 2
        Me.UserLastNmae.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserLastNmae.DefaultText = ""
        Me.UserLastNmae.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserLastNmae.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserLastNmae.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserLastNmae.DisabledState.Parent = Me.UserLastNmae
        Me.UserLastNmae.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserLastNmae.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.UserLastNmae.FocusedState.Parent = Me.UserLastNmae
        Me.UserLastNmae.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLastNmae.ForeColor = System.Drawing.Color.Black
        Me.UserLastNmae.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.UserLastNmae.HoverState.Parent = Me.UserLastNmae
        Me.UserLastNmae.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.UserLastNmae.IconLeft = CType(resources.GetObject("UserLastNmae.IconLeft"), System.Drawing.Image)
        Me.UserLastNmae.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.UserLastNmae.Location = New System.Drawing.Point(406, 142)
        Me.UserLastNmae.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserLastNmae.Name = "UserLastNmae"
        Me.UserLastNmae.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserLastNmae.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UserLastNmae.PlaceholderText = "User Name"
        Me.UserLastNmae.SelectedText = ""
        Me.UserLastNmae.ShadowDecoration.Parent = Me.UserLastNmae
        Me.UserLastNmae.Size = New System.Drawing.Size(230, 36)
        Me.UserLastNmae.TabIndex = 6
        '
        'UserEmail
        '
        Me.UserEmail.Animated = True
        Me.UserEmail.BorderColor = System.Drawing.Color.Silver
        Me.UserEmail.BorderThickness = 2
        Me.UserEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserEmail.DefaultText = ""
        Me.UserEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserEmail.DisabledState.Parent = Me.UserEmail
        Me.UserEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserEmail.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.UserEmail.FocusedState.Parent = Me.UserEmail
        Me.UserEmail.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserEmail.ForeColor = System.Drawing.Color.Black
        Me.UserEmail.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.UserEmail.HoverState.Parent = Me.UserEmail
        Me.UserEmail.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.UserEmail.IconLeft = CType(resources.GetObject("UserEmail.IconLeft"), System.Drawing.Image)
        Me.UserEmail.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.UserEmail.Location = New System.Drawing.Point(71, 268)
        Me.UserEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserEmail.Name = "UserEmail"
        Me.UserEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserEmail.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UserEmail.PlaceholderText = "User Name"
        Me.UserEmail.SelectedText = ""
        Me.UserEmail.ShadowDecoration.Parent = Me.UserEmail
        Me.UserEmail.Size = New System.Drawing.Size(230, 36)
        Me.UserEmail.TabIndex = 7
        '
        'UserNumber
        '
        Me.UserNumber.Animated = True
        Me.UserNumber.BorderColor = System.Drawing.Color.Silver
        Me.UserNumber.BorderThickness = 2
        Me.UserNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNumber.DefaultText = ""
        Me.UserNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNumber.DisabledState.Parent = Me.UserNumber
        Me.UserNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNumber.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.UserNumber.FocusedState.Parent = Me.UserNumber
        Me.UserNumber.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNumber.ForeColor = System.Drawing.Color.Black
        Me.UserNumber.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.UserNumber.HoverState.Parent = Me.UserNumber
        Me.UserNumber.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.UserNumber.IconLeft = CType(resources.GetObject("UserNumber.IconLeft"), System.Drawing.Image)
        Me.UserNumber.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.UserNumber.Location = New System.Drawing.Point(406, 268)
        Me.UserNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserNumber.Name = "UserNumber"
        Me.UserNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNumber.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UserNumber.PlaceholderText = "User Name"
        Me.UserNumber.SelectedText = ""
        Me.UserNumber.ShadowDecoration.Parent = Me.UserNumber
        Me.UserNumber.Size = New System.Drawing.Size(230, 36)
        Me.UserNumber.TabIndex = 8
        '
        'UserPassword1
        '
        Me.UserPassword1.BorderColor = System.Drawing.Color.Silver
        Me.UserPassword1.BorderThickness = 2
        Me.UserPassword1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserPassword1.DefaultText = ""
        Me.UserPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserPassword1.DisabledState.Parent = Me.UserPassword1
        Me.UserPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserPassword1.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.UserPassword1.FocusedState.Parent = Me.UserPassword1
        Me.UserPassword1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPassword1.ForeColor = System.Drawing.Color.Black
        Me.UserPassword1.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.UserPassword1.HoverState.Parent = Me.UserPassword1
        Me.UserPassword1.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.UserPassword1.IconLeft = CType(resources.GetObject("UserPassword1.IconLeft"), System.Drawing.Image)
        Me.UserPassword1.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.UserPassword1.Location = New System.Drawing.Point(71, 387)
        Me.UserPassword1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserPassword1.Name = "UserPassword1"
        Me.UserPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserPassword1.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UserPassword1.PlaceholderText = "Password"
        Me.UserPassword1.SelectedText = ""
        Me.UserPassword1.ShadowDecoration.Parent = Me.UserPassword1
        Me.UserPassword1.Size = New System.Drawing.Size(230, 36)
        Me.UserPassword1.TabIndex = 9
        Me.UserPassword1.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(65, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 33)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(400, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 33)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mobile Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(65, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 33)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(400, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 33)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Retype Password"
        '
        'UserPassword2
        '
        Me.UserPassword2.BorderColor = System.Drawing.Color.Silver
        Me.UserPassword2.BorderThickness = 2
        Me.UserPassword2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserPassword2.DefaultText = ""
        Me.UserPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserPassword2.DisabledState.Parent = Me.UserPassword2
        Me.UserPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserPassword2.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.UserPassword2.FocusedState.Parent = Me.UserPassword2
        Me.UserPassword2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPassword2.ForeColor = System.Drawing.Color.Black
        Me.UserPassword2.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.UserPassword2.HoverState.Parent = Me.UserPassword2
        Me.UserPassword2.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.UserPassword2.IconLeft = CType(resources.GetObject("UserPassword2.IconLeft"), System.Drawing.Image)
        Me.UserPassword2.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.UserPassword2.Location = New System.Drawing.Point(406, 387)
        Me.UserPassword2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserPassword2.Name = "UserPassword2"
        Me.UserPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserPassword2.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UserPassword2.PlaceholderText = "Retype Password"
        Me.UserPassword2.SelectedText = ""
        Me.UserPassword2.ShadowDecoration.Parent = Me.UserPassword2
        Me.UserPassword2.Size = New System.Drawing.Size(230, 36)
        Me.UserPassword2.TabIndex = 14
        Me.UserPassword2.UseSystemPasswordChar = True
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
        Me.LoginButton1.Image = CType(resources.GetObject("LoginButton1.Image"), System.Drawing.Image)
        Me.LoginButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LoginButton1.Location = New System.Drawing.Point(406, 481)
        Me.LoginButton1.Name = "LoginButton1"
        Me.LoginButton1.PressedColor = System.Drawing.Color.Teal
        Me.LoginButton1.PressedDepth = 50
        Me.LoginButton1.ShadowDecoration.Parent = Me.LoginButton1
        Me.LoginButton1.Size = New System.Drawing.Size(191, 45)
        Me.LoginButton1.TabIndex = 16
        Me.LoginButton1.Text = "  Add as Faculty"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BorderRadius = 21
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Silver
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Silver
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(672, 481)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.PressedColor = System.Drawing.Color.Teal
        Me.Guna2GradientButton1.PressedDepth = 50
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton1.TabIndex = 17
        Me.Guna2GradientButton1.Text = "Cancel"
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
        Me.LoginButton2.Location = New System.Drawing.Point(71, 481)
        Me.LoginButton2.Name = "LoginButton2"
        Me.LoginButton2.PressedColor = System.Drawing.Color.Teal
        Me.LoginButton2.PressedDepth = 50
        Me.LoginButton2.ShadowDecoration.Parent = Me.LoginButton2
        Me.LoginButton2.Size = New System.Drawing.Size(180, 45)
        Me.LoginButton2.TabIndex = 19
        Me.LoginButton2.Text = "Save"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(71, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'AddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LoginButton2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.LoginButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.UserPassword2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UserPassword1)
        Me.Controls.Add(Me.UserNumber)
        Me.Controls.Add(Me.UserEmail)
        Me.Controls.Add(Me.UserLastNmae)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddUsers"
        Me.Text = "AddUsers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UserFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserLastNmae As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserPassword1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents UserPassword2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LoginButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
