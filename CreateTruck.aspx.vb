Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class CreateTruck
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Private con As New SqlConnection("Data Source=.;Initial Catalog=caneWeigh;User ID=sa;Password=p@ssw0rd")
    Dim randomGen As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            'Panel1.Visible = True

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")
            loadGridB()
            randomGen = Code_Random()
            TextBox8.Text = randomGen


        End If
    End Sub
    Public Function Code_Random() As String
        Try
            Dim sReturn As String = ""
            Randomize()
            Dim iRandom1 = CInt(9999 * Rnd())
            Dim iRandom2 = CInt(999999 * Rnd())
            Dim iRandom3 = CInt(99999 * Rnd())
            Const Alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
            Dim s1 As String = Alphabet.Substring(iRandom1 Mod 26, 1)
            Dim s3 As String = Alphabet.Substring(iRandom2 Mod 26, 1)
            Dim s5 As String = Alphabet.Substring(iRandom3 Mod 26, 1)
            Dim s2 As String = iRandom1.ToString().Substring(0, 1)
            Dim s4 As String = iRandom2.ToString().Substring(0, 1)
            Dim s6 As String = iRandom3.ToString().Substring(0, 1)
            Return s1 & s2 & s3 & s4 & s5 & s6
        Catch ex As Exception
            Response.Write(ex.Message + ex.StackTrace)
        End Try
    End Function

    Protected Sub loadGridB()
        con.Open()


        Dim cmd As New SqlCommand("caneWeigh_Trucks_Fetch", con)
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
            Dim params3() As SqlParameter = {New SqlParameter("@truckName", txtTruckName.Text),
                New SqlParameter("@code", TextBox8.Text),
                New SqlParameter("@TruckWeight", Val(txtTruckWeight.Text))}

            SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Trucks_insert]", params3)
            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Truck Successfully Created');window.location='CreateTruck.aspx';</script>'")

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
