Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class Login
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connPrisons").ConnectionString
    Dim checkRole As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            'Dim retValue2 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "Appraise_Status_Fetch").Tables(0).Rows(0)
            'txtApprStatus.Text = retValue2.Table.Rows(0).Item("ApprCode")
            'txtApprYear.Text = retValue2.Table.Rows(0).Item("ApprYear")
            'txtApprQtr.Text = retValue2.Table.Rows(0).Item("ApprQtr")

            'Session("ApprQtr") = txtApprQtr.Text
            'Session("ApprYear") = txtApprYear.Text


        End If
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Try
        '    Dim paramsRole() As SqlParameter = {New SqlParameter("@UserName", Trim(txtUsername.Text))}
        '    Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "Loan_Login", paramsRole).Tables(0).Rows(0)
        '    checkRole = retValue3.Table.Rows(0).Item("Role")
        '    Session("appStattus") = retValue3.Table.Rows(0).Item("AppStatus")


        'Catch ex As Exception
        '    lblError.Text = "Access is Denied"
        'End Try




        'If (txtApprStatus.Text = "True1" And (checkRole = "Staff" Or checkRole = "Supervisor" Or checkRole = "Boss of Boss")) Then


        '    lblmsg.Text = "SORRY, APRRAISAL FOR THE QUARTER HAS BEEN CLOSED!!!"

        'Else


        '    Try
        '        If txtPassword.Text = "royal" Then
        '            Dim params1() As SqlParameter = {New SqlParameter("@UserName", Trim(txtUsername.Text)), _
        '                                             New SqlParameter("@IPAddress", Request.ServerVariables("REMOTE_ADDR")), _
        '                                            New SqlParameter("@userPass", Trim(txtPassword.Text))}

        '            Dim retValue1 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "sproc_Appraise_Login", params1).Tables(0).Rows(0)
        '            Session("AdminOk") = True
        '            Session("Role") = retValue1.Table.Rows(0).Item("Role")
        '            Session("User") = retValue1.Table.Rows(0).Item("UserName")
        '            Session("staffID") = retValue1.Table.Rows(0).Item("staffID")
        '            Session("department") = retValue1.Table.Rows(0).Item("Department")
        '            Session("appStatus2") = retValue1.Table.Rows(0).Item("appstatus")
        '            Response.Redirect("changePassword.aspx")
        '        End If

        '        Dim retValue2 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "Appraise_Status_Fetch").Tables(0).Rows(0)
        '        'txtApprStatus.Text = retValue2.Table.Rows(0).Item("ApprCode")
        '        txtApprYear.Text = retValue2.Table.Rows(0).Item("ApprYear")
        '        txtApprQtr.Text = retValue2.Table.Rows(0).Item("ApprQtr")



        Dim params() As SqlParameter = {New SqlParameter("@UserName", Trim(txtUsername.Text)), _
                                    New SqlParameter("@IPAddress", Request.ServerVariables("REMOTE_ADDR")), _
                                   New SqlParameter("@Password", Trim(txtPassword.Text))}


        'Try

        Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "Loan_Login", params).Tables(0).Rows(0)


            If retValue Is Nothing Then
                lblError.Text = "Access is Denied"
            Else
                Session("AdminOk") = True
                Session("Role") = retValue.Table.Rows(0).Item("Role")
                Session("User") = retValue.Table.Rows(0).Item("UserName")
                'Session("staffID") = retValue.Table.Rows(0).Item("staffID")
                'Session("department") = retValue.Table.Rows(0).Item("Department")
                Response.Redirect("userDefault.aspx")
            End If

        'Catch ex As Exception
        lblError.Text = "Access is Denied"
        'LoanError.WriteLog(ex.Message, ex.StackTrace)
        'End Try

        'lblmsg.Text = "APRRAISAL HAS BEEN OPEN!!!"





    End Sub

End Class
