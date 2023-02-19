<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subject))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SelectCourseCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SelectSemYearCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SubjectTypeCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SubjectIDTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SubjectNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TheoryMarksTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PracticalMarksTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UpdateButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DeleteButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SaveButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.RefreshButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ResetButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Teal
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1183, 88)
        Me.Guna2GradientPanel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Subject"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(423, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 43)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Add/Edit Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(12, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 28)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Select Course"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(12, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 28)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Select Sem/Year"
        '
        'SelectCourseCB
        '
        Me.SelectCourseCB.AutoRoundedCorners = True
        Me.SelectCourseCB.BackColor = System.Drawing.Color.Transparent
        Me.SelectCourseCB.BorderColor = System.Drawing.Color.Silver
        Me.SelectCourseCB.BorderRadius = 17
        Me.SelectCourseCB.BorderThickness = 2
        Me.SelectCourseCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SelectCourseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectCourseCB.FocusedColor = System.Drawing.Color.Empty
        Me.SelectCourseCB.FocusedState.Parent = Me.SelectCourseCB
        Me.SelectCourseCB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectCourseCB.ForeColor = System.Drawing.Color.Black
        Me.SelectCourseCB.FormattingEnabled = True
        Me.SelectCourseCB.HoverState.Parent = Me.SelectCourseCB
        Me.SelectCourseCB.ItemHeight = 30
        Me.SelectCourseCB.ItemsAppearance.Parent = Me.SelectCourseCB
        Me.SelectCourseCB.Location = New System.Drawing.Point(200, 137)
        Me.SelectCourseCB.Name = "SelectCourseCB"
        Me.SelectCourseCB.ShadowDecoration.Parent = Me.SelectCourseCB
        Me.SelectCourseCB.Size = New System.Drawing.Size(188, 36)
        Me.SelectCourseCB.TabIndex = 74
        '
        'SelectSemYearCB
        '
        Me.SelectSemYearCB.AutoRoundedCorners = True
        Me.SelectSemYearCB.BackColor = System.Drawing.Color.Transparent
        Me.SelectSemYearCB.BorderColor = System.Drawing.Color.Silver
        Me.SelectSemYearCB.BorderRadius = 17
        Me.SelectSemYearCB.BorderThickness = 2
        Me.SelectSemYearCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SelectSemYearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectSemYearCB.FocusedColor = System.Drawing.Color.Empty
        Me.SelectSemYearCB.FocusedState.Parent = Me.SelectSemYearCB
        Me.SelectSemYearCB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectSemYearCB.ForeColor = System.Drawing.Color.Black
        Me.SelectSemYearCB.FormattingEnabled = True
        Me.SelectSemYearCB.HoverState.Parent = Me.SelectSemYearCB
        Me.SelectSemYearCB.ItemHeight = 30
        Me.SelectSemYearCB.Items.AddRange(New Object() {"Semester-1", "Semester-2", "Semester-3", "Semester-4", "Semester-5", "Semester-6", "Semester-7", "Semester-8", "Year-1", "Year-2", "Year-3", "Year-4"})
        Me.SelectSemYearCB.ItemsAppearance.Parent = Me.SelectSemYearCB
        Me.SelectSemYearCB.Location = New System.Drawing.Point(200, 188)
        Me.SelectSemYearCB.Name = "SelectSemYearCB"
        Me.SelectSemYearCB.ShadowDecoration.Parent = Me.SelectSemYearCB
        Me.SelectSemYearCB.Size = New System.Drawing.Size(188, 36)
        Me.SelectSemYearCB.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(436, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 33)
        Me.Label5.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(405, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 28)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Subject Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(405, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 28)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Subject ID"
        '
        'SubjectTypeCB
        '
        Me.SubjectTypeCB.AutoRoundedCorners = True
        Me.SubjectTypeCB.BackColor = System.Drawing.Color.Transparent
        Me.SubjectTypeCB.BorderColor = System.Drawing.Color.Silver
        Me.SubjectTypeCB.BorderRadius = 17
        Me.SubjectTypeCB.BorderThickness = 2
        Me.SubjectTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SubjectTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubjectTypeCB.FocusedColor = System.Drawing.Color.Empty
        Me.SubjectTypeCB.FocusedState.Parent = Me.SubjectTypeCB
        Me.SubjectTypeCB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectTypeCB.ForeColor = System.Drawing.Color.Black
        Me.SubjectTypeCB.FormattingEnabled = True
        Me.SubjectTypeCB.HoverState.Parent = Me.SubjectTypeCB
        Me.SubjectTypeCB.ItemHeight = 30
        Me.SubjectTypeCB.Items.AddRange(New Object() {"Core", "Optional"})
        Me.SubjectTypeCB.ItemsAppearance.Parent = Me.SubjectTypeCB
        Me.SubjectTypeCB.Location = New System.Drawing.Point(561, 188)
        Me.SubjectTypeCB.Name = "SubjectTypeCB"
        Me.SubjectTypeCB.ShadowDecoration.Parent = Me.SubjectTypeCB
        Me.SubjectTypeCB.Size = New System.Drawing.Size(188, 36)
        Me.SubjectTypeCB.TabIndex = 79
        '
        'SubjectIDTB
        '
        Me.SubjectIDTB.Animated = True
        Me.SubjectIDTB.AutoRoundedCorners = True
        Me.SubjectIDTB.BorderColor = System.Drawing.Color.Silver
        Me.SubjectIDTB.BorderRadius = 17
        Me.SubjectIDTB.BorderThickness = 2
        Me.SubjectIDTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubjectIDTB.DefaultText = ""
        Me.SubjectIDTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SubjectIDTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SubjectIDTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubjectIDTB.DisabledState.Parent = Me.SubjectIDTB
        Me.SubjectIDTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubjectIDTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.SubjectIDTB.FocusedState.Parent = Me.SubjectIDTB
        Me.SubjectIDTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectIDTB.ForeColor = System.Drawing.Color.Black
        Me.SubjectIDTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.SubjectIDTB.HoverState.Parent = Me.SubjectIDTB
        Me.SubjectIDTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.SubjectIDTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.SubjectIDTB.Location = New System.Drawing.Point(561, 94)
        Me.SubjectIDTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SubjectIDTB.Name = "SubjectIDTB"
        Me.SubjectIDTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubjectIDTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.SubjectIDTB.PlaceholderText = "Subject ID"
        Me.SubjectIDTB.SelectedText = ""
        Me.SubjectIDTB.ShadowDecoration.Parent = Me.SubjectIDTB
        Me.SubjectIDTB.Size = New System.Drawing.Size(188, 36)
        Me.SubjectIDTB.TabIndex = 80
        '
        'SubjectNameTB
        '
        Me.SubjectNameTB.Animated = True
        Me.SubjectNameTB.AutoRoundedCorners = True
        Me.SubjectNameTB.BorderColor = System.Drawing.Color.Silver
        Me.SubjectNameTB.BorderRadius = 17
        Me.SubjectNameTB.BorderThickness = 2
        Me.SubjectNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubjectNameTB.DefaultText = ""
        Me.SubjectNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SubjectNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SubjectNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubjectNameTB.DisabledState.Parent = Me.SubjectNameTB
        Me.SubjectNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubjectNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.SubjectNameTB.FocusedState.Parent = Me.SubjectNameTB
        Me.SubjectNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectNameTB.ForeColor = System.Drawing.Color.Black
        Me.SubjectNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.SubjectNameTB.HoverState.Parent = Me.SubjectNameTB
        Me.SubjectNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.SubjectNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.SubjectNameTB.Location = New System.Drawing.Point(561, 140)
        Me.SubjectNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SubjectNameTB.Name = "SubjectNameTB"
        Me.SubjectNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubjectNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.SubjectNameTB.PlaceholderText = "Subject Name"
        Me.SubjectNameTB.SelectedText = ""
        Me.SubjectNameTB.ShadowDecoration.Parent = Me.SubjectNameTB
        Me.SubjectNameTB.Size = New System.Drawing.Size(188, 36)
        Me.SubjectNameTB.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(405, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 28)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Subject Name"
        '
        'TheoryMarksTB
        '
        Me.TheoryMarksTB.Animated = True
        Me.TheoryMarksTB.AutoRoundedCorners = True
        Me.TheoryMarksTB.BorderColor = System.Drawing.Color.Silver
        Me.TheoryMarksTB.BorderRadius = 17
        Me.TheoryMarksTB.BorderThickness = 2
        Me.TheoryMarksTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TheoryMarksTB.DefaultText = ""
        Me.TheoryMarksTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TheoryMarksTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TheoryMarksTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TheoryMarksTB.DisabledState.Parent = Me.TheoryMarksTB
        Me.TheoryMarksTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TheoryMarksTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.TheoryMarksTB.FocusedState.Parent = Me.TheoryMarksTB
        Me.TheoryMarksTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheoryMarksTB.ForeColor = System.Drawing.Color.Black
        Me.TheoryMarksTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.TheoryMarksTB.HoverState.Parent = Me.TheoryMarksTB
        Me.TheoryMarksTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.TheoryMarksTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.TheoryMarksTB.Location = New System.Drawing.Point(953, 137)
        Me.TheoryMarksTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TheoryMarksTB.Name = "TheoryMarksTB"
        Me.TheoryMarksTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TheoryMarksTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TheoryMarksTB.PlaceholderText = "Theory Marks"
        Me.TheoryMarksTB.SelectedText = ""
        Me.TheoryMarksTB.ShadowDecoration.Parent = Me.TheoryMarksTB
        Me.TheoryMarksTB.Size = New System.Drawing.Size(188, 36)
        Me.TheoryMarksTB.TabIndex = 85
        '
        'PracticalMarksTB
        '
        Me.PracticalMarksTB.Animated = True
        Me.PracticalMarksTB.AutoRoundedCorners = True
        Me.PracticalMarksTB.BorderColor = System.Drawing.Color.Silver
        Me.PracticalMarksTB.BorderRadius = 17
        Me.PracticalMarksTB.BorderThickness = 2
        Me.PracticalMarksTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PracticalMarksTB.DefaultText = ""
        Me.PracticalMarksTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PracticalMarksTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PracticalMarksTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PracticalMarksTB.DisabledState.Parent = Me.PracticalMarksTB
        Me.PracticalMarksTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PracticalMarksTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.PracticalMarksTB.FocusedState.Parent = Me.PracticalMarksTB
        Me.PracticalMarksTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PracticalMarksTB.ForeColor = System.Drawing.Color.Black
        Me.PracticalMarksTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.PracticalMarksTB.HoverState.Parent = Me.PracticalMarksTB
        Me.PracticalMarksTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.PracticalMarksTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.PracticalMarksTB.Location = New System.Drawing.Point(953, 188)
        Me.PracticalMarksTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PracticalMarksTB.Name = "PracticalMarksTB"
        Me.PracticalMarksTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PracticalMarksTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.PracticalMarksTB.PlaceholderText = "Practical Marks"
        Me.PracticalMarksTB.SelectedText = ""
        Me.PracticalMarksTB.ShadowDecoration.Parent = Me.PracticalMarksTB
        Me.PracticalMarksTB.Size = New System.Drawing.Size(188, 36)
        Me.PracticalMarksTB.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(770, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 28)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Theory Marks"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(770, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 28)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Practical Marks"
        '
        'UpdateButton
        '
        Me.UpdateButton.Animated = True
        Me.UpdateButton.AutoRoundedCorners = True
        Me.UpdateButton.BorderRadius = 21
        Me.UpdateButton.CheckedState.Parent = Me.UpdateButton
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.CustomImages.Parent = Me.UpdateButton
        Me.UpdateButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.UpdateButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.UpdateButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.UpdateButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.UpdateButton.HoverState.Parent = Me.UpdateButton
        Me.UpdateButton.Location = New System.Drawing.Point(775, 246)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.PressedColor = System.Drawing.Color.Teal
        Me.UpdateButton.PressedDepth = 50
        Me.UpdateButton.ShadowDecoration.Parent = Me.UpdateButton
        Me.UpdateButton.Size = New System.Drawing.Size(180, 45)
        Me.UpdateButton.TabIndex = 93
        Me.UpdateButton.Text = "Update"
        '
        'DeleteButton
        '
        Me.DeleteButton.Animated = True
        Me.DeleteButton.AutoRoundedCorners = True
        Me.DeleteButton.BorderRadius = 21
        Me.DeleteButton.CheckedState.Parent = Me.DeleteButton
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteButton.CustomImages.Parent = Me.DeleteButton
        Me.DeleteButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.DeleteButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.DeleteButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.DeleteButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.DeleteButton.HoverState.Parent = Me.DeleteButton
        Me.DeleteButton.Location = New System.Drawing.Point(972, 246)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.PressedColor = System.Drawing.Color.Teal
        Me.DeleteButton.PressedDepth = 50
        Me.DeleteButton.ShadowDecoration.Parent = Me.DeleteButton
        Me.DeleteButton.Size = New System.Drawing.Size(180, 45)
        Me.DeleteButton.TabIndex = 91
        Me.DeleteButton.Text = "Delete"
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
        Me.SaveButton.Location = New System.Drawing.Point(578, 246)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.PressedColor = System.Drawing.Color.Teal
        Me.SaveButton.PressedDepth = 50
        Me.SaveButton.ShadowDecoration.Parent = Me.SaveButton
        Me.SaveButton.Size = New System.Drawing.Size(180, 45)
        Me.SaveButton.TabIndex = 90
        Me.SaveButton.Text = "Save"
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
        Me.RefreshButton.Location = New System.Drawing.Point(246, 271)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.PressedColor = System.Drawing.Color.Teal
        Me.RefreshButton.PressedDepth = 50
        Me.RefreshButton.ShadowDecoration.Parent = Me.RefreshButton
        Me.RefreshButton.Size = New System.Drawing.Size(105, 30)
        Me.RefreshButton.TabIndex = 89
        Me.RefreshButton.Text = "Refresh"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 324)
        Me.DataGridView1.TabIndex = 94
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label9.Location = New System.Drawing.Point(32, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 43)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Subject List"
        '
        'ResetButton
        '
        Me.ResetButton.AutoRoundedCorners = True
        Me.ResetButton.BorderRadius = 21
        Me.ResetButton.CheckedState.Parent = Me.ResetButton
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.CustomImages.Parent = Me.ResetButton
        Me.ResetButton.FillColor = System.Drawing.Color.Silver
        Me.ResetButton.FillColor2 = System.Drawing.Color.Silver
        Me.ResetButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ResetButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ResetButton.HoverState.Parent = Me.ResetButton
        Me.ResetButton.Location = New System.Drawing.Point(874, 304)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.PressedColor = System.Drawing.Color.Teal
        Me.ResetButton.PressedDepth = 50
        Me.ResetButton.ShadowDecoration.Parent = Me.ResetButton
        Me.ResetButton.Size = New System.Drawing.Size(169, 45)
        Me.ResetButton.TabIndex = 96
        Me.ResetButton.Text = "Reset"
        '
        'Subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 640)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PracticalMarksTB)
        Me.Controls.Add(Me.TheoryMarksTB)
        Me.Controls.Add(Me.SubjectNameTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SubjectIDTB)
        Me.Controls.Add(Me.SubjectTypeCB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SelectSemYearCB)
        Me.Controls.Add(Me.SelectCourseCB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Subject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SelectCourseCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SelectSemYearCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SubjectTypeCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SubjectIDTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubjectNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TheoryMarksTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PracticalMarksTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents UpdateButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents RefreshButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents ResetButton As Guna.UI2.WinForms.Guna2GradientButton
End Class
