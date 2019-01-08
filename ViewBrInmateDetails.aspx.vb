Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class ViewBrInmateDetails
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connPrisons").ConnectionString
    Private con As New SqlConnection("Data Source=.;Initial Catalog=Prisons;User ID=sa;Password=p@ssw0rd")
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            'If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            'Panel1.Visible = True
            txtDepartment.Text = Session("Department")
            txtBranch.Text = Session("Branch")
            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")
            'txtBranch.Text = Session("Branch")

            'Load_Role()
            Load_Branch()

        End If
    End Sub
    Public Sub Load_Branch()
        Try
            'Get Dataset
            Dim params3() As SqlParameter = {New SqlParameter("@BranchID", Session("Branch"))}
            'New SqlParameter("@Department", txtDepartment.Text)}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[Prisons_Branch_Fetch_Branch]", params3)
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Prison Branch --"

            drpBranch.AppendDataBoundItems = True
            drpBranch.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpBranch
                    .DataSource = ds.Tables(0)
                    .DataTextField = "BranchName"
                    .DataValueField = "BranchID"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtInmateNo.Text = "" And txtInmateName.Text = "" And drpBranch.SelectedValue = 0 Then
            lblError.Text = "Please Enter Search Parameters"
        ElseIf txtInmateNo.Text <> "" And txtInmateName.Text = "" And drpBranch.SelectedValue = 0 Then
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            GridView1.Visible = True
            loadGridI()

        ElseIf txtInmateNo.Text = "" And txtInmateName.Text <> "" And drpBranch.SelectedValue = 0 Then
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lblError.Visible = False
            GridView1.Visible = True
            loadGridN()

        ElseIf txtInmateNo.Text = "" And txtInmateName.Text = "" And drpBranch.SelectedValue <> 0 Then
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lblError.Visible = False
            GridView1.Visible = True
            loadGridB()
        ElseIf txtInmateNo.Text <> "" And txtInmateName.Text <> "" And drpBranch.SelectedValue = 0 Then
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lblError.Visible = False
            GridView1.Visible = True
            loadGridIN()
        ElseIf txtInmateNo.Text = "" And txtInmateName.Text <> "" And drpBranch.SelectedValue <> 0 Then
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lblError.Visible = False
            GridView1.Visible = True
            loadGridBN()
        ElseIf txtInmateNo.Text <> "" And txtInmateName.Text = "" And drpBranch.SelectedValue <> 0 Then
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lblError.Visible = False
            GridView1.Visible = True
            loadGridBI()
        ElseIf txtInmateNo.Text <> "" And txtInmateName.Text <> "" And drpBranch.SelectedValue <> 0 Then
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lblError.Visible = False
            GridView1.Visible = True
            loadGridBIN()


        End If

    End Sub
    Protected Sub loadGridB()
        con.Open()


        Dim cmd As New SqlCommand("Prisons_Inmate_Details_B_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = drpBranch.SelectedValue

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
    Protected Sub loadGridI()

        con.Open()


        Dim cmd As New SqlCommand("Prisons_Inmate_Details_I_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@InmateNo", SqlDbType.VarChar).Value = txtInmateNo.Text

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
    Protected Sub loadGridN()
        con.Open()


        Dim cmd As New SqlCommand("Prisons_Inmate_Details_N_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtInmateName.Text

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
    Protected Sub loadGridBN()
        con.Open()


        Dim cmd As New SqlCommand("Prisons_Inmate_Details_BN_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtInmateName.Text
        cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = drpBranch.SelectedValue

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
    Protected Sub loadGridBI()
        con.Open()


        Dim cmd As New SqlCommand("Prisons_Inmate_Details_IB_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@InmateNo", SqlDbType.VarChar).Value = txtInmateNo.Text
        cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = drpBranch.SelectedValue

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
    Protected Sub loadGridIN()
        con.Open()


        Dim cmd As New SqlCommand("Prisons_Inmate_Details_IN_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtInmateName.Text
        cmd.Parameters.Add("@InmateNo", SqlDbType.VarChar).Value = txtInmateNo.Text

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
    Protected Sub loadGridBIN()
        con.Open()


        Dim cmd As New SqlCommand("Prisons_Inmate_Details_IBN_Fetch", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtInmateName.Text
        cmd.Parameters.Add("@InmateNo", SqlDbType.VarChar).Value = txtInmateNo.Text
        cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = drpBranch.SelectedValue

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
    Protected Sub OnPageIndexChangingInmate(sender As Object, e As GridViewPageEventArgs)
        GridView1.PageIndex = e.NewPageIndex

        GridView1.DataBind()
        GridView1.SelectedIndex = -1

    End Sub
End Class
