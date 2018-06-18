<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarReport_View
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarReport_View))
        Me.CarTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarReport = New CarAdmin.CarReport()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CarTableTableAdapter = New CarAdmin.CarReportTableAdapters.CarTableTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.CarTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarTableBindingSource
        '
        Me.CarTableBindingSource.DataMember = "CarTable"
        Me.CarTableBindingSource.DataSource = Me.CarReport
        '
        'CarReport
        '
        Me.CarReport.DataSetName = "CarReport"
        Me.CarReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CarTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CarAdmin.ReportCar.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 92)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(691, 291)
        Me.ReportViewer1.TabIndex = 0
        '
        'CarTableTableAdapter
        '
        Me.CarTableTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Car Report"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(628, 404)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'CarReport_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(715, 439)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CarReport_View"
        Me.Text = "CarReport_View"
        CType(Me.CarTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CarTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CarReport As CarAdmin.CarReport
    Friend WithEvents CarTableTableAdapter As CarAdmin.CarReportTableAdapters.CarTableTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
