Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class changePassword
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")


            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")

        End If
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim params() As SqlParameter = {New SqlParameter("@password", txtOldPassword.Text),
                                   New SqlParameter("@username", Session("User"))}
            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[CaneWeigh_PasswordChange_Fetch]", params)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                Dim paramss() As SqlParameter = {New SqlParameter("@password", txtNewPassword.Text),
                             New SqlParameter("@username", Session("User"))}
                SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "CaneWeigh_PasswordChange_Update", paramss)
                ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Password Changed Succesfully. Login with the New Password');window.location='logout.aspx';</script>'")
            Else
                lblError.Text = "Access is Denied; Old Password Supplied is Incorrect. Pls Refresh Page & Try Again"
            End If

        Catch ex As Exception
            lblError.Text = "Access is Denied; Old password supplied is wrong. pls try again"
            caneLog.WriteLog(ex.Message, ex.Source)
        End Try
    End Sub
End Class
