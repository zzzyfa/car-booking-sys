Imports System.Data
Imports System.Data.OleDb

Public Class EditCar
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub UpdateCarInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpCarDetails.Visible = False

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
            lblCarModel.Text = myDataReaderOLEDB.Item(4)
            txtDailyRate.Text = myDataReaderOLEDB.Item(5)

        Else
            MessageBox.Show("Car Not Found")
        End If
        myConnection.Close()

        'reset textbox

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmdString As String
        Dim strDailyRate As String
        Dim strCarRemark As String

        Dim cmdUpdate As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Shaw\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        If txtRemarks.Text = "" Then
            strCarRemark = "NA"
        Else
            strCarRemark = txtRemarks.Text
        End If
        
        strDailyRate = CStr(txtDailyRate.Text)

        cmdString = "update cartable set cardailyrate=" + txtDailyRate.Text + "," _
        + "carremark='" + strCarRemark + "' where carmodel = '" + txtSearch.Text + "';"

        MessageBox.Show(cmdString)
        cmdUpdate.CommandText = cmdString
        cmdUpdate.Connection = myConnection

        cmdUpdate.ExecuteNonQuery()
        MessageBox.Show("Updated Successfully")
        cmdUpdate.Dispose()
        myConnection.Close()

        txtSearch.Text = String.Empty
        lblCarModel.Text = String.Empty
        lblCarBrand2.Text = String.Empty
        lblCarStatus2.Text = String.Empty
        lblCarType2.Text = String.Empty
        lblCarID2.Text = String.Empty
        txtDailyRate.Text = String.Empty
        txtRemarks.Text = String.Empty
        grpCarDetails.Visible = False

    End Sub
  
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = String.Empty
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        txtSearch.Text = String.Empty

        lblCarBrand2.Text = String.Empty
        lblCarStatus2.Text = String.Empty
        lblCarType2.Text = String.Empty
        lblCarID2.Text = String.Empty
        txtDailyRate.Text = String.Empty
        txtRemarks.Text = String.Empty
    End Sub
End Class