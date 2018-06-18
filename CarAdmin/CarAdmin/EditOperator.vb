Imports System.Data
Imports System.Data.OleDb
Public Class EditOperator
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub EditOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpOpDetails.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim cmdString As String
        Dim cmdSearch As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()


        cmdString = "select * from operatortable where userfullname = '" + txtSearch.Text + "';"
        cmdSearch.CommandText = cmdString
        cmdSearch.Connection = myConnection

        Dim myDataReaderOLEDB As OleDbDataReader = cmdSearch.ExecuteReader

        If myDataReaderOLEDB.Read Then
            grpOpDetails.Visible = True
            lblUserID2.Text = myDataReaderOLEDB(0)
            lblFullNameResult.Text = myDataReaderOLEDB.Item(3)
            lblUserPw2.Text = myDataReaderOLEDB.Item(1)
            txtContactNumber.Text = myDataReaderOLEDB.Item(4)
            txtEmailAddress.Text = myDataReaderOLEDB.Item(5)


        Else
            MessageBox.Show("Operator Not Found")
        End If
        myConnection.Close()

    End Sub

    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = String.Empty

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmdString As String
        Dim cmdUpdate As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "update operatortable set usercontnumber='" + txtContactNumber.Text + "'," _
            + "useremailadd='" + txtEmailAddress.Text + "'," _
               + "remark='" + txtRemarksResult.Text + "' where userfullName='" + txtSearch.Text + "';"


        cmdUpdate.CommandText = cmdString
        cmdUpdate.Connection = myConnection

        cmdUpdate.ExecuteNonQuery()
        MessageBox.Show("Updated Successfully")
        cmdUpdate.Dispose()
        myConnection.Close()

        lblUserID2.Text = String.Empty
        lblFullNameResult.Text = String.Empty
        lblUserPw2.Text = String.Empty
        txtContactNumber.Text = String.Empty
        txtEmailAddress.Text = String.Empty

        txtRemarksResult.Text = String.Empty


        grpOpDetails.Visible = False

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click


        lblUserPw2.Text = String.Empty
        txtContactNumber.Text = String.Empty
        txtEmailAddress.Text = String.Empty

        txtRemarksResult.Text = String.Empty

    End Sub

    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        Me.Close()
    End Sub
End Class