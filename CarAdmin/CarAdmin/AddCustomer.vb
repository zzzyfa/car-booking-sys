Imports System.Data
Imports System.Data.OleDb
Public Class AddCustomer
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmdString As String
        Dim cmdInsert As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "insert into CustomerTable (CustomerID, CustFirstName, CustLastName, CustContNumber, CustEmailAdd, CustAdd, CustRemark) values ('" _
    + txtCustID.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtContNumber.Text + "','" + txtEmailAdd.Text + "','" + txtEmailAdd.Text + "','" + txtRemarks.Text + "');"

        cmdInsert.CommandText = cmdString
        'cmdInsert.CommandType = CommandType.Text
        cmdInsert.Connection = myConnection
        cmdInsert.ExecuteNonQuery()

        MessageBox.Show("Customer Added Successfully")

        myConnection.Close()

        txtCustID.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtContNumber.Text = String.Empty
        txtEmailAdd.Text = String.Empty
        txtFullAdd.Text = String.Empty
        txtRemarks.Text = String.Empty

    End Sub

    Private Sub OperatorAddNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustID.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtContNumber.Text = String.Empty
        txtEmailAdd.Text = String.Empty
        txtFullAdd.Text = String.Empty
        txtRemarks.Text = String.Empty
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblFirstName_Click(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub txtRemarks_TextChanged(sender As Object, e As EventArgs) Handles txtRemarks.TextChanged

    End Sub
End Class