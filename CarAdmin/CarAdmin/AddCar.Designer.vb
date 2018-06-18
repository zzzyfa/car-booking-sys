<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCar))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblCarStatus = New System.Windows.Forms.Label()
        Me.lblCarBrand = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.txtCarStatus = New System.Windows.Forms.TextBox()
        Me.txtCarBrand = New System.Windows.Forms.TextBox()
        Me.txtCarType = New System.Windows.Forms.TextBox()
        Me.txtCarMOdel = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtCarID = New System.Windows.Forms.TextBox()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.txtDailyRate = New System.Windows.Forms.TextBox()
        Me.lblDailyRate = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.s = New System.Windows.Forms.Label()
        Me.grpCarDetails = New System.Windows.Forms.GroupBox()
        Me.grpCarDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(130, 470)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblCarStatus
        '
        Me.lblCarStatus.AutoSize = True
        Me.lblCarStatus.Location = New System.Drawing.Point(51, 89)
        Me.lblCarStatus.Name = "lblCarStatus"
        Me.lblCarStatus.Size = New System.Drawing.Size(94, 17)
        Me.lblCarStatus.TabIndex = 1
        Me.lblCarStatus.Text = "Car Status    :"
        '
        'lblCarBrand
        '
        Me.lblCarBrand.AutoSize = True
        Me.lblCarBrand.Location = New System.Drawing.Point(51, 126)
        Me.lblCarBrand.Name = "lblCarBrand"
        Me.lblCarBrand.Size = New System.Drawing.Size(96, 17)
        Me.lblCarBrand.TabIndex = 2
        Me.lblCarBrand.Text = "Car Brand     :"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Location = New System.Drawing.Point(51, 163)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(94, 17)
        Me.lblCarType.TabIndex = 3
        Me.lblCarType.Text = "Car Type      :"
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Location = New System.Drawing.Point(51, 201)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(96, 17)
        Me.lblCarModel.TabIndex = 4
        Me.lblCarModel.Text = "Car Model     :"
        '
        'txtCarStatus
        '
        Me.txtCarStatus.Location = New System.Drawing.Point(153, 89)
        Me.txtCarStatus.Name = "txtCarStatus"
        Me.txtCarStatus.Size = New System.Drawing.Size(171, 22)
        Me.txtCarStatus.TabIndex = 5
        '
        'txtCarBrand
        '
        Me.txtCarBrand.Location = New System.Drawing.Point(153, 126)
        Me.txtCarBrand.Name = "txtCarBrand"
        Me.txtCarBrand.Size = New System.Drawing.Size(171, 22)
        Me.txtCarBrand.TabIndex = 6
        '
        'txtCarType
        '
        Me.txtCarType.Location = New System.Drawing.Point(153, 163)
        Me.txtCarType.Name = "txtCarType"
        Me.txtCarType.Size = New System.Drawing.Size(171, 22)
        Me.txtCarType.TabIndex = 7
        '
        'txtCarMOdel
        '
        Me.txtCarMOdel.Location = New System.Drawing.Point(153, 200)
        Me.txtCarMOdel.Name = "txtCarMOdel"
        Me.txtCarMOdel.Size = New System.Drawing.Size(171, 22)
        Me.txtCarMOdel.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(325, 470)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtCarID
        '
        Me.txtCarID.Location = New System.Drawing.Point(153, 53)
        Me.txtCarID.Name = "txtCarID"
        Me.txtCarID.Size = New System.Drawing.Size(171, 22)
        Me.txtCarID.TabIndex = 11
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Location = New System.Drawing.Point(51, 53)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(95, 17)
        Me.lblCarID.TabIndex = 10
        Me.lblCarID.Text = "Car ID           :"
        '
        'txtDailyRate
        '
        Me.txtDailyRate.Location = New System.Drawing.Point(153, 237)
        Me.txtDailyRate.Name = "txtDailyRate"
        Me.txtDailyRate.Size = New System.Drawing.Size(171, 22)
        Me.txtDailyRate.TabIndex = 13
        '
        'lblDailyRate
        '
        Me.lblDailyRate.AutoSize = True
        Me.lblDailyRate.Location = New System.Drawing.Point(51, 238)
        Me.lblDailyRate.Name = "lblDailyRate"
        Me.lblDailyRate.Size = New System.Drawing.Size(97, 17)
        Me.lblDailyRate.TabIndex = 12
        Me.lblDailyRate.Text = "Daily Rate     :"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(153, 274)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(171, 22)
        Me.txtRemarks.TabIndex = 15
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(51, 275)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(97, 17)
        Me.lblRemarks.TabIndex = 14
        Me.lblRemarks.Text = "Remark         :"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(229, 470)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        's
        '
        Me.s.AutoSize = True
        Me.s.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s.Location = New System.Drawing.Point(193, 38)
        Me.s.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(129, 25)
        Me.s.TabIndex = 17
        Me.s.Text = "Add New Car"
        '
        'grpCarDetails
        '
        Me.grpCarDetails.Controls.Add(Me.txtCarType)
        Me.grpCarDetails.Controls.Add(Me.lblCarStatus)
        Me.grpCarDetails.Controls.Add(Me.lblCarBrand)
        Me.grpCarDetails.Controls.Add(Me.txtRemarks)
        Me.grpCarDetails.Controls.Add(Me.lblCarType)
        Me.grpCarDetails.Controls.Add(Me.lblRemarks)
        Me.grpCarDetails.Controls.Add(Me.lblCarModel)
        Me.grpCarDetails.Controls.Add(Me.txtDailyRate)
        Me.grpCarDetails.Controls.Add(Me.txtCarStatus)
        Me.grpCarDetails.Controls.Add(Me.lblDailyRate)
        Me.grpCarDetails.Controls.Add(Me.txtCarBrand)
        Me.grpCarDetails.Controls.Add(Me.txtCarID)
        Me.grpCarDetails.Controls.Add(Me.txtCarMOdel)
        Me.grpCarDetails.Controls.Add(Me.lblCarID)
        Me.grpCarDetails.Location = New System.Drawing.Point(60, 89)
        Me.grpCarDetails.Name = "grpCarDetails"
        Me.grpCarDetails.Size = New System.Drawing.Size(401, 341)
        Me.grpCarDetails.TabIndex = 18
        Me.grpCarDetails.TabStop = False
        Me.grpCarDetails.Text = "Car Details"
        '
        'AddCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(515, 539)
        Me.Controls.Add(Me.grpCarDetails)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "AddCar"
        Me.Text = "Add Cars"
        Me.grpCarDetails.ResumeLayout(False)
        Me.grpCarDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblCarStatus As System.Windows.Forms.Label
    Friend WithEvents lblCarBrand As System.Windows.Forms.Label
    Friend WithEvents lblCarType As System.Windows.Forms.Label
    Friend WithEvents lblCarModel As System.Windows.Forms.Label
    Friend WithEvents txtCarStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtCarBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtCarType As System.Windows.Forms.TextBox
    Friend WithEvents txtCarMOdel As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtCarID As System.Windows.Forms.TextBox
    Friend WithEvents lblCarID As System.Windows.Forms.Label
    Friend WithEvents txtDailyRate As System.Windows.Forms.TextBox
    Friend WithEvents lblDailyRate As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents s As System.Windows.Forms.Label
    Friend WithEvents grpCarDetails As System.Windows.Forms.GroupBox

End Class
