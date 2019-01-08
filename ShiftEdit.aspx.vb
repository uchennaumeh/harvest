Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class ShiftEdit
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim TranCode As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")


            TranCode = Request.QueryString(0).ToString


            Dim param As SqlParameter() = {New SqlParameter("@shiftid", Request.QueryString(0).ToString())}




            Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_ShiftID_Fetch", param).Tables(0).Rows(0)
            txtShiftName.Text = retValue.Table.Rows(0).Item("ShiftName")



        End If
    End Sub




    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim params1() As SqlParameter = {New SqlParameter("@ShiftName", (txtShiftName.Text)),
                New SqlParameter("@shiftId", Request.QueryString(0).ToString())}

            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_ShiftDetails__Update", params1)

            'Dim params0() As SqlParameter = {New SqlParameter("@ZoneCode", Request.QueryString(0).ToString())}
            'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_TruckDetails_After_Update", params0)

            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('SHIFT Details Updated Succesfully');window.location='createShift.aspx';</script>'")
        Catch ex As Exception
            lblError.Text = "Error Editing Shift"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try







    End Sub
End Class
