<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeCourse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeCourse))
        Me.UpdateButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.StuNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CourseCB1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.UpdateButton.Location = New System.Drawing.Point(13, 319)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.PressedColor = System.Drawing.Color.Teal
        Me.UpdateButton.PressedDepth = 50
        Me.UpdateButton.ShadowDecoration.Parent = Me.UpdateButton
        Me.UpdateButton.Size = New System.Drawing.Size(180, 45)
        Me.UpdateButton.TabIndex = 147
        Me.UpdateButton.Text = "Update"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label18.Location = New System.Drawing.Point(12, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 33)
        Me.Label18.TabIndex = 146
        Me.Label18.Text = "Student ID"
        '
        'StuNameTB
        '
        Me.StuNameTB.Animated = True
        Me.StuNameTB.AutoRoundedCorners = True
        Me.StuNameTB.BorderColor = System.Drawing.Color.Silver
        Me.StuNameTB.BorderRadius = 17
        Me.StuNameTB.BorderThickness = 2
        Me.StuNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuNameTB.DefaultText = ""
        Me.StuNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuNameTB.DisabledState.Parent = Me.StuNameTB
        Me.StuNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuNameTB.FocusedState.Parent = Me.StuNameTB
        Me.StuNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuNameTB.ForeColor = System.Drawing.Color.Black
        Me.StuNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuNameTB.HoverState.Parent = Me.StuNameTB
        Me.StuNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuNameTB.Location = New System.Drawing.Point(226, 169)
        Me.StuNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuNameTB.Name = "StuNameTB"
        Me.StuNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuNameTB.PlaceholderText = "Student Name"
        Me.StuNameTB.SelectedText = ""
        Me.StuNameTB.ShadowDecoration.Parent = Me.StuNameTB
        Me.StuNameTB.Size = New System.Drawing.Size(184, 36)
        Me.StuNameTB.TabIndex = 145
        Me.StuNameTB.TabStop = False
        '
        'StudentID
        '
        Me.StudentID.Animated = True
        Me.StudentID.AutoRoundedCorners = True
        Me.StudentID.BorderColor = System.Drawing.Color.Silver
        Me.StudentID.BorderRadius = 17
        Me.StudentID.BorderThickness = 2
        Me.StudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentID.DefaultText = ""
        Me.StudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentID.DisabledState.Parent = Me.StudentID
        Me.StudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentID.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StudentID.FocusedState.Parent = Me.StudentID
        Me.StudentID.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentID.ForeColor = System.Drawing.Color.Black
        Me.StudentID.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StudentID.HoverState.Parent = Me.StudentID
        Me.StudentID.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StudentID.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StudentID.Location = New System.Drawing.Point(222, 105)
        Me.StudentID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StudentID.PlaceholderText = "Student ID"
        Me.StudentID.SelectedText = ""
        Me.StudentID.ShadowDecoration.Parent = Me.StudentID
        Me.StudentID.Size = New System.Drawing.Size(184, 36)
        Me.StudentID.TabIndex = 144
        Me.StudentID.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(12, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 33)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Student Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Location = New System.Drawing.Point(12, 236)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(212, 33)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Selected Courses"
        '
        'CourseCB1
        '
        Me.CourseCB1.AutoRoundedCorners = True
        Me.CourseCB1.BackColor = System.Drawing.Color.Transparent
        Me.CourseCB1.BorderColor = System.Drawing.Color.Silver
        Me.CourseCB1.BorderRadius = 17
        Me.CourseCB1.BorderThickness = 2
        Me.CourseCB1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CourseCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseCB1.FocusedColor = System.Drawing.Color.Empty
        Me.CourseCB1.FocusedState.Parent = Me.CourseCB1
        Me.CourseCB1.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseCB1.ForeColor = System.Drawing.Color.Black
        Me.CourseCB1.FormattingEnabled = True
        Me.CourseCB1.HoverState.Parent = Me.CourseCB1
        Me.CourseCB1.ItemHeight = 30
        Me.CourseCB1.ItemsAppearance.Parent = Me.CourseCB1
        Me.CourseCB1.Location = New System.Drawing.Point(226, 233)
        Me.CourseCB1.Name = "CourseCB1"
        Me.CourseCB1.ShadowDecoration.Parent = Me.CourseCB1
        Me.CourseCB1.Size = New System.Drawing.Size(184, 36)
        Me.CourseCB1.TabIndex = 149
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
        Me.CloseButton.Location = New System.Drawing.Point(226, 319)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.PressedColor = System.Drawing.Color.Teal
        Me.CloseButton.PressedDepth = 50
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 151
        Me.CloseButton.Text = "Cancel"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(422, 78)
        Me.Guna2GradientPanel1.TabIndex = 152
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Change Course"
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
        'ChangeCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 401)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CourseCB1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.StuNameTB)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangeCourse"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label18 As Label
    Friend WithEvents StuNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CourseCB1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
