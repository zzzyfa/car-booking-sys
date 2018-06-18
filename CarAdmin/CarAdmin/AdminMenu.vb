Public Class AdminMenu

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpManageCar.Enter

    End Sub

    Private Sub btnCarAdd_Click(sender As Object, e As EventArgs) Handles btnCarAdd.Click
        AddCar.ShowDialog()
    End Sub

    Private Sub btnCarEdit_Click(sender As Object, e As EventArgs) Handles btnCarEdit.Click
        EditCar.ShowDialog()
    End Sub

    Private Sub btnCarRemove_Click(sender As Object, e As EventArgs) Handles btnCarRemove.Click
        RemoveCar.ShowDialog()

    End Sub

    Private Sub btnOpAdd_Click(sender As Object, e As EventArgs) Handles btnOpAdd.Click
        AddOperator.ShowDialog()

    End Sub

    Private Sub btnOpRemove_Click(sender As Object, e As EventArgs) Handles btnOpRemove.Click
        RemoveOperator.ShowDialog()

    End Sub

    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub btnOpEdit_Click(sender As Object, e As EventArgs) Handles btnOpEdit.Click
        EditOperator.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        HomeForm.ShowDialog()
    End Sub
End Class