Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class WeighOut
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Dim randomGen As String
    Dim Resultx As Boolean
    'Dim weightCalB As Decimal = 0.00
    Dim weightCal As Decimal = 0.00
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then

                If Not Session("AdminOk") = True Then Response.Redirect("LogOut.aspx")

                txtUsername.Text = Session("User")
                txtRole.Text = Session("Role")

                Load_variety()
                Load_Cycle()
                Load_spacing()


            End If

            If IsPostBack Then

            End If
        Catch ex As Exception
            lblError.Text = "An Exception occured, Please TryCast Again"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try


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
                'txtBIN.Text = retValue1.Table.Rows(0).Item("BinNumber")
                txtTruckNo.Text = retValue1.Table.Rows(0).Item("TruckNumber")
                'txtGrossW.Text = retValue1.Table.Rows(0).Item("TareWeight")
                txtTimeIn.Text = retValue1.Table.Rows(0).Item("TimeIn")
                Load_Bins()
                Load_Trucks()


            End If
        Catch ex As Exception
            lblError.Text = "Code Entered Doesn't Exist or Has Been Cleared"
        caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try




    End Sub

    'Protected Sub txtTare_TextChanged(sender As Object, e As EventArgs) Handles txtTare.TextChanged
    'lblError.Text = "AutoPostBackControl"

    '
    'End Sub
    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            For i As Integer = 0 To TargetTruckList.Items.Count - 1
                'Dim weightCal As Decimal = 0.00
                Dim item As New ListItem()
                item.Text = TargetTruckList.Items(i).Text
                item.Value = TargetTruckList.Items(i).Value


                Dim params2() As SqlParameter = {New SqlParameter("@value", item.Value)}

                Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_TruckWeight_Fetch", params2).Tables(0).Rows(0)

                Dim number As Integer = retValue3.Table.Rows(0).Item("seqno")
                Dim weight As Decimal = retValue3.Table.Rows(0).Item("weight")
                Dim params3() As SqlParameter = {New SqlParameter("@item", item.Text),
                    New SqlParameter("@TripID", txtWeighInCode.Text),
                    New SqlParameter("@weight", weight)}
                SqlHelper.ExecuteNonQuery(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_TruckWeight_Insert", params3)


            Next

            For i As Integer = 0 To TargetBinList.Items.Count - 1
                ' Dim weightCalB As Decimal = 0.00
                Dim item As New ListItem()
                item.Text = TargetBinList.Items(i).Text
                item.Value = TargetBinList.Items(i).Value


                Dim params2() As SqlParameter = {New SqlParameter("@value", item.Value)}

                Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_binWeight_Fetch", params2).Tables(0).Rows(0)

                Dim number As Integer = retValue3.Table.Rows(0).Item("seqno")
                Dim weight As Decimal = retValue3.Table.Rows(0).Item("weight")

                Dim params3() As SqlParameter = {New SqlParameter("@item", item.Text),
                    New SqlParameter("@TripID", txtWeighInCode.Text),
                    New SqlParameter("@weight", weight)}
                SqlHelper.ExecuteNonQuery(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_binWeight_Insert", params3)


            Next

            Dim paramss() As SqlParameter = {New SqlParameter("@Transcode", txtWeighInCode.Text),
                                             New SqlParameter("@NetWeight", Val(txtNetWeight.Text)),
                                             New SqlParameter("@GrossWeight", Val(txtGrossWeightx.Text)),
                                             New SqlParameter("@TareWeight", Val(txtTareWeight.Text)),
                                             New SqlParameter("@BinNo", (txtBIN.Text)),
                                             New SqlParameter("@cropCycle", (drpCropCycle.SelectedValue)),
                                             New SqlParameter("@spacing", (drpSpacing.SelectedValue)),
                                             New SqlParameter("@variety", (drpVariety.SelectedValue)),
                                             New SqlParameter("@User", Session("User"))}
            SqlHelper.ExecuteNonQuery(Connstring, CommandType.StoredProcedure, "caneWeigh_wieghOut_update", paramss)

            ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('TRUCK-OUT Created Successfully. Please Print Ticket');window.location='PrintWeighOut.aspx';</script>'")
        Catch ex As Exception
            lblError.Text = "An Exception Occurred. Please Try Again"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try


    End Sub
    Protected Sub btnNet_Click(sender As Object, e As EventArgs) Handles btnNet.Click
        Try
            If TargetTruckList.Items.Count <= 0 Then
                lblError.Text = "you must select a Truck and at least one Bin"
                ClientScript.RegisterStartupScript(Me.GetType(), "Success", "<script type='text/javascript'>alert('YOU MUST SELECT A TRUCK AND AT LEAST ONE BIN');window.location='offloading.aspx';</script>'")
            Else
                For i As Integer = 0 To TargetTruckList.Items.Count - 1
                    'Dim weightCal As Decimal = 0.00
                    Dim item As New ListItem()
                    item.Text = TargetTruckList.Items(i).Text
                    item.Value = TargetTruckList.Items(i).Value


                    Dim params2() As SqlParameter = {New SqlParameter("@value", item.Value)}

                    Dim retValue3 As Data.DataRow = SqlHelper.ExecuteDataset(Connstring, Data.CommandType.StoredProcedure, "caneWeigh_TruckWeight_Fetch", params2).Tables(0).Rows(0)

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
                txtTareWeight.Text = TareWeight

                Dim GrossW As Decimal = Val(txtGrossWeightx.Text) - Val(txtTareWeight.Text)
                txtNetWeight.Text = GrossW



                'txtNetWeight.Visible = True
                'txtTareWeight.Visible = True
                lblTare.Visible = True
                lblNet.Visible = True
                SourceTruckList.Enabled = False
                sourceBinList.Enabled = False
                TargetBinList.Enabled = False
                TargetTruckList.Enabled = False
                lblTareCal.Text = TareWeight
                lblNetCal.Text = GrossW


                'txtNet.Text = Val(txtTare.Text) - Val(txtGrossW.Text)
                btnNet.Visible = False
                btnUpdate.Visible = True
                Session("Transcoder") = txtWeighInCode.Text

            End If


        Catch ex As Exception
            lblError.Text = "An Exception Occurred. Please Try Again"
            caneLog.WriteLog(ex.Message, ex.StackTrace)
        End Try

    End Sub
    Public Sub Load_variety()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_variety_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select variety --"

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
    Public Sub Load_spacing()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_Spacing_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Spacing --"

            drpSpacing.AppendDataBoundItems = True
            drpSpacing.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpSpacing

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
    Public Sub Load_Cycle()
        Try


            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_cropCycle_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            Li.Value = "0"
            Li.Text = "-- Select Crop Cycle --"

            drpCropCycle.AppendDataBoundItems = True
            drpCropCycle.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With drpCropCycle

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
    Public Sub Load_Trucks()
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
    Public Sub Load_Bins()
        Try
            'Get Dataset
            'Dim params3() As SqlParameter = {New SqlParameter("@UserName", Session("User")), _
            'New SqlParameter("@Department", txtDepartment.Text)}

            Dim ds As DataSet = SqlHelper.ExecuteDataset(Connstring, CommandType.StoredProcedure, "[dbo].[caneWeigh_BinSource_Fetch]")
            Dim Li As ListItem
            Li = New ListItem
            'Li.Value = "0"
            'Li.Text = "-- Select Roles(s) --"

            sourceBinList.AppendDataBoundItems = True
            sourceBinList.Items.Add(Li)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                With sourceBinList
                    .DataSource = ds.Tables(0)
                    .DataTextField = "bin"
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
        TargetBinList.SelectedIndex = -1
        Dim li As ListItem
        For Each li In sourceBinList.Items
            AddBinItem(li)
        Next
    End Sub
    Protected Sub AddOneBin_Click(sender As Object, e As EventArgs) Handles AddOneBin.Click
        If sourceBinList.SelectedIndex >= 0 Then
            AddBinItem(sourceBinList.SelectedItem)
            RemoveBinItem(sourceBinList.SelectedItem)
        End If
    End Sub
    Protected Sub RemoveBin_Click(sender As Object, e As EventArgs) Handles RemoveBin.Click
        If TargetBinList.SelectedIndex >= 0 Then
            TargetBinList.Items.RemoveAt(TargetBinList.SelectedIndex)
            TargetBinList.SelectedIndex = -1
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
        TargetBinList.SelectedIndex = -1
        TargetBinList.Items.Add(li)
        'If Me.AllowDuplicates = True Then
        '    TargetList.Items.Add(li)
        'Else
        '    If TargetList.Items.FindByText(li.Text) Is Nothing Then
        '        TargetList.Items.Add(li)
        '    End If
        'End If

    End Sub
    Protected Sub RemoveBinItem(ByVal li As ListItem)
        If sourceBinList.SelectedIndex >= 0 Then
            sourceBinList.Items.RemoveAt(sourceBinList.SelectedIndex)
            sourceBinList.SelectedIndex = -1

        End If

    End Sub
    Protected Sub RemoveTruckItem(ByVal li As ListItem)
        If SourceTruckList.SelectedIndex >= 0 Then
            SourceTruckList.Items.RemoveAt(SourceTruckList.SelectedIndex)
            SourceTruckList.SelectedIndex = -1

        End If

    End Sub
End Class
