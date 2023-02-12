<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Courses))
        Me.RefreshButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SaveButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.CourseSemYearCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TotalSemYearTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CourseNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DeleteButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CourseIDTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UpdateButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RefreshButton
        '
        Me.RefreshButton.Animated = True
        Me.RefreshButton.AutoRoundedCorners = True
        Me.RefreshButton.BorderRadius = 21
        Me.RefreshButton.CheckedState.Parent = Me.RefreshButton
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.CustomImages.Parent = Me.RefreshButton
        Me.RefreshButton.FillColor = System.Drawing.Color.DarkTurquoise
        Me.RefreshButton.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.ForeColor = System.Drawing.Color.White
        Me.RefreshButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.RefreshButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.RefreshButton.HoverState.Parent = Me.RefreshButton
        Me.RefreshButton.Location = New System.Drawing.Point(193, 433)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.PressedColor = System.Drawing.Color.Teal
        Me.RefreshButton.PressedDepth = 50
        Me.RefreshButton.ShadowDecoration.Parent = Me.RefreshButton
        Me.RefreshButton.Size = New System.Drawing.Size(139, 45)
        Me.RefreshButton.TabIndex = 21
        Me.RefreshButton.Text = "Refresh"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Teal
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1127, 88)
        Me.Guna2GradientPanel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Courses"
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
        Me.SaveButton.Location = New System.Drawing.Point(572, 430)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.PressedColor = System.Drawing.Color.Teal
        Me.SaveButton.PressedDepth = 50
        Me.SaveButton.ShadowDecoration.Parent = Me.SaveButton
        Me.SaveButton.Size = New System.Drawing.Size(180, 45)
        Me.SaveButton.TabIndex = 68
        Me.SaveButton.Text = "Save"
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
        Me.CourseSemYearCB.Items.AddRange(New Object() {"Semester", "Year"})
        Me.CourseSemYearCB.ItemsAppearance.Parent = Me.CourseSemYearCB
        Me.CourseSemYearCB.Location = New System.Drawing.Point(884, 288)
        Me.CourseSemYearCB.Name = "CourseSemYearCB"
        Me.CourseSemYearCB.ShadowDecoration.Parent = Me.CourseSemYearCB
        Me.CourseSemYearCB.Size = New System.Drawing.Size(230, 36)
        Me.CourseSemYearCB.TabIndex = 67
        '
        'TotalSemYearTB
        '
        Me.TotalSemYearTB.Animated = True
        Me.TotalSemYearTB.AutoRoundedCorners = True
        Me.TotalSemYearTB.BorderColor = System.Drawing.Color.Silver
        Me.TotalSemYearTB.BorderRadius = 17
        Me.TotalSemYearTB.BorderThickness = 2
        Me.TotalSemYearTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalSemYearTB.DefaultText = ""
        Me.TotalSemYearTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TotalSemYearTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TotalSemYearTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalSemYearTB.DisabledState.Parent = Me.TotalSemYearTB
        Me.TotalSemYearTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalSemYearTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.TotalSemYearTB.FocusedState.Parent = Me.TotalSemYearTB
        Me.TotalSemYearTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSemYearTB.ForeColor = System.Drawing.Color.Black
        Me.TotalSemYearTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.TotalSemYearTB.HoverState.Parent = Me.TotalSemYearTB
        Me.TotalSemYearTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.TotalSemYearTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.TotalSemYearTB.Location = New System.Drawing.Point(884, 356)
        Me.TotalSemYearTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TotalSemYearTB.Name = "TotalSemYearTB"
        Me.TotalSemYearTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TotalSemYearTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TotalSemYearTB.PlaceholderText = "Total Sem/Year"
        Me.TotalSemYearTB.SelectedText = ""
        Me.TotalSemYearTB.ShadowDecoration.Parent = Me.TotalSemYearTB
        Me.TotalSemYearTB.Size = New System.Drawing.Size(230, 36)
        Me.TotalSemYearTB.TabIndex = 66
        '
        'CourseNameTB
        '
        Me.CourseNameTB.Animated = True
        Me.CourseNameTB.AutoRoundedCorners = True
        Me.CourseNameTB.BorderColor = System.Drawing.Color.Silver
        Me.CourseNameTB.BorderRadius = 17
        Me.CourseNameTB.BorderThickness = 2
        Me.CourseNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CourseNameTB.DefaultText = ""
        Me.CourseNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CourseNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CourseNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CourseNameTB.DisabledState.Parent = Me.CourseNameTB
        Me.CourseNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CourseNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.CourseNameTB.FocusedState.Parent = Me.CourseNameTB
        Me.CourseNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseNameTB.ForeColor = System.Drawing.Color.Black
        Me.CourseNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.CourseNameTB.HoverState.Parent = Me.CourseNameTB
        Me.CourseNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.CourseNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.CourseNameTB.Location = New System.Drawing.Point(884, 229)
        Me.CourseNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CourseNameTB.Name = "CourseNameTB"
        Me.CourseNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CourseNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.CourseNameTB.PlaceholderText = "Cource Name"
        Me.CourseNameTB.SelectedText = ""
        Me.CourseNameTB.ShadowDecoration.Parent = Me.CourseNameTB
        Me.CourseNameTB.Size = New System.Drawing.Size(230, 36)
        Me.CourseNameTB.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(601, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 43)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Total Sem/Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(601, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 43)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Course Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(601, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 43)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Sem/Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(735, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 43)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Add New Course"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 277)
        Me.DataGridView1.TabIndex = 71
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
        Me.DeleteButton.Location = New System.Drawing.Point(965, 430)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.PressedColor = System.Drawing.Color.Teal
        Me.DeleteButton.PressedDepth = 50
        Me.DeleteButton.ShadowDecoration.Parent = Me.DeleteButton
        Me.DeleteButton.Size = New System.Drawing.Size(162, 45)
        Me.DeleteButton.TabIndex = 72
        Me.DeleteButton.Text = "Delete"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(156, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 43)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Course List"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(601, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 43)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Course ID"
        '
        'CourseIDTB
        '
        Me.CourseIDTB.Animated = True
        Me.CourseIDTB.AutoRoundedCorners = True
        Me.CourseIDTB.BorderColor = System.Drawing.Color.Silver
        Me.CourseIDTB.BorderRadius = 17
        Me.CourseIDTB.BorderThickness = 2
        Me.CourseIDTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CourseIDTB.DefaultText = ""
        Me.CourseIDTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CourseIDTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CourseIDTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CourseIDTB.DisabledState.Parent = Me.CourseIDTB
        Me.CourseIDTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CourseIDTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.CourseIDTB.FocusedState.Parent = Me.CourseIDTB
        Me.CourseIDTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseIDTB.ForeColor = System.Drawing.Color.Black
        Me.CourseIDTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.CourseIDTB.HoverState.Parent = Me.CourseIDTB
        Me.CourseIDTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.CourseIDTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.CourseIDTB.Location = New System.Drawing.Point(884, 167)
        Me.CourseIDTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CourseIDTB.Name = "CourseIDTB"
        Me.CourseIDTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CourseIDTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.CourseIDTB.PlaceholderText = "Cource ID"
        Me.CourseIDTB.SelectedText = ""
        Me.CourseIDTB.ShadowDecoration.Parent = Me.CourseIDTB
        Me.CourseIDTB.Size = New System.Drawing.Size(230, 36)
        Me.CourseIDTB.TabIndex = 75
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
        Me.UpdateButton.Location = New System.Drawing.Point(769, 430)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.PressedColor = System.Drawing.Color.Teal
        Me.UpdateButton.PressedDepth = 50
        Me.UpdateButton.ShadowDecoration.Parent = Me.UpdateButton
        Me.UpdateButton.Size = New System.Drawing.Size(180, 45)
        Me.UpdateButton.TabIndex = 76
        Me.UpdateButton.Text = "Update"
        '
        'Courses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 569)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.CourseIDTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CourseSemYearCB)
        Me.Controls.Add(Me.TotalSemYearTB)
        Me.Controls.Add(Me.CourseNameTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.RefreshButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Courses"
        Me.Text = "Cources"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RefreshButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CourseSemYearCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TotalSemYearTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CourseNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CourseIDTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UpdateButton As Guna.UI2.WinForms.Guna2GradientButton
End Class
