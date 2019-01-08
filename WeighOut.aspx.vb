Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class WeighOut
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim randomGen As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then

            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")




        End If

        If IsPostBack Then

        End If
    End Sub
    Protected Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click


        Try
            ' hidcert.Value = retValue1.Table.Rows(0).Item("Certno")
            Dim param() As SqlParameter = {New SqlParameter("@TransCode", txtWeighInCode.Text)}
            Dim retValue1 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_TransDetails_via_TransCode_Fetch", param).Tables(0).Rows(0)
            If retValue1 Is Nothing Then
                lblError.Text = "Code Entered Doesn't Exist or Has Been Cleared"
            Else
                Panel1.Visible = True
                txtWeighInCode.ReadOnly = True
                btnCode.Visible = False
                'txtCode.Text = retValue1.Table.Rows(0).Item("code")
                txtField.Text = retValue1.Table.Rows(0).Item("fieldName").ToString.ToUpper
                txtDriver.Text = retValue1.Table.Rows(0).Item("DriverName").ToString.ToUpper
                txtShift.Text = retValue1.Table.Rows(0).Item("shiftName")
                txtBIN.Text = retValue1.Table.Rows(0).Item("BinNumber")
                txtTruckNo.Text = retValue1.Table.Rows(0).Item("TruckNumber")
                txtGrossW.Text = retValue1.Table.Rows(0).Item("grossWeight")
                txtTimeIn.Text = retValue1.Table.Rows(0).Item("TimeIn")

            End If
        Catch ex As Exception
            lblError.Text = "Code Entered Doesn't Exist or Has Been Cleared"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try




    End Sub

    Protected Sub txtTare_TextChanged(sender As Object, e As EventArgs) Handles txtTare.TextChanged
        'lblError.Text = "AutoPostBackControl"


    End Sub
    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim paramss() As SqlParameter = {New SqlParameter("@Transcode", txtWeighInCode.Text),
                                         New SqlParameter("@NetWeight", Val(txtNet.Text)),
                                         New SqlParameter("@TareWeight", Val(txtTare.Text)),
                                         New SqlParameter("@User", Session("User"))}
        SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_wieghOut_update", paramss)

        ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('WEIGH-OUT Created Successfully. Please Print Ticket');window.location='PrintWeighOut.aspx';</script>'")
    End Sub
    Protected Sub btnNet_Click(sender As Object, e As EventArgs) Handles btnNet.Click
        txtNet.Text = Val(txtTare.Text) - Val(txtGrossW.Text)
        btnNet.Visible = False
        btnUpdate.Visible = True
        Session("Transcoder") = txtWeighInCode.Text
    End Sub
End Class
