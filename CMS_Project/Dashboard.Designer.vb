<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.TopPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.DateLabel2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.VarLabel1 = New System.Windows.Forms.Label()
        Me.PanelLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.LogoutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AboutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddUsersButton = New Guna.UI2.WinForms.Guna2Button()
        Me.EmailButton = New Guna.UI2.WinForms.Guna2Button()
        Me.MarksButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AttendanceButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SubjectButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CourseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.TeacherButton = New Guna.UI2.WinForms.Guna2Button()
        Me.StudentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DashBoardButton = New Guna.UI2.WinForms.Guna2Button()
        Me.MainPanal = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.MainPanal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.SlateBlue
        Me.TopPanel.Controls.Add(Me.DateLabel2)
        Me.TopPanel.Controls.Add(Me.Label2)
        Me.TopPanel.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.TopPanel.Controls.Add(Me.VarLabel1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(199, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.ShadowDecoration.Parent = Me.TopPanel
        Me.TopPanel.Size = New System.Drawing.Size(1112, 58)
        Me.TopPanel.TabIndex = 2
        '
        'DateLabel2
        '
        Me.DateLabel2.AutoSize = True
        Me.DateLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel2.ForeColor = System.Drawing.Color.GhostWhite
        Me.DateLabel2.Location = New System.Drawing.Point(983, 32)
        Me.DateLabel2.Name = "DateLabel2"
        Me.DateLabel2.Size = New System.Drawing.Size(40, 20)
        Me.DateLabel2.TabIndex = 8
        Me.DateLabel2.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(982, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Admin"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(921, 10)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(55, 42)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 2
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'VarLabel1
        '
        Me.VarLabel1.AutoSize = True
        Me.VarLabel1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VarLabel1.ForeColor = System.Drawing.Color.White
        Me.VarLabel1.Location = New System.Drawing.Point(18, 15)
        Me.VarLabel1.Name = "VarLabel1"
        Me.VarLabel1.Size = New System.Drawing.Size(100, 40)
        Me.VarLabel1.TabIndex = 1
        Me.VarLabel1.Text = "Home"
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.logo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.ShadowDecoration.Parent = Me.PanelLogo
        Me.PanelLogo.Size = New System.Drawing.Size(199, 58)
        Me.PanelLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CMS"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(3, 5)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(73, 50)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.ExitButton)
        Me.PanelMenu.Controls.Add(Me.LogoutButton)
        Me.PanelMenu.Controls.Add(Me.AboutButton)
        Me.PanelMenu.Controls.Add(Me.AddUsersButton)
        Me.PanelMenu.Controls.Add(Me.EmailButton)
        Me.PanelMenu.Controls.Add(Me.MarksButton)
        Me.PanelMenu.Controls.Add(Me.AttendanceButton)
        Me.PanelMenu.Controls.Add(Me.SubjectButton)
        Me.PanelMenu.Controls.Add(Me.CourseButton)
        Me.PanelMenu.Controls.Add(Me.TeacherButton)
        Me.PanelMenu.Controls.Add(Me.StudentButton)
        Me.PanelMenu.Controls.Add(Me.DashBoardButton)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.ShadowDecoration.Parent = Me.PanelMenu
        Me.PanelMenu.Size = New System.Drawing.Size(199, 603)
        Me.PanelMenu.TabIndex = 1
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
        Me.ExitButton.Location = New System.Drawing.Point(0, 553)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShadowDecoration.Parent = Me.ExitButton
        Me.ExitButton.Size = New System.Drawing.Size(199, 45)
        Me.ExitButton.TabIndex = 24
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
        Me.LogoutButton.Location = New System.Drawing.Point(0, 508)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.ShadowDecoration.Parent = Me.LogoutButton
        Me.LogoutButton.Size = New System.Drawing.Size(199, 45)
        Me.LogoutButton.TabIndex = 23
        Me.LogoutButton.Text = "Logout"
        '
        'AboutButton
        '
        Me.AboutButton.Animated = True
        Me.AboutButton.CheckedState.Parent = Me.AboutButton
        Me.AboutButton.CustomImages.Parent = Me.AboutButton
        Me.AboutButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.AboutButton.FillColor = System.Drawing.Color.Transparent
        Me.AboutButton.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.ForeColor = System.Drawing.Color.White
        Me.AboutButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.AboutButton.HoverState.Parent = Me.AboutButton
        Me.AboutButton.Image = CType(resources.GetObject("AboutButton.Image"), System.Drawing.Image)
        Me.AboutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AboutButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.AboutButton.Location = New System.Drawing.Point(0, 463)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.ShadowDecoration.Parent = Me.AboutButton
        Me.AboutButton.Size = New System.Drawing.Size(199, 45)
        Me.AboutButton.TabIndex = 22
        Me.AboutButton.Text = "About Us"
        '
        'AddUsersButton
        '
        Me.AddUsersButton.Animated = True
        Me.AddUsersButton.CheckedState.Parent = Me.AddUsersButton
        Me.AddUsersButton.CustomImages.Parent = Me.AddUsersButton
        Me.AddUsersButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddUsersButton.FillColor = System.Drawing.Color.Transparent
        Me.AddUsersButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUsersButton.ForeColor = System.Drawing.Color.White
        Me.AddUsersButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.AddUsersButton.HoverState.Parent = Me.AddUsersButton
        Me.AddUsersButton.Image = CType(resources.GetObject("AddUsersButton.Image"), System.Drawing.Image)
        Me.AddUsersButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AddUsersButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.AddUsersButton.Location = New System.Drawing.Point(0, 418)
        Me.AddUsersButton.Name = "AddUsersButton"
        Me.AddUsersButton.ShadowDecoration.Parent = Me.AddUsersButton
        Me.AddUsersButton.Size = New System.Drawing.Size(199, 45)
        Me.AddUsersButton.TabIndex = 19
        Me.AddUsersButton.Text = "USERS"
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
        Me.EmailButton.Location = New System.Drawing.Point(0, 373)
        Me.EmailButton.Name = "EmailButton"
        Me.EmailButton.ShadowDecoration.Parent = Me.EmailButton
        Me.EmailButton.Size = New System.Drawing.Size(199, 45)
        Me.EmailButton.TabIndex = 18
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
        Me.MarksButton.Location = New System.Drawing.Point(0, 328)
        Me.MarksButton.Name = "MarksButton"
        Me.MarksButton.ShadowDecoration.Parent = Me.MarksButton
        Me.MarksButton.Size = New System.Drawing.Size(199, 45)
        Me.MarksButton.TabIndex = 17
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
        Me.AttendanceButton.Location = New System.Drawing.Point(0, 283)
        Me.AttendanceButton.Name = "AttendanceButton"
        Me.AttendanceButton.ShadowDecoration.Parent = Me.AttendanceButton
        Me.AttendanceButton.Size = New System.Drawing.Size(199, 45)
        Me.AttendanceButton.TabIndex = 16
        Me.AttendanceButton.Text = "ATTENDANCE"
        '
        'SubjectButton
        '
        Me.SubjectButton.Animated = True
        Me.SubjectButton.CheckedState.Parent = Me.SubjectButton
        Me.SubjectButton.CustomImages.Parent = Me.SubjectButton
        Me.SubjectButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubjectButton.FillColor = System.Drawing.Color.Transparent
        Me.SubjectButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectButton.ForeColor = System.Drawing.Color.White
        Me.SubjectButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.SubjectButton.HoverState.Parent = Me.SubjectButton
        Me.SubjectButton.Image = CType(resources.GetObject("SubjectButton.Image"), System.Drawing.Image)
        Me.SubjectButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SubjectButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.SubjectButton.Location = New System.Drawing.Point(0, 238)
        Me.SubjectButton.Name = "SubjectButton"
        Me.SubjectButton.ShadowDecoration.Parent = Me.SubjectButton
        Me.SubjectButton.Size = New System.Drawing.Size(199, 45)
        Me.SubjectButton.TabIndex = 15
        Me.SubjectButton.Text = "SUBJECTS"
        '
        'CourseButton
        '
        Me.CourseButton.Animated = True
        Me.CourseButton.CheckedState.Parent = Me.CourseButton
        Me.CourseButton.CustomImages.Parent = Me.CourseButton
        Me.CourseButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CourseButton.FillColor = System.Drawing.Color.Transparent
        Me.CourseButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseButton.ForeColor = System.Drawing.Color.White
        Me.CourseButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.CourseButton.HoverState.Parent = Me.CourseButton
        Me.CourseButton.Image = CType(resources.GetObject("CourseButton.Image"), System.Drawing.Image)
        Me.CourseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CourseButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.CourseButton.Location = New System.Drawing.Point(0, 193)
        Me.CourseButton.Name = "CourseButton"
        Me.CourseButton.ShadowDecoration.Parent = Me.CourseButton
        Me.CourseButton.Size = New System.Drawing.Size(199, 45)
        Me.CourseButton.TabIndex = 14
        Me.CourseButton.Text = "COURSES"
        '
        'TeacherButton
        '
        Me.TeacherButton.Animated = True
        Me.TeacherButton.CheckedState.Parent = Me.TeacherButton
        Me.TeacherButton.CustomImages.Parent = Me.TeacherButton
        Me.TeacherButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.TeacherButton.FillColor = System.Drawing.Color.Transparent
        Me.TeacherButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherButton.ForeColor = System.Drawing.Color.White
        Me.TeacherButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.TeacherButton.HoverState.Parent = Me.TeacherButton
        Me.TeacherButton.Image = CType(resources.GetObject("TeacherButton.Image"), System.Drawing.Image)
        Me.TeacherButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TeacherButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.TeacherButton.Location = New System.Drawing.Point(0, 148)
        Me.TeacherButton.Name = "TeacherButton"
        Me.TeacherButton.ShadowDecoration.Parent = Me.TeacherButton
        Me.TeacherButton.Size = New System.Drawing.Size(199, 45)
        Me.TeacherButton.TabIndex = 12
        Me.TeacherButton.Text = "FACULTY"
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
        Me.StudentButton.Location = New System.Drawing.Point(0, 103)
        Me.StudentButton.Name = "StudentButton"
        Me.StudentButton.ShadowDecoration.Parent = Me.StudentButton
        Me.StudentButton.Size = New System.Drawing.Size(199, 45)
        Me.StudentButton.TabIndex = 10
        Me.StudentButton.Text = "STUDENTS"
        '
        'DashBoardButton
        '
        Me.DashBoardButton.Animated = True
        Me.DashBoardButton.CheckedState.Parent = Me.DashBoardButton
        Me.DashBoardButton.CustomImages.Parent = Me.DashBoardButton
        Me.DashBoardButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashBoardButton.FillColor = System.Drawing.Color.Transparent
        Me.DashBoardButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashBoardButton.ForeColor = System.Drawing.Color.White
        Me.DashBoardButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.DashBoardButton.HoverState.Parent = Me.DashBoardButton
        Me.DashBoardButton.Image = CType(resources.GetObject("DashBoardButton.Image"), System.Drawing.Image)
        Me.DashBoardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.DashBoardButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.DashBoardButton.Location = New System.Drawing.Point(0, 58)
        Me.DashBoardButton.Name = "DashBoardButton"
        Me.DashBoardButton.ShadowDecoration.Parent = Me.DashBoardButton
        Me.DashBoardButton.Size = New System.Drawing.Size(199, 45)
        Me.DashBoardButton.TabIndex = 1
        Me.DashBoardButton.Text = "DASHBOARD"
        '
        'MainPanal
        '
        Me.MainPanal.AutoScroll = True
        Me.MainPanal.BackColor = System.Drawing.Color.White
        Me.MainPanal.Controls.Add(Me.PictureBox1)
        Me.MainPanal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanal.Location = New System.Drawing.Point(199, 58)
        Me.MainPanal.Name = "MainPanal"
        Me.MainPanal.Size = New System.Drawing.Size(1112, 545)
        Me.MainPanal.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1112, 545)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 603)
        Me.Controls.Add(Me.MainPanal)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.PanelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.MainPanal.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PanelLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents PanelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DashBoardButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CourseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TeacherButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StudentButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MainPanal As Panel
    Friend WithEvents VarLabel1 As Label
    Friend WithEvents MarksButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AttendanceButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents DateLabel2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogoutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AboutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddUsersButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EmailButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SubjectButton As Guna.UI2.WinForms.Guna2Button
End Class
