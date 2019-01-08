Imports DataObjects
Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class RePrintSlip
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Private con As New SqlConnection("Data Source=.;Initial Catalog=caneWeigh;User ID=farmer_;Password=password@123")
    Dim todayMonth As String

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Try
                Dim param() As SqlParameter = {New SqlParameter("@TransCode", Request.QueryString(0).ToString)}
                Dim retValue1 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_CertDetails_via_TransCode_Fetch", param).Tables(0).Rows(0)


                lblCertID.Text = retValue1.Table.Rows(0).Item("certCount")
                lblBin.Text = retValue1.Table.Rows(0).Item("binNumber").ToString.ToUpper
                lblClark.Text = retValue1.Table.Rows(0).Item("createdby").ToString.ToUpper
                lblDate.Text = retValue1.Table.Rows(0).Item("TimeIn")
                lblField.Text = retValue1.Table.Rows(0).Item("fieldName").ToString.ToUpper
                lblGross.Text = retValue1.Table.Rows(0).Item("grossWeight")
                lblLoadNum.Text = retValue1.Table.Rows(0).Item("code").ToString.ToUpper
                lblNet.Text = retValue1.Table.Rows(0).Item("NetWeight")
                lblOperator.Text = retValue1.Table.Rows(0).Item("DriverName").ToString.ToUpper
                lblRecClark.Text = retValue1.Table.Rows(0).Item("createdby").ToString.ToUpper
                lblShift.Text = retValue1.Table.Rows(0).Item("shiftName").ToString.ToUpper
                lblTare.Text = retValue1.Table.Rows(0).Item("TareWeight")
                lblTimeIn.Text = retValue1.Table.Rows(0).Item("TimeIn")
                lblTimeOut.Text = retValue1.Table.Rows(0).Item("TimeOut")
                lblTruckNum.Text = retValue1.Table.Rows(0).Item("TruckNumber").ToString.ToUpper
                lblZone.Text = retValue1.Table.Rows(0).Item("ZoneNumber")
                lblVariety.Text = retValue1.Table.Rows(0).Item("variety").ToString.ToUpper
                lblSpacing.Text = retValue1.Table.Rows(0).Item("spacing").ToString.ToUpper
                lblCycle.Text = retValue1.Table.Rows(0).Item("cropCycle").ToString.ToUpper
                lblTransType.Text = retValue1.Table.Rows(0).Item("TransType").ToString.ToUpper
                lblOG.Text = retValue1.Table.Rows(0).Item("OGFarmer").ToString.ToUpper
                lblEstate.Text = retValue1.Table.Rows(0).Item("name").ToString.ToUpper


                lblDay.Text = Today.Day().ToString()
                todayMonth = Today.Month().ToString()
                If todayMonth = "1" Then lblMonth.Text = "January"
                If todayMonth = "2" Then lblMonth.Text = "February"
                If todayMonth = "3" Then lblMonth.Text = "March"
                If todayMonth = "4" Then lblMonth.Text = "April"
                If todayMonth = "5" Then lblMonth.Text = "May"
                If todayMonth = "6" Then lblMonth.Text = "June"
                If todayMonth = "7" Then lblMonth.Text = "July"
                If todayMonth = "8" Then lblMonth.Text = "August"
                If todayMonth = "9" Then lblMonth.Text = "September"
                If todayMonth = "10" Then lblMonth.Text = "October"
                If todayMonth = "11" Then lblMonth.Text = "November"
                If todayMonth = "12" Then lblMonth.Text = "Decemcer"



                lblYear0.Text = Today.Year().ToString()



                'End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Protected Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Response.Redirect("dashboard.aspx")
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("dashboard.aspx")
    End Sub
End Class
