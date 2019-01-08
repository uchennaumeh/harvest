Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class FieldEdit
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim TranCode As String
    Dim drpSelect As Integer
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")



            TranCode = Request.QueryString(0).ToString


            Dim param As SqlParameter() = {New SqlParameter("@Fieldid", Request.QueryString(0).ToString())}




            Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_FieldID_Fetch", param).Tables(0).Rows(0)
            txtFieldName.Text = retValue.Table.Rows(0).Item("fieldName")
            txtArea.Text = retValue.Table.Rows(0).Item("fieldArea")
            drpSelect = retValue.Table.Rows(0).Item("EstateID")

            'drpEstate.SelectedValue = retValue.Table.Rows(0).Item("EstateID")

            Load_Estate()


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
                    .SelectedValue = drpSelect
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub




    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim params1() As SqlParameter = {New SqlParameter("@fieldName", (txtFieldName.Text)),
            New SqlParameter("@Area", Val(txtArea.Text)),
            New SqlParameter("@EstateID", drpEstate.SelectedValue),
            New SqlParameter("@fieldID", Request.QueryString(0).ToString())}

            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_FieldDetails__Update", params1)

            'Dim params0() As SqlParameter = {New SqlParameter("@ZoneCode", Request.QueryString(0).ToString())}
            'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_TruckDetails_After_Update", params0)

            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('FIELD Details Updated Succesfully');window.location='createField.aspx';</script>'")
        Catch ex As Exception
            lblError.Text = "Error Editing Estate, Please Try Again"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try







    End Sub
End Class
