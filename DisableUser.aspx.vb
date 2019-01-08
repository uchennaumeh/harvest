Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class DisableUser
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")
    End Sub



    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim params2() As SqlParameter = {New SqlParameter("@username", txtFrom.Text)}


            Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "CaneWeigh_username_ForDisable_Fetch", params2).Tables(0).Rows(0)


            If retValue Is Nothing Then
                lblError.Text = "Check Username Properly"
            Else
                btnSubmit.Visible = False
                txtFrom.ReadOnly = True
                Panel1.Visible = True
                lblUser.Text = retValue.Table.Rows(0).Item("fullname")
                'Session("DisUser") = txtFrom.Text

            End If


        Catch ex As Exception
            lblError.Text = "Wrong Username! please check properly"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try

    End Sub

    Protected Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        Try
            Dim params0() As SqlParameter = {New SqlParameter("@username", (txtFrom.Text))}
            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "CaneWeigh_Disable_User", params0)

            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('User Has Been Successfully Disabled');window.location='Dashboard.aspx';</script>'")
        Catch ex As Exception
            lblError.Text = "Something Went Wrong. Contact IT"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try

    End Sub
End Class
