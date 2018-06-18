Public Class OperatorMenu

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        AddCustomer.ShowDialog()

    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        EditCustomer.ShowDialog()

    End Sub

    Private Sub btnCarBook_Click(sender As Object, e As EventArgs) Handles btnCarBook.Click
        SearchToAssign.ShowDialog()

    End Sub

    Private Sub btnCarRpt_Click(sender As Object, e As EventArgs) Handles btnCarRpt.Click
        CarReport_View.Show()
    End Sub

    Private Sub btnTranRpt_Click(sender As Object, e As EventArgs) Handles btnTranRpt.Click
        TransactionReport_View.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        HomeForm.ShowDialog()
    End Sub

    Private Sub OperatorMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class