<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EditTrans.aspx.vb" MaintainScrollPositionOnPostback="true" Inherits="EditTrans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="EDIT TRANSACTION" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="Modify Transaction" ForeColor="#CC0000"></asp:Label></h1>
                                </td>
                                <td></td>
                                <td align="right">
                                    <asp:Image ID="Image1" ImageAlign="right" runat="server" ImageUrl="~/images/dangote.png" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <p>Please Provide Accurate Details!</p>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>



                        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <asp:Panel ID="Panel1" Visible="false" runat="server">
                            <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Trip ID</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtCode" runat="server" BackColor="#CCFFFF" ReadOnly="true" class="form-control input-md"></asp:TextBox>
                                        </div>



                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Driver Fullnames</label>
                                    <div class="col-md-9">

                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtDriver" runat="server" class="form-control input-md">                                                        
                                            </asp:TextBox>

                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvlDrv" runat="server" ErrorMessage="***" ControlToValidate="txtDriver" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Driver Number</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtDrvNum" runat="server" class="form-control input-md"> </asp:TextBox>

                                        </div>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="***" ControlToValidate="txtDrvNum" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>


                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Tare Weight</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtTare" runat="server" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                        </div>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="***" ControlToValidate="txtTare" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>


                                </div>
                                <br />
                                <br />
                                <br />


                                <div class="form-group">
                                    <label class="col-md-3 control-label">Net Weight</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtNet" runat="server" ReadOnly="true" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                        </div>
                                        <br />
                                        <br />
                                        <br />

                                    </div>
                                    </div>
                                </div>
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Truck Model</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTruckModel" runat="server" class="form-control input-md"></asp:TextBox>



                                                </div>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="***" ControlToValidate="txtTruckModel" ForeColor="Red"></asp:RequiredFieldValidator>

                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">BIN Number</label>
                                            <div class="col-md-9">

                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtBIN" runat="server" class="form-control input-md"></asp:TextBox>


                                                </div>
                                                <asp:RequiredFieldValidator ID="rfvlBIN" runat="server" ErrorMessage="***" ControlToValidate="txtBIN" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Truck Number</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTruckNo" runat="server" class="form-control input-md"></asp:TextBox>


                                                </div>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="***" ControlToValidate="txtTruckNo" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            </div>
                                            <br />
                                            <br />
                                            <br />

                                        
                                        
                                         <div class="form-group">
                                        <label class="col-md-3 control-label">Gross Weight</label>
                                        <div class="col-md-9 col-xs-12">
                                            <div class="input-group">
                                                <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                <asp:TextBox ID="txtGrossW" runat="server" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                            </div>
                                            <asp:RequiredFieldValidator ID="rfvlGross" runat="server" ErrorMessage="***" ControlToValidate="txtGrossW" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>


                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                        <div class="form-group">
                                        <label class="col-md-3 control-label">
                                            <asp:Label ID="lblCycle" runat="server" Text="Cycle"></asp:Label></label>
                                        <div class="col-md-9 col-xs-12">
                                            <div class="input-group">
                                                
                                                
                                                <asp:DropDownList ID="drpCycle" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>

                                            </div>
                                            
                                            <asp:RequiredFieldValidator ID="rfvCycle" runat="server" ErrorMessage="***" ControlToValidate="drpCycle" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
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
                                                    <strong>&nbsp;&nbsp;&nbsp;Estate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:DropDownList ID="drpEstate" runat="server" AutoPostBack="true" class="form-control input-md" Width="300px"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvlEstate" runat="server" ErrorMessage="***" ControlToValidate="drpEstate" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Field&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:DropDownList ID="drpField" runat="server" class="form-control input-md" Width="300px"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvField" runat="server" ErrorMessage="***" ControlToValidate="drpField" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Zone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:DropDownList ID="drpZone" runat="server" class="form-control input-md" Width="300px"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvZone" runat="server" ErrorMessage="***" ControlToValidate="drpZone" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Shift&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                   
                                                  <asp:DropDownList ID="drpShift" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvShift" runat="server" ErrorMessage="***" ControlToValidate="drpShift" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />
                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSpacing" runat="server" Text="Spacing"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                   
                                                  <asp:DropDownList ID="drpSpace" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvSpace" runat="server" ErrorMessage="***" ControlToValidate="drpSpace" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />
                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblVariety" runat="server" Text="Variety"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                   
                                                  <asp:DropDownList ID="drpVariety" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvVariety" runat="server" ErrorMessage="***" ControlToValidate="drpVariety" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />                                       

                                    </div>

                                

                            </div>
                            <div class="row">
                                    <div class="col-md-6">
                                        <asp:Panel ID="Panel3" runat="server" Visible="true">
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
                                    




                                </div>
                        </asp:Panel>
                        <asp:Panel ID="Panel2" visible="false" runat="server">
                            <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Trip ID </label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtCodeOG" runat="server" BackColor="#CCFFFF" ReadOnly="true" class="form-control input-md"></asp:TextBox>
                                        </div>



                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Driver Fullnames</label>
                                    <div class="col-md-9">

                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtDriverOG" runat="server" class="form-control input-md">                                                        
                                            </asp:TextBox>

                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvDrvOG" runat="server" ErrorMessage="***" ControlToValidate="txtDriverOG" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Driver Number</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtDrvNumOG" runat="server" class="form-control input-md"> </asp:TextBox>

                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvDrvNumOG" runat="server" ErrorMessage="***" ControlToValidate="txtDrvNumOG" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>


                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Tare Weight</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtTareOG" runat="server" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvTareOG" runat="server" ErrorMessage="***" ControlToValidate="txtTareOG" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>


                                </div>
                                <br />
                                <br />
                                <br />


                                <div class="form-group">
                                    <label class="col-md-3 control-label">Net Weight</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtNetOG" runat="server" ReadOnly="true" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                        </div>
                                        <br /><br />
            

                                    </div>
                                    </div>
                                <div class="form-group">
                                    <label class="col-md-3 control-label">
                                        <asp:Label ID="lblSpacingOG" runat="server" Text="Spacing"></asp:Label></label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            
                                            <%--<asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" class="form-control input-md" TextMode="Number"></asp:TextBox>--%>
                                            <asp:DropDownList ID="drpSpaceOG" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>
                                                    


                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvSpaceOG" runat="server" ErrorMessage="***" ControlToValidate="drpSpaceOG" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                        <br />
                                        <br />

                                    </div>
                                    </div>
                                </div>
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Truck Model</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTruckModelOG" runat="server" class="form-control input-md"></asp:TextBox>



                                                </div>
                                                <asp:RequiredFieldValidator ID="rfvTruckmodelOG" runat="server" ErrorMessage="***" ControlToValidate="txtTruckModelOG" ForeColor="Red"></asp:RequiredFieldValidator>

                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">BIN Number</label>
                                            <div class="col-md-9">

                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtBinOG" runat="server" class="form-control input-md"></asp:TextBox>


                                                </div>
                                                <asp:RequiredFieldValidator ID="rfvlBinOG" runat="server" ErrorMessage="***" ControlToValidate="txtBinOG" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Truck Number</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTruckNoOG" runat="server" class="form-control input-md"></asp:TextBox>


                                                </div>
                                                <asp:RequiredFieldValidator ID="rfvTruckNoOG" runat="server" ErrorMessage="***" ControlToValidate="txtTruckNoOG" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            </div>
                                            <br />
                                            <br />
                                            <br />
                                        <div class="form-group">
                                        <label class="col-md-3 control-label">Farmer Name*</label>
                                        <div class="col-md-9 col-xs-12">
                                            <div class="input-group">
                                                <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                <asp:TextBox ID="txtFarmerOG" runat="server" class="form-control input-md"></asp:TextBox>


                                            </div>
                                            <asp:RequiredFieldValidator ID="rfvFarmer" runat="server" ErrorMessage="***" ControlToValidate="txtFarmerOG" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>


                                    </div>
                                         <br />
                                            <br />
                                            <br />
                                        
                                        
                                         <div class="form-group">
                                        <label class="col-md-3 control-label">Gross Weight</label>
                                        <div class="col-md-9 col-xs-12">
                                            <div class="input-group">
                                                <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                <asp:TextBox ID="txtGrossWOG" runat="server" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                            </div>
                                            <asp:RequiredFieldValidator ID="rfvGrossOG" runat="server" ErrorMessage="***" ControlToValidate="txtGrossWOG" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>


                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                         <div class="form-group">
                                        <label class="col-md-3 control-label">
                                            <asp:Label ID="lblVarietyOG" runat="server" Text="Variety"></asp:Label></label>
                                        <div class="col-md-9 col-xs-12">
                                            <div class="input-group">
                                                
                                                <%--<asp:TextBox ID="TextBox1" runat="server" class="form-control input-md" TextMode="Number"></asp:TextBox>--%>
                                                <asp:DropDownList ID="drpVarietyOG" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>
                                                    


                                            </div>
                                            <asp:RequiredFieldValidator ID="rfvVarietyOG" runat="server" ErrorMessage="***" ControlToValidate="drpVarietyOG" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
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
                                                    <strong>&nbsp;&nbsp;&nbsp;Estate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:TextBox ID="drpEstateOG" runat="server" class="form-control input-md" Width="300px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvDrpEstateOG" runat="server" ErrorMessage="***" ControlToValidate="drpEstateOG"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Field&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:TextBox ID="drpFieldOG" runat="server" class="form-control input-md" Width="300px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvFieldOG" runat="server" ErrorMessage="***" ControlToValidate="drpFieldOG"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Zone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                    <asp:DropDownList ID="drpZoneOG" runat="server" class="form-control input-md" Width="300px"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvZoneOG" runat="server" ErrorMessage="***" ControlToValidate="drpZoneOG" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />

                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;Shift&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                   
                                                  <asp:DropDownList ID="drpShiftOG" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvSHiftOG" runat="server" ErrorMessage="***" ControlToValidate="drpShiftOG" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />
                                        
                                       
                                        <table>
                                            <tr>
                                                <td>
                                                    <strong>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblCycleOG" runat="server" Text="Cycle"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                </td>
                                                <td align="right">
                                                   
                                                  <asp:DropDownList ID="drpCycleOG" runat="server" class="form-control input-md" Width="300px">
                                                  </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvCycleOG" runat="server" ErrorMessage="***" ControlToValidate="drpCycleOG" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                        </table>

                                        <br />
                                        



                                    </div>

                                

                            </div>
                            <div class="col-md-6">
                                        <asp:Panel ID="Panel4" runat="server" Visible="true">
                                            <table class="auto-style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblAvailBin" runat="server" Text="AVAILABLE TRUCKS" Font-Bold="true"></asp:Label><br />
                                                        <br />
                                                        <asp:ListBox ID="sourceTruckListOG" runat="server" Height="200px" class="form-control input-md" Width="200px"></asp:ListBox>
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="AllBin" visible="false" runat="server" Text=">>" Width="100px" class="btn btn-info" Height="50px" />
                                                        <br />
                                                        <br />
                                                        <asp:Button ID="AddOneBin" runat="server" Text=">" Width="100px" class="btn btn-info" Height="50px" />
                                                        <br />
                                                        <br />
                                                        <asp:Button ID="RemoveBin" runat="server" Text="X" Width="100px" class="btn btn-info" Height="50px" />
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblSelBin" runat="server" Text="SELECTED TRUCK(S)" Font-Bold="true"></asp:Label><br />
                                                        <br />
                                                        <asp:ListBox ID="TargetTruckListOG" runat="server" Height="200px" class="form-control input-md" Width="200px"></asp:ListBox>
                                                    </td>
                                                </tr>
                                            </table>
                                          
                                        </asp:Panel>
                        

                                    </div>
                        </asp:Panel>
                        
                            <div class="panel-footer">

                                <asp:Button ID="btnSubmit" runat="server" class="btn btn-danger btn-lg pull-left" Text="CHECK DETAILS" /><br />
                                <asp:Button ID="Button1" runat="server" Visible="false" class="btn btn-danger btn-lg pull-left" Text="UPDATE TRANSACTION" />
                            </div>


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
                    <asp:TextBox ID="txtStatus" Visible="false" runat="server"></asp:TextBox></td>
            </tr>
        </table>
</asp:Content>

