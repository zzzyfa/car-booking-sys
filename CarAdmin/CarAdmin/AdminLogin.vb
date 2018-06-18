Imports System.Data.OleDb
Public Class AdminLogin
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblPass_Click(sender As Object, e As EventArgs) Handles lblPass.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString

        Dim cmd As OleDbCommand = New OleDbCommand("select * from Login where UserID='" _
                                                   & txtUserID.Text & "'and UserPassword='" _
                                                   & txtPass.Text & "'", myConnection)
        myConnection.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        Dim userID As String = ""
        Dim userpassword As String = ""

        While dr.Read
            userFound = True
            userID = dr("userID").ToString
            userpassword = dr("userpassword").ToString
        End While

        If userFound = True Then
            AdminMenu.ShowDialog()
        Else
            MessageBox.Show("Sorry, Username or password not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        myConnection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        HomeForm.Show()
    End Sub
End Class