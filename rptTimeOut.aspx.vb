Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WebForms
Imports Microsoft.ApplicationBlocks.Data
Partial Class rptTimeOut
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

        txtRole.Text = Session("Role")
        txtUsername.Text = Session("User")

        'txtDepartment.Text = Session("Department")

        If Not IsPostBack Then

            'Try


            'Catch ex As Exception

            'End Try



        End If
    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            ReportViewer1.Visible = True

            Dim thisDataSet As New DataSet

            Dim params() As SqlParameter = {New SqlParameter("@DateFrom", txtFrom.Text),
                                           New SqlParameter("@DateTo", txtTo.Text)}
            thisDataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_Timeout_range_Fetch", params)

            Dim ds As ReportDataSource = New ReportDataSource("DataSetTimeOutRange", thisDataSet.Tables(0))

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ds)
            If thisDataSet.Tables(0).Rows.Count = 0 Then
                ReportViewer1.Visible = False

                lblError.Text = "Sorry, No Records Available For Selected Date Range"

            Else
                lblError.Text = ""
            End If

            ReportViewer1.LocalReport.Refresh()

        Catch ex As Exception

        End Try
    End Sub
End Class
