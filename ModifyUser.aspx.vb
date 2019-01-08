Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class ModifyUser
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            'Panel1.Visible = True

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")

            Load_Role()

            Dim param As SqlParameter() = {New SqlParameter("@userr", Request.QueryString(0).ToString())}




            Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_user_Details_Edit_Fetch", param).Tables(0).Rows(0)
            txtAddress.Text = retValue.Table.Rows(0).Item("Address")
            txtEmail.Text = retValue.Table.Rows(0).Item("email")
            txtFirstname.Text = retValue.Table.Rows(0).Item("firstname")
            txtLastname.Text = retValue.Table.Rows(0).Item("surname")
            txtOthernames.Text = retValue.Table.Rows(0).Item("othernames")
            txtPhone.Text = retValue.Table.Rows(0).Item("telephone")
            txtStafsID.Text = retValue.Table.Rows(0).Item("staffID")
            txtChUser.Text = retValue.Table.Rows(0).Item("username")
            drpRole.SelectedValue = retValue.Table.Rows(0).Item("roleID")
            drpSex.SelectedValue = retValue.Table.Rows(0).Item("Gender")






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
            Dim params() As SqlParameter = {New SqlParameter("@Userr", (txtChUser.Text)),
                                        New SqlParameter("@Role", (drpRole.SelectedValue)),
                                         New SqlParameter("@othernames", (txtOthernames.Text)),
                                         New SqlParameter("@Telephone", (txtPhone.Text)),
                                         New SqlParameter("@email", (txtEmail.Text)),
                                         New SqlParameter("@address", (txtAddress.Text)),
                                         New SqlParameter("@gender", (drpSex.SelectedValue)),
                                         New SqlParameter("@staffID", (txtStafsID.Text))}

            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_user_Details_Edit_Update", params)



            txtAddress.Text = ""
            txtEmail.Text = ""
            txtFirstname.Text = ""
            txtLastname.Text = ""
            txtOthernames.Text = ""
            txtPhone.Text = ""
            drpRole.SelectedValue = 0
            drpSex.SelectedValue = 0

            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('User Updated Succesfully');window.location='users.aspx';</script>'")

            'ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Account Created Succesfully');window.location='login.aspx';</script>'")



        Catch ex As Exception
            caneLog.WriteLog(ex.Message, ex.StackTrace)
            lblError.Text = "Update Failed"
        End Try
    End Sub
End Class
