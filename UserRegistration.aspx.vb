Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class UserRegistration
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connPrisons").ConnectionString

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        'CalendarDOB.EndDate = DateTime.Now

    End Sub


    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Try
        Dim params() As SqlParameter = {New SqlParameter("@UserName", Trim(txtUsername.Text)), _
                                   New SqlParameter("@Password", Trim(txtPassword.Text))}
        'New SqlParameter("@email", Trim(txtEmail.Text)), _
        '                                     New SqlParameter("@Phone", Trim(txtPhone.Text)), _
        '                                   New SqlParameter("@firstname", Trim(txtFirstname.Text)), _
        '                                   New SqlParameter("@lastname", Trim(txtLastname.Text)), _
        '                                     New SqlParameter("@DOB", Trim(txtDOB.Text)), _
        '                                     New SqlParameter("@address", Trim(txtAddress.Text)), _
        '                                     New SqlParameter("@Sex", (drpSex.SelectedItem.ToString))}
        SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "Prisons_User_Details_Insert", params)

        'Dim script2 As String = "alert(""Account Created Succesfully. Logon With The New Credetials"");"
        '.RegisterStartupScript(Me, Me.[GetType](), "ServerControlScript", script2, True)

        ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Account Created Succesfully. Logon With The New Credetials!');window.location='login.aspx';</script>'")



        'Catch ex As Exception
        '    LoanError.WriteLog(ex.Message, ex.StackTrace)
        '    lblError.Text = "User ID Already Exists. Please Try Another ID"
        'End Try

    End Sub
End Class
