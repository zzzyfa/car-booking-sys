Public Class CarReport_View

    Private Sub CarReport_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CarTableTableAdapter.Fill(Me.CarReport.CarTable)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class