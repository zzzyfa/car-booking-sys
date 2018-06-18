<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoveCar))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grpCarDetails = New System.Windows.Forms.GroupBox()
        Me.lblCarModel2 = New System.Windows.Forms.Label()
        Me.lblCarBrand2 = New System.Windows.Forms.Label()
        Me.lblCarType2 = New System.Windows.Forms.Label()
        Me.lblCarStatus2 = New System.Windows.Forms.Label()
        Me.lblCarID2 = New System.Windows.Forms.Label()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.lblCarBrand = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblCarStatus = New System.Windows.Forms.Label()
        Me.lblCarID = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpCarDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(230, 238)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(85, 34)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(121, 94)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(226, 22)
        Me.txtSearch.TabIndex = 1
        '
        'grpCarDetails
        '
        Me.grpCarDetails.Controls.Add(Me.lblCarModel2)
        Me.grpCarDetails.Controls.Add(Me.lblCarBrand2)
        Me.grpCarDetails.Controls.Add(Me.lblCarType2)
        Me.grpCarDetails.Controls.Add(Me.lblCarStatus2)
        Me.grpCarDetails.Controls.Add(Me.lblCarID2)
        Me.grpCarDetails.Controls.Add(Me.lblCarModel)
        Me.grpCarDetails.Controls.Add(Me.lblCarBrand)
        Me.grpCarDetails.Controls.Add(Me.lblCarType)
        Me.grpCarDetails.Controls.Add(Me.btnRemove)
        Me.grpCarDetails.Controls.Add(Me.lblCarStatus)
        Me.grpCarDetails.Controls.Add(Me.lblCarID)
        Me.grpCarDetails.Location = New System.Drawing.Point(103, 155)
        Me.grpCarDetails.Name = "grpCarDetails"
        Me.grpCarDetails.Size = New System.Drawing.Size(328, 287)
        Me.grpCarDetails.TabIndex = 3
        Me.grpCarDetails.TabStop = False
        Me.grpCarDetails.Text = "Car Details"
        '
        'lblCarModel2
        '
        Me.lblCarModel2.AutoSize = True
        Me.lblCarModel2.Location = New System.Drawing.Point(165, 48)
        Me.lblCarModel2.Name = "lblCarModel2"
        Me.lblCarModel2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarModel2.TabIndex = 14
        Me.lblCarModel2.Text = "Label5"
        '
        'lblCarBrand2
        '
        Me.lblCarBrand2.AutoSize = True
        Me.lblCarBrand2.Location = New System.Drawing.Point(165, 151)
        Me.lblCarBrand2.Name = "lblCarBrand2"
        Me.lblCarBrand2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarBrand2.TabIndex = 13
        Me.lblCarBrand2.Text = "Label3"
        '
        'lblCarType2
        '
        Me.lblCarType2.AutoSize = True
        Me.lblCarType2.Location = New System.Drawing.Point(165, 187)
        Me.lblCarType2.Name = "lblCarType2"
        Me.lblCarType2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarType2.TabIndex = 12
        Me.lblCarType2.Text = "Label4"
        '
        'lblCarStatus2
        '
        Me.lblCarStatus2.AutoSize = True
        Me.lblCarStatus2.Location = New System.Drawing.Point(165, 115)
        Me.lblCarStatus2.Name = "lblCarStatus2"
        Me.lblCarStatus2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarStatus2.TabIndex = 11
        Me.lblCarStatus2.Text = "Label2"
        '
        'lblCarID2
        '
        Me.lblCarID2.AutoSize = True
        Me.lblCarID2.Location = New System.Drawing.Point(165, 81)
        Me.lblCarID2.Name = "lblCarID2"
        Me.lblCarID2.Size = New System.Drawing.Size(51, 17)
        Me.lblCarID2.TabIndex = 10
        Me.lblCarID2.Text = "Label1"
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Location = New System.Drawing.Point(52, 48)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(108, 17)
        Me.lblCarModel.TabIndex = 9
        Me.lblCarModel.Text = "Car Model        :"
        '
        'lblCarBrand
        '
        Me.lblCarBrand.AutoSize = True
        Me.lblCarBrand.Location = New System.Drawing.Point(52, 151)
        Me.lblCarBrand.Name = "lblCarBrand"
        Me.lblCarBrand.Size = New System.Drawing.Size(108, 17)
        Me.lblCarBrand.TabIndex = 3
        Me.lblCarBrand.Text = "Car Brand        :"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Location = New System.Drawing.Point(52, 187)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(106, 17)
        Me.lblCarType.TabIndex = 2
        Me.lblCarType.Text = "Car Type         :"
        '
        'lblCarStatus
        '
        Me.lblCarStatus.AutoSize = True
        Me.lblCarStatus.Location = New System.Drawing.Point(52, 115)
        Me.lblCarStatus.Name = "lblCarStatus"
        Me.lblCarStatus.Size = New System.Drawing.Size(106, 17)
        Me.lblCarStatus.TabIndex = 1
        Me.lblCarStatus.Text = "Car Status       :"
        '
        'lblCarID
        '
        Me.lblCarID.AutoSize = True
        Me.lblCarID.Location = New System.Drawing.Point(52, 81)
        Me.lblCarID.Name = "lblCarID"
        Me.lblCarID.Size = New System.Drawing.Size(107, 17)
        Me.lblCarID.TabIndex = 0
        Me.lblCarID.Text = "Car ID              :"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(423, 453)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(356, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 32)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Remove Car"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(438, 89)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 32)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(27, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Car Model    :"
        '
        'RemoveCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 501)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.grpCarDetails)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "RemoveCar"
        Me.Text = "RemoveCar"
        Me.grpCarDetails.ResumeLayout(False)
        Me.grpCarDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents grpCarDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCarBrand As System.Windows.Forms.Label
    Friend WithEvents lblCarType As System.Windows.Forms.Label
    Friend WithEvents lblCarStatus As System.Windows.Forms.Label
    Friend WithEvents lblCarID As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblCarModel2 As System.Windows.Forms.Label
    Friend WithEvents lblCarBrand2 As System.Windows.Forms.Label
    Friend WithEvents lblCarType2 As System.Windows.Forms.Label
    Friend WithEvents lblCarStatus2 As System.Windows.Forms.Label
    Friend WithEvents lblCarID2 As System.Windows.Forms.Label
    Friend WithEvents lblCarModel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
