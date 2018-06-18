Imports System.Data
Imports System.Data.OleDb

Public Class RemoveOperator
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub RemoveOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            lblUserID2.Text = myDataReaderOLEDB.Item(0)
            lblUserType2.Text = myDataReaderOLEDB.Item(2)
            lblUserName2.Text = myDataReaderOLEDB.Item(3)
            lblContNumb2.Text = myDataReaderOLEDB.Item(4)

            lblEmailAdd2.Text = myDataReaderOLEDB.Item(5)

        Else
            MessageBox.Show("User Not Found.")
        End If
        myConnection.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim cmdString As String
        Dim cmdInsert As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "delete from operatortable where userfullname='" + txtSearch.Text + "';"

        cmdInsert.CommandText = cmdString
        'cmdInsert.CommandType = CommandType.Text
        cmdInsert.Connection = myConnection
        cmdInsert.ExecuteNonQuery()


        MessageBox.Show("Operator removed.")

        myConnection.Close()

        txtSearch.Text = String.Empty
        lblUserName2.Text = String.Empty
        lblUserID2.Text = String.Empty
        lblContNumb2.Text = String.Empty
        lblEmailAdd2.Text = String.Empty
        lblUserType2.Text = String.Empty

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub grpRemoveOp_Enter(sender As Object, e As EventArgs) Handles grpOpDetails.Enter

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs)
        txtSearch.Text = String.Empty
        lblUserName2.Text = String.Empty
        lblUserID2.Text = String.Empty
        lblContNumb2.Text = String.Empty
        lblEmailAdd2.Text = String.Empty
        lblUserType2.Text = String.Empty
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class