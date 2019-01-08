Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class Users
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Private con As New SqlConnection("Data Source=.;Initial Catalog=caneWeigh;User ID=sa;Password=p@ssw0rd")

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")
            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Users_Fetch]")
            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                loadGridB()

            Else
                lblError.Text = "There Are No Users !"
            End If






        End If
    End Sub
    Protected Sub loadGridB()
        con.Open()


        Dim cmd As New SqlCommand("caneWeigh_Users_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        Dim count As Integer = ds.Tables(0).Rows.Count
        con.Close()
        If ds.Tables(0).Rows.Count > 0 Then
            GridView1.DataSource = ds
            GridView1.DataBind()
            GridView1.SelectedIndex = -1
            Session("GridView1") = ds
            Cache("Data") = ds

        Else

            lblError.Text = " No data found !!!"
        End If
    End Sub
    Protected Sub OnPageIndexChangingInmate(sender As Object, e As GridViewPageEventArgs)
        GridView1.PageIndex = e.NewPageIndex
        GridView1.DataSource = CType(Cache("Data"), DataSet)
        GridView1.DataBind()
        GridView1.SelectedIndex = -1

    End Sub
End Class
