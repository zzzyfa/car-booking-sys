Imports System.Data
Imports System.Data.OleDb

Public Class RemoveCar
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub RemoveCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpCarDetails.Visible = False
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim cmdString As String
        Dim cmdInsert As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "delete from cartable where carmodel='" + txtSearch.Text + "';"

        cmdInsert.CommandText = cmdString
        'cmdInsert.CommandType = CommandType.Text
        cmdInsert.Connection = myConnection
        cmdInsert.ExecuteNonQuery()


        MessageBox.Show("Car removed.")

        myConnection.Close()

        'reset textbox
        txtSearch.Text = String.Empty
        lblCarBrand2.Text = String.Empty
        lblCarID2.Text = String.Empty
        lblCarModel2.Text = String.Empty
        lblCarStatus2.Text = String.Empty
        lblCarType2.Text = String.Empty

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim cmdString As String
        Dim cmdSearch As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "select * from cartable where carmodel = '" + txtSearch.Text + "';"
        cmdSearch.CommandText = cmdString
        cmdSearch.Connection = myConnection

        Dim myDataReaderOLEDB As OleDbDataReader = cmdSearch.ExecuteReader

        If myDataReaderOLEDB.Read Then
            grpCarDetails.Visible = True
            lblCarID2.Text = myDataReaderOLEDB.Item(0)
            lblCarStatus2.Text = myDataReaderOLEDB.Item(1)
            lblCarBrand2.Text = myDataReaderOLEDB.Item(2)
            lblCarType2.Text = myDataReaderOLEDB.Item(3)
            lblCarModel2.Text = myDataReaderOLEDB.Item(4)
        Else
            MessageBox.Show("Car Not Found.")
        End If
        myConnection.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub grpRemove_Enter(sender As Object, e As EventArgs) Handles grpCarDetails.Enter

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs)
        txtSearch.Text = String.Empty
        lblCarBrand2.Text = String.Empty
        lblCarID2.Text = String.Empty
        lblCarModel2.Text = String.Empty
        lblCarStatus2.Text = String.Empty
        lblCarType2.Text = String.Empty
    End Sub

    Private Sub lblCarType_Click(sender As Object, e As EventArgs) Handles lblCarType.Click

    End Sub
End Class