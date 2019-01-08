Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class EditTrans
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim TranCode As String
    Dim weightCal As Decimal = 0.00
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then

                If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

                txtUsername.Text = Session("User")
                txtRole.Text = Session("Role")


                TranCode = Request.QueryString(0).ToString
                Session("coder") = TranCode
                Dim param7 As SqlParameter() = {New SqlParameter("@TranCode", Request.QueryString(0).ToString())}
                Dim retValue7 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_TransType_via_Trancode_Fetch", param7).Tables(0).Rows(0)
                Dim retString As String = retValue7.Table.Rows(0).Item("transtype")
                Session("TransactionType") = retValue7.Table.Rows(0).Item("transtype")

                If retString = "Savannah" Then
                    Panel1.Visible = True
                    Panel2.Visible = False
                    rfvDrpEstateOG.Enabled = False
                    rfvDrvNumOG.Enabled = False
                    rfvDrvOG.Enabled = False
                    rfvFieldOG.Enabled = False
                    rfvGrossOG.Enabled = False
                    rfvlBinOG.Enabled = False
                    rfvSHiftOG.Enabled = False
                    rfvTruckmodelOG.Enabled = False
                    rfvTruckNoOG.Enabled = False
                    rfvZoneOG.Enabled = False
                    rfvDrpEstateOG.Enabled = False
                    rfvFarmer.Enabled = False
                    rfvCycleOG.Enabled = False
                    rfvSpaceOG.Enabled = False
                    rfvVarietyOG.Enabled = False

                    Load_Zone()

                    Load_Shift()
                    Load_Estate()
                    Load_Spacing()
                    Load_Cycle()
                    Load_Variety()

                    Dim param As SqlParameter() = {New SqlParameter("@TranCode", Request.QueryString(0).ToString())}




                    Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_TranCode_Edit_Fetch", param).Tables(0).Rows(0)
                    txtBIN.Text = retValue.Table.Rows(0).Item("binNumber")
                    txtCode.Text = retValue.Table.Rows(0).Item("code")
                    txtDriver.Text = retValue.Table.Rows(0).Item("DriverName")
                    txtDrvNum.Text = retValue.Table.Rows(0).Item("DriverID")
                    txtGrossW.Text = retValue.Table.Rows(0).Item("GrossWeight")
                    txtTruckModel.Text = retValue.Table.Rows(0).Item("TruckModel")
                    txtTruckNo.Text = retValue.Table.Rows(0).Item("TruckNumber")
                    txtTare.Text = retValue.Table.Rows(0).Item("TareWeight")
                    txtNet.Text = retValue.Table.Rows(0).Item("NetWeight")
                    drpZone.SelectedValue = retValue.Table.Rows(0).Item("ZoneNumber")
                    drpShift.SelectedValue = retValue.Table.Rows(0).Item("shiftID")
                    drpField.SelectedValue = retValue.Table.Rows(0).Item("fieldID")
                    drpEstate.SelectedValue = retValue.Table.Rows(0).Item("ID")
                    drpSpace.SelectedValue = retValue.Table.Rows(0).Item("spacing")
                    drpVariety.SelectedValue = retValue.Table.Rows(0).Item("variety")
                    drpCycle.SelectedValue = retValue.Table.Rows(0).Item("cropCycle")
                    txtStatus.Text = retValue.Table.Rows(0).Item("status")

                    Try
                        Dim params13() As SqlParameter = {New SqlParameter("@EstateID", drpEstate.SelectedValue)}


                        Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_FieldEstate_Fetch]", params13)
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
                                '.SelectedIndex = retValue.Table.Rows(0).Item("fieldID")
                            End With

                        End If
                        ds.Dispose()
                    Catch ex As Exception
                        Response.Write(ex.Message)
                        caneLog.WriteLog(ex.Message, ex.StackTrace)
                    End Try

                    Load_Truck_Target()
                    Load_Truck_Source()

                    If txtStatus.Text = "1" Then
                        txtBIN.ReadOnly = True
                        txtTare.ReadOnly = True
                        txtGrossW.ReadOnly = True
                        txtNet.ReadOnly = True
                        drpSpace.Enabled = False
                        drpCycle.Enabled = False
                        drpVariety.Enabled = False
                        rfvlBIN.Enabled = False
                        rfvVariety.Enabled = False
                        rfvSpace.Enabled = False
                        rfvCycle.Enabled = False
                        lblCycle.Visible = False
                        lblSpacing.Visible = False
                        lblVariety.Visible = False
                        drpCycle.Visible = False
                        drpSpace.Visible = False
                        drpVariety.Visible = False
                        SourceTruckList.Visible = False
                        TargetTruckList.Visible = False
                        lblAvailTruck.Visible = False
                        lblSelTruck.Visible = False
                        AddOneTruck.Visible = False
                        RemoveTruck.Visible = False
                    End If

                ElseIf retString = "Out Grower" Then
                    Panel2.Visible = True
                    Panel1.Visible = False
                    rfvZone.Enabled = False
                    rfvShift.Enabled = False
                    rfvlGross.Enabled = False
                    rfvlEstate.Enabled = False
                    rfvlDrv.Enabled = False
                    rfvlBIN.Enabled = False
                    rfvField.Enabled = False
                    RequiredFieldValidator4.Enabled = False
                    RequiredFieldValidator3.Enabled = False
                    RequiredFieldValidator2.Enabled = False
                    RequiredFieldValidator1.Enabled = False
                    rfvCycle.Enabled = False
                    rfvSpace.Enabled = False
                    rfvVariety.Enabled = False

                    Load_ZoneOG()

                    Load_ShiftOG()
                    Load_SpacingOG()
                    Load_CycleOG()
                    Load_VarietyOG()


                    Load_Truck_TargetOG()
                    Load_Truck_SourceOG()


                    Dim param As SqlParameter() = {New SqlParameter("@TranCode", Request.QueryString(0).ToString())}




                    Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "caneWeigh_TranCode_Edit_Fetch", param).Tables(0).Rows(0)
                    txtBinOG.Text = retValue.Table.Rows(0).Item("binNumber")
                    txtCodeOG.Text = retValue.Table.Rows(0).Item("code")
                    txtDriverOG.Text = retValue.Table.Rows(0).Item("DriverName")
                    txtDrvNumOG.Text = retValue.Table.Rows(0).Item("DriverID")
                    txtGrossWOG.Text = retValue.Table.Rows(0).Item("GrossWeight")
                    txtTruckModelOG.Text = retValue.Table.Rows(0).Item("TruckModel")
                    txtTruckNoOG.Text = retValue.Table.Rows(0).Item("TruckNumber")
                    txtTareOG.Text = retValue.Table.Rows(0).Item("TareWeight")
                    txtNetOG.Text = retValue.Table.Rows(0).Item("NetWeight")
                    drpZoneOG.SelectedValue = retValue.Table.Rows(0).Item("ZoneNumber")
                    drpShiftOG.SelectedValue = retValue.Table.Rows(0).Item("shiftID")
                    drpFieldOG.Text = retValue.Table.Rows(0).Item("fieldname")
                    drpEstateOG.Text = retValue.Table.Rows(0).Item("name")
                    txtFarmerOG.Text = retValue.Table.Rows(0).Item("Farmer")
                    txtStatus.Text = retValue.Table.Rows(0).Item("status")
                    drpSpaceOG.SelectedValue = retValue.Table.Rows(0).Item("spacing")
                    drpVarietyOG.SelectedValue = retValue.Table.Rows(0).Item("variety")
                    drpCycleOG.SelectedValue = retValue.Table.Rows(0).Item("cropCycle")

                    Try
                        Dim params13() As SqlParameter = {New SqlParameter("@EstateID", drpEstate.SelectedValue)}


                        Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_FieldEstate_Fetch]", params13)
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
                                '.SelectedIndex = retValue.Table.Rows(0).Item("fieldID")
                            End With

                        End If
                        ds.Dispose()
                    Catch ex As Exception
                        Response.Write(ex.Message)
                        caneLog.WriteLog(ex.Message, ex.StackTrace)
                    End Try

                    If txtStatus.Text = "1" Then
                        txtBinOG.ReadOnly = True
                        txtTareOG.ReadOnly = True
                        txtNetOG.ReadOnly = True
                        txtGrossWOG.ReadOnly = True
                        drpVarietyOG.Enabled = False
                        drpCycleOG.Enabled = False
                        drpSpaceOG.Enabled = False
                        rfvlBinOG.Enabled = False
                        rfvVarietyOG.Enabled = False
                        rfvSpaceOG.Enabled = False
                        rfvCycleOG.Enabled = False
                        lblSpacingOG.Visible = False
                        lblVarietyOG.Visible = False
                        drpSpaceOG.Visible = False
                        drpVarietyOG.Visible = False
                        lblCycleOG.Visible = False
                        drpCycleOG.Visible = False
                        sourceTruckListOG.Visible = False
                        TargetTruckListOG.Visible = False
                        lblAvailBin.Visible = False
                        lblSelBin.Visible = False
                        AddOneBin.Visible = False
                        RemoveBin.Visible = False
                    End If

                End If


            End If

            If IsPostBack Then

            End If
        Catch ex As Exception
            lblError.Text = "An Error Occurred. Please try again later"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try


    End Sub
    Public Sub Load_Truck_Source()
        Try
            'Get Dataset
            'Dim params3() As SqlParameter = {New SqlParameter("@UserName", Session("User")), _
            'New SqlParameter("@Department", txtDepartment.Text)}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_TruckSource_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            'Li.Value = "0"
            'Li.Text = "-- Select Roles(s) --"

            SourceTruckList.AppendDataBoundItems = True
            SourceTruckList.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With SourceTruckList
                    .DataSource = ds.Tables(0)
                    .DataTextField = "truck"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Public Sub Load_Truck_Target()
        Try
            'Get Dataset
            Dim params33() As SqlParameter = {New SqlParameter("@TripID", Request.QueryString(0).ToString())}
            'New SqlParameter("@Department", txtDepartment.Text)}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_TruckTarget_Fetch]", params33)
            Dim Li As ListItem
            Li = New ListItem
            'Li.Value = "0"
            'Li.Text = "-- Selected Truck(s) --"

            TargetTruckList.AppendDataBoundItems = True
            TargetTruckList.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With TargetTruckList
                    .DataSource = ds.Tables(0)
                    .DataTextField = "truck"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0

                End With

            End If

            ds.Dispose()

            For i As Integer = TargetTruckList.Items.Count - 1 To 0 Step -1
                If Not TargetTruckList.Items(i).Text.Contains(" ") Then
                    TargetTruckList.Items.RemoveAt(i)
                End If
            Next

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Public Sub Load_Truck_SourceOG()
        Try
            'Get Dataset
            'Dim params3() As SqlParameter = {New SqlParameter("@UserName", Session("User")), _
            'New SqlParameter("@Department", txtDepartment.Text)}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_TruckSource_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            'Li.Value = "0"
            'Li.Text = "-- Select Roles(s) --"

            SourceTruckListOG.AppendDataBoundItems = True
            SourceTruckListOG.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With SourceTruckListOG
                    .DataSource = ds.Tables(0)
                    .DataTextField = "truck"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Public Sub Load_Truck_TargetOG()
        Try
            'Get Dataset
            'Dim params3() As SqlParameter = {New SqlParameter("@UserName", Session("User")), _
            'New SqlParameter("@Department", txtDepartment.Text)}
            Dim params33() As SqlParameter = {New SqlParameter("@TripID", Request.QueryString(0).ToString())}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_TruckTargetOG_Fetch]", params33)
            Dim Li As ListItem
            Li = New ListItem
            'Li.Value = "0"
            'Li.Text = "-- Select Roles(s) --"

            TargetTruckListOG.AppendDataBoundItems = True
            TargetTruckListOG.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With TargetTruckListOG
                    .DataSource = ds.Tables(0)
                    .DataTextField = "truck"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

            For i As Integer = TargetTruckListOG.Items.Count - 1 To 0 Step -1
                If Not TargetTruckListOG.Items(i).Text.Contains(" ") Then
                    TargetTruckListOG.Items.RemoveAt(i)
                End If
            Next

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
            Li.Text = "-- Select Zone  --"

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
            Li.Text = "-- Select Zone  --"

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

    Public Sub Load_Estate()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Estate_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Estate  --"

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

    Public Sub Load_ShiftOG()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Shift_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Shift  --"

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
    Public Sub Load_Shift()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Shift_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Shift  --"

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
    Public Sub Load_Variety()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_variety_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select variety  --"

            drpVariety.AppendDataBoundItems = True
            drpVariety.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpVariety

                    .DataSource = ds.Tables(0)
                    .DataTextField = "variety"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    Public Sub Load_VarietyOG()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_variety_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select variety  --"

            drpVarietyOG.AppendDataBoundItems = True
            drpVarietyOG.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpVarietyOG

                    .DataSource = ds.Tables(0)
                    .DataTextField = "variety"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    Public Sub Load_Cycle()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_cropCycle_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select variety  --"

            drpCycle.AppendDataBoundItems = True
            drpCycle.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpCycle

                    .DataSource = ds.Tables(0)
                    .DataTextField = "cycle"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    Public Sub Load_CycleOG()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_cropCycle_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select variety  --"

            drpCycleOG.AppendDataBoundItems = True
            drpCycleOG.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpCycleOG

                    .DataSource = ds.Tables(0)
                    .DataTextField = "cycle"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    Public Sub Load_Spacing()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_spacing_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Spacing --"

            drpSpace.AppendDataBoundItems = True
            drpSpace.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpSpace

                    .DataSource = ds.Tables(0)
                    .DataTextField = "Spacing"
                    .DataValueField = "seqno"
                    .DataBind()
                    .SelectedIndex = 0
                End With

            End If
            ds.Dispose()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    Public Sub Load_SpacingOG()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_spacing_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Spacing  --"

            drpSpaceOG.AppendDataBoundItems = True
            drpSpaceOG.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpSpaceOG

                    .DataSource = ds.Tables(0)
                    .DataTextField = "spacing"
                    .DataValueField = "seqno"
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
            If Session("TransactionType") = "Savannah" Then
                If Val(txtTare.Text) = 0.00 Then
                    txtTare.Text = 0.00
                    txtNet.Text = 0.00

                    Button1.Visible = True
                    btnSubmit.Visible = False

                Else
                    'txtNet.Text = Val(txtTare.Text) - Val(txtGrossW.Text)
                    'Button1.Visible = True
                    'btnSubmit.Visible = False


                    'If TargetTruckList.Items.Count <= 0 Then
                    '    lblError.Text = "you must select a Truck and at least one Bin"
                    '    ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('YOU MUST SELECT A TRUCK AND AT LEAST ONE BIN');window.location='offloading.aspx';</script>'")
                    'Else
                    For i As Integer = 0 To TargetTruckList.Items.Count - 1
                        'Dim weightCal As Decimal = 0.00
                        Dim item As New ListItem()
                        item.Text = TargetTruckList.Items(i).Text
                        item.Value = TargetTruckList.Items(i).Value


                        Dim params2() As SqlParameter = {New SqlParameter("@value", item.Value)}

                        Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_TruckWeight_Edit_Fetch", params2).Tables(0).Rows(0)

                        Dim number As Integer = retValue3.Table.Rows(0).Item("seqno")
                        Dim weight As Decimal = retValue3.Table.Rows(0).Item("weight")
                        'Dim params3() As SqlParameter = {New SqlParameter("@item", item.Text),
                        '    New SqlParameter("@TripID", txtWeighInCode.Text),
                        '    New SqlParameter("@weight", weight)}
                        'SqlHelper.ExecuteNonQuery(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_TruckWeight_Insert", params3)

                        weightCal = weightCal + weight
                    Next

                    'For i As Integer = 0 To TargetBinList.Items.Count - 1

                    '    Dim item As New ListItem()
                    '    item.Text = TargetBinList.Items(i).Text
                    '    item.Value = TargetBinList.Items(i).Value


                    '    Dim params2() As SqlParameter = {New SqlParameter("@value", item.Value)}

                    '    Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_binWeight_Fetch", params2).Tables(0).Rows(0)

                    '    Dim number As Integer = retValue3.Table.Rows(0).Item("seqno")
                    '    Dim weight As Decimal = retValue3.Table.Rows(0).Item("weight")


                    '    weightCalB = weightCalB + weight
                    'Next

                    Dim TareWeight As Decimal = weightCal
                    txtTare.Text = TareWeight

                    Dim GrossW As Decimal = Val(txtGrossW.Text) - Val(txtTare.Text)
                    txtNet.Text = GrossW

                    Button1.Visible = True
                    btnSubmit.Visible = False



                    'txtNetWeight.Visible = True
                    'txtTareWeight.Visible = True
                    'lblTare.Visible = True
                    '    lblNet.Visible = True
                    '    SourceTruckList.Enabled = False
                    '    sourceBinList.Enabled = False
                    '    TargetBinList.Enabled = False
                    '    TargetTruckList.Enabled = False
                    '    lblTareCal.Text = TareWeight
                    '    lblNetCal.Text = GrossW


                    'txtNet.Text = Val(txtTare.Text) - Val(txtGrossW.Text)
                    'btnNet.Visible = False
                    'btnUpdate.Visible = True
                    'Session("Transcoder") = txtWeighInCode.Text

                    'End If

                End If
            Else
                If Val(txtTareOG.Text) = 0.00 Then
                    txtTareOG.Text = 0.00
                    txtNetOG.Text = 0.00

                    Button1.Visible = True
                    btnSubmit.Visible = False

                Else
                    'txtNet.Text = Val(txtTareOG.Text) - Val(txtGrossWOG.Text)
                    'Button1.Visible = True
                    'btnSubmit.Visible = False


                    'If TargetTruckList.Items.Count <= 0 Then
                    '    lblError.Text = "you must select a Truck and at least one Bin"
                    '    ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('YOU MUST SELECT A TRUCK AND AT LEAST ONE BIN');window.location='offloading.aspx';</script>'")
                    'Else
                    For i As Integer = 0 To TargetTruckListOG.Items.Count - 1
                        'Dim weightCal As Decimal = 0.00
                        Dim item As New ListItem()
                        item.Text = TargetTruckListOG.Items(i).Text
                        item.Value = TargetTruckListOG.Items(i).Value


                        Dim params2() As SqlParameter = {New SqlParameter("@value", item.Value)}

                        Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_TruckWeight_Edit_Fetch", params2).Tables(0).Rows(0)

                        Dim number As Integer = retValue3.Table.Rows(0).Item("seqno")
                        Dim weight As Decimal = retValue3.Table.Rows(0).Item("weight")
                        'Dim params3() As SqlParameter = {New SqlParameter("@item", item.Text),
                        '    New SqlParameter("@TripID", txtWeighInCode.Text),
                        '    New SqlParameter("@weight", weight)}
                        'SqlHelper.ExecuteNonQuery(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_TruckWeight_Insert", params3)

                        weightCal = weightCal + weight
                    Next


                    Dim TareWeight As Decimal = weightCal
                    txtTareOG.Text = TareWeight

                    Dim GrossW As Decimal = Val(txtGrossWOG.Text) - Val(txtTareOG.Text)
                    txtNetOG.Text = GrossW

                    Button1.Visible = True
                    btnSubmit.Visible = False


                End If
            End If
        Catch ex As Exception
            lblError.Text = "An Exception Occurred, please try again"
        caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try





    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Session("TransactionType") = "Savannah" Then
                If txtStatus.Text <> "1" Then
                    Dim params1() As SqlParameter = {New SqlParameter("@estate", (drpEstate.SelectedValue)),
                                            New SqlParameter("@field", (drpField.SelectedValue)),
                                            New SqlParameter("@zone", (drpZone.SelectedValue)),
                                            New SqlParameter("@cycle", (drpCycle.SelectedValue)),
                                            New SqlParameter("@space", (drpSpace.SelectedValue)),
                                            New SqlParameter("@variety", (drpVariety.SelectedValue)),
                                            New SqlParameter("@TransCode", (txtCode.Text)),
                                            New SqlParameter("@shift", (drpShift.SelectedValue)),
                                            New SqlParameter("@truckNum", (txtTruckNo.Text)),
                                            New SqlParameter("@BinNo", (txtBIN.Text)),
                                            New SqlParameter("@GrossWeight", Val(txtGrossW.Text)),
                                            New SqlParameter("@Driver", (txtDriver.Text)),
                                            New SqlParameter("@DriverNum", (txtDrvNum.Text)),
                                            New SqlParameter("@TareWeight", (txtTare.Text)),
                                            New SqlParameter("@NetWeight", (txtNet.Text)),
                                            New SqlParameter("@TruckModel", (txtTruckModel.Text))}

                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_update", params1)

                    Dim params0() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}
                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_pre_update_History_temp", params0)

                    'Dim params10() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}

                    'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_ChangeReason_History_Update", params10)





                    ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Transaction Details Updated Succesfully');window.location='Dashboard.aspx';</script>'")


                Else
                    Dim params1() As SqlParameter = {New SqlParameter("@estate", (drpEstate.SelectedValue)),
                                            New SqlParameter("@field", (drpField.SelectedValue)),
                                            New SqlParameter("@zone", (drpZone.SelectedValue)),
                                            New SqlParameter("@TransCode", (txtCode.Text)),
                                            New SqlParameter("@shift", (drpShift.SelectedValue)),
                                            New SqlParameter("@truckNum", (txtTruckNo.Text)),
                                            New SqlParameter("@BinNo", (txtBIN.Text)),
                                            New SqlParameter("@GrossWeight", Val(txtGrossW.Text)),
                                            New SqlParameter("@Driver", (txtDriver.Text)),
                                            New SqlParameter("@DriverNum", (txtDrvNum.Text)),
                                            New SqlParameter("@TareWeight", (txtTare.Text)),
                                            New SqlParameter("@NetWeight", (txtNet.Text)),
                                            New SqlParameter("@TruckModel", (txtTruckModel.Text))}

                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_update_curl", params1)

                    Dim params0() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}
                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_pre_update_History_temp", params0)

                    'Dim params10() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}

                    'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_ChangeReason_History_Update", params10)





                    ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Transaction Details Updated Succesfully');window.location='Dashboard.aspx';</script>'")

                End If

            Else
                If txtStatus.Text <> "1" Then
                    Dim params1() As SqlParameter = {New SqlParameter("@estate", (drpEstateOG.Text)),
                                             New SqlParameter("@field", (drpFieldOG.Text)),
                                             New SqlParameter("@zone", (drpZoneOG.SelectedValue)),
                                             New SqlParameter("@cycle", (drpCycleOG.SelectedValue)),
                                             New SqlParameter("@space", (drpSpaceOG.SelectedValue)),
                                             New SqlParameter("@variety", (drpVarietyOG.SelectedValue)),
                                             New SqlParameter("@TransCode", (txtCodeOG.Text)),
                                             New SqlParameter("@shift", (drpShiftOG.SelectedValue)),
                                             New SqlParameter("@truckNum", (txtTruckNoOG.Text)),
                                             New SqlParameter("@BinNo", (txtBinOG.Text)),
                                             New SqlParameter("@Farmer", (txtFarmerOG.Text)),
                                             New SqlParameter("@GrossWeight", Val(txtGrossWOG.Text)),
                                             New SqlParameter("@Driver", (txtDriverOG.Text)),
                                             New SqlParameter("@DriverNum", (txtDrvNumOG.Text)),
                                             New SqlParameter("@TareWeight", (txtTareOG.Text)),
                                             New SqlParameter("@NetWeight", (txtNetOG.Text)),
                                             New SqlParameter("@TruckModel", (txtTruckModelOG.Text))}

                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_update_OG", params1)

                    Dim params0() As SqlParameter = {New SqlParameter("@TransCode", (txtCodeOG.Text))}
                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_pre_update_History_temp", params0)

                    'Dim params10() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}

                    'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_ChangeReason_History_Update", params10)




                    ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Transaction Details Updated Succesfully');window.location='Dashboard.aspx';</script>'")
                Else

                    Dim params1() As SqlParameter = {New SqlParameter("@estate", (drpEstateOG.Text)),
                                             New SqlParameter("@field", (drpFieldOG.Text)),
                                             New SqlParameter("@zone", (drpZoneOG.SelectedValue)),
                                             New SqlParameter("@TransCode", (txtCodeOG.Text)),
                                             New SqlParameter("@shift", (drpShiftOG.SelectedValue)),
                                             New SqlParameter("@truckNum", (txtTruckNoOG.Text)),
                                             New SqlParameter("@BinNo", (txtBinOG.Text)),
                                             New SqlParameter("@Farmer", (txtFarmerOG.Text)),
                                             New SqlParameter("@GrossWeight", Val(txtGrossWOG.Text)),
                                             New SqlParameter("@Driver", (txtDriverOG.Text)),
                                             New SqlParameter("@DriverNum", (txtDrvNumOG.Text)),
                                             New SqlParameter("@TareWeight", (txtTareOG.Text)),
                                             New SqlParameter("@NetWeight", (txtNetOG.Text)),
                                             New SqlParameter("@TruckModel", (txtTruckModelOG.Text))}

                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_update_OG_curl", params1)

                    Dim params0() As SqlParameter = {New SqlParameter("@TransCode", (txtCodeOG.Text))}
                    SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_weighIn_pre_update_History_temp", params0)

                    'Dim params10() As SqlParameter = {New SqlParameter("@TransCode", (txtCode.Text))}

                    'SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_ChangeReason_History_Update", params10)




                    ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('Transaction Details Updated Succesfully');window.location='Dashboard.aspx';</script>'")


                End If


            End If
        Catch ex As Exception
            lblError.Text = "An Exception occured. Please try again"
        caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try


    End Sub
    Protected Sub AddAllTruck_Click(sender As Object, e As EventArgs) Handles AddAllTruck.Click
        TargetTruckList.SelectedIndex = -1
        Dim li As ListItem
        For Each li In SourceTruckList.Items
            AddTruckItem(li)
        Next
    End Sub
    Protected Sub AddOneTruck_Click(sender As Object, e As EventArgs) Handles AddOneTruck.Click
        If SourceTruckList.SelectedIndex >= 0 Then
            AddTruckItem(SourceTruckList.SelectedItem)
            RemoveTruckItem(SourceTruckList.SelectedItem)
        End If
    End Sub
    Protected Sub RemoveTruck_Click(sender As Object, e As EventArgs) Handles RemoveTruck.Click
        If TargetTruckList.SelectedIndex >= 0 Then
            TargetTruckList.Items.RemoveAt(TargetTruckList.SelectedIndex)
            TargetTruckList.SelectedIndex = -1
        End If
    End Sub
    Protected Sub AllBin_Click(sender As Object, e As EventArgs) Handles AllBin.Click
        TargetTruckListOG.SelectedIndex = -1
        Dim li As ListItem
        For Each li In sourceTruckListOG.Items
            AddBinItem(li)
        Next
    End Sub
    Protected Sub AddOneBin_Click(sender As Object, e As EventArgs) Handles AddOneBin.Click
        If SourceTruckList.SelectedIndex >= 0 Then
            AddBinItem(SourceTruckList.SelectedItem)
            RemoveBinItem(SourceTruckList.SelectedItem)
        End If
    End Sub
    Protected Sub RemoveBin_Click(sender As Object, e As EventArgs) Handles RemoveBin.Click
        If TargetTruckListOG.SelectedIndex >= 0 Then
            TargetTruckListOG.Items.RemoveAt(TargetTruckListOG.SelectedIndex)
            TargetTruckListOG.SelectedIndex = -1
        End If
    End Sub
    Protected Sub AddTruckItem(ByVal li As ListItem)
        TargetTruckList.SelectedIndex = -1
        TargetTruckList.Items.Add(li)
        'If Me.AllowDuplicates = True Then
        '    TargetList.Items.Add(li)
        'Else
        '    If TargetList.Items.FindByText(li.Text) Is Nothing Then
        '        TargetList.Items.Add(li)
        '    End If
        'End If

    End Sub
    Protected Sub AddBinItem(ByVal li As ListItem)
        TargetTruckListOG.SelectedIndex = -1
        TargetTruckListOG.Items.Add(li)
        'If Me.AllowDuplicates = True Then
        '    TargetList.Items.Add(li)
        'Else
        '    If TargetList.Items.FindByText(li.Text) Is Nothing Then
        '        TargetList.Items.Add(li)
        '    End If
        'End If

    End Sub
    Protected Sub RemoveBinItem(ByVal li As ListItem)
        If sourceTruckListOG.SelectedIndex >= 0 Then
            sourceTruckListOG.Items.RemoveAt(sourceTruckListOG.SelectedIndex)
            sourceTruckListOG.SelectedIndex = -1

        End If

    End Sub
    Protected Sub RemoveTruckItem(ByVal li As ListItem)
        If SourceTruckList.SelectedIndex >= 0 Then
            SourceTruckList.Items.RemoveAt(SourceTruckList.SelectedIndex)
            SourceTruckList.SelectedIndex = -1

        End If

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
End Class
