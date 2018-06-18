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
    Dim CarID As String
    Dim Deposit As Double
    Dim Status As String
    Dim TotalAmount As Double
    Dim Subtotal As Double
    Dim TaxAmount As Double
    Dim CustomerID As String
    Dim CarModel As String
    Dim Remarks As String



    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim cmdString As String
        Dim cmdSearch As New OleDbCommand
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "c:\Users\user_PC\dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

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
        myConnection.Close()

    End Sub


    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles BtnBook.Click
        Dim cmdString As String
        Dim cmdInsert As New OleDbCommand
        Dim strTotalPrice As String
        Dim strDeposit As String
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\user_PC\Dropbox\BIT_Shared Folder\Semester 5\VBNET\VB_DB.accdb"

        connString = provider + dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()


        CustomerID = lblCustomerIDResult.Text
        CarID = lblCarID.Text
        CarModel = cboCarModel.Text
        dtCheckIn = dtCheckInDate.Value.ToShortDateString
        dtCheckOut = dtCheckOutDate.Value.ToShortDateString
        strTotalPrice = CStr(TotalAmount)
        strDeposit = CStr(Deposit)

        Status = lblStatus.Text

        If txtRemarks.Text = "" Then
            Remarks = "NA"
        Else
            Remarks = txtRemarks.Text
        End If


    

        cmdString = "insert into TransactionTable (CustID, CarID, CarModel, CheckOutDate, CheckInDate, Cost, Deposit, Status, Remark)" _
                  + " values('" + CustomerID + "','" + CarID + "','" + CarModel + "','" + dtCheckIn + "','" + dtCheckOut + "'," + strTotalPrice + "," + strDeposit + ",'" + Status + "','" + Remarks + "');"

        cmdInsert.CommandText = cmdString
        cmdInsert.CommandType = CommandType.Text
        cmdInsert.Connection = myConnection
        cmdInsert.ExecuteNonQuery()

        MessageBox.Show("Booking Successful")

        myConnection.Close()



      

    End Sub

    Private Sub cboCarModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarModel.SelectedIndexChanged
       
        

        If cboCarModel.SelectedItem = "Honda HRV" Then
            CarPrice = 150
            CarID = "H344D"
            Deposit = 200
            TaxAmount = (0.06 * (CarPrice + Deposit))
            Subtotal = (CarPrice + Deposit)

        ElseIf cboCarModel.SelectedItem = "Honda Accord" Then
            CarPrice = 200
            CarID = "JXP23L"
            Deposit = 200
            TaxAmount = (0.06 * (CarPrice + Deposit))
            Subtotal = (CarPrice + Deposit)

        ElseIf cboCarModel.SelectedItem = "Proton Suprima" Then
            CarPrice = 350
            CarID = "KLO097NN"
            Deposit = 200
            TaxAmount = (0.06 * (CarPrice + Deposit))
            Subtotal = (CarPrice + Deposit)

        ElseIf cboCarModel.SelectedItem = "Audi Q7" Then
            CarPrice = 360
            CarID = "WAN9977N"
            Deposit = 200
            TaxAmount = (0.06 * (CarPrice + Deposit))
            Subtotal = (CarPrice + Deposit)

        ElseIf cboCarModel.SelectedItem = "Hyundai Tucson" Then
            CarPrice = 155
            CarID = "WXY123Z"
            Deposit = 200
            TaxAmount = (0.06 * (CarPrice + Deposit))
            Subtotal = (CarPrice + Deposit)

        End If

        lblPriceResult.Text = "RM" & CarPrice.ToString
        LblDepositCost.Text = "RM" & Deposit.ToString
        lblCarID.Text = CarID
        lblGstResult.Text = "RM" & TaxAmount.ToString


    End Sub

    Private Sub btnViewTotal_Click(sender As Object, e As EventArgs) Handles btnViewTotal.Click
        dtCheckIn = Convert.ToDateTime(dtCheckInDate.Text)
        dtCheckOut = Convert.ToDateTime(dtCheckOutDate.Text)
        duration = dtCheckOut.Subtract(dtCheckIn)


        CarPrice = 0

        If Convert.ToInt32(duration.Days) > 0 Then
            lblduration.Text = (CStr(Convert.ToInt32(duration.Days)) & "Day(s)")
            Status = "Pending"
            TotalAmount = (duration.Days * (Subtotal) + TaxAmount)

        Else
            MessageBox.Show("Invalid Input")

        End If

        lblStatus.Text = Status
        lblTotal.Text = "RM" & TotalAmount.ToString


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AssignACar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class