Imports System.Data
Imports System.Data.OleDb
Public Class SearchToAssign
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Dim cmdString As String
        Dim cmdSearch As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "select * from CustomerTable where CustFirstName  = '" + txtSearch2.Text + "';"
        cmdSearch.CommandText = cmdString
        cmdSearch.Connection = myConnection

        Dim myDataReaderOLEDB As OleDbDataReader = cmdSearch.ExecuteReader

        If myDataReaderOLEDB.Read Then
            grpCustDetails2.Visible = True
            lblCustomerIDResult.Text = myDataReaderOLEDB.Item(0)
            customerID = myDataReaderOLEDB.Item(0)
            lblFirstNameResult2.Text = myDataReaderOLEDB.Item(1)
            custfirstname = myDataReaderOLEDB.Item(1)
            lblLastNameResult2.Text = myDataReaderOLEDB.Item(2)
            custlastname = myDataReaderOLEDB.Item(2)
            lblContactNumberResult2.Text = myDataReaderOLEDB.Item(3)


        Else
            MessageBox.Show("Customer Not Found")
        End If
        myConnection.Close()



    End Sub

    Private Sub lblCustomerID_Click(sender As Object, e As EventArgs) Handles lblCustomerID.Click

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        txtSearch2.Text = String.Empty
    End Sub

    Private Sub btnAssignACar_Click(sender As Object, e As EventArgs) Handles btnAssignACar.Click
        AssignACar.ShowDialog()

    End Sub

    Private Sub SearchToAssign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpCustDetails2.Visible = False
    End Sub
End Class