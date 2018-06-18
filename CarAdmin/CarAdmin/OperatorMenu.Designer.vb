<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperatorMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OperatorMenu))
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.btnCarBook = New System.Windows.Forms.Button()
        Me.btnTranRpt = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnCarRpt = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(95, 37)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(148, 44)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Location = New System.Drawing.Point(95, 87)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(148, 44)
        Me.btnEditCustomer.TabIndex = 1
        Me.btnEditCustomer.Text = "Edit Customer"
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'btnCarBook
        '
        Me.btnCarBook.Location = New System.Drawing.Point(95, 136)
        Me.btnCarBook.Name = "btnCarBook"
        Me.btnCarBook.Size = New System.Drawing.Size(148, 44)
        Me.btnCarBook.TabIndex = 2
        Me.btnCarBook.Text = "Car Booking"
        Me.btnCarBook.UseVisualStyleBackColor = True
        '
        'btnTranRpt
        '
        Me.btnTranRpt.Location = New System.Drawing.Point(29, 60)
        Me.btnTranRpt.Name = "btnTranRpt"
        Me.btnTranRpt.Size = New System.Drawing.Size(120, 44)
        Me.btnTranRpt.TabIndex = 3
        Me.btnTranRpt.Text = "Transaction Report"
        Me.btnTranRpt.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(87, 37)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(268, 24)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome to Operator Menu"
        '
        'btnCarRpt
        '
        Me.btnCarRpt.Location = New System.Drawing.Point(181, 60)
        Me.btnCarRpt.Name = "btnCarRpt"
        Me.btnCarRpt.Size = New System.Drawing.Size(124, 44)
        Me.btnCarRpt.TabIndex = 6
        Me.btnCarRpt.Text = "Car Report"
        Me.btnCarRpt.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(308, 496)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditCustomer)
        Me.GroupBox1.Controls.Add(Me.btnAddCustomer)
        Me.GroupBox1.Controls.Add(Me.btnCarBook)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(335, 210)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer and Booking"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCarRpt)
        Me.GroupBox2.Controls.Add(Me.btnTranRpt)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 314)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(335, 157)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Generator"
        '
        'OperatorMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 541)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "OperatorMenu"
        Me.Text = "Operator Main Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents btnEditCustomer As System.Windows.Forms.Button
    Friend WithEvents btnCarBook As System.Windows.Forms.Button
    Friend WithEvents btnTranRpt As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnCarRpt As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
