<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeSubject))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SubCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.UpdateButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FacultyID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Change Subject"
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
        Me.Guna2GradientPanel1.TabIndex = 161
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
        Me.CloseButton.Location = New System.Drawing.Point(226, 337)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.PressedColor = System.Drawing.Color.Teal
        Me.CloseButton.PressedDepth = 50
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 160
        Me.CloseButton.Text = "Cancel"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Location = New System.Drawing.Point(12, 254)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(204, 33)
        Me.Label15.TabIndex = 159
        Me.Label15.Text = "Selected Subject"
        '
        'SubCB
        '
        Me.SubCB.AutoRoundedCorners = True
        Me.SubCB.BackColor = System.Drawing.Color.Transparent
        Me.SubCB.BorderColor = System.Drawing.Color.Silver
        Me.SubCB.BorderRadius = 17
        Me.SubCB.BorderThickness = 2
        Me.SubCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SubCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubCB.FocusedColor = System.Drawing.Color.Empty
        Me.SubCB.FocusedState.Parent = Me.SubCB
        Me.SubCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubCB.ForeColor = System.Drawing.Color.Black
        Me.SubCB.FormattingEnabled = True
        Me.SubCB.HoverState.Parent = Me.SubCB
        Me.SubCB.ItemHeight = 30
        Me.SubCB.ItemsAppearance.Parent = Me.SubCB
        Me.SubCB.Location = New System.Drawing.Point(226, 251)
        Me.SubCB.Name = "SubCB"
        Me.SubCB.ShadowDecoration.Parent = Me.SubCB
        Me.SubCB.Size = New System.Drawing.Size(184, 36)
        Me.SubCB.TabIndex = 158
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
        Me.UpdateButton.Location = New System.Drawing.Point(13, 337)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.PressedColor = System.Drawing.Color.Teal
        Me.UpdateButton.PressedDepth = 50
        Me.UpdateButton.ShadowDecoration.Parent = Me.UpdateButton
        Me.UpdateButton.Size = New System.Drawing.Size(180, 45)
        Me.UpdateButton.TabIndex = 157
        Me.UpdateButton.Text = "Update"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label18.Location = New System.Drawing.Point(12, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(129, 33)
        Me.Label18.TabIndex = 156
        Me.Label18.Text = "Faculty ID"
        '
        'FNameTB
        '
        Me.FNameTB.Animated = True
        Me.FNameTB.AutoRoundedCorners = True
        Me.FNameTB.BorderColor = System.Drawing.Color.Silver
        Me.FNameTB.BorderRadius = 17
        Me.FNameTB.BorderThickness = 2
        Me.FNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FNameTB.DefaultText = ""
        Me.FNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FNameTB.DisabledState.Parent = Me.FNameTB
        Me.FNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FNameTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FNameTB.FocusedState.Parent = Me.FNameTB
        Me.FNameTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTB.ForeColor = System.Drawing.Color.Black
        Me.FNameTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FNameTB.HoverState.Parent = Me.FNameTB
        Me.FNameTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FNameTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FNameTB.Location = New System.Drawing.Point(226, 187)
        Me.FNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FNameTB.Name = "FNameTB"
        Me.FNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FNameTB.PlaceholderText = "Faculty  Name"
        Me.FNameTB.SelectedText = ""
        Me.FNameTB.ShadowDecoration.Parent = Me.FNameTB
        Me.FNameTB.Size = New System.Drawing.Size(184, 36)
        Me.FNameTB.TabIndex = 155
        Me.FNameTB.TabStop = False
        '
        'FacultyID
        '
        Me.FacultyID.Animated = True
        Me.FacultyID.AutoRoundedCorners = True
        Me.FacultyID.BorderColor = System.Drawing.Color.Silver
        Me.FacultyID.BorderRadius = 17
        Me.FacultyID.BorderThickness = 2
        Me.FacultyID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FacultyID.DefaultText = ""
        Me.FacultyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FacultyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FacultyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FacultyID.DisabledState.Parent = Me.FacultyID
        Me.FacultyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FacultyID.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.FacultyID.FocusedState.Parent = Me.FacultyID
        Me.FacultyID.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacultyID.ForeColor = System.Drawing.Color.Black
        Me.FacultyID.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.FacultyID.HoverState.Parent = Me.FacultyID
        Me.FacultyID.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.FacultyID.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.FacultyID.Location = New System.Drawing.Point(222, 123)
        Me.FacultyID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FacultyID.Name = "FacultyID"
        Me.FacultyID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FacultyID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FacultyID.PlaceholderText = "Faculty ID"
        Me.FacultyID.SelectedText = ""
        Me.FacultyID.ShadowDecoration.Parent = Me.FacultyID
        Me.FacultyID.Size = New System.Drawing.Size(184, 36)
        Me.FacultyID.TabIndex = 154
        Me.FacultyID.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(12, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 33)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Faculty Name"
        '
        'ChangeSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 401)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.SubCB)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.FNameTB)
        Me.Controls.Add(Me.FacultyID)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Subject"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label15 As Label
    Friend WithEvents SubCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents UpdateButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label18 As Label
    Friend WithEvents FNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FacultyID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
