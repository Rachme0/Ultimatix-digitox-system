<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Front_End
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Front_End))
        Me.CloudHeader3 = New CloudToolkitN6.CloudHeader()
        Me.txttitle = New CloudToolkitN6.CloudHeader()
        Me.CloudDigitalClock1 = New CloudToolkitN6.CloudDigitalClock()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttimeout = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttimein = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btntimein = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolclear = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginimage = New System.Windows.Forms.PictureBox()
        Me.btnadminlogin = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.Btnmin = New System.Windows.Forms.PictureBox()
        Me.Btnclose = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.loginimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloudHeader3
        '
        Me.CloudHeader3.BackColor = System.Drawing.Color.Transparent
        Me.CloudHeader3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloudHeader3.BorderColor = System.Drawing.Color.Transparent
        Me.CloudHeader3.BorderWidth = 1.0!
        Me.CloudHeader3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CloudHeader3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloudHeader3.FillColor1 = System.Drawing.SystemColors.ActiveCaptionText
        Me.CloudHeader3.FillColor2 = System.Drawing.Color.Black
        Me.CloudHeader3.FillColor2_1 = System.Drawing.Color.Black
        Me.CloudHeader3.FillColor2_2 = System.Drawing.Color.Black
        Me.CloudHeader3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudHeader3.FontColorMouseOn = System.Drawing.Color.White
        Me.CloudHeader3.FontColorNormal = System.Drawing.Color.White
        Me.CloudHeader3.ForeColor = System.Drawing.Color.White
        Me.CloudHeader3.HeaderText = "Only authorized users are allowed to login"
        Me.CloudHeader3.Icon = Nothing
        Me.CloudHeader3.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudHeader3.IconPadding = 5
        Me.CloudHeader3.ImageHeader = False
        Me.CloudHeader3.Location = New System.Drawing.Point(0, 430)
        Me.CloudHeader3.Margin = New System.Windows.Forms.Padding(5)
        Me.CloudHeader3.Name = "CloudHeader3"
        Me.CloudHeader3.Size = New System.Drawing.Size(779, 36)
        Me.CloudHeader3.TabIndex = 16
        '
        'txttitle
        '
        Me.txttitle.BackColor = System.Drawing.Color.Transparent
        Me.txttitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txttitle.BorderColor = System.Drawing.Color.Transparent
        Me.txttitle.BorderWidth = 1.0!
        Me.txttitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.txttitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.txttitle.FillColor1 = System.Drawing.SystemColors.ActiveCaptionText
        Me.txttitle.FillColor2 = System.Drawing.Color.Black
        Me.txttitle.FillColor2_1 = System.Drawing.Color.Black
        Me.txttitle.FillColor2_2 = System.Drawing.Color.Black
        Me.txttitle.FontColorMouseOn = System.Drawing.Color.White
        Me.txttitle.FontColorNormal = System.Drawing.Color.White
        Me.txttitle.ForeColor = System.Drawing.Color.White
        Me.txttitle.HeaderText = "Ultimatix digitox System - Front-End View"
        Me.txttitle.Icon = Nothing
        Me.txttitle.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.txttitle.IconPadding = 5
        Me.txttitle.ImageHeader = False
        Me.txttitle.Location = New System.Drawing.Point(0, 0)
        Me.txttitle.Margin = New System.Windows.Forms.Padding(5)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(779, 36)
        Me.txttitle.TabIndex = 15
        '
        'CloudDigitalClock1
        '
        Me.CloudDigitalClock1.BackColor = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorLower_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.CloudDigitalClock1.ColorLower_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CloudDigitalClock1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudDigitalClock1.DateColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.DateFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudDigitalClock1.DrawDate = True
        Me.CloudDigitalClock1.Location = New System.Drawing.Point(5, 39)
        Me.CloudDigitalClock1.Margin = New System.Windows.Forms.Padding(5)
        Me.CloudDigitalClock1.Name = "CloudDigitalClock1"
        Me.CloudDigitalClock1.NumberColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.NumberFont = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudDigitalClock1.Size = New System.Drawing.Size(445, 97)
        Me.CloudDigitalClock1.TabIndex = 19
        '
        'txtuserid
        '
        Me.txtuserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuserid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(104, 137)
        Me.txtuserid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(221, 29)
        Me.txtuserid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 175)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Password"
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(104, 174)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(221, 29)
        Me.txtpass.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txttimeout)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttimein)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 212)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(433, 142)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'txttimeout
        '
        Me.txttimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttimeout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimeout.Location = New System.Drawing.Point(103, 98)
        Me.txttimeout.Margin = New System.Windows.Forms.Padding(4)
        Me.txttimeout.Name = "txttimeout"
        Me.txttimeout.ReadOnly = True
        Me.txttimeout.Size = New System.Drawing.Size(322, 29)
        Me.txttimeout.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Time Out"
        '
        'txttimein
        '
        Me.txttimein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttimein.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimein.Location = New System.Drawing.Point(103, 63)
        Me.txttimein.Margin = New System.Windows.Forms.Padding(4)
        Me.txttimein.Name = "txttimein"
        Me.txttimein.ReadOnly = True
        Me.txttimein.Size = New System.Drawing.Size(322, 29)
        Me.txttimein.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 23)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Time In"
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(103, 27)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(322, 29)
        Me.txtusername.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(452, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 407)
        Me.Panel1.TabIndex = 76
        '
        'btntimein
        '
        Me.btntimein.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btntimein.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btntimein.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntimein.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntimein.ForeColor = System.Drawing.Color.White
        Me.btntimein.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btntimein.Location = New System.Drawing.Point(333, 137)
        Me.btntimein.Margin = New System.Windows.Forms.Padding(4)
        Me.btntimein.Name = "btntimein"
        Me.btntimein.Size = New System.Drawing.Size(100, 33)
        Me.btntimein.TabIndex = 3
        Me.btntimein.Text = "Time In"
        Me.btntimein.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntimein.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnclear.Location = New System.Drawing.Point(333, 174)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(100, 33)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Clear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(473, 361)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 57)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Enter your User ID and password." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "click ENTER on keyboard to record time in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clic" &
    "k DELETE on keyboard to clear login"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolclear, Me.toolAdmin})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 36)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 28)
        Me.MenuStrip1.TabIndex = 78
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'toolclear
        '
        Me.toolclear.Name = "toolclear"
        Me.toolclear.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.toolclear.Size = New System.Drawing.Size(158, 24)
        Me.toolclear.Text = "ToolStripMenuItem1"
        '
        'toolAdmin
        '
        Me.toolAdmin.Name = "toolAdmin"
        Me.toolAdmin.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.toolAdmin.Size = New System.Drawing.Size(158, 24)
        Me.toolAdmin.Text = "ToolStripMenuItem1"
        '
        'loginimage
        '
        Me.loginimage.BackColor = System.Drawing.Color.Black
        Me.loginimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginimage.Image = Global.Login.My.Resources.Resources.admin2
        Me.loginimage.Location = New System.Drawing.Point(467, 43)
        Me.loginimage.Margin = New System.Windows.Forms.Padding(4)
        Me.loginimage.Name = "loginimage"
        Me.loginimage.Size = New System.Drawing.Size(299, 314)
        Me.loginimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loginimage.TabIndex = 75
        Me.loginimage.TabStop = False
        '
        'btnadminlogin
        '
        Me.btnadminlogin.AnimationOpacityChange = 0.1R
        Me.btnadminlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnadminlogin.ButtonText = "Admin Login (Ctrl+A)"
        Me.btnadminlogin.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnadminlogin.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnadminlogin.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnadminlogin.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnadminlogin.ControlOpacity = 255
        Me.btnadminlogin.CornerRadius = 1
        Me.btnadminlogin.DrawHoverOverIcon = False
        Me.btnadminlogin.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnadminlogin.ForeColor = System.Drawing.Color.White
        Me.btnadminlogin.GlowColor = System.Drawing.Color.BlueViolet
        Me.btnadminlogin.Icon = CType(resources.GetObject("btnadminlogin.Icon"), System.Drawing.Bitmap)
        Me.btnadminlogin.IsAnimated = True
        Me.btnadminlogin.Location = New System.Drawing.Point(8, 361)
        Me.btnadminlogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadminlogin.MaximumGlowOpacity = 0.8R
        Me.btnadminlogin.Name = "btnadminlogin"
        Me.btnadminlogin.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnadminlogin.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnadminlogin.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnadminlogin.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnadminlogin.Size = New System.Drawing.Size(433, 64)
        Me.btnadminlogin.StartMenuIndex = 0
        Me.btnadminlogin.TabIndex = 73
        Me.btnadminlogin.TextCentered = True
        Me.btnadminlogin.TextDistanceFromBorder = 5
        Me.btnadminlogin.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'Btnmin
        '
        Me.Btnmin.BackColor = System.Drawing.Color.Black
        Me.Btnmin.BackgroundImage = Global.Login.My.Resources.Resources.min
        Me.Btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnmin.Location = New System.Drawing.Point(711, -1)
        Me.Btnmin.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnmin.Name = "Btnmin"
        Me.Btnmin.Size = New System.Drawing.Size(33, 33)
        Me.Btnmin.TabIndex = 18
        Me.Btnmin.TabStop = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.Color.Black
        Me.Btnclose.BackgroundImage = Global.Login.My.Resources.Resources.close
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnclose.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnclose.Location = New System.Drawing.Point(744, 0)
        Me.Btnclose.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(33, 33)
        Me.Btnclose.TabIndex = 17
        Me.Btnclose.TabStop = False
        '
        'Front_End
        '
        Me.AcceptButton = Me.btntimein
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(779, 466)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btntimein)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.loginimage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnadminlogin)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.CloudDigitalClock1)
        Me.Controls.Add(Me.Btnmin)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.CloudHeader3)
        Me.Controls.Add(Me.txttitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Front_End"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Time-In System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.loginimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnmin As System.Windows.Forms.PictureBox
    Friend WithEvents Btnclose As System.Windows.Forms.PictureBox
    Friend WithEvents CloudHeader3 As CloudToolkitN6.CloudHeader
    Friend WithEvents txttitle As CloudToolkitN6.CloudHeader
    Friend WithEvents CloudDigitalClock1 As CloudToolkitN6.CloudDigitalClock
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btnadminlogin As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttimeout As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttimein As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents loginimage As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btntimein As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents toolclear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolAdmin As System.Windows.Forms.ToolStripMenuItem
End Class
