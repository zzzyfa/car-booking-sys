<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(152, 89)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(227, 22)
        Me.txtUserID.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(152, 131)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(227, 22)
        Me.txtPass.TabIndex = 1
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Location = New System.Drawing.Point(52, 90)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(95, 17)
        Me.lblUserID.TabIndex = 2
        Me.lblUserID.Text = "User ID         :"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Location = New System.Drawing.Point(52, 133)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(97, 17)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password      :"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(280, 213)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 28)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Admin Login"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(172, 213)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(423, 283)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserID)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminLogin"
        Me.Text = "AdminLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
