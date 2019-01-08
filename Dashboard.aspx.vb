Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class Dashboard
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

        Dim params1() As SqlParameter = {New SqlParameter("@UserName", Session("User"))}

        Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_logged_user_Fetch", params1).Tables(0).Rows(0)
        'Session("AdminOk") = True
        lblLoggedUser.Text = retValue3.Table.Rows(0).Item("fullname")



        Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_User_count_Fetch").Tables(0).Rows(0)

        If retValue Is Nothing Then
            lblCount.Text = "0"
        Else

            lblCount.Text = retValue.Table.Rows(0).Item("Users")
        End If

        Dim retValue2 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_TotalTareGrossToday_count_Fetch1").Tables(0).Rows(0)

        If retValue2 Is Nothing Then
            lblGrossToday.Text = "0"
            lblGrossWeighToday.Text = "0"
            lblTareToday.Text = "0"
            lblTareWeighToday.Text = "0"


        Else

            lblGrossToday.Text = retValue2.Table.Rows(0).Item("TodayTotalGrossCount")
            lblGrossWeighToday.Text = retValue2.Table.Rows(0).Item("TodayTotalGrossWeigh")
            lblTareToday.Text = retValue2.Table.Rows(0).Item("TodayTotalTareCount")
            lblTareWeighToday.Text = retValue2.Table.Rows(0).Item("TodayTotalTareWeigh")
        End If






    End Sub
End Class
