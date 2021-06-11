<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmadmin))
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.CloudHeader3 = New CloudToolkitN6.CloudHeader()
        Me.txttitle = New CloudToolkitN6.CloudHeader()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(97, 47)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(221, 29)
        Me.txtusername.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Password"
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(97, 85)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(221, 29)
        Me.txtpass.TabIndex = 75
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
        Me.CloudHeader3.FontColorMouseOn = System.Drawing.Color.White
        Me.CloudHeader3.FontColorNormal = System.Drawing.Color.White
        Me.CloudHeader3.ForeColor = System.Drawing.Color.White
        Me.CloudHeader3.HeaderText = "Change Admin Username / Password"
        Me.CloudHeader3.Icon = Nothing
        Me.CloudHeader3.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudHeader3.IconPadding = 5
        Me.CloudHeader3.ImageHeader = False
        Me.CloudHeader3.Location = New System.Drawing.Point(0, 130)
        Me.CloudHeader3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CloudHeader3.Name = "CloudHeader3"
        Me.CloudHeader3.Size = New System.Drawing.Size(463, 36)
        Me.CloudHeader3.TabIndex = 79
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
        Me.txttitle.HeaderText = "Administrator Credentials"
        Me.txttitle.Icon = Nothing
        Me.txttitle.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.txttitle.IconPadding = 5
        Me.txttitle.ImageHeader = False
        Me.txttitle.Location = New System.Drawing.Point(0, 0)
        Me.txttitle.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(463, 36)
        Me.txttitle.TabIndex = 78
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(324, 49)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(64, 69)
        Me.btnsave.TabIndex = 82
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.Location = New System.Drawing.Point(387, 49)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(64, 69)
        Me.btnclose.TabIndex = 83
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frmadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 166)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.CloudHeader3)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmadmin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmadmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents CloudHeader3 As CloudToolkitN6.CloudHeader
    Friend WithEvents txttitle As CloudToolkitN6.CloudHeader
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
