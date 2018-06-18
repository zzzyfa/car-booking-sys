Public Class HomeForm

    Private Sub btnAdminLog_Click(sender As Object, e As EventArgs) Handles btnAdminLog.Click
        Me.Hide()
        AdminLogin.Show()
    End Sub

    Private Sub btnOpLog_Click(sender As Object, e As EventArgs) Handles btnOpLog.Click
        Me.Hide()
        OptLogin.Show()
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class