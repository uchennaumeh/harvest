Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class CreateShift
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Private con As New SqlConnection("Data Source=.;Initial Catalog=caneWeigh;User ID=sa;Password=p@ssw0rd")

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            'Panel1.Visible = True

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")
            loadGridB()


        End If
    End Sub
    Protected Sub loadGridB()
        con.Open()


        Dim cmd As New SqlCommand("caneWeigh_shiftGrid_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@TranCode", SqlDbType.VarChar).Value = txtWeighInCode.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        Dim count As Integer = ds.Tables(0).Rows.Count
        con.Close()
        If ds.Tables(0).Rows.Count > 0 Then
            GridView1.DataSource = ds
            GridView1.DataBind()
            'GridView1.SelectedIndex = -1
            'Session("GridView1") = ds
            'Cache("Data") = ds

        Else

            lblError.Text = " No data found !!!"
        End If
    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim params3() As SqlParameter = {New SqlParameter("@shiftName", txtShiftName.Text)}

            SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Shift_insert]", params3)
            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('SHIFT Successfully Created');window.location='CreateShift.aspx';</script>'")

        Catch ex As Exception
            lblError.Text = "An Exception occured, Try Again"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try
    End Sub
    'Protected Sub OnPageIndexChangingInmate(sender As Object, e As GridViewPageEventArgs)
    '    GridView1.PageIndex = e.NewPageIndex
    '    GridView1.DataSource = CType(Cache("Data"), DataSet)
    '    GridView1.DataBind()
    '    GridView1.SelectedIndex = -1

    'End Sub
End Class
