<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditFaculty
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditFaculty))
        Me.FLastNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.timelable = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FAgeTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FShowpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.FPasswordTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FExpTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FQualiTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditCloseButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.FacultyDeleteButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.FacultyUpdateButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PicClearButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PicSelectButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FemailTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FPINCodeTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FStateTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FCityTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FAddressTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FPhoneTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FDOBDateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FFirstNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FGenderComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.FID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.StatusComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.FsubjectTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ChangeSubButton = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FLastNameTB
        '
        Me.FLastNameTB.Animated = True
        Me.FLastNameTB.AutoRoundedCorners = True
        Me.FLastNameTB.BorderColor = System.Drawing.Color.Silver
        Me.FLastNameTB.BorderRadius = 17
        Me.FLastNameTB.BorderThickness = 2
        Me.FLastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FLastNameTB.DefaultText = ""
        Me.FLastNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FLastNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FLastNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FLastNameTB.DisabledState.Parent = Me.FLastNameTB
        Me.FLastNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FLastNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FLastNameTB.FocusedState.Parent = Me.FLastNameTB
        Me.FLastNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLastNameTB.ForeColor = System.Drawing.Color.Black
        Me.FLastNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FLastNameTB.HoverState.Parent = Me.FLastNameTB
        Me.FLastNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FLastNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FLastNameTB.Location = New System.Drawing.Point(402, 54)
        Me.FLastNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FLastNameTB.Name = "FLastNameTB"
        Me.FLastNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FLastNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FLastNameTB.PlaceholderText = "Last Name"
        Me.FLastNameTB.SelectedText = ""
        Me.FLastNameTB.ShadowDecoration.Parent = Me.FLastNameTB
        Me.FLastNameTB.Size = New System.Drawing.Size(185, 36)
        Me.FLastNameTB.TabIndex = 132
        '
        'timelable
        '
        Me.timelable.AutoSize = True
        Me.timelable.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timelable.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.timelable.Location = New System.Drawing.Point(1000, 521)
        Me.timelable.Name = "timelable"
        Me.timelable.Size = New System.Drawing.Size(35, 18)
        Me.timelable.TabIndex = 131
        Me.timelable.Text = "date"
        Me.timelable.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label18.Location = New System.Drawing.Point(221, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 33)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "Age"
        '
        'FAgeTB
        '
        Me.FAgeTB.Animated = True
        Me.FAgeTB.AutoRoundedCorners = True
        Me.FAgeTB.BorderColor = System.Drawing.Color.Silver
        Me.FAgeTB.BorderRadius = 17
        Me.FAgeTB.BorderThickness = 2
        Me.FAgeTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FAgeTB.DefaultText = ""
        Me.FAgeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FAgeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FAgeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FAgeTB.DisabledState.Parent = Me.FAgeTB
        Me.FAgeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FAgeTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FAgeTB.FocusedState.Parent = Me.FAgeTB
        Me.FAgeTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAgeTB.ForeColor = System.Drawing.Color.Black
        Me.FAgeTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FAgeTB.HoverState.Parent = Me.FAgeTB
        Me.FAgeTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FAgeTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FAgeTB.Location = New System.Drawing.Point(227, 152)
        Me.FAgeTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FAgeTB.Name = "FAgeTB"
        Me.FAgeTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FAgeTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FAgeTB.PlaceholderText = "Age"
        Me.FAgeTB.SelectedText = ""
        Me.FAgeTB.ShadowDecoration.Parent = Me.FAgeTB
        Me.FAgeTB.Size = New System.Drawing.Size(121, 36)
        Me.FAgeTB.TabIndex = 129
        '
        'FShowpass
        '
        Me.FShowpass.AutoSize = True
        Me.FShowpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FShowpass.CheckedState.BorderRadius = 2
        Me.FShowpass.CheckedState.BorderThickness = 0
        Me.FShowpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FShowpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FShowpass.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FShowpass.Location = New System.Drawing.Point(854, 416)
        Me.FShowpass.Name = "FShowpass"
        Me.FShowpass.Size = New System.Drawing.Size(108, 19)
        Me.FShowpass.TabIndex = 128
        Me.FShowpass.Text = "Show Password"
        Me.FShowpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.FShowpass.UncheckedState.BorderRadius = 2
        Me.FShowpass.UncheckedState.BorderThickness = 0
        Me.FShowpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.FShowpass.UseVisualStyleBackColor = True
        '
        'FPasswordTB
        '
        Me.FPasswordTB.AutoRoundedCorners = True
        Me.FPasswordTB.BorderColor = System.Drawing.Color.Silver
        Me.FPasswordTB.BorderRadius = 17
        Me.FPasswordTB.BorderThickness = 2
        Me.FPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FPasswordTB.DefaultText = ""
        Me.FPasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FPasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FPasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FPasswordTB.DisabledState.Parent = Me.FPasswordTB
        Me.FPasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FPasswordTB.FocusedState.BorderColor = System.Drawing.Color.Turquoise
        Me.FPasswordTB.FocusedState.Parent = Me.FPasswordTB
        Me.FPasswordTB.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FPasswordTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPasswordTB.ForeColor = System.Drawing.Color.Black
        Me.FPasswordTB.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.FPasswordTB.HoverState.Parent = Me.FPasswordTB
        Me.FPasswordTB.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkTurquoise
        Me.FPasswordTB.IconLeft = CType(resources.GetObject("FPasswordTB.IconLeft"), System.Drawing.Image)
        Me.FPasswordTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FPasswordTB.Location = New System.Drawing.Point(791, 374)
        Me.FPasswordTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FPasswordTB.Name = "FPasswordTB"
        Me.FPasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FPasswordTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FPasswordTB.PlaceholderText = "Password"
        Me.FPasswordTB.SelectedText = ""
        Me.FPasswordTB.ShadowDecoration.Parent = Me.FPasswordTB
        Me.FPasswordTB.Size = New System.Drawing.Size(230, 36)
        Me.FPasswordTB.TabIndex = 127
        Me.FPasswordTB.UseSystemPasswordChar = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label16.Location = New System.Drawing.Point(786, 338)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 33)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(204, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 33)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Experience"
        '
        'FExpTB
        '
        Me.FExpTB.Animated = True
        Me.FExpTB.AutoRoundedCorners = True
        Me.FExpTB.BorderColor = System.Drawing.Color.Silver
        Me.FExpTB.BorderRadius = 17
        Me.FExpTB.BorderThickness = 2
        Me.FExpTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FExpTB.DefaultText = ""
        Me.FExpTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FExpTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FExpTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FExpTB.DisabledState.Parent = Me.FExpTB
        Me.FExpTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FExpTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FExpTB.FocusedState.Parent = Me.FExpTB
        Me.FExpTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FExpTB.ForeColor = System.Drawing.Color.Black
        Me.FExpTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FExpTB.HoverState.Parent = Me.FExpTB
        Me.FExpTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FExpTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FExpTB.Location = New System.Drawing.Point(210, 374)
        Me.FExpTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FExpTB.Name = "FExpTB"
        Me.FExpTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FExpTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FExpTB.PlaceholderText = "Experience"
        Me.FExpTB.SelectedText = ""
        Me.FExpTB.ShadowDecoration.Parent = Me.FExpTB
        Me.FExpTB.Size = New System.Drawing.Size(163, 36)
        Me.FExpTB.TabIndex = 124
        '
        'FQualiTB
        '
        Me.FQualiTB.Animated = True
        Me.FQualiTB.AutoRoundedCorners = True
        Me.FQualiTB.BorderColor = System.Drawing.Color.Silver
        Me.FQualiTB.BorderRadius = 17
        Me.FQualiTB.BorderThickness = 2
        Me.FQualiTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FQualiTB.DefaultText = ""
        Me.FQualiTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FQualiTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FQualiTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FQualiTB.DisabledState.Parent = Me.FQualiTB
        Me.FQualiTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FQualiTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FQualiTB.FocusedState.Parent = Me.FQualiTB
        Me.FQualiTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FQualiTB.ForeColor = System.Drawing.Color.Black
        Me.FQualiTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FQualiTB.HoverState.Parent = Me.FQualiTB
        Me.FQualiTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FQualiTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FQualiTB.Location = New System.Drawing.Point(11, 374)
        Me.FQualiTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FQualiTB.Name = "FQualiTB"
        Me.FQualiTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FQualiTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FQualiTB.PlaceholderText = "Qualification"
        Me.FQualiTB.SelectedText = ""
        Me.FQualiTB.ShadowDecoration.Parent = Me.FQualiTB
        Me.FQualiTB.Size = New System.Drawing.Size(185, 36)
        Me.FQualiTB.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(6, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 33)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Qualification"
        '
        'EditCloseButton1
        '
        Me.EditCloseButton1.AutoRoundedCorners = True
        Me.EditCloseButton1.BorderRadius = 21
        Me.EditCloseButton1.CheckedState.Parent = Me.EditCloseButton1
        Me.EditCloseButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditCloseButton1.CustomImages.Parent = Me.EditCloseButton1
        Me.EditCloseButton1.FillColor = System.Drawing.Color.Silver
        Me.EditCloseButton1.FillColor2 = System.Drawing.Color.Silver
        Me.EditCloseButton1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCloseButton1.ForeColor = System.Drawing.Color.Black
        Me.EditCloseButton1.HoverState.FillColor = System.Drawing.Color.Gray
        Me.EditCloseButton1.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.EditCloseButton1.HoverState.Parent = Me.EditCloseButton1
        Me.EditCloseButton1.Location = New System.Drawing.Point(769, 457)
        Me.EditCloseButton1.Name = "EditCloseButton1"
        Me.EditCloseButton1.PressedColor = System.Drawing.Color.Teal
        Me.EditCloseButton1.PressedDepth = 50
        Me.EditCloseButton1.ShadowDecoration.Parent = Me.EditCloseButton1
        Me.EditCloseButton1.Size = New System.Drawing.Size(180, 45)
        Me.EditCloseButton1.TabIndex = 121
        Me.EditCloseButton1.Text = "Cancel"
        '
        'FacultyDeleteButton
        '
        Me.FacultyDeleteButton.Animated = True
        Me.FacultyDeleteButton.AutoRoundedCorners = True
        Me.FacultyDeleteButton.BorderRadius = 21
        Me.FacultyDeleteButton.CheckedState.Parent = Me.FacultyDeleteButton
        Me.FacultyDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FacultyDeleteButton.CustomImages.Parent = Me.FacultyDeleteButton
        Me.FacultyDeleteButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.FacultyDeleteButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.FacultyDeleteButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacultyDeleteButton.ForeColor = System.Drawing.Color.White
        Me.FacultyDeleteButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.FacultyDeleteButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.FacultyDeleteButton.HoverState.Parent = Me.FacultyDeleteButton
        Me.FacultyDeleteButton.Location = New System.Drawing.Point(277, 457)
        Me.FacultyDeleteButton.Name = "FacultyDeleteButton"
        Me.FacultyDeleteButton.PressedColor = System.Drawing.Color.Teal
        Me.FacultyDeleteButton.PressedDepth = 50
        Me.FacultyDeleteButton.ShadowDecoration.Parent = Me.FacultyDeleteButton
        Me.FacultyDeleteButton.Size = New System.Drawing.Size(180, 45)
        Me.FacultyDeleteButton.TabIndex = 120
        Me.FacultyDeleteButton.Text = "Delete"
        '
        'FacultyUpdateButton
        '
        Me.FacultyUpdateButton.Animated = True
        Me.FacultyUpdateButton.AutoRoundedCorners = True
        Me.FacultyUpdateButton.BorderRadius = 21
        Me.FacultyUpdateButton.CheckedState.Parent = Me.FacultyUpdateButton
        Me.FacultyUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FacultyUpdateButton.CustomImages.Parent = Me.FacultyUpdateButton
        Me.FacultyUpdateButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.FacultyUpdateButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.FacultyUpdateButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacultyUpdateButton.ForeColor = System.Drawing.Color.White
        Me.FacultyUpdateButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.FacultyUpdateButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.FacultyUpdateButton.HoverState.Parent = Me.FacultyUpdateButton
        Me.FacultyUpdateButton.Location = New System.Drawing.Point(37, 457)
        Me.FacultyUpdateButton.Name = "FacultyUpdateButton"
        Me.FacultyUpdateButton.PressedColor = System.Drawing.Color.Teal
        Me.FacultyUpdateButton.PressedDepth = 50
        Me.FacultyUpdateButton.ShadowDecoration.Parent = Me.FacultyUpdateButton
        Me.FacultyUpdateButton.Size = New System.Drawing.Size(180, 45)
        Me.FacultyUpdateButton.TabIndex = 119
        Me.FacultyUpdateButton.Text = "Update"
        '
        'PicClearButton
        '
        Me.PicClearButton.AutoRoundedCorners = True
        Me.PicClearButton.BorderRadius = 17
        Me.PicClearButton.CheckedState.Parent = Me.PicClearButton
        Me.PicClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicClearButton.CustomImages.Parent = Me.PicClearButton
        Me.PicClearButton.FillColor = System.Drawing.Color.SlateBlue
        Me.PicClearButton.FillColor2 = System.Drawing.Color.SlateBlue
        Me.PicClearButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicClearButton.ForeColor = System.Drawing.Color.White
        Me.PicClearButton.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.PicClearButton.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.PicClearButton.HoverState.Parent = Me.PicClearButton
        Me.PicClearButton.Location = New System.Drawing.Point(894, 215)
        Me.PicClearButton.Name = "PicClearButton"
        Me.PicClearButton.PressedColor = System.Drawing.Color.Turquoise
        Me.PicClearButton.PressedDepth = 100
        Me.PicClearButton.ShadowDecoration.Parent = Me.PicClearButton
        Me.PicClearButton.Size = New System.Drawing.Size(104, 37)
        Me.PicClearButton.TabIndex = 118
        Me.PicClearButton.Text = "Clear"
        Me.PicClearButton.Visible = False
        '
        'PicSelectButton
        '
        Me.PicSelectButton.AutoRoundedCorners = True
        Me.PicSelectButton.BorderRadius = 17
        Me.PicSelectButton.CheckedState.Parent = Me.PicSelectButton
        Me.PicSelectButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSelectButton.CustomImages.Parent = Me.PicSelectButton
        Me.PicSelectButton.FillColor = System.Drawing.Color.SlateBlue
        Me.PicSelectButton.FillColor2 = System.Drawing.Color.SlateBlue
        Me.PicSelectButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicSelectButton.ForeColor = System.Drawing.Color.White
        Me.PicSelectButton.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.PicSelectButton.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.PicSelectButton.HoverState.Parent = Me.PicSelectButton
        Me.PicSelectButton.Location = New System.Drawing.Point(760, 215)
        Me.PicSelectButton.Name = "PicSelectButton"
        Me.PicSelectButton.PressedColor = System.Drawing.Color.Turquoise
        Me.PicSelectButton.PressedDepth = 100
        Me.PicSelectButton.ShadowDecoration.Parent = Me.PicSelectButton
        Me.PicSelectButton.Size = New System.Drawing.Size(104, 36)
        Me.PicSelectButton.TabIndex = 117
        Me.PicSelectButton.Text = "Select"
        Me.PicSelectButton.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(833, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 33)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Photo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(782, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 115
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(536, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 33)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Email"
        '
        'FemailTB
        '
        Me.FemailTB.Animated = True
        Me.FemailTB.AutoRoundedCorners = True
        Me.FemailTB.BorderColor = System.Drawing.Color.Silver
        Me.FemailTB.BorderRadius = 17
        Me.FemailTB.BorderThickness = 2
        Me.FemailTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FemailTB.DefaultText = ""
        Me.FemailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FemailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FemailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FemailTB.DisabledState.Parent = Me.FemailTB
        Me.FemailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FemailTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FemailTB.FocusedState.Parent = Me.FemailTB
        Me.FemailTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FemailTB.ForeColor = System.Drawing.Color.Black
        Me.FemailTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FemailTB.HoverState.Parent = Me.FemailTB
        Me.FemailTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FemailTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FemailTB.Location = New System.Drawing.Point(542, 152)
        Me.FemailTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FemailTB.Name = "FemailTB"
        Me.FemailTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FemailTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FemailTB.PlaceholderText = "Email"
        Me.FemailTB.SelectedText = ""
        Me.FemailTB.ShadowDecoration.Parent = Me.FemailTB
        Me.FemailTB.Size = New System.Drawing.Size(185, 36)
        Me.FemailTB.TabIndex = 113
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(567, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 33)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "PIN Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(22, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 33)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Address"
        '
        'FPINCodeTB
        '
        Me.FPINCodeTB.Animated = True
        Me.FPINCodeTB.AutoRoundedCorners = True
        Me.FPINCodeTB.BorderColor = System.Drawing.Color.Silver
        Me.FPINCodeTB.BorderRadius = 17
        Me.FPINCodeTB.BorderThickness = 2
        Me.FPINCodeTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FPINCodeTB.DefaultText = ""
        Me.FPINCodeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FPINCodeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FPINCodeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FPINCodeTB.DisabledState.Parent = Me.FPINCodeTB
        Me.FPINCodeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FPINCodeTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FPINCodeTB.FocusedState.Parent = Me.FPINCodeTB
        Me.FPINCodeTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPINCodeTB.ForeColor = System.Drawing.Color.Black
        Me.FPINCodeTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FPINCodeTB.HoverState.Parent = Me.FPINCodeTB
        Me.FPINCodeTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FPINCodeTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FPINCodeTB.Location = New System.Drawing.Point(595, 267)
        Me.FPINCodeTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FPINCodeTB.Name = "FPINCodeTB"
        Me.FPINCodeTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FPINCodeTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FPINCodeTB.PlaceholderText = "PIN Code"
        Me.FPINCodeTB.SelectedText = ""
        Me.FPINCodeTB.ShadowDecoration.Parent = Me.FPINCodeTB
        Me.FPINCodeTB.Size = New System.Drawing.Size(201, 36)
        Me.FPINCodeTB.TabIndex = 110
        '
        'FStateTB
        '
        Me.FStateTB.Animated = True
        Me.FStateTB.AutoRoundedCorners = True
        Me.FStateTB.BorderColor = System.Drawing.Color.Silver
        Me.FStateTB.BorderRadius = 17
        Me.FStateTB.BorderThickness = 2
        Me.FStateTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FStateTB.DefaultText = ""
        Me.FStateTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FStateTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FStateTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FStateTB.DisabledState.Parent = Me.FStateTB
        Me.FStateTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FStateTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FStateTB.FocusedState.Parent = Me.FStateTB
        Me.FStateTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FStateTB.ForeColor = System.Drawing.Color.Black
        Me.FStateTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FStateTB.HoverState.Parent = Me.FStateTB
        Me.FStateTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FStateTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FStateTB.Location = New System.Drawing.Point(420, 267)
        Me.FStateTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FStateTB.Name = "FStateTB"
        Me.FStateTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FStateTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FStateTB.PlaceholderText = "State"
        Me.FStateTB.SelectedText = ""
        Me.FStateTB.ShadowDecoration.Parent = Me.FStateTB
        Me.FStateTB.Size = New System.Drawing.Size(167, 36)
        Me.FStateTB.TabIndex = 109
        '
        'FCityTB
        '
        Me.FCityTB.Animated = True
        Me.FCityTB.AutoRoundedCorners = True
        Me.FCityTB.BorderColor = System.Drawing.Color.Silver
        Me.FCityTB.BorderRadius = 17
        Me.FCityTB.BorderThickness = 2
        Me.FCityTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FCityTB.DefaultText = ""
        Me.FCityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FCityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FCityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FCityTB.DisabledState.Parent = Me.FCityTB
        Me.FCityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FCityTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FCityTB.FocusedState.Parent = Me.FCityTB
        Me.FCityTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FCityTB.ForeColor = System.Drawing.Color.Black
        Me.FCityTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FCityTB.HoverState.Parent = Me.FCityTB
        Me.FCityTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FCityTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FCityTB.Location = New System.Drawing.Point(240, 267)
        Me.FCityTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FCityTB.Name = "FCityTB"
        Me.FCityTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FCityTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FCityTB.PlaceholderText = "City"
        Me.FCityTB.SelectedText = ""
        Me.FCityTB.ShadowDecoration.Parent = Me.FCityTB
        Me.FCityTB.Size = New System.Drawing.Size(172, 36)
        Me.FCityTB.TabIndex = 108
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(414, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 33)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(234, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 33)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "City"
        '
        'FAddressTB
        '
        Me.FAddressTB.Animated = True
        Me.FAddressTB.BorderColor = System.Drawing.Color.Silver
        Me.FAddressTB.BorderThickness = 2
        Me.FAddressTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FAddressTB.DefaultText = ""
        Me.FAddressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FAddressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FAddressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FAddressTB.DisabledState.Parent = Me.FAddressTB
        Me.FAddressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FAddressTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FAddressTB.FocusedState.Parent = Me.FAddressTB
        Me.FAddressTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAddressTB.ForeColor = System.Drawing.Color.Black
        Me.FAddressTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FAddressTB.HoverState.Parent = Me.FAddressTB
        Me.FAddressTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FAddressTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FAddressTB.Location = New System.Drawing.Point(17, 251)
        Me.FAddressTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FAddressTB.Multiline = True
        Me.FAddressTB.Name = "FAddressTB"
        Me.FAddressTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FAddressTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FAddressTB.PlaceholderText = "Address"
        Me.FAddressTB.SelectedText = ""
        Me.FAddressTB.ShadowDecoration.Parent = Me.FAddressTB
        Me.FAddressTB.Size = New System.Drawing.Size(208, 66)
        Me.FAddressTB.TabIndex = 105
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(588, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 33)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Gender"
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FPhoneTB
        '
        Me.FPhoneTB.Animated = True
        Me.FPhoneTB.AutoRoundedCorners = True
        Me.FPhoneTB.BorderColor = System.Drawing.Color.Silver
        Me.FPhoneTB.BorderRadius = 17
        Me.FPhoneTB.BorderThickness = 2
        Me.FPhoneTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FPhoneTB.DefaultText = ""
        Me.FPhoneTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FPhoneTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FPhoneTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FPhoneTB.DisabledState.Parent = Me.FPhoneTB
        Me.FPhoneTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FPhoneTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FPhoneTB.FocusedState.Parent = Me.FPhoneTB
        Me.FPhoneTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPhoneTB.ForeColor = System.Drawing.Color.Black
        Me.FPhoneTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FPhoneTB.HoverState.Parent = Me.FPhoneTB
        Me.FPhoneTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FPhoneTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FPhoneTB.Location = New System.Drawing.Point(360, 152)
        Me.FPhoneTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FPhoneTB.Name = "FPhoneTB"
        Me.FPhoneTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FPhoneTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FPhoneTB.PlaceholderText = "Phone Number"
        Me.FPhoneTB.SelectedText = ""
        Me.FPhoneTB.ShadowDecoration.Parent = Me.FPhoneTB
        Me.FPhoneTB.Size = New System.Drawing.Size(174, 36)
        Me.FPhoneTB.TabIndex = 102
        '
        'FDOBDateTimePicker
        '
        Me.FDOBDateTimePicker.AutoRoundedCorners = True
        Me.FDOBDateTimePicker.BorderColor = System.Drawing.Color.Silver
        Me.FDOBDateTimePicker.BorderRadius = 17
        Me.FDOBDateTimePicker.BorderThickness = 2
        Me.FDOBDateTimePicker.CheckedState.Parent = Me.FDOBDateTimePicker
        Me.FDOBDateTimePicker.FillColor = System.Drawing.Color.White
        Me.FDOBDateTimePicker.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDOBDateTimePicker.ForeColor = System.Drawing.Color.Black
        Me.FDOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.FDOBDateTimePicker.HoverState.Parent = Me.FDOBDateTimePicker
        Me.FDOBDateTimePicker.Location = New System.Drawing.Point(17, 152)
        Me.FDOBDateTimePicker.MaxDate = New Date(2023, 2, 3, 0, 0, 0, 0)
        Me.FDOBDateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.FDOBDateTimePicker.Name = "FDOBDateTimePicker"
        Me.FDOBDateTimePicker.ShadowDecoration.Parent = Me.FDOBDateTimePicker
        Me.FDOBDateTimePicker.Size = New System.Drawing.Size(200, 36)
        Me.FDOBDateTimePicker.TabIndex = 101
        Me.FDOBDateTimePicker.Value = New Date(2023, 2, 3, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(354, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 33)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(11, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 33)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Date of Birth"
        '
        'FFirstNameTB
        '
        Me.FFirstNameTB.Animated = True
        Me.FFirstNameTB.AutoRoundedCorners = True
        Me.FFirstNameTB.BorderColor = System.Drawing.Color.Silver
        Me.FFirstNameTB.BorderRadius = 17
        Me.FFirstNameTB.BorderThickness = 2
        Me.FFirstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FFirstNameTB.DefaultText = ""
        Me.FFirstNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FFirstNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FFirstNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFirstNameTB.DisabledState.Parent = Me.FFirstNameTB
        Me.FFirstNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFirstNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FFirstNameTB.FocusedState.Parent = Me.FFirstNameTB
        Me.FFirstNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FFirstNameTB.ForeColor = System.Drawing.Color.Black
        Me.FFirstNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FFirstNameTB.HoverState.Parent = Me.FFirstNameTB
        Me.FFirstNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FFirstNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FFirstNameTB.Location = New System.Drawing.Point(210, 54)
        Me.FFirstNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FFirstNameTB.Name = "FFirstNameTB"
        Me.FFirstNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FFirstNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FFirstNameTB.PlaceholderText = "First Name"
        Me.FFirstNameTB.SelectedText = ""
        Me.FFirstNameTB.ShadowDecoration.Parent = Me.FFirstNameTB
        Me.FFirstNameTB.Size = New System.Drawing.Size(185, 36)
        Me.FFirstNameTB.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(396, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 33)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(203, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 33)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "First Name"
        '
        'FGenderComboBox
        '
        Me.FGenderComboBox.AutoRoundedCorners = True
        Me.FGenderComboBox.BackColor = System.Drawing.Color.Transparent
        Me.FGenderComboBox.BorderColor = System.Drawing.Color.Silver
        Me.FGenderComboBox.BorderRadius = 17
        Me.FGenderComboBox.BorderThickness = 2
        Me.FGenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FGenderComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.FGenderComboBox.FocusedState.Parent = Me.FGenderComboBox
        Me.FGenderComboBox.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FGenderComboBox.ForeColor = System.Drawing.Color.Black
        Me.FGenderComboBox.FormattingEnabled = True
        Me.FGenderComboBox.HoverState.Parent = Me.FGenderComboBox
        Me.FGenderComboBox.ItemHeight = 30
        Me.FGenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.FGenderComboBox.ItemsAppearance.Parent = Me.FGenderComboBox
        Me.FGenderComboBox.Location = New System.Drawing.Point(594, 54)
        Me.FGenderComboBox.Name = "FGenderComboBox"
        Me.FGenderComboBox.ShadowDecoration.Parent = Me.FGenderComboBox
        Me.FGenderComboBox.Size = New System.Drawing.Size(140, 36)
        Me.FGenderComboBox.TabIndex = 104
        '
        'FID
        '
        Me.FID.Animated = True
        Me.FID.AutoRoundedCorners = True
        Me.FID.BorderColor = System.Drawing.Color.Silver
        Me.FID.BorderRadius = 17
        Me.FID.BorderThickness = 2
        Me.FID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FID.DefaultText = ""
        Me.FID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FID.DisabledState.Parent = Me.FID
        Me.FID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FID.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FID.FocusedState.Parent = Me.FID
        Me.FID.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FID.ForeColor = System.Drawing.Color.Black
        Me.FID.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FID.HoverState.Parent = Me.FID
        Me.FID.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FID.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FID.Location = New System.Drawing.Point(17, 54)
        Me.FID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FID.Name = "FID"
        Me.FID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FID.PlaceholderText = "Faculty ID"
        Me.FID.SelectedText = ""
        Me.FID.ShadowDecoration.Parent = Me.FID
        Me.FID.Size = New System.Drawing.Size(166, 36)
        Me.FID.TabIndex = 133
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(22, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 33)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Faculty ID"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.AutoRoundedCorners = True
        Me.StatusComboBox.BackColor = System.Drawing.Color.Transparent
        Me.StatusComboBox.BorderColor = System.Drawing.Color.Silver
        Me.StatusComboBox.BorderRadius = 17
        Me.StatusComboBox.BorderThickness = 2
        Me.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.StatusComboBox.FocusedState.Parent = Me.StatusComboBox
        Me.StatusComboBox.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusComboBox.ForeColor = System.Drawing.Color.Black
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.HoverState.Parent = Me.StatusComboBox
        Me.StatusComboBox.ItemHeight = 30
        Me.StatusComboBox.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.StatusComboBox.ItemsAppearance.Parent = Me.StatusComboBox
        Me.StatusComboBox.Location = New System.Drawing.Point(617, 374)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.ShadowDecoration.Parent = Me.StatusComboBox
        Me.StatusComboBox.Size = New System.Drawing.Size(140, 36)
        Me.StatusComboBox.TabIndex = 135
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Location = New System.Drawing.Point(611, 338)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 33)
        Me.Label15.TabIndex = 136
        Me.Label15.Text = "Status"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(385, 338)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(210, 33)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Assigned Subject"
        '
        'FsubjectTB
        '
        Me.FsubjectTB.Animated = True
        Me.FsubjectTB.AutoRoundedCorners = True
        Me.FsubjectTB.BorderColor = System.Drawing.Color.Silver
        Me.FsubjectTB.BorderRadius = 17
        Me.FsubjectTB.BorderThickness = 2
        Me.FsubjectTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FsubjectTB.DefaultText = ""
        Me.FsubjectTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FsubjectTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FsubjectTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FsubjectTB.DisabledState.Parent = Me.FsubjectTB
        Me.FsubjectTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FsubjectTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FsubjectTB.FocusedState.Parent = Me.FsubjectTB
        Me.FsubjectTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FsubjectTB.ForeColor = System.Drawing.Color.Black
        Me.FsubjectTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FsubjectTB.HoverState.Parent = Me.FsubjectTB
        Me.FsubjectTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FsubjectTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FsubjectTB.Location = New System.Drawing.Point(391, 374)
        Me.FsubjectTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FsubjectTB.Name = "FsubjectTB"
        Me.FsubjectTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FsubjectTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FsubjectTB.PlaceholderText = "Subject"
        Me.FsubjectTB.SelectedText = ""
        Me.FsubjectTB.ShadowDecoration.Parent = Me.FsubjectTB
        Me.FsubjectTB.Size = New System.Drawing.Size(219, 36)
        Me.FsubjectTB.TabIndex = 137
        '
        'ChangeSubButton
        '
        Me.ChangeSubButton.Animated = True
        Me.ChangeSubButton.AutoRoundedCorners = True
        Me.ChangeSubButton.BorderRadius = 21
        Me.ChangeSubButton.CheckedState.Parent = Me.ChangeSubButton
        Me.ChangeSubButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeSubButton.CustomImages.Parent = Me.ChangeSubButton
        Me.ChangeSubButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.ChangeSubButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.ChangeSubButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeSubButton.ForeColor = System.Drawing.Color.White
        Me.ChangeSubButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.ChangeSubButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.ChangeSubButton.HoverState.Parent = Me.ChangeSubButton
        Me.ChangeSubButton.Location = New System.Drawing.Point(518, 457)
        Me.ChangeSubButton.Name = "ChangeSubButton"
        Me.ChangeSubButton.PressedColor = System.Drawing.Color.Teal
        Me.ChangeSubButton.PressedDepth = 50
        Me.ChangeSubButton.ShadowDecoration.Parent = Me.ChangeSubButton
        Me.ChangeSubButton.Size = New System.Drawing.Size(180, 45)
        Me.ChangeSubButton.TabIndex = 143
        Me.ChangeSubButton.Text = "Change Subject"
        '
        'EditFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 556)
        Me.Controls.Add(Me.ChangeSubButton)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.FsubjectTB)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.FID)
        Me.Controls.Add(Me.FLastNameTB)
        Me.Controls.Add(Me.timelable)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.FAgeTB)
        Me.Controls.Add(Me.FShowpass)
        Me.Controls.Add(Me.FPasswordTB)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FExpTB)
        Me.Controls.Add(Me.FQualiTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EditCloseButton1)
        Me.Controls.Add(Me.FacultyDeleteButton)
        Me.Controls.Add(Me.FacultyUpdateButton)
        Me.Controls.Add(Me.PicClearButton)
        Me.Controls.Add(Me.PicSelectButton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.FemailTB)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FPINCodeTB)
        Me.Controls.Add(Me.FStateTB)
        Me.Controls.Add(Me.FCityTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FAddressTB)
        Me.Controls.Add(Me.FGenderComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FPhoneTB)
        Me.Controls.Add(Me.FDOBDateTimePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FFirstNameTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditFaculty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Faculty"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FLastNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents timelable As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents FAgeTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FShowpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents FPasswordTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FExpTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FQualiTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EditCloseButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents FacultyDeleteButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents FacultyUpdateButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PicClearButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PicSelectButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FemailTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FPINCodeTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FStateTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FCityTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FAddressTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FPhoneTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FDOBDateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FFirstNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FGenderComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents FID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents StatusComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents FsubjectTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ChangeSubButton As Guna.UI2.WinForms.Guna2GradientButton
End Class
