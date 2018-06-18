<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCustomer))
        Me.GrpCustDetails = New System.Windows.Forms.GroupBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtFullAdd = New System.Windows.Forms.TextBox()
        Me.txtEmailAdd = New System.Windows.Forms.TextBox()
        Me.txtContNumber = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblFullAddress = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GrpCustDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpCustDetails
        '
        Me.GrpCustDetails.Controls.Add(Me.txtRemarks)
        Me.GrpCustDetails.Controls.Add(Me.txtFullAdd)
        Me.GrpCustDetails.Controls.Add(Me.txtEmailAdd)
        Me.GrpCustDetails.Controls.Add(Me.txtContNumber)
        Me.GrpCustDetails.Controls.Add(Me.txtLastName)
        Me.GrpCustDetails.Controls.Add(Me.txtFirstName)
        Me.GrpCustDetails.Controls.Add(Me.txtCustID)
        Me.GrpCustDetails.Controls.Add(Me.lblRemarks)
        Me.GrpCustDetails.Controls.Add(Me.lblFullAddress)
        Me.GrpCustDetails.Controls.Add(Me.lblEmailAddress)
        Me.GrpCustDetails.Controls.Add(Me.lblContactNumber)
        Me.GrpCustDetails.Controls.Add(Me.lblLastName)
        Me.GrpCustDetails.Controls.Add(Me.lblFirstName)
        Me.GrpCustDetails.Controls.Add(Me.lblCustID)
        Me.GrpCustDetails.Location = New System.Drawing.Point(59, 96)
        Me.GrpCustDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpCustDetails.Name = "GrpCustDetails"
        Me.GrpCustDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpCustDetails.Size = New System.Drawing.Size(411, 357)
        Me.GrpCustDetails.TabIndex = 0
        Me.GrpCustDetails.TabStop = False
        Me.GrpCustDetails.Text = "Customer Details"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(178, 286)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(168, 22)
        Me.txtRemarks.TabIndex = 13
        '
        'txtFullAdd
        '
        Me.txtFullAdd.Location = New System.Drawing.Point(178, 247)
        Me.txtFullAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullAdd.Name = "txtFullAdd"
        Me.txtFullAdd.Size = New System.Drawing.Size(168, 22)
        Me.txtFullAdd.TabIndex = 12
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.Location = New System.Drawing.Point(178, 208)
        Me.txtEmailAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(168, 22)
        Me.txtEmailAdd.TabIndex = 11
        '
        'txtContNumber
        '
        Me.txtContNumber.Location = New System.Drawing.Point(178, 169)
        Me.txtContNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContNumber.Name = "txtContNumber"
        Me.txtContNumber.Size = New System.Drawing.Size(168, 22)
        Me.txtContNumber.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(178, 131)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(168, 22)
        Me.txtLastName.TabIndex = 9
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(178, 93)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(168, 22)
        Me.txtFirstName.TabIndex = 8
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(178, 56)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(168, 22)
        Me.txtCustID.TabIndex = 7
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(49, 287)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(125, 17)
        Me.lblRemarks.TabIndex = 6
        Me.lblRemarks.Text = "Remark                :"
        '
        'lblFullAddress
        '
        Me.lblFullAddress.AutoSize = True
        Me.lblFullAddress.Location = New System.Drawing.Point(49, 248)
        Me.lblFullAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullAddress.Name = "lblFullAddress"
        Me.lblFullAddress.Size = New System.Drawing.Size(126, 17)
        Me.lblFullAddress.TabIndex = 5
        Me.lblFullAddress.Text = "Full Address         :"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(49, 208)
        Me.lblEmailAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(126, 17)
        Me.lblEmailAddress.TabIndex = 4
        Me.lblEmailAddress.Text = "Email Address      :"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(49, 170)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(126, 17)
        Me.lblContactNumber.TabIndex = 3
        Me.lblContactNumber.Text = "Contact Number   :"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(49, 132)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(124, 17)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name           :"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(49, 94)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(124, 17)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name           :"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(49, 57)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(125, 17)
        Me.lblCustID.TabIndex = 0
        Me.lblCustID.Text = "Customer ID         :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add New Customer"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(101, 488)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(339, 488)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(219, 488)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 546)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpCustDetails)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddCustomer"
        Me.Text = "OperatorAddNewCustomer"
        Me.GrpCustDetails.ResumeLayout(False)
        Me.GrpCustDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpCustDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtFullAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtContNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents lblFullAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
