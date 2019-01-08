Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class RePrintTicket
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Private con As New SqlConnection("Data Source=.;Initial Catalog=caneWeigh;User ID=sa;Password=p@ssw0rd")
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            'Panel1.Visible = True

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")


        End If
    End Sub
    Protected Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click
        Try
            Dim params3() As SqlParameter = {New SqlParameter("@TranCode", txtWeighInCode.Text)}


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_TranCode_Edit_Fetch]", params3)
            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                loadGridB()
                Panel1.Visible = 3
            Else
                lblError.Text = "Code Not Found! Check to be sure you have the correct code!"
            End If

        Catch ex As Exception
            lblError.Text = "Code Not Found! Check to be sure you have the correct code!"
        End Try


    End Sub
    Protected Sub loadGridB()
        con.Open()


        Dim cmd As New SqlCommand("caneWeigh_TranCode_Edit_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TranCode", SqlDbType.VarChar).Value = txtWeighInCode.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        Dim count As Integer = ds.Tables(0).Rows.Count
        con.Close()
        If ds.Tables(0).Rows.Count > 0 Then
            GridView1.DataSource = ds
            GridView1.DataBind()

        Else

            lblError.Text = " No data found !!!"
        End If
    End Sub
End Class
