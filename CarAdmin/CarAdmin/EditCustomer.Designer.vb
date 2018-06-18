<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpCustDetails = New System.Windows.Forms.GroupBox()
        Me.txtRemarksResult = New System.Windows.Forms.TextBox()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.lblRemarks2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFullAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtLastNameResult = New System.Windows.Forms.TextBox()
        Me.lblLastNameResult = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblFirstNameResult = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnClose2 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.grpCustDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name   :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(179, 121)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(188, 22)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(375, 117)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grpCustDetails
        '
        Me.grpCustDetails.Controls.Add(Me.lblCustID)
        Me.grpCustDetails.Controls.Add(Me.txtRemarksResult)
        Me.grpCustDetails.Controls.Add(Me.btnClear2)
        Me.grpCustDetails.Controls.Add(Me.lblRemarks2)
        Me.grpCustDetails.Controls.Add(Me.btnSave)
        Me.grpCustDetails.Controls.Add(Me.txtFullAddress)
        Me.grpCustDetails.Controls.Add(Me.Label3)
        Me.grpCustDetails.Controls.Add(Me.txtEmailAddress)
        Me.grpCustDetails.Controls.Add(Me.Label2)
        Me.grpCustDetails.Controls.Add(Me.txtContactNumber)
        Me.grpCustDetails.Controls.Add(Me.lblContactNumber)
        Me.grpCustDetails.Controls.Add(Me.txtLastNameResult)
        Me.grpCustDetails.Controls.Add(Me.lblLastNameResult)
        Me.grpCustDetails.Controls.Add(Me.lblCustomerID)
        Me.grpCustDetails.Controls.Add(Me.lblFirstNameResult)
        Me.grpCustDetails.Controls.Add(Me.lblFirstName)
        Me.grpCustDetails.Location = New System.Drawing.Point(93, 190)
        Me.grpCustDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCustDetails.Name = "grpCustDetails"
        Me.grpCustDetails.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCustDetails.Size = New System.Drawing.Size(395, 378)
        Me.grpCustDetails.TabIndex = 3
        Me.grpCustDetails.TabStop = False
        Me.grpCustDetails.Text = "Customer Details"
        '
        'txtRemarksResult
        '
        Me.txtRemarksResult.Location = New System.Drawing.Point(173, 274)
        Me.txtRemarksResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRemarksResult.Name = "txtRemarksResult"
        Me.txtRemarksResult.Size = New System.Drawing.Size(177, 22)
        Me.txtRemarksResult.TabIndex = 13
        '
        'btnClear2
        '
        Me.btnClear2.Location = New System.Drawing.Point(308, 332)
        Me.btnClear2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(69, 28)
        Me.btnClear2.TabIndex = 7
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'lblRemarks2
        '
        Me.lblRemarks2.AutoSize = True
        Me.lblRemarks2.Location = New System.Drawing.Point(43, 274)
        Me.lblRemarks2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemarks2.Name = "lblRemarks2"
        Me.lblRemarks2.Size = New System.Drawing.Size(129, 17)
        Me.lblRemarks2.TabIndex = 12
        Me.lblRemarks2.Text = "Remark                 :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(209, 332)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Update"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFullAddress
        '
        Me.txtFullAddress.Location = New System.Drawing.Point(173, 239)
        Me.txtFullAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFullAddress.Name = "txtFullAddress"
        Me.txtFullAddress.Size = New System.Drawing.Size(177, 22)
        Me.txtFullAddress.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 240)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Full Address          :"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(173, 202)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(177, 22)
        Me.txtEmailAddress.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 203)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email Address       :"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(173, 165)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(177, 22)
        Me.txtContactNumber.TabIndex = 7
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(41, 166)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(130, 17)
        Me.lblContactNumber.TabIndex = 6
        Me.lblContactNumber.Text = "Contact Number    :"
        '
        'txtLastNameResult
        '
        Me.txtLastNameResult.Location = New System.Drawing.Point(173, 127)
        Me.txtLastNameResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastNameResult.Name = "txtLastNameResult"
        Me.txtLastNameResult.Size = New System.Drawing.Size(177, 22)
        Me.txtLastNameResult.TabIndex = 5
        '
        'lblLastNameResult
        '
        Me.lblLastNameResult.AutoSize = True
        Me.lblLastNameResult.Location = New System.Drawing.Point(43, 128)
        Me.lblLastNameResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastNameResult.Name = "lblLastNameResult"
        Me.lblLastNameResult.Size = New System.Drawing.Size(128, 17)
        Me.lblLastNameResult.TabIndex = 4
        Me.lblLastNameResult.Text = "Last Name            :"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(43, 89)
        Me.lblCustomerID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(129, 17)
        Me.lblCustomerID.TabIndex = 2
        Me.lblCustomerID.Text = "Customer ID          :"
        '
        'lblFirstNameResult
        '
        Me.lblFirstNameResult.AutoSize = True
        Me.lblFirstNameResult.Location = New System.Drawing.Point(179, 52)
        Me.lblFirstNameResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstNameResult.Name = "lblFirstNameResult"
        Me.lblFirstNameResult.Size = New System.Drawing.Size(51, 17)
        Me.lblFirstNameResult.TabIndex = 1
        Me.lblFirstNameResult.Text = "Label2"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(43, 52)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(128, 17)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name            :"
        '
        'btnClose2
        '
        Me.btnClose2.Location = New System.Drawing.Point(477, 575)
        Me.btnClose2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(88, 28)
        Me.btnClose2.TabIndex = 5
        Me.btnClose2.Text = "Close"
        Me.btnClose2.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(464, 117)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 28)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Edit Customer Information"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(182, 89)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(51, 17)
        Me.lblCustID.TabIndex = 14
        Me.lblCustID.Text = "Label5"
        '
        'EditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 613)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose2)
        Me.Controls.Add(Me.grpCustDetails)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EditCustomer"
        Me.Text = "EditCustomer"
        Me.grpCustDetails.ResumeLayout(False)
        Me.grpCustDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents grpCustDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents txtLastNameResult As System.Windows.Forms.TextBox
    Friend WithEvents lblLastNameResult As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblFirstNameResult As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFullAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarksResult As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose2 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClear2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCustID As System.Windows.Forms.Label
End Class
