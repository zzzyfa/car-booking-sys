Public Class TransactionReport_View

    Private Sub TransactionReport_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransactionDataset.TransactionTable' table. You can move, or remove it, as needed.
        Me.TransactionTableTableAdapter.Fill(Me.TransactionDataset.TransactionTable)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class