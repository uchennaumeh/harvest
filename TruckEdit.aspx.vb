Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class TruckEdit
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim TranCode As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")


            TranCode = Request.QueryString(0).ToString


            Dim param As SqlParameter() = {New SqlParameter("@TruckCode", Request.QueryString(0).ToString())}




            Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_TruckDetails_Fetch", param).Tables(0).Rows(0)
            txtTruckName.Text = retValue.Table.Rows(0).Item("truck")
            txtTruckWeight.Text = retValue.Table.Rows(0).Item("weight")
            txtSeq.Text = retValue.Table.Rows(0).Item("Seqno")

        End If
    End Sub




    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim params1() As SqlParameter = {New SqlParameter("@TruckCode", (txtTruckName.Text)),
            New SqlParameter("@Seq", Val(txtSeq.Text)),
                                         New SqlParameter("@weight", Val(txtTruckWeight.Text))}

        SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_TruckDetails__Update", params1)

        Dim params0() As SqlParameter = {New SqlParameter("@seq", (txtSeq.Text))}
        SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_TruckDetails_After_Update", params0)

        'Dim params10() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}

        'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_ChangeReason_History_Update", params10)




        ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Truck Details Updated Succesfully');window.location='createTruck.aspx';</script>'")

    End Sub
End Class
