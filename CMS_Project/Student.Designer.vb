<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.AddStudentButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.AutoRoundedCorners = True
        Me.Guna2GradientButton2.BorderRadius = 17
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.SlateBlue
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.SlateBlue
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.Guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(752, 79)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.PressedColor = System.Drawing.Color.Turquoise
        Me.Guna2GradientButton2.PressedDepth = 100
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(157, 37)
        Me.Guna2GradientButton2.TabIndex = 8
        Me.Guna2GradientButton2.Text = "EDIT"
        '
        'AddStudentButton
        '
        Me.AddStudentButton.AutoRoundedCorners = True
        Me.AddStudentButton.BorderRadius = 17
        Me.AddStudentButton.CheckedState.Parent = Me.AddStudentButton
        Me.AddStudentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddStudentButton.CustomImages.Parent = Me.AddStudentButton
        Me.AddStudentButton.FillColor = System.Drawing.Color.SlateBlue
        Me.AddStudentButton.FillColor2 = System.Drawing.Color.SlateBlue
        Me.AddStudentButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentButton.ForeColor = System.Drawing.Color.White
        Me.AddStudentButton.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.AddStudentButton.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.AddStudentButton.HoverState.Parent = Me.AddStudentButton
        Me.AddStudentButton.Location = New System.Drawing.Point(579, 79)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.PressedColor = System.Drawing.Color.Turquoise
        Me.AddStudentButton.PressedDepth = 100
        Me.AddStudentButton.ShadowDecoration.Parent = Me.AddStudentButton
        Me.AddStudentButton.Size = New System.Drawing.Size(157, 37)
        Me.AddStudentButton.TabIndex = 7
        Me.AddStudentButton.Text = "ADD"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Guna2GradientButton2)
        Me.Panel5.Controls.Add(Me.AddStudentButton)
        Me.Panel5.Controls.Add(Me.LoginButton1)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1100, 131)
        Me.Panel5.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'LoginButton1
        '
        Me.LoginButton1.AutoRoundedCorners = True
        Me.LoginButton1.BorderRadius = 17
        Me.LoginButton1.CheckedState.Parent = Me.LoginButton1
        Me.LoginButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton1.CustomImages.Parent = Me.LoginButton1
        Me.LoginButton1.FillColor = System.Drawing.Color.SlateBlue
        Me.LoginButton1.FillColor2 = System.Drawing.Color.SlateBlue
        Me.LoginButton1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton1.ForeColor = System.Drawing.Color.White
        Me.LoginButton1.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.LoginButton1.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.LoginButton1.HoverState.Parent = Me.LoginButton1
        Me.LoginButton1.Location = New System.Drawing.Point(929, 79)
        Me.LoginButton1.Name = "LoginButton1"
        Me.LoginButton1.PressedColor = System.Drawing.Color.Turquoise
        Me.LoginButton1.PressedDepth = 100
        Me.LoginButton1.ShadowDecoration.Parent = Me.LoginButton1
        Me.LoginButton1.Size = New System.Drawing.Size(157, 37)
        Me.LoginButton1.TabIndex = 6
        Me.LoginButton1.Text = "DELETE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label8.Location = New System.Drawing.Point(88, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 37)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Students"
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.Teal
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(32, 210)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1068, 412)
        Me.Guna2DataGridView1.TabIndex = 7
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Teal
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(492, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Students List"
        '
        'LoginButton2
        '
        Me.LoginButton2.Animated = True
        Me.LoginButton2.AutoRoundedCorners = True
        Me.LoginButton2.BorderRadius = 12
        Me.LoginButton2.CheckedState.Parent = Me.LoginButton2
        Me.LoginButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton2.CustomImages.Parent = Me.LoginButton2
        Me.LoginButton2.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.LoginButton2.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.LoginButton2.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton2.ForeColor = System.Drawing.Color.White
        Me.LoginButton2.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.LoginButton2.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.LoginButton2.HoverState.Parent = Me.LoginButton2
        Me.LoginButton2.Location = New System.Drawing.Point(519, 177)
        Me.LoginButton2.Name = "LoginButton2"
        Me.LoginButton2.PressedColor = System.Drawing.Color.Teal
        Me.LoginButton2.PressedDepth = 50
        Me.LoginButton2.ShadowDecoration.Parent = Me.LoginButton2
        Me.LoginButton2.Size = New System.Drawing.Size(114, 27)
        Me.LoginButton2.TabIndex = 13
        Me.LoginButton2.Text = "Refresh"
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 654)
        Me.Controls.Add(Me.LoginButton2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student"
        Me.Text = "Student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents AddStudentButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LoginButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton2 As Guna.UI2.WinForms.Guna2GradientButton
End Class
