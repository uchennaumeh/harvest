Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
'Imports ShopSale

Partial Class index
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Public Property labelErrorShow As Boolean

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        labelErrorShow = False

        Try
            If txtPassword.Text = "TCC" Then
                Dim params1() As SqlParameter = {New SqlParameter("@UserName", Trim(txtUsername.Text)),
                                                 New SqlParameter("@IPAddress", Request.ServerVariables("REMOTE_ADDR")),
                                                New SqlParameter("@Password", Trim(txtPassword.Text))}

                Dim retValue1 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "CaneWeigh_USer_Login", params1).Tables(0).Rows(0)
                Session("AdminOk") = True
                Session("Role") = retValue1.Table.Rows(0).Item("RoleID")
                Session("User") = retValue1.Table.Rows(0).Item("UserName")
                Session("Branch") = retValue1.Table.Rows(0).Item("BranchID")
                Session("Department") = retValue1.Table.Rows(0).Item("DepartmentID")

                Response.Redirect("changePassword.aspx")

            End If

            Dim params() As SqlParameter = {New SqlParameter("@UserName", Trim(txtUsername.Text)),
                                  New SqlParameter("@IPAddress", Request.ServerVariables("REMOTE_ADDR")),
                                 New SqlParameter("@Password", Trim(txtPassword.Text))}

            Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "CaneWeigh_USer_Login", params).Tables(0).Rows(0)


            If retValue Is Nothing Then
                lblError.Text = "Access is Denied"
            Else
                Session("AdminOk") = True
                Session("Role") = retValue.Table.Rows(0).Item("RoleID")
                Session("User") = retValue.Table.Rows(0).Item("UserName")
                Session("Branch") = retValue.Table.Rows(0).Item("BranchID")
                Session("Department") = retValue.Table.Rows(0).Item("DepartmentID")
                Response.Redirect("dashboard.aspx")
            End If

        Catch ex As Exception
            labelErrorShow = True
            lblError.Text = "Access is Denied"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try
    End Sub
End Class
