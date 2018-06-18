Imports System.Data
Imports System.Data.OleDb

Public Class AddCar
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strDailyRate As String
        Dim strCarRemark As String
        Dim cmdString As String
        Dim cmdInsert As New OleDbCommand
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

        cmdString = "insert into cartable (CarStatus, CarBrand, CarType, CarID, CarModel, CarDailyRate, CarRemark) values ('" _
            + txtCarStatus.Text + "','" + txtCarBrand.Text + "','" + txtCarType.Text + "','" + txtCarID.Text + "','" + txtCarMOdel.Text + "','" + txtDailyRate.Text + "','" + txtRemarks.Text + "');"

        cmdInsert.CommandText = cmdString
        cmdInsert.Connection = myConnection
        cmdInsert.ExecuteNonQuery()

        MessageBox.Show("Car Added Successfully")

        myConnection.Close()

        txtCarID.Text = String.Empty
        txtCarStatus.Text = String.Empty
        txtCarBrand.Text = String.Empty
        txtCarType.Text = String.Empty
        txtCarMOdel.Text = String.Empty
        txtDailyRate.Text = String.Empty
        txtRemarks.Text = String.Empty


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCarID.Text = String.Empty
        txtCarStatus.Text = String.Empty
        txtCarBrand.Text = String.Empty
        txtCarMOdel.Text = String.Empty
        txtCarType.Text = String.Empty
        txtDailyRate.Text = String.Empty
        txtRemarks.Text = String.Empty

    End Sub
End Class
