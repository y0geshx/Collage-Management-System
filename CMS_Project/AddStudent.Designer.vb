<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStudent
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudent))
        Me.StuFirstNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StuLastNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuFatherTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuMotherTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StuDateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.StuPhoneTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StuGenderCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StuAddressTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StuCityTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuPINTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StuEmaliTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UploadButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ClearButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StuCourseTB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StuAdmissionTB = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.SaveButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ResetButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.StuAgeTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timelable = New System.Windows.Forms.Label()
        Me.StuStateCB = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StuFirstNameTB
        '
        Me.StuFirstNameTB.Animated = True
        Me.StuFirstNameTB.AutoRoundedCorners = True
        Me.StuFirstNameTB.BorderColor = System.Drawing.Color.Silver
        Me.StuFirstNameTB.BorderRadius = 17
        Me.StuFirstNameTB.BorderThickness = 2
        Me.StuFirstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuFirstNameTB.DefaultText = ""
        Me.StuFirstNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuFirstNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuFirstNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuFirstNameTB.DisabledState.Parent = Me.StuFirstNameTB
        Me.StuFirstNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuFirstNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuFirstNameTB.FocusedState.Parent = Me.StuFirstNameTB
        Me.StuFirstNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuFirstNameTB.ForeColor = System.Drawing.Color.Black
        Me.StuFirstNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuFirstNameTB.HoverState.Parent = Me.StuFirstNameTB
        Me.StuFirstNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuFirstNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuFirstNameTB.Location = New System.Drawing.Point(35, 75)
        Me.StuFirstNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuFirstNameTB.Name = "StuFirstNameTB"
        Me.StuFirstNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuFirstNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuFirstNameTB.PlaceholderText = "First Name"
        Me.StuFirstNameTB.SelectedText = ""
        Me.StuFirstNameTB.ShadowDecoration.Parent = Me.StuFirstNameTB
        Me.StuFirstNameTB.Size = New System.Drawing.Size(170, 36)
        Me.StuFirstNameTB.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(29, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(207, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(29, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Father Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(222, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 33)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mother Name"
        '
        'StuLastNameTB
        '
        Me.StuLastNameTB.Animated = True
        Me.StuLastNameTB.AutoRoundedCorners = True
        Me.StuLastNameTB.BorderColor = System.Drawing.Color.Silver
        Me.StuLastNameTB.BorderRadius = 17
        Me.StuLastNameTB.BorderThickness = 2
        Me.StuLastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuLastNameTB.DefaultText = ""
        Me.StuLastNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuLastNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuLastNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuLastNameTB.DisabledState.Parent = Me.StuLastNameTB
        Me.StuLastNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuLastNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuLastNameTB.FocusedState.Parent = Me.StuLastNameTB
        Me.StuLastNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuLastNameTB.ForeColor = System.Drawing.Color.Black
        Me.StuLastNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuLastNameTB.HoverState.Parent = Me.StuLastNameTB
        Me.StuLastNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuLastNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuLastNameTB.Location = New System.Drawing.Point(213, 75)
        Me.StuLastNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuLastNameTB.Name = "StuLastNameTB"
        Me.StuLastNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuLastNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuLastNameTB.PlaceholderText = "Last Name"
        Me.StuLastNameTB.SelectedText = ""
        Me.StuLastNameTB.ShadowDecoration.Parent = Me.StuLastNameTB
        Me.StuLastNameTB.Size = New System.Drawing.Size(170, 36)
        Me.StuLastNameTB.TabIndex = 10
        '
        'StuFatherTB
        '
        Me.StuFatherTB.Animated = True
        Me.StuFatherTB.AutoRoundedCorners = True
        Me.StuFatherTB.BorderColor = System.Drawing.Color.Silver
        Me.StuFatherTB.BorderRadius = 17
        Me.StuFatherTB.BorderThickness = 2
        Me.StuFatherTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuFatherTB.DefaultText = ""
        Me.StuFatherTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuFatherTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuFatherTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuFatherTB.DisabledState.Parent = Me.StuFatherTB
        Me.StuFatherTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuFatherTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuFatherTB.FocusedState.Parent = Me.StuFatherTB
        Me.StuFatherTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuFatherTB.ForeColor = System.Drawing.Color.Black
        Me.StuFatherTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuFatherTB.HoverState.Parent = Me.StuFatherTB
        Me.StuFatherTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuFatherTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuFatherTB.Location = New System.Drawing.Point(35, 167)
        Me.StuFatherTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuFatherTB.Name = "StuFatherTB"
        Me.StuFatherTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuFatherTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuFatherTB.PlaceholderText = "Father Name"
        Me.StuFatherTB.SelectedText = ""
        Me.StuFatherTB.ShadowDecoration.Parent = Me.StuFatherTB
        Me.StuFatherTB.Size = New System.Drawing.Size(185, 36)
        Me.StuFatherTB.TabIndex = 11
        '
        'StuMotherTB
        '
        Me.StuMotherTB.Animated = True
        Me.StuMotherTB.AutoRoundedCorners = True
        Me.StuMotherTB.BorderColor = System.Drawing.Color.Silver
        Me.StuMotherTB.BorderRadius = 17
        Me.StuMotherTB.BorderThickness = 2
        Me.StuMotherTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuMotherTB.DefaultText = ""
        Me.StuMotherTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuMotherTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuMotherTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuMotherTB.DisabledState.Parent = Me.StuMotherTB
        Me.StuMotherTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuMotherTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuMotherTB.FocusedState.Parent = Me.StuMotherTB
        Me.StuMotherTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuMotherTB.ForeColor = System.Drawing.Color.Black
        Me.StuMotherTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuMotherTB.HoverState.Parent = Me.StuMotherTB
        Me.StuMotherTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuMotherTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuMotherTB.Location = New System.Drawing.Point(228, 167)
        Me.StuMotherTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuMotherTB.Name = "StuMotherTB"
        Me.StuMotherTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuMotherTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuMotherTB.PlaceholderText = "Mother Name"
        Me.StuMotherTB.SelectedText = ""
        Me.StuMotherTB.ShadowDecoration.Parent = Me.StuMotherTB
        Me.StuMotherTB.Size = New System.Drawing.Size(185, 36)
        Me.StuMotherTB.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(506, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 33)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(415, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 33)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Phone"
        '
        'StuDateTimePicker
        '
        Me.StuDateTimePicker.AutoRoundedCorners = True
        Me.StuDateTimePicker.BorderColor = System.Drawing.Color.Silver
        Me.StuDateTimePicker.BorderRadius = 17
        Me.StuDateTimePicker.BorderThickness = 2
        Me.StuDateTimePicker.CheckedState.Parent = Me.StuDateTimePicker
        Me.StuDateTimePicker.FillColor = System.Drawing.Color.White
        Me.StuDateTimePicker.ForeColor = System.Drawing.Color.Black
        Me.StuDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.StuDateTimePicker.HoverState.Parent = Me.StuDateTimePicker
        Me.StuDateTimePicker.Location = New System.Drawing.Point(512, 75)
        Me.StuDateTimePicker.MaxDate = New Date(2023, 2, 3, 0, 0, 0, 0)
        Me.StuDateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StuDateTimePicker.Name = "StuDateTimePicker"
        Me.StuDateTimePicker.ShadowDecoration.Parent = Me.StuDateTimePicker
        Me.StuDateTimePicker.Size = New System.Drawing.Size(194, 36)
        Me.StuDateTimePicker.TabIndex = 15
        Me.StuDateTimePicker.Value = New Date(2023, 2, 3, 0, 0, 0, 0)
        '
        'StuPhoneTB
        '
        Me.StuPhoneTB.Animated = True
        Me.StuPhoneTB.AutoRoundedCorners = True
        Me.StuPhoneTB.BorderColor = System.Drawing.Color.Silver
        Me.StuPhoneTB.BorderRadius = 17
        Me.StuPhoneTB.BorderThickness = 2
        Me.StuPhoneTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuPhoneTB.DefaultText = ""
        Me.StuPhoneTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuPhoneTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuPhoneTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuPhoneTB.DisabledState.Parent = Me.StuPhoneTB
        Me.StuPhoneTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuPhoneTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuPhoneTB.FocusedState.Parent = Me.StuPhoneTB
        Me.StuPhoneTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuPhoneTB.ForeColor = System.Drawing.Color.Black
        Me.StuPhoneTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuPhoneTB.HoverState.Parent = Me.StuPhoneTB
        Me.StuPhoneTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuPhoneTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuPhoneTB.Location = New System.Drawing.Point(421, 167)
        Me.StuPhoneTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuPhoneTB.Name = "StuPhoneTB"
        Me.StuPhoneTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuPhoneTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuPhoneTB.PlaceholderText = "Phone Number"
        Me.StuPhoneTB.SelectedText = ""
        Me.StuPhoneTB.ShadowDecoration.Parent = Me.StuPhoneTB
        Me.StuPhoneTB.Size = New System.Drawing.Size(174, 36)
        Me.StuPhoneTB.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(384, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 33)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Gender"
        '
        'StuGenderCB
        '
        Me.StuGenderCB.AutoRoundedCorners = True
        Me.StuGenderCB.BackColor = System.Drawing.Color.Transparent
        Me.StuGenderCB.BorderColor = System.Drawing.Color.Silver
        Me.StuGenderCB.BorderRadius = 17
        Me.StuGenderCB.BorderThickness = 2
        Me.StuGenderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StuGenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StuGenderCB.FocusedColor = System.Drawing.Color.Empty
        Me.StuGenderCB.FocusedState.Parent = Me.StuGenderCB
        Me.StuGenderCB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuGenderCB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.StuGenderCB.FormattingEnabled = True
        Me.StuGenderCB.HoverState.Parent = Me.StuGenderCB
        Me.StuGenderCB.ItemHeight = 30
        Me.StuGenderCB.Items.AddRange(New Object() {"male", "female", "other"})
        Me.StuGenderCB.ItemsAppearance.Parent = Me.StuGenderCB
        Me.StuGenderCB.Location = New System.Drawing.Point(390, 75)
        Me.StuGenderCB.Name = "StuGenderCB"
        Me.StuGenderCB.ShadowDecoration.Parent = Me.StuGenderCB
        Me.StuGenderCB.Size = New System.Drawing.Size(116, 36)
        Me.StuGenderCB.TabIndex = 18
        '
        'StuAddressTB
        '
        Me.StuAddressTB.Animated = True
        Me.StuAddressTB.BorderColor = System.Drawing.Color.Silver
        Me.StuAddressTB.BorderThickness = 2
        Me.StuAddressTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuAddressTB.DefaultText = ""
        Me.StuAddressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuAddressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuAddressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuAddressTB.DisabledState.Parent = Me.StuAddressTB
        Me.StuAddressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuAddressTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuAddressTB.FocusedState.Parent = Me.StuAddressTB
        Me.StuAddressTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuAddressTB.ForeColor = System.Drawing.Color.Black
        Me.StuAddressTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuAddressTB.HoverState.Parent = Me.StuAddressTB
        Me.StuAddressTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuAddressTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuAddressTB.Location = New System.Drawing.Point(35, 250)
        Me.StuAddressTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuAddressTB.Multiline = True
        Me.StuAddressTB.Name = "StuAddressTB"
        Me.StuAddressTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuAddressTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuAddressTB.PlaceholderText = "Address"
        Me.StuAddressTB.SelectedText = ""
        Me.StuAddressTB.ShadowDecoration.Parent = Me.StuAddressTB
        Me.StuAddressTB.Size = New System.Drawing.Size(246, 79)
        Me.StuAddressTB.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(283, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 33)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(490, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 33)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "State"
        '
        'StuCityTB
        '
        Me.StuCityTB.Animated = True
        Me.StuCityTB.AutoRoundedCorners = True
        Me.StuCityTB.BorderColor = System.Drawing.Color.Silver
        Me.StuCityTB.BorderRadius = 17
        Me.StuCityTB.BorderThickness = 2
        Me.StuCityTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuCityTB.DefaultText = ""
        Me.StuCityTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuCityTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuCityTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuCityTB.DisabledState.Parent = Me.StuCityTB
        Me.StuCityTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuCityTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuCityTB.FocusedState.Parent = Me.StuCityTB
        Me.StuCityTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuCityTB.ForeColor = System.Drawing.Color.Black
        Me.StuCityTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuCityTB.HoverState.Parent = Me.StuCityTB
        Me.StuCityTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuCityTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuCityTB.Location = New System.Drawing.Point(289, 250)
        Me.StuCityTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuCityTB.Name = "StuCityTB"
        Me.StuCityTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuCityTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuCityTB.PlaceholderText = "City"
        Me.StuCityTB.SelectedText = ""
        Me.StuCityTB.ShadowDecoration.Parent = Me.StuCityTB
        Me.StuCityTB.Size = New System.Drawing.Size(172, 36)
        Me.StuCityTB.TabIndex = 22
        '
        'StuPINTB
        '
        Me.StuPINTB.Animated = True
        Me.StuPINTB.AutoRoundedCorners = True
        Me.StuPINTB.BorderColor = System.Drawing.Color.Silver
        Me.StuPINTB.BorderRadius = 17
        Me.StuPINTB.BorderThickness = 2
        Me.StuPINTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuPINTB.DefaultText = ""
        Me.StuPINTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuPINTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuPINTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuPINTB.DisabledState.Parent = Me.StuPINTB
        Me.StuPINTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuPINTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuPINTB.FocusedState.Parent = Me.StuPINTB
        Me.StuPINTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuPINTB.ForeColor = System.Drawing.Color.Black
        Me.StuPINTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuPINTB.HoverState.Parent = Me.StuPINTB
        Me.StuPINTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuPINTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuPINTB.Location = New System.Drawing.Point(35, 380)
        Me.StuPINTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuPINTB.Name = "StuPINTB"
        Me.StuPINTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuPINTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuPINTB.PlaceholderText = "PIN Code"
        Me.StuPINTB.SelectedText = ""
        Me.StuPINTB.ShadowDecoration.Parent = Me.StuPINTB
        Me.StuPINTB.Size = New System.Drawing.Size(185, 36)
        Me.StuPINTB.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(29, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 33)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(29, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 33)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "PIN Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(595, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 33)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Email"
        '
        'StuEmaliTB
        '
        Me.StuEmaliTB.Animated = True
        Me.StuEmaliTB.AutoRoundedCorners = True
        Me.StuEmaliTB.BorderColor = System.Drawing.Color.Silver
        Me.StuEmaliTB.BorderRadius = 17
        Me.StuEmaliTB.BorderThickness = 2
        Me.StuEmaliTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuEmaliTB.DefaultText = ""
        Me.StuEmaliTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuEmaliTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuEmaliTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuEmaliTB.DisabledState.Parent = Me.StuEmaliTB
        Me.StuEmaliTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuEmaliTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuEmaliTB.FocusedState.Parent = Me.StuEmaliTB
        Me.StuEmaliTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuEmaliTB.ForeColor = System.Drawing.Color.Black
        Me.StuEmaliTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuEmaliTB.HoverState.Parent = Me.StuEmaliTB
        Me.StuEmaliTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuEmaliTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuEmaliTB.Location = New System.Drawing.Point(601, 167)
        Me.StuEmaliTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuEmaliTB.Name = "StuEmaliTB"
        Me.StuEmaliTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuEmaliTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuEmaliTB.PlaceholderText = "Email"
        Me.StuEmaliTB.SelectedText = ""
        Me.StuEmaliTB.ShadowDecoration.Parent = Me.StuEmaliTB
        Me.StuEmaliTB.Size = New System.Drawing.Size(185, 36)
        Me.StuEmaliTB.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(830, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(881, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 33)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Photo"
        '
        'UploadButton
        '
        Me.UploadButton.AutoRoundedCorners = True
        Me.UploadButton.BorderRadius = 17
        Me.UploadButton.CheckedState.Parent = Me.UploadButton
        Me.UploadButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UploadButton.CustomImages.Parent = Me.UploadButton
        Me.UploadButton.FillColor = System.Drawing.Color.SlateBlue
        Me.UploadButton.FillColor2 = System.Drawing.Color.SlateBlue
        Me.UploadButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadButton.ForeColor = System.Drawing.Color.White
        Me.UploadButton.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.UploadButton.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.UploadButton.HoverState.Parent = Me.UploadButton
        Me.UploadButton.Location = New System.Drawing.Point(808, 248)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.PressedColor = System.Drawing.Color.Turquoise
        Me.UploadButton.PressedDepth = 100
        Me.UploadButton.ShadowDecoration.Parent = Me.UploadButton
        Me.UploadButton.Size = New System.Drawing.Size(104, 36)
        Me.UploadButton.TabIndex = 31
        Me.UploadButton.Text = "Upload"
        '
        'ClearButton
        '
        Me.ClearButton.AutoRoundedCorners = True
        Me.ClearButton.BorderRadius = 17
        Me.ClearButton.CheckedState.Parent = Me.ClearButton
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.CustomImages.Parent = Me.ClearButton
        Me.ClearButton.FillColor = System.Drawing.Color.SlateBlue
        Me.ClearButton.FillColor2 = System.Drawing.Color.SlateBlue
        Me.ClearButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.ClearButton.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.ClearButton.HoverState.Parent = Me.ClearButton
        Me.ClearButton.Location = New System.Drawing.Point(929, 248)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.PressedColor = System.Drawing.Color.Turquoise
        Me.ClearButton.PressedDepth = 100
        Me.ClearButton.ShadowDecoration.Parent = Me.ClearButton
        Me.ClearButton.Size = New System.Drawing.Size(104, 37)
        Me.ClearButton.TabIndex = 32
        Me.ClearButton.Text = "Clear"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(246, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 33)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Course"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label16.Location = New System.Drawing.Point(459, 344)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(198, 33)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Admission Date"
        '
        'StuCourseTB
        '
        Me.StuCourseTB.AutoRoundedCorners = True
        Me.StuCourseTB.BackColor = System.Drawing.Color.Transparent
        Me.StuCourseTB.BorderColor = System.Drawing.Color.Silver
        Me.StuCourseTB.BorderRadius = 17
        Me.StuCourseTB.BorderThickness = 2
        Me.StuCourseTB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StuCourseTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StuCourseTB.FocusedColor = System.Drawing.Color.Empty
        Me.StuCourseTB.FocusedState.Parent = Me.StuCourseTB
        Me.StuCourseTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuCourseTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.StuCourseTB.FormattingEnabled = True
        Me.StuCourseTB.HoverState.Parent = Me.StuCourseTB
        Me.StuCourseTB.ItemHeight = 30
        Me.StuCourseTB.ItemsAppearance.Parent = Me.StuCourseTB
        Me.StuCourseTB.Location = New System.Drawing.Point(252, 380)
        Me.StuCourseTB.Name = "StuCourseTB"
        Me.StuCourseTB.ShadowDecoration.Parent = Me.StuCourseTB
        Me.StuCourseTB.Size = New System.Drawing.Size(183, 36)
        Me.StuCourseTB.TabIndex = 39
        '
        'StuAdmissionTB
        '
        Me.StuAdmissionTB.AutoRoundedCorners = True
        Me.StuAdmissionTB.BorderColor = System.Drawing.Color.Silver
        Me.StuAdmissionTB.BorderRadius = 17
        Me.StuAdmissionTB.BorderThickness = 2
        Me.StuAdmissionTB.CheckedState.Parent = Me.StuAdmissionTB
        Me.StuAdmissionTB.FillColor = System.Drawing.Color.White
        Me.StuAdmissionTB.ForeColor = System.Drawing.Color.Black
        Me.StuAdmissionTB.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.StuAdmissionTB.HoverState.Parent = Me.StuAdmissionTB
        Me.StuAdmissionTB.Location = New System.Drawing.Point(465, 380)
        Me.StuAdmissionTB.MaxDate = New Date(2023, 2, 3, 0, 0, 0, 0)
        Me.StuAdmissionTB.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StuAdmissionTB.Name = "StuAdmissionTB"
        Me.StuAdmissionTB.ShadowDecoration.Parent = Me.StuAdmissionTB
        Me.StuAdmissionTB.Size = New System.Drawing.Size(192, 36)
        Me.StuAdmissionTB.TabIndex = 40
        Me.StuAdmissionTB.Value = New Date(2023, 2, 3, 0, 0, 0, 0)
        '
        'SaveButton
        '
        Me.SaveButton.Animated = True
        Me.SaveButton.AutoRoundedCorners = True
        Me.SaveButton.BorderRadius = 21
        Me.SaveButton.CheckedState.Parent = Me.SaveButton
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.CustomImages.Parent = Me.SaveButton
        Me.SaveButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.SaveButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.SaveButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.SaveButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.SaveButton.HoverState.Parent = Me.SaveButton
        Me.SaveButton.Location = New System.Drawing.Point(56, 478)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.PressedColor = System.Drawing.Color.Teal
        Me.SaveButton.PressedDepth = 50
        Me.SaveButton.ShadowDecoration.Parent = Me.SaveButton
        Me.SaveButton.Size = New System.Drawing.Size(180, 45)
        Me.SaveButton.TabIndex = 41
        Me.SaveButton.Text = "Save"
        '
        'ResetButton
        '
        Me.ResetButton.Animated = True
        Me.ResetButton.AutoRoundedCorners = True
        Me.ResetButton.BorderRadius = 21
        Me.ResetButton.CheckedState.Parent = Me.ResetButton
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.CustomImages.Parent = Me.ResetButton
        Me.ResetButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.ResetButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.ResetButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.ResetButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.ResetButton.HoverState.Parent = Me.ResetButton
        Me.ResetButton.Location = New System.Drawing.Point(296, 478)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.PressedColor = System.Drawing.Color.Teal
        Me.ResetButton.PressedDepth = 50
        Me.ResetButton.ShadowDecoration.Parent = Me.ResetButton
        Me.ResetButton.Size = New System.Drawing.Size(180, 45)
        Me.ResetButton.TabIndex = 42
        Me.ResetButton.Text = "Reset"
        '
        'CloseButton
        '
        Me.CloseButton.AutoRoundedCorners = True
        Me.CloseButton.BorderRadius = 21
        Me.CloseButton.CheckedState.Parent = Me.CloseButton
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.CustomImages.Parent = Me.CloseButton
        Me.CloseButton.FillColor = System.Drawing.Color.Silver
        Me.CloseButton.FillColor2 = System.Drawing.Color.Silver
        Me.CloseButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Black
        Me.CloseButton.HoverState.FillColor = System.Drawing.Color.Gray
        Me.CloseButton.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.CloseButton.HoverState.Parent = Me.CloseButton
        Me.CloseButton.Location = New System.Drawing.Point(543, 478)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.PressedColor = System.Drawing.Color.Teal
        Me.CloseButton.PressedDepth = 50
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 43
        Me.CloseButton.Text = "Cancel"
        '
        'StuAgeTB
        '
        Me.StuAgeTB.Animated = True
        Me.StuAgeTB.AutoRoundedCorners = True
        Me.StuAgeTB.BorderColor = System.Drawing.Color.Silver
        Me.StuAgeTB.BorderRadius = 17
        Me.StuAgeTB.BorderThickness = 2
        Me.StuAgeTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuAgeTB.DefaultText = ""
        Me.StuAgeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuAgeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuAgeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuAgeTB.DisabledState.Parent = Me.StuAgeTB
        Me.StuAgeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuAgeTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuAgeTB.FocusedState.Parent = Me.StuAgeTB
        Me.StuAgeTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuAgeTB.ForeColor = System.Drawing.Color.Black
        Me.StuAgeTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuAgeTB.HoverState.Parent = Me.StuAgeTB
        Me.StuAgeTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuAgeTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuAgeTB.Location = New System.Drawing.Point(713, 75)
        Me.StuAgeTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuAgeTB.Name = "StuAgeTB"
        Me.StuAgeTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuAgeTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuAgeTB.PlaceholderText = "Age"
        Me.StuAgeTB.SelectedText = ""
        Me.StuAgeTB.ShadowDecoration.Parent = Me.StuAgeTB
        Me.StuAgeTB.Size = New System.Drawing.Size(110, 36)
        Me.StuAgeTB.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(707, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 33)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Age"
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'timelable
        '
        Me.timelable.AutoSize = True
        Me.timelable.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timelable.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.timelable.Location = New System.Drawing.Point(1007, 538)
        Me.timelable.Name = "timelable"
        Me.timelable.Size = New System.Drawing.Size(35, 18)
        Me.timelable.TabIndex = 95
        Me.timelable.Text = "date"
        Me.timelable.Visible = False
        '
        'StuStateCB
        '
        Me.StuStateCB.Animated = True
        Me.StuStateCB.AutoRoundedCorners = True
        Me.StuStateCB.BackColor = System.Drawing.Color.Transparent
        Me.StuStateCB.BorderColor = System.Drawing.Color.Silver
        Me.StuStateCB.BorderRadius = 17
        Me.StuStateCB.BorderThickness = 2
        Me.StuStateCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StuStateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StuStateCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StuStateCB.FocusedColor = System.Drawing.Color.Empty
        Me.StuStateCB.FocusedState.Parent = Me.StuStateCB
        Me.StuStateCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuStateCB.ForeColor = System.Drawing.Color.Black
        Me.StuStateCB.FormattingEnabled = True
        Me.StuStateCB.HoverState.Parent = Me.StuStateCB
        Me.StuStateCB.ItemHeight = 30
        Me.StuStateCB.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu & Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Orissa", "Punjab", "Rajasthan ", "Sikkim ", "Tamil Nadu ", "Telangana", "Tripura ", "Uttar Pradesh", "Uttarakhand", "West Bengal"})
        Me.StuStateCB.ItemsAppearance.Parent = Me.StuStateCB
        Me.StuStateCB.Location = New System.Drawing.Point(496, 250)
        Me.StuStateCB.Name = "StuStateCB"
        Me.StuStateCB.ShadowDecoration.Parent = Me.StuStateCB
        Me.StuStateCB.Size = New System.Drawing.Size(236, 36)
        Me.StuStateCB.TabIndex = 97
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1045, 556)
        Me.Controls.Add(Me.StuStateCB)
        Me.Controls.Add(Me.timelable)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.StuAgeTB)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.StuAdmissionTB)
        Me.Controls.Add(Me.StuCourseTB)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.UploadButton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.StuEmaliTB)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.StuPINTB)
        Me.Controls.Add(Me.StuCityTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StuAddressTB)
        Me.Controls.Add(Me.StuGenderCB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StuPhoneTB)
        Me.Controls.Add(Me.StuDateTimePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StuMotherTB)
        Me.Controls.Add(Me.StuFatherTB)
        Me.Controls.Add(Me.StuLastNameTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StuFirstNameTB)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StuFirstNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StuLastNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuFatherTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuMotherTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StuDateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents StuPhoneTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StuGenderCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents StuAddressTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents StuCityTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuPINTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents StuEmaliTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents UploadButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ClearButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents StuCourseTB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents StuAdmissionTB As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ResetButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents StuAgeTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents timelable As Label
    Friend WithEvents StuStateCB As Guna.UI2.WinForms.Guna2ComboBox
End Class
