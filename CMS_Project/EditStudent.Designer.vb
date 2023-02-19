<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditStudent))
        Me.timelable = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.StuAgeTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DeleteButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.UpdateButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.StuAdmissionTB = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ClearButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.UploadButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StuEmaliTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StuPINTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuStateTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuCityTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StuAddressTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuGenderCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StuPhoneTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuDateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StuMotherTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuFatherTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StuLastNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StuFirstNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.StatusComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CourseTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ChangeCourseButton = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timelable
        '
        Me.timelable.AutoSize = True
        Me.timelable.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timelable.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.timelable.Location = New System.Drawing.Point(994, 519)
        Me.timelable.Name = "timelable"
        Me.timelable.Size = New System.Drawing.Size(35, 18)
        Me.timelable.TabIndex = 133
        Me.timelable.Text = "date"
        Me.timelable.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(21, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 33)
        Me.Label17.TabIndex = 132
        Me.Label17.Text = "Age"
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
        Me.StuAgeTB.Location = New System.Drawing.Point(22, 146)
        Me.StuAgeTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuAgeTB.Name = "StuAgeTB"
        Me.StuAgeTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuAgeTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuAgeTB.PlaceholderText = "Age"
        Me.StuAgeTB.SelectedText = ""
        Me.StuAgeTB.ShadowDecoration.Parent = Me.StuAgeTB
        Me.StuAgeTB.Size = New System.Drawing.Size(129, 36)
        Me.StuAgeTB.TabIndex = 131
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
        Me.CloseButton.Location = New System.Drawing.Point(734, 459)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.PressedColor = System.Drawing.Color.Teal
        Me.CloseButton.PressedDepth = 50
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(180, 45)
        Me.CloseButton.TabIndex = 130
        Me.CloseButton.Text = "Cancel"
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
        Me.DeleteButton.Location = New System.Drawing.Point(283, 459)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.PressedColor = System.Drawing.Color.Teal
        Me.DeleteButton.PressedDepth = 50
        Me.DeleteButton.ShadowDecoration.Parent = Me.DeleteButton
        Me.DeleteButton.Size = New System.Drawing.Size(180, 45)
        Me.DeleteButton.TabIndex = 129
        Me.DeleteButton.Text = "Delete"
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
        Me.UpdateButton.Location = New System.Drawing.Point(43, 459)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.PressedColor = System.Drawing.Color.Teal
        Me.UpdateButton.PressedDepth = 50
        Me.UpdateButton.ShadowDecoration.Parent = Me.UpdateButton
        Me.UpdateButton.Size = New System.Drawing.Size(180, 45)
        Me.UpdateButton.TabIndex = 128
        Me.UpdateButton.Text = "Update"
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
        Me.StuAdmissionTB.Location = New System.Drawing.Point(452, 361)
        Me.StuAdmissionTB.MaxDate = New Date(2023, 2, 3, 0, 0, 0, 0)
        Me.StuAdmissionTB.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StuAdmissionTB.Name = "StuAdmissionTB"
        Me.StuAdmissionTB.ShadowDecoration.Parent = Me.StuAdmissionTB
        Me.StuAdmissionTB.Size = New System.Drawing.Size(192, 36)
        Me.StuAdmissionTB.TabIndex = 127
        Me.StuAdmissionTB.Value = New Date(2023, 2, 3, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label16.Location = New System.Drawing.Point(446, 325)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(198, 33)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Admission Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(233, 325)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 33)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Course"
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
        Me.ClearButton.Location = New System.Drawing.Point(916, 229)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.PressedColor = System.Drawing.Color.Turquoise
        Me.ClearButton.PressedDepth = 100
        Me.ClearButton.ShadowDecoration.Parent = Me.ClearButton
        Me.ClearButton.Size = New System.Drawing.Size(104, 37)
        Me.ClearButton.TabIndex = 123
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.Visible = False
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
        Me.UploadButton.Location = New System.Drawing.Point(795, 229)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.PressedColor = System.Drawing.Color.Turquoise
        Me.UploadButton.PressedDepth = 100
        Me.UploadButton.ShadowDecoration.Parent = Me.UploadButton
        Me.UploadButton.Size = New System.Drawing.Size(104, 36)
        Me.UploadButton.TabIndex = 122
        Me.UploadButton.Text = "Upload"
        Me.UploadButton.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(868, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 33)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Photo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(817, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(16, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 33)
        Me.Label12.TabIndex = 119
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
        Me.StuEmaliTB.Location = New System.Drawing.Point(22, 230)
        Me.StuEmaliTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuEmaliTB.Name = "StuEmaliTB"
        Me.StuEmaliTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuEmaliTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuEmaliTB.PlaceholderText = "Email"
        Me.StuEmaliTB.SelectedText = ""
        Me.StuEmaliTB.ShadowDecoration.Parent = Me.StuEmaliTB
        Me.StuEmaliTB.Size = New System.Drawing.Size(185, 36)
        Me.StuEmaliTB.TabIndex = 118
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(16, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 33)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "PIN Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(213, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 33)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Address"
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
        Me.StuPINTB.Location = New System.Drawing.Point(22, 361)
        Me.StuPINTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuPINTB.Name = "StuPINTB"
        Me.StuPINTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuPINTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuPINTB.PlaceholderText = "PIN Code"
        Me.StuPINTB.SelectedText = ""
        Me.StuPINTB.ShadowDecoration.Parent = Me.StuPINTB
        Me.StuPINTB.Size = New System.Drawing.Size(185, 36)
        Me.StuPINTB.TabIndex = 115
        '
        'StuStateTB
        '
        Me.StuStateTB.Animated = True
        Me.StuStateTB.AutoRoundedCorners = True
        Me.StuStateTB.BorderColor = System.Drawing.Color.Silver
        Me.StuStateTB.BorderRadius = 16
        Me.StuStateTB.BorderThickness = 2
        Me.StuStateTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StuStateTB.DefaultText = ""
        Me.StuStateTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StuStateTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StuStateTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuStateTB.DisabledState.Parent = Me.StuStateTB
        Me.StuStateTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StuStateTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.StuStateTB.FocusedState.Parent = Me.StuStateTB
        Me.StuStateTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuStateTB.ForeColor = System.Drawing.Color.Black
        Me.StuStateTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.StuStateTB.HoverState.Parent = Me.StuStateTB
        Me.StuStateTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.StuStateTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.StuStateTB.Location = New System.Drawing.Point(640, 231)
        Me.StuStateTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuStateTB.Name = "StuStateTB"
        Me.StuStateTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuStateTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuStateTB.PlaceholderText = "State"
        Me.StuStateTB.SelectedText = ""
        Me.StuStateTB.ShadowDecoration.Parent = Me.StuStateTB
        Me.StuStateTB.Size = New System.Drawing.Size(144, 35)
        Me.StuStateTB.TabIndex = 114
        '
        'StuCityTB
        '
        Me.StuCityTB.Animated = True
        Me.StuCityTB.AutoRoundedCorners = True
        Me.StuCityTB.BorderColor = System.Drawing.Color.Silver
        Me.StuCityTB.BorderRadius = 16
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
        Me.StuCityTB.Location = New System.Drawing.Point(473, 231)
        Me.StuCityTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuCityTB.Name = "StuCityTB"
        Me.StuCityTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuCityTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuCityTB.PlaceholderText = "City"
        Me.StuCityTB.SelectedText = ""
        Me.StuCityTB.ShadowDecoration.Parent = Me.StuCityTB
        Me.StuCityTB.Size = New System.Drawing.Size(159, 35)
        Me.StuCityTB.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(634, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 33)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(467, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 33)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "City"
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
        Me.StuAddressTB.Location = New System.Drawing.Point(219, 229)
        Me.StuAddressTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuAddressTB.Multiline = True
        Me.StuAddressTB.Name = "StuAddressTB"
        Me.StuAddressTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuAddressTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuAddressTB.PlaceholderText = "Address"
        Me.StuAddressTB.SelectedText = ""
        Me.StuAddressTB.ShadowDecoration.Parent = Me.StuAddressTB
        Me.StuAddressTB.Size = New System.Drawing.Size(246, 79)
        Me.StuAddressTB.TabIndex = 110
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
        Me.StuGenderCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuGenderCB.ForeColor = System.Drawing.Color.Black
        Me.StuGenderCB.FormattingEnabled = True
        Me.StuGenderCB.HoverState.Parent = Me.StuGenderCB
        Me.StuGenderCB.ItemHeight = 30
        Me.StuGenderCB.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.StuGenderCB.ItemsAppearance.Parent = Me.StuGenderCB
        Me.StuGenderCB.Location = New System.Drawing.Point(493, 56)
        Me.StuGenderCB.Name = "StuGenderCB"
        Me.StuGenderCB.ShadowDecoration.Parent = Me.StuGenderCB
        Me.StuGenderCB.Size = New System.Drawing.Size(116, 36)
        Me.StuGenderCB.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(487, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 33)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Gender"
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
        Me.StuPhoneTB.Location = New System.Drawing.Point(545, 146)
        Me.StuPhoneTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuPhoneTB.Name = "StuPhoneTB"
        Me.StuPhoneTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuPhoneTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuPhoneTB.PlaceholderText = "Phone Number"
        Me.StuPhoneTB.SelectedText = ""
        Me.StuPhoneTB.ShadowDecoration.Parent = Me.StuPhoneTB
        Me.StuPhoneTB.Size = New System.Drawing.Size(174, 36)
        Me.StuPhoneTB.TabIndex = 107
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
        Me.StuDateTimePicker.Location = New System.Drawing.Point(615, 56)
        Me.StuDateTimePicker.MaxDate = New Date(2023, 2, 3, 0, 0, 0, 0)
        Me.StuDateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StuDateTimePicker.Name = "StuDateTimePicker"
        Me.StuDateTimePicker.ShadowDecoration.Parent = Me.StuDateTimePicker
        Me.StuDateTimePicker.Size = New System.Drawing.Size(194, 36)
        Me.StuDateTimePicker.TabIndex = 106
        Me.StuDateTimePicker.Value = New Date(2023, 2, 3, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(539, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 33)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Phone"
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
        Me.StuMotherTB.Location = New System.Drawing.Point(352, 146)
        Me.StuMotherTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuMotherTB.Name = "StuMotherTB"
        Me.StuMotherTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuMotherTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuMotherTB.PlaceholderText = "Mother Name"
        Me.StuMotherTB.SelectedText = ""
        Me.StuMotherTB.ShadowDecoration.Parent = Me.StuMotherTB
        Me.StuMotherTB.Size = New System.Drawing.Size(185, 36)
        Me.StuMotherTB.TabIndex = 103
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
        Me.StuFatherTB.Location = New System.Drawing.Point(159, 146)
        Me.StuFatherTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuFatherTB.Name = "StuFatherTB"
        Me.StuFatherTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuFatherTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuFatherTB.PlaceholderText = "Father Name"
        Me.StuFatherTB.SelectedText = ""
        Me.StuFatherTB.ShadowDecoration.Parent = Me.StuFatherTB
        Me.StuFatherTB.Size = New System.Drawing.Size(185, 36)
        Me.StuFatherTB.TabIndex = 102
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
        Me.StuLastNameTB.Location = New System.Drawing.Point(327, 56)
        Me.StuLastNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuLastNameTB.Name = "StuLastNameTB"
        Me.StuLastNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuLastNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuLastNameTB.PlaceholderText = "Last Name"
        Me.StuLastNameTB.SelectedText = ""
        Me.StuLastNameTB.ShadowDecoration.Parent = Me.StuLastNameTB
        Me.StuLastNameTB.Size = New System.Drawing.Size(159, 36)
        Me.StuLastNameTB.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(346, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 33)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Mother Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(153, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 33)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Father Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(321, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 33)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Last Name"
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
        Me.StuFirstNameTB.Location = New System.Drawing.Point(162, 56)
        Me.StuFirstNameTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StuFirstNameTB.Name = "StuFirstNameTB"
        Me.StuFirstNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StuFirstNameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StuFirstNameTB.PlaceholderText = "First Name"
        Me.StuFirstNameTB.SelectedText = ""
        Me.StuFirstNameTB.ShadowDecoration.Parent = Me.StuFirstNameTB
        Me.StuFirstNameTB.Size = New System.Drawing.Size(157, 36)
        Me.StuFirstNameTB.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(159, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 33)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "First Name"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(609, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 33)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Date of Birth"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Location = New System.Drawing.Point(664, 325)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 33)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "Status"
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
        Me.StatusComboBox.Location = New System.Drawing.Point(670, 361)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.ShadowDecoration.Parent = Me.StatusComboBox
        Me.StatusComboBox.Size = New System.Drawing.Size(140, 36)
        Me.StatusComboBox.TabIndex = 137
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Open Sans Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label18.Location = New System.Drawing.Point(16, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 33)
        Me.Label18.TabIndex = 140
        Me.Label18.Text = "Student ID"
        '
        'SID
        '
        Me.SID.Animated = True
        Me.SID.AutoRoundedCorners = True
        Me.SID.BorderColor = System.Drawing.Color.Silver
        Me.SID.BorderRadius = 17
        Me.SID.BorderThickness = 2
        Me.SID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SID.DefaultText = ""
        Me.SID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SID.DisabledState.Parent = Me.SID
        Me.SID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SID.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.SID.FocusedState.Parent = Me.SID
        Me.SID.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SID.ForeColor = System.Drawing.Color.Black
        Me.SID.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.SID.HoverState.Parent = Me.SID
        Me.SID.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.SID.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.SID.Location = New System.Drawing.Point(17, 56)
        Me.SID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SID.Name = "SID"
        Me.SID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.SID.PlaceholderText = "Student ID"
        Me.SID.SelectedText = ""
        Me.SID.ShadowDecoration.Parent = Me.SID
        Me.SID.Size = New System.Drawing.Size(134, 36)
        Me.SID.TabIndex = 139
        '
        'CourseTB
        '
        Me.CourseTB.Animated = True
        Me.CourseTB.AutoRoundedCorners = True
        Me.CourseTB.BorderColor = System.Drawing.Color.Silver
        Me.CourseTB.BorderRadius = 17
        Me.CourseTB.BorderThickness = 2
        Me.CourseTB.Cursor = System.Windows.Forms.Cursors.No
        Me.CourseTB.DefaultText = ""
        Me.CourseTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CourseTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CourseTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CourseTB.DisabledState.Parent = Me.CourseTB
        Me.CourseTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CourseTB.FocusedState.BorderColor = System.Drawing.Color.Orchid
        Me.CourseTB.FocusedState.Parent = Me.CourseTB
        Me.CourseTB.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseTB.ForeColor = System.Drawing.Color.Black
        Me.CourseTB.HoverState.BorderColor = System.Drawing.Color.MediumPurple
        Me.CourseTB.HoverState.Parent = Me.CourseTB
        Me.CourseTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Orchid
        Me.CourseTB.IconLeftOffset = New System.Drawing.Point(4, 0)
        Me.CourseTB.Location = New System.Drawing.Point(239, 361)
        Me.CourseTB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CourseTB.Name = "CourseTB"
        Me.CourseTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CourseTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.CourseTB.PlaceholderText = "Course"
        Me.CourseTB.SelectedText = ""
        Me.CourseTB.ShadowDecoration.Parent = Me.CourseTB
        Me.CourseTB.Size = New System.Drawing.Size(185, 36)
        Me.CourseTB.TabIndex = 141
        Me.CourseTB.TabStop = False
        '
        'ChangeCourseButton
        '
        Me.ChangeCourseButton.Animated = True
        Me.ChangeCourseButton.AutoRoundedCorners = True
        Me.ChangeCourseButton.BorderRadius = 21
        Me.ChangeCourseButton.CheckedState.Parent = Me.ChangeCourseButton
        Me.ChangeCourseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeCourseButton.CustomImages.Parent = Me.ChangeCourseButton
        Me.ChangeCourseButton.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.ChangeCourseButton.FillColor2 = System.Drawing.Color.DarkTurquoise
        Me.ChangeCourseButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeCourseButton.ForeColor = System.Drawing.Color.White
        Me.ChangeCourseButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.ChangeCourseButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.ChangeCourseButton.HoverState.Parent = Me.ChangeCourseButton
        Me.ChangeCourseButton.Location = New System.Drawing.Point(505, 459)
        Me.ChangeCourseButton.Name = "ChangeCourseButton"
        Me.ChangeCourseButton.PressedColor = System.Drawing.Color.Teal
        Me.ChangeCourseButton.PressedDepth = 50
        Me.ChangeCourseButton.ShadowDecoration.Parent = Me.ChangeCourseButton
        Me.ChangeCourseButton.Size = New System.Drawing.Size(180, 45)
        Me.ChangeCourseButton.TabIndex = 142
        Me.ChangeCourseButton.Text = "Change course"
        '
        'EditStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 556)
        Me.Controls.Add(Me.ChangeCourseButton)
        Me.Controls.Add(Me.CourseTB)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.SID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.timelable)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.StuAgeTB)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.StuAdmissionTB)
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
        Me.Controls.Add(Me.StuStateTB)
        Me.Controls.Add(Me.StuCityTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StuAddressTB)
        Me.Controls.Add(Me.StuGenderCB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StuPhoneTB)
        Me.Controls.Add(Me.StuDateTimePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StuMotherTB)
        Me.Controls.Add(Me.StuFatherTB)
        Me.Controls.Add(Me.StuLastNameTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StuFirstNameTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Student"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timelable As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents StuAgeTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents UpdateButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents StuAdmissionTB As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ClearButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents UploadButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents StuEmaliTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents StuPINTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuStateTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuCityTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StuAddressTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuGenderCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StuPhoneTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuDateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents StuMotherTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuFatherTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StuLastNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents StatusComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CourseTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ChangeCourseButton As Guna.UI2.WinForms.Guna2GradientButton
    Public WithEvents StuFirstNameTB As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents SID As Guna.UI2.WinForms.Guna2TextBox
End Class
