Imports System.Data
Imports System.Data.OleDb
Public Class AssignACar
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim dtCheckIn As Date
    Dim dtCheckOut As Date
    Dim duration As TimeSpan
    Dim CarPrice As Double



    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim cmdString As String
        Dim cmdSearch As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "c:\users\user\dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "select customerID, custfirstname, custlastname from CustomerTable where CustFirstName  = 'sarah' "
        cmdSearch.CommandText = cmdString
        cmdSearch.Connection = myConnection

        Dim myDataReaderOLEDB As OleDbDataReader = cmdSearch.ExecuteReader

        If myDataReaderOLEDB.Read Then
            grpCustDetails2.Visible = True
            lblCustomerIDResult.Text = myDataReaderOLEDB.Item(0)
            lblFirstNameResult2.Text = myDataReaderOLEDB.Item(1)
            lblLastNameResult2.Text = myDataReaderOLEDB.Item(2)
        End If

    End Sub

    Private Sub AssignACar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdString As String
        Dim cmdSearch As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "c:\users\user\dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        cmdString = "select * from CarTable where carstatus  = 'available'"
        cmdSearch.CommandText = cmdString
        cmdSearch.Connection = myConnection

        Dim myDataReaderOLEDB As OleDbDataReader = cmdSearch.ExecuteReader

        If myDataReaderOLEDB.HasRows = True Then
            While myDataReaderOLEDB.Read()
                cboCarModel.Items.Add(myDataReaderOLEDB.GetString(4))
            End While
        End If

        If myDataReaderOLEDB.Read Then
            While myDataReaderOLEDB.Read()
                lblCarID.Text = myDataReaderOLEDB.GetString(1)
            End While
        End If
        myConnection.Close()

       




    End Sub

    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles BtnBook.Click
        Dim cmdString As String
        Dim cmdInsert As New OleDbCommand
        Dim strCheckInDate As String
        Dim strCheckOutDate As String
        Dim strCustomerID As String
        Dim strCarID As String
        Dim strCarPrice As String
        Dim strDeposit As String
        Dim strStatus As String

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "c:\users\user\dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        strCheckInDate = dtCheckIn.ToShortDateString
        strCheckOutDate = dtCheckOut.ToShortDateString
        strCustomerID = CStr(lblCustomerIDResult.Text)
        strCarID = CStr(lblCarID.Text)
        strCarPrice = CStr(CarPrice)
        strDeposit = CStr(LblDepositCost.Text)
        strStatus = CStr(lblStatus.Text)

        cmdString = "insert into transactions (CustID, CarID, CarModel, CheckOutDate, CheckInDate, Cost, Deposit, Status)" _
                 + "values(" + strCustomerID + ",'" + strCarID + ",'" + cboCarModel.Text + " ','" + strCheckOutDate + "','" + strCheckInDate + "'," + strCarPrice + "," + strDeposit + "," + strStatus + ");"
        MessageBox.Show(cmdString)
        cmdInsert.CommandText = cmdString
        'cmdInsert.CommandType = CommandType.Text
        cmdInsert.Connection = myConnection
        cmdInsert.ExecuteNonQuery()

        MessageBox.Show("Booking saved")

        myConnection.Close()



      

    End Sub

    Private Sub cboCarModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarModel.SelectedIndexChanged
       



    End Sub

    Private Sub btnViewTotal_Click(sender As Object, e As EventArgs) Handles btnViewTotal.Click
        dtCheckIn = Convert.ToDateTime(dtCheckInDate.Text)
        dtCheckOut = Convert.ToDateTime(dtCheckOutDate.Text)
        duration = dtCheckOut.Subtract(dtCheckIn)


        CarPrice = 0

        If Convert.ToInt32(duration.Days) > 0 Then
            lblduration.Text = (CStr(Convert.ToInt32(duration.Days)) & "Day(s)")
            CarPrice = CDbl(lblduration.Text) * CDbl(lblPriceResult.Text) + CDbl(LblDepositCost.Text)
            ' lblTotal.Text = "RM " + CarPrice.ToString("n2")
            'lblStatus.Text = "Pending"
        Else
            MessageBox.Show("Invalid Input")

        End If

    End Sub
End Class