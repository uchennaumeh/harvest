Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class passwordReset
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")
    End Sub



    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim params2() As SqlParameter = {New SqlParameter("@username", txtFrom.Text)}
            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[CaneWeigh_username_ForPasswordChange_Fetch]", params2)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                Dim params() As SqlParameter = {New SqlParameter("@UserName", (txtFrom.Text)),
            New SqlParameter("@Password", "TCC")}

                SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_userpassword_reset", params)
                txtFrom.Text = ""
                ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Password Reset Succesfully. New Password is TCC');</script>'")
            Else
                lblError.Text = "Wrong Username! please check properly"
            End If

        Catch ex As Exception
            lblError.Text = "Wrong Username! please check properly"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try

    End Sub
End Class
