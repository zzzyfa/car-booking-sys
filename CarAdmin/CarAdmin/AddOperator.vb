Imports System.Data
Imports System.Data.OleDb

Public Class AddOperator
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub AddOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmdString As String
        Dim cmdInsert As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "insert into operatortable (UserID, UserPassword, UserType, UserFullName, UserContNumber, UserEmailAdd, Remark) values ('" _
            + txtUserID.Text + "','" + txtUserPw.Text + "','" + lblOperator.Text + "','" + txtUserName.Text + "','" + txtContNumb.Text + "','" + txtEmailAdd.Text + "','" + txtRemark.Text + "');"

        cmdInsert.CommandText = cmdString
        'cmdInsert.CommandType = CommandType.Text
        cmdInsert.Connection = myConnection
        cmdInsert.ExecuteNonQuery()


        MessageBox.Show("Operator Added Successfully")

        myConnection.Close()

        'reset textbox
        txtUserID.Text = String.Empty
        txtUserPw.Text = String.Empty
        txtContNumb.Text = String.Empty
        txtUserName.Text = String.Empty
        txtEmailAdd.Text = String.Empty
        txtRemark.Text = String.Empty

    End Sub

    Private Sub lblUserID_Click(sender As Object, e As EventArgs) Handles lblUserID.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserID.Text = String.Empty
        txtUserPw.Text = String.Empty
        txtUserName.Text = String.Empty
        txtContNumb.Text = String.Empty
        txtEmailAdd.Text = String.Empty
        txtRemark.Text = String.Empty

    End Sub
End Class