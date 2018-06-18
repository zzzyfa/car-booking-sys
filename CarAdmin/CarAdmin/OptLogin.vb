Imports System.Data.OleDb
Public Class OptLogin
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString 'to connect database'

        Dim cmd As OleDbCommand = New OleDbCommand("select * from Login where UserID='" _
                                                   & txtUserID.Text & "'and UserPassword='" _
                                                   & txtPass.Text & "'", myConnection) ' cmd is command, select *  means select all columns, if need specific column then type specific column names'
        myConnection.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader 'dr is the temporary table that shows what was asked for'
        Dim userFound As Boolean = False
        Dim userID As String = ""
        Dim userpassword As String = ""

        While dr.Read
            userFound = True
            userID = dr("userID").ToString
            userpassword = dr("userpassword").ToString
        End While

        If userFound = True Then
            OperatorMenu.ShowDialog()
        Else
            MessageBox.Show("Sorry, Username or password not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        myConnection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        HomeForm.Show()
    End Sub

    Private Sub OptLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class