Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class UserManagement
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            'Panel1.Visible = True

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")


            Load_Role()



        End If
    End Sub
    Public Sub Load_Role()
        Try
            'Get Dataset
            'Dim params3() As SqlParameter = {New SqlParameter("@UserName", Session("User")), _
            'New SqlParameter("@Department", txtDepartment.Text)}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Role_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Role --"

            drpRole.AppendDataBoundItems = True
            drpRole.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpRole
                    .DataSource = ds.Tables(0)
                    .DataTextField = "roleDesc"
                    .DataValueField = "roleID"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim params() As SqlParameter = {New SqlParameter("@UserName", Trim(txtFirstname.Text + "." + txtLastname.Text)),
                                        New SqlParameter("@RoleID", (drpRole.SelectedValue.ToString)),
                                        New SqlParameter("@Status", "3"),
                                         New SqlParameter("@email", (txtEmail.Text)),
                                   New SqlParameter("@Password", "TCC")}

            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "CaneWeigh_login_Details_Insert", params)

            Dim params1() As SqlParameter = {New SqlParameter("@UserName", Trim(txtFirstname.Text + "." + txtLastname.Text)),
                                        New SqlParameter("@RoleID", (drpRole.SelectedValue)),
                                         New SqlParameter("@firstname", (txtFirstname.Text)),
                                         New SqlParameter("@surname", (txtLastname.Text)),
                                         New SqlParameter("@othernames", (txtOthernames.Text)),
                                         New SqlParameter("@phone", (txtPhone.Text)),
                                         New SqlParameter("@email", (txtEmail.Text)),
                                         New SqlParameter("@address", (txtAddress.Text)),
                                         New SqlParameter("@staffID", (txtStafsID.Text)),
                                         New SqlParameter("@createdby", Session("user")),
                                        New SqlParameter("@Sex", (drpSex.SelectedValue))}


            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "CaneWeigh_User_Details_Insert", params1)

            txtAddress.Text = ""
            txtEmail.Text = ""
            txtFirstname.Text = ""
            txtLastname.Text = ""
            txtOthernames.Text = ""
            txtPhone.Text = ""
            drpRole.SelectedValue = 0
            drpSex.SelectedValue = 0

            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Account Created Succesfully');</script>'")

            'ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Account Created Succesfully');window.location='login.aspx';</script>'")



        Catch ex As Exception
            caneLog.WriteLog(ex.Message, ex.StackTrace)
            lblError.Text = "User ID Already Exists. Please Try Another username and password combination"
        End Try
    End Sub
End Class
