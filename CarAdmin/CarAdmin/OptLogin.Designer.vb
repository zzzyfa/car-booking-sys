<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptLogin))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(138, 158)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Operator Log-In"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(219, 158)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Location = New System.Drawing.Point(53, 103)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(71, 13)
        Me.lblPass.TabIndex = 10
        Me.lblPass.Text = "Password     :"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Location = New System.Drawing.Point(53, 75)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(70, 13)
        Me.lblUserID.TabIndex = 9
        Me.lblUserID.Text = "User ID        :"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(124, 103)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(171, 20)
        Me.txtPass.TabIndex = 8
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(124, 75)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(171, 20)
        Me.txtUserID.TabIndex = 7
        '
        'OptLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(353, 206)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserID)
        Me.Name = "OptLogin"
        Me.Text = "OptLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
End Class
