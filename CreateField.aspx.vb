Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class CreateField
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Private con As New SqlConnection("Data Source=.;Initial Catalog=caneWeigh;User ID=sa;Password=p@ssw0rd")

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            'Panel1.Visible = True

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")
            Load_Estate()
            loadGridB()


        End If
    End Sub
    Public Sub Load_Estate()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Estate_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Estate --"

            drpEstate.AppendDataBoundItems = True
            drpEstate.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpEstate

                    .DataSource = ds.Tables(0)
                    .DataTextField = "Name"
                    .DataValueField = "ID"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub loadGridB()
        con.Open()


        Dim cmd As New SqlCommand("caneWeigh_FieldGrid_Fetch", con)
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
            GridView1.SelectedIndex = -1
            Session("GridView1") = ds
            Cache("Data") = ds

        Else

            lblError.Text = " No data found !!!"
        End If
    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim params3() As SqlParameter = {New SqlParameter("@FieldName", txtFieldName.Text),
                New SqlParameter("@Area", Val(txtArea.Text)),
            New SqlParameter("@estateID", drpEstate.SelectedValue)}

            SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_field_insert]", params3)
            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('FIELD Successfully Created');window.location='CreateField.aspx';</script>'")

        Catch ex As Exception
            lblError.Text = "An Exception occured, Try Again"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try
    End Sub
    Protected Sub OnPageIndexChangingInmate(sender As Object, e As GridViewPageEventArgs)
        GridView1.PageIndex = e.NewPageIndex
        GridView1.DataSource = CType(Cache("Data"), DataSet)
        GridView1.DataBind()
        GridView1.SelectedIndex = -1

    End Sub
End Class
