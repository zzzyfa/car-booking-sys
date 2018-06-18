<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCar))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grpCarDetails = New System.Windows.Forms.GroupBox()
        Me.lblCarID2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDailyRate = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCarBrand = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblCarStatus = New System.Windows.Forms.Label()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCarStatus2 = New System.Windows.Forms.Label()
        Me.lblCarType2 = New System.Windows.Forms.Label()
        Me.lblCarBrand2 = New System.Windows.Forms.Label()
        Me.grpCarDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(352, 100)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 32)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(149, 105)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(187, 22)
        Me.txtSearch.TabIndex = 1
        '
        'grpCarDetails
        '
        Me.grpCarDetails.Controls.Add(Me.lblCarType2)
        Me.grpCarDetails.Controls.Add(Me.lblCarBrand2)
        Me.grpCarDetails.Controls.Add(Me.lblCarStatus2)
        Me.grpCarDetails.Controls.Add(Me.lblCarID2)
        Me.grpCarDetails.Controls.Add(Me.Label5)
        Me.grpCarDetails.Controls.Add(Me.btnClear2)
        Me.grpCarDetails.Controls.Add(Me.txtRemarks)
        Me.grpCarDetails.Controls.Add(Me.Label4)
        Me.grpCarDetails.Controls.Add(Me.txtDailyRate)
        Me.grpCarDetails.Controls.Add(Me.btnUpdate)
        Me.grpCarDetails.Controls.Add(Me.Label3)
        Me.grpCarDetails.Controls.Add(Me.Label2)
        Me.grpCarDetails.Controls.Add(Me.lblCarBrand)
        Me.grpCarDetails.Controls.Add(Me.lblCarType)
        Me.grpCarDetails.Controls.Add(Me.lblCarStatus)
        Me.grpCarDetails.Controls.Add(Me.lblCarModel)
        Me.grpCarDetails.Location = New System.Drawing.Point(53, 166)
        Me.grpCarDetails.Name = "grpCarDetails"
        Me.grpCarDetails.Size = New System.Drawing.Size(450, 372)
        Me.grpCarDetails.TabIndex = 2
        Me.grpCarDetails.TabStop = False
        Me.grpCarDetails.Text = "Car Details"
        '
        'lblCarID2
        '
        Me.lblCarID2.AutoSize = True
        Me.lblCarID2.Location = New System.Drawing.Point(186, 90)
        Me.lblCarID2.Name = "lblCarID2"
        Me.lblCarID2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarID2.TabIndex = 14
        Me.lblCarID2.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Car Model     :"
        '
        'btnClear2
        '
        Me.btnClear2.Location = New System.Drawing.Point(363, 324)
        Me.btnClear2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(69, 32)
        Me.btnClear2.TabIndex = 11
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(186, 270)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(178, 22)
        Me.txtRemarks.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Remark        :"
        '
        'txtDailyRate
        '
        Me.txtDailyRate.Location = New System.Drawing.Point(186, 235)
        Me.txtDailyRate.Name = "txtDailyRate"
        Me.txtDailyRate.Size = New System.Drawing.Size(178, 22)
        Me.txtDailyRate.TabIndex = 10
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(281, 324)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 32)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Daily Rate    :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Car ID           :"
        '
        'lblCarBrand
        '
        Me.lblCarBrand.AutoSize = True
        Me.lblCarBrand.Location = New System.Drawing.Point(86, 163)
        Me.lblCarBrand.Name = "lblCarBrand"
        Me.lblCarBrand.Size = New System.Drawing.Size(92, 17)
        Me.lblCarBrand.TabIndex = 3
        Me.lblCarBrand.Text = "Car Brand    :"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Location = New System.Drawing.Point(85, 199)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(94, 17)
        Me.lblCarType.TabIndex = 2
        Me.lblCarType.Text = "Car Type      :"
        '
        'lblCarStatus
        '
        Me.lblCarStatus.AutoSize = True
        Me.lblCarStatus.Location = New System.Drawing.Point(85, 127)
        Me.lblCarStatus.Name = "lblCarStatus"
        Me.lblCarStatus.Size = New System.Drawing.Size(94, 17)
        Me.lblCarStatus.TabIndex = 1
        Me.lblCarStatus.Text = "Car Status    :"
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Location = New System.Drawing.Point(184, 54)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(51, 17)
        Me.lblCarModel.TabIndex = 0
        Me.lblCarModel.Text = "Label1"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(428, 558)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(50, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Car Model    :"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(434, 100)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 32)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 45)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Edit Car Information"
        '
        'lblCarStatus2
        '
        Me.lblCarStatus2.AutoSize = True
        Me.lblCarStatus2.Location = New System.Drawing.Point(186, 127)
        Me.lblCarStatus2.Name = "lblCarStatus2"
        Me.lblCarStatus2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarStatus2.TabIndex = 15
        Me.lblCarStatus2.Text = "Label1"
        '
        'lblCarType2
        '
        Me.lblCarType2.AutoSize = True
        Me.lblCarType2.Location = New System.Drawing.Point(186, 199)
        Me.lblCarType2.Name = "lblCarType2"
        Me.lblCarType2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarType2.TabIndex = 17
        Me.lblCarType2.Text = "Label1"
        '
        'lblCarBrand2
        '
        Me.lblCarBrand2.AutoSize = True
        Me.lblCarBrand2.Location = New System.Drawing.Point(186, 163)
        Me.lblCarBrand2.Name = "lblCarBrand2"
        Me.lblCarBrand2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarBrand2.TabIndex = 16
        Me.lblCarBrand2.Text = "Label1"
        '
        'EditCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(553, 613)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpCarDetails)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "EditCar"
        Me.Text = "UpdateCarInfo"
        Me.grpCarDetails.ResumeLayout(False)
        Me.grpCarDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents grpCarDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblCarModel As System.Windows.Forms.Label
    Friend WithEvents lblCarBrand As System.Windows.Forms.Label
    Friend WithEvents lblCarType As System.Windows.Forms.Label
    Friend WithEvents lblCarStatus As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDailyRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClear2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCarID2 As System.Windows.Forms.Label
    Friend WithEvents lblCarType2 As System.Windows.Forms.Label
    Friend WithEvents lblCarBrand2 As System.Windows.Forms.Label
    Friend WithEvents lblCarStatus2 As System.Windows.Forms.Label
End Class
