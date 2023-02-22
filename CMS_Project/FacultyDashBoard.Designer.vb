<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacultyDashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacultyDashBoard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.LogoutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.EmailButton = New Guna.UI2.WinForms.Guna2Button()
        Me.MarksButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AttendanceButton = New Guna.UI2.WinForms.Guna2Button()
        Me.StudentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateLabel2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.VarLabel1 = New System.Windows.Forms.Label()
        Me.MainPanal = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ExitButton)
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Controls.Add(Me.EmailButton)
        Me.Panel1.Controls.Add(Me.MarksButton)
        Me.Panel1.Controls.Add(Me.AttendanceButton)
        Me.Panel1.Controls.Add(Me.StudentButton)
        Me.Panel1.Controls.Add(Me.PanelLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 603)
        Me.Panel1.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.Animated = True
        Me.ExitButton.CheckedState.Parent = Me.ExitButton
        Me.ExitButton.CustomImages.Parent = Me.ExitButton
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExitButton.FillColor = System.Drawing.Color.Transparent
        Me.ExitButton.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.ExitButton.HoverState.Parent = Me.ExitButton
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ExitButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.ExitButton.Location = New System.Drawing.Point(0, 277)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShadowDecoration.Parent = Me.ExitButton
        Me.ExitButton.Size = New System.Drawing.Size(194, 45)
        Me.ExitButton.TabIndex = 34
        Me.ExitButton.Text = "Exit"
        '
        'LogoutButton
        '
        Me.LogoutButton.Animated = True
        Me.LogoutButton.CheckedState.Parent = Me.LogoutButton
        Me.LogoutButton.CustomImages.Parent = Me.LogoutButton
        Me.LogoutButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoutButton.FillColor = System.Drawing.Color.Transparent
        Me.LogoutButton.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.ForeColor = System.Drawing.Color.White
        Me.LogoutButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.LogoutButton.HoverState.Parent = Me.LogoutButton
        Me.LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), System.Drawing.Image)
        Me.LogoutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogoutButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.LogoutButton.Location = New System.Drawing.Point(0, 232)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.ShadowDecoration.Parent = Me.LogoutButton
        Me.LogoutButton.Size = New System.Drawing.Size(194, 45)
        Me.LogoutButton.TabIndex = 33
        Me.LogoutButton.Text = "Logout"
        '
        'EmailButton
        '
        Me.EmailButton.Animated = True
        Me.EmailButton.CheckedState.Parent = Me.EmailButton
        Me.EmailButton.CustomImages.Parent = Me.EmailButton
        Me.EmailButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmailButton.FillColor = System.Drawing.Color.Transparent
        Me.EmailButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailButton.ForeColor = System.Drawing.Color.White
        Me.EmailButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.EmailButton.HoverState.Parent = Me.EmailButton
        Me.EmailButton.Image = CType(resources.GetObject("EmailButton.Image"), System.Drawing.Image)
        Me.EmailButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.EmailButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.EmailButton.Location = New System.Drawing.Point(0, 187)
        Me.EmailButton.Name = "EmailButton"
        Me.EmailButton.ShadowDecoration.Parent = Me.EmailButton
        Me.EmailButton.Size = New System.Drawing.Size(194, 45)
        Me.EmailButton.TabIndex = 32
        Me.EmailButton.Text = "EMAIL"
        '
        'MarksButton
        '
        Me.MarksButton.Animated = True
        Me.MarksButton.CheckedState.Parent = Me.MarksButton
        Me.MarksButton.CustomImages.Parent = Me.MarksButton
        Me.MarksButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MarksButton.FillColor = System.Drawing.Color.Transparent
        Me.MarksButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarksButton.ForeColor = System.Drawing.Color.White
        Me.MarksButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.MarksButton.HoverState.Parent = Me.MarksButton
        Me.MarksButton.Image = CType(resources.GetObject("MarksButton.Image"), System.Drawing.Image)
        Me.MarksButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MarksButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.MarksButton.Location = New System.Drawing.Point(0, 142)
        Me.MarksButton.Name = "MarksButton"
        Me.MarksButton.ShadowDecoration.Parent = Me.MarksButton
        Me.MarksButton.Size = New System.Drawing.Size(194, 45)
        Me.MarksButton.TabIndex = 31
        Me.MarksButton.Text = "MARKS"
        '
        'AttendanceButton
        '
        Me.AttendanceButton.Animated = True
        Me.AttendanceButton.CheckedState.Parent = Me.AttendanceButton
        Me.AttendanceButton.CustomImages.Parent = Me.AttendanceButton
        Me.AttendanceButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.AttendanceButton.FillColor = System.Drawing.Color.Transparent
        Me.AttendanceButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceButton.ForeColor = System.Drawing.Color.White
        Me.AttendanceButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.AttendanceButton.HoverState.Parent = Me.AttendanceButton
        Me.AttendanceButton.Image = CType(resources.GetObject("AttendanceButton.Image"), System.Drawing.Image)
        Me.AttendanceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AttendanceButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.AttendanceButton.Location = New System.Drawing.Point(0, 97)
        Me.AttendanceButton.Name = "AttendanceButton"
        Me.AttendanceButton.ShadowDecoration.Parent = Me.AttendanceButton
        Me.AttendanceButton.Size = New System.Drawing.Size(194, 45)
        Me.AttendanceButton.TabIndex = 30
        Me.AttendanceButton.Text = "ATTENDANCE"
        '
        'StudentButton
        '
        Me.StudentButton.Animated = True
        Me.StudentButton.CheckedState.Parent = Me.StudentButton
        Me.StudentButton.CustomImages.Parent = Me.StudentButton
        Me.StudentButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.StudentButton.FillColor = System.Drawing.Color.Transparent
        Me.StudentButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentButton.ForeColor = System.Drawing.Color.White
        Me.StudentButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.StudentButton.HoverState.Parent = Me.StudentButton
        Me.StudentButton.Image = CType(resources.GetObject("StudentButton.Image"), System.Drawing.Image)
        Me.StudentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.StudentButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.StudentButton.Location = New System.Drawing.Point(0, 52)
        Me.StudentButton.Name = "StudentButton"
        Me.StudentButton.ShadowDecoration.Parent = Me.StudentButton
        Me.StudentButton.Size = New System.Drawing.Size(194, 45)
        Me.StudentButton.TabIndex = 26
        Me.StudentButton.Text = "STUDENTS"
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.logo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.ShadowDecoration.Parent = Me.PanelLogo
        Me.PanelLogo.Size = New System.Drawing.Size(194, 52)
        Me.PanelLogo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CMS"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(3, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(62, 46)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel2.Controls.Add(Me.DateLabel2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel2.Controls.Add(Me.VarLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(194, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1117, 52)
        Me.Panel2.TabIndex = 2
        '
        'DateLabel2
        '
        Me.DateLabel2.AutoSize = True
        Me.DateLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel2.ForeColor = System.Drawing.Color.GhostWhite
        Me.DateLabel2.Location = New System.Drawing.Point(886, 25)
        Me.DateLabel2.Name = "DateLabel2"
        Me.DateLabel2.Size = New System.Drawing.Size(40, 20)
        Me.DateLabel2.TabIndex = 11
        Me.DateLabel2.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(885, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Faculty"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(824, 3)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(55, 42)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 9
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'VarLabel1
        '
        Me.VarLabel1.AutoSize = True
        Me.VarLabel1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VarLabel1.ForeColor = System.Drawing.Color.White
        Me.VarLabel1.Location = New System.Drawing.Point(23, 8)
        Me.VarLabel1.Name = "VarLabel1"
        Me.VarLabel1.Size = New System.Drawing.Size(100, 40)
        Me.VarLabel1.TabIndex = 2
        Me.VarLabel1.Text = "Home"
        '
        'MainPanal
        '
        Me.MainPanal.AutoScroll = True
        Me.MainPanal.BackColor = System.Drawing.Color.White
        Me.MainPanal.Controls.Add(Me.PictureBox1)
        Me.MainPanal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanal.Location = New System.Drawing.Point(194, 52)
        Me.MainPanal.Name = "MainPanal"
        Me.MainPanal.Size = New System.Drawing.Size(1117, 551)
        Me.MainPanal.TabIndex = 4
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1117, 551)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FacultyDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 603)
        Me.Controls.Add(Me.MainPanal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FacultyDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty DashBoard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanal.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainPanal As Panel
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogoutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EmailButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MarksButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AttendanceButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StudentButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VarLabel1 As Label
    Friend WithEvents DateLabel2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
