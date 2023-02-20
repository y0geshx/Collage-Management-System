<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attandance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attandance))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CourseSemYearCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelCourseCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SelSubjectCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SelStudentID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SubmitButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.StudentNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StudentLastNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RefreshButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Teal
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1151, 78)
        Me.Guna2GradientPanel1.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Attandance"
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
        'CourseSemYearCB
        '
        Me.CourseSemYearCB.AutoRoundedCorners = True
        Me.CourseSemYearCB.BackColor = System.Drawing.Color.Transparent
        Me.CourseSemYearCB.BorderColor = System.Drawing.Color.Silver
        Me.CourseSemYearCB.BorderRadius = 17
        Me.CourseSemYearCB.BorderThickness = 2
        Me.CourseSemYearCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CourseSemYearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseSemYearCB.FocusedColor = System.Drawing.Color.Empty
        Me.CourseSemYearCB.FocusedState.Parent = Me.CourseSemYearCB
        Me.CourseSemYearCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseSemYearCB.ForeColor = System.Drawing.Color.Black
        Me.CourseSemYearCB.FormattingEnabled = True
        Me.CourseSemYearCB.HoverState.Parent = Me.CourseSemYearCB
        Me.CourseSemYearCB.ItemHeight = 30
        Me.CourseSemYearCB.Items.AddRange(New Object() {"Semester -1", "Semester -2", "Semester -3", "Semester -4", "Semester -5", "Semester -6", "Semester -8", "Year -1", "Year -2", "Year -3", "Year -4"})
        Me.CourseSemYearCB.ItemsAppearance.Parent = Me.CourseSemYearCB
        Me.CourseSemYearCB.Location = New System.Drawing.Point(245, 162)
        Me.CourseSemYearCB.Name = "CourseSemYearCB"
        Me.CourseSemYearCB.ShadowDecoration.Parent = Me.CourseSemYearCB
        Me.CourseSemYearCB.Size = New System.Drawing.Size(230, 36)
        Me.CourseSemYearCB.TabIndex = 159
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(494, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 43)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Select Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(494, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 43)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Select Course"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(47, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 43)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Sem/Year"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.AutoRoundedCorners = True
        Me.DateTimePicker.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePicker.BorderRadius = 20
        Me.DateTimePicker.BorderThickness = 2
        Me.DateTimePicker.CheckedState.Parent = Me.DateTimePicker
        Me.DateTimePicker.FillColor = System.Drawing.Color.White
        Me.DateTimePicker.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker.HoverState.Parent = Me.DateTimePicker
        Me.DateTimePicker.Location = New System.Drawing.Point(245, 93)
        Me.DateTimePicker.MaxDate = New Date(2023, 2, 3, 0, 0, 0, 0)
        Me.DateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.ShadowDecoration.Parent = Me.DateTimePicker
        Me.DateTimePicker.Size = New System.Drawing.Size(230, 43)
        Me.DateTimePicker.TabIndex = 161
        Me.DateTimePicker.Value = New Date(2023, 2, 3, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(47, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 43)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Select Date"
        '
        'SelCourseCB
        '
        Me.SelCourseCB.AutoRoundedCorners = True
        Me.SelCourseCB.BackColor = System.Drawing.Color.Transparent
        Me.SelCourseCB.BorderColor = System.Drawing.Color.Silver
        Me.SelCourseCB.BorderRadius = 17
        Me.SelCourseCB.BorderThickness = 2
        Me.SelCourseCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SelCourseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelCourseCB.FocusedColor = System.Drawing.Color.Empty
        Me.SelCourseCB.FocusedState.Parent = Me.SelCourseCB
        Me.SelCourseCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelCourseCB.ForeColor = System.Drawing.Color.Black
        Me.SelCourseCB.FormattingEnabled = True
        Me.SelCourseCB.HoverState.Parent = Me.SelCourseCB
        Me.SelCourseCB.ItemHeight = 30
        Me.SelCourseCB.ItemsAppearance.Parent = Me.SelCourseCB
        Me.SelCourseCB.Location = New System.Drawing.Point(755, 100)
        Me.SelCourseCB.Name = "SelCourseCB"
        Me.SelCourseCB.ShadowDecoration.Parent = Me.SelCourseCB
        Me.SelCourseCB.Size = New System.Drawing.Size(230, 36)
        Me.SelCourseCB.TabIndex = 163
        '
        'SelSubjectCB
        '
        Me.SelSubjectCB.AutoRoundedCorners = True
        Me.SelSubjectCB.BackColor = System.Drawing.Color.Transparent
        Me.SelSubjectCB.BorderColor = System.Drawing.Color.Silver
        Me.SelSubjectCB.BorderRadius = 17
        Me.SelSubjectCB.BorderThickness = 2
        Me.SelSubjectCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SelSubjectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelSubjectCB.FocusedColor = System.Drawing.Color.Empty
        Me.SelSubjectCB.FocusedState.Parent = Me.SelSubjectCB
        Me.SelSubjectCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelSubjectCB.ForeColor = System.Drawing.Color.Black
        Me.SelSubjectCB.FormattingEnabled = True
        Me.SelSubjectCB.HoverState.Parent = Me.SelSubjectCB
        Me.SelSubjectCB.ItemHeight = 30
        Me.SelSubjectCB.ItemsAppearance.Parent = Me.SelSubjectCB
        Me.SelSubjectCB.Location = New System.Drawing.Point(755, 162)
        Me.SelSubjectCB.Name = "SelSubjectCB"
        Me.SelSubjectCB.ShadowDecoration.Parent = Me.SelSubjectCB
        Me.SelSubjectCB.Size = New System.Drawing.Size(230, 36)
        Me.SelSubjectCB.TabIndex = 164
        '
        'SelStudentID
        '
        Me.SelStudentID.AutoRoundedCorners = True
        Me.SelStudentID.BackColor = System.Drawing.Color.Transparent
        Me.SelStudentID.BorderColor = System.Drawing.Color.Silver
        Me.SelStudentID.BorderRadius = 17
        Me.SelStudentID.BorderThickness = 2
        Me.SelStudentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SelStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelStudentID.FocusedColor = System.Drawing.Color.Empty
        Me.SelStudentID.FocusedState.Parent = Me.SelStudentID
        Me.SelStudentID.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelStudentID.ForeColor = System.Drawing.Color.Black
        Me.SelStudentID.FormattingEnabled = True
        Me.SelStudentID.HoverState.Parent = Me.SelStudentID
        Me.SelStudentID.ItemHeight = 30
        Me.SelStudentID.ItemsAppearance.Parent = Me.SelStudentID
        Me.SelStudentID.Location = New System.Drawing.Point(245, 227)
        Me.SelStudentID.Name = "SelStudentID"
        Me.SelStudentID.ShadowDecoration.Parent = Me.SelStudentID
        Me.SelStudentID.Size = New System.Drawing.Size(230, 36)
        Me.SelStudentID.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(47, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 43)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Student ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(494, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 43)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "Student Name"
        '
        'StatusCB
        '
        Me.StatusCB.AutoRoundedCorners = True
        Me.StatusCB.BackColor = System.Drawing.Color.Transparent
        Me.StatusCB.BorderColor = System.Drawing.Color.Silver
        Me.StatusCB.BorderRadius = 17
        Me.StatusCB.BorderThickness = 2
        Me.StatusCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusCB.FocusedColor = System.Drawing.Color.Empty
        Me.StatusCB.FocusedState.Parent = Me.StatusCB
        Me.StatusCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusCB.ForeColor = System.Drawing.Color.Black
        Me.StatusCB.FormattingEnabled = True
        Me.StatusCB.HoverState.Parent = Me.StatusCB
        Me.StatusCB.ItemHeight = 30
        Me.StatusCB.Items.AddRange(New Object() {"Present", "Absent"})
        Me.StatusCB.ItemsAppearance.Parent = Me.StatusCB
        Me.StatusCB.Location = New System.Drawing.Point(755, 288)
        Me.StatusCB.Name = "StatusCB"
        Me.StatusCB.ShadowDecoration.Parent = Me.StatusCB
        Me.StatusCB.Size = New System.Drawing.Size(230, 36)
        Me.StatusCB.TabIndex = 170
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(568, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 43)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Status"
        '
        'SubmitButton
        '
        Me.SubmitButton.Animated = True
        Me.SubmitButton.AutoRoundedCorners = True
        Me.SubmitButton.BorderRadius = 21
        Me.SubmitButton.CheckedState.Parent = Me.SubmitButton
        Me.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubmitButton.CustomImages.Parent = Me.SubmitButton
        Me.SubmitButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.SubmitButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.SubmitButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.SubmitButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.SubmitButton.HoverState.Parent = Me.SubmitButton
        Me.SubmitButton.Location = New System.Drawing.Point(488, 327)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.PressedColor = System.Drawing.Color.Teal
        Me.SubmitButton.PressedDepth = 50
        Me.SubmitButton.ShadowDecoration.Parent = Me.SubmitButton
        Me.SubmitButton.Size = New System.Drawing.Size(180, 45)
        Me.SubmitButton.TabIndex = 171
        Me.SubmitButton.Text = "Submit"
        '
        'StudentNameTB
        '
        Me.StudentNameTB.Animated = True
        Me.StudentNameTB.AutoRoundedCorners = True
        Me.StudentNameTB.BorderColor = System.Drawing.Color.Silver
        Me.StudentNameTB.BorderRadius = 17
        Me.StudentNameTB.BorderThickness = 2
        Me.StudentNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentNameTB.DefaultText = ""
        Me.StudentNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StudentNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StudentNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentNameTB.DisabledState.Parent = Me.StudentNameTB
        Me.StudentNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StudentNameTB.FocusedState.Parent = Me.StudentNameTB
        Me.StudentNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNameTB.ForeColor = System.Drawing.Color.Black
        Me.StudentNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StudentNameTB.HoverState.Parent = Me.StudentNameTB
        Me.StudentNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StudentNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StudentNameTB.Location = New System.Drawing.Point(755, 227)
        Me.StudentNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StudentNameTB.Name = "StudentNameTB"
        Me.StudentNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StudentNameTB.PlaceholderText = "Student Name"
        Me.StudentNameTB.SelectedText = ""
        Me.StudentNameTB.ShadowDecoration.Parent = Me.StudentNameTB
        Me.StudentNameTB.Size = New System.Drawing.Size(230, 36)
        Me.StudentNameTB.TabIndex = 172
        Me.StudentNameTB.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(47, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 43)
        Me.Label9.TabIndex = 173
        Me.Label9.Text = "Last Name"
        '
        'StudentLastNameTB
        '
        Me.StudentLastNameTB.Animated = True
        Me.StudentLastNameTB.AutoRoundedCorners = True
        Me.StudentLastNameTB.BorderColor = System.Drawing.Color.Silver
        Me.StudentLastNameTB.BorderRadius = 17
        Me.StudentLastNameTB.BorderThickness = 2
        Me.StudentLastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentLastNameTB.DefaultText = ""
        Me.StudentLastNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StudentLastNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StudentLastNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentLastNameTB.DisabledState.Parent = Me.StudentLastNameTB
        Me.StudentLastNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentLastNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StudentLastNameTB.FocusedState.Parent = Me.StudentLastNameTB
        Me.StudentLastNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentLastNameTB.ForeColor = System.Drawing.Color.Black
        Me.StudentLastNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StudentLastNameTB.HoverState.Parent = Me.StudentLastNameTB
        Me.StudentLastNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StudentLastNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StudentLastNameTB.Location = New System.Drawing.Point(245, 288)
        Me.StudentLastNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StudentLastNameTB.Name = "StudentLastNameTB"
        Me.StudentLastNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentLastNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StudentLastNameTB.PlaceholderText = "Student Last Name"
        Me.StudentLastNameTB.SelectedText = ""
        Me.StudentLastNameTB.ShadowDecoration.Parent = Me.StudentLastNameTB
        Me.StudentLastNameTB.Size = New System.Drawing.Size(230, 36)
        Me.StudentLastNameTB.TabIndex = 174
        Me.StudentLastNameTB.TabStop = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 424)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1151, 249)
        Me.DataGridView1.TabIndex = 175
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label10.Location = New System.Drawing.Point(12, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(261, 43)
        Me.Label10.TabIndex = 177
        Me.Label10.Text = "Attandance List"
        '
        'RefreshButton
        '
        Me.RefreshButton.Animated = True
        Me.RefreshButton.AutoRoundedCorners = True
        Me.RefreshButton.BorderRadius = 14
        Me.RefreshButton.CheckedState.Parent = Me.RefreshButton
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.CustomImages.Parent = Me.RefreshButton
        Me.RefreshButton.FillColor = System.Drawing.Color.SlateGray
        Me.RefreshButton.FillColor2 = System.Drawing.Color.SlateGray
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.ForeColor = System.Drawing.Color.White
        Me.RefreshButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.RefreshButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.RefreshButton.HoverState.Parent = Me.RefreshButton
        Me.RefreshButton.Location = New System.Drawing.Point(279, 355)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.PressedColor = System.Drawing.Color.Teal
        Me.RefreshButton.PressedDepth = 50
        Me.RefreshButton.ShadowDecoration.Parent = Me.RefreshButton
        Me.RefreshButton.Size = New System.Drawing.Size(105, 30)
        Me.RefreshButton.TabIndex = 176
        Me.RefreshButton.Text = "Refresh"
        '
        'Attandance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 673)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StudentLastNameTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.StudentNameTB)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.StatusCB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SelStudentID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SelSubjectCB)
        Me.Controls.Add(Me.SelCourseCB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.CourseSemYearCB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attandance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attandance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CourseSemYearCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents SelCourseCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SelSubjectCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SelStudentID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents StudentNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents StudentLastNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents RefreshButton As Guna.UI2.WinForms.Guna2GradientButton
End Class
