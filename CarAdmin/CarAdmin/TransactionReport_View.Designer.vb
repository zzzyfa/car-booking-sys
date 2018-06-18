<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionReport_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionReport_View))
        Me.TransactionTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionDataset = New CarAdmin.TransactionDataset()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TransactionTableTableAdapter = New CarAdmin.TransactionDatasetTableAdapters.TransactionTableTableAdapter()
        Me.lblTransReport = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.TransactionTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionTableBindingSource
        '
        Me.TransactionTableBindingSource.DataMember = "TransactionTable"
        Me.TransactionTableBindingSource.DataSource = Me.TransactionDataset
        '
        'TransactionDataset
        '
        Me.TransactionDataset.DataSetName = "TransactionDataset"
        Me.TransactionDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TransactionTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CarAdmin.TransactionReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 82)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(863, 282)
        Me.ReportViewer1.TabIndex = 0
        '
        'TransactionTableTableAdapter
        '
        Me.TransactionTableTableAdapter.ClearBeforeFill = True
        '
        'lblTransReport
        '
        Me.lblTransReport.AutoSize = True
        Me.lblTransReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransReport.Location = New System.Drawing.Point(244, 37)
        Me.lblTransReport.Name = "lblTransReport"
        Me.lblTransReport.Size = New System.Drawing.Size(187, 24)
        Me.lblTransReport.TabIndex = 1
        Me.lblTransReport.Text = "Transaction Report"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(645, 386)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(25, 682)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'TransactionReport_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(887, 421)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTransReport)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TransactionReport_View"
        Me.Text = "Transaction Report"
        CType(Me.TransactionTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TransactionTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionDataset As CarAdmin.TransactionDataset
    Friend WithEvents TransactionTableTableAdapter As CarAdmin.TransactionDatasetTableAdapters.TransactionTableTableAdapter
    Friend WithEvents lblTransReport As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
