<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMenu))
        Me.grpManageCar = New System.Windows.Forms.GroupBox()
        Me.btnCarEdit = New System.Windows.Forms.Button()
        Me.btnCarRemove = New System.Windows.Forms.Button()
        Me.btnCarAdd = New System.Windows.Forms.Button()
        Me.grpManageOp = New System.Windows.Forms.GroupBox()
        Me.btnOpEdit = New System.Windows.Forms.Button()
        Me.btnOpRemove = New System.Windows.Forms.Button()
        Me.btnOpAdd = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.grpManageCar.SuspendLayout()
        Me.grpManageOp.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpManageCar
        '
        Me.grpManageCar.Controls.Add(Me.btnCarEdit)
        Me.grpManageCar.Controls.Add(Me.btnCarRemove)
        Me.grpManageCar.Controls.Add(Me.btnCarAdd)
        Me.grpManageCar.Location = New System.Drawing.Point(49, 96)
        Me.grpManageCar.Margin = New System.Windows.Forms.Padding(4)
        Me.grpManageCar.Name = "grpManageCar"
        Me.grpManageCar.Padding = New System.Windows.Forms.Padding(4)
        Me.grpManageCar.Size = New System.Drawing.Size(495, 179)
        Me.grpManageCar.TabIndex = 0
        Me.grpManageCar.TabStop = False
        Me.grpManageCar.Text = "Car Manager"
        '
        'btnCarEdit
        '
        Me.btnCarEdit.Location = New System.Drawing.Point(185, 69)
        Me.btnCarEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarEdit.Name = "btnCarEdit"
        Me.btnCarEdit.Size = New System.Drawing.Size(127, 47)
        Me.btnCarEdit.TabIndex = 2
        Me.btnCarEdit.Text = "Edit"
        Me.btnCarEdit.UseVisualStyleBackColor = True
        '
        'btnCarRemove
        '
        Me.btnCarRemove.Location = New System.Drawing.Point(341, 69)
        Me.btnCarRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarRemove.Name = "btnCarRemove"
        Me.btnCarRemove.Size = New System.Drawing.Size(127, 47)
        Me.btnCarRemove.TabIndex = 1
        Me.btnCarRemove.Text = "Remove"
        Me.btnCarRemove.UseVisualStyleBackColor = True
        '
        'btnCarAdd
        '
        Me.btnCarAdd.Location = New System.Drawing.Point(25, 69)
        Me.btnCarAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarAdd.Name = "btnCarAdd"
        Me.btnCarAdd.Size = New System.Drawing.Size(127, 47)
        Me.btnCarAdd.TabIndex = 0
        Me.btnCarAdd.Text = "Add"
        Me.btnCarAdd.UseVisualStyleBackColor = True
        '
        'grpManageOp
        '
        Me.grpManageOp.Controls.Add(Me.btnOpEdit)
        Me.grpManageOp.Controls.Add(Me.btnOpRemove)
        Me.grpManageOp.Controls.Add(Me.btnOpAdd)
        Me.grpManageOp.Location = New System.Drawing.Point(49, 293)
        Me.grpManageOp.Margin = New System.Windows.Forms.Padding(4)
        Me.grpManageOp.Name = "grpManageOp"
        Me.grpManageOp.Padding = New System.Windows.Forms.Padding(4)
        Me.grpManageOp.Size = New System.Drawing.Size(495, 185)
        Me.grpManageOp.TabIndex = 1
        Me.grpManageOp.TabStop = False
        Me.grpManageOp.Text = "Operator Manager"
        '
        'btnOpEdit
        '
        Me.btnOpEdit.Location = New System.Drawing.Point(185, 68)
        Me.btnOpEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpEdit.Name = "btnOpEdit"
        Me.btnOpEdit.Size = New System.Drawing.Size(127, 47)
        Me.btnOpEdit.TabIndex = 3
        Me.btnOpEdit.Text = "Edit"
        Me.btnOpEdit.UseVisualStyleBackColor = True
        '
        'btnOpRemove
        '
        Me.btnOpRemove.Location = New System.Drawing.Point(341, 66)
        Me.btnOpRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpRemove.Name = "btnOpRemove"
        Me.btnOpRemove.Size = New System.Drawing.Size(127, 49)
        Me.btnOpRemove.TabIndex = 1
        Me.btnOpRemove.Text = "Remove"
        Me.btnOpRemove.UseVisualStyleBackColor = True
        '
        'btnOpAdd
        '
        Me.btnOpAdd.Location = New System.Drawing.Point(25, 66)
        Me.btnOpAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpAdd.Name = "btnOpAdd"
        Me.btnOpAdd.Size = New System.Drawing.Size(127, 49)
        Me.btnOpAdd.TabIndex = 0
        Me.btnOpAdd.Text = "Add"
        Me.btnOpAdd.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(157, 39)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(302, 29)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Welcome to Admin Menu"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(444, 494)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 28)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 540)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.grpManageOp)
        Me.Controls.Add(Me.grpManageCar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminMenu"
        Me.Text = "Admin Main Menu"
        Me.grpManageCar.ResumeLayout(False)
        Me.grpManageOp.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpManageCar As System.Windows.Forms.GroupBox
    Friend WithEvents grpManageOp As System.Windows.Forms.GroupBox
    Friend WithEvents btnCarEdit As System.Windows.Forms.Button
    Friend WithEvents btnCarRemove As System.Windows.Forms.Button
    Friend WithEvents btnCarAdd As System.Windows.Forms.Button
    Friend WithEvents btnOpRemove As System.Windows.Forms.Button
    Friend WithEvents btnOpAdd As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnOpEdit As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
