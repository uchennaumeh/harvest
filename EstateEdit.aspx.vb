Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class EstateEdit
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim TranCode As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")


            TranCode = Request.QueryString(0).ToString


            Dim param As SqlParameter() = {New SqlParameter("@Estateid", Request.QueryString(0).ToString())}




            Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_EstateID_Fetch", param).Tables(0).Rows(0)
            txtEstateName.Text = retValue.Table.Rows(0).Item("Name")



        End If
    End Sub




    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim params1() As SqlParameter = {New SqlParameter("@EstateName", (txtEstateName.Text)),
                New SqlParameter("@estateid", Request.QueryString(0).ToString())}

            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_EstateDetails__Update", params1)

            'Dim params0() As SqlParameter = {New SqlParameter("@ZoneCode", Request.QueryString(0).ToString())}
            'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_TruckDetails_After_Update", params0)

            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('ESTATE Details Updated Succesfully');window.location='createEstate.aspx';</script>'")
        Catch ex As Exception
            lblError.Text = "Error Editing Estate, Please Try Again"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try







    End Sub

End Class
