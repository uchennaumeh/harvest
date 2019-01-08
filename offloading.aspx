<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="offloading.aspx.vb" Inherits="WeighOut" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="OFFLOADING" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="TRUCK OFFLOADING" ForeColor=""></asp:Label></h1>
                                </td>
                                <td></td>
                                <td align="right">
                                    <asp:Image ID="Image1" ImageAlign="right" runat="server" ImageUrl="~/images/dangote.png" />
                                </td>
                            </tr>
                          <%--  <tr>
                                <td align="left">
                                    <p>Please Provide Accurate Details!</p>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>--%>
                        </table>



                        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="col-md-3 control-label">TRIP ID</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtWeighInCode" runat="server" class="form-control"></asp:TextBox>

                                        </div>

                                        <asp:RequiredFieldValidator ID="rfvlWINCOde" runat="server" ErrorMessage="***" ControlToValidate="txtWeighInCode" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <br />
                             <%--   <br />
                                <br />--%>

                            </div>
                            <asp:Button ID="btnCode" runat="server" Text="CHECK CODE" class="btn btn-primary btn-lg pull-left" />
                        </div>

                        <asp:Panel ID="Panel1" runat="server" Visible="false">
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Field</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtField" ReadOnly="true" runat="server" class="form-control input-md" BackColor="#CCFFFF"></asp:TextBox>
                                                </div>



                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Shift</label>
                                            <div class="col-md-9">

                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtShift" BackColor="#CCFFFF" ReadOnly="true" runat="server" class="form-control input-md">
                                                        
                                                    </asp:TextBox>

                                                </div>

                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />

                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Time In</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTimeIn" BackColor="#CCFFFF" runat="server" ReadOnly="true" class="form-control input-md"></asp:TextBox>
                                                </div>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />


                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Driver</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtDriver" BackColor="#CCFFFF" ReadOnly="true" runat="server" class="form-control input-md">
                                                        
                                                    </asp:TextBox>


                                                </div>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Truck Number</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTruckNo" BackColor="#CCFFFF" ReadOnly="true" runat="server" class="form-control input-md"></asp:TextBox>


                                                </div>


                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">BIN Number(s)*</label>
                                            <div class="col-md-9">

                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtBIN" runat="server" class="form-control input-md"></asp:TextBox>

                                                </div>
                                                <asp:RequiredFieldValidator ID="rfvBin" runat="server" ErrorMessage="***" ControlToValidate="txtBIN" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />



                                    </div>
                                    <div class="col-md-4">
                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Crop Cycle*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:DropDownList ID="drpCropCycle" runat="server" class="form-control input-md" Width="300px"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvCropCycle" runat="server" ErrorMessage="***" ControlToValidate="drpCropCycle" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Spacing*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:DropDownList ID="drpSpacing" runat="server" class="form-control input-md" Width="300px"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvSpacing" runat="server" ErrorMessage="***" ControlToValidate="drpSpacing" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Variety*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:DropDownList ID="drpVariety" runat="server" class="form-control input-md" Width="300px"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvVariety" runat="server" ErrorMessage="***" ControlToValidate="drpVariety" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />
                                        <%--<div class="form-group">
                                            <label class="col-md-3 control-label">Tare Weight</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtGrossW" BackColor="#CCFFFF" runat="server" ReadOnly="true" class="form-control input-md" TextMode="Number"></asp:TextBox>
                                                </div>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />--%>
                                        <%--<div class="form-group">
                                            <label class="col-md-3 control-label">Gross Weight*</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTare" runat="server" class="form-control input-md" TextMode="Number" ViewStateMode="Enabled"></asp:TextBox>


                                                </div>
                                                <asp:RequiredFieldValidator ID="rfvlTare" runat="server" ErrorMessage="***" ControlToValidate="txtTare"></asp:RequiredFieldValidator>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Net Weight</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtNet" runat="server" ReadOnly="true" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                                </div>


                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />--%>

                                    </div>

                                </div>
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Gross Weight*</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtGrossWeightx" runat="server" TextMode="Number" class="form-control input-md"></asp:TextBox>


                                                </div>

                                                <asp:RequiredFieldValidator ID="rfvGross" runat="server" ErrorMessage="***" ControlToValidate="txtGrossWeightx" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">
                                                <asp:Label ID="lblTare" runat="server" Text="Tare Weight" Visible="false"></asp:Label></label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <%--<span class="input-group-addon"><span class="fa fa-pencil"></span></span>--%>
                                                    <asp:Label ID="lblTareCal" runat="server" Text="" Font-Bold="true" Font-Size="Large" ForeColor="#000066"></asp:Label>
                                                    <%--<asp:TextBox ID="ff" runat="server" Visible="false" ReadOnly="true" class="form-control input-md"></asp:TextBox>--%>


                                                </div>


                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">
                                                <asp:Label ID="lblNet" runat="server" Text="Net Weight" Visible="false"></asp:Label></label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <%--<span class="input-group-addon"><span class="fa fa-pencil"></span></span>--%>
                                                    <asp:Label ID="lblNetCal" runat="server" Text="" Font-Bold="true" Font-Size="Large" ForeColor="#000066"></asp:Label>
                                                    <%--<asp:TextBox ID="tt" runat="server" Visible="false" ReadOnly="true" class="form-control input-md"></asp:TextBox>--%>


                                                </div>


                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <br />
                                <br />
                                <div class="row">
                                    <div class="col-md-6">
                                        <asp:Panel ID="Panel2" runat="server" Visible="TRUE">
                                            <table class="auto-style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblAvailTruck" runat="server" Text="AVAILABLE TRUCKS" Font-Bold="true"></asp:Label><br />
                                                        <br />
                                                        <asp:ListBox ID="SourceTruckList" runat="server" Height="200px" class="form-control input-md" Width="200px"></asp:ListBox>
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="AddAllTruck" Visible="false" runat="server" Text=">>" Width="100px" class="btn btn-info" Height="50px" />
                                                        <br />
                                                        <br />
                                                        <asp:Button ID="AddOneTruck" runat="server" Text=">" Width="100px" class="btn btn-info" Height="50px" />
                                                        <br />
                                                        <br />
                                                        <asp:Button ID="RemoveTruck" runat="server" Text="X" Width="100px" class="btn btn-info" Height="50px" />
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblSelTruck" runat="server" Text="SELECTED TRUCK(S)" Font-Bold="true"></asp:Label><br />
                                                        <br />
                                                        <asp:ListBox ID="TargetTruckList" runat="server" Height="200px" class="form-control input-md" Width="200px"></asp:ListBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <br />

                                        </asp:Panel>
                                        <br />
                                        <br />
                                        <br />

                                    </div>
                                    <div class="col-md-6">
                                        <asp:Panel ID="Panel3" runat="server" Visible="false">
                                            <table class="auto-style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblAvailBin" runat="server" Text="AVAILABLE BINS" Font-Bold="true"></asp:Label><br />
                                                        <br />
                                                        <asp:ListBox ID="sourceBinList" runat="server" Height="200px" class="form-control input-md" Width="200px"></asp:ListBox>
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="AllBin" runat="server" Text=">>" Width="100px" class="btn btn-info" Height="50px" />
                                                        <br />
                                                        <br />
                                                        <asp:Button ID="AddOneBin" runat="server" Text=">" Width="100px" class="btn btn-info" Height="50px" />
                                                        <br />
                                                        <br />
                                                        <asp:Button ID="RemoveBin" runat="server" Text="X" Width="100px" class="btn btn-info" Height="50px" />
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblSelBin" runat="server" Text="SELECTED BIN(S)" Font-Bold="true"></asp:Label><br />
                                                        <br />
                                                        <asp:ListBox ID="TargetBinList" runat="server" Height="200px" class="form-control input-md" Width="200px"></asp:ListBox>
                                                    </td>
                                                </tr>
                                            </table>
                                          
                                        </asp:Panel>
                        

                                    </div>




                                </div>
                                <%--                                <div class="row">
                                    
                                </div>--%>
                                
                            </div>

                            <div class="panel-footer">
                                <asp:Button ID="btnNet" runat="server" class="btn btn-primary btn-lg pull-left" Text="NET WEIGHT" /><br />
                                <asp:Button ID="btnUpdate" runat="server" Visible="false" class="btn btn-info btn-lg pull-right" Text="SUBMIT" />

                            </div>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
    </div>



    <table align="center" cellpadding="2" style="width: 70%">
        <tr>
            <td>
                <asp:TextBox ID="txtUsername" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtRole" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtBranch" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDepartment" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtStaffID" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCount" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtNewCount" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtTareWeight" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtNetWeight" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>

