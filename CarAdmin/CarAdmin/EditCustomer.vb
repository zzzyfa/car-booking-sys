Imports System.Data
Imports System.Data.OleDb
Public Class EditCustomer
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub lblFirstNameResult_Click(sender As Object, e As EventArgs) Handles lblFirstNameResult.Click

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim cmdString As String
        Dim cmdSearch As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()


        cmdString = "select * from customertable where custfirstname = '" + txtSearch.Text + "';"
        cmdSearch.CommandText = cmdString
        cmdSearch.Connection = myConnection

        Dim myDataReaderOLEDB As OleDbDataReader = cmdSearch.ExecuteReader

        If myDataReaderOLEDB.Read Then
            grpCustDetails.Visible = True
            lblCustID.Text = myDataReaderOLEDB(0)
            lblFirstNameResult.Text = myDataReaderOLEDB.Item(1)
            txtLastNameResult.Text = myDataReaderOLEDB.Item(2)
            txtContactNumber.Text = myDataReaderOLEDB.Item(3)
            txtEmailAddress.Text = myDataReaderOLEDB.Item(4)
            txtFullAddress.Text = myDataReaderOLEDB.Item(5)

        Else
            MessageBox.Show("Customer Record Not Found")
        End If
        myConnection.Close()




    End Sub

    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpCustDetails.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
          Dim cmdString As String
        Dim cmdUpdate As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()


        cmdString = "update customertable set custlastname='" + txtLastNameResult.Text + "'," _
            + "custcontnumber='" + txtContactNumber.Text + "'," _
            + "custemailadd='" + txtEmailAddress.Text + "'," + "custadd='" + txtFullAddress.Text + "' where custfirstname='" + txtSearch.Text + "';"



        cmdUpdate.CommandText = cmdString
        'cmdUpdate.CommandType = CommandType.Text
        cmdUpdate.Connection = myConnection
        cmdUpdate.ExecuteNonQuery()

        MessageBox.Show("Customer Record Has Been Updated Successfully")

        myConnection.Close()

        lblCustID.Text = String.Empty
        lblFirstNameResult.Text = String.Empty
        txtLastNameResult.Text = String.Empty
        txtContactNumber.Text = String.Empty
        txtEmailAddress.Text = String.Empty
        txtFullAddress.Text = String.Empty
        txtRemarksResult.Text = String.Empty

        grpCustDetails.Visible = False
    End Sub

    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = String.Empty
    End Sub

    Private Sub lblFirstName_Click(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        lblCustID.Text = String.Empty

        txtLastNameResult.Text = String.Empty
        txtContactNumber.Text = String.Empty
        txtEmailAddress.Text = String.Empty
        txtFullAddress.Text = String.Empty
        txtRemarksResult.Text = String.Empty
    End Sub
End Class