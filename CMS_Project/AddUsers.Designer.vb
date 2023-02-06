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
        Me.DeleteButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SaveButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RefreshButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.UpdateButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(67, 26)
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
        Me.UserFirstName.Location = New System.Drawing.Point(33, 142)
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
        Me.Label2.Location = New System.Drawing.Point(27, 106)
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
        Me.Label3.Location = New System.Drawing.Point(291, 106)
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
        Me.UserLastNmae.Location = New System.Drawing.Point(297, 142)
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
        Me.UserEmail.Location = New System.Drawing.Point(33, 248)
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
        Me.UserNumber.Location = New System.Drawing.Point(297, 248)
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
        Me.UserPassword1.Location = New System.Drawing.Point(33, 364)
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
        Me.Label4.Location = New System.Drawing.Point(27, 212)
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
        Me.Label5.Location = New System.Drawing.Point(291, 212)
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
        Me.Label6.Location = New System.Drawing.Point(27, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 33)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Password"
        '
        'DeleteButton1
        '
        Me.DeleteButton1.AutoRoundedCorners = True
        Me.DeleteButton1.BorderRadius = 21
        Me.DeleteButton1.CheckedState.Parent = Me.DeleteButton1
        Me.DeleteButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteButton1.CustomImages.Parent = Me.DeleteButton1
        Me.DeleteButton1.FillColor = System.Drawing.Color.Silver
        Me.DeleteButton1.FillColor2 = System.Drawing.Color.Silver
        Me.DeleteButton1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton1.ForeColor = System.Drawing.Color.Black
        Me.DeleteButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DeleteButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DeleteButton1.HoverState.Parent = Me.DeleteButton1
        Me.DeleteButton1.Location = New System.Drawing.Point(383, 481)
        Me.DeleteButton1.Name = "DeleteButton1"
        Me.DeleteButton1.PressedColor = System.Drawing.Color.Teal
        Me.DeleteButton1.PressedDepth = 50
        Me.DeleteButton1.ShadowDecoration.Parent = Me.DeleteButton1
        Me.DeleteButton1.Size = New System.Drawing.Size(169, 45)
        Me.DeleteButton1.TabIndex = 17
        Me.DeleteButton1.Text = "Delete"
        '
        'SaveButton2
        '
        Me.SaveButton2.Animated = True
        Me.SaveButton2.AutoRoundedCorners = True
        Me.SaveButton2.BorderRadius = 21
        Me.SaveButton2.CheckedState.Parent = Me.SaveButton2
        Me.SaveButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton2.CustomImages.Parent = Me.SaveButton2
        Me.SaveButton2.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.SaveButton2.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.SaveButton2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton2.ForeColor = System.Drawing.Color.White
        Me.SaveButton2.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.SaveButton2.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.SaveButton2.HoverState.Parent = Me.SaveButton2
        Me.SaveButton2.Location = New System.Drawing.Point(27, 481)
        Me.SaveButton2.Name = "SaveButton2"
        Me.SaveButton2.PressedColor = System.Drawing.Color.Teal
        Me.SaveButton2.PressedDepth = 50
        Me.SaveButton2.ShadowDecoration.Parent = Me.SaveButton2
        Me.SaveButton2.Size = New System.Drawing.Size(162, 45)
        Me.SaveButton2.TabIndex = 19
        Me.SaveButton2.Text = "Save"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Showpass
        '
        Me.Showpass.AutoSize = True
        Me.Showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Showpass.CheckedState.BorderRadius = 2
        Me.Showpass.CheckedState.BorderThickness = 0
        Me.Showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Showpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Showpass.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Showpass.Location = New System.Drawing.Point(58, 406)
        Me.Showpass.Name = "Showpass"
        Me.Showpass.Size = New System.Drawing.Size(148, 26)
        Me.Showpass.TabIndex = 21
        Me.Showpass.Text = "Show Password"
        Me.Showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Showpass.UncheckedState.BorderRadius = 2
        Me.Showpass.UncheckedState.BorderThickness = 0
        Me.Showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Showpass.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(616, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(575, 336)
        Me.DataGridView1.TabIndex = 22
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1268, 88)
        Me.Guna2GradientPanel1.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(823, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 43)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Admin List"
        '
        'RefreshButton
        '
        Me.RefreshButton.AutoRoundedCorners = True
        Me.RefreshButton.BorderRadius = 21
        Me.RefreshButton.CheckedState.Parent = Me.RefreshButton
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.CustomImages.Parent = Me.RefreshButton
        Me.RefreshButton.FillColor = System.Drawing.Color.Silver
        Me.RefreshButton.FillColor2 = System.Drawing.Color.Silver
        Me.RefreshButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.ForeColor = System.Drawing.Color.Black
        Me.RefreshButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RefreshButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RefreshButton.HoverState.Parent = Me.RefreshButton
        Me.RefreshButton.Location = New System.Drawing.Point(837, 481)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.PressedColor = System.Drawing.Color.Teal
        Me.RefreshButton.PressedDepth = 50
        Me.RefreshButton.ShadowDecoration.Parent = Me.RefreshButton
        Me.RefreshButton.Size = New System.Drawing.Size(169, 45)
        Me.RefreshButton.TabIndex = 25
        Me.RefreshButton.Text = "Refresh"
        '
        'UpdateButton3
        '
        Me.UpdateButton3.Animated = True
        Me.UpdateButton3.AutoRoundedCorners = True
        Me.UpdateButton3.BorderRadius = 21
        Me.UpdateButton3.CheckedState.Parent = Me.UpdateButton3
        Me.UpdateButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton3.CustomImages.Parent = Me.UpdateButton3
        Me.UpdateButton3.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.UpdateButton3.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.UpdateButton3.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton3.ForeColor = System.Drawing.Color.White
        Me.UpdateButton3.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.UpdateButton3.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.UpdateButton3.HoverState.Parent = Me.UpdateButton3
        Me.UpdateButton3.Location = New System.Drawing.Point(206, 481)
        Me.UpdateButton3.Name = "UpdateButton3"
        Me.UpdateButton3.PressedColor = System.Drawing.Color.Teal
        Me.UpdateButton3.PressedDepth = 50
        Me.UpdateButton3.ShadowDecoration.Parent = Me.UpdateButton3
        Me.UpdateButton3.Size = New System.Drawing.Size(162, 45)
        Me.UpdateButton3.TabIndex = 26
        Me.UpdateButton3.Text = "Update"
        '
        'AddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1268, 588)
        Me.Controls.Add(Me.UpdateButton3)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Showpass)
        Me.Controls.Add(Me.SaveButton2)
        Me.Controls.Add(Me.DeleteButton1)
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
        Me.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddUsers"
        Me.Text = "AddUsers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
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
    Friend WithEvents DeleteButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents SaveButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents RefreshButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents UpdateButton3 As Guna.UI2.WinForms.Guna2GradientButton
End Class
