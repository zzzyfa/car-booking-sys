<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdminLog = New System.Windows.Forms.Button()
        Me.btnOpLog = New System.Windows.Forms.Button()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Rental Booking System"
        '
        'btnAdminLog
        '
        Me.btnAdminLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLog.Location = New System.Drawing.Point(40, 49)
        Me.btnAdminLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdminLog.Name = "btnAdminLog"
        Me.btnAdminLog.Size = New System.Drawing.Size(183, 96)
        Me.btnAdminLog.TabIndex = 1
        Me.btnAdminLog.Text = "Admin"
        Me.btnAdminLog.UseVisualStyleBackColor = True
        '
        'btnOpLog
        '
        Me.btnOpLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpLog.Location = New System.Drawing.Point(249, 49)
        Me.btnOpLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOpLog.Name = "btnOpLog"
        Me.btnOpLog.Size = New System.Drawing.Size(179, 96)
        Me.btnOpLog.TabIndex = 2
        Me.btnOpLog.Text = "Operator"
        Me.btnOpLog.UseCompatibleTextRendering = True
        Me.btnOpLog.UseVisualStyleBackColor = True
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.btnAdminLog)
        Me.grpLogin.Controls.Add(Me.btnOpLog)
        Me.grpLogin.Location = New System.Drawing.Point(44, 126)
        Me.grpLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLogin.Size = New System.Drawing.Size(455, 201)
        Me.grpLogin.TabIndex = 3
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Log-In as:"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(543, 375)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        Me.grpLogin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdminLog As System.Windows.Forms.Button
    Friend WithEvents btnOpLog As System.Windows.Forms.Button
    Friend WithEvents grpLogin As System.Windows.Forms.GroupBox
End Class
