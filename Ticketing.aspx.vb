Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class WeighIn
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim randomGen As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
            Response.Cache.SetNoStore()

            If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")
            'txtDepartment.Text = Session("Department")
            'txtBranch.Text = Session("Branch")
            txtUsername.Text = Session("User")
            txtRole.Text = Session("Role")




            Load_Trans()




            Load_Estate()
            Load_Zone()
            Load_Shift()

        End If

        If IsPostBack Then
            If drpTransType.SelectedValue.ToString() = "1" Then
                Panel1.Visible = True
                Panel2.Visible = False
            Else
                'drpEstateOG.ClearSelection()
                'drpEstateOG.Items.Clear()
                'drpZoneOG.ClearSelection()
                'drpZoneOG.Items.Clear()
                'drpShiftOG.ClearSelection()
                'drpShiftOG.Items.Clear()
                'Panel2.Visible = True
                'Panel1.Visible = False
                'Load_ShiftOG()

                'Load_EstateOG()
                'Load_ZoneOG()
            End If
            'txtCount.Text = polCount
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
    Public Sub Load_Field()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Field_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Field --"

            drpField.AppendDataBoundItems = True
            drpField.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpField
                    .DataSource = ds.Tables(0)
                    .DataTextField = "FieldID"
                    .DataValueField = "fieldName"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub

    Public Sub Load_Trans()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_TransType_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Transaction Type --"

            drpTransType.AppendDataBoundItems = True
            drpTransType.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpTransType
                    .DataSource = ds.Tables(0)
                    .DataTextField = "TransType"
                    .DataValueField = "Seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
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

    Public Sub Load_Shift()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Shift_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Shift --"

            drpShift.AppendDataBoundItems = True
            drpShift.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpShift

                    .DataSource = ds.Tables(0)
                    .DataTextField = "ShiftName"
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
    Public Sub Load_ShiftOG()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Shift_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Shift --"

            drpShiftOG.AppendDataBoundItems = True
            drpShiftOG.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpShiftOG

                    .DataSource = ds.Tables(0)
                    .DataTextField = "ShiftName"
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
    Public Sub Load_Zone()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Zone_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Zone --"

            drpZone.AppendDataBoundItems = True
            drpZone.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpZone

                    .DataSource = ds.Tables(0)
                    .DataTextField = "ZoneName"
                    .DataValueField = "ZoneID"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Public Sub Load_ZoneOG()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Zone_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Zone --"

            drpZoneOG.AppendDataBoundItems = True
            drpZoneOG.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpZoneOG

                    .DataSource = ds.Tables(0)
                    .DataTextField = "ZoneName"
                    .DataValueField = "ZoneID"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub


    Protected Sub drpEstate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpEstate.SelectedIndexChanged


        Try

            drpField.ClearSelection()
            drpField.Items.Clear()

            Dim params4() As SqlParameter = {New SqlParameter("@EstateID", drpEstate.SelectedValue)}
            'New SqlParameter("@Department", txtDepartment.Text)}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_FieldEstate_Fetch]", params4)
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Field --"

            drpField.AppendDataBoundItems = True
            drpField.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpField
                    .DataSource = ds.Tables(0)
                    .DataTextField = "fieldName"
                    .DataValueField = "fieldID"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_count_Fetch").Tables(0).Rows(0)

            Dim number As Integer = retValue3.Table.Rows(0).Item("count")
            txtCount.Text = number
            Dim value As String
            value = number.ToString()


            If value.Length = 1 Then
                value = [String].Format("0000000{0}", value)
            End If

            If value.Length = 2 Then
                value = [String].Format("000000{0}", value)
            End If

            If value.Length = 3 Then
                value = [String].Format("00000{0}", value)
            End If

            If value.Length = 4 Then
                value = [String].Format("0000{0}", value)
            End If

            If value.Length = 5 Then
                value = [String].Format("000{0}", value)
            End If

            If value.Length = 6 Then
                value = [String].Format("00{0}", value)
            End If
            If value.Length = 7 Then
                value = [String].Format("0{0}", value)
            End If






            Dim certCount As String = value

            Session("certCount") = certCount



        Dim params1() As SqlParameter = {New SqlParameter("@code", txtCode.Text),
                                        New SqlParameter("@estate", (drpEstate.SelectedValue)),
                                         New SqlParameter("@field", (drpField.SelectedValue)),
                                         New SqlParameter("@zone", (drpZone.SelectedValue)),
                                         New SqlParameter("@shift", (drpShift.SelectedValue)),
                                         New SqlParameter("@truckNum", (txtTruckNo.Text)),
                                         New SqlParameter("@TransType", (drpTransType.SelectedItem.ToString())),
                                         New SqlParameter("@certCount", (certCount)),
                                         New SqlParameter("@Driver", (txtDriver.Text)),
                                         New SqlParameter("@DriverNum", (txtDrvNum.Text)),
                                         New SqlParameter("@TruckModel", (txtTruckModel.Text)),
                                         New SqlParameter("@createdby", Session("User")),
                                        New SqlParameter("@Status", "1")}

        SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_Trans_Insert", params1)

            Dim params0() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}
            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_pre_update_History", params0)

            Dim NewCount As Integer = Val(txtCount.Text) + 1
            Dim params15() As SqlParameter = {New SqlParameter("@NewCount", NewCount)}

            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_count_increment", params15)



            txtCode.Text = ""
            txtDriver.Text = ""
            txtTruckNo.Text = ""
            drpEstate.SelectedValue = 0
            drpField.SelectedValue = 0
            drpZone.SelectedValue = 0
            drpZone.SelectedValue = 0
            txtDrvNum.Text = ""





            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('TRUCK-IN Created Successfully');window.location='PrintSlip.aspx';</script>'")

        Catch ex As Exception
        lblError.Text = "something went wrong, contact IT"
        caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try


    End Sub
    Protected Sub drpTransType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpTransType.SelectedIndexChanged
        If drpTransType.SelectedValue.ToString() = "1" Then


            randomGen = Code_Random()
            Session("TransCode") = randomGen
            txtCode.Text = randomGen


            Panel1.Visible = True
            Panel2.Visible = False
            rfvDriverNumOG.Enabled = False
            rfvDriverOG.Enabled = False
            rfvFarmerDetailOG.Enabled = False
            rfvFieldOG.Enabled = False
            rfvlEstateOG.Enabled = False
            rfvTruckModelOG.Enabled = False
            rfvTruckNumOG.Enabled = False
            rfvZoneOG.Enabled = False
            rfvShiftOG.Enabled = False


            drpShiftOG.Items.Clear()

            drpZoneOG.Items.Clear()
        Else
            Panel2.Visible = True
            Panel1.Visible = False

            randomGen = Code_Random()
            Session("TransCode") = randomGen
            txtCodeOG.Text = randomGen



            RequiredFieldValidator1.Enabled = False
            RequiredFieldValidator2.Enabled = False
            rfvZone.Enabled = False
            rfvTruckNo.Enabled = False
            rfvShift.Enabled = False
            rfvlEstateOG.Enabled = False
            rfvFieldOG.Enabled = False
            rfvDriverNumOG.Enabled = False
            rfvFarmerDetailOG.Enabled = False

            Load_ShiftOG()


            Load_ZoneOG()
            drpEstate.Items.Clear()
            drpField.Items.Clear()
            drpZone.Items.Clear()
            drpShift.Items.Clear()
        End If
    End Sub

    Protected Sub btnSubmitOG_Click(sender As Object, e As EventArgs) Handles btnSubmitOG.Click
        Try
            Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_count_Fetch").Tables(0).Rows(0)

            Dim number As Integer = retValue3.Table.Rows(0).Item("count")
            txtCount.Text = number
            Dim value As String
            value = number.ToString()


            If value.Length = 1 Then
                value = [String].Format("0000000{0}", value)
            End If

            If value.Length = 2 Then
                value = [String].Format("000000{0}", value)
            End If

            If value.Length = 3 Then
                value = [String].Format("00000{0}", value)
            End If

            If value.Length = 4 Then
                value = [String].Format("0000{0}", value)
            End If

            If value.Length = 5 Then
                value = [String].Format("000{0}", value)
            End If

            If value.Length = 6 Then
                value = [String].Format("00{0}", value)
            End If
            If value.Length = 7 Then
                value = [String].Format("0{0}", value)
            End If






            Dim certCount As String = value

            Session("certCount") = certCount



            Dim params1() As SqlParameter = {New SqlParameter("@code", txtCodeOG.Text),
                New SqlParameter("@field", (drpFieldOG.Text)),
                New SqlParameter("@estate", (drpEstateOG.Text)),
                                                 New SqlParameter("@zone", (drpZoneOG.SelectedValue)),
                                                 New SqlParameter("@shift", (drpShiftOG.SelectedValue)),
                                                 New SqlParameter("@truckNum", (txtTruckNoOG.Text)),
                                                 New SqlParameter("@certCount", (certCount)),
                                                 New SqlParameter("@TransType", (drpTransType.SelectedItem.ToString())),
                                                 New SqlParameter("@Driver", (txtDriverOG.Text)),
                                                 New SqlParameter("@DriverNum", (txtDrvNumOG.Text)),
                                                 New SqlParameter("@TruckModel", (txtTruckModelOG.Text)),
                                                 New SqlParameter("@Farmer", (txtFamerNameOG.Text)),
                                                 New SqlParameter("@createdby", Session("User")),
                                                New SqlParameter("@Status", 1)}


            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_Trans_Insert_OG", params1)

            Dim params0() As SqlParameter = {New SqlParameter("@TransCode", (txtCodeOG.Text))}
            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_pre_update_History", params0)

            Dim NewCount As Integer = Val(txtCount.Text) + 1
            Dim params15() As SqlParameter = {New SqlParameter("@NewCount", NewCount)}

            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_count_increment", params15)



            txtCodeOG.Text = ""
            txtDriverOG.Text = ""
            txtTruckNoOG.Text = ""
            drpEstateOG.Text = ""
            drpFieldOG.Text = ""
            drpZoneOG.SelectedValue = 0
            drpZoneOG.SelectedValue = 0
            txtFamerNameOG.Text = ""
            txtDrvNumOG.Text = ""





            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('TRUCK-IN Created Successfully');window.location='PrintSlip.aspx';</script>'")

        Catch ex As Exception
            lblError.Text = "something went wrong, contact IT"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try

    End Sub
End Class
