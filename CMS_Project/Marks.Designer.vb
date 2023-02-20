<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marks))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.AddStudentButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Teal
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.RefreshButton)
        Me.Guna2GradientPanel1.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2GradientPanel1.Controls.Add(Me.AddStudentButton)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(997, 115)
        Me.Guna2GradientPanel1.TabIndex = 154
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marks"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(425, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 37)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Marks List"
        '
        'RefreshButton
        '
        Me.RefreshButton.Animated = True
        Me.RefreshButton.AutoRoundedCorners = True
        Me.RefreshButton.BorderRadius = 16
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
        Me.RefreshButton.Location = New System.Drawing.Point(432, 72)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.PressedColor = System.Drawing.Color.Teal
        Me.RefreshButton.PressedDepth = 50
        Me.RefreshButton.ShadowDecoration.Parent = Me.RefreshButton
        Me.RefreshButton.Size = New System.Drawing.Size(130, 35)
        Me.RefreshButton.TabIndex = 157
        Me.RefreshButton.Text = "Refresh"
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
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(769, 70)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.PressedColor = System.Drawing.Color.Turquoise
        Me.Guna2GradientButton2.PressedDepth = 100
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(157, 37)
        Me.Guna2GradientButton2.TabIndex = 156
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
        Me.AddStudentButton.Location = New System.Drawing.Point(606, 70)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.PressedColor = System.Drawing.Color.Turquoise
        Me.AddStudentButton.PressedDepth = 100
        Me.AddStudentButton.ShadowDecoration.Parent = Me.AddStudentButton
        Me.AddStudentButton.Size = New System.Drawing.Size(157, 37)
        Me.AddStudentButton.TabIndex = 155
        Me.AddStudentButton.Text = "ADD"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(997, 434)
        Me.DataGridView1.TabIndex = 155
        '
        'Marks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 549)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Marks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RefreshButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents AddStudentButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
